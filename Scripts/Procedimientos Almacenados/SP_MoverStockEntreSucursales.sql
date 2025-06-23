USE CafeteriaStockDB;
GO
CREATE PROCEDURE SP_MoverStockEntreSucursales
    @IdArticulo INT,
    @IdSucursalOrigen INT,
    @IdSucursalDestino INT,
    @CantidadAMover INT
AS
BEGIN
    BEGIN TRY
        -- Validar que la cantidad a mover sea positiva
        IF @CantidadAMover <= 0
        BEGIN
            RAISERROR('La cantidad a mover debe ser un número positivo.', 16, 1);
            RETURN;
        END

        -- Validar que las sucursales de origen y destino no sean la misma
        IF @IdSucursalOrigen = @IdSucursalDestino
        BEGIN
            RAISERROR('La sucursal de origen y la de destino no pueden ser la misma.', 16, 1);
            RETURN;
        END

        BEGIN TRANSACTION;

        DECLARE @StockActualOrigen INT;

        -- Obtener el stock actual del artículo en la sucursal de origen
        SELECT @StockActualOrigen = Cantidad
        FROM Stock
        WHERE IdArticulo = @IdArticulo AND IdSucursal = @IdSucursalOrigen;

        -- Validar si la sucursal de origen tiene stock para el artículo
        IF @StockActualOrigen IS NULL
        BEGIN
            RAISERROR('No existe stock para el artículo seleccionado en la sucursal de origen.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Validar si la cantidad a mover es mayor que el stock actual en origen
        IF @CantidadAMover > @StockActualOrigen
        BEGIN
            RAISERROR('La sucursal de origen no tiene stock suficiente (%d unidades) para mover. Stock actual: %d.', 16, 1, @CantidadAMover, @StockActualOrigen);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- 1. Reducir el stock en la sucursal de origen
        UPDATE Stock
        SET Cantidad = Cantidad - @CantidadAMover
        WHERE IdArticulo = @IdArticulo AND IdSucursal = @IdSucursalOrigen;

        -- 2. Aumentar el stock en la sucursal de destino (o insertarlo si no existe)
        MERGE Stock AS Target
        USING (SELECT @IdArticulo AS IdArticulo, @IdSucursalDestino AS IdSucursal, @CantidadAMover AS Cantidad) AS Source
        ON Target.IdArticulo = Source.IdArticulo AND Target.IdSucursal = Source.IdSucursal
        WHEN MATCHED THEN
            -- Si el registro existe, actualiza la cantidad sumando el valor
            UPDATE SET Target.Cantidad = Target.Cantidad + Source.Cantidad
        WHEN NOT MATCHED BY TARGET THEN
            -- Si el registro no existe, inserta uno nuevo
            INSERT (IdArticulo, IdSucursal, Cantidad)
            VALUES (Source.IdArticulo, Source.IdSucursal, Source.Cantidad);

        COMMIT TRANSACTION;

        PRINT 'Stock movido exitosamente';

    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        DECLARE @ErrorMessage NVARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT;
        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END;