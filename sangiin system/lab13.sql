use lab13;

drop table OrderDetail
drop table Product
drop table Orders
drop table Customer

create table Customer
(
    cusID char(8) primary key,
    cusName varchar(30),
    cusAddress varchar(30)
)

create table Orders
(
    orderSlipNumber integer primary key,
    orderDate char(8),
    cusID char(8)
        foreign key(cusID) references Customer(cusID)
)

create table Product
(
    pID char(8) primary key,
    pName varchar(30),
    pPrice integer,
    qnt integer
)

create table OrderDetail
(
    orderSlipNumber integer,
    pID char(8),
    qnt integer,
    foreign key (orderSlipNumber) references Orders(orderSlipNumber),
    foreign key (pID) references Product(pID)
)

insert into Customer
values
    ('AB000001', 'Star Plutinum', 'SBD 3-r khoroo');
insert into Customer
values
    ('AB000002', 'The World', 'SBD 3-r khoroo');
insert into Customer
values
    ('AB000003', 'Silver Chariot', 'BZD 3-r khoroo');
insert into Customer
values
    ('AB000004', 'Hermit Purple', 'SHD 3-r khoroo');
insert into Customer
values
    ('AB000005', 'Magician Red', 'HUD 3-r khoroo');
insert into Customer
values
    ('AB000006', 'Killer Queen', 'HUD 3-r khoroo');
insert into Customer
values
    ('AB000007', 'Crazy Diamond', 'SHD 3-r khoroo');
insert into Customer
values
    ('AB000008', 'King Crimson', 'BZD 3-r khoroo');
insert into Customer
values
    ('AB000009', 'Ball Breaker', 'CHD 3-r khoroo');
insert into Customer
values
    ('AB000010', 'Weather Report', 'SBD 3-r khoroo');

insert into Orders
values
    (1, '18-02-24', 'AB000002');
insert into Orders
values
    (2, '18-02-25', 'AB000003');
insert into Orders
values
    (3, '18-02-27', 'AB000007');
insert into Orders
values
    (4, '18-03-04', 'AB000004');
insert into Orders
values
    (5, '18-03-10', 'AB000009');
insert into Orders
values
    (6, '18-03-11', 'AB000006');

insert into Product
values('000001', 'Mouse', '5000', 400);
insert into Product
values('000002', 'KeyBoard', '60000', 350);
insert into Product
values('000003', 'Monitor', '500000', 100);
insert into Product
values('000004', 'Microphone', '10000', 600);
insert into Product
values('000005', 'Headphone', '30000', 600);
insert into Product
values('000006', 'USB converter', '2500', 1000);
insert into Product
values('000007', 'Flash Disk', '10000', 200);
insert into Product
values('000008', 'Hard disk', '200000', 50);


select * from OrderDetail
select * from Product

declare @num as integer = 1000
declare @pid as char(6) = '000001'
--1 
begin transaction
insert into OrderDetail
values(1, @pid, @num);
update Product set qnt = qnt - @num where pID = @pid
if ((select qnt
from Product
where pID = @pid) < 0)
begin
    raiserror('qnt is not enought', 16, -1)
    rollback transaction
end
if @@error <> 0
begin
    raiserror('error', 16, -1)
    rollback transaction
end
commit transaction
select *
from Product
where pID = @pid;
select *
from OrderDetail
where pID = @pid and orderSlipNumber = 1

--2
begin transaction
set @num = 10
update OrderDetail set qnt = qnt - @num where pID = @pid and orderSlipNumber = 1
update Product set qnt = qnt + @num where pID = @pid
if ((select qnt
from Product
where pID = @pid) < 0)
begin
    raiserror('product qnt is not enought', 16, -1)
    rollback transaction
end
if ((select qnt
from OrderDetail
where pID = @pid and orderSlipNumber = 1) < 0)
begin
    raiserror('orderDetail qnt is not enought', 16, -1)
    rollback transaction
end
if @@error <> 0
begin
    raiserror('error', 16, -1)
    rollback transaction
end
commit transaction
select *
from Product
where pID = @pid;
select *
from OrderDetail
where pID = @pid and orderSlipNumber = 1

--3
begin transaction
update Product set qnt = qnt + (select max(qnt)
from OrderDetail
where pID = @pid and orderSlipNumber = 1)
where pID = @pid
delete from OrderDetail where pID = @pid and orderSlipNumber = 1
if @@error <> 0
begin
    raiserror('error', 16, -1)
    rollback transaction
end
commit transaction

select *
from Product
where pID = @pid;
select *
from OrderDetail
where pID = @pid and orderSlipNumber = 1

