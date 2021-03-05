create database qlquan_rauma
on primary
(
	name ='qlquan_rauma1',
	filename ='D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\qlquan_rauma1.mdf',
	size=100MB,
	maxsize=1GB,
	filegrowth=20%
),
(
	name ='qlquan_rauma2',
	filename ='D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\qlquan_rauma2.ndf'
)

log on
(
	name ='qlquan_raumalog',
	filename ='D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\qlquan_rauma1.ldf',
	size=10MB,
	maxsize=50MB,
	filegrowth=10%
)

----- Tạo Bảng ----

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

alter table Account
add constraint PK_Account primary key (ID)

Create table TypeAccount
(
	ID_TAcc int not null,
	taikhoan varchar(20) not null,
	email varchar(50) not null, 
	loaiAcc nvarchar(10)
)

