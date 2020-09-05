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
    public partial class frm_SelectOrAddPersons4 : Form
    {
        public frm_SelectOrAddPersons4()
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
        private void  EmptyProperty()
{
	rtbName.Text = "";
	rtbSurname.Text = "";
	rtbSex.Text = "";
}
        private void SetProperty(string name, string surName, string sex)
{
	rtbName.Text = name.Trim();
	rtbSurname.Text =surName.Trim ();
	rtbSex.Text = sex.Trim ();
}
        private void FindInfo(string myStr)
        {
        	EmptyProperty();
        	radGridViewSearch.DataSource = null;
        	if (myStr.Trim().Count() == 10)
        	{
        		result = objManager.View_persons(null, null, null, null, null, null, null,null,null,null, myStr);
        		if (result.success)
        		{
        			radGridViewSearch.DataSource = result.ResultTable;
        			if (radGridViewSearch.Rows.Count > 0)
        			{
        				SetProperty(radGridViewSearch.Rows[0].Cells["Person_Name"].Value.ToString()
        				            , radGridViewSearch.Rows[0].Cells["Person_Surname"].Value.ToString()
        				            , radGridViewSearch.Rows[0].Cells["Person_LabelIsWoman"].Value.ToString());
        			}
					else
        			{
                        if (ItemsPublic.IsDigitNumber(rtbSearchPerson.Text.Trim(), 10) && (ItemsPublic.NationalCodeIsTrue(rtbSearchPerson.Text.Trim())))
                        {
                            if (QuestionSureToAddNewUser())
                            {
                                var frm = new frm_PersonTempAdding();
                                frm.uC_PersonDetailsMini21.rmebNationalCode.Text = rtbSearchPerson.Text;
                                frm.ShowDialog();
                                if (frm.DialogResult == DialogResult.OK)
                                {
                                    radGridViewSelected.Rows.AddNew();
                                    foreach (DataColumn col in frm.result.ResultTable.Columns)
                                    {
                                        radGridViewSelected.CurrentRow.Cells[col.ColumnName].Value =
                                            frm.result.ResultTable.Rows[0][col.ColumnName];
                                    }
                                    radGridViewSelected.CurrentRow = null;
                                }
                                frm.Close();
                                rtbSearchPerson.Text = string.Empty;
                            }
                        }
                        else
                        {
                            MessageBox.Show("مقدار وارد شده جهت کد ملی نا معتبر می باشد");
                        }                        

						rtbSearchPerson.Focus ();

        			}
        		}
        		else
        		{
        			MessageBox.Show(result.Message);
        		}
        	}
        }

    	private bool QuestionSureToAddNewUser()
		{

			var dr = MessageBox.Show ( "فرد مورد نظر در سیستم یافت نشد"+"\n\n"+"آیا قصد افزودن اطلاعات شخص جدیدی را دارید؟" , "هشدار" , MessageBoxButtons.YesNo ,
									 MessageBoxIcon.Question );
			return dr == DialogResult.Yes;
		}
        private void rtbSearchPerson_TextChanged(object sender, EventArgs e)
        {
			if ( rtbSearchPerson.Text.Trim ().Count () > 10 )
			{
				rtbSearchPerson.Text = rtbSearchPerson.Text.Substring ( 0 , 10 );
			}
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
			this.DialogResult = DialogResult.OK;
			this.Close();
        }

        private void cbbCancel_Click(object sender, EventArgs e)
        {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
        }

		private void frm_SelectOrAddPersons4_Load(object sender, EventArgs e)
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

		private void rbtnSelectPerson_Click( object sender , EventArgs e )
		{
			cbbSelect_Click(sender, e);
			rtbSearchPerson.Text = string.Empty;
			rtbSearchPerson.Focus ();
		}

		private void rtbSearchPerson_Enter( object sender , EventArgs e )
		{
			rtbSearchPerson.SelectionStart = 0;
			rtbSearchPerson.SelectionLength = rtbSearchPerson.Text.Length;
		}

		private void frm_SelectOrAddPersons4_Shown( object sender , EventArgs e )
		{
			rtbSearchPerson.Focus ();
		}

		private void rbtnUnSelectPerson_Click( object sender , EventArgs e )
		{
			cbbUnSelect_Click ( sender , e );
		}

		private void rtbSearchPerson_KeyDown( object sender , KeyEventArgs e )
		{
			if(e.KeyCode==Keys.Enter)
			{
				rbtnSelectPerson_Click(sender, e);													 
				return;
			}
			ItemsPublic.checkText(sender, e, rtbSearchPerson.Text,10);
		}

    }
}
