CREATE DATABASE BDHeterogenea;
GO

CREATE DATABASE BDHeterogenea_RegionB;
GO

USE BDHeterogenea;
GO

drop table prestamo
drop table sucursal

CREATE TABLE sucursal
(
    idsucursal INT IDENTITY(1,1) PRIMARY KEY,
    nombresucursal VARCHAR(15),
    ciudadsucursal VARCHAR(15),
    activos INT,
    region VARCHAR(2)
);

CREATE TABLE prestamo
(
    noprestamo INT IDENTITY(1,1) PRIMARY KEY,
    idsucursal INT,
    cantidad INT,
);
GO


USE BDHeterogenea_RegionB;
GO

drop table prestamo
drop table sucursal

CREATE TABLE sucursal
(
    idsucursal INT IDENTITY(1,1) PRIMARY KEY,
    nombresucursal VARCHAR(15),
    ciudadsucursal VARCHAR(15),
    activos INT,
    region VARCHAR(2)
);

CREATE TABLE prestamo
(
    noprestamo INT IDENTITY(1,1) PRIMARY KEY,
    idsucursal INT,
    cantidad INT,
);
GO
