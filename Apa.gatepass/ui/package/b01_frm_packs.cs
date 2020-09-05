using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServerClasses;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace aorc.gatepass.ui.package
{
	public partial class b01_frm_packs : mainFormPacks
    {
        public b01_frm_packs()
        {
            InitializeComponent();		  
        }
		frm_GatePassesGatePlace frmPackM = new frm_GatePassesGatePlace ();
        private void b01_frm_packs_Load(object sender, EventArgs e)
        {
           // SetModelsCar();
       //     setMenuForPakcs();
		uC_packDetailsGates1.uC_vehicleDetails21.SetModelsCar();
		setAllMouseMenus ();
            GroupingControls((Control)this);
            GroupingRadObjects(findRadItems());
            uC_rightSidePacksFilter1.SelectFirst();

                //eventStatusView();
                MainRadGridView.Enabled = true;
                objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toView);
                //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;
                //cbbSave_Click(sender, e);

        //	cbbView_Click(null,null);
        	toolWindowProperties.Hide();
        	//toolWindowProperties.AutoScrollMinSize=true;
        }

		private void SetSizeTabStrip( ref ToolTabStrip IntoolTabStrip )
		{
			int newSize = 254;
			if (toolTabStrip4.SizeInfo.AbsoluteSize.Height == 254)
				newSize = 169;
			var sp = new SplitPanel();
			sp.Size = IntoolTabStrip.Size;
			sp.Height = newSize;
			IntoolTabStrip.Size = sp.Size;
			sp.Size = IntoolTabStrip.SizeInfo.AbsoluteSize;
			sp.Height = newSize;
			IntoolTabStrip.SizeInfo.AbsoluteSize = sp.Size;
		}

		private void ShowPropertiesItems()
        {

			uC_ViewEvents1.rtbEvents.Text = MainRadGridView.CurrentRow.Cells ["Package_Events"].Value.ToString ();
			//uC_packDetailsGates1.rddlShift.SelectedIndex = (int) MainRadGridView.CurrentRow.Cells ["Package_Shift"].Value;

			uC_packDetailsGates1.rddlShift.Text = MainRadGridView.CurrentRow.Cells ["Package_Shift"].Value.ToString ().Trim ();

			uC_packDetailsGates1.rtbStatusPack.Text = MainRadGridView.CurrentRow.Cells["StatusPack_Label"].Value.ToString().Trim();
            uC_packDetailsGates1.rtbOffice.Text = MainRadGridView.CurrentRow.Cells["Office_Name"].Value.ToString().Trim();
            switch ((ServerClasses.AllFunctions._TypePack)MainRadGridView.CurrentRow.Cells["TypePack_Id"].Value)
            {
				case ServerClasses.AllFunctions._TypePack.WorkerMan:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.WorkerMan;
					break;
				case ServerClasses.AllFunctions._TypePack.WorkerWoman:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.WorkerWoman;
					break;
				case ServerClasses.AllFunctions._TypePack.TeachTrainee:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.TeachTrainee;
					break;
				case ServerClasses.AllFunctions._TypePack.TeachUni:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.TeachUni;
					break;
				case ServerClasses.AllFunctions._TypePack.TeachAct:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.TeachAct;
					break;
				case ServerClasses.AllFunctions._TypePack.Guest:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.Guest;
					break;
				case ServerClasses.AllFunctions._TypePack.TempWork:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.TempWork;
					break;
				case ServerClasses.AllFunctions._TypePack.Company:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.Company;
					break;
            }
        	uC_packDetailsGates1.bdcStartDate.DateTime = (DateTime)MainRadGridView.CurrentRow.Cells["Package_StartDate"].Value;
            uC_packDetailsGates1.bdcEndDate.DateTime = (DateTime)MainRadGridView.CurrentRow.Cells["Package_EndDate"].Value;
            uC_packDetailsGates1.rddlValid.SelectedIndex = ((bool)MainRadGridView.CurrentRow.Cells["Package_IsExpired"].Value) ? 0 : 1;
            uC_packDetailsGates1.rtbNumberAgree.Text = MainRadGridView.CurrentRow.Cells["Agreement_Number"].Value.ToString();
            string temS = MainRadGridView.CurrentRow.Cells["Agreement_ID"].Value.ToString();
            decimal? temp =string.IsNullOrEmpty(temS)?(decimal?) null: decimal.Parse(temS);
            uC_packDetailsGates1.CurrentAgreeId = temp;
            uC_packDetailsGates1.rtbCompanyAgree.Text = MainRadGridView.CurrentRow.Cells["Agreement_Company"].Value.ToString();
            uC_packDetailsGates1.rtbTitleAgree.Text = MainRadGridView.CurrentRow.Cells["Agreement_Title"].Value.ToString();

            temS = MainRadGridView.CurrentRow.Cells["TravelArea_Id"].Value.ToString();
            int? temp2 = string.IsNullOrEmpty(temS) ? (int?)null : int.Parse(temS);
            uC_packDetailsGates1.CurrentTravelId = temp2;

            uC_packDetailsGates1.rtbTravelLabel.Text =
            MainRadGridView.CurrentRow.Cells["TravelArea_LabelTravel"].Value.ToString();

            uC_packDetailsGates1.rtbOperRequest.Text = MainRadGridView.CurrentRow.Cells["OperRequestName"].Value.ToString();
            uC_packDetailsGates1.rtbOperConfirm.Text = MainRadGridView.CurrentRow.Cells["OperConfirmName"].Value.ToString();
            uC_packDetailsGates1.rtbOperPassage.Text = MainRadGridView.CurrentRow.Cells["OperPassageName"].Value.ToString();
            uC_packDetailsGates1.tbPackDescriptions.Text =
            MainRadGridView.CurrentRow.Cells["Package_Description"].Value.ToString();
			// if(MainRadGridView.CurrentRow.Cells["Vehicle_ID"]!=null)
			//{
        		uC_packDetailsGates1.rcbHaveVehicle.Checked =!string.IsNullOrEmpty(MainRadGridView.CurrentRow.Cells["Vehicle_ID"].Value.ToString());
			//}else
			//{
			//    uC_packDetailsGates1.rcbHaveVehicle.Checked = false;
			//}
        	//uC_packDetailsGates1.uC_vehicleDetails21.rddlType.SelectedIndex =
            if (uC_packDetailsGates1.rcbHaveVehicle.Checked)
            {
                uC_packDetailsGates1.uC_vehicleDetails21.rtbModel.Text =
                    MainRadGridView.CurrentRow.Cells["Vehicle_Model"].Value.ToString();
                uC_packDetailsGates1.uC_vehicleDetails21.rtbColor.Text =
                    MainRadGridView.CurrentRow.Cells["vehicle_Color"].Value.ToString();
                uC_packDetailsGates1.uC_vehicleDetails21.uC_CarNumber1.CarNumber =
                    MainRadGridView.CurrentRow.Cells["Vehicle_number"].Value.ToString();
                uC_packDetailsGates1.uC_vehicleDetails21.rddlState.SelectedIndex = (bool)MainRadGridView.CurrentRow.Cells["Vehicle_IsCompany"].Value?0:1;
				uC_packDetailsGates1.uC_vehicleDetails21.indexTypeModel =(int?)MainRadGridView.CurrentRow.Cells["VehicleType_ID"].Value;
            }
        }

        private void findThisModel()
        {
            
        }

        private void radGridViewPacks_SelectionChanged(object sender, EventArgs e)
        {
            SetProperties(ShowPropertiesItems);
        }

        private void b01_frm_packs_eventSaveToDelete()
        {

        }

        private void b01_frm_packs_eventSaveToEdit()
        {
			frmPackM = new gatepass.ui.package.frm_GatePassesGatePlace ();
			//var frmPackM = new gatepass.ui.package.frm_packManage();
			frmPackM.isNew = false;
			frmPackM.pmStatus = ItemsPublic.IndexStatus.toEdit;
			frmPackM.IndexPack = ( decimal? ) MainRadGridView.CurrentRow.Cells ["package_Id"].Value;
			frmPackM.setItemsPack ( ref radGridViewPacks );
			frmPackM.ShowDialog ();
			result = frmPackM.DialogResult == DialogResult.OK ? frmPackM.gotResult() : null;
        	//if ( result.success )
			//{
			//    MessageBox.Show ( "ok" );
			//}
        }

        private void b01_frm_packs_eventSaveToNew()
        {
			frmPackM = new gatepass.ui.package.frm_GatePassesGatePlace ();
        	frmPackM.pmStatus = ItemsPublic.IndexStatus.toNew;
        	frmPackM.IndexPack = null;
        	frmPackM.isNew = true;
        	//	 frmPackM.

        	var frmAddPersons = new gatepass.ui.package.frm_SelectOrAddPersons4();
        	frmAddPersons.ShowDialog();
        	if (true || frmAddPersons.DialogResult == DialogResult.OK)
        	{
        		//	frmAddPersons.ShowDialog();
        		if (frmAddPersons.State)
        		{
        			//MainRadGridView.DataSource=null;
        			//MainRadGridView.SelectAll();
        			//frmPackM.MainRadGridView.AllowAddNewRow = true;
        			frmPackM.IsnewRowAdded = true;
        			//frmPackM.MainRadGridView.CurrentRow = null;
        			//MainRadGridView.Rows.RemoveAt(0);
        			//frmPackM.MainRadGridView.DataSource = null;
        			//MainRadGridView.EndInit();
        			//MainRadGridView.EndUpdate();
        			//	MainRadGridView.EndEdit();
        			//while (MainRadGridView.Rows.Count > 0)
        			//{
        			//    MainRadGridView.Rows.RemoveAt(0);
        			//}

        			for (int count = 0; count < frmAddPersons.radGridViewSelected.Rows.Count; count++)
        			{
        				#region set rows

        				frmPackM.MainRadGridView.Rows.AddNew();
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_ID"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_ID"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_NationalCode"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_NationalCode"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_isWoman"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_isWoman"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_IdentifyCode"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_IdentifyCode"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_LicenseDriverCode"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_LicenseDriverCode"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_Name"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Name"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_Surname"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Surname"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_FatherName"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_FatherName"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_BirthCity"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_BirthCity"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_RegisterCity"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_RegisterCity"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_Nationality"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Nationality"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_BirthDate"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_BirthDate"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_Phone1"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Phone1"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_Phone2"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Phone2"].Value;
        				//						frmPackM.MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_HaveForm"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_HaveForm"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_RegisterCode"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_RegisterCode"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Person_LabelIsWoman"].Value =
        					frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_LabelIsWoman"].Value;
        				frmPackM.MainRadGridView.CurrentRow.Cells["Gatepass_ID"].Value = -1;
        				frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_IntPrint"].Value = -1;
        				frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_IsDriver"].Value = false;
        				frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_TimeLock"].Value = null;
        				frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_LockerId"].Value = -1;
        				frmPackM.MainRadGridView.CurrentRow.Cells["package_Id"].Value = -1;
        				if (frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value != null)
        				{
        					using (var ms = new System.IO.MemoryStream())
        					{
        						((Bitmap) frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value).
        							Save(ms,
        							     System.
        							     	Drawing
        							     	.
        							     	Imaging
        							     	.
        							     	ImageFormat
        							     	.Jpeg);
        						var picture = ms.ToArray();
        						frmPackM.MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = picture.Length > 0
        						                                                                    	? picture
        						                                                                    	: null;
        					}
        				}
        				else
        				{
        					frmPackM.MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = null;
        				}

        				#endregion
        			}
        			frmPackM.MainRadGridView.AllowAddNewRow = false;
        			frmPackM.IsnewRowAdded = false;
        			//frmPackM.MainRadGridView.Refresh();
        		}

        		var frmSet = new aorc.gatepass.ui.package.frm_SettingPackGatePlace();
        		frmSet.ShowDialog();
        		frmPackM.SetSetting(frmSet.v01_UC_packDetailsNewGatePlace1);
        		frmPackM.ShowDialog();
        		//result = frmPackM.gotResult ();
        		result = frmPackM.DialogResult == DialogResult.OK ? frmPackM.gotResult() : null;

        		frmPackM.Close();
        		frmPackM.Dispose();
				frmSet.Close ();
				frmSet.Dispose ();
				frmAddPersons.Close ();
				frmAddPersons.Dispose ();
        	}
        }

		void  b01_frm_packs_eventSaveToSearch()
		{
			var frm = new frm_3Search();
			frm.ShowDialog();
			if (frm.DialogResult == DialogResult.OK)
			{
                uC_rightSidePacksFilter1.UnSelect();

				objManager.ChangeStatus ( aorc.gatepass.ItemsPublic.IndexStatus.toView );

				MainRadGridView.DataSource = frm.DTSearch;
					MainRadGridView.Enabled = true;
					//ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;

			}else
			{
				objManager.ChangeStatus ( aorc.gatepass.ItemsPublic.IndexStatus.toView );
				MainRadGridView.Enabled = true;
			}
			frm.Close();
		}

		private void b01_frm_packs_eventSaveToView()
        {
			//AllFunctions._StatusPack? sad = uC_rightSidePacks1.CurrentStatusPack;
            result = objManager.View_packages(null, uC_rightSidePacksFilter1.CurrentStatusPack, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.WhatState, null,null);
        }

        private void b01_frm_packs_eventAfterSave()
        {
			frmPackM.Close ();
			frmPackM.Dispose ();
        }

        private void radDock1_DockWindowClosed(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
        {
            switch (e.DockWindow.Name)
            {
                case "toolWindowProperties":
                    toolWindowProperties.Visible = false;
            		toolTabStrip4_SelectedIndexChanged(sender, e);
                    break;
                case "documentWindowPacks":
                    documentWindowPacks.Visible = false;
                    break;
				case "toolWindowEvents":
					toolWindowEvents.Visible = false;
					toolTabStrip4_SelectedIndexChanged ( sender , e );
					break;
				case "toolWindowRightPacks":
					toolWindowRightPacks.Visible = false;
					break;
            }

            if (!toolWindowProperties.Visible && !documentWindowPacks.Visible)
            {
                cbbCancel_Click(sender, e);
            }
        }

        private void b01_frm_packs_eventStatusDelete()
        {

        }

        private void b01_frm_packs_eventStatusEdit()
        {
         //   uC_packDetailsGates1.rtbOffice.Focus();
			//cbbSave_Click ( null , null );

        }

        private void b01_frm_packs_eventStatusNew()
        {
          //  uC_packDetailsGates1.rtbOffice.Focus();
			//cbbSave_Click ( null , null );

        }

        private void b01_frm_packs_eventStatusSearch()
        {
		

            //uC_packDetailsGates1.rtbOffice.Focus();
        }

        private void b01_frm_packs_eventStatusView()
        {

        }

        private void rmiPacks_Click(object sender, EventArgs e)
        {
            documentWindowPacks.Show();
        	toolWindowRightPacks.Show();
        }

        private void rmiProperty_Click(object sender, EventArgs e)
        {
			toolWindowEvents.Show ();
          //  toolWindowProperties.Show();
        //	toolWindowEvents.Show();
        }

        private void rmiStatusPackEdit_Click(object sender, EventArgs e)
        {

        }

        private void rmiStatusPackNew_Click(object sender, EventArgs e)
        {

        }

		private void radGridViewPacks_DoubleClick( object sender , EventArgs e )
		{
			if (MainRadGridView.SelectedRows.Count == 1)
			{
				cbbEdit_Click(sender, e);
			}
		}
		


		private void toolTabStrip4_SelectedIndexChanged( object sender , EventArgs e )
		{
		//;-)	SetSizeTabStrip ( ref toolTabStrip4 );
		}

		private void radSplitContainer2_RegionChanged( object sender , EventArgs e )
		{

		}

		private void toolWindowEvents_Enter( object sender , EventArgs e )
		{
			//int newSize = 169;
			//var sp = new SplitPanel ();
			//sp.Size = toolWindowEvents.Size;
			//sp.Height = newSize;
			//toolWindowEvents.Size = sp.Size;
		}

		private void toolWindowProperties_Enter( object sender , EventArgs e )
		{
			//int newSize = 254;
			//var sp = new SplitPanel ();
			//sp.Size = toolWindowProperties.Size;
			//sp.Height = newSize;
			//toolWindowProperties.Size = sp.Size;
		}

		private void uC_packDetailsGates1_eventTickVehicle()
		{

		}

        private void uC_rightSidePacksFilter1_eventNodeNoConfirm()
        {
            result = objManager.View_packages(false, AllFunctions._StatusPack.NoConfirm, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.WhatState, null, null);
            if (result.success)
            {
                MainRadGridView.DataSource = result.ResultTable;
                MainRadGridView.Columns["package_Id"].SortOrder = RadSortOrder.Descending;
                if (MainRadGridView.Rows.Count() > 0)
                    MainRadGridView.CurrentRow = MainRadGridView.Rows[MainRadGridView.Rows.Count() - 1];
                MainRadGridView.Enabled = true;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void uC_rightSidePacksFilter1_eventNodeNoPass()
        {
            result = objManager.View_packages(false, AllFunctions._StatusPack.NoPassage, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.WhatState, null, null);
            if (result.success)
            {
                MainRadGridView.DataSource = result.ResultTable;
                MainRadGridView.Columns["package_Id"].SortOrder = RadSortOrder.Descending;
                if (MainRadGridView.Rows.Count() > 0)
                    MainRadGridView.CurrentRow = MainRadGridView.Rows[MainRadGridView.Rows.Count() - 1];
                MainRadGridView.Enabled = true;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void uC_rightSidePacksFilter1_eventNodePassed()
        {
            result = objManager.View_packages(false, AllFunctions._StatusPack.Passage, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.WhatState, null, null);
            if (result.success)
            {
                MainRadGridView.DataSource = result.ResultTable;
                MainRadGridView.Columns["package_Id"].SortOrder = RadSortOrder.Descending;
                if (MainRadGridView.Rows.Count() > 0)
                    MainRadGridView.CurrentRow = MainRadGridView.Rows[MainRadGridView.Rows.Count() - 1];
                MainRadGridView.Enabled = true;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void uC_rightSidePacksFilter1_eventNodeWaitConfirm()
        {
            result = objManager.View_packages(false, AllFunctions._StatusPack.Request, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.WhatState, null, null);
            if (result.success)
            {
                MainRadGridView.DataSource = result.ResultTable;
                MainRadGridView.Columns["package_Id"].SortOrder = RadSortOrder.Descending;
                if (MainRadGridView.Rows.Count() > 0)
                    MainRadGridView.CurrentRow = MainRadGridView.Rows[MainRadGridView.Rows.Count() - 1];
                MainRadGridView.Enabled = true;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void uC_rightSidePacksFilter1_eventNodeWaitPass()
        {
            result = objManager.View_packages(false, AllFunctions._StatusPack.Confirm, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.WhatState, null, null);
            if (result.success)
            {
                MainRadGridView.DataSource = result.ResultTable;
                MainRadGridView.Columns["package_Id"].SortOrder = RadSortOrder.Descending;
                if (MainRadGridView.Rows.Count() > 0)
                    MainRadGridView.CurrentRow = MainRadGridView.Rows[MainRadGridView.Rows.Count() - 1];
                MainRadGridView.Enabled = true;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void uC_rightSidePacksFilter1_eventNodeWaitRequest()
        {
            result = objManager.View_packages(false, AllFunctions._StatusPack.Create, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.WhatState, null, null);
            if (result.success)
            {
                MainRadGridView.DataSource = result.ResultTable;
                MainRadGridView.Columns["package_Id"].SortOrder = RadSortOrder.Descending;
                if (MainRadGridView.Rows.Count() > 0)
                    MainRadGridView.CurrentRow = MainRadGridView.Rows[MainRadGridView.Rows.Count() - 1];
                MainRadGridView.Enabled = true;

            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

    }
}
