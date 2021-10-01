use TestTraining;

create Table Test7_User(
	id int identity,
	[name] varchar(50),
	deptID varchar(50)
)

alter table Test7_User add age int;

insert into Test7_User values ('A','a',2), ('B','a',4), ('C','b',3), ('D','a',1), ('E','c',5), ('AC','c',3),('AV','c',6), ('BW','a',7), ('CE','b',5)

select * from Test7_User;

select top 3 * from Test7_User;

select top 50 percent * from Test7_User;

select top 3 * from Test7_User order by age desc;

select top 1 [name], deptID from Test7_User where age = 5;
