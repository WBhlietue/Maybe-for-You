use Lab9;

begin try
	drop table Register;
	drop table Item;
	drop table OrderPage;
	drop table Customer;
end try
begin catch
	print('hi');
end catch

create table Customer
(
	cusCode int,
	cusName varchar (50),
	cusAddress varchar(50),
	cusDirect varchar(2),
	primary key(cusCode),
);

create table OrderPage
(
	orderNum int,
	cusCode int,
	orderDate varchar(8)
		primary key(orderNum),
	foreign key(cusCode) references Customer(cusCode),
);

create table Item
(
	itemCode varchar(10),
	itemName varchar(50),
	price int,
	primary key(itemCode),
);

create table Register
(
	orderNum int,
	itemCode varchar(10),
	num int,
	foreign key (orderNum) references OrderPage(orderNum),
	foreign key (itemCode) references Item(itemCode),
);

insert into Customer
values(9321, 'Office Ginza Co.LTD', '1-2-3 Ginza, Chuo-ku', 'BZ');
insert into Customer
values(9322, 'Office Abcdef Co.LTD', '1-2-3 Abcdef, Ora-ku', 'SB');
insert into Customer
values(9323, 'Office HiHello Co.LTD', '1-2-3 HiHello, Muda-ku', 'SH');
insert into Customer
values(9324, 'Office Konnichiva Co.LTD', '1-2-3 Konnichiva, Star-Platinum', 'SB');
insert into Customer
values(9325, 'Office School Co.LTD', '1-2-3 School, Za-Warudo', 'BG');
insert into Customer
values(9326, 'Office Company Co.LTD', '1-2-3 Company, Hermit-Purple', 'BZ');
insert into Customer
values(9327, 'Office Hola Co.LTD', '1-2-3 Hola, Silver-Chariot', 'HU');
insert into Customer
values(9328, 'Office Nomin Co.LTD', '1-2-3 Nomin, Magician-Red', 'CH');
insert into Customer
values(9329, 'Office Eartch Co.LTD', '1-2-3 Eartch, Crazy-Diamond', 'BZ');
insert into Customer
values(9330, 'Office Sun Co.LTD', '1-2-3 Sun, Golden-Experience', 'HU');

insert into OrderPage
values(120131, 9321, '18-03-28');
insert into OrderPage
values(120132, 9322, '18-03-29');
insert into OrderPage
values(120133, 9323, '18-03-30');
insert into OrderPage
values(120134, 9321, '18-04-01');
insert into OrderPage
values(120135, 9324, '18-04-05');
insert into OrderPage
values(120136, 9323, '18-04-06');
insert into OrderPage
values(120137, 9325, '18-04-10');
insert into OrderPage
values(120138, 9322, '18-04-18');
insert into OrderPage
values(120139, 9327, '18-04-27');
insert into OrderPage
values(120140, 9325, '18-05-04');

insert into Item
values('H1010', 'Notebook-size personal computer', 250000);
insert into Item
values('H2010', 'Laser printer', 300000);
insert into Item
values('S1040', 'Integrated software', 100000);
insert into Item
values('SP002', 'A-4 size paper', 3000);
insert into Item
values('SP003', 'A-5 size paper', 2500);
insert into Item
values('H0030', 'Mouse', 4000);
insert into Item
values('H1020', 'Desktop personal computer', 180000);
insert into Item
values('S1010', 'Word processing software', 30000);

insert into Register
values(120131, 'H1010', 4);
insert into Register
values(120131, 'H2010', 2);
insert into Register
values(120131, 'S1040', 1);
insert into Register
values(120131, 'SP002', 2);
insert into Register
values(120131, 'SP003', 4);
insert into Register
values(120131, 'H0030', 4);
insert into Register
values(120131, 'H1020', 5);
insert into Register
values(120131, 'S1010', 5);

insert into Register
values(120132, 'H1010', 34);
insert into Register
values(120132, 'H2010', 20);
insert into Register
values(120132, 'S1040', 16);
insert into Register
values(120132, 'SP002', 25);
insert into Register
values(120132, 'SP003', 41);

insert into Register
values(120133, 'SP003', 4);
insert into Register
values(120133, 'H0030', 54);
insert into Register
values(120133, 'H1020', 35);
insert into Register
values(120133, 'S1010', 59);

insert into Register
values(120134, 'H1010', 7);
insert into Register
values(120134, 'H2010', 3);
insert into Register
values(120134, 'H1020', 2);
insert into Register
values(120134, 'S1010', 8);

insert into Register
values(120135, 'H1010', 34);
insert into Register
values(120135, 'SP003', 24);
insert into Register
values(120135, 'H0030', 45);

insert into Register
values(120136, 'S1040', 13);
insert into Register
values(120136, 'H1020', 56);
insert into Register
values(120136, 'S1010', 15);

insert into Register
values(120137, 'H1010', 10);
insert into Register
values(120137, 'S1010', 12);

insert into Register
values(120138, 'H1010', 34);
insert into Register
values(120138, 'H2010', 24);
insert into Register
values(120138, 'S1040', 97);
insert into Register
values(120138, 'SP002', 13);
insert into Register
values(120138, 'SP003', 7);
insert into Register
values(120138, 'S1010', 10);

insert into Register
values(120139, 'SP003', 23);
insert into Register
values(120139, 'H0030', 1);
insert into Register
values(120139, 'H1020', 5);
insert into Register
values(120139, 'S1010', 7);

insert into Register
values(120140, 'H1010', 3);

--hereglegchiin buh medeelel
select *
from Customer;

--120131 iin negj uniin dundaj
select avg(Item.price) as '120131 zahialgiin negj unii dundaj'
from Register
	inner join Item on Item.itemCode = Register.itemCode
where Register.orderNum = 120131

select * from Register
--120132 iin negj uniin niilber
select sum(Item.price) as '120132 zahialgiin negj unii nuulber'
from Register
	inner join Item on Item.itemCode = Register.itemCode
where Register.orderNum = 120132

--120132 iin zahialgiin niit une
select sum(Item.price * Register.num) as '120132 zahialgiin niit uniin dun'
from Register
	inner join Item on Item.itemCode = Register.itemCode
where Register.orderNum = 120132

--120131 iin 10000 ees ih duntei baraanii too
select count(*) as '120131 zahialgiin 10000-ees ih unetei baraani too'
from Register
	inner join Item on Item.itemCode = Register.itemCode
where Item.price > 100000 and Register.orderNum =  120131


--zahialga buriin niit dun
select Register.orderNum, sum(Register.num * Item.price) as ' niit dun'
from Register
	inner join Item on Item.itemCode = Register.itemCode
group by Register.orderNum


--5 aas ih baraa zahialaad, niit dun ni 250000 ees ih baih zahialga
select  Register.orderNum as 'Order num',  count(Item.itemCode) as "num", 
		sum(Register.num * Item.price) as 'price'
from Register
	inner join Item on Item.itemCode = Register.itemCode
group by Register.orderNum
having  count(Item.itemCode) > 5 and sum(Register.num * Item.price) > 250000






--9321 dugaartai hereglegchiin medeelel
select *
from Customer
where cusCode = 9321;


--Bayanzurkh bairlaltai hereglegchiin medeelel
select *
from Customer
where cusDirect = 'BZ';


--9321 dugaartai hereglegchiin zahialsan baraanii too
select sum(Register.num) as '9321 iin zahialsan baraanii too'
from Register
	inner join OrderPage on OrderPage.orderNum = Register.orderNum
where OrderPage.cusCode = 9321

--9321 dugaartai hereglegchiin zahialsan baraanii turul
select count( distinct Register.itemCode) as '9321 iin zahialsan baraanii turliin too'
from Register
	inner join OrderPage on OrderPage.orderNum = Register.orderNum
	inner join Item on Item.itemCode = Register.itemCode
where OrderPage.cusCode = 9321

--9321 dugaartai hereglegchiin zahialgiin niit dun
select sum(Register.num * Item.price) as '9321 iin zahialsan baraanii niit une'
from Register
	inner join OrderPage on OrderPage.orderNum = Register.orderNum
	inner join Item on Item.itemCode = Register.itemCode
where OrderPage.cusCode = 9321


--heden com avsniig zahailga bureer haruulah
select Register.orderNum, sum(Register.num) as 'avsan com nii too'
from Register
where Register.itemCode = 'H1010' or Register.itemCode = 'H1020'
group by cube (Register.orderNum )






--niit zahialsan com nii too
select sum(Register.num) as 'niit zahialsan com'
from Register
where Register.itemCode = 'H1010' or Register.itemCode = 'H1020'

--3.01-3.30 hurtel hamgiin ih zaragdsan baraa
select * , (
	select sum(Register.num)
	from Register
		inner join OrderPage on Register.orderNum = OrderPage.orderNum
	where substring(OrderPage.orderDate, 0, 6)= '18-03'
	group by Register.itemCode
	order by sum(Register.num) desc
	offset 0 ROWS FETCH FIRST 1 ROWS ONLY
	) as 'selled num'
from Item
where itemCode in (
	select Register.itemCode
from Register
	inner join OrderPage on Register.orderNum = OrderPage.orderNum
where substring(OrderPage.orderDate, 0, 6)= '18-03'
group by Register.itemCode
order by sum(Register.num) desc
	offset 0 ROWS FETCH FIRST 1 ROWS ONLY
)


--zahialgiin hugatsaagaar ni usuj, buuruulah
select *
from Register
	inner join OrderPage on Register.orderNum =  OrderPage.orderNum
order by OrderPage.orderDate asc

select *
from Register
	inner join OrderPage on Register.orderNum =  OrderPage.orderNum
order by OrderPage.orderDate desc

--hamgiin ih zaragdsan baraa
select *
from Item
where itemCode in (
	select Register.itemCode
from Register
group by Register.itemCode
order by sum(Register.num) desc
	offset 0 ROWS FETCH FIRST 1 ROWS ONLY
)

--hangiin tsuun zaragdsan 3 baraa
select *
from Item
where itemCode in (
	select Register.itemCode
from Register
group by Register.itemCode
order by sum(Register.num) asc
	offset 0 ROWS FETCH FIRST 3 ROWS ONLY
)

--zahialga tus bureer ni zahialsan too
select Register.orderNum, sum(Register.num) as 'zahialsan too'
from Register
group by Register.orderNum



--baiguulga tus bureer ni zahialsan too
select Customer.cusName, sum(Register.num) as 'zahialsan too'
from Register
	inner join OrderPage on OrderPage.orderNum = Register.orderNum
	inner join Customer on OrderPage.cusCode = Customer.cusCode
group by Customer.cusName
having sum(Register.num)>50 and Customer.cusName = 'Office Abcdef Co.LTD'

--hamgiin olon zahialga hiisen baiguulga
select *
from Customer
where cusName in (
	select Customer.cusName
from Register
	inner join OrderPage on OrderPage.orderNum = Register.orderNum
	inner join Customer on OrderPage.cusCode = Customer.cusCode
group by Customer.cusName
order by sum(Register.num) desc
	offset 0 rows fetch first 1 rows only
)

