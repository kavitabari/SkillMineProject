create table Book(
Book_Id int primary key,
Book_Name varchar(20),
Author_id int ,
Constraint fk_Author Foreign key(Author_id)references Author(Author_id),
Price numeric(10,3),
Published_date date,
)
Create Table Author
(
Author_id int primary key,
Author_Name varchar(30),
Phone_No int,
Email Varchar(20),
Author_Address varchar(20),
City varchar(15)
)
create table Award
(
Award_Id int,
AwardType_id int primary key,
Author_id int ,
Constraint fk_Author Foreign key(Author_id)references Author(Author_id),
Book_Id int,
Constraint fk_Book Foreign key(Book_Id)references Author(Book_Id),
Award_year year
)
create table  Awards(
AwardType_Id int,
Constraint fk_Award Foreign key(AwardType_Id)references Award(AwardType_Id),
Award_Name varchar(30),
Award_price int
)





Book table	– Book id , book name , author id , price , published date
Author table 	– author id , author name , ph no , email , address, city 
Awards table 	– award id , award type id, author id , book id , year 
Awards master table – award type id , award name , award price
