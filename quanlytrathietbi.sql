create database quanlytrathietbi

use quanlytrathietbi

create table tblThietBi (
MaTB nvarchar(10),
TenTB nvarchar(30),
TinhTrang nvarchar(30),
SoLuong int,
GhiChu nvarchar(50),

primary key(MaTB)
)

create table tblPhong (
MaPhong nvarchar(10),
TenPhong nvarchar(30)
primary key (MaPhong)
)

create table tblNhanVien (
MaNV nvarchar(10),
TenNV nvarchar(30),
ChucVu nvarchar(10),
MaPhong nvarchar(10),
primary key (MaNV)
)

create table tblPhieuTra (
MaTB nvarchar(10),
NVTra nvarchar(10),
NVNhan nvarchar(10),
NgayTra datetime,
SoLuong int,
TinhTrang nvarchar(30),
MaPhong nvarchar(10),

primary key(MaTB,NVTra)
)