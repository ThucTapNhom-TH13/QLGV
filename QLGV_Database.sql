create database QLGV
go
use QLGV
go

create table Khoa
(
MaKhoa char(10) not null primary key,
TenKhoa nvarchar(50),
)
go
create table BoMon
(
MaBoMon char(10) not null primary key,
MaKHoa char(10) not null foreign key (MaKhoa) references Khoa(MaKhoa),
TenBoMon nvarchar(50),
)
go
create table ChucVu
(
SoThuTu int identity,
MaChucVu char(10) not null primary key,
TenChucVu nvarchar(50) ,

)
go
create table MonHoc
(
MaMonHoc char(10) not null primary key,
MaBoMon char(10) not null foreign key (MaBoMon) references BoMon,
TenMonHoc nvarchar(50) ,
SoTinChi int,
)
go
create table HocVi
(
MaHocVi char(10) not null primary key,
TenHocVi nvarchar(50) ,
ThuTuSapXep int identity,
VietTat char(10),
)
go
create table HocHam
(
MaHocHam char(10) not null primary key,
TenHocHam nvarchar(50) ,
ThuTuSapXep int identity,
VietTat char(10),
)
go
create table GiaoVien
(
MaGV char(10) not null primary key,
TenGiaoVien nvarchar(50),
NgaySinh date,
GioiTinh nvarchar(10) check (GioiTinh In(N'Nam',N'Nữ')),
DanToc char(10),
Email varchar(50),
quequan nvarchar(50),
MaBoMon char(10) not null foreign key(MaBoMon) references BoMon(MaBoMon),
MaKhoa char(10) not null foreign key (MaKhoa)references Khoa(MaKhoa),
MaChucVu char(10) not null foreign key (MaChucVu) references  ChucVu(MaChucVu),
SoDienThoai char(20),
SoCMT char(20),
HeSoLuong float,
LuongCoBan float default 1500
)
go
create table QuaTrinhDaoTao
(
MaGV char(10) not null foreign key(MaGV) references GiaoVien(MaGV),
MaHocVi char(10) not null foreign key(MaHocVi) references HocVi(MaHocVi),
primary key(MaGV,MaHocVi),
TuNam int,
DenNam int,
XepLoai nvarchar(30),
TruongDaoTao nvarchar(50),
NuocDaoTao nvarchar(50),
ChuyenNganh nvarchar(50),
LaHocViHientai bit,
GhiChu text,
)
go
create table GV_HH
(
MaGV char(10) not null references GiaoVien(MaGV),
MaHocHam  char(10) not null references HocHam(MaHocHam),
primary key(MaGV,MaHocHam),
NoiCongNhan nvarchar(50),
NamPhong int,
LaHocHamHientai bit,
GhiChu Ntext,
)
go
create table QuaTrinhGiangDay
(
MaGV char(10) not null references GiaoVien(MaGV),
MaMonHoc char(10) not null references MonHoc(MaMonHoc),
primary key (MaGV,MaMonHoc),
HinhThucThi Ntext,
NamBDGiangDay int,
)
go
--1 nhập thông tin bảng khoa
			insert into Khoa values ('KH01',N'Công Nghệ Thông Tin')
			insert into Khoa values ('KH02',N'Động Lực')
			insert into Khoa values ('KH03',N'Kỹ Thuật Điều Khiển')
			insert into Khoa values ('KH04',N'Hàng Không Vũ Trụ')
			insert into Khoa values ('KH05',N'Vô Tuyến Điện Tử')
			insert into Khoa values ('KH06',N'Cơ Khí')
--2 nhập thông tin bảng bộ môn
			insert into BoMon values('BM01','KH01',N'Công Nghệ Phần Mềm')
			insert into BoMon values('BM02','KH01',N'Hệ Thống Thông Tin')
			insert into BoMon values('BM03','KH01',N'An Ninh Mạng')
			insert into BoMon values('BM04','KH01',N'Khoa Học Máy Tính')
			insert into BoMon values('BM05','KH02',N'Động Cơ')
			insert into BoMon values('BM06','KH02',N'Ô Tô')
			insert into BoMon values('BM07','KH02',N'Xe Xích Máy Kéo')
			insert into BoMon values('BM08','KH02',N'Máy Xây Dựng')
			insert into BoMon values('BM09','KH03',N'Tên Lửa')
			insert into BoMon values('BM10','KH03',N'Kĩ Thuật Điện')
			insert into BoMon values('BM11','KH03',N'Điện Tử Y Sinh')
			insert into BoMon values('BM12','KH03',N'Kĩ Thuật Điện')
			insert into BoMon values('BM13','KH03',N'Kĩ Thuật Tính Và Tự Động')
			insert into BoMon values('BM14','KH04',N'Robot Đặc biệt Và Cơ Điện Tử')
			insert into BoMon values('BM15','KH04',N'Động Cơ Phản Lực')
			insert into BoMon values('BM16','KH04',N'Công Nghệ Thiết Bị Và Hàng Không Vũ Trụ')
			insert into BoMon values('BM17','KH04',N'Thiết Kế Hệ Thống Kết Cấu Thiết Bị Bay')
			insert into BoMon values('BM18','KH05',N'Thông Tin')
			insert into BoMon values('BM19','KH05',N'Ra-Đa')
			insert into BoMon values('BM20','KH05',N'Tác Chiến Điện Tử')
			insert into BoMon values('BM21','KH05',N'Lý Thuyết Mạch Đo Lường')
			insert into BoMon values('BM22','KH05',N'Xung Số -VXL')
			insert into BoMon values('BM23','KH05',N'Cơ Sở Kỹ Thuật Vô Tuyến')
			insert into BoMon values('BM24','KH06',N'Cơ Học Máy')
			insert into BoMon values('BM25','KH06',N'Cơ Học Vật Rắn')
			insert into BoMon values('BM26','KH06',N'Nhiệt Thủy Khí')
			insert into BoMon values('BM27','KH06',N'Chế Tạo Máy')
			insert into BoMon values('BM28','KH06',N'Gia Công Áp Lực')
			insert into BoMon values('BM29','KH06',N'Vật Liệu Và Công Nghệ Vật Liệu')
			insert into BoMon values('BM30','KH06',N'Quản Lý Khoa Học Công Nghệ')
go
--3 nhập thông tin bảng Học Hàm
			insert into HocHam (MaHocHam,TenHocHam,VietTat) values('HH01',N'Phó Giáo Sư','PGS')
			insert into HocHam (MaHocHam,TenHocHam,VietTat) values('HH02',N'Giáo Sư','GS')
--4 nhập thông tin bảng học vị
			insert into HocVi(MaHocVi,TenHocVi,VietTat)  values ('HV01',N'Cử Nhân','CN')
			insert into HocVi(MaHocVi,TenHocVi,VietTat) values ('HV02',N'Kỹ Sư','KS')
			insert into HocVi(MaHocVi,TenHocVi,VietTat) values ('HV03',N'Thạc Sĩ','ThS')
			insert into HocVi(MaHocVi,TenHocVi,VietTat) values ('HV04',N'Tiến Sĩ','TS')
go
--5 nhập thông tin bảng chức Vụ
			insert into ChucVu values('CV01',N'Chủ Nhiệm Bộ Môn')
			insert into ChucVu values('CV02',N' Phó Chủ Nhiệm Bộ Môn')
			insert into ChucVu values('CV03','Giáo Viên')
			insert into ChucVu values('CV04',N'Nghiên Cứu Sinh')
--6 nhập thông tin bảng giáo viên
			insert into GiaoVien(MaGV,TenGiaoVien,NgaySinh,GioiTinh,DanToc,Email,quequan,MaBoMon,MaKhoa,MaChucVu,SoDienThoai,SoCMT,HeSoLuong) 
			values ('GV099',N'Phan Việt Anh','2/3/1980',N'Nữ',N'Kinh','Anh123@gmail.com',N'Phú Thọ','BM01','KH01','CV01',0988737618,123456,3),
			 ('GV02',N'Nguyễn Kim Thắng','8/8/1987',N'Nam',N'Kinh','kimthang@gmail.com',N'Bắc Ninh','BM03','KH01','CV03',0173123456 ,768334,5.5),
			 ('GV03',N'Hoa Tất Thắng','3/4/1973',N'Nam',N'Kinh','Hoathang@gmail.com',N'Hà Nội','BM02','KH01','CV01',null ,0128766,4.5),
			 ('GV04',N'Tống Minh Đưc','4/5/1977',N'Nam',N'Kinh','Minhduc@gmail.com',N'Hải Phòng','BM02','KH01','CV02',0985730035 ,987234,5),
			 ('GV05',N'Đỗ Thị Mai Hường','5/6/1969',N'Nữ',N'Kinh','huong@gmail.com',N'Phú Thọ','BM02','KH02','CV03',0167345678, 542911,6.8),
			 ('GV06',N'Đào Thanh Tĩnh','9/1/1975',N'Nam',N'Kinh','tinh75@gmail.com',N'Thái Bình','BM02','KH01','CV03',0166345678 ,123987,8),
			 ('GV08',N'Vũ Đình Phái','8/8/1968',N'Nam',N'Kinh','vuphai88@gmail.com',N'Thái Nguyên','BM02','KH02','CV04',0936543127, 123234,6.5),
			 ('GV07',N'Trần Ngọc Anh','3/9/1966',N'Nữ',N'Kinh','traanh@gmail.com',N'Vĩnh Phúc','BM02','KH01','CV03',0985778954, 278654,8.8),
			 ('GV09',N'Nguyễn Hiếu Minh','5/5/1982',N'Nam',N'Kinh','minh1982@gmail.com',N'Hà Nam','BM03','KH01','CV01',0167978654 ,145892,6.5),
			 ('GV10',N'Nguyễn Quang Uy','6/7/1978',N'Nam',N'Kinh','uyquang@gmail.com',N'Nam Định','BM03','KH03','CV02',0985671123, 945821,8.5),
			 ('GV11',N'Lưu Văn Hưng','9/5/1985',N'Nam',N'Kinh','lvhung@gmail.com',N'Tuyên Quang','BM03','KH01','CV03',0977123678, 834701,7.5),
			 ('GV12',N'Tạ Minh Trang','9/9/1990',N'Nữ',N'Kinh','trang90@gmail.com',N'Thanh Hóa','BM03','KH03','CV04',0936789234, 984305,7),
			 ('GV13',N'NGuyễn Lương Bình','4/1/1972',N'Nam',N'Kinh','binhng@gmail.com',N'Nghệ An','BM03','KH01','CV03',0168987564, 987456,6.5)
		

go
--7 nhập thông tin bảng môn học
			insert into MonHoc values('MH01','BM04',N'xử lý ảnh',2)
			insert into MonHoc values('MH02','BM04',N'tương tác người máy',2)
			insert into MonHoc values('MH03','BM02',N'cơ sở dữ liệu',3)
			insert into MonHoc values('MH04','BM02',N'thực tập cơ sở dữ liệu',3)
			insert into MonHoc values('MH05','BM01',N'lập trình web',4)
			insert into MonHoc values('MH06','BM01',N'lập trình cơ bản',3)
			insert into MonHoc values('MH07','BM01',N'công nghệ web',2)
			insert into MonHoc values('MH08','BM03',N'dịch vụ mạng',1)
			insert into MonHoc values('MH09','BM01',N'quản lý dự án phần mềm',2)
			insert into MonHoc values('MH10','BM01',N'thiết kế và xây dựng phần mềm',3)
			insert into MonHoc values('MH11','BM01',N'lập tình java',2)
			insert into MonHoc values('MH12','BM02',N'lập trình visual basic',4)
			insert into MonHoc values('MH13','BM01',N'lập trình nâng cao',2)
			insert into MonHoc values('MH14','BM04',N'toán rời rạc',4)
			insert into MonHoc values('MH15','BM04',N'trí tuệ nhân tạo ',1)
			insert into MonHoc values('MH16','BM02',N'công nghệ đa phương tiện',2)
			insert into MonHoc values('MH17','BM02',N'cấu trúc dữ liệu và giải thuật',3)
			insert into MonHoc values('MH18','BM03',N'mạng máy tính',3)
			insert into MonHoc values('MH19','BM03',N'quản trị mạng',3)
			insert into MonHoc values('MH20','BM01',N'công nghệ lập trình tích hợp',3)
--8 nhap bang qua trinh dao tao
			insert into QuaTrinhDaoTao values('GV01','HV04',1995,2000,N'giỏi',N'Bách Khoa',N'Việt nam',N'Công nghệ thông tin','true','null')
			insert into QuaTrinhDaoTao values('GV09','HV03',1998,2005,N'khá',N'Bách Khoa',N'Việt nam',N'Toán','false','null')
			insert into QuaTrinhDaoTao values('GV010','HV02',2000,2008,N'giỏi',N'HVKTQS',N'Việt nam',N'Kĩ sư xây dựng','true','null')
			insert into QuaTrinhDaoTao values('GV03','HV01',1995,2003,N'giỏi',N'Maxitcova',N'Nga',N'Công nghệ thông tin','true','null')
			insert into QuaTrinhDaoTao values('GV04','HV04',1993,2000,N'giỏi',N'Bách Khoa',N'Việt nam',N'Cầu đường','true','null')
			insert into QuaTrinhDaoTao values('GV07','HV03',1998,2006,N'khá',N'HVKTQS',N'Việt nam',N'Toán','false','null')
			insert into QuaTrinhDaoTao values('GV11','HV02',20003,2008,N'giỏi',N'HVKTQS',N'Việt nam',N'Kĩ sư xây dựng','true','null')
			insert into QuaTrinhDaoTao values('GV08','HV05',1999,2003,N'giỏi',N'Maxitcova',N'Nga',N'Khoa học máy tính','false','null')
--9  nhap bang qua trinh giang day
			insert into QuaTrinhGiangDay values('GV07','MH10', 'viết',2000)
			insert into QuaTrinhGiangDay values('GV12','MH01',N'Vấn đáp',1998)
			insert into QuaTrinhGiangDay values('GV06','MH02',N'Viết',2006)
			insert into QuaTrinhGiangDay values('GV09','MH12',N'Trắc nghiệm',2002)
			insert into QuaTrinhGiangDay values('GV11','MH06',N'Viết',2010)
			
			insert into QuaTrinhGiangDay values('GV08','MH10','Viết',2000)
			insert into QuaTrinhGiangDay values('GV02','MH01','Vấn đáp',1998)
			insert into QuaTrinhGiangDay values('GV13','MH12','Viết',2006)
			insert into QuaTrinhGiangDay values('GV05','MH20','Trắc nghiệm',2002)
			insert into QuaTrinhGiangDay values('GV010','MH16','Viết',2010)


--10 nhập bảng GV-HH
			insert into GV_HH values('GV12','HH01',N'Viêt Nam',2005,'false',null)
			insert into GV_HH values('GV11','HH02',N'Nga',2008,'true',null)
			insert into GV_HH values('GV01','HH01',N'Anh',2005,'false',null)
			insert into GV_HH values('GV05','HH02',N'Đức',2008,'true',null)
			insert into GV_HH values('GV02','HH01',N'Nga',2008,'true',null)
			insert into GV_HH values('GV06','HH01',N'Mỹ',2005,'false',null)
			insert into GV_HH values('GV09','HH02',N'Đức',2008,'true',null)
			insert into GV_HH values('GV11','HH01',N'Nga',2008,'FALSE',null)

go
select *from GiaoVien
select *from HocHam
select *from HocVi
select *from BoMon
select *from ChucVu
select *from QuaTrinhDaoTao
select *from GV_HH
select *from QuaTrinhGiangDay
select *from Khoa
select *from MonHoc
--                              BAI 4
--cac cau lenh truy van
--1. Đưa ra danh sách giáo viên ( Mã giáo viên, tên, ngày sinh,gioi tinh ma khoa,ma bo mon, lương). Sắp xếp 
--theo thứ tự lương giảm dần
select MaGV,TenGiaoVien,NgaySinh,GioiTinh,MaKhoa,MaBoMon,HeSoLuong 
from GiaoVien
order by  HeSoLuong desc
--2.Đưa ra danh sách giáo viên thuộc khoa 'Cong nghe thong tin'
select MaGV,TenGiaoVien 
from GiaoVien,Khoa
where GiaoVien.MaKhoa=Khoa.MaKhoa and Tenkhoa=N'công nghệ thông tin'
--3.đưa ra danh sách giáo viên thuộc bộ môn công nghệ phần mềm
select MaGV,TenGiaoVien
from GiaoVien,BoMon
where GiaoVien.MaBoMon=BoMon.MaBoMon and TenBoMon=N'công nghệ phần mềm'
--4.đưa ra bộ môn thuộc khoa công nghệ thông tin
select MaBoMon,TenBoMon 
from BoMon,Khoa
where BoMon.MaKHoa=Khoa.MaKhoa and TenKhoa=N'công nghệ thông tin'
--5.Đưa ra danh sách giáo viên có hệ số lương >=5
select MaGV,TenGiaoVien,HeSoLuong
from GiaoVien
where HeSoLuong>= 5.0 
order by HeSoLuong desc
--6.đưa ra danh sách giáo viên có giảng dạy
select GiaoVien.MaGV,TenGiaoVien
from GiaoVien,QuaTrinhGiangDay
where GiaoVien.MaGV=QuaTrinhGiangDay.MaGV
--7.đưa ra danh sách giáo viên không giảng dạy
select GiaoVien.MaGV,TenGiaoVien
from GiaoVien
except select GiaoVien.MaGV,TenGiaoVien
from GiaoVien,QuaTrinhGiangDay
where GiaoVien.MaGV=QuaTrinhGiangDay.MaGV
--8.đưa ra danh sách giáo viên là Giáo Sư
select GiaoVien.MaGV,TenGiaoVien
from GiaoVien,HocHam,GV_HH
where HocHam.MaHocHam=GV_HH.MaHocHam and GV_HH.MaGV=GiaoVien.MaGV and TenHocHam=N' giáo Sư'
--9.đưa ra giáo viên là thạc sĩ
select GiaoVien.MaGV,TenGiaoVien
from GiaoVien,QuaTrinhDaoTao,HocVi
where GiaoVien.MaGV=QuaTrinhDaoTao.MaGV and QuaTrinhDaoTao.MaHocVi=HocVi.MaHocVi and TenHocVi=N'thạc sĩ' and LaHocViHientai='true'
--9.đưa ra danh sách các môn học thuộc bộ môn công nghệ phần mềm
select MaMonHoc,TenMonHoc
from MonHoc,BoMon
where MonHoc.MaBoMon=BoMon.MaBoMon and TenBoMon=N'công nghệ phần mềm'
--11.đưa ra những giáo viên là tiến sỹ
select GiaoVien.MaGV,GiaoVien.TenGiaoVien
from GiaoVien,QuaTrinhDaoTao,HocVi
where GiaoVien.MaGV=QuaTrinhDaoTao.MaGV and HocVi.MaHocVi=QuaTrinhDaoTao.MaHocVi and TenHocVi=N'tiến sĩ'
--12.đưa gia giao viên dạy môn xu lí ảnh
select GiaoVien.MaGV,TenGiaoVien
from GiaoVien,QuaTrinhGiangDay,MonHoc
where GiaoVien.MaGV=QuaTrinhGiangDay.MaGV and QuaTrinhGiangDay.MaMonHoc=MonHoc.MaMonHoc and TenMonHoc=N'xử lý ảnh'
--13.đưa ra danh sách giáo viên là chủ nhiệm bộ môn,danh sách đưa ra gồm mã giáo viên,họ tên
select MaGV,TenGiaoVien
from GiaoVien,ChucVu
where GiaoVien.MaChucVu=ChucVu.MaChucVu and TenChucVu=N'chủ nhiệm bộ môn'
--14.đưa ra danh sách giáo viên là chủ nhiệm bộ môn,danh sách đưa ra gồm mã giáo viên,họ tên,tên bộ môn,tên khoa

select MaGV,TenGiaoVien,TenBoMon,TenKhoa
from GiaoVien,BoMon,Khoa,ChucVu
where GiaoVien.MaChucVu=ChucVu.MaChucVu and GiaoVien.MaBoMon= BoMon.MaBoMon
    and GiaoVien.MaKhoa=Khoa.MaKhoa and TenChucVu=N'chủ nhiệm bộ môn'
--15.đưa ra danh sách giáo viên (mã giáo viên ,tên giáo viên,tên bộ môn) sắp xếp theo tên bộ môn
select MaGV,TenGiaoVien,TenBoMon
from GiaoVien,BoMon
where GiaoVien.MaBoMon=BoMon.MaBoMon
order by TenBoMon 

--                      BÀI 5
--1.ưa ra tổng lương theo khoa
select Khoa.MaKhoa,TenKhoa,sum(Hesoluong) as tongluong
from Khoa,GiaoVien
where Khoa.MaKhoa=GiaoVien.MaKhoa
group by Khoa.MaKhoa,TenKhoa
--2.đưa ra danh sách giáo viên có hệ số lương lớn nhất
select MaGV,TenGiaoVien,Hesoluong 
from GiaoVien 
where Hesoluong=(Select max(Hesoluong) from GiaoVien)
--3.đưa ra lương lớn nhất theo từng khoa
select Khoa.MaKhoa,TenKhoa,maxluong
from Khoa,(select MaKhoa,max(Hesoluong) as maxluong from GiaoVien group by MaKhoa) as b
where Khoa.MaKhoa=b.MaKhoa
--4.đua ra giao viên có lương lớn nhất thuộc khoa Công nghệ thông tin
select distinct MaGV,TenGiaoVien,maxluong
from GiaoVien,Khoa,(select Makhoa,max(Hesoluong) as maxluong from GiaoVien group by MaKhoa) as b
where GiaoVien.MaKhoa=b.Makhoa and  Khoa.MaKhoa=b.Makhoa and TenKhoa=N'công nghệ thông tin' and HeSoLuong=b.maxluong
--5.đếm số lượng giáo viên theo từng khoa
select Khoa.MaKhoa,TenKhoa,count(MaGV) as soluong
from Khoa,Giaovien
where Khoa.MaKhoa=GiaoVien.MaKhoa
Group By Khoa.MaKhoa,TenKhoa
--6.đưa ra khoa có so luong giao vien nhieu nhat
