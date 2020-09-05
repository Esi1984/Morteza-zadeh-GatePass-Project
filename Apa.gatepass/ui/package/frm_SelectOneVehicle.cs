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
	public partial class frm_SelectOneVehicle : Form
	{
		public frm_SelectOneVehicle()
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
        public int VTypePlateIndex { get; set; }
        public decimal? PersonId = null;

		protected bool CheckOneSelectedRow(int countSelectedRows)
		{
			if (countSelectedRows != 1)
			{
				MessageBox.Show(ItemsPublic._infoSelRow);
				return false;
			}
			return true;
		}

		private void FindInfo(string myStr,int typePlate)
		{
			MainRadGridView.DataSource = null;
            if (uC_PlatesCar1.CarNumber != null)
			{
			result = objManager.View_vehicles(null,typePlate, myStr,null,null);
			if (result.success)
			{
				MainRadGridView.DataSource = result.ResultTable;
				if (MainRadGridView.Rows.Count > 0)
				{

				}
				else
				{
					if (QuestionSureToAddNewUser())
					{
						var frm = new frm_VehicleTempAdding();
                        frm.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex = uC_PlatesCar1.rddlTypePlate.SelectedIndex;
                        frm.uC_vehicleDetails31.uC_PlatesCar1.CarNumber = uC_PlatesCar1.CarNumber;
						frm.ShowDialog();
						if (frm.DialogResult == DialogResult.OK)
						{
							MainRadGridView.Rows.AddNew();
							foreach (DataColumn col in frm.result.ResultTable.Columns)
							{
								MainRadGridView.CurrentRow.Cells[col.ColumnName].Value =
									frm.result.ResultTable.Rows[0][col.ColumnName];
							}
							MainRadGridView.CurrentRow = MainRadGridView.Rows[0];
						}
						frm.Close();
					}					
				}
			}
			else
			{
				MessageBox.Show(result.Message);
			}
				} else
			{
				ItemsPublic.ShowMessage("قالب شماره خودرو صحیح نمی باشد");
			}
		}

		private bool QuestionSureToAddNewUser()
		{

			var dr = MessageBox.Show ( "خودروی مورد نظر در سیستم یافت نشد"+"\n\n"+"آیا قصد افزودن اطلاعات خودروی جدیدی را دارید؟" , "هشدار" , MessageBoxButtons.YesNo ,
									 MessageBoxIcon.Question );
			return dr == DialogResult.Yes;
		}

		private void cbbSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MainRadGridView.SelectedRows.Count == 1)
				{
					Vcolor = MainRadGridView.CurrentRow.Cells["vehicle_Color"].Value.ToString();
					VModel = MainRadGridView.CurrentRow.Cells["Vehicle_Model"].Value.ToString();
                    VTypePlateIndex = (int)MainRadGridView.CurrentRow.Cells["TypePlates_Id"].Value;
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
				//this.DialogResult = DialogResult.Cancel;
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

		private void frm_SelectOneVehicle_Load(object sender, EventArgs e)
		{
			//rmebG.Focus();
			//State = false;
			//	IdTa = null;
			//	this.DialogResult = DialogResult.Cancel;
            

            uC_PlatesCar1.Focus();
		}
		
		private void rbtnSearch_Click( object sender , EventArgs e )
		{
            FindInfo(uC_PlatesCar1.CarNumber, uC_PlatesCar1.rddlTypePlate.SelectedIndex);
		}

		//private string InputCarNumber()
		 //{
		 ////	return rmeb24.Text.Trim() + "-" + rmebG.Text.Trim() + rtbH.Text.Trim() + rmebGGG.Text.Trim();
		 //}

		private void MainRadGridView_DoubleClick( object sender , EventArgs e )
		 {
			 cbbSave_Click ( sender , e );
		 }

		private void frm_SelectOneVehicle_Shown( object sender , EventArgs e )
		 {
		 	//uC_CarNumber1.Focus();
             uC_PlatesCar1.rddlTypePlate.Focus();
             if (PersonId != null)
             {
                 result = objManager.View_vehiclesComplex(null, null, null, null, null, PersonId, null, null, null, null);
                 if (result != null)
                     if (result.success)
                     {
                         MainRadGridView.DataSource = result.ResultTable;
                     }
                     else
                     {
                         ItemsPublic.ShowMessage(result.Message);
                     }
             }
		 }
         
    }
}
