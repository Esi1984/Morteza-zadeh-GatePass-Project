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
	public partial class UC_PacksSearch : UserControl
	{
		public UC_PacksSearch()
		{
			InitializeComponent();
		}
		public delegate void DelegateStatusAction();
		public event DelegateStatusAction eventTickVehicle;
		public int? CurrentTravelId { get; set; }
		public int? CurrentOfficeId { get; set; }
		public decimal? CurrentAgreeId { get; set; }
		public decimal? CurrentCarId { get; set; }

		private void rmebNationalCode_TextChanged( object sender , EventArgs e )
		{
			if ( rmebNationalCode.Text.Trim ().Count () > 10 )
			{
				rmebNationalCode.Text = rmebNationalCode.Text.Substring ( 0 , 10 );
			}
		}


		public void SelTextBox()
		{
			rmebNationalCode.Focus();
			rmebNationalCode.SelectAll();

		}

		private void rmebNationalCode_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText(sender,e,rmebNationalCode.Text,10);
		}
	}
}
