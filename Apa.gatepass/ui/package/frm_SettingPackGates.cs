using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI;
using ServerClasses;
using Telerik.WinControls;

namespace aorc.gatepass.ui.package
{
	public partial class frm_SettingPackGates : Form
	{

		protected List<object> myNew;
		protected List<object> myEdit;
		protected List<object> mySearch;
		protected List<object> myDelete;
		protected List<object> myView;
		protected List<object> myAll;


		public frm_SettingPackGates()
		{
			try
			{
				InitializeComponent();
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message);
				this.Close();
			}
		}
		private Manager objManager = new Manager();
		private void cbbSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (! (uC_packDetailsForNewGates1.rddlTypePack.SelectedIndex > -1))
				{
					MessageBox.Show("نوع بسته مشخص نیست");
					return;
				}
				if (uC_packDetailsForNewGates1.bdcStartDate.SelectedDate == null)
				{
					MessageBox.Show("تاریخ شروع تنظیم نیست");
					return;
				}
				if (uC_packDetailsForNewGates1.bdcEndDate.SelectedDate == null)
				{
					MessageBox.Show("تاریخ پایان تنظیم نیست");
					return;
				}
				if (uC_packDetailsForNewGates1.CurrentAgreeId == null && uC_packDetailsForNewGates1.rddlTypePack.SelectedIndex < 2)
				{
					MessageBox.Show("قرار داد مشخص نشده است");
					return;
				}
				if (uC_packDetailsForNewGates1.CurrentTravelId == null)
				{
					MessageBox.Show("محدوده تردد تعیین نشده");
					return;
				}
				if ( string.IsNullOrEmpty (uC_packDetailsForNewGates1.rddlShift.Text) )
				{
					MessageBox.Show( "شیفت کاری تنظیم نیست" );
					return;
				}

				if ( uC_packDetailsForNewGates1.CurrentCarId == null && uC_packDetailsForNewGates1.rcbHaveVehicle.Checked )
				{
					MessageBox.Show ( "خودرویی انتخاب نشده است" );
					return;
				}

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				this.Close();
			}
		}

		private void cbbCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void frm_SettingPackGates_Load(object sender, EventArgs e)
		{
			uC_packDetailsForNewGates1.rtbCompanyAgree.ReadOnly=true;
			uC_packDetailsForNewGates1.rtbTitleAgree.ReadOnly=true;
			uC_packDetailsForNewGates1.rtbTravelLabel.ReadOnly=true;
			uC_packDetailsForNewGates1.rtbNumberAgree.ReadOnly=true;
			uC_packDetailsForNewGates1.uC_vehicleDetails21.rtbColor.ReadOnly=true;
			uC_packDetailsForNewGates1.uC_vehicleDetails21.rtbModel.ReadOnly=true;
			uC_packDetailsForNewGates1.uC_vehicleDetails21.rddlType.Enabled=false;
			uC_packDetailsForNewGates1.uC_vehicleDetails21.rddlState.Enabled=false;
			uC_packDetailsForNewGates1.uC_vehicleDetails21.uC_CarNumber1.rtbH.ReadOnly=true;
			uC_packDetailsForNewGates1.uC_vehicleDetails21.uC_CarNumber1.rmeb24.ReadOnly=true;
			uC_packDetailsForNewGates1.uC_vehicleDetails21.uC_CarNumber1.rmebG.ReadOnly=true;
			uC_packDetailsForNewGates1.uC_vehicleDetails21.uC_CarNumber1.rmebGGG.ReadOnly=true;

			if(uC_packDetailsForNewGates1.uC_vehicleDetails21.rddlType.Items.Count<=0)
			{
				uC_packDetailsForNewGates1.uC_vehicleDetails21.SetModelsCar();
			}
			uC_packDetailsForNewGates1.uC_vehicleDetails21.ChangeTheme(ref office2010BlackTheme1);
		}

		private void uC_packDetailsForNewGates1_eventTickVehicle()
		{

		}


		public void SetSettings( UC_packDetailsGates obj )
		{

			uC_packDetailsForNewGates1.uC_vehicleDetails21.SetModelsCar ();
			

			uC_packDetailsForNewGates1.rddlTypePack.SelectedIndex = obj.rddlTypePack.SelectedIndex;

			uC_packDetailsForNewGates1.rtbGates.Text = obj.rtbGates.Text.Trim ();
			uC_packDetailsForNewGates1.CurrentGates = obj.CurrentGates;

			uC_packDetailsForNewGates1.bdcStartDate.DateTime = obj.bdcStartDate.DateTime;
			uC_packDetailsForNewGates1.bdcEndDate.DateTime = obj.bdcEndDate.DateTime;
			uC_packDetailsForNewGates1.rtbNumberAgree.Text = obj.rtbNumberAgree.Text.Trim();
			uC_packDetailsForNewGates1.CurrentAgreeId = obj.CurrentAgreeId;
			uC_packDetailsForNewGates1.rtbCompanyAgree.Text = obj.rtbCompanyAgree.Text.Trim();
			uC_packDetailsForNewGates1.rtbTitleAgree.Text = obj.rtbTitleAgree.Text.Trim();
			uC_packDetailsForNewGates1.rlblCountCar.Text = obj.rlblCountCar.Text.Trim();
			uC_packDetailsForNewGates1.rddlShift.Text = obj.rddlShift.Text.Trim();

			uC_packDetailsForNewGates1.CurrentTravelId = obj.CurrentTravelId;

			uC_packDetailsForNewGates1.rtbTravelLabel.Text = obj.rtbTravelLabel.Text.Trim();

			uC_packDetailsForNewGates1.tbPackDescriptions.Text = obj.tbPackDescriptions.Text.Trim();

			//uC_packDetailsForNewGates1.uC_vehicleDetails21.rddlType.SelectedIndex =
			uC_packDetailsForNewGates1.rcbHaveVehicle.Checked = obj.rcbHaveVehicle.Checked;
			if (uC_packDetailsForNewGates1.rcbHaveVehicle.Checked)
			{
				uC_packDetailsForNewGates1.CurrentCarId = obj.CurrentCarId;
				uC_packDetailsForNewGates1.uC_vehicleDetails21.rtbModel.Text =
					obj.uC_vehicleDetails21.rtbModel.Text.Trim();
				uC_packDetailsForNewGates1.uC_vehicleDetails21.rtbColor.Text =
					obj.uC_vehicleDetails21.rtbColor.Text.Trim();
				uC_packDetailsForNewGates1.uC_vehicleDetails21.uC_CarNumber1.CarNumber =
					obj.uC_vehicleDetails21.uC_CarNumber1.CarNumber;
				uC_packDetailsForNewGates1.uC_vehicleDetails21.rddlState.SelectedIndex =
					obj.uC_vehicleDetails21.rddlState.SelectedIndex;
				uC_packDetailsForNewGates1.uC_vehicleDetails21.indexTypeModel = obj.uC_vehicleDetails21.indexTypeModel;
			}
		}

	}
}
