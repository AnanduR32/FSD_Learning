create table Test10_emp (
	id int identity,
	[name] varchar(5),
	dept varchar(15),
	salary numeric(15)
);
create table Test10_dept(
	id int identity,
	[name] varchar(15),
	[location] varchar(15)
);


insert into Test10_emp values 
		('A', 'qwerty',2412), ('B', 'qwerty', 554), ('C','ascii',2342), 
		('D','tranquil',632), ('E','polyb',3745), ('AC','ascii',1323),
		('AV','polyb',726), ('BW','polyb',6542), ('CE','ascii',4334),
		('GG', 'yale', 2123)

insert into Test10_dept values ('qwerty','holland'), ('ascii','pestos'), ('tranquil','kaneriah'), ('polyb','istanbul'), ('pique', 'morocco')

select * from Test10_emp
inner join Test10_dept
on Test10_emp.dept = Test10_dept.[name]

select * from Test10_emp
left join Test10_dept
on Test10_emp.dept = Test10_dept.[name]

select * from Test10_emp
right join Test10_dept
on Test10_emp.dept = Test10_dept.[name]

select * from Test10_emp
full join Test10_dept
on Test10_emp.dept = Test10_dept.[name]


select Test10_emp.id, Test10_emp.[name], Test10_emp.dept, Test10_emp.salary  from Test10_emp
inner join (select [name], [location] from Test10_dept) as dept_tab
on Test10_emp.dept = dept_tab.[name]


drop table Test10_emp
drop table Test10_dept