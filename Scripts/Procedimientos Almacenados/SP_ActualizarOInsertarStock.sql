USE CafeteriaStockDB;
GO
CREATE PROCEDURE SP_ActualizarOInsertarStock
    @IdArticulo INT,
    @IdSucursal INT,
    @Cantidad INT
AS
BEGIN
    BEGIN TRY
        MERGE Stock AS Target
        USING (SELECT @IdArticulo AS IdArticulo, @IdSucursal AS IdSucursal, @Cantidad AS Cantidad) AS Source
        ON Target.IdArticulo = Source.IdArticulo AND Target.IdSucursal = Source.IdSucursal
        WHEN MATCHED THEN
            -- Si el registro existe, actualiza la cantidad sumando el valor
            UPDATE SET Target.Cantidad = Target.Cantidad + Source.Cantidad
        WHEN NOT MATCHED BY TARGET THEN
            -- Si el registro no existe, inserta uno nuevo
            INSERT (IdArticulo, IdSucursal, Cantidad)
            VALUES (Source.IdArticulo, Source.IdSucursal, Source.Cantidad);

        PRINT 'Operación de stock (actualizar o insertar) completada exitosamente.';

    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT;
        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
        PRINT 'Error al realizar la operación de stock.';
    END CATCH;
END;