USE CafeteriaStockDB;
GO 
CREATE PROCEDURE SP_InsertarArticulo
    @Codigo VARCHAR(50),
    @Nombre VARCHAR(150),
    @IdMarca INT,
    @IdCategoria INT,
    @PrecioUnidad DECIMAL(10, 2),
    @Estado BIT = 1
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        INSERT INTO Articulo (Codigo, Nombre, IdMarca, IdCategoria, PrecioUnidad, Estado)
        VALUES (@Codigo, @Nombre, @IdMarca, @IdCategoria, @PrecioUnidad, @Estado);
        COMMIT TRANSACTION;

        SELECT
            A.IdArticulo,
            A.Codigo,
            A.Nombre,
            A.PrecioUnidad,
            A.Estado,
            M.Descripcion AS Marca,
            C.Descripcion AS Categoria
        FROM
            Articulo AS A
        INNER JOIN
            Marca AS M ON A.IdMarca = M.IdMarca
        INNER JOIN
            Categoria AS C ON A.IdCategoria = C.IdCategoria
        WHERE
            A.Codigo = @Codigo;

        PRINT 'Artículo insertado exitosamente.';

    END TRY
    BEGIN CATCH
        -- Si ocurre algún error, se hace ROLLBACK de la transacción
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        -- Muestra información del error
        DECLARE @ErrorMessage NVARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT;
        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);

        PRINT 'Error al insertar el artículo.';
    END CATCH;
END;
GO