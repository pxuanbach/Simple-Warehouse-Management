create database WarehouseManagement
go

use WarehouseManagement
go

create table ADMINACC
(
	ADNAME varchar(30) primary key,
	ADPASS varchar(20),
)

create table USERACC
(
	UKEY int primary key,
	USERNAME varchar(30),
	USERPASS varchar(20),
	HOTEN varchar(100),
	SDT varchar(20),
)

create table ADKEY
(
	ADNAME varchar(30),
	ADKEY int,
	Constraint PK_ADKEY primary key (ADNAME, ADKEY),
)

create table HANGHOA
(
	MAHANG varchar(20) primary key,		--Ma hang	
	TENHANG varchar(100),				--Ten hang
	DVT varchar(10),					--Don vi
	SOLUONG int,						--So luong
	DONGIA money,						--Don gia
	NGNHAP smalldatetime,				--Ngay nhap
	NGSANXUAT smalldatetime,			--Ngay san xuat
	HSD smalldatetime,					--Han su dung
	UKEY int foreign key references USERACC(UKEY),
)

create table ORDERS
(
	MAHOADON varchar(20) primary key,
	NGXUAT smalldatetime,
	MAHANG varchar(20) foreign key references HANGHOA(MAHANG),
	UKEY int foreign key references USERACC(UKEY),
)

