using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class xRptDSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public xRptDSSV()
        {
            InitializeComponent();
        }
        public xRptDSSV(String maL)
        {
            InitializeComponent();
            qldsvr2.EnforceConstraints = false;
            this.sP_INDSSVTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_INDSSVTableAdapter1.Fill(qldsvr1.SP_INDSSV, maL);
        }
    }
}
