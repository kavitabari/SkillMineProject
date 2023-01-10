create table Empolyee1
(
  EmpId int,
  EmpName varchar(20),
  EmpSalary numeric(20,5),
  EmpAge int
 
)

--add new column in the table
alter table   Empolyee1 add EmpDept varchar(20) 

--rename  the  column in the tabel

sp_help Empolyee1