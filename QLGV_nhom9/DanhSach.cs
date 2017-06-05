using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLGV_nhom9
{
    public partial class DanhSach : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public DanhSach()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThongTinGiaoVien x = new ThongTinGiaoVien();
            x.ShowDialog();
            Load_GiaoVien();
        }
        public void Load_GiaoVien()
        {
            DataTable dt = a.GetData("Select * from Giaovien");
            dgvGiaoVien.DataSource = dt;
        }

        public DataRow LoadChiTietGiaoVien(string maGiaoVien)
        {
            List<SqlParameter> dsParameters=new List<SqlParameter>();
            dsParameters.Add(new SqlParameter("MaGiaoVien",maGiaoVien));
            DataTable dt = a.GetData("SELECT * FROM GiaoVien where MaGV=@MaGiaoVien", dsParameters);
            if (dt == null || dt.Rows.Count < 1) return null;
            return dt.Rows[0];
        }
        
        private void DanhSach_Load(object sender, EventArgs e)
        {
            Load_GiaoVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string magv, tengv, sdt, dantoc, email, quequan, khoa, bomon, chucvu, gioitinh, scmt;
            DateTime ngaysinh;
            double hesoluong, luongcoban;

            magv = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
            //Thay bằng cách lấy thông tin khác
            var chiTietGV = LoadChiTietGiaoVien(magv);
            tengv = chiTietGV["TenGiaoVien"].ToString();
            ngaysinh = DateTime.Parse(chiTietGV["NgaySinh"].ToString());
            gioitinh = chiTietGV["GioiTinh"].ToString();
            dantoc = chiTietGV["DanToc"].ToString();
            email = chiTietGV["Email"].ToString();
            quequan = chiTietGV["quequan"].ToString();
            bomon = chiTietGV["MaBoMon"].ToString();
            khoa = chiTietGV["MaKhoa"].ToString();
            chucvu = chiTietGV["MaChucVu"].ToString();
            sdt = chiTietGV["SoDienThoai"].ToString();
            scmt = chiTietGV["SoCMT"].ToString();
            if (chiTietGV["HeSoLuong"].ToString().Trim() == "")
            {
                hesoluong = 0;
            }
            else
                hesoluong = double.Parse(chiTietGV["HeSoLuong"].ToString());

            luongcoban = double.Parse(chiTietGV["LuongCoBan"].ToString());
            ThongTinGiaoVien x = new ThongTinGiaoVien(magv, tengv, ngaysinh, gioitinh, dantoc, email, quequan, bomon, khoa, chucvu, sdt, scmt, hesoluong, luongcoban);
            x.ShowDialog();
            Load_GiaoVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quí vị có thực muốn xóa giáo viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                List<SqlParameter> listParams = new List<SqlParameter>();
                listParams.Add(new SqlParameter("magv", dgvGiaoVien.CurrentRow.Cells[0].Value.ToString()));

                a.GetDatastoreprocude("xoagiaovien", listParams);
            }
            Load_GiaoVien();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

            ThongTinGiaoVien x = new ThongTinGiaoVien();
            x.ShowDialog();
            Load_GiaoVien();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            listPara.Add(new SqlParameter("@key", txtTimKiem.Text.Trim()));
            DataTable dt = a.GetDatastoreprocude("TimKiemGiaoVien", listPara);
            dgvGiaoVien.DataSource = dt;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            listPara.Add(new SqlParameter("@key", txtTimKiem.Text.Trim()));
            DataTable dt = a.GetDatastoreprocude("LocNhanhGiaoVien", listPara);
            dgvGiaoVien.DataSource = dt;
        }
       
    }
}
