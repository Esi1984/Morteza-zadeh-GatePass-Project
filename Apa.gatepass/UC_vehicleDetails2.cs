using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServerClasses;

namespace aorc.gatepass
{
    public partial class UC_vehicleDetails2 : UserControl
    {

        public UC_vehicleDetails2()
        {
            InitializeComponent();
        }

		private DataTable DtModels;
		
		public void SetModelsCar()
		{
			Manager objManager2 = new Manager();
			var Models = new OutputDatas();
			DtModels = null;
			DtModels = new DataTable();
			DtModels.Columns.Add("VehicleType_ID", typeof(decimal));
			DtModels.Columns.Add("VehicleType_Name", typeof(string));
			DtModels.Columns.Add("VehicleType_Desc", typeof(string));
			DtModels.Columns.Add("VehicleType_Hidden", typeof(bool));
			Models = objManager2.View_vehiclesType(null,null);
			if (!Models.success)
			{
				ItemsPublic.Exeptor("خطا در بازآوری اطلاعات انواع خودرو");
			}
			DtModels = Models.ResultTable.Copy();
			//foreach (var row in Models.ResultTable.Rows)
			for (int index = 0; index < DtModels.Rows.Count; index++)
			{
				rddlType.Items.Add((string)Models.ResultTable.Rows[index]["VehicleType_Name"]);
			}
			//	UC_vehicleDetails21.rddlType.DataSource = Models.ResultTable.Columns["VehicleType_Name"];
		}

		private int SetrddlType(int type)
		{
			//   VehicleType_ID				       VehicleType_Name

			for (int i = 0; i < DtModels.Rows.Count; i++)
			{
				if ((int)DtModels.Rows[i]["VehicleType_ID"] == type)
				{
					return i;
				}
			}

			ItemsPublic.Exeptor("نوع خودرو یافت نشد");
			return -1;
		}

    	public int? indexTypeModel
    	{
    		get { return rddlType.SelectedIndex>-1 ?(int?) DtModels.Rows[rddlType.SelectedIndex]["Operator_BaridId"]:null; }
			set { rddlType.SelectedIndex = value != null ?  SetrddlType((int)value) : -1; }
    	}

        public void ChangeTheme(ref Telerik.WinControls.Themes.Office2010BlackTheme NewTheme)
        {
	        rddlState.ThemeName = NewTheme.ThemeName;
	        rddlType.ThemeName = NewTheme.ThemeName;
	        rtbColor.ThemeName = NewTheme.ThemeName;
	        rtbModel.ThemeName = NewTheme.ThemeName;
	        uC_CarNumber1.ChangeTheme(ref NewTheme);
        }

    }
}
