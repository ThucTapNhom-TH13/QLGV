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
            if (!kiem_tra()) return;
            //Khởi tạo danh sách parameter
            List<SqlParameter> listParams = new List<SqlParameter>();
            listParams.Add(new SqlParameter("mahocvi", txtHocVi.Text.Trim()));
            listParams.Add(new SqlParameter("tenhocvi", txtTenHocVi.Text.Trim()));
            listParams.Add(new SqlParameter("viettat", txtVietTat.Text.Trim()));
            //listParams.Add(new SqlParameter("STT", int.Parse(txtSTT.Text.Trim())));
            if (txtHocVi.Enabled)//Thêm mới
            {
                a.GetDatastoreprocude
                    ("themhocvi", listParams);
            }
            else //Sửa
            {
                a.GetDatastoreprocude
                    ("suahocvi", listParams);
            }
            this.Close();
        }

        private void ThongTinHocVi_Load(object sender, EventArgs e)
        {

        }
    }
}
