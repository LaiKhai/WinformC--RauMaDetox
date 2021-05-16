﻿create database ql_rauma
use ql_rauma
go
----- Tạo Bảng ----

create table SanPham
(
MaSp nvarchar(3) not null primary key,
TenSp nvarchar(20),
MaLoaiSp nvarchar(3) ,
GiaTien money,
MoTa nvarchar(50),
Hinh image,
TrangThai bit default 1
)
go
create table LoaiSP
(
MaLoaiSp nvarchar(3) primary key not null,
LoaiSP nvarchar(20),
TrangThai bit default 1
)
go
create table NhanVien
(
IDNV nvarchar(3) not null,
HoTen nvarchar(50),
NgaySinh datetime,
GioiTinh nvarchar(10),
ChucDanh nvarchar(30),
LoaiNV nvarchar(20),
SDT char(10),
TaiKhoan varchar(100),
MatKhau varchar(100),
Email varchar(100),
TrangThai smallint,
)
go
create table CTPhanQuyen
(
	IDNV nvarchar(3),
	IDquyen nvarchar(3),
	Taikhoan varchar(100),
	LoaiQuyen varchar(50),
	TrangThai Bit default 1
)
go
create table PhanQuyen
(
	IDquyen nvarchar(3) not null,
	LoaiQuyen varchar(50)
)
go
create table HoaDon
(
	IDHoaDon nvarchar(3) not null,
	IDNV nvarchar(3),
	NgayLapHoaDon datetime,
	TrangThai smallint
)
go
create table CTHoaDon
(
	IDHoaDon nvarchar(3),
	MaSp nvarchar(3),
	SoLuong int,
	DonGia money,
	ChietKhau money,
	TongTien money
)
go



--Khóa Chính, Khóa Ngoại 
alter table SanPham
add constraint FK_SanPham_LoaiSanPham foreign key (MaLoaiSP) references LoaiSP(MaLoaiSP)
go
alter table NhanVien
add constraint PK_NhanVien primary key (IDNV)
go
alter table PhanQuyen
add constraint PK_PhanQuyen primary key (IDquyen)
go
alter table HoaDon
add constraint PK_HoaDon primary key (IDHoaDon)
go
alter table CTPhanQuyen
add constraint FK_CTPhanQuyen_PhanQuyen foreign key (IDquyen) references PhanQuyen(IDquyen)
go
alter table CTPhanQuyen
add constraint FK_CTPhanQuyen_NhanVien foreign key (IDNV) references NhanVien(IDNV)
go
alter table CTHoaDon
add constraint FK_CTHoaDon_HoaDon foreign key (IDHoaDon) references HoaDon(IDHoaDon)
go
alter table CTHoaDon
add constraint FK_CTHoaDon_SanPham foreign key (MaSp) references SanPham(MaSp)
go
alter table HoaDon
add constraint FK_HoaDon_NhanVien foreign key (IDNV) references NhanVien(IDNV)
go