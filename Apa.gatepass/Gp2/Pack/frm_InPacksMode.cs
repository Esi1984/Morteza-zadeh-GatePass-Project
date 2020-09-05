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

namespace aorc.gatepass.Gp2.Pack
{
	public partial class frm_InPacksMode : mainFormPacks
    {

        private bool copyingMode = false;


        public frm_InPacksMode()
        {
            InitializeComponent();		  
        }
		frm_InpackGP frmPackM = new frm_InpackGP ();
        private void frm_InPacksMode_Load(object sender, EventArgs e)
        {
           // SetModelsCar();
       //     setMenuForPakcs();
	//	v3UC_PackDetailsGp21.uC_vehicleDetails21.SetModelsCar();

            v3UC_PackDetailsGp21.rtbCompanyAgree.Tag = "a";
            v3UC_PackDetailsGp21.rlblCountCar.Tag = "a";
            v3UC_PackDetailsGp21.rtbGates.Tag = "a";
            v3UC_PackDetailsGp21.rtbNumberAgree.Tag = "a";
            v3UC_PackDetailsGp21.rtbOffice.Tag = "a";
            v3UC_PackDetailsGp21.rtbOperConfirm.Tag = "a";
            v3UC_PackDetailsGp21.rtbOperPassage.Tag = "a";
            v3UC_PackDetailsGp21.rtbOperRequest.Tag = "a";
            v3UC_PackDetailsGp21.rtbPlaces.Tag = "a";
            v3UC_PackDetailsGp21.rtbStatusPack.Tag = "a";
            v3UC_PackDetailsGp21.rtbPackId.Tag = "a";
            v3UC_PackDetailsGp21.rtbTravelLabel.Tag = "a";
            v3UC_PackDetailsGp21.tbPackDescriptions.Tag = "a";
            v3UC_PackDetailsGp21.bdcEndDate.Tag = "a";
            v3UC_PackDetailsGp21.bdcStartDate.Tag = "a";
            v3UC_PackDetailsGp21.rddlShift.Tag = "a";
            v3UC_PackDetailsGp21.rddlTypePack.Tag = "a";
            v3UC_PackDetailsGp21.rddlValid.Tag = "a";
            //v3UC_PackDetailsGp21..Tag = "a";
            //v3UC_PackDetailsGp21.Tag = "a";
            //v3UC_PackDetailsGp21.Tag = "a";
            //v3UC_PackDetailsGp21.Tag = "a";
            //v3UC_PackDetailsGp21.Tag = "a";
            //v3UC_PackDetailsGp21.Tag = "a";
            //v3UC_PackDetailsGp21.Tag = "a";
            //v3UC_PackDetailsGp21.Tag = "a";
            //v3UC_PackDetailsGp21.Tag = "a";
            //v3UC_PackDetailsGp21.Tag = "a";

		    setAllMouseMenus ();
            GroupingControls((Control)this);
            GroupingRadObjects(findRadItems());
           // uC_rightSidePacksFilter1.SelectFirst();
            uC_rightSidePacksFilter1.UnSelect();
                //eventStatusView();
                MainRadGridView.Enabled = true;

                objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.viewPack);
                radGridViewPacks_RowsChanged(null,null);


                //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;
                //cbbSave_Click(sender, e);

        //	cbbView_Click(null,null);
        //	toolWindowProperties.Hide();
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

            uC_ViewEvents1.rtbEvents.Text = MainRadGridView.CurrentRow.Cells["Package_Events"].Value.ToString();

            // ========================================================
            var result = new OutputDatas();
            var objGateManager = new Manager();
            var IndexPack = (decimal?)MainRadGridView.CurrentRow.Cells["package_Id"].Value;
            result = objGateManager.View_Gates(IndexPack);
            if (result.success)
            {

                v3UC_PackDetailsGp21.rtbGates.Text = "";
                v3UC_PackDetailsGp21.CurrentGates = new List<int>();
                foreach (DataRow obj in result.ResultTable.Rows)
                {
                    //	string ss = obj.Cells["Gate_Id"].Value.ToString().Trim();
                    //int ii = int.Parse(obj.Cells["Gate_Id"].Value.ToString().Trim());
                    v3UC_PackDetailsGp21.CurrentGates.Add(int.Parse(obj["Gate_Id"].ToString().Trim()));
                    v3UC_PackDetailsGp21.rtbGates.Text += obj["Gate_Name"].ToString().Trim() + "\r\n";
                }
            }
            else
            {
                ItemsPublic.ShowMessage(result.Message);
            }


            result = new OutputDatas();
            objGateManager = new Manager();
            result = objGateManager.View_Places(IndexPack);
            if (result.success)
            {
                v3UC_PackDetailsGp21.rtbPlaces.Text = "";
                v3UC_PackDetailsGp21.CurrentPlaces = new List<int>();
                foreach (DataRow obj in result.ResultTable.Rows)
                {
                    //	string ss = obj.Cells["Place_Id"].Value.ToString().Trim();
                    //int ii = int.Parse(obj.Cells["Place_Id"].Value.ToString().Trim());
                    v3UC_PackDetailsGp21.CurrentPlaces.Add(int.Parse(obj["Place_Id"].ToString().Trim()));
                    v3UC_PackDetailsGp21.rtbPlaces.Text += obj["Place_Name"].ToString().Trim() + "\r\n";
                }
            }
            else
            {
                ItemsPublic.ShowMessage(result.Message);
            }



            v3UC_PackDetailsGp21.rddlShift.Text = MainRadGridView.CurrentRow.Cells["Package_Shift"].Value.ToString().Trim();

            v3UC_PackDetailsGp21.rtbStatusPack.Text = MainRadGridView.CurrentRow.Cells["StatusPack_Label"].Value.ToString().Trim();
            v3UC_PackDetailsGp21.rtbPackId.Text = MainRadGridView.CurrentRow.Cells["Package_TicketId"].Value.ToString().Trim();
            v3UC_PackDetailsGp21.rtbOffice.Text = MainRadGridView.CurrentRow.Cells["Office_Name"].Value.ToString().Trim();

            if(MainRadGridView.CurrentRow.Cells["TypePack_Id"].Value!=null)
                if (!(MainRadGridView.CurrentRow.Cells["TypePack_Id"].Value is DBNull))
                {
                    v3UC_PackDetailsGp21.TypePackRealId = (int)MainRadGridView.CurrentRow.Cells["TypePack_Id"].Value;
                    v3UC_PackDetailsGp21.isGpType = (bool?)MainRadGridView.CurrentRow.Cells["TypePack_IsShort"].Value;
                    v3UC_PackDetailsGp21.rddlTypePack.Text = MainRadGridView.CurrentRow.Cells["TypePack_Name"].Value.ToString().Trim();
                }

            //switch ((ServerClasses.AllFunctions._TypePack)MainRadGridView.CurrentRow.Cells["TypePack_Id"].Value)
            //{
            //    case ServerClasses.AllFunctions._TypePack.WorkerMan:
            //        v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.WorkerMan;
            //        break;
            //    case ServerClasses.AllFunctions._TypePack.WorkerWoman:
            //        v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.WorkerWoman;
            //        break;
            //    case ServerClasses.AllFunctions._TypePack.TeachTrainee:
            //        v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.TeachTrainee;
            //        break;
            //    case ServerClasses.AllFunctions._TypePack.TeachUni:
            //        v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.TeachUni;
            //        break;
            //    case ServerClasses.AllFunctions._TypePack.TeachAct:
            //        v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.TeachAct;
            //        break;
            //    case ServerClasses.AllFunctions._TypePack.Guest:
            //        v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.Guest;
            //        break;
            //    case ServerClasses.AllFunctions._TypePack.TempWork:
            //        v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.TempWork;
            //        break;
            //    case ServerClasses.AllFunctions._TypePack.Company:
            //        v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.Company;
            //        break;
            //}

            if (MainRadGridView.CurrentRow.Cells["Package_StartDate"].Value != null)
                if (!(MainRadGridView.CurrentRow.Cells["Package_StartDate"].Value is DBNull))
            v3UC_PackDetailsGp21.bdcStartDate.DateTime = (DateTime)MainRadGridView.CurrentRow.Cells["Package_StartDate"].Value;

            if (MainRadGridView.CurrentRow.Cells["Package_EndDate"].Value != null)
                if (!(MainRadGridView.CurrentRow.Cells["Package_EndDate"].Value is DBNull))
            v3UC_PackDetailsGp21.bdcEndDate.DateTime = (DateTime)MainRadGridView.CurrentRow.Cells["Package_EndDate"].Value;


            v3UC_PackDetailsGp21.rddlValid.SelectedIndex = ((bool)MainRadGridView.CurrentRow.Cells["Package_IsExpired"].Value)
                                                                ? 0
                                                                : 1;

            if (MainRadGridView.CurrentRow.Cells["Agreement_Number"].Value != null)
                if (!(MainRadGridView.CurrentRow.Cells["Agreement_Number"].Value is DBNull))
            v3UC_PackDetailsGp21.rtbNumberAgree.Text = MainRadGridView.CurrentRow.Cells["Agreement_Number"].Value.ToString().Trim();

            string temS = MainRadGridView.CurrentRow.Cells["Agreement_ID"].Value.ToString().Trim();
            decimal? temp = string.IsNullOrEmpty(temS) ? (decimal?)null : decimal.Parse(temS);
            v3UC_PackDetailsGp21.CurrentAgreeId = temp;

            if (MainRadGridView.CurrentRow.Cells["Agreement_Company"].Value != null)
                if (!(MainRadGridView.CurrentRow.Cells["Agreement_Company"].Value is DBNull))
            v3UC_PackDetailsGp21.rtbCompanyAgree.Text = MainRadGridView.CurrentRow.Cells["Agreement_Company"].Value.ToString().Trim();
            //	v3UC_PackDetailsGp21.rtbTitleAgree.Text = MainRadGridView.CurrentRow.Cells["Agreement_Title"].Value.ToString().Trim();
            v3UC_PackDetailsGp21.rlblCountCar.Text = ItemsPublic.HowManyCarInAgree(temp);


            if (MainRadGridView.CurrentRow.Cells["TravelArea_Id"].Value != null)
                if (!(MainRadGridView.CurrentRow.Cells["TravelArea_Id"].Value is DBNull))
                {

                    temS = MainRadGridView.CurrentRow.Cells["TravelArea_Id"].Value.ToString().Trim();
                    int? temp2 = string.IsNullOrEmpty(temS) ? (int?)null : int.Parse(temS);
                    v3UC_PackDetailsGp21.CurrentTravelId = temp2;

                    v3UC_PackDetailsGp21.rtbTravelLabel.Text =
                        MainRadGridView.CurrentRow.Cells["TravelArea_LabelTravel"].Value.ToString().Trim();

                }

            v3UC_PackDetailsGp21.rtbOperRequest.Text = MainRadGridView.CurrentRow.Cells["OperRequestName"].Value.ToString().Trim();
            v3UC_PackDetailsGp21.rtbOperConfirm.Text = MainRadGridView.CurrentRow.Cells["OperConfirmName"].Value.ToString().Trim();
            v3UC_PackDetailsGp21.rtbOperPassage.Text = MainRadGridView.CurrentRow.Cells["OperPassageName"].Value.ToString().Trim();
            v3UC_PackDetailsGp21.tbPackDescriptions.Text =
                MainRadGridView.CurrentRow.Cells["Package_Description"].Value.ToString().Trim();

            //v3UC_PackDetailsGp21.uC_vehicleDetails21.rddlType.SelectedIndex =
            //string stV = rgvPack.CurrentRow.Cells["Vehicle_ID"].Value.ToString().Trim();
            //bool boV = !string.IsNullOrEmpty(stV);
            //v3UC_PackDetailsGp21.rcbHaveVehicle.Checked = boV;
            //if (v3UC_PackDetailsGp21.rcbHaveVehicle.Checked)
            //{
            //    v3UC_PackDetailsGp21.CurrentCarId = (decimal?) rgvPack.CurrentRow.Cells["Vehicle_ID"].Value;
            //    v3UC_PackDetailsGp21.uC_vehicleDetails31.rtbModel.Text =
            //        rgvPack.CurrentRow.Cells["Vehicle_Model"].Value.ToString().Trim();
            //    v3UC_PackDetailsGp21.uC_vehicleDetails31.rtbColor.Text =
            //        rgvPack.CurrentRow.Cells["vehicle_Color"].Value.ToString().Trim();



            //    v3UC_PackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex =
            //        (int)rgvPack.CurrentRow.Cells["TypePlates_Id"].Value;


            //    v3UC_PackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.CarNumber =
            //        rgvPack.CurrentRow.Cells["Vehicle_number"].Value.ToString().Trim();



            //    v3UC_PackDetailsGp21.uC_vehicleDetails31.rddlState.SelectedIndex =
            //        (bool) rgvPack.CurrentRow.Cells["Vehicle_IsCompany"].Value ? 0 : 1;
            //    v3UC_PackDetailsGp21.uC_vehicleDetails31.indexTypeModel =
            //        (int?) rgvPack.CurrentRow.Cells["VehicleType_ID"].Value;
            //}
            //else
            //{
            //    v3UC_PackDetailsGp21.rcbHaveVehicle.Checked = false;
            //}
        }

        private void findThisModel()
        {
            
        }

        private void radGridViewPacks_SelectionChanged(object sender, EventArgs e)
        {
            if(!copyingMode)
            SetProperties(ShowPropertiesItems);
        }

        private void frm_InPacksMode_eventSaveToDelete()
        {

        }

        private void frm_InPacksMode_eventSaveToEdit()
        {

			frmPackM = new frm_InpackGP ();
			//var frmPackM = new gatepass.ui.package.frm_packManage();
			frmPackM.isNew = false;

			frmPackM.pmStatus = ItemsPublic.IndexStatus.toEdit;
			frmPackM.IndexPack = ( decimal? ) MainRadGridView.CurrentRow.Cells ["package_Id"].Value;
            frmPackM.setItemsPack((decimal)frmPackM.IndexPack);

			frmPackM.ShowDialog ();

            if (frmPackM.changedSettings)
            {
                cbbView_Click(null, null);
               // cbbCancel_Click(sender, e);
            }

            //	result = frmPackM.DialogResult == DialogResult.OK ? frmPackM.gotResult() : null;
        	//if ( result.success )
			//{
			//    MessageBox.Show ( "ok" );
			//}
        }

        private void frm_InPacksMode_eventSaveToNew()
        {


            ////var frmPackM2 = new aorc.gatepass.Gp2.Pack.frm_InpackGP();
            //frmPackM.pmStatus = ItemsPublic.IndexStatus.toNew;
            //frmPackM.IndexPack = null;
            //frmPackM.isNew = true;
            //frmPackM.MainRadGridView.AllowAddNewRow = false;
            //frmPackM.IsnewRowAdded = false;
            //frmPackM.ShowDialog();

            //if (frmPackM.changedSettings)
            //{
            //    cbbView_Click(null, null);
            //    // cbbCancel_Click(sender, e);
            //}

            //uC_rightSidePacksFilter1.UnSelect();


            //frmPackM = new frm_InpackGP ();
            //frmPackM.pmStatus = ItemsPublic.IndexStatus.toNew;
            //frmPackM.IndexPack = null;
            //frmPackM.isNew = true;
            ////	 frmPackM.

            //var frmAddPersons = new aorc.gatepass.Gp2.Pack.frm_SelectOrAddPersonsGp2();
            //frmAddPersons.ShowDialog();
            //if (true || frmAddPersons.DialogResult == DialogResult.OK)
            //{
            //    //	frmAddPersons.ShowDialog();
            //    if (frmAddPersons.State)
            //    {
            //        //MainRadGridView.DataSource=null;
            //        //MainRadGridView.SelectAll();
            //        //frmPackM.MainRadGridView.AllowAddNewRow = true;
            //        frmPackM.IsnewRowAdded = true;
            //        //frmPackM.MainRadGridView.CurrentRow = null;
            //        //MainRadGridView.Rows.RemoveAt(0);
            //        //frmPackM.MainRadGridView.DataSource = null;
            //        //MainRadGridView.EndInit();
            //        //MainRadGridView.EndUpdate();
            //        //	MainRadGridView.EndEdit();
            //        //while (MainRadGridView.Rows.Count > 0)
            //        //{
            //        //    MainRadGridView.Rows.RemoveAt(0);
            //        //}

            //        for (int count = 0; count < frmAddPersons.radGridViewSelected.Rows.Count; count++)
            //        {
            //            #region set rows

            //            frmPackM.MainRadGridView.Rows.AddNew();
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_ID"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_ID"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_NationalCode"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_NationalCode"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_isWoman"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_isWoman"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_IdentifyCode"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_IdentifyCode"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_LicenseDriverCode"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_LicenseDriverCode"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_Name"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Name"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_Surname"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Surname"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_FatherName"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_FatherName"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_BirthCity"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_BirthCity"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_RegisterCity"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_RegisterCity"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_Nationality"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Nationality"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_BirthDate"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_BirthDate"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_Phone1"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Phone1"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_Phone2"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Phone2"].Value;
            //            //						frmPackM.MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_HaveForm"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_HaveForm"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_RegisterCode"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_RegisterCode"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Person_LabelIsWoman"].Value =
            //                frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_LabelIsWoman"].Value;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["Gatepass_ID"].Value = -1;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_IntPrint"].Value = -1;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_IsDriver"].Value = false;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_TimeLock"].Value = null;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_LockerId"].Value = -1;
            //            frmPackM.MainRadGridView.CurrentRow.Cells["package_Id"].Value = -1;
            //            if (frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value != null)
            //            {
            //                using (var ms = new System.IO.MemoryStream())
            //                {
            //                    ((Bitmap) frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value).
            //                        Save(ms,
            //                             System.
            //                                Drawing
            //                                .
            //                                Imaging
            //                                .
            //                                ImageFormat
            //                                .Jpeg);
            //                    var picture = ms.ToArray();
            //                    frmPackM.MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = picture.Length > 0
            //                                                                                            ? picture
            //                                                                                            : null;
            //                }
            //            }
            //            else
            //            {
            //                frmPackM.MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = null;
            //            }

            //            #endregion
            //        }
            //        frmPackM.MainRadGridView.AllowAddNewRow = false;
            //        frmPackM.IsnewRowAdded = false;
            //        //frmPackM.MainRadGridView.Refresh();
            //    }

            //    var frmSet = new aorc.gatepass.Gp2.Pack.frm_SettingPackGatePlaceGp2();
            //    frmSet.ShowDialog();
            //    frmPackM.SetSetting(frmSet.v2UC_NewPackDetailsGp21);
            //    frmPackM.ShowDialog();
            //    //result = frmPackM.gotResult ();
            //    result = frmPackM.DialogResult == DialogResult.OK ? frmPackM.gotResult() : null;

            //    frmPackM.Close();
            //    frmPackM.Dispose();
            //    frmSet.Close ();
            //    frmSet.Dispose ();
            //    frmAddPersons.Close ();
            //    frmAddPersons.Dispose ();
            //}
        }

		void  frm_InPacksMode_eventSaveToSearch()
		{
            //var frm = new frm_3SearchGp2();
            //frm.ShowDialog();
            //if (frm.DialogResult == DialogResult.OK)
            //{
            //    uC_rightSidePacksFilter1.UnSelect();

            //    objManager.ChangeStatus ( aorc.gatepass.ItemsPublic.IndexStatus.toView );

            //    MainRadGridView.DataSource = frm.DTSearch;
            //        MainRadGridView.Enabled = true;
            //        if (MainRadGridView.Rows.Count()==1)
            //        {
            //            MainRadGridView.Rows[0].IsSelected = true;
            //            cbbEdit_Click(null, null);
            //        }
            //        //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;

            //}else
            //{
            //    objManager.ChangeStatus ( aorc.gatepass.ItemsPublic.IndexStatus.toView );
            //    MainRadGridView.Enabled = true;
            //}
            //frm.Close();
		}

		private void frm_InPacksMode_eventSaveToView()
        {
			//AllFunctions._StatusPack? sad = uC_rightSidePacks1.CurrentStatusPack;
            if (uC_rightSidePacksFilter1.CurrentStatusPack == AllFunctions._StatusPack.Confirm)
            {
                result = objManager.View_packages(null, uC_rightSidePacksFilter1.CurrentStatusPack, null, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.WhatState, null);
            }
            else
            {
                result = objManager.View_packages(null, uC_rightSidePacksFilter1.CurrentStatusPack, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.WhatState, null, null);
            }
        }

        private void frm_InPacksMode_eventAfterSave()
        {
            uC_SearchGpOnline1.inFocus();
         	frmPackM.Close ();
			frmPackM.Dispose ();
           // radGridViewPacks_RowsChanged(null,null);
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

        private void frm_InPacksMode_eventStatusDelete()
        {

        }

        private void frm_InPacksMode_eventStatusEdit()
        {
         //   v3UC_PackDetailsGp21.rtbOffice.Focus();
			//cbbSave_Click ( null , null );

        }

        private void frm_InPacksMode_eventStatusNew()
        {
          //  v3UC_PackDetailsGp21.rtbOffice.Focus();
			//cbbSave_Click ( null , null );

        }

        private void frm_InPacksMode_eventStatusSearch()
        {
		

            //v3UC_PackDetailsGp21.rtbOffice.Focus();
        }

        private void frm_InPacksMode_eventStatusView()
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
            toolWindowProperties.Show();
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

		private void v3UC_PackDetailsGp21_eventTickVehicle()
		{

		}

        private void uC_rightSidePacksFilter1_eventNodeNoConfirm()
        {

            MainRadGridView.CurrentRow = null;

            result = objManager.View_packages(false, AllFunctions._StatusPack.NoConfirm, null, null, null, null, null, null, null, null, null, null, null, null, null, null,uC_rightSidePacksFilter1.FilterMode);
            if (result.success)
            {
                copyingMode = true;
                MainRadGridView.DataSource = result.ResultTable;
                copyingMode = false;

            //    MainRadGridView.Columns["package_Id"].SortOrder = RadSortOrder.Descending;
                if (MainRadGridView.Rows.Count() > 0)
                {

                    MainRadGridView.CurrentRow = MainRadGridView.Rows[MainRadGridView.Rows.Count() - 1];
                }
                MainRadGridView.Enabled = true;
                radGridViewPacks_RowsChanged(null,null);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void uC_rightSidePacksFilter1_eventNodeNoPass()
        {
            MainRadGridView.CurrentRow = null;
            result = objManager.View_packages(false, AllFunctions._StatusPack.NoPassage, null, null, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.FilterMode);
            if (result.success)
            {
                copyingMode = true;
                MainRadGridView.DataSource = result.ResultTable;
                copyingMode = false;

             //   MainRadGridView.Columns["package_Id"].SortOrder = RadSortOrder.Descending;
                if (MainRadGridView.Rows.Count() > 0)
                    MainRadGridView.CurrentRow = MainRadGridView.Rows[MainRadGridView.Rows.Count() - 1];
                MainRadGridView.Enabled = true;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
            radGridViewPacks_RowsChanged(null, null);
            
        }

        private void uC_rightSidePacksFilter1_eventNodePassed()
        {
            MainRadGridView.CurrentRow = null;
            //result = objManager.View_packages(false, AllFunctions._StatusPack.Passage, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.WhatGates, null);
            result = objManager.View_packages(false, AllFunctions._StatusPack.Passage, null, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.WhatState, uC_rightSidePacksFilter1.FilterMode);
            if (result.success)
            {
                copyingMode = true;
                MainRadGridView.DataSource = result.ResultTable;
                copyingMode = false;

            //    MainRadGridView.Columns["package_Id"].SortOrder = RadSortOrder.Descending;
                if (MainRadGridView.Rows.Count() > 0)
                    MainRadGridView.CurrentRow = MainRadGridView.Rows[MainRadGridView.Rows.Count() - 1];
                MainRadGridView.Enabled = true;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
            radGridViewPacks_RowsChanged(null, null);
        }

        private void uC_rightSidePacksFilter1_eventNodeWaitConfirm()
        {
            MainRadGridView.CurrentRow = null;
            result = objManager.View_packages(false, AllFunctions._StatusPack.Request, null, null, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.FilterMode);
            if (result.success)
            {
                copyingMode = true;
                MainRadGridView.DataSource = result.ResultTable;
                copyingMode = false;

          //      MainRadGridView.Columns["package_Id"].SortOrder = RadSortOrder.Descending;
                if (MainRadGridView.Rows.Count() > 0)
                    MainRadGridView.CurrentRow = MainRadGridView.Rows[MainRadGridView.Rows.Count() - 1];
                MainRadGridView.Enabled = true;
            }
            else
            {
                MessageBox.Show(result.Message);
            }

            radGridViewPacks_RowsChanged(null, null);
        }


        private void uC_rightSidePacksFilter1_eventNodeWaitPass()
        {
            MainRadGridView.CurrentRow = null;
            result = objManager.View_packages(false, AllFunctions._StatusPack.Confirm, null, null, null, null, null, null, null, null, null, null, null, null, null, uC_rightSidePacksFilter1.WhatState, uC_rightSidePacksFilter1.FilterMode);
            if (result.success)
            {
                copyingMode = true;
                MainRadGridView.DataSource = result.ResultTable;
                copyingMode = false;

          //      MainRadGridView.Columns["package_Id"].SortOrder = RadSortOrder.Descending;
                if (MainRadGridView.Rows.Count() > 0)
                    MainRadGridView.CurrentRow = MainRadGridView.Rows[MainRadGridView.Rows.Count() - 1];
                MainRadGridView.Enabled = true;
            }
            else
            {
                MessageBox.Show(result.Message);
            }

            radGridViewPacks_RowsChanged(null, null);
        }


        private void uC_rightSidePacksFilter1_eventNodeWaitRequest()
        {
            MainRadGridView.CurrentRow = null;
            result = objManager.View_packages(false, AllFunctions._StatusPack.Create, null, null, null, null, null, null, null, null, null, null, null, null, null, null,uC_rightSidePacksFilter1.FilterMode);
            if (result.success)
            {
                copyingMode = true;
                MainRadGridView.DataSource = result.ResultTable;
                copyingMode = false;

           //     MainRadGridView.Columns["package_Id"].SortOrder = RadSortOrder.Descending;
                if (MainRadGridView.Rows.Count() > 0)
                    MainRadGridView.CurrentRow = MainRadGridView.Rows[MainRadGridView.Rows.Count() - 1];
                MainRadGridView.Enabled = true;

            }
            else
            {
                MessageBox.Show(result.Message);
            }
            radGridViewPacks_RowsChanged(null, null);
        }


        private void radGridViewPacks_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if(!copyingMode)
            TextAlaram("تعدا رکورد ها: " + radGridViewPacks.Rows.Count.ToString()+ "            ");
        }

        private void uC_SearchGpOnline1_eventEndSearch()
        {
            uC_rightSidePacksFilter1.UnSelect();
            objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toView);
            copyingMode = true;
            MainRadGridView.DataSource = uC_SearchGpOnline1.Result;
            MainRadGridView.Enabled = true;
            copyingMode = false;

            if (MainRadGridView.Rows.Count() == 1)
            {
                MainRadGridView.Rows[0].IsSelected = true;
                cbbEdit_Click(null, null);
            }
            uC_SearchGpOnline1.rtbSearch.Text = "";
            uC_SearchGpOnline1.inFocus();

            radGridViewPacks_RowsChanged(null, null);
        }

        private void frm_InPacksMode_Shown(object sender, EventArgs e)
        {
            uC_SearchGpOnline1.inFocus();
        }

        private void radGridViewPacks_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            try
            {
                 if (e != null)
                    if (e.RowElement != null)
                        if (!(e.RowElement is GridTableHeaderRowElement))
                        {
                            if (e.RowElement.RowInfo.Cells["TypePack_IsShort"] != null)
                                if (e.RowElement.RowInfo.Cells["TypePack_IsShort"].Value != null)
                                    if (!(bool)e.RowElement.RowInfo.Cells["TypePack_IsShort"].Value)
                                    {
                                        e.RowElement.DrawFill = true;
                                        e.RowElement.BackColor = Color.MediumVioletRed;
                                    }
                        }


            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
            }
        }

    }
}
