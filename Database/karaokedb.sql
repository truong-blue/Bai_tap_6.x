-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 10, 2026 lúc 01:33 PM
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
-- Cơ sở dữ liệu: `karaokedb`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitietdichvu`
--

CREATE TABLE `chitietdichvu` (
  `MaHD` int(11) NOT NULL,
  `MaDV` int(11) NOT NULL,
  `SoLuong` int(11) NOT NULL CHECK (`SoLuong` > 0),
  `DonGia` decimal(18,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `dichvu`
--

CREATE TABLE `dichvu` (
  `MaDV` int(11) NOT NULL,
  `TenDV` varchar(100) NOT NULL,
  `DonGia` decimal(18,2) NOT NULL CHECK (`DonGia` > 0),
  `TonKho` int(11) NOT NULL DEFAULT 0 CHECK (`TonKho` >= 0)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `dichvu`
--

INSERT INTO `dichvu` (`MaDV`, `TenDV`, `DonGia`, `TonKho`) VALUES
(1, 'Bia Heineken (Lon)', 25000.00, 200),
(2, 'Bia Tiger (Lon)', 22000.00, 300),
(3, 'Nước Ngọt Coca Cola', 15000.00, 150),
(4, 'Trái Cây Dĩa Lớn', 120000.00, 50),
(5, 'Khăn Lạnh', 5000.00, 500),
(6, 'Mực Nướng Dĩa', 180000.00, 30);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hoadon`
--

CREATE TABLE `hoadon` (
  `MaHD` int(11) NOT NULL,
  `MaPhong` int(11) NOT NULL,
  `GioVao` datetime NOT NULL DEFAULT current_timestamp(),
  `GioRa` datetime DEFAULT NULL,
  `TongTienPhong` decimal(18,2) DEFAULT 0.00,
  `TongTienDichVu` decimal(18,2) DEFAULT 0.00,
  `TrangThai` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phonghat`
--

CREATE TABLE `phonghat` (
  `MaPhong` int(11) NOT NULL,
  `TenPhong` varchar(50) NOT NULL,
  `LoaiPhong` varchar(30) DEFAULT 'Thường',
  `GiaTheoGio` decimal(18,2) NOT NULL CHECK (`GiaTheoGio` > 0),
  `TrangThai` varchar(20) DEFAULT 'Trống'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `phonghat`
--

INSERT INTO `phonghat` (`MaPhong`, `TenPhong`, `LoaiPhong`, `GiaTheoGio`, `TrangThai`) VALUES
(1, 'Phòng VIP 01', 'VIP', 250000.00, 'Trống'),
(2, 'Phòng VIP 02', 'VIP', 250000.00, 'Trống'),
(3, 'Phòng Thường 01', 'Thường', 150000.00, 'Trống'),
(4, 'Phòng Thường 02', 'Thường', 150000.00, 'Trống'),
(5, 'Phòng Thường 03', 'Thường', 150000.00, 'Trống');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `chitietdichvu`
--
ALTER TABLE `chitietdichvu`
  ADD PRIMARY KEY (`MaHD`,`MaDV`),
  ADD KEY `MaDV` (`MaDV`);

--
-- Chỉ mục cho bảng `dichvu`
--
ALTER TABLE `dichvu`
  ADD PRIMARY KEY (`MaDV`);

--
-- Chỉ mục cho bảng `hoadon`
--
ALTER TABLE `hoadon`
  ADD PRIMARY KEY (`MaHD`),
  ADD KEY `MaPhong` (`MaPhong`);

--
-- Chỉ mục cho bảng `phonghat`
--
ALTER TABLE `phonghat`
  ADD PRIMARY KEY (`MaPhong`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `dichvu`
--
ALTER TABLE `dichvu`
  MODIFY `MaDV` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT cho bảng `hoadon`
--
ALTER TABLE `hoadon`
  MODIFY `MaHD` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `phonghat`
--
ALTER TABLE `phonghat`
  MODIFY `MaPhong` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Ràng buộc đối với các bảng kết xuất
--

--
-- Ràng buộc cho bảng `chitietdichvu`
--
ALTER TABLE `chitietdichvu`
  ADD CONSTRAINT `chitietdichvu_ibfk_1` FOREIGN KEY (`MaHD`) REFERENCES `hoadon` (`MaHD`) ON DELETE CASCADE,
  ADD CONSTRAINT `chitietdichvu_ibfk_2` FOREIGN KEY (`MaDV`) REFERENCES `dichvu` (`MaDV`);

--
-- Ràng buộc cho bảng `hoadon`
--
ALTER TABLE `hoadon`
  ADD CONSTRAINT `hoadon_ibfk_1` FOREIGN KEY (`MaPhong`) REFERENCES `phonghat` (`MaPhong`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
