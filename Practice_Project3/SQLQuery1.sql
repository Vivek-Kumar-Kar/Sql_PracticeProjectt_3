create database SchoolPP_3
use SchoolPP_3

Create Table StudentsPr4(
Id int primary key not null,
StudentsName nvarchar(50) not null,
Class nvarchar(50) not null,
TotalMarks float not null
);
insert into StudentsPr4 values (1,'Pradeep Sarkar',8,500),(2,'Sumit Kumar',7,470);

Select * from StudentsPr4