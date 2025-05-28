USE BDHeterogenea;
GO

CREATE PROCEDURE sp_SeleccionarSucursalPorRegion
    @opcion INT
AS
BEGIN
    IF @opcion = 1
    BEGIN
        -- Selecci�n desde regi�n A (linked server Oracle)
        SELECT * FROM OPENQUERY(ORACLE_LINK, 'SELECT * FROM SUCURSAL');
    END
    ELSE IF @opcion = 2
    BEGIN
        -- Selecci�n desde regi�n B (base de datos local SQL Server)
        SELECT * FROM BDHeterogenea_RegionB.dbo.Sucursal;
    END
    ELSE IF @opcion = 3
    BEGIN
        -- Selecci�n desde regi�n C (base de datos replicaci�n en SQL Server)
        SELECT * FROM BDHeterogenea.dbo.Sucursal;
    END
    ELSE
    BEGIN
        PRINT 'Opci�n inv�lida. Usa 1, 2 o 3.';
    END
END;
GO