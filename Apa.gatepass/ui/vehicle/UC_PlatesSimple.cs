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
	public partial class UC_PlatesSimple : UserControl
	{
		public UC_PlatesSimple()
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
		
			rmebGGG.Tag = newTag;
            rddlTypes.Tag = newTag;
		}

		private string GetTags()
		{
            return rmebGGG.Tag.ToString();
		}

		private int getText(string str)
		{
			string strR = string.Empty;
			foreach (char c in str)
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
            foreach (var item in rddlTypes.Items)
            {
                if(item.Text == strR )
                {
                    return item.RowIndex;
                }
            }

			return -1;
		}
        private string getNum(string str)
        {
            string strR = string.Empty;
            int index = 0;
            for (index = 0; index < str.Length;index++ )
            {
                if (str[index] != '-')
                {
                    continue;
                }
                    break;              
            }          
            return str.Substring(index + 2);
        }

		private bool SetNumber(string str)
		{
			try
			{
				if (!string.IsNullOrEmpty(str))
				{
					str = str.Trim();
                    rddlTypes.SelectedIndex = getText(str);
                    rmebGGG.Text = getNum(str);
				}
				else
				{
					rmebGGG.Text = string.Empty;
                    rddlTypes.SelectedIndex = -1;
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
			if (rddlTypes.SelectedIndex == -1 || rmebGGG.Text.Trim().Count() < 4 )
			{
				//	ItemsPublic.Exeptor("خطا در قالب ورودی پلاک خودرو");
				return null;
			}
            return rddlTypes.Text + " - "  + rmebGGG.Text.Trim();
		}

		private void rmebGGG_KeyDown( object sender , KeyEventArgs e )
		{
			// ItemsPublic.checkText(sender, e, rmebGGG.Text,5);
		}

		internal void ChangeTheme( ref Telerik.WinControls.Themes.Office2010BlackTheme NewTheme )
		{
                rmebGGG.ThemeName = NewTheme.ThemeName;
                rddlTypes.ThemeName = NewTheme.ThemeName;
		}
	}
}
