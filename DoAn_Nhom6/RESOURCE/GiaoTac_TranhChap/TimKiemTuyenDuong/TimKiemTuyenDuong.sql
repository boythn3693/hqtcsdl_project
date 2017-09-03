﻿CREATE 
--ALTER
PROC GT_XEMTUYENDUONG
	@MaTuyenDuong varchar(512)
AS
BEGIN TRAN
	BEGIN TRY
	SELECT * FROM TUYENDUONG WHERE MaTuyenDuong = @MaTuyenDuong
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 1	
	END CATCH
COMMIT TRAN
RETURN 0
GO

CREATE --ALTERPROC GT_XOATUYENDUONG	@MaTuyenDuong CHAR(12)ASSET TRAN ISOLATION LEVEL REPEATABLE READBEGIN TRAN	BEGIN TRY		IF NOT EXISTS (SELECT * FROM TUYENDUONG WHERE MaTuyenDuong = @MaTuyenDuong)		BEGIN			PRINT  @MaTuyenDuong + N' KHÔNG TỒN TẠI'			ROLLBACK TRAN			RETURN 1		END		--ĐỂ TEST		WAITFOR DELAY '0:0:05'		---------------------------------		DELETE TUYENDUONG WHERE MaTuyenDuong = @MaTuyenDuong	END TRY	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 1	END CATCHCOMMIT TRANRETURN 0