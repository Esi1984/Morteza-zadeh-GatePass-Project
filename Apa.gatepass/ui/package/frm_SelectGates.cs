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
    public partial class frm_SelectGates : Form
    {
        public frm_SelectGates()
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

        Manager objManager = new Manager();
        private OutputDatas result = new OutputDatas();
    	
		protected bool CheckOneSelectedRow(int countSelectedRows)
		{
			if (countSelectedRows != 1)
			{
				MessageBox.Show(ItemsPublic._infoSelRow);
				return false;
			}
			return true;
		}
    

        private void cbbSave_Click(object sender, EventArgs e)
        {
        	this.DialogResult = DialogResult.OK;
			this.Close();
        }

        private void cbbCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }

		private void frm_SelectGates_Load(object sender, EventArgs e)
		{
			result = objManager.View_Gates(null);
			if ( result.success )
			{
				radGridViewSearch.DataSource = result.ResultTable;
				if (CurrentInfo != null)
					foreach (int item in CurrentInfo)
					{
						radGridViewSelected.Rows.AddNew();
						GridViewRowInfo FindRow = radGridViewSearch.Rows.Single ( x => ( int ) x.Cells ["Gate_Id"].Value == item );
						for ( int index = 0 ; index < radGridViewSearch.Columns.Count ; index++ )
						{
							//col = "";
							//result.ResultTable.Rows[0][col.ColumnName];
							radGridViewSelected.CurrentRow.Cells [index].Value = FindRow.Cells [index].Value;
						}
					}
			}
			else
			{
				MessageBox.Show ( result.Message );
				this.Close();
			}
		}


		private void rbtnSelectGate_Click( object sender , EventArgs e )
		{
			try
			{
				if ( CheckOneSelectedRow ( radGridViewSearch.SelectedRows.Count ) )
				{
					if ( radGridViewSearch.CurrentRow != null )
					{
						var value =int.Parse(radGridViewSearch.CurrentRow.Cells ["Gate_Id"].Value.ToString());
						var query = radGridViewSelected.Rows.Where ( x => int.Parse( x.Cells ["Gate_Id"].Value.ToString()) == value );
						if ( query.Count ()==0 )
						{
							radGridViewSelected.Rows.AddNew ();
							//radGridViewSelected.CurrentRow.Cells[""].Value = radGridViewSearch.CurrentRow.Cells[""].Value;
							//radGridViewSelected.CurrentRow.Cells[""].Value = radGridViewSearch.CurrentRow.Cells[""].Value;
							//radGridViewSelected.CurrentRow.Cells[""].Value = radGridViewSearch.CurrentRow.Cells[""].Value;
							//radGridViewSelected.CurrentRow.Cells[""].Value = radGridViewSearch.CurrentRow.Cells[""].Value;
							//radGridViewSelected.CurrentRow.Cells[""].Value = radGridViewSearch.CurrentRow.Cells[""].Value;
							//radGridViewSelected.CurrentRow.Cells[""].Value = radGridViewSearch.CurrentRow.Cells[""].Value;
							//radGridViewSelected.CurrentRow.Cells[""].Value = radGridViewSearch.CurrentRow.Cells[""].Value;
							//radGridViewSelected.CurrentRow.Cells[""].Value = radGridViewSearch.CurrentRow.Cells[""].Value;
							//radGridViewSelected.CurrentRow.Cells[""].Value = radGridViewSearch.CurrentRow.Cells[""].Value;
							//radGridViewSelected.CurrentRow.Cells[""].Value = radGridViewSearch.CurrentRow.Cells[""].Value;
							//radGridViewSelected.CurrentRow.Cells[""].Value = radGridViewSearch.CurrentRow.Cells[""].Value;
							//radGridViewSelected.CurrentRow.Cells[""].Value = radGridViewSearch.CurrentRow.Cells[""].Value;

							//radGridViewSelected.CurrentRow = radGridViewSearch.SelectedRows[0].;]
							for ( int index = 0 ; index < radGridViewSearch.Columns.Count ; index++ )
							{
								//col = "";
								//result.ResultTable.Rows[0][col.ColumnName];
								radGridViewSelected.CurrentRow.Cells [index].Value = radGridViewSearch.CurrentRow.Cells [index].Value;
							}
						}
					}
					//return;
				}
				//MainRadGridView.Enabled = false;
				//objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toEdit);
				// //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toEdit;
			}
			catch ( Exception ex )
			{
				ItemsPublic.ShowMessage ( ex.Message );
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}
		}

		private void rbtnUnSelectGate_Click( object sender , EventArgs e )
		{
			try
			{
				if ( CheckOneSelectedRow ( radGridViewSelected.SelectedRows.Count ) )
				{
					if ( radGridViewSelected.CurrentRow != null )
					{
						//GridViewRowInfo gvrInfo = radGridViewSearch.SelectedRows[0];
						radGridViewSelected.CurrentRow.Delete ();
						//radGridViewSelected.CurrentRow = radGridViewSearch.SelectedRows[0];
					}
					//return;
				}
				//MainRadGridView.Enabled = false;
				//objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toEdit);
				// //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toEdit;
			}
			catch ( Exception ex )
			{
				ItemsPublic.ShowMessage ( ex.Message );
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}
		}

    	private List<int> CurrentInfo = new List<int>();
		internal void SetInfo( List<int> CurrentGates )
		{
			CurrentInfo = CurrentGates;
		}

        private void radGridViewSearch_Click(object sender, EventArgs e)
        {
            rbtnSelectGate_Click(sender, e);
        }

        private void radGridViewSelected_Click(object sender, EventArgs e)
        {
            rbtnUnSelectGate_Click(sender, e);
        }
	}
}
