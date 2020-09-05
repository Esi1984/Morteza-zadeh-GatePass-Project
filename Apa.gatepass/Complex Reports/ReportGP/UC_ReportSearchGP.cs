using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.Complex_Reports.ReportGP
{
    public partial class UC_ReportSearchGP : UserControl
    {
        public UC_ReportSearchGP()
        {
            InitializeComponent();
        }

        internal void clearItenms()
        {            
            uC_SelCasePerson.ClearItems();
            uC_SelCaseVeh.ClearItems();
            uC_SelCaseAgree.ClearItems();
            uC_SelCaseOff.ClearItems();
            uC_SelCaseRequest.ClearItems();
            uC_SelCaseConfirm.ClearItems();
            uC_SelCasePassage.ClearItems();
            uC_SelCaseWP.ClearItems();
            bdcStartDate1.SelectedDate = null;
            bdcStartDate2.SelectedDate = null;
            rddlTypePack.SelectedIndex = -1;
            rddlPrint.SelectedIndex = -1;
            
        }
        public void InitialDatesCurrentMonth()
        {
            bdcStartDate1.SelectedDate = DateTime.Now.Date.AddDays(-1 * ItemsPublic.GetDayOfMonth(DateTime.Now) + 1);
            bdcStartDate2.SelectedDate = DateTime.Now.Date;
        }
    }
}
