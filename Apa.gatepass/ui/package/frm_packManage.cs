using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServerClasses;
using Telerik.WinControls.UI;

namespace aorc.gatepass.ui.package
{
	public partial class frm_packManage : aorc.gatepass.mainForm2
    {
        public frm_packManage()
        {
            InitializeComponent();
        }
        private OutputDatas Models;
        public ItemsPublic.IndexStatus pmStatus;
        public decimal? IndexPack;
        public RadGridView rgvPack { get; set; }
        private void SetModelsCar()
        {
            Models = null;
            Models = new OutputDatas();
            Models = objManager.View_vehiclesType(null,null);
            if (!Models.success)
            {
                ItemsPublic.Exeptor("خطا در بازآوری اطلاعات انواع خودرو");
            }

        }
        public void showPropertiesPack()
        {
            //radgridview
        }
        public void setItemsPack(ref RadGridView rgvInput)
        {
            rgvPack = rgvInput;
        }
        private void frm_packManage_Load(object sender, EventArgs e)
        {
            //setMenuForPakcManager();
            //justViewGrouping((Control)this);
            GroupingControls((Control)this);
            GroupingRadObjects(findRadItems());
            SetModelsCar();            
            if (pmStatus == ItemsPublic.IndexStatus.toEdit)
            {
              //  result = objManager.View_gatePasses(IndexPack);
                cbbView_Click(sender,e);

           //     cbbView_Click(sender, e);
           //     cbbSave_Click(sender, e);
                
                //cbbSave_Click(sender, e);

            }
            if (pmStatus == ItemsPublic.IndexStatus.toNew)
            {
                //result = objManager.View_gatePasses(IndexPack);
               // cbbNew_Click(sender, e);
               // cbbEdit_Click(sender, e);
            }
            setPackInfo();
        }
        private void setPackInfo()
        {

            uC_packDetails1.rtbOffice.Text = rgvPack.CurrentRow.Cells["Office_Name"].Value.ToString();
            switch ((ServerClasses.AllFunctions._TypePack)rgvPack.CurrentRow.Cells["TypePack_Id"].Value)
            {
				case ServerClasses.AllFunctions._TypePack.WorkerMan:
					uC_packDetails1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.WorkerMan;
					break;
				case ServerClasses.AllFunctions._TypePack.WorkerWoman:
					uC_packDetails1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.WorkerWoman;
					break;
				case ServerClasses.AllFunctions._TypePack.TeachTrainee:
					uC_packDetails1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.TeachTrainee;
					break;
				case ServerClasses.AllFunctions._TypePack.TeachUni:
					uC_packDetails1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.TeachUni;
					break;
				case ServerClasses.AllFunctions._TypePack.TeachAct:
					uC_packDetails1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.TeachAct;
					break;
				case ServerClasses.AllFunctions._TypePack.Guest:
					uC_packDetails1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.Guest;
					break;
				case ServerClasses.AllFunctions._TypePack.TempWork:
					uC_packDetails1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.TempWork;
					break;
				case ServerClasses.AllFunctions._TypePack.Company:
					uC_packDetails1.rddlTypePack.SelectedIndex = ( int ) ServerClasses.AllFunctions._TypePack.Company;
					break;
            }
            uC_packDetails1.bdcStartDate.DateTime = (DateTime)rgvPack.CurrentRow.Cells["Package_StartDate"].Value;
            uC_packDetails1.bdcEndDate.DateTime = (DateTime)rgvPack.CurrentRow.Cells["Package_EndDate"].Value;
            uC_packDetails1.rddlValid.SelectedIndex = ((bool)rgvPack.CurrentRow.Cells["Package_IsExpired"].Value) ? 0 : 1;
            uC_packDetails1.rtbNumberAgree.Text = rgvPack.CurrentRow.Cells["Agreement_Number"].Value.ToString();
            string temS = rgvPack.CurrentRow.Cells["Agreement_ID"].Value.ToString();
            decimal? temp = string.IsNullOrEmpty(temS) ? (decimal?)null : decimal.Parse(temS);
            uC_packDetails1.CurrentAgreeId = temp;
            uC_packDetails1.rtbCompanyAgree.Text = rgvPack.CurrentRow.Cells["Agreement_Company"].Value.ToString();
            uC_packDetails1.rtbTitleAgree.Text = rgvPack.CurrentRow.Cells["Agreement_Title"].Value.ToString();

            temS = rgvPack.CurrentRow.Cells["TravelArea_Id"].Value.ToString();
            int? temp2 = string.IsNullOrEmpty(temS) ? (int?)null : int.Parse(temS);
            uC_packDetails1.CurrentTravelId = temp2;

            uC_packDetails1.rtbTravelLabel.Text =
            rgvPack.CurrentRow.Cells["TravelArea_LabelTravel"].Value.ToString();

            uC_packDetails1.rtbOperRequest.Text = rgvPack.CurrentRow.Cells["OperRequestName"].Value.ToString();
            uC_packDetails1.rtbOperConfirm.Text = rgvPack.CurrentRow.Cells["OperConfirmName"].Value.ToString();
            uC_packDetails1.rtbOperPassage.Text = rgvPack.CurrentRow.Cells["OperPassageName"].Value.ToString();
            uC_packDetails1.tbPackDescriptions.Text =
            rgvPack.CurrentRow.Cells["Package_Description"].Value.ToString();
            uC_packDetails1.rcbHaveVehicle.Checked = !string.IsNullOrEmpty(rgvPack.CurrentRow.Cells["Vehicle_ID"].Value.ToString());
            //uC_packDetails1.uC_vehicleDetails1.rddlType.SelectedIndex =
            if (uC_packDetails1.rcbHaveVehicle.Checked)
            {
                uC_packDetails1.uC_vehicleDetails21.rtbModel.Text =
                    rgvPack.CurrentRow.Cells["Vehicle_Model"].Value.ToString();
                uC_packDetails1.uC_vehicleDetails21.rtbColor.Text =
                    rgvPack.CurrentRow.Cells["vehicle_Color"].Value.ToString();
                uC_packDetails1.uC_vehicleDetails21.uC_CarNumber1.CarNumber =
                    rgvPack.CurrentRow.Cells["Vehicle_number"].Value.ToString();
                uC_packDetails1.uC_vehicleDetails21.rddlState.SelectedIndex = (bool)rgvPack.CurrentRow.Cells["Vehicle_IsCompany"].Value ? 0 : 1;
                uC_packDetails1.uC_vehicleDetails21.indexTypeModel =(int?)rgvPack.CurrentRow.Cells["VehicleType_ID"].Value;
            }

        }
        private void ShowPropertiesItems()
        {
            uC_personDetails1.rtbName.Text = MainRadGridView.SelectedRows[0].Cells["Person_Name"].Value.ToString();
            uC_personDetails1.rtbSurname.Text = MainRadGridView.SelectedRows[0].Cells["Person_Surname"].Value.ToString();
            uC_personDetails1.rmebNationalCode.Text = MainRadGridView.SelectedRows[0].Cells["Person_NationalCode"].Value.ToString();

            uC_personDetails1.rtbNationality.Text = MainRadGridView.SelectedRows[0].Cells["Person_Nationality"].Value.ToString();
            uC_personDetails1.rtbFatherName.Text = MainRadGridView.SelectedRows[0].Cells["Person_FatherName"].Value.ToString();
       //     uC_personDetails1.comboCities1.Text = MainRadGridView.SelectedRows[0].Cells["Person_BirthCity"].Value.ToString();
            uC_personDetails1.rtbRegisterCity.Text = MainRadGridView.SelectedRows[0].Cells["Person_RegisterCity"].Value.ToString();
            uC_personDetails1.rmeIdentifyCode.Text = MainRadGridView.SelectedRows[0].Cells["Person_IdentifyCode"].Value.ToString();

          //  string temS = MainRadGridView.SelectedRows[0].Cells["Person_RegisterCode"].Value.ToString();
            //decimal? temp = string.IsNullOrEmpty(temS) ? (decimal?)null : decimal.Parse(temS);
          //  uC_personDetails1.rtbRegisterCode.Text = temS;
            uC_personDetails1.rtbRegisterCode.Text = MainRadGridView.SelectedRows[0].Cells["Person_RegisterCode"].Value.ToString();
            if (!(MainRadGridView.SelectedRows[0].Cells["Person_BirthDate"].Value is DBNull))
            {
                uC_personDetails1.bdcBirthDate.DateTime = (DateTime)MainRadGridView.SelectedRows[0].Cells["Person_BirthDate"].Value;
            }

            uC_personDetails1.rmebLicenseDriveCode.Text = MainRadGridView.SelectedRows[0].Cells["Person_LicenseDriverCode"].Value.ToString();
            uC_personDetails1.rmebPhone1.Text = MainRadGridView.SelectedRows[0].Cells["Person_Phone1"].Value.ToString();
            uC_personDetails1.rmebPhone2.Text = MainRadGridView.SelectedRows[0].Cells["Person_Phone2"].Value.ToString();
            uC_personDetails1.rddlHaveForm.SelectedIndex = ((bool)MainRadGridView.SelectedRows[0].Cells["Person_HaveForm"].Value) ? 0 : 1;
            uC_personDetails1.rddlsex.SelectedIndex = (bool)MainRadGridView.SelectedRows[0].Cells["Person_isWoman"].Value ? 1 : 0;
            if (!(MainRadGridView.SelectedRows[0].Cells["Person_Picture"].Value is DBNull))
            {
                byte[] Picture = ((byte[])MainRadGridView.SelectedRows[0].Cells["Person_Picture"].Value);
                if (Picture.Length > 0)
                {
                    uC_personDetails1.ImgData = Picture;
                }
                else
                {
                    uC_personDetails1.ImgData = new byte[0];
                }
            }
            else
            {
                uC_personDetails1.ImgData = new byte[0];
            }

            //Get BlackList Status from Server
            //var temp = decimal.Parse(MainRadGridView.SelectedRows[0].Cells["Person_ID"].Value.ToString());
            //if (BlackListData.ContainsKey(temp))
            //    uC_personDetails1.rddlIsBlack.SelectedIndex = (BlackListData[temp] == false) ? 1 : 0;
            //else
            //    uC_personDetails1.rddlIsBlack.SelectedIndex = 1;
        }
        private void radGridViewPackManage_SelectionChanged(object sender, EventArgs e)
        {
			SetProperties(ShowPropertiesItems);
		}

        private void frm_packManage_eventSaveToDelete()
        {
           // result = objManager.
        }

        private void frm_packManage_eventSaveToEdit()
        {
            
        }

        private void frm_packManage_eventSaveToNew()
        {
            
        }

        private void frm_packManage_eventSaveToSearch()
        {

        }

        private void frm_packManage_eventSaveToView()
        {
            result = objManager.View_gatePasses(IndexPack);
        }

        private void frm_packManage_eventAfterSave()
        {

        }

        private void frm_packManage_eventStatusDelete()
        {

        }

        private void frm_packManage_eventStatusEdit()
        {

        }

        private void frm_packManage_eventStatusNew()
        {

        }

        private void frm_packManage_eventStatusSearch()
        {

        }

        private void frm_packManage_eventStatusView()
        {

        }

        private void cbbNew_Click(object sender, EventArgs e)
        {
        	var frmAddPersons = new gatepass.ui.package.frm_SelectOrAddPersons4();
            ////   frmAddPersons.pmStatus = ItemsPublic.IndexStatus.toEdit;
            // //  frmAddPersons.IndexPack = (decimal?)MainRadGridView.CurrentRow.Cells["package_Id"].Value;
            // //  frmAddPersons.setItemsPack(ref radGridViewPacks);
               frmAddPersons.ShowDialog();
        	if (frmAddPersons.State)
        	{
        		radGridViewPackManage.DataSource = frmAddPersons.radGridViewSelected;
        		//radGridViewPackManage.Enabled = true;
        	}
               frmAddPersons.Close();
               frmAddPersons.Dispose();
        }

		private void uC_personDetails1_Load(object sender, EventArgs e)
		{

		}
    }
}
