create database Library2

create table Authors(
 Id int not null identity primary key,
 Name nvarchar(100),
 Surname nvarchar(100) 
)

create table Books(
 Id  int not null identity Primary Key,
  Name nvarchar(100),
 AuthorId int foreign key references Authors(Id),
  PageCount int not null,
 CostPrice decimal(4, 2),
 SalePrice decimal(4,2) 

)
create table Tags(
 Id int identity  primary key,
 Name nvarchar(100) not null
)
create table BookTags(
Id int identity primary key,
BookId int foreign key references Books(Id),
TagId int foreign key references Tags(Id)
)
select * from Authors
select * from Books
select * from Tags
select * from BookTags


insert into Authors
values
('Jack', 'London'),
('Louisa', 'May'),
('George', 'Orwel')

insert into Books
values
('Little Woman', 2, 150,15,20),
('1984',3,300,20,30),
('Martin Eden',1,200,16,20),
('Animal farm',3, 100, 10,13)

insert into Tags
values
('Bestseller'),
('Featured'),
('New')
insert into BookTags
values
(1,1),
(2,1),
(2,2),
(3,1),
(3,2),
(4,1)

create view Book_Information as 
select B.Id, B.Name, B.PageCount, (A.Name+' '+A.Surname) as 'AuthorFullName' from Books as B
join Authors as A
on A.Id=B.AuthorId
 
 create procedure SP_Find_Book_By_Name_Or_AuthorName @name nvarchar(100) 
 as
 select B.Id, B.Name, B.PageCount, (A.Name+' '+A.Surname) as 'AuthorFullName' from Books as B
join Authors as A
on A.Id=B.AuthorId
where @name=B.Name or @name=A.Name

exec SP_Find_Book_By_Name_Or_AuthorName 'Martin Eden'

create view Author_Information as
select A.Id, (A.Name+' '+A.Surname) as 'FullName', COUNT(*) as 'Book Count', Max(B.PageCount) as'MaxPageCount'  from Authors as A
join Books as B
on B.AuthorId=A.Id
group by A.Id, A.Name, A.Surname

