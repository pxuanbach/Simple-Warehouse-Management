create database WarehouseManagement
go

use WarehouseManagement
go

create table ADMINACC
(
	ADNAME varchar(30) primary key,
	ADPASS varchar(30),
)

create table USERACC
(
	UKEY int primary key,
	USERNAME varchar(30),
	USERPASS varchar(30),
	HOTEN nvarchar(100),
	SDT int,
	GIOITINH nvarchar(5),
	EMAIL varchar(100),
	BIRTHDAY smalldatetime,
	POSITION nvarchar(50),
)
--USERNAME,USERPASS,HOTEN,SDT,GIOITINH,EMAIL,BIRTHDAY,POSITION

create table ADKEY
(
	ADNAME varchar(30),
	ADKEY int,
	Constraint PK_ADKEY primary key (ADNAME, ADKEY),
)

create table HANGHOA
(
	MAHANG varchar(20),					--Ma hang	
	TENHANG nvarchar(100),				--Ten hang
	DVT nvarchar(10),					--Don vi
	SOLUONG int,						--So luong
	DONGIA money,						--Don gia
	NGNHAP smalldatetime,				--Ngay nhap
	NGSANXUAT smalldatetime,			--Ngay san xuat
	HSD smalldatetime,					--Han su dung
	UKEY int,
	Constraint PK_HANGHOA primary key (MAHANG, UKEY),
)
--MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD

create table ORDERS
(
	MAHOADON nvarchar(20) primary key,
	NGXUAT smalldatetime,
	MAHANG varchar(20),
	UKEY int,
)

---------------------------------------------
ALTER TABLE ORDERS
   ADD CONSTRAINT FK_MAHANG_UKEY
   FOREIGN KEY(MAHANG, UKEY)
   REFERENCES HANGHOA(MAHANG, UKEY)
---------------------------------------------




insert USERACC values
(19521334,'dat09','0','Nguyễn Đức Chí Đạt','0123456789','Nam','nguyenducchidat@gmail.com','2020/01/29','Sinh viên')

insert HANGHOA values
('AA001','Vở','quyển',100,5000,'2020/01/02',null,null, 19521334),
('BB003','Notebook','quyển',20,25000,'2020/01/30',null,null, 19521334),
('BB004','Sách giáo khoa','quyển',10,55000,'2020/01/30',null,null, 19521334),
('CC002','Kẹo cao su','hộp',20,20000,'2020/01/25',null,null, 19521334)

--delete from HANGHOA where MAHANG='C0022';

insert USERACC values (19521233, 'bach', '1', 'Phạm Xuân Bách', '0372363285','Nam','phamxuanbach@gmail.com','2001/03/30','Sinh viên')

Select HANGHOA.MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD from HANGHOA inner join USERACC on USERACC.UKEY=HANGHOA.UKEY where USERNAME ='dat09'

Select USERNAME,USERPASS,HOTEN,SDT,GIOITINH,EMAIL,BIRTHDAY,POSITION From USERACC Where USERNAME = 'username'

Select BIRTHDAY From USERACC Where USERNAME = 'dat09'

Select MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD from HANGHOA where UKEY = 333

UPDATE HANGHOA 
SET MAHANG = 'TH001', TENHANG ='keo ngot', DVT = 'bit',
	SOLUONG = 1000, DONGIA = 2000, NGNHAP = '2020-10-19', 
	NGSANXUAT = '2020-10-19' , HSD = '2020-10-19' 
WHERE MAHANG = 'TH001'

UPDATE HANGHOA 
SET MAHANG = 'AA011', TENHANG ='vo 100 trang', DVT = 'quyen',SOLUONG = 200, DONGIA = 20000, 
NGNHAP = '2020-11-06 22:22:00', NGSANXUAT = '2020-11-06 22:22:00' , HSD = '2020-11-06 22:22:00' 
WHERE MAHANG = 'AA011'

Select * 
From HANGHOA
Where CHARINDEX('vo',HANGHOA.TENHANG) != 0
