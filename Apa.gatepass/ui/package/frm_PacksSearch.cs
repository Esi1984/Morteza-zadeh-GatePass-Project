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
	public partial class frm_PacksSearch : Form
	{
		public frm_PacksSearch()
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
		public string Person_NationalCode { get;set;}
		private void cbbSave_Click(object sender, EventArgs e)
		{
			try
			{
				Person_NationalCode = uC_PacksSearch1.rmebNationalCode.Text.Trim();
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message);
			}
		}

		private void cbbCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void frm_PacksSearch_Load(object sender, EventArgs e)
		{
			try
			{
			//	GroupingControls((Control) this);
			//	objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toNew);
				
			}
			finally
			{

			}
		}

		private void frm_PacksSearch_Shown( object sender , EventArgs e )
		{
			//rtbSearchPerson.SelectionStart = 0;
			//rtbSearchPerson.SelectionLength = rtbSearchPerson.Text.Length;
			uC_PacksSearch1.SelTextBox ();
		}




	}
}
