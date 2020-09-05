using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using aorc.gatepass.Complex_Reports;
using ServerClasses;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;


namespace aorc.gatepass.Complex_Reports.Reporter
{
    public partial class MainReporter : Form
    {


        ReportInOut.UC_InOutView ucPropertyInOutView;

        UC_ViewPersonDetails ucPropertyPerson;
        ReportPerson.UC_ReportSearchPerson ucSearchPerson;

        UC_agreementsDetails ucPropertyAgree;
        ReportGH.UC_ReportSearchAgree ucSearchAgree;

        UC_officeDetails ucPropertyOffice;
        ReportOffice.UC_ReportSearchOffice ucSearchOffice;

        ui.vehicle.UC_vehicleDetails3 ucPropertyVeh;
        ReportVeh.UC_ReportSearchVehicle ucSearchVeh;

        Gp2.Pack.V3UC_PackDetailsGp2 ucPropertyPack;
        ReportGP.UC_ReportSearchGP ucSearchGP;

        ReportPassingEsmaeil.UC_PageGp ucPropertyInOut;
        ReportPassingEsmaeil.UC_TagSearch ucSearchInOut;

        #region Columns

        GridViewDecimalColumn gridViewDecimalColumnPerson1;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson1;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson2;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson3;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson4;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson5;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson6;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson7;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson8;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson9;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson10;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson11;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson12;
        GridViewCheckBoxColumn gridViewCheckBoxColumnPerson1;
        GridViewDateTimeColumn gridViewDateTimeColumnPerson1;
        GridViewCheckBoxColumn gridViewCheckBoxColumnPerson2;
        GridViewImageColumn gridViewImageColumnPerson1;
        GridViewDateTimeColumn gridViewDateTimeColumnPerson2;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson13;
        GridViewCheckBoxColumn gridViewCheckBoxColumnPerson3;
        GridViewCheckBoxColumn gridViewCheckBoxColumnPerson4;

        GridViewTextBoxColumn gridViewTextBoxColumnAgreement1;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement2;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement3;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement4;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement5;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement6;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement7;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement8;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement9;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement10;
        GridViewDateTimeColumn gridViewDateTimeColumnAgreement1;
        GridViewDateTimeColumn gridViewDateTimeColumnAgreement2;
        GridViewCheckBoxColumn gridViewCheckBoxColumnAgreement1;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement11;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement12;
        GridViewCheckBoxColumn gridViewCheckBoxColumnAgreement2;


        GridViewTextBoxColumn gridViewTextBoxColumnOff1;
        GridViewTextBoxColumn gridViewTextBoxColumnOff2;
        GridViewCheckBoxColumn gridViewCheckBoxColumnOff1;
        GridViewTextBoxColumn gridViewTextBoxColumnOff3;
        GridViewTextBoxColumn gridViewTextBoxColumnOff4;
        GridViewTextBoxColumn gridViewTextBoxColumnOff5;
        GridViewTextBoxColumn gridViewTextBoxColumnOff6;
        GridViewTextBoxColumn gridViewTextBoxColumnOff7;
        GridViewTextBoxColumn gridViewTextBoxColumnOff8;
        GridViewTextBoxColumn gridViewTextBoxColumnOff9;
        GridViewTextBoxColumn gridViewTextBoxColumnOff10;
        GridViewTextBoxColumn gridViewTextBoxColumnOff11;

        GridViewDecimalColumn gridViewDecimalColumnVeh1;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh1;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh2;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh3;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh4;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh5;
        GridViewCheckBoxColumn gridViewCheckBoxColumnVeh1;
        GridViewCheckBoxColumn gridViewCheckBoxColumnVeh2;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh6;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh7;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh8;

        #region Pack and GatePass

        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack1;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack2;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack3;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack4;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack5;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack6;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack7;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack1;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack2;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack8;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack9;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack10;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack3;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack4;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack11;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack5;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack6;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack7;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack8;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack9;
        Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumnPack1;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack12;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack10;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack11;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack12;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack13;
        Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumnPack1;
        Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumnPack2;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack13;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack14;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack15;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack16;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack14;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack15;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack16;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack17;

        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnGatePass1;
        Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumnGatePass1;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass1;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass2;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass3;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass4;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass5;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass6;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass7;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass8;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass9;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass10;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass11;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass12;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass13;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass14;
        Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumnGatePass1;
        Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumnGatePass2;
        Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumnGatePass1;
        Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumnGatePass2;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass15;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass16;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass17;
        Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumnGatePass3;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass18;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnGatePass2;
        //Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnGatePass3 ;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnGatePass4;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnGatePass5;
        Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumnGatePass3;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass19;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnGatePass6;
        Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumnGatePass4;
        Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumnGatePass5;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass20;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass21;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass22;

        #endregion


        #endregion

        protected Manager objManager;
        protected OutputDatas result;
        bool stateIsnewRowAdded = false;
        public enum _State : int
        {
            _None = 0,
            _Person = 1,
            _agreement = 2,
            _office = 3,
            _vehicle = 4,
            _gatepass = 5,
            _blacklist = 6,
            _operator = 7,
            _Inout = 8
        }
        _State CurrentState = _State._None;

        public MainReporter()
        {
            try
            {
                InitializeComponent();
                //     objManager = new Manager();
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                this.Close();
            }
        }

        private void showMyProperties()
        {
            switch (CurrentState)
            {
                case _State._None:
                    break;
                case _State._Person:
                    showPersonPro();
                    break;
                case _State._agreement:
                    showAgreePro();
                    break;
                case _State._office:
                    showOffPro();
                    break;
                case _State._vehicle:
                    showVehPro();
                    break;
                case _State._gatepass:
                    showGPPro();
                    break;
                case _State._blacklist:
                    showBLPro();
                    break;
                case _State._operator:
                    showOperPro();
                    break;
                case _State._Inout:
                    showInOutPro();
                    break;
                default:
                    break;
            }
        }

        private void showInOutPro()
        {
            ucPropertyInOut.clearItems();
            ucPropertyInOut.setItems(radGridViewReport.CurrentRow);
            //result.MiniTable1
            //foreach (var item in result.MiniTable1.Rows)
            //{
            ////    item[0].
            //}
            ucPropertyInOutView.Show(result.MiniTable1, (decimal)radGridViewReport.CurrentRow.Cells["Archive_ID"].Value);
        }

        private void showOperPro()
        {
            throw new NotImplementedException();
        }

        private void showBLPro()
        {
            throw new NotImplementedException();
        }

        private void showGPPro()
        {
            ucPropertyVeh.clearItems();
            //  ucPropertyPerson.clearItems();
            ucPropertyPack.clearItems();
            //  ucPropertyAgree.clearItems();
            //  ucPropertyOffice.clearItems();

            // uC_ViewEvents1.rtbEvents.Text = MainRadGridView.CurrentRow.Cells["Package_Events"].Value.ToString();

            // ========================================================
            var result = new OutputDatas();
            var objGateManager = new Manager();

            var IndexPack = (decimal?)radGridViewReport.CurrentRow.Cells["package_Id"].Value;
            result = objGateManager.View_Gates(IndexPack);
            if (result.success)
            {
                ucPropertyPack.rtbGates.Text = "";
                ucPropertyPack.CurrentGates = new List<int>();
                foreach (DataRow obj in result.ResultTable.Rows)
                {
                    //	string ss = obj.Cells["Gate_Id"].Value.ToString().Trim();
                    //int ii = int.Parse(obj.Cells["Gate_Id"].Value.ToString().Trim());
                    ucPropertyPack.CurrentGates.Add(int.Parse(obj["Gate_Id"].ToString().Trim()));
                    ucPropertyPack.rtbGates.Text += obj["Gate_Name"].ToString().Trim() + "\r\n";
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
                ucPropertyPack.rtbPlaces.Text = "";
                ucPropertyPack.CurrentPlaces = new List<int>();
                foreach (DataRow obj in result.ResultTable.Rows)
                {
                    //	string ss = obj.Cells["Place_Id"].Value.ToString().Trim();
                    //int ii = int.Parse(obj.Cells["Place_Id"].Value.ToString().Trim());
                    ucPropertyPack.CurrentPlaces.Add(int.Parse(obj["Place_Id"].ToString().Trim()));
                    ucPropertyPack.rtbPlaces.Text += obj["Place_Name"].ToString().Trim() + "\r\n";
                }
            }
            else
            {
                ItemsPublic.ShowMessage(result.Message);
            }

            ucPropertyPack.rddlShift.Text = radGridViewReport.CurrentRow.Cells["Package_Shift"].Value.ToString().Trim();

            ucPropertyPack.rtbStatusPack.Text = radGridViewReport.CurrentRow.Cells["StatusPack_Label"].Value.ToString().Trim();
            ucPropertyPack.rtbPackId.Text = radGridViewReport.CurrentRow.Cells["Package_TicketId"].Value.ToString().Trim();
            ucPropertyPack.rtbOffice.Text = radGridViewReport.CurrentRow.Cells["Office_Name"].Value.ToString().Trim();
            switch ((ServerClasses.AllFunctions._TypePack)radGridViewReport.CurrentRow.Cells["TypePack_Id"].Value)
            {
                case ServerClasses.AllFunctions._TypePack.WorkerMan:
                    ucPropertyPack.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.WorkerMan;
                    break;
                case ServerClasses.AllFunctions._TypePack.WorkerWoman:
                    ucPropertyPack.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.WorkerWoman;
                    break;
                case ServerClasses.AllFunctions._TypePack.TeachTrainee:
                    ucPropertyPack.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.TeachTrainee;
                    break;
                case ServerClasses.AllFunctions._TypePack.TeachUni:
                    ucPropertyPack.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.TeachUni;
                    break;
                case ServerClasses.AllFunctions._TypePack.TeachAct:
                    ucPropertyPack.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.TeachAct;
                    break;
                case ServerClasses.AllFunctions._TypePack.Guest:
                    ucPropertyPack.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.Guest;
                    break;
                case ServerClasses.AllFunctions._TypePack.TempWork:
                    ucPropertyPack.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.TempWork;
                    break;
                case ServerClasses.AllFunctions._TypePack.Company:
                    ucPropertyPack.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.Company;
                    break;
                case ServerClasses.AllFunctions._TypePack.CardPublic:
                    ucPropertyPack.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.CardPublic;
                    break;
                case ServerClasses.AllFunctions._TypePack.CardCompany:
                    ucPropertyPack.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.CardCompany;
                    break;

                case ServerClasses.AllFunctions._TypePack.CardArmy:
                    ucPropertyPack.rddlTypePack.SelectedIndex = (int)ServerClasses.AllFunctions._TypePack.CardArmy;
                    break;
            }
            ucPropertyPack.bdcStartDate.DateTime = (DateTime)radGridViewReport.CurrentRow.Cells["Package_StartDate"].Value;
            ucPropertyPack.bdcEndDate.DateTime = (DateTime)radGridViewReport.CurrentRow.Cells["Package_EndDate"].Value;
            ucPropertyPack.rddlValid.SelectedIndex = ((bool)radGridViewReport.CurrentRow.Cells["Package_IsExpired"].Value)
                                                                ? 0
                                                                : 1;
            ucPropertyPack.rtbNumberAgree.Text = radGridViewReport.CurrentRow.Cells["Agreement_Number"].Value.ToString().Trim();
            string temS = radGridViewReport.CurrentRow.Cells["Agreement_ID"].Value.ToString().Trim();
            decimal? temp = string.IsNullOrEmpty(temS) ? (decimal?)null : decimal.Parse(temS);
            ucPropertyPack.CurrentAgreeId = temp;
            ucPropertyPack.rtbCompanyAgree.Text = radGridViewReport.CurrentRow.Cells["Agreement_Company"].Value.ToString().Trim();
            //	ucPropertyPack.rtbTitleAgree.Text = radGridViewReport.CurrentRow.Cells["Agreement_Title"].Value.ToString().Trim();
            ucPropertyPack.rlblCountCar.Text = ItemsPublic.HowManyCarInAgree(temp);


            temS = radGridViewReport.CurrentRow.Cells["TravelArea_Id"].Value.ToString().Trim();
            int? temp2 = string.IsNullOrEmpty(temS) ? (int?)null : int.Parse(temS);
            ucPropertyPack.CurrentTravelId = temp2;

            ucPropertyPack.rtbTravelLabel.Text =
                radGridViewReport.CurrentRow.Cells["TravelArea_LabelTravel"].Value.ToString().Trim();

            ucPropertyPack.rtbOperRequest.Text = radGridViewReport.CurrentRow.Cells["OperRequestName"].Value.ToString().Trim();
            ucPropertyPack.rtbOperConfirm.Text = radGridViewReport.CurrentRow.Cells["OperConfirmName"].Value.ToString().Trim();
            ucPropertyPack.rtbOperPassage.Text = radGridViewReport.CurrentRow.Cells["OperPassageName"].Value.ToString().Trim();
            ucPropertyPack.tbPackDescriptions.Text =
                radGridViewReport.CurrentRow.Cells["Package_Description"].Value.ToString().Trim();


            showPersonPro();
            if (!string.IsNullOrEmpty(radGridViewReport.CurrentRow.Cells["Vehicle_ID"].Value.ToString()))
            {
                showVehPro();
            }

        }

        private void showAgreePro()
        {
            ucPropertyAgree.rmebNumber.Text = radGridViewReport.CurrentRow.Cells["Agreement_Number"].Value.ToString();
            ucPropertyAgree.rtbTitle.Text = radGridViewReport.CurrentRow.Cells["Agreement_Title"].Value.ToString();
            ucPropertyAgree.rtbCompany.Text = radGridViewReport.CurrentRow.Cells["Agreement_Company"].Value.ToString();
            ucPropertyAgree.rmebPhone.Text = radGridViewReport.CurrentRow.Cells["Agreement_AgentPhone"].Value.ToString();
            ucPropertyAgree.rtbAgentName.Text = radGridViewReport.CurrentRow.Cells["Agreement_AgentName"].Value.ToString();
            ucPropertyAgree.bdcEndDate1.DateTime = (DateTime)radGridViewReport.CurrentRow.Cells["Agreement_EndDate"].Value;
            ucPropertyAgree.bdcStartDate1.DateTime = (DateTime)radGridViewReport.CurrentRow.Cells["Agreement_StartDate"].Value;
            ucPropertyAgree.tbDescriptions.Text = radGridViewReport.CurrentRow.Cells["Agreement_Description"].Value.ToString();
            ucPropertyAgree.rddlActive.SelectedIndex = ((bool)radGridViewReport.CurrentRow.Cells["Agreement_IsActive"].Value == true) ? 0 : 1;
            ucPropertyAgree.rtbManagerName.Text = radGridViewReport.CurrentRow.Cells["Agreement_ManagerName"].Value.ToString();
            ucPropertyAgree.rtbAdress.Text = radGridViewReport.CurrentRow.Cells["Agreement_Adress"].Value.ToString();
            ucPropertyAgree.rmebPhoneCompany.Text = radGridViewReport.CurrentRow.Cells["Agreement_ManagerTell"].Value.ToString();
            ucPropertyAgree.rddlTypeAgree.SelectedIndex = ((bool)radGridViewReport.CurrentRow.Cells["Agreement_IsIndustrial"].Value == true) ? 0 : 1;
            ucPropertyAgree.rmebCountCar.Text = radGridViewReport.CurrentRow.Cells["Agreement_CountCars"].Value.ToString();
        }

        private void showPersonPro()
        {

            ucPropertyPerson.rtbName.Text = radGridViewReport.SelectedRows[0].Cells["Person_Name"].Value.ToString();
            ucPropertyPerson.rtbSurname.Text = radGridViewReport.SelectedRows[0].Cells["Person_Surname"].Value.ToString();
            ucPropertyPerson.rmebNationalCode.Text =
            radGridViewReport.SelectedRows[0].Cells["Person_NationalCode"].Value.ToString();

            ucPropertyPerson.TcoNationality.Text =
            radGridViewReport.SelectedRows[0].Cells["Person_Nationality"].Value.ToString().Trim();
            ucPropertyPerson.rtbFatherName.Text = radGridViewReport.SelectedRows[0].Cells["Person_FatherName"].Value.ToString();
            ucPropertyPerson.TcoBirthCity.Text = (radGridViewReport.SelectedRows[0].Cells["Person_BirthCity"].Value.ToString().Trim());
            ucPropertyPerson.TcoRegisterCity.Text = (radGridViewReport.SelectedRows[0].Cells["Person_RegisterCity"].Value.ToString().Trim());
            ucPropertyPerson.rmeIdentifyCode.Text =
                radGridViewReport.SelectedRows[0].Cells["Person_IdentifyCode"].Value.ToString();

            ucPropertyPerson.rtbRegisterCode.Text = radGridViewReport.CurrentRow.Cells["Person_RegisterCode"].Value.ToString();
            if (!(radGridViewReport.SelectedRows[0].Cells["Person_BirthDate"].Value is DBNull))
            {
                ucPropertyPerson.bdcBirthDate.DateTime =
                    (DateTime)radGridViewReport.SelectedRows[0].Cells["Person_BirthDate"].Value;
            }
            else
            {
                ucPropertyPerson.bdcBirthDate.DateTime = (DateTime?)null;
            }

            if (!(radGridViewReport.SelectedRows[0].Cells["Person_SecureFormDate"].Value is DBNull))
            {
                ucPropertyPerson.bdcEndSecureDate.DateTime =
                    (DateTime)radGridViewReport.SelectedRows[0].Cells["Person_SecureFormDate"].Value;
            }
            else
            {
                ucPropertyPerson.bdcEndSecureDate.DateTime = (DateTime?)null;
            }


            ucPropertyPerson.rmebLicenseDriveCode.Text =
                radGridViewReport.SelectedRows[0].Cells["Person_LicenseDriverCode"].Value.ToString();
            ucPropertyPerson.rmebPhone1.Text = radGridViewReport.SelectedRows[0].Cells["Person_Phone1"].Value.ToString();
            ucPropertyPerson.rmebPhone2.Text = radGridViewReport.SelectedRows[0].Cells["Person_Phone2"].Value.ToString();
            ucPropertyPerson.TcoHaveForm.Text =
                ((bool)radGridViewReport.SelectedRows[0].Cells["Person_HaveForm"].Value) ? "دارد" : "ندارد";
            ucPropertyPerson.TcoSex.Text = (bool)radGridViewReport.SelectedRows[0].Cells["Person_isWoman"].Value
                                                       ? "مونث"
                                                    : "مذکر";
            if (!(radGridViewReport.SelectedRows[0].Cells["Person_Picture"].Value is DBNull))
            {
                byte[] Picture = ((byte[])radGridViewReport.SelectedRows[0].Cells["Person_Picture"].Value);
                if (Picture.Length > 0)
                {
                    ucPropertyPerson.ImgData = Picture;
                }
                else
                {
                    ucPropertyPerson.ImgData = new byte[0];
                }
            }
            else
            {
                ucPropertyPerson.ImgData = new byte[0];
            }

            //Get BlackList Status from Server
            //if (ItemsPublic.MyRights.Contains(ServerClasses.AllFunctions._Rights.View_persons))
            //{
            //   var temp = decimal.Parse(radGridViewReport.SelectedRows[0].Cells["Person_ID"].Value.ToString());
            //if (BlackListData.ContainsKey(temp))
            ucPropertyPerson.TcoIsBlack.Text = ((bool)radGridViewReport.SelectedRows[0].Cells["Person_IsBlackTemp"].Value) ? "مسدود" : "عادی";
            //(BlackListData[temp] == false) ? 1 : 0;
            // else
            // ItemsPublic.Exeptor("وضعیت فرد مورد نظر در سیستم وجود ندارد");
            //}
            //else
            //{
            //    ucPropertyPerson.rddlIsBlack.SelectedIndex = 1;
            //}
            // ucPropertyPerson.rddlIsBlack.SelectedIndex = 1;
        }

        private void showOffPro()
        {

            var kkk = radGridViewReport.CurrentRow.Cells["Office_ParentId"].Value.ToString();
            ucPropertyOffice.newParentId = (string.IsNullOrEmpty(kkk) ? (int?)null : int.Parse(kkk));
            //   ucPropertyOffice.newParentId = kkk;
            ucPropertyOffice.rtbOfficeName.Text = radGridViewReport.CurrentRow.Cells["Office_Name"].Value.ToString();
            var pName = radGridViewReport.CurrentRow.Cells["Office_ParentName"].Value;
            ucPropertyOffice.rtbOfficeParent.Text = (pName != null) ? pName.ToString() : "";

            //radGridViewReport.CurrentRow.Cells["Office_ParentName"].Value.ToString();
            ucPropertyOffice.rddlActive.SelectedIndex =
                ((bool)radGridViewReport.CurrentRow.Cells["Office_Active"].Value == true) ? 0 : 1;
            ucPropertyOffice.rmebPhone1.Text = radGridViewReport.CurrentRow.Cells["Office_Phone1"].Value.ToString();
            ucPropertyOffice.rmebPhone2.Text = radGridViewReport.CurrentRow.Cells["Office_Phone2"].Value.ToString();
            ucPropertyOffice.rsemonth.Value =
                int.Parse(radGridViewReport.CurrentRow.Cells["Office_MonthlyGPAllowed"].Value.ToString());
            ucPropertyOffice.rseRemindMonth.Value =
                int.Parse(radGridViewReport.CurrentRow.Cells["Office_MonthlyRemindGp"].Value.ToString());
            ucPropertyOffice.rseDay.Value =
                int.Parse(radGridViewReport.CurrentRow.Cells["Office_DailyGPAllowed"].Value.ToString());
            ucPropertyOffice.rseRemindDay.Value =
                int.Parse(radGridViewReport.CurrentRow.Cells["Office_DailyRemindGp"].Value.ToString());
            ucPropertyOffice.tbDescriptions.Text =
                radGridViewReport.CurrentRow.Cells["Office_Description"].Value.ToString();



        }

        private void showVehPro()
        {
            ucPropertyVeh.rtbColor.Text = radGridViewReport.CurrentRow.Cells["vehicle_Color"].Value.ToString();
            ucPropertyVeh.rtbModel.Text = radGridViewReport.CurrentRow.Cells["Vehicle_Model"].Value.ToString();

            ucPropertyVeh.uC_PlatesCar1.rddlTypePlate.SelectedIndex = (int)radGridViewReport.CurrentRow.Cells["TypePlates_Id"].Value;
            ucPropertyVeh.uC_PlatesCar1.CarNumber = radGridViewReport.CurrentRow.Cells["Vehicle_number"].Value.ToString();

            ucPropertyVeh.rddlState.SelectedIndex =
                ((bool)radGridViewReport.CurrentRow.Cells["Vehicle_IsCompany"].Value) ? 0 : 1;

            ucPropertyVeh.indexTypeModel = (int)radGridViewReport.CurrentRow.Cells["VehicleType_ID"].Value;
        }

        private void emptyProperties()
        {

        }

        protected void SetProperties()
        {
            try
            {
                if (!stateIsnewRowAdded)
                {
                    if (radGridViewReport.SelectedRows.Count == 1)
                    {
                        showMyProperties();
                    }
                    else
                    {
                        emptyProperties();
                    }
                }
            }
            catch (Exception ex)
            {
                //ItemsPublic.ShowMessage(ex.Message);
                ItemsPublic.ShowMessage(ex.Message);
                //  this.Close();
            }
        }

        private void menuService_ContextMenuDisplaying(object sender, ContextMenuDisplayingEventArgs e)
        {
            //the menu request is associated with a valid DockWindow instance, which resides within a DocumentTabStrip
            if (e.MenuType == ContextMenuType.DockWindow &&
                e.DockWindow.DockTabStrip is DocumentTabStrip)
            {
                //remove the "Close" menu items
                foreach (RadMenuItemBase menuItem in e.MenuItems)
                {
                    if (menuItem.Name == "CloseWindow" ||
                        menuItem.Name == "CloseAllButThis" ||
                        menuItem.Name == "CloseAll" ||
                        menuItem is RadMenuSeparatorItem)
                    {
                        // In case you just want to disable to option you can set Enabled false
                        // menuItem.Enabled = false;
                        menuItem.Text = "سلام";
                        // menuItem.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
                    }
                }
            }
        }

        protected void CursorWait()
        {
            this.UseWaitCursor = true;
            this.Cursor = Cursors.WaitCursor;
        }

        protected void CursorDefault()
        {
            this.UseWaitCursor = false;
            this.Cursor = Cursors.Default;
        }

        protected void cbbDoEmpty_Click(object sender, EventArgs e)
        {
            try
            {
                switch (CurrentState)
                {
                    case _State._None:
                        break;
                    case _State._Person:
                        ucSearchPerson.clearItenms();
                        break;
                    case _State._agreement:
                        ucSearchAgree.clearItenms();
                        break;
                    case _State._office:
                        ucSearchOffice.clearItenms();
                        break;
                    case _State._vehicle:
                        ucSearchVeh.clearItenms();
                        break;
                    case _State._gatepass:
                        ucSearchGP.clearItenms();
                        break;
                    case _State._blacklist:
                        break;
                    case _State._operator:
                        break;
                    case _State._Inout:
                        break;
                    default:
                        throw new Exception("وضعیت در بخش گزارشات نا معلوم می باشد");
                }
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
            }

        }

        protected void cbbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentState == _State._Person && radGridViewReport.SelectedRows.Count>0)
                {
                    CursorWait();
                     var frmPackM2 = new aorc.gatepass.Gp2.Pack.frm_InpackGP();
						frmPackM2.pmStatus = ItemsPublic.IndexStatus.toNew;
        				frmPackM2.IndexPack = null;
        				frmPackM2.isNew = true;
						frmPackM2.MainRadGridView.AllowAddNewRow = false;
        				frmPackM2.IsnewRowAdded = false;
                        frmPackM2.SeletedPersons(radGridViewReport.SelectedRows);
						frmPackM2.ShowDialog ();
						frmPackM2.Close();
        				frmPackM2.Dispose();
                        CursorDefault();
                }
            }
            catch (Exception ex)
            {
                CursorDefault();
                ItemsPublic.ShowMessage(ex.Message);
            }
        }

        private void cbbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //:-)//   eventStatusDelete();
                radGridViewReport.Enabled = true;
                objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toDelete);
                //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toDelete;
                cbbSave_Click(sender, e);
                cbbCancel_Click(sender, e);
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }
        }

        private void cbbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                CursorWait();
                //  stateIsnewRowAdded = true;
                uC_TreeReport1.Enabled = false;
                radGridViewReport.Enabled = false;
                radGridViewReport.CurrentRow = null;
                radLabelElementStatus.Text = "";
                result = null;
                //  objManager = new Manager();
                DateTime? Package_StartDate = null;
                DateTime? Package_StartDate2 = null;

                switch (CurrentState)
                {
                    case _State._None:
                        break;
                    case _State._Person:
                        #region _Person
                        bool? Person_isWoman = null;
                        bool? Person_HaveForm = null;
                        bool? Person_Picture = null;
                        bool? BlackList_isBlack = null;

                        if (ucSearchPerson.rddlsex.SelectedIndex != -1)
                            Person_isWoman = ucSearchPerson.rddlsex.SelectedIndex == 1;
                        if (ucSearchPerson.rddlHaveForm.SelectedIndex != -1)
                            Person_HaveForm = ucSearchPerson.rddlHaveForm.SelectedIndex == 0;
                        //if (ucSearchPerson.rddlIsBlack.SelectedIndex != -1)
                        //    BlackList_isBlack = ucSearchPerson.rddlIsBlack.SelectedIndex == 0;

                        Package_StartDate = (ucSearchPerson.bdcStartDate1.SelectedDate != null) ? ucSearchPerson.bdcStartDate1.SelectedDate.Value : (DateTime?)null;
                        Package_StartDate2 = (ucSearchPerson.bdcStartDate2.SelectedDate != null) ? ucSearchPerson.bdcStartDate2.SelectedDate.Value : (DateTime?)null;
                        result = objManager.View_personsComplex(
                            Person_isWoman, Person_HaveForm,
                            Person_Picture, BlackList_isBlack,
                            ucSearchPerson.rtbName.Text.Trim(),
                            ucSearchPerson.rtbSurname.Text.Trim(),
                            ucSearchPerson.rmebNationalCode.Text.Trim(),
                            ucSearchPerson.rmeIdentifyCode.Text.Trim(),
                            ucSearchPerson.rmebLicenseDriveCode.Text.Trim(),
                            ucSearchPerson.rtbRegisterCode.Text.Trim(),
                            string.Empty,
                            ucSearchPerson.uC_SelCaseVeh.CaseId(), (int?)ucSearchPerson.uC_SelCaseOff.CaseId(),
                            ucSearchPerson.uC_SelCaseAgree.CaseId(), (int?)ucSearchPerson.uC_SelCaseWP.CaseId(),
                            Package_StartDate, Package_StartDate2);
                        #endregion
                        break;
                    case _State._agreement:
                        bool? boolIsIndusterial = null;
                        bool? Isreport = true;
                        if (ucSearchAgree.rddlTypeAgree.SelectedIndex != -1)
                        {
                            boolIsIndusterial = ucSearchAgree.rddlTypeAgree.SelectedIndex == 0;
                        }

                        Package_StartDate = (ucSearchAgree.bdcStartDate1.SelectedDate != null) ? ucSearchAgree.bdcStartDate1.SelectedDate.Value : (DateTime?)null;
                        Package_StartDate2 = (ucSearchAgree.bdcStartDate2.SelectedDate != null) ? ucSearchAgree.bdcStartDate2.SelectedDate.Value : (DateTime?)null;


                        result = objManager.View_agreementsComplex(
                            null, null, null, null, ucSearchAgree.rtbManagerName.Text.Trim(), ucSearchAgree.rtbAgentName.Text.Trim()
                            , ucSearchAgree.rtbCompany.Text.Trim(), boolIsIndusterial, ucSearchAgree.rmebNumber.Text.Trim()
                            , ucSearchAgree.uC_SelCaseVeh.CaseId(), (int?)ucSearchAgree.uC_SelCaseOff.CaseId()
                            , ucSearchAgree.uC_SelCasePerson.CaseId()
                            , Package_StartDate, Package_StartDate2, Isreport);
                        break;
                    case _State._office:
                        Package_StartDate = (ucSearchOffice.bdcStartDate1.SelectedDate != null) ? ucSearchOffice.bdcStartDate1.SelectedDate.Value : (DateTime?)null;
                        Package_StartDate2 = (ucSearchOffice.bdcStartDate2.SelectedDate != null) ? ucSearchOffice.bdcStartDate2.SelectedDate.Value : (DateTime?)null;
                        result = objManager.View_officesComplex(ucSearchOffice.rtbOfficeName.Text.Trim()
                            , ucSearchOffice.uC_SelCaseAgree.CaseId()
                            , ucSearchOffice.uC_SelCasePerson.CaseId()
                            , Package_StartDate, Package_StartDate2
                            ,true);
                        break;
                    case _State._vehicle:
                        Package_StartDate = (ucSearchVeh.bdcStartDate1.SelectedDate != null) ? ucSearchVeh.bdcStartDate1.SelectedDate.Value : (DateTime?)null;
                        Package_StartDate2 = (ucSearchVeh.bdcStartDate2.SelectedDate != null) ? ucSearchVeh.bdcStartDate2.SelectedDate.Value : (DateTime?)null;
                        result = objManager.View_vehiclesComplex(ucSearchVeh.uC_vehicleDetailsSearch1.indexTypeModel,
                            ucSearchVeh.uC_vehicleDetailsSearch1.uC_PlatesCar1.rddlTypePlate.SelectedIndex
                            , ucSearchVeh.uC_vehicleDetailsSearch1.uC_PlatesCar1.CarNumber
                            , ucSearchVeh.uC_vehicleDetailsSearch1.rddlState.SelectedIndex
                            , ucSearchVeh.uC_vehicleDetailsSearch1.rtbModel.Text.Trim()
                            , ucSearchVeh.uC_SelCasePerson.CaseId(), ucSearchVeh.uC_SelCaseAgree.CaseId()
                            , (int?)ucSearchVeh.uC_SelCaseOff.CaseId()
                            , Package_StartDate, Package_StartDate2);
                        break;
                    case _State._gatepass:
                        //   ReportGp
                        Package_StartDate = (ucSearchGP.bdcStartDate1.SelectedDate != null)
                            ? ucSearchGP.bdcStartDate1.SelectedDate.Value : (DateTime?)null;
                        Package_StartDate2 = (ucSearchGP.bdcStartDate2.SelectedDate != null)
                            ? ucSearchGP.bdcStartDate2.SelectedDate.Value : (DateTime?)null;
                        result = objManager.ReportGp(ucSearchGP.uC_SelCaseAgree.CaseId()
                                                     , (int?)ucSearchGP.uC_SelCaseOff.CaseId()
                                                     , (int?)ucSearchGP.uC_SelCaseWP.CaseId()
                                                     , ucSearchGP.uC_SelCasePerson.CaseId()
                                                     , ucSearchGP.uC_SelCaseVeh.CaseId()
                                                     , (int?)ucSearchGP.uC_SelCaseRequest.CaseId()
                                                     , (int?)ucSearchGP.uC_SelCaseConfirm.CaseId()
                                                     , (int?)ucSearchGP.uC_SelCasePassage.CaseId()
                                                     , ucSearchGP.rddlPrint.SelectedIndex
                                                     , ucSearchGP.rddlTypePack.SelectedIndex
                                                     , Package_StartDate
                                                     , Package_StartDate2
                                                     );

                        toolWindowSecondProperties.Show();
                        toolTabStrip4.SelectedIndex = 1;
                        break;
                    case _State._blacklist:
                        break;
                    case _State._operator:
                        break;
                    case _State._Inout:
                        Package_StartDate = (ucSearchInOut.bdcStartDate1.SelectedDate != null)
                            ? ucSearchInOut.bdcStartDate1.SelectedDate.Value : (DateTime?)null;
                        Package_StartDate2 = (ucSearchInOut.bdcStartDate2.SelectedDate != null)
                            ? ucSearchInOut.bdcStartDate2.SelectedDate.Value : (DateTime?)null;
                        result = objManager.ReportInOut(ucSearchInOut.uC_SelCasePerson.CaseId()
                                                       , ucSearchInOut.uC_SelCaseVeh.CaseId()
                                                       , null, Package_StartDate, Package_StartDate2)
                                                       ;
                        break;
                    default:
                        break;
                }
                if (result != null)
                    if (result.success)
                    {
                        copyingMode = true;
                        radGridViewReport.DataSource = result.ResultTable;
                        copyingMode = false;
                        if (radGridViewReport.Rows.Count < 1)
                        {
                            ItemsPublic.ShowMessage("موردی یافت نشد");
                        }
                        else
                        {
                            radLabelElementStatus.Text = "                         " + "تعداد موارد یافت شده: " + radGridViewReport.Rows.Count.ToString() + "                         ";
                            //radLabelElementStatus.LabelFill.BackColor = Color.FromArgb(238,204,156);
                            //radLabelElementStatus.LabelFill.BackColor2 = Color.FromArgb(255, 149, 0);
                            //radLabelElementStatus.LabelFill.BackColor3 = Color.FromArgb(178,118,34);
                            //radLabelElementStatus.LabelFill.BackColor4 = Color.FromArgb(114,74,19);
                        }
                    }
                    else
                    {
                        ItemsPublic.ShowMessage("انجام گزارش گیری به دلیل زیر ناموفق بود" + "\r\n" + "\r\n" + result.Message);
                    }
                CursorDefault();
                uC_TreeReport1.Enabled = true;
                radGridViewReport.Enabled = true;
                //radGridViewReport.SelectedRows = radGridViewReport.Rows[0];
                //  stateIsnewRowAdded = false;
            }
            catch (Exception ex)
            {
                CursorDefault();
                ItemsPublic.ShowMessage(ex.Message);
            }
        }

        protected void cbbRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //:-)//   eventStatusView();
                radGridViewReport.Enabled = true;
                objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toView);
                //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;
                cbbSave_Click(sender, e);
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }
        }

        protected void cbbSave_Click(object sender, EventArgs e)
        {

            try
            {

            }
            catch (Exception ex)
            {
                CursorDefault();
                if (result == null)
                {
                    ItemsPublic.ShowMessage(ItemsPublic._errConnection);
                }
                else
                {
                    ItemsPublic.ShowMessage(ex.Message);
                }
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }
        }

        protected void cbbCancel_Click(object sender, EventArgs e)
        {
            try
            {
                //cbbRefresh_Click(sender,e);
                radGridViewReport.Enabled = true;
                radGridViewReport.CurrentRow = null;
                objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toView);
                //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }
        }

        private void radStatusStrip1_Resize(object sender, EventArgs e)
        {
            try
            {
                this.radLabelElementStatus.Bounds = new System.Drawing.Rectangle(0, 0, radStatusStrip1.Width, 18);
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }
        }

        List<AllFunctions._Rights> userRights = ItemsPublic.MyRights;

        private void MainReporter_Load(object sender, EventArgs e)
        {
            toolWindowSecondProperties.Hide();

            uC_TreeReport1.TreeViewReports.Nodes["NodePerson"].Visible = 
                userRights.Contains(AllFunctions._Rights.Report_person) 
                || userRights.Contains(AllFunctions._Rights.ReportLimitedPerson);
            
            uC_TreeReport1.TreeViewReports.Nodes["NodeAgreement"].Visible = userRights.Contains(AllFunctions._Rights.Report_Agreement);
            uC_TreeReport1.TreeViewReports.Nodes["NodeOffice"].Visible = userRights.Contains(AllFunctions._Rights.Report_office);
            uC_TreeReport1.TreeViewReports.Nodes["NodeVehicle"].Visible = userRights.Contains(AllFunctions._Rights.Report_vehicle);
            uC_TreeReport1.TreeViewReports.Nodes["NodeGP"].Visible = userRights.Contains(AllFunctions._Rights.Report_gatepass);
            uC_TreeReport1.TreeViewReports.Nodes["NodeBlacklist"].Visible = userRights.Contains(AllFunctions._Rights.Report_blacklist);
            uC_TreeReport1.TreeViewReports.Nodes["NodeOperator"].Visible = userRights.Contains(AllFunctions._Rights.Report_operator);
            uC_TreeReport1.TreeViewReports.Nodes["NodeInout"].Visible = userRights.Contains(AllFunctions._Rights.Report_Inout);

        }

        private void rmiStatusView_Click(object sender, EventArgs e)
        {
            cbbRefresh_Click(sender, e);
        }

        private void rmiStatusSearch_Click(object sender, EventArgs e)
        {
            cbbSearch_Click(sender, e);
        }

        protected void rmiStatusNew_Click(object sender, EventArgs e)
        {
            cbbDoEmpty_Click(sender, e);
        }

        protected void rmiStatusEdit_Click(object sender, EventArgs e)
        {
            cbbEdit_Click(sender, e);
        }

        private void rmiStatusDelete_Click(object sender, EventArgs e)
        {
            cbbDelete_Click(sender, e);
        }

        private void rmiStatusExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rmiCut_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^X");
        }

        private void rmiPaste_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^V");
        }

        private void rmiCopy_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^C");
        }

        private void rmiSave_Click(object sender, EventArgs e)
        {
            cbbSave_Click(sender, e);
        }

        private void rmiCancel_Click(object sender, EventArgs e)
        {
            cbbCancel_Click(sender, e);
        }

        private void rmiHelp2_Click(object sender, EventArgs e)
        {

        }

        private void rmiAbout_Click(object sender, EventArgs e)
        {

        }

        private void rmiStatusPrint_Click(object sender, EventArgs e)
        {

        }

        private void rmiStatusSettingPrint_Click(object sender, EventArgs e)
        {

        }

        RadMenuItem rightcbbRefresh = new RadMenuItem();

        RadMenuItem rightCbbSearch = new RadMenuItem();

        RadMenuItem rightCbbEdit = new RadMenuItem();

        RadMenuItem rightCbbExit = new RadMenuItem();

        protected void setAllMouseMenus()
        {
            setAllRightMenusCopy();
            //contextMenu.Items.AddRange ( rightcbbRefresh , rmiStatusSearch , rmiStatusNew , rmiStatusEdit , rmiStatusDelete , rmiStatusPrint , rmiStatusExit );
            contextMenu.Items.AddRange(rightcbbRefresh, rightCbbSearch, rightCbbEdit
                                        , rightCbbExit);
            radGridViewReport.ContextMenuOpening += new ContextMenuOpeningEventHandler(radGridViewReport_ContextMenuOpening);
        }

        private void setAllRightMenusCopy()
        {
            rightcbbRefresh.AccessibleDescription = "مشاهده";
            rightcbbRefresh.AccessibleName = "مشاهده";
            rightcbbRefresh.FlipText = false;
            rightcbbRefresh.Image = global::aorc.gatepass.Properties.Resources._52g;
            rightcbbRefresh.Name = "rightcbbRefresh";
            rightcbbRefresh.Tag = "av";
            rightcbbRefresh.Text = "بازآوری";
            rightcbbRefresh.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            rightcbbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            rightcbbRefresh.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            rightcbbRefresh.Click += new System.EventHandler(cbbRefresh_Click);

            // cbbSearch
            // 
            this.rightCbbSearch.AccessibleDescription = "جستجو";
            this.rightCbbSearch.AccessibleName = "جستجو";
            this.rightCbbSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rightCbbSearch.Image = global::aorc.gatepass.Properties.Resources.searchg;
            this.rightCbbSearch.Name = "rightCbbSearch";
            this.rightCbbSearch.Tag = "av";
            this.rightCbbSearch.Text = "جستجو";
            this.rightCbbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rightCbbSearch.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rightCbbSearch.Click += new System.EventHandler(this.cbbSearch_Click);
            // 

            // cbbEdit
            // 
            this.rightCbbEdit.AccessibleDescription = "بسته باز شود";
            this.rightCbbEdit.AccessibleName = "بسته باز شود";
            this.rightCbbEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rightCbbEdit.Image = global::aorc.gatepass.Properties.Resources.editg;
            this.rightCbbEdit.Name = "rightCbbEdit";
            this.rightCbbEdit.Tag = "av";
            this.rightCbbEdit.Text = "بسته باز شود";
            this.rightCbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rightCbbEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rightCbbEdit.Click += new System.EventHandler(this.cbbEdit_Click);
            // 

            // exit
            this.rightCbbExit.AccessibleDescription = "خروج";
            this.rightCbbExit.AccessibleName = "خروج";
            this.rightCbbExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rightCbbExit.Image = global::aorc.gatepass.Properties.Resources.exitg;
            this.rightCbbExit.Name = "rightCbbExit";
            this.rightCbbExit.Text = "خروج";
            this.rightCbbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rightCbbExit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rightCbbExit.Click += new System.EventHandler(this.rmiStatusExit_Click);
        }

        private void radGridViewReport_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu = contextMenu;
        }

        private void uC_TreeReport1_eventSelectedNodeChanged()
        {
            try
            {
                
                switch (uC_TreeReport1.TreeViewReports.SelectedNodes[0].Name)
                {
                    case "NodePerson":
                        cbbEdit.Visibility = ElementVisibility.Visible;
                        Painter(_State._Person);
                        break;
                    case "NodeAgreement":
                        cbbEdit.Visibility = ElementVisibility.Hidden;
                        Painter(_State._agreement);
                        break;
                    case "NodeOffice":
                        cbbEdit.Visibility = ElementVisibility.Hidden;
                        Painter(_State._office);
                        break;
                    case "NodeVehicle":
                        cbbEdit.Visibility = ElementVisibility.Hidden;
                        Painter(_State._vehicle);
                        break;
                    case "NodeGP":
                        cbbEdit.Visibility = ElementVisibility.Hidden;
                        Painter(_State._gatepass);
                        break;
                    case "NodeBlacklist":
                        cbbEdit.Visibility = ElementVisibility.Hidden;
                        Painter(_State._blacklist);
                        break;
                    case "NodeOperator":
                        cbbEdit.Visibility = ElementVisibility.Hidden;
                        Painter(_State._operator);
                        break;
                    case "NodeInout":
                        cbbEdit.Visibility = ElementVisibility.Hidden;
                        Painter(_State._Inout);
                        break;

                }
            }
            catch (Exception ex)
            {
                CursorDefault();
                ItemsPublic.ShowMessage("متاسفانه خطایی به شرح زیر رخ داد" + "\r\n" + "\r\n" + ex.Message);
            }
        }
        // int _far = 20;
        private void Painter(_State InState)
        {
            CursorWait();
            CurrentState = InState;
            radLabelElementStatus.Text = "";
            copyingMode = true;
            radGridViewReport.DataSource = null;
            copyingMode = false;
            radGridViewReport.MasterTemplate.GroupDescriptors.Clear();
            radGridViewReport.MasterTemplate.Columns.Clear();

            while (toolWindowProperties.Controls.Count > 0)
                toolWindowProperties.Controls.RemoveAt(0);

            while (toolWindowSearch.Controls.Count > 0)
                toolWindowSearch.Controls.RemoveAt(0);

            while (toolWindowSecondProperties.Controls.Count > 0)
                toolWindowSecondProperties.Controls.RemoveAt(0);

            toolWindowSecondProperties.Hide();
            switch (CurrentState)
            {
                case _State._None:
                    #region None
                    #endregion
                    break;
                case _State._Person:
                    #region person UC
                    ucPropertyPerson = new UC_ViewPersonDetails();
                    ucSearchPerson = new ReportPerson.UC_ReportSearchPerson();
                    toolWindowProperties.Controls.Add(ucPropertyPerson);
                    toolWindowSearch.Controls.Add(ucSearchPerson);
                    ucSearchPerson.InitialDatesCurrentMonth();
                                    
                    if ( !userRights.Contains(AllFunctions._Rights.Report_person) 
                        && userRights.Contains(AllFunctions._Rights.ReportLimitedPerson)  )
                    {
                        ucSearchPerson.limitedOffice();
                    }

                    ucPropertyPerson.rbtnImage.Tag = "a";
                    ucPropertyPerson.TcoNationality.Tag = "a";
                    ucPropertyPerson.TcoSex.Tag = "a";
                    ucPropertyPerson.TcoHaveForm.Tag = "a";
                    ucPropertyPerson.TcoBirthCity.Tag = "a";
                    ucPropertyPerson.rtbFatherName.Tag = "a";
                    ucPropertyPerson.rtbSurname.Tag = "a";
                    ucPropertyPerson.rtbName.Tag = "a";
                    ucPropertyPerson.TcoIsBlack.Tag = "a";
                    ucPropertyPerson.rmebPhone2.Tag = "a";
                    ucPropertyPerson.rmebPhone1.Tag = "a";
                    ucPropertyPerson.rmebLicenseDriveCode.Tag = "a";
                    ucPropertyPerson.bdcBirthDate.Tag = "a";
                    ucPropertyPerson.bdcEndSecureDate.Tag = "a";
                    ucPropertyPerson.TcoRegisterCity.Tag = "a";
                    ucPropertyPerson.rmeIdentifyCode.Tag = "a";
                    ucPropertyPerson.rtbRegisterCode.Tag = "a";
                    ucPropertyPerson.rmebNationalCode.Tag = "a";

                    //ucPropertyPerson.comboBirthCity.SetAllLocations();
                    //ucPropertyPerson.comboNationality.SetAllLocations();
                    //ucPropertyPerson.comboRegisterCity.SetAllLocations();
                    //      toolWindowProperties.Width = ucPropertyPerson.Width + _far;
                    //       toolWindowSearch.Height = ucSearchPerson.Height + _far;
                    #endregion
                    #region Person
                    gridViewDecimalColumnPerson1 = new GridViewDecimalColumn();
                    gridViewTextBoxColumnPerson1 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnPerson2 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnPerson3 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnPerson4 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnPerson5 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnPerson6 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnPerson7 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnPerson8 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnPerson9 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnPerson10 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnPerson11 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnPerson12 = new GridViewTextBoxColumn();
                    gridViewCheckBoxColumnPerson1 = new GridViewCheckBoxColumn();
                    gridViewDateTimeColumnPerson1 = new GridViewDateTimeColumn();
                    gridViewCheckBoxColumnPerson2 = new GridViewCheckBoxColumn();
                    gridViewImageColumnPerson1 = new GridViewImageColumn();
                    gridViewDateTimeColumnPerson2 = new GridViewDateTimeColumn();
                    gridViewTextBoxColumnPerson13 = new GridViewTextBoxColumn();
                    gridViewCheckBoxColumnPerson3 = new GridViewCheckBoxColumn();
                    gridViewCheckBoxColumnPerson4 = new GridViewCheckBoxColumn();



                    //this.radGridViewReport.MasterTemplate.AddNewRowPosition = SystemRowPosition.Bottom;
                    //this.radGridViewReport.MasterTemplate.AllowAddNewRow = false;
                    gridViewDecimalColumnPerson1.EnableExpressionEditor = false;
                    gridViewDecimalColumnPerson1.FieldName = "Person_ID";
                    gridViewDecimalColumnPerson1.HeaderText = "ردیف";
                    gridViewDecimalColumnPerson1.IsVisible = false;
                    gridViewDecimalColumnPerson1.Name = "Person_ID";
                    gridViewDecimalColumnPerson1.Width = 66;
                    gridViewTextBoxColumnPerson1.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson1.FieldName = "Person_Name";
                    gridViewTextBoxColumnPerson1.HeaderText = "نام";
                    gridViewTextBoxColumnPerson1.Name = "Person_Name";
                    gridViewTextBoxColumnPerson1.Width = 119;
                    gridViewTextBoxColumnPerson2.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson2.FieldName = "Person_Surname";
                    gridViewTextBoxColumnPerson2.HeaderText = "نام خانوادگی";
                    gridViewTextBoxColumnPerson2.Name = "Person_Surname";
                    gridViewTextBoxColumnPerson2.Width = 195;
                    gridViewTextBoxColumnPerson3.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson3.FieldName = "Person_NationalCode";
                    gridViewTextBoxColumnPerson3.HeaderText = "شماره ملی";
                    gridViewTextBoxColumnPerson3.Name = "Person_NationalCode";
                    gridViewTextBoxColumnPerson3.Width = 145;
                    gridViewTextBoxColumnPerson4.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson4.FieldName = "Person_IdentifyCode";
                    gridViewTextBoxColumnPerson4.HeaderText = "شماره شناسایی";
                    gridViewTextBoxColumnPerson4.Name = "Person_IdentifyCode";
                    gridViewTextBoxColumnPerson4.Width = 103;
                    gridViewTextBoxColumnPerson5.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson5.FieldName = "Person_LicenseDriverCode";
                    gridViewTextBoxColumnPerson5.HeaderText = "شماره گواهینامه رانندگی";
                    gridViewTextBoxColumnPerson5.Name = "Person_LicenseDriverCode";
                    gridViewTextBoxColumnPerson5.Width = 168;
                    gridViewTextBoxColumnPerson6.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson6.FieldName = "Person_FatherName";
                    gridViewTextBoxColumnPerson6.HeaderText = "نام پدر";
                    gridViewTextBoxColumnPerson6.Name = "Person_FatherName";
                    gridViewTextBoxColumnPerson6.Width = 109;
                    gridViewTextBoxColumnPerson7.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson7.FieldName = "Person_BirthCity";
                    gridViewTextBoxColumnPerson7.HeaderText = "محل تولد";
                    gridViewTextBoxColumnPerson7.Name = "Person_BirthCity";
                    gridViewTextBoxColumnPerson7.Width = 106;
                    gridViewTextBoxColumnPerson8.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson8.FieldName = "Person_RegisterCity";
                    gridViewTextBoxColumnPerson8.HeaderText = "محل صدور شناسنامه";
                    gridViewTextBoxColumnPerson8.IsVisible = false;
                    gridViewTextBoxColumnPerson8.Name = "Person_RegisterCity";
                    gridViewTextBoxColumnPerson9.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson9.FieldName = "Person_Nationality";
                    gridViewTextBoxColumnPerson9.HeaderText = "تابعیت";
                    gridViewTextBoxColumnPerson9.Name = "Person_Nationality";
                    gridViewTextBoxColumnPerson9.Width = 64;
                    gridViewTextBoxColumnPerson10.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson10.FieldName = "Person_Phone1";
                    gridViewTextBoxColumnPerson10.HeaderText = "شماره تماس اول";
                    gridViewTextBoxColumnPerson10.IsVisible = false;
                    gridViewTextBoxColumnPerson10.Name = "Person_Phone1";
                    gridViewTextBoxColumnPerson11.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson11.FieldName = "Person_Phone2";
                    gridViewTextBoxColumnPerson11.HeaderText = "شماره تماس دوم";
                    gridViewTextBoxColumnPerson11.IsVisible = false;
                    gridViewTextBoxColumnPerson11.Name = "Person_Phone2";
                    gridViewTextBoxColumnPerson12.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson12.FieldName = "Person_RegisterCode";
                    gridViewTextBoxColumnPerson12.HeaderText = "شماره شناسنامه";
                    gridViewTextBoxColumnPerson12.Name = "Person_RegisterCode";
                    gridViewTextBoxColumnPerson12.Width = 121;
                    gridViewCheckBoxColumnPerson1.EnableExpressionEditor = false;
                    gridViewCheckBoxColumnPerson1.FieldName = "Person_HaveForm";
                    gridViewCheckBoxColumnPerson1.HeaderText = "فرم حفاظتی";
                    gridViewCheckBoxColumnPerson1.MinWidth = 20;
                    gridViewCheckBoxColumnPerson1.Name = "Person_HaveForm";
                    gridViewCheckBoxColumnPerson1.Width = 106;
                    gridViewDateTimeColumnPerson1.EnableExpressionEditor = false;
                    gridViewDateTimeColumnPerson1.FieldName = "Person_SecureFormDate";
                    gridViewDateTimeColumnPerson1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
                    gridViewDateTimeColumnPerson1.HeaderText = " پایان اعتبار فرم";
                    gridViewDateTimeColumnPerson1.IsVisible = false;
                    gridViewDateTimeColumnPerson1.Name = "Person_SecureFormDate";
                    gridViewDateTimeColumnPerson1.Width = 90;
                    gridViewCheckBoxColumnPerson2.EnableExpressionEditor = false;
                    gridViewCheckBoxColumnPerson2.FieldName = "Person_isWoman";
                    gridViewCheckBoxColumnPerson2.HeaderText = "مونث";
                    gridViewCheckBoxColumnPerson2.IsVisible = false;
                    gridViewCheckBoxColumnPerson2.MinWidth = 20;
                    gridViewCheckBoxColumnPerson2.Name = "Person_isWoman";
                    gridViewCheckBoxColumnPerson2.Width = 31;
                    gridViewImageColumnPerson1.EnableExpressionEditor = false;
                    gridViewImageColumnPerson1.FieldName = "Person_Picture";
                    gridViewImageColumnPerson1.HeaderText = "عکس";
                    gridViewImageColumnPerson1.IsVisible = false;
                    gridViewImageColumnPerson1.Name = "Person_Picture";
                    gridViewDateTimeColumnPerson2.EnableExpressionEditor = false;
                    gridViewDateTimeColumnPerson2.FieldName = "Person_BirthDate";
                    gridViewDateTimeColumnPerson2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
                    gridViewDateTimeColumnPerson2.HeaderText = "تاریخ تولد";
                    gridViewDateTimeColumnPerson2.IsVisible = false;
                    gridViewDateTimeColumnPerson2.Name = "Person_BirthDate";
                    gridViewTextBoxColumnPerson13.EnableExpressionEditor = false;
                    gridViewTextBoxColumnPerson13.FieldName = "Person_LabelIsWoman";
                    gridViewTextBoxColumnPerson13.HeaderText = "جنسیت";
                    gridViewTextBoxColumnPerson13.Name = "Person_LabelIsWoman";
                    gridViewTextBoxColumnPerson13.Width = 57;
                    gridViewCheckBoxColumnPerson3.EnableExpressionEditor = false;
                    gridViewCheckBoxColumnPerson3.FieldName = "Person_Temp";
                    gridViewCheckBoxColumnPerson3.HeaderText = "موقت";
                    gridViewCheckBoxColumnPerson3.IsVisible = false;
                    gridViewCheckBoxColumnPerson3.MinWidth = 20;
                    gridViewCheckBoxColumnPerson3.Name = "Person_Temp";
                    gridViewCheckBoxColumnPerson4.FieldName = "Person_IsBlackTemp";
                    gridViewCheckBoxColumnPerson4.HeaderText = "Person_IsBlackTemp";
                    gridViewCheckBoxColumnPerson4.IsVisible = false;
                    gridViewCheckBoxColumnPerson4.Name = "Person_IsBlackTemp";



                    this.radGridViewReport.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] {
            gridViewDecimalColumnPerson1,
            gridViewTextBoxColumnPerson1,
            gridViewTextBoxColumnPerson2,
            gridViewTextBoxColumnPerson3,            
            gridViewTextBoxColumnPerson6,
            gridViewTextBoxColumnPerson7,
            gridViewTextBoxColumnPerson8,
            gridViewTextBoxColumnPerson9,
            gridViewTextBoxColumnPerson10,
            gridViewTextBoxColumnPerson11,
            gridViewTextBoxColumnPerson12,
            gridViewTextBoxColumnPerson4,
            gridViewTextBoxColumnPerson5,
            gridViewCheckBoxColumnPerson1,
            gridViewDateTimeColumnPerson1,
            gridViewCheckBoxColumnPerson2,
            gridViewImageColumnPerson1,
            gridViewDateTimeColumnPerson2,
            gridViewTextBoxColumnPerson13,
            gridViewCheckBoxColumnPerson3,
            gridViewCheckBoxColumnPerson4});

                    #endregion
                    break;
                case _State._agreement:
                    ucPropertyAgree = new UC_agreementsDetails();
                    ucSearchAgree = new ReportGH.UC_ReportSearchAgree();
                    ucPropertyAgree.modeIsSearch = false;
                    toolWindowProperties.Controls.Add(ucPropertyAgree);
                    toolWindowSearch.Controls.Add(ucSearchAgree);
                    ucSearchAgree.InitialDatesCurrentMonth();
                    #region agreement
                    gridViewTextBoxColumnAgreement1 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnAgreement2 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnAgreement3 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnAgreement4 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnAgreement5 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnAgreement6 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnAgreement7 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnAgreement8 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnAgreement9 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnAgreement10 = new GridViewTextBoxColumn();
                    gridViewDateTimeColumnAgreement1 = new GridViewDateTimeColumn();
                    gridViewDateTimeColumnAgreement2 = new GridViewDateTimeColumn();
                    gridViewCheckBoxColumnAgreement1 = new GridViewCheckBoxColumn();
                    gridViewTextBoxColumnAgreement11 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnAgreement12 = new GridViewTextBoxColumn();
                    gridViewCheckBoxColumnAgreement2 = new GridViewCheckBoxColumn();

                    // 
                    // radGridViewReport
                    //         this.radGridViewReport.MasterTemplate.AddNewRowPosition = SystemRowPosition.Bottom;
                    //        this.radGridViewReport.MasterTemplate.AllowAddNewRow = false;
                    gridViewTextBoxColumnAgreement1.EnableExpressionEditor = false;
                    gridViewTextBoxColumnAgreement1.FieldName = "Agreement_ID";
                    gridViewTextBoxColumnAgreement1.HeaderText = "ردیف";
                    gridViewTextBoxColumnAgreement1.IsVisible = false;
                    gridViewTextBoxColumnAgreement1.Name = "Agreement_ID";
                    gridViewTextBoxColumnAgreement1.Width = 71;
                    gridViewTextBoxColumnAgreement2.EnableExpressionEditor = false;
                    gridViewTextBoxColumnAgreement2.FieldName = "Agreement_Number";
                    gridViewTextBoxColumnAgreement2.HeaderText = "شماره قرارداد";
                    gridViewTextBoxColumnAgreement2.Name = "Agreement_Number";
                    gridViewTextBoxColumnAgreement2.Width = 100;
                    gridViewTextBoxColumnAgreement3.EnableExpressionEditor = false;
                    gridViewTextBoxColumnAgreement3.FieldName = "Agreement_Title";
                    gridViewTextBoxColumnAgreement3.HeaderText = "عنوان ";
                    gridViewTextBoxColumnAgreement3.Name = "Agreement_Title";
                    gridViewTextBoxColumnAgreement3.Width = 465;
                    gridViewTextBoxColumnAgreement4.EnableExpressionEditor = false;
                    gridViewTextBoxColumnAgreement4.FieldName = "Agreement_Company";
                    gridViewTextBoxColumnAgreement4.HeaderText = "شرکت/پیمانکاری";
                    gridViewTextBoxColumnAgreement4.Name = "Agreement_Company";
                    gridViewTextBoxColumnAgreement4.Width = 170;
                    gridViewTextBoxColumnAgreement5.EnableExpressionEditor = false;
                    gridViewTextBoxColumnAgreement5.FieldName = "Agreement_ManagerName";
                    gridViewTextBoxColumnAgreement5.HeaderText = "مدیر عامل";
                    gridViewTextBoxColumnAgreement5.Name = "Agreement_ManagerName";
                    gridViewTextBoxColumnAgreement5.Width = 118;
                    gridViewTextBoxColumnAgreement6.EnableExpressionEditor = false;
                    gridViewTextBoxColumnAgreement6.FieldName = "Agreement_CountCars";
                    gridViewTextBoxColumnAgreement6.HeaderText = "تعداد خودرو";
                    gridViewTextBoxColumnAgreement6.Name = "Agreement_CountCars";
                    gridViewTextBoxColumnAgreement6.Width = 71;
                    gridViewTextBoxColumnAgreement7.EnableExpressionEditor = false;
                    gridViewTextBoxColumnAgreement7.FieldName = "Agreement_LabelIsIndustrial";
                    gridViewTextBoxColumnAgreement7.HeaderText = "نوع قرارداد";
                    gridViewTextBoxColumnAgreement7.Name = "Agreement_LabelIsIndustrial";
                    gridViewTextBoxColumnAgreement7.Width = 67;
                    gridViewTextBoxColumnAgreement8.EnableExpressionEditor = false;
                    gridViewTextBoxColumnAgreement8.FieldName = "Agreement_AgentName";
                    gridViewTextBoxColumnAgreement8.HeaderText = "نماینده";
                    gridViewTextBoxColumnAgreement8.IsVisible = false;
                    gridViewTextBoxColumnAgreement8.Name = "Agreement_AgentName";
                    gridViewTextBoxColumnAgreement9.EnableExpressionEditor = false;
                    gridViewTextBoxColumnAgreement9.FieldName = "Agreement_AgentPhone";
                    gridViewTextBoxColumnAgreement9.HeaderText = "تلفن نماینده";
                    gridViewTextBoxColumnAgreement9.IsVisible = false;
                    gridViewTextBoxColumnAgreement9.Name = "Agreement_AgentPhone";
                    gridViewTextBoxColumnAgreement10.EnableExpressionEditor = false;
                    gridViewTextBoxColumnAgreement10.FieldName = "Agreement_Description";
                    gridViewTextBoxColumnAgreement10.HeaderText = "توضیحات";
                    gridViewTextBoxColumnAgreement10.IsVisible = false;
                    gridViewTextBoxColumnAgreement10.Name = "Agreement_Description";
                    gridViewDateTimeColumnAgreement1.EnableExpressionEditor = false;
                    gridViewDateTimeColumnAgreement1.FieldName = "Agreement_StartDate";
                    gridViewDateTimeColumnAgreement1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
                    gridViewDateTimeColumnAgreement1.HeaderText = "تاریخ شروع";
                    gridViewDateTimeColumnAgreement1.IsVisible = false;
                    gridViewDateTimeColumnAgreement1.Name = "Agreement_StartDate";
                    gridViewDateTimeColumnAgreement2.EnableExpressionEditor = false;
                    gridViewDateTimeColumnAgreement2.FieldName = "Agreement_EndDate";
                    gridViewDateTimeColumnAgreement2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
                    gridViewDateTimeColumnAgreement2.HeaderText = "تاریخ پایان";
                    gridViewDateTimeColumnAgreement2.IsVisible = false;
                    gridViewDateTimeColumnAgreement2.Name = "Agreement_EndDate";
                    gridViewCheckBoxColumnAgreement1.EnableExpressionEditor = false;
                    gridViewCheckBoxColumnAgreement1.FieldName = "Agreement_IsActive";
                    gridViewCheckBoxColumnAgreement1.HeaderText = "وضعیت فعال";
                    gridViewCheckBoxColumnAgreement1.MinWidth = 20;
                    gridViewCheckBoxColumnAgreement1.Name = "Agreement_IsActive";
                    gridViewCheckBoxColumnAgreement1.Width = 76;
                    gridViewTextBoxColumnAgreement11.EnableExpressionEditor = false;
                    gridViewTextBoxColumnAgreement11.FieldName = "Agreement_ManagerTell";
                    gridViewTextBoxColumnAgreement11.HeaderText = "تلفن شرکت";
                    gridViewTextBoxColumnAgreement11.IsVisible = false;
                    gridViewTextBoxColumnAgreement11.Name = "Agreement_ManagerTell";
                    gridViewTextBoxColumnAgreement12.EnableExpressionEditor = false;
                    gridViewTextBoxColumnAgreement12.FieldName = "Agreement_Adress";
                    gridViewTextBoxColumnAgreement12.HeaderText = "آدرس";
                    gridViewTextBoxColumnAgreement12.IsVisible = false;
                    gridViewTextBoxColumnAgreement12.Name = "Agreement_Adress";
                    gridViewCheckBoxColumnAgreement2.EnableExpressionEditor = false;
                    gridViewCheckBoxColumnAgreement2.FieldName = "Agreement_IsIndustrial";
                    gridViewCheckBoxColumnAgreement2.HeaderText = " قرارداد صنعتی";
                    gridViewCheckBoxColumnAgreement2.IsVisible = false;
                    gridViewCheckBoxColumnAgreement2.MinWidth = 20;
                    gridViewCheckBoxColumnAgreement2.Name = "Agreement_IsIndustrial";
                    this.radGridViewReport.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] {
            gridViewTextBoxColumnAgreement1,
            gridViewTextBoxColumnAgreement2,
            gridViewTextBoxColumnAgreement3,
            gridViewTextBoxColumnAgreement4,
            gridViewTextBoxColumnAgreement5,
            gridViewTextBoxColumnAgreement6,
            gridViewTextBoxColumnAgreement7,
            gridViewTextBoxColumnAgreement8,
            gridViewTextBoxColumnAgreement9,
            gridViewTextBoxColumnAgreement10,
            gridViewDateTimeColumnAgreement1,
            gridViewDateTimeColumnAgreement2,
            gridViewCheckBoxColumnAgreement1,
            gridViewTextBoxColumnAgreement11,
            gridViewTextBoxColumnAgreement12,
            gridViewCheckBoxColumnAgreement2});

                    #endregion
                    break;
                case _State._office:
                    ucPropertyOffice = new UC_officeDetails();
                    ucSearchOffice = new ReportOffice.UC_ReportSearchOffice();
                    toolWindowProperties.Controls.Add(ucPropertyOffice);
                    toolWindowSearch.Controls.Add(ucSearchOffice);
                    ucSearchOffice.InitialDatesCurrentMonth();
                    #region office

                    gridViewTextBoxColumnOff1 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnOff2 = new GridViewTextBoxColumn();
                    gridViewCheckBoxColumnOff1 = new GridViewCheckBoxColumn();
                    gridViewTextBoxColumnOff3 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnOff4 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnOff5 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnOff6 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnOff7 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnOff8 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnOff9 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnOff10 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnOff11 = new GridViewTextBoxColumn();

                    // 
                    //      this.radGridViewReport.MasterTemplate.AllowAddNewRow = false;
                    gridViewTextBoxColumnOff1.EnableExpressionEditor = false;
                    gridViewTextBoxColumnOff1.FieldName = "Office_ID";
                    gridViewTextBoxColumnOff1.HeaderText = "ردیف";
                    gridViewTextBoxColumnOff1.IsVisible = false;
                    gridViewTextBoxColumnOff1.Name = "Office_ID";
                    gridViewTextBoxColumnOff1.Width = 71;
                    gridViewTextBoxColumnOff2.EnableExpressionEditor = false;
                    gridViewTextBoxColumnOff2.FieldName = "Office_Name";
                    gridViewTextBoxColumnOff2.HeaderText = "نام اداره";
                    gridViewTextBoxColumnOff2.Name = "Office_Name";
                    gridViewTextBoxColumnOff2.Width = 268;
                    gridViewCheckBoxColumnOff1.EnableExpressionEditor = false;
                    gridViewCheckBoxColumnOff1.FieldName = "Office_Active";
                    gridViewCheckBoxColumnOff1.HeaderText = "وضعیت فعال";
                    gridViewCheckBoxColumnOff1.MinWidth = 20;
                    gridViewCheckBoxColumnOff1.Name = "Office_Active";
                    gridViewCheckBoxColumnOff1.Width = 64;
                    gridViewTextBoxColumnOff3.EnableExpressionEditor = false;
                    gridViewTextBoxColumnOff3.FieldName = "Office_ParentName";
                    gridViewTextBoxColumnOff3.HeaderText = "اداره بالاسری";
                    gridViewTextBoxColumnOff3.Name = "Office_ParentName";
                    gridViewTextBoxColumnOff3.Width = 258;
                    gridViewTextBoxColumnOff4.EnableExpressionEditor = false;
                    gridViewTextBoxColumnOff4.FieldName = "Office_ParentId";
                    gridViewTextBoxColumnOff4.HeaderText = "شماره اداره بالا سری";
                    gridViewTextBoxColumnOff4.IsVisible = false;
                    gridViewTextBoxColumnOff4.Name = "Office_ParentId";
                    gridViewTextBoxColumnOff4.Width = 220;
                    gridViewTextBoxColumnOff5.EnableExpressionEditor = false;
                    gridViewTextBoxColumnOff5.FieldName = "Office_MonthlyRemindGp";
                    gridViewTextBoxColumnOff5.HeaderText = "باقیمانده سهمیه روزانه";
                    gridViewTextBoxColumnOff5.IsVisible = false;
                    gridViewTextBoxColumnOff5.Name = "Office_MonthlyRemindGp";
                    gridViewTextBoxColumnOff6.EnableExpressionEditor = false;
                    gridViewTextBoxColumnOff6.FieldName = "Office_MonthlyGPAllowed";
                    gridViewTextBoxColumnOff6.HeaderText = "سهمیه ماهیانه";
                    gridViewTextBoxColumnOff6.IsVisible = false;
                    gridViewTextBoxColumnOff6.Name = "Office_MonthlyGPAllowed";
                    gridViewTextBoxColumnOff7.EnableExpressionEditor = false;
                    gridViewTextBoxColumnOff7.FieldName = "Office_DailyGPAllowed";
                    gridViewTextBoxColumnOff7.HeaderText = "سهمیه روزانه";
                    gridViewTextBoxColumnOff7.IsVisible = false;
                    gridViewTextBoxColumnOff7.Name = "Office_DailyGPAllowed";
                    gridViewTextBoxColumnOff8.EnableExpressionEditor = false;
                    gridViewTextBoxColumnOff8.FieldName = "Office_DailyRemindGp";
                    gridViewTextBoxColumnOff8.HeaderText = "باقیمانده سهمیه روزانه";
                    gridViewTextBoxColumnOff8.IsVisible = false;
                    gridViewTextBoxColumnOff8.Name = "Office_DailyRemindGp";
                    gridViewTextBoxColumnOff9.EnableExpressionEditor = false;
                    gridViewTextBoxColumnOff9.FieldName = "Office_Description";
                    gridViewTextBoxColumnOff9.HeaderText = "توضیحات";
                    gridViewTextBoxColumnOff9.IsVisible = false;
                    gridViewTextBoxColumnOff9.Name = "Office_Description";
                    gridViewTextBoxColumnOff10.EnableExpressionEditor = false;
                    gridViewTextBoxColumnOff10.FieldName = "Office_Phone1";
                    gridViewTextBoxColumnOff10.HeaderText = "شماره تماس اول";
                    gridViewTextBoxColumnOff10.IsVisible = false;
                    gridViewTextBoxColumnOff10.Name = "Office_Phone1";
                    gridViewTextBoxColumnOff11.EnableExpressionEditor = false;
                    gridViewTextBoxColumnOff11.FieldName = "Office_Phone2";
                    gridViewTextBoxColumnOff11.HeaderText = "شماره تماس دوم";
                    gridViewTextBoxColumnOff11.IsVisible = false;
                    gridViewTextBoxColumnOff11.Name = "Office_Phone2";
                    gridViewTextBoxColumnOff11.Width = 192;
                    this.radGridViewReport.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumnOff1,
            gridViewTextBoxColumnOff2,
            gridViewCheckBoxColumnOff1,
            gridViewTextBoxColumnOff3,
            gridViewTextBoxColumnOff4,
            gridViewTextBoxColumnOff5,
            gridViewTextBoxColumnOff6,
            gridViewTextBoxColumnOff7,
            gridViewTextBoxColumnOff8,
            gridViewTextBoxColumnOff9,
            gridViewTextBoxColumnOff10,
            gridViewTextBoxColumnOff11});

                    #endregion

                    break;
                case _State._vehicle:
                    ucPropertyVeh = new ui.vehicle.UC_vehicleDetails3();
                    ucSearchVeh = new ReportVeh.UC_ReportSearchVehicle();
                    toolWindowProperties.Controls.Add(ucPropertyVeh);
                    toolWindowSearch.Controls.Add(ucSearchVeh);
                    ucSearchVeh.InitialDatesCurrentMonth();
                    ucSearchVeh.uC_vehicleDetailsSearch1.SetModelsCar();
                    ucPropertyVeh.SetModelsCar();
                    #region vehicle
                    gridViewDecimalColumnVeh1 = new GridViewDecimalColumn();
                    gridViewTextBoxColumnVeh1 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnVeh2 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnVeh3 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnVeh4 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnVeh5 = new GridViewTextBoxColumn();
                    gridViewCheckBoxColumnVeh1 = new GridViewCheckBoxColumn();
                    gridViewCheckBoxColumnVeh2 = new GridViewCheckBoxColumn();
                    gridViewTextBoxColumnVeh6 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnVeh7 = new GridViewTextBoxColumn();
                    gridViewTextBoxColumnVeh8 = new GridViewTextBoxColumn();

                    // 
                    // radGridViewTypeVehicle
                    // 
                    //       this.radGridViewReport.MasterTemplate.AllowAddNewRow = false;
                    //      this.radGridViewReport.MasterTemplate.AutoGenerateColumns = false;
                    gridViewDecimalColumnVeh1.EnableExpressionEditor = false;
                    gridViewDecimalColumnVeh1.FieldName = "Vehicle_ID";
                    gridViewDecimalColumnVeh1.HeaderText = "آیدی خودرو";
                    gridViewDecimalColumnVeh1.IsVisible = false;
                    gridViewDecimalColumnVeh1.Name = "Vehicle_ID";
                    gridViewTextBoxColumnVeh1.EnableExpressionEditor = false;
                    gridViewTextBoxColumnVeh1.FieldName = "VehicleType_Name";
                    gridViewTextBoxColumnVeh1.HeaderText = "نوع خودرو";
                    gridViewTextBoxColumnVeh1.Name = "VehicleType_Name";
                    gridViewTextBoxColumnVeh1.Width = 93;
                    gridViewTextBoxColumnVeh2.EnableExpressionEditor = false;
                    gridViewTextBoxColumnVeh2.FieldName = "Vehicle_number";
                    gridViewTextBoxColumnVeh2.HeaderText = "شماره خودرو";
                    gridViewTextBoxColumnVeh2.Name = "Vehicle_number";
                    gridViewTextBoxColumnVeh2.Width = 114;
                    gridViewTextBoxColumnVeh3.EnableExpressionEditor = false;
                    gridViewTextBoxColumnVeh3.FieldName = "vehicle_Name";
                    gridViewTextBoxColumnVeh3.HeaderText = "نام خودرو";
                    gridViewTextBoxColumnVeh3.IsVisible = false;
                    gridViewTextBoxColumnVeh3.Name = "vehicle_Name";
                    gridViewTextBoxColumnVeh3.Width = 138;
                    gridViewTextBoxColumnVeh4.EnableExpressionEditor = false;
                    gridViewTextBoxColumnVeh4.FieldName = "vehicle_Color";
                    gridViewTextBoxColumnVeh4.HeaderText = "رنگ خودرو";
                    gridViewTextBoxColumnVeh4.Name = "vehicle_Color";
                    gridViewTextBoxColumnVeh4.Width = 89;
                    gridViewTextBoxColumnVeh5.EnableExpressionEditor = false;
                    gridViewTextBoxColumnVeh5.FieldName = "Vehicle_Model";
                    gridViewTextBoxColumnVeh5.HeaderText = "مدل خودرو";
                    gridViewTextBoxColumnVeh5.Name = "Vehicle_Model";
                    gridViewTextBoxColumnVeh5.Width = 102;
                    gridViewCheckBoxColumnVeh1.EnableExpressionEditor = false;
                    gridViewCheckBoxColumnVeh1.FieldName = "VehicleType_Hidden";
                    gridViewCheckBoxColumnVeh1.HeaderText = "وضعیت خودرو";
                    gridViewCheckBoxColumnVeh1.IsVisible = false;
                    gridViewCheckBoxColumnVeh1.MinWidth = 20;
                    gridViewCheckBoxColumnVeh1.Name = "VehicleType_Hidden";
                    gridViewCheckBoxColumnVeh2.EnableExpressionEditor = false;
                    gridViewCheckBoxColumnVeh2.FieldName = "Vehicle_IsCompany";
                    gridViewCheckBoxColumnVeh2.HeaderText = "خودرو شرکتی";
                    gridViewCheckBoxColumnVeh2.MinWidth = 20;
                    gridViewCheckBoxColumnVeh2.Name = "Vehicle_IsCompany";
                    gridViewCheckBoxColumnVeh2.Width = 76;
                    gridViewTextBoxColumnVeh6.EnableExpressionEditor = false;
                    gridViewTextBoxColumnVeh6.FieldName = "VehicleType_ID";
                    gridViewTextBoxColumnVeh6.HeaderText = "آیدی نوع خودرو";
                    gridViewTextBoxColumnVeh6.IsVisible = false;
                    gridViewTextBoxColumnVeh6.Name = "VehicleType_ID";
                    gridViewTextBoxColumnVeh7.EnableExpressionEditor = false;
                    gridViewTextBoxColumnVeh7.FieldName = "TypePlates_Id";
                    gridViewTextBoxColumnVeh7.HeaderText = "شماره نوع پلاک";
                    gridViewTextBoxColumnVeh7.IsVisible = false;
                    gridViewTextBoxColumnVeh7.Name = "TypePlates_Id";
                    gridViewTextBoxColumnVeh8.EnableExpressionEditor = false;
                    gridViewTextBoxColumnVeh8.FieldName = "TypePlates_Desc";
                    gridViewTextBoxColumnVeh8.HeaderText = "نوع پلاک";
                    gridViewTextBoxColumnVeh8.Name = "TypePlates_Desc";
                    gridViewTextBoxColumnVeh8.Width = 69;
                    this.radGridViewReport.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumnVeh1,
            gridViewTextBoxColumnVeh1,
            gridViewTextBoxColumnVeh2,
            gridViewTextBoxColumnVeh3,
            gridViewTextBoxColumnVeh4,
            gridViewTextBoxColumnVeh5,
            gridViewCheckBoxColumnVeh1,
            gridViewCheckBoxColumnVeh2,
            gridViewTextBoxColumnVeh6,
            gridViewTextBoxColumnVeh7,
            gridViewTextBoxColumnVeh8});
                    #endregion
                    break;
                case _State._gatepass:
                    
                    ucPropertyPack = new Gp2.Pack.V3UC_PackDetailsGp2();
                    ucPropertyPerson = new UC_ViewPersonDetails();
                    ucPropertyVeh = new ui.vehicle.UC_vehicleDetails3();
                    ucSearchGP = new ReportGP.UC_ReportSearchGP();
                    toolWindowSearch.Controls.Add(ucSearchGP);
                    toolWindowProperties.Controls.Add(ucPropertyPerson);
                    toolWindowSecondProperties.Controls.Add(ucPropertyPack);
                    toolWindowSecondProperties.Controls.Add(ucPropertyVeh);
                                        ucSearchGP.InitialDatesCurrentMonth();
                    toolWindowSecondProperties.Show();
                    ucPropertyVeh.SetModelsCar();
                    ucPropertyPack.Location = new System.Drawing.Point(0, 0);
                    ucPropertyVeh.Location = new System.Drawing.Point(ucPropertyPack.Width + 10, 0);
                    ucPropertyPack.rtbCompanyAgree.Tag = "a";
                    ucPropertyPack.rlblCountCar.Tag = "a";
                    ucPropertyPack.rtbGates.Tag = "a";
                    ucPropertyPack.rtbNumberAgree.Tag = "a";
                    ucPropertyPack.rtbOffice.Tag = "a";
                    ucPropertyPack.rtbOperConfirm.Tag = "a";
                    ucPropertyPack.rtbOperPassage.Tag = "a";
                    ucPropertyPack.rtbOperRequest.Tag = "a";
                    ucPropertyPack.rtbPlaces.Tag = "a";
                    ucPropertyPack.rtbStatusPack.Tag = "a";
                    ucPropertyPack.rtbPackId.Tag = "a";
                    ucPropertyPack.rtbTravelLabel.Tag = "a";
                    ucPropertyPack.tbPackDescriptions.Tag = "a";
                    ucPropertyPack.bdcEndDate.Tag = "a";
                    ucPropertyPack.bdcStartDate.Tag = "a";
                    ucPropertyPack.rddlShift.Tag = "a";
                    ucPropertyPack.rddlTypePack.Tag = "a";
                    ucPropertyPack.rddlValid.Tag = "a";
                    Gpainter();
                    break;
                case _State._blacklist:
                    #region blacklist
                    #endregion
                    break;
                case _State._operator:
                    #region operator
                    #endregion
                    break;
                case _State._Inout:
                    #region Inout

               //     ucPropertyInOutView = new ReportInOut.UC_InOutView();
                    ucPropertyInOut = new ReportPassingEsmaeil.UC_PageGp();
                    // ucPropertyPerson = new UC_ViewPersonDetails();
                    // ucPropertyVeh = new ui.vehicle.UC_vehicleDetails3();

                    ucSearchInOut = new ReportPassingEsmaeil.UC_TagSearch();

                    toolWindowSearch.Controls.Add(ucSearchInOut);
                    toolWindowProperties.Controls.Add(ucPropertyInOut);
                 //   toolWindowProperties.Controls.Add(ucPropertyInOutView);
                    ucSearchInOut.InitialDatesCurrentMonth();
                    ucPropertyInOut.Location = new System.Drawing.Point(0, 0);
                 //   ucPropertyInOutView.Location = new System.Drawing.Point((ucPropertyInOut.Width - ucPropertyInOutView.Width) / 2, ucPropertyInOut.Height + 15);


                    //toolWindowSecondProperties.Controls.Add(ucPropertyPack);
                    //toolWindowSecondProperties.Controls.Add(ucPropertyVeh);
                    //toolWindowSecondProperties.Show();
                    //ucPropertyVeh.SetModelsCar();
                    //  ucPropertyInOut.ViewMode();

                    InOutEsmaeilPainter();
                    // InOutPainter();
                    #endregion
                    break;
                default:
                    break;
            }
            objManager = new Manager();
            myAll = new List<object>();
            objManager.EveryItems = myAll;
            objManager.InActiveTheme = office2010BlackTheme1;
            objManager.RBE = radLabelElementStatus;
            GroupingControls((Control)this);
            objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.viewPack);
            toolWindowSecondProperties.Hide();
            CursorDefault();
        }

        private void Gpainter()
        {
            #region _gatepass

            #region Pack and GatePass

            gridViewTextBoxColumnPack1 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack2 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack3 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack4 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack5 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack6 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack7 = new GridViewTextBoxColumn();
            gridViewDecimalColumnPack1 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack2 = new GridViewDecimalColumn();
            gridViewTextBoxColumnPack8 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack9 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack10 = new GridViewTextBoxColumn();
            gridViewDecimalColumnPack3 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack4 = new GridViewDecimalColumn();
            gridViewTextBoxColumnPack11 = new GridViewTextBoxColumn();
            gridViewDecimalColumnPack5 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack6 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack7 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack8 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack9 = new GridViewDecimalColumn();
            gridViewCheckBoxColumnPack1 = new GridViewCheckBoxColumn();
            gridViewTextBoxColumnPack12 = new GridViewTextBoxColumn();
            gridViewDecimalColumnPack10 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack11 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack12 = new GridViewDecimalColumn();
            gridViewTextBoxColumnPack13 = new GridViewTextBoxColumn();
            gridViewDateTimeColumnPack1 = new GridViewDateTimeColumn();
            gridViewDateTimeColumnPack2 = new GridViewDateTimeColumn();
            gridViewDecimalColumnPack13 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack14 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack15 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack16 = new GridViewDecimalColumn();
            gridViewTextBoxColumnPack14 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack15 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack16 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack17 = new GridViewTextBoxColumn();

            gridViewDecimalColumnGatePass1 = new GridViewDecimalColumn();
            gridViewCheckBoxColumnGatePass1 = new GridViewCheckBoxColumn();
            gridViewTextBoxColumnGatePass1 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass2 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass3 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass4 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass5 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass6 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass7 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass8 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass9 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass10 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass11 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass12 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass13 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass14 = new GridViewTextBoxColumn();
            gridViewDateTimeColumnGatePass1 = new GridViewDateTimeColumn();
            gridViewCheckBoxColumnGatePass2 = new GridViewCheckBoxColumn();
            gridViewImageColumnGatePass1 = new GridViewImageColumn();
            gridViewDateTimeColumnGatePass2 = new GridViewDateTimeColumn();
            gridViewTextBoxColumnGatePass15 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass16 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass17 = new GridViewTextBoxColumn();
            gridViewCheckBoxColumnGatePass3 = new GridViewCheckBoxColumn();
            gridViewTextBoxColumnGatePass18 = new GridViewTextBoxColumn();
            gridViewDecimalColumnGatePass2 = new GridViewDecimalColumn();
            //   gridViewDecimalColumnGatePass3 = new GridViewDecimalColumn();
            gridViewDecimalColumnGatePass4 = new GridViewDecimalColumn();
            gridViewDecimalColumnGatePass5 = new GridViewDecimalColumn();
            gridViewDateTimeColumnGatePass3 = new GridViewDateTimeColumn();
            gridViewTextBoxColumnGatePass19 = new GridViewTextBoxColumn();
            gridViewDecimalColumnGatePass6 = new GridViewDecimalColumn();
            gridViewCheckBoxColumnGatePass4 = new GridViewCheckBoxColumn();
            gridViewCheckBoxColumnGatePass5 = new GridViewCheckBoxColumn();
            gridViewTextBoxColumnGatePass20 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass21 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass22 = new GridViewTextBoxColumn();

            gridViewCheckBoxColumnPerson4 = new GridViewCheckBoxColumn();

            gridViewCheckBoxColumnPerson4.FieldName = "Person_IsBlackTemp";
            gridViewCheckBoxColumnPerson4.HeaderText = "Person_IsBlackTemp";
            gridViewCheckBoxColumnPerson4.IsVisible = false;
            gridViewCheckBoxColumnPerson4.Name = "Person_IsBlackTemp";



            gridViewTextBoxColumnPack1.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack1.FieldName = "Package_TicketId";
            gridViewTextBoxColumnPack1.HeaderText = "شماره بسته";
            gridViewTextBoxColumnPack1.Name = "Package_TicketId";
            gridViewTextBoxColumnPack1.IsVisible = false;
            gridViewTextBoxColumnPack1.Width = 90;
            gridViewTextBoxColumnPack2.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack2.FieldName = "TypePack_Name";
            gridViewTextBoxColumnPack2.HeaderText = "نوع بسته";
            gridViewTextBoxColumnPack2.Name = "TypePack_Name";
            gridViewTextBoxColumnPack2.Width = 117;
            gridViewTextBoxColumnPack3.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack3.FieldName = "Office_Name";
            gridViewTextBoxColumnPack3.HeaderText = "اداره متقاضی";
            gridViewTextBoxColumnPack3.Name = "Office_Name";
            gridViewTextBoxColumnPack3.Width = 178;
            gridViewTextBoxColumnPack4.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack4.FieldName = "OperRequestName";
            gridViewTextBoxColumnPack4.HeaderText = "درخواست کننده";
            gridViewTextBoxColumnPack4.Name = "OperRequestName";
            gridViewTextBoxColumnPack4.Width = 157;
            gridViewTextBoxColumnPack5.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack5.FieldName = "OperConfirmName";
            gridViewTextBoxColumnPack5.HeaderText = "تایید کننده";
            gridViewTextBoxColumnPack5.Name = "OperConfirmName";
            gridViewTextBoxColumnPack5.Width = 159;
            gridViewTextBoxColumnPack6.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack6.FieldName = "OperPassageName";
            gridViewTextBoxColumnPack6.HeaderText = "تصویب کننده";
            gridViewTextBoxColumnPack6.Name = "OperPassageName";
            gridViewTextBoxColumnPack6.Width = 150;
            gridViewTextBoxColumnPack7.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack7.FieldName = "Package_Description";
            gridViewTextBoxColumnPack7.HeaderText = "توضیحات";
            gridViewTextBoxColumnPack7.IsVisible = false;
            gridViewTextBoxColumnPack7.Name = "Package_Description";
            gridViewDecimalColumnPack1.EnableExpressionEditor = false;
            gridViewDecimalColumnPack1.FieldName = "Agreement_ID";
            gridViewDecimalColumnPack1.HeaderText = "آیدی قرارداد";
            gridViewDecimalColumnPack1.IsVisible = false;
            gridViewDecimalColumnPack1.Name = "Agreement_ID";
            gridViewDecimalColumnPack2.EnableExpressionEditor = false;
            gridViewDecimalColumnPack2.FieldName = "Agreement_Number";
            gridViewDecimalColumnPack2.HeaderText = "شماره قرارداد";
            gridViewDecimalColumnPack2.Name = "Agreement_Number";
            gridViewDecimalColumnPack2.Width = 153;
            gridViewTextBoxColumnPack8.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack8.FieldName = "Agreement_Title";
            gridViewTextBoxColumnPack8.HeaderText = "عنوان قرارداد";
            gridViewTextBoxColumnPack8.Name = "Agreement_Title";
            gridViewTextBoxColumnPack8.Width = 247;
            gridViewTextBoxColumnPack9.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack9.FieldName = "Agreement_Company";
            gridViewTextBoxColumnPack9.HeaderText = "شرکت طرف قرارداد";
            gridViewTextBoxColumnPack9.Name = "Agreement_Company";
            gridViewTextBoxColumnPack9.Width = 205;
            gridViewTextBoxColumnPack10.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack10.FieldName = "TravelArea_LabelTravel";
            gridViewTextBoxColumnPack10.HeaderText = "مسیر تردد";
            gridViewTextBoxColumnPack10.Name = "TravelArea_LabelTravel";
            gridViewTextBoxColumnPack10.Width = 190;
            gridViewDecimalColumnPack3.EnableExpressionEditor = false;
            gridViewDecimalColumnPack3.FieldName = "Office_ID";
            gridViewDecimalColumnPack3.HeaderText = "آیدی اداره";
            gridViewDecimalColumnPack3.IsVisible = false;
            gridViewDecimalColumnPack3.Name = "Office_ID";
            gridViewDecimalColumnPack4.EnableExpressionEditor = false;
            gridViewDecimalColumnPack4.FieldName = "TravelArea_Id";
            gridViewDecimalColumnPack4.HeaderText = "آیدی محدوده تردد";
            gridViewDecimalColumnPack4.IsVisible = false;
            gridViewDecimalColumnPack4.Name = "TravelArea_Id";
            gridViewTextBoxColumnPack11.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack11.FieldName = "TravelArea_Name";
            gridViewTextBoxColumnPack11.HeaderText = "نام محدوده تردد";
            gridViewTextBoxColumnPack11.IsVisible = false;
            gridViewTextBoxColumnPack11.Name = "TravelArea_Name";
            gridViewDecimalColumnPack5.EnableExpressionEditor = false;
            gridViewDecimalColumnPack5.FieldName = "TravelArea_ParentId";
            gridViewDecimalColumnPack5.HeaderText = "آیدی محدوده والد";
            gridViewDecimalColumnPack5.IsVisible = false;
            gridViewDecimalColumnPack5.Name = "TravelArea_ParentId";
            gridViewDecimalColumnPack6.EnableExpressionEditor = false;
            gridViewDecimalColumnPack6.FieldName = "TypePack_Id";
            gridViewDecimalColumnPack6.HeaderText = "آیدی  نوع بسته";
            gridViewDecimalColumnPack6.IsVisible = false;
            gridViewDecimalColumnPack6.Name = "TypePack_Id";
            gridViewDecimalColumnPack7.EnableExpressionEditor = false;
            gridViewDecimalColumnPack7.FieldName = "OperRequestId";
            gridViewDecimalColumnPack7.HeaderText = "آیدی درخواست کننده";
            gridViewDecimalColumnPack7.IsVisible = false;
            gridViewDecimalColumnPack7.Name = "OperRequestId";
            gridViewDecimalColumnPack8.EnableExpressionEditor = false;
            gridViewDecimalColumnPack8.FieldName = "OperRequestBaridId";
            gridViewDecimalColumnPack8.HeaderText = "شماره برید درخواست کننده";
            gridViewDecimalColumnPack8.IsVisible = false;
            gridViewDecimalColumnPack8.Name = "OperRequestBaridId";
            gridViewDecimalColumnPack9.EnableExpressionEditor = false;
            gridViewDecimalColumnPack9.FieldName = "OperConfirmBaridId";
            gridViewDecimalColumnPack9.HeaderText = "شماره برید تایید کننده";
            gridViewDecimalColumnPack9.IsVisible = false;
            gridViewDecimalColumnPack9.Name = "OperConfirmBaridId";
            gridViewCheckBoxColumnPack1.EnableExpressionEditor = false;
            gridViewCheckBoxColumnPack1.FieldName = "Package_IsExpired";
            gridViewCheckBoxColumnPack1.HeaderText = "منقضی شده";
            gridViewCheckBoxColumnPack1.IsVisible = false;
            gridViewCheckBoxColumnPack1.MinWidth = 20;
            gridViewCheckBoxColumnPack1.Name = "Package_IsExpired";
            gridViewCheckBoxColumnPack1.Width = 68;
            gridViewTextBoxColumnPack12.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack12.FieldName = "Package_Shift";
            gridViewTextBoxColumnPack12.HeaderText = "شیفت کاری";
            gridViewTextBoxColumnPack12.Name = "Package_Shift";
            gridViewTextBoxColumnPack12.Width = 66;
            gridViewDecimalColumnPack10.EnableExpressionEditor = false;
            gridViewDecimalColumnPack10.FieldName = "OperPassageId";
            gridViewDecimalColumnPack10.HeaderText = "آیدی تصویب کننده";
            gridViewDecimalColumnPack10.IsVisible = false;
            gridViewDecimalColumnPack10.Name = "OperPassageId";
            gridViewDecimalColumnPack11.EnableExpressionEditor = false;
            gridViewDecimalColumnPack11.FieldName = "Package_OfficePrintID";
            gridViewDecimalColumnPack11.HeaderText = "آیدی چاپی";
            gridViewDecimalColumnPack11.IsVisible = false;
            gridViewDecimalColumnPack11.Name = "Package_OfficePrintID";
            gridViewDecimalColumnPack12.EnableExpressionEditor = false;
            gridViewDecimalColumnPack12.FieldName = "OffPrintId";
            gridViewDecimalColumnPack12.HeaderText = "آیدی اداره چاپ";
            gridViewDecimalColumnPack12.IsVisible = false;
            gridViewDecimalColumnPack12.Name = "OffPrintId";
            gridViewTextBoxColumnPack13.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack13.FieldName = "OffPrintName";
            gridViewTextBoxColumnPack13.HeaderText = "نام اداره چاپ کننده";
            gridViewTextBoxColumnPack13.IsVisible = false;
            gridViewTextBoxColumnPack13.Name = "OffPrintName";
            gridViewDateTimeColumnPack1.EnableExpressionEditor = false;
            gridViewDateTimeColumnPack1.FieldName = "Package_StartDate";
            gridViewDateTimeColumnPack1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnPack1.HeaderText = "تاریخ شروع";
            gridViewDateTimeColumnPack1.IsVisible = false;
            gridViewDateTimeColumnPack1.Name = "Package_StartDate";
            gridViewDateTimeColumnPack2.EnableExpressionEditor = false;
            gridViewDateTimeColumnPack2.FieldName = "Package_EndDate";
            gridViewDateTimeColumnPack2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnPack2.HeaderText = "تاریخ پایان";
            gridViewDateTimeColumnPack2.IsVisible = false;
            gridViewDateTimeColumnPack2.Name = "Package_EndDate";
            gridViewDecimalColumnPack13.EnableExpressionEditor = false;
            gridViewDecimalColumnPack13.FieldName = "package_Id";
            gridViewDecimalColumnPack13.HeaderText = "آیدی بسته";
            gridViewDecimalColumnPack13.IsVisible = false;
            gridViewDecimalColumnPack13.Name = "package_Id";
            gridViewDecimalColumnPack14.EnableExpressionEditor = false;
            gridViewDecimalColumnPack14.FieldName = "OperConfirmId";
            gridViewDecimalColumnPack14.HeaderText = "آیدی تایید کننده";
            gridViewDecimalColumnPack14.IsVisible = false;
            gridViewDecimalColumnPack14.Name = "OperConfirmId";
            gridViewDecimalColumnPack15.EnableExpressionEditor = false;
            gridViewDecimalColumnPack15.FieldName = "OperPassageBaridId";
            gridViewDecimalColumnPack15.HeaderText = "شماره اتوماسیون تصویب کننده";
            gridViewDecimalColumnPack15.IsVisible = false;
            gridViewDecimalColumnPack15.Name = "OperPassageBaridId";
            gridViewDecimalColumnPack16.EnableExpressionEditor = false;
            gridViewDecimalColumnPack16.FieldName = "StatusPack_Id";
            gridViewDecimalColumnPack16.HeaderText = "آیدی وضعیت";
            gridViewDecimalColumnPack16.IsVisible = false;
            gridViewDecimalColumnPack16.Name = "StatusPack_Id";
            gridViewTextBoxColumnPack14.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack14.FieldName = "StatusPack_Name";
            gridViewTextBoxColumnPack14.HeaderText = "نام وضعیت";
            gridViewTextBoxColumnPack14.IsVisible = false;
            gridViewTextBoxColumnPack14.Name = "StatusPack_Name";
            gridViewTextBoxColumnPack15.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack15.FieldName = "StatusPack_Desc";
            gridViewTextBoxColumnPack15.HeaderText = "توضیحات وضعیت";
            gridViewTextBoxColumnPack15.IsVisible = false;
            gridViewTextBoxColumnPack15.Name = "StatusPack_Desc";
            gridViewTextBoxColumnPack16.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack16.FieldName = "StatusPack_Label";
            gridViewTextBoxColumnPack16.HeaderText = "وضعیت";
            gridViewTextBoxColumnPack16.IsVisible = false;
            gridViewTextBoxColumnPack16.Name = "StatusPack_Label";
            gridViewTextBoxColumnPack16.Width = 68;
            gridViewTextBoxColumnPack17.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack17.FieldName = "Package_Events";
            gridViewTextBoxColumnPack17.HeaderText = "رویداد نگاری مجموعه بسته";
            gridViewTextBoxColumnPack17.IsVisible = false;
            gridViewTextBoxColumnPack17.Name = "Package_Events";
            gridViewTextBoxColumnPack17.Width = 58;


            gridViewDecimalColumnGatePass1.EnableExpressionEditor = false;
            gridViewDecimalColumnGatePass1.FieldName = "Person_ID";
            gridViewDecimalColumnGatePass1.HeaderText = "ردیف";
            gridViewDecimalColumnGatePass1.IsVisible = false;
            gridViewDecimalColumnGatePass1.Name = "Person_ID";
            gridViewDecimalColumnGatePass1.Width = 66;
            gridViewCheckBoxColumnGatePass1.EnableExpressionEditor = false;
            gridViewCheckBoxColumnGatePass1.FieldName = "GatePass_State";
            gridViewCheckBoxColumnGatePass1.HeaderText = "انتخاب";
            gridViewCheckBoxColumnGatePass1.IsVisible = false;
            gridViewCheckBoxColumnGatePass1.MinWidth = 20;
            gridViewCheckBoxColumnGatePass1.Name = "GatePass_State";
            gridViewTextBoxColumnGatePass1.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass1.FieldName = "GatePass_TicketId";
            gridViewTextBoxColumnGatePass1.HeaderText = "شماره مجوز";
            gridViewTextBoxColumnGatePass1.Name = "GatePass_TicketId";
            gridViewTextBoxColumnGatePass1.Width = 86;
            gridViewTextBoxColumnGatePass2.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass2.FieldName = "Person_NationalCode";
            gridViewTextBoxColumnGatePass2.HeaderText = "شماره ملی";
            gridViewTextBoxColumnGatePass2.Name = "Person_NationalCode";
            gridViewTextBoxColumnGatePass2.Width = 145;
            gridViewTextBoxColumnGatePass3.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass3.FieldName = "Person_Name";
            gridViewTextBoxColumnGatePass3.HeaderText = "نام";
            gridViewTextBoxColumnGatePass3.Name = "Person_Name";
            gridViewTextBoxColumnGatePass3.Width = 119;
            gridViewTextBoxColumnGatePass4.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass4.FieldName = "Person_Surname";
            gridViewTextBoxColumnGatePass4.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumnGatePass4.Name = "Person_Surname";
            gridViewTextBoxColumnGatePass4.Width = 195;
            gridViewTextBoxColumnGatePass5.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass5.FieldName = "Person_FatherName";
            gridViewTextBoxColumnGatePass5.HeaderText = "نام پدر";
            gridViewTextBoxColumnGatePass5.Name = "Person_FatherName";
            gridViewTextBoxColumnGatePass5.Width = 109;
            gridViewTextBoxColumnGatePass6.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass6.FieldName = "Person_IdentifyCode";
            gridViewTextBoxColumnGatePass6.HeaderText = "شماره شناسایی";
            gridViewTextBoxColumnGatePass6.Name = "Person_IdentifyCode";
            gridViewTextBoxColumnGatePass6.Width = 103;
            gridViewTextBoxColumnGatePass7.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass7.FieldName = "Person_LabelIsWoman";
            gridViewTextBoxColumnGatePass7.HeaderText = "جنسیت";
            gridViewTextBoxColumnGatePass7.Name = "Person_LabelIsWoman";
            gridViewTextBoxColumnGatePass7.Width = 57;
            gridViewTextBoxColumnGatePass8.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass8.FieldName = "Person_LicenseDriverCode";
            gridViewTextBoxColumnGatePass8.HeaderText = "شماره گواهینامه رانندگی";
            gridViewTextBoxColumnGatePass8.IsVisible = false;
            gridViewTextBoxColumnGatePass8.Name = "Person_LicenseDriverCode";
            gridViewTextBoxColumnGatePass8.Width = 168;
            gridViewTextBoxColumnGatePass9.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass9.FieldName = "Person_BirthCity";
            gridViewTextBoxColumnGatePass9.HeaderText = "محل تولد";
            gridViewTextBoxColumnGatePass9.IsVisible = false;
            gridViewTextBoxColumnGatePass9.Name = "Person_BirthCity";
            gridViewTextBoxColumnGatePass9.Width = 106;
            gridViewTextBoxColumnGatePass10.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass10.FieldName = "Person_RegisterCity";
            gridViewTextBoxColumnGatePass10.HeaderText = "محل صدور شناسنامه";
            gridViewTextBoxColumnGatePass10.IsVisible = false;
            gridViewTextBoxColumnGatePass10.Name = "Person_RegisterCity";
            gridViewTextBoxColumnGatePass11.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass11.FieldName = "Person_Nationality";
            gridViewTextBoxColumnGatePass11.HeaderText = "تابعیت";
            gridViewTextBoxColumnGatePass11.IsVisible = false;
            gridViewTextBoxColumnGatePass11.Name = "Person_Nationality";
            gridViewTextBoxColumnGatePass11.Width = 64;
            gridViewTextBoxColumnGatePass12.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass12.FieldName = "Person_Phone1";
            gridViewTextBoxColumnGatePass12.HeaderText = "شماره تماس اول";
            gridViewTextBoxColumnGatePass12.IsVisible = false;
            gridViewTextBoxColumnGatePass12.Name = "Person_Phone1";
            gridViewTextBoxColumnGatePass13.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass13.FieldName = "Person_Phone2";
            gridViewTextBoxColumnGatePass13.HeaderText = "شماره تماس دوم";
            gridViewTextBoxColumnGatePass13.IsVisible = false;
            gridViewTextBoxColumnGatePass13.Name = "Person_Phone2";
            gridViewTextBoxColumnGatePass14.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass14.FieldName = "Person_RegisterCode";
            gridViewTextBoxColumnGatePass14.HeaderText = "شماره شناسنامه";
            gridViewTextBoxColumnGatePass14.IsVisible = false;
            gridViewTextBoxColumnGatePass14.Name = "Person_RegisterCode";
            gridViewTextBoxColumnGatePass14.Width = 121;
            gridViewDateTimeColumnGatePass1.EnableExpressionEditor = false;
            gridViewDateTimeColumnGatePass1.FieldName = "Person_SecureFormDate";
            gridViewDateTimeColumnGatePass1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnGatePass1.HeaderText = "پایان اعتبار فرم";
            gridViewDateTimeColumnGatePass1.IsVisible = false;
            gridViewDateTimeColumnGatePass1.Name = "Person_SecureFormDate";
            gridViewDateTimeColumnGatePass1.Width = 85;
            gridViewCheckBoxColumnGatePass2.EnableExpressionEditor = false;
            gridViewCheckBoxColumnGatePass2.FieldName = "Person_isWoman";
            gridViewCheckBoxColumnGatePass2.HeaderText = "مونث";
            gridViewCheckBoxColumnGatePass2.IsVisible = false;
            gridViewCheckBoxColumnGatePass2.MinWidth = 20;
            gridViewCheckBoxColumnGatePass2.Name = "Person_isWoman";
            gridViewCheckBoxColumnGatePass2.Width = 31;
            gridViewImageColumnGatePass1.EnableExpressionEditor = false;
            gridViewImageColumnGatePass1.FieldName = "Person_Picture";
            gridViewImageColumnGatePass1.HeaderText = "عکس";
            gridViewImageColumnGatePass1.IsVisible = false;
            gridViewImageColumnGatePass1.Name = "Person_Picture";
            gridViewDateTimeColumnGatePass2.EnableExpressionEditor = false;
            gridViewDateTimeColumnGatePass2.FieldName = "Person_BirthDate";
            gridViewDateTimeColumnGatePass2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnGatePass2.HeaderText = "تاریخ تولد";
            gridViewDateTimeColumnGatePass2.IsVisible = false;
            gridViewDateTimeColumnGatePass2.Name = "Person_BirthDate";
            gridViewTextBoxColumnGatePass15.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass15.FieldName = "Vehicle_number";
            gridViewTextBoxColumnGatePass15.HeaderText = "پلاک خودرو";
            gridViewTextBoxColumnGatePass15.Name = "Vehicle_number";
            gridViewTextBoxColumnGatePass15.Width = 81;
            gridViewTextBoxColumnGatePass16.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass16.FieldName = "Vehicle_Model";
            gridViewTextBoxColumnGatePass16.HeaderText = "مدل خودرو";
            gridViewTextBoxColumnGatePass16.Name = "Vehicle_Model";
            gridViewTextBoxColumnGatePass16.Width = 67;
            gridViewTextBoxColumnGatePass17.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass17.FieldName = "vehicle_Color";
            gridViewTextBoxColumnGatePass17.HeaderText = "رنگ خودرو";
            gridViewTextBoxColumnGatePass17.Name = "vehicle_Color";
            gridViewTextBoxColumnGatePass17.Width = 64;
            gridViewCheckBoxColumnGatePass3.EnableExpressionEditor = false;
            gridViewCheckBoxColumnGatePass3.FieldName = "Vehicle_IsCompany";
            gridViewCheckBoxColumnGatePass3.HeaderText = "خودرو شرکتی";
            gridViewCheckBoxColumnGatePass3.MinWidth = 20;
            gridViewCheckBoxColumnGatePass3.Name = "Vehicle_IsCompany";
            gridViewCheckBoxColumnGatePass3.Width = 85;
            gridViewTextBoxColumnGatePass18.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass18.FieldName = "CountPrinted";
            gridViewTextBoxColumnGatePass18.HeaderText = "دفعات چاپ";
            gridViewTextBoxColumnGatePass18.Name = "CountPrinted";
            gridViewTextBoxColumnGatePass18.Width = 66;
            gridViewDecimalColumnGatePass2.EnableExpressionEditor = false;
            gridViewDecimalColumnGatePass2.FieldName = "Gatepass_ID";
            gridViewDecimalColumnGatePass2.HeaderText = "آیدی گیت پاس";
            gridViewDecimalColumnGatePass2.IsVisible = false;
            gridViewDecimalColumnGatePass2.Name = "Gatepass_ID";
            //gridViewDecimalColumnGatePass3.EnableExpressionEditor = false;
            //gridViewDecimalColumnGatePass3.FieldName = "package_Id";
            //gridViewDecimalColumnGatePass3.HeaderText = "آیدی بسته";
            //gridViewDecimalColumnGatePass3.IsVisible = false;
            //gridViewDecimalColumnGatePass3.Name = "package_Id";
            gridViewDecimalColumnGatePass4.EnableExpressionEditor = false;
            gridViewDecimalColumnGatePass4.FieldName = "GatePass_IntPrint";
            gridViewDecimalColumnGatePass4.HeaderText = "GatePass_IntPrint";
            gridViewDecimalColumnGatePass4.IsVisible = false;
            gridViewDecimalColumnGatePass4.Name = "GatePass_IntPrint";
            gridViewDecimalColumnGatePass5.EnableExpressionEditor = false;
            gridViewDecimalColumnGatePass5.FieldName = "GatePass_LockerId";
            gridViewDecimalColumnGatePass5.HeaderText = "GatePass_LockerId";
            gridViewDecimalColumnGatePass5.IsVisible = false;
            gridViewDecimalColumnGatePass5.Name = "GatePass_LockerId";
            gridViewDateTimeColumnGatePass3.EnableExpressionEditor = false;
            gridViewDateTimeColumnGatePass3.FieldName = "GatePass_TimeLock";
            gridViewDateTimeColumnGatePass3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnGatePass3.HeaderText = "GatePass_TimeLock";
            gridViewDateTimeColumnGatePass3.IsVisible = false;
            gridViewDateTimeColumnGatePass3.Name = "GatePass_TimeLock";
            gridViewTextBoxColumnGatePass19.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass19.FieldName = "GatePass_Events";
            gridViewTextBoxColumnGatePass19.HeaderText = "رویداد نگاری مجوز";
            gridViewTextBoxColumnGatePass19.IsVisible = false;
            gridViewTextBoxColumnGatePass19.Name = "GatePass_Events";
            gridViewDecimalColumnGatePass6.EnableExpressionEditor = false;
            gridViewDecimalColumnGatePass6.FieldName = "Vehicle_ID";
            gridViewDecimalColumnGatePass6.HeaderText = "Vehicle_ID";
            gridViewDecimalColumnGatePass6.IsVisible = false;
            gridViewDecimalColumnGatePass6.Name = "Vehicle_ID";
            gridViewCheckBoxColumnGatePass4.EnableExpressionEditor = false;
            gridViewCheckBoxColumnGatePass4.FieldName = "Person_HaveForm";
            gridViewCheckBoxColumnGatePass4.HeaderText = "فرم حفاظتی";
            gridViewCheckBoxColumnGatePass4.MinWidth = 20;
            gridViewCheckBoxColumnGatePass4.Name = "Person_HaveForm";
            gridViewCheckBoxColumnGatePass4.Width = 86;
            gridViewCheckBoxColumnGatePass5.EnableExpressionEditor = false;
            gridViewCheckBoxColumnGatePass5.FieldName = "GatePass_IsExpired";
            gridViewCheckBoxColumnGatePass5.HeaderText = "منقضی شده";
            gridViewCheckBoxColumnGatePass5.MinWidth = 20;
            gridViewCheckBoxColumnGatePass5.Name = "GatePass_IsExpired";
            gridViewCheckBoxColumnGatePass5.Width = 74;
            gridViewTextBoxColumnGatePass20.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass20.FieldName = "VehicleType_ID";
            gridViewTextBoxColumnGatePass20.HeaderText = "VehicleType_ID";
            gridViewTextBoxColumnGatePass20.IsVisible = false;
            gridViewTextBoxColumnGatePass20.Name = "VehicleType_ID";
            gridViewTextBoxColumnGatePass21.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass21.FieldName = "TypePlates_Desc";
            gridViewTextBoxColumnGatePass21.HeaderText = "TypePlates_Desc";
            gridViewTextBoxColumnGatePass21.IsVisible = false;
            gridViewTextBoxColumnGatePass21.Name = "TypePlates_Desc";
            gridViewTextBoxColumnGatePass22.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass22.FieldName = "TypePlates_Id";
            gridViewTextBoxColumnGatePass22.HeaderText = "TypePlates_Id";
            gridViewTextBoxColumnGatePass22.IsVisible = false;
            gridViewTextBoxColumnGatePass22.Name = "TypePlates_Id";


            this.radGridViewReport.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumnGatePass1,
            gridViewCheckBoxColumnGatePass1,
            gridViewTextBoxColumnGatePass1,
            gridViewTextBoxColumnGatePass2,
            gridViewTextBoxColumnGatePass3,
            gridViewTextBoxColumnGatePass4,
            gridViewTextBoxColumnGatePass5,
            gridViewTextBoxColumnGatePass6,
            gridViewTextBoxColumnGatePass7,
            gridViewTextBoxColumnGatePass8,
            gridViewTextBoxColumnGatePass9,
            gridViewTextBoxColumnGatePass10,
            gridViewTextBoxColumnGatePass11,
            gridViewTextBoxColumnGatePass12,
            gridViewTextBoxColumnGatePass13,
            gridViewTextBoxColumnGatePass14,
            gridViewDateTimeColumnGatePass1,
            gridViewCheckBoxColumnGatePass2,
            gridViewImageColumnGatePass1,
            gridViewDateTimeColumnGatePass2,
            gridViewTextBoxColumnGatePass15,
            gridViewTextBoxColumnGatePass16,
            gridViewTextBoxColumnGatePass17,
            gridViewCheckBoxColumnGatePass3,
            gridViewTextBoxColumnGatePass18,
            gridViewDecimalColumnGatePass2,
           // gridViewDecimalColumnGatePass3,
            gridViewDecimalColumnGatePass4,
            gridViewDecimalColumnGatePass5,
            gridViewDateTimeColumnGatePass3,
            gridViewTextBoxColumnGatePass19,
            gridViewDecimalColumnGatePass6,
            gridViewCheckBoxColumnGatePass4,
            gridViewCheckBoxColumnGatePass5,
            gridViewTextBoxColumnGatePass20,
            gridViewTextBoxColumnGatePass21,
            gridViewTextBoxColumnGatePass22,
            gridViewTextBoxColumnPack1,
            gridViewTextBoxColumnPack2,
            gridViewTextBoxColumnPack3,
            gridViewTextBoxColumnPack4,
            gridViewTextBoxColumnPack5,
            gridViewTextBoxColumnPack6,
            gridViewTextBoxColumnPack7,
            gridViewDecimalColumnPack1,
            gridViewDecimalColumnPack2,
            gridViewTextBoxColumnPack8,
            gridViewTextBoxColumnPack9,
            gridViewTextBoxColumnPack10,
            gridViewDecimalColumnPack3,
            gridViewDecimalColumnPack4,
            gridViewTextBoxColumnPack11,
            gridViewDecimalColumnPack5,
            gridViewDecimalColumnPack6,
            gridViewDecimalColumnPack7,
            gridViewDecimalColumnPack8,
            gridViewDecimalColumnPack9,
            gridViewCheckBoxColumnPack1,
            gridViewTextBoxColumnPack12,
            gridViewDecimalColumnPack10,
            gridViewDecimalColumnPack11,
            gridViewDecimalColumnPack12,
            gridViewTextBoxColumnPack13,
            gridViewDateTimeColumnPack1,
            gridViewDateTimeColumnPack2,
            gridViewDecimalColumnPack13,
            gridViewDecimalColumnPack14,
            gridViewDecimalColumnPack15,
            gridViewDecimalColumnPack16,
            gridViewTextBoxColumnPack14,
            gridViewTextBoxColumnPack15,
            gridViewTextBoxColumnPack16,
            gridViewTextBoxColumnPack17,
            gridViewCheckBoxColumnPerson4
        });

            #endregion

            #endregion
        }


        private void InOutEsmaeilPainter()
        {
            #region _gatepass

            #region Pack and GatePass

            gridViewTextBoxColumnPerson9 = new GridViewTextBoxColumn();
            gridViewDecimalColumnPack3 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack7 = new GridViewDecimalColumn();

            gridViewCheckBoxColumnGatePass2 = new GridViewCheckBoxColumn();
            gridViewTextBoxColumnGatePass2 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass6 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass8 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass3 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass4 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass5 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnPack1 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnPack10 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass11 = new GridViewTextBoxColumn();

            gridViewDateTimeColumnGatePass2 = new GridViewDateTimeColumn();


            gridViewImageColumnGatePass1 = new GridViewImageColumn();

            gridViewTextBoxColumnGatePass7 = new GridViewTextBoxColumn();


            gridViewTextBoxColumnGatePass15 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnPack2 = new GridViewTextBoxColumn();


            gridViewTextBoxColumnGatePass17 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass16 = new GridViewTextBoxColumn();

            gridViewCheckBoxColumnGatePass3 = new GridViewCheckBoxColumn();

            gridViewTextBoxColumnPack13 = new GridViewTextBoxColumn();

            gridViewDateTimeColumnPack1 = new GridViewDateTimeColumn();

            gridViewDateTimeColumnPack2 = new GridViewDateTimeColumn();
            //gridViewTextBoxColumnPack1 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass22 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack9 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack7 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack12 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack3 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass21 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass9 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass10 = new GridViewTextBoxColumn();
            gridViewDecimalColumnGatePass2 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack1 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack2 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack4 = new GridViewDecimalColumn();
            gridViewTextBoxColumnPack4 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack5 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack6 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack8 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnPack11 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack14 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack15 = new GridViewTextBoxColumn();
            gridViewDateTimeColumnGatePass1 = new GridViewDateTimeColumn();

            gridViewDateTimeColumnGatePass3 = new GridViewDateTimeColumn();

            gridViewImageColumnPerson1 = new GridViewImageColumn();


            gridViewDecimalColumnVeh1 = new GridViewDecimalColumn();


            gridViewTextBoxColumnPerson9.EnableExpressionEditor = false;
            gridViewTextBoxColumnPerson9.FieldName = "TravelArea_Name";
            gridViewTextBoxColumnPerson9.HeaderText = "نام محدوده تردد";
            gridViewTextBoxColumnPerson9.IsVisible = false;
            gridViewTextBoxColumnPerson9.Name = "TravelArea_Name";



            gridViewDecimalColumnPack3.EnableExpressionEditor = false;
            gridViewDecimalColumnPack3.FieldName = "CountPrinted";
            gridViewDecimalColumnPack3.HeaderText = "تعداد چاپ";
            gridViewDecimalColumnPack3.IsVisible = false;
            gridViewDecimalColumnPack3.Name = "CountPrinted";


            gridViewDecimalColumnPack7.EnableExpressionEditor = false;
            gridViewDecimalColumnPack7.FieldName = "Archive_ID";
            gridViewDecimalColumnPack7.HeaderText = "آیدی آرشیو";
            gridViewDecimalColumnPack7.IsVisible = false;
            gridViewDecimalColumnPack7.Name = "Archive_ID";

            gridViewTextBoxColumnGatePass2.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass2.FieldName = "Person_NationalCode";
            gridViewTextBoxColumnGatePass2.HeaderText = "شماره ملی";
            gridViewTextBoxColumnGatePass2.Name = "Person_NationalCode";
            gridViewTextBoxColumnGatePass2.Width = 145;

            gridViewCheckBoxColumnGatePass2.EnableExpressionEditor = false;
            gridViewCheckBoxColumnGatePass2.FieldName = "Person_isWoman";
            gridViewCheckBoxColumnGatePass2.HeaderText = "مونث";
            gridViewCheckBoxColumnGatePass2.IsVisible = false;
            gridViewCheckBoxColumnGatePass2.MinWidth = 20;
            gridViewCheckBoxColumnGatePass2.Name = "Person_isWoman";
            gridViewCheckBoxColumnGatePass2.Width = 31;



            gridViewTextBoxColumnGatePass6.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass6.FieldName = "Person_IdentifyCode";
            gridViewTextBoxColumnGatePass6.HeaderText = "شماره شناسایی";
            gridViewTextBoxColumnGatePass6.Name = "Person_IdentifyCode";
            gridViewTextBoxColumnGatePass6.Width = 103;



            gridViewTextBoxColumnGatePass8.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass8.FieldName = "Person_LicenseDriverCode";
            gridViewTextBoxColumnGatePass8.HeaderText = "شماره گواهینامه رانندگی";
            gridViewTextBoxColumnGatePass8.IsVisible = true;
            gridViewTextBoxColumnGatePass8.Name = "Person_LicenseDriverCode";
            gridViewTextBoxColumnGatePass8.Width = 168;



            gridViewTextBoxColumnGatePass3.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass3.FieldName = "Person_Name";
            gridViewTextBoxColumnGatePass3.HeaderText = "نام";
            gridViewTextBoxColumnGatePass3.Name = "Person_Name";
            gridViewTextBoxColumnGatePass3.Width = 119;
            gridViewTextBoxColumnGatePass4.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass4.FieldName = "Person_Surname";
            gridViewTextBoxColumnGatePass4.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumnGatePass4.Name = "Person_Surname";
            gridViewTextBoxColumnGatePass4.Width = 195;
            gridViewTextBoxColumnGatePass5.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass5.FieldName = "Person_FatherName";
            gridViewTextBoxColumnGatePass5.HeaderText = "نام پدر";
            gridViewTextBoxColumnGatePass5.Name = "Person_FatherName";
            gridViewTextBoxColumnGatePass5.Width = 109;




            gridViewTextBoxColumnPack1.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack1.FieldName = "Person_BirthCity";
            gridViewTextBoxColumnPack1.HeaderText = "شهر محل تولد";
            gridViewTextBoxColumnPack1.Name = "Person_BirthCity";
            gridViewTextBoxColumnPack1.IsVisible = true;
            gridViewTextBoxColumnPack1.Width = 90;



            gridViewTextBoxColumnPack10.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack10.FieldName = "Person_RegisterCity";
            gridViewTextBoxColumnPack10.HeaderText = "محل صدور";
            gridViewTextBoxColumnPack10.Name = "Person_RegisterCity";
            gridViewTextBoxColumnPack10.Width = 90;



            gridViewTextBoxColumnGatePass11.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass11.FieldName = "Person_Nationality";
            gridViewTextBoxColumnGatePass11.HeaderText = "تابعیت";
            gridViewTextBoxColumnGatePass11.IsVisible = true;
            gridViewTextBoxColumnGatePass11.Name = "Person_Nationality";
            gridViewTextBoxColumnGatePass11.Width = 64;



            gridViewDateTimeColumnGatePass2.EnableExpressionEditor = false;
            gridViewDateTimeColumnGatePass2.FieldName = "Person_BirthDate";
            gridViewDateTimeColumnGatePass2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnGatePass2.HeaderText = "تاریخ تولد";
            gridViewDateTimeColumnGatePass2.IsVisible = true;
            gridViewDateTimeColumnGatePass2.Name = "Person_BirthDate";



            gridViewImageColumnGatePass1.EnableExpressionEditor = false;
            gridViewImageColumnGatePass1.FieldName = "Person_Picture";
            gridViewImageColumnGatePass1.HeaderText = "عکس";
            gridViewImageColumnGatePass1.IsVisible = false;
            gridViewImageColumnGatePass1.Name = "Person_Picture";


            gridViewTextBoxColumnGatePass7.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass7.FieldName = "Person_LabelIsWoman";
            gridViewTextBoxColumnGatePass7.HeaderText = "جنسیت";
            gridViewTextBoxColumnGatePass7.Name = "Person_LabelIsWoman";
            gridViewTextBoxColumnGatePass7.Width = 57;


            gridViewTextBoxColumnGatePass15.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass15.FieldName = "Vehicle_number";
            gridViewTextBoxColumnGatePass15.HeaderText = "پلاک خودرو";
            gridViewTextBoxColumnGatePass15.Name = "Vehicle_number";
            gridViewTextBoxColumnGatePass15.Width = 81;



            gridViewTextBoxColumnPack2.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack2.FieldName = "vehicle_Name";
            gridViewTextBoxColumnPack2.HeaderText = "نام خودرو";
            gridViewTextBoxColumnPack2.Name = "vehicle_Name";
            gridViewTextBoxColumnPack2.Width = 117;


            gridViewTextBoxColumnGatePass17.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass17.FieldName = "vehicle_Color";
            gridViewTextBoxColumnGatePass17.HeaderText = "رنگ خودرو";
            gridViewTextBoxColumnGatePass17.Name = "vehicle_Color";
            gridViewTextBoxColumnGatePass17.Width = 64;


            gridViewTextBoxColumnGatePass16.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass16.FieldName = "Vehicle_Model";
            gridViewTextBoxColumnGatePass16.HeaderText = "مدل خودرو";
            gridViewTextBoxColumnGatePass16.Name = "Vehicle_Model";
            gridViewTextBoxColumnGatePass16.Width = 67;

            gridViewCheckBoxColumnGatePass3.EnableExpressionEditor = false;
            gridViewCheckBoxColumnGatePass3.FieldName = "Vehicle_IsCompany";
            gridViewCheckBoxColumnGatePass3.HeaderText = "خودرو شرکتی";
            gridViewCheckBoxColumnGatePass3.IsVisible = false;
            gridViewCheckBoxColumnGatePass3.MinWidth = 20;
            gridViewCheckBoxColumnGatePass3.Name = "Vehicle_IsCompany";
            gridViewCheckBoxColumnGatePass3.Width = 85;



            gridViewTextBoxColumnPack13.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack13.FieldName = "VehicleType_Name";
            gridViewTextBoxColumnPack13.HeaderText = "نام نوع خودرو";
            gridViewTextBoxColumnPack13.IsVisible = true;
            gridViewTextBoxColumnPack13.Name = "VehicleType_Name";


            gridViewDateTimeColumnPack1.EnableExpressionEditor = false;
            gridViewDateTimeColumnPack1.FieldName = "Package_StartDate";
            gridViewDateTimeColumnPack1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnPack1.HeaderText = "تاریخ شروع";
            gridViewDateTimeColumnPack1.IsVisible = false;
            gridViewDateTimeColumnPack1.Name = "Package_StartDate";



            gridViewDateTimeColumnPack2.EnableExpressionEditor = false;
            gridViewDateTimeColumnPack2.FieldName = "Package_EndDate";
            gridViewDateTimeColumnPack2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnPack2.HeaderText = "تاریخ پایان";
            gridViewDateTimeColumnPack2.IsVisible = false;
            gridViewDateTimeColumnPack2.Name = "Package_EndDate";



            gridViewTextBoxColumnGatePass22.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass22.FieldName = "Package_OperIdRequest";
            gridViewTextBoxColumnGatePass22.HeaderText = "Package_OperIdRequest";
            gridViewTextBoxColumnGatePass22.IsVisible = false;
            gridViewTextBoxColumnGatePass22.Name = "Package_OperIdRequest";



            gridViewTextBoxColumnPack9.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack9.FieldName = "Package_NameOperRequest";
            gridViewTextBoxColumnPack9.HeaderText = "نام درخواست کننده";
            gridViewTextBoxColumnPack9.Name = "Package_NameOperRequest";
            gridViewTextBoxColumnPack9.Width = 102;



            gridViewTextBoxColumnPack7.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack7.FieldName = "Package_Description";
            gridViewTextBoxColumnPack7.HeaderText = "توضیحات";
            gridViewTextBoxColumnPack7.IsVisible = true;
            gridViewTextBoxColumnPack7.Name = "Package_Description";





            gridViewTextBoxColumnPack12.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack12.FieldName = "Package_Shift";
            gridViewTextBoxColumnPack12.HeaderText = "شیفت کاری";
            gridViewTextBoxColumnPack12.Name = "Package_Shift";
            gridViewTextBoxColumnPack12.Width = 66;


            gridViewTextBoxColumnPack3.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack3.FieldName = "Office_Name";
            gridViewTextBoxColumnPack3.HeaderText = "اداره متقاضی";
            gridViewTextBoxColumnPack3.Name = "Office_Name";
            gridViewTextBoxColumnPack3.Width = 105;


            gridViewTextBoxColumnGatePass21.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass21.FieldName = "TypePlates_Desc";
            gridViewTextBoxColumnGatePass21.HeaderText = "TypePlates_Desc";
            gridViewTextBoxColumnGatePass21.IsVisible = false;
            gridViewTextBoxColumnGatePass21.Name = "TypePlates_Desc";



            gridViewTextBoxColumnGatePass9.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass9.FieldName = "Places_Label";
            gridViewTextBoxColumnGatePass9.HeaderText = "محدوده تردد";
            gridViewTextBoxColumnGatePass9.IsVisible = true;
            gridViewTextBoxColumnGatePass9.Name = "Places_Label";
            gridViewTextBoxColumnGatePass9.Width = 106;


            gridViewTextBoxColumnGatePass10.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass10.FieldName = "Gate_Label";
            gridViewTextBoxColumnGatePass10.HeaderText = "دروازه تردد";
            gridViewTextBoxColumnGatePass10.IsVisible = true;
            gridViewTextBoxColumnGatePass10.Name = "Gate_Label";



            gridViewDecimalColumnGatePass2.EnableExpressionEditor = false;
            gridViewDecimalColumnGatePass2.FieldName = "Gatepass_ID";
            gridViewDecimalColumnGatePass2.HeaderText = "آیدی گیت پاس";
            gridViewDecimalColumnGatePass2.IsVisible = false;
            gridViewDecimalColumnGatePass2.Name = "Gatepass_ID";

            gridViewDecimalColumnVeh1.EnableExpressionEditor = false;
            gridViewDecimalColumnVeh1.FieldName = "Archive_TagId";
            gridViewDecimalColumnVeh1.HeaderText = "کد تردد";
            gridViewDecimalColumnVeh1.IsVisible = true;
            gridViewDecimalColumnVeh1.Name = "Archive_TagId";

            gridViewDecimalColumnPack1.EnableExpressionEditor = false;
            gridViewDecimalColumnPack1.FieldName = "Package_BaridIdOperRequest";
            gridViewDecimalColumnPack1.HeaderText = "Package_BaridIdOperRequest";
            gridViewDecimalColumnPack1.IsVisible = false;
            gridViewDecimalColumnPack1.Name = "Package_BaridIdOperRequest";

            gridViewDecimalColumnPack2.EnableExpressionEditor = false;
            gridViewDecimalColumnPack2.FieldName = "Package_BaridIdOperConfirm";
            gridViewDecimalColumnPack2.HeaderText = "Package_BaridIdOperConfirm";
            gridViewDecimalColumnPack2.IsVisible = false;
            gridViewDecimalColumnPack2.Name = "Package_BaridIdOperConfirm";
            gridViewDecimalColumnPack2.Width = 105;


            gridViewDecimalColumnPack4.EnableExpressionEditor = false;
            gridViewDecimalColumnPack4.FieldName = "Package_BaridIdOperPassage";
            gridViewDecimalColumnPack4.HeaderText = "Package_BaridIdOperPassage";
            gridViewDecimalColumnPack4.IsVisible = false;
            gridViewDecimalColumnPack4.Name = "Package_BaridIdOperPassage";




            gridViewTextBoxColumnPack4.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack4.FieldName = "Package_OperIdConfirm";
            gridViewTextBoxColumnPack4.HeaderText = "Package_OperIdConfirm";
            gridViewTextBoxColumnPack4.IsVisible = false;
            gridViewTextBoxColumnPack4.Name = "Package_OperIdConfirm";
            gridViewTextBoxColumnPack4.Width = 105;
            gridViewTextBoxColumnPack5.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack5.FieldName = "Package_NameOperConfirm";
            gridViewTextBoxColumnPack5.HeaderText = "تایید کننده ";
            gridViewTextBoxColumnPack5.Name = "Package_NameOperConfirm";
            gridViewTextBoxColumnPack5.Width = 105;
            gridViewTextBoxColumnPack6.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack6.FieldName = "Package_OperIdPassage";
            gridViewTextBoxColumnPack6.HeaderText = "Package_OperIdPassage";
            gridViewTextBoxColumnPack6.IsVisible = false;
            gridViewTextBoxColumnPack6.Name = "Package_OperIdPassage";
            gridViewTextBoxColumnPack6.Width = 105;


            gridViewTextBoxColumnPack8.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack8.FieldName = "Package_NameOperPassage";
            gridViewTextBoxColumnPack8.HeaderText = "تصویب کننده";
            gridViewTextBoxColumnPack8.IsVisible = true;
            gridViewTextBoxColumnPack8.Name = "Package_NameOperPassage";
            gridViewTextBoxColumnPack8.Width = 247;



            gridViewTextBoxColumnPack11.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack11.FieldName = "TravelArea_LabelTravel";
            gridViewTextBoxColumnPack11.HeaderText = "محل کار";
            gridViewTextBoxColumnPack11.IsVisible = true;
            gridViewTextBoxColumnPack11.Name = "TravelArea_LabelTravel";


            gridViewTextBoxColumnPack14.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack14.FieldName = "Agreement_Company";
            gridViewTextBoxColumnPack14.HeaderText = "پیمانکار / شرکت";
            gridViewTextBoxColumnPack14.IsVisible = true;
            gridViewTextBoxColumnPack14.Name = "Agreement_Company";

            gridViewTextBoxColumnPack15.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack15.FieldName = "TypePack_Name";
            gridViewTextBoxColumnPack15.HeaderText = "نوع بسته";
            gridViewTextBoxColumnPack15.IsVisible = true;
            gridViewTextBoxColumnPack15.Name = "TypePack_Name";







            gridViewDateTimeColumnGatePass1.EnableExpressionEditor = false;
            gridViewDateTimeColumnGatePass1.FieldName = "Agreement_StartDate";
            gridViewDateTimeColumnGatePass1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnGatePass1.HeaderText = "Agreement_StartDate";
            gridViewDateTimeColumnGatePass1.IsVisible = false;
            gridViewDateTimeColumnGatePass1.Name = "Agreement_StartDate";
            gridViewDateTimeColumnGatePass1.Width = 85;
            gridViewDateTimeColumnGatePass3.EnableExpressionEditor = false;
            gridViewDateTimeColumnGatePass3.FieldName = "Agreement_EndDate";
            gridViewDateTimeColumnGatePass3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnGatePass3.HeaderText = "Agreement_EndDate";
            gridViewDateTimeColumnGatePass3.IsVisible = false;
            gridViewDateTimeColumnGatePass3.Name = "Agreement_EndDate";


            gridViewImageColumnPerson1.EnableExpressionEditor = false;
            gridViewImageColumnPerson1.FieldName = "Sign_Shape";
            gridViewImageColumnPerson1.HeaderText = "Sign_Shape";
            gridViewImageColumnPerson1.IsVisible = false;
            gridViewImageColumnPerson1.Name = "Sign_Shape";


            this.radGridViewReport.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumnPack3,
gridViewDecimalColumnPack7,

gridViewCheckBoxColumnGatePass2,
gridViewTextBoxColumnGatePass2,

gridViewTextBoxColumnGatePass6,

gridViewTextBoxColumnGatePass8,

gridViewTextBoxColumnGatePass3,

gridViewTextBoxColumnGatePass4,
gridViewTextBoxColumnGatePass5,

gridViewTextBoxColumnPack1,

gridViewTextBoxColumnPack10,

gridViewTextBoxColumnGatePass11,

gridViewDateTimeColumnGatePass2,


gridViewImageColumnGatePass1,

gridViewTextBoxColumnGatePass7,


gridViewTextBoxColumnGatePass15,

gridViewTextBoxColumnPack2,


gridViewTextBoxColumnGatePass17,

gridViewTextBoxColumnGatePass16,

gridViewCheckBoxColumnGatePass3,

gridViewTextBoxColumnPack13,

gridViewDateTimeColumnPack1,

gridViewDateTimeColumnPack2,

gridViewTextBoxColumnGatePass22,
gridViewTextBoxColumnPack9,
gridViewTextBoxColumnPack7,
gridViewTextBoxColumnPack12,
gridViewTextBoxColumnPack3,
gridViewTextBoxColumnGatePass21,
gridViewTextBoxColumnGatePass9,
gridViewTextBoxColumnGatePass10,
gridViewDecimalColumnGatePass2,
gridViewDecimalColumnPack1,
gridViewDecimalColumnPack2,
gridViewDecimalColumnPack4,
gridViewTextBoxColumnPack4,
gridViewTextBoxColumnPack5,
gridViewTextBoxColumnPack6,
gridViewTextBoxColumnPack8,

gridViewTextBoxColumnPack11,
gridViewTextBoxColumnPack14,
gridViewTextBoxColumnPack15,
gridViewDateTimeColumnGatePass1,

gridViewDateTimeColumnGatePass3,

gridViewImageColumnPerson1,
gridViewTextBoxColumnPerson9,
gridViewDecimalColumnVeh1
        });

            #endregion

            #endregion
        }
        private void InOutPainter()
        {
            #region _gatepass

            #region Pack and GatePass

            gridViewTextBoxColumnPerson9 = new GridViewTextBoxColumn();
            gridViewDecimalColumnPack3 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack7 = new GridViewDecimalColumn();

            gridViewCheckBoxColumnGatePass2 = new GridViewCheckBoxColumn();
            gridViewTextBoxColumnGatePass2 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass6 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass8 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass3 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass4 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass5 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnPack1 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnPack10 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass11 = new GridViewTextBoxColumn();

            gridViewDateTimeColumnGatePass2 = new GridViewDateTimeColumn();


            gridViewImageColumnGatePass1 = new GridViewImageColumn();

            gridViewTextBoxColumnGatePass7 = new GridViewTextBoxColumn();


            gridViewTextBoxColumnGatePass15 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnPack2 = new GridViewTextBoxColumn();


            gridViewTextBoxColumnGatePass17 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass16 = new GridViewTextBoxColumn();

            gridViewCheckBoxColumnGatePass3 = new GridViewCheckBoxColumn();

            gridViewTextBoxColumnPack13 = new GridViewTextBoxColumn();

            gridViewDateTimeColumnPack1 = new GridViewDateTimeColumn();

            gridViewDateTimeColumnPack2 = new GridViewDateTimeColumn();
            //gridViewTextBoxColumnPack1 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass22 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack9 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack7 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack12 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack3 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass21 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass9 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass10 = new GridViewTextBoxColumn();
            gridViewDecimalColumnGatePass2 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack1 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack2 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack4 = new GridViewDecimalColumn();
            gridViewTextBoxColumnPack4 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack5 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack6 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack8 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnPack11 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack14 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack15 = new GridViewTextBoxColumn();
            gridViewDateTimeColumnGatePass1 = new GridViewDateTimeColumn();

            gridViewDateTimeColumnGatePass3 = new GridViewDateTimeColumn();

            gridViewImageColumnPerson1 = new GridViewImageColumn();


            gridViewDecimalColumnVeh1 = new GridViewDecimalColumn();


            gridViewTextBoxColumnPerson9.EnableExpressionEditor = false;
            gridViewTextBoxColumnPerson9.FieldName = "TravelArea_Name";
            gridViewTextBoxColumnPerson9.HeaderText = "نام محدوده تردد";
            gridViewTextBoxColumnPerson9.IsVisible = false;
            gridViewTextBoxColumnPerson9.Name = "TravelArea_Name";



            gridViewDecimalColumnPack3.EnableExpressionEditor = false;
            gridViewDecimalColumnPack3.FieldName = "CountPrinted";
            gridViewDecimalColumnPack3.HeaderText = "تعداد چاپ";
            gridViewDecimalColumnPack3.IsVisible = false;
            gridViewDecimalColumnPack3.Name = "CountPrinted";


            gridViewDecimalColumnPack7.EnableExpressionEditor = false;
            gridViewDecimalColumnPack7.FieldName = "Archive_ID";
            gridViewDecimalColumnPack7.HeaderText = "آیدی آرشیو";
            gridViewDecimalColumnPack7.IsVisible = false;
            gridViewDecimalColumnPack7.Name = "Archive_ID";

            gridViewTextBoxColumnGatePass2.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass2.FieldName = "Person_NationalCode";
            gridViewTextBoxColumnGatePass2.HeaderText = "شماره ملی";
            gridViewTextBoxColumnGatePass2.Name = "Person_NationalCode";
            gridViewTextBoxColumnGatePass2.Width = 145;

            gridViewCheckBoxColumnGatePass2.EnableExpressionEditor = false;
            gridViewCheckBoxColumnGatePass2.FieldName = "Person_isWoman";
            gridViewCheckBoxColumnGatePass2.HeaderText = "مونث";
            gridViewCheckBoxColumnGatePass2.IsVisible = false;
            gridViewCheckBoxColumnGatePass2.MinWidth = 20;
            gridViewCheckBoxColumnGatePass2.Name = "Person_isWoman";
            gridViewCheckBoxColumnGatePass2.Width = 31;



            gridViewTextBoxColumnGatePass6.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass6.FieldName = "Person_IdentifyCode";
            gridViewTextBoxColumnGatePass6.HeaderText = "شماره شناسایی";
            gridViewTextBoxColumnGatePass6.Name = "Person_IdentifyCode";
            gridViewTextBoxColumnGatePass6.Width = 103;



            gridViewTextBoxColumnGatePass8.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass8.FieldName = "Person_LicenseDriverCode";
            gridViewTextBoxColumnGatePass8.HeaderText = "شماره گواهینامه رانندگی";
            gridViewTextBoxColumnGatePass8.IsVisible = true;
            gridViewTextBoxColumnGatePass8.Name = "Person_LicenseDriverCode";
            gridViewTextBoxColumnGatePass8.Width = 168;



            gridViewTextBoxColumnGatePass3.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass3.FieldName = "Person_Name";
            gridViewTextBoxColumnGatePass3.HeaderText = "نام";
            gridViewTextBoxColumnGatePass3.Name = "Person_Name";
            gridViewTextBoxColumnGatePass3.Width = 119;
            gridViewTextBoxColumnGatePass4.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass4.FieldName = "Person_Surname";
            gridViewTextBoxColumnGatePass4.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumnGatePass4.Name = "Person_Surname";
            gridViewTextBoxColumnGatePass4.Width = 195;
            gridViewTextBoxColumnGatePass5.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass5.FieldName = "Person_FatherName";
            gridViewTextBoxColumnGatePass5.HeaderText = "نام پدر";
            gridViewTextBoxColumnGatePass5.Name = "Person_FatherName";
            gridViewTextBoxColumnGatePass5.Width = 109;




            gridViewTextBoxColumnPack1.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack1.FieldName = "Person_BirthCity";
            gridViewTextBoxColumnPack1.HeaderText = "شهر محل تولد";
            gridViewTextBoxColumnPack1.Name = "Person_BirthCity";
            gridViewTextBoxColumnPack1.IsVisible = true;
            gridViewTextBoxColumnPack1.Width = 90;



            gridViewTextBoxColumnPack10.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack10.FieldName = "Person_RegisterCity";
            gridViewTextBoxColumnPack10.HeaderText = "محل صدور";
            gridViewTextBoxColumnPack10.Name = "Person_RegisterCity";
            gridViewTextBoxColumnPack10.Width = 90;



            gridViewTextBoxColumnGatePass11.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass11.FieldName = "Person_Nationality";
            gridViewTextBoxColumnGatePass11.HeaderText = "تابعیت";
            gridViewTextBoxColumnGatePass11.IsVisible = true;
            gridViewTextBoxColumnGatePass11.Name = "Person_Nationality";
            gridViewTextBoxColumnGatePass11.Width = 64;



            gridViewDateTimeColumnGatePass2.EnableExpressionEditor = false;
            gridViewDateTimeColumnGatePass2.FieldName = "Person_BirthDate";
            gridViewDateTimeColumnGatePass2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnGatePass2.HeaderText = "تاریخ تولد";
            gridViewDateTimeColumnGatePass2.IsVisible = true;
            gridViewDateTimeColumnGatePass2.Name = "Person_BirthDate";



            gridViewImageColumnGatePass1.EnableExpressionEditor = false;
            gridViewImageColumnGatePass1.FieldName = "Person_Picture";
            gridViewImageColumnGatePass1.HeaderText = "عکس";
            gridViewImageColumnGatePass1.IsVisible = false;
            gridViewImageColumnGatePass1.Name = "Person_Picture";


            gridViewTextBoxColumnGatePass7.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass7.FieldName = "Person_LabelIsWoman";
            gridViewTextBoxColumnGatePass7.HeaderText = "جنسیت";
            gridViewTextBoxColumnGatePass7.Name = "Person_LabelIsWoman";
            gridViewTextBoxColumnGatePass7.Width = 57;


            gridViewTextBoxColumnGatePass15.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass15.FieldName = "Vehicle_number";
            gridViewTextBoxColumnGatePass15.HeaderText = "پلاک خودرو";
            gridViewTextBoxColumnGatePass15.Name = "Vehicle_number";
            gridViewTextBoxColumnGatePass15.Width = 81;



            gridViewTextBoxColumnPack2.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack2.FieldName = "vehicle_Name";
            gridViewTextBoxColumnPack2.HeaderText = "نام خودرو";
            gridViewTextBoxColumnPack2.Name = "vehicle_Name";
            gridViewTextBoxColumnPack2.Width = 117;


            gridViewTextBoxColumnGatePass17.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass17.FieldName = "vehicle_Color";
            gridViewTextBoxColumnGatePass17.HeaderText = "رنگ خودرو";
            gridViewTextBoxColumnGatePass17.Name = "vehicle_Color";
            gridViewTextBoxColumnGatePass17.Width = 64;


            gridViewTextBoxColumnGatePass16.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass16.FieldName = "Vehicle_Model";
            gridViewTextBoxColumnGatePass16.HeaderText = "مدل خودرو";
            gridViewTextBoxColumnGatePass16.Name = "Vehicle_Model";
            gridViewTextBoxColumnGatePass16.Width = 67;

            gridViewCheckBoxColumnGatePass3.EnableExpressionEditor = false;
            gridViewCheckBoxColumnGatePass3.FieldName = "Vehicle_IsCompany";
            gridViewCheckBoxColumnGatePass3.HeaderText = "خودرو شرکتی";
            gridViewCheckBoxColumnGatePass3.IsVisible = false;
            gridViewCheckBoxColumnGatePass3.MinWidth = 20;
            gridViewCheckBoxColumnGatePass3.Name = "Vehicle_IsCompany";
            gridViewCheckBoxColumnGatePass3.Width = 85;



            gridViewTextBoxColumnPack13.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack13.FieldName = "VehicleType_Name";
            gridViewTextBoxColumnPack13.HeaderText = "نام نوع خودرو";
            gridViewTextBoxColumnPack13.IsVisible = true;
            gridViewTextBoxColumnPack13.Name = "VehicleType_Name";


            gridViewDateTimeColumnPack1.EnableExpressionEditor = false;
            gridViewDateTimeColumnPack1.FieldName = "Package_StartDate";
            gridViewDateTimeColumnPack1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnPack1.HeaderText = "تاریخ شروع";
            gridViewDateTimeColumnPack1.IsVisible = false;
            gridViewDateTimeColumnPack1.Name = "Package_StartDate";



            gridViewDateTimeColumnPack2.EnableExpressionEditor = false;
            gridViewDateTimeColumnPack2.FieldName = "Package_EndDate";
            gridViewDateTimeColumnPack2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnPack2.HeaderText = "تاریخ پایان";
            gridViewDateTimeColumnPack2.IsVisible = false;
            gridViewDateTimeColumnPack2.Name = "Package_EndDate";



            gridViewTextBoxColumnGatePass22.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass22.FieldName = "Package_OperIdRequest";
            gridViewTextBoxColumnGatePass22.HeaderText = "Package_OperIdRequest";
            gridViewTextBoxColumnGatePass22.IsVisible = false;
            gridViewTextBoxColumnGatePass22.Name = "Package_OperIdRequest";



            gridViewTextBoxColumnPack9.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack9.FieldName = "Package_NameOperRequest";
            gridViewTextBoxColumnPack9.HeaderText = "نام درخواست کننده";
            gridViewTextBoxColumnPack9.Name = "Package_NameOperRequest";
            gridViewTextBoxColumnPack9.Width = 102;



            gridViewTextBoxColumnPack7.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack7.FieldName = "Package_Description";
            gridViewTextBoxColumnPack7.HeaderText = "توضیحات";
            gridViewTextBoxColumnPack7.IsVisible = true;
            gridViewTextBoxColumnPack7.Name = "Package_Description";





            gridViewTextBoxColumnPack12.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack12.FieldName = "Package_Shift";
            gridViewTextBoxColumnPack12.HeaderText = "شیفت کاری";
            gridViewTextBoxColumnPack12.Name = "Package_Shift";
            gridViewTextBoxColumnPack12.Width = 66;


            gridViewTextBoxColumnPack3.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack3.FieldName = "Office_Name";
            gridViewTextBoxColumnPack3.HeaderText = "اداره متقاضی";
            gridViewTextBoxColumnPack3.Name = "Office_Name";
            gridViewTextBoxColumnPack3.Width = 105;


            gridViewTextBoxColumnGatePass21.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass21.FieldName = "TypePlates_Desc";
            gridViewTextBoxColumnGatePass21.HeaderText = "TypePlates_Desc";
            gridViewTextBoxColumnGatePass21.IsVisible = false;
            gridViewTextBoxColumnGatePass21.Name = "TypePlates_Desc";



            gridViewTextBoxColumnGatePass9.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass9.FieldName = "Places_Label";
            gridViewTextBoxColumnGatePass9.HeaderText = "محدوده تردد";
            gridViewTextBoxColumnGatePass9.IsVisible = true;
            gridViewTextBoxColumnGatePass9.Name = "Places_Label";
            gridViewTextBoxColumnGatePass9.Width = 106;


            gridViewTextBoxColumnGatePass10.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass10.FieldName = "Gate_Label";
            gridViewTextBoxColumnGatePass10.HeaderText = "دروازه تردد";
            gridViewTextBoxColumnGatePass10.IsVisible = true;
            gridViewTextBoxColumnGatePass10.Name = "Gate_Label";



            gridViewDecimalColumnGatePass2.EnableExpressionEditor = false;
            gridViewDecimalColumnGatePass2.FieldName = "Gatepass_ID";
            gridViewDecimalColumnGatePass2.HeaderText = "آیدی گیت پاس";
            gridViewDecimalColumnGatePass2.IsVisible = false;
            gridViewDecimalColumnGatePass2.Name = "Gatepass_ID";

            gridViewDecimalColumnVeh1.EnableExpressionEditor = false;
            gridViewDecimalColumnVeh1.FieldName = "Archive_TagId";
            gridViewDecimalColumnVeh1.HeaderText = "کد تردد";
            gridViewDecimalColumnVeh1.IsVisible = true;
            gridViewDecimalColumnVeh1.Name = "Archive_TagId";

            gridViewDecimalColumnPack1.EnableExpressionEditor = false;
            gridViewDecimalColumnPack1.FieldName = "Package_BaridIdOperRequest";
            gridViewDecimalColumnPack1.HeaderText = "Package_BaridIdOperRequest";
            gridViewDecimalColumnPack1.IsVisible = false;
            gridViewDecimalColumnPack1.Name = "Package_BaridIdOperRequest";

            gridViewDecimalColumnPack2.EnableExpressionEditor = false;
            gridViewDecimalColumnPack2.FieldName = "Package_BaridIdOperConfirm";
            gridViewDecimalColumnPack2.HeaderText = "Package_BaridIdOperConfirm";
            gridViewDecimalColumnPack2.IsVisible = false;
            gridViewDecimalColumnPack2.Name = "Package_BaridIdOperConfirm";
            gridViewDecimalColumnPack2.Width = 105;


            gridViewDecimalColumnPack4.EnableExpressionEditor = false;
            gridViewDecimalColumnPack4.FieldName = "Package_BaridIdOperPassage";
            gridViewDecimalColumnPack4.HeaderText = "Package_BaridIdOperPassage";
            gridViewDecimalColumnPack4.IsVisible = false;
            gridViewDecimalColumnPack4.Name = "Package_BaridIdOperPassage";




            gridViewTextBoxColumnPack4.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack4.FieldName = "Package_OperIdConfirm";
            gridViewTextBoxColumnPack4.HeaderText = "Package_OperIdConfirm";
            gridViewTextBoxColumnPack4.IsVisible = false;
            gridViewTextBoxColumnPack4.Name = "Package_OperIdConfirm";
            gridViewTextBoxColumnPack4.Width = 105;
            gridViewTextBoxColumnPack5.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack5.FieldName = "Package_NameOperConfirm";
            gridViewTextBoxColumnPack5.HeaderText = "تایید کننده ";
            gridViewTextBoxColumnPack5.Name = "Package_NameOperConfirm";
            gridViewTextBoxColumnPack5.Width = 105;
            gridViewTextBoxColumnPack6.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack6.FieldName = "Package_OperIdPassage";
            gridViewTextBoxColumnPack6.HeaderText = "Package_OperIdPassage";
            gridViewTextBoxColumnPack6.IsVisible = false;
            gridViewTextBoxColumnPack6.Name = "Package_OperIdPassage";
            gridViewTextBoxColumnPack6.Width = 105;


            gridViewTextBoxColumnPack8.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack8.FieldName = "Package_NameOperPassage";
            gridViewTextBoxColumnPack8.HeaderText = "تصویب کننده";
            gridViewTextBoxColumnPack8.IsVisible = true;
            gridViewTextBoxColumnPack8.Name = "Package_NameOperPassage";
            gridViewTextBoxColumnPack8.Width = 247;



            gridViewTextBoxColumnPack11.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack11.FieldName = "TravelArea_LabelTravel";
            gridViewTextBoxColumnPack11.HeaderText = "محل کار";
            gridViewTextBoxColumnPack11.IsVisible = true;
            gridViewTextBoxColumnPack11.Name = "TravelArea_LabelTravel";


            gridViewTextBoxColumnPack14.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack14.FieldName = "Agreement_Company";
            gridViewTextBoxColumnPack14.HeaderText = "پیمانکار / شرکت";
            gridViewTextBoxColumnPack14.IsVisible = true;
            gridViewTextBoxColumnPack14.Name = "Agreement_Company";

            gridViewTextBoxColumnPack15.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack15.FieldName = "TypePack_Name";
            gridViewTextBoxColumnPack15.HeaderText = "نوع بسته";
            gridViewTextBoxColumnPack15.IsVisible = true;
            gridViewTextBoxColumnPack15.Name = "TypePack_Name";







            gridViewDateTimeColumnGatePass1.EnableExpressionEditor = false;
            gridViewDateTimeColumnGatePass1.FieldName = "Agreement_StartDate";
            gridViewDateTimeColumnGatePass1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnGatePass1.HeaderText = "Agreement_StartDate";
            gridViewDateTimeColumnGatePass1.IsVisible = false;
            gridViewDateTimeColumnGatePass1.Name = "Agreement_StartDate";
            gridViewDateTimeColumnGatePass1.Width = 85;
            gridViewDateTimeColumnGatePass3.EnableExpressionEditor = false;
            gridViewDateTimeColumnGatePass3.FieldName = "Agreement_EndDate";
            gridViewDateTimeColumnGatePass3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnGatePass3.HeaderText = "Agreement_EndDate";
            gridViewDateTimeColumnGatePass3.IsVisible = false;
            gridViewDateTimeColumnGatePass3.Name = "Agreement_EndDate";


            gridViewImageColumnPerson1.EnableExpressionEditor = false;
            gridViewImageColumnPerson1.FieldName = "Sign_Shape";
            gridViewImageColumnPerson1.HeaderText = "Sign_Shape";
            gridViewImageColumnPerson1.IsVisible = false;
            gridViewImageColumnPerson1.Name = "Sign_Shape";


            this.radGridViewReport.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumnPack3,
gridViewDecimalColumnPack7,

gridViewCheckBoxColumnGatePass2,
gridViewTextBoxColumnGatePass2,

gridViewTextBoxColumnGatePass6,

gridViewTextBoxColumnGatePass8,

gridViewTextBoxColumnGatePass3,

gridViewTextBoxColumnGatePass4,
gridViewTextBoxColumnGatePass5,

gridViewTextBoxColumnPack1,

gridViewTextBoxColumnPack10,

gridViewTextBoxColumnGatePass11,

gridViewDateTimeColumnGatePass2,


gridViewImageColumnGatePass1,

gridViewTextBoxColumnGatePass7,


gridViewTextBoxColumnGatePass15,

gridViewTextBoxColumnPack2,


gridViewTextBoxColumnGatePass17,

gridViewTextBoxColumnGatePass16,

gridViewCheckBoxColumnGatePass3,

gridViewTextBoxColumnPack13,

gridViewDateTimeColumnPack1,

gridViewDateTimeColumnPack2,

gridViewTextBoxColumnGatePass22,
gridViewTextBoxColumnPack9,
gridViewTextBoxColumnPack7,
gridViewTextBoxColumnPack12,
gridViewTextBoxColumnPack3,
gridViewTextBoxColumnGatePass21,
gridViewTextBoxColumnGatePass9,
gridViewTextBoxColumnGatePass10,
gridViewDecimalColumnGatePass2,
gridViewDecimalColumnPack1,
gridViewDecimalColumnPack2,
gridViewDecimalColumnPack4,
gridViewTextBoxColumnPack4,
gridViewTextBoxColumnPack5,
gridViewTextBoxColumnPack6,
gridViewTextBoxColumnPack8,

gridViewTextBoxColumnPack11,
gridViewTextBoxColumnPack14,
gridViewTextBoxColumnPack15,
gridViewDateTimeColumnGatePass1,

gridViewDateTimeColumnGatePass3,

gridViewImageColumnPerson1,
gridViewTextBoxColumnPerson9,
gridViewDecimalColumnVeh1
        });

            #endregion

            #endregion
        }

        private void clear(_State InState)
        {
            try
            {
                CursorWait();
                switch (CurrentState)
                {
                    case _State._None:
                        break;
                    case _State._Person:
                        ucSearchPerson.clearItenms();
                        break;
                    case _State._agreement:
                        ucSearchAgree.clearItenms();

                        break;
                    case _State._office:
                        ucSearchOffice.clearItenms();
                        break;
                    case _State._vehicle:
                        ucSearchVeh.clearItenms();

                        break;
                    case _State._gatepass:
                        break;
                    case _State._blacklist:
                        break;
                    case _State._operator:
                        break;
                    case _State._Inout:
                        break;
                    default:
                        break;
                }
                CursorDefault();
            }
            catch (Exception ex)
            {
                CursorDefault();
                ItemsPublic.ShowMessage(ex.Message);
            }
        }
        bool copyingMode = false;
        private void radGridViewReport_SelectionChanged(object sender, EventArgs e)
        {
            SetProperties();
        }

        protected void GroupingControls(Control collect)
        {

            try
            {

                foreach (Control cntrl in collect.Controls)
                {
                    //if ( lump )
                    //{
                    //    if ( cntrl is RadTextBox  || cntrl is RadButton || cntrl is RadMaskedEditBox || cntrl is RadTextBox || cntrl is UserControl )
                    //    {
                    //        int h = 0;
                    //        MessageBox.Show ( cntrl.Name + "\n" + cntrl.Tag );
                    //    }
                    //}

                    //if ( cntrl is UserControl && cntrl.Name=="uC_ViewPersonDetails1" )
                    //{
                    //    lump = true;
                    //    MessageBox.Show(cntrl.Name);
                    //}

                    if (cntrl.Tag == null || cntrl.Tag.ToString() == "")
                    {
                        GroupingControls(cntrl);
                    }
                    else if (cntrl.Tag.ToString().Any(c => c == 'l'))
                    {
                        //  cntrl.Tag = "";
                        //   GroupingControlsView(cntrl);
                        //   cntrl.Tag = "";
                        continue;
                    }

                    if (cntrl.Tag != null && cntrl.Tag.ToString() != "")
                    {
                        if (cntrl.Tag.ToString().Any(c => c == 'a'))
                        {

                        }
                        else
                        {
                            throw new Exception("control have not 'a' caracter");
                        }

                        foreach (char c in cntrl.Tag.ToString())
                        {
                            // d ro vase disable kardan gharar midim

                            // edit =e , new = n , search = s ,  = d, view =v 
                            //if ( cntrl is RadButton )
                            //{
                            //    int k = 0;
                            //    MessageBox.Show ( cntrl.Name );
                            //}
                            switch (c)
                            {
                                case 'e':
                                    //    myEdit.Add(cntrl);
                                    break;
                                case 'n':
                                    //   myNew.Add(cntrl);
                                    break;
                                case 's':
                                    //   mySearch.Add(cntrl);
                                    break;
                                case 'd':
                                    //   myDelete.Add(cntrl);
                                    break;
                                case 'v':
                                    //   myView.Add(cntrl);
                                    break;
                                case 'a':
                                    myAll.Add(cntrl);
                                    break;
                                case 'L':
                                    break;
                                default:
                                    throw new Exception("Ananymous Caracter");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                //MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        protected List<object> myAll = new List<object>();

        private void MainReporter_Shown(object sender, EventArgs e)
        {
            if (uC_TreeReport1.TreeViewReports.Nodes.Where(x=>x.Visible).Count() == 1)
            {
                uC_TreeReport1.TreeViewReports.SelectedNode = uC_TreeReport1.TreeViewReports.Nodes.Single(x => x.Visible);
            }
        }
    }
}
