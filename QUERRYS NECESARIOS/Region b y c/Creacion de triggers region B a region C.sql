USE BDHeterogenea_RegionB;
GO

CREATE OR ALTER TRIGGER trg_ReplicarSucursal
ON dbo.sucursal
AFTER INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar sucursales nuevas en BDHeterogenea (sin idsucursal)
    INSERT INTO BDHeterogenea.dbo.sucursal (nombresucursal, ciudadsucursal, activos, region)
    SELECT nombresucursal, ciudadsucursal, activos, region
    FROM inserted;
END;
GO

CREATE OR ALTER TRIGGER trg_ReplicarPrestamo
ON dbo.prestamo
AFTER INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar préstamos nuevos en BDHeterogenea (sin noprestamo)
    INSERT INTO BDHeterogenea.dbo.prestamo (idsucursal, cantidad)
    SELECT idsucursal, cantidad
    FROM inserted;
END;
GO
