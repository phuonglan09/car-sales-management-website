create database RentCar3
use RentCar3

CREATE TABLE Staff (
    MaNV VARCHAR(100) PRIMARY KEY,
    Ten nVARCHAR(100),
    GioiTinh nVARCHAR(10),
    Email VARCHAR(100),
    Phone VARCHAR(11) unique,
	DiaChi nvarchar(100),
);


create table Account (
	MaNV VARCHAR(100) PRIMARY KEY,
    TenDN VARCHAR(100),
	Pass varchar(100),
	Quyen nvarchar(100)
	FOREIGN KEY (MaNV) REFERENCES Staff(MaNV)
);


create table Client (
	MaKH VARCHAR(100) primary key,
	TenKH nVARCHAR(100),
	GT nVARCHAR(10),		
    Mail VARCHAR(100),
    SDT VARCHAR(11) unique,
	DC nvarchar(100),
	NgayThem datetime
);

-- Thiếu mẫu: tên xe (2)
create table Vehicle (
	MaXe VARCHAR(100) primary key,
	Mau nvarchar(100),
	LoaiXe nvarchar(100),
	Hang nvarchar(100),
	LoaiNhienLieu nvarchar(100),
	DungTich float,	-- (lit)
	Registration nvarchar(100),
	MauSac nvarchar(100),
	TinhNang nvarchar(100),	--moi them
	GiaThue float,
	TinhTrang nvarchar(100), --đang cho thuê, trống
	Note nvarchar(100)
);


create table DonHang (
	MaDH VARCHAR(100) primary key,
	MaKH VARCHAR(100),
	MaNV VARCHAR(100),
	MaXe VARCHAR(100),
	NgayThue datetime,
	NgayTra datetime,
	TinhTrangTruoc nvarchar(100),
	NgayThemDH datetime,
	CheckReturn varchar(5),	-- yes, no
	GhiChu nvarchar(100),
	FOREIGN KEY (MaKH) REFERENCES Client(MaKH),
	FOREIGN KEY (MaNV) REFERENCES Staff(MaNV),
	FOREIGN KEY (MaXe) REFERENCES Vehicle(MaXe)
	
);


--  đổi tình trạng trước lên trên (1)
create table DonHangInfo (
	MaInfo varchar(100) primary key,
	MaDH VARCHAR(100),
	DateOfPayment datetime,
	TongSoLuong int,	-- ngay thue
	TotalPrice float,
	TinhTrangSau nvarchar(100),    --traxe
	FOREIGN KEY (MaDH) REFERENCES DonHang(MaDH),
);

UPDATE DonHangInfo
SET TongSoLuong = DATEDIFF(day, (SELECT NgayThue FROM DonHang WHERE DonHangInfo.MaDH = DonHang.MaDH), (SELECT NgayTra FROM DonHang WHERE DonHangInfo.MaDH = DonHang.MaDH));

UPDATE DonHangInfo

-- oke
UPDATE DonHangInfo
SET TotalPrice = DonHangInfo.TongSoLuong * Vehicle.GiaThue
FROM DonHangInfo
JOIN DonHang ON DonHangInfo.MaDH = DonHang.MaDH
JOIN Vehicle ON DonHang.MaXe = Vehicle.MaXe;

select TotalPrice from DonHangInfo

select TongSoLuong from DonHangInfo
select Count(*) from DonHang

SELECT Vehicle.GiaThue
FROM DonHangInfo
JOIN DonHang ON DonHangInfo.MaDH = DonHang.MaDH
JOIN Vehicle ON DonHang.MaXe = Vehicle.MaXe;
-----

SELECT 
    DonHang.MaDH,
    Client.TenKH,
    Staff.Ten,
    Vehicle.Mau,

    DonHang.NgayThemDH,
    DonHang.CheckReturn,

    DonHangInfo.DateOfPayment,
    DonHangInfo.TongSoLuong,
    DonHangInfo.TotalPrice
FROM DonHang
JOIN DonHangInfo ON DonHang.MaDH = DonHangInfo.MaDH
JOIN Client ON DonHang.MaKH = Client.MaKH
JOIN Staff ON DonHang.MaNV = Staff.MaNV
JOIN Vehicle ON DonHang.MaXe = Vehicle.MaXe;
--
---lich trinh
Mã Đơn Đặt Hàng (MaDH): Cho phép người dùng xác định mỗi đơn đặt hàng một cách duy nhất.

Ngày Bắt Đầu Thuê (NgayThue) và Ngày Kết Thúc Thuê (NgayTra): Hiển thị thời gian khách hàng sẽ thuê xe.

Thông tin Xe Thuê (MauXe, BiểnSố, LoaiXe, ...): Cung cấp thông tin chi tiết về xe được thuê để khách hàng biết xe nào đang được sử dụng.

Trạng Thái Đơn Đặt Hàng (CheckReturn): Cho biết đơn đặt hàng đã được trả hay chưa.

Thông tin Thanh Toán (DateOfPayment, TongSoLuong, TotalPrice): Hiển thị các thông tin liên quan đến thanh toán.

Ghi Chú (GhiChu): Cung cấp một ô để khách hàng hoặc nhân viên có thể thêm các ghi chú hoặc yêu cầu đặc biệt.

Loại Nhân Viên (loainv): Hiển thị loại nhân viên liên quan đến đơn đặt hàng.

Mã Khách Hàng (MaKH) và Tên Khách Hàng (TenKH): Để xác định người thuê xe.


-- còn chi tiết
delete from table DonHangInfo
----------- doanh thu
SELECT
    Vehicle.Hang AS HangXe,
    Vehicle.Mau AS MauXe,
    COUNT(DonHang.MaDH) AS SoLuong,
    SUM(DonHangInfo.TotalPrice) AS DoanhThu
FROM
    DonHang
JOIN DonHangInfo ON DonHang.MaDH = DonHangInfo.MaDH
JOIN Client ON DonHang.MaKH = Client.MaKH
JOIN Staff ON DonHang.MaNV = Staff.MaNV
JOIN Vehicle ON DonHang.MaXe = Vehicle.MaXe
GROUP BY
    Vehicle.Hang, Vehicle.Mau
ORDER BY
    HangXe, MauXe;