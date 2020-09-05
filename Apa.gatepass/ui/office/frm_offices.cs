using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace aorc.gatepass.ui.office
{
    public partial class frm_offices : mainForm
    {
        public frm_offices()
        {
            InitializeComponent();
        }

        private DataTable DtOffice = new DataTable();
        private byte OnTree = 2;
        private void frm_offices_Load(object sender, EventArgs e)
        {           


            uC_TreeOffices1.radTreeView1.ChildMember = MainRadGridView.Columns["Office_ID"].Name;
            uC_TreeOffices1.radTreeView1.ParentMember = MainRadGridView.Columns["Office_ParentId"].Name;
            uC_TreeOffices1.radTreeView1.DisplayMember = MainRadGridView.Columns["Office_Name"].Name;
            uC_TreeOffices1.radTreeView1.ValueMember = MainRadGridView.Columns["Office_ID"].Name;


			setAllMouseMenus ();
            GroupingControls((Control) this);
            GroupingRadObjects(findRadItems());
            cbbView_Click(sender, e);
			
        }

        private string FindParentName(int? parentId)
        {
            if (parentId != null)
            {
                for (int i = 0; i < DtOffice.Rows.Count; i++)
                {

                    if ((int) DtOffice.Rows[i]["Office_ID"] == parentId)
                    {
                        return DtOffice.Rows[i]["Office_Name"].ToString();
                    }
                }
                ItemsPublic.Exeptor(ItemsPublic._errParentDontFind);
            }
            //  
            return null;
        }

        private void SetParentNames()
        {
            foreach (var rows in MainRadGridView.Rows)
            {
                rows.Cells["Office_ParentName"].Value = FindParentName((int?) rows.Cells["Office_ParentId"].Value);
            }
        }

        private void ShowPropertiesItems()
        {
            var kkk = MainRadGridView.CurrentRow.Cells["Office_ParentId"].Value.ToString();
            uC_officeDetails1.newParentId = (string.IsNullOrEmpty(kkk) ? (int?) null : int.Parse(kkk));
            //   uC_officeDetails1.newParentId = kkk;
            uC_officeDetails1.rtbOfficeName.Text = MainRadGridView.CurrentRow.Cells["Office_Name"].Value.ToString();
            var pName = MainRadGridView.CurrentRow.Cells["Office_ParentName"].Value;
            uC_officeDetails1.rtbOfficeParent.Text = (pName != null) ? pName.ToString() : "";

            //MainRadGridView.CurrentRow.Cells["Office_ParentName"].Value.ToString();
            uC_officeDetails1.rddlActive.SelectedIndex =
                ((bool) MainRadGridView.CurrentRow.Cells["Office_Active"].Value == true) ? 0 : 1;
            uC_officeDetails1.rmebPhone1.Text = MainRadGridView.CurrentRow.Cells["Office_Phone1"].Value.ToString();
            uC_officeDetails1.rmebPhone2.Text = MainRadGridView.CurrentRow.Cells["Office_Phone2"].Value.ToString();
            uC_officeDetails1.rsemonth.Value =
                int.Parse(MainRadGridView.CurrentRow.Cells["Office_MonthlyGPAllowed"].Value.ToString());
            uC_officeDetails1.rseRemindMonth.Value =
                int.Parse(MainRadGridView.CurrentRow.Cells["Office_MonthlyRemindGp"].Value.ToString());
            uC_officeDetails1.rseDay.Value =
                int.Parse(MainRadGridView.CurrentRow.Cells["Office_DailyGPAllowed"].Value.ToString());
            uC_officeDetails1.rseRemindDay.Value =
                int.Parse(MainRadGridView.CurrentRow.Cells["Office_DailyRemindGp"].Value.ToString());
            uC_officeDetails1.tbDescriptions.Text =
                MainRadGridView.CurrentRow.Cells["Office_Description"].Value.ToString();

            

        }

        private void radGridViewOffices_SelectionChanged(object sender, EventArgs e)
        {
            if (OnTree==0)
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

        private void frm_offices_eventSaveToDelete()
        {
            result = objManager.ClsOffice_delete((int) MainRadGridView.CurrentRow.Cells["Office_ID"].Value);
            OnTree = 2;
            uC_TreeOffices1.radTreeView1.SelectedNode = null;
            OnTree = 0;
        }

        private void frm_offices_eventSaveToEdit()
        {

            result = objManager.ClsOffice_update(
                (int) MainRadGridView.CurrentRow.Cells["Office_ID"].Value,
                ((uC_officeDetails1.rddlActive.SelectedIndex == 0) ? true : false),
                uC_officeDetails1.newParentId,
                uC_officeDetails1.rtbOfficeName.Text,
                ((int?) uC_officeDetails1.rsemonth.Value),
                ((int?) uC_officeDetails1.rseDay.Value),
                uC_officeDetails1.tbDescriptions.Text,
                (string) uC_officeDetails1.rmebPhone1.Value,
                (string) uC_officeDetails1.rmebPhone2.Value
                );
        }

        private void frm_offices_eventSaveToNew()
        {
            result = objManager.ClsOffice_insert(
                uC_officeDetails1.rddlActive.SelectedIndex == 0,
                uC_officeDetails1.newParentId,
                uC_officeDetails1.rtbOfficeName.Text,
                ((int?) uC_officeDetails1.rsemonth.Value),
                ((int?) uC_officeDetails1.rseDay.Value),
                uC_officeDetails1.tbDescriptions.Text,
                (string) uC_officeDetails1.rmebPhone1.Value,
                (string) uC_officeDetails1.rmebPhone2.Value
                );
            frm_offices_eventStatusNew();
        }

        private void frm_offices_eventSaveToSearch()
        {
            result = objManager.View_offices(uC_officeDetails1.rtbOfficeName.Text);
        }

        private void frm_offices_eventSaveToView()
        {
            result = objManager.View_offices(null);
            //if (result.success)
            //{
            //    DtOffice = result.ResultTable;
            //}
        }

        private void radDock1_DockWindowClosed(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
        {
            switch (e.DockWindow.Name)
            {
                case "toolWindowProperties":
                    toolWindowProperties.Visible = false;
                    break;
                case "documentWindowOffices":
                    documentWindowOffices.Visible = false;
                    break;
            }

            if (!toolWindowProperties.Visible && !documentWindowOffices.Visible)
            {
                cbbCancel_Click(sender, e);
            }
        }
        private void rmiTreeOffices_Click(object sender, EventArgs e)
        {
            documentWindowTreeOffices.Show();

        }
        private void rmiOffices_Click(object sender, EventArgs e)
        {
            documentWindowOffices.Show();
        }

        private void rmiProperty_Click(object sender, EventArgs e)
        {
            toolWindowProperties.Show();
        }
        private void uC_TreeOffices1_eventSelectedNodeChanged()
        {

            if (OnTree==1)
            {
                if (uC_TreeOffices1.radTreeView1.SelectedNode != null)
                {
                    int tempId = (int) uC_TreeOffices1.radTreeView1.SelectedNode.Value;
                    var oo = MainRadGridView.Rows.Single(x => (int) x.Cells["Office_ID"].Value == tempId);
                    MainRadGridView.CurrentRow = oo;
                }
                else
                {
                    MainRadGridView.CurrentRow = null;
                }
            }
            // uC_TreeOffices1.radTreeView1.SelectedNode.Visible = false;
        }

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
                        var myNode = (int) MainRadGridView.CurrentRow.Cells["Office_ID"].Value;
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
        private void frm_offices_eventAfterSave()
        {
         //   MainRadGridView.CurrentRow = null;
            uC_TreeOffices1.radTreeView1.DataSource = null;
            uC_TreeOffices1.radTreeView1.DataSource = MainRadGridView.DataSource;
            //if (MainRadGridView.Rows.Count < 10)
            uC_TreeOffices1.radTreeView1.ExpandAll();
        //    setTree();
            byte temp =  OnTree;
            OnTree = 2;
            if (uC_TreeOffices1.radTreeView1.Nodes.Count() > 0)
            uC_TreeOffices1.radTreeView1.SelectedNode = uC_TreeOffices1.radTreeView1.Nodes[0];
            OnTree = temp;
            //  uC_TreeOffices1.radTreeView1.Refresh();
        }

        private void documentWindowTreeOffices_Click(object sender, EventArgs e)
        {

        }

        private void documentWindowOffices_Click(object sender, EventArgs e)
        {

        }

        private void radDock1_ActiveWindowChanged(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
        {
             switch (e.DockWindow.Name)
            {
                     
                case "documentWindowOffices":
                    OnTree = 0;
                    break;
                case "documentWindowTreeOffices":
                    OnTree = 1;
                    break;
            }
        }

        private void frm_offices_eventStatusDelete()
        {

        }

        private void frm_offices_eventStatusEdit()
        {
            uC_officeDetails1.rtbOfficeName.Focus();
        }

        private void frm_offices_eventStatusNew()
        {
            uC_officeDetails1.rtbOfficeName.Focus();
        }

        private void frm_offices_eventStatusSearch()
        {
            uC_officeDetails1.rtbOfficeName.Focus();
        }

        private void frm_offices_eventStatusView()
        {

        }




    }
}
