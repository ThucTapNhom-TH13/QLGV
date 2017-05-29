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
    public partial class DanhSachHocVi : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public DanhSachHocVi()
        {
            InitializeComponent();
        }
        public void Load_HocVi()
        {
            DataTable dt = a.GetData("select *from HocVi");
            dgvHocVi.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void DanhSachHocVi_Load(object sender, EventArgs e)
        {
            Load_HocVi();
        }


    }
}
