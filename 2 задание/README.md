# Задание 2

В базе данных MS SQL Server есть продукты и категории.  
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.  
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».  
Если у продукта нет категорий, то его имя все равно должно выводиться.

---

## Решение

### Создаем таблицы данных по условию

```SQL

CREATE TABLE Product (
    PK_ID INT NOT NULL PRIMARY KEY,
    UQ_ProductName NVARCHAR(64) NOT NULL UNIQUE
);

CREATE TABLE Category (
    PK_ID INT NOT NULL PRIMARY KEY,
    UQ_CategoryName NVARCHAR(64) NOT NULL UNIQUE
);

CREATE TABLE ProductCategory (
    FK_ProductID INT NOT NULL FOREIGN KEY REFERENCES Product(PK_ID) ON DELETE CASCADE,
    FK_CategoryID INT NOT NULL FOREIGN KEY REFERENCES Category(PK_ID) ON DELETE CASCADE,
    PRIMARY KEY(FK_ProductID, FK_CategoryID)
);

```

### Вставляем тестовые данные

```SQL

INSERT INTO Product VALUES (1, N'Гиря 16кг'), (2, N'Мяч'), (3, N'Блокнот'), (4, N'Тетрадка'), (5, N'Процессор'), (6, 'Playstation 4'), (7, N'Беговая дорожка')
INSERT INTO Category VALUES (1, N'Спорт'), (2, N'Канцтовары'), (3, N'Техника'), (4, N'Развлечения')
INSERT INTO ProductCategory VALUES (1, 1), (2, 1), (2, 4), (3, 2), (4, 2), (5, 3), (6, 4), (7, 1), (7, 3)

INSERT INTO Product VALUES(8, N'Квадрокоптер') --Проверка случая отсутствия категории у продукта

```

### Пишем запрос

```SQL

SELECT P.UQ_ProductName AS N'Товар', ISNULL(C.UQ_CategoryName, '-') AS N'Категория' FROM Product P
LEFT JOIN ProductCategory CP ON P.PK_ID = CP.FK_ProductID
LEFT JOIN Category C ON CP.FK_CategoryID = C.PK_ID;

```

### Результат

|Товар|Категория|
|---|---|
|Playstation 4|Развлечения|
|Беговая дорожка|Спорт|
|Беговая дорожка|Техника|
|Блокнот|Канцтовары|
|Гиря 16кг|Спорт|
|Квадрокоптер|-|
|Мяч|Спорт|
|Мяч|Развлечения|
|Процессор|Техника|
|Тетрадка|Канцтовары|
