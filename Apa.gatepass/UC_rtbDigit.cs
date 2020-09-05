using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServerClasses;

namespace aorc.gatepass
{
	public partial class UC_rtbDigit : UserControl
	{
		public UC_rtbDigit()
		{
			InitializeComponent();
		}

		private void rtbDigit_KeyPress( object sender , KeyPressEventArgs e )
		{
			MessageBox.Show(e.KeyChar.ToString());
		}

	}
}
