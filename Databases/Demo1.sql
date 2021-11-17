create database PratianTraining;

create table Products (id int, name varchar(50), description varchar(50), brand varchar(50), category varchar(50), price decimal)

insert into Products values (1,'Samsung Galaxy M30','Good Phone','Samsung','Phones',13000);
insert into Products values
(2,'Vivo V5 S','Camera Phone','Vivo','Phones',9000),
(3,'Samsung Galaxy J4+','Smart Phone','Samsung','Phones',9000),
(4,'Sandisk 4 GB Pendrive','PenDrive','Sandisk','Computer Accessories',6000);

insert into Products (id,name,brand,category,price)
values
(5,'Whirlpool Top Load Washin Machine','Whirlpool','Home appliances',15000),
(6,'Kent Water Filter','Kent','Home appliances',15000);

Select * from Products
Select name, category from Products

alter table Products add status varchar(50)

truncate table Products;

select distinct category from Products

Update Products set status='In-stock';

Select * from Products where category='Phones';

update Products set Price=Price*0.9 where brand = 'Samsung'

select * from Products where name like '_a%';

select * from Products where description is null

