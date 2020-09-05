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
	public partial class frm_VehicleTempAdding : Form
	{
		public frm_VehicleTempAdding()
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
		public OutputDatas result = new OutputDatas ();
		private void cbbSave_Click(object sender, EventArgs e)
		{
			try
			{
                result = objManager.ClsVehicles_insert(uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex,
                uC_vehicleDetails31.uC_PlatesCar1.CarNumber ,
				null ,
				uC_vehicleDetails31.rtbColor.Text ,
				uC_vehicleDetails31.rtbModel.Text ,
				uC_vehicleDetails31.indexTypeModel ,
				uC_vehicleDetails31.rddlState.SelectedIndex == 0 );

				if (result.success)
				{
					//  eventClearProperiesItems();
					//objManager.EmptyControls ( myAll );
					ItemsPublic.ShowMessage(ItemsPublic._infoNew);
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					MessageBox.Show(result.Message);
				}

			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message);
				//	this.DialogResult = DialogResult.Cancel;
				//this.Close();
			}
		}

		private void cbbCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void frm_VehicleTempAdding_Load(object sender, EventArgs e)
		{
			uC_vehicleDetails31.rtbModel.Focus();
			uC_vehicleDetails31.SetModelsCar();
		}

		private void uC_packDetailsForNew1_eventTickVehicle()
		{

		}

		private void frm_VehicleTempAdding_Shown( object sender , EventArgs e )
		{
			uC_vehicleDetails31.Focus();
		}

		


	}
}
