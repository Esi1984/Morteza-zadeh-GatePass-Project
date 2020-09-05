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

namespace aorc.gatepass.Gp2.Pack
{
	public partial class frm_SecureUpdateGp2 : Form
	{

		public bool haveForm {get;set; }

		public DateTime? dtEndSecure { get; set; }

		public frm_SecureUpdateGp2()
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

		private void cbbSave_Click(object sender, EventArgs e)
		{
			try
			{
				haveForm = uC_personSecure1.rddlHaveForm.SelectedIndex == 0;
				dtEndSecure = 	 ( uC_personSecure1.bdcEndSecureDate.SelectedDate != null )
			                                      	? uC_personSecure1.bdcEndSecureDate.SelectedDate.Value
			                                      	: ( DateTime? ) null;
				if ( haveForm && dtEndSecure==null )
				{
					ItemsPublic.ShowMessage("لطفا تاریخ پایان اعتبار را مشخص نمائید");
					return;
				}

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

        public void groupMode()
        {
            uC_personSecure1.groupMode();
            this.Height = 173;
        }

		private void frm_SecureUpdateGp2_Load(object sender, EventArgs e)
		{
			
		}

		public void showProperties( string name , string surname , string sex , string nationalCode,DateTime? dtEndSecure,bool haveForm )
		{
			if ( dtEndSecure!=null) uC_personSecure1.bdcEndSecureDate.DateTime = dtEndSecure;
			else uC_personSecure1.bdcEndSecureDate.DateTime = (DateTime?)null;

			uC_personSecure1.rddlHaveForm.SelectedIndex = haveForm?0:1;

				//( ( bool ) uC_personSecure1.SelectedRows [0].Cells ["Person_HaveForm"].Value ) ? 0 : 1;

		 	uC_personSecure1.rtbName.Text = name.Trim();
			uC_personSecure1.rtbSurname.Text = surname.Trim ();
			uC_personSecure1.TcoSex.Text = sex.Trim ();
			uC_personSecure1.rmebNationalCode.Text = nationalCode.Trim ();
		 }

	}
}
