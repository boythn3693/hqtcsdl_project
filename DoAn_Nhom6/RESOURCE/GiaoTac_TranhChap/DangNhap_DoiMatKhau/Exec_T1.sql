USE [QuanLyLaiXe]
GO

--------------------------------
--T1--
EXEC GT_DANGNHAP 'nvbac','123'
SELECT * FROM TAIXE
--------------------------------

--------------------------------
--T1--
EXEC GT_FIX_DANGNHAP 'nvbac','1234'
SELECT * FROM TAIXE
--------------------------------