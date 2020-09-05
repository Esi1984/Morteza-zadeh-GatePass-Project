using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace aorc.gatepass
{
    public partial class UC_groupDetails : UserControl
    {
        //public delegate void RightsToGrid();
        //public event RightsToGrid eventRightsToGrid;
        public RadGridView RightsRadGridView { get; set; }
      //  public DataTable CurrentRights { get; set; }
        public UC_groupDetails()
        {
            InitializeComponent();
        }

        private void rbtnSeeRights_Click(object sender, EventArgs e)
        {
            var frm = new ui.group.frm_SelectRights();
            frm.CurrentGrid = RightsRadGridView;
            frm.ShowDialog();
            if (frm.DialogResult==DialogResult.OK)
            {
                RightsRadGridView.DataSource = frm.RightsSelected;
            }
            
            //eventRightsToGrid();
            frm.Close();
            frm.Dispose();
        }
    }
}
