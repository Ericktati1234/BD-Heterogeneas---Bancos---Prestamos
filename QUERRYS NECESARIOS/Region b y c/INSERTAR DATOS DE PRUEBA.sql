USE BDHeterogenea

EXEC sp_InsertarPrestamo 12, 1,  10000;

EXEC sp_InsertarSucursal 11, 'Centro',      'Monterrey',   1500000, 'A';
EXEC sp_InsertarSucursal 2, 'Norte',       'Saltillo',     800000, 'A';
EXEC sp_InsertarSucursal 3, 'Sur',         'Veracruz',    1200000, 'A';
EXEC sp_InsertarSucursal 4, 'Este',        'Tampico',      950000, 'A';
EXEC sp_InsertarSucursal 5, 'Oeste',       'Hermosillo',  1100000, 'A';
EXEC sp_InsertarSucursal 6, 'Altos',       'Guadalajara', 1400000, 'A';
EXEC sp_InsertarSucursal 7, 'Pacifico',    'Mazatlán',     750000, 'A';
EXEC sp_InsertarSucursal 8, 'Laguna',      'Torreón',      920000, 'A';
EXEC sp_InsertarSucursal 9, 'Bajio',       'León',        1350000, 'A';
EXEC sp_InsertarSucursal 10, 'CentroSur',  'Cuernavaca',   980000, 'A';

EXEC sp_InsertarPrestamo 11, 1,  10000;
EXEC sp_InsertarPrestamo 2, 2,   5000;
EXEC sp_InsertarPrestamo 3, 3,  15000;
EXEC sp_InsertarPrestamo 4, 4,   8000;
EXEC sp_InsertarPrestamo 5, 5,  12000;
EXEC sp_InsertarPrestamo 6, 6,   3000;
EXEC sp_InsertarPrestamo 7, 7,  20000;
EXEC sp_InsertarPrestamo 8, 8,  18000;
EXEC sp_InsertarPrestamo 9, 9,   6000;
EXEC sp_InsertarPrestamo 10, 10, 25000;
GO

USE BDHeterogenea_RegionB;
GO

INSERT INTO Sucursal VALUES ( 'Noroeste',  'Tijuana',     1600000, 'B');
INSERT INTO Sucursal VALUES ( 'SurEste',   'Cancún',      1450000, 'B');
INSERT INTO Sucursal VALUES ( 'CentroNte', 'San Luis',    1250000, 'B');
INSERT INTO Sucursal VALUES ( 'Sierra',    'Chihuahua',    900000, 'B');
INSERT INTO Sucursal VALUES ( 'Mixteca',   'Oaxaca',       700000, 'B');

INSERT INTO Prestamo VALUES ( 11, 13000);
INSERT INTO Prestamo VALUES ( 12, 17000);
INSERT INTO Prestamo VALUES ( 13, 11000);
INSERT INTO Prestamo VALUES ( 14,  9500);
INSERT INTO Prestamo VALUES ( 15, 10500);
