CREATE DATABASE DuLieu;
GO

USE DuLieu;
GO

CREATE TABLE SinhVien(
    MaSinhVien NVARCHAR(10) PRIMARY KEY,
    TenSinhVien nText NOT NULL,
    DiemTrungBinh NVARCHAR(8) NOT NULL
);
GO

INSERT INTO SinhVien (MaSinhVien, TenSinhVien, DiemTrungBinh)
VALUES
('SV01', N'Nguyễn Văn A', '8.5'),
('SV02', N'Trần Thị B', '7.0'),
('SV03', N'Lê Văn C', '9.0'),
('SV04', N'Phạm Thị D', '6.5'),
('SV05', N'Hoàng Văn E', '8.0');
GO