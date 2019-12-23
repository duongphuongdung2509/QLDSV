namespace QLDSV
{
    partial class FormMonhoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonhoc));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.them = new System.Windows.Forms.ToolStripButton();
            this.sua = new System.Windows.Forms.ToolStripButton();
            this.xoa = new System.Windows.Forms.ToolStripButton();
            this.ghi = new System.Windows.Forms.ToolStripButton();
            this.thoat = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboKhoa = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVR = new QLDSV.QLDSVR();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVRTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVRTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV.QLDSVRTableAdapters.MONHOCTableAdapter();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.them,
            this.sua,
            this.xoa,
            this.ghi,
            this.thoat});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Image = ((System.Drawing.Image)(resources.GetObject("them.Image")));
            this.them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 22);
            this.them.Text = "THÊM";
            this.them.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // sua
            // 
            this.sua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Image = ((System.Drawing.Image)(resources.GetObject("sua.Image")));
            this.sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(59, 22);
            this.sua.Text = "SỬA";
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Image = ((System.Drawing.Image)(resources.GetObject("xoa.Image")));
            this.xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(61, 22);
            this.xoa.Text = "XÓA";
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // ghi
            // 
            this.ghi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghi.Image = ((System.Drawing.Image)(resources.GetObject("ghi.Image")));
            this.ghi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ghi.Name = "ghi";
            this.ghi.Size = new System.Drawing.Size(57, 22);
            this.ghi.Text = "GHI";
            this.ghi.Click += new System.EventHandler(this.ghi_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Image = ((System.Drawing.Image)(resources.GetObject("thoat.Image")));
            this.thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(83, 22);
            this.thoat.Text = "THOÁT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboKhoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 1;
            // 
            // comboKhoa
            // 
            this.comboKhoa.DataSource = this.v_DS_PHANMANHBindingSource;
            this.comboKhoa.DisplayMember = "TENCN";
            this.comboKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKhoa.FormattingEnabled = true;
            this.comboKhoa.Location = new System.Drawing.Point(300, 4);
            this.comboKhoa.Name = "comboKhoa";
            this.comboKhoa.Size = new System.Drawing.Size(251, 27);
            this.comboKhoa.TabIndex = 1;
            this.comboKhoa.ValueMember = "TENSERVER";
            this.comboKhoa.SelectedIndexChanged += new System.EventHandler(this.comboKHOA_SelectedIndexChanged);
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
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "BỘ PHẬN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "MÃ MÔN HỌC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "TÊN MÔN HỌC";
            // 
            // txtMaMon
            // 
            this.txtMaMon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "MAMH", true));
            this.txtMaMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.Location = new System.Drawing.Point(137, 84);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(202, 26);
            this.txtMaMon.TabIndex = 4;
            this.txtMaMon.TextChanged += new System.EventHandler(this.txtMaMon_TextChanged);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVR;
            // 
            // txtTenMon
            // 
            this.txtTenMon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.txtTenMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(557, 84);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(202, 26);
            this.txtTenMon.TabIndex = 5;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVRTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCGridControl
            // 
            this.mONHOCGridControl.DataSource = this.mONHOCBindingSource;
            this.mONHOCGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mONHOCGridControl.Location = new System.Drawing.Point(0, 164);
            this.mONHOCGridControl.MainView = this.gridView1;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.Size = new System.Drawing.Size(800, 256);
            this.mONHOCGridControl.TabIndex = 6;
            this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridView1.GridControl = this.mONHOCGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // FormMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.mONHOCGridControl);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "FormMonhoc";
            this.Text = "FormMonHoc";
            this.Load += new System.EventHandler(this.FormMonhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton them;
        private System.Windows.Forms.ToolStripButton sua;
        private System.Windows.Forms.ToolStripButton xoa;
        private System.Windows.Forms.ToolStripButton thoat;
        private System.Windows.Forms.ToolStripButton ghi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private QLDSVR qLDSVR;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLDSVRTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLDSVRTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVRTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
    }
}