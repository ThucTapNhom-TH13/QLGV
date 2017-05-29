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
    public partial class thongketheohocvi : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public thongketheohocvi()
        {
            InitializeComponent();
        }
        public void Load_TKHocVi()
        {
           
        }
        private void thongketheohocvi_Load(object sender, EventArgs e)
        {
          
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Load_TKHocVi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
