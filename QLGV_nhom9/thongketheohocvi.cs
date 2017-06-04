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
    public partial class thongketheohocvi : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public thongketheohocvi()
        {
            InitializeComponent();
        }
        public void Load_TKHocVi()
        {
            List<SqlParameter> prm = new List<SqlParameter>();
            prm.Add(new SqlParameter("mahocvi", cmbHocVi.SelectedValue.ToString().Trim()));
            DataTable dt = a.GetData("select *from GiaoVien where  MaGV in (select MaGV from QuaTrinhDaoTao where MaHocVi=@mahocvi )", prm);
            dgvTKHocVi.DataSource = dt;
        }
        private void thongketheohocvi_Load(object sender, EventArgs e)
        {
            cmbHocVi.DisplayMember = "TenHocVi";
            cmbHocVi.ValueMember = "MaHocVi";
            cmbHocVi.DataSource = a.GetData("select *from HocVi");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Load_TKHocVi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
