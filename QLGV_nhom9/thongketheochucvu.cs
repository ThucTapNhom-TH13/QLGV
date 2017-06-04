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
    public partial class thongketheochucvu : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public thongketheochucvu()
        {
            InitializeComponent();
        }
        public void Load_TKChucVu()
        {
            List<SqlParameter> prm = new List<SqlParameter>();
            prm.Add(new SqlParameter("machucvu", cmbChucVu.SelectedValue.ToString().Trim()));
            DataTable dt = a.GetData("select *from GiaoVien where MaChucVu=@machucvu", prm);
            dgvTKChucVu.DataSource = dt;
        }
        private void thongketheochucvu_Load(object sender, EventArgs e)
        {
            cmbChucVu.DisplayMember = "TenChucVu";
            cmbChucVu.ValueMember = "MaChucVu";
            cmbChucVu.DataSource = a.GetData("select *from ChucVu");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Load_TKChucVu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
