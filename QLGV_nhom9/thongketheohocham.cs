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
    public partial class thongketheohocham : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public thongketheohocham()
        {
            InitializeComponent();
        }
        public void Load_TKHocHam()
        {
            List<SqlParameter> prm = new List<SqlParameter>();
            prm.Add(new SqlParameter("mahocham", cmbHocHam.SelectedValue.ToString().Trim()));
            DataTable dt = a.GetData("select *from GiaoVien where  MaGV in (select MaGV from GV_HH where MaHocHam=@mahocham )", prm);
            dgvTKHocHam.DataSource = dt;
        }
        private void thongketheohocham_Load(object sender, EventArgs e)
        {
            cmbHocHam.DisplayMember = "TenHocHam";
            cmbHocHam.ValueMember = "MaHocHam";
            cmbHocHam.DataSource = a.GetData("select *from HocHam");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Load_TKHocHam();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
