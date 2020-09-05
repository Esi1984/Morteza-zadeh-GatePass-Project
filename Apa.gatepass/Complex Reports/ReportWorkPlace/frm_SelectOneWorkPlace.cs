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
using aorc.gatepass.Complex_Reports.Uc_Mini;

namespace aorc.gatepass.Complex_Reports.ReportWorkPlace
{
	public partial class frm_SelectOneWorkPlace : Form
	{
        public clsReportCase objWorkPlace = new clsReportCase();        
		public frm_SelectOneWorkPlace()
		{
			try
			{
				InitializeComponent();
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message);				
				this.Close();
			}
		}

		private Manager objManager = new Manager();
		private OutputDatas result = new OutputDatas();
		private string masir;
		private int? IdTa;

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
			try
			{
				result = objManager.View_travelAreas ( myStr );
				if ( result.success )
				{
					MainRadGridView.DataSource = result.ResultTable;
					MainRadGridView.Enabled = true;
					setTreeView ();
				}
				else
				{
					MessageBox.Show ( result.Message );
				}
			}
			catch ( Exception ex )
			{
				ItemsPublic.ShowMessage ( ex.Message );
				this.Close ();
			}
		}

		private void rtbSearchPerson_TextChanged(object sender, EventArgs e)
		{
			if (rtbSearch.Text.Trim().Count() > 1)
			{
				FindInfo(rtbSearch.Text.Trim());
			}
		}

		public string MyArea(int? Value)
		{
			int? temp = null;
			//string str = string.Empty;
			if (Value != null)
			{
                var item = MainRadGridView.Rows.Single(x => (int)x.Cells["TravelArea_Id"].Value == Value);
                string str3 = item.Cells["TravelArea_ParentId"].Value.ToString();
				temp = (str3 != string.Empty) ? int.Parse(str3) : (int?) null;
                string str1 = item.Cells["TravelArea_Name"].Value.ToString().Trim();
				string str2 = MyArea(temp);

                if (str2 != string.Empty)
                {
                    str2 += " > " + str1;
                }
                else
                {
                    str2 = str1;
                }

                return (str2);
                                               
			}
            return string.Empty;
		}

		private void cbbSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (uC_TreeOffices1.radTreeView1.SelectedNode != null)
				{
                    
					IdTa = (int) uC_TreeOffices1.radTreeView1.SelectedNode.Value;
                    var oo = MainRadGridView.Rows.Single(x => (int)x.Cells["TravelArea_Id"].Value == IdTa);
                    objWorkPlace.SelectedCase.ID = (decimal)(int)oo.Cells["TravelArea_Id"].Value;
                    objWorkPlace.SelectedCase.Fname = MyArea(IdTa);
					//masir = MyArea(IdTa);
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
                MessageBox.Show(ex.Message);
                objWorkPlace.CurrentCase = null;
				//this.Close();
			}
		}

		private void cbbCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void frm_SelectArea_Load(object sender, EventArgs e)
		{
			//State = false;
			IdTa = null;
            uC_TreeOffices1.radTreeView1.ChildMember = MainRadGridView.Columns["TravelArea_Id"].Name;
            uC_TreeOffices1.radTreeView1.ParentMember = MainRadGridView.Columns["TravelArea_ParentId"].Name;
            uC_TreeOffices1.radTreeView1.DisplayMember = MainRadGridView.Columns["TravelArea_Name"].Name;
            uC_TreeOffices1.radTreeView1.ValueMember = MainRadGridView.Columns["TravelArea_Id"].Name;
			FindInfo(null);
			
			//	this.DialogResult = DialogResult.Cancel;
		}
		private void setTreeView() 
		{
			//   MainRadGridView.CurrentRow = null;
			uC_TreeOffices1.radTreeView1.DataSource = null;
			uC_TreeOffices1.radTreeView1.DataSource = MainRadGridView.DataSource;
			uC_TreeOffices1.radTreeView1.ExpandAll();
			//    setTree();
			//byte temp = OnTree;
			//	OnTree = 2;
			if ( uC_TreeOffices1.radTreeView1.Nodes.Count>0)
				uC_TreeOffices1.radTreeView1.SelectedNode = uC_TreeOffices1.radTreeView1.Nodes[0];
			//	OnTree = temp;
			//  uC_TreeOffices1.radTreeView1.Refresh();
		}		

		private void uC_TreeOffices1_eventSelectedNodeChanged()
		{

		}

		private void uC_TreeOffices1_DoubleClick( object sender , EventArgs e )
		{
			cbbSave_Click(sender, e);
		}

        private void cbbNoChoice_Click(object sender, EventArgs e)
        {
             try
            {
                objWorkPlace.CurrentCase = null;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
            }
        }

        private void rtbSearch_TextChanged(object sender, EventArgs e)
        {
            if (rtbSearch.Text.Trim().Count() > 1)
            {
                FindInfo(rtbSearch.Text.Trim());
            }
        }

        private void frm_SelectOneWorkPlace_Shown(object sender, EventArgs e)
        {
            rtbSearch.Focus();
        }

	}
}
