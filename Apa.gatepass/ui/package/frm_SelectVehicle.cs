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
	public partial class frm_SelectVehicle : Form
	{
		public frm_SelectVehicle()
		{
			try
			{
				InitializeComponent();
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message);
				// ItemsPublic.ShowMessage(ex.Message);
				this.Close();
			}
		}

		private Manager objManager = new Manager();
		private OutputDatas result = new OutputDatas();

		public string Vcolor;
		public string VModel;
		public string Vnumber;
		public int VTypeIndex;
		public bool VisCompany;
		public decimal CurrentId;

		protected bool CheckOneSelectedRow(int countSelectedRows)
		{
			if (countSelectedRows != 1)
			{
				MessageBox.Show(ItemsPublic._infoSelRow);
				return false;
			}
			return true;
		}

		private void FindInfo(string myStr)
		{

			MainRadGridView.DataSource = null;
			if (myStr.Count() > 1)
			{
				result = objManager.View_vehicles(null,null,myStr,null,null);
				if (result.success)
				{
					MainRadGridView.DataSource = result.ResultTable;
				}
				else
				{
					MessageBox.Show(result.Message);
				}
			}
		}

		private void rtbSearchPerson_TextChanged(object sender, EventArgs e)
		{
			FindInfo(rtbSearch.Text);
		}

		private void cbbSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MainRadGridView.SelectedRows.Count == 1)
				{
					Vcolor = MainRadGridView.CurrentRow.Cells["vehicle_Color"].Value.ToString();
					VModel = MainRadGridView.CurrentRow.Cells["Vehicle_Model"].Value.ToString();
					Vnumber = MainRadGridView.CurrentRow.Cells["Vehicle_number"].Value.ToString();
					VTypeIndex = (int) MainRadGridView.CurrentRow.Cells["VehicleType_ID"].Value;
					CurrentId = (decimal) MainRadGridView.CurrentRow.Cells["Vehicle_ID"].Value;
					VisCompany = (bool) MainRadGridView.CurrentRow.Cells["Vehicle_IsCompany"].Value;
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					MessageBox.Show(ItemsPublic._infoSelRow);
				}
			}
			catch (Exception ex)
			{
				//State = false;
				//	this.DialogResult = DialogResult.Cancel;
				//eventSaveTiny();
				//this.DialogResult = DialogResult.OK;

				this.Close();
			}
		}

		private void cbbCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void frm_SelectVehicle_Load(object sender, EventArgs e)
		{
			//State = false;
		//	IdTa = null;
			
			
			//	this.DialogResult = DialogResult.Cancel;
		}
		private void uC_TreeOffices1_eventSelectedNodeChanged()
		{

		}

		private void MainRadGridView_DoubleClick( object sender , EventArgs e )
		{
			   cbbSave_Click( sender,  e);
		}

		
	}
}
