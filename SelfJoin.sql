select * from  Empolyee1
alter table Empolyee1 add MangerId  int --addcolumn 
update  Empolyee1 set MangerId =1 where EmpId in (1,2,3)

select emp.EmpName as 'Empolyee1' man.EmpName as 'Manger'

