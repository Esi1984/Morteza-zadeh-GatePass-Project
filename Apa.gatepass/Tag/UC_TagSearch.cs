using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.Tag
{
    public partial class UC_TagSearch : UserControl
    {
        public UC_TagSearch()
        {
            InitializeComponent();
        }

        public delegate void DelegateStatusAction();

        public event DelegateStatusAction eventGpInput;
        public event DelegateStatusAction eventTagInput;

        private void rtbGpId_TextChanged(object sender, EventArgs e)
        {
            //if (ItemsPublic.IsDigitNumber(rtbGpId.Text, 18))
            //{
            //    rtbTagId.Focus();
            //    rtbTagId.SelectAll();
            //    eventGpInput();
            //}
        }


        
        internal void clearItems()
        {
            rtbTagId.Text = "";
            rtbGpId.Text = "";
            rtbGpId.Focus();
        }

       

        private void rtbGpId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                eventGpInput();
                rtbTagId.Focus();
                rtbTagId.SelectAll();
                return;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                rtbGpId.Text = "";
            }

        }

       
        private void rtbTagId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ItemsPublic.IsDigitNumber(rtbTagId.Text.Trim(), -1) && rtbTagId.Text.Trim().Count() > 3)
                {
                    eventTagInput();
                    rtbGpId.Focus();
                    rtbGpId.SelectAll();
                }
                return;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                rtbTagId.Text = "";
            }
        }
    }
}
