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
    public partial class DanhSachHocHam : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public DanhSachHocHam()
        {
            InitializeComponent();
        }
        public void Load_HocHam()
        {
            DataTable dt = a.GetData("select *from HocHam");
            dgvHocHam.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThongTinHocHam x = new ThongTinHocHam();
            x.ShowDialog();
            Load_HocHam();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahocham, tenhocham, viettat;
            int stt;
            mahocham = dgvHocHam.CurrentRow.Cells[0].Value.ToString();
            tenhocham = dgvHocHam.CurrentRow.Cells[1].Value.ToString();
            stt = int.Parse(dgvHocHam.CurrentRow.Cells[2].Value.ToString());
            viettat = dgvHocHam.CurrentRow.Cells[3].Value.ToString();
            ThongTinHocHam x = new ThongTinHocHam(mahocham, tenhocham, stt, viettat);
            x.ShowDialog();
            Load_HocHam();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quí vị có thực muốn xóa học hàm này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                List<SqlParameter> listParams = new List<SqlParameter>();
                listParams.Add(new SqlParameter("mahocham", dgvHocHam.CurrentRow.Cells[0].Value.ToString()));


                a.GetDatastoreprocude("xoahocham", listParams);
            }
            Load_HocHam();
        }

        private void DanhSachHocHam_Load(object sender, EventArgs e)
        {
            Load_HocHam();
        }


    }
}
