--/======================================/
/*                   Proyecto: Derrapa Zone                     */
--/======================================/
--HECHO POR:
--JUAN ESTEBAN CHAVEZ COLLAZOS
--KATHERIN CHAMORRO LUCERO
--JUAN CAMILO BENAVIDES SALAZAR
--JHOAN SEBASTIAN GARCIA CAMACHO
--JUAN DIEGO PEREZ MARTINEZ

--
----SCRIPT DE CREACION

--/=====================================/
/*                      Eliminación de Tablas                    */
--/=====================================/
DROP TABLE tblRealizaServicioTecnico CASCADE CONSTRAINTS;
DROP TABLE tblInvolucraVentaEjemplar CASCADE CONSTRAINTS;
DROP TABLE tblSe_RealizaServicioPostventa CASCADE CONSTRAINTS;
DROP TABLE tblServiciosPostVenta CASCADE CONSTRAINTS;
DROP TABLE tblEjemplar CASCADE CONSTRAINTS;
DROP TABLE tblVenta CASCADE CONSTRAINTS;
DROP TABLE tblCliente CASCADE CONSTRAINTS;
DROP TABLE tblVehiculo CASCADE CONSTRAINTS;
DROP TABLE tblProveedor CASCADE CONSTRAINTS;
DROP TABLE tblVendedor CASCADE CONSTRAINTS;
DROP TABLE tblTecnico CASCADE CONSTRAINTS;
DROP TABLE tblUsuario CASCADE CONSTRAINTS;
DROP TABLE tblRol CASCADE CONSTRAINTS;

--/=====================================/
/*                     Creación de Tablas                        */
--/=====================================/

--/=========================================/
/* Table: tblRol                                                           */
--/=========================================/
CREATE TABLE tblRol (
    idRol INTEGER PRIMARY KEY,
    nombreRol VARCHAR2(50) NOT NULL UNIQUE
);

--/=========================================/
/* Table: tblUsuario                                                       */
--/=========================================/
CREATE TABLE tblUsuario (
    idUsuario INTEGER PRIMARY KEY,
    nombreUsuario VARCHAR2(50) NOT NULL UNIQUE,
    passwordUsuario VARCHAR2(50) NOT NULL,
    idRol INTEGER NOT NULL,
    CONSTRAINT fk_usuario_rol FOREIGN KEY (idRol) REFERENCES tblRol(idRol)
);

--
/* Table: tblProveedor                                                     */
--/=========================================/
CREATE TABLE tblProveedor (
    idProveedor INTEGER NOT NULL,
    nombreProveedor VARCHAR2(50) NOT NULL,
    telefonoProveedor VARCHAR2(50),
    direccionProveedor VARCHAR2(50),
    CONSTRAINT pk_tblProveedor PRIMARY KEY (idProveedor)
);

--/=========================================/
/* Table: tblVehiculo                                                       */
--/=========================================/
CREATE TABLE tblVehiculo (
    idVehiculo INTEGER NOT NULL,
    modeloVehiculo VARCHAR2(50) NOT NULL,
    marcaVehiculo VARCHAR2(50) NOT NULL,
    añoVehiculo INTEGER NOT NULL,
    precioVehiculo NUMBER NOT NULL,
    idProveedor INTEGER NOT NULL,
    CONSTRAINT pk_tblVehiculo PRIMARY KEY (idVehiculo),
    CONSTRAINT fk_tblVehiculo_Proveedor FOREIGN KEY (idProveedor) REFERENCES tblProveedor(idProveedor)
);

--/=========================================/
/* Table: tblCliente                                                          */
--/=========================================/
CREATE TABLE tblCliente (
    cedulaCliente INTEGER NOT NULL,
    nombreCliente VARCHAR2(50) NOT NULL,
    apellidoCliente VARCHAR2(50) NOT NULL,
    telefonoCliente VARCHAR2(50),
    emailCliente VARCHAR2(100) UNIQUE,
    direccionCliente VARCHAR2(50),
    CONSTRAINT pk_tblCliente PRIMARY KEY (cedulaCliente)
);

--/=========================================/
/* Table: tblVendedor                                                     */
--/=========================================/
CREATE TABLE tblVendedor (
    idVendedor INTEGER NOT NULL,
    nombreVendedor VARCHAR2(50) NOT NULL,
    apellidoVendedor VARCHAR2(50) NOT NULL,
    estadoVendedor VARCHAR2(50) NOT NULL, 
    salarioVendedor NUMBER NOT NULL,
    fechaContratacionVendedor TIMESTAMP NOT NULL,
    idUsuario INTEGER,
    CONSTRAINT fk_vendedor_usuario FOREIGN KEY (idUsuario) REFERENCES tblUsuario(idUsuario),
    CONSTRAINT pk_tblVendedor PRIMARY KEY (idVendedor),
    CONSTRAINT ckc_estadoVendedor CHECK (estadoVendedor IN ('activo', 'inactivo')),
    CONSTRAINT ckc_salarioVendedor CHECK (salarioVendedor >= 0)
);

--/=========================================/
/* Table: tblTecnico                                                        */
--/=========================================/
CREATE TABLE tblTecnico (
    idTecnico INTEGER NOT NULL,
    nombreTecnico VARCHAR2(50) NOT NULL,
    apellidoTecnico VARCHAR2(50) NOT NULL,
    estadoTecnico VARCHAR2(50) NOT NULL,
    salarioTecnico NUMBER NOT NULL,
    fechaContratacionTecnico TIMESTAMP NOT NULL,
    idUsuario INTEGER,
    CONSTRAINT fk_tecnico_usuario FOREIGN KEY (idUsuario) REFERENCES tblUsuario(idUsuario),
    CONSTRAINT pk_tblTecnico PRIMARY KEY (idTecnico),
    CONSTRAINT ckc_estadoTecnico CHECK (estadoTecnico IN ('activo', 'inactivo')),
    CONSTRAINT ckc_salarioTecnico CHECK (salarioTecnico >= 0)
);

--/=========================================/
/* Table: tblEjemplar                                                       */
--/=========================================/
CREATE TABLE tblEjemplar (
    idEjemplar INTEGER NOT NULL,
    idVehiculo INTEGER NOT NULL,
    idProveedor INTEGER NOT NULL,
    estadoEjemplar VARCHAR2(50) NOT NULL,
    CONSTRAINT pk_tblEjemplar PRIMARY KEY (idEjemplar),
    CONSTRAINT fk_ejempVehiculo_id FOREIGN KEY (idVehiculo) REFERENCES tblVehiculo(idVehiculo),
    CONSTRAINT fk_proveedor_id FOREIGN KEY (idProveedor) REFERENCES tblProveedor(idProveedor),
    CONSTRAINT ckc_estadoEjemplar CHECK (estadoEjemplar IN ('disponible', 'vendido'))
);

--/=========================================/
/* Table: tblVenta                                                            */
--/=========================================/
CREATE TABLE tblVenta (
    idVenta INTEGER NOT NULL,
    fechaVenta TIMESTAMP NOT NULL,
    totalVenta NUMBER NOT NULL,
    comisionVenta INTEGER,
    idVendedor INTEGER NOT NULL,
    cedulaCliente INTEGER NOT NULL,
    idEjemplar INTEGER NOT NULL,
    CONSTRAINT pk_tblVenta PRIMARY KEY (idVenta),
    CONSTRAINT uq_venta UNIQUE(idVendedor, cedulaCliente, idEjemplar),
    CONSTRAINT fk_vendedor_id FOREIGN KEY (idVendedor) REFERENCES tblVendedor(idVendedor),
    CONSTRAINT fk_cliente_id FOREIGN KEY (cedulaCliente) REFERENCES tblCliente(cedulaCliente),
    CONSTRAINT fk_ejemplar_id FOREIGN KEY (idEjemplar) REFERENCES tblEjemplar(idEjemplar),
    CONSTRAINT ckc_totalVenta CHECK (totalVenta >= 0)
);

--/=========================================/
/* Table: tblServiciosPostVenta                                       */
--/=========================================/
CREATE TABLE tblServiciosPostVenta (
    idServicio INTEGER NOT NULL,
    tipoServicio VARCHAR2(50) NOT NULL,
    costoServicio NUMBER NOT NULL,
    CONSTRAINT pk_tblServiciosPostVenta PRIMARY KEY (idServicio),
    CONSTRAINT ckc_tipoServicio CHECK (tipoServicio IN ('mantenimiento', 'reparacion')),
    CONSTRAINT ckc_costoServicio CHECK (costoServicio >= 0)
);

--/=========================================/
/* Table: tblRealizaServicioTecnico                                  */
--/=========================================/
CREATE TABLE tblRealizaServicioTecnico (
    idRealizacionServicio INTEGER NOT NULL,   
    idServicio INTEGER NOT NULL,
    idTecnico INTEGER NOT NULL,
    idVenta INTEGER NOT NULL,
    fechaInicioServicio TIMESTAMP NOT NULL,
    fechaFinServicio TIMESTAMP,
    CONSTRAINT pk_tblRealizaServicioTecnico PRIMARY KEY (idRealizacionServicio),
    CONSTRAINT uq_servicioTecnico UNIQUE(idServicio,idVenta, idTecnico, fechaInicioServicio),
    CONSTRAINT fk_tblRealiza_tecnico_id FOREIGN KEY (idTecnico) REFERENCES tblTecnico(idTecnico),
    CONSTRAINT fk_tblRealiza_servicio_id FOREIGN KEY (idServicio) REFERENCES tblServiciosPostVenta(idServicio)
);

--/=========================================/
/* Table: tblInvolucraVentaEjemplar                                  */
--/=========================================/
CREATE TABLE tblInvolucraVentaEjemplar (
    idEjemplar INTEGER NOT NULL,
    idVenta INTEGER NOT NULL,
    CONSTRAINT pk_tblInvolucraVentaEjemplar PRIMARY KEY (idEjemplar, idVenta),
    CONSTRAINT fk_tblInvolucraVentaEjemplar_ejemplar_id FOREIGN KEY (idEjemplar) REFERENCES tblEjemplar(idEjemplar),
    CONSTRAINT fk_tblInvolucraVentaEjemplar_venta_id FOREIGN KEY (idVenta) REFERENCES tblVenta(idVenta)
);

--/=========================================/
/*                  Secuencias para Autogeneración               */
--/=========================================/

CREATE SEQUENCE seq_ventas START WITH 1 INCREMENT BY 1;

CREATE SEQUENCE seq_vehiculos START WITH 1  INCREMENT BY 1;

CREATE SEQUENCE seq_ejemplar START WITH 1 INCREMENT BY 1;

CREATE SEQUENCE seq_servicios_postventa START WITH 1 INCREMENT BY 1;

CREATE SEQUENCE seq_servicios_tecnicos START WITH 1 INCREMENT BY 1;

CREATE SEQUENCE seq_usuarios START WITH 2 INCREMENT BY 1;

CREATE SEQUENCE seq_tecnicos START WITH 1 INCREMENT BY 1;

CREATE SEQUENCE seq_vendedores START WITH 1 INCREMENT BY 1;

--/=========================================/
/*               PARA ELIMINAR LAS SECUENCIAS           */
--/=========================================/

DROP SEQUENCE seq_ventas;

DROP SEQUENCE seq_ejemplar;

DROP SEQUENCE seq_servicios_postventa;

DROP SEQUENCE seq_vehiculos;

DROP SEQUENCE seq_servicios_tecnicos;

DROP SEQUENCE seq_usuarios;

DROP SEQUENCE seq_tecnicos;

DROP SEQUENCE seq_vendedores;



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

/*Disparador compuesto para calcular comision de vendedor*/
CREATE OR REPLACE TRIGGER trg_calcular_comision_vendedor
FOR INSERT OR UPDATE ON tblVenta
COMPOUND TRIGGER
    v_total_comision NUMBER := 0;
    v_idVendedor NUMBER;

    -- Sección: Antes de cada fila modificada
    BEFORE EACH ROW IS
    BEGIN
        -- Calcular la comisión de la venta actual y asignarla a :NEW.comisionVenta
        :NEW.comisionVenta := :NEW.totalVenta * 0.05;

        -- Guardar el ID del vendedor afectado
        v_idVendedor := :NEW.idVendedor;
    END BEFORE EACH ROW;

    -- Sección: Después de la sentencia
    AFTER STATEMENT IS
    BEGIN
        -- Calcular la comisión acumulada para el vendedor afectado en los últimos 30 días
        SELECT NVL(SUM(comisionVenta), 0)
        INTO v_total_comision
        FROM tblVenta
        WHERE idVendedor = v_idVendedor
          AND fechaVenta >= TRUNC(SYSDATE) - 30;

        -- Mostrar la comisión acumulada en los últimos 30 días en la salida
        DBMS_OUTPUT.PUT_LINE('Comisión acumulada para el vendedor con ID ' || v_idVendedor || ' en los últimos 30 días: ' || v_total_comision);
    END AFTER STATEMENT;

END trg_calcular_comision_vendedor;
/

CREATE OR REPLACE TRIGGER trg_bloquear_tecnicos_inactivos
BEFORE INSERT OR UPDATE ON tblTecnico
FOR EACH ROW
BEGIN
    IF :NEW.estadoTecnico = 'inactivo' THEN
        RAISE_APPLICATION_ERROR(-20006, 'Error: No se puede insertar o actualizar técnicos con estado "inactivo".');
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


CREATE OR REPLACE TRIGGER trg_insert_involucra_venta_ejemplar
AFTER INSERT ON tblVenta
FOR EACH ROW
BEGIN
    -- Insertar un registro en la tabla tblInvolucraVentaEjemplar
    INSERT INTO tblInvolucraVentaEjemplar (idEjemplar, idVenta)
    VALUES (:NEW.idEjemplar, :NEW.idVenta);
    
    -- Puedes agregar otros comportamientos en caso de necesitarlo
    DBMS_OUTPUT.PUT_LINE('Insertado en tblInvolucraVentaEjemplar: idEjemplar = ' || :NEW.idEjemplar || ', idVenta = ' || :NEW.idVenta);
END;



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

DROP TRIGGER trg_insert_involucra_venta_ejemplar;
 

--/=========================================/
/*                                 INSERCIONES                                       */
--/=========================================/

--/=========================================/
/*               PARA BORRAR INSERCIONES SIN DROPEAR LAS TABLAS         */
--/=========================================/
-- Eliminar registros de las tablas dependientes primero
DELETE FROM tblSe_RealizaServicioPostVenta;
DELETE FROM tblInvolucraVentaEjemplar;
DELETE FROM tblRealizaServicioTecnico;
DELETE FROM tblServiciosPostVenta;
DELETE FROM tblVenta;
DELETE FROM tblEjemplar;
DELETE FROM tblTecnico;
DELETE FROM tblVendedor;
DELETE FROM tblCliente;
DELETE FROM tblVehiculo;
DELETE FROM tblProveedor;
DELETE FROM tblUsuario;
DELETE FROM tblRol;

-- Confirmación
COMMIT;

--/--------------------------------------------------------------/
/* INSERTS DERRAPA ZONE:                                                          */
--/-------------------------------------------------------------/

--tblRoles
INSERT INTO tblRol (idRol, nombreRol) VALUES (1, 'ADMIN');
INSERT INTO tblRol (idRol, nombreRol) VALUES (2, 'VENDEDOR');
INSERT INTO tblRol (idRol, nombreRol) VALUES (3, 'TECNICO');

--tblServiciosPostVenta
INSERT INTO tblServiciosPostVenta (idServicio,tipoServicio, costoServicio)
VALUES (1,'mantenimiento', 500);

INSERT INTO tblServiciosPostVenta (idServicio,tipoServicio, costoServicio)
VALUES (2,'reparacion', 750);

--tblUsuarios
INSERT INTO tblUsuario (idUsuario, nombreUsuario, passwordUsuario, idRol) 
VALUES (1, 'admin', '123456', 1);

--tblProveedor 
INSERT INTO tblProveedor (idProveedor, nombreProveedor, telefonoProveedor, direccionProveedor)
VALUES (1, 'Proveedor Uno', '123456789', 'Calle A #123');

INSERT INTO tblProveedor (idProveedor, nombreProveedor, telefonoProveedor, direccionProveedor)
VALUES (2, 'Proveedor Dos', '987654321', 'Avenida B #456');

--tblVehiculo
INSERT INTO tblVehiculo (modeloVehiculo, marcaVehiculo, añoVehiculo, precioVehiculo,idProveedor)
VALUES ('Modelo X', 'Marca A', 2024, 25000,1);

INSERT INTO tblVehiculo (modeloVehiculo, marcaVehiculo, añoVehiculo, precioVehiculo,idProveedor)
VALUES ('Modelo Y', 'Marca B', 2022, 25000,1);

--tblCliente
INSERT INTO tblCliente (cedulaCliente, nombreCliente, apellidoCliente, telefonoCliente, emailCliente, direccionCliente)
VALUES (1, 'Carlos', 'Perez', '111222333', 'carlos.perez@example.com', 'Calle C #789');

INSERT INTO tblCliente (cedulaCliente, nombreCliente, apellidoCliente, telefonoCliente, emailCliente, direccionCliente)
VALUES (2, 'Laura', 'Gomez', '444555666', 'laura.gomez@example.com', 'Calle D #101');

--tblVendedor
INSERT INTO tblVendedor (nombreVendedor, apellidoVendedor, estadoVendedor, salarioVendedor, fechaContratacionVendedor)
VALUES ('Ana', 'Martinez', 'activo', 3000, TO_TIMESTAMP('2024-01-01 09:00:00', 'YYYY-MM-DD HH24:MI:SS'));

INSERT INTO tblVendedor (nombreVendedor, apellidoVendedor, estadoVendedor, salarioVendedor, fechaContratacionVendedor)
VALUES ('Juan', 'Rodriguez', 'activo', 3200, TO_TIMESTAMP('2024-02-15 10:00:00', 'YYYY-MM-DD HH24:MI:SS'));

--tblTecnico
INSERT INTO tblTecnico (nombreTecnico, apellidoTecnico, estadoTecnico, salarioTecnico, fechaContratacionTecnico)
VALUES ('Juan', 'Perez', 'activo', 3000, TO_DATE('2024-01-01', 'YYYY-MM-DD'));

INSERT INTO tblTecnico (nombreTecnico, apellidoTecnico, estadoTecnico, salarioTecnico, fechaContratacionTecnico)
VALUES ('Chavez', 'Perra', 'activo', 3000, TO_DATE('2024-01-01', 'YYYY-MM-DD'));

--tblEjemplar
INSERT INTO tblEjemplar (idVehiculo, idProveedor, estadoEjemplar)
VALUES (1, 1, 'disponible');

INSERT INTO tblEjemplar (idVehiculo, idProveedor, estadoEjemplar)
VALUES (2, 2, 'disponible');

INSERT INTO tblEjemplar (idVehiculo, idProveedor, estadoEjemplar)
VALUES (1, 1, 'disponible');

--tblVenta
INSERT INTO tblVenta (fechaVenta, totalVenta, comisionVenta, idVendedor, cedulaCliente, idEjemplar)
VALUES (TO_TIMESTAMP('2024-05-10 10:00:00', 'YYYY-MM-DD HH24:MI:SS'), 18000, 1800, 1, 1, 1);

INSERT INTO tblVenta (fechaVenta, totalVenta, comisionVenta, idVendedor, cedulaCliente, idEjemplar)
VALUES (TO_TIMESTAMP('2024-06-01 11:00:00', 'YYYY-MM-DD HH24:MI:SS'), 22000, 2000, 2, 2, 2);


--tblRealizaServicioTecnico
INSERT INTO tblRealizaServicioTecnico (idServicio, idTecnico,idVenta, fechaInicioServicio, fechaFinServicio)
VALUES (1, 1, 1 , TO_TIMESTAMP('2024-07-01 08:30:00', 'YYYY-MM-DD HH24:MI:SS'), TO_TIMESTAMP('2024-07-01 10:30:00', 'YYYY-MM-DD HH24:MI:SS'));

INSERT INTO tblRealizaServicioTecnico (idServicio, idTecnico,idVenta, fechaInicioServicio, fechaFinServicio)
VALUES (2, 2, 2, TO_TIMESTAMP('2024-07-10 09:30:00', 'YYYY-MM-DD HH24:MI:SS'), TO_TIMESTAMP('2024-07-10 11:30:00', 'YYYY-MM-DD HH24:MI:SS'));

--tblInvolucraVentaEjemplar 
INSERT INTO tblInvolucraVentaEjemplar (idEjemplar, idVenta)
VALUES (1, 1);

INSERT INTO tblInvolucraVentaEjemplar (idEjemplar, idVenta)
VALUES (2, 2);

commit;


--/=========================================/
/*               Creación de roles         */
--/=========================================/

CONNECT system/oracle;

alter session set "_ORACLE_SCRIPT"=true;

CREATE ROLE C##ADMIN_ROL;
CREATE ROLE C##VENDEDOR_ROL;
CREATE ROLE C##TECNICO_ROL;

-- Asignación de privilegios a los roles

-- Privilegios Admin_Rol
CONNECT system/oracle;
GRANT ALL PRIVILEGES TO C##ADMIN_ROL;

-- Privilegios de Vendedor_Rol
GRANT SELECT, INSERT, UPDATE ON tblVenta TO C##VENDEDOR_ROL;
GRANT SELECT, INSERT, UPDATE ON tblCliente TO C##VENDEDOR_ROL;
GRANT SELECT ON tblEjemplar TO C##VENDEDOR_ROL;

-- Privilegios de Tecnico_Rol
GRANT SELECT, INSERT, UPDATE ON tblServiciosPostVenta TO C##TECNICO_ROL;
GRANT SELECT, INSERT, UPDATE ON tblRealizaServicioTecnico TO C##TECNICO_ROL;
GRANT SELECT ON tblVehiculo TO C##TECNICO_ROL;

-- Creacion de usuarios
CONNECT system/oracle;
alter session set "_ORACLE_SCRIPT"=true;

CREATE USER vendedor_usuario IDENTIFIED BY vendedor123;
CREATE USER tecnico_usuario IDENTIFIED BY Tecnico123;
CREATE USER admin_usuario IDENTIFIED BY Administrador123;

-- Asignación de roles
CONNECT system/oracle;
alter session set "_ORACLE_SCRIPT"=true;

GRANT C##ADMIN_ROL TO admin_usuario;
GRANT C##VENDEDOR_ROL TO vendedor_usuario;
GRANT C##TECNICO_ROL TO tecnico_usuario;

CONNECT system/oracle;

GRANT CONNECT TO admin_usuario;
GRANT CONNECT TO vendedor_usuario;
GRANT CONNECT TO tecnico_usuario;


--/=========================================/
/*               PRUEBAS           */
--/=========================================/


CONNECT vendedor_usuario/vendedor123;

INSERT INTO USER_PROYECTOBASES.tblVenta (fechaVenta, totalVenta, comisionVenta, idVendedor, cedulaCliente, idEjemplar)
VALUES (TO_TIMESTAMP('2024-05-10 10:00:00', 'YYYY-MM-DD HH24:MI:SS'), 18000.00, 1800, 1, 1, 3);

commit;

CONNECT tecnico_usuario/Tecnico123;

INSERT INTO USER_PROYECTOBASES.tblRealizaServicioTecnico (idServicio, idTecnico, fechaInicioServicio, fechaFinServicio)
VALUES (2, 1, TO_TIMESTAMP('2024-07-01 08:30:00', 'YYYY-MM-DD HH24:MI:SS'), TO_TIMESTAMP('2024-07-01 10:30:00', 'YYYY-MM-DD HH24:MI:SS'));

commit;






