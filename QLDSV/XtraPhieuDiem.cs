using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class XtraPhieuDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraPhieuDiem()
        {
            InitializeComponent();
        }
        public XtraPhieuDiem(String MaLop, String MaSV)
        {
            InitializeComponent();
            qldsvr1.EnforceConstraints = false;
            this.sP_PHIEUDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_PHIEUDIEMTableAdapter.Fill(qldsvr1.SP_PHIEUDIEM, MaSV, MaLop);
        }
    }
}
