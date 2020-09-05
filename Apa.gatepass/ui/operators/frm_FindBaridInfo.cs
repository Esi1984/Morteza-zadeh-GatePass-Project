using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.ui.operators
{
    public partial class frm_FindBaridInfo : TinyForm
    {
        public frm_FindBaridInfo()
        {
            InitializeComponent();
        }
        private void frm_BaridForm_Load(object sender, EventArgs e)
        {
            unVisibleCbbEmpty();
            myColSearchName = "BaridName";
            mySource = ItemsPublic.AllUserBarid;

            if (mySource == null) 
            { 
                      ItemsPublic.Exeptor("اطلاعاتی از اتوماسیون دریافت نشده");
            }

            MainRadGridView.DataSource = mySource;
        }

        private void frm_FindBaridInfo_eventSaveTiny()
        {
            baridIdSelected = (decimal)radGridViewBaridInfo.CurrentRow.Cells["Operator_BaridId"].Value;
            NameSelected = radGridViewBaridInfo.CurrentRow.Cells["BaridName"].Value.ToString();
            JobSelected = radGridViewBaridInfo.CurrentRow.Cells["BaridJob"].Value.ToString();
            UserCodeSelected = radGridViewBaridInfo.CurrentRow.Cells["BaridUserCode"].Value.ToString();
        }

        private void radGridViewBaridInfo_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            cbbSave_Click(sender, e);
        }
    }
}
