create database QuanLyHangHoa
use QuanLyHangHoa

CREATE TABLE LoaiHang (
    MaLoaiHang INT PRIMARY KEY,
    TenLoaiHang NVARCHAR(30) NOT NULL UNIQUE
)

CREATE TABLE NhaSanXuat (
    MaNhaSanXuat INT PRIMARY KEY,
    TenNhaSanXuat NVARCHAR(30) NOT NULL UNIQUE
)

CREATE TABLE HangHoa (
    MaHangHoa INT PRIMARY KEY,
    TenHangHoa NVARCHAR(30) NOT NULL UNIQUE,
    SoLuong INT NOT NULL,
    MaLoaiHang INT NOT NULL REFERENCES LoaiHang(MaLoaiHang),
    MaNhaSanXuat INT NOT NULL REFERENCES NhaSanXuat(MaNhaSanXuat),
    CHECK (SoLuong>=0)
)


insert into LoaiHang values (01,'KemDanhRang')
insert into LoaiHang values (02,'BanChaiDanhRang')
insert into LoaiHang values (03,'NuocSucMieng')

insert into NhaSanXuat values (01,'Colgate')
insert into NhaSanXuat values (02,'Closeup')
insert into NhaSanXuat values (03,'Sensodyne')

insert into HangHoa values (01,'Ban Chai Colgate',15,02,01)
insert into HangHoa values (02,'Closeup Lua Bang',9,01,02)
insert into HangHoa values (03,'Nuoc Suc Mieng Sensodyne',20,03,03)

create view vHangHoa 
as select MaHangHoa,TenHangHoa,SoLuong,TenLoaiHang,TenNhaSanXuat
from HangHoa inner join LoaiHang on HangHoa.MaLoaiHang=LoaiHang.MaLoaiHang
inner join NhaSanXuat on NhaSanXuat.MaNhaSanXuat=HangHoa.MaNhaSanXuat




