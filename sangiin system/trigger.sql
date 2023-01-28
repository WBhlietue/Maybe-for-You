use lab14;


create table TriggerTest
(
    a integer,
    b integer,
    c integer,
    summ integer,
)


go
create trigger triggertst
    on TriggerTest
    for insert
    as update TriggerTest set TriggerTest.summ = TriggerTest.a + TriggerTest.b + TriggerTest.c

insert into TriggerTest
values(38, 62, 54, 0)
insert into TriggerTest
values(98, 60, 10, 0)
insert into TriggerTest
values(77, 36, 42, 0)
insert into TriggerTest
values(92, 82, 25, 0)
insert into TriggerTest
values(22, 80, 79, 0)
insert into TriggerTest
values(70, 28, 18, 0)
insert into TriggerTest
values(42, 91, 84, 0)
insert into TriggerTest
values(99, 21, 17, 0)
insert into TriggerTest
values(54, 19, 25, 0)
insert into TriggerTest
values(10, 73, 51, 0)
insert into TriggerTest
values(82, 37, 18, 0)
insert into TriggerTest
values(21, 36, 83, 0)
insert into TriggerTest
values(61, 50, 63, 0)
insert into TriggerTest
values(69, 56, 83, 0)
insert into TriggerTest
values(78, 91, 14, 0)
insert into TriggerTest
values(78, 60, 27, 0)
insert into TriggerTest
values(53, 80, 22, 0)
insert into TriggerTest
values(92, 55, 14, 0)
insert into TriggerTest
values(38, 18, 40, 0)
insert into TriggerTest
values(57, 29, 47, 0)


select *
from TriggerTest


--drop table TriggerTest2
create table TriggerTest2
(
    a integer,
    b integer
)

go
alter trigger TriggerTest2Limit
on TriggerTest2
for insert
as 
update TriggerTest2 set a = case when a < 0 then 0
                                              else a end,
                        b = case when b < 0 then 0
                                              else b end

go
alter trigger TriggerTest2Alert
on TriggerTest2
for insert
as 
begin
    declare @a integer
    declare @b integer
    select @a = a, @b = b
    from inserted

    if(@a < 0)
    begin
        print('a is lesser than 0')
    end
    if(@b < 0)
    begin
        print('b is lesser than 0')
    end
end




    insert into TriggerTest2
values(10, 10)
    insert into TriggerTest2
values(-10, 10);
    insert into TriggerTest2
values(10, -10);
    insert into TriggerTest2
values(-10, -10)

    select *
from inserted

    select *
from TriggerTest2