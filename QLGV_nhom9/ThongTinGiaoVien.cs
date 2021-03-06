﻿                                                       using System;
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
    public partial class ThongTinGiaoVien : Form
    {
        ChuoiKetNoi a = new ChuoiKetNoi();
        public ThongTinGiaoVien()
        {
            InitializeComponent();
        }
        public ThongTinGiaoVien(string magv, string tengv, DateTime ngaysinh, string gioitinh, string dantoc, string email, string quequan, string bomon, string khoa, string chucvu, string sdt, string scmt, double hesoluong,double luongcoban)
        {
            InitializeComponent();
            //Hiển thị trên giao diện
            txtMaGV.Text = magv;
            txtTenGV.Text = tengv;
            txtQueQuan.Text = quequan;
            txtEmail.Text = email;
            txtDanToc.Text = dantoc;
            cmbKhoa.Text = khoa;
            cmbGioiTinh.Text = gioitinh;
            cmbChucVu.Text = chucvu;
            txtHeSoLuong.Text = hesoluong.ToString();
            txtLuongCoBan.Text = luongcoban.ToString();
            txtCMT.Text = scmt;
            txtSDT.Text = sdt;
            dtpNgaySinh.Text = ngaysinh.ToString();
            cmbBoMon.Text = bomon;
            txtMaGV.Enabled = false;//ko cho phep sua
        }


        //kiểm tra thông tin khi nhập
        public bool KiemTra()
        {
            DataTable dt = a.GetData("select *from GiaoVien");
            if(cmbGioiTinh.Text.ToString().Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập giới tính!");
                cmbGioiTinh.Focus();//đua con tro lại vị trí cần nhập
                return false;
            }
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã giáo viên !");
                txtMaGV.Focus();//đua con tro lại vị trí cần nhập
                return false;
            }
            if (txtMaGV.Enabled)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["MaGV"].ToString().Trim().ToUpper() == txtMaGV.Text.Trim().ToUpper())
                    {
                        MessageBox.Show("mã giáo viên bị trùng.vui lòng nhập lại mã giáo viên!");
                        txtMaGV.Focus();
                        return false;
                    }

                }
            }
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (dt.Rows[i]["SoCMT"].ToString().Trim() == txtCMT.Text.Trim())
            //    {
            //        MessageBox.Show("Số CMT này có có người dùng, bạn vui vòng kiểm tra lại!");
            //        txtCMT.Focus();
            //        return false;
            //    }
            //}
            
                if (txtTenGV.Text.Trim() == "")//trim oại bỏ khoảng trắng
                {
                    MessageBox.Show("Vui lòng nhập họ tên giáo  viên!");
                    txtTenGV.Focus();
                    return false;
                }
                //kiểm tra hệ số lương
                double d;
                if (double.TryParse(txtHeSoLuong.Text.Trim(), out d))//cố gắng convert.nếu dc thì gán cho d
                {
                    if (d < 0 )
                    {
                        MessageBox.Show("hệ số lương không hợp lệ");
                        txtHeSoLuong.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("hệ số lương không hợp lệ. Vui lòng chỉ nhập số!");
                    txtHeSoLuong.Focus();
                    return false;
                }
            //kiểm tra số điện thoại
                int e;
                if (int.TryParse(txtSDT.Text.Trim(), out e))//cố gắng convert.nếu dc thì gán cho d
                {
                    if(e<0)
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng chỉ nhập số!");
                        txtSDT.Focus();
                        return false;
                    }                 
                } 
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng chỉ nhập số!");
                    txtSDT.Focus();
                    return false;
                }
            //kiem tra luong co ban
                if (double.TryParse(txtLuongCoBan.Text.Trim(), out d))//cố gắng convert.nếu dc thì gán cho d
                {
                    if (d < 0)
                    {
                        MessageBox.Show("Lương cơ bản không hợp lệ");
                        txtLuongCoBan.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Lương cơ bản không hợp lệ. Vui lòng chỉ nhập số!");
                    txtLuongCoBan.Focus();
                    return false;
                }
            return true;
        }


        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;

            List<SqlParameter> listParams = new List<SqlParameter>();
            listParams.Add(new SqlParameter("magv", txtMaGV.Text.Trim()));
            listParams.Add(new SqlParameter("tengiaovien", txtTenGV.Text.Trim()));
            listParams.Add(new SqlParameter("makhoa", cmbKhoa.SelectedValue.ToString().Trim()));
            listParams.Add(new SqlParameter("gioitinh", cmbGioiTinh.Text.Trim()));
            listParams.Add(new SqlParameter("machucvu", cmbChucVu.SelectedValue.ToString().Trim()));
            listParams.Add(new SqlParameter("email", txtEmail.Text.Trim()));
            listParams.Add(new SqlParameter("quequan", txtQueQuan.Text.Trim()));
            listParams.Add(new SqlParameter("dantoc", txtDanToc.Text.Trim()));
            listParams.Add(new SqlParameter("hesoluong", double.Parse(txtHeSoLuong.Text.Trim())));
            listParams.Add(new SqlParameter("sdt", txtSDT.Text.Trim()));
            listParams.Add(new SqlParameter("cmt", txtCMT.Text.Trim()));
            listParams.Add(new SqlParameter("ngaysinh", dtpNgaySinh.Value));
            listParams.Add(new SqlParameter("mabomon", cmbBoMon.SelectedValue.ToString().Trim()));

            listParams.Add(new SqlParameter("luongcoban", int.Parse(txtLuongCoBan.Text.Trim())));
            if (txtMaGV.Enabled)//Thêm mới
            {
                a.ExcecuteProcedure
                    ("themgiaovien", listParams);
            }
            else //Sửa
            {
                a.ExcecuteProcedure
                    ("suagiaovien", listParams);
            }
            this.Close();
        }

        private void ThongTinGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDSKhoa();
            LoadDSChucVu();

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSBoMon();
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

        public void LoadDSChucVu()
        {
            //Load DSChucVu
            cmbChucVu.DisplayMember = "TenChucVu";
            cmbChucVu.ValueMember = "MaChucVu";
            cmbChucVu.DataSource = a.GetData("select *from ChucVu");
        }
    }
}
