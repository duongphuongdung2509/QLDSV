namespace QLDSV
{
    partial class FormPhieuDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVR = new QLDSV.QLDSVR();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbMaLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.QLDSVRTableAdapters.LOPTableAdapter();
            this.CbMaSV = new System.Windows.Forms.ComboBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV.QLDSVRTableAdapters.SINHVIENTableAdapter();
            this.btManHinh = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.sP_PHIEUDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_PHIEUDIEMTableAdapter = new QLDSV.QLDSVRTableAdapters.SP_PHIEUDIEMTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVRTableAdapters.TableAdapterManager();
            this.sP_PHIEUDIEMGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLDSV.QLDSVRTableAdapters.MONHOCTableAdapter();
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVRTableAdapters.V_DS_PHANMANHTableAdapter();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PHIEUDIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PHIEUDIEMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU ĐIỂM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "BỘ PHẬN";
            // 
            // comboKhoa
            // 
            this.comboKhoa.DataSource = this.vDSPHANMANHBindingSource;
            this.comboKhoa.DisplayMember = "TENCN";
            this.comboKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKhoa.FormattingEnabled = true;
            this.comboKhoa.Location = new System.Drawing.Point(368, 78);
            this.comboKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.comboKhoa.Name = "comboKhoa";
            this.comboKhoa.Size = new System.Drawing.Size(294, 27);
            this.comboKhoa.TabIndex = 2;
            this.comboKhoa.ValueMember = "TENSERVER";
            this.comboKhoa.SelectedIndexChanged += new System.EventHandler(this.comboKhoa_SelectedIndexChanged);
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.qLDSVR;
            // 
            // qLDSVR
            // 
            this.qLDSVR.DataSetName = "QLDSVR";
            this.qLDSVR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "MÃ SV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "MÃ LỚP";
            // 
            // CbMaLop
            // 
            this.CbMaLop.DataSource = this.lOPBindingSource;
            this.CbMaLop.DisplayMember = "MALOP";
            this.CbMaLop.FormattingEnabled = true;
            this.CbMaLop.Location = new System.Drawing.Point(143, 131);
            this.CbMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.CbMaLop.Name = "CbMaLop";
            this.CbMaLop.Size = new System.Drawing.Size(256, 27);
            this.CbMaLop.TabIndex = 34;
            this.CbMaLop.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVR;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // CbMaSV
            // 
            this.CbMaSV.DataSource = this.sINHVIENBindingSource;
            this.CbMaSV.DisplayMember = "MASV";
            this.CbMaSV.FormattingEnabled = true;
            this.CbMaSV.Location = new System.Drawing.Point(634, 131);
            this.CbMaSV.Name = "CbMaSV";
            this.CbMaSV.Size = new System.Drawing.Size(228, 27);
            this.CbMaSV.TabIndex = 35;
            this.CbMaSV.ValueMember = "MASV";
            this.CbMaSV.SelectedIndexChanged += new System.EventHandler(this.CbMaSV_SelectedIndexChanged);
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSVR;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // btManHinh
            // 
            this.btManHinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManHinh.Location = new System.Drawing.Point(165, 204);
            this.btManHinh.Name = "btManHinh";
            this.btManHinh.Size = new System.Drawing.Size(113, 30);
            this.btManHinh.TabIndex = 36;
            this.btManHinh.Text = "MÀN HÌNH ";
            this.btManHinh.UseVisualStyleBackColor = true;
            this.btManHinh.Click += new System.EventHandler(this.btManHinh_Click);
            // 
            // btPrint
            // 
            this.btPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(426, 203);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(113, 31);
            this.btPrint.TabIndex = 37;
            this.btPrint.Text = "MÁY IN";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(691, 204);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(113, 30);
            this.btThoat.TabIndex = 38;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // sP_PHIEUDIEMBindingSource
            // 
            this.sP_PHIEUDIEMBindingSource.DataMember = "SP_PHIEUDIEM";
            this.sP_PHIEUDIEMBindingSource.DataSource = this.qLDSVR;
            // 
            // sP_PHIEUDIEMTableAdapter
            // 
            this.sP_PHIEUDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVRTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_PHIEUDIEMGridControl
            // 
            this.sP_PHIEUDIEMGridControl.DataSource = this.sP_PHIEUDIEMBindingSource;
            this.sP_PHIEUDIEMGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sP_PHIEUDIEMGridControl.Location = new System.Drawing.Point(0, 349);
            this.sP_PHIEUDIEMGridControl.MainView = this.gridView1;
            this.sP_PHIEUDIEMGridControl.Name = "sP_PHIEUDIEMGridControl";
            this.sP_PHIEUDIEMGridControl.Size = new System.Drawing.Size(906, 239);
            this.sP_PHIEUDIEMGridControl.TabIndex = 39;
            this.sP_PHIEUDIEMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMAMH,
            this.colDIEM});
            this.gridView1.GridControl = this.sP_PHIEUDIEMGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVR;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            // 
            // FormPhieuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 588);
            this.Controls.Add(this.sP_PHIEUDIEMGridControl);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btManHinh);
            this.Controls.Add(this.CbMaSV);
            this.Controls.Add(this.CbMaLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPhieuDiem";
            this.Text = "FormPhieuDiem";
            this.Load += new System.EventHandler(this.FormPhieuDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PHIEUDIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PHIEUDIEMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbMaLop;
        private QLDSVR qLDSVR;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVRTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox CbMaSV;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLDSVRTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.Button btManHinh;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.BindingSource sP_PHIEUDIEMBindingSource;
        private QLDSVRTableAdapters.SP_PHIEUDIEMTableAdapter sP_PHIEUDIEMTableAdapter;
        private QLDSVRTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_PHIEUDIEMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVRTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private QLDSVRTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
    }
}