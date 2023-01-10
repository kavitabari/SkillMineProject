Create table Dept(
DeptId int Primary key,
DeptName Varchar(20),
DeptSalary numeric(30,2)
)

insert into Dept (DeptId,DeptName,DeptSalary)Values(1,'HR',20000)   
insert into Dept (DeptId,DeptName,DeptSalary)Values(2,'Sales',40000)
insert into Dept (DeptId,DeptName,DeptSalary)Values(3,'Account',60000) 
insert into Dept (DeptId,DeptName,DeptSalary)Values(4,'Teacher',67000) 

select *from Dept
select * from Empolyee1

insert into Empolyee1 (EmpId,EmpName,EmpSalary,EmpAge,EmpDept)Values(1,'HR',20000,24,1)   
insert into Empolyee1 (EmpId,EmpName,EmpSalary,EmpAge,EmpDept)Values(2,'Sales',40000,34,2)
insert into Empolyee1 (EmpId,EmpName,EmpSalary,EmpAge,EmpDept)Values(3,'Account',60000,22,3) 
insert into Empolyee1 (EmpId,EmpName,EmpSalary,EmpAge,EmpDept)Values(4,'Teacher',67000,33,4) 
insert into Empolyee1 (EmpId,EmpName,EmpSalary,EmpAge,EmpDept)Values(5,'Developer',67000,33,5) 

update Empolyee1 set EmpSalary=50000, EmpAge=23 where  empid=4

delete  from  Empolyee1 where EmpId=5

--DQL 

select   EmpName,Empage,Empsalary from Empolyee1

select * from Empolyee1 where EmpId=1

--select * from  Empolyee1 where DeptId=4

select * from Empolyee1 where Empsalary<35000

select * from Empolyee1 where Empsalary>=35000

select * from Empolyee1 where Empage >30
--range
select * from Empolyee1 where Empsalary between 20000 and 50000
