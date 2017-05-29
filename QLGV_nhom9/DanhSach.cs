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
    public partial class DanhSach : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public DanhSach()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThongTinGiaoVien x = new ThongTinGiaoVien();
            x.ShowDialog();
            Load_GiaoVien();
        }
        public void Load_GiaoVien()
        {
           
        }

        public DataRow LoadChiTietGiaoVien(string maGiaoVien)
        {
            List<SqlParameter> dsParameters=new List<SqlParameter>();
            dsParameters.Add(new SqlParameter("MaGiaoVien",maGiaoVien));
            DataTable dt = a.GetData("SELECT * FROM GiaoVien where MaGV=@MaGiaoVien", dsParameters);
            if (dt == null || dt.Rows.Count < 1) return null;
            return dt.Rows[0];
        }
        
        private void DanhSach_Load(object sender, EventArgs e)
        {
            Load_GiaoVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
          
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
                 
        }
       
    }
}
