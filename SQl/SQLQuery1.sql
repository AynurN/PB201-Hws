create database DepartamentDB 
create table Departaments(
Id int not null unique identity(1,1),
  Name nvarchar(150) not null,
  MaxEmployeeCount int check (MaxEmployeeCount>=10 and MaxEmployeeCount<=50)

)
create table Positions(
Id int not null unique identity(1,1),
  Name nvarchar(50) not null
)
create table Employees(
Id int not null unique identity(1,1),
Name nvarchar(60) default 'Employee name',
Surname nvarchar(70) default 'Employee Surname',
  Salary decimal(18,2)  check(Salary>=500 and Salary<=12000)
)
select * from Employees
select * from Positions
select * from Departaments

insert into Departaments
values
('Engineering', 40)

insert into  Employees(Salary)
values
(600)
insert into  Employees
values
('Aynur', 'Nazarli', 2000)
insert into  Positions
values
('manager'),
('employee')