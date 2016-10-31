create database KOLDB

create table studentINFO(
StudentID int,
sname varchar(300),
course varchar(300),
marks int)

select * from studentinfo

--create table student(name varchar(300) not null)  

insert studentINFO values(1,'Ajay','btech',100)
insert studentINFO values(2,'Vijay','btech',100)
insert studentINFO values(3,'Sanjay','btech',100)
insert studentINFO values(4,'Dhananjay','btech',100)
insert studentINFO values(5,'Parajay','btech',100)
insert studentINFO values(6,'Akash','btech',100)
insert studentINFO values(7,'Anam','btech',100)
insert studentINFO values(8,'Bishal','btech',100)
insert studentINFO values(9,'Abdullah','btech',100)
insert studentINFO values(10,'Yash','btech',100)

--Logical Operation

select * from studentINFO where StudentID>=3 and StudentID<=9

select * from studentINFO where StudentID<=3 or StudentID>=9

select * from studentINFO where not (StudentID>=3 and StudentID<=9)

select * from studentINFO where StudentID>=3 and StudentID<=9

update studentINFO set marks=null where StudentID=8


--Range Operation

select * from studentINFO where StudentID between 2 and 9

select * from studentINFO where StudentID not between 2 and 9

--sorting

select * from studentINFO order by marks asc

select * from studentINFO order by marks desc

--pattern search

select * from studentINFO where sname like 'A%'

select * from studentINFO where sname like '%JAY'

select distinct course from studentinf ---remove all repeated entries
--Aggregate

select sum(marks) as 'TOTAL' from studentINFO

select avg(marks) as 'AVERAGE' from studentINFO

select min(marks) as 'MINIMUM' from studentINFO

select max(marks) as 'MAXIMUM' from studentINFO

select count(marks) as 'COUNT' from studentINFO

--Grouping

select course from studentinfo group by course

select course,COUNT(course) from studentinfo group by course

select course,COUNT(course) as 'count' from studentinfo where marks<150 group by course


use KOLDB

create table EmployeeINFO(
EmployeeID int,
name varchar(300),
salary int,
desingnation varchar(300))

select * from EmployeeINFO

insert EmployeeINFO values(1,'Virat',5478,'Designer')
drop table EmployeeINFO

create table EmployeeINFO(
EmployeeID int primary key,
name varchar(300),
salary int,
desingnation varchar(300))

select * from EmployeeINFO
insert EmployeeINFO values(3,'Peter',12500,'Manager')
insert EmployeeINFO values(4,'John',96520,'Chairman')
--insert EmployeeINFO values(null,'John',96520,'Chairman')

--primary- to avoid duplicate value, dosent accept null value
--unique- same as primary.. aap ek hi bar null daal skte ho otherwise null unique ni hoga
--check--(only in Microsoft!!:-))-to restrict a column for particukar set of values-- like gender(M/F) 
--default-to set a column with default value// bina insert kiye hue v automatically ajayga
--foreign-it allows repeated values..primary and foreignkey is use to co relate two table.. primary key colum is related with the common column(foreign key).. ye column whi allow krta h jo primary key m hai


--primary
drop table EmployeeINFO

create table EmployeeINFO(
EmployeeID int primary key,
name varchar(300),
salary int,
desingnation varchar(300))

select * from EmployeeINFO

--unique

drop table EmployeeINFO

create table EmployeeINFO(
EmployeeID int unique,
name varchar(300),
salary int,
desingnation varchar(300))

select * from EmployeeINFO

--check

drop table EmployeeINFO

create table EmployeeINFO(
EmployeeID int primary key,
name varchar(300),
salary int,
nationality varchar(30) check (nationality in ('indian','african')),
desingnation varchar(300))

--create table EmployeeINFO(
--EmployeeID int primary key,
--name varchar(300),
--salary int,
--age int check 18 and 20),
--desingnation varchar(300))


insert EmployeeINFO values(3,'Peter',12500,'indian','Manager')
select * from EmployeeINFO

--default

create table EmployeeINFO(
EmployeeID int primary key,
name varchar(300),
salary int,
age int check (age>=18),
desingnation varchar(30) default 'CEO')

Alter table EmployeeInfo add Quota varchar(300) default 'Genral'
 
insert into EmployeeINFO(EmployeeID,name,salary,age) values(6,'Virat',5478,20),(5,'Vhjfirat',5478,20),(4,'Virat',5478,20)

select * from EmployeeINFO

DROP table EmployeeINFO

--multiple unique is allowed but multiple primary not allowed
--primary and foreignkey is use to co relate two table.. primary key colum is related with the common column(foreign key)


--foreign key
create table stock(productid int primary key,productname varchar(900))
create table product(pid int foreign key references stock(productid) ,pstatus varchar(900))

insert stock values(1,'lux'),(2,'vim'),(3,'deo')
insert product values(2,'sold')

select * from stock
select * from product


--------------------------------Joining two table--------------------------------
drop table studentINFO

create table studentInfo(id int primary key,name varchar(900))

create table fee(studentid int foreign key references studentInfo(id) ,course varchar(900),fee int)

select * from studentInfo
select * from fee


insert studentInfo values(1,'akash')
insert studentInfo values(2,'Buddhuaine')
insert studentInfo values(3,'anam')
insert studentInfo values(4,'buddhu')


insert fee values(1,'btch',5000)
insert fee values(2,'nalla',9999)
insert fee values(3,'phd',5120)
insert fee values(4,'mtech',9856)


---sequential way to insert
--insert fee (studentid,fee,course) values(1,5000,'abc')

--INNER JOIN
select * from studentInfo join fee on studentInfo.id=fee.studentid

--Displaying selected column
select id,name,course,fee from studentInfo join fee on studentInfo.id=fee.studentid

--createing objct of table: Table_name Object_name
select s.id,s.name,f.course,f.fee from studentInfo s join fee f on s.id=f.studentid

