--� ���� ������ MS SQL Server ���� �������� � ���������. 
--������ �������� ����� ��������������� ����� ���������, � ����� ��������� ����� ���� ����� ���������. 
--�������� SQL ������ ��� ������ ���� ��� ���� �������� � ��� ���������.
--���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.
--�� ����������� � �������� ����� ����� � ����� �� ������� �������.


CREATE TABLE #Product
(
    Id BIGINT IDENTITY NOT NULL PRIMARY KEY,
    Name NVARCHAR(100),
	CategoryId BIGINT
)
INSERT #Product 
VALUES ('����� ����', '1'), ('������', '1'), ('�����', '2'), ('����', '2'), ('��� ����� �����������', NULL)

CREATE TABLE #Category
(
    Id BIGINT IDENTITY NOT NULL PRIMARY KEY,
    Name NVARCHAR(100)
)
INSERT #Category
VALUES ('����'), ('��������')

SELECT p.Name, c.Name 
  FROM #Product p (NOLOCK) 
    LEFT JOIN #Category c (NOLOCK) 
    ON p.CategoryId = c.Id

DROP TABLE #Category, #Product