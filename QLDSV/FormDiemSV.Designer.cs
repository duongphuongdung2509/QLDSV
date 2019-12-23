namespace QLDSV
{
    partial class FormDiemSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiemSV));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btStart = new System.Windows.Forms.ToolStripButton();
            this.btGhiDiem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboKhoa = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVR = new QLDSV.QLDSVR();
            this.label1 = new System.Windows.Forms.Label();
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVRTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVRTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new QLDSV.QLDSVRTableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new QLDSV.QLDSVRTableAdapters.MONHOCTableAdapter();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.Label();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMaMon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLanThi = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sP_DIEMSVGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_DIEMSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_DIEMSVTableAdapter = new QLDSV.QLDSVRTableAdapters.SP_DIEMSVTableAdapter();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DIEMSVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DIEMSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(416, 80);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(76, 19);
            tENLOPLabel.TabIndex = 11;
            tENLOPLabel.Text = "TÊN LỚP";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMHLabel.Location = new System.Drawing.Point(416, 129);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(124, 19);
            tENMHLabel.TabIndex = 15;
            tENMHLabel.Text = "TÊN MÔN HỌC";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btStart,
            this.btGhiDiem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(825, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Image = ((System.Drawing.Image)(resources.GetObject("btStart.Image")));
            this.btStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(97, 22);
            this.btStart.Text = "BẮT ĐẦU";
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btGhiDiem
            // 
            this.btGhiDiem.Enabled = false;
            this.btGhiDiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhiDiem.Image = ((System.Drawing.Image)(resources.GetObject("btGhiDiem.Image")));
            this.btGhiDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGhiDiem.Name = "btGhiDiem";
            this.btGhiDiem.Size = new System.Drawing.Size(103, 22);
            this.btGhiDiem.Text = "GHI ĐIỂM";
            this.btGhiDiem.Click += new System.EventHandler(this.btGhiDiem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboKhoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 43);
            this.panel1.TabIndex = 10;
            // 
            // comboKhoa
            // 
            this.comboKhoa.DataSource = this.v_DS_PHANMANHBindingSource;
            this.comboKhoa.DisplayMember = "TENCN";
            this.comboKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKhoa.FormattingEnabled = true;
            this.comboKhoa.Location = new System.Drawing.Point(280, 8);
            this.comboKhoa.Name = "comboKhoa";
            this.comboKhoa.Size = new System.Drawing.Size(293, 27);
            this.comboKhoa.TabIndex = 1;
            this.comboKhoa.ValueMember = "TENSERVER";
            this.comboKhoa.SelectedIndexChanged += new System.EventHandler(this.comboKhoa_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.qLDSVR;
            // 
            // qLDSVR
            // 
            this.qLDSVR.DataSetName = "QLDSVR";
            this.qLDSVR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "BỘ PHẬN";
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
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
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // cbMaLop
            // 
            this.cbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOPBindingSource, "TENLOP", true));
            this.cbMaLop.DataSource = this.lOPBindingSource;
            this.cbMaLop.DisplayMember = "MALOP";
            this.cbMaLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(137, 77);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(187, 25);
            this.cbMaLop.TabIndex = 11;
            this.cbMaLop.ValueMember = "MALOP";
            this.cbMaLop.SelectedIndexChanged += new System.EventHandler(this.cbMaLop_SelectedIndexChanged);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVR;
            // 
            // cbTenLop
            // 
            this.cbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.cbTenLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenLop.Location = new System.Drawing.Point(546, 80);
            this.cbTenLop.Name = "cbTenLop";
            this.cbTenLop.Size = new System.Drawing.Size(195, 25);
            this.cbTenLop.TabIndex = 12;
            // 
            // txtMaLop
            // 
            this.txtMaLop.AutoSize = true;
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(12, 81);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(71, 19);
            this.txtMaLop.TabIndex = 13;
            this.txtMaLop.Text = "MÃ LỚP";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVR;
            // 
            // cbMaMon
            // 
            this.cbMaMon.DataSource = this.mONHOCBindingSource;
            this.cbMaMon.DisplayMember = "MAMH";
            this.cbMaMon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaMon.FormattingEnabled = true;
            this.cbMaMon.Location = new System.Drawing.Point(137, 123);
            this.cbMaMon.Name = "cbMaMon";
            this.cbMaMon.Size = new System.Drawing.Size(187, 25);
            this.cbMaMon.TabIndex = 14;
            this.cbMaMon.ValueMember = "MAMH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "MÃ MÔN HỌC";
            // 
            // txtMaMon
            // 
            this.txtMaMon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.txtMaMon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.Location = new System.Drawing.Point(546, 130);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(195, 25);
            this.txtMaMon.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "LẦN THI";
            // 
            // cbLanThi
            // 
            this.cbLanThi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLanThi.FormattingEnabled = true;
            this.cbLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbLanThi.Location = new System.Drawing.Point(356, 175);
            this.cbLanThi.Name = "cbLanThi";
            this.cbLanThi.Size = new System.Drawing.Size(135, 25);
            this.cbLanThi.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sP_DIEMSVGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 188);
            this.panel2.TabIndex = 20;
            // 
            // sP_DIEMSVGridControl
            // 
            this.sP_DIEMSVGridControl.DataSource = this.sP_DIEMSVBindingSource;
            this.sP_DIEMSVGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sP_DIEMSVGridControl.Location = new System.Drawing.Point(0, -32);
            this.sP_DIEMSVGridControl.MainView = this.gridView1;
            this.sP_DIEMSVGridControl.Name = "sP_DIEMSVGridControl";
            this.sP_DIEMSVGridControl.Size = new System.Drawing.Size(825, 220);
            this.sP_DIEMSVGridControl.TabIndex = 0;
            this.sP_DIEMSVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_DIEMSVBindingSource
            // 
            this.sP_DIEMSVBindingSource.DataMember = "SP_DIEMSV";
            this.sP_DIEMSVBindingSource.DataSource = this.qLDSVR;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTEN,
            this.colDIEM});
            this.gridView1.GridControl = this.sP_DIEMSVGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
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
            // sP_DIEMSVTableAdapter
            // 
            this.sP_DIEMSVTableAdapter.ClearBeforeFill = true;
            // 
            // FormDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(825, 439);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbLanThi);
            this.Controls.Add(this.label3);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaMon);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.cbTenLop);
            this.Controls.Add(this.cbMaLop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "FormDiemSV";
            this.Text = "FormDiemSV";
            this.Load += new System.EventHandler(this.FormDiemSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_DIEMSVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DIEMSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btStart;
        private System.Windows.Forms.ToolStripButton btGhiDiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboKhoa;
        private System.Windows.Forms.Label label1;
        private QLDSVR qLDSVR;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLDSVRTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLDSVRTableAdapters.TableAdapterManager tableAdapterManager;
        private QLDSVRTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private System.Windows.Forms.TextBox cbTenLop;
        private System.Windows.Forms.Label txtMaLop;
        private QLDSVRTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.ComboBox cbMaMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLanThi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource sP_DIEMSVBindingSource;
        private QLDSVRTableAdapters.SP_DIEMSVTableAdapter sP_DIEMSVTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_DIEMSVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
    }
}