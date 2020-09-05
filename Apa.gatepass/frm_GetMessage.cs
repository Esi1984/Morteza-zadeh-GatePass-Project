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
	public partial class frm_GetMessage : Form
	{
		public frm_GetMessage()
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
			get { return rtbMessage.Text.Trim(); }
			set { }
		}

		public static DialogResult CreateDialog()
		{
			frm_GetMessage frm = new frm_GetMessage();
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

		private void frm_GetMessage_Load(object sender, EventArgs e)
		{

		}

		private void frm_GetMessage_Shown(object sender, EventArgs e)
		{
			rtbMessage.Focus();
		}
	}
}
