namespace QLGV_nhom9
{
    partial class thongketheokhoa
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.dgvTKKhoa = new System.Windows.Forms.DataGridView();
            this.lblThongKeKhoa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoGV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(260, 280);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoa.TabIndex = 12;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(326, 346);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(159, 346);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 10;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(159, 280);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(50, 13);
            this.lblMaKhoa.TabIndex = 9;
            this.lblMaKhoa.Text = "Mã Khoa";
            // 
            // dgvTKKhoa
            // 
            this.dgvTKKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKKhoa.Location = new System.Drawing.Point(33, 61);
            this.dgvTKKhoa.Name = "dgvTKKhoa";
            this.dgvTKKhoa.Size = new System.Drawing.Size(1350, 200);
            this.dgvTKKhoa.TabIndex = 8;
            // 
            // lblThongKeKhoa
            // 
            this.lblThongKeKhoa.AutoSize = true;
            this.lblThongKeKhoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeKhoa.Location = new System.Drawing.Point(400, 24);
            this.lblThongKeKhoa.Name = "lblThongKeKhoa";
            this.lblThongKeKhoa.Size = new System.Drawing.Size(187, 22);
            this.lblThongKeKhoa.TabIndex = 7;
            this.lblThongKeKhoa.Text = "Thống Kê Theo Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số giáo viên";
            // 
            // txtSoGV
            // 
            this.txtSoGV.Location = new System.Drawing.Point(260, 312);
            this.txtSoGV.Name = "txtSoGV";
            this.txtSoGV.Size = new System.Drawing.Size(121, 20);
            this.txtSoGV.TabIndex = 14;
            // 
            // thongketheokhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 392);
            this.Controls.Add(this.txtSoGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblMaKhoa);
            this.Controls.Add(this.dgvTKKhoa);
            this.Controls.Add(this.lblThongKeKhoa);
            this.Name = "thongketheokhoa";
            this.Text = "thongketheokhoa";
            this.Load += new System.EventHandler(this.thongketheokhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.DataGridView dgvTKKhoa;
        private System.Windows.Forms.Label lblThongKeKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoGV;
    }
}