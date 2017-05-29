namespace QLGV_nhom9
{
    partial class thongketheobomon
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
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThongKeBM = new System.Windows.Forms.Button();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.dgvTKBoMon = new System.Windows.Forms.DataGridView();
            this.lblThongKeBoMon = new System.Windows.Forms.Label();
            this.lblTenBoMon = new System.Windows.Forms.Label();
            this.cmbBoMon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoGV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKBoMon)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(688, 292);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(150, 21);
            this.cmbKhoa.TabIndex = 18;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(763, 407);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnThongKeBM
            // 
            this.btnThongKeBM.Location = new System.Drawing.Point(633, 407);
            this.btnThongKeBM.Name = "btnThongKeBM";
            this.btnThongKeBM.Size = new System.Drawing.Size(75, 23);
            this.btnThongKeBM.TabIndex = 16;
            this.btnThongKeBM.Text = "Thống Kê";
            this.btnThongKeBM.UseVisualStyleBackColor = true;
            this.btnThongKeBM.Click += new System.EventHandler(this.btnThongKeBM_Click);
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(616, 292);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(54, 13);
            this.lblMaKhoa.TabIndex = 15;
            this.lblMaKhoa.Text = "Tên Khoa";
            // 
            // dgvTKBoMon
            // 
            this.dgvTKBoMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKBoMon.Location = new System.Drawing.Point(12, 60);
            this.dgvTKBoMon.Name = "dgvTKBoMon";
            this.dgvTKBoMon.Size = new System.Drawing.Size(1350, 191);
            this.dgvTKBoMon.TabIndex = 14;
            // 
            // lblThongKeBoMon
            // 
            this.lblThongKeBoMon.AutoSize = true;
            this.lblThongKeBoMon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeBoMon.Location = new System.Drawing.Point(615, 24);
            this.lblThongKeBoMon.Name = "lblThongKeBoMon";
            this.lblThongKeBoMon.Size = new System.Drawing.Size(209, 22);
            this.lblThongKeBoMon.TabIndex = 13;
            this.lblThongKeBoMon.Text = "Thống Kê Theo Bộ Môn";
            // 
            // lblTenBoMon
            // 
            this.lblTenBoMon.AutoSize = true;
            this.lblTenBoMon.Location = new System.Drawing.Point(616, 329);
            this.lblTenBoMon.Name = "lblTenBoMon";
            this.lblTenBoMon.Size = new System.Drawing.Size(66, 13);
            this.lblTenBoMon.TabIndex = 15;
            this.lblTenBoMon.Text = "Tên Bộ Môn";
            // 
            // cmbBoMon
            // 
            this.cmbBoMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoMon.FormattingEnabled = true;
            this.cmbBoMon.Location = new System.Drawing.Point(688, 329);
            this.cmbBoMon.Name = "cmbBoMon";
            this.cmbBoMon.Size = new System.Drawing.Size(150, 21);
            this.cmbBoMon.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Số Lượng";
            // 
            // txtSoGV
            // 
            this.txtSoGV.Location = new System.Drawing.Point(688, 358);
            this.txtSoGV.Name = "txtSoGV";
            this.txtSoGV.ReadOnly = true;
            this.txtSoGV.Size = new System.Drawing.Size(150, 20);
            this.txtSoGV.TabIndex = 20;
            // 
            // thongketheobomon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 456);
            this.Controls.Add(this.txtSoGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoMon);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblTenBoMon);
            this.Controls.Add(this.btnThongKeBM);
            this.Controls.Add(this.lblMaKhoa);
            this.Controls.Add(this.dgvTKBoMon);
            this.Controls.Add(this.lblThongKeBoMon);
            this.Name = "thongketheobomon";
            this.Text = "thongketheobomon";
            this.Load += new System.EventHandler(this.thongketheobomon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKBoMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThongKeBM;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.DataGridView dgvTKBoMon;
        private System.Windows.Forms.Label lblThongKeBoMon;
        private System.Windows.Forms.Label lblTenBoMon;
        private System.Windows.Forms.ComboBox cmbBoMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoGV;
    }
}