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
	public partial class ComboCountry : UserControl
	{
		public ComboCountry()
		{
			InitializeComponent();
		}

		//private int? indexSelectLocation
		//{
		//    get
		//    {
		//        return rddlLocations.SelectedIndex > -1
		//                ? (int?) ItemsPublic.AllNationality.Rows[rddlLocations.SelectedIndex]["Nationality_Id"]
		//                : null;
		//    }
		//    set { rddlLocations.SelectedIndex = value != null ? SetrddlLocation((int) value) : -1; }
		//}

	//	private OutputDatas Result = new OutputDatas();

		private int SetrddlLocation(int inLocId)
		{

			for (int i = 0; i < ItemsPublic.AllNationality.Rows.Count; i++)
			{
				if ((int) ItemsPublic.AllNationality.Rows[i]["Nationality_Id"] == inLocId)
				{
					return i;
				}
			}
			ItemsPublic.Exeptor("کشور مورد نظر یافت نشد");
			return -1;
		}

		public void SetAllLocations()
		{
			//Manager objManager2 = new Manager();
			//DtModels = null;
			//DtModels = new DataTable ();
			//DtModels.Columns.Add ( "VehicleType_ID" , typeof ( decimal ) );
			//DtModels.Columns.Add ( "VehicleType_Name" , typeof ( string ) );
			//DtModels.Columns.Add ( "VehicleType_Desc" , typeof ( string ) );
			//DtModels.Columns.Add ( "VehicleType_Hidden" , typeof ( bool ) );
			//Result = objManager2.View_Nationalities ();
			//if ( !Result.success )
			//{
			//    ItemsPublic.Exeptor ( "خطا در بازآوری اطلاعات کشورها" );
			//}
			//	DtModels = types.ResultTable.Copy ();
			//foreach (var row in Models.ResultTable.Rows)
			//rddlBLReasonType.Items.AddRange ( new string [] { types.ResultTable.} );
			if ( rddlLocations.Items.Count ()!=ItemsPublic.AllNationality.Rows.Count )
			{
				rddlLocations.Items.Clear();
				for (int index = 0; index < ItemsPublic.AllNationality.Rows.Count; index++)
				{
					rddlLocations.Items.Add(((string) ItemsPublic.AllNationality.Rows[index]["Nationality_Name"]).Trim());
				}
			}
		}
		public void setItem(string InLoc)
		{
			SetAllLocations ();
			foreach (var item in rddlLocations.Items)
			{
				if ( item.Text.Trim () == InLoc.Trim () )
					{
						rddlLocations.SelectedItem = item;
						return;
					}
			}
			rddlLocations.Text = InLoc.Trim ();
			rddlLocations.SelectedIndex = -1;
		}
		public string ReturnSaveIfNew()
		{
			if ( rddlLocations.SelectedIndex == -1 ||
				    rddlLocations.Text !=
				    rddlLocations.Items [rddlLocations.SelectedIndex].Text )
			{
				if (ItemsPublic.AllNationality.Rows.Cast<DataRow>().Any(item => item ["Nationality_Name"].ToString ().Trim () == rddlLocations.Text.Trim ()))
				{
					rddlLocations.Items.Add ( rddlLocations.Text.Trim () );
					return rddlLocations.Text.Trim ();
				}
				var objManager2 = new Manager ();
				var	Result = objManager2.ClsLocations_Nationality_insert ( rddlLocations.Text );
				if ( !Result.success )
				{
					ItemsPublic.Exeptor ( Result.Message );
				}
				//indexSelectLocation = ( int ) Result.ResultTable.Rows [0] ["Nationality_Id"];
				//rddlLocations.Items.Add ( ( string ) Result.ResultTable.Rows [0] ["Nationality_Name"] );
				ItemsPublic.AllNationality.Rows.Add ( Result.ResultTable.Rows [0] ["Nationality_Id"] , Result.ResultTable.Rows [0] ["Nationality_Name"] );
			}
			
			string temp = rddlLocations.Text.Trim();
			//SetAllLocations ();
           // this.rddlLocations.SelectedIndex = 
            setItem(temp);
            return temp;
		}
        public void setReportText(string txt)
        {
            rddlLocations.Text = txt;
        }
	}
}
