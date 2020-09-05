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

namespace aorc.gatepass.ui.package
{
	public partial class frm_3Search : Form
	{
		public DataTable DTSearch {get { return uC_SearchGp1.Result; }
			set { }
		}
		
		public frm_3Search()
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
		private Manager objManager = new Manager();
		
		private void frm_3Search_Load(object sender, EventArgs e)
		{
			
		}

		private void frm_3Search_Shown( object sender , EventArgs e )
		{
			uC_SearchGp1.inFocus();
		}

		private void uC_SearchGp1_eventEndSearch()
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		
	}
}
