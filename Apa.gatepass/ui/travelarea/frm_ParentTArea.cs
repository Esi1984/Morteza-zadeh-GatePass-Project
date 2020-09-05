using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace aorc.gatepass.ui.travelarea
{
    public partial class frm_ParentTArea : aorc.gatepass.TinyForm
    {
        public frm_ParentTArea()
        {
            InitializeComponent();
        }

        private void frm_ParentTArea_Load(object sender, EventArgs e)
        {
            unVisibleCbbEmpty();
            myColSearchName = "TravelArea_Name";
            cbbView_Click(sender, e);
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            cbbSave_Click(sender, e);
        }

        private void frm_ParentTArea_eventSaveToView()
        {
            result = objManager.View_travelAreas(null);
            if (result.success)
            {
                mySource = result.ResultTable;
            }
        }

        private void frm_ParentTArea_eventSaveTiny()
        {
            IdSelected = (int?)MainRadGridView.CurrentRow.Cells["TravelArea_Id"].Value;
            NameSelected = MainRadGridView.CurrentRow.Cells["TravelArea_Name"].Value.ToString();
        }
    }
}
