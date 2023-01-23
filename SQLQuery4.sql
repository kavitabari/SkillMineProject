create table book1(
Bookid int not null primary key,
Bookname varchar(30),
authorid int,
price decimal,
publisheddate date
)


create table Author1(
Authorid int not null Primary key,
Authorname varchar(30),
phno varchar(10),
email varchar(30),
Authoraddress varchar(50),
city varchar(30)
)

create table AwardMaster1(
Awardtypeid int not null primary key,
AwardName varchar(30),
AwardPrize decimal
)
create table Awards1(
Awardid int not null primary key,
Awardtypeid int ,
Authorid int,
Bookid int,
AwardYears varchar(20) 
)
--drop  table AwardMaster1
--alter table Awards1 add constraint pk_awardid primary key (awardid)
alter table Awards1 add constraint fk_Awardtypeid foreign key(Awardtypeid) references AwardMaster1 (Awardtypeid)
alter table Awards1 add constraint fk_bookid foreign key(bookid) references book1 (bookid)
alter table Awards1 add constraint fk_Authorid foreign key(Authorid) references Author1 (Authorid)

select * from book1
select * from Author1
select * from AwardMaster1
select * from Awards1

insert into book1 values (1,'Jungle Book',100,500,'2010-5-12')
insert into book1 values (2,'Mrutynjay',101,400,'2014-4-21')
insert into book1 values (3,'MahaBharat',102,600,'1875-2-20')
insert into book1 values (4,'Ramayan',103,900,'2017-7-5')
insert into book1 values (5,'Agnipankh',104,700,'2020-9-13')

INSERT INTO Author1 VALUES(100, 'Pranit', '9850332330', 'pranit@gmail.com', 'near modern highschool' , 'Ichalkaranji')
INSERT INTO Author1 VALUES(101, 'Arun', '123332330', 'arun@gmail.com', 'near st stand' , 'Nashik')
INSERT INTO Author1 VALUES(102, 'Kavita', '9850334556', 'kavita@gmail.com', 'near dmart' , 'Bhusawal')
INSERT INTO Author1 VALUES(103, 'Mahesh', '123456789', 'mahesh@gmail.com', 'near sfc mall' , 'Kolhapur')
INSERT INTO Author1 VALUES(104, 'Ajay', '789456123', 'ajay@gmail.com', 'near shiroli fata' , 'Shiroli')

insert into AwardMaster1 values(420,'PadmBhushan',50000)
insert into AwardMaster1 values(421,'PadmShree',55000)
insert into AwardMaster1 values(422,'Dadasaheb Falke',600000)
insert into AwardMaster1 values(423,'Arjun',1000000)
insert into AwardMaster1 values(424,'Veer',4500000)