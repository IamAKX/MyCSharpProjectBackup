create table student (studentID int primary key, name varchar(300), sem varchar(300))

create table course (courseID int primary key,course varchar(300),duration varchar(300))

create table courseinfo (stuID int foreign key references student(studentID), couID int foreign key references course(courseID))


insert into student(studentID,name,sem) values(1,'Anam','III'),(2,'Akash','II'),(3,'Yash','IV'),(4,'Abdullah','V')

insert into course (courseID,course,duration) values (111,'ASP.NET','2 months'),(222,'JAVA','2.5 months'),(333,'PHP','1 month')

insert into courseinfo(stuID,couID) values (1,111),(1,333),(2,111),(3,333),(2,333),(4,222)

select * from student
select * from course
select * from courseinfo

select s.studentID,s.name,s.sem,c.course,c.duration from student s join courseinfo ci on s.studentID=ci.stuID join course c on ci.couID=c.courseID