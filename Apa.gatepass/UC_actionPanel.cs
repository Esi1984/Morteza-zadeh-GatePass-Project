using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;



namespace aorc.gatepass
{
    public partial class UC_actionPanel : UserControl
    {
        public UC_actionPanel()
        {
            InitializeComponent();
        }
        public  Manager objManager = new Manager();
        public delegate void DelegateStatusAction();
        public event DelegateStatusAction statusNew;
        public event DelegateStatusAction statusEdit;
        public event DelegateStatusAction statusSearch;
        public event DelegateStatusAction statusView;
        public event DelegateStatusAction statusDelete;

        private void SetDefaultItem(RadMenuItem item)
        {
            rsbAction.DefaultItem = item;
            rsbAction.ImageIndex = item.ImageIndex;
            rsbAction.Text = item.Text;
        }

        private void rmiSearch_Click(object sender, EventArgs e)
        {
            // SetDefaultItem(rmiSearch);
         //   objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toSearch);
        }

        private void rmiNew_Click(object sender, EventArgs e)
        {
            //SetDefaultItem(rmiNew );
         //  objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toNew);
        }

        private void rmiEdit_Click(object sender, EventArgs e)
        {
        //    SetDefaultItem(rmiEdit);
        //    objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toEdit);
        }

        private void rmiView_Click(object sender, EventArgs e)
        {
         //   SetDefaultItem(rmiView);
          //  objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toView);
        }

        private void rmiDelete_Click(object sender, EventArgs e)
        {
           // SetDefaultItem(rmiDelete);
        //    objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toDelete);
        }

        private void rgbAction_Click(object sender, EventArgs e)
        {

        }
    }
}
