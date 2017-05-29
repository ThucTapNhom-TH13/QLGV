namespace QLGV_nhom9
{
    partial class ThongTinHocHam
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
            this.txtHocHam = new System.Windows.Forms.TextBox();
            this.lblMaHocHam = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.lblSTT = new System.Windows.Forms.Label();
            this.txtTenHocHam = new System.Windows.Forms.TextBox();
            this.lblTenHocHam = new System.Windows.Forms.Label();
            this.txtVietTat = new System.Windows.Forms.TextBox();
            this.lblVietTat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHocHam
            // 
            this.txtHocHam.Location = new System.Drawing.Point(154, 38);
            this.txtHocHam.Name = "txtHocHam";
            this.txtHocHam.Size = new System.Drawing.Size(118, 20);
            this.txtHocHam.TabIndex = 0;
            // 
            // lblMaHocHam
            // 
            this.lblMaHocHam.AutoSize = true;
            this.lblMaHocHam.Location = new System.Drawing.Point(60, 38);
            this.lblMaHocHam.Name = "lblMaHocHam";
            this.lblMaHocHam.Size = new System.Drawing.Size(70, 13);
            this.lblMaHocHam.TabIndex = 1;
            this.lblMaHocHam.Text = "Mã Học Hàm";
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(154, 113);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(118, 20);
            this.txtSTT.TabIndex = 0;
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(60, 113);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(28, 13);
            this.lblSTT.TabIndex = 1;
            this.lblSTT.Text = "STT";
            // 
            // txtTenHocHam
            // 
            this.txtTenHocHam.Location = new System.Drawing.Point(154, 77);
            this.txtTenHocHam.Name = "txtTenHocHam";
            this.txtTenHocHam.Size = new System.Drawing.Size(118, 20);
            this.txtTenHocHam.TabIndex = 0;
            // 
            // lblTenHocHam
            // 
            this.lblTenHocHam.AutoSize = true;
            this.lblTenHocHam.Location = new System.Drawing.Point(60, 77);
            this.lblTenHocHam.Name = "lblTenHocHam";
            this.lblTenHocHam.Size = new System.Drawing.Size(74, 13);
            this.lblTenHocHam.TabIndex = 1;
            this.lblTenHocHam.Text = "Tên Học Hàm";
            // 
            // txtVietTat
            // 
            this.txtVietTat.Location = new System.Drawing.Point(154, 153);
            this.txtVietTat.Name = "txtVietTat";
            this.txtVietTat.Size = new System.Drawing.Size(118, 20);
            this.txtVietTat.TabIndex = 0;
            // 
            // lblVietTat
            // 
            this.lblVietTat.AutoSize = true;
            this.lblVietTat.Location = new System.Drawing.Point(60, 153);
            this.lblVietTat.Name = "lblVietTat";
            this.lblVietTat.Size = new System.Drawing.Size(44, 13);
            this.lblVietTat.TabIndex = 1;
            this.lblVietTat.Text = "Viết Tắt";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnGhiNhan);
            this.panel1.Location = new System.Drawing.Point(-106, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 76);
            this.panel1.TabIndex = 2;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(303, 19);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 23);
            this.btnHuyBo.TabIndex = 0;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.Location = new System.Drawing.Point(169, 19);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(75, 23);
            this.btnGhiNhan.TabIndex = 0;
            this.btnGhiNhan.Text = "Ghi Nhận";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            this.btnGhiNhan.Click += new System.EventHandler(this.btnGhiNhan_Click);
            // 
            // ThongTinHocHam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTenHocHam);
            this.Controls.Add(this.lblVietTat);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.lblMaHocHam);
            this.Controls.Add(this.txtTenHocHam);
            this.Controls.Add(this.txtVietTat);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.txtHocHam);
            this.Name = "ThongTinHocHam";
            this.Text = "ThongTinHocHam";
            this.Load += new System.EventHandler(this.ThongTinHocHam_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHocHam;
        private System.Windows.Forms.Label lblMaHocHam;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.TextBox txtTenHocHam;
        private System.Windows.Forms.Label lblTenHocHam;
        private System.Windows.Forms.TextBox txtVietTat;
        private System.Windows.Forms.Label lblVietTat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnGhiNhan;
    }
}