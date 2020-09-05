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
	public partial class UC_personSecure : UserControl
	{
		public UC_personSecure()
		{
			InitializeComponent();
		}

		private void rddlHaveForm_SelectedIndexChanged( object sender , Telerik.WinControls.UI.Data.PositionChangedEventArgs e )
		{
			if(rddlHaveForm.SelectedIndex==0)
			{
				bdcEndSecureDate.Enabled = true;
			}else
			{
				bdcEndSecureDate.Enabled = false;
			}
		}

        public void groupMode()
        {
            radGroupBox1.Visible = false;
            rgbPersonDetails.Text = "وضعیت فرم حفاظتی افراد انتخابی";
        }
	}
}
