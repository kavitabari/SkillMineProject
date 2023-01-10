create table Dep1t(
deptid int primary key,
deptname varchar(10)
)

create table Employee(
empid int primary key,
empname varchar(20) not null,
email varchar(40) unique,
age int check (age>18),
country varchar(20) default 'India',
deptid int foreign key references Dept(deptid)
)

create table emp(
empid int,
empname varchar(30),
constraint pk_employee primary key (empid),
constraint unique_employee unique(mobile),
constraint fk_empdept foreign key (depid) references dept(dpetid),
constraint chk_age check (age>=18),
constraint default_country default 'India'for country
)
