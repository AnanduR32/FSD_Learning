create table Test8_emp (
	id int identity,
	[name] varchar(5) constraint test8_notNull not null,
	email varchar(5) constraint test8_unique unique,
	mobile numeric(10) constraint test8_mobile check(len(mobile)=10),
	[date] date
)

insert into Test8_emp values 
		('A','a',1234567892, '2021-01-12'), ('B','b',1234567894, '2021-01-19'), ('C','c',1234567893, '2021-01-21'), 
		('D','d',1234567891, '2021-02-04'), ('E','e',1234567895, '2021-02-11'), ('AC','f',1234567893, '2021-02-25'),
		('AV','g',1234567896, '2020-12-10'), ('BW','h',1234567897, '2020-12-12'), ('CE','i',1234567895, '2020-12-18')

select * from Test8_emp where name like '%a%'
select * from Test8_emp where name like 'a_'
select * from Test8_emp where mobile like '123%'
select * from Test8_emp where [date] between '2021-01-21' and '2021-03-21'

drop table Test8_emp;