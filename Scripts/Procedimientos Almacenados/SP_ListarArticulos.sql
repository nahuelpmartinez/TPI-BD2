--Lista todos los artículos con su marca y categoría
USE CafeteriaStockDB;
GO
CREATE PROCEDURE SP_ListarArticulos
AS
BEGIN
    BEGIN TRY
        SELECT
            A.IdArticulo,
            A.Codigo,
            A.Nombre,
            A.PrecioUnidad,
            A.Estado AS EstadoA,
            M.IdMarca,
            M.Descripcion AS DescripcionMarca,
            C.IdCategoria,
            C.Descripcion AS DescripcionCategoria
        FROM
            Articulo AS A
        INNER JOIN
            Marca AS M ON A.IdMarca = M.IdMarca
        INNER JOIN
            Categoria AS C ON A.IdCategoria = C.IdCategoria
        WHERE A.Estado = 1;
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT;
        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
        PRINT 'Error al listar los artículos.';
    END CATCH;
END;
GO
