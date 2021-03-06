﻿using System;
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
    public partial class ThongTinBoMon : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public ThongTinBoMon()
        {
            InitializeComponent();
        }
        public ThongTinBoMon(string mabomon, string tenbomon, string tenkhoa)
        {
            InitializeComponent();
            txtMaBoMon.Text = mabomon;
            txtTenBoMon.Text = tenbomon;
            cmbKhoa.Text = tenkhoa;
            txtMaBoMon.Enabled = false;
        }
        //kiểm tra thông tin khi nhập
        public bool kiem_tra()
        {
            DataTable dt = a.GetData("select *from BoMon");
            if (txtMaBoMon.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã bộ môn!");
                txtMaBoMon.Focus();//đua con tro lại vị trí cần nhập
                return false;
            }
            if (txtMaBoMon.Enabled)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["MaBoMon"].ToString().Trim() == txtMaBoMon.Text.Trim())
                    {
                        MessageBox.Show("mã bộ môn bị trùng.vui lòng nhập lại mã bộ môn!");
                        txtMaBoMon.Focus();
                        return false;
                    }

                }
            }
            if (txtTenBoMon.Text.Trim() == "")//trim oại bỏ khoảng trắng
            {
                MessageBox.Show("Vui lòng nhập tên bộ môn!");
                txtTenBoMon.Focus();
                return false;
            }
            if (cmbKhoa.Text.Trim()=="")
            {
                MessageBox.Show("vui lòng chọn khoa");
                cmbKhoa.Focus();
                return true;
            }
            return true;
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (!kiem_tra()) return;
            // khoi tao danh sach parameter
            List<SqlParameter> listParams = new List<SqlParameter>();
            listParams.Add(new SqlParameter("mabomon", txtMaBoMon.Text.Trim()));
            listParams.Add(new SqlParameter("tenbomon", txtTenBoMon.Text.Trim()));
            listParams.Add(new SqlParameter("makhoa", cmbKhoa.SelectedValue.ToString().Trim()));
            if (txtMaBoMon.Enabled)//Thêm mới
            {
                a.GetDatastoreprocude("thembomon", listParams);
            }
            else //Sửa
            {

                a.GetDatastoreprocude("suabomon", listParams);
            }
            this.Close();
        }

        private void ThongTinBoMon_Load(object sender, EventArgs e)
        {
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
            cmbKhoa.DataSource = a.GetData("select *from Khoa");
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
