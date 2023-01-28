use lab14

drop table Od
drop table Baraa

create table Baraa
(
    baraaID nchar(5) not null primary key,
    baraaNer nvarchar(50) not null,
    negjUne float
)

create table Od
(
    odid integer not null primary key,
    orderSplitNumber integer not null,
    qnt integer not null,
    baraaID nchar(5) not null,
    foreign key (baraaID) references Baraa(baraaID)
)

insert into Baraa
values('H0030', 'Mouse', 4000)
insert into Baraa
values('H1010', 'Notebook-size personal computer', 250000)
insert into Baraa
values('H1020', 'Desktop personal computer', 180000)
insert into Baraa
values('H2010', 'Laser printer', 300000)
insert into Baraa
values('S1010', 'Word processing software', 30000)
insert into Baraa
values('S1040', 'Integrated software', 100000)
insert into Baraa
values('SP002', 'A-4 size paper', null)
insert into Baraa
values('SP003', 'A-5 size paper', null)

insert into Od
values(1, 120131, 4, 'H1010')
insert into Od
values(2, 120131, 2, 'H2010')
insert into Od
values(3, 120131, 1, 'S1040')
insert into Od
values(4, 120131, 2, 'SP002')
insert into Od
values(5, 120131, 4, 'SP003')
insert into Od
values(6, 120131, 4, 'H0030')
insert into Od
values(7, 120131, 5, 'H1020')
insert into Od
values(8, 120131, 5, 'S1010')
insert into Od
values(9, 120132, 4, 'S1010')
insert into Od
values(10, 120132, 3, 'H1020')

select *
from Baraa;
select *
from Od;

--2


drop proc sp_baraa_1

go
create proc sp_baraa_1
as
select *
from Baraa
where negjUne > 150000 or negjUne is null;

exec sp_baraa_1

go
alter proc sp_baraa_1
as
select *
from Baraa
where negjUne > 150000 or negjUne is null;

exec sp_baraa_1

--3, 4: 3aas deesh avsan baraani medeelel
begin transaction
create table Tempbaraa
(
    baraa_id nchar(5) not null,
    baraa_ner nvarchar(50) not null,
    nrgj_une float
)
insert into Tempbaraa
exec sp_baraa_1
select baraa_id, baraa_ner, nrgj_une, qnt
from Tempbaraa
    inner join Od on Od.baraaID = Tempbaraa.baraa_id
where qnt > 3
rollback transaction

--5 
go
alter proc so_baraa_2
    @negj_une float
as
if @negj_une is null
begin
    raiserror('negj une is not null', 14, 1);
    return
end
select *
from Baraa
where negjUne > @negj_une

--6
exec so_baraa_2 299999
exec so_baraa_2 null

--7 
go
alter proc od_Select
    @num integer
as
if @num is null
begin
    raiserror('num is not null', 14, 1);
    return
end
select *
from Od
where qnt>@num

exec od_Select 3

-- 8
begin transaction
create table Tempbaraa2
(
    odid integer not null primary key,
    orderSplitNumber integer not null,
    qnt integer not null,
    baraaID nchar(5) not null,
)
insert into Tempbaraa2
exec od_Select 4
select *
from Tempbaraa2
rollback transaction

--9
go
alter proc sp_baraa_3
    (@baraa_id nchar(1),
    @result float output)
as
select @result = AVG(negjUne)
from Baraa
where baraaID like @baraa_id + '%'

declare @res float
exec sp_baraa_3 @baraa_id = 'H', @result = @res output
;
select 'Dundaj une : ', @res




--10
select *
from Baraa;
declare @rs float
exec sp_baraa_3 'H',  @rs output
;
select 'H iin dundaj une : ', @rs
exec sp_baraa_3 'S', @rs output
;
select 'S iin dundaj une : ', @rs

--11
go
alter proc getTotal (@orderSplitNum integer, @totl integer output) as
select @totl = sum(qnt)
from Od
where od.orderSplitNumber = @orderSplitNum

declare @total int
exec getTotal 120131, @total output
select 'Total: ', @total


