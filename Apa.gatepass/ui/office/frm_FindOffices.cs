using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.ui.office
{
    public partial class frm_FindOffices : TinyForm
    {
        public frm_FindOffices()
        {
            InitializeComponent();
        }
        private void frm_offices_Load(object sender, EventArgs e)
        {
            unVisibleCbbEmpty();
            myColSearchName = "Office_Name";
            cbbView_Click(sender, e);
        }
        private void frm_offices_eventSaveToView()
        {
            result = objManager.View_offices(null);
            if (result.success)
            {
                mySource = result.ResultTable;
            }
        }

        private void frm_FindOffices_eventSaveTiny()
        {
                    IdSelected = (int)radGridViewOffices.CurrentRow.Cells["Office_ID"].Value;
                    NameSelected = radGridViewOffices.CurrentRow.Cells["Office_Name"].Value.ToString();
        }

        private void radGridViewOffices_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            cbbSave_Click(sender, e);
        }

    }
}
