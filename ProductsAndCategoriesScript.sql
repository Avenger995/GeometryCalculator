--Пусть есть таблица продуктов с DDL:
CREATE TABLE Products (
	Id INT PRIMARY KEY,
	Name TEXT
);

--Пусть есть таблица категорий с DDL:
CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	Name TEXT
);

--Также есть таблица со связями продуктов и категорий:
CREATE TABLE ProductCategories (
	Id INT PRIMARY KEY,
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id)
);

--Наполняем таблицы:
INSERT INTO Products
VALUES
	(1, 'Сок'),
	(2, 'Колбаса'),
	(3, 'Велосипед');

INSERT INTO Categories
VALUES
	(1, 'Жидкость'),
	(2, 'Сладкое'),
	(3, 'Солёное'),
	(4, 'Замороженное');

INSERT INTO ProductCategories
VALUES
	(1, 1, 1),
	(2, 1, 2),
	(3, 2, 3);

-- Итоговый запрос
SELECT P.Name, C.Name
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;