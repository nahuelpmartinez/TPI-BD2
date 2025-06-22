--Este trigger se ejecuta INSTEAD OF DELETE en la tabla Articulo.
--Verifica si el artículo a eliminar tiene stock.
--Si tiene stock, impide la eliminación y emite un mensaje.
--Si no tiene stock, procede con la eliminación del artículo.
USE CafeteriaStockDB;
GO
CREATE TRIGGER TR_EliminarArticulo
ON Articulo
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @IdArticuloAEliminar INT;
    DECLARE @TieneStock BIT;

    SELECT @IdArticuloAEliminar = IdArticulo FROM DELETED;

    BEGIN TRY
        SET @TieneStock = 0;

        -- Verificar si el artículo tiene stock en alguna sucursal (cantidad > 0)
        IF EXISTS (SELECT 1 FROM Stock WHERE IdArticulo = @IdArticuloAEliminar AND Cantidad > 0)
        BEGIN
            SET @TieneStock = 1;
        END

        IF @TieneStock = 1
        BEGIN
            -- Si el artículo tiene stock, impedir la eliminación
            RAISERROR('No se puede eliminar el artículo seleccionado ya que el mismo posee stock activo.', 16, 1);
        END
        ELSE
        BEGIN
            -- Si el artículo NO tiene stock, proceder con la eliminación
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
GO
