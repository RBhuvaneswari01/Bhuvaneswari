use shopping
select * from issue
select *from member

insert into Issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date)values(7001	,101,	1,'2021-09-06')
insert into Issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date)values(7002,	102,	2,'2010-09-06')
insert into Issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date)values(7004	,101,	1,	'2001-09-06')
insert into Issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date)values(7005	,104,	2,	'2020-09-06')
insert into Issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date)values(7006,	101,	3,	'2019-09-06')

update issue
set return_date='2001-09-21'
where lib_issue_id=7004

update issue
set return_date='2001-09-21'
where lib_issue_id=7005


update member
set Penalty_Amount=100
where member_name='garima sen'

delete  from issue
where Member_Id=1and Issue_Date<'2010-09-06'

delete  from book
where Category!='rdbms'and Category!='database'
drop table member101
drop table book101
select* from member
select* from issue
select *from book

select * from member
where Acc_Open_Date ='2005-12-10'


select*from book
where Author='loni'and Cost<600

select*from issue
where Return_date!='2001-09-21'

select*from issue
where Return_date='2001-09-21'

update issue
set Return_date='2006-12-31'
where Member_Id!=7005 and Member_Id!=7006

select*from issue
where  (Issue_Date) -(Return_date)>30

select * from Book
where Cost between 500 and 700 and Category= 'Database'

SELECT * FROM Book 
WHERE category in ('Science','Database', 'Fiction','Management');

select * from member 
order by Penalty_Amount desc

select * from book 
order by category asc,cost desc;

select * from book where Book_Name like '%sql%'

SELECT * FROM MEMBER where MEMBER_NAME like'R%'OR
MEMBER_NAME LIKE'G%' AND MEMBER_NAME LIKE '%I%';

select upper(book_name) from book
order by book_name desc;

--SELECT TO_CHAR(ISSUE_date, 'DY/MON/DD/YYYY'),TO_CHAR(RETURN_DATE,'DY/MON/DD/YYYY')FROM ISSUE_506917 WHERE LIB_ISSUE_ID=7001;
select * from issue 
order by issue_date ;

SELECT SUM(MAX_BOOKS_ALLOWED) FROM MEMBER WHERE MEMBER_ID=1 

select sum(penalty_amount) from member

select sum(cost)from book
where Category='database'

select min(cost) from book

select*from issue

select issue_date from issue
where Lib_Issue_Id=7001

---SELECT LAST_DAY(ISSUE_DATE) FROM ISSUE

select avg(cost) from book
where Category='database'



