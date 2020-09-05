using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass
{
    public partial class UC_TreeOffices : UserControl
    {
        public UC_TreeOffices()
        {
            InitializeComponent();
        }
        public delegate void SelectedNodeChanged();
        public event SelectedNodeChanged eventSelectedNodeChanged;
        private void radTreeView1_SelectedNodeChanged(object sender, Telerik.WinControls.UI.RadTreeViewEventArgs e)
        {
            eventSelectedNodeChanged();
        }
    }
}
