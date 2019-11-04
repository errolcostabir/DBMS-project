alter proc useradd2
@fname varchar(50),
@lname varchar(50),
@phone_no numeric(10,0),
@department varchar(50),
@username varchar(50),
@password varchar(50)
as
insert into Tsignup(fname,lname,phone_no,department,username,password) values(@fname,@lname,@phone_no,@department,@username,@password);