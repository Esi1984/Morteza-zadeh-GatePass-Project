using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.ui.blacklist
{
    public partial class frm_blacklists : aorc.gatepass.mainForm 
    {
        public frm_blacklists()
        {
            InitializeComponent();
        }

        private void frm_blacklists_Load(object sender, EventArgs e)
        {
            GroupingControls((Control)this);
            GroupingRadObjects(findRadItems());
           // cbbView_Click(sender, e);
        }

    }
}
