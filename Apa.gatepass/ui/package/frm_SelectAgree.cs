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
    public partial class frm_SelectAgree : Form
    {
		public frm_SelectAgree()
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
    	//public bool State;
		public string number;
    	public string title;
    	public string company;
    	public string currentId;
		public string countCarDesc;
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
            	result = objManager.View_agreements(null, null, null, null, null, null, null, null, myStr);

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

		//private void rtbSearchPerson_TextChanged(object sender, EventArgs e)
		//{
		//    FindInfo(rtbSearch.Text);
		//}

        private void cbbSave_Click(object sender, EventArgs e)
        {
			try
			{
				if (radGridViewSearch.SelectedRows.Count == 1)
				{
					//eventSaveTiny();
					//State = true;
					number = radGridViewSearch.CurrentRow.Cells ["Agreement_Number"].Value.ToString ();
					title = radGridViewSearch.CurrentRow.Cells["Agreement_Title"].Value.ToString();
					company = radGridViewSearch.CurrentRow.Cells["Agreement_Company"].Value.ToString();
					currentId = radGridViewSearch.CurrentRow.Cells ["Agreement_ID"].Value.ToString ();
					countCarDesc = ItemsPublic.HowManyCarInAgree(decimal.Parse(currentId ));
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

		private void frm_SelectAgree_Load(object sender, EventArgs e)
		{
			//State = false;
			//this.DialogResult = DialogResult.Cancel;
		}

		private void radGridViewSearch_DoubleClick( object sender , EventArgs e )
		{
			cbbSave_Click ( sender , e );
		}

		private void rbtnSearch_Click( object sender , EventArgs e )
		{
			FindInfo ( rtbSearch.Text.Trim());
		}

		private void rtbSearch_KeyDown( object sender , KeyEventArgs e )
		{
			if ( e.KeyCode==Keys.Enter )
			{
				rbtnSearch_Click ( sender , e );
			}
		}

		private void frm_SelectAgree_Shown( object sender , EventArgs e )
		{
			rtbSearch.Focus();
		}

	
      
    }
}
