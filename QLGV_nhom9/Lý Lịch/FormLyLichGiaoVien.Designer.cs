namespace QLGV_nhom9.Lý_Lịch
{
    partial class FormLyLichGiaoVien
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GiaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetGiaoVien = new QLGV_nhom9.Lý_Lịch.DataSetGiaoVien();
            this.KhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BoMonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GiaoVienTableAdapter = new QLGV_nhom9.Lý_Lịch.DataSetGiaoVienTableAdapters.GiaoVienTableAdapter();
            this.KhoaTableAdapter = new QLGV_nhom9.Lý_Lịch.DataSetGiaoVienTableAdapters.KhoaTableAdapter();
            this.BoMonTableAdapter = new QLGV_nhom9.Lý_Lịch.DataSetGiaoVienTableAdapters.BoMonTableAdapter();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoMon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGiaoVien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GiaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoMonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GiaoVienBindingSource
            // 
            this.GiaoVienBindingSource.DataMember = "GiaoVien";
            this.GiaoVienBindingSource.DataSource = this.DataSetGiaoVien;
            // 
            // DataSetGiaoVien
            // 
            this.DataSetGiaoVien.DataSetName = "DataSetGiaoVien";
            this.DataSetGiaoVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KhoaBindingSource
            // 
            this.KhoaBindingSource.DataMember = "Khoa";
            this.KhoaBindingSource.DataSource = this.DataSetGiaoVien;
            // 
            // BoMonBindingSource
            // 
            this.BoMonBindingSource.DataMember = "BoMon";
            this.BoMonBindingSource.DataSource = this.DataSetGiaoVien;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "GiaoVien";
            reportDataSource1.Value = this.GiaoVienBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.KhoaBindingSource;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.BoMonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGV_nhom9.Lý Lịch.LyLichGiaoVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(847, 372);
            this.reportViewer1.TabIndex = 0;
            // 
            // GiaoVienTableAdapter
            // 
            this.GiaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // KhoaTableAdapter
            // 
            this.KhoaTableAdapter.ClearBeforeFill = true;
            // 
            // BoMonTableAdapter
            // 
            this.BoMonTableAdapter.ClearBeforeFill = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(202, 33);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Xem Lý Lịch";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Khoa";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(63, 8);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoa.TabIndex = 6;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bộ môn";
            // 
            // cmbBoMon
            // 
            this.cmbBoMon.FormattingEnabled = true;
            this.cmbBoMon.Location = new System.Drawing.Point(248, 8);
            this.cmbBoMon.Name = "cmbBoMon";
            this.cmbBoMon.Size = new System.Drawing.Size(121, 21);
            this.cmbBoMon.TabIndex = 6;
            this.cmbBoMon.SelectedIndexChanged += new System.EventHandler(this.cmbBoMon_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giáo viên";
            // 
            // cmbGiaoVien
            // 
            this.cmbGiaoVien.FormattingEnabled = true;
            this.cmbGiaoVien.Location = new System.Drawing.Point(63, 35);
            this.cmbGiaoVien.Name = "cmbGiaoVien";
            this.cmbGiaoVien.Size = new System.Drawing.Size(121, 21);
            this.cmbGiaoVien.TabIndex = 6;
            // 
            // FormLyLichGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.cmbGiaoVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBoMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormLyLichGiaoVien";
            this.Text = "FormLyLichGiaoVien";
            this.Load += new System.EventHandler(this.FormLyLichGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GiaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoMonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GiaoVienBindingSource;
        private DataSetGiaoVien DataSetGiaoVien;
        private System.Windows.Forms.BindingSource KhoaBindingSource;
        private System.Windows.Forms.BindingSource BoMonBindingSource;
        private DataSetGiaoVienTableAdapters.GiaoVienTableAdapter GiaoVienTableAdapter;
        private DataSetGiaoVienTableAdapters.KhoaTableAdapter KhoaTableAdapter;
        private DataSetGiaoVienTableAdapters.BoMonTableAdapter BoMonTableAdapter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGiaoVien;
    }
}