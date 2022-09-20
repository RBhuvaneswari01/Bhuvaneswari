create database product

drop database product
create database shopping
use shopping
create table custmer
(
custid int,
custname varchar(20),
custcity varchar(20),
custstate varchar(20)
)
create table product
(
prodid int,
prodname varchar(20),
unitprice float,
unitofmeasurement float,
qtystock float)

create table sales_header
(
invno int,
invodate date,
invamt int,
dispercent float
)
create table sales_details
(
invono int,
custid int,
prodid int,
qtysold float
)
alter table sales_header
add primary key (custid)
drop table sales_details
create table sales_details
(
invono int primary key,
custid int,
prodid int,
qtysold float
)
alter table sales_details
drop column qtysold

alter table sales_details
add  qty int
