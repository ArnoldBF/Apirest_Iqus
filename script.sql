-- 1. Crear la base de datos
CREATE DATABASE db_iqus;
GO

-- 2. Usar la base de datos
USE db_iqus;
GO

-- 3. Crear la tabla Productos
CREATE TABLE dbo.Productos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    Descripcion NVARCHAR(50)
);
GO

-- 4. Insertar datos ficticios
INSERT INTO dbo.Productos (Nombre, PrecioUnitario, Descripcion)
VALUES
('Mouse', 45.00, 'USB negro'),
('Teclado', 80.00, 'Membrana'),
('Monitor', 750.00, '24 pulgadas'),
('Laptop', 2500.00, '8GB RAM'),
('Tablet', 1200.00, 'Android'),
('Impresora', 900.00, 'Color WiFi'),
('Auriculares', 180.00, 'Bluetooth'),
('Webcam', 310.00, 'HD 720p'),
('Cargador', 65.00, 'USB-C'),
('Cable HDMI', 30.00, '2 metros'),
('USB 32GB', 40.00, 'Kingston'),
('Router', 220.00, 'WiFi 5'),
('Switch', 300.00, '8 puertos'),
('Micrófono', 250.00, 'Condensador'),
('Parlantes', 130.00, '2.0 canales'),
('Silla', 1450.00, 'Ergonómica'),
('Mochila', 290.00, 'Laptop 15"'),
('Cooler', 85.00, 'Para laptop'),
('Soporte', 70.00, 'Aluminio'),
('Joystick', 320.00, 'USB'),
('Smartwatch', 890.00, 'Deportivo'),
('SSD 240GB', 280.00, 'SATA'),
('HDD 1TB', 350.00, 'Externo'),
('Pantalla', 1100.00, 'IPS FHD'),
('Batería', 190.00, 'Portátil'),
('Lector SD', 60.00, 'USB 3.0'),
('Hub USB', 120.00, '4 puertos'),
('Antena WiFi', 140.00, 'USB'),
('Lámpara LED', 90.00, 'Escritorio'),
('Trípode', 100.00, 'Ligero');
GO

-- 5. Consulta de prueba
SELECT TOP (1000) [Id],
       [Nombre],
       [PrecioUnitario],
       [Descripcion]
FROM dbo.Productos;
GO
