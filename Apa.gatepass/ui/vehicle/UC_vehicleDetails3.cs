using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServerClasses;

namespace aorc.gatepass.ui.vehicle
{
    public partial class UC_vehicleDetails3 : UserControl
    {
        public UC_vehicleDetails3()
        {
            InitializeComponent();
        }

		private DataTable DtModels;
        const int _khali = -1000;
		public void SetModelsCar()
		{
			Manager objManager2 = new Manager();
			var Models = new OutputDatas();
			DtModels = null;
			DtModels = new DataTable();
			DtModels.Columns.Add("VehicleType_ID", typeof(int));
			DtModels.Columns.Add("VehicleType_Name", typeof(string));
			DtModels.Columns.Add("VehicleType_Desc", typeof(string));
			DtModels.Columns.Add("VehicleType_Hidden", typeof(bool));
            DtModels.Columns.Add("VehicleType_DDLID", typeof(int));

			Models = objManager2.View_vehiclesType(null,null);
			if (!Models.success)
			{
				ItemsPublic.Exeptor("خطا در بازآوری اطلاعات انواع خودرو");
			}
			//DtModels = Models.ResultTable.Copy();
            int countNotHidden = -1;
            
            foreach (DataRow item in  Models.ResultTable.Rows)
            {
                //countNotHidden++;   
                DtModels.Rows.Add();
                DtModels.Rows[DtModels.Rows.Count - 1]["VehicleType_ID"] = item["VehicleType_ID"];
                DtModels.Rows[DtModels.Rows.Count - 1]["VehicleType_Name"] = item["VehicleType_Name"];
                DtModels.Rows[DtModels.Rows.Count - 1]["VehicleType_Desc"] = item["VehicleType_Desc"];
                DtModels.Rows[DtModels.Rows.Count - 1]["VehicleType_Hidden"] = item["VehicleType_Hidden"];
                if (!(bool)item["VehicleType_Hidden"])
                {
                    countNotHidden++;
                    DtModels.Rows[DtModels.Rows.Count - 1]["VehicleType_DDLID"] = countNotHidden;
                }
                else
                {
                    DtModels.Rows[DtModels.Rows.Count - 1]["VehicleType_DDLID"] = _khali;
                }
                if (!(bool)item["VehicleType_Hidden"])
                    rddlType.Items.Add((string)item["VehicleType_Name"]);
            }
            
			//foreach (var row in Models.ResultTable.Rows)
            //for (int index = 0; index < DtModels.Rows.Count; index++)
            //{
                
            //}
			//	UC_vehicleDetails31.rddlType.DataSource = Models.ResultTable.Columns["VehicleType_Name"];
		}
        private int? findRealIndex(int ddlIndex)
        {
            if( ddlIndex < 0 )
            {
                return null;
            }

            foreach (DataRow item in DtModels.Rows)
	        {
		            if((int)item["VehicleType_DDLID"] == ddlIndex )
                    {
                        return (int?)item["VehicleType_ID"];
                    }
	        }

            ItemsPublic.Exeptor("نوع خودرو یافت نشد");
            return null;
        }
        int hiddenIndex = _khali;
		private void SetrddlType(int? type)
		{
			//   VehicleType_ID				       VehicleType_Name
            //return ;
            if(type==null)
            {
                rddlType.SelectedIndex = -1;
                hiddenIndex = _khali;
                return;
            }
			for (int i = 0; i < DtModels.Rows.Count; i++)
			{
				if ((int)DtModels.Rows[i]["VehicleType_ID"] == type)
				{
                    if (!(bool)DtModels.Rows[i]["VehicleType_Hidden"])
                    {
                            rddlType.SelectedIndex =(int)DtModels.Rows[i]["VehicleType_DDLID"];
                            hiddenIndex = _khali;
                    }else
                    {
                        rddlType.SelectedIndex = -1;
                        rddlType.Text = (string)DtModels.Rows[i]["VehicleType_Name"];
                        hiddenIndex = (int)DtModels.Rows[i]["VehicleType_DDLID"];
                    }
                    return;
				}
			}

			ItemsPublic.Exeptor("نوع خودرو یافت نشد");
			
		}

    	public int? indexTypeModel
    	{
            get { return findRealIndex(rddlType.SelectedIndex != -1 ?rddlType.SelectedIndex : hiddenIndex); }
        //    set { rddlType.SelectedIndex = value != null ? SetrddlType((int)value) : -1; }
            set {  SetrddlType(value); }
    	}

        public void ChangeTheme(ref Telerik.WinControls.Themes.Office2010BlackTheme NewTheme)
        {
	        rddlState.ThemeName = NewTheme.ThemeName;
	        rddlType.ThemeName = NewTheme.ThemeName;
	        rtbColor.ThemeName = NewTheme.ThemeName;
	        rtbModel.ThemeName = NewTheme.ThemeName;
            uC_PlatesCar1.ChangeTheme(ref NewTheme);	        
        }

        internal void clearItems()
        {
            uC_PlatesCar1.rddlTypePlate.SelectedIndex = -1;
            uC_PlatesCar1.uC_PlatesMeli1.rtbH.Text = "";
            uC_PlatesCar1.uC_PlatesMeli1.rmeb24.Text = "";
            uC_PlatesCar1.uC_PlatesMeli1.rmebG.Text = "";
            uC_PlatesCar1.uC_PlatesMeli1.rmebGGG.Text = "";
            uC_PlatesCar1.uC_PlatesSimple1.rmebGGG.Text = "";
            uC_PlatesCar1.uC_PlatesSimple1.rddlTypes.SelectedIndex = -1;
            rtbColor.Text = "";
            rtbModel.Text = "";
            rddlState.SelectedIndex = -1;
            rddlType.SelectedIndex = -1;
        }
    }
}
