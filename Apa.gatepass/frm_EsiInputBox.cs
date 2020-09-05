using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI;
using ServerClasses;
using Telerik.WinControls;

namespace aorc.gatepass
{
	public partial class frm_EsiInputBox : Form
	{

        public string esiTitle { get; set; }
        public string esiMessage { get; set; }

        public void setItems(string esiValueTitle , string esiValueMessage){
            this.Text = esiValueTitle;
            this.radGroupBox3.Text = esiValueMessage;
        }
		public frm_EsiInputBox()
		{
			try
			{
				InitializeComponent();
                
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message);
				this.Close();
			}
		}

		internal string message
		{
			get { return rtbMessage.Text.Trim().TrimEnd(); }
			set { }
		}

		public static DialogResult CreateDialog()
		{
			frm_EsiInputBox frm = new frm_EsiInputBox();
			return frm.ShowDialog();
		}

		private void cbbSave_Click(object sender, EventArgs e)
		{
			try
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				this.Close();
			}
		}

		private void cbbCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void frm_EsiInputBox_Load(object sender, EventArgs e)
		{

		}

		private void frm_EsiInputBox_Shown(object sender, EventArgs e)
		{
			rtbMessage.Focus();
		}

        private void rtbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              //  eventGpInput();
              //  rtbTagId.Focus();
              //  rtbTagId.SelectAll();

                cbbSave_Click(sender,e);
                //return;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                rtbMessage.Text = "";
            }
        }
	}
}
