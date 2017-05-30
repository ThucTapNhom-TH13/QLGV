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
    public partial class DanhSachMonHoc : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public DanhSachMonHoc()
        {
            InitializeComponent();
        }
        public void Load_MonHoc()
        {
            DataTable dt = a.GetData("select*from MonHoc");
            dgvMonHoc.DataSource = dt;
        }
        private void btnThemMH_Click(object sender, EventArgs e)
        {
            ThongTinMonHoc x = new ThongTinMonHoc();
            x.ShowDialog();
            Load_MonHoc();
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            string mamonhoc, tenmonhoc, mabomon;
            int sotinchi;
            mamonhoc = dgvMonHoc.CurrentRow.Cells[0].Value.ToString();
            tenmonhoc = dgvMonHoc.CurrentRow.Cells[2].Value.ToString();
            sotinchi = int.Parse(dgvMonHoc.CurrentRow.Cells[3].Value.ToString());
            mabomon = dgvMonHoc.CurrentRow.Cells[1].Value.ToString();
            ThongTinMonHoc x = new ThongTinMonHoc(mamonhoc, tenmonhoc, sotinchi, mabomon);
            x.ShowDialog();
            Load_MonHoc();
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quí vị có thực muốn xóa môn  này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                List<SqlParameter> listParams = new List<SqlParameter>();
                listParams.Add(new SqlParameter("@mamonhoc", dgvMonHoc.CurrentRow.Cells[0].Value.ToString()));

                a.GetDatastoreprocude("xoamonhoc", listParams);
            }
            Load_MonHoc();
        }

        private void DanhSachMonHoc_Load(object sender, EventArgs e)
        {
            Load_MonHoc();

        }

        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
