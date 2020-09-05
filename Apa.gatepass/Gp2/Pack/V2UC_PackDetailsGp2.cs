using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.Gp2.Pack
{
	public partial class V2UC_PackDetailsGp2 : UserControl
	{
		public V2UC_PackDetailsGp2()
		{
			InitializeComponent();
		}

		public delegate void DelegateStatusAction();

		public event DelegateStatusAction eventTickVehicle;
		public int? CurrentTravelId { get; set; }
		public int? CurrentOfficeId { get; set; }
		public decimal? CurrentAgreeId { get; set; }
		//public decimal? CurrentCarId { get; set; }
		public List<int> CurrentGates { get; set; }
		public List<int> CurrentPlaces { get; set; }

		private void rbtnAgree_Click(object sender, EventArgs e)
		{
			var frm = new gatepass.ui.package.frm_SelectAgree();
			frm.ShowDialog();
			if (frm.DialogResult == DialogResult.OK)
			{
				CurrentAgreeId = decimal.Parse(frm.currentId);
				rtbNumberAgree.Text = frm.number;
				rtbCompanyAgree.Text = frm.company;
				//rtbTitleAgree.Text = frm.title;
				rlblCountCar.Text = frm.countCarDesc;
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

	

	

		private void rddlTypePack_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			if (rddlTypePack.SelectedIndex > 1)
			{
				CurrentAgreeId = null;
			//	rbtnAgree.Enabled = false;
				rtbCompanyAgree.Text = string.Empty;
				rtbNumberAgree.Text = string.Empty;
				//rtbTitleAgree.Text = string.Empty;
			}
			else if (rddlTypePack.SelectedIndex < 2 && rddlTypePack.Enabled)
			{
			//	rbtnAgree.Enabled = true;
			}
		}
	}
}
