-- stored procedures 

select * from Test10_emp

create procedure GetEmployeeNames
as 
begin
	select distinct [name] as name from Test10_emp
end

exec GetEmployeeNames

create procedure GetEmployeeByDept
@dept varchar(50)
as 
begin
	select id, [name], salary from Test10_emp where dept = @dept
end

exec GetEmployeeByDept @dept = 'qwerty'


create procedure GetEmployeeInIDRange
@start int,
@end int
as 
begin
	select [name], dept, salary 
	from Test10_emp 
	where id between @start and @end;
end

exec GetEmployeeInIDRange @start = 2, @end = 5

sp_helptext GetEmployeeInIDRange
sp_help GetEmployeeInIDRange

create or alter procedure GetEmployeeInIDRange
@start int,
@end int
as 
begin
	select id, [name], dept, salary 
	from Test10_emp 
	where id between @start and @end;
end

exec GetEmployeeInIDRange @start = 4, @end = 5

-- Encryption
----- disables sp_helptext alone, on the procedure

create or alter procedure GetEmployeeInIDRange
@start int,
@end int
with encryption
as 
begin
	select id, [name], dept, salary 
	from Test10_emp 
	where id between @start and @end;
end

exec GetEmployeeInIDRange @start = 4, @end = 5

sp_help GetEmployeeInIDRange