create table Test3_a(
	id int identity,
	[name] varchar(20),
	[location] varchar(20)
);

create table Test3_b(
	id int identity,
	[name] varchar(20),
	[location] varchar(20)
);

insert into Test3_a values ('Andrews','a'), ('Aldric','a'), ('Abbey','a');
insert into Test3_b values ('Bennet', 'b'), ('Betty','b'), ('Blake','b');

(select * from Test3_a 
where location = 'a'
union 
select * from Test3_b
where location = 'b')
order by location desc;
