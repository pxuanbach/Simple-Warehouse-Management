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

create table HOADON
(
	MAHOADON int IDENTITY(1,1) primary key,
	TENDOITAC nvarchar(100) not null,
	THOIGIAN smalldatetime,
	TRIGIA money,
	UKEY int,
)

create table CTHD
(
	MAHOADON int foreign key references HOADON(MAHOADON),
	MAHANG varchar(20),
	SOLUONG int,
	DONGIA money,
	UKEY int,
)
---------------------------------------------
CREATE TRIGGER TRG_CK_TRIGIA_HOADON ON CTHD
FOR INSERT, UPDATE, DELETE
AS
BEGIN
	DECLARE @MAHD int, @GIA int, @UKEY int
	SELECT @MAHD = MAHOADON, @UKEY = UKEY
	FROM INSERTED
	
	SET @GIA = (SELECT SUM(DONGIA*SOLUONG) AS TRIGIA
							FROM CTHD
							WHERE MAHOADON = @MAHD and UKEY = @UKEY
							GROUP BY MAHOADON)
	IF (@GIA = NULL)
	BEGIN
		UPDATE HOADON SET TRIGIA = NULL WHERE MAHOADON = @MAHD and UKEY = @UKEY
	END
	ELSE
	BEGIN
		UPDATE HOADON SET TRIGIA = @GIA WHERE MAHOADON = @MAHD and UKEY = @UKEY
	END
END
----------------------------------------------------------------------------


insert HOADON values
(N'Công ty Thực phẩm', '2020/02/20', 50000000),
(N'Công ty Tài nguyên Môi trường', '2020/02/20', 20000000)

insert CTHD values
(3,'BB004', 19521334)

insert USERACC values
(19521334,'dat09','0','Nguyễn Đức Chí Đạt','0123456789','Nam','nguyenducchidat@gmail.com','2020/01/29','Sinh viên')

insert HANGHOA values
('AA001',N'Vở',N'quyển',100,5000,'2020/01/02',null,null, 1952),
('BB003',N'Notebook',N'quyển',20,25000,'2020/01/30',null,null, 1952),
('BB002',N'Sách giáo khoa',N'quyển',10,55000,'2020/01/30',null,null, 19521334),
('CC002',N'Kẹo cao su',N'hộp',20,20000,'2020/01/25',null,null, 19521334)

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

Select *
From USERACC

UPDATE USERACC
SET HOTEN = N'Nguyễn Đức Chí Đạt'
WHERE UKEY = 19521334

UPDATE USERACC
SET HOTEN = N'Phạm Xuân Bách'
WHERE UKEY = 19521233

Select *
from HANGHOA 
where UKEY = 19521334 and MAHANG = 'CC001' 
	and TENHANG = N'Kéo siêu bền'
	and DONGIA = 25000

Select * From HANGHOA Where UKEY = 19521334
                and MAHANG = 'CC001' and TENHANG = N'Kéo siêu bền'
                and DONGIA = 25000

UPDATE HANGHOA 
SET SOLUONG = 0
WHERE MAHANG = 'AA001'

delete from CTHD where MAHOADON = 3;

DELETE FROM HOADON;

insert CTHD values
(40,'AA003', 10, 10000, 19521334)

insert HOADON(TENDOITAC, THOIGIAN, UKEY) values
(N'Công ty Thực phẩm', '2020/02/20', 19521334)

DELETE FROM CTHD
Where MAHOADON = 25

Select MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD from HANGHOA where SOLUONG <> 0 and UKEY = 19521334

SELECT max(MAHOADON)
From HOADON

Select TENHANG, DONGIA
From HANGHOA inner join CTHD on CTHD.MAHANG = HANGHOA.MAHANG
Where HANGHOA.UKEY = CTHD.UKEY and CTHD.UKEY = 1952

Select MAHANG, SOLUONG
From CTHD 
Where UKEY = 1952

Delete From HANGHOA Where MAHANG = 'DD001' and UKEY = 19521334

Delete From HOADON