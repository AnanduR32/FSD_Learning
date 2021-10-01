create table Test6_emp(
	id int identity,
	[name] varchar(30) constraint test5_not_null not null,
	age int default 18,
	constraint age_limit check(age>=18) -- constraint checks if age >= 18
);

insert into Test6_emp(name) values ('A');

select * from Test6_emp;

insert into Test6_emp values ('B', 2); --doesn't work

insert into Test6_emp values ('B', 22); -- works since age here is 22 which is > 18

alter table Test6_emp add salary int;

alter table Test6_emp add constraint check_salary check(salary>10000); -- added new constraint to check if salary input is > 10000

update Test6_emp set salary = 1200 where [name] = 'B'; -- doesn't work 

update Test6_emp set salary = 12000 where [name] = 'B'; -- works

drop table Test6_emp