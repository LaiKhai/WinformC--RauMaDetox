﻿create database ql_rauma
use ql_rauma
go
----- Tạo Bảng ----

create table SanPham
(
MaSp char(3) not null primary key,
TenSp int,
MaLoaiSp char(3) ,
GiaTien money,
MoTa nvarchar(20),
TrangThai bit default 1
)

create table LoaiSP
(
MaLoaiSp char(3) primary key not null,
LoaiSP nvarchar(20),
TrangThai bit default 1
)

create table NhanVien
(
ID_NV char(3) not null,
HoTen nvarchar(50),
NgaySinh datetime,
GioiTinh nvarchar(10),
ChucDanh nvarchar(30),
LoaiNV nvarchar(20),
SDT char(10),
TaiKhoan varchar(100),
MatKhau varchar(100),
Email varchar(100),
TrangThai Bit default 1,
)
create table CT_PhanQuyen
(
	ID_NV char(3),
	ID_quyen char(3),
	Taikhoan varchar(100),
	LoaiQuyen varchar(50),
	TrangThai Bit default 1
)
create table PhanQuyen
(
	ID_quyen char(3) not null,
	LoaiQuyen varchar(50)
)

create table HoaDon
(
	ID_HoaDon char(3) not null,
	ID_NV char(3),
	NgayLapHoaDon datetime,
)
create table CT_HoaDon
(
	ID_HoaDon char(3),
	MaSp char(3),
	SoLuong int,
	DonGia money,
	ChietKhau money,
	TongTien money
)




--Khóa Chính, Khóa Ngoại 
alter table SanPham
add constraint FK_SanPham_LoaiSanPham foreign key (MaLoaiSP) references LoaiSP(MaLoaiSP)

alter table NhanVien
add constraint PK_NhanVien primary key (ID_NV)

alter table PhanQuyen
add constraint PK_PhanQuyen primary key (ID_quyen)

alter table HoaDon
add constraint PK_HoaDon primary key (ID_HoaDon)

alter table CT_PhanQuyen
add constraint FK_CTPhanQuyen_PhanQuyen foreign key (ID_quyen) references PhanQuyen(ID_quyen)

alter table CT_PhanQuyen
add constraint FK_CTPhanQuyen_NhanVien foreign key (ID_NV) references NhanVien(ID_NV)

alter table CT_HoaDon
add constraint FK_CTHoaDon_HoaDon foreign key (ID_HoaDon) references HoaDon(ID_HoaDon)

alter table CT_HoaDon
add constraint FK_CTHoaDon_SanPham foreign key (MaSp) references SanPham(MaSp)

alter table HoaDon
add constraint FK_HoaDon_NhanVien foreign key (ID_NV) references NhanVien(ID_NV)