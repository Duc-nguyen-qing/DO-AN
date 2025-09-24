CREATE DATABASE QUANLYBANHANG;
GO

USE QUANLYBANHANG;
GO

-- Bảng nhân viên
CREATE TABLE NHANVIEN (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    TenNV NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15),
    ChucVu NVARCHAR(50),
    NgaySinh DATE,
    CCCD VARCHAR(20),
    Luong DECIMAL(18,2),
    DiaChi NVARCHAR(200),
    GioiTinh NVARCHAR(10)
);
GO

-- Bảng sản phẩm
CREATE TABLE SANPHAM (
    MaSP INT IDENTITY(1,1) PRIMARY KEY,
    TenSP NVARCHAR(100) NOT NULL,
    SoLuong INT DEFAULT 0,
    GiaNhap DECIMAL(18,2),
    GiaBan DECIMAL(18,2),
    NhaCungCap NVARCHAR(100)
);
GO

-- Bảng hóa đơn
CREATE TABLE HOADON (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    MaNV INT FOREIGN KEY REFERENCES NHANVIEN(MaNV),
    TenKH NVARCHAR(100),
    SoDienThoaiKH VARCHAR(15),
    DiaChiKH NVARCHAR(200),
    NgayTao DATETIME DEFAULT GETDATE(),
    TongTien DECIMAL(18,2) DEFAULT 0
);
GO

-- Bảng chi tiết hóa đơn
CREATE TABLE CHITIETHD (
    MaCT INT IDENTITY(1,1) PRIMARY KEY,
    MaHD INT FOREIGN KEY REFERENCES HOADON(MaHD),
    MaSP INT FOREIGN KEY REFERENCES SANPHAM(MaSP),
    SoLuong INT,
    DonGia DECIMAL(18,2),
    ThanhTien DECIMAL(18,2)
);
GO

-- Dữ liệu mẫu
INSERT INTO NHANVIEN (TenNV, SoDienThoai, ChucVu, NgaySinh, CCCD, Luong, DiaChi, GioiTinh) VALUES 
(N'Nguyễn Thanh Đức', '0912345678', N'Nhân viên', '1990-01-15', '123456789', 5000000, N'Hà Nội', N'Nam'),
(N'Trần Thị B', '0987654321', N'Nhân Viên', '1985-05-20', '987654321', 8000000, N'Hồ Chí Minh', N'Nữ');

INSERT INTO SANPHAM (TenSP, SoLuong, GiaNhap, GiaBan, NhaCungCap) VALUES
(N'iPhone 15', 100, 15000000, 20000000, N'Apple'),
(N'Samsung Galaxy', 50, 8000000, 12000000, N'Samsung'),
(N'MacBook Pro', 30, 30000000, 35000000, N'Apple');
GO