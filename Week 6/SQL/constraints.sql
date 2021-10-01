
create table Test5_dept(
	id int identity,
	[name] varchar(30) constraint test5_not_null not null,
	[location] varchar(20),
	dept_id char(6),
	constraint test5_pk_dept primary key (dept_id),
	constraint test5_unique_name unique (name),
);

insert into Test5_dept values ('Sales and operations','a','s&op01'), ('IT and infratructure','b','it&inf'), ('Business Intelligence','a', 'busitl');

insert into Test5_dept values ('Sales and Operations','b','s&op02')

alter table Test5_dept drop constraint test5_unique_name;

insert into Test5_dept values ('Sales and Operations','b','s&op02')

select * from Test5_dept;
