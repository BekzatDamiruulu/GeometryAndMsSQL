
SELECT p.ProductName, c.CategoryName
FROM Test_Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Test_Categories c ON pc.CategoryID = c.CategoryID;