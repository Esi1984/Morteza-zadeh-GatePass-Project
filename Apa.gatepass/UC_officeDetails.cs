using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass
{
    public partial class UC_officeDetails : UserControl
    {
        public UC_officeDetails()
        {
            InitializeComponent();
        }
        public int? newParentId = null;
        private void rtbOfficeParent_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.rtbOfficeParent.Text))
            {
                newParentId=null;
            }
        }

        private void rbtnOfficeParent_Click(object sender, EventArgs e)
        {
            aorc.gatepass.ui.office.frm_FindOffices frm = new gatepass.ui.office.frm_FindOffices();
            frm.ShowDialog();
            //frm.DialogResult
            if (frm.DialogResult == DialogResult.OK)
            {
                newParentId = frm.IdSelected;
                rtbOfficeParent.Text = frm.NameSelected;
            }
            frm.Close();
            frm.Dispose();
        }



        internal void clearItems()
        {
            throw new NotImplementedException();
        }
    }
}
