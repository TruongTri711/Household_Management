CREATE DATABASE QLHOKHAU
GO 

USE QLHOKHAU
GO

-- tạo bảng SOHOKHAU
CREATE TABLE SOHOKHAU
(
	MaSHK CHAR(10) PRIMARY KEY,
	DiaChi NVARCHAR(200),
	NgayCap CHAR(15),
)
GO

-- tạo bảng THAYDOICHUHO
CREATE TABLE THAYDOICHUHO
(
	 MaphieuTDCH CHAR(20) PRIMARY KEY,
	 HoTen NVARCHAR(70),
	 NamSinh CHAR(15),	
	 LYDOTHAYDOI NVARCHAR(100),
	 NGAYTHAYDOI CHAR(15),
	 QHCHUHOCU NVARCHAR(15),
	 QHCHUHOMOI NVARCHAR(15),
	 
	 MaSHK CHAR(10)	 
	 
	 FOREIGN KEY(MaSHK) REFERENCES dbo.SOHOKHAU(MaSHK)
 
)
GO

 -- tạo bảng SOTAMTRU
CREATE TABLE TAMTRUTAMVANG
(
	 MaSTT CHAR(15) PRIMARY KEY,
	 HoTen NVARCHAR(70),
	 NamSinh CHAR(15),-- CHECK(YEAR(GETDATE()) - YEAR(NamSinh) >= 0 )
	 CMND CHAR(15),
	 DiaChi NVARCHAR(100),
	 TuNgay CHAR(15),
	 DenNgay CHAR(15),
	 LyDo NVARCHAR(200),
	 
	 MaSHK CHAR(10) 
	 FOREIGN KEY(MaSHK) REFERENCES dbo.SOHOKHAU(MaSHK)
)

-- tạo bảng PHIEUTU
CREATE TABLE PHIEUTU
(
	 MaPhieuTu CHAR(20) PRIMARY KEY,
	 HoTen NVARCHAR(70),
	 NamSinh CHAR(15),
	 NgayMat CHAR(15), --CHECK(YEAR(GETDATE()) - YEAR(NamSinh) >= 0 ),
	 LydoMat NVARCHAR(100),
	 NoiMat NVARCHAR(100),
	 
	 MaSHK CHAR(10)
	 
	 FOREIGN KEY(MaSHK) REFERENCES dbo.SOHOKHAU(MaSHK)
)
GO

-- tạo bảng GIAYKHAISINH
CREATE TABLE GIAYKHAISINH
(
	 MaGKS CHAR (15) PRIMARY KEY,
	 
	 HoTen NVARCHAR(70),
	 GioiTinh NVARCHAR(7) CHECK (GIOITINH IN ('Nam',N'Nữ')),
	 NamSinh CHAR(15), --CHECK(YEAR(GETDATE()) - YEAR(NamSinh) >= 0 ),
	 NoiSinh NVARCHAR(70),
	 DanToc NVARCHAR(50),
	 QuocTich NVARCHAR(50),
	 QueQuan NVARCHAR(50),
	 HotenCha NVARCHAR(60),
	 DanTocCha NVARCHAR(40),
	 QuocTichCha NVARCHAR(40),
	 HotenMe NVARCHAR(60),
	 DanTocMe NVARCHAR(40),
	 QuocTichMe NVARCHAR(40),
	 HoTenNguoiDiKhaiSinh NVARCHAR(60),
	 QHNguoiKhaiSinh NVARCHAR(10),
	 NgayDangKy CHAR(15),	 
)
GO

-- tạo bảng NHANTHAN
CREATE TABLE NHANTHAN
(
	 MaSHK CHAR(10),
	 
	 QHCHUHO NVARCHAR(20),
	 HoTen NVARCHAR(70),
	 BiDanh NVARCHAR(30),
	 NamSinh CHAR(15),
	 NoiSinh NVARCHAR(50),
	 GioiTinh NVARCHAR(7) CHECK (GIOITINH IN ('Nam',N'Nữ')),
	 QueQuan NVARCHAR(50),
	 DanToc NVARCHAR(30),
	 TonGiao NVARCHAR(20),
	 CMND CHAR(15),
	 HoChieuSo CHAR(15), 
	 NgheNghiep NVARCHAR(50),
	 ChuyenDenNgay CHAR(15),
	 NoiOTruocKhiChuyenDen NVARCHAR(70),
	 MaGKS CHAR(15)
	 
	 PRIMARY KEY(HoTen,NamSinh)
)
GO

 --tạo bảng CMND
CREATE TABLE CMND 
(
	 CMND CHAR(15) PRIMARY KEY,
	 HoTen NVARCHAR(70),
	 NamSinh CHAR(15),
	 NguyenQuan NVARCHAR(50),
	 NoiCap NVARCHAR (150),
	 NgayCap CHAR(20)	
)
GO

 --tạo khóa ngoại 
ALTER TABLE dbo.NHANTHAN ADD FOREIGN KEY(MaGKS) REFERENCES dbo.GIAYKHAISINH(MaGKS)
ALTER TABLE dbo.NHANTHAN ADD FOREIGN KEY(MaSHK) REFERENCES dbo.SOHOKHAU(MaSHK)
ALTER TABLE dbo.CMND ADD FOREIGN KEY(HoTen,NamSinh) REFERENCES dbo.NHANTHAN(HoTen,NamSinh)
GO

-- insert daata bảng SOHOKHAU
INSERT dbo.SOHOKHAU VALUES  ( '01' , N'Ấp An Nghĩa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1987' )-- Tổ 1 , Tổ 2 , Tổ 3 , Tổ 4
INSERT dbo.SOHOKHAU VALUES  ( '02' , N'Ấp An Nghĩa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1989' )-- Tổ 5 , Tổ 6 , Tổ 7
INSERT dbo.SOHOKHAU VALUES  ( '03' , N'Ấp An Nghĩa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1990' )
INSERT dbo.SOHOKHAU VALUES  ( '04' , N'Ấp An Nghĩa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1992' )
INSERT dbo.SOHOKHAU VALUES  ( '05' , N'Ấp An Nghĩa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1991' )
INSERT dbo.SOHOKHAU VALUES  ( '06' , N'Ấp An Nghĩa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1983' )
INSERT dbo.SOHOKHAU VALUES  ( '07' , N'Ấp An Nghĩa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1978' )
INSERT dbo.SOHOKHAU VALUES  ( '08' , N'Ấp An Nghĩa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1976' )
INSERT dbo.SOHOKHAU VALUES  ( '09' , N'Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1980' )
INSERT dbo.SOHOKHAU VALUES  ( '10',  N'Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1985' )
INSERT dbo.SOHOKHAU VALUES  ( '11',  N'Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1981' )
INSERT dbo.SOHOKHAU VALUES  ( '12',  N'Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1979' )
INSERT dbo.SOHOKHAU VALUES  ( '13',  N'Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1974' )
INSERT dbo.SOHOKHAU VALUES  ( '14',  N'Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1988' )
INSERT dbo.SOHOKHAU VALUES  ( '15',  N'Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1998' )
INSERT dbo.SOHOKHAU VALUES  ( '16',  N'Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1990' )
INSERT dbo.SOHOKHAU VALUES  ( '17',  N'Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1994' )
INSERT dbo.SOHOKHAU VALUES  ( '18',  N'Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1987' )
INSERT dbo.SOHOKHAU VALUES  ( '19',  N'Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1992' )
INSERT dbo.SOHOKHAU VALUES  ( '20',  N'Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1985' )
INSERT dbo.SOHOKHAU VALUES  ( '21' , N'Ấp An Bình, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/04/1988' )
INSERT dbo.SOHOKHAU VALUES  ( '22' , N'Ấp An Bình, Xã An Thới Đông, Cần Giờ, TPHCM' , '20/04/2001' )
INSERT dbo.SOHOKHAU VALUES  ( '23' , N'Ấp An Bình, Xã An Thới Đông, Cần Giờ, TPHCM' , '11/01/2017' )
INSERT dbo.SOHOKHAU VALUES  ( '24' , N'Ấp An Bình, Xã An Thới Đông, Cần Giờ, TPHCM' , '30/09/2018' )
INSERT dbo.SOHOKHAU VALUES  ( '25' , N'Ấp An Bình, Xã An Thới Đông, Cần Giờ, TPHCM' , '01/01/2017' )
INSERT dbo.SOHOKHAU VALUES  ( '26' , N'Ấp An Bình, Xã An Thới Đông, Cần Giờ, TPHCM' , '24/12/1999' )
INSERT dbo.SOHOKHAU VALUES  ( '27' , N'Ấp An Bình, Xã An Thới Đông, Cần Giờ, TPHCM' , '04/10/1980' )
INSERT dbo.SOHOKHAU VALUES  ( '28' , N'Ấp An Bình, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/012/2004')
INSERT dbo.SOHOKHAU VALUES  ( '29' , N'Ấp An Bình, Xã An Thới Đông, Cần Giờ, TPHCM' , '30/12/2017' )
INSERT dbo.SOHOKHAU VALUES  ( '30' , N'Ấp An Bình, Xã An Thới Đông, Cần Giờ, TPHCM' , '20/01/2018' )
INSERT dbo.SOHOKHAU VALUES  ( '31' , N'Ấp Rạch Lá, Xã An Thới Đông, Cần Giờ, TPHCM' , '01/01/2003' )
INSERT dbo.SOHOKHAU VALUES  ( '32' , N'Ấp Rạch Lá, Xã An Thới Đông, Cần Giờ, TPHCM' , '30/12/2000' )
INSERT dbo.SOHOKHAU VALUES  ( '33' , N'Ấp Rạch Lá, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/12/2003' )
INSERT dbo.SOHOKHAU VALUES  ( '34' , N'Ấp Rạch Lá, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/01/2000' )
INSERT dbo.SOHOKHAU VALUES  ( '35' , N'Ấp Rạch Lá, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/08/2004' )
INSERT dbo.SOHOKHAU VALUES  ( '36' , N'Ấp Rạch Lá, Xã An Thới Đông, Cần Giờ, TPHCM' , '07/06/2005' )
INSERT dbo.SOHOKHAU VALUES  ( '37' , N'Ấp Rạch Lá, Xã An Thới Đông, Cần Giờ, TPHCM' , '17/09/2004' )
INSERT dbo.SOHOKHAU VALUES  ( '38' , N'Ấp Rạch Lá, Xã An Thới Đông, Cần Giờ, TPHCM' , '14/05/2003' )
INSERT dbo.SOHOKHAU VALUES  ( '39' , N'Ấp Rạch Lá, Xã An Thới Đông, Cần Giờ, TPHCM' , '04/12/2004' )
INSERT dbo.SOHOKHAU VALUES  ( '40' , N'Ấp Rạch Lá, Xã An Thới Đông, Cần Giờ, TPHCM' , '12/08/2003' )
INSERT dbo.SOHOKHAU VALUES  ( '41' , N'Ấp Rạch Lá, Xã An Thới Đông, Cần Giờ, TPHCM' , '09/09/2004' )
GO

			-- =====================================================================================================================================
-- insert TAMTTRUTAMVANG
INSERT dbo.TAMTRUTAMVANG VALUES  ( '1' ,  N'Lê Bá Lộc' , '03/02/2001' , '' ,   N'421 Thành Thái, Quận 10, TPHCM' ,  '15/02/2020' ,  '13/02/2025' ,  N'Học' ,  '01'  )
INSERT dbo.TAMTRUTAMVANG VALUES  ( '2' , N'Lê Bá Kiến' , '03/04/2001' ,  '023120103' ,  N'425 Thành Thái, Quận 10, TPHCM' , '15/03/2020' , '13/04/2025' ,  N'Học' ,   '05'   )
INSERT dbo.TAMTRUTAMVANG VALUES  ( '3' ,  N'Trần Lê Huy' , '03/12/2000' ,  '020124598' ,  N'421 Nguyễn Duy Dương, Quận 10, TPHCM' ,  '01/02/2020' , '13/02/2024' ,  N'Học' ,   '07'    )
INSERT dbo.TAMTRUTAMVANG VALUES  ( '4' , N'Bá Văn Cao' , '03/02/2001' ,  '02132645023' , N'421 Thành Thái, Quận 10, TPHCM' , '15/02/2018' , '13/02/2022' , N'Học' , '09'  )
INSERT dbo.TAMTRUTAMVANG VALUES  ( '5' ,  N'Nguyễn Huy Hùng' ,   '03/02/2005' ,  '' ,  N'421 Thành Thái, Quận 10, TPHCM' , '15/02/2018' ,  '13/02/2023' , N'Học' ,  '11'   )
INSERT dbo.TAMTRUTAMVANG VALUES  ( '6' ,  N'Đào Bá Lê' ,  '03/02/2002' ,  '021203254' ,   N'444 Thành Thái, Quận 10, TPHCM' , '15/02/2019' ,  '13/02/2022' , N'Học' , '15'   )
INSERT dbo.TAMTRUTAMVANG VALUES  ( '7' ,  N'Trần Phước Thiện' , '03/02/2003' ,  '045201235' ,  N'421 Thành Thái, Quận 10, TPHCM' , '15/02/2020' ,  '13/02/2025' ,  N'Học' ,   '17'    )
INSERT dbo.TAMTRUTAMVANG VALUES  ( '8' , N'Phạm Văn Tuyển' ,  '03/02/2005' ,'023154625', N'421 Thành Thái, Quận 10, TPHCM' ,  '15/02/2020' ,  '13/02/2025' ,  N'Học' ,  '20'  )

			-- =====================================================================================================================================
-- insert PhieuTu
INSERT dbo.PHIEUTU VALUES  ( '1' , N'Trần Bão Tố' , '11/03/1985' , '20/06/2020' , N'Bệnh Cười' , N'TPHCM' , '01' )
INSERT dbo.PHIEUTU VALUES  ( '2' , N'Nguyễn Di Cư' , '10/07/1964' , '10/04/2020' , N'Bệnh Cà khịa' , N'TPHCM' , '04' )
GO

			-- ======================================================================================================================================

-- insert data bảng GIAYKHAISINH
INSERT dbo.GIAYKHAISINH( MaGKS , HoTen , GioiTinh , NamSinh , NoiSinh , DanToc , QuocTich ,  QueQuan , HotenCha ,  DanTocCha ,  QuocTichCha ,  HotenMe ,  DanTocMe ,  
						QuocTichMe ,  HoTenNguoiDiKhaiSinh ,  QHNguoiKhaiSinh , NgayDangKy  )
VALUES  ( '01' , N'Trần Văn Đạt' , N'Nam' , '12/05/1964' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Long An' , N'Trần Hiếu Chiến' , N'Kinh' , N'Việt Nam' , N'Nguyễn Phi Nhung' ,
		 N'Kinh' , N'Việt Nam' , N'Trần Hiếu Chiến' , N'Cha' , '12/05/1964' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '02' , N'Phan Tú Cầm' , N'Nữ' ,  '12/06/1965' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Cà Mau' , N'Phan Hiếu Nghĩa' , N'Kinh' , N'Việt Nam' , N'Trần Phi Ngọc' ,
		 N'Kinh' , N'Việt Nam' , N'Lê Hiếu Nghĩa' , N'Cha' , '10/06/1965' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '03' , N'Trần Đức Bo' , N'Nam' ,  '21/07/1982' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Long An' , N'Trần Đức Thánh' , N'Kinh' , N'Việt Nam' , N'Lê Thị Huyền My' ,
		 N'Kinh' , N'Việt Nam' , N'Trần Đức Thánh' , N'Cha' , '21/07/1982' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '04' , N'Trần Thị Thanh Tâm' , N'Nữ' ,  '21/01/1980' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Bến Tre' , N'Trần Thanh Đức' , N'Kinh' , N'Việt Nam' , N'Phan Thị Lương' ,
		 N'Kinh' , N'Việt Nam' , N'Trần Thanh Đức' , N'Cha' , '21/01/1980' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '05' , N'Trần Ngọc Long' , N'Nam' ,  '21/05/2000' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Long An' , N'Trần Đức Bo' , N'Kinh' , N'Việt Nam' , N'Trần Thị Thanh Tâm' ,
		 N'Kinh' , N'Việt Nam' , N'Trần Đức Bo' , N'Cha' , '21/05/2000' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '06' , N'Trương Phi' , N'Nam' ,  '12/09/1977' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'TP HCM' , N'Trương Gia Bảo' , N'Kinh' , N'Việt Nam' , N'Trần Ngọc Hoa' ,
		 N'Kinh' , N'Việt Nam' , N'Trương Gia Bảo' , N'Cha' , '12/09/1977' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '07' , N'Nguyễn Thị Mai Anh' , N'Nữ' ,  '12/02/1980' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Quãng Ngãi' , N'Nguyễn Hữu Lộc' , N'Kinh' , N'Việt Nam' , N'Trương Thị Lựu' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Hữu Lộc' , N'Cha' , '12/09/1977' )

INSERT dbo.GIAYKHAISINH VALUES  ( '08' , N'Trương Tinh Thái' , N'Nữ' ,  '12/05/1999' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'TP HCM' , N'Trương Phi' , N'Kinh' , N'Việt Nam' , N'Nguyễn Thị Mai Anh' ,
		 N'Kinh' , N'Việt Nam' , N'Trương Phi' , N'Cha' , '12/05/1999' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '09' , N'Trương Tinh Thần' , N'Nam' ,  '31/05/1999' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'TP HCM' , N'Trương Phi' , N'Kinh' , N'Việt Nam' , N'Nguyễn Thị Mai Anh' ,
		 N'Kinh' , N'Việt Nam' , N'Trương Phi' , N'Cha' , '31/05/1999' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '10' , N'Phạm Văn Lăng' , N'Nam' ,  '01/01/1964' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Tây Ninh' , N'Phạm Hồng Phước' , N'Kinh' , N'Việt Nam' , N'Nguyễn Thị Mương' ,
		 N'Kinh' , N'Việt Nam' , N'Phạm Hồng Phước' , N'Cha' , '01/01/1964' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '11' , N'Nguyễn Thị Thu' , N'Nữ' ,  '18/01/1972' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Tây Ninh' , N'Nguyễn Văn Sạch' , N'Kinh' , N'Việt Nam' , N'Nguyễn Thị Chảo' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Văn Sạch' , N'Cha' , '18/01/1972' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '12' , N'Phạm Hoàng Tuấn' , N'Nam' ,  '31/05/2000' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Tây Ninh' , N'Phạm Văn Lăng' , N'Kinh' , N'Việt Nam' , N'Nguyễn Thị Thu' ,
		 N'Kinh' , N'Việt Nam' , N'Phạm Văn Lăng' , N'Cha' , '31/05/2000' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '13' , N'Quang Vũ' , N'Nam' ,  '23/01/1970' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Cà Mau' , N'Quang Vân Trường' , N'Kinh' , N'Việt Nam' , N'Đỗ Như Ý' ,
		 N'Kinh' , N'Việt Nam' , N'Quang Vân Trường' , N'Cha' , '23/01/1970' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '14' , N'Nguyễn Thị Hằng Nga' , N'Nữ' ,  '02/03/1975' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Tiền Giang' , N'Nguyễn Văn Sách' , N'Kinh' , N'Việt Nam' , N'Lưu Hằng Tử' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Văn Sách' , N'Cha' , '02/03/1975' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '15' , N'Quang Mãnh Hổ' , N'Nam' , '15/05/2005' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Cà Mau' , N'Quang Vũ' , N'Kinh' , N'Việt Nam' , N'Nguyễn Thị Hằng Nga' ,
		 N'Kinh' , N'Việt Nam' , N'Quang Vũ' , N'Cha' , '15/05/2005' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '16' , N'Nguyễn Thanh Minh' , N'Nam' ,  '16/10/1960' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Cần Thơ' , N'Nguyễn Thanh Toán' , N'Kinh' , N'Việt Nam' , N'Hồ Ngọc Hà' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Thanh Toán' , N'Cha' ,  '16/10/1960'  )

INSERT dbo.GIAYKHAISINH VALUES  ( '17' , N'Trần Thị Ngọc' , N'Nữ' ,  '19/12/1962' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Trà Vinh' , N'Trần Đình Trọng' , N'Kinh' , N'Việt Nam' , N'Hồ Ngọc Hân' ,
		 N'Kinh' , N'Việt Nam' , N'Trần Đình Trọng' , N'Cha' , '19/12/1962'  ) 
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '18' , N'Thái Vũ' , N'Nam' ,  '18/08/1955' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Sơn La' , N'Thái Giám' , N'Kinh' , N'Việt Nam' , N'Quách Thị Mậu' ,
		 N'Kinh' , N'Việt Nam' , N'Thái Giám' , N'Cha' , '18/08/1955'  ) 
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '19' , N'Trần Bích Trâm' , N'Nữ' ,  '22/02/1952' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Long An' , N'Trần Dần' , N'Kinh' , N'Việt Nam' , N'Quách Thị Mai' ,
		 N'Kinh' , N'Việt Nam' , N'Trần Dần' , N'Cha' , '22/02/1952'  ) 
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '20' , N'Thái Văn Cơ' , N'Nữ' ,  '14/04/1984' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Sơn La' , N'Thái Vũ' , N'Kinh' , N'Việt Nam' , N'Trần Bích Trâm' ,
		 N'Kinh' , N'Việt Nam' , N'Thái Vũ' , N'Cha' , '14/04/1984'  ) 
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '21' , N'Phan Phương Nam' , N'Nam' ,  '09/12/1958' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Thái Bình' , N'Phan Châu Trinh' , N'Kinh' , N'Việt Nam' , N'Nguyễn Thị Minh Châu' ,
		 N'Kinh' , N'Việt Nam' , N'Phan Châu Trinh' , N'Cha' , '09/12/1958'  ) 
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '22' , N'Nguyễn Thị Mỹ Trinh' , N'Nữ' ,  '05/01/1960' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Huế' , N'Nguyễn Công Toàn' , N'Kinh' , N'Việt Nam' , N'Nguyễn Huỳnh Như Hoa' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Công Toàn' , N'Cha' , '05/01/1960'  ) 
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '23' , N'Phan Phương Đông' , N'Nam' ,  '03/03/1980' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Thái Bình' , N'Phan Phương Nam' , N'Kinh' , N'Việt Nam' , N'Nguyễn Thị Mỹ Trinh' ,
		 N'Kinh' , N'Việt Nam' , N'Phan Phương Nam' , N'Cha' , '03/03/1980'  ) 
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '24' , N'Nguyễn Bá Độ' , N'Nam' ,  '12/12/1960' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Ninh Thuận' , N'Nguyễn Bá Đạo' , N'Kinh' , N'Việt Nam' , N'Phạm Nguyễn Hồng Tú' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Bá Đạo' , N'Cha' , '12/12/1960'  ) 
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '25' , N'Nguyễn Thị Diễm Trinh' , N'Nữ' ,  '11/01/1964' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Nha Trang' , N'Nguyễn Xuân Hòa' , N'Kinh' , N'Việt Nam' , N'Nguyễn Thị Bạch My' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Xuân Hòa' , N'Cha' , '11/01/1964'  ) 
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '26' , N'Phạm Nhật Vượng' , N'Nam' ,  '16/07/1965' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Bình Phước' , N'Phạm Hữu Tài' , N'Kinh' , N'Việt Nam' , N'Phan Thị Loan' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Bá Đạo' , N'Cha' , '16/07/1965'  ) 
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '27' , N'Trần Thị Thắm' , N'Nữ' ,  '28/11/1970' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Hà Nội' , N'Trần Văn An' , N'Kinh' , N'Việt Nam' , N'Đỗ Ngọc Ngà' ,
		 N'Kinh' , N'Việt Nam' , N'Trần Văn An' , N'Cha' , '28/11/1970'  )	
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '28' , N'Nguyễn Xuân Huy' , N'Nam' ,  '08/08/1963' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Phú Quốc' , N'Nguyễn Quốc Chí' , N'Kinh' , N'Việt Nam' , N'Lê Thị Riêng' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Quốc Chí' , N'Cha' , '08/08/1963'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '29' , N'Lê Ngọc Mỹ Dung' , N'Nữ' ,  '30/12/1968' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Thái Bình' , N'Lê Chu Thành' , N'Kinh' , N'Việt Nam' , N'Nguyễn Thị Như Hoài' ,
		 N'Kinh' , N'Việt Nam' , N'Lê Chu Thành' , N'Cha' , '30/12/1968'  )
	
INSERT dbo.GIAYKHAISINH VALUES  ( '30' , N'Lê Nhật Khoa' , N'Nam' ,  '19/09/1961' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Bình Thuận' , N'Lê Nguyễn Tường Khanh' , N'Kinh' , N'Việt Nam' , N'Lê Thị Hồng' ,
		 N'Kinh' , N'Việt Nam' , N'Lê Nguyễn Tường Khanh' , N'Cha' , '19/09/1961'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '31' , N'Lê Thị Hạnh' , N'Nữ' ,  '02/02/1963' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Long Xuyên' , N'Lê Chu Thái' , N'Kinh' , N'Việt Nam' , N'Nguyễn Thị Thu Cúc' ,
		 N'Kinh' , N'Việt Nam' , N'Lê Chu Thái' , N'Cha' , '02/02/1963'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '32' , N'Lê Nhật Hạ' , N'Nữ' ,  '09/12/1985' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Bình Thuận' , N'Lê Nhật Khoa' , N'Kinh' , N'Việt Nam' , N'Lê Thị Hạnh' ,
		 N'Kinh' , N'Việt Nam' , N'Lê Nhật Khoa' , N'Cha' , '09/12/1985'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '33' , N'Lưu Ban' , N'Nam' ,  '17/07/1956' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Cao Bằng' , N'Lưu Bằng Chứng' , N'Kinh' , N'Việt Nam' , N'Nguyễn Lê Gia Hân' ,
		 N'Kinh' , N'Việt Nam' , N'Lưu Bằng Chứng' , N'Cha' , '17/07/1956'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '34' , N'Nguyễn Thị Bích' , N'Nữ' ,  '25/05/1959' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Sơn La' , N'Nguyễn Văn Cừ' , N'Kinh' , N'Việt Nam' , N'Lê Ngọc Mỹ ' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Văn Cừ' , N'Cha' , '25/05/1959'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '35' , N'Hoàng Công Trình' , N'Nam' ,  '01/01/1970' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Hà Nội' , N'Hoàng Hoa Thám' , N'Kinh' , N'Việt Nam' , N'Lê Nguyễn Tường Vy' ,
		 N'Kinh' , N'Việt Nam' , N'Hoàng Hoa Thám' , N'Cha' , '01/01/1970'  )
		 		 	 
INSERT dbo.GIAYKHAISINH VALUES  ( '36' , N'Hoàng Hà' , N'Nữ' ,  '06/06/1974' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Hải Phòng' , N'Hoàng Vũ' , N'Kinh' , N'Việt Nam' , N'Chu Ngọc Kim Ngân' ,
		 N'Kinh' , N'Việt Nam' , N'Hoàng Vũ' , N'Cha' , '06/06/1974'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '37' , N'Tào Tháo' , N'Nam' ,  '23/03/1975' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Bình Dương' , N'Tào Công ' , N'Kinh' , N'Việt Nam' , N'Quách Gia Nghi' ,
		 N'Kinh' , N'Việt Nam' , N'Tào Công' , N'Cha' , '23/03/1975'  )		 

INSERT dbo.GIAYKHAISINH VALUES  ( '38' , N'Nguyễn Thị Xuân' , N'Nữ' ,  '19/09/1978' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Cà Mau' , N'Nguyễn Hồ Hoàng Kiếm ' , N'Kinh' , N'Việt Nam' , N'Chu Thị Mỹ Hạnh' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Hồ Hoàng Kiếm' , N'Cha' , '19/09/1978'  )	
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '39' , N'Viên Thiệu' , N'Nam' ,  '22/03/1972	' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Bến Tre' , N'Viên Thục ' , N'Kinh' , N'Việt Nam' , N'Đỗ Thanh Thanh Hà' ,
		 N'Kinh' , N'Việt Nam' , N'Viên Thục' , N'Cha' , '22/03/1972'  )	
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '40' , N'Quách Thị Mai Vân' , N'Nữ' ,  '21/01/1974' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Mỹ Tho' , N'Quách Gia' , N'Kinh' , N'Việt Nam' , N'Chu Di Tam Tộc' ,
		 N'Kinh' , N'Việt Nam' , N'Quách Gia' , N'Cha' , '21/01/1974'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '41' , N'Viên Thuật' , N'Nam' ,  '27/07/1994	' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Bến Tre' , N'Viên Thiệu ' , N'Kinh' , N'Việt Nam' , N'Quách Thị Mai Vân' ,
		 N'Kinh' , N'Việt Nam' , N'Viên Thiệu' , N'Cha' , '27/07/1994'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '42' , N'Trương Minh Trí' , N'Nam' ,  '12/10/1966	' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Phú Yên' , N'Trương Giác' , N'Kinh' , N'Việt Nam' , N'Liềm Kim Ngân' ,
		 N'Kinh' , N'Việt Nam' , N'Trương Giác' , N'Cha' , '12/10/1966'  )

INSERT dbo.GIAYKHAISINH VALUES  ( '43' , N'Nguyễn Kiều Diễm Trinh' , N'Nữ' ,  '03/03/1970' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Bến Tre' , N'Nguyễn Quốc Thái' , N'Kinh' , N'Việt Nam' , N'Nguyễn Thị Minh Khai' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Quốc Thái' , N'Cha' , '03/03/1970'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '44' , N'Trương Minh Mẫn' , N'Nam' ,  '01/01/2000	' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Phú Yên' , N'Trương Minh Trí' , N'Kinh' , N'Việt Nam' , N'Nguyễn Kiều Diễm Trinh' ,
		 N'Kinh' , N'Việt Nam' , N'Trương Minh Trí' , N'Cha' , '01/01/2000'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '45' , N'Triệu Mãn Diên' , N'Nam' ,  '18/01/1959	' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'TP HCM' , N'Triệu Vân' , N'Kinh' , N'Việt Nam' , N'Từ Hi Thái Hậu' ,
		 N'Kinh' , N'Việt Nam' , N'Triệu Vân' , N'Cha' , '18/01/1959'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '46' , N'Mục Ninh Tuyết' , N'Nữ' ,  '22/07/1962' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Tây Ninh' , N'Mục Gia Thị' , N'Kinh' , N'Việt Nam' , N'Mục Bạch Lữ Nghi' ,
		 N'Kinh' , N'Việt Nam' , N'Mục Gia Thị' , N'Cha' , '22/07/1962'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '47' , N'Triệu Tử Long' , N'Nam' ,  '19/09/1982	' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'TP HCM' , N'Triệu Mãn Diên' , N'Kinh' , N'Việt Nam' , N'Mục Ninh Tuyết' ,
		 N'Kinh' , N'Việt Nam' , N'Triệu Mãn Diên' , N'Cha' , '19/09/1982'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '48' , N'Tôn Sách' , N'Nam' ,  '11/12/1964	' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Đồng Tháp' , N'Tôn Hoàn' , N'Kinh' , N'Việt Nam' , N'Mẫu Nhi Thiên Hạ' ,
		 N'Kinh' , N'Việt Nam' , N'Tôn Hoàn' , N'Cha' , '11/12/1964'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '49' , N'Đại Kiều' , N'Nữ' ,  '12/11/1968' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Hậu Giang' , N'Đại Gia' , N'Kinh' , N'Việt Nam' , N'Trần Ngọc Dung' ,
		 N'Kinh' , N'Việt Nam' , N'Đại Gia' , N'Cha' , '12/11/1968'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '50' , N'Tôn Quyền' , N'Nam' ,  '22/11/1998	' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Đồng Tháp' , N'Tôn Sách' , N'Kinh' , N'Việt Nam' , N'Đại Kiều' ,
		 N'Kinh' , N'Việt Nam' , N'Tôn Sách' , N'Cha' , '22/11/1998'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '51' , N'Nguyễn Hà Đông' , N'Nam' ,  '21/03/1950	' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Tiền Giang' , N'Nguyễn Hà Bá' , N'Kinh' , N'Việt Nam' , N'Từ Thị Thúy Hiền' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Hà Bá' , N'Cha' , '21/03/1950'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '52' , N'Trần Thị Mơ' , N'Nữ' ,  '03/03/1952' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Phú Quốc' , N'Trần Gia Gia' , N'Kinh' , N'Việt Nam' , N'Trần Bội Thu' ,
		 N'Kinh' , N'Việt Nam' , N'Trần Gia Gia' , N'Cha' , '03/03/1952'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '53' , N'Nguyễn Hà Tĩnh' , N'Nam' ,  '21/03/1982	' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Tiền Giang' , N'Nguyễn Hà Đông' , N'Kinh' , N'Việt Nam' , N'Trần Thị Mơ' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Hà Đông' , N'Cha' , '21/03/1982'  )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '54' , N'Nguyễn Hà Nam' , N'Nam' ,  '21/03/1982	' , N'Từ Vũ' , N'Kinh' , N'Việt Nam' , N'Tiền Giang' , N'Nguyễn Hà Đông' , N'Kinh' , N'Việt Nam' , N'Trần Thị Mơ' ,
		 N'Kinh' , N'Việt Nam' , N'Nguyễn Hà Đông' , N'Cha' , '21/03/1982'  )

INSERT dbo.GIAYKHAISINH VALUES  ( '55' , N'Trần Văn Lâm' , N'Nam' ,  '11/08/1964' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Long An' , N'Trần Hiếu Thắng' , N'Kinh' , N'Viet Nam' , N'Nguyễn Phi Nhung' ,
		 N'kinh' , N'Viet Nam' , N'Trần Hiếu Thắng' , N'Cha' , '11/10/1965' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '56' , N'Phan Tú Uyên' , N'Nữ' ,  '10/07/1965' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'An Giang' , N'Phạm Thành Đạt' , N'Kinh' , N'Viet Nam' , N'Nguyễn Xuân Nghi' ,
		 N'kinh' , N'Viet Nam' , N'Phạm Thành Đạt' , N'Cha' , '10/06/1966' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '57' , N'Đinh Quang Vinh' , N'Nam' ,  '12/05/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Long An' , N'Đinh Xuân Diệu' , N'Kinh' , N'Viet Nam' , N'Trần Diễm Cát' ,
		 N'kinh' , N'Viet Nam' , N'Đinh Quang Vinh' , N'Cha' , '10/07/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '58' , N'Lý Nhã Kỳ' , N'Nữ' ,  '10/06/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Tiền Giang' , N'Lý Tôn Bạch' , N'Kinh' , N'Viet Nam' , N'Nguyễn Huê Hồng' ,
		 N'kinh' , N'Viet Nam' , N'Lý Tôn Bạch' , N'Cha' , '10/06/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '59' , N'Lý Tú Cầm' , N'Nữ' ,  '10/06/1999' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Long An' , N'Đinh Quang Vinh' , N'Kinh' , N'Viet Nam' , N'Lý Tú Cầm' ,
		 N'kinh' , N'Viet Nam' , N'Đinh Quang Vinh' , N'Cha' , '10/12/2000' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '60' , N'Đoàn Hoàng Lộc' , N'Nam' ,  '10/06/1989' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Long An' , N'Đoàn Hoàng Hà' , N'Kinh' , N'Viet Nam' , N'Nguyễn Thị Mến' ,
		 N'kinh' , N'Viet Nam' , N'Đoàn Hoàng Hà' , N'Cha' , '10/06/1990' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '61' , N'Bùi Thị Tố Lan' , N'Nữ' ,  '10/06/1987' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Tiền Giang' , N'Bùi Xuân Hoài' , N'Kinh' , N'Viet Nam' , N'Nguyễn Phi Phụng' ,
		 N'kinh' , N'Viet Nam' , N'Bùi Xuân Hoài' , N'Cha' , '10/06/1988' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '62' , N'Đoàn Hoàng Tuấn' , N'Nam' ,  '11/06/2000' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Long An' , N'Đoàn Hoàng Lộc' , N'Kinh' , N'Viet Nam' , N'Bùi Thị Tố Lan' ,
		 N'kinh' , N'Viet Nam' , N'Đoàn Hoàng Lộc' , N'Cha' , '23/06/2001' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '63' , N'Nguyễn Linh An' , N'Nam' ,  '12/05/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Cần Thơ' , N'Nguyên Văn Linh' , N'Kinh' , N'Viet Nam' , N'Nguyễn Thị Tố' ,
		 N'kinh' , N'Viet Nam' , N'Nguyễn Văn Linh' , N'Cha' , '13/04/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '64' , N'Bùi Thị Xuân' , N'Nữ' ,  '10/08/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Tiền Giang' , N'Bùi Minh Khai' , N'Kinh' , N'Viet Nam' , N'Nguyễn Kiều An' ,
		 N'kinh' , N'Viet Nam' , N'Bùi Minh Khai' , N'Cha' , '20/06/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '65' , N'Trần Ngọc Hậu' , N'Nam' ,  '20/05/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Bến Tre' , N'Trần Ngọc An' , N'Kinh' , N'Viet Nam' , N'Nguyễn Thị Kiều' ,
		 N'kinh' , N'Viet Nam' , N'Trần Ngọc Hậu' , N'Cha' , '24/06/1973' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '66' , N'Nguyễn Thị Ngân' , N'Nữ' ,  '12/06/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Cần Thơ' , N'Nguyễn Hoài Nghĩa' , N'Kinh' , N'Viet Nam' , N'Trần Diễm Mi' ,
		 N'kinh' , N'Viet Nam' , N'Nguyễn Hoài Nghĩa' , N'Cha' , '11/09/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '67' , N'Long Tường Khanh' , N'Nam' ,  '12/05/1989' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Long An' , N'Long Hoàng Nguyên' , N'Kinh' , N'Viet Nam' , N'Nguyễn Thanh Hằng' ,
		 N'kinh' , N'Viet Nam' , N'Long Hoàng Nguyên' , N'Cha' , '10/07/1990' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '68' , N'Nguyễn Thị Kiều Tiên' , N'Nữ' ,  '10/01/1989' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Tiền Giang' , N'Nguyển Trãi Anh' , N'Kinh' , N'Viet Nam' , N'Lê Bích Thủy' ,
		 N'kinh' , N'Viet Nam' , N'Nguyễn Trãi Anh' , N'Cha' , '20/04/1990' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '69' , N'Lý Minh Dương' , N'Nam' ,  '12/05/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Long An' , N'Lý Hiếu Nghĩa' , N'Kinh' , N'Viet Nam' , N'Nguyễn Phi Ngân' ,
		 N'kinh' , N'Viet Nam' , N'Lý Hiếu Nghĩa' , N'Cha' , '14/05/1973' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '70' , N'Xương Nguyệt Anh' , N'Nữ' ,  '10/06/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Tiền Giang' , N'Xương Tào Tôn' , N'Kinh' , N'Viet Nam' , N'Ngô Lam Mẫn' ,
		 N'kinh' , N'Viet Nam' , N'Xương Tào Tôn' , N'Cha' , '30/04/1973' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '71' , N'Nguyễn Văn Dương' , N'Nam' ,  '15/05/1963' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Quảng Nam' , N'Nguyễn Văn Thành' , N'Kinh' , N'Viet Nam' , N'Lê Anh Thủy' ,
		 N'kinh' , N'Viet Nam' , N'Nguyễn Văn Thành' , N'Cha' , '11/06/1964' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '72' , N'Nguyễn Thị Xuân Hoài' , N'Nữ' ,  '10/06/1963' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Bạc Liêu' , N'Nguyễn Kim Trọng' , N'Kinh' , N'Viet Nam' , N'Nguyễn Phi Ngọc' ,
		 N'kinh' , N'Viet Nam' , N'Nguyễn Kim Trọng' , N'Cha' , '13/08/1964' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '73' , N'Lê Huỳnh Nhựt Tân' , N'Nam' ,  '21/12/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Tây Nguyên' , N'Lê Nhật Hoàng' , N'Kinh' , N'Viet Nam' , N'Nguyễn Ngọc Hân' ,
		 N'kinh' , N'Viet Nam' , N'Lê Nhật Hoàng' , N'Cha' , '30/09/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '74' , N'Ngô Minh Thư' , N'Nữ' ,  '10/06/1987' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Long An' , N'Ngô Đình Diệm' , N'Kinh' , N'Viet Nam' , N'Nguyễn Tuyết An' ,
		 N'kinh' , N'Viet Nam' , N'Ngô Đình Diệm' , N'Cha' , '24/09/1988' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '75' , N'Trần Quang Khải' , N'Nam' ,  '12/09/1989' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Tiền Giang' , N'Trần Hiếu Nghĩa' , N'Kinh' , N'Viet Nam' , N'Lê Ngọc Dung' ,
		 N'kinh' , N'Viet Nam' , N'Trần Hiếu Nghĩa' , N'Cha' , '10/12/1990' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '76' , N'Nguyển Thị Tuyết Như' , N'Nữ' ,  '09/08/1989' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Tiền Giang' , N'Nguyễn Đình Chiến' , N'Kinh' , N'Viet Nam' , N'Lê Ngọc An' ,
		 N'kinh' , N'Viet Nam' , N'Nguyễn Đình Chiến' , N'Cha' , '10/11/1990' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '77' , N'Phạm Hoàng Tuấn' , N'Nam' ,  '12/05/1989' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'An Giang' , N'Phạm Hoàng Nguyên' , N'Kinh' , N'Viet Nam' , N'Trần Diệu An' ,
		 N'kinh' , N'Viet Nam' , N'Phạm Hoàng Nguyên' , N'Cha' , '30/12/1990' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '78' , N'Lý Thu Hoài' , N'Nữ' ,  '10/06/1987' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Hậu Giang' , N'Lý Xử Từ' , N'Kinh' , N'Viet Nam' , N'Hoàng Kim Yến' ,
		 N'kinh' , N'Viet Nam' , N'Lý Xử Từ' , N'Cha' , '10/12/1990' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '79' , N'Mạc Đăng Khoa' , N'Nam' ,  '12/05/1978' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Cà Mau' , N'Mạc Văn Đường' , N'Kinh' , N'Viet Nam' , N'Lê Thúy Kiều' ,
		 N'kinh' , N'Viet Nam' , N'Mạc Văn Đường' , N'Cha' , '10/12/1979' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '80' , N'Hoa Mộc Lan' , N'Nữ' ,  '10/06/1978' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Cà Mau' , N'Hoa Anh Tài' , N'Kinh' , N'Viet Nam' , N'Đoàn Huệ Mẫn' ,
		 N'kinh' , N'Viet Nam' , N'Hoa Anh Tài' , N'Cha' , '10/12/1979' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '81' , N'Nguyễn Manh Cường' , N'Nam' ,  '12/05/1977' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Gia Lai' , N'Nguyễn Mạnh Hùng' , N'Kinh' , N'Viet Nam' , N'Lê Thanh Thúy' ,
		 N'kinh' , N'Viet Nam' , N'Nguyễn Mạnh Hùng' , N'Cha' , '10/12/1990' )
		 
 INSERT dbo.GIAYKHAISINH VALUES  ( '82' , N'Phạm Thị Thảo' , N'Nữ' ,  '11/09/1987' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Bến Tre' , N'Phạm Thanh Hùng' , N'Kinh' , N'Viet Nam' , N'Phạm Hoàng Thư' ,
		 N'kinh' , N'Viet Nam' , N'Phạm Thanh Hùng' , N'Cha' , '10/12/1988' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '83' , N'Phạm Trung Tấn' , N'Nam' ,  '12/05/1983' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Phạm Hoàng Anh' , N'Kinh' , N'Viet Nam' , N'Ngô Thị Xuân' ,
		 N'kinh' , N'Viet Nam' , N'Phạm Hoàng Anh' , N'Cha' , '10/12/1990' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '84' , N'Bùi Thị Tuyến Mẫn' , N'Nữ' ,  '10/06/1983' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Tiền Giang' , N'Bùi Xuân Hải' , N'Kinh' , N'Viet Nam' , N'Lê Tuyết Trăm' ,
		 N'kinh' , N'Viet Nam' , N'Bùi Xuân Hải' , N'Cha' , '10/12/1984' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '85' , N'Phạm Trung Thành' , N'Nam' ,  '10/06/2012' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Phạm Trung Tấn' , N'Kinh' , N'Viet Nam' , N'Bùi Thị Mẫn' ,
		 N'kinh' , N'Viet Nam' , N'Phạm Trung Tấn' , N'Cha' , '10/12/2013' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '86' , N'Nguyễn Duy An' , N'Nam' ,  '12/02/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Nguyễn Quang Khài' , N'Kinh' , N'Viet Nam' , N'Lê Thanh Nga' ,
		 N'kinh' , N'Viet Nam' , N'Nguyễn Quang Khải' , N'Cha' , '10/12/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '87' , N'Trần Thu Thùy' , N'Nữ' ,  '07/01/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'Nghệ An' , N'Trần Quang Đăng' , N'Kinh' , N'Viet Nam' , N'Lê Thùy Dung' ,
		 N'kinh' , N'Viet Nam' , N'Trần Quang Đăng' , N'Cha' , '10/12/1974' )		 		 		 		 		 
		 		 		 		 		 
INSERT dbo.GIAYKHAISINH VALUES  ( '88' , N'Nguyễn Thị Như Ý' , N'Nữ' ,  '07/07/2000' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TPHCM' , N'Nguyễn Duy An' , N'Kinh' , N'Viet Nam' , N'Trần Thu Thùy' ,
		 N'kinh' , N'Viet Nam' , N'Nguyễn Duy An' , N'Cha' , '10/12/2001' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '89' , N'Trần Thanh Hiền ' , N'Nam' ,  '12/05/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Trần An Nhiên' , N'Kinh' , N'Viet Nam' , N'Lỳ Uyển Nhi' ,
		 N'kinh' , N'Viet Nam' , N'Trần An Nhiên' , N'Cha' , '10/12/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '90' , N'Vĩnh Khiêm Thuyên' , N'Nữ' ,  '10/06/197' , N'Tiền Giang' , N'Kinh' , N'Viet Nam' , N'Tiền Giang' , N'Vĩnh Thanh Hòa' , N'Kinh' , N'Viet Nam' , N'Lê Ngọc Dung' ,
		 N'kinh' , N'Viet Nam' , N'Vĩnh Thanh Hòa' , N'Cha' , '10/12/1998' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '91' , N'Trần Ngọc An' , N'Nam' ,  '06/04/2000' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Trần Ngọc Thanh' , N'Kinh' , N'Viet Nam' , N'Nguyển Anh Lan' ,
		 N'kinh' , N'Viet Nam' , N'Trần Ngọc Thanh' , N'Cha' , '10/12/2001' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '92' , N'Lê Hoàng Khôi' , N'Nam' ,  '12/05/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Lê Thanh Minh' , N'Kinh' , N'Viet Nam' , N'Trần Ngọc Dung' ,
		 N'kinh' , N'Viet Nam' , N'Vĩnh Thanh Hòa' , N'Cha' , '10/12/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '93' , N'Trần Thanh Thúy' , N'Nam' ,  '10/06/1973' , N'Tiền Giang' , N'Kinh' , N'Viet Nam' , N'Tiền Giang' , N'Trần Thanh Nam' , N'Kinh' , N'Viet Nam' , N'Lê Ngọc Kiều' ,
		 N'kinh' , N'Viet Nam' , N'Trần Thanh Nam' , N'Cha' , '15/11/1974' )
		 		 		 
		 	 	 
INSERT dbo.GIAYKHAISINH VALUES  ( '95' , N'Lý Chánh An' , N'Nam' ,  '12/05/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Lý Văn Luận' , N'Kinh' , N'Viet Nam' , N'Lê Thanh Hoa' ,
		 N'kinh' , N'Viet Nam' , N'Lý VăN Luận' , N'Cha' , '10/10/1974' )
		 		 
INSERT dbo.GIAYKHAISINH VALUES  ( '96' , N'Nguyễn Thị Xuân Thy' , N'Nữ' ,  '10/06/1973' , N'Tiền Giang' , N'Kinh' , N'Viet Nam' , N'Tiền Giang' , N'Nguyễn Quốc Bảo' , N'Kinh' , N'Viet Nam' , N'Lê Ngọc Ánh' ,
		 N'kinh' , N'Viet Nam' , N'Nguyễn Quốc Bảo' , N'Cha' , '10/11/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '97' , N'Lý Tự Trọng' , N'Nam' ,  '05/07/2000' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Lý Chánh An' , N'Kinh' , N'Viet Nam' , N'Nguyễn Thị Xuân Thy' ,
		 N'kinh' , N'Viet Nam' , N'Lý Chánh An' , N'Cha' , '10/09/2001' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '98' , N'Cao Hoàng Minh' , N'Nam' ,  '12/05/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Cao Hoàng Hùng' , N'Kinh' , N'Viet Nam' , N'Trần Ngọc Yến' ,
		 N'kinh' , N'Viet Nam' , N'Cao Hoàng Hùng' , N'Cha' , '10/10/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '99' , N'Nguyễn Tuyết Nhung' , N'Nữ' ,  '12/05/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Lý Văn Luận' , N'Kinh' , N'Viet Nam' , N'Lê Thanh Hoa' ,
		 N'kinh' , N'Viet Nam' , N'Lý VăN Luận' , N'Cha' , '10/10/1974' )
		 	
INSERT dbo.GIAYKHAISINH VALUES  ( '100' , N'Cao Diệp Vấn' , N'Nam' ,  '20/08/1998' , N'Tiền Giang' , N'Kinh' , N'Viet Nam' , N'Tiền Giang' , N'Cao Hoàng Minh' , N'Kinh' , N'Viet Nam' , N'Nguyễn Tuyết Nhung' ,
		 N'kinh' , N'Viet Nam' , N'Cao Hoàng Minh' , N'Cha' , '09/11/1999' )
		 	
INSERT dbo.GIAYKHAISINH VALUES  ( '101' , N'Ngô Đoàn Diện' , N'Nam' ,  '12/03/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Ngô Quan Vũ' , N'Kinh' , N'Viet Nam' , N'Từ Ngọc Thủy' ,
		 N'kinh' , N'Viet Nam' , N'Ngô Quan Vũ' , N'Cha' , '09/09/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '102' , N'Trần Thị Anh Thư' , N'Nữ' ,  '10/06/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Lý Văn Luận' , N'Kinh' , N'Viet Nam' , N'Lê Thanh Hoa' ,
		 N'kinh' , N'Viet Nam' , N'Lý VăN Luận' , N'Cha' , '10/10/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '103' , N'Tạ Quang Thắng' , N'Nam' ,  '12/04/1973' , N'Từ Vũ' , N'Kinh' , N'Viet Nam' , N'TP.HCM' , N'Tạ Quang Bửu' , N'Kinh' , N'Viet Nam' , N'Trần Yến Thoa' ,
		 N'kinh' , N'Viet Nam' , N'Tạ Quang Bửu' , N'Cha' , '10/10/1974' )
		 
INSERT dbo.GIAYKHAISINH VALUES  ( '104' , N'Châu Hải My' , N'Nữ' ,  '10/01/1973' , N'Đồng Tháp' , N'Kinh' , N'Viet Nam' , N'Đồng Tháp' , N'Châu Vinh Quang' , N'Kinh' , N'Viet Nam' , N'Trần Ngọc Tâm' ,
		 N'kinh' , N'Viet Nam' , N'Châu Vinh Quang' , N'Cha' , '10/01/1974' )
GO

			-- ======================================================================================================================================

-- insert bảng THANNHAN
INSERT dbo.NHANTHAN VALUES  (  '01',N'Chủ Hộ' , N'Trần Văn Đạt', N''   , '12/05/1964', N'Từ Dũ' , N'Nam' , N'Long An' , N'Kinh' , N'' ,'022648020', '' , N'' , '15/03/1989' , N'','01')
INSERT dbo.NHANTHAN VALUES  (  '01',N'Vợ' , N'Phan Tú Cầm' , N''   , '12/06/1965',  N'Từ Dũ' , N'Nữ' , N'Cà Mau' , N'Kinh' , N'' , '022648022' ,'', N'' , '15/03/1991' , N'' ,'02' )
INSERT dbo.NHANTHAN VALUES  (  '02',N'Chủ Hộ',N'Trần Đức Bo', N''  ,'21/07/1982',N'Từ Dũ',N'Nam',N'Long An',N'Kinh',N'','024462040','',N'','12/04/1990',N'','03')
INSERT dbo.NHANTHAN VALUES  (  '02',N'Vợ',N'Trần Thị Thanh Tâm', N''  ,'21/01/1980',N'Từ Dũ',N'Nữ',N'Bến Tre',N'Kinh',N'','024462042','',N'','12/04/1992',N'','04')
INSERT dbo.NHANTHAN VALUES  (  '02',N'Con',N'Trần Ngọc Long', N''  ,'21/05/2000',N'Từ Dũ',N'Nam',N'Long An',N'Kinh',N'','024462044','',N'','21/05/2000',N'','05')
INSERT dbo.NHANTHAN VALUES  (  '03',N'Chủ Hộ',N'Trương Phi', N''  ,'12/09/1977',N'Từ Dũ',N'Nam',N'TP HCM',N'Kinh',N'','024462046','',N'','12/04/1991',N'','06')
INSERT dbo.NHANTHAN VALUES  (  '03',N'Vợ',N'Nguyễn Thị Mai Anh', N''  ,'12/02/1980',N'Từ Dũ',N'Nữ',N'Quãng Ngãi',N'Kinh',N'','022248044','',N'','12/04/1993',N'','07')
INSERT dbo.NHANTHAN VALUES  (  '03',N'Con',N'Trương Tinh Thái', N''  ,'12/05/1999',N'Từ Dũ',N'Nữ',N'TP HCm',N'Kinh',N'','022248040','',N'','12/05/1999',N'','08')
INSERT dbo.NHANTHAN VALUES  (  '03',N'Con',N'Trương Tinh Thần', N''  ,'31/05/1999',N'Từ Dũ',N'Nam',N'TP HCM',N'Kinh',N'','022248042','',N'','31/05/1999',N'','09')
INSERT dbo.NHANTHAN VALUES  (  '04',N'Chủ Hộ',N'Phạm Văn Lăng', N''  ,'01/01/1964',N'Từ Dũ',N'Nam',N'Tây Ninh',N'Kinh',N'','026668002','',N'','12/04/1994',N'','10')
INSERT dbo.NHANTHAN VALUES  (  '04',N'Vợ',N'Nguyễn Thị Thu', N''  ,'18/01/1972',N'Từ Dũ',N'Nữ',N'Tây Ninh',N'Kinh',N'','026668004','',N'','12/04/1995',N'','11')
INSERT dbo.NHANTHAN VALUES  (  '04',N'Con',N'Phạm Hoàng Tuấn', N''  ,'31/05/2000',N'Từ Dũ',N'Nam',N'Tây Ninh',N'Kinh',N'','026660006','',N'','31/05/2000',N'','12')
INSERT dbo.NHANTHAN VALUES  (  '05',N'Chủ Hộ',N'Quang Vũ', N''  ,'23/01/1970',N'Từ Dũ',N'Nam',N'Cà Mau',N'Kinh',N'','028020622','',N'','23/01/1994',N'','13')
INSERT dbo.NHANTHAN VALUES  (  '05',N'Vợ',N'Nguyễn Thị Hằng Nga', N''  ,'02/03/1975',N'Từ Dũ',N'Nữ',N'Tiền Giang',N'Kinh',N'','028020624','',N'','23/01/1995',N'','14')
INSERT dbo.NHANTHAN VALUES  (  '05',N'Con',N'Quang Mãnh Hổ', N''  ,'15/05/2005',N'Từ Dũ',N'Nam',N'Cà Mau',N'Kinh',N'','028020626','',N'','15/05/2005',N'','15')
INSERT dbo.NHANTHAN VALUES  (  '06',N'Chủ Hộ',N'Nguyễn Thanh Minh', N''  ,'16/10/1960',N'Từ Dũ',N'Nam',N'Cần Thơ',N'Kinh',N'','026088682','',N'','11/04/1985',N'','16')
INSERT dbo.NHANTHAN VALUES  (  '06',N'Vợ',N'Trần Thị Ngọc', N''  ,'19/12/1962',N'Từ Dũ',N'Nữ',N'Trà Vinh',N'Kinh',N'','026088684','',N'','11/04/1986',N'','17')
INSERT dbo.NHANTHAN VALUES  (  '07',N'Chủ Hộ',N'Thái Vũ', N''  ,'18/08/1955',N'Từ Dũ',N'Nam',N'Sơn La',N'Kinh',N'','020046484','',N'','30/04/1980',N'','18')
INSERT dbo.NHANTHAN VALUES  (  '07',N'Vợ',N'Trần Bích Trâm', N''  ,'22/02/1952',N'Từ Dũ',N'Nữ',N'Long An',N'Kinh',N'','020046486','',N'','30/04/1982',N'','19')
INSERT dbo.NHANTHAN VALUES  (  '07',N'Con',N'Thái Văn Cơ', N''  ,'14/04/1984',N'Từ Dũ',N'Nữ',N'Sơn La ',N'Kinh',N'','020046488','',N'','14/04/1984',N'','20')
INSERT dbo.NHANTHAN VALUES  (  '08',N'Chủ Hộ',N'Phan Phương Nam ', N''  ,'09/12/1958',N'Từ Dũ',N'Nam',N'Thái Bình',N'Kinh',N'','020000002','',N'','09/12/1978',N'','21')
INSERT dbo.NHANTHAN VALUES  (  '08',N'Vợ',N'Nguyễn Thị Mỹ Trinh', N''  ,'05/01/1960',N'Từ Dũ',N'Nữ',N'Huế',N'Kinh',N'','020000044','',N'','05/01/1980',N'','22')
INSERT dbo.NHANTHAN VALUES  (  '08',N'Con',N'Phan Phương Đông ', N''  ,'03/03/1980',N'Từ Dũ',N'Nam',N'Thái Bình',N'Kinh',N'','024462046','',N'','03/03/1980',N'','23')
INSERT dbo.NHANTHAN VALUES  (  '09',N'Chủ Hộ',N'Nguyễn Bá Độ ', N''  ,'12/12/1960',N'Từ Dũ',N'Nam',N'Ninh Thuận',N'Kinh',N'','024060802','',N'','02/07/1982',N'','24')
INSERT dbo.NHANTHAN VALUES  (  '09',N'Vợ',N'Nguyễn Thị Diễm Trinh ', N''  ,'11/01/1964',N'Từ Dũ',N'Nữ',N'Nha Trang',N'Kinh',N'','024060804','',N'','11/01/1984',N'','25')
INSERT dbo.NHANTHAN VALUES  (  '10',N'Chủ Hộ',N'Phạm Nhật Vượng ', N''  ,'16/07/1965',N'Từ Dũ',N'Nam',N'Bình Phước',N'Kinh',N'','020406082','',N'','16/07/1987',N'','26')
INSERT dbo.NHANTHAN VALUES  (  '10',N'Vợ',N'Trần Thị Thắm ', N''  ,'28/11/1970',N'Từ Dũ',N'Nữ',N'Hà Nội',N'Kinh',N'','020406084','',N'','28/11/1990',N'','27')
INSERT dbo.NHANTHAN VALUES  (  '11',N'Chủ Hộ',N'Nguyễn Xuân Huy ', N''  ,'08/08/1963',N'Từ Dũ',N'Nam',N'Phú Quốc',N'Kinh',N'','024060062','',N'','08/08/1983',N'','28')
INSERT dbo.NHANTHAN VALUES  (  '11',N'Vợ',N'Lê Ngọc Mỹ Dung ', N''  ,'30/12/1968',N'Từ Dũ',N'Nữ',N'Thái Bình',N'Kinh',N'','024060064','',N'','30/12/1985',N'','29')
INSERT dbo.NHANTHAN VALUES  (  '12',N'Chủ Hộ',N'Lê Nhật Khoa ', N''  ,'19/09/1961',N'Từ Dũ',N'Nam',N'Bình Thuận',N'Kinh',N'','028060402','',N'','19/09/1981',N'','30')
INSERT dbo.NHANTHAN VALUES  (  '12',N'Vợ',N'Lê Thị Hạnh ', N''  ,'02/02/1963',N'Từ Dũ',N'Nữ',N'Long Xuyên',N'Kinh',N'','028060404','',N'','02/02/1983',N'','31')
INSERT dbo.NHANTHAN VALUES  (  '12',N'Con',N'Lê Nhật Hạ ', N''  ,'09/12/1985',N'Từ Dũ',N'Nữ',N'Bình Thuận',N'Kinh',N'','028060406','',N'','09/12/1985',N'','32')
INSERT dbo.NHANTHAN VALUES  (  '13',N'Chủ Hộ',N'Lưu Ban ', N''  ,'17/07/1956',N'Từ Dũ',N'Nam',N'Cao Bằng',N'Kinh',N'','028482862','',N'','17/07/1976',N'','33')
INSERT dbo.NHANTHAN VALUES  (  '13',N'Vợ',N'Nguyễn Thị Bích ', N''  ,'25/05/1959',N'Từ Dũ',N'Nữ',N'Sơn La',N'Kinh',N'','028482864','',N'','25/05/1978',N'','34')
INSERT dbo.NHANTHAN VALUES  (  '14',N'Chủ Hộ',N'Hoàng Công Trình ', N''  ,'01/01/1970',N'Từ Dũ',N'Nam',N'Hà Nội',N'Kinh',N'','020200222','',N'','01/01/1990',N'','35')
INSERT dbo.NHANTHAN VALUES  (  '14',N'Vợ',N'Hoàng Hà ', N''  ,'06/06/1974',N'Từ Dũ',N'Nữ',N'Hải Phòng',N'Kinh',N'','020200224','',N'','06/06/1992',N'','36')
INSERT dbo.NHANTHAN VALUES  (  '15',N'Chủ Hộ',N'Tào Tháo ', N''  ,'23/03/1975',N'Từ Dũ',N'Nam',N'Bình Dương',N'Kinh',N'','022864822','',N'','23/03/2000',N'','37')
INSERT dbo.NHANTHAN VALUES  (  '15',N'Vợ',N'Nguyễn Thị Xuân ', N''  ,'19/09/1978',N'Từ Dũ',N'Nữ',N'Cà Mau',N'Kinh',N'','022864824','',N'','19/09/2000',N'','38')
INSERT dbo.NHANTHAN VALUES  (  '16',N'Chủ Hộ',N'Viên Thiệu ', N''  ,'22/03/1972',N'Từ Dũ',N'Nam',N'Bến Tre',N'Kinh',N'','026688442','',N'','22/03/1992',N'','39')
INSERT dbo.NHANTHAN VALUES  (  '16',N'Vợ',N'Quách Thị Mai Vân ', N''  ,'21/01/1974',N'Từ Dũ',N'Nữ',N'Mỹ Tho',N'Kinh',N'','026688446','',N'','21/01/1994',N'','40')
INSERT dbo.NHANTHAN VALUES  (  '16',N'Con',N'Viên Thuật ', N''  ,'27/07/1994',N'Từ Dũ',N'Nam',N'Bến Tre',N'Kinh',N'','026688448','',N'','27/07/1994',N'','41')
INSERT dbo.NHANTHAN VALUES  (  '17',N'Chủ Hộ',N'Trương Minh Trí ', N''  ,'12/10/1966',N'Từ Dũ',N'Nam',N'Phú Yên',N'Kinh',N'','024884482','',N'','12/10/1996',N'','42')
INSERT dbo.NHANTHAN VALUES  (  '17',N'Vợ',N'Nguyễn Kiều Diễm Trinh ', N''  ,'03/03/1970',N'Từ Dũ',N'Nữ',N'Bến Tre',N'Kinh',N'','024884484','',N'','03/03/1998',N'','43')
INSERT dbo.NHANTHAN VALUES  (  '17',N'Con',N'Trương Minh Mẫn ', N''  ,'01/01/2000',N'Từ Dũ',N'Nam',N'Phú Yên',N'Kinh',N'','024884486','',N'','01/01/2000',N'','44')
INSERT dbo.NHANTHAN VALUES  (  '18',N'Chủ Hộ',N'Triệu Mãn Diên', N''  ,'18/01/1959',N'Từ Dũ',N'Nam',N'TP HCM',N'Kinh',N'','026862642','',N'','18/01/1989',N'','45')
INSERT dbo.NHANTHAN VALUES  (  '18',N'Vợ',N'Mục Ninh Tuyết ', N''  ,'22/07/1962',N'Từ Dũ',N'Nữ',N'Tây Ninh',N'Kinh',N'','026862644','',N'','22/07/1991',N'','46')
INSERT dbo.NHANTHAN VALUES  (  '18',N'Con',N'Triệu Tử Long ', N''  ,'19/09/1982',N'Từ Dũ',N'Nam',N'TP HCM',N'Kinh',N'','026862646','',N'','22/03/1994',N'','47')
INSERT dbo.NHANTHAN VALUES  (  '19',N'Chủ Hộ',N'Tôn Sách ', N''  ,'11/12/1964',N'Từ Dũ',N'Nam',N'Đồng Tháp',N'Kinh',N'','022882282','',N'','11/12/1994',N'','48')
INSERT dbo.NHANTHAN VALUES  (  '19',N'Vợ',N'Đại Kiều ', N''  ,'12/11/1968',N'Từ Dũ',N'Nữ',N'Hậu Giang',N'Kinh',N'','022882284','',N'','12/11/1996',N'','49')
INSERT dbo.NHANTHAN VALUES  (  '19',N'Con',N'Tôn Quyền ', N''  ,'22/11/1998',N'Từ Dũ',N'Nam',N'Đồng Tháp',N'Kinh',N'','022882286','',N'','22/11/1998',N'','50')
INSERT dbo.NHANTHAN VALUES  (  '20',N'Chủ Hộ',N'Nguyễn Hà Đông ', N''  ,'21/03/1950',N'Từ Dũ',N'Nam',N'Tiền Giang',N'Kinh',N'','028428424','',N'','21/03/1987',N'','51')
INSERT dbo.NHANTHAN VALUES  (  '20',N'Vợ',N'Trần Thị Mơ ', N''  ,'03/03/1952',N'Từ Dũ',N'Nữ',N'Phú Quốc',N'Kinh',N'','028428422','',N'','03/03/1982',N'','52')
INSERT dbo.NHANTHAN VALUES  (  '20',N'Con',N'Nguyễn Hà Tĩnh ', N''  ,'21/03/1982',N'Từ Dũ',N'Nam',N'Tiền Giang',N'Kinh',N'','028428426','',N'','21/03/1982',N'','53')
INSERT dbo.NHANTHAN VALUES  (  '20',N'Con',N'Nguyễn Hà Nam ', N''  ,'21/03/1982',N'Từ Dũ',N'Nam',N'Tiền Giang',N'Kinh',N'','028428420','',N'','21/03/1982',N'','54')
INSERT dbo.NHANTHAN VALUES  (  '21',  N'Chủ Hộ' , N'Trần Văn Lâm'    ,       N'' , '11/08/1964' , N'Từ Vũ' , N'Nam' , N'Long An'   , N'Kinh' , N'' ,  '021357911','' , N'' , '15/03/1989' , N'' ,'55' )
INSERT dbo.NHANTHAN VALUES  (  '21',  N'Vợ'     , N'Phan Tú Uyên'    ,       N'' , '10/07/1965' , N'Từ Vũ' , N'Nữ'  , N'AN Giang'  , N'Kinh' , N'' ,  '021357913','' , N'' , '15/03/1991' , N''  ,'56')
INSERT dbo.NHANTHAN VALUES  (  '22',  N'Chủ Hộ' , N'Đinh Quang Vinh' ,       N'' , '12/05/1973' , N'Từ Vũ' , N'Nam' , N'Long An'   , N'Kinh' , N'' ,  '021357915','' , N'' , '15/03/2002' , N'' ,'57' )
INSERT dbo.NHANTHAN VALUES  (  '22',  N'Vợ'     , N'Lý Nhã Kỳ'       ,       N'' , '10/06/1973' , N'Từ Vũ' , N'Nữ'  , N'Tiền Giang', N'Kinh' , N'' ,  '021357917','' , N'' , '15/03/2003' , N'' ,'58' )
INSERT dbo.NHANTHAN VALUES  (  '22',  N'Con'    , N'Lý Tú Cầm'       ,       N'' , '10/06/1999' , N'Từ Vũ' , N'Nữ'  , N'Long An'   , N'Kinh' , N'' ,  '021357919','' , N'' , '15/03/2003' , N'' ,'59' )
INSERT dbo.NHANTHAN VALUES  (  '23',  N'Chủ Hộ' , N'Đoàn Hoáng Lộc'  ,       N'' , '12/05/1989' , N'Từ Vũ' , N'Nam' , N'Long An'   , N'Kinh' , N'' ,  '021357931','' , N'' , '20/03/2018' , N'' ,'60' )
INSERT dbo.NHANTHAN VALUES  (  '23',  N'Vợ'     , N'Bùi Thị Tố Lan'  ,       N'' , '10/06/1987' , N'Từ Vũ' , N'Nữ'  , N'Tiền Giang', N'Kinh' , N'' ,  '021357933','' , N'' , '17/03/2019' , N'' ,'61')
INSERT dbo.NHANTHAN VALUES  (  '23',  N'Con'    , N'Đoàn Hoàng Tuấn' ,       N'' , '10/06/1973' , N'Từ Vũ' , N'Nam' , N'Long An'   , N'Kinh' , N'' ,  '021357935','' , N'' , '15/03/2020' , N'' ,'62')
INSERT dbo.NHANTHAN VALUES  (  '24',  N'Chủ Hộ' , N'Nguyễn Linh An'  ,       N'' , '12/05/1973' , N'Từ Vũ' , N'Nam' , N'Cần Thơ'   , N'Kinh' , N'' ,  '021357937','' , N'' , '20/03/2019' , N'' ,'63' )
INSERT dbo.NHANTHAN VALUES  (  '24',  N'Vợ'     , N'Bùi Thị Xuân'    ,       N'' , '10/08/1973' , N'Từ Vũ' , N'Nữ'  , N'Tiền Giang', N'Kinh' , N'' ,  '021357939','' , N'' , '17/03/2020' , N'' ,'64' )
INSERT dbo.NHANTHAN VALUES  (  '25',  N'Chủ Hộ' , N'Trần Ngọc Hậu'   ,       N'' , '20/05/1973' , N'Từ Vũ' , N'Nam' , N'Bến Tre'   , N'Kinh' , N'' ,  '021357951','' , N'' , '20/03/2000' , N'' ,'65' )
INSERT dbo.NHANTHAN VALUES  (  '25',  N'Vợ'     , N'Nguyễn Thị Ngân' ,       N'' , '12/06/1973' , N'Từ Vũ' , N'Nữ'  , N'Cần Thơ'   , N'Kinh' , N'' ,  '021357953','' , N'' , '17/03/2001' , N'' ,'66' )
INSERT dbo.NHANTHAN VALUES  (  '26',  N'Chủ Hộ' , N'Long Tường Khanh',       N'' , '12/05/1989' , N'Từ Vũ' , N'Nam' , N'Long An'   , N'Kinh' , N'' ,  '021357955','' , N'' , '20/03/2018' , N'' ,'67' )
INSERT dbo.NHANTHAN VALUES  (  '26',  N'Vợ'     , N'Nguyễn Kiều Tiên',       N'' , '10/06/1989' , N'Từ Vũ' , N'Nữ' , N'Tiền Giang' , N'Kinh' , N'' ,  '021357957','' , N'' , '17/03/2019' , N'' ,'68' )
INSERT dbo.NHANTHAN VALUES  (  '27',  N'Chủ Hộ' , N'Lý Minh Dương'   ,       N'' , '12/05/1973' , N'Long An', N'Nam' , N'Long An' , N'Kinh' , N''  ,  '021357959','' , N'' , '20/05/2000' , N'' ,'69' )
INSERT dbo.NHANTHAN VALUES  (  '27',  N'Vợ'     , N'Xương Nguyệt Anh',       N'' , '10/06/1973' , N'Từ Vũ' , N'Nữ' , N'Tiền Giang' , N'Kinh' , N'' ,  '021357971','' , N'' , '30/05/2001' , N''  ,'70')
INSERT dbo.NHANTHAN VALUES  (  '28',  N'Chủ Hộ' , N'Nguyễn Văn Dương',       N'' , '15/05/1963' , N'Từ Vũ' , N'Nam' , N'Quảng Nam' , N'Kinh' , N'' ,  '021357973','' , N'' , '04/12/1980' , N'' ,'71' )
INSERT dbo.NHANTHAN VALUES  (  '28',  N'Vợ'     , N'Nguyễn Thị Xuân Hoài'  , N'' , '10/06/1963' , N'Từ Vũ' , N'Nữ' , N'Bạc Liêu' , N'Kinh' , N''   ,  '021357975','' , N'' , '01/12/1981' , N'' ,'72' )
INSERT dbo.NHANTHAN VALUES  (  '29',  N'Chủ Hộ' , N'Lê Huỳnh Nhựt Tân',      N'' , '21/12/1973' , N'Từ Vũ' , N'Nam' , N'Tây Nguyên' , N'Kinh' , N'',  '021357977','' , N'' , '20/03/2005' , N'','73')
INSERT dbo.NHANTHAN VALUES  (  '29',  N'Vợ'     , N'Ngô Minh Thư'    ,       N'' , '10/06/1987' , N'Từ Vũ' , N'Nữ' , N'Tây Nguyên' , N'Kinh' , N'' ,  '021357979','' , N'' , '17/03/2006' , N'' ,'74' )
INSERT dbo.NHANTHAN VALUES  (  '30',  N'Chủ Hộ' , N'Trần Quang Khải' ,       N'' , '12/09/1989' , N'Từ Vũ' , N'Nam' , N'Tiền Giang' , N'Kinh' , N'',  '021357991','' , N'' , '20/01/2018' , N'' ,'75' )
INSERT dbo.NHANTHAN VALUES  (  '30',  N'Vợ'     , N'Nguyển Thị Tuyết Như'  , N'' , '09/08/1989' , N'Từ Vũ' , N'Nữ' , N'Tiền Giang' , N'Kinh' , N'' ,  '021357993','' , N'' , '11/01/2019' , N'' ,'76' )
INSERT dbo.NHANTHAN VALUES  (  '31',  N'Chủ Hộ' , N'Phạm Hoàng Tuấn' ,       N'' , '12/05/1989' , N'Từ Vũ' , N'Nam' , N'An Giang' , N'Kinh' , N''  ,  '021357997','' , N'' , '20/03/2018' , N'' ,'77' )
INSERT dbo.NHANTHAN VALUES  (  '31',  N'Vợ'     , N'Lý Thu Hoài'     ,       N'' , '10/06/1987' , N'Từ Vũ' , N'Nữ' , N'Hậu Giang' , N'Kinh' , N''  ,  '021357999','' , N'' , '17/03/2019' , N'' ,'78' )
INSERT dbo.NHANTHAN VALUES  (  '32',  N'Chủ Hộ' , N'Mạc Đăng Khoa'   ,       N'' , '12/05/1978' , N'Từ Vũ' , N'Nam' , N'Cà Mau' , N'Kinh' , N''    ,  '021359713','' , N'' , '20/03/2003' , N'' ,'79' )
INSERT dbo.NHANTHAN VALUES  (  '32',  N'Vợ'     , N'Hoa Mộc Lan'     ,       N'' , '10/06/1978' , N'Cà Mau' , N'Nữ' , N'Cà Mau' , N'Kinh' , N''    ,  '021359733','' , N'' , '17/03/2004' , N'' ,'80' )
INSERT dbo.NHANTHAN VALUES  (  '33',  N'Chủ Hộ' , N'Nguyễn Manh Cường' ,     N'' , '12/05/1977' , N'Gia Lai' , N'Nam' , N'Gia Lai' , N'Kinh' , N'' ,  '021359737','' , N'' , '20/03/2001' , N'' ,'81' )
INSERT dbo.NHANTHAN VALUES  (  '33',  N'Vợ'     , N'Phạm Thị Thảo'   ,       N'' , '11/09/1987' , N'Bến Tre' , N'Nữ' , N'Bến Tre' , N'Kinh' , N''  ,  '021359735','' , N'' , '17/03/2002' , N'' ,'82' )
INSERT dbo.NHANTHAN VALUES  (  '34',  N'Chủ Hộ' , N'Phạm Trung Tấn' ,        N'' , '12/05/1983' , N'Từ Vũ' , N'Nam' , N'TP.HCM' , N'Kinh' , N''    ,  '021359739','' , N'' , '20/04/2005' , N'' ,'83' )
INSERT dbo.NHANTHAN VALUES  (  '34',  N'Vợ'     , N'Bùi Thị Tuyến Mẫn'  ,    N'' , '10/06/1983' , N'Từ Vũ' , N'Nữ' , N'Tiền Giang' , N'Kinh' , N'' ,  '021359751','' , N'' , '17/04/2005' , N'' ,'84' )
INSERT dbo.NHANTHAN VALUES  (  '34',  N'Con'    , N'Phạm Trung Thành',       N'' , '10/06/2012' , N'Từ Vũ' , N'Nữ' , N'TPHCM' , N'Kinh' , N''      ,  '021359753','' , N'' , '15/03/2005' , N''  ,'85')
INSERT dbo.NHANTHAN VALUES  (  '35',  N'Chủ Hộ' , N'Nguyễn Duy An'   ,       N'' , '12/02/1973' , N'Từ Vũ' , N'Nam' , N'TP.HCM' , N'Kinh' , N''    ,  '021359755','' , N'' , '20/04/2001' , N''  ,'86')
INSERT dbo.NHANTHAN VALUES  (  '35',  N'Vợ'     , N'Trần Thu Thùy'   ,       N'' , '07/01/1973' , N'Nghệ An' , N'Nữ' , N'Nghệ An' , N'Kinh' , N''  ,  '021359757','' , N'' , '17/04/2001' , N''  ,'87')
INSERT dbo.NHANTHAN VALUES  (  '35',  N'Con'    , N'Nguyễn Thị Như Ý' ,      N'' , '07/07/2000' , N'Từ Vũ' , N'Nữ' , N'TPHCM' , N'Kinh' , N''      ,  '021359771','' , N'' , '15/04/2001' , N''  ,'88')
INSERT dbo.NHANTHAN VALUES  (  '36',  N'Chủ Hộ' , N'Trần Thanh Hiền  ' ,     N'' , '12/05/1973' , N'Từ Vũ' , N'Nam' , N'TP.HCM' , N'Kinh' , N''    ,  '021359773','' , N'' , '20/04/2005' , N''  ,'89')
INSERT dbo.NHANTHAN VALUES  (  '36',  N'Vợ'     , N'Vĩnh Khiêm Thuyên' ,     N'' , '10/06/1973' , N'Tiền Giang',N'Nữ',N'Tiền Giang',N'Kinh', N''   ,  '021359777','' , N'' , '17/04/2006' , N''  ,'90')
INSERT dbo.NHANTHAN VALUES  (  '36',  N'Con'    , N'Trần Ngọc An'      ,     N'' , '06/04/2000' , N'Từ Vũ' , N'Nam' , N'TPHCM' , N'Kinh' , N''     ,  '021359779','' , N'' , '15/03/2006' , N''  ,'91')
INSERT dbo.NHANTHAN VALUES  (  '37',  N'Chủ Hộ' , N'Lê Hoàng Khôi'   ,       N'' , '12/05/1973' , N'Từ Vũ' , N'Nam' , N'TP.HCM' , N'Kinh' , N''    ,  '021359711','' , N'' , '20/04/2006' , N''  ,'92')
INSERT dbo.NHANTHAN VALUES  (  '37',  N'Vợ'     , N'Trần Thanh Thúy' ,       N'' , '11/04/1973' , N'Tiền Giang' , N'Nữ' , N'Tiền Giang' , N'Kinh'  , N'' , '021355711','' , N'' , '17/04/2005' , N'','93'  )
INSERT dbo.NHANTHAN VALUES  (  '38',  N'Chủ Hộ' , N'Lý Chánh An'     ,       N'' , '12/05/1973' , N'Từ Vũ' , N'Nam' , N'TP.HCM' , N'Kinh' , N''    ,  '021355717','' , N'' , '20/04/2005' , N'','95')
INSERT dbo.NHANTHAN VALUES  (  '38',  N'Vợ'     , N'Nguyễn Thị Xuân Thy' ,   N'' , '10/06/1973' , N'Tiền Giang' , N'Nữ' , N'Tiền Giang' , N'Kinh'  , N'' , '021355719' ,'' , N'' , '17/04/2005' , N'','96'  )
INSERT dbo.NHANTHAN VALUES  (  '38',  N'Con'    , N'Lý Tự Trọng'     ,       N'' , '05/07/2000' , N'Từ Vũ' , N'Nam' , N'TPHCM' , N'Kinh' , N''     ,  '' , '' , N'' , '15/03/2005' , N''  ,'97')
INSERT dbo.NHANTHAN VALUES  (  '39',  N'Chủ Hộ' , N'Cao Hoàng Minh'  ,       N'' , '12/05/1973' , N'Từ Vũ' , N'Nam' , N'TP.HCM' , N'Kinh' , N''    ,  '021355737','' , N'' , '20/04/2005' , N'','98')
INSERT dbo.NHANTHAN VALUES  (  '39',  N'Vợ'     , N'Nguyễn Tuyết Nhung' ,    N'' , '10/06/1973' , N'Đồng Tháp' , N'Nữ' , N'Đồng Tháp' , N'Kinh' , N'','021355739', '' , N'' , '17/04/2005' , N'' ,'99' )
INSERT dbo.NHANTHAN VALUES  (  '39',  N'Con'    , N'Cao Diệp Vấn'    ,       N'' , '20/08/1998' , N'Tiền Giang' , N'Nam' , N'Tiền Giang' , N'Kinh' , N'' , '','' , N'' , '30/04/2005' , N'','100'  )
INSERT dbo.NHANTHAN VALUES  (  '40',  N'Chủ Hộ' , N'Ngô Đoàn Diện'  ,        N'' , '12/03/1973' , N'Từ Vũ' , N'Nam' , N'TP.HCM' , N'Kinh' , N''    ,  '021355755', '' , N'' , '20/04/2005' , N'','101')
INSERT dbo.NHANTHAN VALUES  (  '40',  N'Vợ'     , N'Trần Thị Anh Thư' ,      N'' , '10/06/1973' , N'Đồng Tháp' , N'Nữ' , N'Đồng Tháp' , N'Kinh' , N'' ,  '021355757','' , N'' , '17/04/2005' , N'','102' )
INSERT dbo.NHANTHAN VALUES  (  '41',  N'Chủ Hộ' , N'Tạ Quang Thắng'  ,       N'' , '12/04/1973' , N'Từ Vũ' , N'Nam' , N'TP.HCM' , N'Kinh' , N''    ,  '021355759','' , N'' , '20/01/2006' , N'','103')
INSERT dbo.NHANTHAN VALUES  (  '41',  N'Vợ'     , N'Châu Hải My' ,           N'' , '10/01/1973' , N'Đồng Tháp' , N'Nữ' , N'Đồng Tháp' , N'Kinh' , N'' ,'021355771', '' , N'' , '17/04/2005' , N'' ,'104' )
GO



 -- ======================================================================================================================================

-- insert data bảng CMND 
INSERT dbo.CMND VALUES  ( '022648020' , N'Trần Văn Đạt', '12/05/1964' , N'Long An' ,N'Long An' , '12/05/1979         ' )
INSERT dbo.CMND VALUES  ( '022648022' , N'Phan Tú Cầm', '12/06/1965' , N'Cà Mau, '  ,N'Cà Mau' , '12/06/1980         ' )
INSERT dbo.CMND VALUES  ( '024462040' , N'Trần Đức Bo', '21/07/1982' , N'Long An'  ,N'Long An' , '21/07/1997          ' )
INSERT dbo.CMND VALUES  ( '024462042' , N'Trần Thị Thanh Tâm', '21/01/1980 ' , N'Sơn La'  ,N'Sơn La' , '18/08/1995' )
INSERT dbo.CMND VALUES  ( '024462044' , N'Trần Ngọc Long', '21/05/2000          ' , N'Long An'  ,N'Long An' , '21/05/2015         ' )
INSERT dbo.CMND VALUES  ( '022248046' , N'Trương Phi', '12/09/1977     ' , N'TP HCM'  ,N'TP HCM' , '12/09/1992          ' )
INSERT dbo.CMND VALUES  ( '022248044' , N'Nguyễn Thị Mai Anh', '12/02/1980' , N'Quãng Ngãi'  ,N'Quãng Ngãi' , '12/02/1995' )
INSERT dbo.CMND VALUES  ( '022248040' , N'Trương Tinh Thái', '12/05/1999' , N'TP HCM'  ,N'TP HCM' , '12/05/2014' )
INSERT dbo.CMND VALUES  ( '022248042' , N'Trương Tinh Thần', '31/05/1999' , N'TP HCM'  ,N'TP HCM' , '31/05/2014' )
INSERT dbo.CMND VALUES  ( '026668002' , N'Phạm Văn Lăng', '01/01/1964' , N'Tây Ninh'   ,N'Tây Ninh' , '01/01/1979' )
INSERT dbo.CMND VALUES  ( '026668004' , N'Nguyễn Thị Thu', '18/01/1972' , N'Tây Ninh'  ,N'Tây Ninh' , '18/01/1987' )
INSERT dbo.CMND VALUES  ( '026660006' , N'Phạm Hoàng Tuấn','31/05/2000' , N'Tây Ninh'  ,N'Tây Ninh' , '31/05/2015' )
INSERT dbo.CMND VALUES  ( '028020622' , N'Quang Vũ', '23/01/1970' , N'Cà Mau'  ,N'Cà Mau' , '23/01/1985' )
INSERT dbo.CMND VALUES  ( '028020624' , N'Nguyễn Thị Hằng Nga', '02/03/1975' , N'Tiền Giang'  ,N'Tiền Giang' , '02/03/1990' )
INSERT dbo.CMND VALUES  ( '028020626' , N'Quang Mãnh Hổ', '15/05/2005' , N'Cà Mau'  ,N'Cà Mau' , '15/05/2020' )
INSERT dbo.CMND VALUES  ( '026088682' , N'Nguyễn Thanh Minh', '16/10/1960' , N'Cần Thơ'  ,N'Cần Thơ' , '16/10/1975' )
INSERT dbo.CMND VALUES  ( '026088684' , N'Trần Thị Ngọc', '19/12/1962' , N'Trà Vinh'  ,N'Trà Vinh' , '19/12/1977' )
INSERT dbo.CMND VALUES  ( '020046484' , N'Thái Vũ', '18/08/1955' , N'Sơn La'  ,N'Sơn La' , '18/08/1970' )
INSERT dbo.CMND VALUES  ( '020046486' , N'Trần Bích Trâm', '22/02/1952' , N'Long An'  ,N'Long An' , '22/02/1967' )
INSERT dbo.CMND VALUES  ( '020046488' , N'Thái Văn Cơ', '14/04/1984' , N'Sơn La'  ,N'Sơn La' , '14/04/1999' )
INSERT dbo.CMND VALUES  ( '020000002' , N'Phan Phương Nam', '09/12/1958' , N'Thái Bình'  ,N'Thái Bình' , '09/12/1973' )
INSERT dbo.CMND VALUES  ( '020000044' , N'Nguyễn Thị Mỹ Trinh', '05/01/1960' , N'Huế'  ,N'Huế' , '05/01/1975' )
INSERT dbo.CMND VALUES  ( '024462046' , N'Phan Phương Đông', '03/03/1980' , N'Thái Bình'  ,N'Thái Bình', '03/03/1995' )
INSERT dbo.CMND VALUES  ( '024060802' , N'Nguyễn Bá Độ', '12/12/1960' , N'Ninh Thuận'  ,N'Ninh Thuận', '12/12/1975' )
INSERT dbo.CMND VALUES  ( '024060804' , N'Nguyễn Thị Diễm Trinh', '11/01/1964' , N'Nha Trang'  ,N'Nha Trang', '11/01/1979' )
INSERT dbo.CMND VALUES  ( '020406082' , N'Phạm Nhật Vượng ', '16/07/1965' , N'Bình Phước'  ,N'Bình Phước', '16/07/1980' )
INSERT dbo.CMND VALUES  ( '020406084' , N'Trần Thị Thắm', '28/11/1970' , N'Hà Nội'  ,N'Hà Nội', '28/11/1985' )
INSERT dbo.CMND VALUES  ( '024060062' , N'Nguyễn Xuân Huy ', '08/08/1963' , N'Phú Quốc'  ,N'Phú Quốc', '08/08/1978' )
INSERT dbo.CMND VALUES  ( '024060064' , N'Lê Ngọc Mỹ Dung', '30/12/1968' , N'Thái Bình'  ,N'Thái Bình', '30/12/1983' )
INSERT dbo.CMND VALUES  ( '028060402' , N'Lê Nhật Khoa', '19/09/1961' , N'Bình Thuận'  ,N'Bình Thuận', '19/09/1976' )
INSERT dbo.CMND VALUES  ( '028060404' , N'Lê Thị Hạnh', '02/02/1963' , N'Long Xuyên'  ,N'Long Xuyên', '02/02/1978' )
INSERT dbo.CMND VALUES  ( '028060406' , N'Lê Nhật Hạ', '09/12/1985' , N'Bình Thuận'  ,N'Bình Thuận', '09/12/1985' )
INSERT dbo.CMND VALUES  ( '028482862' , N'Lưu Ban', '17/07/1956' , N'Cao Bằng'  ,N'Cao Bằng', '17/07/1971' )
INSERT dbo.CMND VALUES  ( '028482864' , N'Nguyễn Thị Bích', '25/05/1959' , N'Sơn La'  ,N'Sơn La', '25/05/1974' )
INSERT dbo.CMND VALUES  ( '020200222' , N'Hoàng Công Trình', '01/01/1970' , N'Hà Nội'  ,N'Hà Nội', '01/01/1985' )
INSERT dbo.CMND VALUES  ( '020200224' , N'Hoàng Hà', '06/06/1974' , N'Hải Phòng'  ,N'Hải Phòng', '06/06/1989' )
INSERT dbo.CMND VALUES  ( '022864822' , N'Tào Tháo', '23/03/1975' , N'Bình Dương'  ,N'Bình Dương', '23/03/1990' )
INSERT dbo.CMND VALUES  ( '022864824' , N'Nguyễn Thị Xuân', '19/09/1978' , N'Cà Mau'  ,N'Cà Mau', '19/09/1993' )
INSERT dbo.CMND VALUES  ( '026688442' , N'Viên Thiệu', '22/03/1972' , N'Bến Tre'  ,N'Bến Tre', '22/03/1987' )
INSERT dbo.CMND VALUES  ( '026688446' , N'Quách Thị Mai Vân', '21/01/1974' , N'Mỹ Tho'  ,N'Mỹ Tho', '21/01/1989' )
INSERT dbo.CMND VALUES  ( '026688448' , N'Viên Thuật', '27/07/1994' , N'Bến Tre'  ,N'Bến Tre', '27/07/2009' )
INSERT dbo.CMND VALUES  ( '024884482' , N'Trương Minh Trí', '12/10/1966' , N'Phú Yên'  ,N'Phú Yên', '12/10/1981' )
INSERT dbo.CMND VALUES  ( '024884484' , N'Nguyễn Kiều Diễm Trinh', '03/03/1970' , N'Bến Tre'  ,N'Bến Tre', '03/03/1985' )
INSERT dbo.CMND VALUES  ( '024884486' , N'Trương Minh Mẫn', '01/01/2000' , N'Phú Yên'  ,N'Phú Yên', '01/01/2015' )
INSERT dbo.CMND VALUES  ( '026862642' , N'Triệu Mãn Diên', '18/01/1959' , N'TP HCM'  ,N'TP HCM', '18/01/1974' )
INSERT dbo.CMND VALUES  ( '026862644' , N'Mục Ninh Tuyết', '22/07/1962' , N'Tây Ninh'  ,N'Tây Ninh', '22/07/1977' )
INSERT dbo.CMND VALUES  ( '026862646' , N'Triệu Tử Long', '19/09/1982' , N'TP HCM'  ,N'TP HCM', '19/09/1997' )
INSERT dbo.CMND VALUES  ( '022882282' , N'Tôn Sách', '11/12/1964' , N'Đồng Tháp'  ,N'Đồng Tháp', '11/12/1979' )
INSERT dbo.CMND VALUES  ( '022882284' , N'Đại Kiều', '12/11/1968' , N'Hậu Giang'  ,N'Hậu Giang', '12/11/1983' )
INSERT dbo.CMND VALUES  ( '022882286' , N'Tôn Quyền', '22/11/1998' , N'Đồng Tháp'  ,N'Đồng Tháp', '22/11/2013' )
INSERT dbo.CMND VALUES  ( '028428424' , N'Nguyễn Hà Đông', '21/03/1950' , N'Tiền Giang'  ,N'Tiền Giang', '21/03/1965' )
INSERT dbo.CMND VALUES  ( '028428422' , N'Trần Thị Mơ', '03/03/1952' , N'Phú Quốc'  ,N'Phú Quốc', '03/03/1967' )
INSERT dbo.CMND VALUES  ( '028428426' , N'Nguyễn Hà Tĩnh', '21/03/1982' , N'Tiền Giang'  ,N'Tiền Giang', '21/03/1997' )
INSERT dbo.CMND VALUES  ( '028428420' , N'Nguyễn Hà Nam ', '21/03/1982' , N'Tiền Giang'  ,N'Tiền Giang', '21/03/1997' )
INSERT dbo.CMND VALUES  ( '021357911' ,N'Trần Văn Lâm'    , '11/08/1964'   ,N'Long An ', N'Long An' , '11/08/1982' )
INSERT dbo.CMND VALUES  ( '021357913' ,N'Phan Tú Uyên'    , '10/07/1965'   ,N'An Giang', N'An Giang' , '15/04/1983' )
INSERT dbo.CMND VALUES  ( '021357915' ,N'Đinh Quang Vinh' , '12/05/1973'   ,N'Long An', N'Long An' , '10/02/1994' )
INSERT dbo.CMND VALUES  ( '021357917' ,N'Lý Nhã Kỳ'       , '10/06/1973'   ,N'Tiền Giang',N'Tiền Giang' , '16/01/1994' )
INSERT dbo.CMND VALUES  ( '021357919' ,N'Lý Tú Cầm'       , '10/06/1999'   ,N'Long An', N'Long An' , '01/08/2017' )
INSERT dbo.CMND VALUES  ( '021357931' ,N'Đoàn Hoáng Lộc'  , '12/05/1989'   ,N'Long An', N'Long An' , '11/03/2007' )
INSERT dbo.CMND VALUES  ( '021357933' ,N'Bùi Thị Tố Lan'  , '10/06/1987'   ,N'Tiền Giang',N'Tiền Giang' , '19/09/2006' )
INSERT dbo.CMND VALUES  ( '021357935' ,N'Đoàn Hoàng Tuấn' , '10/06/1973'   ,N'Long An', N'Long An', '03/05/1991' )
INSERT dbo.CMND VALUES  ( '021357937' ,N'Nguyễn Linh An'  , '12/05/1973'   ,N'Cần Thơ', N'Cần Thơ' , ' 11/04/1992' )
INSERT dbo.CMND VALUES  ( '021357939' ,N'Bùi Thị Xuân'    , '10/08/1973'   ,N'Tiền Giang',N'Tiền Giang' , '21/08/1991' )
INSERT dbo.CMND VALUES  ( '021357951' ,N'Trần Ngọc Hậu'   , '20/05/1973'   ,N'Bến Tre', N'Bến Tre', '11/08/1991' )
INSERT dbo.CMND VALUES  ( '021357953' ,N'Nguyễn Thị Ngân' , '12/06/1973'   ,N'Cần Thơ',N'Cần Thơ' , '11/07/1982' )
INSERT dbo.CMND VALUES  ( '021357955' ,N'Long Tường Khanh' , '12/05/1989'  ,N'Long An',N'Long An' , '25/06/2007' )
INSERT dbo.CMND VALUES  ( '021357957' ,N'Nguyễn Kiều Tiên' , '10/06/1989'  ,N'Tiền Giang',N'Tiền Giang' , '30/03/2007' )
INSERT dbo.CMND VALUES  ( '021357959' ,N'Lý Minh Dương'    , '12/05/1973'  ,N'Long An' , N'Long An' , '10/11/1991' )
INSERT dbo.CMND VALUES  ( '021357971' ,N'Xương Nguyệt Anh' , '10/06/1973'  ,N'Tiền Giang', N'Tiền Giang' , '12/04/1992' )
INSERT dbo.CMND VALUES  ( '021357973' ,N'Nguyễn Văn Dương' , '15/05/1963'  ,N'Quảng Nam', N'Quảng Nam' , '09/09/1982' )
INSERT dbo.CMND VALUES  ( '021357975' ,N'Nguyễn Thị Xuân Hoài','10/06/1963',N'Bạc Liêu',N'Bạc Liêu' , '20/08/1981' )
INSERT dbo.CMND VALUES  ( '021357977' ,N'Lê Huỳnh Nhựt Tân' , '21/12/1973' ,N'Tây Nguyên', N'Tây Nguyên' , '19/08/1991' )
INSERT dbo.CMND VALUES  ( '021357979' ,N'Ngô Minh Thư'     ,  '10/06/1987' ,N'Tây Nguyên',N'Tây Nguyên' , '22/03/2006' )
INSERT dbo.CMND VALUES  ( '021357991' ,N'Trần Quang Khải'  , '12/09/1989'  ,N'Tiền Giang', N'Tiền Giang' , '24/09/2007' )
INSERT dbo.CMND VALUES  ( '021357993' ,N'Nguyển Thị Tuyết Như','09/08/1989',N'Tiền Giang',N'Tiền Giang' , '25/06/2007' )
INSERT dbo.CMND VALUES  ( '021357997' ,N'Phạm Hoàng Tuấn'    , '12/05/1989',N'An Giang', N'An Giang' , '21/09/2007' )
INSERT dbo.CMND VALUES  ( '021357999' ,N'Lý Thu Hoài'      , '10/06/1987'  ,N'Hậu Giang', N'Hậu Giang' , '10/01/2006' )
INSERT dbo.CMND VALUES  ( '021359713' ,N'Mạc Đăng Khoa'    , '12/05/1978'  ,N'Cà Mau', N'Cà Mau', '14/04/1995' )
INSERT dbo.CMND VALUES  ( '021359733' ,N'Hoa Mộc Lan'      , '10/06/1978'  ,N'Cà Mau',N'Cà Mau' , '15/05/1995' )
INSERT dbo.CMND VALUES  ( '021359737' ,N'Nguyễn Manh Cường', '12/05/1977'  ,N'Gia Lai',N'Gia Lai' , '14/01/1996' )
INSERT dbo.CMND VALUES  ( '021359735' ,N'Phạm Thị Thảo'    , '11/09/1987'  ,N'Bến Tre',N'Bến Tre' , '19/04/2006' )
INSERT dbo.CMND VALUES  ( '021359739' ,N'Phạm Trung Tấn'   , '12/05/1983'  ,N'TP.HCM',N'TP.HCM' , '13/08/2002' )
INSERT dbo.CMND VALUES  ( '021359751' ,N'Bùi Thị Tuyến Mẫn' , '10/06/1983' ,N'Tiền Giang', N'Tiền Giang' , '16/04/2002' )
INSERT dbo.CMND VALUES  ( '021359753' ,N'Phạm Trung Thành' , '10/06/2012'  ,N'TPHCM', N'TPHCM' , '31/08/2030' )
INSERT dbo.CMND VALUES  ( '021359755' ,N'Nguyễn Duy An'    , '12/02/1973'  ,N'TPHCM', N'TPHCM' , '04/04/1991' )
INSERT dbo.CMND VALUES  ( '021359757' ,N'Trần Thu Thùy'    , '07/01/1973'  ,N'Nghệ An', N'Nghệ An' , '30/08/1991' )
INSERT dbo.CMND VALUES  ( '021359771' ,N'Nguyễn Thị Như Ý'   ,'07/07/2000' ,N'TPHCM',N'TPHCM' , '24/04/2018' )
INSERT dbo.CMND VALUES  ( '021359773' ,N'Trần Thanh Hiền  '   ,'12/05/1973',N'TPHCM', N'TPHCM' , '11/01/1991' )
INSERT dbo.CMND VALUES  ( '021359777' ,N'Vĩnh Khiêm Thuyên'  , '10/06/1973',N'Tiền Giang', N'Tiền Giang' , '15/05/2018' )
INSERT dbo.CMND VALUES  ( '021359779' ,N'Trần Ngọc An'      , '06/04/2000' ,N'TPHCM'     ,N'TPHCM'       , '07/11/2015' )
INSERT dbo.CMND VALUES  ( '021359711' ,N'Lê Hoàng Khôi'    , '12/05/1973'  ,N'TPHCM', N'TPHCM' , '19/06/1991' )
INSERT dbo.CMND VALUES  ( '021355711' ,N'Trần Thanh Thúy'  , '11/04/1973'  ,N'Tiền Giang',N'Tiền Giang' , '17/07/1991' )
INSERT dbo.CMND VALUES  ( '021355717' ,N'Lý Chánh An'    , '12/05/1973'    ,N'TPHCM', N'TPHCM' , '18/02/1991' )
INSERT dbo.CMND VALUES  ( '021355719' ,N'Nguyễn Thị Xuân Thy','10/06/1973' ,N'Tiền Giang', N'Tiền Giang' , '26/06/1991' )
--INSERT dbo.CMND VALUES  ( '021355733' ,N'Lý Tự Trọng','05/07/2000',N'TPHCM',N'TPHCM' , '11/08/2018' )
INSERT dbo.CMND VALUES  ( '021355737' ,N'Cao Hoàng Minh'   , '12/05/1973'  ,N'TPHCM', N'TPHCM' , '17/08/1991' )
INSERT dbo.CMND VALUES  ( '021355739' ,N'Nguyễn Tuyết Nhung' , '10/06/1973',N'Đồng Tháp',N'Đồng Tháp' , '19/09/1991' )
--INSERT dbo.CMND VALUES  ( '021355751' ,N'Cao Diệp Vấn'   , '20/08/1998'    ,N'Tiền Giang' ,N'Tiền Giang'  , '22/08/2016' )
INSERT dbo.CMND VALUES  ( '021355755' ,N'Ngô Đoàn Diện'  ,'12/03/1973'     ,N'TP.HCM' , N'TP.HCM'  , '09/08/1991' )
INSERT dbo.CMND VALUES  ( '021355757' ,N'Trần Thị Anh Thư'   ,'10/06/1973' ,N'Đồng Tháp', N'Đồng Tháp' , '11/07/1991' )
INSERT dbo.CMND VALUES  ( '021355759' ,N'Tạ Quang Thắng'   ,'12/04/1973'   ,N'TP.HCM' ,N'TP.HCM'  , '16/08/1991' )
INSERT dbo.CMND VALUES  ( '021355771' ,N'Châu Hải My'  ,'10/01/1973'       ,N'Đồng Tháp', N'Đồng Tháp' , '15/05/1991' )
GO

-- ================================================== CAU LENH SQL ==================================================

-- tạo PROC tổng số hộ
CREATE PROC PROC_TongSoHo AS
BEGIN
	SELECT COUNT(MaSHK) AS TongSoHo FROM dbo.SOHOKHAU
END
GO

-- tạo PROC tìm kiếm nhân thân
CREATE PROC PROC_FindNT @MaSHK CHAR(10) AS
BEGIN
	SELECT * FROM dbo.NHANTHAN WHERE MaSHK = @MaSHK
END
GO

-- tạo PROC lấy ds nhân thân
CREATE PROC PROC_DSNT AS
BEGIN
	SELECT * FROM dbo.NHANTHAN 
END
GO

-- tạo PROC tìm giấy khai sinh
CREATE PROC FindGKS @GKS CHAR(15)AS
BEGIN
	SELECT * FROM dbo.GIAYKHAISINH WHERE MaGKS = @GKS
END
GO

-- tạo PROC xem hộ khẩu
CREATE PROC XemHK @SHK CHAR(10)AS
BEGIN
	SELECT * FROM dbo.SOHOKHAU WHERE MaSHK = @SHK
END
GO

-- tạo PROC xem giấy khai sinh
CREATE PROC DSGKS AS
BEGIN
	SELECT * FROM dbo.GIAYKHAISINH 
END
GO

-- tạo PROC tổng GKS
CREATE PROC PROC_TongGKS AS
BEGIN
	SELECT COUNT(MaGKS) AS TongGKS FROM dbo.GIAYKHAISINH
END
GO

-- tạo PROC tổng nhân thân
CREATE PROC PROC_TongNT @TongNT CHAR(10) AS
BEGIN
	SELECT COUNT(*) AS TongNT FROM dbo.NHANTHAN WHERE MaSHK = @TongNT
END
GO

-- tạo PROC ds CMND
CREATE PROC DsCMND AS
BEGIN
	SELECT * FROM dbo.CMND
END
GO

-- tạo PROC tong CMND
CREATE PROC TongCMND AS
BEGIN
	SELECT COUNT(*) AS TongCMND FROM dbo.CMND 
END
GO


-- tạo PROC kiem tra KEY CMND
CREATE PROC KTKEYCMND @KT CHAR(15) AS
BEGIN
	SELECT CMND AS TongCMND FROM dbo.CMND WHERE CMND = @KT
END
GO

-- tạo PROC lay ds phieu tu
CREATE PROC DSPHIEUTU AS
BEGIN
	SELECT * FROM dbo.PHIEUTU
END
GO

-- tạo PROC find phieu tu
CREATE PROC FINDPHIEUTU @find CHAR(20) AS
BEGIN
	SELECT * FROM dbo.PHIEUTU WHERE MaPhieuTu = @find
END
GO

-- tạo PROC Tong phieu tu
CREATE PROC TongPhieuTu AS
BEGIN
	SELECT COUNT(*) AS Tong FROM dbo.PHIEUTU
END
GO

-- tạo PROC dsTDCH
CREATE PROC dsTDCH AS
BEGIN
	SELECT * FROM dbo.THAYDOICHUHO
END
GO

-- tạo PROC findTDCH
CREATE PROC FindTDCH @find CHAR(20) AS
BEGIN
	SELECT * FROM dbo.THAYDOICHUHO WHERE MaphieuTDCH = @find
END
GO


-- tạo PROC TongTDCH
CREATE PROC TongTDCH AS
BEGIN
	SELECT COUNT(*) AS Tong FROM dbo.THAYDOICHUHO
END
GO

-- tạo PROC dschuacoCMND
CREATE PROC DSCHUACOCMND AS
BEGIN
	SELECT * FROM dbo.NHANTHAN WHERE CMND = ''
END
GO

-- tạo PROC TongdschuacoCMND
CREATE PROC TongDSCHUACOCMND AS
BEGIN
	SELECT COUNT(*) AS Tong FROM dbo.NHANTHAN WHERE CMND = ''
END
GO

-- tạo PROC dsTTV
CREATE PROC DSTTV AS
BEGIN
	SELECT * FROM TAMTRUTAMVANG
END
GO

-- tạo PROC TongTTTV
CREATE PROC TongTTTV AS
BEGIN
	SELECT COUNT(*) AS Tong FROM TAMTRUTAMVANG
END
GO

-- tạo PROC CheckMaSHK
CREATE PROC CheckMaSHK @check CHAR(15) AS
BEGIN
	SELECT MaSHK FROM dbo.SOHOKHAU WHERE MaSHK = @check
END
GO

-- tạo PROC CheckMaSTTV
CREATE PROC CheckMaSTT @check CHAR(15) AS
BEGIN
	SELECT MaSTT FROM dbo.TAMTRUTAMVANG WHERE MaSTT = @check
END
GO 


-- tạo PROC xóa PHIEUTU
CREATE PROC DeletePHIEUTU (@delete CHAR(20)) AS
BEGIN
	DELETE dbo.PHIEUTU WHERE MaPhieuTu = @delete
END
GO

-- tạo PROC xóa TDCH
CREATE PROC DeleteTDCH (@delete CHAR(20)) AS
BEGIN
	DELETE dbo.THAYDOICHUHO WHERE MaphieuTDCH = @delete
END
GO

-- tạo PROC find TTTV
CREATE PROC findTTTV @find CHAR(15) AS
BEGIN
	SELECT * FROM dbo.TAMTRUTAMVANG WHERE MaSTT = @find
END
GO

-- tạo PROC findNT để thêm vào phần sau khi đăng ký SHK
CREATE PROC findNTsaukhidangkySHK 
( @hoten NVARCHAR(70),@namsinh CHAR(15) ) AS
BEGIN
	SELECT * FROM dbo.NHANTHAN WHERE HoTen = @hoten AND NamSinh = @namsinh
END
GO

-- tạo PROC delete TTTV
CREATE PROC deleteTTTV @delete CHAR(15) AS
BEGIN
	DELETE dbo.TAMTRUTAMVANG WHERE MaSTT = @delete
END
GO

-- tạo PROC lấy ds SHK
CREATE PROC DSSHK AS
BEGIN
	SELECT * FROM dbo.SOHOKHAU
END
GO

-- tạo PROC findSHK theo MaSHK
CREATE PROC findSHKtheoMaSHK @find CHAR(10) AS
BEGIN
	SELECT * FROM dbo.SOHOKHAU WHERE MaSHK = @find
END
GO

-- tạo PROC thong ke so ho khau
CREATE PROC PROC_thongke AS
BEGIN
	SELECT DiaChi,COUNT(*) AS thongke FROM dbo.SOHOKHAU GROUP BY DiaChi
END
GO
