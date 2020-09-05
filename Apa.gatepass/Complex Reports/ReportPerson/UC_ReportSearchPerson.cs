using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.Complex_Reports.ReportPerson
{
    public partial class UC_ReportSearchPerson : UserControl
    {

        public UC_ReportSearchPerson()
        {
            InitializeComponent();
        }

        internal void clearItenms()
        {            
            uC_SelCaseAgree.ClearItems();
            uC_SelCaseVeh.ClearItems();
            uC_SelCaseWP.ClearItems();
            uC_SelCaseOff.ClearItems();
            bdcStartDate1.SelectedDate = null;
            bdcStartDate2.SelectedDate = null;
            rtbFatherName.Text = string.Empty;
            rtbName.Text = string.Empty;
            rtbRegisterCode.Text = string.Empty;
            rtbSurname.Text = string.Empty;
            rmebLicenseDriveCode.Text = string.Empty;
            rmebNationalCode.Text = string.Empty;
            rmeIdentifyCode.Text = string.Empty;
            rddlHaveForm.SelectedIndex = -1;
            rddlsex.SelectedIndex = -1;
        }

        public void limitedOffice()
        {
            uC_SelCaseOff.LimitedOffice();
        }


        public void InitialDatesCurrentMonth()
        {
            bdcStartDate1.SelectedDate = DateTime.Now.Date.AddDays(-1 *  ItemsPublic.GetDayOfMonth(DateTime.Now) +1);
            bdcStartDate2.SelectedDate = DateTime.Now.Date;
        }
    }
}
