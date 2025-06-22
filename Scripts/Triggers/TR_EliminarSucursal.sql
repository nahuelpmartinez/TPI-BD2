-- Se ejecuta INSTEAD OF DELETE en la tabla Sucursal.
-- Redirige todo el stock de la sucursal que se intenta eliminar
-- al depósito (IDSucursal = 1) antes de proceder con la eliminación.
USE CafeteriaStockDB;
GO
CREATE TRIGGER TR_EliminarSucursal
ON Sucursal
INSTEAD OF DELETE
AS
BEGIN
    --ID del DEPOSITO
    DECLARE @DepositoId INT = 1;

    BEGIN TRY
        -- Verifica que la sucursal a eliminar no sea el propio depósito
        IF EXISTS (SELECT 1 FROM DELETED WHERE IdSucursal = @DepositoId)
        BEGIN
            -- Lanza un error personalizado si se intenta eliminar el depósito
            RAISERROR('No se puede eliminar la sucursal de depósito (ID = 1).', 16, 1);
            RETURN; -- Sale del trigger sin realizar la eliminación
        END
        -- Usa MERGE para actualizar o insertar el stock en el depósito
        -- desde las sucursales que se están eliminando.
        MERGE Stock AS Target
        USING (
            SELECT
                S.IdArticulo,
                S.Cantidad
            FROM
                Stock AS S
            INNER JOIN
                DELETED AS D ON S.IdSucursal = D.IdSucursal
        ) AS Source (IdArticulo, Cantidad)
        ON Target.IdArticulo = Source.IdArticulo AND Target.IdSucursal = @DepositoId
        WHEN MATCHED THEN
            -- Si el artículo ya existe en el stock del depósito, suma las cantidades
            UPDATE SET Target.Cantidad = Target.Cantidad + Source.Cantidad
        WHEN NOT MATCHED BY TARGET THEN
            -- Si el artículo no existe en el stock del depósito, insértalo
            INSERT (IdArticulo, IdSucursal, Cantidad)
            VALUES (Source.IdArticulo, @DepositoId, Source.Cantidad);

        -- Después de transferir el stock, procede a eliminar las sucursales
        -- que originalmente se intentaron borrar.
        DELETE FROM Sucursal
        WHERE IdSucursal IN (SELECT IdSucursal FROM DELETED);

        PRINT 'Operación de eliminación de sucursal completada. Stock transferido al depósito.';

    END TRY
    BEGIN CATCH
        -- Si ocurre un error, re-lanza el error original
        DECLARE @ErrorMessage NVARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT;
        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END;
GO
