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
    public partial class thongketheokhoa : Form
    {

        ChuoiKetNoi a = new ChuoiKetNoi();
        public thongketheokhoa()
        {
            InitializeComponent();
        }
        public void Load_TKKhoa()
        {
            List<SqlParameter> prm = new List<SqlParameter>();
            prm.Add(new SqlParameter("makhoa", cmbKhoa.SelectedValue.ToString().Trim()));
            DataTable dt = a.GetData("select *from GiaoVien where MaKhoa=@makhoa", prm);
            dgvTKKhoa.DataSource = dt;
        }
        private void thongketheokhoa_Load(object sender, EventArgs e)
        {
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
            cmbKhoa.DataSource = a.GetData("select *from Khoa");
        }

        public int CountSogv()
        {
            List<SqlParameter> prm = new List<SqlParameter>();
            prm.Add(new SqlParameter("makhoa", cmbKhoa.SelectedValue.ToString().Trim()));
            DataTable dt = a.GetData("select *from GiaoVien where MaKhoa=@makhoa", prm);
            return dt.Rows.Count;
        }


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Load_TKKhoa();
            txtSoGV.Text = CountSogv().ToString();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
