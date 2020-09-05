using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI;
using ServerClasses;
using Telerik.WinControls;
using aorc.gatepass.Complex_Reports;


namespace aorc.gatepass.Complex_Reports.Reporter
{
    public partial class V2_MainReporter : Form
    {

        UC_ViewPersonDetails ucPropertyPerson;
        ReportPerson.UC_ReportSearchPerson ucSearchPerson;

        UC_agreementsDetails ucPropertyAgree;
        ReportGH.UC_ReportSearchAgree ucSearchAgree;

        UC_officeDetails ucPropertyOffice;
        ReportOffice.UC_ReportSearchOffice ucSearchOffice;

       ui.vehicle.UC_vehicleDetails3 ucPropertyVeh;
       ReportVeh.UC_ReportSearchVehicle ucSearchVeh;

        #region Columns
      
        GridViewDecimalColumn gridViewDecimalColumnPerson1 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson1 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson2 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson3 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson4 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson5 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson6 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson7 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson8 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson9 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson10 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson11 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson12 ;
        GridViewCheckBoxColumn gridViewCheckBoxColumnPerson1 ;
        GridViewDateTimeColumn gridViewDateTimeColumnPerson1 ;
        GridViewCheckBoxColumn gridViewCheckBoxColumnPerson2 ;
        GridViewImageColumn gridViewImageColumnPerson1 ;
        GridViewDateTimeColumn gridViewDateTimeColumnPerson2 ;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson13 ;
        GridViewCheckBoxColumn gridViewCheckBoxColumnPerson3 ;
        GridViewCheckBoxColumn gridViewCheckBoxColumnPerson4 ;

        GridViewTextBoxColumn gridViewTextBoxColumnAgreement1 ;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement2; 
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement3 ;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement4 ;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement5 ;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement6 ;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement7 ;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement8 ; 
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement9 ;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement10 ;
        GridViewDateTimeColumn gridViewDateTimeColumnAgreement1 ;
        GridViewDateTimeColumn gridViewDateTimeColumnAgreement2 ;
        GridViewCheckBoxColumn gridViewCheckBoxColumnAgreement1 ;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement11 ;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement12 ;
        GridViewCheckBoxColumn gridViewCheckBoxColumnAgreement2 ;


        GridViewTextBoxColumn gridViewTextBoxColumnOff1 ;
        GridViewTextBoxColumn gridViewTextBoxColumnOff2 ;
        GridViewCheckBoxColumn gridViewCheckBoxColumnOff1 ;
        GridViewTextBoxColumn gridViewTextBoxColumnOff3 ;
        GridViewTextBoxColumn gridViewTextBoxColumnOff4 ;
        GridViewTextBoxColumn gridViewTextBoxColumnOff5 ;
        GridViewTextBoxColumn gridViewTextBoxColumnOff6 ;
        GridViewTextBoxColumn gridViewTextBoxColumnOff7 ;
        GridViewTextBoxColumn gridViewTextBoxColumnOff8 ;
        GridViewTextBoxColumn gridViewTextBoxColumnOff9 ;
        GridViewTextBoxColumn gridViewTextBoxColumnOff10 ;
        GridViewTextBoxColumn gridViewTextBoxColumnOff11 ;

        GridViewDecimalColumn gridViewDecimalColumnVeh1 ;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh1 ;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh2 ;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh3 ;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh4 ;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh5 ;
        GridViewCheckBoxColumn gridViewCheckBoxColumnVeh1 ;
        GridViewCheckBoxColumn gridViewCheckBoxColumnVeh2 ;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh6 ;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh7 ;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh8 ;

        
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
            _blacklist= 6,
            _operator = 7,
            _Inout = 8
        }
        _State CurrentState = _State._None;

        public V2_MainReporter()
        {
            try
            {
                InitializeComponent();
           //     objManager = new Manager();
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message );
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            ucPropertyPerson.rlblBirthCity.Text = (radGridViewReport.SelectedRows[0].Cells["Person_BirthCity"].Value.ToString().Trim());
            ucPropertyPerson.TcoRegisterCity.Text =(radGridViewReport.SelectedRows[0].Cells["Person_RegisterCity"].Value.ToString().Trim());
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
            var temp = decimal.Parse(radGridViewReport.SelectedRows[0].Cells["Person_ID"].Value.ToString());
            //if (BlackListData.ContainsKey(temp))
            ucPropertyPerson.TcoIsBlack.Text = ((bool)radGridViewReport.SelectedRows[0].Cells["Person_IsBlackTemp"].Value) ? "مسدود" :"عادی";
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
             //:-)//   eventStatusEdit();
            }
            catch (Exception ex)
            {
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
                            , Package_StartDate,Package_StartDate2,Isreport);
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
                            , Package_StartDate,Package_StartDate2);
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
                if (result != null)
                    if (result.success)
                    {
                        radGridViewReport.DataSource = result.ResultTable;
                        if (radGridViewReport.Rows.Count < 1)
                            ItemsPublic.ShowMessage("موردی یافت نشد");
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
                ItemsPublic.ShowMessage(ex.Message );
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
        			ItemsPublic.ShowMessage(ex.Message );
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

        private void V2_MainReporter_Load(object sender, EventArgs e)
        {
            var userRights = ItemsPublic.MyRights;
            uC_TreeReport1.TreeViewReports.Nodes["NodePerson"].Visible = userRights.Contains(AllFunctions._Rights.Report_person);
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
            cbbSave_Click(sender,e);
        }

        private void rmiCancel_Click(object sender, EventArgs e)
        {
           cbbCancel_Click(sender,e);
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

		RadMenuItem rightcbbRefresh = new RadMenuItem ();
		RadMenuItem rightCbbSearch = new RadMenuItem ();
		RadMenuItem rightCbbEdit = new RadMenuItem ();
		RadMenuItem rightCbbExit = new RadMenuItem ();

		protected void setAllMouseMenus()
		{
			setAllRightMenusCopy ();
			//contextMenu.Items.AddRange ( rightcbbRefresh , rmiStatusSearch , rmiStatusNew , rmiStatusEdit , rmiStatusDelete , rmiStatusPrint , rmiStatusExit );
			contextMenu.Items.AddRange ( rightcbbRefresh , rightCbbSearch ,  rightCbbEdit
										, rightCbbExit );
			radGridViewReport.ContextMenuOpening += new ContextMenuOpeningEventHandler ( radGridViewReport_ContextMenuOpening );
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
			rightcbbRefresh.Click += new System.EventHandler ( cbbRefresh_Click );

			// cbbSearch
			// 
			this.rightCbbSearch.AccessibleDescription = "جستجو";
			this.rightCbbSearch.AccessibleName = "جستجو";
			this.rightCbbSearch.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbSearch.Image = global::aorc.gatepass.Properties.Resources.searchg;
			this.rightCbbSearch.Name = "rightCbbSearch";
			this.rightCbbSearch.Tag = "av";
			this.rightCbbSearch.Text = "جستجو";
			this.rightCbbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbSearch.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbSearch.Click += new System.EventHandler ( this.cbbSearch_Click );
			// 
			
			// cbbEdit
			// 
			this.rightCbbEdit.AccessibleDescription = "بسته باز شود";
			this.rightCbbEdit.AccessibleName = "بسته باز شود";
			this.rightCbbEdit.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbEdit.Image = global::aorc.gatepass.Properties.Resources.editg;
			this.rightCbbEdit.Name = "rightCbbEdit";
			this.rightCbbEdit.Tag = "av";
			this.rightCbbEdit.Text = "بسته باز شود";
			this.rightCbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbEdit.Click += new System.EventHandler ( this.cbbEdit_Click );
			// 

			// exit
			this.rightCbbExit.AccessibleDescription = "خروج";
			this.rightCbbExit.AccessibleName = "خروج";
			this.rightCbbExit.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbExit.Image = global::aorc.gatepass.Properties.Resources.exitg;
			this.rightCbbExit.Name = "rightCbbExit";
			this.rightCbbExit.Text = "خروج";
			this.rightCbbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbExit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbExit.Click += new System.EventHandler ( this.rmiStatusExit_Click );
		}

		private void radGridViewReport_ContextMenuOpening( object sender , ContextMenuOpeningEventArgs e )
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
                        Painter(_State._Person);
                        break;
                    case "NodeAgreement":
                        Painter(_State._agreement);
                        break;
                    case "NodeOffice":
                        Painter(_State._office);
                        break;
                    case "NodeVehicle":
                        Painter(_State._vehicle);
                        break;
                    case "NodeGP":
                        Painter(_State._gatepass);
                        break;
                    case "NodeBlacklist":
                        Painter(_State._blacklist);
                        break;
                    case "NodeOperator":
                        Painter(_State._operator);
                        break;
                    case "NodeInout":
                        Painter(_State._Inout);
                        break;

                }
            }catch(Exception ex){
                CursorDefault();
                ItemsPublic.ShowMessage("متاسفانه خطایی به شرح زیر رخ داد" + "\r\n" + "\r\n" + ex.Message);
            }
        }
       // int _far = 20;
        private void Painter(_State InState)
        {
            CursorWait();
            CurrentState = InState;
            radGridViewReport.DataSource = null;
            radGridViewReport.MasterTemplate.GroupDescriptors.Clear();
            radGridViewReport.MasterTemplate.Columns.Clear();

            if(toolWindowProperties.Controls.Count>0)
                toolWindowProperties.Controls.RemoveAt(0);

            if (toolWindowSearch.Controls.Count > 0)
                toolWindowSearch.Controls.RemoveAt(0);

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
         gridViewDecimalColumnPerson1 = new GridViewDecimalColumn ();
         gridViewTextBoxColumnPerson1 = new GridViewTextBoxColumn ();
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
         gridViewCheckBoxColumnPerson1 = new GridViewCheckBoxColumn ();
         gridViewDateTimeColumnPerson1 = new GridViewDateTimeColumn ();
         gridViewCheckBoxColumnPerson2 = new GridViewCheckBoxColumn ();
         gridViewImageColumnPerson1 = new GridViewImageColumn ();
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
                     ucPropertyOffice = new  UC_officeDetails();
                     ucSearchOffice = new ReportOffice.UC_ReportSearchOffice();
                     toolWindowProperties.Controls.Add(ucPropertyOffice);
                     toolWindowSearch.Controls.Add(ucSearchOffice);
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
                     ucPropertyVeh = new  ui.vehicle.UC_vehicleDetails3 ();
                     ucSearchVeh = new ReportVeh.UC_ReportSearchVehicle();
                     toolWindowProperties.Controls.Add(ucPropertyVeh);
                     toolWindowSearch.Controls.Add(ucSearchVeh);
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
                    #region _gatepass
                    #endregion
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
            CursorDefault();
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
            catch(Exception ex)
            {
                CursorDefault();
                ItemsPublic.ShowMessage(ex.Message);
            }
        }

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
                ItemsPublic.ShowMessage(ex.Message );
                //MessageBox.Show(ex.Message);
                this.Close();
            }
        }
        protected List<object> myAll = new List<object>();        
    }
}
