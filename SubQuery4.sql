
create table Product1(
PId int Primary key,
Pname varchar(50),
Pice numeric(10,2)
)

Create table OrderTable
(
Id int ,
Name varchar(50),
SellPrice numeric(10,2 )
)
select * from Product1
select * from OrderTable

insert into OrderTable select Id,Name,SellPrice from OrderTable where Id in
(select PId from Product1 where Pice >1000)

insert into  Product1(PId,Pname,Pice)values(1,'kavita',2000)
insert into  Product1(PId,Pname,Pice)values(2,'Ritesh',2000)
insert into  Product1(PId,Pname,Pice)values(3,' rina',2000)


insert into  Product1(PId,Pname,Pice)values(4,'mina',2000)


insert into  OrderTable(Id,Name,SellPrice)values(1,'kavita',5000)
insert into  OrderTable(Id,Name,SellPrice)values(2,'vina',600000)
insert into  OrderTable(Id,Name,SellPrice)values(3,' tina',27000)
insert into  OrderTable(Id,Name,SellPrice)values(4,'mina',28000)

