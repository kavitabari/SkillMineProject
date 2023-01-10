select * from Customer
--1.Substrin
select SUBSTRING(CustomerName,2,6)as custname from Customer

--2.Concat


select Concat(CustomerName,'->',Country)as custname from Customer

--3.-Upper
select UPPER(CustomerName) as custname, lower(Country)as Country from Customer
--4.Lower
select Lower(CustomerName) as custname, lower(Country)as Country from Customer
--5.Len
select len(EmpName) as emplength from Empolyee1
---5. TRIM -> remove white space from L & R side , 
-- LTRIM->remove white space from Left side, 
-- RTRIM ->remove white space from Right side
select TRIM(EmpName) from Empolyee1


--6.Reverse
select  REVERSE(CustomerName)as tempname from Customer
--7.Round
select Round(EmpSalary,5) from Empolyee1
select CURRENT_TIMESTAMP
select cast(CURRENT_TIMESTAMP as time)as 'today date'

select CAST(GETDATE()as date)as'current date'

select CAST(GETDate()as date)as'current time'

select customerName,Country from Customer

select CustomerName,ISNULL(Country,'Not Assigned')as 'Country' from  Customer

 --product price  qty  total
 select isnull(price,1000), ISNULL(CustomerName,'NA'), price *(isnull(CustomerName,1))




