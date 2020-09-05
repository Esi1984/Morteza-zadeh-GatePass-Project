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
	public partial class frm_PersonTempAdding : Form
	{
		public frm_PersonTempAdding()
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
		public OutputDatas result = new OutputDatas ();
		private void cbbSave_Click(object sender, EventArgs e)
		{
			try
			{

				bool idCodeValid;
				if (uC_PersonDetailsMini21.rmeIdentifyCode.Text.Trim() == string.Empty ||
				    uC_PersonDetailsMini21.rmeIdentifyCode.Text.Trim() == "0")
				{
					idCodeValid = false;
				}
				else
				{
					idCodeValid = true;
				}

				result = objManager.ClsPersons_insert(uC_PersonDetailsMini21.rtbName.Text.Trim(),
				                                      uC_PersonDetailsMini21.rtbSurname.Text.Trim(),
				                                      uC_PersonDetailsMini21.rmebNationalCode.Text.Trim(),
													  uC_PersonDetailsMini21.comboNationality.ReturnSaveIfNew () ,
				                                      uC_PersonDetailsMini21.rtbFatherName.Text.Trim(),
													  uC_PersonDetailsMini21.comboBirthCity.ReturnSaveIfNew () ,
				                                      (uC_PersonDetailsMini21.bdcBirthDate.SelectedDate != null)
				                                      	? uC_PersonDetailsMini21.bdcBirthDate.SelectedDate.Value
				                                      	: (DateTime?) null,
				                                      uC_PersonDetailsMini21.rmebLicenseDriveCode.Text.Trim(),
				                                      uC_PersonDetailsMini21.rmebPhone1.Text.Trim(),
				                                      uC_PersonDetailsMini21.rmebPhone2.Text.Trim(),
				                                      (uC_PersonDetailsMini21.rddlHaveForm.SelectedIndex == 0) ? true : false,
                                                      ((uC_PersonDetailsMini21.rddlsex.SelectedIndex == -1) ? (bool?)null : ((uC_PersonDetailsMini21.rddlsex.SelectedIndex == 1) ? true : false))
                                                      ,
				                                      uC_PersonDetailsMini21.comboRegisterCity.ReturnSaveIfNew()
				                                      , null,
				                                      (idCodeValid == true)
				                                      	? uC_PersonDetailsMini21.rmeIdentifyCode.Text.Trim()
				                                      	: string.Empty
				                                      , uC_PersonDetailsMini21.rtbRegisterCode.Text.Trim(),null);
				if (result.success)
				{
					//  eventClearProperiesItems();
					//objManager.EmptyControls ( myAll );
					ItemsPublic.ShowMessage(ItemsPublic._infoNew);
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					MessageBox.Show(result.Message);
				}

			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message);
				//	this.DialogResult = DialogResult.Cancel;
				//this.Close();
			}
		}

		private void cbbCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void frm_PersonTempAdding_Load(object sender, EventArgs e)
		{
			ItemsPublic.SetAllLocations ();
			uC_PersonDetailsMini21.comboBirthCity.SetAllLocations ();
			uC_PersonDetailsMini21.comboNationality.SetAllLocations ();
			uC_PersonDetailsMini21.comboRegisterCity.SetAllLocations ();
			uC_PersonDetailsMini21.rtbName.Focus ();
		}

		private void uC_packDetailsForNew1_eventTickVehicle()
		{

		}

		private void frm_PersonTempAdding_Shown( object sender , EventArgs e )
		{
			uC_PersonDetailsMini21.rtbName.Focus ();
		}

		


	}
}
