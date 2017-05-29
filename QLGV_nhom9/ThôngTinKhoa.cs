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
    public partial class ThôngTinKhoa : Form
    {
        ChuoiKetNoi a=new ChuoiKetNoi();
        public ThôngTinKhoa()
        {
            InitializeComponent();
        }

        public ThôngTinKhoa(string makhoa,string tenkhoa)
        {
            InitializeComponent();
            txtMaKhoa.Text = makhoa;
            txtTenKhoa.Text = tenkhoa;
            txtMaKhoa.Enabled = false;//ko cho phep sua
        }
        public bool kiem_tra()
        {
           
            if (txtMaKhoa.Text.Trim() == "")
            {     
                MessageBox.Show("Vui lòng nhập mã khoa!");
                txtMaKhoa.Focus();//đua con tro lại vị trí cần nhập
                return false;
            }
            if (txtMaKhoa.Enabled)
            {
                DataTable dt = a.GetData("select *from Khoa");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["MaKhoa"].ToString().Trim() == txtMaKhoa.Text.Trim())
                    {
                        MessageBox.Show("Mã khoa bị trùng, vui lòng nhập lại mã khoa!");
                        txtMaKhoa.Focus();
                        return false;
                    }

                }
              
            }
            
            if (txtTenKhoa.Text.Trim() == "")//trim loại bỏ khoảng trắng
            {
                MessageBox.Show("Vui lòng nhập tên khoa!");
                txtTenKhoa.Focus();
                return false;
            }
            return true;
        }

        private void ThôngTinKhoa_Load(object sender, EventArgs e)
        {

        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (!kiem_tra()) return;
            // khoi tao danh sach parameter
            List<SqlParameter> listParams = new List<SqlParameter>();
            listParams.Add(new SqlParameter("makhoa", txtMaKhoa.Text.Trim()));
            listParams.Add(new SqlParameter("tenkhoa", txtTenKhoa.Text.Trim()));

            if (txtMaKhoa.Enabled)//Thêm mới
            {
                a.GetDatastoreprocude
                    ("themkhoa", listParams);
            }
            else //Sửa
            {

                a.GetDatastoreprocude
                    ("suakhoa", listParams);
            }
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

