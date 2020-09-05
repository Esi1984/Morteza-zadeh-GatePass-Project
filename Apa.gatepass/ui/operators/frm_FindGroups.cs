using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.ui.operators
{
    public partial class frm_FindGroups : TinyForm
    {
        public frm_FindGroups()
        {
            InitializeComponent();
        }
        private void frm_TinyGroups_Load(object sender, EventArgs e)
        {
            unVisibleCbbEmpty();
            myColSearchName = "Group_Name";
            cbbView_Click(sender, e);
        }

        private void frm_TinyGroups_eventSaveToView()
        {
            result = objManager.View_groups(null,null,null);
            if (result.success)
            {
                mySource = result.ResultTable;
            }
        }

        private void frm_FindGroups_eventSaveTiny()
        {
            IdSelected = (int?)radGridViewGroups.CurrentRow.Cells["Group_Id"].Value;
            NameSelected = radGridViewGroups.CurrentRow.Cells["Group_Name"].Value.ToString();
        }

        private void radGridViewGroups_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            cbbSave_Click(sender, e);
        }

    }
}
