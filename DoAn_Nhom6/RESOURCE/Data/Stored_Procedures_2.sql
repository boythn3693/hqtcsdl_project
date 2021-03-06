USE [QuanLyLaiXe]


CREATE PROCEDURE sp_DSTaiKhoan
AS
	SELECT TenDangNhap, MatKhau FROM TAIXE
GO

CREATE PROCEDURE sp_LayThongTinTheoTen
	@TENDANGNHAP VARCHAR(512)
AS
	SELECT TenDangNhap, MatKhau FROM TAIXE WHERE TenDangNhap=@TENDANGNHAP
GO

-----DANG NHAP-----

CREATE PROCEDURE sp_DANGNHAP(
	@TENDANGNHAP VARCHAR(512),
	@MATKHAU VARCHAR(512)
)
AS
	IF EXISTS (SELECT * FROM TAIXE WHERE TenDangNhap=@TENDANGNHAP AND MatKhau=@MATKHAU)
	BEGIN 
		Return 1
	END
	ELSE
	BEGIN 
		Raiserror ('LỖI: Đăng nhập không thành công.', 16, 1)
		Return
	END
GO

---------------------
---------------------
---- BANG TAI XE ----
--- SELECT ALL ------
CREATE PROCEDURE sp_DANHSACH_TAIXE
AS
	SELECT * FROM TAIXE
GO

CREATE PROCEDURE sp_DANHSACH_QUANLY
AS
	SELECT T.MaTaiXe, T.TenTaiXe FROM TAIXE T
GO
--- TIM KIEM ---
CREATE PROCEDURE sp_TIMKIEM_TAIXE(
	@TENTAIXE varchar(512)
)
AS
	SELECT * FROM TAIXE WHERE MaTaiXe = @TENTAIXE
GO
--- FUNCTION KIEM TRA TAI XE TRONG TO ---
CREATE FUNCTION KIEMTRA(
	@MATO INT
)
RETURNS INT
AS
BEGIN
	RETURN (SELECT COUNT(MaTo) FROM TAIXE WHERE MaTo=@MATO)
END
GO
--- INSERT ---
CREATE PROCEDURE sp_THEM_TAIXE(
	@TenTaiXe varchar(512),
	@KhaNangLai bigint,
	@QuangDuong bigint,
	@TenDangNhap varchar(512),
	@MatKhau varchar(512),
	@TinhTrang bit,
	@MaTo int
)
AS
	DECLARE @KQ INT
	SET @KQ = (SELECT dbo.KIEMTRA(@MaTo))
	IF(@KQ > 10)
	BEGIN
		raiserror ('TỔ CHỈ CHO PHÉP TỐI ĐA 10 THÀNH VIÊN', 16, 1)
		return
	END
	INSERT INTO TAIXE VALUES(@TenTaiXe, @KhaNangLai,@QuangDuong, @TenDangNhap,@MatKhau,@TinhTrang,@MaTo)
GO
--- UPDATE ---
CREATE PROCEDURE sp_CAPNHAT_TAIXE(
	@MaTaiXe int,
	@TenTaiXe varchar(512),
	@KhaNangLai bigint,
	@QuangDuong bigint,
	@MatKhau varchar(512),
	@TinhTrang bit,
	@MaTo int
)
AS
	UPDATE TAIXE SET TenTaiXe=@TenTaiXe, KhaNangLai=@KhaNangLai, QuangDuong=@QuangDuong,MatKhau=@MatKhau, TinhTrang=@TinhTrang,MaTo=@MaTo WHERE MaTaiXe=@MaTaiXe
GO
--- DELETE ---
CREATE PROCEDURE sp_XOA_TAIXE(
	@MaTaiXe int
)
AS
	IF NOT EXISTS (SELECT * FROM TAIXE WHERE MaTaiXe = @MaTaiXe)
	BEGIN 
		raiserror ('LỖI: Tài xế không tồn tại', 16, 1)
		return
	END
	DELETE FROM TAIXE WHERE MaTaiXe = @MaTaiXe
GO

------------------------------
------------------------------
---- BANG TAIXE_LICHTRINH ----
-------- SELECT ALL ----------
CREATE PROCEDURE sp_DANHSACH_TAIXE_LICHTRINH
AS
	SELECT t.TenTaiXe, l.TenLichTrinh, t_L.NgayPhanCong, t_l.ThoiGianXuatPhat, t_l.ThoiGianKetThuc,t_l.NgayPhanCong,l.DiemXuatPhat,l.DiemKetThuc,td.TenTuyenDuong,td.ChieuDai
	FROM TAIXE_LICHTRINH t_l, TAIXE t, LICHTRINH l, LICHTRINH_TUYENDUONG lt_td, TUYENDUONG td
	WHERE t_l.MaTaiXe=t.MaTaiXe AND t_l.MaLichTrinh=l.MaLichTrinh and l.MaLichTrinh=lt_td.MaLichTrinh and lt_td.MaTuyenDuong=td.MaTuyenDuong
GO
--- TIM KIEM ---
CREATE PROCEDURE sp_TIMKIEM_TAIXE_LICHTRINH(
	@MATAIXE INT,
	@TENTAIXE varchar(512),
	@TENLICHTRINH varchar(512),
	@NGAYPHANCONG DATETIME
)
AS
	SELECT t.TenTaiXe, l.TenLichTrinh, t_L.NgayPhanCong, t_l.ThoiGianXuatPhat, t_l.ThoiGianKetThuc,t_l.NgayPhanCong,l.DiemXuatPhat,l.DiemKetThuc 
	FROM TAIXE_LICHTRINH t_l, TAIXE t, LICHTRINH l
	WHERE t.MaTaiXe=@MATAIXE and t.TenTaiXe=@TENTAIXE and t_l.NgayPhanCong=@NGAYPHANCONG and l.TenLichTrinh=@TENLICHTRINH and t_l.MaTaiXe=t.MaTaiXe AND t_l.MaLichTrinh=l.MaLichTrinh
GO
--- INSERT ---
CREATE PROCEDURE sp_THEM_TAIXE_LICHTRINH(
	@MaTaiXe int,
	@MaLichTrinh int,
	@NgayPhanCong datetime,
	@ThoiGianXuatPhat datetime,
	@ThoiGianKetThuc datetime,
	@NguoiPhanCong int
)
AS
	IF NOT EXISTS (SELECT * FROM LICHTRINH WHERE MaLichTrinh=@MaLichTrinh)
	BEGIN 
		raiserror ('LỖI: Lich trình không tồn tại', 16, 1)
		return
	END
	IF NOT EXISTS (SELECT * FROM TAIXE WHERE MaTaiXe=@MaTaiXe)
	BEGIN 
		raiserror ('LỖI: Tài xế không tồn tại', 16, 1)
		return
	END
	INSERT INTO TAIXE_LICHTRINH VALUES(@MaTaiXe, @MaLichTrinh, @NgayPhanCong, @ThoiGianXuatPhat, @ThoiGianKetThuc, @NguoiPhanCong)
GO
--- DELETE ---
CREATE PROCEDURE sp_XOA_TAIXE_LICHTRINH(
	@MaPhanCongLichTrinh int
)
AS
	IF NOT EXISTS (SELECT * FROM TAIXE_LICHTRINH WHERE MaPhanCongLichTrinh=@MaPhanCongLichTrinh)
	BEGIN 
		raiserror ('LỖI: Phân công lịch trình không tồn tại', 16, 1)
		return
	END
	DELETE FROM TAIXE_LICHTRINH WHERE MaPhanCongLichTrinh=@MaPhanCongLichTrinh
GO
--- UPDATE ---
CREATE PROCEDURE sp_CAPNHAT_TAIXE_LICHTRINH(
	@MaPhanCongLichTrinh int,
	@MaTaiXe int,
	@MaLichTrinh int,
	@NgayPhanCong datetime,
	@ThoiGianXuatPhat datetime,
	@ThoiGianKetThuc datetime,
	@NguoiPhanCong int
)
AS
	IF NOT EXISTS (SELECT * FROM TAIXE_LICHTRINH WHERE MaPhanCongLichTrinh=@MaPhanCongLichTrinh)
	BEGIN 
		raiserror ('LỖI: Phân công lịch trình không tồn tại', 16, 1)
		return
	END
	IF NOT EXISTS (SELECT * FROM LICHTRINH WHERE MaLichTrinh=@MaLichTrinh)
	BEGIN 
		raiserror ('LỖI: Lich trình không tồn tại', 16, 1)
		return
	END
	IF NOT EXISTS (SELECT * FROM TAIXE WHERE MaTaiXe=@MaTaiXe)
	BEGIN 
		raiserror ('LỖI: Tài xế không tồn tại', 16, 1)
		return
	END
	UPDATE TAIXE_LICHTRINH 
	SET ThoiGianXuatPhat=@ThoiGianXuatPhat, ThoiGianKetThuc=@ThoiGianKetThuc, NguoiPhanCong=@NguoiPhanCong, MaTaiXe=@MaTaiXe, MaLichTrinh=@MaLichTrinh,NgayPhanCong=@NgayPhanCong
	WHERE MaPhanCongLichTrinh=@MaPhanCongLichTrinh
GO

------------------------------
------------------------------
------- BANG LICHTRINH -------
-------- SELECT ALL ----------
CREATE PROCEDURE sp_LICHTRINH
AS
	SELECT l.MaLichTrinh, l.TenLichTrinh, l.DiemXuatPhat,l.DiemKetThuc,td.TenTuyenDuong,td.ChieuDai
	FROM LICHTRINH l, LICHTRINH_TUYENDUONG lt_td, TUYENDUONG td
	WHERE l.MaLichTrinh=td.MaLichTrinh and lt_td.MaTuyenDuong=td.MaTuyenDuong
GO
------ TIM KIEM -----
CREATE PROCEDURE sp_TIMKIEM_LICHTRINH(
	@TENLICHTRINH varchar(512),
	@TENTUYENDUONG varchar(512)
)
AS
	SELECT l.MaLichTrinh, l.TenLichTrinh, l.DiemXuatPhat,l.DiemKetThuc,td.TenTuyenDuong,td.ChieuDai
	FROM LICHTRINH l, LICHTRINH_TUYENDUONG lt_td, TUYENDUONG td
	WHERE l.MaLichTrinh=td.MaLichTrinh and lt_td.MaTuyenDuong=td.MaTuyenDuong and l.TenLichTrinh=@TENLICHTRINH and td.TenTuyenDuong=@TENTUYENDUONG
GO
------ INSERT -------
CREATE PROCEDURE sp_THEM_LICHTRINH(
	@TENLICHTRINH NVARCHAR(512),
	@DIEMXUATPHAT NVARCHAR(512),
	@DIEMKETTHUC NVARCHAR(512)
)
AS
	INSERT INTO TAIXE_LICHTRINH VALUES(@TENLICHTRINH, @DIEMXUATPHAT, @DIEMKETTHUC)
GO
------ DELETE -------
CREATE PROCEDURE sp_XOA_LICHTRINH(
	@MALICHTRINH INT
)
AS
	IF NOT EXISTS (SELECT * FROM LICHTRINH WHERE MaLichTrinh=@MALICHTRINH)
	BEGIN 
		raiserror ('LỖI:lịch trình không tồn tại', 16, 1)
		return
	END
	DELETE FROM LICHTRINH WHERE MaLichTrinh=@MALICHTRINH
GO
------ UPDATE -------
CREATE PROCEDURE sp_CAPNHAT_LICHTRINH(
	@MALICHTRINH INT,
	@TENLICHTRINH NVARCHAR(512),
	@DIEMXUATPHAT NVARCHAR(512),
	@DIEMKETTHUC NVARCHAR(512)
)
AS
	IF NOT EXISTS (SELECT * FROM LICHTRINH WHERE MaLichTrinh=@MALICHTRINH)
	BEGIN 
		raiserror ('LỖI:lịch trình không tồn tại', 16, 1)
		return
	END
	UPDATE LICHTRINH
	SET TenLichTrinh=@TENLICHTRINH, DiemXuatPhat=@DIEMXUATPHAT, DiemKetThuc=@DIEMKETTHUC
	WHERE MaLichTrinh=@MALICHTRINH	
GO

-----------------------------------------
-----------------------------------------
------- BANG LICHTRINH_TUYENDUONG -------
------------- SELECT ALL ----------------
------ INSERT -------
CREATE PROCEDURE sp_THEM_LICHTRINH_TUYENDUONG(
	@MALICHTRINH INT,
	@MATUYENDUONG NVARCHAR(512)
)
AS
	IF NOT EXISTS (SELECT * FROM LICHTRINH WHERE MaLichTrinh=@MALICHTRINH)
	BEGIN 
		raiserror ('LỖI:lịch trình không tồn tại', 16, 1)
		return
	END
	IF NOT EXISTS (SELECT * FROM TUYENDUONG WHERE MaTuyenDuong=@MATUYENDUONG)
	BEGIN 
		raiserror ('LỖI:Tuyến đường không tồn tại', 16, 1)
		return
	END
	IF EXISTS (SELECT * FROM LICHTRINH_TUYENDUONG WHERE MaTuyenDuong=@MATUYENDUONG AND MaLichTrinh=@MALICHTRINH)
	BEGIN 
		raiserror ('LỖI:Lịch trình tuyến đường đã tồn tại', 16, 1)
		return
	END
	INSERT INTO LICHTRINH_TUYENDUONG VALUES(@MALICHTRINH,@MATUYENDUONG)
GO
------ DELETE -------
CREATE PROCEDURE sp_XOA_LICHTRINH_TUYENDUONG(
	@MALICHTRINH INT,
	@MATUYENDUONG NVARCHAR(512)
)
AS
	IF NOT EXISTS (SELECT * FROM LICHTRINH WHERE MaLichTrinh=@MALICHTRINH)
	BEGIN 
		raiserror ('LỖI:lịch trình không tồn tại', 16, 1)
		return
	END
	IF NOT EXISTS (SELECT * FROM TUYENDUONG WHERE MaTuyenDuong=@MATUYENDUONG)
	BEGIN 
		raiserror ('LỖI:Tuyến đường không tồn tại', 16, 1)
		return
	END
	DELETE FROM LICHTRINH_TUYENDUONG WHERE MaLichTrinh=@MALICHTRINH AND MaTuyenDuong=@MATUYENDUONG
GO