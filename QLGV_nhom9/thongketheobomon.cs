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
            List<SqlParameter> prm = new List<SqlParameter>();
            prm.Add(new SqlParameter("mabomon", cmbBoMon.SelectedValue.ToString().Trim()));
            DataTable dt = a.GetData("select *from GiaoVien where MaBoMon=mabomon", prm);
            dgvTKBoMon.DataSource = dt;
        }
        private void thongketheobomon_Load(object sender, EventArgs e)
        {
            //LoadDSBoMon();
            LoadDSKhoa();
        }
        public void LoadDSKhoa()
        {
            //Load ds khoa

            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
            cmbKhoa.DataSource = a.GetData("select *from Khoa");
            LoadDSBoMon();
        }

        public void LoadDSBoMon()
        {
            //Load DS BoMon
            cmbBoMon.DisplayMember = "TenBoMon";
            cmbBoMon.ValueMember = "MaBoMon";
            List<SqlParameter> prm = new List<SqlParameter>();
            prm.Add(new SqlParameter("makhoa", cmbKhoa.SelectedValue.ToString().Trim()));
            cmbBoMon.DataSource = a.GetData("select *from BoMon where MaKhoa=@makhoa", prm);
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
            //LoadDSBoMon();
            Load_TKBoMon();
            // txtSoGV.Text = CountSogv().ToString();
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
            Load_TKBoMon();
            txtSoGV.Text = CountSogv().ToString();
        }
    }
}
