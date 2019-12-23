namespace QLDSV
{
    partial class FormPrintDSSV
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
            System.Windows.Forms.Label mALOPLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.qLDSVR = new QLDSV.QLDSVR();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.QLDSVRTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVRTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVRTableAdapters.V_DS_PHANMANHTableAdapter();
            this.cbTenLop = new System.Windows.Forms.ComboBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btManHinh = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.sP_INDSSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_INDSSVTableAdapter = new QLDSV.QLDSVRTableAdapters.SP_INDSSVTableAdapter();
            this.sP_INDSSVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOISINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INDSSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INDSSVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(541, 140);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(71, 19);
            mALOPLabel.TabIndex = 3;
            mALOPLabel.Text = "MÃ LỚP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "IN DANH SÁCH SINH VIÊN";
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
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVRTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 44);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboKhoa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 43);
            this.panel2.TabIndex = 11;
            // 
            // comboKhoa
            // 
            this.comboKhoa.DataSource = this.vDSPHANMANHBindingSource;
            this.comboKhoa.DisplayMember = "TENCN";
            this.comboKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKhoa.FormattingEnabled = true;
            this.comboKhoa.Location = new System.Drawing.Point(358, 17);
            this.comboKhoa.Name = "comboKhoa";
            this.comboKhoa.Size = new System.Drawing.Size(293, 27);
            this.comboKhoa.TabIndex = 1;
            this.comboKhoa.ValueMember = "TENSERVER";
            this.comboKhoa.SelectedIndexChanged += new System.EventHandler(this.comboKhoa_SelectedIndexChanged);
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.qLDSVR;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "BỘ PHẬN";
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // cbTenLop
            // 
            this.cbTenLop.DataSource = this.lOPBindingSource;
            this.cbTenLop.DisplayMember = "TENLOP";
            this.cbTenLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenLop.FormattingEnabled = true;
            this.cbTenLop.Location = new System.Drawing.Point(176, 132);
            this.cbTenLop.Name = "cbTenLop";
            this.cbTenLop.Size = new System.Drawing.Size(280, 27);
            this.cbTenLop.TabIndex = 2;
            this.cbTenLop.ValueMember = "TENLOP";
            this.cbTenLop.SelectedIndexChanged += new System.EventHandler(this.cbTenLop_SelectedIndexChanged);
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(627, 133);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(147, 26);
            this.txtMaLop.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "TÊN LỚP";
            // 
            // btManHinh
            // 
            this.btManHinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManHinh.Location = new System.Drawing.Point(198, 191);
            this.btManHinh.Name = "btManHinh";
            this.btManHinh.Size = new System.Drawing.Size(113, 30);
            this.btManHinh.TabIndex = 6;
            this.btManHinh.Text = "MÀN HÌNH ";
            this.btManHinh.UseVisualStyleBackColor = true;
            this.btManHinh.Click += new System.EventHandler(this.btManHinh_Click);
            // 
            // btPrint
            // 
            this.btPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(399, 190);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(113, 31);
            this.btPrint.TabIndex = 7;
            this.btPrint.Text = "MÁY IN";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(594, 191);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(113, 30);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // sP_INDSSVBindingSource
            // 
            this.sP_INDSSVBindingSource.DataMember = "SP_INDSSV";
            this.sP_INDSSVBindingSource.DataSource = this.qLDSVR;
            // 
            // sP_INDSSVTableAdapter
            // 
            this.sP_INDSSVTableAdapter.ClearBeforeFill = true;
            // 
            // sP_INDSSVGridControl
            // 
            this.sP_INDSSVGridControl.DataSource = this.sP_INDSSVBindingSource;
            this.sP_INDSSVGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sP_INDSSVGridControl.Location = new System.Drawing.Point(0, 362);
            this.sP_INDSSVGridControl.MainView = this.gridView1;
            this.sP_INDSSVGridControl.Name = "sP_INDSSVGridControl";
            this.sP_INDSSVGridControl.Size = new System.Drawing.Size(794, 215);
            this.sP_INDSSVGridControl.TabIndex = 9;
            this.sP_INDSSVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colNGAYSINH,
            this.colNOISINH,
            this.colDIACHI});
            this.gridView1.GridControl = this.sP_INDSSVGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colNOISINH
            // 
            this.colNOISINH.FieldName = "NOISINH";
            this.colNOISINH.Name = "colNOISINH";
            this.colNOISINH.Visible = true;
            this.colNOISINH.VisibleIndex = 5;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 6;
            // 
            // FormPrintDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 577);
            this.Controls.Add(this.sP_INDSSVGridControl);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btManHinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.cbTenLop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormPrintDSSV";
            this.Text = "FormPrintDSSV";
            this.Load += new System.EventHandler(this.FormPrintDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INDSSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INDSSVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLDSVR qLDSVR;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVRTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSVRTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private QLDSVRTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.ComboBox cbTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btManHinh;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.BindingSource sP_INDSSVBindingSource;
        private QLDSVRTableAdapters.SP_INDSSVTableAdapter sP_INDSSVTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_INDSSVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOISINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
    }
}