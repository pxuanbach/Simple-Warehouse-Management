create database WarehouseManagement
go

use WarehouseManagement
go

create table STOCK
(
	IDSTOCK varchar(20) primary key,	--Ma hang	
	NAMESTOCK varchar(100),				--Ten hang
	UNIT varchar(10),					--Don vi
	AMOUNT int,							--So luong
	PRICE money,						--Don gia
	DATEADDED smalldatetime,			--Ngay nhap
	MANUFACTURINGDATE smalldatetime,	--Ngay san xuat
	EXPIRYDATE smalldatetime,			--Han su dung
)

create table USERACCOUNT
(
	USERNAME varchar(20) primary key,
	PASSWORD varchar(20),
)