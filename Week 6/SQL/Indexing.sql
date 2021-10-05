create table Test10_emp(
	id int constraint test10_emp_primary primary key,
	[name] varchar(50),
	salary int,
	age int
);

sp_helpindex Test10_emp

alter table Test10_emp drop constraint test10_emp_primary;

sp_helpindex Test10_emp

create clustered index test10_emp_clusteredIndexing on Test10_emp(id, [name]);

sp_helpindex Test10_emp

drop index Test10_emp.test10_emp_clusteredIndexing

create clustered index test10_emp_clusteredIndexing on Test10_emp(id, [name] desc);

sp_helpindex Test10_emp

create nonclustered index test10_emp_nonclusteredIndexing_sal on Test10_emp(salary)

create nonclustered index test10_emp_nonclusteredIndexing_age on Test10_emp(age)

sp_helpindex Test10_emp

alter table Test10_emp add constraint Test10_emp_constraint_unique unique(age)

sp_helpindex Test10_emp

drop table Test10_emp