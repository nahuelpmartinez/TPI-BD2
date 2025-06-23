USE CafeteriaStockDB;
GO
CREATE TRIGGER TR_EliminarArticulo
ON Articulo
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @IdArticuloAEliminar INT;
    DECLARE @TieneStockActivo BIT;

    SELECT @IdArticuloAEliminar = IdArticulo FROM DELETED;

    BEGIN TRY
        SET @TieneStockActivo = 0;

        --Verificar si el artículo tiene stock activo (Cantidad > 0)
        IF EXISTS (SELECT 1 FROM Stock WHERE IdArticulo = @IdArticuloAEliminar AND Cantidad > 0)
        BEGIN
            SET @TieneStockActivo = 1;
        END

        IF @TieneStockActivo = 1
        BEGIN
            -- Si el artículo tiene stock activo, impedir la eliminación
            RAISERROR('No se puede eliminar el artículo ya que el mismo posee stock activo.', 16, 1);
        END
        ELSE
        BEGIN
            -- Si el artículo NO tiene stock activo (Cant = 0 o no hay registros),
            -- procedemos a eliminar cualquier registro de ese artículo en la tabla Stock.
            DELETE FROM Stock
            WHERE IdArticulo = @IdArticuloAEliminar;

            --Si ya no hay referencias en Stock, podemos eliminar el artículo de la tabla Articulo.
            DELETE FROM Articulo
            WHERE IdArticulo = @IdArticuloAEliminar;

            PRINT 'Artículo eliminado exitosamente ya que no poseía stock activo.';
        END

    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT;
        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END;

