CREATE TABLE Categories (
  id INT PRIMARY KEY,
  name VARCHAR (20)
  );
  GO
CREATE TABLE Products (
  id INT PRIMARY KEY,
  product_id INT,
  name VARCHAR(40),
  category_id INT FOREIGN KEY REFERENCES Categories(id)
);
GO
  
  INSERT INTO Categories VALUES (1, 'music');
  GO
  INSERT INTO Categories VALUES (2, 'software');
  GO
  INSERT INTO Categories VALUES (3, 'clothes');
  GO

  INSERT INTO Products VALUES (1,1, 'FL Studio', 1);
  GO
  INSERT INTO Products VALUES (2,1, 'FL Studio', 2);
  GO
  INSERT INTO Products VALUES (3,2, 'Dawid Bowie - Heroes CD', 1);
  GO
  INSERT INTO Products VALUES (4,3, 'H&M White plain shirt', 3);
  GO
  INSERT INTO Products VALUES (5,4,'Parker Quink Cartridges', null);
  GO
  

SELECT Products.Name, Categories.Name 
FROM Products
LEFT JOIN Categories ON Products.category_id = Categories.id;