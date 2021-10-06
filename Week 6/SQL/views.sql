create database TrainingXebia
use TrainingXebia

CREATE TABLE Test12_emp_a (
  SSN INTEGER PRIMARY KEY,
  Name varchar(255) NOT NULL ,
  LastName varchar(255) NOT NULL ,
  Department INTEGER NOT NULL , 
);
CREATE TABLE Test12_emp_b (
  SSN INTEGER PRIMARY KEY,
  Name varchar(255) NOT NULL ,
  LastName varchar(255) NOT NULL ,
  Department INTEGER NOT NULL , 
);

INSERT INTO Test12_emp_a (SSN,Name,LastName,Department) VALUES
			('123234877','Michael','Rogers',14), ('152934485','Anand','Manikutty',14), 
			('222364883','Carol','Smith',37), ('326587417','Joe','Stevens',37), 
			('546523478','John','Doe',59), ('332569843','George','ODonnell',77);

INSERT INTO Test12_emp_b (SSN,Name,LastName,Department) VALUES
			('332154719','Mary-Anne','Foster',14), ('631231482','David','Smith',77),
			('654873219','Zacary','Efron',59), ('745685214','Eric','Goldsmith',59),
			('845657245','Elizabeth','Doe',14), ('845657246','Kumar','Swamy',14);

create or alter view Test12_simpleView_nameDept 
as
	select [name], LastName, Department 
	from Test12_emp_a

select * from Test12_simpleView_nameDept

update Test12_simpleView_nameDept set [name] = 'Jane' where LastName = 'Doe'
select * from Test12_emp_a

select SSN from Test12_emp_a                 -- Can access from main table
select SSN from Test12_simpleView_nameDept	   -- Cannot access from View


-- Complex View 
create or alter view Test12_complexView_nameDept 
as
	select a.Name, a.LastName, a.Department
	from Test12_emp_a a
	union
	select b.Name, b.LastName, b.Department 
	from Test12_emp_b b

select * from Test12_complexView_nameDept

-- DDL commands don't work with complex views
update Test12_complexView_nameDept set [name] = 'Jane' where LastName = 'Doe' and Department = 59 -- Doesn't work

drop table Test12_emp