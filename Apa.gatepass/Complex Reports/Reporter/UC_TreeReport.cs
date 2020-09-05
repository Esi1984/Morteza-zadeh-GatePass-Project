using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.Complex_Reports.Reporter
{
    public partial class UC_TreeReport : UserControl
    {
        public UC_TreeReport()
        {
            InitializeComponent();
        }
        public delegate void SelectedNodeChanged();
        public event SelectedNodeChanged eventSelectedNodeChanged;
        private void TreeViewReports_SelectedNodeChanged(object sender, Telerik.WinControls.UI.RadTreeViewEventArgs e)
        {
            eventSelectedNodeChanged();
        }
    }
}
