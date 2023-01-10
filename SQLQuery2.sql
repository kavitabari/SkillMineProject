SELECT *
FROM Customer
WHERE Country IN
    (SELECT Country
     FROM Customer e
     WHERE Customer.CustomerId <> e.CustomerId);