use shopping
go
select * from issue
select * from member

select *from book

select category from book

--1)	List the various categories and count of books in each category.
select  category,count(Book_No) from book 
group by category

--2)  List the book_No and the number of times the book is issued in the descending order of count.

select book_no,count(lib_issue_id) Issuedcount from issue 
group by book_no
order by issuedcount desc

--3) Find the maximum, minimum, total and average penalty amount in the member table.
select min(Penalty_Amount),max(Penalty_Amount),avg(Penalty_Amount)from member

--4) Display the member id and the no of books for each member that has issued more then 2 books.
 select Member_Id,count(Lib_Issue_Id) from issue
 group by member_id
 having count(Lib_Issue_Id)>2

 --5) Display the member id, book no and no of times the same book is issued by the member in the descending order of count.
 select book_no, member_id ,count(lib_issue_id) Issuedcount from issue 
group by book_no,member_id
order by issuedcount desc

--6)Display the month and no of books issued each month in the descending order of count.
select month(Issue_Date) month,count(Book_No) bookcount from issue
group by MONTH(issue_date)
order by count(Book_No) desc

--7) List the book_no of all the books that are not issued to any  member so far. 
select book_no from issue
where Issue_Date is null

--8)List all the member id that exist in member table and has also at least one book issued by them.
select i.Member_Id,m.member_id
 from issue as  i inner join  member as m on i.Member_Id=m.member_id

 --9)  List the member ID with highest and lowest no of books issued. 
 select Member_Id,max(Lib_Issue_Id),max(Lib_Issue_Id) from issue 
 group by Member_Id

 --10)List all the Issue_details for books issued in December and July without using any arithmetic, Logical or comparison operator.
 select *from issue 
 where month(Issue_Date)in(12,9)

  --11)	 List the Book_No, Book_Name and Issue_date for all the books that are issued in month of December and belong to category Database.
  select b.category, b.Book_No,b.Book_Name,i.Issue_Date
 from issue as  i inner join  book as b on i.Book_No=b.Book_No
  where month(Issue_Date)in(9)and b.Category='database'

--12)	 List the Member Id, Member Name and No of books Issued in the descending order of the count.
select m.member_id,m.member_name,count(lib_issue_id) 
 from issue as  i inner join  member as m on i.Member_Id=m.member_id
 group by rollup(m.member_id,m.member_name)
 order by count(lib_issue_id)  desc

--13)	List the Book No, Book Name, Issue_date and Return_Date for all the books issued by Richa Sharma.
select b.Author, b.Book_No,b.Book_Name,i.Issue_Date,i.Return_date
 from issue as  i inner join  book as b on i.Book_No=b.Book_No
 where b.Author='loni'

--14)	List the details of all the members that have issued books in Database category.
select m.member_id,m.member_name
  from issue i inner join  member m
  on  i.Member_Id= m.member_id
  inner join book b
  on i.Book_No=b.Book_No
  where Category='database'
--15)	List all the books that have highest price in their own category.
select category,max(cost) from book
group by Category

--16)	List all the Issue_Details where Issue_date is not within the Acc_open_date and Return_date for that member.
select distinct i.* from issue i,member m 
where i.issue_date not between m.acc_open_date and i.return_date

--17)	List all the members that have not issued a single book so far.
select member_id from member
except
select member_id from issue
--18)	List all the Members where No of books Issued exceeds the Max No of books allowed.---------------------------doubt
select m.member_id,m.member_name,count(lib_issue_id) 
 from issue as  i inner join  member as m on i.Member_Id=m.member_id
 
use Northwind
go
select *from Customers
--How many customers do we have in our database?
select distinct  count(Customerid) from Customers
--2-- How many of our customer names begin with the letter "b"?
select distinct  count(Customerid) from Customers
   where ContactName like 'b%'
--3--How many of our customer names contain the letter "s" ?
select distinct  count(Customerid) from Customers
   where ContactName like '%s%'
   --4--How many customers do we have in each city?
select distinct city, count(Customerid) from Customers
   group by City
   --5--What are the top three cities where we have our most customers?
   --6--