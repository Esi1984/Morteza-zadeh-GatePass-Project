using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using ServerClasses;

namespace aorc.gatepass.ui.group
{
    public partial class frm_groups : aorc.gatepass.mainForm
    {
        public frm_groups()
        {
            InitializeComponent();
        }
        
        private void frm_groups_Load(object sender, EventArgs e)
        {
			setAllMouseMenus ();
            GroupingControls((Control)this);
            GroupingRadObjects(findRadItems());
            cbbView_Click(sender, e);
        }
        private void SetMyRights(int? GroupId)
        {
            OutputDatas OD = objManager.View_rights(GroupId,null);
            if (OD.success)
            {
                uC_groupDetails1.RightsRadGridView.DataSource = OD.ResultTable;
            }else
            {
                ItemsPublic.Exeptor(OD.Message);
            }
        }
        private void ShowPropertiesItems()
        {
            CursorWait();
            uC_groupDetails1.rtbName.Text = MainRadGridView.CurrentRow.Cells["Group_Name"].Value.ToString();
            uC_groupDetails1.tbDescriptions.Text = MainRadGridView.CurrentRow.Cells["Group_Description"].Value.ToString();
            uC_groupDetails1.rddlActive.SelectedIndex = ((bool)MainRadGridView.CurrentRow.Cells["Group_IsActive"].Value == true) ? 0 : 1;
            SetMyRights((int?)MainRadGridView.CurrentRow.Cells["Group_ID"].Value);
            CursorDefault();
        }

        private void frm_groups_eventSaveToDelete()
        {
            result = objManager.ClsGroups_delete((int?)MainRadGridView.CurrentRow.Cells["Group_ID"].Value);
        }

        private void frm_groups_eventSaveToEdit()
        {
            result = objManager.ClsGroups_update(
           (int?)MainRadGridView.CurrentRow.Cells["Group_ID"].Value
          ,(uC_groupDetails1.rddlActive.SelectedIndex == 0) ? true : false
          , uC_groupDetails1.rtbName.Text
          , uC_groupDetails1.tbDescriptions.Text
          , setIdRightsNew());
        }
        private List<int> setIdRightsNew()
        {
            // read frim radgridviewRights and return IDs 
            var LI = new List<int>();
            foreach (var row in radGridViewRights.Rows)
            {
                var ooo = (int)row.Cells["Right_ID"].Value;
                LI.Add((int)row.Cells["Right_ID"].Value);
            }
            return LI;
        }
        private void frm_groups_eventSaveToNew()
        {
            result = objManager.ClsGroups_insert(
                (uC_groupDetails1.rddlActive.SelectedIndex==0)?true:false
                ,uC_groupDetails1.rtbName.Text
                ,uC_groupDetails1.tbDescriptions.Text
                ,setIdRightsNew());
            frm_groups_eventStatusNew();
        }

        private void frm_groups_eventSaveToSearch()
        {
            bool? value = null;
            if (uC_groupDetails1.rddlActive.SelectedIndex != -1)
            {
                value = uC_groupDetails1.rddlActive.SelectedIndex == 0;
            }
            result = objManager.View_groups(uC_groupDetails1.rtbName.Text,value,null);
        }

        private void frm_groups_eventSaveToView()
        {
            result = objManager.View_groups(null,null,null);
        }

        private void radGridViewGroups_SelectionChanged(object sender, EventArgs e)
        {
            SetProperties(ShowPropertiesItems);
        }

        private void radDock1_DockWindowClosed(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
        {
            switch (e.DockWindow.Name)
            {
                case "toolWindowProperties":
                    toolWindowProperties.Visible = false;
                    break;
                case "documentWindowGroups":
                    documentWindowGroups.Visible = false;
                    break;
            }

            if (!toolWindowProperties.Visible && !documentWindowGroups.Visible)
            {
                cbbCancel_Click(sender, e);
            }
        }

        private void rmiProperty_Click(object sender, EventArgs e)
        {
            toolWindowProperties.Show();
        }

        private void rmiGroups_Click(object sender, EventArgs e)
        {
            documentWindowGroups.Show();
        }

        private void rmiRights_Click(object sender, EventArgs e)
        {
            documentWindowRights.Show();
        }

        private void frm_groups_eventAfterSave()
        {

        }

        private void frm_groups_eventStatusDelete()
        {

        }

        private void frm_groups_eventStatusEdit()
        {
            uC_groupDetails1.rtbName.Focus();
        }

        private void frm_groups_eventStatusNew()
        {
            uC_groupDetails1.rtbName.Focus();
        }

        private void frm_groups_eventStatusView()
        {

        }

        private void frm_groups_eventStatusSearch()
        {
            uC_groupDetails1.rtbName.Focus();
        }

        //private void uC_groupDetails1_eventRightsToGrid()
        //{
        //    radGridViewRights.DataSource = uC_groupDetails1.CurrentRights;
        //}
    }
}
