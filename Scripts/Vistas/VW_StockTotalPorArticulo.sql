USE CafeteriaStockDB
GO
CREATE VIEW VW_StockTotalPorArticulo AS
SELECT
    a.Codigo AS Código,
    a.Nombre AS Articulo,
    SUM(st.Cantidad) AS StockTotal
FROM Articulo a
JOIN Stock st ON a.IDArticulo = st.IDArticulo
WHERE a.Estado = 1
GROUP BY a.Codigo, a.Nombre;