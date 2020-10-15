create database WarehouseManagement
go

use WarehouseManagement
go

create table USERACC
(
	USERID int primary key,
	USERNAME varchar(20),
	USERPASS varchar(20),
)

create table HANGHOA
(
	MAHANG varchar(20) primary key,	--Ma hang	
	TENHANG varchar(100),				--Ten hang
	DVT varchar(10),					--Don vi
	SOLUONG int,							--So luong
	GIA money,						--Don gia
	NGNHAP smalldatetime,			--Ngay nhap
	NGSANXUAT smalldatetime,	--Ngay san xuat
	HSD smalldatetime,			--Han su dung
	USERID int foreign key references USERACC(USERID),
)

create table ORDERS
(
	MAHOADON varchar(20) primary key,
	NGXUAT smalldatetime,
	MAHANG varchar(20) foreign key references HANGHOA(MAHANG),
	USERID int foreign key references USERACC(USERID),
)

