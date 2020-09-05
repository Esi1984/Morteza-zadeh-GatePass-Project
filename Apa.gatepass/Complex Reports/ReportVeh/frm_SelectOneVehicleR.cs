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
using aorc.gatepass.Complex_Reports.Uc_Mini;

namespace aorc.gatepass.Complex_Reports.ReportVeh
{
	public partial class frm_SelectOneVehicleR : Form
	{
		public frm_SelectOneVehicleR()
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

        //public string Vcolor;
        //public string VModel;
        //public string Vnumber;
        //public int VTypeIndex;
        //public bool VisCompany;
		//public decimal CurrentId;
        //public int VTypePlateIndex { get; set; }
        public clsReportCase objVehicle = new clsReportCase();        

		protected bool CheckOneSelectedRow(int countSelectedRows)
		{
			if (countSelectedRows != 1)
			{
				MessageBox.Show(ItemsPublic._infoSelRow);
				return false;
			}
			return true;
		}

        private void FindInfo()
        {

            MainRadGridView.DataSource = null;
            result = objManager.View_vehicles(uC_vehicleDetailsSearch1.indexTypeModel, uC_vehicleDetailsSearch1.uC_PlatesCar1.rddlTypePlate.SelectedIndex, uC_vehicleDetailsSearch1.uC_PlatesCar1.CarNumber, uC_vehicleDetailsSearch1.rddlState.SelectedIndex,uC_vehicleDetailsSearch1.rtbModel.Text.Trim());
                if (result.success)
                {
                    MainRadGridView.DataSource = result.ResultTable;
                    if (MainRadGridView.Rows.Count < 1)
                    {
                        ItemsPublic.ShowMessage("موردی یافت نشد");
                    }
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
        }

		private void cbbSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MainRadGridView.SelectedRows.Count == 1)
				{
                    objVehicle.SelectedCase.Sname = MainRadGridView.CurrentRow.Cells["vehicle_Color"].Value.ToString() + " " + "به شماره" +" "+ MainRadGridView.CurrentRow.Cells["Vehicle_number"].Value.ToString();
                    objVehicle.SelectedCase.Lname = MainRadGridView.CurrentRow.Cells["Vehicle_Model"].Value.ToString();
                    //objVehicle.SelectedCase.SpecialCode = MainRadGridView.CurrentRow.Cells["Vehicle_number"].Value.ToString();
                    objVehicle.SelectedCase.Fname = "خودروی" + " " + MainRadGridView.CurrentRow.Cells["VehicleType_Name"].Value.ToString() + " "+objVehicle.SelectedCase.Lname;
					objVehicle.SelectedCase.SecondSpecialCode = (int) MainRadGridView.CurrentRow.Cells["VehicleType_ID"].Value;
                    objVehicle.SelectedCase.ID = (decimal)MainRadGridView.CurrentRow.Cells["Vehicle_ID"].Value;
					objVehicle.SelectedCase.stateBool1 = (bool) MainRadGridView.CurrentRow.Cells["Vehicle_IsCompany"].Value;
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
                ItemsPublic.ShowMessage(ex.Message);
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
       
		private void frm_SelectOneVehicle_Load(object sender, EventArgs e)
		{
			//rmebG.Focus();
			//State = false;
			//	IdTa = null;
			//	this.DialogResult = DialogResult.Cancel;
            if (!ItemsPublic.MyRights.Contains(AllFunctions._Rights.View_vehicles) )
            {
                uC_vehicleDetailsSearch1.LimitedAcess();
            }
            try
            {
                uC_vehicleDetailsSearch1.SetModelsCar();

            }
            catch(Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                this.Close();
            }

         //   uC_vehicleDetailsSearch1.uC_PlatesCar1.Focus();
		}
		
		private void rbtnSearch_Click( object sender , EventArgs e )
		{
            //FindInfo(uC_vehicleDetailsSearch1.uC_PlatesCar1.CarNumber, uC_vehicleDetailsSearch1.uC_PlatesCar1.rddlTypePlate.SelectedIndex);
            FindInfo();
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
             uC_vehicleDetailsSearch1.uC_PlatesCar1.rddlTypePlate.Focus();  
             
		 }

         private void cbbDecline_Click(object sender, EventArgs e)
         {
             try
             {
                 objVehicle.CurrentCase = null;
                 this.DialogResult = DialogResult.OK;
                 this.Close();
             }
             catch (Exception ex)
             {
                 ItemsPublic.ShowMessage(ex.Message);
             }
         }

         private void cbbEmpty_Click(object sender, EventArgs e)
         {
             uC_vehicleDetailsSearch1.clearItems();
         }


         
    }
}
