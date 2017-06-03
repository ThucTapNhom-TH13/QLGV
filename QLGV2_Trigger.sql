use QLGV
--trigger xóa học hàm
go
create trigger delete_HocHam on HocHam instead of delete
as
declare @mahocham char(10)
select @mahocham=MaHocHam from deleted
begin
delete from GV_HH where MaHocHam=@mahocham
delete from HocHam where MaHocHam=@mahocham
end
go
--trigger xóa học vị
go
create trigger delete_HocVi on HocVi instead of delete
as
declare @mahocvi char(10)
select @mahocvi=MaHocVi from deleted
begin
delete from QuaTrinhDaoTao where MaHocVi=@mahocvi
delete from HocVi where MaHocVi=@mahocvi
end
go
-- trigger xóa môn học
go
create trigger delete_MonHoc on MonHoc instead of delete
as
declare @mamonhoc char(10)
select @mamonhoc=MaMonHoc from deleted
begin
delete from QuaTrinhGiangDay where MaMonHoc=@mamonhoc
delete from MonHoc where MaMonHoc=@mamonhoc
end
go
--trigger xóa bộ môn
go
create trigger delete_BoMon on BoMon instead of delete
as
declare @mabomon char(10)
set @mabomon= (select MaBoMon from deleted)
begin 
update GiaoVien set MaBoMon=null where MaBoMon=@mabomon
delete from MonHoc where MaBoMon=@mabomon
delete from BoMon where MaBoMon=@mabomon
end
go
--trigger xóa khoa
go
create trigger delete_Khoa on Khoa instead of delete
as
declare @makhoa char(10)
set @makhoa= (select MaKhoa from deleted)
begin 
update GiaoVien set MaKhoa=null where MaKhoa=@makhoa
delete from BoMon where MaKhoa=@makhoa
delete from Khoa where MaKhoa=@makhoa
end
go
--trigger xóa chức vụ
go
create trigger delete_ChucVu on ChucVu instead of delete
as
declare @machucvu char(10)
set @machucvu=(select MaChucVu from deleted)
begin
update GiaoVien set MaChucVu=null where MaChucVu=@machucvu
delete ChucVu where MaChucVu=@machucvu
end
go
--trigger xóa giáo viên
go
create trigger delete_GiaoVien on GiaoVien instead of delete
as
declare @magiaovien char(10)
select @magiaovien=MaGV from deleted
begin
delete GV_HH where MaGV=@magiaovien
delete QuaTrinhDaoTao where MaGV=@magiaovien
delete QuaTrinhGiangDay where MaGV=@magiaovien
delete GiaoVien where MaGV=@magiaovien
end
go