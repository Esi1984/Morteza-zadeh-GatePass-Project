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

namespace aorc.gatepass
{
	public partial class frm_GlobalSetting : Form
	{
		public frm_GlobalSetting()
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

		private bool QuestionSureToEdit()
		{

			var dr = MessageBox.Show("آیا قصد اعمال تنظیمات جدید به سامانه را دارید؟", "هشدار", MessageBoxButtons.YesNo,
			                         MessageBoxIcon.Question);
			return dr == DialogResult.Yes;
		}

		private void cbbSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (QuestionSureToEdit())
				{
					var listSets = new List<int>();
					listSets.Add((uC_globalSettings1.rcbGlobalActive.Checked) ? 1 : 0);
					listSets.Add((uC_globalSettings1.rcbPrintWithPictureAllowed.Checked ? 1 : 0));
					listSets.Add((uC_globalSettings1.rcbPrintWithoutPictureAllowed.Checked ? 1 : 0));
					listSets.Add((uC_globalSettings1.rcbPrintAgainGpAllowed.Checked ? 1 : 0));
					listSets.Add((uC_globalSettings1.rcbNewRequestPackGPAllowed.Checked ? 1 : 0));
					//listSets.Add(int.Parse(uC_globalSettings1.rmebCountTeaching.Text));
				//	listSets.Add(int.Parse(uC_globalSettings1.rmebCountGuest.Text));
					//listSets.Add(int.Parse(uC_globalSettings1.rmebCountTrainee.Text));
				//	listSets.Add(int.Parse(uC_globalSettings1.rmebCountCompany.Text));
				//	listSets.Add(int.Parse(uC_globalSettings1.rmebCountAgree.Text));
				//	listSets.Add(int.Parse(uC_globalSettings1.rmebCountTempWork.Text));
					listSets.Add ( int.Parse ( uC_globalSettings1.rmebGpDelayTime.Text ) );
                    listSets.Add((uC_globalSettings1.rcbAllowDigitSign.Checked ? 1 : 0));
					result = objManager.ClsGlobalSetting_update(listSets.AsEnumerable());
					if (result.success)
					{
						MessageBox.Show("تنظیمات سامانه مجوز تردد بروز شد");
						this.DialogResult = DialogResult.OK;
						this.Close();
					}
					else
					{
						MessageBox.Show(result.Message);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				//this.Close();
			}
		}

		private void cbbCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void ShowProperties()
		{
			uC_globalSettings1.rcbGlobalActive.Checked = int.Parse(result.ResultTable.Rows[0][0].ToString().Trim()) == 1;
			uC_globalSettings1.rcbPrintWithPictureAllowed.Checked = int.Parse(result.ResultTable.Rows[1][0].ToString().Trim()) ==
			                                                        1;
			uC_globalSettings1.rcbPrintWithoutPictureAllowed.Checked =
				int.Parse(result.ResultTable.Rows[2][0].ToString().Trim()) == 1;
			uC_globalSettings1.rcbPrintAgainGpAllowed.Checked = int.Parse(result.ResultTable.Rows[3][0].ToString().Trim()) == 1;
			uC_globalSettings1.rcbNewRequestPackGPAllowed.Checked = int.Parse(result.ResultTable.Rows[4][0].ToString().Trim()) ==
			                                                        1;
		//	uC_globalSettings1.rmebCountTeaching.Text = result.ResultTable.Rows[5][0].ToString().Trim();
		//	uC_globalSettings1.rmebCountGuest.Text = result.ResultTable.Rows[6][0].ToString().Trim();
		//	uC_globalSettings1.rmebCountTrainee.Text = result.ResultTable.Rows[7][0].ToString().Trim();
		//	uC_globalSettings1.rmebCountCompany.Text = result.ResultTable.Rows[8][0].ToString().Trim();
		//	uC_globalSettings1.rmebCountAgree.Text = result.ResultTable.Rows[9][0].ToString().Trim();
		//	uC_globalSettings1.rmebCountTempWork.Text = result.ResultTable.Rows[10][0].ToString().Trim();
			uC_globalSettings1.rmebGpDelayTime.Text = result.ResultTable.Rows[11][0].ToString().Trim();
            uC_globalSettings1.rcbAllowDigitSign.Checked = int.Parse(result.ResultTable.Rows[12][0].ToString().Trim()) == 1;
		}

		private void frm_GlobalSetting_Load(object sender, EventArgs e)
		{
			try
			{
				result = objManager.ClsGlobalSetting_View();
				if (result.success)
				{
					ShowProperties();
				}
				else
				{
					ItemsPublic.ShowMessage(result.Message);
				}
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message);
			}
		}

	}
}
