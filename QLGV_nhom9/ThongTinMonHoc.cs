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
    public partial class ThongTinMonHoc : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public ThongTinMonHoc()
        {
            InitializeComponent();
        }
        public ThongTinMonHoc(string mamonhoc,string tenmonhoc,int sotinchi,string mabomon)
        {
            InitializeComponent();
            txtMaMonHoc.Text = mamonhoc;
            txtTenMonHoc.Text = tenmonhoc;
            cmbBoMon.Text = mabomon;
            txtSoTinChi.Text = sotinchi.ToString();
            txtMaMonHoc.Enabled = false;
        }
        private void ThongTinMonHoc_Load(object sender, EventArgs e)
        {
            cmbBoMon.DisplayMember = "TenBoMon";
            cmbBoMon.ValueMember = "MaBoMon";
            cmbBoMon.DataSource = a.GetData("select *from BoMon");
        }
        public bool kiem_tra()
        {
            DataTable dt = a.GetData("select *from MonHoc");
            if (txtMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã môn học!");
                txtMaMonHoc.Focus();//đua con tro lại vị trí cần nhập
                return false;
            }
            if (txtMaMonHoc.Enabled)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["MaMonHoc"].ToString().Trim() == txtMaMonHoc.Text.Trim())
                    {
                        MessageBox.Show("đã tồn tại mã môn học.vui lòng nhập lại mã môn học!");
                        txtMaMonHoc.Focus();
                        return false;
                    }
                }
            }
                if (txtTenMonHoc.Text.Trim() == "")//trim oại bỏ khoảng trắng
                {
                    MessageBox.Show("Vui lòng nhập tên môn học!");
                    txtTenMonHoc.Focus();
                    return false;
                }


            if (txtSoTinChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số tín chỉ!");
                txtSoTinChi.Focus();
                return false;
            }

            if (cmbBoMon.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn một bộ môn!");
                cmbBoMon.Focus();
                return false;
            }
            return true;
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (!kiem_tra()) return;
            //Khởi tạo danh sách parameter
            List<SqlParameter> listParams = new List<SqlParameter>();
            listParams.Add(new SqlParameter("mamonhoc", txtMaMonHoc.Text.Trim()));
            listParams.Add(new SqlParameter("tenmonhoc", txtTenMonHoc.Text.Trim()));
            listParams.Add(new SqlParameter("stc", int.Parse(txtSoTinChi.Text.Trim())));
            listParams.Add(new SqlParameter("mabomon", cmbBoMon.SelectedValue.ToString().Trim()));

            if (txtMaMonHoc.Enabled)//Thêm mới
            {
                a.GetDatastoreprocude("themmonhoc", listParams);
            }
            else //Sửa
            {
                a.GetDatastoreprocude("suamonhoc", listParams);
            }
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
