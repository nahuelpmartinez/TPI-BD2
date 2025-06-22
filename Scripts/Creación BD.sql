CREATE DATABASE CafeteriaStockDB;
GO
USE CafeteriaStockDB;
GO
CREATE TABLE Categoria (
    IdCategoria INT PRIMARY KEY IDENTITY(1,1),
    Descripcion VARCHAR(255) NOT NULL,
    Estado BIT NOT NULL DEFAULT 1
);
GO
CREATE TABLE Marca (
    IdMarca INT PRIMARY KEY IDENTITY(1,1),
    Descripcion VARCHAR(255) NOT NULL,
    Estado BIT NOT NULL DEFAULT 1
);
GO
CREATE TABLE Sucursal (
    IdSucursal INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Direccion VARCHAR(255),
    FechaCreacion DATETIME DEFAULT GETDATE(),
    Estado BIT NOT NULL DEFAULT 1
);
GO
CREATE TABLE Articulo (
    IdArticulo INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(150) NOT NULL,
    Codigo VARCHAR(50) NOT NULL UNIQUE,
    PrecioUnidad DECIMAL(10, 2) NOT NULL,
    IdMarca INT NOT NULL,
    IdCategoria INT NOT NULL,
    Estado BIT NOT NULL DEFAULT 1,
    FOREIGN KEY (IdMarca) REFERENCES Marca(IdMarca),
    FOREIGN KEY (IdCategoria) REFERENCES Categoria(IdCategoria)
);
GO
CREATE TABLE Stock (
    IdArticulo INT NOT NULL,
    IdSucursal INT NOT NULL,
    Cantidad INT NOT NULL,
    PRIMARY KEY (IdArticulo, IdSucursal),
    FOREIGN KEY (IdArticulo) REFERENCES Articulo(IdArticulo),
    FOREIGN KEY (IdSucursal) REFERENCES Sucursal(IdSucursal),
    CONSTRAINT CHK_Stock_Cantidad CHECK (Cantidad >= 0)
);
