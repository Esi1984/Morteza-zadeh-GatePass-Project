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
	public partial class UC_PersonDetailsMini2 : UserControl
	{
		public UC_PersonDetailsMini2()
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

		private void rmebNationalCode_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText(sender,e,rmebNationalCode.Text,10);
		}

		private void rtbRegisterCode_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText(sender,e,rtbRegisterCode.Text,10);
		}

		private void rmeIdentifyCode_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText(sender,e,rmeIdentifyCode.Text,10);
		}

		private void rmebLicenseDriveCode_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText(sender,e,rmebLicenseDriveCode.Text,10);
		}
	}
}
