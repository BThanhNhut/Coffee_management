CREATE DATABASE QL_Cafe
GO

USE QL_Cafe
GO

-- Thức ăn
-- Bàn
-- loại thức ăn
-- Tài khoản
-- hóa đơn
-- ChitietHD

CREATE TABLE BanCafe
(
    MaBan INT IDENTITY,
    TenBan NVARCHAR(50) NOT NULL DEFAULT N'Chưa đặt',
    TinhTrang NVARCHAR(50) NOT NULL DEFAULT N'Bàn Trống',
    CONSTRAINT PK_BanCafe PRIMARY KEY (MaBan)
)
GO

CREATE TABLE LoaiTaiKhoan 
(
    MaLoai_TK INT IDENTITY,
    TenLoai NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_LoaiTaiKhoan PRIMARY KEY (MaLoai_TK)
)
GO

CREATE TABLE TaiKhoan 
(
    TenDN CHAR(50), -- Tên đặng nhập
    TenHT NVARCHAR(50) NOT NULL, -- Tên hiển thị
    Pass NVARCHAR(50) NOT NULL,
    Loai INT NOT NULL,
	DiaChi NVARCHAR(50),
	SDT VARCHAR(15),
	GioiTinh  NVARCHAR(20)


    CONSTRAINT PK_TaiKhoan PRIMARY KEY (TenDN)
    CONSTRAINT FK_LoaiTaiKhoan FOREIGN KEY (Loai) REFERENCES LoaiTaiKhoan(MaLoai_TK)
)
GO

CREATE TABLE LoaiThucAn 
(
    MaLoai_TA INT IDENTITY,
    TenLoai NVARCHAR(50) NOT NULL DEFAULT N'Chưa có tên' ,
    CONSTRAINT PK_LoaiThucAn PRIMARY KEY (MaLoai_TA)
)
GO

CREATE TABLE ThucAn 
(
    MaTA INT IDENTITY,
    TenTA NVARCHAR(50) NOT NULL DEFAULT N'Chưa có tên',
    Loai INT NOT NULL,
    Gia INT NOT NULL

    CONSTRAINT PK_ThucAn PRIMARY KEY (MaTA)
    CONSTRAINT FK_LoaiThucAn FOREIGN KEY (Loai) REFERENCES LoaiThucAn(MaLoai_TA)
)
GO

CREATE TABLE HoaDon 
(
    MaHD INT IDENTITY,
    NgayVao DATE NOT NULL DEFAULT GETDATE(),
    NgayRa DATE NULL,
    MaBan INT NOT NULL,
    TinhTrang INT NOT NULL DEFAULT 0,
    GiamGia INT NOT NULL DEFAULT 0,
	TongTien FLOAT NULL DEFAULT 0

    CONSTRAINT PK_HoaDon PRIMARY KEY (MaHD)
    CONSTRAINT FK_BanCafe FOREIGN KEY (MaBan) REFERENCES BanCafe(MaBan)
)
GO

CREATE TABLE CT_HoaDon 
(
    Ma INT IDENTITY,
    MaHD INT NOT NULL,
    MaTA INT NOT NULL,
    SoLuong int NOT NULL DEFAULT 0

    CONSTRAINT PK_CT_HoaDon PRIMARY KEY (Ma)
    CONSTRAINT FK_HoaDon FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    CONSTRAINT FK_ThucAn FOREIGN KEY (MaTA) REFERENCES ThucAn(MaTA)
)
GO

-- THÊM BÀN
INSERT INTO BanCafe(TenBan)
VALUES 
(N'Bàn số 1'),
(N'Bàn số 2'),
(N'Bàn số 3'),
(N'Bàn số 4'),
(N'Bàn số 5'),
(N'Bàn số 6'),
(N'Bàn số 7'),
(N'Bàn số 8'),
(N'Bàn số 9'),
(N'Bàn số 10'),
(N'Bàn số 11'),
(N'Bàn số 12'),
(N'Bàn số 13'),
(N'Bàn số 14'),
(N'Bàn số 15'),
(N'Bàn số 16'),
(N'Bàn số 17'),
(N'Bàn số 18'),
(N'Bàn số 19'),
(N'Bàn số 20')
GO
GO
-- THÊM lOẠI MÓN

INSERT INTO LoaiThucAn
VALUES
(N'Cà Phê'),
(N'Trà trái cây - Trà sửa'),
(N'Đồ ăn vặt'),
(N'Thức uốn khác'),
(N'Hi-tea Healthy'),
(N'CloudTea'),
(N'CoudFee')
GO

-- THÊM MÓN
INSERT INTO ThucAn
VALUES
(N'Cà Phê Sửa Đá',1,39000),
(N'Cà Phê Sửa Nóng',1,35000),
(N'Bạc Sỉu',1,29000),
(N'Bạc Sỉu Nóng',1,35000),
(N'Cà Phê Đen Đá',1,29000),
(N'Cà Phê Đen Nóng',1,35000),
(N'Caramel Macchiato Nóng',1,49000),
(N'Caramel Macchiato Đá',1,49000),
(N'Latte Đá',1,49000),
(N'Latte Nóng',1,49000),
(N'Americano Nóng',1,39000),
(N'Americano Đá',1,39000),

(N'Trà Sửa Dừa Nóng',2,55000),
(N'Trà Long Nhẵn Hạt Sen',2,49000),
(N'Trà Đào Cam Xả',2,49000),
(N'Trà Đào Cam Xả Nóng',2,49000),
(N'Trà Long Nhãn Hạt Chia',2,49000),
(N'Trà Long Nhãn Hạt Chia (Nóng)',2,49000),
(N'Trà Đen Macchiato',2,49000),
(N'Hồng Trà Sửa Trân Châu',2,55000),
(N'Hồng Trà Sửa Nóng',2,55000),
(N'Trà Sửa Mắc Ca Trân Châu',2,55000),
(N'Hòng Trà Latte Macchiato',2,55000),

(N'Bánh Mì Que Pate',3,15000),
(N'Bánh Mì Que Pate Cay',3,15000),
(N'Chà Bông Phô Mai',3,35000),
(N'Mochi Kem Phúc Bốn Tử',3,19000),
(N'Mochi Kem Chocolate',3,19000),
(N'Mochi Kem Xoài',3,19000),
(N'Mochi Kem Việt Quất',3,39000),
(N'Mochi Kem MatCha',3,19000),

(N'Chocolate Đá',4,55000),
(N'Chocolate Nóng',4,55000),

(N'Hi-Tea Phúc Bốn Tử Mandarin',5,49000),
(N'Hi-Tea Dâu Tây Mận Muối Aloevera',5,49000),
(N'Hi-Tea Xoài Aloe Vera',5,49000),
(N'Hi-Tea Yuzu Trân Châu',5,55000),
(N'Hi-Tea Vải',5,55000),
(N'Hi-Tea Đào',5,55000),
(N'Hi-Tea Tuyết Xoài Đào',5,55000),
(N'Hi-Tea Tuyết Yuzu vải',5,55000),

(N'CloudTea Hồng Trà Arabica',6,55000),
(N'CloudTea Oolong Nướng Kem Dừa Đá Xay',6,55000),
(N'CloudTea Oolong Nướng Kem Dừa',6,55000),

(N'CloudFee Hạnh Nhân Nướng',7,49000),
(N'CloudFee Caramel',7,49000),
(N'CloudFee Classic',7,49000),
(N'CloudFee Pandan Coconut',7,49000)
GO

-- THÊM HÓA ĐƠN
DELETE FROM HoaDon 
SET DATEFORMAT DMY
INSERT INTO HoaDon (MaBan, TinhTrang, NgayVao, NgayRa, GiamGia, TongTien)
VALUES
(1, 1,'17/12/2022', '17/12/2022', 5, 245000),
(2, 1,'18/12/2022', '18/12/2022', 10, 255000),
(3, 1,'19/12/2022', '19/12/2022', 15, 255000),
(4, 1,'17/12/2022', '17/12/2022', 20, 255000),
(5, 1,'17/12/2022', '17/12/2022', 10, 255000),
(6, 1,'17/12/2022', '17/12/2022', 10, 305000),
(7, 1,'18/12/2022', '18/12/2022', 10, 555000),
(8, 1,'19/12/2022', '19/12/2022', 10, 245000),
(9, 1,'17/12/2022', '17/12/2022', 10, 215000),
(10, 1,'17/12/2022', '17/12/2022', 10, 190000),
(1, 1,'20/12/2022', '17/12/2022', 10, 35000),
(2, 1,'19/12/2022', '18/12/2022', 10, 355000),
(3, 1,'1/12/2022', '1/12/2022', 10, 355000),
(4, 1,'22/12/2022', '22/12/2022', 10, 355000),
(5, 1,'24/12/2022', '24/12/2022', 10, 355000),
(6, 1,'29/12/2022', '29/12/2022', 10, 305000),
(7, 1,'30/12/2022', '30/12/2022', 10, 355000),
(8, 1,'25/12/2022', '25/12/2022', 10, 345000),
(9, 1,'26/12/2022', '26/12/2022', 10, 315000),
(10, 1,'21/12/2022', '21/12/2022', 10, 390000),
(1, 1,'29/12/2022', '29/12/2022', 10, 345000),
(2, 1,'2/12/2022', '2/12/2022', 10, 355000),
(3, 1,'30/12/2022', '30/12/2022', 10, 155000),
(4, 1,'28/12/2022', '30/12/2022', 10, 155000),
(5, 1,'29/12/2022', '29/12/2022', 10, 255000),
(6, 1,'29/12/2022', '29/12/2022', 10, 305000),
(7, 1,'30/12/2022', '30/12/2022', 10, 355000),
(8, 1,'25/12/2022', '25/12/2022', 10, 245000),
(9, 1,'26/12/2022', '26/12/2022', 15, 115000),
(10, 1,'29/12/2022', '29/12/2022', 12, 290000),

(11, 1,'29/12/2022', '29/12/2022', 5, 345000),
(12, 1,'20/12/2022', '20/12/2022', 5, 355000),
(13, 1,'30/12/2022', '30/12/2022', 5, 155000),
(14, 1,'28/12/2022', '28/12/2022', 5, 155000),
(15, 1,'29/12/2022', '29/12/2022', 5, 255000),
(16, 1,'29/12/2022', '29/12/2022', 5, 305000),
(17, 1,'30/12/2022', '30/12/2022', 5, 355000),
(18, 1,'25/12/2022', '25/12/2022', 5, 245000),
(19, 1,'26/12/2022', '26/12/2022', 5, 115000),
(10, 1,'29/12/2022', '29/12/2022', 5, 290000),
(11, 1,'29/12/2022', '29/01/2022', 5, 345000),
(12, 1,'02/12/2022', '02/12/2022', 5, 355000),
(13, 1,'30/12/2022', '30/01/2022', 5, 155000),
(14, 1,'28/12/2022', '28/01/2022', 5, 155000),
(15, 1,'29/12/2022', '29/01/2022', 5, 255000),
(16, 1,'29/12/2022', '29/01/2022', 5, 305000),
(17, 1,'30/12/2022', '30/01/2022', 5, 355000),
(18, 1,'25/12/2022', '25/01/2022', 5, 245000),
(19, 1,'26/12/2022', '26/01/2022', 5, 115000),
(10, 1,'29/12/2022', '29/01/2022', 5, 290000),

(11, 1,'29/3/2022', '29/3/2022', 5, 345000),
(12, 1,'20/3/2022', '20/3/2022', 5, 355000),
(13, 1,'30/4/2022', '30/4/2022', 5, 155000),
(14, 1,'28/4/2022', '28/4/2022', 5, 155000),
(15, 1,'29/4/2022', '29/4/2022', 5, 255000),
(16, 1,'29/4/2022', '29/4/2022', 5, 305000),
(17, 1,'30/4/2022', '30/4/2022', 5, 355000),
(18, 1,'25/4/2022', '25/4/2022', 5, 245000),
(19, 1,'26/4/2022', '26/4/2022', 5, 115000),
(10, 1,'29/4/2022', '29/4/2022', 5, 290000),
(11, 1,'29/5/2022', '29/5/2022', 5, 345000),
(12, 1,'02/5/2022', '02/5/2022', 5, 355000),
(13, 1,'30/5/2022', '30/5/2022', 5, 155000),
(14, 1,'28/5/2022', '28/5/2022', 5, 155000),
(15, 1,'29/5/2022', '29/5/2022', 5, 255000),
(16, 1,'29/5/2022', '29/5/2022', 5, 305000),
(17, 1,'30/5/2022', '30/5/2022', 5, 355000),
(18, 1,'25/5/2022', '25/5/2022', 5, 245000),
(19, 1,'26/5/2022', '26/5/2022', 5, 115000),
(10, 1,'29/5/2022', '29/5/2022', 5, 290000)

--(16, 1,'29/12/2022', '29/4/2022', 5, 305000),
--(17, 1,'30/12/2022', '30/4/2022', 5, 335000),
--(18, 1,'25/12/2022', '25/4/2022', 5, 235000),
--(19, 1,'26/12/2022', '26/4/2022', 5, 515000),
--(10, 1,'29/12/2022', '29/4/2022', 5, 890000),
--(15, 1,'29/12/2022', '29/4/2022', 5, 255000),
--(16, 1,'29/12/2022', '29/4/2022', 5, 105000),
--(17, 1,'30/12/2022', '30/4/2022', 5, 955000),
--(18, 1,'25/12/2022', '25/4/2022', 5, 245000),
--(19, 1,'26/12/2022', '26/4/2022', 5, 115000),
--(10, 1,'29/12/2022', '29/4/2022', 5, 890000),
--(11, 1,'29/12/2022', '29/4/2022', 5, 145000)
GO

select * from HoaDon
-- THÊM CHHI TIẾT HÓA ĐƠN

INSERT INTO CT_HoaDon(MaHD, MaTA, SoLuong)
VALUES
(1,1,1),
(1,3,1),
(1,20,2),
(2,3,3),
(2,22,9)
GO


INSERT INTO LoaiTaiKhoan
VALUES
('Admin'),
('Staff')

INSERT INTO TaiKhoan  (TenDN,TenHT,Pass,Loai,DiaChi,SDT)
VALUES
('admin',N'Biện Thanh Nhựt','123',1,N'Tây Ninh','0948989898'),
('taikhoan1',N'Tống Duy Trường Đạt','123',2,N'Quảng Ngãi','094827889'),
('taikhoan2',N'Vũ Hoàng Tiên','123',2,N'Đồng Nai','09484182921'),
('taikhoan3',N'Nguyễn Hữu Trung','123',2,N'Quảng Ngãi','094827889'),
('taikhoan4',N'Phan Ánh Linh','123',2,N'Đồng Nai','09484182921'),
('taikhoan5',N'Hồ Phương Thảo','123',2,N'TP - HCM','094827889'),
('taikhoan6',N'Huỳnh Thị Kiều Mai','123',2,N'Gia Lai','09484182921'),
('taikhoan7',N'Lê Minh Kha','123',2,N'TP - HCM','094827889'),
('taikhoan8',N'Nguyển Trí Phúc','123',2,N'TP - HCM','094827889')
GO
SELECT * FROM TaiKhoan
GO



-- Kiểm tra tài khoản đăng nhập
CREATE PROC SP_DangNhap
@TenDN nvarchar (20), @Pass nvarchar (20)
AS
BEGIN
	SELECT * FROM TaiKhoan WHERE TaiKhoan.TenDN = @TenDN AND TaiKhoan.Pass = @Pass
END
GO
Exec SP_DangNhap @TenDN = 'admin', @Pass = '123'
select * from TaiKhoan
GO

--Tìm kiếm tài khoản dựa vào tên
CREATE PROC SP_TimKiem_TK
@TenDN nvarchar(50)
AS
BEGIN
	SELECT * FROM TaiKhoan WHERE TaiKhoan.TenDN = @TenDN
END
GO
Exec SP_TimKiem_TK @TenDN = 'admin'
GO

--Load danh sách bàn lên 
CREATE PROC SP_LoadBan 
AS
BEGIN
	SELECT * FROM BanCafe
END 
GO
Exec SP_LoadBan
GO

--Lấy mã hóa đơn từ mã bàn
CREATE PROC SP_LayHoaDon_BanAn
@MaBan INT
AS
BEGIN
	SELECT * FROM HoaDon WHERE HoaDon.MaBan = @MaBan AND TinhTrang = 0
END
GO
Exec SP_LayHoaDon_BanAn @MaBan = 1
GO


-- Lấy danh sách thức ăn từ mã hd
CREATE PROC SP_Lay_DSHD
@MaHD INT
AS
BEGIN
	SELECT * FROM CT_HoaDon WHERE CT_HoaDon.MaHD = @MaHD
END
GO
Exec SP_Lay_DSHD @MaHD = 2
GO

--- Lấy thông tin thức ăn từ mã bàn
CREATE PROC SP_LayTT_ThucAn
@MaBan INT
AS
BEGIN
	SELECT ThucAn.TenTA, CT_HoaDon.SoLuong, ThucAn.Gia, ThucAn.Gia*CT_HoaDon.SoLuong as TongTien
	FROM HoaDon, CT_HoaDon, ThucAn 
	WHERE HoaDon.MaHD = CT_HoaDon.MaHD AND CT_HoaDon.MaTA = ThucAn.MaTA AND HoaDon.MaBan = @MaBan AND HoaDon.TinhTrang = 0
END
GO
	EXEC SP_LayTT_ThucAn @MaBan = 2
GO

--- Load loại thức an
CREATE PROC SP_LoadLoaiThucAn
AS
BEGIN
	SELECT * FROM LoaiThucAn
END
GO
EXEC SP_LoadLoaiThucAn 
GO

--- Load thức ăn
CREATE PROC SP_LoadThucAn
@MaLoai_TA INT
AS
BEGIN
	SELECT * FROM ThucAn where Loai = @MaLoai_TA
END
GO
EXEC SP_LoadThucAn  @MaLoai_TA = 1
GO

-- Thêm hóa đơn
CREATE PROC SP_Insert_HoaDon
@MaBan INT
AS
BEGIN
	INSERT INTO HoaDon (MaBan)
	VALUES (@MaBan)
END
GO
--EXEC SP_Insert_HoaDon @MaBan = '20'
GO

-- Thêm chi mon an
CREATE PROC SP_Insert_CT_HoaDon
@MaHD INT, @MaTA INT, @SoLuong INT
AS
BEGIN
	DECLARE @Ktra INT  -- Ktra su tồn tại của hóa đơn
	DECLARE @SoLuongTA INT = 0
	SELECT @Ktra = Ma, @SoLuongTA = SoLuong FROM CT_HoaDon WHERE MaHD = @MaHD AND MaTA = @MaTA
	IF(@Ktra > 0)
	BEGIN
		DECLARE @SoLuongMoi INT
		SET @SoLuongMoi = @SoLuongTA + @SoLuong
		IF(@SoLuongMoi > 0)
			UPDATE CT_HoaDon SET SoLuong = @SoLuongTA + @SoLuong WHERE MaTA = @MaTA
		ELSE IF (@SoLuongMoi <= 0)
			DELETE CT_HoaDon WHERE MaHD = @MaHD AND MaTA = @MaTA
	END
	ELSE
		IF(@SoLuong > 0)
			INSERT INTO CT_HoaDon (MaHD, MaTA, SoLuong) VALUES (@MaHD, @MaTA,@SoLuong)
END
GO
--EXEC SP_Insert_CT_HoaDon @MaHD =1 , @MaTA = 5 , @SoLuong = 1
GO
--SELECT  Ma, SoLuong FROM CT_HoaDon WHERE MaHD = 1 AND MaTA = 3
--DROP PROC SP_Insert_CT_HoaDon
--SELECT * FROM CT_HoaDon
--SELECT * FROM HoaDon
--INSERT INTO CT_HoaDon VALUES (1,3,1)
GO
-- Lấy id max của Hóa Đơn
CREATE PROC SP_LayIDMax_HoaDon 
AS
BEGIN
	SELECT MAX(MaHD) FROM HoaDon
END
GO
EXEC SP_LayIDMax_HoaDon
GO

--  Thanh toán hóa đơn
CREATE PROC SP_ThanhToanHD
@MaHD INT, @GiamGia INT, @TongTien Float
AS
BEGIN
	UPDATE HoaDon SET NgayRa = GETDATE(), TinhTrang = 1, GiamGia = @GiamGia, TongTien = @TongTien WHERE MaHD = @MaHD
END
GO
--EXEC SP_ThanhToanHD @MaHD = '1'
GO

--///
GO
-- Tạo 2 tricgger Insert và update
CREATE TRIGGER UPDATE_CTHOADON
ON CT_HoaDon FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @MaHD INT
	SELECT @MaHD = MaHD FROM inserted

	DECLARE @MaBan INT
	SELECT @MaBan = MaBan FROM HoaDon WHERE MaHD = @MaHD AND TinhTrang = 0

	UPDATE BanCafe SET TinhTrang = N'Có Người' WHERE MaBan = @MaBan
END
GO

CREATE TRIGGER UPDATE_HOADON
ON HoaDon FOR UPDATE
AS
BEGIN
	DECLARE @MaHD INT
	SELECT @MaHD =  MaHD FROM inserted

	DECLARE @MaBan INT
	SELECT @MaBan = MaBan FROM HoaDon WHERE MaHD = @MaHD
	
	DECLARE @SoLuong int = 0
	SELECT @SoLuong = COUNT(*) FROM HoaDon WHERE MaBan = @MaBan AND TinhTrang = 0

	IF(@SoLuong = 0)
		UPDATE BanCafe SET TinhTrang = N'Bàn Trống' WHERE MaBan = @MaBan
END
GO

-- Lấy tất cả bàn ăn
CREATE PROC SP_LayAll_BanAn
AS
BEGIN 
	SELECT * FROM BanCafe
END
GO
EXEC SP_LayAll_BanAn 
GO

-- Lấy tất cả tài khoản
CREATE PROC SP_LayALL_TaiKhoan
AS
BEGIN
	SELECT * FROM TaiKhoan
END
GO
EXEC SP_LayALL_TaiKhoan
GO
-- Lấy tất cả thức ăn
CREATE PROC SP_Lay_All_ThucAn
AS
BEGIN
	SELECT * FROM ThucAn
END
GO
-- Lấy tất cả loại thức ăn
CREATE PROC SP_Lay_All_LoaiThucAn
AS
BEGIN
	SELECT * FROM LoaiThucAn
END
GO
-- Xóa thức ăn
CREATE PROC SP_XoaThucAn
@MaTA INT
AS
BEGIN
	DELETE ThucAn WHERE MaTA = @MaTA
END
GO
-- Sửa Thức ăn
CREATE PROC SP_SuaThucAn
@MaTA INT, @TenTA NVARCHAR(50) , @Loai INT, @Gia INT
AS
BEGIN
	UPDATE ThucAn SET TenTA = @TenTA, Loai = @Loai, Gia = @Gia WHERE MaTA = @MaTA
END

GO
-- Thêm thức an
CREATE PROC SP_ThemThucAn
@TenTA nvarchar(50),@Loai INT, @Gia INT
AS
BEGIN
	INSERT INTO ThucAn (TenTA, Loai, Gia) VALUES (@TenTA,@Loai,@Gia)
END
GO
	EXEC SP_ThemThucAn @TenTA = N'BANH',@Loai = 1, @Gia = 20000
GO
-- Thêm bàn
CREATE PROC SP_ThemBan
@TenBan NVARCHAR(50)
AS
BEGIN
	INSERT INTO BanCafe (TenBan) VALUES (@TenBan)
END
GO
GO
--Thêm loại thức ăn
CREATE PROC SP_ThemLoaiThucAn
@TenLoai NVARCHAR(50)
AS
BEGIN
	INSERT INTO LoaiThucAn (TenLoai) VALUES (@TenLoai)
END
GO
GO
select * from ThucAn
go


-- Lấy tất cả danh sách hóa đơn 
CREATE PROC Lay_All_DSHD_ThongKe
@NgayVao DATE, @NgayRa DATE
AS
BEGIN
	SELECT TenBan, TongTien, NgayVao, NgayRa, GiamGia FROM BanCafe, HoaDon WHERE NgayVao >= @NgayVao AND NgayRa <= @NgayRa
	AND HoaDon.TinhTrang = 1 AND BanCafe.MaBan = HoaDon.MaBan
END
GO
-- Lấy tất cả chi tiết hóa đơn
CREATE PROC SP_Lay_TT_InHD
@MaBan INT,@MaHD INT
AS
BEGIN
	SELECT ThucAn.TenTA, CT_HoaDon.SoLuong, ThucAn.Gia, ThucAn.Gia*CT_HoaDon.SoLuong as ThanhTien, GiamGia, TongTien - (TongTien/100)*GiamGia as tt FROM HoaDon, CT_HoaDon, ThucAn
	WHERE HoaDon.MaHD = CT_HoaDon.MaHD AND CT_HoaDon.MaTA = ThucAn.MaTA AND HoaDon.MaBan = @MaBan AND HoaDon.TinhTrang = 1 AND CT_HoaDon.MaHD = @MaHD
END
GO

--Binding Hoa Don loai thuc an
CREATE PROC SP_BinDing_LoaiTA
@TenTA NVARCHAR(50)
AS
BEGIN
	SELECT Loai FROM ThucAn WHERE ThucAn.TenTA = @TenTA
END
GO
EXEC SP_BinDing_LoaiTA @TenTA = N'Bạc Sỉu'
GO

----Binding thuc don thuc an
CREATE PROC SP_BinDing_ThucAn 
@TenTA NVARCHAR(50)
AS
BEGIN
	SELECT MaTA FROM ThucAn WHERE ThucAn.TenTA = @TenTA
END
GO
--SELECT MaTA FROM ThucAn WHERE ThucAn.TenTA = N'Trà Sửa Mắc Ca Trân Châu' AND Loai = 2
-- Thống kê số tiền theo tháng
CREATE PROC SP_ThongKeSoTien
@BatDau int, @KetThuc int
AS
BEGIN
	SELECT MONTH(NgayRa) AS Thang, SUM(TongTien) AS TongTien1Thang  FROM HoaDon WHERE MONTH(NgayRa) >= @BatDau OR MONTH(NgayRa) <= @KetThuc GROUP BY MONTH(NgayRa) 
END
GO
	exec SP_ThongKeSoTien @BatDau = 1, @KetThuc = 12
GO

-- Cập nhật thông tin cá nhân
CREATE PROC SP_CapNhatTK 
@TenDN VARCHAR(50), @TenHT NVARCHAR(50), @MatKhau VARCHAR(50), @MatKhauMoi VARCHAR(20), @ChucVu NVARCHAR(50), @DiaChi NVARCHAR(50), @SDT VARCHAR(20)
AS
BEGIN
	DECLARE @Ktra INT = 0
	SELECT @Ktra = COUNT(*) FROM TaiKhoan WHERE TaiKhoan.TenDN = @TenDN AND TaiKhoan.Pass = @MatKhau
	IF (@Ktra > 0)
		BEGIN
			IF (@MatKhauMoi = NULL OR @MatKhauMoi = '')
				BEGIN
					UPDATE TaiKhoan SET TenHT = @TenHT, DiaChi = @DiaChi, SDT = @SDT WHERE TenDN = @TenDN
				END
			ELSE
				BEGIN
					UPDATE TaiKhoan SET TenHT = @TenHT, DiaChi = @DiaChi, SDT = @SDT, Pass = @MatKhauMoi WHERE TenDN = @TenDN
				END
		END
END

--select * from TaiKhoan

--UPDATE TaiKhoan SET Pass = '123'
select * from ThucAn

