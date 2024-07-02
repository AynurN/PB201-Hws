create database Academy_Data
use Academy_Data

create table Academies(
Id int identity primary key,
Name nvarchar(50)
)
create table Groups(
Id int identity primary key,
Name nvarchar(50),
IsDeleted bit,
AcademyId int foreign key references Academies(Id)
)

create table Students(
Id int identity primary key,
Name nvarchar(50),
Surname nvarchar(70),
Age int,
Adulthood bit,
GroupId int foreign key references Groups(Id),
isDeleted bit
)

create table DeletedStudents(
Id int identity primary key,
Name nvarchar(50),
Surname nvarchar(70),
GroupId int
)
create table DeletedGroups(
Id int identity primary key,
Name nvarchar(50),
AcademyId int
)
create view Show_Academies as
select * from Academies
create view Show_Groups as
select * from Groups
create view Show_Students as
select * from Students


create procedure USP_Bring_Group_By_Name @name nvarchar(50)
as
select*from Groups
where Name=@name

create procedure USP_Bring_Students_Older @age int
as
select*from Students
where Age>@age

create procedure USP_Bring_Students_Younger @age int
as
select*from Students
where Age<@age

create trigger TR_Add_DeletedStudents on Students
after delete
as
begin
 insert into DeletedStudents
 select Name, Surname, GroupId from deleted
 update Students
  set isDeleted=1
 where id= (select id from deleted)
end

create trigger TR_Delete_Groupss on Groups
after delete
as
begin
 update Groups
  set isDeleted=1
 where id= (select id from deleted)
end

create trigger TR_Change_Age on Students
after update 
as
begin
 update Students
  set Adulthood= case when Age>=18 then 1 else 0 end
  where  id= (select id from inserted)
end

create trigger TR_Check_Before_Insert on Students
after insert
as
begin 
  update Students
  set Adulthood= case when Age>=18 then 1 else 0 end
  where  id= (select id from inserted)
end

create function UF_Get_Students_By_GroupSpecTable(@id int)
returns @SpecTable table
(
studentID int,
FullName nvarchar(120),
Age int,
Adulthood bit,
GroupId int,
isDeleted bit
)
as 
begin 
insert into @SpecTable
select Id, (Name+' '+Surname), Age, Adulthood,GroupId, isDeleted from Students
where GroupId=@id
return 
end


create function UF_Get_Groups_By_AcademySpecTable(@id int)
returns @SpecTable table
(GroupId int ,
GroupName nvarchar(50),
IsDeleted bit,
AcademyId int
)
as 
begin 
insert into @SpecTable
select Id, Name, isDeleted,AcademyId from Groups
where AcademyId=@id
return 
end