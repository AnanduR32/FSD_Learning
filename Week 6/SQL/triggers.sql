use TrainingXebia

CREATE TABLE Test14_emp (
  SSN INTEGER PRIMARY KEY,
  Name varchar(255) NOT NULL ,
  LastName varchar(255) NOT NULL ,
  Department INTEGER NOT NULL , 
);

create table Test14_audit (
	id int identity,
	[message] varchar(255) 
);

create or alter trigger Test14_TriggerOnInsert
on Test14_emp 
after insert 
as 
	declare @EmpName varchar(255);
	declare Test12_internalCursorTrigger cursor for select [Name] from inserted
	open Test12_internalCursorTrigger 
	fetch next from Test12_internalCursorTrigger into @EmpName
	while @@FETCH_STATUS = 0
	begin 
		declare @audit_message varchar(255) = 'Inserted record into table employee named ' + CAST(@EmpName as varchar(255)) + ' successfully'
		insert into Test14_audit values (@audit_message);

		fetch next from Test12_internalCursorTrigger into @EmpName
	end 
	close Test12_internalCursorTrigger
	deallocate Test12_internalCursorTrigger
	

select * from Test14_emp
select * from Test14_audit

INSERT INTO Test14_emp (SSN,Name,LastName,Department) VALUES
			('123234877','Michael','Rogers',14), ('152934485','Anand','Manikutty',14), 
			('222364883','Carol','Smith',37), ('326587417','Joe','Stevens',37);

select * from Test14_emp
select * from Test14_audit

truncate table Test14_emp
truncate table Test14_audit