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
	public partial class UC_SearchGpOnline : UserControl
	{
		public UC_SearchGpOnline()
		{
			InitializeComponent();
		}

		public delegate void DelegateStatusAction();

		public event DelegateStatusAction eventEndSearch;

		private void rtbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			
            if (e.KeyCode == Keys.Enter)
			{
				rbtnSearch_Click(sender, e);
				return;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                rtbSearch.Text = "";
            }
		}

		internal DataTable Result
		{
			get { return result.ResultTable; }
			set
			{
				
			}
		}
		public void inFocus()
		{
			rtbSearch.Focus();
		}
		private OutputDatas result;
		 private void setRlblDesc()
		 {
		 	//return;
		 	rrbPackId.ForeColor = Color.Black;
			rrbGatePassId.ForeColor = Color.Black;
			rrbNationalCode.ForeColor = Color.Black;
			rlblHint.Visible=false;
			 if ( rrbPackId.IsChecked )
			 {
			 	//rlblDesc.Text = rrbPackId.Tag.ToString();
				 rrbPackId.ForeColor = Color.IndianRed;
			 }
			 else if ( rrbGatePassId.IsChecked )
			 {
				 rrbGatePassId.ForeColor = Color.IndianRed;
			 //	rlblDesc.Text = rrbGatePassId.Tag.ToString();
			 }
			 else if ( rrbNationalCode.IsChecked )
			 {
				 rrbNationalCode.ForeColor = Color.IndianRed;
			 	//rlblDesc.Text = rrbNationalCode.Tag.ToString();
			 }
             inFocus();
		 }
		private void rbtnSearch_Click(object sender, EventArgs e)
		{
			try
			{
                if (string.IsNullOrEmpty(rtbSearch.Text))
                {
                    return;
                }

                CursorWait();
				rlblHint.Visible = false;
				var objManager = new Manager();

				if (rrbPackId.IsChecked)
				{
					result = objManager.View_packages(false, null, null, null, null, null, null
                                                      , null, null, null, null, null, ConvertNumbers.Base36ToInt64(rtbSearch.Text.Trim().ToUpper()).ToString(), null, null, null, 3);
				}
				else if (rrbGatePassId.IsChecked)
				{
					result = objManager.View_packages(false, null, null, null, null, null, null
                                                      , null, null, null, null, null, null, ConvertNumbers.Base36ToInt64(rtbSearch.Text.Trim().ToUpper()).ToString(), null, null, 3);
				}
				else if (rrbNationalCode.IsChecked)
				{
					result = objManager.View_packages(false, null, null, null, null, null, null
                                                      , null, null, null, null, rtbSearch.Text.Trim(), null, null, null, null, 3);
				}
				if (result.success)
				{
					if ( result.ResultTable.Rows.Count>0 )
					{
						eventEndSearch();
					}else
					{
						rlblHint.Visible = true;
					}
					//MainRadGridView.DataSource = result.ResultTable;
					//	MainRadGridView.Enabled = true;
					//ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;
				}
				else
				{
					MessageBox.Show(result.Message);
				}
                inFocus();
                CursorDefault();
				//Person_NationalCode = uC_PacksSearch1.rmebNationalCode.Text.Trim ();
				//this.DialogResult = DialogResult.OK;
				//this.Close ();
			}
			catch (Exception ex)
			{
                inFocus();
                CursorDefault();
				ItemsPublic.ShowMessage(ex.Message);
			}
		}

		//private void rrbGatePassId_RegionChanged(object sender, EventArgs e)
		//{
		//    rlblDesc.Text = rrbGatePassId.IsChecked ? rrbGatePassId.Tag.ToString() : rlblDesc.Text;
		//}

		//private void rrbPackId_RegionChanged(object sender, EventArgs e)
		//{
		//    rlblDesc.Text = rrbPackId.IsChecked ? rrbPackId.Tag.ToString() : rlblDesc.Text;
		//}

		//private void rrbNationalCode_RegionChanged(object sender, EventArgs e)
		//{
		//    rlblDesc.Text = rrbNationalCode.IsChecked ? rrbNationalCode.Tag.ToString() : rlblDesc.Text;
		//}

		private void rtbSearch_TextChanged( object sender , EventArgs e )
		{
			rlblHint.Visible = false;
		}

		private void rrbPackId_ToggleStateChanged( object sender , Telerik.WinControls.UI.StateChangedEventArgs args )
		{
			setRlblDesc ();
		}

		private void rrbGatePassId_ToggleStateChanged( object sender , Telerik.WinControls.UI.StateChangedEventArgs args )
		{
			setRlblDesc ();
		}

		private void rrbNationalCode_ToggleStateChanged( object sender , Telerik.WinControls.UI.StateChangedEventArgs args )
		{
			setRlblDesc ();
            
		}


        protected void CursorWait()
        {
            this.UseWaitCursor = true;
            this.Cursor = Cursors.WaitCursor;
        }

        protected void CursorDefault()
        {
            this.UseWaitCursor = false;
            this.Cursor = Cursors.Default;
        }



	}
}
