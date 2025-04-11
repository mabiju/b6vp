-- to create a database object
create database db_college;

-- to create a database table
use db_college;
create table tbl_students
(
	roll int primary key identity(1,1),
	sname varchar(50) not null,
	saddress varchar(50) not null,
	sage int not null,
	sdob date not null
);

-- to insert data into the database table : Method 1
use db_college;
insert into tbl_students (sname, saddress, sage, sdob) values ('ram','pokhara',24,'1992-02-14');

-- to display all the data from the database table
use db_college;
select * from tbl_students;

-- to insert data into the database table : Method 2
use db_college;
insert into tbl_students values ('sita','palpa',22,'1994-02-18');


-- to insert data into the database table : Method 3
use db_college;
insert into tbl_students values
('hari','palpa',21,'1996-02-18'),
('gita','butwal',20,'1992-02-18'),
('nitya','dharan',16,'1999-02-18'),
('mina','bhaktapur',23,'1996-02-18'),
('tina','lalitpur',19,'1997-02-18');
