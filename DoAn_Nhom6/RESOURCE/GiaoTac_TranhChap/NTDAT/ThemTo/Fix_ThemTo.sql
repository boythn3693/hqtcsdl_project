USE [QuanLyLaiXe]
GO
------------------------
----- T1: THEM THONG TIN TO ------
------------------------

--- T1----
--DROP PROCEDURE GT_Fix_XemDanhSachTo
CREATE PROC GT_Fix_XemDanhSachTo
AS
BEGIN TRAN
	SET TRAN ISOLATION LEVEL Serializable
	BEGIN TRY
		Declare @slt int
		Set @slt = (SELECT COUNT(MaTo) FROM TOLAI)
		
		--ĐỂ TEST		WAITFOR DELAY '0:0:10'
		
		SELECT T.MaTo,T.TenTo,TX1.TenTaiXe,T.NgayNhanChuc,TX2.TenTaiXe
		FROM TOLAI T, TAIXE TX1, TAIXE TX2 
		WHERE T.ToTruong=TX1.MaTaiXe AND T.QuanLy=TX2.MaTaiXe
					
	END TRY	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN	END CATCH
COMMIT TRAN
RETURN 0