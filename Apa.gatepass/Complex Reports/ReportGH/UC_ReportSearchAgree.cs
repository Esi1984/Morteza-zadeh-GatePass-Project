using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.Complex_Reports.ReportGH
{
    public partial class UC_ReportSearchAgree : UserControl
    {
        public UC_ReportSearchAgree()
        {
            InitializeComponent();
        }

        internal void clearItenms()
        {
            uC_SelCasePerson.ClearItems();
            uC_SelCaseVeh.ClearItems();            
            uC_SelCaseOff.ClearItems();
            bdcStartDate1.SelectedDate = null;
            bdcStartDate2.SelectedDate = null;
           rtbAgentName.Text = string.Empty;
           rtbCompany.Text = string.Empty;
           rtbManagerName.Text = string.Empty;
           rmebNumber.Text = string.Empty;
           rddlTypeAgree.SelectedIndex = -1;
            

        }
        public void InitialDatesCurrentMonth()
        {
            bdcStartDate1.SelectedDate = DateTime.Now.Date.AddDays(-1 * ItemsPublic.GetDayOfMonth(DateTime.Now) + 1);
            bdcStartDate2.SelectedDate = DateTime.Now.Date;
        }
                
    }
}
