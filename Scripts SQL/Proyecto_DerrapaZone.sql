
--=========================================/
/*                      Creación de Disparadores                     
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
            RAISE_APPLICATION_ERROR(-20001, 'El ejemplar ya está vendido. No se puede realizar la venta.');
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
/

/* Disparador para verificar que no esté duplicado para un servicio postventa*/

CREATE OR REPLACE TRIGGER trg_servicios_postventa_id
BEFORE INSERT ON tblServiciosPostVenta
FOR EACH ROW
DECLARE
    v_count NUMBER;
BEGIN
    SELECT COUNT(*)
    INTO v_count
    FROM tblServiciosPostVenta
    WHERE fechaServicio = :NEW.fechaServicio;

    IF v_count = 0 THEN
        IF :NEW.idServicio IS NULL THEN
            SELECT seq_servicios_postventa.NEXTVAL 
            INTO :NEW.idServicio 
            FROM dual;
        END IF;
    ELSE
        RAISE_APPLICATION_ERROR(-20002, 'Registro duplicado: ya existe un servicio postventa con esta fecha.');
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
        RAISE_APPLICATION_ERROR(-20001, 'Registro duplicado: el mismo servicio ya fue realizado por este técnico en esta fecha.');
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

/* Disparador para validar rol de Técnico */
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
    -- Crear el nombre base: inicial del nombre + apellido en minúsculas
    v_nombreUsuario := LOWER(SUBSTR(:NEW.nombreTecnico, 1, 1)) || LOWER(:NEW.apellidoTecnico);

    -- Iniciar con el nombre base
    v_usuarioFinal := v_nombreUsuario;

    -- Validar unicidad del nombre de usuario
    LOOP
        -- Contar cuántos usuarios existen con este nombre
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

    -- Generar una contraseña aleatoria
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
    -- Crear el nombre base: inicial del nombre + apellido en minúsculas
    v_nombreUsuario := LOWER(SUBSTR(:NEW.nombreVendedor, 1, 1)) || LOWER(:NEW.apellidoVendedor);

    -- Iniciar con el nombre base
    v_usuarioFinal := v_nombreUsuario;

    -- Validar unicidad del nombre de usuario
    LOOP
        -- Contar cuántos usuarios existen con este nombre
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

    -- Generar una contraseña aleatoria
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
    -- Asignar automáticamente idTecnico desde la secuencia
    IF :NEW.idTecnico IS NULL THEN
        :NEW.idTecnico := seq_tecnicos.NEXTVAL;
    END IF;
END;


--Disparador para idVendedor

CREATE OR REPLACE TRIGGER trg_auto_id_vendedor
BEFORE INSERT ON tblVendedor
FOR EACH ROW
BEGIN
    -- Asignar automáticamente idVendedor desde la secuencia
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
        RAISE_APPLICATION_ERROR(-20001, 'Registro duplicado: ya existe un vehículo con este modelo y marca.');
    END IF;
END;

/=========================================/
/*               PARA ELIMINAR LOS DISPARADORES           */
/=========================================/

DROP TRIGGER trg_venta_id;

DROP TRIGGER trg_actualizar_estado_ejemplar;

DROP TRIGGER trg_servicios_postventa_id;

DROP TRIGGER trg_servicios_tecnicos_id;

DROP TRIGGER trg_validar_rol_vendedor;

DROP TRIGGER trg_validar_rol_tecnico;

DROP TRIGGER trg_validate_and_set_idEjemplar;

DROP TRIGGER trg_id_vehiculo_proveedor;

 
/=========================================/
/*                  Procedimientos y Funciones                      */
/=========================================/

/--------------------------------------------------------------/
/* PROCEDIMIENTO: RegistrarProveedor               */
/* Creador: Sebastián García                                 */
/-------------------------------------------------------------/
CREATE OR REPLACE PROCEDURE RegistrarProveedor(
    p_idProveedor IN tblProveedor.idProveedor%TYPE,
    p_nombreProveedor IN tblProveedor.nombreProveedor%TYPE,
    p_telefonoProveedor IN tblProveedor.telefonoProveedor%TYPE,
    p_direccionProveedor IN tblProveedor.direccionProveedor%TYPE
) AS
    v_count INTEGER;
BEGIN
    -- Verificar si el idProveedor ya existe
    SELECT COUNT(*)
    INTO v_count
    FROM tblProveedor
    WHERE idProveedor = p_idProveedor;

    IF v_count > 0 THEN
        RAISE_APPLICATION_ERROR(-20001, 'Error: El ID de proveedor ' || p_idProveedor || ' ya existe.');
    END IF;
    INSERT INTO tblProveedor (idProveedor, nombreProveedor, telefonoProveedor, direccionProveedor)
    VALUES (p_idProveedor, p_nombreProveedor, p_telefonoProveedor, p_direccionProveedor);

    DBMS_OUTPUT.PUT_LINE('Proveedor "' || p_nombreProveedor || '" registrado con ID ' || p_idProveedor);

EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Se ha producido un error al registrar el proveedor: ' || SQLERRM);
END;

------BLOQUE ANONIMO

SET SERVEROUTPUT ON

DECLARE
    v_idProveedor tblProveedor.idProveedor%TYPE := 3;
    v_nombreProveedor tblProveedor.nombreProveedor%TYPE := 'Proveedor Prueba';
    v_telefonoProveedor tblProveedor.telefonoProveedor%TYPE := '123456789';
    v_direccionProveedor tblProveedor.direccionProveedor%TYPE := 'Dirección Prueba';
BEGIN
    RegistrarProveedor(v_idProveedor,v_nombreProveedor,v_telefonoProveedor,v_direccionProveedor);

END;

DROP PROCEDURE RegistrarProveedor;


/--------------------------------------------------------------/
/* FUNCIÓN: consultarEjemplaresDisponibles        */
/* Creador: Sebastián García                               */
/--------------------------------------------------------------/
CREATE OR REPLACE FUNCTION consultarEjemplaresDisponibles
RETURN SYS_REFCURSOR
IS
    ejemplares_cursor SYS_REFCURSOR;
BEGIN
    OPEN ejemplares_cursor FOR
        SELECT e.idEjemplar, v.modeloVehiculo, v.marcaVehiculo, v.añoVehiculo, v.precioVehiculo, p.nombreProveedor
        FROM tblEjemplar e
        JOIN tblVehiculo v ON e.idVehiculo = v.idVehiculo
        JOIN tblProveedor p ON e.idProveedor = p.idProveedor
        WHERE e.estadoEjemplar = 'disponible';
    RETURN ejemplares_cursor;
END consultarEjemplaresDisponibles;

---------BLOQUE ANONIMO
SET SERVEROUTPUT ON

DECLARE
    ejemplares_cursor SYS_REFCURSOR;
    idEjemplar_tbl tblEjemplar.idEjemplar%TYPE;
    modeloVehiculo_tbl tblVehiculo.modeloVehiculo%TYPE;
    marcaVehiculo_tbl tblVehiculo.marcaVehiculo%TYPE;
    añoVehiculo_tbl tblVehiculo.añoVehiculo%TYPE;
    precioVehiculo_tbl tblVehiculo.precioVehiculo%TYPE;
    nombreProveedor_tbl tblProveedor.nombreProveedor%TYPE;
BEGIN
    ejemplares_cursor := consultarEjemplaresDisponibles;
    LOOP        
        FETCH ejemplares_cursor INTO idEjemplar_tbl, modeloVehiculo_tbl, marcaVehiculo_tbl, añoVehiculo_tbl, precioVehiculo_tbl, nombreProveedor_tbl;
        EXIT WHEN ejemplares_cursor%NOTFOUND;        
        
        DBMS_OUTPUT.PUT_LINE('ID Ejemplar: ' || idEjemplar_tbl || ', Modelo: ' || modeloVehiculo_tbl || ', Marca: ' || marcaVehiculo_tbl || ', Año: ' || añoVehiculo_tbl || ', Precio: ' || precioVehiculo_tbl || ', Proveedor: ' || nombreProveedor_tbl);
    END LOOP;

    CLOSE ejemplares_cursor;
END;

DROP FUNCTION consultarEjemplaresDisponibles;
/*----------------------------------------------------------------/
/* PROCEDIMIENTO: generar_reporte_ventas         */
/* Creador: Juan Chávez                                       */
/---------------------------------------------------------------/
CREATE OR REPLACE PROCEDURE generar_reporte_ventas (
    p_fecha_inicio IN TIMESTAMP,
    p_id_vendedor IN INTEGER,
    p_id_cliente IN INTEGER
) AS
    TYPE venta_record IS RECORD (
        idVenta tblVenta.idVenta%TYPE,
        fechaVenta tblVenta.fechaVenta%TYPE,
        totalVenta tblVenta.totalVenta%TYPE,
        comisionVenta tblVenta.comisionVenta%TYPE,
        idVendedor tblVenta.idVendedor%TYPE,
        cedulaCliente tblVenta.cedulaCliente%TYPE
    );
    CURSOR c_ventas IS
        SELECT idVenta, fechaVenta, totalVenta, comisionVenta, idVendedor, cedulaCliente
        FROM tblVenta
        WHERE (p_fecha_inicio IS NULL OR fechaVenta >= p_fecha_inicio)
          AND (p_id_vendedor IS NULL OR idVendedor = p_id_vendedor)
          AND (p_id_cliente IS NULL OR cedulaCliente = p_id_cliente);
    v_venta_row venta_record;
BEGIN
    IF p_fecha_inicio IS NULL AND p_id_vendedor IS NULL AND p_id_cliente IS NULL THEN
        DBMS_OUTPUT.PUT_LINE('Por favor, ingrese al menos un filtro de búsqueda.');
        RETURN;
    END IF;
    OPEN c_ventas;
    FETCH c_ventas INTO v_venta_row;
    IF c_ventas%NOTFOUND THEN
        DBMS_OUTPUT.PUT_LINE('No se encontraron ventas para los criterios especificados.');
        CLOSE c_ventas;
        RETURN;
    END IF;
    LOOP
        DBMS_OUTPUT.PUT_LINE('ID Venta: ' || v_venta_row.idVenta || 
                             ', Fecha: ' || TO_CHAR(v_venta_row.fechaVenta, 'YYYY-MM-DD') ||
                             ', Total: ' || v_venta_row.totalVenta);
        FETCH c_ventas INTO v_venta_row;
        EXIT WHEN c_ventas%NOTFOUND;
    END LOOP;
    CLOSE c_ventas;
END generar_reporte_ventas;

-----BLOQUE ANONIMO
SET SERVEROUTPUT ON
DECLARE
    -- Variables para pasar los parámetros al procedimiento
    v_fecha timestamp := TO_TIMESTAMP('2024-06-01', 'YYYY-MM-DD');
    v_id_vendedor INTEGER := 2;  -- Cambiar al ID de vendedor que deseas probar
    v_id_cliente INTEGER := NULL;  -- Puedes poner NULL si no deseas filtrar por cliente
BEGIN
    -- Llamar al procedimiento
    generar_reporte_ventas(v_fecha,null,null);
    --generar_reporte_ventas(null,null,null);
END;

DROP PROCEDURE generar_reporte_ventas;
/---------------------------------------------------------------/
/* FUNCIÓN: calcular_comision_venta                   */
/* Creador: Juan Chávez                                      */
/--------------------------------------------------------------/
CREATE OR REPLACE FUNCTION calcular_comision_venta(p_idVenta IN INTEGER)
RETURN NUMBER
IS
    v_totalVenta NUMBER;
    v_comisionVenta NUMBER;
    v_porcentaje_comision CONSTANT NUMBER := 0.05;
BEGIN
    SELECT totalVenta INTO v_totalVenta
    FROM tblVenta
    WHERE idVenta = p_idVenta;
    v_comisionVenta := v_totalVenta * v_porcentaje_comision;
    RETURN v_comisionVenta;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN NULL;
    WHEN OTHERS THEN
        RETURN NULL;
END calcular_comision_venta;

-- BLOQUE ANONIMO 
DECLARE
    v_idVenta INTEGER := 2; 
    v_comision NUMBER;
BEGIN
    v_comision := calcular_comision_venta(v_idVenta);

    -- Mostramos el resultado
    IF v_comision IS NOT NULL THEN
        DBMS_OUTPUT.PUT_LINE('La comisión para la venta con ID ' || v_idVenta || ' es: ' || TO_CHAR(v_comision));
    ELSE
        DBMS_OUTPUT.PUT_LINE('No se encontró la venta con ID ' || v_idVenta || ' o hubo un error en el cálculo.');
    END IF;
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Ocurrió un error: ' || SQLERRM);
END;

DROP FUNCTION calcular_comision_venta;
/--------------------------------------------------------------/
/* PROCEDIMIENTO: actualizar_y_eliminar_usuarios_inactivos   */
/* Creador: Katherin Chamorro                              */
/---------------------------------------------------------------/
CREATE OR REPLACE PROCEDURE actualizar_y_eliminar_usuarios_inactivos AS
BEGIN
    -- Establecer idUsuario en NULL para vendedores inactivos
    UPDATE tblVendedor
    SET idUsuario = NULL
    WHERE estadoVendedor = 'inactivo' AND idUsuario IS NOT NULL;

    -- Establecer idUsuario en NULL para técnicos inactivos
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
        DBMS_OUTPUT.PUT_LINE('Ocurrió un error al actualizar y eliminar usuarios inactivos: ' || SQLERRM);
END actualizar_y_eliminar_usuarios_inactivos;

-- BLOQUE ANONIMO
-- Cambiar el estado de un técnico o vendedor a 'inactivo'
-- Cada vez que un técnico o vendedor pasa a ser inactivo, el usuario correspondiente se eliminará al ejecutar el procedimiento 'actualizar_y_eliminar_usuarios_inactivos'.

UPDATE tblVendedor 
SET estadoVendedor = 'inactivo' 
WHERE idVendedor = 2;

-- Ejecutar el procedimiento para actualizar y eliminar usuarios inactivos
BEGIN
    actualizar_y_eliminar_usuarios_inactivos;
END;
/

DROP PROCEDURE actualizar_y_eliminar_usuarios_inactivos;

/--------------------------------------------------------------/
/* FUNCIÓN: Consultar_informacion_cliente          */
/* Creador: Katherin Chamorro                            */
/--------------------------------------------------------------/
CREATE OR REPLACE FUNCTION Consultar_informacion_cliente(p_idCliente IN INTEGER)
RETURN VARCHAR2
IS
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

-- BLOQUE ANONIMO
DECLARE
    v_idCliente INTEGER := 2; 
    v_infoCliente VARCHAR2(200);
BEGIN
    v_infoCliente := Consultar_informacion_cliente(v_idCliente);

    DBMS_OUTPUT.PUT_LINE('Información del cliente: ' || v_infoCliente);
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Error en la prueba: ' || SQLERRM);
END;

DROP FUNCTION Consultar_informacion_cliente;
/*----------------------------------------------------------------------------------/
/* PROCEDIMIENTO: Consultar_informacion_proveedor                */
/* Creador: Juan Pérez                                                               */
/---------------------------------------------------------------------------------/
CREATE OR REPLACE PROCEDURE Consultar_informacion_proveedor(
    p_idProveedor IN INTEGER
)
IS
    -- Variables para almacenar los datos del proveedor
    v_nombreProveedor tblProveedor.nombreProveedor%TYPE;
    v_telefonoProveedor tblProveedor.telefonoProveedor%TYPE;
    v_direccionProveedor tblProveedor.direccionProveedor%TYPE;

    -- Variables para manejar los datos del vehículo
    CURSOR vehiculos_cursor IS
        SELECT idVehiculo, modeloVehiculo, marcaVehiculo, añoVehiculo
        FROM tblVehiculo
        WHERE idProveedor = p_idProveedor;

    v_idVehiculo tblVehiculo.idVehiculo%TYPE;
    v_modeloVehiculo tblVehiculo.modeloVehiculo%TYPE;
    v_marcaVehiculo tblVehiculo.marcaVehiculo%TYPE;
    v_añoVehiculo tblVehiculo.añoVehiculo%TYPE;
BEGIN
    -- Obtener información del proveedor
    SELECT nombreProveedor, telefonoProveedor, direccionProveedor
    INTO v_nombreProveedor, v_telefonoProveedor, v_direccionProveedor
    FROM tblProveedor
    WHERE idProveedor = p_idProveedor;

    -- Mostrar información del proveedor
    DBMS_OUTPUT.PUT_LINE('Proveedor:');
    DBMS_OUTPUT.PUT_LINE('Nombre: ' || v_nombreProveedor);
    DBMS_OUTPUT.PUT_LINE('Teléfono: ' || NVL(v_telefonoProveedor, 'No registrado'));
    DBMS_OUTPUT.PUT_LINE('Dirección: ' || NVL(v_direccionProveedor, 'No registrada'));

    -- Mostrar información de los vehículos asociados
    DBMS_OUTPUT.PUT_LINE('Vehículos asociados:');
    OPEN vehiculos_cursor;
    LOOP
        FETCH vehiculos_cursor INTO v_idVehiculo, v_modeloVehiculo, v_marcaVehiculo, v_añoVehiculo;
        EXIT WHEN vehiculos_cursor%NOTFOUND;

        DBMS_OUTPUT.PUT_LINE('- ID Vehículo: ' || v_idVehiculo || 
                             ', Modelo: ' || v_modeloVehiculo || 
                             ', Marca: ' || v_marcaVehiculo || 
                             ', Año: ' || v_añoVehiculo);
    END LOOP;
    CLOSE vehiculos_cursor;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        DBMS_OUTPUT.PUT_LINE('Proveedor no encontrado.');
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Ocurrió un error: ' || SQLERRM);
END Consultar_informacion_proveedor;
/

---------Procedimiento para c#

CREATE OR REPLACE PROCEDURE Consultar_informacion_proveedor(
    p_idProveedor IN INTEGER,
    p_proveedor OUT SYS_REFCURSOR,
    p_vehiculos OUT SYS_REFCURSOR
)
IS
BEGIN
    -- Retornar información del proveedor
    OPEN p_proveedor FOR
        SELECT nombreProveedor, telefonoProveedor, direccionProveedor
        FROM tblProveedor
        WHERE idProveedor = p_idProveedor;

    -- Retornar información de los vehículos asociados
    OPEN p_vehiculos FOR
        SELECT idVehiculo, modeloVehiculo, marcaVehiculo, añoVehiculo
        FROM tblVehiculo
        WHERE idProveedor = p_idProveedor;
END Consultar_informacion_proveedor;


----Procedimiento para c# *Proveedores

CREATE OR REPLACE PROCEDURE Consultar_todos_los_proveedores (
    p_proveedor OUT SYS_REFCURSOR,
    p_vehiculo OUT SYS_REFCURSOR
)
IS
BEGIN
    -- Proveedores
    OPEN p_proveedor FOR
    SELECT 
        idProveedor,
        nombreProveedor,
        telefonoProveedor,
        direccionProveedor
    FROM tblProveedor;
    
    -- Vehículos asociados
    OPEN p_vehiculo FOR
    SELECT 
        idVehiculo,
        modeloVehiculo,
        marcaVehiculo,
        añoVehiculo,
        idProveedor
    FROM tblVehiculo;
END Consultar_todos_los_proveedores;


-- BLOQUE ANONIMO
    SET SERVEROUTPUT ON;
    DECLARE
        v_idProveedor INTEGER := 1;
    BEGIN
        Consultar_informacion_proveedor(p_idProveedor => v_idProveedor);
    EXCEPTION
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('Error en la prueba: ' || SQLERRM);
    END;

DROP PROCEDURE Consultar_informacion_proveedor;

/--------------------------------------------------------------/
/* FUNCIÓN: consultar_servicios_realizados         */
/* Creador: Juan Pérez                                       */
/-------------------------------------------------------------/
CREATE OR REPLACE FUNCTION consultar_servicios_realizados(p_idCliente INTEGER)
RETURN SYS_REFCURSOR
IS
    cursor_servicios SYS_REFCURSOR;
BEGIN
    OPEN cursor_servicios FOR
    SELECT s.idServicio, s.fechaServicio, s.tipoServicio, s.costoServicio
    FROM tblServiciosPostVenta s
    JOIN tblSe_RealizaServicioPostVenta sp ON s.idServicio = sp.idServicio
    JOIN tblVenta v ON sp.idVenta = v.idVenta
    WHERE v.cedulaCliente = p_idCliente;
    RETURN cursor_servicios;
END consultar_servicios_realizados;

----BLOQUE ANONIMO
SET SERVEROUTPUT ON

DECLARE
    cursor_servicios SYS_REFCURSOR;
    idServicio_tbl tblServiciosPostVenta.idServicio%TYPE;
    fechaServicio_tbl tblServiciosPostVenta.fechaServicio%TYPE;
    tipoServicio_tbl tblServiciosPostVenta.tipoServicio%TYPE;
    costoServicio_tbl tblServiciosPostVenta.costoServicio%TYPE;
    v_idCliente INTEGER := 2;  -- Cambia este valor según sea necesario
    filas_recuperadas NUMBER := 0;
BEGIN
    BEGIN
        -- Llamar a la función para obtener el cursor
        cursor_servicios := consultar_servicios_realizados(p_idCliente => v_idCliente);

        -- Iterar sobre el cursor y mostrar los resultados
        LOOP
            FETCH cursor_servicios INTO idServicio_tbl, fechaServicio_tbl, tipoServicio_tbl, costoServicio_tbl;
            EXIT WHEN cursor_servicios%NOTFOUND;
            
            filas_recuperadas := filas_recuperadas + 1;
            DBMS_OUTPUT.PUT_LINE('ID Servicio: ' || idServicio_tbl || ', Fecha: ' || fechaServicio_tbl || 
                                 ', Tipo: ' || tipoServicio_tbl || ', Costo: ' || costoServicio_tbl);
        END LOOP;

        -- Si no se recuperaron filas, mostramos un mensaje
        IF filas_recuperadas = 0 THEN
            DBMS_OUTPUT.PUT_LINE('No se encontraron servicios realizados para el cliente con ID ' || v_idCliente);
        END IF;

    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            DBMS_OUTPUT.PUT_LINE('No se encontraron servicios realizados para el cliente con ID ' || v_idCliente);
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('Error inesperado al consultar los servicios realizados: ' || SQLERRM);
    END;

END;

DROP FUNCTION consultar_servicios_realizados;

/----------------------------------------------------------------------------------/
/* PROCEDIMIENTO: Registrar_Cliente_Nuevo                */
/* Creador: Juan Camilo Benavides  Salazar                                                           */
/---------------------------------------------------------------------------------/
CREATE OR REPLACE PROCEDURE Registrar_Cliente_Nuevo(
    p_cedulaCliente     tblCliente.cedulaCliente%TYPE,
    p_nombreCliente     tblCliente.nombreCliente%TYPE,
    p_apellidoCliente   tblCliente.apellidoCliente%TYPE,
    p_telefonoCliente   tblCliente.telefonoCliente%TYPE,
    p_emailCliente      tblCliente.emailCliente%TYPE,
    p_direccionCliente  tblCliente.direccionCliente%TYPE
) IS
    v_exists INTEGER;

    -- Declarar una excepción personalizada para la cédula duplicada
    ex_cedula_duplicada EXCEPTION;

BEGIN
    -- Verificar si ya existe un cliente con la misma cédula
    SELECT COUNT(*) INTO v_exists
    FROM tblCliente
    WHERE cedulaCliente = p_cedulaCliente;
    
    IF v_exists > 0 THEN
        RAISE ex_cedula_duplicada; -- Lanzar la excepción si la cédula está duplicada
    END IF;

    -- Intentar insertar el cliente en la tabla
    INSERT INTO tblCliente (cedulaCliente, nombreCliente, apellidoCliente, telefonoCliente, emailCliente, direccionCliente)
    VALUES (p_cedulaCliente, p_nombreCliente, p_apellidoCliente, p_telefonoCliente, p_emailCliente, p_direccionCliente);

    DBMS_OUTPUT.PUT_LINE('Cliente registrado correctamente.');

EXCEPTION
    WHEN ex_cedula_duplicada THEN
        DBMS_OUTPUT.PUT_LINE('Error: La cédula del cliente ya está registrada en el sistema.');
    WHEN DUP_VAL_ON_INDEX THEN
        DBMS_OUTPUT.PUT_LINE('Error: El email ya está registrado en el sistema.');
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Error inesperado: ' || SQLERRM);
END Registrar_Cliente_Nuevo;

-- BLOQUE ANONIMO
DECLARE
    v_cedulaCliente    tblCliente.cedulaCliente%TYPE := 3; -- Ejemplo de cédula para el cliente
    v_nombreCliente    tblCliente.nombreCliente%TYPE := 'Juan';
    v_apellidoCliente  tblCliente.apellidoCliente%TYPE := 'Pérez';
    v_telefonoCliente  tblCliente.telefonoCliente%TYPE := '123-456-7890';
    v_emailCliente     tblCliente.emailCliente%TYPE := 'juan.perez@example.com';
    v_direccionCliente tblCliente.direccionCliente%TYPE := 'Calle Falsa 123';
BEGIN
    -- Llamada al procedimiento para registrar un nuevo cliente
    Registrar_Cliente_Nuevo(v_cedulaCliente, v_nombreCliente,  v_apellidoCliente, v_telefonoCliente,  v_emailCliente,  v_direccionCliente );
END;

DROP PROCEDURE Registrar_Cliente_Nuevo;

/----------------------------------------------------------------------------------/
/* FUNCION: fn_Numero_De_Clientes     */
/* Creador: Juan Camilo Benavides  Salazar                                                           */
/---------------------------------------------------------------------------------/
CREATE OR REPLACE FUNCTION fn_Numero_De_Clientes RETURN NUMBER IS
    v_totalClientes NUMBER;
BEGIN
    -- Intentar contar el número de clientes registrados en la tabla
    SELECT COUNT(*) INTO v_totalClientes FROM tblCliente;
    
    -- Retornar el número total de clientes
    RETURN v_totalClientes;

EXCEPTION
    WHEN NO_DATA_FOUND THEN
        DBMS_OUTPUT.PUT_LINE('Error: No se encontraron datos en la tabla tblCliente.');
        RETURN 0;
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Error inesperado: ' || SQLERRM);
        RETURN -1;
END fn_Numero_De_Clientes;

--BLOQUE ANONIMO
DECLARE
    v_numeroClientes NUMBER;
BEGIN
    -- Llamar a la función y almacenar el resultado en una variable
    v_numeroClientes := fn_Numero_De_Clientes;

    -- Condicional para verificar el resultado de la función
    IF v_numeroClientes = -1 THEN
        DBMS_OUTPUT.PUT_LINE('Error al contar los clientes. Verifique el sistema.');
    ELSIF v_numeroClientes = 0 THEN
        DBMS_OUTPUT.PUT_LINE('No hay clientes registrados en el sistema.');
    ELSE
        DBMS_OUTPUT.PUT_LINE('Número de clientes registrados en el sistema: ' || v_numeroClientes);
    END IF;
END;

DROP FUNCTION fn_Numero_De_Clientes;

----Procedimiento para las inserciones en bucle

CREATE OR REPLACE PROCEDURE InsertarEjemplares(
    p_idVehiculo   IN NUMBER,
    p_idProveedor  IN NUMBER,
    p_estado       IN VARCHAR2,
    p_cantidad     IN NUMBER,
    p_filasInsertadas OUT NUMBER
)
AS
BEGIN
    p_filasInsertadas := 0; -- Inicializar el contador
    FOR i IN 1..p_cantidad LOOP
        INSERT INTO tblEjemplar (idVehiculo, idProveedor, estadoEjemplar)
        VALUES (p_idVehiculo, p_idProveedor, p_estado);
        p_filasInsertadas := p_filasInsertadas + 1; -- Incrementar el contador
    END LOOP;
END;


DROP PROCEDURE InsertarEjemplares;