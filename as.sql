create table department
(
DepartmentId int primary key identity(1,1),
specilaztion varchar(40),
);
insert into department(specilaztion) values ('cs')
create table student
(
id int primary key identity(1,1) ,
names nvarchar(40)not null,
passwordd nvarchar(40) not null,
Email nvarchar(40) unique,
addresss nvarchar(30),
age int,
depId int ,
foreign key (depId)REFERENCES department(DepartmentId),
);
insert into student(names,passwordd,addresss,age,Email,depId) values ('saif','345','cairo',17,'saif@',1)

                        
SELECT student.id,student.names,student.addresss,department.specilaztion
FROM student
INNER JOIN department
ON student.depId =
department.DepartmentId; 

