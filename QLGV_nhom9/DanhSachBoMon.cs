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
    public partial class DanhSachBoMon : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public DanhSachBoMon()
        {
            InitializeComponent();
        }
        public void Load_BoMon()
        {
            DataTable dt = a.GetData("select * from BoMon");
            dgvBoMon.DataSource = dt;
        }
        public DataRow LoadChiTietBoMon(string mabomon)
        {
            List<SqlParameter> dsParameters = new List<SqlParameter>();
            dsParameters.Add(new SqlParameter("mabomon", mabomon));
            DataTable dt = a.GetData("SELECT * FROM BoMon where MaBoMon=@mabomon", dsParameters);
            if (dt == null || dt.Rows.Count < 1) return null;
            return dt.Rows[0];
        }
        private void btnThemBM_Click(object sender, EventArgs e)
        {
            ThongTinBoMon x = new ThongTinBoMon();
            x.ShowDialog();
            Load_BoMon();
        }

        

        private void btnXoaBM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quí vị có thực muốn xóa bộ môn này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                List<SqlParameter> listParams = new List<SqlParameter>();
                listParams.Add(new SqlParameter("mabomon", dgvBoMon.CurrentRow.Cells[0].Value.ToString()));

                a.GetDatastoreprocude("xoabomon", listParams);
            }
            Load_BoMon();
        }

        private void btnSuaBM_Click(object sender, EventArgs e)
        {
            string mabomon, tenbomon, makhoa;
            mabomon = dgvBoMon.CurrentRow.Cells[0].Value.ToString();
            var ChiTietBM = LoadChiTietBoMon(mabomon);
            tenbomon = ChiTietBM["TenBoMon"].ToString();
            makhoa = ChiTietBM["MaKhoa"].ToString();
            ThongTinBoMon x = new ThongTinBoMon(mabomon, tenbomon, makhoa);
            x.ShowDialog();
            Load_BoMon();
        }
        private void DanhSachBoMon_Load(object sender, EventArgs e)
        {
            Load_BoMon();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvBoMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
