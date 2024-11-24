
--/=========================================/
/*                  Procedimientos y Funciones                      */
--/=========================================/

CREATE OR REPLACE PROCEDURE registrar_empleado (
    p_nombre            IN VARCHAR2,
    p_apellido          IN VARCHAR2,
    p_tipo_empleado     IN VARCHAR2, -- 'TECNICO' o 'VENDEDOR'
    p_fecha_contratacion IN TIMESTAMP,
    p_estado            IN VARCHAR2 DEFAULT 'activo', -- Estado por defecto: 'activo'
    p_filasInsertadas   OUT NUMBER
) AS
    v_idRol INTEGER;
    v_salario CONSTANT NUMBER := 3000; 
BEGIN
    -- Validar el tipo de empleado
    IF p_tipo_empleado NOT IN ('TECNICO', 'VENDEDOR') THEN
        RAISE_APPLICATION_ERROR(-20001, 'Error: El tipo de empleado debe ser "TECNICO" o "VENDEDOR".');
    END IF;

    -- Validar el estado
    IF p_estado NOT IN ('activo', 'inactivo') THEN
        RAISE_APPLICATION_ERROR(-20002, 'Error: El estado del empleado debe ser "activo" o "inactivo".');
    END IF;

    -- Obtener el rol correspondiente al tipo de empleado
    BEGIN
        SELECT idRol
        INTO v_idRol
        FROM tblRol
        WHERE nombreRol = p_tipo_empleado;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            RAISE_APPLICATION_ERROR(-20003, 'Error: No existe un rol asociado al tipo de empleado "' || p_tipo_empleado || '".');
    END;

    -- Insertar en la tabla correspondiente (tblTecnico o tblVendedor)
    IF p_tipo_empleado = 'TECNICO' THEN
        INSERT INTO tblTecnico (nombreTecnico, apellidoTecnico, estadoTecnico, salarioTecnico, fechaContratacionTecnico)
        VALUES (p_nombre, p_apellido, p_estado, v_salario, p_fecha_contratacion);
    ELSIF p_tipo_empleado = 'VENDEDOR' THEN
        INSERT INTO tblVendedor (nombreVendedor, apellidoVendedor, estadoVendedor, salarioVendedor, fechaContratacionVendedor)
        VALUES (p_nombre, p_apellido, p_estado, v_salario, p_fecha_contratacion);
    END IF;

    -- Confirmar la inserci�n
    p_filasInsertadas := 1;
    DBMS_OUTPUT.PUT_LINE('Empleado registrado exitosamente.');

EXCEPTION
    WHEN DUP_VAL_ON_INDEX THEN
        RAISE_APPLICATION_ERROR(-20004, 'Error: Ya existe un registro con la misma informaci�n.');
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20005, 'Error inesperado: ' || SQLERRM);
END registrar_empleado;
/


-- Procedimiento para eliminar usuarios inactivos 
CREATE OR REPLACE PROCEDURE actualizar_y_eliminar_usuarios_inactivos AS
BEGIN
    -- Establecer idUsuario en NULL para vendedores inactivos
    UPDATE tblVendedor
    SET idUsuario = NULL
    WHERE estadoVendedor = 'inactivo' AND idUsuario IS NOT NULL;

    -- Establecer idUsuario en NULL para t�cnicos inactivos
    UPDATE tblTecnico
    SET idUsuario = NULL
    WHERE estadoTecnico = 'inactivo' AND idUsuario IS NOT NULL;

    -- Eliminar usuarios que ya no tienen referencias activas en tblVendedor ni en tblTecnico
    DELETE FROM tblUsuario
    WHERE idUsuario NOT IN (SELECT idUsuario FROM tblVendedor WHERE idUsuario IS NOT NULL)
      AND idUsuario NOT IN (SELECT idUsuario FROM tblTecnico WHERE idUsuario IS NOT NULL)
      AND idRol != (SELECT idRol FROM tblRol WHERE idRol = 1);

    COMMIT;

    DBMS_OUTPUT.PUT_LINE('Usuarios inactivos actualizados y eliminados exitosamente.');
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        DBMS_OUTPUT.PUT_LINE('Ocurri� un error al actualizar y eliminar usuarios inactivos: ' || SQLERRM);
END actualizar_y_eliminar_usuarios_inactivos;

-- BLOQUE ANONIMO
-- Cambiar el estado de un t�cnico o vendedor a 'inactivo'
-- Cada vez que un t�cnico o vendedor pasa a ser inactivo, el usuario correspondiente se eliminar� al ejecutar el procedimiento 'actualizar_y_eliminar_usuarios_inactivos'.

UPDATE tblVendedor 
SET estadoVendedor = 'inactivo' 
WHERE idVendedor = 2;

-- Ejecutar el procedimiento para actualizar y eliminar usuarios inactivos
BEGIN
    actualizar_y_eliminar_usuarios_inactivos;
END;
/

-- Funcion para consultar servicios realizados 
CREATE OR REPLACE FUNCTION consultar_servicios_realizados(p_idCliente INTEGER)
RETURN SYS_REFCURSOR
IS
    cursor_servicios SYS_REFCURSOR;
BEGIN
    OPEN cursor_servicios FOR
    SELECT s.idServicio, st.fechaInicioServicio, st.fechaFinServicio, s.tipoServicio, s.costoServicio
    FROM tblServiciosPostVenta s
    JOIN tblRealizaServicioTecnico st ON s.idServicio = st.idServicio
    JOIN tblSe_RealizaServicioPostVenta sp ON s.idServicio = sp.idServicio
    JOIN tblVenta v ON sp.idVenta = v.idVenta
    WHERE v.cedulaCliente = p_idCliente;
    RETURN cursor_servicios;
END consultar_servicios_realizados;


--/=========================================/
/*               PARA ELIMINAR FUNCIONES           */
--/=========================================/

DROP PROCEDURE registrar_empleado;

DROP PROCEDURE actualizar_y_eliminar_usuarios_inactivos;

DROP FUNCTION consultar_servicios_realizados;


--/=========================================/
/*               PAQUETES           */
--/=========================================/

-- Paquete para ventas
CREATE OR REPLACE PACKAGE pkg_ventas AS
    -- Procedimientos 
    PROCEDURE registrar_venta(
        p_fecha       IN DATE,
        p_id_vendedor IN NUMBER,
        p_cedula_cliente IN NUMBER,
        p_id_ejemplar IN NUMBER,
        p_filasInsertadas OUT NUMBER
    );
    PROCEDURE generar_reporte_venta(
        p_id_venta IN INTEGER,
        p_cursor OUT SYS_REFCURSOR
    );

    -- Funciones 
    FUNCTION calcular_total_venta(p_idEjemplar IN INTEGER) RETURN NUMBER;
    
END pkg_ventas;


CREATE OR REPLACE PACKAGE BODY pkg_ventas AS

    -- Funci�n para calcular el total de una venta basada en el precio del veh�culo
    FUNCTION calcular_total_venta(p_idEjemplar IN INTEGER) RETURN NUMBER IS
        v_precioVehiculo NUMBER;
    BEGIN
        SELECT precioVehiculo
        INTO v_precioVehiculo
        FROM tblVehiculo V
        JOIN tblEjemplar E ON V.idVehiculo = E.idVehiculo
        WHERE E.idEjemplar = p_idEjemplar;

        RETURN v_precioVehiculo;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            RAISE_APPLICATION_ERROR(-20001, 'El ejemplar especificado no existe.');
        WHEN OTHERS THEN
            RAISE;
    END calcular_total_venta;


    -- Procedimiento para registrar una venta
    PROCEDURE registrar_venta(
    p_fecha         IN DATE,
    p_id_vendedor   IN NUMBER,
    p_cedula_cliente IN NUMBER,
    p_id_ejemplar   IN NUMBER,
    p_filasInsertadas OUT NUMBER
) IS
    v_totalVenta NUMBER;
    v_comisionVenta NUMBER;
    v_idVenta INTEGER;
BEGIN
    -- Iniciar la transacci�n expl�cita
    SAVEPOINT inicio_transaccion;

    -- Calcular el total de la venta
    v_totalVenta := calcular_total_venta(p_id_ejemplar);

    -- Insertar la venta y recuperar su ID
    INSERT INTO tblVenta (fechaVenta, totalVenta, idVendedor, cedulaCliente, idEjemplar)
    VALUES (p_fecha, v_totalVenta, p_id_vendedor, p_cedula_cliente, p_id_ejemplar)
    
    RETURNING idVenta INTO v_idVenta;
    
    p_filasInsertadas := 1;

    -- Confirmar la transacci�n
    COMMIT;

    DBMS_OUTPUT.PUT_LINE('Se ha registrado la venta con un total de: ' || v_totalVenta || ' y una comisi�n de: ' || v_comisionVenta);

        EXCEPTION
    WHEN DUP_VAL_ON_INDEX THEN
        ROLLBACK TO inicio_transaccion;
        DBMS_OUTPUT.PUT_LINE('Error: La venta ya existe con el ID proporcionado.');
    WHEN NO_DATA_FOUND THEN
        ROLLBACK TO inicio_transaccion;
        DBMS_OUTPUT.PUT_LINE('Error: No se encontr� informaci�n para calcular el total de la venta.');
    WHEN INVALID_NUMBER THEN
        ROLLBACK TO inicio_transaccion;
        DBMS_OUTPUT.PUT_LINE('Error: Se proporcion� un n�mero inv�lido en los par�metros.');
    WHEN VALUE_ERROR THEN
        ROLLBACK TO inicio_transaccion;
        DBMS_OUTPUT.PUT_LINE('Error: Valor fuera de rango o no v�lido.');
    WHEN OTHERS THEN
        ROLLBACK TO inicio_transaccion;
        DBMS_OUTPUT.PUT_LINE('Error inesperado: ' || SQLERRM);
        RAISE;
        END registrar_venta;
    
    -- Procedimiento para reporte de ventas 
    PROCEDURE generar_reporte_venta(
    p_id_venta IN INTEGER,
    p_cursor OUT SYS_REFCURSOR
) AS
BEGIN
    -- Validar si se ingres� un ID de venta
    IF p_id_venta IS NULL THEN
        RAISE_APPLICATION_ERROR(-20001, 'Debe proporcionar un ID de venta.');
    END IF;

    -- Abrir el cursor con los datos de la consulta
    OPEN p_cursor FOR
        SELECT v.idVenta AS "ID Venta",
               v.fechaVenta AS "Fecha Venta",
               e.idEjemplar AS "Ejemplar Vendido",
               v.totalVenta AS "Total",
               vd.nombreVendedor AS "Vendedor",
               v.comisionVenta AS "Comision Venta",
               c.cedulaCliente AS "Cedula Cliente",
               c.nombreCliente AS "Nombre Cliente"
        FROM tblVenta v
        INNER JOIN tblEjemplar e ON v.idEjemplar = e.idEjemplar
        INNER JOIN tblVendedor vd ON v.idVendedor = vd.idVendedor
        INNER JOIN tblCliente c ON v.cedulaCliente = c.cedulaCliente
        WHERE v.idVenta = p_id_venta;
END generar_reporte_venta;
END pkg_ventas;

SET SERVEROUTPUT ON
BEGIN
    -- Registrar una venta sin especificar el total (se calcular� autom�ticamente)
    pkg_ventas.registrar_venta(
        p_fecha         => SYSDATE,
        p_id_vendedor   => 1,
        p_cedula_cliente => 1,
        p_id_ejemplar   => 3
    );
END;


-- Paquete para clientes 
CREATE OR REPLACE PACKAGE pkg_clientes AS
    -- Funciones
    FUNCTION Consultar_informacion_cliente(p_idCliente IN INTEGER) RETURN VARCHAR2;
    FUNCTION fn_Numero_De_Clientes RETURN NUMBER;

    -- Procedimientos
    PROCEDURE Registrar_Cliente_Nuevo(
        p_cedulaCliente     IN tblCliente.cedulaCliente%TYPE,
        p_nombreCliente     IN tblCliente.nombreCliente%TYPE,
        p_apellidoCliente   IN tblCliente.apellidoCliente%TYPE,
        p_telefonoCliente   IN tblCliente.telefonoCliente%TYPE,
        p_emailCliente      IN tblCliente.emailCliente%TYPE,
        p_direccionCliente  IN tblCliente.direccionCliente%TYPE,
        p_filasInsertadas   OUT NUMBER
    );
END pkg_clientes;


CREATE OR REPLACE PACKAGE BODY pkg_clientes AS
    -- Funci�n para consultar informaci�n de un cliente
    FUNCTION Consultar_informacion_cliente(p_idCliente IN INTEGER) RETURN VARCHAR2 IS
        v_nombreCliente tblCliente.nombreCliente%TYPE;
        v_apellidoCliente tblCliente.apellidoCliente%TYPE;
        v_telefonoCliente tblCliente.telefonoCliente%TYPE;
        v_emailCliente tblCliente.emailCliente%TYPE;
        v_informacion_cliente VARCHAR2(200);
    BEGIN
        SELECT nombreCliente, apellidoCliente, telefonoCliente, emailCliente
        INTO v_nombreCliente, v_apellidoCliente, v_telefonoCliente, v_emailCliente
        FROM tblCliente
        WHERE cedulaCliente = p_idCliente;
        
        v_informacion_cliente := 'Nombre: ' || v_nombreCliente || ', Email: ' || NVL(v_emailCliente, 'N/D');
        RETURN v_informacion_cliente;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            RETURN 'Cliente no encontrado.';
        WHEN OTHERS THEN
            RETURN 'Error en consulta.';
    END Consultar_informacion_cliente;

    -- Funci�n para contar el n�mero total de clientes
    FUNCTION fn_Numero_De_Clientes RETURN NUMBER IS
        v_totalClientes NUMBER;
    BEGIN
        SELECT COUNT(*) INTO v_totalClientes FROM tblCliente;
        RETURN v_totalClientes;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            RETURN 0;
        WHEN OTHERS THEN
            RETURN -1;
    END fn_Numero_De_Clientes;

    -- Procedimiento para registrar un nuevo cliente
    PROCEDURE Registrar_Cliente_Nuevo(
        p_cedulaCliente     IN tblCliente.cedulaCliente%TYPE,
        p_nombreCliente     IN tblCliente.nombreCliente%TYPE,
        p_apellidoCliente   IN tblCliente.apellidoCliente%TYPE,
        p_telefonoCliente   IN tblCliente.telefonoCliente%TYPE,
        p_emailCliente      IN tblCliente.emailCliente%TYPE,
        p_direccionCliente  IN tblCliente.direccionCliente%TYPE,
        p_filasInsertadas   OUT NUMBER
    ) IS
        v_exists INTEGER;

    BEGIN
        -- Verificar si ya existe un cliente con la misma c�dula
        SELECT COUNT(*) INTO v_exists
        FROM tblCliente
        WHERE cedulaCliente = p_cedulaCliente;
        
        IF v_exists > 0 THEN
            RAISE_APPLICATION_ERROR(-20001, 'Error: La c�dula del cliente ya est� registrada en el sistema.');
        END IF;

        -- Intentar insertar el cliente en la tabla
        INSERT INTO tblCliente (cedulaCliente, nombreCliente, apellidoCliente, telefonoCliente, emailCliente, direccionCliente)
        VALUES (p_cedulaCliente, p_nombreCliente, p_apellidoCliente, p_telefonoCliente, p_emailCliente, p_direccionCliente);
        
        p_filasInsertadas:=1;

        DBMS_OUTPUT.PUT_LINE('Cliente registrado correctamente.');

    EXCEPTION
        WHEN DUP_VAL_ON_INDEX THEN
            RAISE_APPLICATION_ERROR(-20002, 'Error: El email ya est� registrado en el sistema.');
        WHEN OTHERS THEN
            RAISE_APPLICATION_ERROR(-20003, 'Error inesperado: ' || SQLERRM);
    END Registrar_Cliente_Nuevo;
END pkg_clientes;


-- Paquete para ejemplares
CREATE OR REPLACE PACKAGE pkg_ejemplares AS
    -- Funciones
    FUNCTION consultarEjemplaresDisponibles RETURN SYS_REFCURSOR;

    -- Procedimientos
    PROCEDURE InsertarEjemplares(
        p_idVehiculo       IN NUMBER,
        p_idProveedor      IN NUMBER,
        p_estado           IN VARCHAR2,
        p_cantidad         IN NUMBER,
        p_filasInsertadas  OUT NUMBER
    );

    PROCEDURE Consultar_informacion_ejemplar(
        p_idEjemplar IN INTEGER,
        p_ejemplar OUT SYS_REFCURSOR
    );
    
    PROCEDURE modificar_ejemplar (
    p_idEjemplar       IN INTEGER,
    p_estadoEjemplar   IN VARCHAR2,
    p_modeloVehiculo   IN VARCHAR2,
    p_nombreProveedor  IN VARCHAR2
    );
  
END pkg_ejemplares;


CREATE OR REPLACE PACKAGE BODY pkg_ejemplares AS
    -- Funci�n para consultar ejemplares disponibles
    FUNCTION consultarEjemplaresDisponibles RETURN SYS_REFCURSOR IS
        ejemplares_cursor SYS_REFCURSOR;
    BEGIN
        OPEN ejemplares_cursor FOR
            SELECT e.idEjemplar, v.modeloVehiculo, v.marcaVehiculo, v.a�oVehiculo, v.precioVehiculo, p.nombreProveedor
            FROM tblEjemplar e
            JOIN tblVehiculo v ON e.idVehiculo = v.idVehiculo
            JOIN tblProveedor p ON e.idProveedor = p.idProveedor
            WHERE e.estadoEjemplar = 'disponible';
        RETURN ejemplares_cursor;
    END consultarEjemplaresDisponibles;

    -- Procedimiento para insertar ejemplares en lote
    PROCEDURE InsertarEjemplares(
        p_idVehiculo       IN NUMBER,
        p_idProveedor      IN NUMBER,
        p_estado           IN VARCHAR2,
        p_cantidad         IN NUMBER,
        p_filasInsertadas  OUT NUMBER
    ) IS
    BEGIN
        p_filasInsertadas := 0; -- Inicializar el contador
        FOR i IN 1..p_cantidad LOOP
            INSERT INTO tblEjemplar (idVehiculo, idProveedor, estadoEjemplar)
            VALUES (p_idVehiculo, p_idProveedor, p_estado);
            p_filasInsertadas := p_filasInsertadas + 1; -- Incrementar el contador
        END LOOP;
    END InsertarEjemplares;

    -- Procedimiento para consultar informaci�n de un ejemplar espec�fico
    PROCEDURE Consultar_informacion_ejemplar(
        p_idEjemplar IN INTEGER,
        p_ejemplar OUT SYS_REFCURSOR
    ) IS
    BEGIN
        -- Retornar informaci�n del ejemplar
        OPEN p_ejemplar FOR
            SELECT idEjemplar, modeloVehiculo, estadoEjemplar, nombreProveedor
            FROM tblEjemplar 
            INNER JOIN tblVehiculo
            ON tblEjemplar.idVehiculo = tblVehiculo.idVehiculo
            INNER JOIN tblProveedor
            ON tblVehiculo.idProveedor = tblProveedor.idProveedor
            WHERE idEjemplar = p_idEjemplar;
    END Consultar_informacion_ejemplar;
    
    -- Procedimiento para modificar un ejemplar    
    PROCEDURE modificar_ejemplar (
    p_idEjemplar       IN INTEGER,
    p_estadoEjemplar   IN VARCHAR2,
    p_modeloVehiculo   IN VARCHAR2,
    p_nombreProveedor  IN VARCHAR2
) AS
    v_vehiculo_exists INTEGER;
    v_proveedor_exists INTEGER;
    v_relacion_exists INTEGER;
    v_estado_actual VARCHAR2(50);
    v_ejemplar_exists INTEGER;
BEGIN
    -- Validar que el ejemplar exista
    SELECT COUNT(*)
    INTO v_ejemplar_exists
    FROM tblEjemplar
    WHERE idEjemplar = p_idEjemplar;

    IF v_ejemplar_exists = 0 THEN
        RAISE_APPLICATION_ERROR(-20001, 'Error: El ejemplar especificado no existe.');
    END IF;

    -- Validar que el estado sea v�lido
    IF p_estadoEjemplar NOT IN ('disponible', 'vendido') THEN
        RAISE_APPLICATION_ERROR(-20002, 'Error: El estado del ejemplar debe ser "disponible" o "vendido".');
    END IF;

    -- Validar que el modelo del veh�culo exista
    SELECT COUNT(*)
    INTO v_vehiculo_exists
    FROM tblVehiculo
    WHERE modeloVehiculo = p_modeloVehiculo;

    IF v_vehiculo_exists = 0 THEN
        RAISE_APPLICATION_ERROR(-20003, 'Error: El modelo del veh�culo especificado no existe.');
    END IF;

    -- Validar que el proveedor exista
    SELECT COUNT(*)
    INTO v_proveedor_exists
    FROM tblProveedor
    WHERE nombreProveedor = p_nombreProveedor;

    IF v_proveedor_exists = 0 THEN
        RAISE_APPLICATION_ERROR(-20004, 'Error: El proveedor especificado no existe.');
    END IF;

    -- Validar que el modelo del veh�culo est� asociado al proveedor
    SELECT COUNT(*)
    INTO v_relacion_exists
    FROM tblVehiculo v
    WHERE v.modeloVehiculo = p_modeloVehiculo
      AND v.idProveedor = (SELECT idProveedor FROM tblProveedor WHERE nombreProveedor = p_nombreProveedor);

    IF v_relacion_exists = 0 THEN
        RAISE_APPLICATION_ERROR(-20005, 'Error: El modelo del veh�culo no est� asociado al proveedor especificado.');
    END IF;

    -- Validar que el estado actual del ejemplar no sea 'vendido'
    SELECT estadoEjemplar
    INTO v_estado_actual
    FROM tblEjemplar
    WHERE idEjemplar = p_idEjemplar;

    IF v_estado_actual = 'vendido' THEN
        RAISE_APPLICATION_ERROR(-20006, 'Error: No se puede modificar un ejemplar que ya est� vendido.');
    END IF;

    -- Actualizar el ejemplar
    UPDATE tblEjemplar
    SET estadoEjemplar = p_estadoEjemplar,
        idVehiculo = (SELECT idVehiculo FROM tblVehiculo WHERE modeloVehiculo = p_modeloVehiculo),
        idProveedor = (SELECT idProveedor FROM tblProveedor WHERE nombreProveedor = p_nombreProveedor)
    WHERE idEjemplar = p_idEjemplar;

    DBMS_OUTPUT.PUT_LINE('Ejemplar actualizado exitosamente.');
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR(-20007, 'Error: Datos relacionados no encontrados durante la validaci�n.');
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20008, 'Error inesperado: ' || SQLERRM);
END modificar_ejemplar;

END pkg_ejemplares;


-- Paquete para proveedores
CREATE OR REPLACE PACKAGE pkg_proveedores AS
    -- Procedimientos
    PROCEDURE RegistrarProveedor(
        p_idProveedor       IN tblProveedor.idProveedor%TYPE,
        p_nombreProveedor   IN tblProveedor.nombreProveedor%TYPE,
        p_telefonoProveedor IN tblProveedor.telefonoProveedor%TYPE,
        p_direccionProveedor IN tblProveedor.direccionProveedor%TYPE,
        p_filasInsertadas   OUT NUMBER
    );

    PROCEDURE Consultar_informacion_proveedor(
        p_idProveedor IN INTEGER
    );

    PROCEDURE Consultar_informacion_proveedor_cursor(
        p_idProveedor IN INTEGER,
        p_proveedor OUT SYS_REFCURSOR
    );

END pkg_proveedores;


CREATE OR REPLACE PACKAGE BODY pkg_proveedores AS
    -- Procedimiento para registrar un proveedor
    PROCEDURE RegistrarProveedor(
    p_idProveedor       IN tblProveedor.idProveedor%TYPE,
    p_nombreProveedor   IN tblProveedor.nombreProveedor%TYPE,
    p_telefonoProveedor IN tblProveedor.telefonoProveedor%TYPE,
    p_direccionProveedor IN tblProveedor.direccionProveedor%TYPE,
    p_filasInsertadas   OUT NUMBER
) IS
    v_id_count INTEGER;
    v_nombre_count INTEGER;
BEGIN
    -- Verificar si el ID ya existe
    SELECT COUNT(*)
    INTO v_id_count
    FROM tblProveedor
    WHERE idProveedor = p_idProveedor;

    IF v_id_count > 0 THEN
        RAISE_APPLICATION_ERROR(-20001, 'Error: El ID de proveedor ya existe.');
    END IF;

    -- Verificar si el nombre ya existe
    SELECT COUNT(*)
    INTO v_nombre_count
    FROM tblProveedor
    WHERE nombreProveedor = p_nombreProveedor;

    IF v_nombre_count > 0 THEN
        RAISE_APPLICATION_ERROR(-20002, 'Error: El nombre del proveedor ya existe.');
    END IF;

    -- Insertar nuevo proveedor
    INSERT INTO tblProveedor (idProveedor, nombreProveedor, telefonoProveedor, direccionProveedor)
    VALUES (p_idProveedor, p_nombreProveedor, p_telefonoProveedor, p_direccionProveedor);

    p_filasInsertadas := 1;

    DBMS_OUTPUT.PUT_LINE('Proveedor registrado con ID ' || p_idProveedor);

EXCEPTION
    WHEN OTHERS THEN
        -- Solo registrar el error, pero dejar que se propague
        DBMS_OUTPUT.PUT_LINE('Error en RegistrarProveedor: ' || SQLERRM);
        RAISE;
END RegistrarProveedor;

    -- Procedimiento para consultar informaci�n de un proveedor y sus veh�culos
    PROCEDURE Consultar_informacion_proveedor(
        p_idProveedor IN INTEGER
    ) IS
        v_nombreProveedor tblProveedor.nombreProveedor%TYPE;
        v_telefonoProveedor tblProveedor.telefonoProveedor%TYPE;
        v_direccionProveedor tblProveedor.direccionProveedor%TYPE;

        CURSOR vehiculos_cursor IS
            SELECT idVehiculo, modeloVehiculo, marcaVehiculo, a�oVehiculo
            FROM tblVehiculo
            WHERE idProveedor = p_idProveedor;

        v_idVehiculo tblVehiculo.idVehiculo%TYPE;
        v_modeloVehiculo tblVehiculo.modeloVehiculo%TYPE;
        v_marcaVehiculo tblVehiculo.marcaVehiculo%TYPE;
        v_a�oVehiculo tblVehiculo.a�oVehiculo%TYPE;
    BEGIN
        SELECT nombreProveedor, telefonoProveedor, direccionProveedor
        INTO v_nombreProveedor, v_telefonoProveedor, v_direccionProveedor
        FROM tblProveedor
        WHERE idProveedor = p_idProveedor;

        DBMS_OUTPUT.PUT_LINE('Proveedor:');
        DBMS_OUTPUT.PUT_LINE('Nombre: ' || v_nombreProveedor);
        DBMS_OUTPUT.PUT_LINE('Tel�fono: ' || NVL(v_telefonoProveedor, 'No registrado'));
        DBMS_OUTPUT.PUT_LINE('Direcci�n: ' || NVL(v_direccionProveedor, 'No registrada'));

        DBMS_OUTPUT.PUT_LINE('Veh�culos asociados:');
        OPEN vehiculos_cursor;
        LOOP
            FETCH vehiculos_cursor INTO v_idVehiculo, v_modeloVehiculo, v_marcaVehiculo, v_a�oVehiculo;
            EXIT WHEN vehiculos_cursor%NOTFOUND;

            DBMS_OUTPUT.PUT_LINE('- ID Veh�culo: ' || v_idVehiculo || 
                                 ', Modelo: ' || v_modeloVehiculo || 
                                 ', Marca: ' || v_marcaVehiculo || 
                                 ', A�o: ' || v_a�oVehiculo);
        END LOOP;
        CLOSE vehiculos_cursor;

    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            DBMS_OUTPUT.PUT_LINE('Proveedor no encontrado.');
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('Ocurri� un error: ' || SQLERRM);
    END Consultar_informacion_proveedor;

    -- Procedimiento para consultar informaci�n de un proveedor con un cursor
    PROCEDURE Consultar_informacion_proveedor_cursor(
        p_idProveedor IN INTEGER,
        p_proveedor OUT SYS_REFCURSOR
    ) IS
    BEGIN
        OPEN p_proveedor FOR
            SELECT idProveedor, nombreProveedor, telefonoProveedor, direccionProveedor
            FROM tblProveedor
            WHERE idProveedor = p_idProveedor;
    END Consultar_informacion_proveedor_cursor;

END pkg_proveedores;

commit;

SET SERVEROUTPUT ON
DECLARE
    filas_insertadas NUMBER;
BEGIN
    pkg_proveedores.RegistrarProveedor(
        p_idProveedor       => 1,
        p_nombreProveedor   => 'Proveedor Ejemplo',
        p_telefonoProveedor => '123456789',
        p_direccionProveedor => 'Calle 123',
        p_filasInsertadas   => filas_insertadas
    );

    DBMS_OUTPUT.PUT_LINE('Filas Insertadas: ' || filas_insertadas);
END;






--/=========================================/
/*               PARA BORRAR PAQUETES           */
--/=========================================/

DROP PACKAGE pkg_ventas;

DROP PACKAGE pkg_clientes;

DROP PACKAGE pkg_ejemplares;

DROP PACKAGE pkg_proveedores;


--/=========================================/
/*               VISTAS           */
--/=========================================/

--/=========================================/
/*               EJECUTAR        */
--/=========================================/

CONNECT system/oracle;
GRANT CREATE VIEW TO USER_PROYECTOBASES;


-- Vista para inventario ejemplares INSTEAD OF
CREATE OR REPLACE VIEW vista_inventario_ejemplares AS
SELECT 
    e.idEjemplar AS "ID Ejemplar",
    v.modeloVehiculo AS "Modelo Veh�culo",
    e.estadoEjemplar AS "Estado Ejemplar",
    p.nombreProveedor AS "Nombre Proveedor"
FROM 
    tblEjemplar e
JOIN 
    tblVehiculo v ON e.idVehiculo = v.idVehiculo
JOIN 
    tblProveedor p ON v.idProveedor = p.idProveedor;

-- Trigger para vista invetario ejemplares
CREATE OR REPLACE TRIGGER trg_inventario_ejemplares
INSTEAD OF INSERT OR UPDATE OR DELETE ON vista_inventario_ejemplares
FOR EACH ROW
DECLARE
    v_vehiculo_exists INTEGER;
    v_proveedor_exists INTEGER;
    v_relacion_exists INTEGER;
    v_estado_actual VARCHAR2(50);
BEGIN
    -- Operaci�n INSERT
    IF INSERTING THEN
        INSERT INTO tblEjemplar (idVehiculo, idProveedor, estadoEjemplar)
        VALUES (
            (SELECT idVehiculo FROM tblVehiculo WHERE modeloVehiculo = :NEW."Modelo Veh�culo"),
            (SELECT idProveedor FROM tblProveedor WHERE nombreProveedor = :NEW."Nombre Proveedor"),
            :NEW."Estado Ejemplar"
        );
    END IF;

    -- Operaci�n UPDATE
    IF UPDATING THEN
        -- Validar que el modelo del veh�culo exista
        SELECT COUNT(*)
        INTO v_vehiculo_exists
        FROM tblVehiculo
        WHERE modeloVehiculo = :NEW."Modelo Veh�culo";

        IF v_vehiculo_exists = 0 THEN
            RAISE_APPLICATION_ERROR(-20001, 'Error: El modelo del veh�culo especificado no existe.');
        END IF;

        -- Validar que el proveedor exista
        SELECT COUNT(*)
        INTO v_proveedor_exists
        FROM tblProveedor
        WHERE nombreProveedor = :NEW."Nombre Proveedor";

        IF v_proveedor_exists = 0 THEN
            RAISE_APPLICATION_ERROR(-20002, 'Error: El proveedor especificado no existe.');
        END IF;

        -- Validar que el modelo del veh�culo est� asociado al proveedor
        SELECT COUNT(*)
        INTO v_relacion_exists
        FROM tblVehiculo v
        WHERE v.modeloVehiculo = :NEW."Modelo Veh�culo"
          AND v.idProveedor = (SELECT idProveedor FROM tblProveedor WHERE nombreProveedor = :NEW."Nombre Proveedor");

        IF v_relacion_exists = 0 THEN
            RAISE_APPLICATION_ERROR(-20003, 'Error: El modelo del veh�culo no est� asociado al proveedor especificado.');
        END IF;

        -- Validar que el estado actual del ejemplar no sea 'vendido'
        SELECT estadoEjemplar
        INTO v_estado_actual
        FROM tblEjemplar
        WHERE idEjemplar = :OLD."ID Ejemplar";

        IF v_estado_actual = 'vendido' THEN
            RAISE_APPLICATION_ERROR(-20004, 'Error: No se puede actualizar un ejemplar que ya est� vendido.');
        END IF;

        -- Realizar la actualizaci�n si todas las validaciones pasan
        UPDATE tblEjemplar
        SET 
            idVehiculo = (SELECT idVehiculo FROM tblVehiculo WHERE modeloVehiculo = :NEW."Modelo Veh�culo" AND ROWNUM = 1),
            idProveedor = (SELECT idProveedor FROM tblProveedor WHERE nombreProveedor = :NEW."Nombre Proveedor" AND ROWNUM = 1),
            estadoEjemplar = :NEW."Estado Ejemplar"
        WHERE idEjemplar = :OLD."ID Ejemplar";

    END IF;

    -- Operaci�n DELETE
    IF DELETING THEN
        DELETE FROM tblEjemplar
        WHERE idEjemplar = :OLD."ID Ejemplar";
    END IF;
    
END trg_inventario_ejemplares;

---Prueba

UPDATE vista_inventario_ejemplares
SET 
    "Modelo Veh�culo" = 'Modelo Y',
    "Nombre Proveedor" = 'Proveedor Uno'
WHERE "ID Ejemplar" = 3;
commit;



-- Vista para proveedores
CREATE OR REPLACE VIEW vista_proveedores AS
SELECT 
    p.idProveedor AS "ID Proveedor",
    p.nombreProveedor AS "Nombre Proveedor",
    p.telefonoProveedor AS "Tel�fono Proveedor",
    p.direccionProveedor AS "Direcci�n Proveedor",
    COUNT(v.idVehiculo) AS "Cantidad de Veh�culos Asociados"
FROM 
    tblProveedor p
LEFT JOIN 
    tblVehiculo v ON p.idProveedor = v.idProveedor
GROUP BY 
    p.idProveedor, p.nombreProveedor, p.telefonoProveedor, p.direccionProveedor;


-- Trigger para vista proveedor

CREATE OR REPLACE TRIGGER trg_proveedores
INSTEAD OF INSERT OR UPDATE OR DELETE ON vista_proveedores
FOR EACH ROW
DECLARE
    v_proveedor_exists INTEGER;
    v_vehiculo_count INTEGER;
BEGIN
    -- Operaci�n INSERT
    IF INSERTING THEN
        -- Validar que el ID del proveedor no sea NULL
        IF :NEW."ID Proveedor" IS NULL THEN
            RAISE_APPLICATION_ERROR(-20005, 'Error: El ID del proveedor es obligatorio.');
        END IF;

        -- Validar que no exista ya un proveedor con el mismo ID
        SELECT COUNT(*)
        INTO v_proveedor_exists
        FROM tblProveedor
        WHERE idProveedor = :NEW."ID Proveedor";

        IF v_proveedor_exists > 0 THEN
            RAISE_APPLICATION_ERROR(-20001, 'Error: Ya existe un proveedor con el mismo ID.');
        END IF;

        -- Validar que no exista ya un proveedor con el mismo nombre
        SELECT COUNT(*)
        INTO v_proveedor_exists
        FROM tblProveedor
        WHERE nombreProveedor = :NEW."Nombre Proveedor";

        IF v_proveedor_exists > 0 THEN
            RAISE_APPLICATION_ERROR(-20002, 'Error: Ya existe un proveedor con el mismo nombre.');
        END IF;

        -- Insertar en tblProveedor
        INSERT INTO tblProveedor (idProveedor, nombreProveedor, telefonoProveedor, direccionProveedor)
        VALUES (
            :NEW."ID Proveedor",
            :NEW."Nombre Proveedor",
            :NEW."Tel�fono Proveedor",
            :NEW."Direcci�n Proveedor"
        );
    END IF;

    -- Operaci�n UPDATE
    IF UPDATING THEN
        -- Validar que el proveedor exista
        SELECT COUNT(*)
        INTO v_proveedor_exists
        FROM tblProveedor
        WHERE idProveedor = :OLD."ID Proveedor";

        IF v_proveedor_exists = 0 THEN
            RAISE_APPLICATION_ERROR(-20003, 'Error: El proveedor especificado no existe.');
        END IF;

        -- Validar que el nuevo nombre no est� duplicado en otro proveedor
        SELECT COUNT(*)
        INTO v_proveedor_exists
        FROM tblProveedor
        WHERE nombreProveedor = :NEW."Nombre Proveedor" AND idProveedor != :OLD."ID Proveedor";

        IF v_proveedor_exists > 0 THEN
            RAISE_APPLICATION_ERROR(-20004, 'Error: Ya existe otro proveedor con el mismo nombre.');
        END IF;

        -- Actualizar los datos del proveedor
        UPDATE tblProveedor
        SET 
            nombreProveedor = :NEW."Nombre Proveedor",
            telefonoProveedor = :NEW."Tel�fono Proveedor",
            direccionProveedor = :NEW."Direcci�n Proveedor"
        WHERE idProveedor = :OLD."ID Proveedor";
    END IF;

    -- Operaci�n DELETE
    IF DELETING THEN
        -- Validar si el proveedor tiene veh�culos asociados
        SELECT COUNT(*)
        INTO v_vehiculo_count
        FROM tblVehiculo
        WHERE idProveedor = :OLD."ID Proveedor";

        IF v_vehiculo_count > 0 THEN
            RAISE_APPLICATION_ERROR(-20006, 'Error: No se puede eliminar un proveedor con veh�culos asociados.');
        END IF;

        -- Eliminar el proveedor
        DELETE FROM tblProveedor
        WHERE idProveedor = :OLD."ID Proveedor";
    END IF;
END trg_proveedores;
/


-- Prueba

UPDATE vista_proveedores
SET 
    "Nombre Proveedor" = 'Proveedor Actualizado prueba de veh�culo',
    "Tel�fono Proveedor" = '123456789',
    "Direcci�n Proveedor" = 'Avenida Vieja'
WHERE "ID Proveedor" = 1;
commit;

-- Vista para 
CREATE OR REPLACE VIEW vista_ventas AS
SELECT 
    v.idVenta AS "ID Venta",
    v.fechaVenta AS "Fecha Venta",
    e.idEjemplar AS "Ejemplar Vendido",
    v.totalVenta AS "Total",
    vd.nombreVendedor AS "Vendedor",
    v.comisionVenta AS "Comision Venta",
    c.cedulaCliente AS "Cedula Cliente",
    c.nombreCliente AS "Nombre Cliente"
FROM 
    tblVenta v
INNER JOIN 
    tblEjemplar e ON v.idEjemplar = e.idEjemplar
INNER JOIN
    tblVendedor vd ON v.idVendedor = vd.idVendedor
INNER JOIN
    tblCliente c ON v.cedulaCliente = c.cedulaCliente;

--/=========================================/
/*               PARA BORRAR VISTAS       */
--/=========================================/

DROP VIEW vista_inventario_ejemplares;

DROP VIEW vista_proveedores;

DROP VIEW vista_ventas;

--/=========================================/
/*                             INDICES                            */
--/=========================================/


-- �ndice b�sico en la columna modeloVehiculo
CREATE INDEX idx_tblVehiculo_modeloVehiculo
ON tblVehiculo (modeloVehiculo);

SELECT index_name, table_name, column_name
FROM user_ind_columns
WHERE table_name = 'TBLVEHICULO';

ALTER INDEX idx_tblVehiculo_modeloVehiculo MONITORING USAGE

----Debe ejecutarse desde system o un usuario q tenga privilegios 
--Monitoreo
SELECT *
FROM DBA_OBJECT_USAGE
WHERE TABLE_NAME='TBLVEHICULO'

---Esta consulta de tblVehiculo pone el indice en USED Yes
    SELECT idVehiculo, modeloVehiculo
    FROM TBLVEHICULO
    WHERE modeloVehiculo LIKE 'M%' ORDER BY
    modeloVehiculo DESC


--consultes los servicios realizados en los �ltimos X d�as. 
----Funcion determinista
CREATE OR REPLACE FUNCTION fn_dias_servicio(p_fechaServicio DATE) 
RETURN NUMBER
DETERMINISTIC
IS
BEGIN
    RETURN (SYSDATE - p_fechaServicio);
END fn_dias_servicio;

---Indice basado en una funcion para la tblServiciosPostventa
CREATE INDEX idx_tblServiciosPostVenta_dias_servicio
ON tblServiciosPostVenta (fn_dias_servicio(fechaServicio));

ALTER INDEX idx_tblServiciosPostVenta_dias_servicio MONITORING USAGE;

----Debe ejecutarse desde system o un usuario q tenga privilegios 
--Monitoreo
SELECT *
FROM DBA_OBJECT_USAGE
WHERE TABLE_NAME='TBLSERVICIOSPOSTVENTA'

---Esta consulta pone el indice en USED Yes
SELECT *
FROM tblServiciosPostVenta
WHERE fn_dias_servicio(fechaServicio) <= 30;

/=========================================/
/*               DICCIONARIO DE DATOS         */
/=========================================/

--1. Mostrar informaci�n de los objetos de la BD

SELECT object_name, object_type, created, status
FROM user_objects
ORDER BY object_type;

--2. Mostrar el nombre de todas las tablas que posee.

SELECT table_name
FROM user_tables;

--3. Mostrar informaci�n de las restricciones definidas sobre sus tablas

SELECT column_name, data_type, data_length,
data_precision, data_scale, nullable
FROM user_tab_columns;

--4. Mostrar informaci�n de las secuencias

SELECT sequence_name, min_value, max_value,
increment_by, last_number
FROM user_sequences;

--5. Mostrar los nombres de las columnas de una de las tablas de su esquema.

SELECT column_name, data_type, data_length,
data_precision, data_scale, nullable
FROM user_tab_columns
WHERE table_name = 'TBLVEHICULO';

--6. Mostrar la consulta de una de las vistas.

CREATE OR REPLACE VIEW vista_proveedores AS
SELECT 
    p.idProveedor AS "ID Proveedor",
    p.nombreProveedor AS "Nombre Proveedor",
    p.telefonoProveedor AS "Tel�fono Proveedor",
    p.direccionProveedor AS "Direcci�n Proveedor",
    COUNT(v.idVehiculo) AS "Cantidad de Veh�culos Asociados"
FROM 
    tblProveedor p
LEFT JOIN 
    tblVehiculo v ON p.idProveedor = v.idProveedor
GROUP BY 
    p.idProveedor, p.nombreProveedor, p.telefonoProveedor, p.direccionProveedor;
    
    
--7. Consulte las restricciones de una de las tablas de su esquema.

SELECT constraint_name, constraint_type,
search_condition, r_constraint_name,
delete_rule, status
FROM user_constraints
WHERE table_name = 'TBLVEHICULO';

--8. Mostrar el nombre de todos los procedimientos que posee.

SELECT OBJECT_NAME AS NOMBRE_PROCEDIMIENTO
FROM USER_OBJECTS
WHERE OBJECT_TYPE = 'PROCEDURE';

---Consulta para cuando los procedimientos estan encapsulados en packages

SELECT OBJECT_NAME AS PAQUETE,
       PROCEDURE_NAME AS NOMBRE_PROCEDIMIENTO
FROM USER_PROCEDURES
WHERE OBJECT_TYPE = 'PACKAGE'
   OR OBJECT_TYPE = 'PACKAGE BODY';


--9. Ver usuarios con roles y privilegios asignados

----Permite ver el rol y privilegios del usuario actual
SELECT GRANTED_ROLE AS ROL, ADMIN_OPTION
FROM USER_ROLE_PRIVS;

SELECT PRIVILEGE, ADMIN_OPTION
FROM USER_SYS_PRIVS;





