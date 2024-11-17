/=========================================/
/*                                 CRUD                                       */
/=========================================/

/--------------------------------------------------------------/
/* INSERTS DERRAPA ZONE:                                                          */
/-------------------------------------------------------------/

--tblRoles
INSERT INTO tblRol (idRol, nombreRol) VALUES (1, 'ADMIN');
INSERT INTO tblRol (idRol, nombreRol) VALUES (2, 'VENDEDOR');
INSERT INTO tblRol (idRol, nombreRol) VALUES (3, 'TECNICO');

--tblUsuarios
INSERT INTO tblUsuario (idUsuario, nombreUsuario, passwordUsuario, idRol) 
VALUES (1, 'admin', '123456', 1);


--tblProveedor 
INSERT INTO tblProveedor (idProveedor, nombreProveedor, telefonoProveedor, direccionProveedor)
VALUES (1, 'Proveedor Uno', '123456789', 'Calle A #123');

INSERT INTO tblProveedor (idProveedor, nombreProveedor, telefonoProveedor, direccionProveedor)
VALUES (2, 'Proveedor Dos', '987654321', 'Avenida B #456');

--tblVehiculo
INSERT INTO tblVehiculo (idVehiculo, modeloVehiculo, marcaVehiculo, añoVehiculo, precioVehiculo)
VALUES (1, 'Modelo X', 'Marca A', 2024, 25000.00);

INSERT INTO tblVehiculo (idVehiculo, modeloVehiculo, marcaVehiculo, añoVehiculo, precioVehiculo)
VALUES (2, 'Modelo Y', 'Marca B', 2023, 20000.00);

--tblCliente
INSERT INTO tblCliente (cedulaCliente, nombreCliente, apellidoCliente, telefonoCliente, emailCliente, direccionCliente)
VALUES (1, 'Carlos', 'Perez', '111222333', 'carlos.perez@example.com', 'Calle C #789');

INSERT INTO tblCliente (cedulaCliente, nombreCliente, apellidoCliente, telefonoCliente, emailCliente, direccionCliente)
VALUES (2, 'Laura', 'Gomez', '444555666', 'laura.gomez@example.com', 'Calle D #101');

--tblVendedor
INSERT INTO tblVendedor (nombreVendedor, apellidoVendedor, estadoVendedor, salarioVendedor, fechaContratacionVendedor)
VALUES ('Ana', 'Martinez', 'activo', 3000.00, TO_TIMESTAMP('2024-01-01 09:00:00', 'YYYY-MM-DD HH24:MI:SS'));

INSERT INTO tblVendedor (nombreVendedor, apellidoVendedor, estadoVendedor, salarioVendedor, fechaContratacionVendedor)
VALUES ('Juan', 'Rodriguez', 'activo', 3200.00, TO_TIMESTAMP('2024-02-15 10:00:00', 'YYYY-MM-DD HH24:MI:SS'));

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
VALUES (TO_TIMESTAMP('2024-05-10 10:00:00', 'YYYY-MM-DD HH24:MI:SS'), 18000.00, 1800, 1, 1, 1);

INSERT INTO tblVenta (fechaVenta, totalVenta, comisionVenta, idVendedor, cedulaCliente, idEjemplar)
VALUES (TO_TIMESTAMP('2024-06-01 11:00:00', 'YYYY-MM-DD HH24:MI:SS'), 22000.00, 2000, 2, 2, 2);

--tblServiciosPostVenta
INSERT INTO tblServiciosPostVenta (fechaServicio, tipoServicio, costoServicio)
VALUES (TO_TIMESTAMP('2024-07-01 08:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'mantenimiento', 500.00);

INSERT INTO tblServiciosPostVenta (fechaServicio, tipoServicio, costoServicio)
VALUES (TO_TIMESTAMP('2024-07-10 09:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'reparacion', 750.00);


--tblRealizaServicioTecnico
INSERT INTO tblRealizaServicioTecnico (idServicio, idTecnico, fechaInicioServicio, fechaFinServicio)
VALUES (1, 1, TO_TIMESTAMP('2024-07-01 08:30:00', 'YYYY-MM-DD HH24:MI:SS'), TO_TIMESTAMP('2024-07-01 10:30:00', 'YYYY-MM-DD HH24:MI:SS'));

INSERT INTO tblRealizaServicioTecnico (idServicio, idTecnico, fechaInicioServicio, fechaFinServicio)
VALUES (2, 2, TO_TIMESTAMP('2024-07-10 09:30:00', 'YYYY-MM-DD HH24:MI:SS'), TO_TIMESTAMP('2024-07-10 11:30:00', 'YYYY-MM-DD HH24:MI:SS'));

--tblInvolucraVentaEjemplar 
INSERT INTO tblInvolucraVentaEjemplar (idEjemplar, idVenta)
VALUES (1, 1);

INSERT INTO tblInvolucraVentaEjemplar (idEjemplar, idVenta)
VALUES (2, 2);

--tblSe_RealizaServicioPostVenta
INSERT INTO tblSe_RealizaServicioPostVenta (idServicio, idVenta)
VALUES (1, 1);

INSERT INTO tblSe_RealizaServicioPostVenta (idServicio, idVenta)
VALUES (2, 2);


/--------------------------------------------------------------/
/* UPDATES:                                                        */
/-------------------------------------------------------------/

UPDATE tblProveedor
SET direccionProveedor = 'Calle A #456'
WHERE idProveedor = 1;  

UPDATE tblVehiculo
SET precioVehiculo = 24000.00
WHERE idVehiculo = 1;  

UPDATE tblCliente
SET telefonoCliente = '333444555'
WHERE cedulaCliente = 1;  

UPDATE tblTecnico
SET salarioTecnico = 2700.00
WHERE idTecnico = 2; 

UPDATE tblVenta
SET comisionVenta = 1900.00
WHERE idVenta = 1;  

UPDATE tblServiciosPostVenta
SET costoServicio = 600.00
WHERE idServicio = 1; 

UPDATE tblRealizaServicioTecnico
SET fechaFinServicio = TO_TIMESTAMP('2024-07-01 11:30:00', 'YYYY-MM-DD HH24:MI:SS')
WHERE idServicio = 1; 

UPDATE tblInvolucraVentaEjemplar
SET idVenta = 2  
WHERE idEjemplar = 1;  

UPDATE tblSe_RealizaServicioPostVenta
SET idServicio = 2  
WHERE idVenta = 1;  


/--------------------------------------------------------------/
/* DELETES:                                                        */
/-------------------------------------------------------------/

DELETE FROM tblRealizaServicioTecnico WHERE idServicio = 1 AND idTecnico = 1;

DELETE FROM tblSe_RealizaServicioPostVenta WHERE idServicio = 2 AND idVenta = 1;

DELETE FROM tblServiciosPostVenta WHERE idServicio = 1;

DELETE FROM tblVenta WHERE idVenta = 1;

DELETE FROM tblInvolucraVentaEjemplar WHERE idEjemplar = 1 AND idVenta = 2;

DELETE FROM tblEjemplar WHERE idEjemplar = 1;

DELETE FROM tblEjemplar WHERE idEjemplar = 3;

DELETE FROM tblVehiculo WHERE idVehiculo = 1;

DELETE FROM tblProveedor WHERE idProveedor = 1;--

DELETE FROM tblCliente WHERE cedulaCliente = 1;

UPDATE tblVendedor SET estadoVendedor = 'inactivo' WHERE idVendedor = 1;

UPDATE tblTecnico SET estadoTecnico = 'inactivo' WHERE idTecnico = 1;

/--------------------------------------------------------------/
/* SELECT:                                                        */
/-------------------------------------------------------------/

SELECT idProveedor, nombreProveedor, telefonoProveedor, direccionProveedor
FROM tblProveedor
WHERE telefonoProveedor IS NOT NULL
ORDER BY nombreProveedor;


SELECT idVehiculo, modeloVehiculo, marcaVehiculo, añoVehiculo, precioVehiculo
FROM tblVehiculo
WHERE precioVehiculo BETWEEN 20000 AND 30000
AND añoVehiculo >= 2023
ORDER BY añoVehiculo DESC, precioVehiculo;


SELECT cedulaCliente, nombreCliente, apellidoCliente, telefonoCliente, emailCliente
FROM tblCliente
WHERE emailCliente LIKE '%@example.com'
ORDER BY apellidoCliente, nombreCliente;


SELECT idVendedor, nombreVendedor, apellidoVendedor, salarioVendedor, estadoVendedor
FROM tblVendedor
WHERE estadoVendedor = 'activo'
AND salarioVendedor > 3000
ORDER BY salarioVendedor DESC;


SELECT idServicio, fechaServicio, tipoServicio, costoServicio
FROM tblServiciosPostVenta
WHERE tipoServicio = 'reparacion'
AND costoServicio BETWEEN 500 AND 1000
ORDER BY fechaServicio;


SELECT r.idRealizacionServicio, t.nombreTecnico, s.tipoServicio, r.fechaInicioServicio, r.fechaFinServicio
FROM tblRealizaServicioTecnico r
JOIN tblTecnico t ON r.idTecnico = t.idTecnico
JOIN tblServiciosPostVenta s ON r.idServicio = s.idServicio
WHERE r.fechaFinServicio IS NOT NULL
ORDER BY r.fechaInicioServicio DESC;

-----------------------------------------------------------------
 