
--Create user defined function to calculate salary hike by 15 % & display emp salary & new salary 

create function Calculatesalary(@salary int)
returns int
as begin
declare @hikesalary int
set @hikesalary=@salary+(@salary*0.15)
return @hikesalary
end

select
--SELECT EmpName
--       to_char(1.15*salary,'$99,999') AS "Salary"
--FROM Empolyee1;