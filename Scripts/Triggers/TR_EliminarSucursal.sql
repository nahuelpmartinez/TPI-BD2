USE CafeteriaStockDB;
GO
CREATE TRIGGER TR_EliminarSucursal
ON Sucursal
INSTEAD OF DELETE
AS
BEGIN
    -- ID del DEPOSITO
    DECLARE @DepositoId INT = 1;
    DECLARE @IdSucursalAEliminar INT = (SELECT IdSucursal FROM DELETED);

    BEGIN TRY
        -- Validar que la sucursal a eliminar no sea el propio depósito
        IF @IdSucursalAEliminar = @DepositoId
        BEGIN
            RAISERROR('No se puede eliminar la sucursal de depósito (ID = 1).', 16, 1);
            RETURN;
        END

        --Mover el stock de la sucursal que se va a eliminar al depósito
        MERGE Stock AS Target
        USING (
            SELECT S.IdArticulo, S.Cantidad
            FROM Stock AS S
            WHERE S.IdSucursal = @IdSucursalAEliminar
        ) AS Source (IdArticulo, Cantidad)
        ON Target.IdArticulo = Source.IdArticulo AND Target.IdSucursal = @DepositoId
        WHEN MATCHED THEN
            UPDATE SET Target.Cantidad = Target.Cantidad + Source.Cantidad
        WHEN NOT MATCHED BY TARGET THEN
            INSERT (IdArticulo, IdSucursal, Cantidad)
            VALUES (Source.IdArticulo, @DepositoId, Source.Cantidad);

        --Eliminar el stock de la sucursal que se va a eliminar
        DELETE FROM Stock
        WHERE IdSucursal = @IdSucursalAEliminar;

        --Después de transferir y limpiar el stock, eliminar la sucursal
        DELETE FROM Sucursal
        WHERE IdSucursal = @IdSucursalAEliminar;

        PRINT 'Operación de eliminación de sucursal completada. Stock transferido al depósito.';

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