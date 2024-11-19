/======================================/
/*                   Proyecto: Derrapa Zone                     */
/======================================/
--HECHO POR:
--JUAN ESTEBAN CHAVEZ COLLAZOS
--KATHERIN CHAMORRO LUCERO
--JUAN CAMILO BENAVIDES SALAZAR
--JHOAN SEBASTIAN GARCIA CAMACHO
--JUAN DIEGO PEREZ MARTINEZ


----SCRIPT DE CREACION

/=====================================/
/*                      Eliminación de Tablas                    */
/=====================================/
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

/=====================================/
/*                     Creación de Tablas                        */
/=====================================/

/=========================================/
/* Table: tblRol                                                           */
/=========================================/
CREATE TABLE tblRol (
    idRol INTEGER PRIMARY KEY,
    nombreRol VARCHAR2(50) NOT NULL UNIQUE
);

/=========================================/
/* Table: tblUsuario                                                       */
/=========================================/
CREATE TABLE tblUsuario (
    idUsuario INTEGER PRIMARY KEY,
    nombreUsuario VARCHAR2(50) NOT NULL UNIQUE,
    passwordUsuario VARCHAR2(50) NOT NULL,
    idRol INTEGER NOT NULL,
    CONSTRAINT fk_usuario_rol FOREIGN KEY (idRol) REFERENCES tblRol(idRol)
);

/=========================================/
/* Table: tblProveedor                                                     */
/=========================================/
CREATE TABLE tblProveedor (
    idProveedor INTEGER NOT NULL,
    nombreProveedor VARCHAR2(50) NOT NULL,
    telefonoProveedor VARCHAR2(50),
    direccionProveedor VARCHAR2(50),
    CONSTRAINT pk_tblProveedor PRIMARY KEY (idProveedor)
);

/=========================================/
/* Table: tblVehiculo                                                       */
/=========================================/
CREATE TABLE tblVehiculo (
    idVehiculo INTEGER NOT NULL,
    modeloVehiculo VARCHAR2(50) NOT NULL,
    marcaVehiculo VARCHAR2(50) NOT NULL,
    añoVehiculo INTEGER NOT NULL,
    precioVehiculo DECIMAL(10, 2) NOT NULL,
    idProveedor INTEGER NOT NULL,
    CONSTRAINT pk_tblVehiculo PRIMARY KEY (idVehiculo),
    CONSTRAINT fk_tblVehiculo_Proveedor FOREIGN KEY (idProveedor) REFERENCES tblProveedor(idProveedor)
);

/=========================================/
/* Table: tblCliente                                                          */
/=========================================/
CREATE TABLE tblCliente (
    cedulaCliente INTEGER NOT NULL,
    nombreCliente VARCHAR2(50) NOT NULL,
    apellidoCliente VARCHAR2(50) NOT NULL,
    telefonoCliente VARCHAR2(50),
    emailCliente VARCHAR2(100) UNIQUE,
    direccionCliente VARCHAR2(50),
    CONSTRAINT pk_tblCliente PRIMARY KEY (cedulaCliente)
);

/=========================================/
/* Table: tblVendedor                                                     */
/=========================================/
CREATE TABLE tblVendedor (
    idVendedor INTEGER NOT NULL,
    nombreVendedor VARCHAR2(50) NOT NULL,
    apellidoVendedor VARCHAR2(50) NOT NULL,
    estadoVendedor VARCHAR2(50) NOT NULL, 
    salarioVendedor DECIMAL(10, 2) NOT NULL,
    fechaContratacionVendedor TIMESTAMP NOT NULL,
    idUsuario INTEGER,
    CONSTRAINT fk_vendedor_usuario FOREIGN KEY (idUsuario) REFERENCES tblUsuario(idUsuario),
    CONSTRAINT pk_tblVendedor PRIMARY KEY (idVendedor),
    CONSTRAINT ckc_estadoVendedor CHECK (estadoVendedor IN ('activo', 'inactivo')),
    CONSTRAINT ckc_salarioVendedor CHECK (salarioVendedor >= 0)
);

/=========================================/
/* Table: tblTecnico                                                        */
/=========================================/
CREATE TABLE tblTecnico (
    idTecnico INTEGER NOT NULL,
    nombreTecnico VARCHAR2(50) NOT NULL,
    apellidoTecnico VARCHAR2(50) NOT NULL,
    estadoTecnico VARCHAR2(50) NOT NULL,
    salarioTecnico DECIMAL(10, 2) NOT NULL,
    fechaContratacionTecnico TIMESTAMP NOT NULL,
    idUsuario INTEGER,
    CONSTRAINT fk_tecnico_usuario FOREIGN KEY (idUsuario) REFERENCES tblUsuario(idUsuario),
    CONSTRAINT pk_tblTecnico PRIMARY KEY (idTecnico),
    CONSTRAINT ckc_estadoTecnico CHECK (estadoTecnico IN ('activo', 'inactivo')),
    CONSTRAINT ckc_salarioTecnico CHECK (salarioTecnico >= 0)
);

/=========================================/
/* Table: tblEjemplar                                                       */
/=========================================/
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

/=========================================/
/* Table: tblVenta                                                            */
/=========================================/
CREATE TABLE tblVenta (
    idVenta INTEGER NOT NULL,
    fechaVenta TIMESTAMP NOT NULL,
    totalVenta DECIMAL(10, 2) NOT NULL,
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

/=========================================/
/* Table: tblServiciosPostVenta                                       */
/=========================================/
CREATE TABLE tblServiciosPostVenta (
    idServicio INTEGER NOT NULL,
    fechaServicio TIMESTAMP NOT NULL,
    tipoServicio VARCHAR2(50) NOT NULL,
    costoServicio DECIMAL(10, 2) NOT NULL,
    CONSTRAINT pk_tblServiciosPostVenta PRIMARY KEY (idServicio),
    CONSTRAINT uq_servicioPostVenta UNIQUE(fechaServicio),
    CONSTRAINT ckc_tipoServicio CHECK (tipoServicio IN ('mantenimiento', 'reparacion')),
    CONSTRAINT ckc_costoServicio CHECK (costoServicio >= 0)
);

/=========================================/
/* Table: tblRealizaServicioTecnico                                  */
/=========================================/
CREATE TABLE tblRealizaServicioTecnico (
    idRealizacionServicio INTEGER NOT NULL,   
    idServicio INTEGER NOT NULL,
    idTecnico INTEGER NOT NULL,
    fechaInicioServicio TIMESTAMP NOT NULL,
    fechaFinServicio TIMESTAMP NOT NULL,
    CONSTRAINT pk_tblRealizaServicioTecnico PRIMARY KEY (idRealizacionServicio),
    CONSTRAINT uq_servicioTecnico UNIQUE(idServicio, idTecnico, fechaInicioServicio),
    CONSTRAINT fk_tblRealiza_tecnico_id FOREIGN KEY (idTecnico) REFERENCES tblTecnico(idTecnico),
    CONSTRAINT fk_tblRealiza_servicio_id FOREIGN KEY (idServicio) REFERENCES tblServiciosPostVenta(idServicio)
);

/=========================================/
/* Table: tblInvolucraVentaEjemplar                                  */
/=========================================/
CREATE TABLE tblInvolucraVentaEjemplar (
    idEjemplar INTEGER NOT NULL,
    idVenta INTEGER NOT NULL,
    CONSTRAINT pk_tblInvolucraVentaEjemplar PRIMARY KEY (idEjemplar, idVenta),
    CONSTRAINT fk_tblInvolucraVentaEjemplar_ejemplar_id FOREIGN KEY (idEjemplar) REFERENCES tblEjemplar(idEjemplar),
    CONSTRAINT fk_tblInvolucraVentaEjemplar_venta_id FOREIGN KEY (idVenta) REFERENCES tblVenta(idVenta)
);

/=========================================/
/* Table: tblSe_RealizaServicioPostVenta                         */
/=========================================/
CREATE TABLE tblSe_RealizaServicioPostVenta (
    idServicio INTEGER NOT NULL,
    idVenta INTEGER NOT NULL,
    CONSTRAINT pk_tblSe_RealizaServicioVenta PRIMARY KEY (idServicio, idVenta),
    CONSTRAINT fk_tblSe_Realiza_Servicio FOREIGN KEY (idServicio) REFERENCES tblServiciosPostVenta(idServicio),
    CONSTRAINT fk_tblSe_Realiza_venta FOREIGN KEY (idVenta) REFERENCES tblVenta(idVenta)
);

/=========================================/
/*                  Secuencias para Autogeneración               */
/=========================================/

CREATE SEQUENCE seq_ventas START WITH 1 INCREMENT BY 1;

CREATE SEQUENCE seq_vehiculos START WITH 1  INCREMENT BY 1;

CREATE SEQUENCE seq_ejemplar START WITH 1 INCREMENT BY 1;

CREATE SEQUENCE seq_servicios_postventa START WITH 1 INCREMENT BY 1;

CREATE SEQUENCE seq_servicios_tecnicos START WITH 1 INCREMENT BY 1;

CREATE SEQUENCE seq_usuarios START WITH 2 INCREMENT BY 1;

CREATE SEQUENCE seq_tecnicos START WITH 1 INCREMENT BY 1;

CREATE SEQUENCE seq_vendedores START WITH 1 INCREMENT BY 1;

/=========================================/
/*               PARA REINICIAR LAS SECUENCIAS           */
/=========================================/
ALTER SEQUENCE seq_ventas RESTART;

ALTER SEQUENCE seq_ejemplar RESTART;

ALTER SEQUENCE seq_vehiculos RESTART;

ALTER SEQUENCE seq_servicios_postventa RESTART;

ALTER SEQUENCE seq_servicios_tecnicos RESTART;

ALTER SEQUENCE seq_usuarios RESTART;

ALTER SEQUENCE seq_tecnicos RESTART;

ALTER SEQUENCE seq_vendedores RESTART;

/=========================================/
/*               PARA ELIMINAR LAS SECUENCIAS           */
/=========================================/

DROP SEQUENCE seq_ventas;

DROP SEQUENCE seq_ejemplar;

DROP SEQUENCE seq_servicios_postventa;

DROP SEQUENCE seq_vehiculos;

DROP SEQUENCE seq_servicios_tecnicos;

DROP SEQUENCE seq_usuarios;

DROP SEQUENCE seq_tecnicos;

DROP SEQUENCE seq_vendedores;


/=========================================/
/*               PARA ELIMINAR LAS SECUENCIAS           */
/=========================================/

--------------Creación de roles
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


/=========================================/
/*               PRUEBAS           */
/=========================================/


CONNECT vendedor_usuario/vendedor123;

INSERT INTO USER_PROYECTOBASES.tblVenta (fechaVenta, totalVenta, comisionVenta, idVendedor, cedulaCliente, idEjemplar)
VALUES (TO_TIMESTAMP('2024-05-10 10:00:00', 'YYYY-MM-DD HH24:MI:SS'), 18000.00, 1800, 1, 1, 3);

commit;

CONNECT tecnico_usuario/Tecnico123;

INSERT INTO USER_PROYECTOBASES.tblRealizaServicioTecnico (idServicio, idTecnico, fechaInicioServicio, fechaFinServicio)
VALUES (2, 1, TO_TIMESTAMP('2024-07-01 08:30:00', 'YYYY-MM-DD HH24:MI:SS'), TO_TIMESTAMP('2024-07-01 10:30:00', 'YYYY-MM-DD HH24:MI:SS'));

commit;






