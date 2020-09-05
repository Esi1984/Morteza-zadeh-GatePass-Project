using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.Complex_Reports.Uc_Mini
{
    public partial class UC_SelCase : UserControl
    {

        private clsReportCase objCase = new clsReportCase();

        ItemsPublic.MyEnumReportSatet CurrentState = ItemsPublic.MyEnumReportSatet.none;

        public int FindState
        {
            get
            {
                return (int)CurrentState;
            }
            set
            {
                CurrentState = (ItemsPublic.MyEnumReportSatet)value;
                switch (CurrentState)
                {
                    case ItemsPublic.MyEnumReportSatet.none:
                       if(!ManualBtnLabel) rbtSearch.Text = "نا مشخص";
                        break;
                    case ItemsPublic.MyEnumReportSatet.person:
                        if (!ManualBtnLabel) rbtSearch.Text = "انتخاب شخص";
                        break;
                    case ItemsPublic.MyEnumReportSatet.agreement:
                        if (!ManualBtnLabel) rbtSearch.Text = "انتخاب قرارداد";
                        break;
                    case ItemsPublic.MyEnumReportSatet.office:
                        if (!ManualBtnLabel) rbtSearch.Text = "انتخاب اداره";
                        break;
                    case ItemsPublic.MyEnumReportSatet.workPlace:
                        if (!ManualBtnLabel) rbtSearch.Text = "انتخاب  محل کار";
                        break;
                    case ItemsPublic.MyEnumReportSatet.operators:
                        if (!ManualBtnLabel) rbtSearch.Text = "انتخاب کاربر";
                        break;
                    case ItemsPublic.MyEnumReportSatet.vehicle:
                        if (!ManualBtnLabel) rbtSearch.Text = "انتخاب خودرو";
                        break;
                    default:
                        throw new Exception("وضعیت ورودی جهت تنظیم وضعیت کنترل انتخاب، قابل تشخیص نمی باشد");
                }
            }
        }

        public UC_SelCase()
        {
            InitializeComponent();
        }

        private void rbtSearch_Click(object sender, EventArgs e)
        {
            //if (objCase.SelectedCase.limitedOffice==false)
            try
            {
                switch (CurrentState)
                {
                    case ItemsPublic.MyEnumReportSatet.none:
                        break;
                    case ItemsPublic.MyEnumReportSatet.person:
                        searchPerson();
                        break;
                    case ItemsPublic.MyEnumReportSatet.agreement:
                        searchAgreement();
                        break;
                    case ItemsPublic.MyEnumReportSatet.office:
                        searchOffice();
                        break;
                    case ItemsPublic.MyEnumReportSatet.workPlace:
                        searchWorkPlace();
                        break;
                    case ItemsPublic.MyEnumReportSatet.operators:
                        searchOper();
                        break;
                    case ItemsPublic.MyEnumReportSatet.vehicle:
                        searchVehicle();
                        break;
                    default:
                        throw new Exception("وضعیت جاری جهت جستجوی کنترل انتخاب، قابل تشخیص نمی باشد");
                }
            }catch  (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
            }
        }

        private void searchPerson()
        {
            aorc.gatepass.Complex_Reports.ReportPerson.frm_SelectOnePersons frmSelPerson
                = new aorc.gatepass.Complex_Reports.ReportPerson.frm_SelectOnePersons();
            frmSelPerson.ShowDialog();
            if (frmSelPerson.DialogResult == DialogResult.OK)
            {
                objCase = frmSelPerson.objPerson;
                rtbLabel.Text = objCase.SelectedCase.Label;
            }
        }

        private void searchAgreement()
        {
            aorc.gatepass.Complex_Reports.ReportGH.frm_SelectOneAgree frmSelAgree
                = new aorc.gatepass.Complex_Reports.ReportGH.frm_SelectOneAgree();
            frmSelAgree.ShowDialog();
            if (frmSelAgree.DialogResult == DialogResult.OK)
            {
                objCase = frmSelAgree.objAgree;
                rtbLabel.Text = objCase.SelectedCase.Label;
            }
        }
        private void searchOffice()
        {
            aorc.gatepass.Complex_Reports.ReportOffice.frm_SelectOneOffice frmSelOffice 
                = new aorc.gatepass.Complex_Reports.ReportOffice.frm_SelectOneOffice();
            frmSelOffice.ShowDialog();
            if (frmSelOffice.DialogResult == DialogResult.OK)
            {
                objCase = frmSelOffice.objOffice;
                rtbLabel.Text = objCase.SelectedCase.Label;
            }
        }
        private void searchWorkPlace()
        {
            aorc.gatepass.Complex_Reports.ReportWorkPlace.frm_SelectOneWorkPlace frmSelWorkPlace
                = new aorc.gatepass.Complex_Reports.ReportWorkPlace.frm_SelectOneWorkPlace();
            frmSelWorkPlace.ShowDialog();
            if (frmSelWorkPlace.DialogResult == DialogResult.OK)
            {
                objCase = frmSelWorkPlace.objWorkPlace;
                rtbLabel.Text = objCase.SelectedCase.Label;
            }
        }
        private void searchVehicle()
        {
            aorc.gatepass.Complex_Reports.ReportVeh.frm_SelectOneVehicleR frmSelVel
                = new aorc.gatepass.Complex_Reports.ReportVeh.frm_SelectOneVehicleR();
            frmSelVel.ShowDialog();
            if (frmSelVel.DialogResult == DialogResult.OK)
            {
                objCase = frmSelVel.objVehicle;
                rtbLabel.Text = objCase.SelectedCase.Label;
            }
        }
        private void searchOper()
        {
            aorc.gatepass.Complex_Reports.ReportOper.frm_SelectOneOper frmSelOper
                           = new aorc.gatepass.Complex_Reports.ReportOper.frm_SelectOneOper();
            frmSelOper.ShowDialog();
            if (frmSelOper.DialogResult == DialogResult.OK)
            {
                objCase = frmSelOper.objOper;
                rtbLabel.Text = objCase.SelectedCase.Label;
            }
        }
        public void ClearItems()
        {
            if (objCase.SelectedCase.limitedOffice != true)
            {
                objCase.CurrentCase = null;
                rtbLabel.Text = objCase.SelectedCase.Label;
            }
        }
        public void LimitedOffice()
        {
            objCase.SelectedCase.limitedOffice = true;
            rbtSearch.Enabled = false;
            objCase.SelectedCase.ID = ItemsPublic.MyOfficeId;
            objCase.SelectedCase.Fname = ItemsPublic.MyOfficeName;
            rtbLabel.Text = objCase.SelectedCase.Label;

           // rtbLabel.Text = objCase.SelectedCase.Label;
        }
        public decimal? CaseId()
        {
            return objCase.SelectedCase.ID;
        }
        private bool ManualBtnLabel = false;
        public string CaseLabel
        {
           get
            {
                return rbtSearch.Text;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value == "none")
                {
                    ManualBtnLabel = false;
                    rbtSearch.Text = "none";
                }
                else
                {
                    ManualBtnLabel = true;
                    rbtSearch.Text = value;
                }
                
            }
            
        }
    }
}
