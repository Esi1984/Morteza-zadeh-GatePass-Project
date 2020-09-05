using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.Complex_Reports.ReportOffice
{
    public partial class UC_ReportSearchOffice : UserControl
    {
        public UC_ReportSearchOffice()
        {
            InitializeComponent();
        }

        internal void clearItenms()
        {
            uC_SelCaseAgree.ClearItems();
            uC_SelCasePerson.ClearItems();
            bdcStartDate1.SelectedDate = null;
            bdcStartDate2.SelectedDate = null;
            rtbOfficeName.Text = string.Empty;
            
        }

        public void InitialDatesCurrentMonth()
        {
            bdcStartDate1.SelectedDate = DateTime.Now.Date.AddDays(-1 * ItemsPublic.GetDayOfMonth(DateTime.Now) + 1);
            bdcStartDate2.SelectedDate = DateTime.Now.Date;
        }

    }
}
