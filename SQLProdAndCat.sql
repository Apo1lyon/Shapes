CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Products
VALUES
	(1, '����������� ���'),
	(2, 'ProGit'),
	(3, '����� ������ D&D'),
	(4, '���_������ ����'),
	(5, 'CLR via C#');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Categories
VALUES
	(1, '�����'),
	(2, '�����������'),
	(3, '������');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(2, 1),
	(2, 2),
	(3, 2),
	(4, 1);

SELECT PR."Name", CA."Name"
FROM Products PR
LEFT JOIN ProductCategories PC
	ON PR.Id = PC.ProductId
LEFT JOIN Categories CA
	ON PC.CategoryId = CA.Id;