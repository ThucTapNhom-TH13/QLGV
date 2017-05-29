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
    public partial class ThongTinChucVu : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public ThongTinChucVu()
        {
            InitializeComponent();
        }
        public ThongTinChucVu(string machucvu, string tenchucvu, int stt)
        {
          

        }
        //kiem tra thong tin khi nhap
        public bool kiem_tra()
        {
            DataTable dt = a.GetData("select *from ChucVu");
            if (txtMaChucVu.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã chức vụ!");
                txtMaChucVu.Focus();//đua con tro lại vị trí cần nhập
                return false;
            }
            if (txtMaChucVu.Enabled)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["MaChucVu"].ToString().Trim() == txtMaChucVu.Text.Trim())
                    {
                        MessageBox.Show("mã chức vụ bị trùng.vui lòng nhập lại mã chức vụ!");
                        txtMaChucVu.Focus();
                        return false;
                    }

                }
            }
            if (txtTenChucVu.Text.Trim() == "")//trim oại bỏ khoảng trắng
            {
                MessageBox.Show("Vui lòng nhập tên chức vụ cho giáo viên!");
                txtTenChucVu.Focus();
                return false;
            }
            return true;
        }
        private void ThongTinChucVu_Load(object sender, EventArgs e)
        {

        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
