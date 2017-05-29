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
    public partial class DanhSachKhoa : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public DanhSachKhoa()
        {
            InitializeComponent();
        }

        public void Load_Khoa()
        {
            DataTable dt = a.GetData("SELECT * FROM Khoa");
            dgvKhoa.DataSource = dt;
        }
        private void DanhSachKhoa_Load(object sender, EventArgs e)
        {
            Load_Khoa();
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            ThôngTinKhoa x = new ThôngTinKhoa();
            x.ShowDialog();
            Load_Khoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
