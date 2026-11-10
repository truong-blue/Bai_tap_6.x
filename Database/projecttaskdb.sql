-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 10, 2026 lúc 11:45 AM
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
-- Cơ sở dữ liệu: `projecttaskdb`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `congviec`
--

CREATE TABLE `congviec` (
  `MaTask` int(11) NOT NULL,
  `MaDuAn` int(11) DEFAULT NULL,
  `TenTask` varchar(200) NOT NULL,
  `MoTa` text DEFAULT NULL,
  `HanNop` datetime DEFAULT NULL,
  `DoUuTien` varchar(20) DEFAULT 'Trung bình',
  `TrangThai` varchar(50) DEFAULT 'To Do'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `congviec`
--

INSERT INTO `congviec` (`MaTask`, `MaDuAn`, `TenTask`, `MoTa`, `HanNop`, `DoUuTien`, `TrangThai`) VALUES
(1, 1, 'Cấu hình Modbus TCP Server', 'Thiết lập mô phỏng giao thức trên PNETLab', '2026-10-15 00:00:00', 'Cao', 'Done'),
(2, 1, 'Tích hợp Suricata IDS', 'Bắt gói tin và phát hiện bất thường', '2026-11-05 00:00:00', 'Cao', 'In Progress'),
(3, 2, 'VLAN Trunking & OSPF', 'Cấu hình Inter-VLAN Routing trên Cisco Packet Tracer', '2026-11-01 00:00:00', 'Trung bình', 'To Do');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `duan`
--

CREATE TABLE `duan` (
  `MaDuAn` int(11) NOT NULL,
  `TenDuAn` varchar(150) NOT NULL,
  `NgayBatDau` datetime DEFAULT NULL,
  `NgayKetThuc` datetime DEFAULT NULL,
  `TrangThai` varchar(50) DEFAULT 'Đang chạy'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `duan`
--

INSERT INTO `duan` (`MaDuAn`, `TenDuAn`, `NgayBatDau`, `NgayKetThuc`, `TrangThai`) VALUES
(1, 'Xây dựng Hệ thống Web SCADA', '2026-03-01 00:00:00', '2026-12-31 00:00:00', 'Đang chạy'),
(2, 'Triển khai Hạ tầng Mạng Tòa E', '2026-09-01 00:00:00', '2026-11-30 00:00:00', 'Đang chạy');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phancong`
--

CREATE TABLE `phancong` (
  `MaTask` int(11) NOT NULL,
  `MaThanhVien` int(11) NOT NULL,
  `NgayGiao` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `phancong`
--

INSERT INTO `phancong` (`MaTask`, `MaThanhVien`, `NgayGiao`) VALUES
(1, 1, '2026-11-10 17:44:29'),
(2, 1, '2026-11-10 17:44:29'),
(3, 2, '2026-11-10 17:44:29');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thanhvien`
--

CREATE TABLE `thanhvien` (
  `MaThanhVien` int(11) NOT NULL,
  `HoTen` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `ChuyenMon` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `thanhvien`
--

INSERT INTO `thanhvien` (`MaThanhVien`, `HoTen`, `Email`, `ChuyenMon`) VALUES
(1, 'Nguyễn Hữu Trường', 'truong.nh@epu.edu.vn', 'Cyber Security'),
(2, 'Trần Văn Nam', 'nam.tv@epu.edu.vn', 'Network Admin'),
(3, 'Lê Thị Mai', 'mai.lt@epu.edu.vn', 'Developer');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `congviec`
--
ALTER TABLE `congviec`
  ADD PRIMARY KEY (`MaTask`),
  ADD KEY `MaDuAn` (`MaDuAn`);

--
-- Chỉ mục cho bảng `duan`
--
ALTER TABLE `duan`
  ADD PRIMARY KEY (`MaDuAn`);

--
-- Chỉ mục cho bảng `phancong`
--
ALTER TABLE `phancong`
  ADD PRIMARY KEY (`MaTask`,`MaThanhVien`),
  ADD KEY `MaThanhVien` (`MaThanhVien`);

--
-- Chỉ mục cho bảng `thanhvien`
--
ALTER TABLE `thanhvien`
  ADD PRIMARY KEY (`MaThanhVien`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `congviec`
--
ALTER TABLE `congviec`
  MODIFY `MaTask` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `duan`
--
ALTER TABLE `duan`
  MODIFY `MaDuAn` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT cho bảng `thanhvien`
--
ALTER TABLE `thanhvien`
  MODIFY `MaThanhVien` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Ràng buộc đối với các bảng kết xuất
--

--
-- Ràng buộc cho bảng `congviec`
--
ALTER TABLE `congviec`
  ADD CONSTRAINT `congviec_ibfk_1` FOREIGN KEY (`MaDuAn`) REFERENCES `duan` (`MaDuAn`) ON DELETE CASCADE;

--
-- Ràng buộc cho bảng `phancong`
--
ALTER TABLE `phancong`
  ADD CONSTRAINT `phancong_ibfk_1` FOREIGN KEY (`MaTask`) REFERENCES `congviec` (`MaTask`) ON DELETE CASCADE,
  ADD CONSTRAINT `phancong_ibfk_2` FOREIGN KEY (`MaThanhVien`) REFERENCES `thanhvien` (`MaThanhVien`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
