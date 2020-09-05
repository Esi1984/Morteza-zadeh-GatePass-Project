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
    public partial class UC_travelareaDetails : UserControl
    {
        public UC_travelareaDetails()
        {
            InitializeComponent();
        }
        public int? CurrentParentId = null;
        private void rbtnParent_Click(object sender, EventArgs e)
        {
            var frm = new ui.travelarea.frm_ParentTArea();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                CurrentParentId = frm.IdSelected;
                rtbParent.Text = frm.NameSelected;
            }
            //eventRightsToGrid();
            frm.Close();
            frm.Dispose();
        }

        private void rtbParent_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.rtbParent.Text))
            {
                CurrentParentId = null;
            }
        }
    }
}
