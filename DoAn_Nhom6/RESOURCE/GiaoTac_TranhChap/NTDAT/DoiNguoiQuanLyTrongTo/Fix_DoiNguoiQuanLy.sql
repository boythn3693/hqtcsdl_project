USE [QuanLyLaiXe]
GO
------------------------
--- T1: Xem Thong Tin TO ------
--- T2: Xoa to ---
------------------------

--- T1----
--DROP PROCEDURE GT_Fix_XemThongTinTheoTo
CREATE PROC GT_Fix_XemThongTinTheoTo
	@MaNguoiQuanLy int
AS
BEGIN TRAN
	SET TRAN ISOLATION LEVEL REPEATABLE READ
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM TOLAI WHERE QuanLy=@MaNguoiQuanLy)
		BEGIN 
			PRINT N'MA TO KHONG DUNG'
			ROLLBACK TRAN
			RETURN
		END
		
		--ĐỂ TEST		WAITFOR DELAY '0:0:10'
		SELECT t.MaTo,t.TenTo,t1.TenTaiXe,t.NgayNhanChuc,t2.TenTaiXe
		FROM ToLai t, TAIXE t1, TAIXE t2 
		WHERE t.QuanLy=@MaNguoiQuanLy and t.QuanLy=t2.MaTaiXe and t.ToTruong=t1.MaTaiXe
		
	END TRY	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN	END CATCH
COMMIT TRAN
