create database TestTraining

use TestTraining;

create table Test (
	[name] int,
	detail varchar(50)
);

select * from Test;

SP_RENAME "Test.name", "Username"; 

select * from Test;

insert into Test (Username, detail) values (1,'Anandu'), (2,'Anandu'), (3,'Anandu'), (4,'Anandu'), (5,'Anandu');

update Test set detail = 'aquaregis' where Username = 3;

alter table Test alter column detail varchar(20);

select * from sys.tables

set identity_insert Test on;

drop table Test