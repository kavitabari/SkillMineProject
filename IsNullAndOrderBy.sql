select * from Empolyee1


update Empolyee1 set EmpAge=null where EmpId=4

select * from Empolyee1

select * from Empolyee1 where EmpAge is not null

select * from Empolyee1 where EmpAge is null

select * from Empolyee1 order by EmpName

select * from Empolyee1 order by EmpName desc

select * from Empolyee1 order by EmpSalary desc

select * from Empolyee1 order by EmpSalary,EmpName 


select * from Empolyee1 
order by EmpName
offset 3 rows
fetch next 3 rows only

