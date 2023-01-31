SELECT p.name AS productName, c.name AS category FROM Products AS p
LEFT JOIN ProdCat AS pc ON p.id = pc.products_id
INNER JOIN Products_Categories AS c ON c.id = pc.category_id
ORDER BY product;