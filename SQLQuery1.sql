alter proc useradd1
@fname varchar(50),
@lname varchar(50),
@phone_no numeric(10,0),
@department varchar(50),
@year varchar(50),
@username varchar(50),
@password varchar(50)
as
insert into signup(fname,lname,phone_no,department,year,username,password) values(@fname,@lname,@phone_no,@department,@year,@username,@password);