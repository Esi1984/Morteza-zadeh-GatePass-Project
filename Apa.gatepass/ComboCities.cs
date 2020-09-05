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
	public partial class ComboCities : UserControl
	{
		public ComboCities()
		{
			InitializeComponent();
		}
		//private int? indexSelectLocation
		//{
		//    get { return rddlLocations.SelectedIndex>-1 ?( int? ) ItemsPublic.AllCity.Rows [rddlLocations.SelectedIndex] ["City_Id"]:null; }
		//    set { rddlLocations.SelectedIndex = value != null ?  SetrddlLocation ( ( int ) value ) : -1; }
		//}
		//OutputDatas Result = new OutputDatas();
		private int SetrddlLocation( int inLocId )
		{

			for ( int i = 0 ; i <  ItemsPublic.AllCity.Rows.Count ; i++ )
			{
				if ( ( int ) ItemsPublic.AllCity.Rows [i] ["City_Id"] == inLocId )
				{
					return i;
				}
			}
			ItemsPublic.Exeptor ( "محل مورد نظر یافت نشد" );
			return -1;
		}
		public void SetAllLocations()
		{
			//Manager objManager2 = new Manager();
			////DtModels = null;
			////DtModels = new DataTable ();
			////DtModels.Columns.Add ( "VehicleType_ID" , typeof ( decimal ) );
			////DtModels.Columns.Add ( "VehicleType_Name" , typeof ( string ) );
			////DtModels.Columns.Add ( "VehicleType_Desc" , typeof ( string ) );
			////DtModels.Columns.Add ( "VehicleType_Hidden" , typeof ( bool ) );
			//Result = objManager2.View_Cities();
			//if (!Result.success)
			//{
			//    ItemsPublic.Exeptor("خطا در بازآوری اطلاعات شهرها");
			//}
			//	DtModels = types.ResultTable.Copy ();
			//foreach (var row in Models.ResultTable.Rows)
			//rddlBLReasonType.Items.AddRange ( new string [] { types.ResultTable.} );
		//	rddlLocations.DataSource = ItemsPublic.AllCity.Clone();
			//for (int index = 0; index < ItemsPublic.AllCity.Rows.Count; index++)
			//{
			//    rddlLocations.Items.Add ( ( ( string ) ItemsPublic.AllCity.Rows [index] ["City_Name"] ).Trim () );

			//}
			if ( rddlLocations.Items.Count ()!=ItemsPublic.AllCity.Rows.Count )
			{
				rddlLocations.Items.Clear();
				for (int index = 0; index < ItemsPublic.AllCity.Rows.Count; index++)
				{
					rddlLocations.Items.Add(((string) ItemsPublic.AllCity.Rows[index]["City_Name"]).Trim());
				}
			}
		}

		public void setItem( string InLoc )
		{
			SetAllLocations ();
			foreach ( var item in rddlLocations.Items )
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
            int indexCurrent = rddlLocations.SelectedIndex;
            if(! string.IsNullOrEmpty(rddlLocations.Text.Trim()))
			if ( rddlLocations.SelectedIndex == -1 ||
				    rddlLocations.Text !=
				    rddlLocations.Items [rddlLocations.SelectedIndex].Text )
			{
				if (ItemsPublic.AllCity.Rows.Cast<DataRow>().Any(item => item ["City_Name"].ToString ().Trim () == rddlLocations.Text.Trim ()))
				{
					rddlLocations.Items.Add ( rddlLocations.Text.Trim () );
					return rddlLocations.Text.Trim ();
				}
				var objManager2 = new Manager ();
				 var result = objManager2.ClsLocations_City_insert ( rddlLocations.Text.Trim());
				if ( !result.success )
				{
					ItemsPublic.Exeptor ( result.Message );
				}
				if(result.ResultTable!=null)
				{
					//indexSelectLocation = (int) result.ResultTable.Rows[0]["City_Id"];
					//rddlLocations.Items.Add((string) result.ResultTable.Rows[0]["City_Name"]);
					ItemsPublic.AllCity.Rows.Add ( result.ResultTable.Rows [0] ["City_Id"] , result.ResultTable.Rows [0] ["City_Name"] );
				}

			}
            
			string temp = rddlLocations.Text.Trim();
			//SetAllLocations ();
            setItem(temp);
            return temp;
		}

        public void setReportText(string txt)
        {
            rddlLocations.Text = txt;
        }

	}
}
