using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.Complex_Reports.ReportVeh
{
    public partial class UC_ReportSearchVehicle : UserControl
    {
        public UC_ReportSearchVehicle()
        {
            InitializeComponent();
        }

        internal void clearItenms()
        {
            uC_SelCaseOff.ClearItems();
            uC_SelCasePerson.ClearItems();
            uC_SelCaseAgree.ClearItems();
            bdcStartDate1.SelectedDate = null;
            bdcStartDate2.SelectedDate = null;
            uC_vehicleDetailsSearch1.clearItems();
        }

        public void InitialDatesCurrentMonth()
        {
            bdcStartDate1.SelectedDate = DateTime.Now.Date.AddDays(-1 * ItemsPublic.GetDayOfMonth(DateTime.Now) + 1);
            bdcStartDate2.SelectedDate = DateTime.Now.Date;
        }


    }
}
