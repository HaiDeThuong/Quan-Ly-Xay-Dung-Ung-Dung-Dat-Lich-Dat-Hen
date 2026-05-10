USE FatSheetBarber;
GO

DROP TABLE IF EXISTS Bookings;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS Services;
DROP TABLE IF EXISTS Role;

CREATE TABLE Role (
    RoleID INT PRIMARY KEY,
    RoleName NVARCHAR(50)
);
INSERT INTO Role VALUES (1, 'Admin'), (2, 'Customer'), (3, 'Barber');

CREATE TABLE Users (
    UserID INT IDENTITY PRIMARY KEY,
    FullName NVARCHAR(100),
    PhoneNumber VARCHAR(15) UNIQUE, 
    Password VARCHAR(50),
    RoleID INT FOREIGN KEY REFERENCES Role(RoleID)
);


INSERT INTO Users (FullName, PhoneNumber, Password, RoleID) VALUES 
(N'Hải', '0901', '123', 3),
(N'Quang', '0902', '123', 3),
(N'Phát', '0903', '123', 3),
(N'Duy', '0904', '123', 3),
(N'Kỳ Anh', '0905', '123', 3),
(N'Khánh Duy', '0906', '123', 3);


CREATE TABLE 
    ServiceID INT IDENTITY PRIMARY KEY,
    ServiceName NVARCHAR(100),
    Price DECIMAL(18,2)
);
INSERT INTO Services (ServiceName, Price) VALUES 
(N'Cắt tóc nam (Classic)', 50000),
(N'Combo Gội sấy + Massage', 80000),
(N'Uốn tóc Premlock', 350000),
(N'Nhuộm màu thời trang', 250000),
(N'Tẩy tóc', 150000),
(N'Cạo mặt + Ráy tai', 40000);


CREATE TABLE Bookings (
    BookingID INT IDENTITY PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),   
    BarberID INT FOREIGN KEY REFERENCES Users(UserID),  
    ServiceID INT FOREIGN KEY REFERENCES Services(ServiceID),
    BookingDate DATETIME,
    Status NVARCHAR(50) DEFAULT N'Pending'
);

--Kiểm Tra
SELECT * FROM Users WHERE RoleID = 3; 
SELECT * FROM Services;               
SELECT * FROM Bookings