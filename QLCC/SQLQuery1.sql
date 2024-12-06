
CREATE DATABASE HovatenSV_MaSv;

USE HovatenSV_MaSv;

-- Tạo bảng DONVI
CREATE TABLE DONVI (
    MADV VARCHAR(10) PRIMARY KEY,
    TENDV VARCHAR(100),
    DIACHI VARCHAR(100),
    DIENTHOAI VARCHAR(10)
);

-- Tạo bảng CHUCVU
CREATE TABLE CHUCVU (
    MACV VARCHAR(10) PRIMARY KEY,
    TENCV VARCHAR(100),
    HESOCV FLOAT
);

-- Tạo bảng NHANVIEN
CREATE TABLE NHANVIEN (
    MANV VARCHAR(10) PRIMARY KEY,
    MADV VARCHAR(10) NOT NULL,
    HOTEN VARCHAR(100) NOT NULL,
    NGAYSINH DATETIME,
    GIOITINH VARCHAR(3),
    DIACHI VARCHAR(100),
    DIENTHOAI VARCHAR(10),
    MACV VARCHAR(10),
    FOREIGN KEY (MADV) REFERENCES DONVI(MADV)
);

-- Tạo bảng CHAMCONG
CREATE TABLE CHAMCONG (
    MANV VARCHAR(10) NOT NULL,
    THANG INT,
    SONGAYCONG FLOAT,
    SONGAYPHEP FLOAT,
    TIENLUONG FLOAT,
    FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

CREATE TABLE HETHONG (
    TENDN VARCHAR(100) NOT NULL,
    MATKHAU VARCHAR(100),
    QUYEN VARCHAR(1)
);

-- Sử dụng cơ sở dữ liệu vừa tạo
USE HovatenSV_MaSv;

-- Chèn dữ liệu mẫu vào bảng DONVI
INSERT INTO DONVI (MADV, TENDV, DIACHI, DIENTHOAI) VALUES
('D001', 'Phòng Kế Toán', '123 Lý Thường Kiệt', '0123456789'),
('D002', 'Phòng Nhân Sự', '456 Hai Bà Trưng', '0987654321'),
('D003', 'Phòng Kỹ Thuật', '789 Nguyễn Huệ', '0912345678');

-- Chèn dữ liệu mẫu vào bảng CHUCVU
INSERT INTO CHUCVU (MACV, TENCV, HESOCV) VALUES
('CV001', 'Trưởng Phòng', 3.5),
('CV002', 'Phó Phòng', 2.5),
('CV003', 'Nhân Viên', 1.5);

-- Chèn dữ liệu mẫu vào bảng NHANVIEN
INSERT INTO NHANVIEN (MANV, MADV, HOTEN, NGAYSINH, GIOITINH, DIACHI, DIENTHOAI, MACV) VALUES
('NV001', 'D001', 'Nguyễn Văn A', '1985-05-10', 'Nam', '123 Lý Thường Kiệt', '0123456789', 'CV01'),
('NV002', 'D002', 'Trần Thị B', '1990-08-20', 'Nữ', '456 Hai Bà Trưng', '0987654321', 'CV02'),
('NV003', 'D003', 'Lê Văn C', '1995-12-15', 'Nam', '789 Nguyễn Huệ', '0912345678', 'CV03');

-- Chèn dữ liệu mẫu vào bảng CHAMCONG
INSERT INTO CHAMCONG (MANV, THANG, SONGAYCONG, SONGAYPHEP, TIENLUONG) VALUES
('NV001', 1, 22, 2, 15000000),
('NV002', 1, 20, 3, 12000000),
('NV003', 1, 18, 5, 10000000);

-- Chèn dữ liệu mẫu vào bảng HETHONG
INSERT INTO HETHONG (TENDN, MATKHAU, QUYEN) VALUES
('admin', '123456', 'A'),
('tranthib', '123456', 'U'),
('levanc', '123456', 'U');

USE HovatenSV_MaSv;
GO

DROP PROCEDURE TimKiemNhanVienTheoPhongBan
GO

CREATE PROCEDURE TimKiemChamCongTheoThang
    @Thang INT,
	@MaNV VARCHAR(100)
AS
BEGIN
    SELECT 
        NV.MANV, 
        NV.HOTEN, 
        CC.THANG, 
        CC.SONGAYCONG, 
        CC.SONGAYPHEP, 
        CC.TIENLUONG
    FROM 
        NHANVIEN NV
    JOIN 
        CHAMCONG CC ON NV.MANV = CC.MANV
    WHERE 
        CC.THANG = @Thang
		AND NV.MANV LIKE '%' + @MaNV + '%';
END;
GO

CREATE PROCEDURE TimKiemNhanVienTheoPhongBan
    @PhongBan NVARCHAR(50)
AS
BEGIN
    SELECT 
        NV.MANV, 
        NV.HOTEN, 
        NV.NGAYSINH, 
        NV.GIOITINH, 
        NV.DIACHI, 
        NV.DIENTHOAI,
        DV.TENDV
    FROM 
        NHANVIEN NV
    JOIN 
        DONVI DV ON NV.MADV = DV.MADV
    WHERE 
        DV.TENDV LIKE '%' + @PhongBan + '%';
END;

