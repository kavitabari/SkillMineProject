select * from  Empolyee1

SELECT EmpName  EmpSalary, DeptId
 FROM Empolyee1
   WHERE EmpSalary < 
      (SELECT AVG(EmpSalary) 
        FROM Empolyee1 )
         AND DeptId = 
               (SELECT DeptId 
                 FROM Empolyee1 
                  WHERE EmpName = 'Sales');

				  select * from Customer
