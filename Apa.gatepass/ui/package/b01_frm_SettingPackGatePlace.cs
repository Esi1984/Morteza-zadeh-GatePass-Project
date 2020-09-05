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
	public partial class b01_frm_SettingPackGatePlace : Form
	{

		protected List<object> myNew;
		protected List<object> myEdit;
		protected List<object> mySearch;
		protected List<object> myDelete;
		protected List<object> myView;
		protected List<object> myAll;


		public b01_frm_SettingPackGatePlace()
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
				if ( !( uC_packDetailsNewGatePlace1.CurrentPlaces.Count()>0 ) )
				{
					MessageBox.Show ( "محدوده تردد انتخاب نشده است" );
					return;
				}
				if (! (uC_packDetailsNewGatePlace1.rddlTypePack.SelectedIndex > -1))
				{
					MessageBox.Show("نوع بسته مشخص نیست");
					return;
				}
				if (uC_packDetailsNewGatePlace1.bdcStartDate.SelectedDate == null)
				{
					MessageBox.Show("تاریخ شروع تنظیم نیست");
					return;
				}
				if (uC_packDetailsNewGatePlace1.bdcEndDate.SelectedDate == null)
				{
					MessageBox.Show("تاریخ پایان تنظیم نیست");
					return;
				}
				if (uC_packDetailsNewGatePlace1.CurrentAgreeId == null && uC_packDetailsNewGatePlace1.rddlTypePack.SelectedIndex < 2)
				{
					MessageBox.Show("قرار داد مشخص نشده است");
					return;
				}
				if (uC_packDetailsNewGatePlace1.CurrentTravelId == null)
				{
					MessageBox.Show("محل کار تعیین نشده");
					return;
				}
				if ( string.IsNullOrEmpty (uC_packDetailsNewGatePlace1.rddlShift.Text) )
				{
					MessageBox.Show( "شیفت کاری تنظیم نیست" );
					return;
				}

				if ( uC_packDetailsNewGatePlace1.CurrentCarId == null && uC_packDetailsNewGatePlace1.rcbHaveVehicle.Checked )
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

		private void b01_frm_SettingPackGatePlace_Load(object sender, EventArgs e)
		{
			uC_packDetailsNewGatePlace1.rtbCompanyAgree.ReadOnly=true;
			uC_packDetailsNewGatePlace1.rtbTitleAgree.ReadOnly=true;
			uC_packDetailsNewGatePlace1.rtbTravelLabel.ReadOnly=true;
			uC_packDetailsNewGatePlace1.rtbNumberAgree.ReadOnly=true;
			uC_packDetailsNewGatePlace1.uC_vehicleDetails21.rtbColor.ReadOnly=true;
			uC_packDetailsNewGatePlace1.uC_vehicleDetails21.rtbModel.ReadOnly=true;
			uC_packDetailsNewGatePlace1.uC_vehicleDetails21.rddlType.Enabled=false;
			uC_packDetailsNewGatePlace1.uC_vehicleDetails21.rddlState.Enabled=false;
			uC_packDetailsNewGatePlace1.uC_vehicleDetails21.uC_CarNumber1.rtbH.ReadOnly=true;
			uC_packDetailsNewGatePlace1.uC_vehicleDetails21.uC_CarNumber1.rmeb24.ReadOnly=true;
			uC_packDetailsNewGatePlace1.uC_vehicleDetails21.uC_CarNumber1.rmebG.ReadOnly=true;
			uC_packDetailsNewGatePlace1.uC_vehicleDetails21.uC_CarNumber1.rmebGGG.ReadOnly=true;

			if(uC_packDetailsNewGatePlace1.uC_vehicleDetails21.rddlType.Items.Count<=0)
			{
				uC_packDetailsNewGatePlace1.uC_vehicleDetails21.SetModelsCar();
			}
			uC_packDetailsNewGatePlace1.uC_vehicleDetails21.ChangeTheme(ref office2010BlackTheme1);
		}


		public void SetSettings( UC_packDetailsGatePlace obj )
		{

			uC_packDetailsNewGatePlace1.uC_vehicleDetails21.SetModelsCar ();
			
			uC_packDetailsNewGatePlace1.rddlTypePack.SelectedIndex = obj.rddlTypePack.SelectedIndex;

			uC_packDetailsNewGatePlace1.rtbPlaces.Text = obj.rtbPlaces.Text.Trim ();
			uC_packDetailsNewGatePlace1.CurrentPlaces = obj.CurrentPlaces;

			uC_packDetailsNewGatePlace1.rtbGates.Text = obj.rtbGates.Text.Trim ();
			uC_packDetailsNewGatePlace1.CurrentGates = obj.CurrentGates;

			uC_packDetailsNewGatePlace1.bdcStartDate.DateTime = obj.bdcStartDate.DateTime;
			uC_packDetailsNewGatePlace1.bdcEndDate.DateTime = obj.bdcEndDate.DateTime;
			uC_packDetailsNewGatePlace1.rtbNumberAgree.Text = obj.rtbNumberAgree.Text.Trim();
			uC_packDetailsNewGatePlace1.CurrentAgreeId = obj.CurrentAgreeId;
			uC_packDetailsNewGatePlace1.rtbCompanyAgree.Text = obj.rtbCompanyAgree.Text.Trim();
			uC_packDetailsNewGatePlace1.rtbTitleAgree.Text = obj.rtbTitleAgree.Text.Trim();
			uC_packDetailsNewGatePlace1.rlblCountCar.Text = obj.rlblCountCar.Text.Trim();
			uC_packDetailsNewGatePlace1.rddlShift.Text = obj.rddlShift.Text.Trim();

			uC_packDetailsNewGatePlace1.CurrentTravelId = obj.CurrentTravelId;

			uC_packDetailsNewGatePlace1.rtbTravelLabel.Text = obj.rtbTravelLabel.Text.Trim();

			uC_packDetailsNewGatePlace1.tbPackDescriptions.Text = obj.tbPackDescriptions.Text.Trim();

			//uC_packDetailsNewGatePlace1.uC_vehicleDetails21.rddlType.SelectedIndex =
			uC_packDetailsNewGatePlace1.rcbHaveVehicle.Checked = obj.rcbHaveVehicle.Checked;
			if (uC_packDetailsNewGatePlace1.rcbHaveVehicle.Checked)
			{
				uC_packDetailsNewGatePlace1.CurrentCarId = obj.CurrentCarId;
				uC_packDetailsNewGatePlace1.uC_vehicleDetails21.rtbModel.Text =
					obj.uC_vehicleDetails21.rtbModel.Text.Trim();
				uC_packDetailsNewGatePlace1.uC_vehicleDetails21.rtbColor.Text =
					obj.uC_vehicleDetails21.rtbColor.Text.Trim();
				uC_packDetailsNewGatePlace1.uC_vehicleDetails21.uC_CarNumber1.CarNumber =
					obj.uC_vehicleDetails21.uC_CarNumber1.CarNumber;
				uC_packDetailsNewGatePlace1.uC_vehicleDetails21.rddlState.SelectedIndex =
					obj.uC_vehicleDetails21.rddlState.SelectedIndex;
				uC_packDetailsNewGatePlace1.uC_vehicleDetails21.indexTypeModel = obj.uC_vehicleDetails21.indexTypeModel;
			}
		}

		private void uC_packDetailsNewGatePlace1_eventTickVehicle()
		{

		}

		

	}
}
