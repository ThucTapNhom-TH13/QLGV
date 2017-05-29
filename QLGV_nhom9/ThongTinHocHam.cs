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
    public partial class ThongTinHocHam : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public ThongTinHocHam()
        {
            InitializeComponent();
        }

        public ThongTinHocHam(string mahocham,string tenhocham,int stt,string viettat)
        {
            InitializeComponent();
            txtHocHam.Text = mahocham;
            txtTenHocHam.Text = tenhocham;
            txtSTT.Text = stt.ToString();
            txtVietTat.Text = viettat;
            txtHocHam.Enabled = false;
        }
        //kiem tra thong tin nhap
        public bool kiem_tra()
        {
            DataTable dt = a.GetData("select *from HocHam");
            if (txtHocHam.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã học hàm!");
                txtHocHam.Focus();//đua con tro lại vị trí cần nhập
                return false;
            }
            if (txtHocHam.Enabled)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["MaHocHam"].ToString().Trim() == txtHocHam.Text.Trim())
                    {
                        MessageBox.Show("mã học hàm bị trùng.vui lòng nhập lại mã học hàm!");
                        txtHocHam.Focus();
                        return false;
                    }

                }
            }

            if (txtTenHocHam.Text.Trim() == "")//trim oại bỏ khoảng trắng
            {
                MessageBox.Show("Vui lòng nhập ten học hàm!");
                txtTenHocHam.Focus();
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
            listParams.Add(new SqlParameter("mahocham", txtHocHam.Text.Trim()));
            listParams.Add(new SqlParameter("tenhocham", txtTenHocHam.Text.Trim()));
            listParams.Add(new SqlParameter("viettat", txtVietTat.Text.Trim()));
            //listParams.Add(new SqlParameter("STT", int.Parse(txtSTT.Text.Trim())));
            if (txtHocHam.Enabled)//Thêm mới
            {
                a.GetDatastoreprocude
                    ("themhocham", listParams);
            }
            else //Sửa
            {
                a.GetDatastoreprocude
                    ("suahocham", listParams);
            }
            this.Close();
        }

        private void ThongTinHocHam_Load(object sender, EventArgs e)
        {

        }
    }
}
