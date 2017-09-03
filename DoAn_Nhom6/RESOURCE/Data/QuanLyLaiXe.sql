create database QuanLyLaiXe
go
use QuanLyLaiXe

create table TAIXE(
	MaTaiXe int not null primary key identity,
	TenTaiXe nvarchar(512),
	KhaNangLai bigint,
	QuangDuong bigint,
	TenDangNhap varchar(512),
	MatKhau varchar(512),
	TinhTrang bit,
	MaTo int,
)

create table VAITRO(
	MaVaiTro int not null primary key,
	TenVaiTro nvarchar(512)
)

create table TAIXE_VAITRO(
	MaTaiXe int,
	MaVaiTro int,
	primary key (MaTaiXe, MaVaiTro),
	constraint FK_TaiXe_VaiTro_TaiXe foreign key (MaTaiXe) references TAIXE(MaTaiXe),
	constraint FK_TaiXe_VaiTro_VaiTro foreign key (MaVaiTro) references VAITRO(MaVaiTro)
)

create table TOLAI(
	MaTo int not null primary key identity,
	TenTo nvarchar(512),
	ToTruong int,
	NgayNhanChuc datetime,
	QuanLy int
)

create table LICHTRINH(
	MaLichTrinh int not null primary key identity,
	TenLichTrinh nvarchar(512), 
	DiemXuatPhat nvarchar(512),
	DiemKetThuc nvarchar(512)
)

create table TUYENDUONG(
	MaTuyenDuong varchar(512) not null primary key,
	TenTuyenDuong nvarchar(512),
	ChieuDai int
)

create table LICHTRINH_TUYENDUONG(
	MaLichTrinh int not null,
	MaTuyenDuong varchar(512) not null,
	primary key (MaLichTrinh, MaTuyenDuong),
	constraint FK_LichTrinh_TuyenDuong_LichTrinh foreign key (MaLichTrinh) references LICHTRINH(MaLichTrinh),
	constraint FK_LichTrinh_TuyenDuong_TuyenDuong foreign key (MaTuyenDuong) references TUYENDUONG(MaTuyenDuong)
)

create table TAIXE_LICHTRINH(
	MaPhanCongLichTrinh int primary key identity,
	MaTaiXe int,
	MaLichTrinh int,
	NgayPhanCong datetime,
	ThoiGianXuatPhat datetime,
	ThoiGianKetThuc datetime,
	NguoiPhanCong int,
	constraint FK_TaiXe_LichTrinh_TaiXe foreign key (MaTaiXe) references TAIXE(MaTaiXe),
	constraint FK_TaiXe_LichTrinh_LichTrinh foreign key (MaLichTrinh) references LICHTRINH(MaLichTrinh),
	constraint FK_TaiXe_LichTrinh_QuanLy foreign key (NguoiPhanCong) references TAIXE(MaTaiXe)
)

alter table TAIXE add constraint FK_TaiXe_ToLai foreign key (MaTo) references TOLAI(MaTo)
alter table TOLAI add constraint FK_ToLai_TaiXe_ToTruong foreign key (ToTruong) references TAIXE(MaTaiXe)
alter table TOLAI add constraint FK_ToLai_TaiXe_QuanLy foreign key (QuanLy) references TAIXE(MaTaiXe)

----insert data-----

insert into TOLAI(TenTo, ToTruong, NgayNhanChuc, QuanLy) values 
(N'Tổ Quận 10', null, '10/10/2016', null),
(N'Tổ Quận Bình Thạnh', null, '10/10/2016', null)

insert into TAIXE(TenTaiXe, KhaNangLai, QuangDuong, MaTo, TenDangNhap, MatKhau, TinhTrang) values
(N'Nguyễn Văn Bắc', 1000, 1050, 1, 'nvbac', '123', 1),
(N'Nguyễn Ngọc Phước', 1500, 1500, 1, 'nnphuoc', '123', 1),
(N'Lê Trần', 1200, 1500, 2, 'ltran', '123', 1),
(N'Phạm Minh Trí', 1000, 1500, 2, 'pmtri', '123', 1)

insert into VAITRO(MaVaiTro, TenVaiTro) values 
(1, N'Tài Xế'),
(2, N'Quản Lý'),
(3, N'Quản Trị')

insert into TAIXE_VAITRO(MaTaiXe, MaVaiTro) values 
(1, 3),
(2, 1),
(2, 2),
(3, 1),
(4, 1)
																	     
insert into LICHTRINH(TenLichTrinh, DiemXuatPhat, DiemKetThuc) values
(N'Bến xe miền Đông, bến xe miền Tây', N'Bến Xe Miền Đông', N'Bến Xe Miền Tây'),
(N'Bến xe miền Tây, bến xe miền Đông', N'Bến Xe Miền Tây', N'Bến Xe Miền Đông'),
(N'Đại học sư pham, đại khọc khoa hoc tự nhiên', N'Đại học sư phạm TP HCM', N'Đại học khoa học tự nhiên TP HCM'),
(N'Đại học quốc tế TP HCM, đại học Y dược TP HCM', N'Đại học quốc tế TP HCM', N'Đại học Y dược TP HCM')

insert into TUYENDUONG(MaTuyenDuong, TenTuyenDuong, ChieuDai) values
('NGUYENVANCU',N'Nguyễn Văn Cừ', 2),
('NGUYENTHIMINHKHAI',N'Nguyễn Thị Minh khai', 5),
('LYTHAITO',N'Lý Thái Tổ', 2),
('DIENBIENPHU',N'Điện Biên Phủ', 7),
('3/2', '3/2', 1),
('HONGBANG', N'Hồng Bàng', 1)

insert into LICHTRINH_TUYENDUONG(MaLichTrinh, MaTuyenDuong) values 
(1, 'DIENBIENPHU'),
(1, '3/2'),
(1, 'HONGBANG'),
(2, 'DIENBIENPHU'),
(2, '3/2'),
(2, 'HONGBANG'),
(3, 'NGUYENVANCU'),
(3, 'NGUYENTHIMINHKHAI'),
(4, 'HONGBANG'),
(4, '3/2'),
(4, 'DIENBIENPHU'),
(4, 'LYTHAITO')

update TOLAI set ToTruong = 1, QuanLy = 1 where MaTo = 1;
update TOLAI set ToTruong = 2, QuanLy = 1 where MaTo = 2;





















