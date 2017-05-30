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
    public partial class DanhSachChucVu : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public DanhSachChucVu()
        {
            InitializeComponent();
        }
        public void Load_ChucVu()
        {
            DataTable dt = a.GetData("select*from ChucVu");
            dgvChucVu.DataSource = dt;
        }
        private void btnThemCV_Click(object sender, EventArgs e)
        {
            ThongTinChucVu x = new ThongTinChucVu();
            x.ShowDialog();
            Load_ChucVu();

        }

        private void btnSuaCV_Click(object sender, EventArgs e)
        {
            string machucvu, tenchucvu;
            int stt;

            machucvu = dgvChucVu.CurrentRow.Cells[1].Value.ToString();
            tenchucvu = dgvChucVu.CurrentRow.Cells[2].Value.ToString();
            stt = int.Parse(dgvChucVu.CurrentRow.Cells[0].Value.ToString());
            ThongTinChucVu x = new ThongTinChucVu(machucvu, tenchucvu, stt);
            x.ShowDialog();
            Load_ChucVu();
        }

        private void btnXoaCV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực muốn xóa Chức Vụ này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                List<SqlParameter> listParams = new List<SqlParameter>();
                listParams.Add(new SqlParameter("machucvu", dgvChucVu.CurrentRow.Cells[1].Value.ToString()));

                a.GetDatastoreprocude("xoachucvu", listParams);
            }
            Load_ChucVu();
        }

        private void DanhSachChucVu_Load(object sender, EventArgs e)
        {
            Load_ChucVu();
        }
    }
}
