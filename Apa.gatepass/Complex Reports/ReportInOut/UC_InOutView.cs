using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.Complex_Reports.ReportInOut
{
    public partial class UC_InOutView : UserControl
    {
        public UC_InOutView()
        {
            InitializeComponent();

            tempTable.Columns.Add("InOutLog_ID", typeof(decimal));
            tempTable.Columns.Add("Archive_ID", typeof(decimal));
            tempTable.Columns.Add("Gatepass_ID", typeof(decimal));
            tempTable.Columns.Add("Person_ID", typeof(decimal));
            tempTable.Columns.Add("Vehicle_ID", typeof(decimal));
            tempTable.Columns.Add("Time", typeof(DateTime));

            tempTable.Columns.Add("Gate_Id", typeof(decimal));

            tempTable.Columns.Add("FarsiDate", typeof(string));
            tempTable.Columns.Add("FarsiTime", typeof(string));
        }

        DataTable tempTable = new DataTable();

        public void Show( DataTable DT, decimal Archive_ID)
        {
            radGridViewSelected.DataSource = null;
            tempTable.Rows.Clear();
            foreach (DataRow item in DT.Rows)
            {
                if ((decimal)item["Archive_ID"] == Archive_ID)
                {
                    tempTable.Rows.Add(null, null, null, null, null, null, null
                        ,ItemsPublic.GetPersianDate((DateTime)item["Time"])
                        ,ItemsPublic.GetPersianHour((DateTime)item["Time"]));
                }
            }
            radGridViewSelected.DataSource = tempTable;
            radGridViewSelected.Refresh();

        }
    }
}
