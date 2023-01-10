---Create database
use SkillMine
create database  empolyee

CREATE TABLE Employeee(
    EmpId integer, 
    FirstName varchar(20), 
    LastName varchar(20), 
    Email varchar(25), 
    PhoneNo varchar(25), 
    Salary integer
);

CREATE TABLE Employee11(
    EmpId integer PRIMARY KEY, 
    FirstName varchar(20), 
    LastName varchar(20), 
    Email varchar(25), 
    PhoneNo varchar(25), 
    Salary integer
);

--Create a Copy of a Table with Data

CREATE TABLE Employee_Backup as select * FROM Employeee