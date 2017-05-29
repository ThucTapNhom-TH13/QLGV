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
    public partial class ThongTinHocVi : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public ThongTinHocVi()
        {
            InitializeComponent();
        }
        public ThongTinHocVi(string mahocvi, string tenhocvi,int stt,string viettat)
        {
           
        }
        //kiem tra thong tin khi nhap
        public bool kiem_tra()
        {
            DataTable dt = a.GetData("select *from HocVi");
            if (txtHocVi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã học vị!");
                txtHocVi.Focus();//đua con tro lại vị trí cần nhập
                return false;
            }
            if (txtHocVi.Enabled)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["MaHocVi"].ToString().Trim() == txtHocVi.Text.Trim())
                    {
                        MessageBox.Show("mã học vị bị trùng.vui lòng nhập lại mã học vị!");
                        txtHocVi.Focus();
                        return false;
                    }

                }
            }

            if (txtTenHocVi.Text.Trim() == "")//trim oại bỏ khoảng trắng
            {
                MessageBox.Show("Vui lòng nhập ten học vị!");
                txtTenHocVi.Focus();
                return false;
            }
            return true;
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
           
        }

        private void ThongTinHocVi_Load(object sender, EventArgs e)
        {

        }
    }
}
