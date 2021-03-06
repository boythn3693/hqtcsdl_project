USE [QuanLyLaiXe]
GO
------------------------
--- T1: Xem Thong Tin TO ------
--- T2: Xoa to ---
------------------------

--- T1----
--DROP PROCEDURE GT_XemThongTinTheoTo
CREATE PROC GT_XemThongTinTheoTo
	@MaNguoiQuanLy int
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM TOLAI WHERE QuanLy=@MaNguoiQuanLy)
		BEGIN 
			PRINT N'Khong ton tai nguoi quan ly'
			ROLLBACK TRAN
			RETURN
		END
		
		--ĐỂ TEST		WAITFOR DELAY '0:0:10'
		
		SELECT t.MaTo,t.TenTo,t1.TenTaiXe,t.NgayNhanChuc,t2.TenTaiXe
		FROM ToLai t, TAIXE t1, TAIXE t2 
		WHERE t.QuanLy=@MaNguoiQuanLy and t.QuanLy=t2.MaTaiXe and t.ToTruong=t1.MaTaiXe
		
	END TRY	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN	END CATCH
COMMIT TRAN
GO
--- T2 -----
--DROP PROCEDURE GT_DOINGUOIQUANLY
CREATE PROC GT_DOINGUOIQUANLY
	@MaTo INT,
	@QuanLy INT
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM TOLAI WHERE MaTo=@MaTo)
		BEGIN 
			PRINT N'MA TO KHONG DUNG'
			ROLLBACK TRAN
			RETURN
		END
		
		IF NOT EXISTS (SELECT * FROM TAIXE WHERE MaTaiXe=@QuanLy)
		BEGIN 
			PRINT N'KHONG TIM THAY NGUOI QUAN LY'
			ROLLBACK TRAN
			RETURN
		END
		
		PRINT N'DA CHAY T2'
		UPDATE TOLAI SET QuanLy=@QuanLy WHERE MaTo=@MaTo
		
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN
	END CATCH
COMMIT TRAN
RETURN 1
