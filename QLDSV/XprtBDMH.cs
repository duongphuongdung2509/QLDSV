using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class XprtBDMH : DevExpress.XtraReports.UI.XtraReport
    {
        public XprtBDMH()
        {
            InitializeComponent();
        }
        public XprtBDMH(String TenLop, String TenMH, String Lan )
        {
            InitializeComponent();
            qldsvr1.EnforceConstraints = false;
            this.sP_INBDMONHOCTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_INBDMONHOCTableAdapter1.Fill(qldsvr1.SP_INBDMONHOC, TenLop,TenMH, new System.Nullable<short>(((short)(System.Convert.ChangeType(Lan, typeof(short))))));
        }
    }
}
