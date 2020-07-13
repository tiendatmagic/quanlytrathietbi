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
insert into tblThietBi values ('TB01',N'Chuột',N'Hư hỏng nặng',1,N'Cần thay thể gấp')
insert into tblThietBi values ('TB02',N'Bàn phím',N'Gõ không ăn',1,N'Cần thay thể gấp')
insert into tblThietBi values ('TB03',N'Màn hình',N'Có điểm chết',1,N'Cần bảo hành')

create table tblPhong (
MaPhong nvarchar(10),
TenPhong nvarchar(30)
primary key (MaPhong)
)
insert into tblPhong values ('PH01',N'Thường')
insert into tblPhong values ('PH02',N'Cao cấp')
insert into tblPhong values ('PH03',N'VIP')

create table tblNhanVien (
MaNV nvarchar(10),
TenNV nvarchar(30),
ChucVu nvarchar(30),
MaPhong nvarchar(10),
primary key (MaNV)
)



insert into tblNhanVien values ('NV01',N'Phan Cư Chánh',N'Nhân Viên quèn','PH01')
insert into tblNhanVien values ('NV02',N'Nguyễn Quốc Việt',N'Nhân Viên quèn','PH02')
insert into tblNhanVien values ('NV03',N'Cao Tiến Đạt',N'Giám đốc','PH03')

create table tblPhieuTra (
MaTB nvarchar(10),
NVTra nvarchar(30),
NVNhan nvarchar(30),
NgayTra datetime,
SoLuong int,
TinhTrang nvarchar(30),
MaPhong nvarchar(10),
primary key(MaTB,NVTra)
)



insert into tblPhieuTra values ('TB01',N'Cao Tiến Đạt',N'Phan Cư Chánh','2020-7-13',3,N'Hư hỏng nặng','PH01')
insert into tblPhieuTra values ('TB02',N'Cao Tiến Đạt',N'Nguyễn Quốc Việt','2020-7-13',2,N'Hư hỏng nặng','PH02')
insert into tblPhieuTra values ('TB03',N'Nguyễn Quốc Việt',N'Phan Cư Chánh','2020-7-14',4,N'Hư hỏng nặng','PH03')
