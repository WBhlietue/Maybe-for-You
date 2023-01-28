use bd;
drop table room;
drop table customer;



create table customer(
	cus_code varchar(20) primary key,
    pass varchar(10),
	cusfname varchar(50) ,
    cuslname varchar(50),
    cus_birth  char(20),
    cus_reg char(20),
    cus_phone char(20)
);
select * from customer;
create table room(
	room_id int primary key,
    is_empty bool,
    cus_code varchar(20),
    r_Date varchar(8),
    foreign key (cus_code) references customer(cus_code)
);

insert into customer values('', '', '', '', '', '', '');

insert into room values (101, true, '', '');
insert into room values (102, true, '', '');
insert into room values (103, true, '', '');
insert into room values (104, true, '', '');
insert into room values (105, true, '', '');
insert into room values (106, true, '', '');
insert into room values (107, true, '', '');
insert into room values (108, true, '', '');
insert into room values (109, true, '', '');

insert into room values (201, true, '', '');
insert into room values (202, true, '', '');
insert into room values (203, true, '', '');
insert into room values (204, true, '', '');
insert into room values (205, true, '', '');
insert into room values (206, true, '', '');
insert into room values (207, true, '', '');
insert into room values (208, true, '', '');
insert into room values (209, true, '', '');

insert into room values (301, true, '', '');
insert into room values (302, true, '', '');
insert into room values (303, true, '', '');
insert into room values (304, true, '', '');
insert into room values (305, true, '', '');
insert into room values (306, true, '', '');
insert into room values (307, true, '', '');
insert into room values (308, true, '', '');
insert into room values (309, true, '', '');

insert into room values (401, true, '', '');
insert into room values (402, true, '', '');
insert into room values (403, true, '', '');
insert into room values (404, true, '', '');
insert into room values (405, true, '', '');
insert into room values (406, true, '', '');
insert into room values (407, true, '', '');
insert into room values (408, true, '', '');
insert into room values (409, true, '', '');
