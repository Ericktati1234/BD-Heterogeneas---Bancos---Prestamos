USE BDHeterogenea;
GO

CREATE PROCEDURE sp_SeleccionarSucursalPorRegion
    @opcion INT
AS
BEGIN
    IF @opcion = 1
    BEGIN
        -- Selección desde región A (linked server Oracle)
        SELECT * FROM OPENQUERY(ORACLE_LINK, 'SELECT * FROM SUCURSAL');
    END
    ELSE IF @opcion = 2
    BEGIN
        -- Selección desde región B (base de datos local SQL Server)
        SELECT * FROM BDHeterogenea_RegionB.dbo.Sucursal;
    END
    ELSE IF @opcion = 3
    BEGIN
        -- Selección desde región C (base de datos replicación en SQL Server)
        SELECT * FROM BDHeterogenea.dbo.Sucursal;
    END
    ELSE
    BEGIN
        PRINT 'Opción inválida. Usa 1, 2 o 3.';
    END
END;
GO