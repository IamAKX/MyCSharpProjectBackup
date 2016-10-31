create database ADODB

create table studentinfo(
studentid int primary key,
name varchar(300),
course varchar(300))

update studentinfo set studentid=9 where studentid=55

select * from studentinfo