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

namespace aorc.gatepass.Gp2.Pack
{
	public partial class frm_SettingPackGatePlaceGp2 : Form
	{

		protected List<object> myNew;
		protected List<object> myEdit;
		protected List<object> mySearch;
		protected List<object> myDelete;
		protected List<object> myView;
		protected List<object> myAll;

		public frm_SettingPackGatePlaceGp2()
		{
			try
			{
				InitializeComponent();
                //if (isGpType !=null)
                //{
                //    v2UC_NewPackDetailsGp21.SetTypePackList((bool)isGpType);

                //}
                //else
                //{

                //}
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
				if ( !( v2UC_NewPackDetailsGp21.CurrentPlaces.Count()>0 ) )
				{
					MessageBox.Show ( "محدوده تردد انتخاب نشده است" );
					return;
				}
                if (!(v2UC_NewPackDetailsGp21.CurrentGates.Count() > 0))
                {
                    MessageBox.Show("دروازه تردد انتخاب نشده است");
                    return;
                }

                if (v2UC_NewPackDetailsGp21.TypePackId == null)
				{
					MessageBox.Show("نوع بسته مشخص نیست");
					return;
				}
				if (v2UC_NewPackDetailsGp21.bdcStartDate.SelectedDate == null)
				{
					MessageBox.Show("تاریخ شروع تنظیم نیست");
					return;
				}
				if (v2UC_NewPackDetailsGp21.bdcEndDate.SelectedDate == null)
				{
					MessageBox.Show("تاریخ پایان تنظیم نیست");
					return;
				}
                if (!v2UC_NewPackDetailsGp21.AgreeisOk())
				{
					MessageBox.Show("قرار داد مشخص نشده است");
					return;
				}
				if (v2UC_NewPackDetailsGp21.CurrentTravelId == null)
				{
					MessageBox.Show("محل کار تعیین نشده");
					return;
				}
				if ( string.IsNullOrEmpty (v2UC_NewPackDetailsGp21.rddlShift.Text) )
				{
					MessageBox.Show( "شیفت کاری تنظیم نیست" );
					return;
				}

                //if ( v2UC_NewPackDetailsGp21.CurrentCarId == null && v2UC_NewPackDetailsGp21.rcbHaveVehicle.Checked )
                //{
                //    MessageBox.Show ( "خودرویی انتخاب نشده است" );
                //    return;
                //}

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
                MessageBox.Show("تنظیمات ناقص می باشد");
				//this.Close();
			}
		}

		private void cbbCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void frm_SettingPackGatePlaceGp2_Load(object sender, EventArgs e)
		{
			v2UC_NewPackDetailsGp21.rtbCompanyAgree.ReadOnly=true;
			//v2UC_NewPackDetailsGp21.rtbTitleAgree.ReadOnly=true;
			v2UC_NewPackDetailsGp21.rtbTravelLabel.ReadOnly=true;
			//v2UC_NewPackDetailsGp21.rtbNumberAgree.ReadOnly=true;
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.rtbColor.ReadOnly=true;
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.rtbModel.ReadOnly=true;
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.rddlType.Enabled=false;
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.rddlState.Enabled=false;
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.Enabled = false;
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.uC_PlatesMeli1.rtbH.ReadOnly = true;
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.uC_PlatesMeli1.rmeb24.ReadOnly = true;
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.uC_PlatesMeli1.rmebG.ReadOnly = true;
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.uC_PlatesMeli1.rmebGGG.ReadOnly = true;
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.uC_PlatesSimple1.rddlTypes.Enabled = false;
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.Enabled = false;
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.uC_PlatesSimple1.rmebGGG.ReadOnly = true;

            //if(v2UC_NewPackDetailsGp21.uC_vehicleDetails31.rddlType.Items.Count<=0)
            //{
            //    v2UC_NewPackDetailsGp21.uC_vehicleDetails31.SetModelsCar();
            //}
            //v2UC_NewPackDetailsGp21.uC_vehicleDetails31.ChangeTheme(ref office2010BlackTheme1);

            
		}

		public void SetSettings( V3UC_PackDetailsGp2 obj )
		{

			//v2UC_NewPackDetailsGp21.uC_vehicleDetails31.SetModelsCar ();

            ////........
            v2UC_NewPackDetailsGp21.isGpType = obj.isGpType;
            v2UC_NewPackDetailsGp21.TypePackId = obj.TypePackRealId;   // obj.rddlTypePack.SelectedIndex;
            ////........
			v2UC_NewPackDetailsGp21.rtbPlaces.Text = obj.rtbPlaces.Text.Trim ();
			v2UC_NewPackDetailsGp21.CurrentPlaces = obj.CurrentPlaces;

			v2UC_NewPackDetailsGp21.rtbGates.Text = obj.rtbGates.Text.Trim ();
			v2UC_NewPackDetailsGp21.CurrentGates = obj.CurrentGates;

			v2UC_NewPackDetailsGp21.bdcStartDate.DateTime = obj.bdcStartDate.DateTime;
			v2UC_NewPackDetailsGp21.bdcEndDate.DateTime = obj.bdcEndDate.DateTime;
			v2UC_NewPackDetailsGp21.rtbNumberAgree.Text = obj.rtbNumberAgree.Text.Trim();
			v2UC_NewPackDetailsGp21.CurrentAgreeId = obj.CurrentAgreeId;
			v2UC_NewPackDetailsGp21.rtbCompanyAgree.Text = obj.rtbCompanyAgree.Text.Trim();
		//	v2UC_NewPackDetailsGp21.rtbTitleAgree.Text = obj.rtbTitleAgree.Text.Trim();
			v2UC_NewPackDetailsGp21.rlblCountCar.Text = obj.rlblCountCar.Text.Trim();
			v2UC_NewPackDetailsGp21.rddlShift.Text = obj.rddlShift.Text.Trim();

			v2UC_NewPackDetailsGp21.CurrentTravelId = obj.CurrentTravelId;

			v2UC_NewPackDetailsGp21.rtbTravelLabel.Text = obj.rtbTravelLabel.Text.Trim();

			v2UC_NewPackDetailsGp21.tbPackDescriptions.Text = obj.tbPackDescriptions.Text.Trim();

			//v2UC_NewPackDetailsGp21.uC_vehicleDetails21.rddlType.SelectedIndex =
            //v2UC_NewPackDetailsGp21.rcbHaveVehicle.Checked = obj.rcbHaveVehicle.Checked;
            //if (v2UC_NewPackDetailsGp21.rcbHaveVehicle.Checked)
            //{
            //    v2UC_NewPackDetailsGp21.CurrentCarId = obj.CurrentCarId;
            //    v2UC_NewPackDetailsGp21.uC_vehicleDetails31.rtbModel.Text =
            //        obj.uC_vehicleDetails31.rtbModel.Text.Trim();
            //    v2UC_NewPackDetailsGp21.uC_vehicleDetails31.rtbColor.Text =
            //        obj.uC_vehicleDetails31.rtbColor.Text.Trim();

            //    v2UC_NewPackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex =
            //        obj.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex;

            //    v2UC_NewPackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.CarNumber =
            //        obj.uC_vehicleDetails31.uC_PlatesCar1.CarNumber;

            //    v2UC_NewPackDetailsGp21.uC_vehicleDetails31.rddlState.SelectedIndex =
            //        obj.uC_vehicleDetails31.rddlState.SelectedIndex;
            //    v2UC_NewPackDetailsGp21.uC_vehicleDetails31.indexTypeModel = obj.uC_vehicleDetails31.indexTypeModel;
            //}
		}

		private void v2UC_NewPackDetailsGp21_eventTickVehicle()
		{

		}

        private void v2UC_NewPackDetailsGp21_Load(object sender, EventArgs e)
        {

        }

        private void frm_SettingPackGatePlaceGp2_Shown(object sender, EventArgs e)
        {
            
        }

	}
}
