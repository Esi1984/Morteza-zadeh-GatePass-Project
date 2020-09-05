using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace aorc.gatepass.ui.travelarea
{
    public partial class frm_travelAreas : aorc.gatepass.mainForm
    {
        public frm_travelAreas()
        {
            InitializeComponent();
        }
        private void frm_travelAreas_Load(object sender, EventArgs e)
        {
            uC_TreeOffices1.radTreeView1.ChildMember = MainRadGridView.Columns["TravelArea_Id"].Name;
            uC_TreeOffices1.radTreeView1.ParentMember = MainRadGridView.Columns["TravelArea_ParentId"].Name;
            uC_TreeOffices1.radTreeView1.DisplayMember = MainRadGridView.Columns["TravelArea_Name"].Name;
            uC_TreeOffices1.radTreeView1.ValueMember = MainRadGridView.Columns["TravelArea_Id"].Name;
			setAllMouseMenus ();
            GroupingControls((Control)this);
            GroupingRadObjects(findRadItems());
            cbbView_Click(sender, e);
			
        }
        private void ShowPropertiesItems()
         {
             uC_travelareaDetails1.rtbName.Text = MainRadGridView.CurrentRow.Cells["TravelArea_Name"].Value.ToString();
             uC_travelareaDetails1.rtbDescriptions.Text = MainRadGridView.CurrentRow.Cells["TravelArea_Description"].Value.ToString();
             uC_travelareaDetails1.rtbParent.Text = MainRadGridView.CurrentRow.Cells["TravelArea_ParentName"].Value.ToString();
             var kkk = MainRadGridView.CurrentRow.Cells["TravelArea_ParentId"].Value.ToString();
             uC_travelareaDetails1.CurrentParentId = (string.IsNullOrEmpty(kkk) ? (int?)null : int.Parse(kkk));
         }
        private byte OnTree = 2;
        private bool tempSetTree;

        private void setTree(IEnumerable<RadTreeNode> Rtn)
    {
        if (tempSetTree)
        {

            if (OnTree == 0)
            {
                if (MainRadGridView != null)
                {
                    if (MainRadGridView.CurrentRow != null)
                    {
                        var myNode = (int)MainRadGridView.CurrentRow.Cells["TravelArea_Id"].Value;
                        foreach (var item in Rtn)
                        {
                            if ((int) item.Value == myNode)
                            {
                                uC_TreeOffices1.radTreeView1.SelectedNode = item;
                                tempSetTree = false;
                                return;
                            }
                            if (item.Nodes.Count > 0)
                            {
                                setTree(item.Nodes);
                                if (!tempSetTree)
                                {
                                    return;
                                }
                            }

                        }
                    }
                }
            }
        }

    }
        private void radGridViewTravelArea_SelectionChanged(object sender, EventArgs e)
         {
             if (OnTree == 0)
             {
                 if (MainRadGridView.SelectedRows.Count == 1)
                 {
                     tempSetTree = true;
                     setTree(uC_TreeOffices1.radTreeView1.Nodes);
                 }
                 else
                 {
                     OnTree = 2;
                     uC_TreeOffices1.radTreeView1.SelectedNode = null;
                     OnTree = 0;
                 }
             }
             SetProperties(ShowPropertiesItems);
         }
        private void frm_travelAreas_eventSaveToDelete()
        {
            result = objManager.ClsTravelAreas_update(int.Parse(MainRadGridView.CurrentRow.Cells["TravelArea_Id"].Value.ToString()),
                                                    uC_travelareaDetails1.rtbName.Text,
                                                      uC_travelareaDetails1.rtbDescriptions.Text,
                                                      uC_travelareaDetails1.CurrentParentId,
                                                      true);
            OnTree = 2;
            uC_TreeOffices1.radTreeView1.SelectedNode = null;
            OnTree = 0;
        }
        private void frm_travelAreas_eventSaveToEdit()
        {
            result = objManager.ClsTravelAreas_update(int.Parse(MainRadGridView.CurrentRow.Cells["TravelArea_Id"].Value.ToString()),
                                                      uC_travelareaDetails1.rtbName.Text,
                                                      uC_travelareaDetails1.rtbDescriptions.Text,
                                                      uC_travelareaDetails1.CurrentParentId,
                                                      null);
        }
        private void frm_travelAreas_eventSaveToNew()
        {
            result = objManager.ClsTravelAreas_insert(
                uC_travelareaDetails1.rtbName.Text
                , uC_travelareaDetails1.rtbDescriptions.Text
                , uC_travelareaDetails1.CurrentParentId);
            frm_travelAreas_eventStatusNew();
        }
        private void frm_travelAreas_eventSaveToSearch()
        {
            result = objManager.View_travelAreas(uC_travelareaDetails1.rtbName.Text);
        }
        private void frm_travelAreas_eventSaveToView()
        {
            result = objManager.View_travelAreas(null);
        }
        private void radDock1_DockWindowClosed(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
        {
            switch (e.DockWindow.Name)
            {
                case "toolWindowProperties":
                    toolWindowProperties.Visible = false;
                    break;
                case "documentWindowTravelArea":
                    documentWindowTravelArea.Visible = false;
                    break;
            }

            if (!toolWindowProperties.Visible && !documentWindowTravelArea.Visible)
            {
                cbbCancel_Click(sender, e);
            }
        }
        private void rmiTravelAreas_Click(object sender, EventArgs e)
        {
            documentWindowTravelArea.Show();
        }
        private void rmiTreeTravelArea_Click(object sender, EventArgs e)
        {
            documentWindowTree.Show();
        }
        private void rmiProperty_Click(object sender, EventArgs e)
        {
            toolWindowProperties.Show();
        }

        private void frm_travelAreas_eventAfterSave()
        {
            //   MainRadGridView.CurrentRow = null;
            uC_TreeOffices1.radTreeView1.DataSource = null;
            uC_TreeOffices1.radTreeView1.DataSource = MainRadGridView.DataSource;
            if (MainRadGridView.Rows.Count < 10)
            uC_TreeOffices1.radTreeView1.ExpandAll();
            //    setTree();
            byte temp = OnTree;
            OnTree = 2;
            if (uC_TreeOffices1.radTreeView1.Nodes.Count()>0)
            uC_TreeOffices1.radTreeView1.SelectedNode = uC_TreeOffices1.radTreeView1.Nodes[0];
            OnTree = temp;
            //  uC_TreeOffices1.radTreeView1.Refresh();
        }

        private void frm_travelAreas_eventStatusDelete()
        {

        }

        private void frm_travelAreas_eventStatusEdit()
        {
            uC_travelareaDetails1.rtbDescriptions.Focus();
        }

        private void frm_travelAreas_eventStatusNew()
        {
            uC_travelareaDetails1.rtbName.Focus();
        }

        private void frm_travelAreas_eventStatusSearch()
        {
            uC_travelareaDetails1.rtbName.Focus();
        }

        private void frm_travelAreas_eventStatusView()
        {

        }

        private void radDock1_ActiveWindowChanged(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
        {
            switch (e.DockWindow.Name)
            {

                case "documentWindowTravelArea":
                    OnTree = 0;
                    break;
                case "documentWindowTree":
                    OnTree = 1;
                    break;
            }
        }

        private void uC_TreeOffices1_eventSelectedNodeChanged()
        {
            if (OnTree == 1)
            {
                if (uC_TreeOffices1.radTreeView1.SelectedNode != null)
                {
                    int tempId = (int)uC_TreeOffices1.radTreeView1.SelectedNode.Value;
                    var oo = MainRadGridView.Rows.Single(x => (int)x.Cells["TravelArea_Id"].Value == tempId);
                    MainRadGridView.CurrentRow = oo;
                }
                else
                {
                    MainRadGridView.CurrentRow = null;
                }
            }
        }
    }
}
