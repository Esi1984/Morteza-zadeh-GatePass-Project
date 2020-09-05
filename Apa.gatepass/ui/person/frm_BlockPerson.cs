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

namespace aorc.gatepass.ui.person
{
	public partial class frm_BlockPerson : Form
	{
		public decimal? currentPersonId;
		public bool? currentIsBlack;

		public frm_BlockPerson()
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

		private void cbbSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(uC_BlackListDetails1.rddlBLReasonType.Text))
				{
					ItemsPublic.ShowMessage("دلیل وارد نشده است");
					return;
				}
				int? IndexBLRSelected = null;
				if (uC_BlackListDetails1.rddlBLReasonType.SelectedIndex == -1 ||
				    uC_BlackListDetails1.rddlBLReasonType.Text !=
				    uC_BlackListDetails1.rddlBLReasonType.Items[uC_BlackListDetails1.rddlBLReasonType.SelectedIndex].Text)
				{
					var result = objManager.ClsBlack_BLR_insert(uC_BlackListDetails1.rddlBLReasonType.Text, string.Empty);
					if (!result.success)
					{
						ItemsPublic.ShowMessage(result.Message);
						this.DialogResult = DialogResult.Cancel;
						return;
					}
					IndexBLRSelected = (int) result.ResultTable.Rows[0]["BLReason_ID"];
				}
				else
				{
					IndexBLRSelected = uC_BlackListDetails1.indexBLR;
				}
				var result2 = objManager.ClsBlack_BL_insert
					(currentPersonId, null, IndexBLRSelected, uC_BlackListDetails1.tbDescriptions.Text, !currentIsBlack);
				if (!result2.success)
				{
					ItemsPublic.ShowMessage(result2.Message);
					this.DialogResult = DialogResult.Cancel;
					return;
				}
				ItemsPublic.ShowMessage("عملیات تغییر وضعیت فرد مورد نظر با موفقیت انجام شد");
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				this.Close();
			}
		}

		private void cbbCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void frm_BlockPerson_Load(object sender, EventArgs e)
		{
			if(currentIsBlack==true)
			{
				uC_BlackListDetails1.rgbBlackList.Text = "جهت عادی کردن وضعیت فرد انتخابی";
			}else if (currentIsBlack==false)
			{
				uC_BlackListDetails1.rgbBlackList.Text = "جهت مسدود کردن فرد انتخابی";
			}else
			{
				ItemsPublic.Exeptor("وضعیت جاری نا مشخص می باشد");
			}
			uC_BlackListDetails1.SetAllTypeBLReasons();
			OutputDatas result = new OutputDatas();
			result = objManager.View_blackLists(currentPersonId);
			if (!result.success)
			{
				ItemsPublic.ShowMessage(result.Message);
				return;
			}
			radGridView1.DataSource = result.ResultTable;
			for ( int i=0;i<radGridView1.Rows.Count();i++ )
			{
				var str = radGridView1.Rows [i].Cells ["BlackList_DateTime"].Value.ToString ().Trim();
				var dtItem = DateTime.Parse (str);
			//	MessageBox.Show ( result.ResultTable.Rows [i] ["BlackList_DateTime"].ToString() );
			//	MessageBox.Show ("item:  "+ dtItem.ToString() );
				radGridView1.Rows [i].Cells ["BlackList_dtFarsiLabel"].Value = ItemsPublic.GetPersianDate ( dtItem );
				radGridView1.Rows[i].Cells["BlackList_isBalckLabel"].Value =
				( bool ) radGridView1.Rows [i].Cells ["BlackList_isBlack"].Value ? "مسدود" : "عادی";

                //radGridView1.Rows[i].Cells["BLReason_Desc"].Value = 
			}
		}

		//private string convertDate(DateTime dt)
//{
	
//}

	}
}
