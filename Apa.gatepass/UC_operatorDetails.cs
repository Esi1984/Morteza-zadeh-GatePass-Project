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
    public partial class UC_operatorDetails : UserControl
    {
        public UC_operatorDetails()
        {
            InitializeComponent();
        }

        public decimal?  CurrentBaridId { get; set; }
        public int? CurrentOfficeId { get; set; }
        public int? CurrentGroupId { get; set; }

        private void rbtnBaridForm_Click(object sender, EventArgs e)
        {
            var frm = new ui.operators.frm_FindBaridInfo();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                CurrentBaridId = frm.baridIdSelected;
                rtbBaridName.Text = frm.NameSelected;
                rmebBardiUserCode.Text = frm.UserCodeSelected;
                rtbBaridJob.Text = frm.JobSelected;
            }
            frm.Close();
            frm.Dispose();
        }

        private void rbtnOffice_Click(object sender, EventArgs e)
        {
            var frm = new ui.office.frm_FindOffices();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                CurrentOfficeId = frm.IdSelected;
                rtbOfficeName.Text = frm.NameSelected;
            }
            frm.Close();
            frm.Dispose();
        }

        private void rbtnGroup_Click(object sender, EventArgs e)
        {
            var frm = new ui.operators.frm_FindGroups();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                CurrentGroupId = frm.IdSelected;
                rtbGroupName.Text = frm.NameSelected;
            }
            frm.Close();
            frm.Dispose();
        }

        private void rtbGroupName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.rtbGroupName.Text))
            {
                CurrentGroupId = null;
            }
            if (string.IsNullOrEmpty(this.rtbOfficeName.Text))
            {
                CurrentOfficeId = null;
            }
        }
    }
}
