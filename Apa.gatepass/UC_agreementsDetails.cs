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
	public partial class UC_agreementsDetails : UserControl
	{
		public UC_agreementsDetails()
		{
			InitializeComponent();
		}

		public bool? modeIsSearch
		{
			get
			{
				return null;
			}
			set
			{
				if ( value==true)
				{
					ModeIsSearch();
				}
				else if(value == false)
				{
					ModeIsNotSearch();
				}
			}
		}

		private void ModeIsSearch()
		{
			bdcEndDate2.Visible = true;
			bdcStartDate2.Visible = true;
			rlblTaEnd.Visible = true;
			rlblTaStart.Visible = true;
			rlblStartDate.Text = "تاریخ شروع از";
			rlblEndDate.Text = "تاریخ پایان از";
		}

		private void ModeIsNotSearch()
		{
			bdcEndDate2.Visible = false;
			bdcStartDate2.Visible = false;
			rlblTaEnd.Visible = false;
			rlblTaStart.Visible = false;
			rlblStartDate.Text = "تاریخ شروع";
			rlblEndDate.Text = "تاریخ پایان";
		}

		private void rmebNumber_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText(sender, e, rmebNumber.Text, null);
		}


        internal void clearItems()
        {
            throw new NotImplementedException();
        }
    }
}
