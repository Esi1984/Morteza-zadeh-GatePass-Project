using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Laitner;

namespace aorc.gatepass.ui.operators
{
    public partial class frm_operators : aorc.gatepass.mainForm
    {
        public frm_operators()
        {
            InitializeComponent();
        }
        private void frm_operators_Load(object sender, EventArgs e)
        {
            
			setAllMouseMenus ();
            GroupingControls((Control)this);
            GroupingRadObjects(findRadItems());
            cbbView_Click(sender, e);
            // cbbSearch_Click(sender, e);
        }
        private void WhatMyGroups(decimal OfficeOperators_Id)
        {

           var WhatGroups = objManager.View_groups(null, null, OfficeOperators_Id);
			if ( WhatGroups.success )
			{
				//radGridViewSearch.DataSource = WhatGroups.ResultTable;
				//if (CurrentInfo != null)
                uC_OperatorDetailGp21.rtbGroups.Text = "";
                uC_OperatorDetailGp21.CurrentGroups = new List<int>();
					foreach (DataRow item in WhatGroups.ResultTable.Rows)
					{
                    uC_OperatorDetailGp21.CurrentGroups.Add(int.Parse(item["Group_ID"].ToString().Trim()));
                    uC_OperatorDetailGp21.rtbGroups.Text += item["Group_Name"].ToString().Trim() + "\r\n";
					}
            }
			else
			{
				MessageBox.Show ( result.Message );
				this.Close();
			}

        }
        private void ShowPropertiesItems()
        {
            //(int?)MainRadGridView.CurrentRow.Cells["Group_ID"].Value;
            //uC_OperatorDetailGp21.CurrentGroups = ;
            //uC_OperatorDetailGp21.rtbGroups = ;

            WhatMyGroups((decimal)MainRadGridView.CurrentRow.Cells["OfficeOperators_Id"].Value);

            uC_OperatorDetailGp21.CurrentOfficeId = (int?)MainRadGridView.CurrentRow.Cells["Office_ID"].Value;
            uC_OperatorDetailGp21.rtbBaridName.Text = MainRadGridView.CurrentRow.Cells["BaridName"].Value.ToString();
            uC_OperatorDetailGp21.rmebBardiUserCode.Text = MainRadGridView.CurrentRow.Cells["BaridUserCode"].Value.ToString();
            uC_OperatorDetailGp21.rtbBaridJob.Text = MainRadGridView.CurrentRow.Cells["BaridJob"].Value.ToString();
            uC_OperatorDetailGp21.rtbOfficeName.Text = MainRadGridView.CurrentRow.Cells["Office_Name"].Value.ToString();
           // uC_OperatorDetailGp21.rtbGroupName.Text = MainRadGridView.CurrentRow.Cells["Group_Name"].Value.ToString();
            var tempStr = MainRadGridView.CurrentRow.Cells["Operator_Tellphone1"].Value.ToString();
            uC_OperatorDetailGp21.rmebPhone1.Value = (tempStr != "") ? (object)(tempStr): null;
            tempStr = MainRadGridView.CurrentRow.Cells["Operator_Tellphone2"].Value.ToString();
            uC_OperatorDetailGp21.rmebPhone2.Value = (tempStr != "") ? (object)(tempStr) : null;
            bool kk = bool.Parse(MainRadGridView.CurrentRow.Cells["Operator_Active"].Value.ToString());
            uC_OperatorDetailGp21.rddlActive.SelectedIndex = (kk == true) ? 0 : 1;
            uC_OperatorDetailGp21.rddlSign.SelectedIndex = ((bool.Parse(MainRadGridView.CurrentRow.Cells["Sign_Allowed"].Value.ToString()) == true)) ? 0 : 1;
            try
            {
                uC_Sign1.bdcDateExpire.DateTime = DateTime.Parse(MainRadGridView.CurrentRow.Cells["Sign_DateExpire"].Value.ToString());
            }catch
            {
                uC_Sign1.bdcDateExpire.DateTime = null;
            }
            //    uC_Sign1.bdcDateExpire.DateTime = ((dt == null ? null : (DateTime)dt));
            try
            {
                uC_Sign1.bdcDateStart.DateTime =
                    DateTime.Parse(MainRadGridView.CurrentRow.Cells["Sign_DateStart"].Value.ToString());
            }catch
            {
                uC_Sign1.bdcDateStart.DateTime = null;
            }

            if (!(MainRadGridView.CurrentRow.Cells["Sign_Shape"].Value is DBNull))
            {
                var Picture = ((byte[])MainRadGridView.CurrentRow.Cells["Sign_Shape"].Value);
              
                uC_Sign1.ImgData = Picture.Length > 0 ? Picture : new byte[0];
            }
            else
            {
                uC_Sign1.ImgData = new byte[0];
            }

        }
        private void radGridViewOperators_SelectionChanged(object sender, EventArgs e)
        {
            SetProperties(ShowPropertiesItems);
        }
        private void frm_operators_eventSaveToDelete()
        {
            result = objManager.ClsOffOper_Delete((decimal)MainRadGridView.CurrentRow.Cells["OfficeOperators_Id"].Value);
        }
        private void frm_operators_eventSaveToEdit()
        {
            result = objManager.ClsOffOper_Update(
                (decimal) MainRadGridView.CurrentRow.Cells["OfficeOperators_Id"].Value,
                uC_OperatorDetailGp21.CurrentGroups,
                uC_OperatorDetailGp21.rmebPhone1.Value.ToString(),
                uC_OperatorDetailGp21.rmebPhone2.Value.ToString(),
                (uC_OperatorDetailGp21.rddlActive.SelectedIndex == 0),
                (uC_OperatorDetailGp21.rddlSign.SelectedIndex == 0),
                uC_Sign1.bdcDateExpire.SelectedDate,
                uC_Sign1.bdcDateStart.SelectedDate,
                uC_Sign1.ImgData,uC_OperatorDetailGp21.rtbBaridName.Text
                );
        }
        private void frm_operators_eventSaveToNew()
        {
            var a1 = uC_OperatorDetailGp21.CurrentBaridId;
            var  a2= uC_OperatorDetailGp21.rmebPhone1.Value.ToString();
            var  a3= uC_OperatorDetailGp21.rmebPhone2.Value.ToString();
            var  a4= uC_OperatorDetailGp21.rddlActive.SelectedIndex == 0 ;
            var  a5= uC_OperatorDetailGp21.rddlSign.SelectedIndex == 0 ;
            var  a6= uC_Sign1.bdcDateExpire.SelectedDate;
            var  a7= uC_Sign1.bdcDateStart.SelectedDate;
            var  a8= uC_Sign1.ImgData;
            var a9 = uC_OperatorDetailGp21.CurrentGroups;
            var  a10= uC_OperatorDetailGp21.CurrentOfficeId;
            result = objManager.ClsOffOper_Create(a1,
                                                  a2,
                                                  a3,
                                                  a4,
                                                 a5 ,
                                                a6  ,
                                                a7  , 
                                                a8  ,
                                                a9  ,
                                               a10, uC_OperatorDetailGp21.rtbBaridName.Text);
            frm_operators_eventStatusNew();
        }
        private void frm_operators_eventSaveToSearch()
        {
            //result = objManager.View_operators(uC_OperatorDetailGp21.rddlActive.SelectedIndex == 0 ? true : false,barid);
            result = objManager.View_operators(null, uC_OperatorDetailGp21.rtbBaridName.Text, uC_OperatorDetailGp21.rtbOfficeName.Text);
        }
        private void frm_operators_eventSaveToView()
        {
            result = objManager.View_operators(null, string.Empty, string.Empty);
        }

        private void radDock1_DockWindowClosed(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
        {
            switch (e.DockWindow.Name)
            {
                case "toolWindowProperties":
                    toolWindowProperties.Visible = false;
                    break;
                case "documentWindowOperators":
                    documentWindowOperators.Visible = false;
                    break;
            }

            if (!toolWindowProperties.Visible && !documentWindowOperators.Visible)
            {
                cbbCancel_Click(sender, e);
            }
        }

        private void rmiProperty_Click(object sender, EventArgs e)
        {
            toolWindowProperties.Show();
        }

        private void rmiOperators_Click(object sender, EventArgs e)
        {
            documentWindowOperators.Show();
        }

        private void frm_operators_eventAfterSave()
        {

        }

        private void frm_operators_eventStatusDelete()
        {
            uC_OperatorDetailGp21.rbtnBaridForm.Focus();
        }

        private void frm_operators_eventStatusEdit()
        {
            uC_OperatorDetailGp21.rbtnGroup.Focus();
        }

        private void frm_operators_eventStatusNew()
        {

        }

        private void frm_operators_eventStatusSearch()
        {

        }

        private void frm_operators_eventStatusView()
        {

        }

        private void excel_Click(object sender, EventArgs e)
        {
            ManageExcel mm = new ManageExcel();
            mm.WirteToExcel(ref radGridViewOperators);
        }
    }
}
