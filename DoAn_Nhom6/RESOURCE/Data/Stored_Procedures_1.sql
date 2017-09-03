use QuanLyLaiXe
--Tuyến Đường--
----Select Tuyen Duong
CREATE PROCEDURE sp_SelectAllTuyenDuong
AS
	SELECT * FROM TUYENDUONG
GO
----Select Tuyen Duong By MaTuyenDuong
CREATE PROCEDURE sp_SelectTuyenDuong_MaTuyenDuong
	(@MaTuyenDuong varchar(512))
AS
	SELECT * FROM TUYENDUONG WHERE MaTuyenDuong=@MaTuyenDuong
GO
----Them Tuyen Duong
CREATE PROCEDURE sp_ThemTuyenDuong(
		@MaTuyenDuong varchar(512) out,
		@TenTuyenDuong nvarchar(512),
		@ChieuDai int )
AS
	IF EXISTS (SELECT * FROM TUYENDUONG WHERE TenTuyenDuong = @TenTuyenDuong)
	BEGIN 
		raiserror ('LỖI: Tuyến đường đã tồn tại', 16, 1)
		return
	END
	INSERT INTO TUYENDUONG VALUES(@MaTuyenDuong, @TenTuyenDuong, @ChieuDai)
	SET @MaTuyenDuong = (SELECT Scope_Identity())
GO

----Sua Tuyen Duong
CREATE PROCEDURE sp_SuaTuyenDuong(
		@MaTuyenDuong varchar(512),
		@TenTuyenDuong nvarchar(512),
		@ChieuDai int )
AS
	IF NOT EXISTS (SELECT * FROM TUYENDUONG WHERE MaTuyenDuong = @MaTuyenDuong)
	BEGIN 
		raiserror ('LỖI: Tuyến đường không tồn tại', 16, 1)
		return
	END
	UPDATE TUYENDUONG SET TenTuyenDuong=TenTuyenDuong, ChieuDai=@ChieuDai WHERE MaTuyenDuong=@MaTuyenDuong
GO

---Xoa Tuyen Duong
CREATE PROCEDURE sp_XoaTuyenDuong(
		@MaTuyenDuong varchar(512))
AS
	IF NOT EXISTS (SELECT * FROM TUYENDUONG WHERE MaTuyenDuong = @MaTuyenDuong)
	BEGIN 
		raiserror ('LỖI: Tuyến đường không tồn tại', 16, 1)
		return
	END
	DELETE FROM TUYENDUONG WHERE MaTuyenDuong=@MaTuyenDuong
GO
--Tổ lái--
----Select All ToLai
CREATE PROCEDURE sp_SelectAllToLai
AS
	SELECT * FROM ToLai
GO

----Select ToLai By MaTo
CREATE PROCEDURE sp_SelectToLai_MaTo
(@MaTo int)
AS
	SELECT * FROM ToLai WHERE MaTo=@MaTo
GO
--Them Tolai
CREATE PROCEDURE sp_ThemToLai(
		@MaTo int out,
		@TenTo nvarchar(512),
		@ToTruong int,
		@NgayNhanChuc datetime )
AS
	IF EXISTS (SELECT * FROM TOLAI WHERE TenTo = @TenTo)
	BEGIN 
		raiserror ('LỖI: Tên tổ đã tồn tại', 16, 1)
		return
	END
	IF EXISTS (SELECT * FROM TOLAI WHERE ToTruong=@ToTruong)
	BEGIN 
		raiserror ('LỖI: Tài xế này đã làm tổ trưởng 1 tổ khác', 16, 1)
		return
	END
	INSERT INTO TOLAI  VALUES(@TenTo, @ToTruong, @NgayNhanChuc)
	SET @MaTo = (SELECT Scope_Identity())
GO
--Sửa tổ lái
CREATE PROCEDURE sp_SuaToLai(
		@MaTo int,
		@TenTo nvarchar(64),
		@ToTruong int,
		@NgayNhanChuc datetime )
AS
	IF NOT EXISTS (SELECT * FROM TOLAI WHERE @MaTo = @MaTo)
	BEGIN 
		raiserror ('LỖI: Mã Tổ không tồn tại ', 16, 1)
		return
	END
	UPDATE TOLAI SET TenTo=@TenTo, ToTruong=@ToTruong, NgayNhanChuc=@NgayNhanChuc WHERE MaTo=@MaTo
GO

---Xoa To lai
CREATE PROCEDURE sp_XoaToLai( @MaTo int )
AS
	IF NOT EXISTS (SELECT * FROM TOLAI WHERE MaTo = @MaTo)
	BEGIN 
		raiserror ('LỖI: Mã Tổ không tồn tại', 16, 1)
		return
	END
	DELETE FROM TOLAI WHERE MaTo=@MaTo
GO