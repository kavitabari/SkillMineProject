
create table Customer
(
CustomerId int PRIMARY KEY ,
CustomerName Varchar(20),
City Varchar(20),
Country Varchar(20),
PostCode int,
PinCode int,
Price numeric(30,2)
)
alter table customer add DOB date

select * from Customer

--update  Customer set Country='France'where  CustomerId=6
 --update  Customer set City='France'where  CustomerId=10


 --update  Customer set City='Chinchwad'where  CustomerId=6
 -- update  Customer set City='Sahada'where  CustomerId=7
INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (1, 'Ramesh', 'London', 'Norway',23456,101 ,10.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (2, 'Khilan', 'Berlin', 'Delhi',234565,102, 1500.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (3, 'kaushik',' London', 'Kota',456678,103, 50.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (4, 'Chaitali', 'Berlin', 'Norway',3456234,123, 500.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (5, 'Hardik', 'London', 'Bhopal', 1233456,105,600.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (6, 'Komal', 'London', 'MP',345213,106, 106.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (7, 'Muffy', 'Berlin', 'Norway',3456234,107, 20.00 );

------------------------------------------------------------------


INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (8, 'Ritesh', 'London', 'Norway',456324,108 ,10.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (9, 'Priya', 'Berlin', 'Delhi',111111,102, 20.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (10, 'Bina',' London', 'Kota',567889,110, 50.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (11, 'Rina', 'Berlin', 'Norway',123321,109, 20.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (12, 'Kavita', 'Ahmdabad', 'Gujart', 456765,111,40.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (13, 'Komal', 'Pune', 'Mahashtra',23456,112, 50.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (14, 'Tina', 'Pune', 'Mahashtra',234567,107, 20.00 );


------------------------------------------------------------------


INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (15, 'Ritesh', 'London', 'Norway',23456,108 ,10.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (16, 'Suchita', 'Berlin', 'Delhi',567435,102, 90.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (17, 'Vaibhav',' London', 'Kota',234456,115, 100.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (18, 'Rina', 'Berlin', 'Norway',2344567,114, 20.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (19, 'Kavita', 'Ahmdabad', 'Gujart', 123345,111,40.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (20, 'Dinesh', 'Pune', 'Mahashtra',234444,112, 50.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (21, 'Sayali', 'Pune', 'Mahashtra',12345,113, 20.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (22, 'Sayali', 'Vapi', 'Gujart',12345,113, 500.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (23, 'Ritesh', 'London', 'Norway',23456,108 ,10.00 );

INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (24, 'Suchita', 'Berlin', 'Delhi',567435,102, 90.00 );


INSERT INTO Customer (CustomerId,CustomerName,City,Country,PostCode,PinCode,Price)
VALUES (25, 'Suchita', 'Berlin', 'France',567435,102, 90.00 );