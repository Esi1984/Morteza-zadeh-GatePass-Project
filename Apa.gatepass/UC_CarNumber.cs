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
	public partial class UC_CarNumber : UserControl
	{
		public UC_CarNumber()
		{
			InitializeComponent();
		}

		public string CarNumber
		{
			get { return GetNumber(); }
			set { SetNumber(value); }
		}

		public string CarNumberTags
		{
			get { return GetTags(); }
			set { SetTags(value); }
		}

		private void SetTags(string newTag)
		{
			rtbH.Tag = newTag;
			rmeb24.Tag = newTag;
			rmebG.Tag = newTag;
			rmebGGG.Tag = newTag;
		}

		private string GetTags()
		{
			return rtbH.Tag.ToString();
		}

		private string getHarf(string str)
		{
			string strR = string.Empty;
			foreach (char c in str.Substring(5))
			{
				try
				{
					var result = int.Parse(c.ToString());
					break;
				}
				catch
				{
					strR += c.ToString();
				}
			}
			if ( strR.Count ()!=1 && strR!="الف" )
{
	throw new Exception();
}
			return strR;
		}

		private bool SetNumber(string str)
		{
			try
			{
				if (!string.IsNullOrEmpty(str))
				{
					str = str.Trim();

					rmeb24.Text = str.Substring(0, 2);
					rmebG.Text = str.Substring(3, 2);
					rmebGGG.Text = str.Substring(str.Length - 3);
					rtbH.Text = getHarf(str);
				}
				else
				{
					rmeb24.Text = string.Empty;
					rmebG.Text = string.Empty;
					rmebGGG.Text = string.Empty;
					rtbH.Text = string.Empty;

				}
				return true;
			}
			catch
			{
				//ItemsPublic.Exeptor("خطا در تبدیل قالب پلاک خودرو");
				return false;
			}
		}

		private string GetNumber()
		{
			if (rmeb24.Text.Trim().Count() != 2 || rmebG.Text.Trim().Count() != 2 || rmebGGG.Text.Trim().Count() != 3)
			{
				//	ItemsPublic.Exeptor("خطا در قالب ورودی پلاک خودرو");
				return null;
			}
			return rmeb24.Text.Trim() + "-" + rmebG.Text.Trim() + rtbH.Text.Trim() + rmebGGG.Text.Trim();
		}

		private void rmebGGG_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText(sender, e, rmebGGG.Text,3);
		}

		private void rmebG_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText ( sender , e , rmebG.Text,2 );
		}

		private void rmeb24_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText ( sender , e , rmeb24.Text,2 );
		}


		internal void ChangeTheme( ref Telerik.WinControls.Themes.Office2010BlackTheme NewTheme )
		{
rmeb24.ThemeName = NewTheme.ThemeName;
rmebG.ThemeName = NewTheme.ThemeName;
rmebGGG.ThemeName = NewTheme.ThemeName;
rtbH.ThemeName = NewTheme.ThemeName;
		}
	}
}
