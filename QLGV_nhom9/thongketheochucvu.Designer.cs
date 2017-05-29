namespace QLGV_nhom9
{
    partial class thongketheochucvu
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
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblMaChucVu = new System.Windows.Forms.Label();
            this.dgvTKChucVu = new System.Windows.Forms.DataGridView();
            this.lblThongKeCV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Location = new System.Drawing.Point(282, 293);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(121, 21);
            this.cmbChucVu.TabIndex = 30;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(342, 359);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(175, 359);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 28;
            this.btnThongKe.Text = "thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblMaChucVu
            // 
            this.lblMaChucVu.AutoSize = true;
            this.lblMaChucVu.Location = new System.Drawing.Point(175, 293);
            this.lblMaChucVu.Name = "lblMaChucVu";
            this.lblMaChucVu.Size = new System.Drawing.Size(70, 13);
            this.lblMaChucVu.TabIndex = 27;
            this.lblMaChucVu.Text = "Tên Chức Vụ";
            // 
            // dgvTKChucVu
            // 
            this.dgvTKChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKChucVu.Location = new System.Drawing.Point(52, 78);
            this.dgvTKChucVu.Name = "dgvTKChucVu";
            this.dgvTKChucVu.Size = new System.Drawing.Size(548, 191);
            this.dgvTKChucVu.TabIndex = 26;
            // 
            // lblThongKeCV
            // 
            this.lblThongKeCV.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.lblThongKeCV.AutoSize = true;
            this.lblThongKeCV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeCV.Location = new System.Drawing.Point(171, 37);
            this.lblThongKeCV.Name = "lblThongKeCV";
            this.lblThongKeCV.Size = new System.Drawing.Size(215, 22);
            this.lblThongKeCV.TabIndex = 25;
            this.lblThongKeCV.Text = "Thống Kê Theo Chức Vụ";
            // 
            // thongketheochucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 407);
            this.Controls.Add(this.cmbChucVu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblMaChucVu);
            this.Controls.Add(this.dgvTKChucVu);
            this.Controls.Add(this.lblThongKeCV);
            this.Name = "thongketheochucvu";
            this.Text = "thongketheochucvu";
            this.Load += new System.EventHandler(this.thongketheochucvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblMaChucVu;
        private System.Windows.Forms.DataGridView dgvTKChucVu;
        private System.Windows.Forms.Label lblThongKeCV;
    }
}