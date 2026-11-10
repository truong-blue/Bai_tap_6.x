-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 10, 2026 lúc 12:36 PM
-- Phiên bản máy phục vụ: 10.11.16-MariaDB
-- Phiên bản PHP: 8.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `garagedb`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitietsuachua`
--

CREATE TABLE `chitietsuachua` (
  `MaPhieu` int(11) NOT NULL,
  `MaPhuTung` int(11) NOT NULL,
  `SoLuong` int(11) NOT NULL CHECK (`SoLuong` > 0),
  `TienCong` decimal(18,2) DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `khachhang`
--

CREATE TABLE `khachhang` (
  `MaKH` int(11) NOT NULL,
  `TenKH` varchar(100) NOT NULL,
  `DienThoai` varchar(15) NOT NULL,
  `DiaChi` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `khachhang`
--

INSERT INTO `khachhang` (`MaKH`, `TenKH`, `DienThoai`, `DiaChi`) VALUES
(1, 'Nguyễn Hữu Trường', '0988112233', 'Bắc Ninh'),
(2, 'Trần Văn Hùng', '0912345678', 'Hà Nội');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phieusuachua`
--

CREATE TABLE `phieusuachua` (
  `MaPhieu` int(11) NOT NULL,
  `BienSo` varchar(20) NOT NULL,
  `NgayNhan` datetime DEFAULT current_timestamp(),
  `NoiDungSua` text DEFAULT NULL,
  `TongTien` decimal(18,2) DEFAULT 0.00,
  `TrangThai` varchar(30) DEFAULT 'Đang sửa'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phutung`
--

CREATE TABLE `phutung` (
  `MaPhuTung` int(11) NOT NULL,
  `TenPhuTung` varchar(150) NOT NULL,
  `DonGia` decimal(18,2) NOT NULL CHECK (`DonGia` > 0),
  `SoLuongTon` int(11) NOT NULL DEFAULT 0 CHECK (`SoLuongTon` >= 0)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `phutung`
--

INSERT INTO `phutung` (`MaPhuTung`, `TenPhuTung`, `DonGia`, `SoLuongTon`) VALUES
(1, 'Lọc nhớt động cơ', 250000.00, 50),
(2, 'Dầu máy Castrol 4L', 850000.00, 30),
(3, 'Má phanh trước', 1200000.00, 15),
(4, 'Bugi Iridium', 180000.00, 40);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `xe`
--

CREATE TABLE `xe` (
  `BienSo` varchar(20) NOT NULL,
  `MaKH` int(11) NOT NULL,
  `HieuXe` varchar(50) NOT NULL,
  `NamSanXuat` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `xe`
--

INSERT INTO `xe` (`BienSo`, `MaKH`, `HieuXe`, `NamSanXuat`) VALUES
('30F-678.90', 2, 'Toyota Camry', 2020),
('99A-123.45', 1, 'VinFast Lux A2.0', 2022);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `chitietsuachua`
--
ALTER TABLE `chitietsuachua`
  ADD PRIMARY KEY (`MaPhieu`,`MaPhuTung`),
  ADD KEY `MaPhuTung` (`MaPhuTung`);

--
-- Chỉ mục cho bảng `khachhang`
--
ALTER TABLE `khachhang`
  ADD PRIMARY KEY (`MaKH`),
  ADD UNIQUE KEY `DienThoai` (`DienThoai`);

--
-- Chỉ mục cho bảng `phieusuachua`
--
ALTER TABLE `phieusuachua`
  ADD PRIMARY KEY (`MaPhieu`),
  ADD KEY `BienSo` (`BienSo`);

--
-- Chỉ mục cho bảng `phutung`
--
ALTER TABLE `phutung`
  ADD PRIMARY KEY (`MaPhuTung`);

--
-- Chỉ mục cho bảng `xe`
--
ALTER TABLE `xe`
  ADD PRIMARY KEY (`BienSo`),
  ADD KEY `MaKH` (`MaKH`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `khachhang`
--
ALTER TABLE `khachhang`
  MODIFY `MaKH` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT cho bảng `phieusuachua`
--
ALTER TABLE `phieusuachua`
  MODIFY `MaPhieu` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `phutung`
--
ALTER TABLE `phutung`
  MODIFY `MaPhuTung` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Ràng buộc đối với các bảng kết xuất
--

--
-- Ràng buộc cho bảng `chitietsuachua`
--
ALTER TABLE `chitietsuachua`
  ADD CONSTRAINT `chitietsuachua_ibfk_1` FOREIGN KEY (`MaPhieu`) REFERENCES `phieusuachua` (`MaPhieu`) ON DELETE CASCADE,
  ADD CONSTRAINT `chitietsuachua_ibfk_2` FOREIGN KEY (`MaPhuTung`) REFERENCES `phutung` (`MaPhuTung`);

--
-- Ràng buộc cho bảng `phieusuachua`
--
ALTER TABLE `phieusuachua`
  ADD CONSTRAINT `phieusuachua_ibfk_1` FOREIGN KEY (`BienSo`) REFERENCES `xe` (`BienSo`) ON DELETE CASCADE;

--
-- Ràng buộc cho bảng `xe`
--
ALTER TABLE `xe`
  ADD CONSTRAINT `xe_ibfk_1` FOREIGN KEY (`MaKH`) REFERENCES `khachhang` (`MaKH`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
