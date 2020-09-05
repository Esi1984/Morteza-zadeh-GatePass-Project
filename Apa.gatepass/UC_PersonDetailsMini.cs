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
	public partial class UC_PersonDetailsMini : UserControl
	{
		public UC_PersonDetailsMini()
		{
			InitializeComponent ();
		}

		private void rmebNationalCode_TextChanged( object sender , EventArgs e )
		{
			if ( rmebNationalCode.Text.Trim ().Count () > 10 )
			{
				rmebNationalCode.Text = rmebNationalCode.Text.Substring ( 0 , 10 );
			}
		}

		private void rmeIdentifyCode_Enter( object sender , EventArgs e )
		{
			rmeIdentifyCode.SelectionStart = 0;
			rmeIdentifyCode.SelectionLength = rmeIdentifyCode.Text.Length;
		}

		private void rmebLicenseDriveCode_Enter( object sender , EventArgs e )
		{
			rmebLicenseDriveCode.SelectionStart = 0;
			rmebLicenseDriveCode.SelectionLength = rmebLicenseDriveCode.Text.Length;
		}
	}
}
