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
    public partial class DanhSachHocHam : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public DanhSachHocHam()
        {
            InitializeComponent();
        }
        public void Load_HocHam()
        {
            DataTable dt = a.GetData("select *from HocHam");
            dgvHocHam.DataSource = dt;
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

        private void DanhSachHocHam_Load(object sender, EventArgs e)
        {
            Load_HocHam();
        }


    }
}
