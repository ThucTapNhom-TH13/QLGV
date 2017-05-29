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
using Microsoft.Reporting.WinForms;
using System.IO;
namespace QLGV_nhom9.Lý_Lịch
{
    public partial class FormLyLichGiaoVien : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public FormLyLichGiaoVien()
        {
            InitializeComponent();
        }

        void LoadReportLyLich()
        {
            this.reportViewer1.RefreshReport();
            List<SqlParameter> listParams = new List<SqlParameter>();
            listParams.Add(new SqlParameter("magv", cmbGiaoVien.SelectedValue.ToString().Trim()));
            DataTable tbgv = a.GetData("select * from GiaoVien where MaGV=@magv",listParams);//Them where
            ReportDataSource rps = new ReportDataSource();
            try
            {
                rps = new ReportDataSource("GiaoVien", tbgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable tbkh = a.GetData("select * from Khoa ");
            ReportDataSource rps1 = new ReportDataSource("Khoa", tbkh);
            DataTable tbbm = a.GetData("select * from BoMon ");
            ReportDataSource rps2 = new ReportDataSource("BoMon", tbbm);




            List<SqlParameter> listPara = new List<SqlParameter>();
            listPara.Add(new SqlParameter("@magiaovien", cmbGiaoVien.SelectedValue.ToString().Trim()));
            DataTable dt = a.GetDatastoreprocude("InAnHocVi", listPara);
            ReportDataSource rps4 = new ReportDataSource("InAnHocVi", dt);


            List<SqlParameter> listPara1 = new List<SqlParameter>();
            listPara1.Add(new SqlParameter("@magiaovien", cmbGiaoVien.SelectedValue.ToString().Trim()));
            DataTable dt1 = a.GetDatastoreprocude("InAnHocHam", listPara1);
            ReportDataSource rps5 = new ReportDataSource("InAnHocHam", dt1);

            this.reportViewer1.LocalReport.ReportPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Lý lịch\\LyLichGiaoVien.rdlc"; ;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rps);
            this.reportViewer1.LocalReport.DataSources.Add(rps1);
            this.reportViewer1.LocalReport.DataSources.Add(rps2);
            this.reportViewer1.LocalReport.DataSources.Add(rps4);
            this.reportViewer1.LocalReport.DataSources.Add(rps5);
            //this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void FormLyLichGiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetGiaoVien.GiaoVien' table. You can move, or remove it, as needed.
            LoadDSKhoa();
            LoadDSGiaoVien();
          
          
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
        public void LoadDSGiaoVien()
        {
            cmbGiaoVien.ResetText();
            cmbGiaoVien.DisplayMember = "TenGiaoVien";
            cmbGiaoVien.ValueMember = "MaGV";
            List<SqlParameter> prm = new List<SqlParameter>();
            prm.Add(new SqlParameter("mabomon", cmbBoMon.SelectedValue.ToString().Trim()));
           
            cmbGiaoVien.DataSource = a.GetData("select *from GiaoVien where MaBoMon=@mabomon ", prm);
           
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
          
            LoadReportLyLich();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSBoMon();
        }

        private void cmbBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSGiaoVien();
           
        }

    }
}
