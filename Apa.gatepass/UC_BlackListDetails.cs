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
	public partial class UC_BlackListDetails : UserControl
	{
		public UC_BlackListDetails()
		{
			InitializeComponent();
		}
		public int? indexBLR
		{
			get { return rddlBLReasonType.SelectedIndex>-1 ?( int? ) types.ResultTable.Rows [rddlBLReasonType.SelectedIndex] ["BLReason_ID"]:null; }
			set { rddlBLReasonType.SelectedIndex = value != null ?  SetrddlType ( ( int ) value ) : -1; }
		}
		OutputDatas types = new OutputDatas();
		private int SetrddlType( int type )
		{

			for ( int i = 0 ; i <  types.ResultTable.Rows.Count ; i++ )
			{
				if ( ( int ) types.ResultTable.Rows [i] ["BLReason_ID"] == type )
				{
					return i;
				}
			}

			ItemsPublic.Exeptor ( "دلیل لیست سیاه یافت نشد" );
			return -1;
		}
		public void SetAllTypeBLReasons()
		{
			Manager objManager2 = new Manager();
			//DtModels = null;
			//DtModels = new DataTable ();
			//DtModels.Columns.Add ( "VehicleType_ID" , typeof ( decimal ) );
			//DtModels.Columns.Add ( "VehicleType_Name" , typeof ( string ) );
			//DtModels.Columns.Add ( "VehicleType_Desc" , typeof ( string ) );
			//DtModels.Columns.Add ( "VehicleType_Hidden" , typeof ( bool ) );
			types = objManager2.View_bLreasons(null);
			if (!types.success)
			{
				ItemsPublic.Exeptor("خطا در بازآوری اطلاعات دلایل مسدود سازی");
			}
//	DtModels = types.ResultTable.Copy ();
			//foreach (var row in Models.ResultTable.Rows)
			//rddlBLReasonType.Items.AddRange ( new string [] { types.ResultTable.} );
			for (int index = 0; index < types.ResultTable.Rows.Count; index++)
			{
				rddlBLReasonType.Items.Add((string) types.ResultTable.Rows[index]["BLReason_Type"]);
			}
		}
	}
}
