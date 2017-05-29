namespace QLGV_nhom9
{
    partial class DanhSachBoMon
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
            this.dgvBoMon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemBM = new System.Windows.Forms.ToolStripButton();
            this.btnSuaBM = new System.Windows.Forms.ToolStripButton();
            this.btnXoaBM = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoMon)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBoMon
            // 
            this.dgvBoMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvBoMon.Location = new System.Drawing.Point(-141, 108);
            this.dgvBoMon.Name = "dgvBoMon";
            this.dgvBoMon.ReadOnly = true;
            this.dgvBoMon.Size = new System.Drawing.Size(1360, 550);
            this.dgvBoMon.TabIndex = 3;
            this.dgvBoMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoMon_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaBoMon";
            this.Column1.HeaderText = "Mã Bộ Môn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaKhoa";
            this.Column2.HeaderText = "Mã Khoa";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "TenBoMon";
            this.Column3.HeaderText = "Tên Bộ Môn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1300, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "DANH SÁCH BỘ MÔN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemBM,
            this.btnSuaBM,
            this.btnXoaBM});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1300, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnThemBM
            // 
            this.btnThemBM.Image = global::QLGV_nhom9.Properties.Resources.thêm_3;
            this.btnThemBM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemBM.Name = "btnThemBM";
            this.btnThemBM.Size = new System.Drawing.Size(58, 22);
            this.btnThemBM.Text = "Thêm";
            this.btnThemBM.Click += new System.EventHandler(this.btnThemBM_Click);
            // 
            // btnSuaBM
            // 
            this.btnSuaBM.Image = global::QLGV_nhom9.Properties.Resources.hình_sửa_1;
            this.btnSuaBM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaBM.Name = "btnSuaBM";
            this.btnSuaBM.Size = new System.Drawing.Size(46, 22);
            this.btnSuaBM.Text = "Sửa";
            this.btnSuaBM.Click += new System.EventHandler(this.btnSuaBM_Click);
            // 
            // btnXoaBM
            // 
            this.btnXoaBM.Image = global::QLGV_nhom9.Properties.Resources.hình_xóa_1;
            this.btnXoaBM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaBM.Name = "btnXoaBM";
            this.btnXoaBM.Size = new System.Drawing.Size(47, 22);
            this.btnXoaBM.Text = "Xóa";
            this.btnXoaBM.Click += new System.EventHandler(this.btnXoaBM_Click);
            // 
            // DanhSachBoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 421);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBoMon);
            this.Name = "DanhSachBoMon";
            this.Text = "DanhSachBoMon";
            this.Load += new System.EventHandler(this.DanhSachBoMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoMon)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemBM;
        private System.Windows.Forms.ToolStripButton btnSuaBM;
        private System.Windows.Forms.ToolStripButton btnXoaBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}