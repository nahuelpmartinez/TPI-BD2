USE CafeteriaStockDB;
GO
CREATE PROCEDURE SP_ReducirStock
    @IdArticulo INT,
    @IdSucursal INT,
    @Cantidad INT
AS
BEGIN
    BEGIN TRY
        DECLARE @StockActual INT;

        SELECT @StockActual = Cantidad
        FROM Stock
        WHERE IdArticulo = @IdArticulo AND IdSucursal = @IdSucursal;

        -- Validar si el registro de stock existe
        IF @StockActual IS NULL
        BEGIN
            RAISERROR('No existe stock para el artículo y sucursal especificados.', 16, 1);
            RETURN;
        END

        -- Validar si la cantidad a reducir es mayor que el stock actual
        IF @Cantidad > @StockActual
        BEGIN
            RAISERROR('La cantidad a dar de baja (%d) es mayor que el stock actual (%d).', 16, 1, @Cantidad, @StockActual);
            RETURN;
        END

        -- Restar del stock
        UPDATE Stock
        SET Cantidad = Cantidad - @Cantidad
        WHERE IdArticulo = @IdArticulo AND IdSucursal = @IdSucursal;

        PRINT 'Stock reducido exitosamente.';

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