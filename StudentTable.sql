create table Student
(
rollno int   primary key,
sname Varchar(20),
birth_date date,
course_id int,
Constraint fk_Course Foreign key(Course_id)references Course(Course_id),
batch_id int,
fees_paid int,
Remark varchar(30)
)


create  table Course
(
Course_id int  primary key,
Course_Name Varchar(30),
duration time,
Trainer_id int,
Constraint fk_Trainer Foreign key(Trainer_id)references Trainer(Trainer_id),
totalfees int
)


create table Trainer
(
Trainer_id int primary key,
TrainerName varchar(20),
Join_date date,
Email varchar(20),
years int
)


Student - rollno , sname , degree , birthdate , course id , batch id , fees paid , Remark, is placed
Course – course id , course name, duration (in months), trainer id , total fees
Trainer – Trainer id , trainer name , join date , email , experience in years 