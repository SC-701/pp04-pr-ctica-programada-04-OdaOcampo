CREATE PROCEDURE ObtenerVehiculo
    @Id UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        V.Id,
        V.IdModelo,
        V.TelefonoPropietairo,
        V.Precio,
        V.CorreoPropietrario,
        V.Anio,
        V.Color,
        V.Placa,
        M.Nombre AS Modelo,
        MA.Nombre AS Marca
    FROM Vehiculo V
    INNER JOIN Modelos M ON V.IdModelo = M.Id
    INNER JOIN Marcas MA ON M.IdMarca = MA.Id
    WHERE V.Id = @Id;
END