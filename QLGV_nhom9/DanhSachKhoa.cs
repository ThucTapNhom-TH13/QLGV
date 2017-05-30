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
            if (MessageBox.Show("Quí vị có thực muốn xóa Khoa này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                List<SqlParameter> listParams = new List<SqlParameter>();
                listParams.Add(new SqlParameter("@MaKhoa", dgvKhoa.CurrentRow.Cells[0].Value.ToString()));


                a.GetDatastoreprocude("xoakhoa", listParams);
            }
            Load_Khoa();
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            string makhoa, tenkhoa;

            makhoa = dgvKhoa.CurrentRow.Cells[0].Value.ToString();
            tenkhoa = dgvKhoa.CurrentRow.Cells[1].Value.ToString();
            ThôngTinKhoa x = new ThôngTinKhoa(makhoa, tenkhoa);
            x.ShowDialog();
            Load_Khoa();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
