
use QLGV
--thêm khoa
go
create proc themkhoa(
@makhoa char(10),@tenkhoa nvarchar(50)
)
as
begin
insert into Khoa values(@makhoa,@tenkhoa)
end
go
--sửa khoa
create proc suakhoa(
@makhoa char(10),@tenkhoa nvarchar(50)
)
as
begin
update Khoa
set
TenKhoa=@tenkhoa

where MaKhoa=@makhoa

end
--xóa thông tin khoa
go
create proc xoakhoa(
@makhoa char(10)
)
as
begin
delete Khoa where MaKhoa=@makhoa

end


go
--thêm bộ môn
create proc thembomon(
@mabomon char(10),@makhoa char(10),@tenbomon nvarchar(50)
)
as
begin
insert into BoMon values(@mabomon,@makhoa,@tenbomon)
end
go
--sửa bộ môn
create proc suabomon(
@mabomon char(10),@makhoa char(10),@tenbomon nvarchar(50)
)
as
begin
update BoMon
set
TenBoMon=@tenbomon,
MaKhoa=@makhoa
where MaBoMon=@mabomon

end
--xóa thông tin bộ môn
go
create proc xoabomon(
@mabomon char(10)
)
as
begin
delete BoMon where MaBoMon=@mabomon

end


go
--thêm chức vụ

create proc themchucvu(
@machucvu char(10),@tenchucvu nvarchar(50)
)
as
begin
insert into ChucVu(MaChucVu,TenChucVu) values(@machucvu,@tenchucvu)
end
go
--sửa chức vụ
create proc suachucvu(
@machucvu char(10),@tenchucvu nvarchar(50)
)
as
begin
update ChucVu
set
TenChucVu=@tenchucvu

where MaChucVu=@machucvu

end
--xóa thông tin chức vụ
go
create proc xoachucvu(
@machucvu char(10)
)
as
begin
delete ChucVu where MaChucVu=@machucvu

end



go


--thêm môn học

create proc themmonhoc(
@mamonhoc char(10),@mabomon char(10),@tenmonhoc nvarchar(50),@stc int
)
as
begin
insert into MonHoc values(@mamonhoc,@mabomon,@tenmonhoc,@stc)
end
go
--sửa môn học
create proc suamonhoc(
@mamonhoc char(10),@mabomon char(10),@tenmonhoc nvarchar(50),@stc int
)
as
begin
update MonHoc
set
TenMonHoc=@tenmonhoc,
MaBoMon=@mabomon,
SoTinChi=@stc

where MaMonHoc=@mamonhoc

end
--xóa môn học
go
create proc xoamonhoc(
@mamonhoc char(10)
)
as
begin
delete MonHoc where MaMonHoc=@mamonhoc

end




go


--thêm giáo viên

create proc themgiaovien(
@magv char(10),@tengiaovien nvarchar(50),@ngaysinh date,
@gioitinh nvarchar(10),@dantoc char(20),@email nvarchar(50),@quequan nvarchar(50),
@mabomon char(10),@makhoa char(10),@machucvu char(10),@sdt int,@cmt int,@hesoluong float,@luongcoban int
)
as
begin
insert into GiaoVien values(@magv,@tengiaovien,@ngaysinh,@gioitinh
,@dantoc,@email,@quequan,@mabomon,@makhoa,@machucvu,@sdt,@cmt,@hesoluong,@luongcoban)
end
go
select *from giaovien
go
--sửa giao viên
create proc suagiaovien(
@magv char(10),@tengiaovien nvarchar(50),@ngaysinh date,
@gioitinh nvarchar(10),@dantoc char(20),@email nvarchar(50),@quequan nvarchar(50),
@mabomon char(10),@makhoa char(10),@machucvu char(10),@sdt int,@cmt int,@hesoluong float,@luongcoban float
)
as
begin
update GiaoVien
set
TenGiaoVien=@tengiaovien,
NgaySinh=@ngaysinh,
GioiTinh=@gioitinh,
DanToc=@dantoc,
Email=@email,
QueQuan=@quequan,
MaBoMon=@mabomon,
MaKhoa=@makhoa,
MaChucVu=@machucvu,
SoDienThoai=@sdt,
SoCMT=@cmt,
HeSoLuong=@hesoluong,
LuongCoBan=@luongcoban

where MaGV=@magv

end
--xóa giáo viên
go
create proc xoagiaovien(
@magv char(10)
)
as
begin
delete GiaoVien where MaGV=@magv

end

go
--thêm học hàm
create proc themhocham(
@mahocham char(10),@tenhocham nvarchar(50),@viettat char(10)
)
as
begin
insert into HocHam values(@mahocham,@tenhocham,@viettat)
end
go
--sửa học hàm
create proc suahocham(
@mahocham char(10),@tenhocham nvarchar(50),@viettat char(10)
)
as
begin
update HocHam
set
TenHocHam=@tenhocham,
VietTat=@viettat
where MaHocHam=@mahocham

end
--xóa thông tin học hàm
go
create proc xoahocham(
@mahocham char(10)
)
as
begin
delete HocHam where MaHocHam=@mahocham

end

go
--thêm học vị
create proc themhocvi(
@mahocvi char(10),@tenhocvi nvarchar(50),@viettat char(10)
)
as
begin
insert into HocVi values(@mahocvi,@tenhocvi,@viettat)
end
go
--sửa học hàm
create proc suahocvi(
@mahocvi char(10),@tenhocvi nvarchar(50),@viettat char(10)
)
as
begin
update HocVi
set
TenHocVi=@tenhocvi,
VietTat=@viettat
where MaHocVi=@mahocvi

end
--xóa thông tin học hàm
go
create proc xoahocvi(
@mahocvi char(10)
)
as
begin
delete HocVi where MaHocVi=@mahocvi

end

go
create proc TimKiem
(
@tengiaovien nvarchar(50),
@quequan nvarchar(50),
@gioitinh nvarchar(10),
@khoa nvarchar(50),
@bomon nvarchar(50),
@chucvu nvarchar(50)
)
as
begin
select gv.MaGV, gv.TenGiaoVien, gv.NgaySinh,gv.GioiTinh,gv.DanToc,gv.Email,gv.QueQuan,gv.MaBoMon,gv.MaKhoa,gv.MaChucVu,gv.SoDienThoai,gv.SoCMT,gv.HeSoLuong,gv.LuongCoBan
from GiaoVien gv, ChucVu cv, BoMon bm, Khoa k 
where gv.MaBoMon=bm.MaBoMon and gv.MaKhoa=k.MaKhoa  and gv.MaChucVu=cv.MaChucVu 
and (gv.TenGiaoVien like N'%' + @tengiaovien + '%' or @tengiaovien = '')
and (gv.quequan like N'%' + @quequan + '%' or @quequan = '')
and (gv.GioiTinh like N'%' + @GioiTinh + '%' or @GioiTinh = '')
and (k.TenKhoa like N'%' + @khoa + '%' or @khoa = '')
and (bm.TenBoMon like N'%' + @bomon + '%' or @bomon = '')
and (cv.TenChucVu like N'%' + @chucvu + '%' or @chucvu = '')
end
go
select *from GiaoVien
go
--1.In an
go
create proc InAnHocHam(@magiaovien char(10))
as
begin
	select TenHocHam, NoiCongNhan,NamPhong
	from Giaovien gv, HocHam hh, GV_HH gvhh
	where gv.MaGV=@magiaovien and gv.MaGV=gvhh.MaGV and hh.MaHocHam=gvhh.MaHocHam
end
go
create proc InAnHocVi(@magiaovien char(10))
as
begin
	select TenHocVi, TuNam, DenNam, XepLoai, TruongDaoTao, NuocDaoTao
	from Giaovien gv, HocVi hv,QuaTrinhDaoTao qtdt
	where gv.MaGV=@magiaovien and gv.MaGV=qtdt.MaGV and hv.MaHocVi=qtdt.MaHocVi
end
go
create proc InAnMonHoc(@magiaovien char(10))
as
begin
	select TenMonHoc, NamBDGiangDay
	from GiaoVien gv, MonHoc mh, QuaTrinhGiangDay  qtgd
	where gv.MaGV=@magiaovien and gv.MaGV=qtgd.MaGV and mh.MaMonHoc=qtgd.MaMonHoc
end
select *from Quatrinhgiangday
go

create proc InAn(@magiaovien char(10))
as
begin
	select gv.MaGV,TenGiaoVien,NgaySinh,GioiTinh,DanToc,Email,QueQuan,SoDienThoai,TenChucVu,TenBoMon,TenKhoa
	from GiaoVien gv, ChucVu cv, Khoa k, BoMon bm
	where gv.MaChucVu=cv.MaChucVu and gv.MaKhoa=k.MaKhoa and gv.MaBoMon=bm.MaBoMon and gv.MaGV=@magiaovien
end	
select *from GiaoVien
go
--2.Tim kiem giao vien
create proc TimKiemGiaoVien
(
	@key nvarchar(50)
)
as
begin
	select *
	from giaovien
	where magv like N'%'+@key+N'%' or TenGiaoVien like N'%'+@key+N'%' or Convert(nvarchar(50),NgaySinh,103) like N'%'+@key+N'%'
	or Email like N'%'+@key+N'%' or Convert(nvarchar(50),SoDienThoai) like N'%'+@key+N'%' or Convert(nvarchar(50),SoCMT) like N'%'+@key+N'%' or
	DanToc like N'%'+@key+N'%' or Convert(nvarchar(50),HeSoLuong) like N'%'+@key+N'%' or Convert(nvarchar(50),LuongCoBan) like N'%'+@key+N'%' or
	  GioiTinh like N'%'+@key+N'%' or quequan like N'%'+@key+N'%' or MaBoMon like N'%'+@key+N'%' 
	 or MaKhoa like N'%'+@key+N'%' or MaChucVu like N'%'+@key+N'%' 
end
go
--3.Lọc nhanh trong bảng giáo viên
create proc LocNhanhGiaoVien(@key nvarchar(50))
as
begin
	select *
	from GiaoVien
	where magv like N'%'+@key+'%'
		OR TenGiaoVien like N'%'+@key+'%'
		or Convert(nvarchar(50),NgaySinh,103) like N'%'+@key+'%'
		or DanToc like N'%'+@key+'%'
		or GioiTinh like N'%'+@key+'%'
		or Email like N'%'+@key+'%'
		or quequan like N'%'+@key+'%'
		or MaBoMon like N'%'+@key+'%'
		or MaChucVu like N'%'+@key+'%'
		or MaKhoa like N'%'+@key+'%'
		or Convert(nvarchar(50),SoDienThoai) like N'%'+@key+'%'
		or SoCMT like N'%'+@key+'%'
		or Convert(nvarchar(50),HeSoLuong) like N'%'+@key+'%'
		or Convert(nvarchar(50),LuongCoBan) like N'%'+@key+'%'	
end
select *from GiaoVien
--
go
alter proc RptLyLichGiaoVien1
as
begin

	select gv.MaGV,TenGiaoVien,NgaySinh,GioiTinh,DanToc,Email,QueQuan,SoDienThoai,TenChucVu,TenBoMon,TenKhoa,
		TenHocVi, TuNam, DenNam, XepLoai, TruongDaoTao, NuocDaoTao,TenHocHam, NoiCongNhan,NamPhong,mh.TenMonHoc,mh.NamBDGiangDay

	from GiaoVien gv, ChucVu cv, Khoa k, BoMon bm,
		(select gv.magv,TenHocVi, TuNam, DenNam, XepLoai, TruongDaoTao, NuocDaoTao
		from Giaovien gv, HocVi hv,QuaTrinhDaoTao qtdt
		where gv.MaGV=qtdt.MaGV and hv.MaHocVi=qtdt.MaHocVi)hv,
		(select gv.magv,TenHocHam, NoiCongNhan,NamPhong
		from Giaovien gv, HocHam hh, GV_HH gvhh
		where gv.MaGV=gvhh.MaGV and hh.MaHocHam=gvhh.MaHocHam) hh,		
		(select gv.magv, TenMonHoc, NamBDGiangDay
		from GiaoVien gv, MonHoc mh, QuaTrinhGiangDay  qtgd
		where  gv.MaGV=qtgd.MaGV and mh.MaMonHoc=qtgd.MaMonHoc) mh


	where gv.MaChucVu=cv.MaChucVu and gv.MaKhoa=k.MaKhoa and gv.MaBoMon=bm.MaBoMon 
		and gv.magv=mh.magv and gv.magv=hh.magv and gv.magv=hv.magv 
end

RptLyLichGiaoVien 

ALTER proc RptLyLichGiaoVien(@magiaovien char(10))
as
begin
	
	


	
	select gv.MaGV,TenGiaoVien,NgaySinh,GioiTinh,DanToc,Email,QueQuan,SoDienThoai,TenChucVu,TenBoMon,TenKhoa,
		TenHocVi, TuNam, DenNam, XepLoai, TruongDaoTao, NuocDaoTao,TenHocHam, NoiCongNhan,NamPhong,mh.TenMonHoc,mh.NamBDGiangDay

	from GiaoVien gv, ChucVu cv, Khoa k, BoMon bm,
		(select gv.magv,TenHocVi, TuNam, DenNam, XepLoai, TruongDaoTao, NuocDaoTao
		from Giaovien gv, HocVi hv,QuaTrinhDaoTao qtdt
		where gv.MaGV=@magiaovien and gv.MaGV=qtdt.MaGV and hv.MaHocVi=qtdt.MaHocVi)hv,
		(select gv.magv,TenHocHam, NoiCongNhan,NamPhong
		from Giaovien gv, HocHam hh, GV_HH gvhh
		where gv.MaGV=@magiaovien and gv.MaGV=gvhh.MaGV and hh.MaHocHam=gvhh.MaHocHam) hh,		
		(select gv.magv, TenMonHoc, NamBDGiangDay
		from GiaoVien gv, MonHoc mh, QuaTrinhGiangDay  qtgd
		where gv.MaGV=@magiaovien and gv.MaGV=qtgd.MaGV and mh.MaMonHoc=qtgd.MaMonHoc) mh


	where gv.MaChucVu=cv.MaChucVu and gv.MaKhoa=k.MaKhoa and gv.MaBoMon=bm.MaBoMon and gv.MaGV=@magiaovien
		and gv.magv=mh.magv and gv.magv=hh.magv and gv.magv=hv.magv 
end

RptLyLichGiaoVien 'GV11'