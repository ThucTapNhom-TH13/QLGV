namespace QLGV_nhom9
{
    partial class ThongTinBoMon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtTenBoMon = new System.Windows.Forms.TextBox();
            this.txtMaBoMon = new System.Windows.Forms.TextBox();
            this.lblTenBoMon = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblMaBoMon = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnGhiNhan);
            this.panel1.Location = new System.Drawing.Point(35, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 99);
            this.panel1.TabIndex = 10;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(134, 17);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(109, 40);
            this.btnHuyBo.TabIndex = 0;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhiNhan.Location = new System.Drawing.Point(21, 17);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(96, 40);
            this.btnGhiNhan.TabIndex = 0;
            this.btnGhiNhan.Text = "Ghi Nhận";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            this.btnGhiNhan.Click += new System.EventHandler(this.btnGhiNhan_Click);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(125, 95);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoa.TabIndex = 9;
            // 
            // txtTenBoMon
            // 
            this.txtTenBoMon.Location = new System.Drawing.Point(125, 48);
            this.txtTenBoMon.Name = "txtTenBoMon";
            this.txtTenBoMon.Size = new System.Drawing.Size(121, 20);
            this.txtTenBoMon.TabIndex = 7;
            // 
            // txtMaBoMon
            // 
            this.txtMaBoMon.Location = new System.Drawing.Point(125, 17);
            this.txtMaBoMon.Name = "txtMaBoMon";
            this.txtMaBoMon.Size = new System.Drawing.Size(121, 20);
            this.txtMaBoMon.TabIndex = 8;
            // 
            // lblTenBoMon
            // 
            this.lblTenBoMon.AutoSize = true;
            this.lblTenBoMon.Location = new System.Drawing.Point(53, 55);
            this.lblTenBoMon.Name = "lblTenBoMon";
            this.lblTenBoMon.Size = new System.Drawing.Size(66, 13);
            this.lblTenBoMon.TabIndex = 4;
            this.lblTenBoMon.Text = "Tên Bộ Môn";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(53, 103);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 5;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblMaBoMon
            // 
            this.lblMaBoMon.AutoSize = true;
            this.lblMaBoMon.Location = new System.Drawing.Point(53, 24);
            this.lblMaBoMon.Name = "lblMaBoMon";
            this.lblMaBoMon.Size = new System.Drawing.Size(62, 13);
            this.lblMaBoMon.TabIndex = 6;
            this.lblMaBoMon.Text = "Mã Bộ Môn";
            // 
            // ThongTinBoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 256);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.txtTenBoMon);
            this.Controls.Add(this.txtMaBoMon);
            this.Controls.Add(this.lblTenBoMon);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblMaBoMon);
            this.Name = "ThongTinBoMon";
            this.Text = "ThongTinBoMon";
            this.Load += new System.EventHandler(this.ThongTinBoMon_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.TextBox txtTenBoMon;
        private System.Windows.Forms.TextBox txtMaBoMon;
        private System.Windows.Forms.Label lblTenBoMon;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblMaBoMon;

    }
}