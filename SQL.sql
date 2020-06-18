USE Final_Project 
GO 



CREATE TABLE Company
(	
	NameC NVARCHAR(50) NOT NULL,-- C= Company, Tên hãng
	IDC VARCHAR(50) PRIMARY KEY NOT NULL, -- Mã hãng
	AddressC NVARCHAR(50) NOT NULL, -- Địa chỉ hãng
	PhoneC NVARCHAR(50) NOT NULL--Số điện thoại hãng
)
GO

CREATE TABLE Category
(	
	NameCate NVARCHAR(50) NOT NULL,-- Cate=Category, Tên danh mục
	IDCate VARCHAR(50) PRIMARY KEY NOT NULL, -- mã danh mục
	DesCate NVARCHAR(50)--Description Category -- Mô tả
)
GO

CREATE TABLE Brand 
(	
	NameBr NVARCHAR(50)NOT NULL,-- Tên nhãn hiệu
	IDBr VARCHAR(50) PRIMARY KEY NOT NULL,-- Mã nhãn hiệu
	IDCate VARCHAR(50)NOT NULL,--Mã danh mục
	DesBr NVARCHAR(50) NOT NULL,--Chi tiết
	FOREIGN KEY (IDCate) REFERENCES dbo.CATEGORY(IDCate)
)
GO

CREATE TABLE Product
(	
	IDPro VARCHAR(50)PRIMARY KEY NOT NULL, -- Mã sản phẩm
	IDBr VARCHAR(50) NOT NULL,-- mã nhãn hiệu
	NamePro NVARCHAR(50)NOT NULL,--Tên sản phẩm
	PricePro FLOAT NOT NULL,--Giá sản phẩm
	PicturePro IMAGE NOT NULL,--Hình ảnh sản phẩm
	DiscountPro INT ,--Giảm giá
	Warranty INT NOT NULL,--Bảo hành
	Origin NVARCHAR(50) NOT NULL,--Xuất xứ
	FOREIGN KEY (IDBr) REFERENCES dbo.Brand(IDBr)
)
GO

CREATE TABLE Warehouse
(	
	IDWa VARCHAR(50) PRIMARY KEY NOT NULL, -- mã kho
	IDPro VARCHAR(50),
	AddressWa NVARCHAR(50) NOT NULL,--Địa chỉ kho
	Quantity INT NOT NULL--Số lượng
	FOREIGN KEY (IDPro) REFERENCES dbo.Product(IDPro)
)
GO

CREATE TABLE Employee
(
	IDEm VARCHAR(50) PRIMARY KEY NOT NULL,--Mã nhân viên
	FirstN NVARCHAR(50)NOT NULL,--Họ nhân viên
	LastN NVARCHAR(50)NOT NULL,--Tên nhân viên
	Birthday DATETIME NOT NULL,--Ngày sinh
	Gender VARCHAR(50)NOT NULL,--Giới tính
	Phone INT NOT NULL,--Số điện thoại
	AddressEm NVARCHAR(50)NOT NULL,--Địa chỉ
	PictureEm IMAGE NOT NULL,--Hình ảnh
)

CREATE TABLE Customer
(
	IDCus VARCHAR(50) PRIMARY KEY NOT NULL,--Mã khách hàng
	FirstN NVARCHAR(50)NOT NULL,--Họ khách
	LastN NVARCHAR(50)NOT NULL,--tên khách
	Birthday DATETIME NOT NULL,--Ngày sinh
	Gender VARCHAR(50)NOT NULL,--Giới tính
	Phone INT NOT NULL,--Số điện thoại
)

CREATE TABLE Account
(
	USERNAME VARCHAR(50) PRIMARY KEY NOT NULL,--Tên đăng nhập
	PASSWORD NVARCHAR(200) NOT NULL,-- mật khẩu
	Pos INT NOT NULL,--chức vụ
	IDEm VARCHAR(50) NOT NULL,--Mã nhân viên
	FOREIGN KEY (IDEm) REFERENCES dbo.Employee(IDEm)
)

CREATE TABLE Bill_In
(
	IDB_I VARCHAR(50) PRIMARY KEY NOT NULL,--Mã hoá đơn nhập kho
	IDC VARCHAR(50) NOT NULL,--Mã công ty
	IDEm VARCHAR(50) NOT NULL,--Mã nhân viên nhập kho
	DateIN DATETIME,--Ngày nhập kho
	Checkout INT--Tình trạng	
	FOREIGN KEY (IDEm) REFERENCES dbo.Employee(IDEm),
	FOREIGN KEY (IDC) REFERENCES dbo.Company(IDC)
)
CREATE TABLE Bill_Info_In
(
	ID VARCHAR(50) PRIMARY KEY NOT NULL,--Mã chi tiết hoá đơn nhập kho
	IDB_In VARCHAR(50) NOT NULL,--Mã hoá đơn nhập kho
	IDPro VARCHAR(50) NOT NULL,--Mã sản phẩm nhập
	CountIn DATETIME,--Số lượng nhập
	PriceIn	FLOAT--Giá mỗi sản phẩm nhập
	FOREIGN KEY (IDB_IN) REFERENCES dbo.Bill_In(IDB_I),
	FOREIGN KEY (IDPro) REFERENCES dbo.Product(IDPro),
)


CREATE TABLE Bill_Out
(
	IDB_O VARCHAR(50) PRIMARY KEY NOT NULL,--Mã hoá đơn bán
	IDCus VARCHAR(50) NOT NULL,--Mã khách hàng
	IDEm VARCHAR(50) NOT NULL,--Mã nhân viên bán
	DateOut DATETIME,--Ngày bán
	Discount INT,--Giảm giá
	Checkout INT,	-- Tình trạng hoá đơn bán
	PriceOut	FLOAT--Tổng tiền
	FOREIGN KEY (IDEm) REFERENCES dbo.Employee(IDEm),
	FOREIGN KEY (IDCus) REFERENCES dbo.Customer(IDCus)
)
CREATE TABLE Bill_Info_Out
(
	ID VARCHAR(50) PRIMARY KEY NOT NULL,--Mã chi tiết hoá đơn bán
	IDB_Out VARCHAR(50) NOT NULL,--Mã hoá đơn bán
	IDPro VARCHAR(50) NOT NULL,--Mã sản phẩm bán
	CountOut DATETIME,--Số lượng sản phẩm
	FOREIGN KEY (IDB_Out) REFERENCES dbo.Bill_Out(IDB_O),
	FOREIGN KEY (IDPro) REFERENCES dbo.Product(IDPro)
)
