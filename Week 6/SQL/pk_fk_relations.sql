create table Test4_dept(
	id int identity,
	[name] varchar(30),
	[location] varchar(20),
	dept_id char(6),
	constraint pk_dept primary key (dept_id)
);
insert into Test4_dept values ('Sales and operations','a','s&op01'), ('IT and infratructure','b','it&inf'), ('Business Intelligence','a', 'busitl');

create table Test4_emp(
	id int identity,
	[name] varchar(20),
	[location] varchar(20),
	dept_id char(6),
	constraint fk_emp_dept foreign key (dept_id) references Test4_dept(dept_id) on delete cascade
);

insert into Test4_emp values ('Bennet', 'b', 's&op01'), ('Betty','b', 's&op01'), ('Blake','a', 'busitl'), ('Bella','b', 'busitl'), ('Baron','a', 'it&inf');

select * from Test4_dept;
select * from Test4_emp;

delete from Test4_dept where dept_id = 'it&inf' 

select * from Test4_dept;
select * from Test4_emp;

drop table Test4_dept;
drop table Test4_emp;
