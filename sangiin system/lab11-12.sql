-- create database lab11

use lab11

drop table Line
drop table Product
drop table Vendor
drop table Invoice
drop table Customer

create table Customer
(
    cus_code integer,
    cus_lName varchar(20),
    cus_fName varchar(20),
    cus_initial char(1),
    cus_areaCode integer,
    cus_phone integer,
    cus_balance decimal(10, 2),
    primary key (cus_code)
);

create table Invoice
(
    inv_number integer,
    cus_code integer,
    inv_date char(8),
    primary key (inv_number),
    foreign key (cus_code) references Customer(cus_code)
);

create table Vendor
(
    v_code integer,
    v_name varchar(20),
    v_contact varchar(20),
    v_areaCode integer,
    v_phone integer,
    v_state char(2),
    v_order char(1)
        primary key (v_code)
);

create table Product
(
    p_code char(8),
    p_descript varchar(20),
    p_indate char(8),
    p_qoh integer,
    p_min integer,
    p_price integer,
    p_discount decimal(10, 2),
    v_code integer,
    primary key (p_code),
    foreign key (v_code) references Vendor(v_code),
)

create table Line
(
    inv_number integer,
    line_number integer,
    p_code char(8),
    line_units integer,
    line_price decimal(10, 2),
    foreign key (inv_number) references Invoice(inv_number),
    foreign key (p_code) references Product(p_code)
)


insert into Customer
values(10010, 'Ramas', 'Alfred', 'A', 615, 8442573, 0.00);
insert into Customer
values(10011, 'Dunne', 'Leona', 'K', 713, 8941238, 0.00);
insert into Customer
values(10012, 'Smith', 'Kothy', 'W', 615, 8942285, 345.86);
insert into Customer
values(10013, 'Olowski', 'Paul', 'F', 615, 8942100, 536.75);
insert into Customer
values(10014, 'Orlando', 'Myron', '', 615, 2221672, 0.00);
insert into Customer
values(10015, 'O''Brion', 'Amy', 'B', 713, 4423381, 0.00);
insert into Customer
values(10016, 'Brown', 'James', 'G', 615, 2971228, 221.19);
insert into Customer
values(10017, 'Williams', 'George', '', 615, 2902556, 768.93);
insert into Customer
values(10018, 'Farriss', 'Anne', 'G', 713, 3827185, 216.55);
insert into Customer
values(10019, 'Smith', 'Oliette', 'K', 615, 2973809, 0.00);

insert into Invoice
values(1001, 10014, '16-03-08');
insert into Invoice
values(1002, 10011, '16-03-08');
insert into Invoice
values(1003, 10012, '16-03-08');
insert into Invoice
values(1004, 10011, '17-03-08');
insert into Invoice
values(1005, 10018, '17-03-08');
insert into Invoice
values(1006, 10014, '17-03-08');
insert into Invoice
values(1007, 10015, '17-03-08');
insert into Invoice
values(1008, 10011, '17-03-08');

insert into Vendor
values(21225, 'Bryson, Inc.', 'Smithson', 615, 2233234, 'IN', 'Y');
insert into Vendor
values(21226, 'SuperLoo, Inc.', 'Flushing', 904, 2158995, 'IN', 'Y');
insert into Vendor
values(21231, 'D&E Supply', 'Singh', 615, 2283245, 'IN', 'Y');
insert into Vendor
values(21344, 'Gomez Bros.', 'Ortega', 615, 8892546, 'IN', 'Y');
insert into Vendor
values(22567, 'Dome Supply', 'Smith', 901, 6701419, 'IN', 'Y');
insert into Vendor
values(23119, 'Randsets Ltd.', 'Anderson', 901, 6783998, 'IN', 'Y');
insert into Vendor
values(24004, 'Brackman Bros.', 'Browning', 615, 2201410, 'IN', 'Y');
insert into Vendor
values(24288, 'Ordva, Inc.', 'Hasktord', 615, 8981234, 'IN', 'Y');
insert into Vendor
values(25443, 'R&K, Inc.', 'Smith', 904, 2270093, 'IN', 'Y');
insert into Vendor
values(25501, 'Domol Supplies', 'Smythe', 615, 8903520, 'IN', 'Y');
insert into Vendor
values(25595, 'Rubicon Systems', 'Orlon', 904, 4560092, 'IN', 'Y');

insert into Product
values('11QER/31', 'Power painter 15psi', '03-11-07', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('13-Q2/P2', '7.25-in saw blade', '13-12-07', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('14-Q1/L3', '9.00-in saw blade', '13-11-07', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('1546-QQ2', 'Hrd cloth, 1/4-in', '15-01-08', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('1558-QWM', 'Hrd cloth, 1/2in', '15-01-08', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('2232JQTY', 'B&D jigsaw, 12-in', '30-12-07', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('2232VQWE', 'B&D jigsaw, 8-in', '24-12-07', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('2238VQPD', 'B&D cordies drillm', '20-01-08', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('23109-HB', 'Claw hammer', '20-01-08', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('23114-AA', 'Sledge hammer', '02-01-08', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('54778-2T', 'Rat-tail fire', '15-12-07', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('89-WRE-Q', 'Hicut chain saw', '07-02-08', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('PVC23DRT', 'PVC pipe', '20-02-08', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('SM-18277', 'Metal screw', '01-03-08', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('SW-23116', 'Vvd screw', '24-02-08', 8, 5, 109.99, 0.00, 25595 )
insert into Product
values('VVR3/TT3', 'Steel matting', '17-01-08', 8, 5, 109.99, 0.00, 25595 )


insert into Line
values(1001, 1, '13-Q2/P2', 1, 14.99)
insert into Line
values(1001, 2, '23109-HB', 1, 9.95)
insert into Line
values(1002, 1, '54778-2T', 2, 4.99)
insert into Line
values(1003, 1, '2238VQPD', 1, 38.95)
insert into Line
values(1003, 2, '1546-QQ2', 1, 39.95)
insert into Line
values(1003, 3, '13-Q2/P2', 5, 14.99)
insert into Line
values(1004, 1, '54778-2T', 3, 4.99)
insert into Line
values(1004, 2, '23109-HB', 2, 9.95)
insert into Line
values(1005, 1, 'PVC23DRT', 12, 5.87)
insert into Line
values(1006, 1, 'SM-18277', 3, 6.99)
insert into Line
values(1006, 2, '2232JQTY', 1, 109.92)
insert into Line
values(1006, 3, '23109-HB', 1, 9.95)
insert into Line
values(1006, 4, '89-WRE-Q', 1, 256.99)
insert into Line
values(1007, 1, '13-Q2/P2', 2, 14.99)
insert into Line
values(1007, 2, '54778-2T', 1, 4.99)
insert into Line
values(1008, 1, 'PVC23DRT', 5, 5.87)
insert into Line
values(1008, 2, 'VVR3/TT3', 3, 119.95)
insert into Line
values(1008, 3, '23109-HB', 1, 9.95)


-- 2
select count(distinct line_number) as 'count'
from Line

-- 3
select *
from Customer
where cus_balance > 500

-- 4
select Invoice.cus_code, Invoice.inv_number, Invoice.inv_date, Product.p_descript, line_units, line_price
from Line
    inner join Invoice on Invoice.inv_number = Line.inv_number
    inner join Product on Product.p_code = Line.p_code
order by Invoice.cus_code

-- 5
select Invoice.cus_code, Invoice.inv_number, Product.p_descript, line_units as 'Units Bought', line_price as 'Unit Price', (line_units * line_price) as 'Subtotal'
from Line
    inner join Invoice on Invoice.inv_number = Line.inv_number
    inner join Product on Product.p_code = Line.p_code
order by Invoice.cus_code


begin transaction
create table Temp
(
    cus_code integer,
    cus_balance decimal(10, 2),
    total_purchase integer,
    number_of_purchases integer,
    avarage_purchases decimal(10, 2)
)
insert into Temp
select Customer.cus_code, Customer.cus_balance, sum(line_units * line_price) , count(Customer.cus_code) , convert( decimal(10, 2), sum(line_units * line_price)/count(Customer.cus_code))
from Line
    inner join Invoice on Invoice.inv_number = Line.inv_number
    inner join Customer on Customer.cus_code = Invoice.cus_code
group by Customer.cus_code, Customer.cus_balance
order by Customer.cus_code
--6 
select cus_code, cus_balance, total_purchase
from Temp
--7 
select cus_code, cus_balance, total_purchase, number_of_purchases
from Temp
--8
select *
from Temp
rollback transaction

--9 
select inv_number, sum(line_price * line_units) as 'Invoice Total'
from Line
group by inv_number
order by inv_number

--10
select Invoice.cus_code, Invoice.inv_number, sum(line_price * line_units) as 'Invoice Total'
from Line
    inner join Invoice on Invoice.inv_number = Line.inv_number
group by Invoice.inv_number, Invoice.cus_code
order by Invoice.cus_code
