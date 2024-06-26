create database Library

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

select B.Id, (A.Name+A.Surname) as 'AuthorFullName', B.Name as'BookName', B.SalePrice as 'BookPrice', B.PageCount, T.Name from Books as B
inner join Authors as A
on B.AuthorId=A.Id
inner join BookTags as BT
on B.Id=BT.BookId
inner join Tags as T
on BT.TagId=T.Id