namespace QLGV_nhom9
{
    partial class ThongTinHocVi
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
            this.lblTenHocVi = new System.Windows.Forms.Label();
            this.lblVietTat = new System.Windows.Forms.Label();
            this.lblSTT = new System.Windows.Forms.Label();
            this.lblMaHocVi = new System.Windows.Forms.Label();
            this.txtTenHocVi = new System.Windows.Forms.TextBox();
            this.txtVietTat = new System.Windows.Forms.TextBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.txtHocVi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnGhiNhan);
            this.panel1.Location = new System.Drawing.Point(-43, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 76);
            this.panel1.TabIndex = 11;
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
            // lblTenHocVi
            // 
            this.lblTenHocVi.AutoSize = true;
            this.lblTenHocVi.Location = new System.Drawing.Point(123, 61);
            this.lblTenHocVi.Name = "lblTenHocVi";
            this.lblTenHocVi.Size = new System.Drawing.Size(61, 13);
            this.lblTenHocVi.TabIndex = 7;
            this.lblTenHocVi.Text = "Tên Học Vị";
            // 
            // lblVietTat
            // 
            this.lblVietTat.AutoSize = true;
            this.lblVietTat.Location = new System.Drawing.Point(123, 137);
            this.lblVietTat.Name = "lblVietTat";
            this.lblVietTat.Size = new System.Drawing.Size(44, 13);
            this.lblVietTat.TabIndex = 8;
            this.lblVietTat.Text = "Viết Tắt";
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(123, 97);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(28, 13);
            this.lblSTT.TabIndex = 9;
            this.lblSTT.Text = "STT";
            // 
            // lblMaHocVi
            // 
            this.lblMaHocVi.AutoSize = true;
            this.lblMaHocVi.Location = new System.Drawing.Point(123, 22);
            this.lblMaHocVi.Name = "lblMaHocVi";
            this.lblMaHocVi.Size = new System.Drawing.Size(57, 13);
            this.lblMaHocVi.TabIndex = 10;
            this.lblMaHocVi.Text = "Mã Học Vị";
            // 
            // txtTenHocVi
            // 
            this.txtTenHocVi.Location = new System.Drawing.Point(217, 61);
            this.txtTenHocVi.Name = "txtTenHocVi";
            this.txtTenHocVi.Size = new System.Drawing.Size(118, 20);
            this.txtTenHocVi.TabIndex = 3;
            // 
            // txtVietTat
            // 
            this.txtVietTat.Location = new System.Drawing.Point(217, 137);
            this.txtVietTat.Name = "txtVietTat";
            this.txtVietTat.Size = new System.Drawing.Size(118, 20);
            this.txtVietTat.TabIndex = 4;
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(217, 97);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(118, 20);
            this.txtSTT.TabIndex = 5;
            // 
            // txtHocVi
            // 
            this.txtHocVi.Location = new System.Drawing.Point(217, 22);
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Size = new System.Drawing.Size(118, 20);
            this.txtHocVi.TabIndex = 6;
            // 
            // ThongTinHocVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 296);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTenHocVi);
            this.Controls.Add(this.lblVietTat);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.lblMaHocVi);
            this.Controls.Add(this.txtTenHocVi);
            this.Controls.Add(this.txtVietTat);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.txtHocVi);
            this.Name = "ThongTinHocVi";
            this.Text = "ThongTinHocVi";
            this.Load += new System.EventHandler(this.ThongTinHocVi_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.Label lblTenHocVi;
        private System.Windows.Forms.Label lblVietTat;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label lblMaHocVi;
        private System.Windows.Forms.TextBox txtTenHocVi;
        private System.Windows.Forms.TextBox txtVietTat;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.TextBox txtHocVi;
    }
}