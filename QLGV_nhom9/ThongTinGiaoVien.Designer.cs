namespace QLGV_nhom9
{
    partial class ThongTinGiaoVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbBoMon = new System.Windows.Forms.ComboBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblBoMon = new System.Windows.Forms.Label();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.txtCMT = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.lblHeSoLuong = new System.Windows.Forms.Label();
            this.lblDanToc = new System.Windows.Forms.Label();
            this.lblCMT = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBoMon
            // 
            this.cmbBoMon.FormattingEnabled = true;
            this.cmbBoMon.Items.AddRange(new object[] {
            "nam",
            "nữ"});
            this.cmbBoMon.Location = new System.Drawing.Point(152, 161);
            this.cmbBoMon.Name = "cmbBoMon";
            this.cmbBoMon.Size = new System.Drawing.Size(159, 21);
            this.cmbBoMon.TabIndex = 32;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(315, 20);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(109, 32);
            this.btnHuyBo.TabIndex = 0;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnGhiNhan);
            this.panel1.Location = new System.Drawing.Point(13, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 72);
            this.panel1.TabIndex = 34;
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhiNhan.Location = new System.Drawing.Point(112, 20);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(109, 32);
            this.btnGhiNhan.TabIndex = 0;
            this.btnGhiNhan.Text = "Ghi Nhận";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            this.btnGhiNhan.Click += new System.EventHandler(this.btnGhiNhan_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(152, 248);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(159, 20);
            this.dtpNgaySinh.TabIndex = 33;
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Location = new System.Drawing.Point(152, 202);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(159, 21);
            this.cmbChucVu.TabIndex = 31;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(152, 301);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(159, 21);
            this.cmbGioiTinh.TabIndex = 30;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(152, 102);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(159, 21);
            this.cmbKhoa.TabIndex = 29;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(152, 60);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(159, 20);
            this.txtTenGV.TabIndex = 27;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(44, 301);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(51, 13);
            this.lblGioiTinh.TabIndex = 13;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(44, 254);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(56, 13);
            this.lblNgaySinh.TabIndex = 14;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(44, 213);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(48, 13);
            this.lblChucVu.TabIndex = 15;
            this.lblChucVu.Text = "Chức Vụ";
            // 
            // lblBoMon
            // 
            this.lblBoMon.AutoSize = true;
            this.lblBoMon.Location = new System.Drawing.Point(44, 161);
            this.lblBoMon.Name = "lblBoMon";
            this.lblBoMon.Size = new System.Drawing.Size(44, 13);
            this.lblBoMon.TabIndex = 16;
            this.lblBoMon.Text = "Bộ Môn";
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Location = new System.Drawing.Point(486, 290);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(130, 20);
            this.txtLuongCoBan.TabIndex = 26;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(486, 247);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(130, 20);
            this.txtHeSoLuong.TabIndex = 25;
            // 
            // txtDanToc
            // 
            this.txtDanToc.Location = new System.Drawing.Point(486, 198);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(130, 20);
            this.txtDanToc.TabIndex = 24;
            // 
            // txtCMT
            // 
            this.txtCMT.Location = new System.Drawing.Point(486, 153);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(130, 20);
            this.txtCMT.TabIndex = 22;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(486, 95);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(130, 20);
            this.txtQueQuan.TabIndex = 23;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(486, 53);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(130, 20);
            this.txtSDT.TabIndex = 28;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(486, 11);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(152, 15);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(159, 20);
            this.txtMaGV.TabIndex = 20;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(44, 105);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 18;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Location = new System.Drawing.Point(44, 65);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(75, 13);
            this.lblTenGV.TabIndex = 17;
            this.lblTenGV.Text = "Tên Giáo Viên";
            // 
            // lblLuongCoBan
            // 
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.Location = new System.Drawing.Point(388, 297);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(74, 13);
            this.lblLuongCoBan.TabIndex = 12;
            this.lblLuongCoBan.Text = "Lương Cơ bản";
            // 
            // lblHeSoLuong
            // 
            this.lblHeSoLuong.AutoSize = true;
            this.lblHeSoLuong.Location = new System.Drawing.Point(388, 254);
            this.lblHeSoLuong.Name = "lblHeSoLuong";
            this.lblHeSoLuong.Size = new System.Drawing.Size(70, 13);
            this.lblHeSoLuong.TabIndex = 11;
            this.lblHeSoLuong.Text = "Hệ Số Lương";
            // 
            // lblDanToc
            // 
            this.lblDanToc.AutoSize = true;
            this.lblDanToc.Location = new System.Drawing.Point(388, 205);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(49, 13);
            this.lblDanToc.TabIndex = 10;
            this.lblDanToc.Text = "Dân Tộc";
            // 
            // lblCMT
            // 
            this.lblCMT.AutoSize = true;
            this.lblCMT.Location = new System.Drawing.Point(388, 161);
            this.lblCMT.Name = "lblCMT";
            this.lblCMT.Size = new System.Drawing.Size(86, 13);
            this.lblCMT.TabIndex = 9;
            this.lblCMT.Text = "Chứng Minh Thư";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(388, 60);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(75, 13);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "Số Điện Thoại";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(388, 102);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(56, 13);
            this.lblQueQuan.TabIndex = 7;
            this.lblQueQuan.Text = "Quê Quán";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(388, 15);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(44, 18);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(71, 13);
            this.lblMaGV.TabIndex = 6;
            this.lblMaGV.Text = "Mã Giáo Viên";
            // 
            // ThongTinGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 425);
            this.Controls.Add(this.cmbBoMon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cmbChucVu);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblBoMon);
            this.Controls.Add(this.txtLuongCoBan);
            this.Controls.Add(this.txtHeSoLuong);
            this.Controls.Add(this.txtDanToc);
            this.Controls.Add(this.txtCMT);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblTenGV);
            this.Controls.Add(this.lblLuongCoBan);
            this.Controls.Add(this.lblHeSoLuong);
            this.Controls.Add(this.lblDanToc);
            this.Controls.Add(this.lblCMT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMaGV);
            this.Name = "ThongTinGiaoVien";
            this.Text = "ThongTinGiaoVien";
            this.Load += new System.EventHandler(this.ThongTinGiaoVien_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoMon;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblBoMon;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.TextBox txtCMT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.Label lblHeSoLuong;
        private System.Windows.Forms.Label lblDanToc;
        private System.Windows.Forms.Label lblCMT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMaGV;


    }
}