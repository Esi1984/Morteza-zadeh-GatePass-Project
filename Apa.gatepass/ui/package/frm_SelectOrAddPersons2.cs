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
    public partial class frm_SelectOrAddPersons2 : Form
    {
        public frm_SelectOrAddPersons2()
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
    	public bool State;
		protected bool CheckOneSelectedRow(int countSelectedRows)
		{
			if (countSelectedRows != 1)
			{
				MessageBox.Show(ItemsPublic._infoSelRow);
				return false;
			}
			return true;
		}
        private void FindInfo(string myStr)
        {
            radGridViewSearch.DataSource = null;
            if (myStr.Count() > 2)
            {
                result = objManager.View_persons(null, null, null, false, null, null, null,null,null,null, myStr);
                if (result.success)
                {
                    radGridViewSearch.DataSource = result.ResultTable;
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
        }

        private void rtbSearchPerson_TextChanged(object sender, EventArgs e)
        {
            FindInfo(rtbSearchPerson.Text);
        }

        private void cbbSelect_Click(object sender, EventArgs e)
        {
			try
			{
				if (CheckOneSelectedRow(radGridViewSearch.SelectedRows.Count))
				{
					if (radGridViewSearch.CurrentRow != null)
					{
						var value =(decimal) radGridViewSearch.CurrentRow.Cells["Person_ID"].Value;
						var query = radGridViewSelected.Rows.Where(x => (decimal)x.Cells["Person_ID"].Value == value);
						if (query.Count()==0)
						{
							radGridViewSelected.Rows.AddNew();
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
							for (int index = 0; index < radGridViewSearch.Columns.Count; index++)
							{
								//col = "";
								//result.ResultTable.Rows[0][col.ColumnName];
								radGridViewSelected.CurrentRow.Cells[index].Value = radGridViewSearch.CurrentRow.Cells[index].Value;
							}
						}
					}
					//return;
				}
				//MainRadGridView.Enabled = false;
				//objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toEdit);
				// //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toEdit;
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message);
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}
        }

        private void cbbUnSelect_Click(object sender, EventArgs e)
        {
			try
			{
				if (CheckOneSelectedRow(radGridViewSelected.SelectedRows.Count))
				{
					if (radGridViewSelected.CurrentRow != null)
					{
						//GridViewRowInfo gvrInfo = radGridViewSearch.SelectedRows[0];
						radGridViewSelected.CurrentRow.Delete();
						//radGridViewSelected.CurrentRow = radGridViewSearch.SelectedRows[0];
					}
					//return;
				}
				//MainRadGridView.Enabled = false;
				//objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toEdit);
				// //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toEdit;
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message);
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}
        }

        private void cbbSave_Click(object sender, EventArgs e)
        {
        	State = true;

			this.Close();
        }

        private void cbbCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }

		private void frm_SelectOrAddPersons2_Load(object sender, EventArgs e)
		{
			State = false;
		}

		private void radGridViewSearch_DoubleClick( object sender , EventArgs e )
		{
			cbbSelect_Click(sender, e);
		}

		private void radGridViewSelected_DoubleClick( object sender , EventArgs e )
		{
			cbbUnSelect_Click(sender, e);
		}
      
    }
}
