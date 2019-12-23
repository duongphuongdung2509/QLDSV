namespace QLDSV
{
    partial class FormPrintBDMH
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.qLDSVR = new QLDSV.QLDSVR();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.QLDSVRTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVRTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV.QLDSVRTableAdapters.MONHOCTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVRTableAdapters.V_DS_PHANMANHTableAdapter();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qldsvr1 = new QLDSV.QLDSVR();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CbLan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btManHinh = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.sP_INBDMONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_INBDMONHOCTableAdapter = new QLDSV.QLDSVRTableAdapters.SP_INBDMONHOCTableAdapter();
            this.sP_INBDMONHOCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sP_INBDMONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lOPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CbTenLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CbTenMH = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsvr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INBDMONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INBDMONHOCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INBDMONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(71, 118);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(81, 19);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TÊN LỚP:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMHLabel.Location = new System.Drawing.Point(71, 166);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(124, 19);
            tENMHLabel.TabIndex = 5;
            tENMHLabel.Text = "TÊN MÔN HỌC";
            tENMHLabel.Click += new System.EventHandler(this.tENMHLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG ĐIỂM MÔN HỌC";
            // 
            // qLDSVR
            // 
            this.qLDSVR.DataSetName = "QLDSVR";
            this.qLDSVR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVRTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "BỘ PHẬN";
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.qLDSVR;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataSource = this.v_DS_PHANMANHBindingSource1;
            this.cbKhoa.DisplayMember = "TENCN";
            this.cbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(354, 65);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(270, 27);
            this.cbKhoa.TabIndex = 5;
            this.cbKhoa.ValueMember = "TENSERVER";
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource1
            // 
            this.v_DS_PHANMANHBindingSource1.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource1.DataSource = this.qLDSVR;
            // 
            // qldsvr1
            // 
            this.qldsvr1.DataSetName = "QLDSVR";
            this.qldsvr1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVR;
            // 
            // CbLan
            // 
            this.CbLan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbLan.FormattingEnabled = true;
            this.CbLan.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CbLan.Location = new System.Drawing.Point(642, 136);
            this.CbLan.Name = "CbLan";
            this.CbLan.Size = new System.Drawing.Size(121, 27);
            this.CbLan.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(560, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "LẦN THI";
            // 
            // btManHinh
            // 
            this.btManHinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManHinh.Location = new System.Drawing.Point(113, 222);
            this.btManHinh.Name = "btManHinh";
            this.btManHinh.Size = new System.Drawing.Size(113, 30);
            this.btManHinh.TabIndex = 9;
            this.btManHinh.Text = "MÀN HÌNH ";
            this.btManHinh.UseVisualStyleBackColor = true;
            this.btManHinh.Click += new System.EventHandler(this.btManHinh_Click);
            // 
            // btPrint
            // 
            this.btPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(360, 221);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(113, 31);
            this.btPrint.TabIndex = 10;
            this.btPrint.Text = "MÁY IN";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(595, 221);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(113, 30);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // sP_INBDMONHOCBindingSource
            // 
            this.sP_INBDMONHOCBindingSource.DataMember = "SP_INBDMONHOC";
            this.sP_INBDMONHOCBindingSource.DataSource = this.qldsvr1;
            // 
            // sP_INBDMONHOCTableAdapter
            // 
            this.sP_INBDMONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // sP_INBDMONHOCBindingSource1
            // 
            this.sP_INBDMONHOCBindingSource1.DataMember = "SP_INBDMONHOC";
            this.sP_INBDMONHOCBindingSource1.DataSource = this.qLDSVR;
            // 
            // sP_INBDMONHOCGridControl
            // 
            this.sP_INBDMONHOCGridControl.DataSource = this.sP_INBDMONHOCBindingSource1;
            this.sP_INBDMONHOCGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sP_INBDMONHOCGridControl.Location = new System.Drawing.Point(0, 390);
            this.sP_INBDMONHOCGridControl.MainView = this.gridView1;
            this.sP_INBDMONHOCGridControl.Name = "sP_INBDMONHOCGridControl";
            this.sP_INBDMONHOCGridControl.Size = new System.Drawing.Size(817, 202);
            this.sP_INBDMONHOCGridControl.TabIndex = 14;
            this.sP_INBDMONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colHOTEN,
            this.colDIEM});
            this.gridView1.GridControl = this.sP_INBDMONHOCGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            // 
            // lOPBindingSource1
            // 
            this.lOPBindingSource1.DataMember = "LOP";
            this.lOPBindingSource1.DataSource = this.qldsvr1;
            // 
            // CbTenLop
            // 
            this.CbTenLop.DataSource = this.lOPBindingSource2;
            this.CbTenLop.DisplayMember = "TENLOP";
            this.CbTenLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTenLop.FormattingEnabled = true;
            this.CbTenLop.Location = new System.Drawing.Point(205, 110);
            this.CbTenLop.Name = "CbTenLop";
            this.CbTenLop.Size = new System.Drawing.Size(234, 27);
            this.CbTenLop.TabIndex = 15;
            this.CbTenLop.ValueMember = "TENLOP";
            // 
            // lOPBindingSource2
            // 
            this.lOPBindingSource2.DataMember = "LOP";
            this.lOPBindingSource2.DataSource = this.qLDSVR;
            // 
            // qLDSVRBindingSource
            // 
            this.qLDSVRBindingSource.DataSource = this.qLDSVR;
            this.qLDSVRBindingSource.Position = 0;
            // 
            // CbTenMH
            // 
            this.CbTenMH.DataSource = this.mONHOCBindingSource1;
            this.CbTenMH.DisplayMember = "TENMH";
            this.CbTenMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTenMH.FormattingEnabled = true;
            this.CbTenMH.Location = new System.Drawing.Point(205, 158);
            this.CbTenMH.Name = "CbTenMH";
            this.CbTenMH.Size = new System.Drawing.Size(234, 27);
            this.CbTenMH.TabIndex = 16;
            this.CbTenMH.ValueMember = "TENMH";
            // 
            // mONHOCBindingSource1
            // 
            this.mONHOCBindingSource1.DataMember = "MONHOC";
            this.mONHOCBindingSource1.DataSource = this.qLDSVRBindingSource;
            // 
            // FormPrintBDMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 592);
            this.Controls.Add(this.CbTenMH);
            this.Controls.Add(this.CbTenLop);
            this.Controls.Add(this.sP_INBDMONHOCGridControl);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btManHinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbLan);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.label1);
            this.Name = "FormPrintBDMH";
            this.Text = "FormPrintBDMH";
            this.Load += new System.EventHandler(this.FormINBDMONHOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsvr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INBDMONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INBDMONHOCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INBDMONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLDSVR qLDSVR;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVRTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSVRTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLDSVRTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource1;
        private QLDSVRTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private QLDSVR qldsvr1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.ComboBox CbLan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btManHinh;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.BindingSource sP_INBDMONHOCBindingSource;
        private QLDSVRTableAdapters.SP_INBDMONHOCTableAdapter sP_INBDMONHOCTableAdapter;
        private System.Windows.Forms.BindingSource sP_INBDMONHOCBindingSource1;
        private DevExpress.XtraGrid.GridControl sP_INBDMONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private System.Windows.Forms.BindingSource lOPBindingSource1;
        private System.Windows.Forms.ComboBox CbTenLop;
        private System.Windows.Forms.BindingSource lOPBindingSource2;
        private System.Windows.Forms.BindingSource qLDSVRBindingSource;
        private System.Windows.Forms.ComboBox CbTenMH;
        private System.Windows.Forms.BindingSource mONHOCBindingSource1;
    }
}