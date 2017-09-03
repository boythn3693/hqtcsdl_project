USE [QuanLyLaiXe]
GO

---------T1--------
-------------------
EXEC GT_XemThongTinTheoTo 1
-------------------

---------T1--------
-------------------
EXEC GT_Fix_XemThongTinTheoTo 1
select * from TOLAI where QuanLy=1
-------------------