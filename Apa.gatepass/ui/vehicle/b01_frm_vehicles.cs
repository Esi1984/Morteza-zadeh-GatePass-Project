using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServerClasses;

namespace aorc.gatepass.ui.vehicle
{
	public partial class b01_frm_vehicles : aorc.gatepass.mainForm
	{
		public b01_frm_vehicles()
		{
			InitializeComponent();
		}



		private void b01_frm_vehicles_Load(object sender, EventArgs e)
		{
			setAllMouseMenus ();
			GroupingControls((Control) this);
			GroupingRadObjects(findRadItems());
			uC_vehicleDetails21.SetModelsCar();
			cbbView_Click(sender, e);
			
		}

		

		private void ShowPropertiesItems()
		{
			uC_vehicleDetails21.rtbColor.Text = MainRadGridView.CurrentRow.Cells["vehicle_Color"].Value.ToString();
			uC_vehicleDetails21.rtbModel.Text = MainRadGridView.CurrentRow.Cells["Vehicle_Model"].Value.ToString();
			uC_vehicleDetails21.uC_CarNumber1.CarNumber = MainRadGridView.CurrentRow.Cells ["Vehicle_number"].Value.ToString ();
			uC_vehicleDetails21.rddlState.SelectedIndex =
				((bool) MainRadGridView.CurrentRow.Cells["Vehicle_IsCompany"].Value) ? 0 : 1;

			uC_vehicleDetails21.indexTypeModel = (int) MainRadGridView.CurrentRow.Cells["VehicleType_ID"].Value;
		}

		private void radGridViewTypeVehicle_SelectionChanged(object sender, EventArgs e)
		{
			SetProperties(ShowPropertiesItems);
		}

		private void b01_frm_vehicles_eventSaveToDelete()
		{
			//result = objManager.vei(int.Parse(MainRadGridView.CurrentRow.Cells["VehicleType_ID"].Value.ToString()), true, string.Empty);
		}

		private void b01_frm_vehicles_eventSaveToEdit()
		{
			//    decimal? a0 = (decimal?)MainRadGridView.CurrentRow.Cells["Vehicle_ID"].Value;
			//string a1	=	uC_vehicleDetails1.rtbNumber.Text;
			//    a1=	 null;
			//    a1=	uC_vehicleDetails1.rtbColor.Text;
			//    a1=	uC_vehicleDetails1.rtbModel.Text;
			//a0	=	  (int?)Models.ResultTable.Rows[uC_vehicleDetails1.rddlType.SelectedIndex]["VehicleType_ID"];
			//bool? a2	=	uC_vehicleDetails1.rddlState.SelectedIndex == 0	 ;

			result = objManager.ClsVehicles_update(-1,
				(decimal?) MainRadGridView.CurrentRow.Cells["Vehicle_ID"].Value,
				uC_vehicleDetails21.uC_CarNumber1.CarNumber,
				null,
				uC_vehicleDetails21.rtbColor.Text,
				uC_vehicleDetails21.rtbModel.Text,
				uC_vehicleDetails21.indexTypeModel,
				uC_vehicleDetails21.rddlState.SelectedIndex == 0);
		}

		private void b01_frm_vehicles_eventSaveToNew()
		{
			//string a1 = uC_vehicleDetails1.rtbNumber.Text;
			//a1 = null;
			//a1 = uC_vehicleDetails1.rtbColor.Text;
			//a1 = uC_vehicleDetails1.rtbModel.Text;
			//decimal? a0 = uC_vehicleDetails1.indexTypeModel;
			//bool? a2 = uC_vehicleDetails1.rddlState.SelectedIndex == 0;
			result = objManager.ClsVehicles_insert(1232,
				uC_vehicleDetails21.uC_CarNumber1.CarNumber ,
				null,
				uC_vehicleDetails21.rtbColor.Text,
				uC_vehicleDetails21.rtbModel.Text,
				uC_vehicleDetails21.indexTypeModel,
				uC_vehicleDetails21.rddlState.SelectedIndex == 0);

			b01_frm_vehicles_eventStatusNew();
		}

		private void b01_frm_vehicles_eventSaveToSearch()
		{
			result = objManager.View_vehicles(null,null, uC_vehicleDetails21.uC_CarNumber1.CarNumber,null,null);
		}

		private void b01_frm_vehicles_eventSaveToView()
		{
			result = objManager.View_vehicles(null,null,null,null,null);
		}

		private void radDock1_DockWindowClosed(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
		{
			switch (e.DockWindow.Name)
			{
				case "toolWindowProperties":
					toolWindowProperties.Visible = false;
					break;
				case "documentWindowTypeVehicle":
					documentWindowTypeVehicle.Visible = false;
					break;
			}

			if (!toolWindowProperties.Visible && !documentWindowTypeVehicle.Visible)
			{
				cbbCancel_Click(sender, e);
			}
		}

		private void rmiProperty_Click(object sender, EventArgs e)
		{
			toolWindowProperties.Show();
		}

		private void rmiVehicleTypes_Click(object sender, EventArgs e)
		{
			documentWindowTypeVehicle.Show();
		}

		private void b01_frm_vehicles_eventAfterSave()
		{

		}

		private void b01_frm_vehicles_eventStatusDelete()
		{

		}

		private void b01_frm_vehicles_eventStatusEdit()
		{
			//uC_vehicleTypesDetails1.rtbDescriptions.Focus();
			uC_vehicleDetails21.rddlType.Focus();
		}

		private void b01_frm_vehicles_eventStatusNew()
		{
			uC_vehicleDetails21.rddlType.Focus();
		}

		private void b01_frm_vehicles_eventStatusSearch()
		{
		}

		private void b01_frm_vehicles_eventStatusView()
		{

		}
	}
}
