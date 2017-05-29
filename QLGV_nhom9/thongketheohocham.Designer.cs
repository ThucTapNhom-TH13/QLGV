namespace QLGV_nhom9
{
    partial class thongketheohocham
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
            this.cmbHocHam = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblMaHocHam = new System.Windows.Forms.Label();
            this.dgvTKHocHam = new System.Windows.Forms.DataGridView();
            this.lblThongKeHH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHocHam)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHocHam
            // 
            this.cmbHocHam.FormattingEnabled = true;
            this.cmbHocHam.Location = new System.Drawing.Point(250, 283);
            this.cmbHocHam.Name = "cmbHocHam";
            this.cmbHocHam.Size = new System.Drawing.Size(121, 21);
            this.cmbHocHam.TabIndex = 24;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(310, 349);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(143, 349);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 22;
            this.btnThongKe.Text = "thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblMaHocHam
            // 
            this.lblMaHocHam.AutoSize = true;
            this.lblMaHocHam.Location = new System.Drawing.Point(143, 283);
            this.lblMaHocHam.Name = "lblMaHocHam";
            this.lblMaHocHam.Size = new System.Drawing.Size(74, 13);
            this.lblMaHocHam.TabIndex = 21;
            this.lblMaHocHam.Text = "Tên Học Hàm";
            // 
            // dgvTKHocHam
            // 
            this.dgvTKHocHam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKHocHam.Location = new System.Drawing.Point(17, 64);
            this.dgvTKHocHam.Name = "dgvTKHocHam";
            this.dgvTKHocHam.Size = new System.Drawing.Size(548, 191);
            this.dgvTKHocHam.TabIndex = 20;
            // 
            // lblThongKeHH
            // 
            this.lblThongKeHH.AutoSize = true;
            this.lblThongKeHH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeHH.Location = new System.Drawing.Point(139, 27);
            this.lblThongKeHH.Name = "lblThongKeHH";
            this.lblThongKeHH.Size = new System.Drawing.Size(217, 22);
            this.lblThongKeHH.TabIndex = 19;
            this.lblThongKeHH.Text = "Thống kê Theo Học Hàm";
            // 
            // thongketheohocham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 399);
            this.Controls.Add(this.cmbHocHam);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblMaHocHam);
            this.Controls.Add(this.dgvTKHocHam);
            this.Controls.Add(this.lblThongKeHH);
            this.Name = "thongketheohocham";
            this.Text = "thongketheohocham";
            this.Load += new System.EventHandler(this.thongketheohocham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHocHam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHocHam;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblMaHocHam;
        private System.Windows.Forms.DataGridView dgvTKHocHam;
        private System.Windows.Forms.Label lblThongKeHH;
    }
}