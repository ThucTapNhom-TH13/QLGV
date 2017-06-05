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
    public partial class DanhSachHocVi : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public DanhSachHocVi()
        {
            InitializeComponent();
        }
        public void Load_HocVi()
        {
            DataTable dt = a.GetData("select * from HocVi");
            dgvHocVi.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThongTinHocVi x = new ThongTinHocVi();
            x.ShowDialog();
            Load_HocVi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahocvi, tenhocvi, viettat;
            int stt;
            mahocvi = dgvHocVi.CurrentRow.Cells[0].Value.ToString();
            tenhocvi = dgvHocVi.CurrentRow.Cells[1].Value.ToString();
            stt = int.Parse(dgvHocVi.CurrentRow.Cells[2].Value.ToString());
            viettat = dgvHocVi.CurrentRow.Cells[3].Value.ToString();
            ThongTinHocVi x = new ThongTinHocVi(mahocvi, tenhocvi, stt, viettat);
            x.ShowDialog();
            Load_HocVi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quí vị có thực muốn xóa học hàm này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                List<SqlParameter> listParams = new List<SqlParameter>();
                listParams.Add(new SqlParameter("mahocvi", dgvHocVi.CurrentRow.Cells[0].Value.ToString()));


                a.GetDatastoreprocude("xoahocvi", listParams);
            }
            Load_HocVi();
        }

        private void DanhSachHocVi_Load(object sender, EventArgs e)
        {
            Load_HocVi();
        }


    }
}
