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
	public partial class UC_PlatesCar : UserControl
	{
		public UC_PlatesCar()
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
            
            uC_PlatesMeli1.CarNumberTags = newTag;
            uC_PlatesSimple1.CarNumberTags = newTag;
            //switch (rddlTypePlate.SelectedIndex)
            //{
            //    case 0:
                    
            //        break;
            //    case 1:
                    
            //        break;
            //}
		}

		private string GetTags()
		{
            return uC_PlatesMeli1.CarNumberTags;            
		}

		private void SetNumber(string str)
		{
            switch (rddlTypePlate.SelectedIndex)
            {
                case 0:
                    uC_PlatesMeli1.CarNumber = str;
                    break;
                case 1:
                    uC_PlatesSimple1.CarNumber = str;
                    break;
            }			
		}

		private string GetNumber()
		{
            switch (rddlTypePlate.SelectedIndex)
            {
                case 0:
                    return uC_PlatesMeli1.CarNumber;
                case 1:
                 return   uC_PlatesSimple1.CarNumber;
            }
            return string.Empty;
		}
		
		internal void ChangeTheme( ref Telerik.WinControls.Themes.Office2010BlackTheme NewTheme )
		{
            rddlTypePlate.ThemeName = NewTheme.ThemeName;
            uC_PlatesMeli1.ChangeTheme(ref NewTheme);
            uC_PlatesSimple1.ChangeTheme(ref NewTheme);
		}

        private void rddlTypePlate_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (rddlTypePlate.SelectedIndex)
            {
                case 0:
                    uC_PlatesMeli1.Visible = true;
                    uC_PlatesSimple1.Visible = false;
                    break;
                case 1:
                    uC_PlatesMeli1.Visible = false;
                    uC_PlatesSimple1.Visible = true;
                    break;
                case -1:
                    uC_PlatesMeli1.Visible = false;
                    uC_PlatesSimple1.Visible = false;
                    break;
            }
        }

        private void UC_PlatesCar_Load(object sender, EventArgs e)
        {
            rddlTypePlate_SelectedIndexChanged(null, null);
        }

	}
}
