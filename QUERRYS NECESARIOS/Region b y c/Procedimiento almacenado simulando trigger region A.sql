use BDHeterogenea;
go

--Procedimiento almacenado para insertar sucursales en ambas bases de datos (simulando un trigger)

CREATE PROCEDURE sp_InsertarSucursal
    @idsucursal       VARCHAR(5),
    @nombresucursal   VARCHAR(15),
    @ciudadsucursal   VARCHAR(15),
    @activos          NUMERIC,
    @region           VARCHAR(2)
AS
BEGIN
    DECLARE @sqlOracle NVARCHAR(MAX);
    SET @sqlOracle = '
        INSERT INTO Sucursal (idsucursal, nombresucursal, ciudadsucursal, activos, region)
        VALUES (''' + @idsucursal + ''', ''' + @nombresucursal + ''', ''' + @ciudadsucursal + ''', ' 
        + CONVERT(VARCHAR(20), @activos) + ', ''' + @region + ''')';

    EXEC (@sqlOracle) AT ORACLE_LINK;

    INSERT INTO Sucursal ( nombresucursal, ciudadsucursal, activos, region)
    VALUES ( @nombresucursal, @ciudadsucursal, @activos, @region);
END;
GO

--Procedimiento almacenado para insertar Prestamos en ambas bases de datos (simulando un trigger)


CREATE PROCEDURE sp_InsertarPrestamo
    @noprestamo   VARCHAR(15),
    @idsucursal   VARCHAR(5),
    @cantidad     NUMERIC
AS
BEGIN
    DECLARE @sqlOracle NVARCHAR(MAX);
    SET @sqlOracle = '
        INSERT INTO Prestamo (noprestamo, idsucursal, cantidad)
        VALUES (''' + @noprestamo + ''', ''' + @idsucursal + ''', ' + CONVERT(VARCHAR(20), @cantidad) + ')';

    EXEC (@sqlOracle) AT ORACLE_LINK;

    INSERT INTO Prestamo (noprestamo, idsucursal, cantidad)
    VALUES (@noprestamo, @idsucursal, @cantidad);
END;
GO

--Procedimiento almacenado para Eliminar sucursales en ambas bases de datos (simulando un trigger)


CREATE PROCEDURE sp_EliminarSucursal
    @idsucursal VARCHAR(5)
AS
BEGIN
    EXEC ('DELETE FROM Sucursal WHERE idsucursal = ''' + @idsucursal + '''') AT ORACLE_LINK;

    DELETE FROM Sucursal WHERE idsucursal = @idsucursal;
END;
GO

--Procedimiento almacenado para eliminar prestamos en ambas bases de datos (simulando un trigger)


CREATE PROCEDURE sp_EliminarPrestamo
    @noprestamo VARCHAR(15)
AS
BEGIN
    EXEC ('DELETE FROM Prestamo WHERE noprestamo = ''' + @noprestamo + '''') AT ORACLE_LINK;

    DELETE FROM Prestamo WHERE noprestamo = @noprestamo;
END;
GO