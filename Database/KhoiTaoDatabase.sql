create database ql_rauma
on primary
(
	name ='qlquan_rauma1',
	filename ='D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\WinformC--RauMaDetox\qlquan_rauma1.mdf',
	size=100MB,
	maxsize=1GB,
	filegrowth=20%
),
(
	name ='qlquan_rauma2',
	filename ='D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\WinformC--RauMaDetox\qlquan_rauma2.ndf'
)

log on
(
	name ='qlquan_raumalog',
	filename ='D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\WinformC--RauMaDetox\qlquan_raumalog.ldf',
	size=10MB,
	maxsize=50MB,
	filegrowth=10%
)

----- Tạo Bảng ----

-- Tài Khoản, Phân quyền --
Create table Account
(
	ID int not null,
	taikhoan varchar(20) not null,
	matkhau varchar(20) not null,
	email varchar(50) not null,
	hoten nvarchar(50) not null,
	loaiAcc nvarchar(10),
	trangthai nvarchar(10)
)

Create table TypeAccount
(
	ID_TAcc int not null,
	taikhoan varchar(20) not null,
	email varchar(50) not null, 
	loaiAcc nvarchar(10)
)

create table Permission
(
	ID_per int not null,
	Typepermission varchar(20)
)

create table UserPermission
(
	ID_User_Permission int not null,
	ID_TAcc int,
	ID_per int,
	taikhoan varchar(20),
	loaiAcc nvarchar(10)
)

create table Menu
(
    MaSP int ,
    TenSP nvarchar(100) not null ,
    GiaSP int,
    TenLoai nvarchar(100),
    
)

create table PhanLoaiSanPhan
(
   MaSP int primary key ,
   TenLoai nvarchar(100),
)

--Khóa Chính, Khóa Ngoại --

alter table Account
add constraint PK_Account primary key (taikhoan)

alter table TypeAccount
add constraint PK_TypeAccount primary key (ID_TAcc)

alter table UserPermission
add constraint PK_User_Permission primary key (ID_User_Permission)

alter table Permission
add constraint PK_Permission primary key (ID_per)

alter table TypeAccount
add constraint FK_TypeAccount foreign key (taikhoan) references Account(taikhoan)

alter table UserPermission
add constraint FK_UserPermission foreign key (ID_TAcc) references TypeAccount(ID_TAcc)

alter table UserPermission
add constraint FK_UserPermission_per foreign key (ID_per) references Permission(ID_per)