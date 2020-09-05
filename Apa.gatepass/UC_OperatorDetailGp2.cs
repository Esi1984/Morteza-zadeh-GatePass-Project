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
    public partial class UC_OperatorDetailGp2 : UserControl
    {
        public UC_OperatorDetailGp2()
        {
            InitializeComponent();
        }

        public decimal?  CurrentBaridId { get; set; }
        public int? CurrentOfficeId { get; set; }
        //public int? CurrentGroupId { get; set; }
        public List<int> CurrentGroups { get; set; }

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
            var frm = new ui.operators.frm_SelectGroups();
            frm.SetInfo(CurrentGroups);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                rtbGroups.Text = "";
                CurrentGroups = new List<int>();
                foreach (var obj in frm.radGridViewSelected.Rows)
                {
                    //	string ss = obj.Cells["Gate_Id"].Value.ToString().Trim();
                    //int ii = int.Parse(obj.Cells["Gate_Id"].Value.ToString().Trim());
                    CurrentGroups.Add(int.Parse(obj.Cells["Group_ID"].Value.ToString().Trim()));
                    rtbGroups.Text += obj.Cells["Group_Name"].Value.ToString().Trim() + "\r\n";
                }
            }
            frm.Close();
            frm.Dispose();
        }

        private void rtbGroups_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(rtbGroups.Text.Trim()))
            {
                CurrentGroups = new List<int>();
            }
        }

    }
}
