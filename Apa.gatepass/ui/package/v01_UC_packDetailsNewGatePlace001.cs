using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServerClasses;

namespace aorc.gatepass.ui.package
{
	public partial class v01_UC_packDetailsNewGatePlace001 : UserControl
	{

		public v01_UC_packDetailsNewGatePlace001()
		{
			InitializeComponent();
		}

		public delegate void DelegateStatusAction();
		public event DelegateStatusAction eventTickVehicle;
		public int? CurrentTravelId { get; set; }
		public int? CurrentOfficeId { get; set; }
		public decimal? CurrentAgreeId { get; set; }
		public decimal? CurrentCarId { get; set; }
		public List<int> CurrentGates { get;set;}
		public List<int> CurrentPlaces { get; set; }
        private OutputDatas ODConfirmer;
		private void rbtnAgree_Click(object sender, EventArgs e)
		{
			var frm = new gatepass.ui.package.frm_SelectAgree();
			frm.ShowDialog();
			if (frm.DialogResult == DialogResult.OK)
			{
				CurrentAgreeId = decimal.Parse(frm.currentId);
				rtbNumberAgree.Text = frm.number;
				rtbCompanyAgree.Text = frm.company;
				rtbTitleAgree.Text = frm.title;
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

		private void rcbHaveVehicle_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
			if ( !rcbHaveVehicle.Checked )
			{
				CurrentCarId=null;
                uC_vehicleDetails31.rtbColor.Text = string.Empty;
				uC_vehicleDetails31.rtbModel.Text = string.Empty;
                uC_vehicleDetails31.rddlType.SelectedIndex = -1;
                uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex = -1;
				uC_vehicleDetails31.uC_PlatesCar1.CarNumber = string.Empty;
				uC_vehicleDetails31.indexTypeModel = null;
				uC_vehicleDetails31.rddlState.SelectedIndex =-1;
				
			}
			if (rcbHaveVehicle.Checked && rcbHaveVehicle.Enabled)
			{
				rbtnCar.Enabled = true;
				//uC_vehicleDetails21.rtbColor.Enabled = true;
				//uC_vehicleDetails21.rtbModel.Enabled = true;
				//uC_vehicleDetails21.rddlState.Enabled = true;
				//uC_vehicleDetails21.rddlType.Enabled = true;
				//uC_vehicleDetails21.rmebNumber.Enabled = true;
			}
			else
			{
				rbtnCar.Enabled = false;
					  
				//uC_vehicleDetails21.rtbColor.Enabled = false;
				//uC_vehicleDetails21.rtbModel.Enabled = false;
				//uC_vehicleDetails21.rddlState.Enabled = false;
				//uC_vehicleDetails21.rddlType.Enabled = false;
				//uC_vehicleDetails21.rmebNumber.Enabled = false;
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
				uC_vehicleDetails31.rtbColor.Text = frm.Vcolor;
				uC_vehicleDetails31.rtbModel.Text = frm.VModel;
                uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex = frm.VTypePlateIndex;
				uC_vehicleDetails31.uC_PlatesCar1.CarNumber = frm.Vnumber;
				uC_vehicleDetails31.indexTypeModel = frm.VTypeIndex;
				uC_vehicleDetails31.rddlState.SelectedIndex = frm.VisCompany ? 0 : 1;
			}
			frm.Close();
			frm.Dispose();
		}

		private void rddlTypePack_SelectedIndexChanged( object sender , Telerik.WinControls.UI.Data.PositionChangedEventArgs e )
		{
			if (rddlTypePack.SelectedIndex > 1)
			{
				CurrentAgreeId = null;
				rbtnAgree.Enabled = false;
				rtbCompanyAgree.Text = string.Empty;
				rtbNumberAgree.Text = string.Empty;
				rtbTitleAgree.Text = string.Empty;
			}
			else if (rddlTypePack.SelectedIndex < 2 && rddlTypePack.Enabled)
			{
				rbtnAgree.Enabled = true;
			}
		}

		private void rbtnGates_Click( object sender , EventArgs e )
		{
			var frm = new gatepass.ui.package.frm_SelectGates ();
			frm.SetInfo( CurrentGates);
			frm.ShowDialog ();
			if ( frm.DialogResult == DialogResult.OK )
			{
				rtbGates.Text = "";
				CurrentGates = new List<int>();
				foreach ( var obj in frm.radGridViewSelected.Rows )
				{
				//	string ss = obj.Cells["Gate_Id"].Value.ToString().Trim();
					//int ii = int.Parse(obj.Cells["Gate_Id"].Value.ToString().Trim());
					CurrentGates.Add ( int.Parse ( obj.Cells ["Gate_Id"].Value.ToString ().Trim () ) );
					rtbGates.Text += obj.Cells ["Gate_Name"].Value.ToString ().Trim()+"\r\n";
				}
			}
			frm.Close ();
			frm.Dispose ();
		}

		private void rbtnPlaces_Click( object sender , EventArgs e )
		{
			var frm = new gatepass.ui.package.frm_SelectPlaces ();
			frm.SetInfo ( CurrentPlaces );
			frm.ShowDialog ();
			if ( frm.DialogResult == DialogResult.OK )
			{
				rtbPlaces.Text = "";
				CurrentPlaces = new List<int> ();
				foreach ( var obj in frm.radGridViewSelected.Rows )
				{
					//	string ss = obj.Cells["Gate_Id"].Value.ToString().Trim();
					//int ii = int.Parse(obj.Cells["Gate_Id"].Value.ToString().Trim());
					CurrentPlaces.Add ( int.Parse ( obj.Cells ["Place_Id"].Value.ToString ().Trim () ) );
					rtbPlaces.Text += obj.Cells ["Place_Name"].Value.ToString ().Trim ()+"\r\n";
				}
			}
			frm.Close ();
			frm.Dispose ();
		}

        public void SetConfirmsList()
        {
           var objC = new Manager();

           var ODConfirmer = new OutputDatas();
           ODConfirmer = objC.MyConfirmers(null);
           if (ODConfirmer.success)
           {
               rddlConfirmer.DataSource = ODConfirmer.ResultTable.Columns["BaridName"];

               //for (int index = 0; index < ODConfirmer.ResultTable.Rows.Count; index++)
               //{
               //    rddlConfirmer.Items.Add((string)ODConfirmer.ResultTable.Rows[index]["BaridName"]);
               //}
           }
           else
           {
               ItemsPublic.ShowMessage(ODConfirmer.Message);
           }
        }
        
        private int SetrddlConfirmer(int Operator_BaridId)
        {
            //   VehicleType_ID				       VehicleType_Name

            for (int i = 0; i < ODConfirmer.ResultTable.Rows.Count; i++)
            {
                if ((int)ODConfirmer.ResultTable.Rows[i]["Operator_BaridId"] == Operator_BaridId)
                {
                    return i;
                }
            }

            ItemsPublic.Exeptor("اپراتور یافت نشد");
            return -1;
        }
        
        public int? indexConfirmer
        {
            get { return rddlConfirmer.SelectedIndex > -1 ? (int?)ODConfirmer.ResultTable.Rows[rddlConfirmer.SelectedIndex]["Operator_BaridId"] : null; }
            set { rddlConfirmer.SelectedIndex = value != null ? SetrddlConfirmer((int)value) : -1; }
        }

	}
}
