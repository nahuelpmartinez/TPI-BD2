CREATE TRIGGER TR_EliminarArticulo ON Articulo
INSTEAD OF DELETE
AS
BEGIN
	UPDATE Articulo SET Estado = 0 WHERE IdArticulo IN (SELECT IdArticulo FROM deleted);
END