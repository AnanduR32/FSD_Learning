create table Test9_emp (
	id int identity,
	[name] varchar(5),
	dept varchar(15),
	salary numeric(15)
)

insert into Test9_emp values 
		('A', 'qwerty',2412), ('B', 'qwerty', 554), ('C','ascii',2342), 
		('D','tranquil',632), ('E','polyb',3745), ('AC','ascii',1323),
		('AV','polyb',726), ('BW','polyb',6542), ('CE','ascii',4334)

select dept, count(*) from Test9_emp group by dept;

select dept, count(*) from Test9_emp group by dept having count(*) > 2;

select dept, count(*) from Test9_emp group by dept having Sum(salary) > 5000;

select dept [Department], count(*) [#employees], sum(salary) [Consolidate salary] from Test9_emp group by dept having Sum(salary) <1000 and count(*) < 2;



drop table Test9_emp