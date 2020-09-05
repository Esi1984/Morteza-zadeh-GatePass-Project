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
	public partial class frm_SettingPackGatePlace : Form
	{

		protected List<object> myNew;
		protected List<object> myEdit;
		protected List<object> mySearch;
		protected List<object> myDelete;
		protected List<object> myView;
		protected List<object> myAll;


		public frm_SettingPackGatePlace()
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
				if ( !( v01_UC_packDetailsNewGatePlace1.CurrentPlaces.Count()>0 ) )
				{
					MessageBox.Show ( "محدوده تردد انتخاب نشده است" );
					return;
				}
				if (! (v01_UC_packDetailsNewGatePlace1.rddlTypePack.SelectedIndex > -1))
				{
					MessageBox.Show("نوع بسته مشخص نیست");
					return;
				}
				if (v01_UC_packDetailsNewGatePlace1.bdcStartDate.SelectedDate == null)
				{
					MessageBox.Show("تاریخ شروع تنظیم نیست");
					return;
				}
				if (v01_UC_packDetailsNewGatePlace1.bdcEndDate.SelectedDate == null)
				{
					MessageBox.Show("تاریخ پایان تنظیم نیست");
					return;
				}
				if (v01_UC_packDetailsNewGatePlace1.CurrentAgreeId == null && v01_UC_packDetailsNewGatePlace1.rddlTypePack.SelectedIndex < 2)
				{
					MessageBox.Show("قرار داد مشخص نشده است");
					return;
				}
				if (v01_UC_packDetailsNewGatePlace1.CurrentTravelId == null)
				{
					MessageBox.Show("محل کار تعیین نشده");
					return;
				}
				if ( string.IsNullOrEmpty (v01_UC_packDetailsNewGatePlace1.rddlShift.Text) )
				{
					MessageBox.Show( "شیفت کاری تنظیم نیست" );
					return;
				}

				if ( v01_UC_packDetailsNewGatePlace1.CurrentCarId == null && v01_UC_packDetailsNewGatePlace1.rcbHaveVehicle.Checked )
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

		private void frm_SettingPackGatePlace_Load(object sender, EventArgs e)
		{
			v01_UC_packDetailsNewGatePlace1.rtbCompanyAgree.ReadOnly=true;
			v01_UC_packDetailsNewGatePlace1.rtbTitleAgree.ReadOnly=true;
			v01_UC_packDetailsNewGatePlace1.rtbTravelLabel.ReadOnly=true;
			v01_UC_packDetailsNewGatePlace1.rtbNumberAgree.ReadOnly=true;
			v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.rtbColor.ReadOnly=true;
			v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.rtbModel.ReadOnly=true;
			v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.rddlType.Enabled=false;
			v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.rddlState.Enabled=false;
            //v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.Enabled = false;
            v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.uC_PlatesMeli1.rtbH.ReadOnly = true;
            v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.uC_PlatesMeli1.rmeb24.ReadOnly = true;
            v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.uC_PlatesMeli1.rmebG.ReadOnly = true;
            v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.uC_PlatesMeli1.rmebGGG.ReadOnly = true;
            v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.uC_PlatesSimple1.rddlTypes.Enabled = false;
            v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.Enabled = false;
            v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.uC_PlatesSimple1.rmebGGG.ReadOnly = true;

			if(v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.rddlType.Items.Count<=0)
			{
				v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.SetModelsCar();
			}
			v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.ChangeTheme(ref office2010BlackTheme1);
		}

		public void SetSettings( v01_UC_packDetailsGatePlace obj )
		{

			v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.SetModelsCar ();
			
			v01_UC_packDetailsNewGatePlace1.rddlTypePack.SelectedIndex = obj.rddlTypePack.SelectedIndex;

			v01_UC_packDetailsNewGatePlace1.rtbPlaces.Text = obj.rtbPlaces.Text.Trim ();
			v01_UC_packDetailsNewGatePlace1.CurrentPlaces = obj.CurrentPlaces;

			v01_UC_packDetailsNewGatePlace1.rtbGates.Text = obj.rtbGates.Text.Trim ();
			v01_UC_packDetailsNewGatePlace1.CurrentGates = obj.CurrentGates;

			v01_UC_packDetailsNewGatePlace1.bdcStartDate.DateTime = obj.bdcStartDate.DateTime;
			v01_UC_packDetailsNewGatePlace1.bdcEndDate.DateTime = obj.bdcEndDate.DateTime;
			v01_UC_packDetailsNewGatePlace1.rtbNumberAgree.Text = obj.rtbNumberAgree.Text.Trim();
			v01_UC_packDetailsNewGatePlace1.CurrentAgreeId = obj.CurrentAgreeId;
			v01_UC_packDetailsNewGatePlace1.rtbCompanyAgree.Text = obj.rtbCompanyAgree.Text.Trim();
			v01_UC_packDetailsNewGatePlace1.rtbTitleAgree.Text = obj.rtbTitleAgree.Text.Trim();
			v01_UC_packDetailsNewGatePlace1.rlblCountCar.Text = obj.rlblCountCar.Text.Trim();
			v01_UC_packDetailsNewGatePlace1.rddlShift.Text = obj.rddlShift.Text.Trim();

			v01_UC_packDetailsNewGatePlace1.CurrentTravelId = obj.CurrentTravelId;

			v01_UC_packDetailsNewGatePlace1.rtbTravelLabel.Text = obj.rtbTravelLabel.Text.Trim();

			v01_UC_packDetailsNewGatePlace1.tbPackDescriptions.Text = obj.tbPackDescriptions.Text.Trim();

			//v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails21.rddlType.SelectedIndex =
			v01_UC_packDetailsNewGatePlace1.rcbHaveVehicle.Checked = obj.rcbHaveVehicle.Checked;
			if (v01_UC_packDetailsNewGatePlace1.rcbHaveVehicle.Checked)
			{
				v01_UC_packDetailsNewGatePlace1.CurrentCarId = obj.CurrentCarId;
				v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.rtbModel.Text =
					obj.uC_vehicleDetails31.rtbModel.Text.Trim();
				v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.rtbColor.Text =
					obj.uC_vehicleDetails31.rtbColor.Text.Trim();

                v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex =
                    obj.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex;

				v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.CarNumber =
					obj.uC_vehicleDetails31.uC_PlatesCar1.CarNumber;

				v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.rddlState.SelectedIndex =
					obj.uC_vehicleDetails31.rddlState.SelectedIndex;
				v01_UC_packDetailsNewGatePlace1.uC_vehicleDetails31.indexTypeModel = obj.uC_vehicleDetails31.indexTypeModel;
			}
		}

		private void v01_UC_packDetailsNewGatePlace1_eventTickVehicle()
		{

		}




		

	}
}
