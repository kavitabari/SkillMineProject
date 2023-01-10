--1.	Write a statement that will select the City column from the Customers table
select  City,* from Customer
--2.	Select all the different values from the Country column in the Customers table.
SELECT DISTINCT Country FROM Customer;
--3.	Select all records where the City column has the value "London"
SELECT * FROM Customer WHERE City = 'London'
--4.	Use the NOT keyword to select all records where City is NOT "Berlin".
SELECT * FROM Customer WHERE NOT City = 'Berlin'
--5.	Select all records where the CustomerID column has the value 23.
SELECT * FROM Customer WHERE CustomerID = 23;
--6.	Select all records where the City column has the value 'Berlin' and the PostalCode column has the value 121110.
SELECT * FROM Customer WHERE City = 'Berlin'AND PostCode = 121110;
--7.	Select all records where the City column has the value 'Berlin' or 'London'.
SELECT * FROM Customer WHERE City = 'Berlin'OR City = 'London';
--8.	Select all records from the Customers table, sort the result alphabetically by the column City.
SELECT * FROM Customer ORDER BY City;
--9.	Select all records from the Customers table, sort the result reversed alphabetically by the column City.
SELECT * FROM Customer ORDER BY City DESC;
--10.	Select all records from the Customers table, sort the result alphabetically, first by the column Country, then, by the column City
SELECT * FROM Customer ORDER BY Country, City;
--11.	Select all records from the Customers where the PostalCode column is empty.
SELECT * FROM Customer WHERE PostCode IS NULL;
--12.	Select all records from the Customers where the PostalCode column is NOT empty.
SELECT * FROM Customer WHERE PostCode IS NOT NULL;
--13.	Set the value of the City columns to 'Oslo', but only the ones where the Country column has the value "Norway".
UPDATE Customer SET City = 'Oslo' WHERE Country = 'Norway'  and CustomerId  =4;
--14.	Delete all the records from the Customers table where the Country value is 'Norway'
DELETE FROM Customer WHERE Country = 'Norway'  and CustomerId  =8;
--15.	Use the MIN function to select the record with the smallest value of the Price column.
SELECT MIN(PRICE)FROM Customer;
--16.	Use an SQL function to select the record with the highest value of the Price column.
SELECT MAX(PRICE)FROM Customer;
--17.	Use the correct function to return the number of records that have the Price value set to 20
SELECT COUNT (*)FROM Customer WHERE Price = 20;
--18.	Use an SQL function to calculate the average price of all Customer.
SELECT AVG(PRICE)FROM Customer;
--19.	Use an SQL function to calculate the sum of all the Price column values in the Products table
SELECT SUM(Price)FROM Customer;
--20.	Select all records where the value of the City column starts with the letter "a".
SELECT * FROM Customer WHERE City LIKE 'a%';
--21.	Select all records where the value of the City column ends with the letter "a".
SELECT * FROM Customer WHERE City LIKE '%a';
--22.	Select all records where the value of the City column contains the letter "a".
SELECT * FROM Customer WHERE City LIKE '%a%';
--23.	Select all records where the value of the City column starts with letter "a" and ends with the letter "b".
SELECT * FROM Customer WHERE City LIKE 'a%b';
--24.	Select all records where the value of the City column does NOT start with the letter "a"
select * from Customer where City not  like 'a%'
SELECT * FROM Customer WHERE City NOT LIKE 'a%';
--25.	Select all records where the second letter of the City is an "a".
select * from Customer where City like '_a%'
--26.	Select all records where the first letter of the City is an "a" or a "c" or an "s".
 select * from Customer where City like 'a%' or City like 'c%' or City like 's%' 
--27.	Select all records where the first letter of the City starts with anything from an "a" to an "f".
select * from Customer where City  like '[a-f]%' 
--28.	Select all records where the first letter of the City is NOT an "a" or a "c" or an "f".
select * from Customer where City  not like 'a%' and City  not like 'c%' and City  not like 'f%' 
--29.	Use the IN operator to select all the records where the Country is either "Norway" or "France".
 select * from  Customer where  Country  in('Norway', 'France')
--30.	Use the IN operator to select all the records where Country is NOT "Norway" and NOT "France".
 select * from  Customer where  Country  NOT in('Norway', 'France')
--31.	Use the BETWEEN operator to select all the records where the value of the Price column is between 10 and 20
select * from Customer where Price between 10 and 20
--32.	Use the BETWEEN operator to select all the records where the value of the Price column is NOT between 10 and 20.
select * from Customer where Price  Not between 10 and 20
--33.	Use the BETWEEN operator to select all the records where the value of the ProductName column is alphabetically between 'Geitost' and 'Pavlova'.
SELECT * FROM Customer WHERE CustomerName BETWEEN 'Geitost' AND 'Pavlova';
--34.	When displaying the Customers table, make an ALIAS of the PostalCode column, the column should be called Pno instead.
SELECT CustomerName,City,PostCode AS Pno FROM Customer;
--35.	When displaying the Customers table, refer to the table as Consumers instead of Customers.
SELECT * FROM Customer AS Consumers;
--36.	List the number of customers in each country.
SELECT COUNT(CustomerID),Country FROM Customer  GROUP BY  Country ; 
--37.	List the number of customers in each country, ordered by the country with the most customers first.
 select COUNT(CustomerName) as List,Country from Customer Group by  Country order by COUNT(CustomerName)desc
 SELECT COUNT(CustomerID), Country  FROM Customer GROUP BY Country ORDER BY COUNT(CustomerID) DESC;
--38.	Write the correct SQL statement to create a new database called testDB.
create database testDB
--39.	Write the correct SQL statement to delete a database named testDB
drop database testDB
 --40.	Add a column of type DATE called Birthday in Persons table
  --alter table Person add DOB date
  --select * from Person
  update Customer set DOB=CAST('12-1-2023'as date) where customerId=7
  alter table customer add DOB date
  select * from Customer
   update Customer set DOB=CAST('1-1-2023'as date) where customerId=1

   --41.	Delete the column Birthday from the Persons table
   alter table Customer drop column DOB
     