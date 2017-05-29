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
    public partial class thongketheohocham : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public thongketheohocham()
        {
            InitializeComponent();
        }
        public void Load_TKHocHam()
        {
         
        }
        private void thongketheohocham_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Load_TKHocHam();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
