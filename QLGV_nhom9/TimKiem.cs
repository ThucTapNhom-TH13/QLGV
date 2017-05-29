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
    public partial class TimKiem : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public TimKiem()
        {
            InitializeComponent();
            
        }
        public void Load_GiaoVien()
        {
            DataTable dt = a.GetData("select *from GiaoVien");
            dgvTimKiem.DataSource = dt;
        }
        private void TimKiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLGVDataSet2.GiaoVien' table. You can move, or remove it, as needed.
            // this.giaoVienTableAdapter2.Fill(this.qLGVDataSet2.GiaoVien);

            //this.giaoVienTableAdapter1.Fill(this.qLGVDataSet1.GiaoVien);
            HienThiKhoa();
            LoadDSChucVu();
            //LoadDSBoMon();

            // this.giaoVienTableAdapter.Fill(this.qLGVDataSet.GiaoVien);
            Load_GiaoVien();

        }
       public void HienThiKhoa()
        {
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
            cmbKhoa.DataSource = a.GetData("select *from Khoa");
            LoadDSBoMon();
            cmbKhoa.Text = "";
        }
        public void LoadDSBoMon()
        {
            //Load DS BoMon
            cmbBoMon.DisplayMember = "TenBoMon";
            cmbBoMon.ValueMember = "MaBoMon";
            //List<SqlParameter> prm = new List<SqlParameter>();
            //prm.Add(new SqlParameter("makhoa", cmbKhoa.SelectedValue.ToString().Trim()));
            //cmbBoMon.DataSource = a.GetData("select *from BoMon where MaKhoa=@makhoa", prm);
            cmbBoMon.DataSource = a.GetData("select *from BoMon");
            cmbBoMon.Text = "";
        }
        public void LoadDSChucVu()
        {
            //Load DSChucVu
            cmbChucVu.DisplayMember = "TenChucVu";
            cmbChucVu.ValueMember = "MaChucVu";
            cmbChucVu.DataSource = a.GetData("select *from ChucVu");
            cmbChucVu.Text = "";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<SqlParameter> listParams = new List<SqlParameter>();
            listParams.Add(new SqlParameter("@tengiaovien", txtHoTen.Text.Trim()));
            listParams.Add(new SqlParameter("@quequan", txtQueQuan.Text.Trim()));
            listParams.Add(new SqlParameter("@gioitinh", cmbGioiTinh.Text.Trim()));
            listParams.Add(new SqlParameter("@chucvu", cmbChucVu.Text));
            listParams.Add(new SqlParameter("@khoa", cmbKhoa.Text));
            listParams.Add(new SqlParameter("@bomon", cmbBoMon.Text));

            DataTable dt = a.GetDatastoreprocude
                       ("TimKiem", listParams);
            dgvTimKiem.DataSource = dt;
        }

        private void dgvTimKiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = a.GetData("Select *from GiaoVien");
            dgvTimKiem.DataSource = dt;
            string ma = Convert.ToString(dgvTimKiem.CurrentRow.Cells[0].Value);

        }
    }
}
