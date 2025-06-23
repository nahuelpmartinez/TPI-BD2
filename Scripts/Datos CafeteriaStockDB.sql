USE CafeteriaStockDB;
GO
-- 1. Insertar datos en la tabla Categoria
PRINT 'Insertando datos en Categoria...';
INSERT INTO Categoria (Descripcion, Estado) VALUES
('Bebidas Calientes', 1),
('Bebidas Frias', 1),
('Panaderia', 1),
('Pasteleria', 1),
('Insumos Generales', 1),
('Snacks', 1);
GO
-- 2. Insertar datos en la tabla Marca
PRINT 'Insertando datos en Marca...';
INSERT INTO Marca (Descripcion, Estado) VALUES
('Cafe Supreme', 1),
('Lacteos Frescos', 1),
('Dulce Tentacion', 1),
('Pan Artesanal', 1),
('Global Supplies', 1),
('Agua Pura', 1),
('Snack Delicioso', 1);
GO
-- 3. Insertar datos en la tabla Sucursal
PRINT 'Insertando datos en Sucursal...';
INSERT INTO Sucursal (Nombre, Direccion, Estado) VALUES
('Deposito', 'Av. Siempre Viva 742, Springfield', 1),
('Sucursal Norte', 'Calle Falsa 123, Sector Industrial', 1),
('Sucursal Sur', 'Blvd. de los Sueños Rotos 45, Zona Residencial', 1);
GO
-- 4. Insertar datos en la tabla Articulo
PRINT 'Insertando datos en Articulo...';
INSERT INTO Articulo (Nombre, Codigo, PrecioUnidad, IdMarca, IdCategoria, Estado) VALUES
-- Bebidas Calientes
('Cafe Americano', 'CAFE001', 2.50, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Cafe Supreme'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Bebidas Calientes'), 1),
('Espresso', 'ESP001', 2.00, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Cafe Supreme'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Bebidas Calientes'), 1),
('Latte', 'LATTE001', 3.00, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Cafe Supreme'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Bebidas Calientes'), 1),
('Te Negro', 'TEN001', 2.20, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Global Supplies'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Bebidas Calientes'), 1),
-- Bebidas Frias
('Jugo de Naranja', 'JUGON001', 3.50, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Lacteos Frescos'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Bebidas Frias'), 1),
('Agua Embotellada 500ml', 'AGUA001', 1.50, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Agua Pura'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Bebidas Frias'), 1),
('Gaseosa Cola', 'GASCOLA001', 2.80, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Global Supplies'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Bebidas Frias'), 1),
-- Panaderia
('Croissant Simple', 'CROIS001', 1.80, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Pan Artesanal'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Panaderia'), 1),
('Medialuna de Manteca', 'MEDIAL001', 1.60, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Pan Artesanal'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Panaderia'), 1),
('Pan Integral Rebanado', 'PANINT001', 4.00, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Pan Artesanal'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Panaderia'), 1),
-- Pasteleria
('Muffin de Chocolate', 'MUFFCHOC001', 2.90, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Dulce Tentacion'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Pasteleria'), 1),
('Cheesecake porcion', 'CHEESECAKE001', 4.50, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Dulce Tentacion'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Pasteleria'), 1),
-- Insumos Generales
('Azucar (kg)', 'AZUCAR001', 1.20, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Global Supplies'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Insumos Generales'), 1),
('Leche Entera (Litro)', 'LECHE001', 1.90, (SELECT IdMarca FROM Marca WHERE Marca.Descripcion = 'Lacteos Frescos'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Insumos Generales'), 1),
-- Snacks
('Barra de Cereal', 'BARRAC001', 1.75, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Snack Delicioso'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Snacks'), 1),
('Papas Fritas 50g', 'PAPAS001', 2.10, (SELECT IdMarca FROM Marca WHERE Descripcion = 'Snack Delicioso'), (SELECT IdCategoria FROM Categoria WHERE Descripcion = 'Snacks'), 1);
GO
-- 5. Insertar datos en la tabla Stock
PRINT 'Insertando datos en Stock...';
-- Deposito
INSERT INTO Stock (IdArticulo, IdSucursal, Cantidad) VALUES
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'CAFE001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Deposito'), 150),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'ESP001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Deposito'), 100),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'LATTE001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Deposito'), 120),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'TEN001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Deposito'), 80),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'JUGON001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Deposito'), 70),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'AGUA001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Deposito'), 200),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'CROIS001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Deposito'), 90),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'MUFFCHOC001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Deposito'), 60),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'AZUCAR001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Deposito'), 50),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'LECHE001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Deposito'), 40),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'BARRAC001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Deposito'), 110);
-- Sucursal Norte
INSERT INTO Stock (IdArticulo, IdSucursal, Cantidad) VALUES
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'CAFE001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Norte'), 100),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'LATTE001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Norte'), 80),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'JUGON001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Norte'), 50),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'AGUA001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Norte'), 150),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'MEDIAL001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Norte'), 75),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'CHEESECAKE001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Norte'), 30),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'AZUCAR001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Norte'), 30),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'LECHE001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Norte'), 25),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'PAPAS001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Norte'), 85);
-- Sucursal Sur
INSERT INTO Stock (IdArticulo, IdSucursal, Cantidad) VALUES
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'CAFE001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Sur'), 90),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'ESP001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Sur'), 60),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'TEN001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Sur'), 70),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'GASCOLA001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Sur'), 100),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'PANINT001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Sur'), 40),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'MUFFCHOC001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Sur'), 50),
((SELECT IdArticulo FROM Articulo WHERE Codigo = 'LECHE001'), (SELECT IdSucursal FROM Sucursal WHERE Nombre = 'Sucursal Sur'), 35);
GO
PRINT 'Datos de ejemplo insertados exitosamente en CafeteriaStockDB.';
