select distinct EmpSalary  from Empolyee1 e1 
where 4=(select COUNT(distinct EmpSalary) from Empolyee1 e2
where e1.EmpSalary<=e2.EmpSalary)


select * from Empolyee1

