
--=========================================/
/*                      Creaci�n de Disparadores                     
--=========================================/

/* Disparador para generar idVenta */
CREATE OR REPLACE TRIGGER trg_venta_id
BEFORE INSERT ON tblVenta
FOR EACH ROW
DECLARE
    v_estadoEjemplar tblEjemplar.estadoEjemplar%TYPE;
BEGIN
    IF :NEW.idVenta IS NULL THEN
        SELECT estadoEjemplar 
        INTO v_estadoEjemplar 
        FROM tblEjemplar 
        WHERE idEjemplar = :NEW.idEjemplar; 
        IF v_estadoEjemplar = 'vendido' THEN
            RAISE_APPLICATION_ERROR(-20001, 'El ejemplar ya est� vendido. No se puede realizar la venta.');
        ELSE
            SELECT seq_ventas.NEXTVAL INTO :NEW.idVenta FROM dual;
        END IF;
    END IF;
END;

/* Disparador para actualizar estado de ejemplar */
CREATE OR REPLACE TRIGGER trg_actualizar_estado_ejemplar
AFTER INSERT ON tblVenta
FOR EACH ROW
BEGIN
    UPDATE tblEjemplar SET estadoEjemplar = 'vendido' WHERE idEjemplar = :NEW.idEjemplar;
END;

/* Disparador para generar idEjemplar */
CREATE OR REPLACE TRIGGER trg_validate_and_set_idEjemplar
BEFORE INSERT ON tblEjemplar
FOR EACH ROW
DECLARE
    v_vehiculo_exists INTEGER;
    v_proveedor_exists INTEGER;
BEGIN
    -- Validar que el idVehiculo exista en tblVehiculo
    SELECT COUNT(*)
    INTO v_vehiculo_exists
    FROM tblVehiculo
    WHERE idVehiculo = :NEW.idVehiculo;

    IF v_vehiculo_exists = 0 THEN
        RAISE_APPLICATION_ERROR(-20001, 'El idVehiculo no existe en la tabla tblVehiculo.');
    END IF;

    -- Validar que el idProveedor exista en tblProveedor
    SELECT COUNT(*)
    INTO v_proveedor_exists
    FROM tblProveedor
    WHERE idProveedor = :NEW.idProveedor;

    IF v_proveedor_exists = 0 THEN
        RAISE_APPLICATION_ERROR(-20002, 'El idProveedor no existe en la tabla tblProveedor.');
    END IF;

    -- Asignar el idEjemplar desde la secuencia si no se especifica
    IF :NEW.idEjemplar IS NULL THEN
        :NEW.idEjemplar := seq_ejemplar.NEXTVAL;
    END IF;
END;


/* Disparador para registro duplicado para un servicio tecnico*/
CREATE OR REPLACE TRIGGER trg_servicios_tecnicos_id
BEFORE INSERT ON tblRealizaServicioTecnico
FOR EACH ROW
DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*)
    INTO v_count
    FROM tblRealizaServicioTecnico
    WHERE idServicio = :NEW.idServicio
      AND idTecnico = :NEW.idTecnico
      AND fechaInicioServicio = :NEW.fechaInicioServicio;

    IF v_count = 0 THEN
        IF :NEW.idRealizacionServicio IS NULL THEN
            SELECT seq_servicios_tecnicos.NEXTVAL 
            INTO :NEW.idRealizacionServicio
            FROM dual;
        END IF;
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Registro duplicado: el mismo servicio ya fue realizado por este t�cnico en esta fecha.');
    END IF;
END;

/* Disparador para validar rol de Vendedor */
CREATE OR REPLACE TRIGGER trg_validar_rol_vendedor
BEFORE INSERT ON tblVendedor
FOR EACH ROW
DECLARE
    v_idRolUsuario INTEGER;
    v_idRolVendedor INTEGER;
BEGIN
    SELECT idRol INTO v_idRolUsuario FROM tblUsuario WHERE idUsuario = :NEW.idUsuario;
    SELECT idRol INTO v_idRolVendedor FROM tblRol WHERE nombreRol = 'VENDEDOR';
    IF v_idRolUsuario <> v_idRolVendedor THEN
        RAISE_APPLICATION_ERROR(-20001, 'Error: El usuario no tiene el rol de VENDEDOR.');
    END IF;
END;

/* Disparador para validar rol de T�cnico */
CREATE OR REPLACE TRIGGER trg_validar_rol_tecnico
BEFORE INSERT ON tblTecnico
FOR EACH ROW
DECLARE
    v_idRolUsuario INTEGER;
    v_idRolTecnico INTEGER;
BEGIN
    SELECT idRol INTO v_idRolUsuario FROM tblUsuario WHERE idUsuario = :NEW.idUsuario;
    SELECT idRol INTO v_idRolTecnico FROM tblRol WHERE nombreRol = 'TECNICO';
    IF v_idRolUsuario <> v_idRolTecnico THEN
        RAISE_APPLICATION_ERROR(-20002, 'Error: El usuario no tiene el rol de TECNICO.');
    END IF;
END;

------Disparador para usertecnico
CREATE OR REPLACE TRIGGER trg_auto_user_tecnico
BEFORE INSERT ON tblTecnico
FOR EACH ROW
DECLARE
    v_nombreUsuario VARCHAR2(50);
    v_sufijo NUMBER := 1;
    v_usuarioFinal VARCHAR2(50);
    v_password VARCHAR2(20);
    v_count NUMBER;
BEGIN
    -- Crear el nombre base: inicial del nombre + apellido en min�sculas
    v_nombreUsuario := LOWER(SUBSTR(:NEW.nombreTecnico, 1, 1)) || LOWER(:NEW.apellidoTecnico);

    -- Iniciar con el nombre base
    v_usuarioFinal := v_nombreUsuario;

    -- Validar unicidad del nombre de usuario
    LOOP
        -- Contar cu�ntos usuarios existen con este nombre
        SELECT COUNT(*)
        INTO v_count
        FROM tblUsuario
        WHERE nombreUsuario = v_usuarioFinal;

        -- Si no existen usuarios con este nombre, salir del loop
        IF v_count = 0 THEN
            EXIT;
        END IF;

        -- Si existe, agregar un sufijo
        v_usuarioFinal := v_nombreUsuario || v_sufijo;
        v_sufijo := v_sufijo + 1;
    END LOOP;

    -- Generar una contrase�a aleatoria
    v_password := DBMS_RANDOM.STRING('x', 10);

    -- Insertar en tblUsuario
    :NEW.idUsuario := seq_usuarios.NEXTVAL;
    INSERT INTO tblUsuario (idUsuario, nombreUsuario, passwordUsuario, idRol)
    VALUES (:NEW.idUsuario, v_usuarioFinal, v_password, 
            (SELECT idRol FROM tblRol WHERE nombreRol = 'TECNICO'));

END;
/

---Disparador para userVendedor
CREATE OR REPLACE TRIGGER trg_auto_user_vendedor
BEFORE INSERT ON tblVendedor
FOR EACH ROW
DECLARE
    v_nombreUsuario VARCHAR2(50);
    v_sufijo NUMBER := 1;
    v_usuarioFinal VARCHAR2(50);
    v_password VARCHAR2(20);
    v_count NUMBER;
BEGIN
    -- Crear el nombre base: inicial del nombre + apellido en min�sculas
    v_nombreUsuario := LOWER(SUBSTR(:NEW.nombreVendedor, 1, 1)) || LOWER(:NEW.apellidoVendedor);

    -- Iniciar con el nombre base
    v_usuarioFinal := v_nombreUsuario;

    -- Validar unicidad del nombre de usuario
    LOOP
        -- Contar cu�ntos usuarios existen con este nombre
        SELECT COUNT(*)
        INTO v_count
        FROM tblUsuario
        WHERE nombreUsuario = v_usuarioFinal;

        -- Si no existen usuarios con este nombre, salir del loop
        IF v_count = 0 THEN
            EXIT;
        END IF;

        -- Si existe, agregar un sufijo
        v_usuarioFinal := v_nombreUsuario || v_sufijo;
        v_sufijo := v_sufijo + 1;
    END LOOP;

    -- Generar una contrase�a aleatoria
    v_password := DBMS_RANDOM.STRING('x', 10);

    -- Insertar en tblUsuario
    :NEW.idUsuario := seq_usuarios.NEXTVAL;
    INSERT INTO tblUsuario (idUsuario, nombreUsuario, passwordUsuario, idRol)
    VALUES (:NEW.idUsuario, v_usuarioFinal, v_password, 
            (SELECT idRol FROM tblRol WHERE nombreRol = 'VENDEDOR'));
END;

-----Disparador para idtecnico
CREATE OR REPLACE TRIGGER trg_auto_id_tecnico
BEFORE INSERT ON tblTecnico
FOR EACH ROW
BEGIN
    -- Asignar autom�ticamente idTecnico desde la secuencia
    IF :NEW.idTecnico IS NULL THEN
        :NEW.idTecnico := seq_tecnicos.NEXTVAL;
    END IF;
END;

--Disparador para idVendedor
CREATE OR REPLACE TRIGGER trg_auto_id_vendedor
BEFORE INSERT ON tblVendedor
FOR EACH ROW
BEGIN
    -- Asignar autom�ticamente idVendedor desde la secuencia
    IF :NEW.idVendedor IS NULL THEN
        :NEW.idVendedor := seq_vendedores.NEXTVAL;
    END IF;
END;

-- Disparador para verificar datos duplicado
CREATE OR REPLACE TRIGGER trg_id_vehiculo_proveedor
BEFORE INSERT ON tblVehiculo
FOR EACH ROW
DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*)
    INTO v_count
    FROM tblVehiculo
    WHERE modeloVehiculo = :NEW.modeloVehiculo
    OR marcaVehiculo = :NEW.marcaVehiculo;

    IF v_count = 0 THEN
        IF :NEW.idVehiculo IS NULL THEN
            SELECT seq_vehiculos.NEXTVAL 
            INTO :NEW.idVehiculo
            FROM dual;
        END IF;
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Registro duplicado: ya existe un veh�culo con este modelo y marca.');
    END IF;
END;

/*Disparador compuesto para calcular comision de vendedor*/
CREATE OR REPLACE TRIGGER trg_calcular_comision_vendedor
FOR INSERT OR UPDATE ON tblVenta
COMPOUND TRIGGER
    v_total_comision NUMBER := 0;
    v_idVendedor NUMBER;

    -- Secci�n: Antes de cada fila modificada
    BEFORE EACH ROW IS
    BEGIN
        -- Calcular la comisi�n de la venta actual y asignarla a :NEW.comisionVenta
        :NEW.comisionVenta := :NEW.totalVenta * 0.05;

        -- Guardar el ID del vendedor afectado
        v_idVendedor := :NEW.idVendedor;
    END BEFORE EACH ROW;

    -- Secci�n: Despu�s de la sentencia
    AFTER STATEMENT IS
    BEGIN
        -- Calcular la comisi�n acumulada para el vendedor afectado en los �ltimos 30 d�as
        SELECT NVL(SUM(comisionVenta), 0)
        INTO v_total_comision
        FROM tblVenta
        WHERE idVendedor = v_idVendedor
          AND fechaVenta >= TRUNC(SYSDATE) - 30;

        -- Mostrar la comisi�n acumulada en los �ltimos 30 d�as en la salida
        DBMS_OUTPUT.PUT_LINE('Comisi�n acumulada para el vendedor con ID ' || v_idVendedor || ' en los �ltimos 30 d�as: ' || v_total_comision);
    END AFTER STATEMENT;

END trg_calcular_comision_vendedor;
/

CREATE OR REPLACE TRIGGER trg_bloquear_tecnicos_inactivos
BEFORE INSERT OR UPDATE ON tblTecnico
FOR EACH ROW
BEGIN
    IF :NEW.estadoTecnico = 'inactivo' THEN
        RAISE_APPLICATION_ERROR(-20006, 'Error: No se puede insertar o actualizar t�cnicos con estado "inactivo".');
    END IF;
END trg_bloquear_tecnicos_inactivos;
/


CREATE OR REPLACE TRIGGER trg_bloquear_vendedores_inactivos
BEFORE INSERT OR UPDATE ON tblVendedor
FOR EACH ROW
BEGIN
    IF :NEW.estadoVendedor = 'inactivo' THEN
        RAISE_APPLICATION_ERROR(-20007, 'Error: No se puede insertar o actualizar vendedores con estado "inactivo".');
    END IF;
END trg_bloquear_vendedores_inactivos;
/


/*=========================================*/
/*               PARA ELIMINAR LOS DISPARADORES           */
--/=========================================/

DROP TRIGGER trg_venta_id;

DROP TRIGGER trg_actualizar_estado_ejemplar;

DROP TRIGGER trg_servicios_postventa_id;

DROP TRIGGER trg_servicios_tecnicos_id;

DROP TRIGGER trg_validar_rol_vendedor;

DROP TRIGGER trg_validar_rol_tecnico;

DROP TRIGGER trg_validate_and_set_idEjemplar;

DROP TRIGGER trg_id_vehiculo_proveedor;

DROP TRIGGER trg_calcular_comision_vendedor;
 
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
        v_count INTEGER;
    BEGIN
        SELECT COUNT(*)
        INTO v_count
        FROM tblProveedor
        WHERE idProveedor = p_idProveedor;

        IF v_count > 0 THEN
            RAISE_APPLICATION_ERROR(-20001, 'Error: El ID de proveedor ' || p_idProveedor || ' ya existe.');
        END IF;

        INSERT INTO tblProveedor (idProveedor, nombreProveedor, telefonoProveedor, direccionProveedor)
        VALUES (p_idProveedor, p_nombreProveedor, p_telefonoProveedor, p_direccionProveedor);

        p_filasInsertadas := 1;

        DBMS_OUTPUT.PUT_LINE('Proveedor "' || p_nombreProveedor || '" registrado con ID ' || p_idProveedor);

    EXCEPTION
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('Se ha producido un error al registrar el proveedor: ' || SQLERRM);
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

-- Vista para inventario ejemplares INTEAD OF
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
        SET estadoEjemplar = :NEW."Estado Ejemplar"
        WHERE idEjemplar = :OLD."ID Ejemplar";
    END IF;

    -- Operaci�n DELETE
    IF DELETING THEN
        DELETE FROM tblEjemplar
        WHERE idEjemplar = :OLD."ID Ejemplar";
    END IF;
END;

---Prueba

UPDATE vista_inventario_ejemplares
SET "Estado Ejemplar" = 'disponible',
    "Modelo Veh�culo" = 'Modelo X',
    "Nombre Proveedor" = 'Proveedor Uno'
WHERE "ID Ejemplar" = 8;
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
/*               POR SI ACASO          */
--/=========================================/

CONNECT system/oracle;
GRANT CREATE VIEW TO USER_BASES;




