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

            InitializeComponent();
            txtMaChucVu.Text = machucvu;
            txtTenChucVu.Text = tenchucvu;
            txtSTT.Text = stt.ToString();
            txtMaChucVu.Enabled = false;

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
            if (!kiem_tra()) return;
            // khoi tao danh sach parameter
            List<SqlParameter> listParams = new List<SqlParameter>();
            listParams.Add(new SqlParameter("machucvu", txtMaChucVu.Text.Trim()));
            listParams.Add(new SqlParameter("tenchucvu", txtTenChucVu.Text.Trim()));

            if (txtMaChucVu.Enabled)//Thêm mới
            {
                a.GetDatastoreprocude
                    ("themchucvu", listParams);
            }
            else //Sửa
            {

                a.GetDatastoreprocude
                    ("suachucvu", listParams);
            }
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
