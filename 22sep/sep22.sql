use shopping
go
create table member_c
(
Member_Id int Primary Key,
Acc_Open_Date date default sysdatetime(),
Max_Allowed_Books int,
penality money
)
alter table member_c
add constraint chk_books check(max_allowed_books<100)

alter table member_c
add constraint chk_pen check(penality<=100)

--2)	Create table Book_C with following constraints.
--a.	Book_No – Primary Key
--b.	Book_Name – Not Null
--c.	Category – Science, Fiction, Database, RDBMS, Others.
create table book_c
(
book_no int Primary Key,
book_name  varchar(20) not null,
category varchar(30),
constraint chk check(category in ('database', 'science', 'fiction','rdbms','others'))
)

--3)	Create table Issue_C with following constraints.
--a.	Lib_Issue_Id – Primary Key
--b.	Member_Id – Foreign Key
--c.	Book_No – Foreign key
--d.	Issue_date < Return_date
create table issue_c
(
Lib_Issue_Id int primary key,
Member_Id int constraint fk_memfk foreign key references Member_C(Member_id),
Book_No int constraint fk_bfk foreign key references Book_C(Book_no),
issue_date date,
return_date date,
)
alter table issue_c
add constraint chk_issuereturn check(Issue_date < Return_date)
insert into book_c values(20,'dreamgirls','fiction',700)
--Add a constraint Price < 2500 to Book table.
alter table book_c
add price int  constraint chk_price check(price<2500)
 select *from book_c
 --View all the constraints for table Issue_C using view User_Constraints.
 create view v_issue
as 
select Lib_Issue_Id,Member_Id ,Book_No from issue_c

select*from v_issue
--Disable constraint created in step 3-d
alter table issue_c
drop constraint chk_issuereturn
--Create a view with check option to display all the books that has price greater then 500.
create view v_book_c
as
select*from book_c
where price>500
select *from v_book_c
--Perform DML operations to the view and evaluate the effect of Check Option.
create view v_book_c
as
select*from book_c
where price>500

select *from v_book_c

insert into v_book_c
values (3,'dreamboy','fiction',300)
insert into v_book_c
values (4,'dream','fiction',500)
insert into v_book_c
values (5,'dream chaser','fiction',800)

update v_book_c
set price=900
where book_no=5

delete v_book_c
where book_no=5
--------------Create Index on Book_Name in book table.
create nonclustered index pk_bookname
on book_c(book_name)
----------------------------Create Index on Member_Id, Book_No in Issue table.
create index c_names
on issue_c(member_id,book_no)
