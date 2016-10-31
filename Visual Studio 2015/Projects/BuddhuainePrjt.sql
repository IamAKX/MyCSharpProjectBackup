create database BuddhuaineProject

use BuddhuaineProject

create table empinfo (empno int primary key, ename varchar(15),hiredate date, job varchar(20), mgr int,sal int,comm int,deptno int)


insert into empinfo values(1,'Anam Saba','15-jun-2017','Software Engineer',4,40000,0,10)
insert into empinfo values(2,'Akash Giri','15-jun-2017','Software Engineer',null,40001,0,10)
insert into empinfo values(3,'Faraz Ahmad','18-jan-2016','Graphic Engineer',null,40001,500,20)
insert into empinfo values(4,'Garry Author','20-aug-2018','Manager',null,99000,500,30)
insert into empinfo values(5,'Mithila Hore','12-sep-2018','Assistant Manager',4,2540,500,40)
insert into empinfo values(6,'James Bond','19-sep-2014','Clerk',null,800,500,50)
insert into empinfo values(7,'Neil Kiln','10-feb-2014','Manager',null,1600,1500,30)
insert into empinfo values(8,'Justin Parker','18-oct-1981','Web Developer',7,20000,1000,60)
insert into empinfo values(9,'Peter Parker','10-feb-1990','Clerk',7,900,200,20)
insert into empinfo values(10,'John Robert','10-jun-1980','Salesman',4,1000,200,30)
insert into empinfo values(11,'Ron Hawkin','10-mar-1992','Analyst',4,10000,300,null)

update empinfo set sal=99999 where ename='Akash Giri'

create table deptinfo (deptno int primary key, dname varchar(15),location varchar(10))

insert into deptinfo values('10','Engineer','Kolkata')
insert into deptinfo values('20','Designer','Dallas')
insert into deptinfo values('30','Administrator','Mumbai')
insert into deptinfo values('40','Administrator','Kolkata')
insert into deptinfo values('50','Management','Dallas')
insert into deptinfo values('70','Banker','Goa')

select * from deptinfo

select * from empinfo


a)	List the employees earns more than any employee in ‘Kolkata’.
	select ename from empinfo where sal = ( select max(sal) from empinfo e, deptinfo d where e.deptno= d.deptno and d.location='Kolkata') 

b)	List the employee who works in the same department as ‘Akash’.		
	select ename from empinfo where deptno = (select deptno from empinfo where ename = 'Akash Giri')

c)	List the name, employee number, their manager name and manager number.
	select e1.ename, e1.empno,e2.ename, e2.empno from empinfo e1,empinfo e2 where e1.mgr=e2.empno

d)	List the name of the employee job is same as ‘Akash Giri’.
	select job from empinfo where ename='Akash Giri'

e)	List the name of employee whose salary is more than  ‘Assistant Manager’.
	select ename from empinfo where sal > (select max(sal) from empinfo where job='Assistant Manager')

f)	List the name of employee who joined after ‘Faraz Ahmad’.
	select ename from empinfo where hiredate>(select hiredate from empinfo where ename='Faraz Ahmad')

g)	Display the name of the dept. whose job is ‘Manager’.
	select distinct d.dname from empinfo e, deptinfo d where e.job = 'Manager' and e.deptno=d.deptno

h)	Display the name of the dept. in which ‘Anam Saba’ works.
	select d.dname from deptinfo d, empinfo e where e.ename='Anam Saba' and e.deptno=d.deptno

i)	Display the dept. whose salary is maximum.
	select d.dname from deptinfo d, empinfo e where d.deptno = e.deptno and sal = (select max(sal) from empinfo)

k)	Display the name of the city in which mamager works.
	select distinct d.location from deptinfo d, empinfo e where e.job='Manager' and e.deptno=d.deptno

l)	Display the grade of the employee named in ‘Anam Saba’
	select e2.ename from empinfo e1,empinfo e2 where e1.mgr=e2.empno and e1.ename='Anam Saba'

m)	List the employees earn more than every employee in ‘DALLAS’.
	select * from empinfo where sal > (select max(e.sal) from empinfo e, deptinfo d where d.location='Dallas' and d.deptno = e.deptno) 
	
n)	Display the name of the department which has no employee.
	select distinct d.dname from deptinfo d, empinfo e where d.deptno NOT EXISTS (select deptno from empinfo)