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
            
        }

        private void btnSuaBM_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoaBM_Click(object sender, EventArgs e)
        {
           
        }

        private void DanhSachBoMon_Load(object sender, EventArgs e)
        {
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvBoMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
