﻿------------------------
--- T1: CAP NHAT THONG TIN TUYEN DUONG ------
--- T2: CAP NHAT THONG TIN TUYEN DUONG ------


--- T1----
--DROP PROCEDURE GT_CAPNHATTUYENDUONGCREATE --ALTERPROC GT_CAPNHATTUYENDUONG	@MaTuyenDuong varchar(512),
	@TenTuyenDuong nvarchar(512),
	@ChieuDai intASBEGIN TRAN	BEGIN TRY		IF NOT EXISTS (SELECT * FROM TUYENDUONG WHERE MaTuyenDuong = @MaTuyenDuong)		BEGIN			PRINT @MaTuyenDuong + N' KHÔNG TỒN TẠI'			ROLLBACK TRAN			RETURN 1		END		IF @TenTuyenDuong IS NULL		BEGIN			PRINT N'TÊN TUYẾN ĐƯỜNG KHÔNG ĐƯỢC TRỐNG'			ROLLBACK TRAN			RETURN 1		END		IF @ChieuDai <= 0		BEGIN			PRINT N'CHIỀU DÀI KHÔNG HỢP LỆ'			ROLLBACK TRAN			RETURN 1		END		UPDATE TUYENDUONG SET TenTuyenDuong=@TenTuyenDuong, ChieuDai=@ChieuDai WHERE MaTuyenDuong=@MaTuyenDuong		--ĐỂ TEST		WAITFOR DELAY '0:0:05'		ROLLBACK TRAN 		RETURN 1		-----	END TRY	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 1	END CATCHCOMMIT TRANRETURN 0GO--- T2----
--DROP PROCEDURE GT_XEMDSTUYENDUONGCREATE --ALTERPROC GT_XEMDSTUYENDUONGASSET TRAN ISOLATION LEVEL READ UNCOMMITTEDBEGIN TRAN	BEGIN TRY		SELECT TenTuyenDuong FROM TUYENDUONG	END TRY	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN	END CATCHCOMMIT TRANGO