-- Kode ini di buat dalam PgAdmin 4 --
-- Jika Ingin Mencoba tanpa Mengedit ubah nama database menjadi penjualan_laptop --

begin;

create table customers(
	id_customers smallserial primary key,
	customer_name varchar(50) not null,
	no_hp varchar(50) not null,
	alamat varchar(50) not null
);
create table laptop(
	id_product smallserial primary key,
	name_product varchar (50) not null,
	price integer not null,
	units_in_stock smallserial not null
);

create table orders (
	order_id smallserial primary key,
	order_date date not null,
	id_customer smallserial not null
);

create table order_details (
	order_id smallserial not null,
	id_laptop smallserial not null,
	quantity integer not null
);

alter table orders add constraint cust_order_pk foreign key (id_customer) references customers(id_customers);
alter table order_details add constraint laptop_order_details_pk foreign key (id_laptop) references laptop(id_product);
alter table order_details add constraint order_order_details_pk foreign key (order_id) references orders(order_id) on delete cascade;

insert into customers (id_customers, customer_name, no_hp, alamat) values (1, 'Moch Syaiful Rizal', '087654321891', 'Situbondo'),
(2, 'Desy Arinda Milyana', '087654785432', 'Situbondo');

insert into laptop (id_product, name_product, price, units_in_stock) values (101, 'Axioo MyBook Z10 Metal', 9000000, 30), (102, 'HP F14sq098t', 7000000, 20),
(103, 'Dell 786', 4300000, 50);

insert into orders(order_id, order_date, id_customer) values (22241, '04-06-2023', 1), (22242, '04-06-2023', 2);

insert into order_details (order_id, id_laptop, quantity) values (22241, 101, 1), (22242, 102, 1);

end;
