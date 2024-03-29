use master
go
	if (exists(select * from sys.sysdatabases where name='quanlykhoahoc5'))
		drop database quanlykhoahoc5

go
create database quanlykhoahoc5

go
use quanlykhoahoc5
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
create table GIANGVIEN(
	id_GV varchar(20) primary key,
	ten_GV nvarchar(30) not null,
	username varchar(20) not null,
	ngaysinh_GV date not null,
	sodt_GV varchar(10) not null unique,
	diachi_GV nvarchar(100) not null,
	ghichu_GV ntext,
	ngaytao datetime,
	ngaysua datetime,
	foreign key (username) references ACCOUNT (username)
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
	hocphi float not null,
	ngaybatdau date not null,
	ngayketthuc date not null,
	thoigian int not null, 
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
	id_HV varchar(20) not null,
	id_LH varchar(20) not null,
	primary key(id_HV,id_LH),
	diem_1 float not null default -1,
	diem_2 float not null default -1,
	danhgia bit not null default 0,
	diem_do_an float not null default -1,
	xet_tot_nghiep bit not null default 0,
	xeploai nvarchar(20) not null default N'Không xếp loại',
	ghichu_HVLH ntext null,
	constraint HVLH_HV foreign key(id_HV) references HOCVIEN(id_HV),
	constraint HVLH_LH foreign key(id_LH) references LOPHOC(id_LH),	
)

go
create table DiemDanh(
	id int primary key identity,
	id_HV varchar(20) not null,
	id_LH varchar(20) not null,
	ngayDiemDanh date not null,
	unique(id_HV,id_LH,ngayDiemDanh)
)
go
alter table DiemDanh add foreign key(id_HV) references HocVien(id_HV)
go
alter table DiemDanh add foreign key(id_LH) references LopHoc(id_LH)
go
-- pass word = 123
insert into ACCOUNT values('admin', 'c4ca4238a0b923820dcc509a6f75849b', 0, null, null)
insert into ACCOUNT values('ql1', 'c4ca4238a0b923820dcc509a6f75849b', 1, null, null)
insert into ACCOUNT values('ql2', 'c4ca4238a0b923820dcc509a6f75849b', 1, null, null)
insert into ACCOUNT values('gv1', 'c4ca4238a0b923820dcc509a6f75849b', 2, null, null)
insert into ACCOUNT values('gv2', 'c4ca4238a0b923820dcc509a6f75849b', 2, null, null)
insert into ACCOUNT values('tn1', 'c4ca4238a0b923820dcc509a6f75849b', 3, null, null)
insert into ACCOUNT values('tn2', 'c4ca4238a0b923820dcc509a6f75849b', 3, null, null)
-----------------------------
go
create table LICHHOC(
	id_LIH int identity primary key,
	id_LH varchar(20) not null,
	tuan int not null,
	thu int not null,
	noidung nvarchar(50),
	ghichu_LIH ntext,
	constraint FK_LIH_LH foreign key(id_LH) references LOPHOC(id_LH)
)

---	Them bang hoc phi

go
create table HOCPHI(
	id_HV varchar(20),
	id_LH varchar(20),
	nop_lan_1 float,
	ngay_nop_lan_1 date,
	nop_lan_2 float,
	ngay_nop_lan_2 date,
	hoanthanh int,
	primary key(id_HV, id_LH),
	foreign key(id_HV) references HOCVIEN(id_HV),
	foreign key(id_LH) references LOPHOC(id_LH)
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

go
--- function get thứ bị trùng trong 1 khoảng thời gian và buổi trong ngày (thoigian), k tinh lop hoc dang xet
create function fn_GetThuForbidden(@id_PH varchar(20),@id_LH varchar(20), @thoigian int, @ngaybatdau date, @ngayketthuc date)
returns @tbresult table (
	thu int
)
as
begin
	insert into @tbresult select distinct thu
	from PHONGHOC inner join LOPHOC on (LOPHOC.id_PH = PHONGHOC.id_PH) 
						inner join LICHHOC on (LOPHOC.id_LH = LICHHOC.id_LH)
	where PHONGHOC.id_PH = @id_PH and LOPHOC.thoigian = @thoigian and LOPHOC.id_LH != @id_LH
		and (
				(ngaybatdau between @ngaybatdau and @ngayketthuc) 
				or (ngayketthuc between @ngaybatdau and @ngayketthuc)
				or (ngaybatdau < @ngaybatdau and ngayketthuc > @ngayketthuc)
			)

	return
end


--- sample test
go
insert into HOCVIEN (id_HV, ten_HV, sodt_HV, ngaysinh_HV, diachi_HV,ngaytao, ngaysua) values
('HV0001', N'Phạm Thế Anh', '090069966', '1998-03-10', N'Nguyên Xá', '2019-12-02', '2019-12-02'),
('HV0002', N'Hoàng Bá Ân', '00443388', '1998-05-22', N'Hà Nội', '2019-12-02', '2019-12-02'),
('HV0003', N'Nguyễn Văn Chương', '09001122', '1998-06-25', N'Hà Nam', '2019-12-02', '2019-12-02'),
('HV0004', N'Trần Văn Đức', '0322113333', '1998-02-26', N'Lạng Sơn', '2019-12-02', '2019-12-02'),
('HV0005', N'Hoàng Minh Dương', '0324111444', '1998-10-09', N'Nhổn', '2019-12-02', '2019-12-02'),
('HV0006', N'Lê Văn Bình', '0030221333', '1998-08-21', 'NKTX', '2019-12-02', '2019-12-02'),
('HV0007', N'Trương Tuấn Hiệp', '0970000123', '1998-02-01', N'Hà Nam', '2019-12-02', '2019-12-02'),
('HV0008', N'Phan Văn Đạt', '0123222111', '1998-01-02', N'Nguyên Xá', '2019-12-02', '2019-12-02')
go

insert into KHOAHOC (id_KH, ten_KH, gia_KH, ngaytao, ngaysua) values
('KH0001', 'Android', '5500000', '2019-12-02', '2019-12-02'),
('KH0002', 'PHP', '6500000', '2019-12-02', '2019-12-02'),
('KH0003', 'Java', '6000000', '2019-12-02', '2019-12-02'),
('KH0004', 'Python', '7000000', '2019-12-02', '2019-12-02'),
('KH0005', 'C#', '6200000', '2019-12-02', '2019-12-02'),
('KH0006', 'C/C++', '9000000', '2019-12-02', '2019-12-02'),
('KH0007', 'Front End', '8500000', '2019-12-02', '2019-12-02'),
('KH0008', 'Ruby', '7200000', '2019-12-02', '2019-12-02')

go

--insert into GIANGVIEN(id_GV, ten_GV, ngaysinh_GV, sodt_GV, diachi_GV, ngaytao, ngaysua) values
--('GV0001', N'Dương Văn Giang', '1998-09-20', '00009969', N'Nguyên Xá', '2019-12-02', '2019-12-02'),
--('GV0002', N'Nguyễn Đình Giang', '1998-10-22', '0900113114', N'Hà Nội', '2019-12-02', '2019-12-02'),
--('GV0003', N'Phạm Huy Lâm', '1998-03-2', '0300113000', N'Hà Nam', '2019-12-02', '2019-12-02')
--go
insert into PHONGHOC(id_PH, ten_PH, ngaytao, succhua_PH, ngaysua) values
('PH0001', N'Lab 1', '2019-12-02', 20, '2019-12-02'),
('PH0002', N'Lab 2', '2019-12-02', 20, '2019-12-02'),
('PH0003', N'Lab 3', '2019-12-02', 15, '2019-12-02'),
('PH0004', N'Lab 4', '2019-12-02', 10, '2019-12-02'),
('PH0005', N'Lab 5', '2019-12-02', 20, '2019-12-02')

