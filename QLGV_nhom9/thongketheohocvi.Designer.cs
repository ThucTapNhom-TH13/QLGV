namespace QLGV_nhom9
{
    partial class thongketheohocvi
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
            this.cmbHocVi = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblMaHocVi = new System.Windows.Forms.Label();
            this.dgvTKHocVi = new System.Windows.Forms.DataGridView();
            this.lblThongKeHV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHocVi)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHocVi
            // 
            this.cmbHocVi.FormattingEnabled = true;
            this.cmbHocVi.Location = new System.Drawing.Point(651, 304);
            this.cmbHocVi.Name = "cmbHocVi";
            this.cmbHocVi.Size = new System.Drawing.Size(121, 21);
            this.cmbHocVi.TabIndex = 30;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(711, 370);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(544, 370);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 28;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblMaHocVi
            // 
            this.lblMaHocVi.AutoSize = true;
            this.lblMaHocVi.Location = new System.Drawing.Point(544, 304);
            this.lblMaHocVi.Name = "lblMaHocVi";
            this.lblMaHocVi.Size = new System.Drawing.Size(70, 13);
            this.lblMaHocVi.TabIndex = 27;
            this.lblMaHocVi.Text = "Mã Học Hàm";
            // 
            // dgvTKHocVi
            // 
            this.dgvTKHocVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKHocVi.Location = new System.Drawing.Point(22, 72);
            this.dgvTKHocVi.Name = "dgvTKHocVi";
            this.dgvTKHocVi.Size = new System.Drawing.Size(1350, 195);
            this.dgvTKHocVi.TabIndex = 26;
            // 
            // lblThongKeHV
            // 
            this.lblThongKeHV.AutoSize = true;
            this.lblThongKeHV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeHV.Location = new System.Drawing.Point(543, 31);
            this.lblThongKeHV.Name = "lblThongKeHV";
            this.lblThongKeHV.Size = new System.Drawing.Size(199, 22);
            this.lblThongKeHV.TabIndex = 25;
            this.lblThongKeHV.Text = "Thống Kê Theo Học Vị";
            // 
            // thongketheohocvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 414);
            this.Controls.Add(this.cmbHocVi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblMaHocVi);
            this.Controls.Add(this.dgvTKHocVi);
            this.Controls.Add(this.lblThongKeHV);
            this.Name = "thongketheohocvi";
            this.Text = "thongketheohocvi";
            this.Load += new System.EventHandler(this.thongketheohocvi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHocVi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHocVi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblMaHocVi;
        private System.Windows.Forms.DataGridView dgvTKHocVi;
        private System.Windows.Forms.Label lblThongKeHV;
    }
}