use master
go
	if (exists(select * from sys.sysdatabases where name='quanlykhoahoc_test'))
		drop database quanlykhoahoc_test

go
create database quanlykhoahoc_test

go
use quanlykhoahoc_test
go
create table GIANGVIEN(
	id_GV varchar(20) primary key,
	ten_GV nvarchar(30) not null,
	ngaysinh_GV date not null,
	sodt_GV varchar(10) not null unique,
	diachi_GV nvarchar(100) not null,
	ghichu_GV ntext,
	ngaytao datetime,
	ngaysua datetime 
)
go
create table PHONGHOC(
	id_PH varchar(20) primary key,
	ten_PH nvarchar(30) not null unique,
	ngaytao datetime,
	ngaysua datetime,
	ghichu_PH ntext
)
go
alter table PHONGHOC add  succhua_PH int not null
go
create table KHOAHOC(
	id_KH varchar(20) primary key,
	ten_KH nvarchar(50) not null unique,
	gia_KH int not null,
	ngaytao datetime,
	ngaysua datetime,
	ghichu_KH ntext
)
go
create table LOPHOC(
	id_LH varchar(20) primary key,
	id_KH varchar(20) not null,
	ngaybatdau date not null,
	ngayketthuc date not null,
	id_GV varchar(20) not null,
	ten_LH nvarchar(30) not null,
	id_PH varchar(20) not null,
	ghichu_LH ntext,
	siso_LH int default 0 not null,
	constraint LH_GV foreign key(id_GV) references GIANGVIEN(id_GV),
	constraint LH_KH foreign key(id_KH) references KHOAHOC(id_KH),
	constraint LH_PH foreign key(id_PH) references PHONGHOC(id_PH)
)

go
create table HOCVIEN(
	id_HV varchar(20) primary key,
	ten_HV nvarchar(30) not null,
	sodt_HV varchar(10) not null unique,
	ngaysinh_HV date not null,
	diachi_HV nvarchar(100) not null,
	ngaytao datetime,
	ngaysua datetime
)
go
create table HOCVIEN_LOPHOC(
	id_HVLH int identity primary key,
	id_HV varchar(20) not null,
	id_LH varchar(20) not null,
	diem_1 float not null default -1,
	diem_2 float not null default -1,
	diem_3 float not null default -1,
	diem_4 float not null default -1,
	ghichu_HVLH ntext null,
	constraint HVLH_HV foreign key(id_HV) references HOCVIEN(id_HV),
	constraint HVLH_LH foreign key(id_LH) references LOPHOC(id_LH),	
)

go
-------------------------------
create table ACCOUNT(
	username varchar(20) primary key not null,
	password varchar(50) not null,
	level int not null,
	fullname nvarchar(50) null,
	phone nvarchar(15) null
)
go
create table DiemDanh(
	id int primary key identity,
	ngayDiemDanh date not null,
	id_HVLH int
)
go
alter table DiemDanh add foreign key(id_HVLH) references HOCVIEN_LOPHOC(id_HVLH)
go

-- pass word = 123
insert into ACCOUNT values('admin', '202cb962ac59075b964b07152d234b70', 0, null, null)
-----------------------------
go
create table LICHHOC(
	id_LIH int identity primary key,
	id_LH varchar(20) not null,
	thu int not null,
	tiet varchar(30) not null,
	ghichu_LIH ntext,
	constraint FK_LIH_LH foreign key(id_LH) references LOPHOC(id_LH)
)

---	Them bang hoc phi

go
create table HOCPHI(
	id_HP int identity primary key,
	hocphi float,
	nop_lan_1 float,
	ngay_nop_lan_1 date,
	nop_lan_2 float,
	ngay_nop_lan_2 date,
	hoanthanh int,
	id_HVLH int,
	foreign key(id_HVLH) references HOCVIEN_LOPHOC(id_HVLH),
	
)
	
--- VER 1.8  -- GIANG

	--- Thêm trigger xoá học viên khỏi HOCVIEN_LOPHOC thì giảm sĩ số ở LOPHOC
go

create trigger trg_deleteHV_LH_giamSiSo
on HOCVIEN_LOPHOC
for delete
as
	begin
		declare @id_LH varchar(20)
		set @id_LH = (select id_LH from deleted)
		update LOPHOC set siso_LH = (select COUNT(*) from HOCVIEN_LOPHOC where id_LH = @id_LH) where id_LH = @id_LH
	end 
go
--- VER 2.0 -- GIANG
	-- Lấy ra lịch sử dụng theo mã phòng trong 1 khoảng thời gian
create function fn_GetLichHoc(@id_PH int, @ngaybatdau date, @ngayketthuc date)
returns @tbresult table (
	id_PH varchar(20),
	ten_PH nvarchar(30),
	id_LH varchar(20),
	ten_LH nvarchar(30),
	thu int,
	tiet varchar(30),
	ngaybatdau date,
	ngayketthuc date
)
as
begin
	insert into @tbresult select PhongHoc.id_PH, ten_PH, LOPHOC.id_LH, ten_LH, thu, tiet, ngaybatdau, ngayketthuc
	from PHONGHOC inner join LOPHOC on (LOPHOC.id_PH = PHONGHOC.id_PH) 
						inner join LICHHOC on (LOPHOC.id_LH = LICHHOC.id_LH)
	where PHONGHOC.id_PH = @id_PH 
		and (
				(ngaybatdau between @ngaybatdau and @ngayketthuc) 
				or (ngayketthuc between @ngaybatdau and @ngayketthuc)
				or (ngaybatdau < @ngaybatdau and ngayketthuc > @ngayketthuc)
			)
	return
end

--- VER 2.1 -- GIANG
go
	-- Trigger nếu cập nhật lớp mà cập nhật mã phòng thì xoá lịch học
create trigger trg_updateLH_PhongHoc_dellLIH
on LOPHOC
for update
as
begin
	declare @id_PH_old varchar(20)
	set @id_PH_old = (select id_PH from deleted)
	
	declare @id_PH_new varchar(20)
	set @id_PH_new = (select id_PH from inserted)
	
	declare @id_LH varchar(20)
	set @id_LH = (select id_LH from deleted)
	
	if (@id_PH_new != @id_PH_old)
		delete from LICHHOC where id_LH = @id_LH
end

GO

-- Them trigger kiem tra lop hoc da day hay chua
create TRIGGER checkFullClass
on HOCVIEN_LOPHOC
for INSERT
AS
BEGIN
	declare @malop varchar(20)
	declare @maphong varchar(20)
	declare @soluong int
	declare @succhua int
	set @malop=(select id_LH from inserted)
	set @soluong=(select count(*) from HOCVIEN_LOPHOC where id_LH=@malop)
	set @maphong=(select id_PH from LOPHOC where id_LH=@malop)
	set @succhua=(select succhua_PH from PHONGHOC where id_PH=@maphong)
	if(@succhua<@soluong)
		BEGIN
			RAISERROR('lop day',16,1)
			ROLLBACK TRANSACTION
		END
	ELSE
		BEGIN
			update LOPHOC set siso_LH = @soluong where id_LH=@malop
		end

END

GO
-- Trigger sua lop hoc tu phong lon sang phong nho
create TRIGGER updateClass
on LOPHOC
for UPDATE
as 

BEGIN
	DECLARE @maphongmoi varchar(20)
	declare @soluong INT
	declare @succhua INT

	set @maphongmoi = (select id_PH from inserted)
	set @succhua = (select succhua_PH from PHONGHOC where id_PH = @maphongmoi)
	set @soluong = (select COUNT(*) from HOCVIEN_LOPHOC inner join deleted on HOCVIEN_LOPHOC.id_LH = deleted.id_LH)
	if(@soluong > @succhua)
		BEGIN
			RAISERROR('Phong moi khong du cho', 16, 1)
			rollback TRANSACTION
		END
END