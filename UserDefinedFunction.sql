--User Defined Function

create function Addition(@a int,@b int)
returns int
as begin
declare @sum int
set @sum=@a+@b
return @sum
end
select dbo.Addition(77,123) as 'Sum' 

create function GetEmpNameById(@id int)
returns varchar(20)
as begin
return (select EmpName from Employee where empid=@id)
end

select dbo.GetEmpNameById(2) as 'EmpName'

create function GetEmpDetails(@id int)
returns table
as 
return (select * from Employee where EmpId=@id)


select * from dbo.GetEmpDetails(2)

create function GetEmpByDept(@id int)
returns table
as 
return (select * from Employee where deptid=@id)

select * from dbo.GetEmpByDept(4)






