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
    public partial class InAn : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public InAn()
        {
            InitializeComponent();
        }
        private void Load_HocVi()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            listPara.Add(new SqlParameter("@magiaovien", txtMaGV.Text.Trim()));
            DataTable dt = a.GetDatastoreprocude("InAnHocVi", listPara);
            dgvHocVi.DataSource = dt;
        }
        private void Load_HocHam()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            listPara.Add(new SqlParameter("@magiaovien", txtMaGV.Text.Trim()));
            DataTable dt = a.GetDatastoreprocude("InAnHocHam", listPara);
            dgvHocHam.DataSource = dt;
        }
        private void Load_MonHoc()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            listPara.Add(new SqlParameter("@magiaovien", txtMaGV.Text.Trim()));
            DataTable dt = a.GetDatastoreprocude("InAnMonHoc", listPara);
            dgvMonHoc.DataSource = dt;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            Load_HocVi();
            Load_HocHam();
            Load_MonHoc();
            List<SqlParameter> listPara = new List<SqlParameter>();
            listPara.Add(new SqlParameter("@magiaovien", txtMaGV.Text.Trim()));
            DataTable dt = a.GetDatastoreprocude("InAn", listPara);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["MaGV"].ToString().Trim() == txtMaGV.Text.Trim())
                {
                    txtTenGiaoVien.Text = dt.Rows[i]["TenGiaoVien"].ToString();
                    txtQueQuan.Text = dt.Rows[i]["quequan"].ToString();
                    txtNgaySinh.Text = dt.Rows[i]["NgaySinh"].ToString();
                    txtGioiTinh.Text = dt.Rows[i]["GioiTinh"].ToString();
                    txtChucVu.Text = dt.Rows[i]["TenChucVu"].ToString();
                    txtDanToc.Text = dt.Rows[i]["DanToc"].ToString();
                    txtEmail.Text = dt.Rows[i]["Email"].ToString();
                    txtSDT.Text = dt.Rows[i]["SoDienThoai"].ToString();
                    txtKhoa.Text = dt.Rows[i]["TenKhoa"].ToString();
                    txtBoMon.Text = dt.Rows[i]["TenBoMon"].ToString();
                    break;
                }
            }
        }

        private void InAn_Load(object sender, EventArgs e)
        {
            Load_HocVi();
            Load_HocHam();
            Load_MonHoc();
        }
    }
}
