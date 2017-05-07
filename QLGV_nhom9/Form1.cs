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
using QLGV_nhom9.Lý_Lịch;
namespace QLGV_nhom9
{
    public partial class frmMain : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public frmMain()
        {
            InitializeComponent();
        }

        public void ShowChild(Form parent, Form child)
        {
            if (parent == null) throw new ArgumentNullException("parent form is null");

            //if (parent.HasChildren)
            //{
            //    foreach (var fi in parent.MdiChildren)
            //    {
            //        if (fi.GetType() != child.GetType()) continue;
            //        fi.MdiParent = parent;
            //        fi.ControlBox = false;
            //        fi.StartPosition = FormStartPosition.CenterScreen;
            //        fi.WindowState = FormWindowState.Normal;
            //        fi.WindowState = FormWindowState.Maximized;
            //        fi.Activate();
            //        return;
            //    }
            //}
            if (parent.HasChildren)
            {
                foreach (var fi in parent.MdiChildren)
                {
                    fi.Close();
                }
            }
            child.MdiParent = parent;
            parent.StartPosition = FormStartPosition.CenterScreen;
            child.ControlBox = false;
            child.WindowState = FormWindowState.Normal;
            child.WindowState = FormWindowState.Maximized;
            child.Show();
            child.Activate();
        }


        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void họcHàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new DanhSachHocHam());
        }

        private void họcVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new DanhSachHocVi());
        }


        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new DanhSachChucVu());
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new DanhSachMonHoc());
        }

        private void toolGiaoVien_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new DanhSach());
        }

        private void toolInKhoa_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new DanhSachKhoa());
        }

        private void toolBoMon_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new DanhSachBoMon());
        }

        private void toolDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void theoBộMônToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new thongketheobomon());
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void theoChứcVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new thongketheochucvu());
        }

        private void theoKhoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new thongketheokhoa());
        }

        private void theoHọcHàmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new thongketheohocham());
        }

        private void theoHọcVịToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new thongketheohocvi());
        }

        private void toolTimKiem_Click(object sender, EventArgs e)
        {
            this.ShowChild(this, new TimKiem());
        }

        private void inẪnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.ShowChild(this, new InAn());
            this.ShowChild(this, new FormLyLichGiaoVien());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://plus.google.com/u/0/101081654093017271632/posts/6X5EQk7FTBX");
        }
    }
}
