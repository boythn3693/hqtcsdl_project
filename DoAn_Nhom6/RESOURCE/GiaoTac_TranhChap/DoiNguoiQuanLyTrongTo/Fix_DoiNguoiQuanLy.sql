USE [QuanLyLaiXe]
GO
------------------------
--- T1: Xem Thong Tin TO ------
--- T2: Xoa to ---
------------------------

--- T1----
--DROP PROCEDURE GT_Fix_XemThongTinTheoTo
CREATE PROC GT_Fix_XemThongTinTheoTo
	@MaTo int
AS
BEGIN TRAN
	SET TRAN ISOLATION LEVEL REPEATABLE READ
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM TOLAI WHERE MaTo=@MaTo)
		BEGIN 
			PRINT N'MA TO KHONG DUNG'
			ROLLBACK TRAN
			RETURN
		END
		
		--ĐỂ TEST		WAITFOR DELAY '0:0:10'
		SELECT * FROM TOLAI WHERE MaTo=@MaTo
		
	END TRY	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN	END CATCH
COMMIT TRAN
