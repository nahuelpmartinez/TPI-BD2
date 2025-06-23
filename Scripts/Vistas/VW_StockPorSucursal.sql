USE CafeteriaStockDB
GO
CREATE VIEW VW_StockPorSucursal AS
SELECT 
    s.IdSucursal,
    s.Nombre AS Sucursal,
    a.Codigo AS Código,
    a.Nombre AS Articulo,
    st.Cantidad
FROM Stock st
JOIN Articulo a ON st.IDArticulo = a.IDArticulo
JOIN Sucursal s ON st.IDSucursal = s.IDSucursal
WHERE a.Estado = 1;