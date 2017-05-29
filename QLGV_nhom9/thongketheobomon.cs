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
    public partial class thongketheobomon : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public thongketheobomon()
        {
            InitializeComponent();
        }
        public void Load_TKBoMon()
        {        
           
        }
        private void thongketheobomon_Load(object sender, EventArgs e)
        {
            //LoadDSBoMon();
            LoadDSKhoa();
        }
        public void LoadDSKhoa()
        {
         
        }

        public void LoadDSBoMon()
        {
           
        }
        public int CountSogv()
        {
            List<SqlParameter> prm = new List<SqlParameter>();
            prm.Add(new SqlParameter("mabomon", cmbBoMon.SelectedValue.ToString().Trim()));
            DataTable dt = a.GetData("select *from GiaoVien where MaBoMon=@mabomon", prm);
            return dt.Rows.Count;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongKeBM_Click(object sender, EventArgs e)
        {
           
        }
    }
}
