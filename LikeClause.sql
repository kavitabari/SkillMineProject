
-- like used to match the string with specific pattern

select * from Empolyee1 where EmpName like 'a%' 
select * from Empolyee1 where EmpName like '%r' 
select * from Empolyee1 where EmpName like '%p%' 

select * from Empolyee1 where EmpName like '%[apr]'
select * from Empolyee1 where EmpName like '[apr]%'

select * from Empolyee1 where EmpName like '[a-h]%' 
select * from Empolyee1 where EmpName like '%[d-r]'

select * from Empolyee1 where EmpName like 'a______'
select * from Empolyee1 where EmpName like '___t'
select * from Empolyee1 where EmpName like '____o_'

-- not like
select * from Empolyee1 where EmpName not like 'a%'
select * from Empolyee1 where EmpName not like '[asr]%'

select * from  Empolyee1

select @@IDENTITY as identityvalue

select @@IDLE as identityvalue

select  SCOPE_IDENTITY()as[SCOPE_IDENTITY]