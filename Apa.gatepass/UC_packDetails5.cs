using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass
{
	public partial class UC_packDetails5 : UserControl
	{
		public UC_packDetails5()
		{
			InitializeComponent();
		}
		public delegate void DelegateStatusAction();
		public event DelegateStatusAction eventTickVehicle;
		public int? CurrentTravelId { get; set; }
		public int? CurrentOfficeId { get; set; }
		public decimal? CurrentAgreeId { get; set; }
		public decimal? CurrentCarId { get; set; }

		private void rbtnAgree_Click(object sender, EventArgs e)
		{
			var frm = new gatepass.ui.package.frm_SelectAgree();
			frm.ShowDialog();
			if (frm.DialogResult == DialogResult.OK)
			{
				CurrentAgreeId = decimal.Parse(frm.number);
				rtbNumberAgree.Text = frm.number;
				rtbCompanyAgree.Text = frm.company;
				rtbTitleAgree.Text = frm.title;
			}
			frm.Close();
			frm.Dispose();
		}

		private void rbtnTravel_Click(object sender, EventArgs e)
		{
			var frm = new gatepass.ui.package.frm_SelectArea();
			frm.ShowDialog();
			if (frm.DialogResult == DialogResult.OK)
			{
				CurrentTravelId = frm.IdTa;
				rtbTravelLabel.Text = frm.masir;
			}
			frm.Close();
			//frm.Dispose();
		}

		private void rcbHaveVehicle_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
			if ( !rcbHaveVehicle.Checked )
			{
				CurrentCarId=null;
				uC_vehicleDetails1.rtbColor.Text = string.Empty;
				uC_vehicleDetails1.rtbModel.Text = string.Empty;
				uC_vehicleDetails1.rtbNumber.Text = string.Empty;
				uC_vehicleDetails1.indexTypeModel = null;
				uC_vehicleDetails1.rddlState.SelectedIndex =-1;
				
			}
			if (rcbHaveVehicle.Checked && rcbHaveVehicle.Enabled)
			{
				rbtnCar.Enabled = true;
				//uC_vehicleDetails1.rtbColor.Enabled = true;
				//uC_vehicleDetails1.rtbModel.Enabled = true;
				//uC_vehicleDetails1.rddlState.Enabled = true;
				//uC_vehicleDetails1.rddlType.Enabled = true;
				//uC_vehicleDetails1.rmebNumber.Enabled = true;
			}
			else
			{
				rbtnCar.Enabled = false;
					  
				//uC_vehicleDetails1.rtbColor.Enabled = false;
				//uC_vehicleDetails1.rtbModel.Enabled = false;
				//uC_vehicleDetails1.rddlState.Enabled = false;
				//uC_vehicleDetails1.rddlType.Enabled = false;
				//uC_vehicleDetails1.rmebNumber.Enabled = false;
			}
			eventTickVehicle();
		}

		private void rbtnCar_Click(object sender, EventArgs e)
		{
			var frm = new gatepass.ui.package.frm_SelectOneVehicle();
			frm.ShowDialog();
			if (frm.DialogResult == DialogResult.OK)
			{
				CurrentCarId = frm.CurrentId;
				uC_vehicleDetails1.rtbColor.Text = frm.Vcolor;
				uC_vehicleDetails1.rtbModel.Text = frm.VModel;
				uC_vehicleDetails1.rtbNumber.Text = frm.Vnumber;
				uC_vehicleDetails1.indexTypeModel = frm.VTypeIndex;
				uC_vehicleDetails1.rddlState.SelectedIndex = frm.VisCompany ? 0 : 1;
			}
			frm.Close();
			frm.Dispose();
		}

		private void rddlTypePack_SelectedIndexChanged( object sender , Telerik.WinControls.UI.Data.PositionChangedEventArgs e )
		{
			if(rddlTypePack.SelectedIndex >1)
			{
					CurrentAgreeId=null;
rbtnAgree.Enabled=false;
rtbCompanyAgree.Text=string.Empty;
rtbNumberAgree.Text=string.Empty;
				rtbTitleAgree.Text = string.Empty;
			}
			else if ( rddlTypePack.SelectedIndex <2 && rddlTypePack.Enabled)
			{
				rbtnAgree.Enabled=true;
			}
		}
	}
}
