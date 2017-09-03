﻿CREATE 
--ALTER
PROC GT_THEMTUYENDUONG
	@MaTuyenDuong varchar(512) out,
	@TenTuyenDuong nvarchar(512),
	@ChieuDai int
AS
BEGIN TRAN
	BEGIN TRY
	IF EXISTS (SELECT * FROM TUYENDUONG WHERE MaTuyenDuong = @MaTuyenDuong)
	BEGIN
		PRINT CAST(@MaTuyenDuong AS VARCHAR(512)) + N' Đã Tồn Tại'
		ROLLBACK TRAN
		RETURN 1
	END
	IF @TenTuyenDuong = NULL
	BEGIN
		PRINT N'Tên tuyến đường không được để trống'
		ROLLBACK TRAN
		RETURN 1
	END
	IF @ChieuDai = 0
	BEGIN
		PRINT N'Chiều dài phải khác không'
		ROLLBACK TRAN
		RETURN 1
	END
	INSERT INTO TUYENDUONG VALUES(@MaTuyenDuong, @TenTuyenDuong, @ChieuDai)
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 1	
	END CATCH
COMMIT TRAN
RETURN 0
GO

CREATE 