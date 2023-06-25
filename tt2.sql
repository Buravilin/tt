--В базе данных MS SQL Server есть продукты и категории. 
--Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
--Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
--Если у продукта нет категорий, то его имя все равно должно выводиться.
--По возможности — положите ответ рядом с кодом из первого вопроса.


CREATE TABLE #Product
(
    Id BIGINT IDENTITY NOT NULL PRIMARY KEY,
    Name NVARCHAR(100),
	CategoryId BIGINT
)
INSERT #Product 
VALUES ('Белый хлеб', '1'), ('Ржаной', '1'), ('Водка', '2'), ('Пиво', '2'), ('Под конец корпоратива', NULL)

CREATE TABLE #Category
(
    Id BIGINT IDENTITY NOT NULL PRIMARY KEY,
    Name NVARCHAR(100)
)
INSERT #Category
VALUES ('Хлеб'), ('Алкоголь')

SELECT p.Name, c.Name 
  FROM #Product p (NOLOCK) 
    LEFT JOIN #Category c (NOLOCK) 
    ON p.CategoryId = c.Id

DROP TABLE #Category, #Product