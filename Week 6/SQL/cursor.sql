CREATE TABLE Test13_emp (
  SSN INTEGER PRIMARY KEY,
  Name varchar(255) NOT NULL ,
  LastName varchar(255) NOT NULL ,
  Department INTEGER NOT NULL , 
);

INSERT INTO Test13_emp (SSN,Name,LastName,Department) VALUES
			('123234877','Michael','Rogers',14), ('152934485','Anand','Manikutty',14), 
			('222364883','Carol','Smith',37), ('326587417','Joe','Stevens',37), 
			('546523478','John','Doe',59), ('332569843','George','ODonnell',77),
			('332154719','Mary-Anne','Foster',14), ('631231482','David','Smith',77),
			('654873219','Zacary','Efron',59), ('745685214','Eric','Goldsmith',59),
			('845657245','Elizabeth','Doe',14), ('845657246','Kumar','Swamy',14);


declare Test13_cursorScroll_EmpAll cursor scroll for select * from Test13_emp

open Test13_cursorScroll_EmpAll

fetch last from Test13_cursorScroll_EmpAll
fetch prior from Test13_cursorScroll_EmpAll
fetch first from Test13_cursorScroll_EmpAll
fetch next from Test13_cursorScroll_EmpAll
fetch absolute 3 from Test13_cursorScroll_EmpAll
fetch relative -2 from Test13_cursorScroll_EmpAll

close Test13_cursorScroll_EmpAll
deallocate Test13_cursorScroll_EmpAll

declare Test13_cursorScroll_EmpRestricted cursor scroll for select [Name], Department from Test13_emp
declare @EmpName varchar(255), @EmpDept integer;
open Test13_cursorScroll_EmpRestricted
fetch last from Test13_cursorScroll_EmpRestricted into @EmpName, @EmpDept;
print 'Employee: ' + Cast(@EmpName as varchar(50)) + ' of Department: ' + Cast(@EmpDept as varchar(10))
close Test13_cursorScroll_EmpRestricted

fetch last from Test13_cursorScroll_EmpRestricted