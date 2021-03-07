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
    MaSP int not null primary key,
    TenSP nvarchar(100) not null ,
    GiaSP int,
    TenLoai nvarchar(100),   
)

create table PhanLoaiSanPham
(
   MaSP int not null,
   TenLoai nvarchar(100),
)

create table NhanVien
(
ID_NV int  not null,
HoTen nvarchar(50),
LoaiNV nvarchar(2),
ChucDanh nvarchar(20)
)

create table ChamCong
(
ID_NV int not null,
Hoten Nvarchar(50),
LoaiNV nvarchar(2),
Tonggio int,
)

create table HoaDon
(
	ID_HoaDon int not null,
	ID_NV int,
	TenSP nvarchar(100),
	NgayLapHD datetime,
)

create table CT_HoaDon
(
	ID_HoaDon int not null,
	MaSP int not null,
	SoLuong int,
	GiaTien money,
	ChietKhau money
)
--Khóa Chính, Khóa Ngoại --
alter table PhanLoaiSanPham
add constraint PK_PhanLoaiSP primary key (MaSP)

alter table CT_HoaDon
add constraint PK_CTHoaDon primary key (ID_HoaDon,MaSP)

alter table Account
add constraint PK_Account primary key (taikhoan)

alter table TypeAccount
add constraint PK_TypeAccount primary key (ID_TAcc)

alter table UserPermission
add constraint PK_User_Permission primary key (ID_User_Permission)

alter table Permission
add constraint PK_Permission primary key (ID_per)

alter table NhanVien
add constraint PK_NhanVien primary key(ID_NV)

alter table ChamCong
add constraint FK_ChamCong primary key(ID_NV)

alter table HoaDon
add constraint PK_HoaDon primary key (ID_HoaDon)

alter table TypeAccount
add constraint FK_TypeAccount foreign key (taikhoan) references Account(taikhoan)

alter table UserPermission
add constraint FK_UserPermission foreign key (ID_TAcc) references TypeAccount(ID_TAcc)

alter table UserPermission
add constraint FK_UserPermission_per foreign key (ID_per) references Permission(ID_per)

alter table ChamCong
add constraint FK_NhanVien foreign key (ID_NV) references NhanVien(ID_NV)

alter table Account
add constraint FK_Account foreign key (ID) references NhanVien(ID_NV)

alter table CT_HoaDon
add constraint FK_CTHoaDon_HoaDon foreign key (ID_HoaDon) references HoaDon(ID_HoaDon)

alter table CT_HoaDon
add constraint FK_CTHoaDon_Menu foreign key (MaSP) references Menu(MaSP)

alter table PhanLoaiSanPham
add constraint FK_PhanLoaiSP_Menu foreign key (MaSP) references Menu(MaSP)

alter table HoaDon
add constraint FK_HoaDon_NhanVien foreign key (ID_NV) references NhanVien(ID_NV)
