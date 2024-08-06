CREATE DATABASE DB_LTGFASION
GO
USE DB_LTGFASION

-- Tạo bảng LOAISANPHAM
CREATE TABLE DANHMUC (
    MADANHMUC INT PRIMARY KEY,
    TENDANHMUC NVARCHAR(255)
);
-- Tạo bảng LOAISANPHAM
CREATE TABLE LOAISANPHAM (
    MALOAI INT PRIMARY KEY,
    TENLOAI NVARCHAR(255)
);

-- Tạo bảng TAIKHOAN
CREATE TABLE TAIKHOAN (
    TENDN NVARCHAR(255) PRIMARY KEY,
    MATKHAU NVARCHAR(255),
	EMAIL NVARCHAR(255)
);
--Tạo ràng buộc Email không giống nhau
ALTER TABLE TAIKHOAN
ADD CONSTRAINT UNIQUE_EMAIL UNIQUE (EMAIL)
--Tạo ràng buộc định dạng Email
ALTER TABLE TAIKHOAN
ADD CONSTRAINT CHECK_EMAIL CHECK (EMAIL LIKE '%_@_%_.___%')

-- Tạo bảng SANPHAM
CREATE TABLE SANPHAM (
    MASP INT PRIMARY KEY,
    TENSP NVARCHAR(50),
    GIA FLOAT,
	MOTA NVARCHAR(50),
	DUONGDAN NVARCHAR(50),
	NGAYCAPNHAT DATE,
	SOLUONG INT,
	UUDAI float,
    MALOAI INT FOREIGN KEY REFERENCES LOAISANPHAM(MALOAI),
	MADANHMUC INT FOREIGN KEY REFERENCES DANHMUC(MADANHMUC)
);

CREATE TABLE GIOHANG (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TENDN NVARCHAR(255) FOREIGN KEY REFERENCES TAIKHOAN(TENDN),
    MASP INT FOREIGN KEY REFERENCES SANPHAM(MASP),
    SOLUONG INT,
);

CREATE TABLE TINTUC (
    MATINTUC INT PRIMARY KEY IDENTITY(1,1),
    TIEUDE NVARCHAR(255) NOT NULL,
    NOIDUNG NVARCHAR(MAX) NOT NULL,
    NGAYDANG DATETIME NOT NULL DEFAULT GETDATE(),
	DUONGDAN NVARCHAR(50)
);



drop table DANHMUC
drop table SANPHAM
drop table LOAISANPHAM
drop table GIOHANG

INSERT INTO DANHMUC (MADANHMUC, TENDANHMUC) VALUES
    (1, N'Thời Trang Nam'),
    (2, N'Thời Trang Nữ')


INSERT INTO LOAISANPHAM (MALOAI, TENLOAI) VALUES
    (1, N'Áo khoác'),
    (2, N'Áo sơ mi'),
	(3, N'Quần ngắn'),
	(4, N'Quần jeans'),
	(5, N'Đầm, váy')

INSERT INTO SANPHAM (MASP, TENSP, GIA, MOTA, DUONGDAN, MALOAI, MADANHMUC, NGAYCAPNHAT, SOLUONG, UUDAI) VALUES
    -- Bổ sung thêm sản phẩm cho 'Thời Trang Nam'
    (1, N'Áo Khoác Màu Đỏ', 550000, N'Nổi bật giữa đám đông', N'1.jpg', 1, 1, '2022-01-15', 10, 0.1),
    (2, N'Áo Sơ Mi Xanh', 360000, N'Thoải mái tự tin', N'2.jpg', 2, 1, '2021-01-15', 15, 0),
    (3, N'Quần Ngắn Thể Thao Trắng', 260000, N'Sành điệu khi đi chơi', N'3.jpg', 3, 1, '2023-01-15', 20, 0.05),
    (4, N'Quần Jeans Đen', 310000, N'Thoáng mát năng động', N'4.jpg', 4, 1, '2021-01-15', 12, 0),
    (5, N'Áo Khoác Màu Xanh', 290000, N'Mang cho mình màu xanh biển cả', N'5.jpg', 1, 1, '2023-01-15', 12, 0),
	(6, N'Áo Khoác Ader', 550000, N'Thương hiệu Ader sôi nổi', N'6.jpg', 1, 1, '2023-01-15', 10, 0.3),
	(7, N'Áo Khoác Never', 350000, N'Cá tính mạnh mẽ', N'7.jpg', 1, 1, '2022-01-15', 10, 0.4),

    -- Bổ sung thêm sản phẩm cho 'Thời Trang Nữ'
    (8, N'Áo Khoác Mùa Đông', 480000, N'Ấm áp qua mùa đông', N'8.jpg', 1, 2, '2022-01-15', 18, 0),
    (9, N'Áo Sơ Mi Xanh', 390000, N'Trẻ trung thời thượng', N'9.jpg', 2, 2, '2022-01-15', 25, 0.15),
    (10, N'Váy Dự Tiệc Họa Tiết', 600000, N'Lộng lẫy trong buổi tiệc', N'10.jpg', 5, 2, '2021-01-15', 8, 0.2),
    (11, N'Quần Jean Thể Thao', 300000, N'Thể thao khoe cá tính', N'11.jpg', 4, 2, '2021-01-15', 14, 0),
    (12, N'Đầm Trẻ Trung', 350000, N'Bộ đầm trẻ trung đi chơi', N'12.jpg', 5, 2, '2023-01-15', 22, 0.1);


INSERT INTO TAIKHOAN (TENDN, MATKHAU, EMAIL) VALUES
	(N'Admin', N'Admin', N'Admin@gmail.com'),
	(N'Trường Giang', N'123', N'htgiang@gmail.com')


INSERT INTO TINTUC (TIEUDE, NOIDUNG, DUONGDAN) VALUES
('Xu hướng thời trang mùa xuân 2023', 'Những xu hướng thời trang độc đáo và mới lạ cho mùa xuân năm nay.', 'tintuc1.jpg'),
('Bí quyết chọn trang phục phù hợp', 'Cách chọn trang phục sao cho phản ánh đẳng cấp và phong cách cá nhân của bạn.', 'tintuc2.jpg'),
('Màu sắc thời trang nổi bật', 'Khám phá những màu sắc thời trang đang làm mưa làm gió trong giới mộ điệu.', 'tintuc3.jpg');

