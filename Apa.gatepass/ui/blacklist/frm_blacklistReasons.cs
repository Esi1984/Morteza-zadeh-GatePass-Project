using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.ui.blacklist
{
    public partial class frm_blacklistReasons : aorc.gatepass.mainForm
    {
        public frm_blacklistReasons()
        {
            InitializeComponent();
        }

        private void frm_blacklistReasons_Load(object sender, EventArgs e)
        {
			setAllMouseMenus ();
            GroupingControls((Control)this);
            GroupingRadObjects(findRadItems());
            cbbView_Click(sender, e);
			
        }
        private void ShowPropertiesItems()
        {
            uC_BLReasons1.rtbTypeName.Text = MainRadGridView.CurrentRow.Cells["BLReason_Type"].Value.ToString();
            uC_BLReasons1.tbDescriptions.Text = MainRadGridView.CurrentRow.Cells["BLReason_Desc"].Value.ToString();
        }

        private void radGridViewBLReasons_SelectionChanged(object sender, EventArgs e)
        {
            SetProperties(ShowPropertiesItems);
        }

        private void frm_blacklistReasons_eventSaveToDelete()
        {
            var ID = int.Parse(MainRadGridView.CurrentRow.Cells["BLReason_ID"].Value.ToString());
            result = objManager.ClsBlack_BLR_delete(ID);
        }

        private void frm_blacklistReasons_eventSaveToEdit()
        {
            var ID = int.Parse(MainRadGridView.CurrentRow.Cells["BLReason_ID"].Value.ToString());
            result = objManager.ClsBlack_BLR_update(ID
                                                    ,uC_BLReasons1.rtbTypeName.Text
                                                    , uC_BLReasons1.tbDescriptions.Text);
        }

        private void frm_blacklistReasons_eventSaveToNew()
        {
            result = objManager.ClsBlack_BLR_insert(uC_BLReasons1.rtbTypeName.Text, uC_BLReasons1.tbDescriptions.Text);
            frm_blacklistReasons_eventStatusNew();
        }

        private void frm_blacklistReasons_eventSaveToSearch()
        {
            result = objManager.View_bLreasons(uC_BLReasons1.rtbTypeName.Text);
        }

        private void frm_blacklistReasons_eventSaveToView()
        {
            result = objManager.View_bLreasons(null);
        }

        private void frm_blacklistReasons_eventAfterSave()
        {

        }

        private void radDock1_DockWindowClosed(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
        {
            switch (e.DockWindow.Name)
            {
                case "toolWindowProperties":
                    toolWindowProperties.Visible = false;
                    break;
                case "documentWindowBLReasons":
                    documentWindowBLReasons.Visible = false;
                    break;
            }
            if (!toolWindowProperties.Visible && !documentWindowBLReasons.Visible)
            {
                cbbCancel_Click(sender, e);
            }
        }

        private void rmiProperty_Click(object sender, EventArgs e)
        {
            toolWindowProperties.Show();
        }

        private void rmiTypeName_Click(object sender, EventArgs e)
        {
            documentWindowBLReasons.Show();
        }

        private void frm_blacklistReasons_eventStatusDelete()
        {

        }

        private void frm_blacklistReasons_eventStatusEdit()
        {
            uC_BLReasons1.rtbTypeName.Focus();
        }

        private void frm_blacklistReasons_eventStatusNew()
        {
            uC_BLReasons1.rtbTypeName.Focus();
        }

        private void frm_blacklistReasons_eventStatusSearch()
        {
            uC_BLReasons1.rtbTypeName.Focus();
        }

        private void frm_blacklistReasons_eventStatusView()
        {

        }

    }
}
