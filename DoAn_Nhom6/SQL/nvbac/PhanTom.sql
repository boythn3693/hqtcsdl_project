﻿DROP PROC PROC_XOATOLAI 
PROC PROC_THEMTAIXELATOTRUONG
	@TenTaiXe NVARCHAR(512),
	@KhaNangLai INT,
	@QuangDuong INT,
	@TenDangNhap VARCHAR(512),
	@MatKhau VARCHAR(512),
	@TinhTrang BIT,
	@MaTo INT
AS
BEGIN TRAN
	BEGIN TRY
		IF EXISTS (SELECT * 
					FROM TAIXE
					WHERE TenDangNhap = @TenDangNhap)
		BEGIN 
			PRINT @TenDangNhap + N'ĐÃ TỒN TẠI TRONG HỆ THỐNG'
			ROLLBACK TRAN
			RETURN 1
		END 
		IF @TenTaiXe IS NULL 
		BEGIN 
			PRINT N'TÊN TÀI XẾ KHÔNG ĐƯỢC TRỐNG'
			ROLLBACK TRAN
			RETURN 1
		END 
		IF @KhaNangLai < 0
		BEGIN
			PRINT N'KHẢ NĂNG LÁI PHẢI LÀ SỐ LỚN HƠN HOẶC BẰNG 0'
			ROLLBACK TRAN
			RETURN 1 
		END 
		IF @QuangDuong <= 0
		BEGIN 
			PRINT N'QUÃNG ĐƯỜNG LÁI PHẢI LỚN HƠN 0'
			ROLLBACK TRAN
			RETURN 1
		END 
		IF @TenDangNhap IS NULL
		BEGIN 
			PRINT N'TÊN ĐĂNG NHẬP KHÔNG ĐƯỢC TRỐNG'
			ROLLBACK TRAN
			RETURN 1
		END 
		IF @MatKhau IS NULL
		BEGIN 
			PRINT N'MẬT KHẨU KHÔNG ĐƯỢC TRỐNG'
			ROLLBACK TRAN
			RETURN 1
		END
	INSERT INTO TAIXE(TenTaiXe, KhaNangLai, QuangDuong, TenDangNhap, MatKhau, TinhTrang, MaTo) 
		VALUES(@TenTaiXe, @KhaNangLai, @QuangDuong, @TenDangNhap, @MatKhau, @TinhTrang, @MaTo)
	DECLARE @MaTaiXe INT
	SET @MaTaiXe = (SELECT MaTaiXe FROM TAIXE WHERE TenDangNhap = @TenDangNhap)
	UPDATE TOLAI
	SET ToTruong = @MaTaiXe
	WHERE MaTo = @MaTo
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
	END CATCH
COMMIT TRAN
RETURN 0
GO