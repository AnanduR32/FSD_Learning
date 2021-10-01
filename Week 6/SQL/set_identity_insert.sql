create table Test2 (
	[Username] int identity,
	detail varchar(50)
);

insert into Test2 (detail) values ('Anandu'), ('aqua'), ('regis');

delete from Test2 where Username = 3

select * from Test2;

set identity_insert Test2 on;

insert into Test2 (Username, detail) values (3, 'regis'),(4,'32');

select * from Test2;

set identity_insert Test2 off;

insert into Test2 values ('R');

select * from Test2;
