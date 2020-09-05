using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServerClasses;

namespace aorc.gatepass.ui.vehicle
{
	public partial class UC_PlatesMeli : UserControl
	{
		public UC_PlatesMeli()
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
			foreach (char c in str.Substring(9))
			{

                if (c != ' ')
                {
                    strR += c.ToString();
                }
                else
                {
                    break;
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
					rmebGGG.Text = str.Substring(5, 3);
                    rtbH.Text = getHarf(str);
					rmebG.Text = str.Substring(str.Length - 2);					
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
			return rmeb24.Text.Trim() + " - " + rmebGGG.Text.Trim() + " "  + rtbH.Text.Trim() +" " + rmebG.Text.Trim();
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
