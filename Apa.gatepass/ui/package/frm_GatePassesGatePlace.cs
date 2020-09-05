using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI;
using ServerClasses;
using Telerik.WinControls;
using aorc.gatepass.Reports;

namespace aorc.gatepass.ui.package
{
	public partial class frm_GatePassesGatePlace : Form
	{

		// public event DelegateStatusAction eventClearProperiesItems;
		//  public event DelegateStatusAction eventShowPropertiesItems;
		private decimal? CurrentDriverId;
		public bool isNew;
		protected Manager objManager;
		//public RadGridView MainRadGridView { get; set; }
		public OutputDatas result = new OutputDatas();
		protected List<object> myNew;
		protected List<object> myEdit;
		protected List<object> mySearch;
		protected List<object> myDelete;
		protected List<object> myView;
		protected List<object> myAll;
		private OutputDatas Models;
		public ItemsPublic.IndexStatus pmStatus;
		public decimal? IndexPack;
		public RadGridView rgvPack { get; set; }
		public bool IsnewRowAdded = false;
		//public GridViewRowInfo detailsPack;
		private void rightsEnableControls()
		{
			v01_uC_packDetailsGatePlace1.rbtnAgree.Enabled = v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex < 2 &&
			                                             cbbSave.Enabled;

			if (pmStatus == ItemsPublic.IndexStatus.toNew)
			{
				cbbConfirm.Enabled = false;
				cbbNoConfirm.Enabled = false;
				cbbPassage.Enabled = false;
				cbbNoPassage.Enabled = false;
				cbbCollectPrint.Enabled = false;
				cbbOnePrint.Enabled = false;
				cbbSecureForm.Enabled = false;
				cbbView.Enabled = false;
				//return;
			}
			else
			{
				switch ((AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value)
				{
					case AllFunctions._StatusPack.Create:
						//cbbSaveTo.Enabled=false;
						//cbbRequest.Enabled=false;
						cbbConfirm.Enabled = false;
						cbbNoConfirm.Enabled = false;
						cbbPassage.Enabled = false;
						cbbNoPassage.Enabled = false;
						cbbCollectPrint.Enabled = false;
						cbbOnePrint.Enabled = false;

						break;
					case AllFunctions._StatusPack.Request:
						//	cbbConfirm.Enabled = false;
						//	cbbNoConfirm.Enabled = false;
						cbbSaveTo.Enabled = false;
						cbbRequest.Enabled = false;
						cbbPassage.Enabled = false;
						cbbNoPassage.Enabled = false;
						cbbEdit.Enabled = false;
						cbbNew.Enabled = false;
						cbbSecureForm.Enabled = false;
						cbbCollectPrint.Enabled = false;
						cbbOnePrint.Enabled = false;
						break;
					case AllFunctions._StatusPack.Confirm:
						cbbSaveTo.Enabled = false;
						cbbRequest.Enabled = false;
						cbbConfirm.Enabled = false;
						cbbNoConfirm.Enabled = false;
						cbbEdit.Enabled = false;
						cbbNew.Enabled = false;
						cbbSecureForm.Enabled = false;
						cbbCollectPrint.Enabled = false;
						cbbOnePrint.Enabled = false;
						//	cbbPassage.Enabled = false;
						//	cbbNoPassage.Enabled = false;
						break;
					case AllFunctions._StatusPack.NoConfirm:
						cbbConfirm.Enabled = false;
						cbbNoConfirm.Enabled = false;
						cbbPassage.Enabled = false;
						cbbNoPassage.Enabled = false;
						cbbCollectPrint.Enabled = false;
						cbbOnePrint.Enabled = false;
						break;
					case AllFunctions._StatusPack.Passage:
						cbbEdit.Enabled = false;
						cbbNew.Enabled = false;
						//cbbSecureForm.Enabled=false;
						cbbSaveTo.Enabled = false;
						cbbRequest.Enabled = false;
						cbbConfirm.Enabled = false;
						cbbNoConfirm.Enabled = false;
						cbbPassage.Enabled = false;
						cbbNoPassage.Enabled = false;
						break;
					case AllFunctions._StatusPack.NoPassage:
						cbbConfirm.Enabled = false;
						cbbNoConfirm.Enabled = false;
						cbbPassage.Enabled = false;
						cbbNoPassage.Enabled = false;
						cbbCollectPrint.Enabled = false;
						cbbOnePrint.Enabled = false;
						break;
				}

			}

			//if ( rgvPack.CurrentRow.Cells ["package_Id"].Value == null 
			//||  ( int? ) rgvPack.CurrentRow.Cells ["package_Id"].Value==-1 )
			//{
			//      cbbSecureForm.Enabled=false;
			//} 
			if (v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked && cbbEdit.Enabled)
			{
				cbbDriver.Enabled = true;
			}
			else
			{
				cbbDriver.Enabled = false;
			}
			rightCbbDriver.Enabled = cbbDriver.Enabled;
			rightCbbSecure.Enabled = cbbSecureForm.Enabled;
			rightCbbEdit.Enabled = cbbEdit.Enabled;
			rightCbbNew.Enabled = cbbNew.Enabled;
			rightCbbOnePrint.Enabled = cbbOnePrint.Enabled;
		}

		private void eventStatusNew()
		{
		}

		private void eventStatusEdit()
		{
		}

		private void eventStatusSearch()
		{
		}

		private void eventStatusView()
		{

		}

		private void eventStatusDelete()
		{
		}

		private void eventSaveToDelete()
		{
		}

		private void eventSaveToEdit()
		{
		}

		private void eventSaveToNew()
		{
		}

		private void eventSaveToView()
		{
			result = objManager.View_gatePasses(IndexPack);
		}

		private void eventAfterSave()
		{
		}

		private void eventSaveToSearch()
		{
		}

		//private void SetModelsCar()
		//{
		//    Models = null;
		//    Models = new OutputDatas();
		//    Models = objManager.View_vehiclesType(null);
		//    if (!Models.success)
		//    {
		//        ItemsPublic.Exeptor("خطا در بازآوری اطلاعات انواع خودرو");
		//    }

		//}

		public void setItemsPack(ref RadGridView rgvInput)
		{
			rgvPack = rgvInput;
		}

		private void setMenuForPakcManager()
		{
			cbbView.Text = "بازآوری لیست افراد";
			cbbNew.Text = "افزودن شخص";
			cbbEdit.Text = "بروزرسانی مشخصات بسته";
			cbbDriver.Text = "جستجوی افراد";
		}

		protected void setMenuForPakcs()
		{
			rmiStatusEdit.Visibility = ElementVisibility.Hidden;
			rmiStatusNew.Visibility = ElementVisibility.Hidden;
			//  cbbView.Text = "بازآوری لیست افراد";
			// cbbNew.Text = "افزودن شخص";
			//   cbbEdit.Text = "بروزرسانی مشخصات بسته";
			//  cbbSearch.Text = "جستجوی افراد";
		}

		protected RadItemCollection findRadItems()
		{
			var ric = new RadItemCollection();
			ric.AddRange(cbbCancel, cbbCollectPrint, cbbEdit, cbbNew, cbbOnePrint, cbbSave, cbbDriver, cbbView, cbbSaveTo,
			             cbbConfirm,
			             cbbNoConfirm, cbbPassage, cbbNoPassage, cbbRequest);
			ric.AddRange(rmiCancel, rmiCopy, rmiCut, rmiHelp2, rmiPaste, rmiSave, rmiCollectPrint, rmiStatusEdit,
			             rmiStatusExit, rmiStatusNew, rmiOnePrint, rmiDriver, rmiStatusSettingPrint,
			             rmiStatusView);
			ric.AddRange(rightCbbSecure, rightCbbDriver, rightCbbEdit, rightCbbExit, rightCbbNew, rightCbbOnePrint, rightCbbView);


			this.rightCbbView.Tag = cbbView.Tag;
			this.rightCbbNew.Tag = cbbNew.Tag;
			this.rightCbbEdit.Tag = cbbEdit.Tag;
			this.rightCbbDriver.Tag = cbbDriver.Tag;
			this.rightCbbOnePrint.Tag = cbbOnePrint.Tag;
			this.rightCbbExpire.Tag = cbbExpire.Tag;

			rmiCancel.Tag = cbbCancel.Tag;
			// rmiCopy.Tag = cbbCopy.Tag;
			// rmiCut.Tag = cbbCut.Tag;
			rmiCollectPrint.Tag = cbbCollectPrint.Tag;
			rmiStatusEdit.Tag = cbbEdit.Tag;
			rmiStatusNew.Tag = cbbNew.Tag;
			//   rmiPaste.Tag = cbbPaste.Tag;
			rmiOnePrint.Tag = cbbOnePrint.Tag;
			rmiStatusSettingPrint.Tag = cbbOnePrint.Tag;
			rmiSave.Tag = cbbSave.Tag;
			rmiDriver.Tag = cbbDriver.Tag;
			rmiStatusView.Tag = cbbView.Tag;


			rmiCancel.Text = cbbCancel.Text.Trim();
			rmiCollectPrint.Text = cbbCollectPrint.Text.Trim();
			rmiStatusEdit.Text = cbbEdit.Text.Trim();
			rmiStatusNew.Text = cbbNew.Text.Trim();
			rmiOnePrint.Text = cbbOnePrint.Text.Trim();
			//rmiStatusSettingPrint.Text = cbbCollectPrint.Text.Trim();
			rmiSave.Text = cbbSave.Text.Trim();
			rmiDriver.Text = cbbDriver.Text.Trim();
			rmiStatusView.Text = cbbView.Text.Trim();


			rmiCancel.Image = cbbCancel.Image;
			rmiCollectPrint.Image = cbbCollectPrint.Image;
			rmiStatusEdit.Image = cbbEdit.Image;
			rmiStatusNew.Image = cbbNew.Image;
			rmiOnePrint.Image = cbbOnePrint.Image;
			//rmiStatusSettingPrint.Image = cbbCollectPrint.Image;
			rmiSave.Image = cbbSave.Image;
			rmiDriver.Image = cbbDriver.Image;
			rmiStatusView.Image = cbbView.Image;


			return ric;
			//foreach (var vv in ric)
			//{
			//    if (vv is RadItem)
			//    {
			//        //vv.BackColor = Color.Red;
			//        vv.Enabled = false;
			//    }
			//}
		}

		private void SetPicIfHaveRight()
		{
			if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPersons_update) &&
			    pmStatus != ItemsPublic.IndexStatus.toNew)
			{
				uC_ViewPersonDetails1.rbtnImage.Tag = "advens";
				uC_ViewPersonDetails1.rbtnImage.Enabled = true;
			}
		}

		public frm_GatePassesGatePlace()
		{
			try
			{
				InitializeComponent();

				objManager = new Manager();
				myNew = new List<object>();
				myEdit = new List<object>();
				mySearch = new List<object>();
				myDelete = new List<object>();
				myView = new List<object>();
				myAll = new List<object>();

				objManager.InActiveTheme = office2010BlackTheme1;
				objManager.RBE = radLabelElementStatus;
				objManager.NewActive = myNew;
				objManager.EditActive = myEdit;
				objManager.SearchActive = mySearch;
				objManager.DeleteActive = myDelete;
				objManager.ViewActive = myView;
				objManager.EveryItems = myAll;
				v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.SetModelsCar();
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				// ItemsPublic.ShowMessage(ex.Message);
				this.Close();
			}
		}

		private string setErrMessage(Exception ex)
		{
			MatchCollection matches = Regex.Matches(ex.StackTrace, @"(\ *[^\\]*:line\s\d{1,})", RegexOptions.Multiline);
			string strErr = "";
			foreach (Match match in matches)
			{
				// Loop through captures.
				foreach (Capture capture in match.Captures)
				{
					// Display them.
					//Console.WriteLine("--" + capture.Value);
					strErr += "\n" + capture.Value;
				}
			}
			return strErr;
		}

		private bool haveRightToExpireGp()
		{
			if (!ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPacksGps_ExpireGp)
			    || MainRadGridView.CurrentRow == null
			    || (bool) MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value
			    || rgvPack == null
				)
			{
				return false;
			}

			if ((AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value == AllFunctions._StatusPack.Request
			    && ItemsPublic.MyRights.Contains(AllFunctions._Rights.confirm)
				)
			{
				return true;
			}

			if ((AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value == AllFunctions._StatusPack.Confirm ||
			    (AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value == AllFunctions._StatusPack.Passage)
			{
				switch ((AllFunctions._TypePack) rgvPack.CurrentRow.Cells["TypePack_Id"].Value)
				{
						#region type pack && rights

					case AllFunctions._TypePack.Guest:
						if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageGuest))
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.TeachTrainee:
						if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageTrainee))
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.TeachAct:
						if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageTrainee))
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.TeachUni:
						if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageTrainee))
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.TempWork:
						if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageGuest))
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.Company:
						if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageGuest))
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.WorkerMan:
						if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageWorkerMan))
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.WorkerWoman:
						if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassgeWorkerWoman))
						{
							return true;
						}
						break;
					default:
						ItemsPublic.Exeptor("نوع بسته نامشخص می باشد");
						break;
						//   datas[_IdData.Event_Description] += "\n" + "نوع بسته نامشخص می باشد";
						//  throw new Exception();

						#endregion
				}
			}

			return false;
		}

		protected void SetProperties()
		{
			try
			{
				if (true)
				{
					//   MessageBox.Show(MainRadGridView.CurrentRow.Cells[0].Value.ToString());
					if (!IsnewRowAdded && MainRadGridView.SelectedRows.Count == 1)
					{
						SetPicIfHaveRight();
						ShowPropertiesItems();
						cbbDriver.Enabled = v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked && MainRadGridView.CurrentRow != null &&
						                    cbbEdit.Enabled &&
						                    !string.IsNullOrEmpty(
						                    	MainRadGridView.CurrentRow.Cells["Person_LicenseDriverCode"].Value.ToString().Trim());
						rightCbbDriver.Enabled = cbbDriver.Enabled;

						//var a3 = (bool) MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value != true;

						//cbbExpire.Enabled =( MainRadGridView.CurrentRow != null
						//                    && (bool) MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value == false
						//                    &&
						//                    (rgvPack != null &&
						//                     ((AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value ==
						//                     AllFunctions._StatusPack.Passage || (AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value ==AllFunctions._StatusPack.Confirm || (AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value ==AllFunctions._StatusPack.Request)));

						cbbExpire.Enabled = haveRightToExpireGp();
						rightCbbExpire.Enabled = cbbExpire.Enabled;

					}
					else
					{
						uC_ViewPersonDetails1.rbtnImage.Enabled = false;
						objManager.EmptyControls(myAll);
					}
				}
			}
			catch (Exception ex)
			{
				//ItemsPublic.ShowMessage(ex.Message);
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//  this.Close();
			}
		}

		protected void justListForm()
		{
			RadCommandBar1.Visible = false;
			radMenu1.Visible = false;
		}

		private void menuService_ContextMenuDisplaying(object sender, ContextMenuDisplayingEventArgs e)
		{
			//the menu request is associated with a valid DockWindow instance, which resides within a DocumentTabStrip
			if (e.MenuType == ContextMenuType.DockWindow &&
			    e.DockWindow.DockTabStrip is DocumentTabStrip)
			{
				//remove the "Close" menu items
				foreach (RadMenuItemBase menuItem in e.MenuItems)
				{
					if (menuItem.Name == "CloseWindow" ||
					    menuItem.Name == "CloseAllButThis" ||
					    menuItem.Name == "CloseAll" ||
					    menuItem is RadMenuSeparatorItem)
					{
						// In case you just want to disable to option you can set Enabled false
						// menuItem.Enabled = false;
						menuItem.Text = "سلام";
						// menuItem.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
					}
				}
			}
		}

		protected void GroupingControlsView(Control collect)
		{
			try
			{
				foreach (Control cntrl in collect.Controls)
				{
					GroupingControlsView(cntrl);
					if (cntrl.Tag != null && cntrl.Tag.ToString() != "")
					{
						if (cntrl.Tag.ToString().Any(c => c == 'a'))
						{
							myAll.Add(cntrl);
							// cntrl.Tag = "a";
						}
						else
						{
							throw new Exception("Ananymous caracter in All mode");
						}
					}
				}
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
				//   this.Close();
			}
		}

		protected void justViewGrouping(Control collect)
		{
			try
			{
				foreach (Control cntrl in collect.Controls)
				{
					if (cntrl.Tag.ToString().Any(c => c == 'l'))
					{
						GroupingControlsView(cntrl);
						continue;
					}
				}
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//MessageBox.Show(ex.Message);
				this.Close();
			}
		}

		//private string S = "";
		//private bool lump = false;

		protected void GroupingControls(Control collect)
		{

			try
			{

				foreach (Control cntrl in collect.Controls)
				{
					//if ( lump )
					//{
					//    if ( cntrl is RadTextBox  || cntrl is RadButton || cntrl is RadMaskedEditBox || cntrl is RadTextBox || cntrl is UserControl )
					//    {
					//        int h = 0;
					//        MessageBox.Show ( cntrl.Name + "\n" + cntrl.Tag );
					//    }
					//}

					//if ( cntrl is UserControl && cntrl.Name=="uC_ViewPersonDetails1" )
					//{
					//    lump = true;
					//    MessageBox.Show(cntrl.Name);
					//}

					if (cntrl.Tag == null || cntrl.Tag.ToString() == "")
					{
						GroupingControls(cntrl);
					}
					else if (cntrl.Tag.ToString().Any(c => c == 'l'))
					{
						//  cntrl.Tag = "";
						GroupingControlsView(cntrl);
						//   cntrl.Tag = "";
						continue;
					}

					if (cntrl.Tag != null && cntrl.Tag.ToString() != "")
					{
						if (cntrl.Tag.ToString().Any(c => c == 'a'))
						{

						}
						else
						{
							throw new Exception("control have not 'a' caracter");
						}

						foreach (char c in cntrl.Tag.ToString())
						{
							// d ro vase disable kardan gharar midim

							// edit =e , new = n , search = s ,  = d, view =v 
							//if ( cntrl is RadButton )
							//{
							//    int k = 0;
							//    MessageBox.Show ( cntrl.Name );
							//}
							switch (c)
							{
								case 'e':
									myEdit.Add(cntrl);
									break;
								case 'n':
									myNew.Add(cntrl);
									break;
								case 's':
									mySearch.Add(cntrl);
									break;
								case 'd':
									myDelete.Add(cntrl);
									break;
								case 'v':
									myView.Add(cntrl);
									break;
								case 'a':
									myAll.Add(cntrl);
									break;
								case 'L':
									break;
								default:
									throw new Exception("Ananymous Caracter");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//MessageBox.Show(ex.Message);
				this.Close();
			}
		}

		protected void GroupingRadObjects(RadItemCollection collect)
		{
			try
			{
				foreach (RadItem cntrl in collect)
				{

					if (cntrl.Tag != null && cntrl.Tag.ToString() != "")
					{
						if (cntrl.Tag.ToString().Any(c => c == 'a'))
						{

						}
						else
						{
							throw new Exception("Radboject have not 'a' caracter");
						}

						foreach (char c in cntrl.Tag.ToString())
						{
							// d ro vase disable kardan gharar midim

							// edit =e , new = n , search = s ,  = d, view =v 

							switch (c)
							{
								case 'e':
									myEdit.Add(cntrl);
									break;
								case 'n':
									myNew.Add(cntrl);
									break;
								case 's':
									mySearch.Add(cntrl);
									break;
								case 'd':
									myDelete.Add(cntrl);
									break;
								case 'v':
									myView.Add(cntrl);
									break;
								case 'a':
									myAll.Add(cntrl);
									break;
								default:
									throw new Exception("Ananymous Caracter");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
				this.Close();
			}
		}


		protected bool CheckOneSelectedRow(int countSelectedRows)
		{

			if (countSelectedRows != 1)
			{
				MessageBox.Show(ItemsPublic._infoSelRow);
				return false;
			}


			return true;
		}

		protected bool QuestionSureToDel()
		{

			var dr = MessageBox.Show(ItemsPublic._questionSureToDel, "هشدار", MessageBoxButtons.YesNo,
			                         MessageBoxIcon.Question);
			return dr == DialogResult.Yes;
		}

		protected bool QuestionSureToEdit()
		{

			var dr = MessageBox.Show("آیا قصد ویرایش تنظیمات این بسته را دارید؟", "هشدار", MessageBoxButtons.YesNo,
			                         MessageBoxIcon.Question);
			return dr == DialogResult.Yes;
		}

		protected bool QuestionSureTo(string str)
		{

			var dr = MessageBox.Show(str, "هشدار", MessageBoxButtons.YesNo,
			                         MessageBoxIcon.Question);
			return dr == DialogResult.Yes;
		}

		protected void InfoDeleted()
		{
			ItemsPublic.ShowMessage(ItemsPublic._infoDel);
		}

		protected void InfoEdited()
		{
			ItemsPublic.ShowMessage(ItemsPublic._infoEdit);
		}

		protected void InfoAdded()
		{
			ItemsPublic.ShowMessage(ItemsPublic._infoNew);
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

		protected void cbbNew_Click(object sender, EventArgs e)
		{
			try
			{
				//          eventStatusNew();
				//MainRadGridView.Enabled = false;
				//                MainRadGridView.CurrentRow = null;
				//              MainRadGridView.ClearSelection();
				//            objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toNew);
				//ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toNew;

				//	var frmAddPersons = new gatepass.ui.package.frm_SelectingPersons5();
				var frmAddPersons = new gatepass.ui.package.frm_SelectOrAddPersons4();
				////   frmAddPersons.pmStatus = ItemsPublic.IndexStatus.toEdit;
				//  frmAddPersons.IndexPack = (decimal?)MainRadGridView.CurrentRow.Cells["package_Id"].Value;
				// //  frmAddPersons.setItemsPack(ref radGridViewPacks);
				//frmAddPersons.radGridViewSelected = MainRadGridView;
				//frmAddPersons.radGridViewSelected.DataSource=MainRadGridView;

				//frmAddPersons.radGridViewSelected = MainRadGridView;

				//	frmAddPersons.radGridViewSelected.DataSource = MainRadGridView.DataSource;
				if (MainRadGridView.Rows.Count != 0)
				{
					#region setRows

					for (int count = 0; count < MainRadGridView.Rows.Count; count++)
					{
						frmAddPersons.radGridViewSelected.Rows.AddNew();
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_ID"].Value =
							MainRadGridView.Rows[count].Cells["Person_ID"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_NationalCode"].Value =
							MainRadGridView.Rows[count].Cells["Person_NationalCode"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_isWoman"].Value =
							MainRadGridView.Rows[count].Cells["Person_isWoman"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_IdentifyCode"].Value =
							MainRadGridView.Rows[count].Cells["Person_IdentifyCode"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_LicenseDriverCode"].Value =
							MainRadGridView.Rows[count].Cells["Person_LicenseDriverCode"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_Name"].Value =
							MainRadGridView.Rows[count].Cells["Person_Name"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_Surname"].Value =
							MainRadGridView.Rows[count].Cells["Person_Surname"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_FatherName"].Value =
							MainRadGridView.Rows[count].Cells["Person_FatherName"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_BirthCity"].Value =
							MainRadGridView.Rows[count].Cells["Person_BirthCity"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_RegisterCity"].Value =
							MainRadGridView.Rows[count].Cells["Person_RegisterCity"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_Nationality"].Value =
							MainRadGridView.Rows[count].Cells["Person_Nationality"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_BirthDate"].Value =
							MainRadGridView.Rows[count].Cells["Person_BirthDate"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_Phone1"].Value =
							MainRadGridView.Rows[count].Cells["Person_Phone1"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_Phone2"].Value =
							MainRadGridView.Rows[count].Cells["Person_Phone2"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_HaveForm"].Value =
							MainRadGridView.Rows[count].Cells["Person_HaveForm"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_RegisterCode"].Value =
							MainRadGridView.Rows[count].Cells["Person_RegisterCode"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_LabelIsWoman"].Value =
							MainRadGridView.Rows[count].Cells["Person_LabelIsWoman"].Value;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["Gatepass_ID"].Value = -1;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["GatePass_IntPrint"].Value = -1;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["GatePass_IsDriver"].Value = false;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["GatePass_TimeLock"].Value = null;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["GatePass_LockerId"].Value = -1;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["package_Id"].Value = -1;
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["CountPrinted"].Value = "0";
						frmAddPersons.radGridViewSelected.CurrentRow.Cells["GatePass_IsExpired"].Value =
							MainRadGridView.Rows[count].Cells["GatePass_IsExpired"].Value;

						if (!(MainRadGridView.Rows[count].Cells["Person_Picture"].Value is DBNull) &&
						    MainRadGridView.Rows[count].Cells["Person_Picture"].Value != null)
						{
							try
							{
								try
								{
									var Picture =
										((byte[]) MainRadGridView.Rows[count].Cells["Person_Picture"].Value);
									frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_Picture"].Value = Picture.Length > 0
									                                                                             	? Picture
									                                                                             	: null;
								}
								catch
								{
									frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_Picture"].Value =
										MainRadGridView.Rows[count].Cells["Person_Picture"].Value;
								}
							}
							catch
							{
								MessageBox.Show("عکس شخص بارگذاری نشد");
							}

							//frmAddPersons.radGridViewSelected.CurrentRow.Cells ["Person_Picture"].Value = 
							//MainRadGridView.Rows [count].Cells ["Person_Picture"].Value;

						}
						else
						{
							frmAddPersons.radGridViewSelected.CurrentRow.Cells["Person_Picture"].Value = null;
						}

					}

					#endregion
				}
				frmAddPersons.ShowDialog();
				if (frmAddPersons.State)
				{
					//MainRadGridView.DataSource=null;
					//MainRadGridView.SelectAll();
					MainRadGridView.AllowAddNewRow = true;
					IsnewRowAdded = true;
					MainRadGridView.CurrentRow = null;
					//MainRadGridView.Rows.RemoveAt(0);
					MainRadGridView.DataSource = null;
					//MainRadGridView.EndInit();
					//MainRadGridView.EndUpdate();
					MainRadGridView.EndEdit();
					while (MainRadGridView.Rows.Count > 0)
					{
						MainRadGridView.Rows.RemoveAt(0);
					}

					for (int count = 0; count < frmAddPersons.radGridViewSelected.Rows.Count; count++)
					{
						#region set rows

						MainRadGridView.Rows.AddNew();
						MainRadGridView.CurrentRow.Cells["Person_ID"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_ID"].Value;
						MainRadGridView.CurrentRow.Cells["Person_NationalCode"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_NationalCode"].Value;
						MainRadGridView.CurrentRow.Cells["Person_isWoman"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_isWoman"].Value;
						MainRadGridView.CurrentRow.Cells["Person_IdentifyCode"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_IdentifyCode"].Value;
						MainRadGridView.CurrentRow.Cells["Person_LicenseDriverCode"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_LicenseDriverCode"].Value;
						MainRadGridView.CurrentRow.Cells["Person_Name"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Name"].Value;
						MainRadGridView.CurrentRow.Cells["Person_Surname"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Surname"].Value;
						MainRadGridView.CurrentRow.Cells["Person_FatherName"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_FatherName"].Value;
						MainRadGridView.CurrentRow.Cells["Person_BirthCity"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_BirthCity"].Value;
						MainRadGridView.CurrentRow.Cells["Person_RegisterCity"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_RegisterCity"].Value;
						MainRadGridView.CurrentRow.Cells["Person_Nationality"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Nationality"].Value;
						MainRadGridView.CurrentRow.Cells["Person_BirthDate"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_BirthDate"].Value;
						MainRadGridView.CurrentRow.Cells["Person_Phone1"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Phone1"].Value;
						MainRadGridView.CurrentRow.Cells["Person_Phone2"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Phone2"].Value;
						//						MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value;
						MainRadGridView.CurrentRow.Cells["Person_HaveForm"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_HaveForm"].Value;
						MainRadGridView.CurrentRow.Cells["Person_RegisterCode"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_RegisterCode"].Value;
						MainRadGridView.CurrentRow.Cells["Person_LabelIsWoman"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_LabelIsWoman"].Value;
						MainRadGridView.CurrentRow.Cells["Gatepass_ID"].Value = -1;
						MainRadGridView.CurrentRow.Cells["GatePass_IntPrint"].Value = -1;
						MainRadGridView.CurrentRow.Cells["GatePass_IsDriver"].Value = false;
						MainRadGridView.CurrentRow.Cells["GatePass_TimeLock"].Value = null;
						MainRadGridView.CurrentRow.Cells["GatePass_LockerId"].Value = -1;
						MainRadGridView.CurrentRow.Cells["package_Id"].Value = -1;
						MainRadGridView.CurrentRow.Cells["CountPrinted"].Value = "0";
						MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value =
							frmAddPersons.radGridViewSelected.Rows[count].Cells["GatePass_IsExpired"].Value;

						//if(MainRadGridView.CurrentRow.Cells ["Person_ID"].Value == null){MainRadGridView.CurrentRow.Cells ["Person_ID"].Value ="";}

						if (MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value = false;
						}
						if (MainRadGridView.CurrentRow.Cells["Person_NationalCode"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_NationalCode"].Value = "";
						}

						if (MainRadGridView.CurrentRow.Cells["Person_isWoman"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_isWoman"].Value = "";
						}

						if (MainRadGridView.CurrentRow.Cells["Person_IdentifyCode"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_IdentifyCode"].Value = "";
						}

						if (MainRadGridView.CurrentRow.Cells["Person_LicenseDriverCode"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_LicenseDriverCode"].Value = "";
						}

						if (MainRadGridView.CurrentRow.Cells["Person_Name"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_Name"].Value = "";
						}

						if (MainRadGridView.CurrentRow.Cells["Person_Surname"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_Surname"].Value = "";
						}

						if (MainRadGridView.CurrentRow.Cells["Person_FatherName"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_FatherName"].Value = "";
						}

						if (MainRadGridView.CurrentRow.Cells["Person_BirthCity"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_BirthCity"].Value = "";
						}

						if (MainRadGridView.CurrentRow.Cells["Person_RegisterCity"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_RegisterCity"].Value = "";
						}

						if (MainRadGridView.CurrentRow.Cells["Person_Nationality"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_Nationality"].Value = "";
						}

						//if(MainRadGridView.CurrentRow.Cells ["Person_BirthDate"].Value == null){MainRadGridView.CurrentRow.Cells ["Person_BirthDate"].Value =null;}

						if (MainRadGridView.CurrentRow.Cells["Person_Phone1"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_Phone1"].Value = "";
						}

						if (MainRadGridView.CurrentRow.Cells["Person_Phone2"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_Phone2"].Value = "";
						}

						//if(MainRadGridView.CurrentRow.Cells ["Person_HaveForm"].Value == null){MainRadGridView.CurrentRow.Cells ["Person_HaveForm"].Value ="";}

						if (MainRadGridView.CurrentRow.Cells["Person_RegisterCode"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_HaveForm"].Value = "";
						}

						if (MainRadGridView.CurrentRow.Cells["Person_LabelIsWoman"].Value == null)
						{
							MainRadGridView.CurrentRow.Cells["Person_LabelIsWoman"].Value = "";
						}

						//if(MainRadGridView.CurrentRow.Cells ["Gatepass_ID"].Value == null){MainRadGridView.CurrentRow.Cells ["Gatepass_ID"].Value ="";}
						//if(MainRadGridView.CurrentRow.Cells ["GatePass_IntPrint"].Value == null){MainRadGridView.CurrentRow.Cells ["GatePass_IntPrint"].Value ="";}
						//if(MainRadGridView.CurrentRow.Cells ["GatePass_IsDriver"].Value == null){MainRadGridView.CurrentRow.Cells ["GatePass_IsDriver"].Value ="";}
						//if(MainRadGridView.CurrentRow.Cells ["GatePass_TimeLock"].Value == null){MainRadGridView.CurrentRow.Cells ["GatePass_TimeLock"].Value ="";}
						//if(MainRadGridView.CurrentRow.Cells ["GatePass_LockerId"].Value == null){MainRadGridView.CurrentRow.Cells ["GatePass_LockerId"].Value ="";}
						//if(MainRadGridView.CurrentRow.Cells ["package_Id"].Value == null){MainRadGridView.CurrentRow.Cells ["package_Id"].Value ="";}
						//if(MainRadGridView.CurrentRow.Cells ["CountPrinted"].Value == null){MainRadGridView.CurrentRow.Cells ["CountPrinted"].Value ="";}


						if (frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value != null)
						{
							using (var ms = new System.IO.MemoryStream())
							{
								((Bitmap) frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value).
									Save(ms,
									     System.
									     	Drawing
									     	.
									     	Imaging
									     	.
									     	ImageFormat
									     	.Jpeg);
								var picture = ms.ToArray();
								MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = picture.Length > 0
								                                                           	? picture
								                                                           	: null;
							}
						}
						else
						{
							MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = null;
						}

						#endregion
					}
					MainRadGridView.AllowAddNewRow = false;
					IsnewRowAdded = false;
					MainRadGridView.Refresh();
					//radGridViewPackManage.Enabled = true;
				}
				frmAddPersons.Close();
				frmAddPersons.Dispose();
				//setPackInfo();
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}
			IsnewRowAdded = true;
			MainRadGridView.CurrentRow = null;
			IsnewRowAdded = false;
			rightsEnableControls();
		}

		protected void cbbEdit_Click(object sender, EventArgs e)
		{
			try
			{
				//eventStatusEdit();
				//if (!QuestionSureToEdit())
				//{
				//    return;
				//}
				//MainRadGridView.Enabled = false;
				//MainRadGridView.CurrentRow = null;
				//objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.setPack);
				//ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toEdit;

				var frmSet = new gatepass.ui.package.frm_SettingPackGatePlace();
				frmSet.SetSettings(this.v01_uC_packDetailsGatePlace1);
				frmSet.ShowDialog();
				if (frmSet.DialogResult == DialogResult.OK)
				{
					MainRadGridView.CurrentRow = null;
					this.SetSetting(frmSet.v01_UC_packDetailsNewGatePlace1);
					objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.setPack);
					cbbSave_Click(null, null);
				}
				frmSet.Close();
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}
			rightsEnableControls();
		}



		private void cbbSearch_Click(object sender, EventArgs e)
		{
			try
			{
				if (MainRadGridView.SelectedRows.Count != 1)
				{
					MessageBox.Show(ItemsPublic._infoSelRow);
				}
				else
				{
					//v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked = true;
					CurrentDriverId = (decimal) MainRadGridView.CurrentRow.Cells["Person_ID"].Value;
					if (v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked)
					{
						if (CurrentDriverId == null && personIdDriver() == null)
						{
							ItemsPublic.Exeptor("راننده ای برای خودرو انتخاب نشده است");
						}
						if (CurrentDriverId != null)
						{
							foreach (var row in MainRadGridView.Rows)
							{
								if ((bool) row.Cells["GatePass_IsDriver"].Value)
								{
									//break;

									row.Cells["GatePass_IsDriver"].Value = false;

									break;
								}
							}
							foreach (var row in MainRadGridView.Rows)
							{
								if ((decimal) row.Cells["Person_ID"].Value == CurrentDriverId)
								{
									//	break;
									row.Cells["GatePass_IsDriver"].Value = true;
									break;
								}
							}
							//	MainRadGridView.EndEdit ();
							//	MainRadGridView.CloseEditor();
							//	MainRadGridView.Refresh();
							CurrentDriverId = null;
						}
					}
					//	MessageBox.Show("در صورت تایید شخص انتخابی به عنوان " + "\n" + "راننده خودرو انتخاب خواهد شد");
				}
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}
		}

		protected void cbbView_Click(object sender, EventArgs e)
		{
			try
			{
				eventStatusView();
				MainRadGridView.Enabled = true;
				objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.viewPack);
				cbbSave_Click(null, null);
				//ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;

			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}
		}

		protected void cbbSave_Click(object sender, EventArgs e)
		{
			result = new OutputDatas();
			try
			{
				// result.Dispose();
				switch (objManager.TypeStatus)
				{
					case ItemsPublic.IndexStatus.toDelete:

						#region toDelete

						if (!CheckOneSelectedRow(MainRadGridView.SelectedRows.Count) || !QuestionSureToDel())
						{
							return;
						}
						CursorWait();
						eventSaveToDelete();
						CursorDefault();
						if (result.success)
						{
							InfoDeleted();
							MainRadGridView.CurrentRow.Delete();
						}
						else
						{
							MessageBox.Show(result.Message);
						}
						break;

						#endregion

					case ItemsPublic.IndexStatus.toEdit:

						#region toEdit

						if (!CheckOneSelectedRow(MainRadGridView.SelectedRows.Count) || !QuestionSureToEdit())
						{
							return;
						}
						CursorWait();
						eventSaveToEdit();
						CursorDefault();
						if (result.success)
						{
							InfoEdited();
							//   this.MainRadGridView.ReadOnly = false;
							//   this.MainRadGridView.AllowEditRow = true;
							//   this.MainRadGridView.Enabled = true;
							foreach (DataColumn col in result.ResultTable.Columns)
							{
								//      MainRadGridView.CurrentRow.Cells[col.ColumnName].ReadOnly = false;
								//   MainRadGridView.CurrentRow.Cells[col.ColumnName].BeginEdit();
								MainRadGridView.CurrentRow.Cells[col.ColumnName].Value =
									result.ResultTable.Rows[0][col.ColumnName];
								//    MainRadGridView.CurrentRow.Cells[col.ColumnName].EndEdit();
							}
							//     this.MainRadGridView.ReadOnly = true;
							//      this.MainRadGridView.AllowEditRow = false;
							cbbCancel_Click(sender, e);
						}
						else
						{
							MessageBox.Show(result.Message);
						}
						break;

						#endregion

					case ItemsPublic.IndexStatus.toNew:

						#region toNew

						CursorWait();
						eventSaveToNew();
						CursorDefault();
						if (result.success)
						{
							//  eventClearProperiesItems();
							objManager.EmptyControls(myAll);
							InfoAdded();
							IsnewRowAdded = true;
							MainRadGridView.Rows.AddNew();
							IsnewRowAdded = false;
							foreach (DataColumn col in result.ResultTable.Columns)
							{
								MainRadGridView.CurrentRow.Cells[col.ColumnName].Value =
									result.ResultTable.Rows[0][col.ColumnName];
							}
							MainRadGridView.CurrentRow = null;
						}
						else
						{
							MessageBox.Show(result.Message);
						}

						break;

						#endregion

					case ItemsPublic.IndexStatus.toSearch:

						#region toSearch

						CursorWait();
						eventSaveToSearch();
						CursorDefault();
						if (result.success)
						{
							objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toView);
							MainRadGridView.DataSource = result.ResultTable;
							MainRadGridView.Enabled = true;
							//ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;
						}
						else
						{
							MessageBox.Show(result.Message);
						}
						break;

						#endregion

					case ItemsPublic.IndexStatus.toView:

						#region toView

						CursorWait();
						eventSaveToView();
						CursorDefault();
						if (result.success)
						{
							MainRadGridView.DataSource = result.ResultTable;
							MainRadGridView.Enabled = true;
						}
						else
						{
							MessageBox.Show(result.Message);
						}
						break;

						#endregion

					case aorc.gatepass.ItemsPublic.IndexStatus.setPack:

						#region SetPack

						try
						{
							//eventStatusView();
							MainRadGridView.Enabled = true;
							objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.viewPack);
							if (v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked)
							{
								if (CurrentDriverId == null && personIdDriver() == null)
								{
									//	ItemsPublic.Exeptor("راننده ای برای خودرو انتخاب نشده است");
								}
								if (CurrentDriverId != null)
								{
									foreach (var row in MainRadGridView.Rows)
									{
										if ((bool) row.Cells["GatePass_IsDriver"].Value)
										{
											//break;

											row.Cells["GatePass_IsDriver"].Value = false;

											break;
										}
									}
									foreach (var row in MainRadGridView.Rows)
									{
										if ((decimal) row.Cells["Person_ID"].Value == CurrentDriverId)
										{
											//	break;
											row.Cells["GatePass_IsDriver"].Value = true;
											break;
										}
									}
									//	MainRadGridView.EndEdit ();
									//	MainRadGridView.CloseEditor();
									//	MainRadGridView.Refresh();
									CurrentDriverId = null;
								}
							}
							else
							{
								CurrentDriverId = null;
								foreach (var row in MainRadGridView.Rows)
								{
									if ((bool) row.Cells["GatePass_IsDriver"].Value)
									{
										row.Cells["GatePass_IsDriver"].Value = false;
										//MainRadGridView.EndEdit ();
										//MainRadGridView.CloseEditor ();
										//MainRadGridView.Refresh ();
										break;
									}
								}
							}
							//ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;
						}
						catch (Exception ex)
						{
							ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
							//ItemsPublic.ShowMessage(ex.Message);
							// this.Close();
						}

						//		cbbView_Click(null,null);
						//	CursorWait();
						//eventSaveToEdit();
						//	CursorDefault();
						//if (result.success)
						//{
						//    InfoEdited();
						//    //   this.MainRadGridView.ReadOnly = false;
						//    //   this.MainRadGridView.AllowEditRow = true;
						//    //   this.MainRadGridView.Enabled = true;
						//    foreach (DataColumn col in result.ResultTable.Columns)
						//    {
						//        //      MainRadGridView.CurrentRow.Cells[col.ColumnName].ReadOnly = false;
						//        //   MainRadGridView.CurrentRow.Cells[col.ColumnName].BeginEdit();
						//        MainRadGridView.CurrentRow.Cells[col.ColumnName].Value =
						//            result.ResultTable.Rows[0][col.ColumnName];
						//        //    MainRadGridView.CurrentRow.Cells[col.ColumnName].EndEdit();
						//    }
						//    //     this.MainRadGridView.ReadOnly = true;
						//    //      this.MainRadGridView.AllowEditRow = false;
						//    cbbCancel_Click(sender, e);
						//}
						//else
						//{
						//    MessageBox.Show(result.Message);
						//}
						break;

						#endregion

				}
				eventAfterSave();
				rightsEnableControls();
			}
			catch (Exception ex)
			{
				CursorDefault();
				if (result == null)
				{
					ItemsPublic.ShowMessage(ItemsPublic._errConnection);
				}
				else
				{
					ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				}
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}

		}

		protected void cbbCancel_Click(object sender, EventArgs e)
		{
			try
			{
				//cbbView_Click(sender,e);
				MainRadGridView.Enabled = true;
				MainRadGridView.CurrentRow = null;
				objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toView);
				//ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;
				rightsEnableControls();
				CurrentDriverId = null;
				if (pmStatus != ItemsPublic.IndexStatus.toNew)
				{
					setPackInfo();
				}
				else
				{
					//setEmptyInfo();
				}
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}
		}

		private void radStatusStrip1_Resize(object sender, EventArgs e)
		{
			try
			{
				this.radLabelElementStatus.Bounds = new System.Drawing.Rectangle(0, 0, radStatusStrip1.Width, 18);
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}
		}

		private GroupDescriptor descG = new GroupDescriptor("GatePass_IsExpired");

		private void frm_GatePassesGatePlace_Load(object sender, EventArgs e)
		{
			MainRadGridView.GroupDescriptors.Add(descG);
			uC_ViewPersonDetails1.rbtnImage.Tag = "a";
			uC_ViewPersonDetails1.TcoNationality.Tag = "a";
			uC_ViewPersonDetails1.TcoSex.Tag = "a";
			uC_ViewPersonDetails1.TcoHaveForm.Tag = "a";
			uC_ViewPersonDetails1.TcoBirthCity.Tag = "a";
			uC_ViewPersonDetails1.rtbFatherName.Tag = "a";
			uC_ViewPersonDetails1.rtbSurname.Tag = "a";
			uC_ViewPersonDetails1.rtbName.Tag = "a";
			uC_ViewPersonDetails1.TcoIsBlack.Tag = "a";
			uC_ViewPersonDetails1.rmebPhone2.Tag = "a";
			uC_ViewPersonDetails1.rmebPhone1.Tag = "a";
			uC_ViewPersonDetails1.rmebLicenseDriveCode.Tag = "a";
			uC_ViewPersonDetails1.bdcBirthDate.Tag = "a";
			uC_ViewPersonDetails1.bdcEndSecureDate.Tag = "a";
			uC_ViewPersonDetails1.TcoRegisterCity.Tag = "a";
			uC_ViewPersonDetails1.rmeIdentifyCode.Tag = "a";
			uC_ViewPersonDetails1.rtbRegisterCode.Tag = "a";
			uC_ViewPersonDetails1.rmebNationalCode.Tag = "a";
			//	SetPicIfHaveRight ();
			//setMenuForPakcManager();
			//justViewGrouping((Control)this);
			//oo = new GridViewRowInfo(new GridViewInfo(new GridViewTemplate(MainRadGridView)));

            v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rtbColor.Tag =
                v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rtbColor.Tag + "L";

            v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rtbModel.Tag =
				v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rtbModel.Tag + "L";


            v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.Tag  =
                v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.Tag + "L";

            v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.CarNumberTags =
                v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.CarNumberTags + "L";

			v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rddlState.Tag =
				v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rddlState.Tag + "L";

			v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rddlType.Tag =
				v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rddlType.Tag + "L";

			setAllMouseMenus();
			GroupingControls((Control) this);

			//foreach (var cntrl in myAll)
			//{
			//    if (cntrl is RadButton)
			//        S += S + "\n" + ((RadButton) cntrl).Name;
			//}

			GroupingRadObjects(findRadItems());

			if (pmStatus == ItemsPublic.IndexStatus.toEdit)
			{
				//  result = objManager.View_gatePasses(IndexPack);
				//cbbSave_Click(sender, e);
				//rightsEnableControls();
				cbbView_Click(sender, e);
				setPackInfo();
				//     cbbView_Click(sender, e);
				//     cbbSave_Click(sender, e);
				//	cbbSave_Click(sender, e);
			}
			if (pmStatus == ItemsPublic.IndexStatus.toNew)
			{
				MainRadGridView.CurrentRow = null;
				objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.viewPack);
			}
			rightsEnableControls();
			uC_ViewPersonDetails1.getPicThenSetPic = true;
//....................
			//string strstr = "";
			//foreach (Object o in myAll)
			//{
			//    strstr += o.ToString();
			//}

		}

		private void setPackInfo()
		{
			var result = new OutputDatas();
			var objGateManager = new Manager();
			result = objGateManager.View_Gates(IndexPack);
			if (result.success)
			{

				v01_uC_packDetailsGatePlace1.rtbGates.Text = "";
				v01_uC_packDetailsGatePlace1.CurrentGates = new List<int>();
				foreach (DataRow obj in result.ResultTable.Rows)
				{
					//	string ss = obj.Cells["Gate_Id"].Value.ToString().Trim();
					//int ii = int.Parse(obj.Cells["Gate_Id"].Value.ToString().Trim());
					v01_uC_packDetailsGatePlace1.CurrentGates.Add(int.Parse(obj["Gate_Id"].ToString().Trim()));
					v01_uC_packDetailsGatePlace1.rtbGates.Text += obj["Gate_Name"].ToString().Trim() + "\r\n";
				}
			}
			else
			{
				ItemsPublic.ShowMessage(result.Message);
			}


			result = new OutputDatas();
			objGateManager = new Manager();
			result = objGateManager.View_Places(IndexPack);
			if (result.success)
			{
				v01_uC_packDetailsGatePlace1.rtbPlaces.Text = "";
				v01_uC_packDetailsGatePlace1.CurrentPlaces = new List<int>();
				foreach (DataRow obj in result.ResultTable.Rows)
				{
					//	string ss = obj.Cells["Place_Id"].Value.ToString().Trim();
					//int ii = int.Parse(obj.Cells["Place_Id"].Value.ToString().Trim());
					v01_uC_packDetailsGatePlace1.CurrentPlaces.Add(int.Parse(obj["Place_Id"].ToString().Trim()));
					v01_uC_packDetailsGatePlace1.rtbPlaces.Text += obj["Place_Name"].ToString().Trim() + "\r\n";
				}
			}
			else
			{
				ItemsPublic.ShowMessage(result.Message);
			}



			v01_uC_packDetailsGatePlace1.rddlShift.Text = rgvPack.CurrentRow.Cells["Package_Shift"].Value.ToString().Trim();

			v01_uC_packDetailsGatePlace1.rtbStatusPack.Text = rgvPack.CurrentRow.Cells["StatusPack_Label"].Value.ToString().Trim();
            v01_uC_packDetailsGatePlace1.rtbPlaces.Text = rgvPack.CurrentRow.Cells["Package_TicketId"].Value.ToString().Trim();
			v01_uC_packDetailsGatePlace1.rtbOffice.Text = rgvPack.CurrentRow.Cells["Office_Name"].Value.ToString().Trim();
			switch ((ServerClasses.AllFunctions._TypePack) rgvPack.CurrentRow.Cells["TypePack_Id"].Value)
			{
				case ServerClasses.AllFunctions._TypePack.WorkerMan:
					v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.WorkerMan;
					break;
				case ServerClasses.AllFunctions._TypePack.WorkerWoman:
					v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.WorkerWoman;
					break;
				case ServerClasses.AllFunctions._TypePack.TeachTrainee:
					v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.TeachTrainee;
					break;
				case ServerClasses.AllFunctions._TypePack.TeachUni:
					v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.TeachUni;
					break;
				case ServerClasses.AllFunctions._TypePack.TeachAct:
					v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.TeachAct;
					break;
				case ServerClasses.AllFunctions._TypePack.Guest:
					v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.Guest;
					break;
				case ServerClasses.AllFunctions._TypePack.TempWork:
					v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.TempWork;
					break;
				case ServerClasses.AllFunctions._TypePack.Company:
					v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.Company;
					break;
			}
			v01_uC_packDetailsGatePlace1.bdcStartDate.DateTime = (DateTime) rgvPack.CurrentRow.Cells["Package_StartDate"].Value;
			v01_uC_packDetailsGatePlace1.bdcEndDate.DateTime = (DateTime) rgvPack.CurrentRow.Cells["Package_EndDate"].Value;
			v01_uC_packDetailsGatePlace1.rddlValid.SelectedIndex = ((bool) rgvPack.CurrentRow.Cells["Package_IsExpired"].Value)
			                                                   	? 0
			                                                   	: 1;
			v01_uC_packDetailsGatePlace1.rtbNumberAgree.Text = rgvPack.CurrentRow.Cells["Agreement_Number"].Value.ToString().Trim();
			string temS = rgvPack.CurrentRow.Cells["Agreement_ID"].Value.ToString().Trim();
			decimal? temp = string.IsNullOrEmpty(temS) ? (decimal?) null : decimal.Parse(temS);
			v01_uC_packDetailsGatePlace1.CurrentAgreeId = temp;
			v01_uC_packDetailsGatePlace1.rtbCompanyAgree.Text = rgvPack.CurrentRow.Cells["Agreement_Company"].Value.ToString().Trim();
			v01_uC_packDetailsGatePlace1.rtbTitleAgree.Text = rgvPack.CurrentRow.Cells["Agreement_Title"].Value.ToString().Trim();
			v01_uC_packDetailsGatePlace1.rlblCountCar.Text = ItemsPublic.HowManyCarInAgree(temp);


			temS = rgvPack.CurrentRow.Cells["TravelArea_Id"].Value.ToString().Trim();
			int? temp2 = string.IsNullOrEmpty(temS) ? (int?) null : int.Parse(temS);
			v01_uC_packDetailsGatePlace1.CurrentTravelId = temp2;

			v01_uC_packDetailsGatePlace1.rtbTravelLabel.Text =
				rgvPack.CurrentRow.Cells["TravelArea_LabelTravel"].Value.ToString().Trim();

			v01_uC_packDetailsGatePlace1.rtbOperRequest.Text = rgvPack.CurrentRow.Cells["OperRequestName"].Value.ToString().Trim();
			v01_uC_packDetailsGatePlace1.rtbOperConfirm.Text = rgvPack.CurrentRow.Cells["OperConfirmName"].Value.ToString().Trim();
			v01_uC_packDetailsGatePlace1.rtbOperPassage.Text = rgvPack.CurrentRow.Cells["OperPassageName"].Value.ToString().Trim();
			v01_uC_packDetailsGatePlace1.tbPackDescriptions.Text =
				rgvPack.CurrentRow.Cells["Package_Description"].Value.ToString().Trim();

			//v01_uC_packDetailsGatePlace1.uC_vehicleDetails21.rddlType.SelectedIndex =
            string stV = rgvPack.CurrentRow.Cells["Vehicle_ID"].Value!= null ? rgvPack.CurrentRow.Cells["Vehicle_ID"].Value.ToString().Trim():"";
			bool boV = !string.IsNullOrEmpty(stV);
			v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked = boV;
			if (v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked)
			{
				v01_uC_packDetailsGatePlace1.CurrentCarId = (decimal?) rgvPack.CurrentRow.Cells["Vehicle_ID"].Value;
				v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rtbModel.Text =
					rgvPack.CurrentRow.Cells["Vehicle_Model"].Value.ToString().Trim();
				v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rtbColor.Text =
					rgvPack.CurrentRow.Cells["vehicle_Color"].Value.ToString().Trim();



                v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex =
                    (int)rgvPack.CurrentRow.Cells["TypePlates_Id"].Value;


                v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.CarNumber =
                    rgvPack.CurrentRow.Cells["Vehicle_number"].Value.ToString().Trim();

				

				v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rddlState.SelectedIndex =
					(bool) rgvPack.CurrentRow.Cells["Vehicle_IsCompany"].Value ? 0 : 1;
				v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.indexTypeModel =
					(int?) rgvPack.CurrentRow.Cells["VehicleType_ID"].Value;
			}
			else
			{
				v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked = false;
			}
		}

		private void setEmptyInfo()
		{
			v01_uC_packDetailsGatePlace1.CurrentCarId = null;
			CurrentDriverId = null;
			v01_uC_packDetailsGatePlace1.rtbStatusPack.Text = "درحال ساخت";
			v01_uC_packDetailsGatePlace1.rtbOffice.Text = "";
			v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex = -1;
			v01_uC_packDetailsGatePlace1.bdcStartDate.DateTime = null;
			v01_uC_packDetailsGatePlace1.bdcEndDate.DateTime = null;
			v01_uC_packDetailsGatePlace1.rddlValid.SelectedIndex = -1;
			v01_uC_packDetailsGatePlace1.rtbNumberAgree.Text = "";
			v01_uC_packDetailsGatePlace1.CurrentAgreeId = null;
			v01_uC_packDetailsGatePlace1.rtbCompanyAgree.Text = "";
			v01_uC_packDetailsGatePlace1.rtbTitleAgree.Text = "";

			v01_uC_packDetailsGatePlace1.CurrentTravelId = null;

			v01_uC_packDetailsGatePlace1.rtbTravelLabel.Text = "";

			v01_uC_packDetailsGatePlace1.rtbOperRequest.Text = "";
			v01_uC_packDetailsGatePlace1.rtbOperConfirm.Text = "";
			v01_uC_packDetailsGatePlace1.rtbOperPassage.Text = "";
			v01_uC_packDetailsGatePlace1.tbPackDescriptions.Text = "";
			v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked = false;
			v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rtbModel.Text = "";
			v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rtbColor.Text = "";
            v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex =-1;
			v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.CarNumber = "";
			v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rddlState.SelectedIndex = -1;
			v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.indexTypeModel = null;
		}

		private void ShowPropertiesItems()
		{
			if (MainRadGridView.SelectedRows[0].Cells["Person_Name"].Value != null)
			{
				uC_ViewPersonDetails1.rtbName.Text = MainRadGridView.SelectedRows[0].Cells["Person_Name"].Value.ToString().Trim();
			}
			if (MainRadGridView.SelectedRows[0].Cells["Person_Surname"].Value != null)
			{
				uC_ViewPersonDetails1.rtbSurname.Text =
					MainRadGridView.SelectedRows[0].Cells["Person_Surname"].Value.ToString().Trim();
			}
			if (MainRadGridView.SelectedRows[0].Cells["Person_NationalCode"].Value != null)
			{
				uC_ViewPersonDetails1.rmebNationalCode.Text =
					MainRadGridView.SelectedRows[0].Cells["Person_NationalCode"].Value.ToString().Trim();
			}
			if (MainRadGridView.SelectedRows[0].Cells["Person_Nationality"].Value != null)
			{
				//if (MainRadGridView.SelectedRows[0].Cells["Person_Nationality"].Value!=null)
//	{
				uC_ViewPersonDetails1.TcoNationality.Text =
					MainRadGridView.SelectedRows[0].Cells["Person_Nationality"].Value.ToString().Trim();
				//}
			}
			if (MainRadGridView.SelectedRows[0].Cells["Person_FatherName"].Value != null)
			{
				uC_ViewPersonDetails1.rtbFatherName.Text =
					MainRadGridView.SelectedRows[0].Cells["Person_FatherName"].Value.ToString().Trim();
			}
			var value = MainRadGridView.SelectedRows[0].Cells["Person_BirthCity"].Value;
			if (value != null)
			{
				uC_ViewPersonDetails1.TcoBirthCity.Text = value.ToString().Trim();
			}
			if (MainRadGridView.SelectedRows[0].Cells["Person_RegisterCity"].Value != null)
			{
				uC_ViewPersonDetails1.TcoRegisterCity.Text =
					MainRadGridView.SelectedRows[0].Cells["Person_RegisterCity"].Value.ToString().Trim();
			}

			if (MainRadGridView.SelectedRows[0].Cells["Person_IdentifyCode"].Value != null)
			{
				uC_ViewPersonDetails1.rmeIdentifyCode.Text =
					MainRadGridView.SelectedRows[0].Cells["Person_IdentifyCode"].Value.ToString().Trim();
			}

			//  string temS = MainRadGridView.SelectedRows[0].Cells["Person_RegisterCode"].Value.ToString().Trim();
			//decimal? temp = string.IsNullOrEmpty(temS) ? (decimal?)null : decimal.Parse(temS);
			//  uC_ViewPersonDetails1.rtbRegisterCode.Text = temS;
			if (MainRadGridView.SelectedRows[0].Cells["Person_RegisterCode"].Value != null)
			{
				uC_ViewPersonDetails1.rtbRegisterCode.Text =
					MainRadGridView.SelectedRows[0].Cells["Person_RegisterCode"].Value.ToString().Trim();
			}

			if (! (MainRadGridView.SelectedRows[0].Cells["Person_BirthDate"].Value is DBNull) &&
			    MainRadGridView.SelectedRows[0].Cells["Person_BirthDate"].Value != null)
			{
				uC_ViewPersonDetails1.bdcBirthDate.DateTime =
					(DateTime) MainRadGridView.SelectedRows[0].Cells["Person_BirthDate"].Value;
			}
			else
			{
				uC_ViewPersonDetails1.bdcBirthDate.DateTime = (DateTime?) null;
			}
			if (MainRadGridView.SelectedRows[0].Cells["Person_LicenseDriverCode"].Value != null)
			{
				uC_ViewPersonDetails1.rmebLicenseDriveCode.Text =
					MainRadGridView.SelectedRows[0].Cells["Person_LicenseDriverCode"].Value.ToString().Trim();
			}
			else
			{
				uC_ViewPersonDetails1.rmebLicenseDriveCode.Text = string.Empty;
			}
			if (MainRadGridView.SelectedRows[0].Cells["Person_Phone1"].Value != null)
			{
				uC_ViewPersonDetails1.rmebPhone1.Text =
					MainRadGridView.SelectedRows[0].Cells["Person_Phone1"].Value.ToString().Trim();
			}
			if (MainRadGridView.SelectedRows[0].Cells["Person_Phone2"].Value != null)
			{
				uC_ViewPersonDetails1.rmebPhone2.Text =
					MainRadGridView.SelectedRows[0].Cells["Person_Phone2"].Value.ToString().Trim();
			}
			uC_ViewPersonDetails1.TcoHaveForm.Text =
				((bool) MainRadGridView.SelectedRows[0].Cells["Person_HaveForm"].Value) ? "دارد" : "ندارد";
			if (((bool) MainRadGridView.SelectedRows[0].Cells["Person_HaveForm"].Value))
			{
				if (! (MainRadGridView.SelectedRows[0].Cells["Person_SecureFormDate"].Value is DBNull) &&
				    MainRadGridView.SelectedRows[0].Cells["Person_SecureFormDate"].Value != null)
					uC_ViewPersonDetails1.bdcEndSecureDate.DateTime =
						(DateTime) MainRadGridView.SelectedRows[0].Cells["Person_SecureFormDate"].Value;
				else
					uC_ViewPersonDetails1.bdcEndSecureDate.DateTime = (DateTime?) null;
			}
			else
			{
				uC_ViewPersonDetails1.bdcEndSecureDate.DateTime = (DateTime?) null;
			}
			uC_ViewPersonDetails1.TcoSex.Text = (bool) MainRadGridView.SelectedRows[0].Cells["Person_isWoman"].Value
			                                    	? "مونث"
			                                    	: "مذکر";
			if (!(MainRadGridView.SelectedRows[0].Cells["Person_Picture"].Value is DBNull) &&
			    MainRadGridView.SelectedRows[0].Cells["Person_Picture"].Value != null)
			{
				var Picture = new byte[0];
				if (isNew == false)
				{
					Picture = ((byte[]) MainRadGridView.SelectedRows[0].Cells["Person_Picture"].Value);
				}
				else
				{
					using (var ms = new System.IO.MemoryStream())
					{
						((Bitmap) MainRadGridView.SelectedRows[0].Cells["Person_Picture"].Value).
							Save(ms,
							     System.
							     	Drawing
							     	.
							     	Imaging
							     	.
							     	ImageFormat
							     	.Jpeg);
						Picture = ms.ToArray();
						//MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = picture.Length > 0
						//                                                               ? picture
						//                                                               : null;
					}
				}
				if (Picture.Length > 0)
				{
					uC_ViewPersonDetails1.ImgData = Picture;
				}
				else
				{
					uC_ViewPersonDetails1.ImgData = new byte[0];
				}
			}
			else
			{
				uC_ViewPersonDetails1.ImgData = new byte[0];
			}


			//Get BlackList Status from Server
			//var temp = decimal.Parse(MainRadGridView.SelectedRows[0].Cells["Person_ID"].Value!=null;
			//if (BlackListData.ContainsKey(temp))
			//    uC_ViewPersonDetails1.TcoIsBlack.SelectedIndex = (BlackListData[temp] == false) ? 1 : 0;
			//else
			//    uC_ViewPersonDetails1.TcoIsBlack.SelectedIndex = 1;
		}

		private void rmiStatusView_Click(object sender, EventArgs e)
		{
			cbbView_Click(sender, e);
			rightsEnableControls();

		}

		private void rmiDriver_Click(object sender, EventArgs e)
		{
			cbbSearch_Click(sender, e);
			rightsEnableControls();
		}

		protected void rmiStatusNew_Click(object sender, EventArgs e)
		{
			cbbNew_Click(sender, e);
			rightsEnableControls();
		}

		protected void rmiStatusEdit_Click(object sender, EventArgs e)
		{
			cbbEdit_Click(sender, e);
			rightsEnableControls();
		}

		private void rmiCollectPrint_Click(object sender, EventArgs e)
		{
			cbbCollectPrint_Click(sender, e);
			rightsEnableControls();
		}

		private void rmiStatusExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void rmiCut_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^X");
		}

		private void rmiPaste_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^V");
		}

		private void rmiCopy_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^C");
		}

		private void rmiSave_Click(object sender, EventArgs e)
		{
			cbbSave_Click(sender, e);
			rightsEnableControls();
		}

		private void rmiCancel_Click(object sender, EventArgs e)
		{
			cbbCancel_Click(sender, e);
			rightsEnableControls();
		}

		private void rmiHelp2_Click(object sender, EventArgs e)
		{

		}

		private void rmiAbout_Click(object sender, EventArgs e)
		{

		}

		private void rmiOnePrint_Click(object sender, EventArgs e)
		{

		}

		private void rmiStatusSettingPrint_Click(object sender, EventArgs e)
		{

		}

		private void cbbNoPassage_Click(object sender, EventArgs e)
		{
			try
			{
				//if (!QuestionSureTo("آیا قصد عدم تصویب درخواست مجوز را دارید؟"))
				//{
				//    return;
				//}

				var frmDialog = new frm_GetMessage ();
				if ( frmDialog.ShowDialog () != DialogResult.OK )
				{
					return;
				}

                result = objManager.ClsPacksGps_passage(IndexPack, AllFunctions._StatusPack.NoPassage, frmDialog.message, new DataTable());
				if (result.success)
				{
                    string mailMessage = string.Empty;
                    aorc.gatepass.ui.mail.MailBarid requestMail = new aorc.gatepass.ui.mail.MailBarid();
                    if (!requestMail.SendMail(ItemsPublic.MyBaridId, (decimal)rgvPack.CurrentRow.Cells["OperRequestBaridId"].Value, (decimal)IndexPack, "عدم تصویب مجوز", "بسته رد تصویب شد با این توضیحات که "+frmDialog.message))
                    {
                        mailMessage = "\r\n\r\n" + "اما ارسال پیام در اتوماسیون ناموفق بود";
                    }

                    MessageBox.Show("بسته در مرحله تصویب رد شد" + mailMessage);
					CloseOk();
				}
				else
				{
					MessageBox.Show(result.Message);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cbbNoConfirm_Click(object sender, EventArgs e)
		{
			try
			{
				//if (!QuestionSureTo("آیا قصد عدم تایید درخواست مجوز را دارید؟"))
				//{
				//    return;
				//}
				var frmDialog = new frm_GetMessage();
				if ( frmDialog.ShowDialog() != DialogResult.OK )
				 {
				 	return;
				 }
                result = objManager.ClsPacksGps_confirm(IndexPack, AllFunctions._StatusPack.NoConfirm, frmDialog.message, null);
				if (result.success)
				{

                    string mailMessage = string.Empty;
                    aorc.gatepass.ui.mail.MailBarid requestMail = new aorc.gatepass.ui.mail.MailBarid();
                    if (!requestMail.SendMail(ItemsPublic.MyBaridId, (decimal)rgvPack.CurrentRow.Cells["OperRequestBaridId"].Value, (decimal)IndexPack, "عدم تایید مجوز", "بسته رد تایید شد با این توضیحات که "+frmDialog.message))
                    {
                        mailMessage = "\r\n\r\n" + "اما ارسال پیام در اتوماسیون ناموفق بود";
                    }

                    MessageBox.Show("بسته تایید نشد" + mailMessage);
					CloseOk();
				}
				else
				{
					MessageBox.Show(result.Message);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cbbPassage_Click(object sender, EventArgs e)
		{
			try
			{
				if (!QuestionSureTo("آیا قصد تصویب درخواست مجوز را دارید؟"))
				{
					return;
				}
                result = objManager.ClsPacksGps_passage(IndexPack, AllFunctions._StatusPack.Passage, null, new DataTable());
				if (result.success)
				{
					MessageBox.Show("بسته تصویب شد");
					CloseOk();
				}
				else
				{
					MessageBox.Show(result.Message);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cbbConfirm_Click(object sender, EventArgs e)
		{
			try
			{
				if ( !QuestionSureTo ( "آیا قصد تایید درخواست مجوز را دارید؟" ) )
				{
					return;
				}

				//var frmDialog = new frm_GetMessage();
				//if ( frmDialog.ShowDialog() != DialogResult.OK )
				// {
				//    return;
				// }

                result = objManager.ClsPacksGps_confirm(IndexPack, AllFunctions._StatusPack.Confirm, null, new DataTable());
				if (result.success)
				{
					MessageBox.Show("بسته تایید شد");
					CloseOk();
				}
				else
				{
					MessageBox.Show(result.Message);
				}
				//	this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cbbRequest_Click(object sender, EventArgs e)
		{
            //if (!QuestionSureTo("آیا قصد ارسال درخواست مجوز را دارید؟"))
            //{
            //    return;
            //}

            frm_SelectConfirmer objC = new frm_SelectConfirmer();
            objC.ShowDialog();
            if (objC.DialogResult == DialogResult.OK)
            {
                BaridIdConfirmer = objC.BaridIdConfirmer;
			    SavePackInDataBase(AllFunctions._StatusPack.Request);
            }
		}
        private decimal? BaridIdConfirmer = null;
		private void MainRadGridView_SelectionChanged(object sender, EventArgs e)
		{
			SetProperties();
		}

		private void cbbSaveTo_Click(object sender, EventArgs e)
		{

			// emale taghirat age mode edit hastim?
			// afzodane taghirat age mode new hastim
			// pass dadane natijeh be form ghabli 
			// peighame monaseb
			// bastane form
			//posPack = AllFunctions._StatusPack.

			SavePackInDataBase(AllFunctions._StatusPack.Create);

		}

		public OutputDatas gotResult()
		{
			return result;
		}

		private decimal? personIdDriver()
		{
			if (v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked)
			{
				foreach (var row in MainRadGridView.Rows)
				{
					if ((bool?) row.Cells["GatePass_IsDriver"].Value == true)
					{
						return ((decimal?) row.Cells["Person_ID"].Value);
					}
				}
			}
			return null;
		}

		private void SavePackInDataBase(AllFunctions._StatusPack pos)
		{
			try
			{
				IEnumerable<decimal> personsId = (MainRadGridView.Rows.Where(x => true)).Select(gridViewRowInfo =>
				                                                                                (decimal)
				                                                                                gridViewRowInfo.Cells["Person_ID"].
				                                                                                	Value).ToList();
				if (isNew && IndexPack == null)
				{
                    result = objManager.ClsPacksGps_insertPackGpsOldVersion(
						(v01_uC_packDetailsGatePlace1.bdcStartDate.SelectedDate != null)
							? v01_uC_packDetailsGatePlace1.bdcStartDate.SelectedDate.Value
							: (DateTime?) null,
						(v01_uC_packDetailsGatePlace1.bdcEndDate.SelectedDate != null)
							? v01_uC_packDetailsGatePlace1.bdcEndDate.SelectedDate.Value
							: (DateTime?) null,
						v01_uC_packDetailsGatePlace1.CurrentAgreeId,
						v01_uC_packDetailsGatePlace1.CurrentTravelId,
						v01_uC_packDetailsGatePlace1.tbPackDescriptions.Text.Trim(), v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex,
						personsId,
						personIdDriver(),
						v01_uC_packDetailsGatePlace1.CurrentCarId, pos, v01_uC_packDetailsGatePlace1.rddlShift.Text.Trim()
						, v01_uC_packDetailsGatePlace1.CurrentGates, v01_uC_packDetailsGatePlace1.CurrentPlaces);
					if (result.success)
					{
                     //   isNew = false;
                        IndexPack = (decimal?)result.ResultTable.Rows[0]["package_Id"];
                        string mailMessage = string.Empty;
                        if (pos == AllFunctions._StatusPack.Request)
                        {
                            aorc.gatepass.ui.mail.MailBarid requestMail = new aorc.gatepass.ui.mail.MailBarid();
                            if (!requestMail.SendMail(ItemsPublic.MyBaridId, (decimal)BaridIdConfirmer, (decimal)IndexPack, "درخواست مجوز عبور",string.Empty))
                            {
                                mailMessage = "\r\n\r\n" + "اما ارسال پیام در اتوماسیون ناموفق بود";
                            }
                        }
                        
						string hint = ConvertNumbers.Int64ToBase36 ( long.Parse ( result.ResultTable.Rows [0] ["package_Id"].ToString () ) );

                        ItemsPublic.ShowMessage("عملیات با موفقیت انجام شد" + "\r\n" + "شماره پیگیری" + "\r\n\r\n" + hint + mailMessage);
					//	ItemsPublic.ShowMessage ( "عملیات با موفقیت انجام شد" + "\r\n" + "شماره پیگیری" + " : " +"\r\n"+ hint );
						//ItemsPublic.ShowMessage("عملیات با موفقیت انجام شد" + "\r\n" + "شماره پیگیری" + "\r\n" + hint+" <=");
						if (pos != AllFunctions._StatusPack.Create)
							CloseOk();
					}
					else
					{
						MessageBox.Show(result.Message);
					}
				}
				else
				{
                    result = objManager.ClsPacksGps_updatePackGpsOldVersion(
						IndexPack,
						v01_uC_packDetailsGatePlace1.tbPackDescriptions.Text.Trim(),
						v01_uC_packDetailsGatePlace1.CurrentAgreeId,
						v01_uC_packDetailsGatePlace1.CurrentTravelId,
						(v01_uC_packDetailsGatePlace1.bdcStartDate.SelectedDate != null)
							? v01_uC_packDetailsGatePlace1.bdcStartDate.SelectedDate.Value
							: (DateTime?) null,
						(v01_uC_packDetailsGatePlace1.bdcEndDate.SelectedDate != null)
							? v01_uC_packDetailsGatePlace1.bdcEndDate.SelectedDate.Value
							: (DateTime?) null,
						v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex, personsId, personIdDriver(),
						v01_uC_packDetailsGatePlace1.CurrentCarId, pos,
						v01_uC_packDetailsGatePlace1.rddlShift.Text.Trim()
						, v01_uC_packDetailsGatePlace1.CurrentGates, v01_uC_packDetailsGatePlace1.CurrentPlaces);
					if (result.success)
					{
						//MessageBox.Show("عملیات با موفقیت انجام شد");
						string hint = ConvertNumbers.Int64ToBase36 ( long.Parse ( result.ResultTable.Rows [0] ["package_Id"].ToString () ) );
                        string mailMessage = string.Empty;
                        if (pos == AllFunctions._StatusPack.Request)
                        {
                            aorc.gatepass.ui.mail.MailBarid requestMail = new aorc.gatepass.ui.mail.MailBarid();
                            if (!requestMail.SendMail(ItemsPublic.MyBaridId, (decimal)BaridIdConfirmer, decimal.Parse((result.ResultTable.Rows[0]["package_Id"].ToString())), "درخواست مجوز عبور",string.Empty))
                            {
                                mailMessage ="\r\n\r\n"+ "اما ارسال پیام در اتوماسیون ناموفق بود";
                            }
                        }


                        ItemsPublic.ShowMessage("عملیات با موفقیت انجام شد" + "\r\n" + "شماره پیگیری" + "\r\n\r\n" + hint + mailMessage);
						//ItemsPublic.ShowMessage ( "عملیات با موفقیت انجام شد" + "\r\n" + "شماره پیگیری" + " : " + hint );
						//ItemsPublic.ShowMessage ( "عملیات با موفقیت انجام شد" + "\r\n" + "به شماره پیگیری زیر" + "\r\n" +"=> "+ hint+" <=" );
						if (pos != AllFunctions._StatusPack.Create)
							CloseOk();
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
				//MessageBox.Show ( "اطلاعات وارده کامل نمی باشد" );
			}
		}

		private void v01_uC_packDetailsGatePlace1_eventTickVehicle()
		{
			try
			{
				cbbDriver.Enabled = v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked && MainRadGridView.CurrentRow != null &&
				                    cbbEdit.Enabled;
				//eventStatusView();
				//	MainRadGridView.Enabled = true;
				//	objManager.ChangeStatus ( aorc.gatepass.ItemsPublic.IndexStatus.viewPack );
				if (v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked)
				{
					if (! (CurrentDriverId == null && personIdDriver() == null))
					{
						//	ItemsPublic.Exeptor ( "راننده ای برای خودرو انتخاب نشده است" );

						if (CurrentDriverId != null)
						{
							foreach (var row in MainRadGridView.Rows)
							{
								if ((bool) row.Cells["GatePass_IsDriver"].Value)
								{
									//break;

									row.Cells["GatePass_IsDriver"].Value = false;

									break;
								}
							}
							foreach (var row in MainRadGridView.Rows)
							{
								if ((decimal) row.Cells["Person_ID"].Value == CurrentDriverId)
								{
									//	break;
									row.Cells["GatePass_IsDriver"].Value = true;
									break;
								}
							}
							//	MainRadGridView.EndEdit ();
							//	MainRadGridView.CloseEditor();
							//	MainRadGridView.Refresh();
							CurrentDriverId = null;
						}
					}
				}
				else
				{
					CurrentDriverId = null;
					foreach (var row in MainRadGridView.Rows)
					{
						if ((bool) row.Cells["GatePass_IsDriver"].Value)
						{
							row.Cells["GatePass_IsDriver"].Value = false;
							//MainRadGridView.EndEdit ();
							//MainRadGridView.CloseEditor ();
							//MainRadGridView.Refresh ();
							break;
						}
					}
				}
				//ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}
		}

		private void CloseOk()
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void rmiPropertyPerson_Click(object sender, EventArgs e)
		{
			toolWindowPropertiesPerson.Show();
		}

		private void rmiSettingsPack_Click(object sender, EventArgs e)
		{
			toolWindowPropertiesPack.Show();
		}

		private void rmiGPTable_Click(object sender, EventArgs e)
		{
			documentWindowGatePasses.Show();
		}

		private void radDock1_DockWindowClosed(object sender, DockWindowEventArgs e)
		{
			switch (e.DockWindow.Name)
			{
				case "toolWindowPropertiesPerson":
					toolWindowPropertiesPerson.Visible = false;
					break;
				case "documentWindowGatePasses":
					documentWindowGatePasses.Visible = false;
					break;
			}
			if (!toolWindowPropertiesPerson.Visible && !documentWindowGatePasses.Visible)
			{
				cbbCancel_Click(sender, e);
			}
		}

		public void SetSetting(aorc.gatepass.v01_UC_packDetailsNewGatePlace obj)
		{
            v01_uC_packDetailsGatePlace1.rtbPlaces.Text = obj.rtbPlaces.Text.Trim();
            v01_uC_packDetailsGatePlace1.CurrentPlaces = obj.CurrentPlaces;

            v01_uC_packDetailsGatePlace1.rtbGates.Text = obj.rtbGates.Text.Trim();
            v01_uC_packDetailsGatePlace1.CurrentGates = obj.CurrentGates;

			v01_uC_packDetailsGatePlace1.rddlTypePack.SelectedIndex = obj.rddlTypePack.SelectedIndex;
			v01_uC_packDetailsGatePlace1.bdcStartDate.DateTime = obj.bdcStartDate.DateTime;
			v01_uC_packDetailsGatePlace1.bdcEndDate.DateTime = obj.bdcEndDate.DateTime;
			v01_uC_packDetailsGatePlace1.rtbNumberAgree.Text = obj.rtbNumberAgree.Text.Trim();
			v01_uC_packDetailsGatePlace1.CurrentAgreeId = obj.CurrentAgreeId;
			v01_uC_packDetailsGatePlace1.rtbCompanyAgree.Text = obj.rtbCompanyAgree.Text.Trim();
			v01_uC_packDetailsGatePlace1.rtbTitleAgree.Text = obj.rtbTitleAgree.Text.Trim();
			v01_uC_packDetailsGatePlace1.rlblCountCar.Text = obj.rlblCountCar.Text.Trim();
			v01_uC_packDetailsGatePlace1.rddlShift.Text = obj.rddlShift.Text.Trim();

			v01_uC_packDetailsGatePlace1.CurrentTravelId = obj.CurrentTravelId;

			v01_uC_packDetailsGatePlace1.rtbTravelLabel.Text = obj.rtbTravelLabel.Text.Trim();

			v01_uC_packDetailsGatePlace1.tbPackDescriptions.Text = obj.tbPackDescriptions.Text.Trim();

			//v01_uC_packDetailsGatePlace1.uC_vehicleDetails21.rddlType.SelectedIndex =
			v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked = obj.rcbHaveVehicle.Checked;
			if (v01_uC_packDetailsGatePlace1.rcbHaveVehicle.Checked)
			{

				v01_uC_packDetailsGatePlace1.CurrentCarId = obj.CurrentCarId;
				v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rtbModel.Text =

					obj.uC_vehicleDetails31.rtbModel.Text.Trim();
				v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rtbColor.Text =
					obj.uC_vehicleDetails31.rtbColor.Text.Trim();

                v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex =
                    obj.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex;

                v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.uC_PlatesCar1.CarNumber =
					obj.uC_vehicleDetails31.uC_PlatesCar1.CarNumber;

				v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.rddlState.SelectedIndex =
					obj.uC_vehicleDetails31.rddlState.SelectedIndex;

				v01_uC_packDetailsGatePlace1.uC_vehicleDetails31.indexTypeModel = obj.uC_vehicleDetails31.indexTypeModel;
			}
		}

		private void MainRadGridView_RowFormatting(object sender, RowFormattingEventArgs e)
		{
			//if ( int.Parse ( e.RowElement.RowInfo.Cells ["CountPrinted"].Value.ToString () ) == 0 )

			if (e != null)
				if (e.RowElement != null)
					if (!(e.RowElement is GridTableHeaderRowElement))
						if (e.RowElement.RowInfo.Cells["CountPrinted"] != null)
							if (e.RowElement.RowInfo.Cells["CountPrinted"].Value != null)
							{
								if (int.Parse(e.RowElement.RowInfo.Cells["CountPrinted"].Value.ToString()) > 0)
								{
									e.RowElement.DrawFill = true;
									e.RowElement.BackColor = Color.LightBlue;
								}
								else if (!(bool) e.RowElement.RowInfo.Cells["Person_HaveForm"].Value)
								{
									e.RowElement.DrawFill = true;
									e.RowElement.BackColor = Color.PaleGoldenrod;
								}
								else
								{
									e.RowElement.DrawFill = true;
									e.RowElement.BackColor = Color.White;
								}
							}
		}

		private void uC_ViewPersonDetails1_eventUpdatePic()
		{
			Manager objM = new Manager();

			decimal ID = decimal.Parse(MainRadGridView.SelectedRows[0].Cells["Person_ID"].Value.ToString());
			bool idCodeValid;
			if (uC_ViewPersonDetails1.rmeIdentifyCode.Text.Trim() == string.Empty ||
			    uC_ViewPersonDetails1.rmeIdentifyCode.Text.Trim() == "0")
			{
				idCodeValid = false;
			}
			else
			{
				idCodeValid = true;
			}
			result = objM.ClsPersons_update(ID, uC_ViewPersonDetails1.rtbName.Text.Trim(),
			                                uC_ViewPersonDetails1.rtbSurname.Text.Trim(),
			                                uC_ViewPersonDetails1.rmebNationalCode.Text.Trim(),
			                                uC_ViewPersonDetails1.TcoNationality.Text.Trim(),
			                                uC_ViewPersonDetails1.rtbFatherName.Text.Trim(),
			                                uC_ViewPersonDetails1.TcoBirthCity.Text.Trim()
			                                ,
			                                (uC_ViewPersonDetails1.bdcBirthDate.SelectedDate != null)
			                                	? uC_ViewPersonDetails1.bdcBirthDate.SelectedDate.Value
			                                	: (DateTime?) null,
			                                uC_ViewPersonDetails1.rmebLicenseDriveCode.Text.Trim(),
			                                uC_ViewPersonDetails1.rmebPhone1.Text.Trim(),
			                                uC_ViewPersonDetails1.rmebPhone2.Text.Trim()
			                                , (uC_ViewPersonDetails1.TcoHaveForm.Text == "دارد") ? true : false,
			                                (uC_ViewPersonDetails1.TcoSex.Text == "مونث") ? true : false,
			                                uC_ViewPersonDetails1.TcoRegisterCity.Text.Trim()
			                                , uC_ViewPersonDetails1.ImgData,
			                                (idCodeValid == true)
			                                	? uC_ViewPersonDetails1.rmeIdentifyCode.Text.Trim()
			                                	: string.Empty
			                                , uC_ViewPersonDetails1.rtbRegisterCode.Text.Trim(),
			                                (uC_ViewPersonDetails1.bdcEndSecureDate.SelectedDate != null)
			                                	? uC_ViewPersonDetails1.bdcEndSecureDate.SelectedDate.Value
			                                	: (DateTime?) null);
			if (result.success == false)
			{
				ItemsPublic.ShowMessage(result.Message);
				return;
			}
			cbbView_Click(null, null);
			cbbSave_Click(null, null);
		}

		private void cbbCollectPrint_Click(object sender, EventArgs e)
		{
			try
			{
				//eventStatusDelete();
				//MainRadGridView.Enabled = true;
				//objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toDelete);
				////ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toDelete;
				//cbbSave_Click(sender, e);
				//cbbCancel_Click(sender, e);
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}
		}

		private void cbbOnePrint_Click(object sender, EventArgs e)
		{
			try
			{
				if (MainRadGridView.SelectedRows.Count() == 1)
				{
					decimal IDG = (decimal) MainRadGridView.CurrentRow.Cells["Gatepass_ID"].Value;

					var ResultPrint = objManager.ClsPacksGps_RequestPrintGP(null);
					if (ResultPrint.success)
					{
						ReportViewerGP.ShowReport(ResultPrint.ResultTable);
					}
					else
					{
						ItemsPublic.ShowMessage(ResultPrint.Message);
					}
				}
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
			}
		}

		private void cbbExpire_Click(object sender, EventArgs e)
		{
			try
			{
				if (MainRadGridView.SelectedRows.Count() == 1)
				{
					var IDG = (decimal) MainRadGridView.CurrentRow.Cells["Gatepass_ID"].Value;
					var Resultexpire = objManager.ClsPacksGps_ExpireGp(IDG);
					if (Resultexpire.success)
					{
						ItemsPublic.ShowMessage(Resultexpire.success ? "مجوز عبور مورد نظر منقضی شد" : Resultexpire.Message);
						MainRadGridView.SelectedRows[0].Cells["GatePass_IsExpired"].Value = true;
					}
					else
					{
						ItemsPublic.ShowMessage(Resultexpire.Message);
					}
				}
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
			}
		}

		private RadMenuItem rightCbbView = new RadMenuItem();
		private RadMenuItem rightCbbNew = new RadMenuItem();
		private RadMenuItem rightCbbEdit = new RadMenuItem();
		private RadMenuItem rightCbbDriver = new RadMenuItem();
		private RadMenuItem rightCbbOnePrint = new RadMenuItem();
		private RadMenuItem rightCbbExpire = new RadMenuItem();
		private RadMenuItem rightCbbExit = new RadMenuItem();
		private RadMenuItem rightCbbSecure = new RadMenuItem();

		protected void setAllMouseMenus()
		{
			setAllRightMenusCopy();
			contextMenu.Items.AddRange(rightCbbView, rightCbbNew, rightCbbEdit, rightCbbDriver, rightCbbSecure
			                           , rightCbbOnePrint, rightCbbExpire, rightCbbExit);
			MainRadGridView.ContextMenuOpening += new ContextMenuOpeningEventHandler(MainRadGridView_ContextMenuOpening);
		}

		private void setAllRightMenusCopy()
		{
			// cbbView
			this.rightCbbView.AccessibleDescription = "مشاهده";
			this.rightCbbView.AccessibleName = "مشاهده";
			this.rightCbbView.FlipText = false;
			this.rightCbbView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
			                                                 System.Drawing.GraphicsUnit.Point, ((byte) (178)));
			this.rightCbbView.Image = global::aorc.gatepass.Properties.Resources._52g;
			this.rightCbbView.Name = "cbbView";

			this.rightCbbView.Text = "بازآوری";
			this.rightCbbView.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.rightCbbView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbView.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbView.Click += new System.EventHandler(this.cbbView_Click);
			// 
			// cbbNew
			// 
			this.rightCbbNew.AccessibleDescription = "جدید";
			this.rightCbbNew.AccessibleName = "جدید";
			this.rightCbbNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
			                                                System.Drawing.GraphicsUnit.Point, ((byte) (178)));
			this.rightCbbNew.Image = global::aorc.gatepass.Properties.Resources.personsg;
			this.rightCbbNew.Name = "cbbNew";

			this.rightCbbNew.Text = "انتخاب افراد";
			this.rightCbbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbNew.Click += new System.EventHandler(this.cbbNew_Click);
			// 

			// cbbEdit
			// 
			this.rightCbbEdit.AccessibleDescription = "ویرایش";
			this.rightCbbEdit.AccessibleName = "ویرایش";
			this.rightCbbEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
			                                                 System.Drawing.GraphicsUnit.Point, ((byte) (178)));
			this.rightCbbEdit.Image = global::aorc.gatepass.Properties.Resources.editg;
			this.rightCbbEdit.Name = "cbbEdit";

			this.rightCbbEdit.Text = "تنظیمات بسته";
			this.rightCbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbEdit.Click += new System.EventHandler(this.cbbEdit_Click);
			//
			//rightCbbSecure
			//
			this.rightCbbSecure.AccessibleDescription = "وضعیت حفاظتی";
			this.rightCbbSecure.AccessibleName = "وضعیت حفاظتی";
			this.rightCbbSecure.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
			                                                   System.Drawing.GraphicsUnit.Point, ((byte) (178)));
			this.rightCbbSecure.Image = global::aorc.gatepass.Properties.Resources.agent16;
			this.rightCbbSecure.Name = "CbbSecure";

			this.rightCbbSecure.Text = "وضعیت حفاظتی";
			this.rightCbbSecure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbSecure.ToolTipText = "تنظیم وضعیت فرد انتخابی از نظر داشتن فرم حفاظتی";
			this.rightCbbSecure.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbSecure.Click += new System.EventHandler(this.cbbSecureForm_Click);
			// 
			// cbbDriver
			// 
			this.rightCbbDriver.AccessibleDescription = "راننده";
			this.rightCbbDriver.AccessibleName = "راننده";
			this.rightCbbDriver.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
			                                                   System.Drawing.GraphicsUnit.Point, ((byte) (178)));
			this.rightCbbDriver.Image = global::aorc.gatepass.Properties.Resources.carg;
			this.rightCbbDriver.Name = "cbbDriver";

			this.rightCbbDriver.Text = "انتخاب راننده";
			this.rightCbbDriver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbDriver.ToolTipText = "انتخاب فرد جاری به عنوان راننده";
			this.rightCbbDriver.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbDriver.Click += new System.EventHandler(this.cbbSearch_Click);
			// 

			// cbbOnePrint
			// 
			this.rightCbbOnePrint.AccessibleDescription = "چاپ انتخابی";
			this.rightCbbOnePrint.AccessibleName = "چاپ انتخابی";
			this.rightCbbOnePrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
			                                                     System.Drawing.GraphicsUnit.Point, ((byte) (178)));
			this.rightCbbOnePrint.Image = global::aorc.gatepass.Properties.Resources.print_icong;
			this.rightCbbOnePrint.Name = "cbbOnePrint";

			this.rightCbbOnePrint.Text = "چاپ انتخابی";
			this.rightCbbOnePrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbOnePrint.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbOnePrint.Click += new System.EventHandler(this.cbbOnePrint_Click);
			// 

			// cbbExpire
			// 
			this.rightCbbExpire.AccessibleDescription = "منقضی کردن مجوز عبور";
			this.rightCbbExpire.AccessibleName = "منقضی کردن مجوز عبور";
			this.rightCbbExpire.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
			                                                   System.Drawing.GraphicsUnit.Point, ((byte) (178)));
			this.rightCbbExpire.Image = global::aorc.gatepass.Properties.Resources.abortg;
			this.rightCbbExpire.Name = "cbbExpire";

			this.rightCbbExpire.Text = "خاتمه مجوز";
			this.rightCbbExpire.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.rightCbbExpire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbExpire.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbExpire.Click += new System.EventHandler(this.cbbExpire_Click);

			// exit
			this.rightCbbExit.AccessibleDescription = "خروج";
			this.rightCbbExit.AccessibleName = "خروج";
			this.rightCbbExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
			                                                 System.Drawing.GraphicsUnit.Point, ((byte) (178)));
			this.rightCbbExit.Image = global::aorc.gatepass.Properties.Resources.exitg;
			this.rightCbbExit.Name = "rightCbbExit";
			this.rightCbbExit.Text = "خروج";
			this.rightCbbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbExit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbExit.Click += new System.EventHandler(this.rmiStatusExit_Click);
		}

		private void MainRadGridView_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
		{
			e.ContextMenu = contextMenu;
		}

		private void cbbSecureForm_Click(object sender, EventArgs e)
		{
			try
			{
				if (MainRadGridView.SelectedRows.Count() == 1)
				{
					var frmSecure = new gatepass.ui.package.frm_SecureUpdate();
					frmSecure.showProperties(
						uC_ViewPersonDetails1.rtbName.Text
						, uC_ViewPersonDetails1.rtbSurname.Text
						, uC_ViewPersonDetails1.TcoSex.Text
						, uC_ViewPersonDetails1.rmebNationalCode.Text
						, uC_ViewPersonDetails1.bdcEndSecureDate.DateTime
						, (bool) MainRadGridView.SelectedRows[0].Cells["Person_HaveForm"].Value
						);
					frmSecure.ShowDialog();
					if (frmSecure.DialogResult == DialogResult.OK)
					{
						Manager objM = new Manager();
						decimal ID = decimal.Parse(MainRadGridView.SelectedRows[0].Cells["Person_ID"].Value.ToString());
						bool idCodeValid;
						if (uC_ViewPersonDetails1.rmeIdentifyCode.Text.Trim() == string.Empty ||
						    uC_ViewPersonDetails1.rmeIdentifyCode.Text.Trim() == "0")
						{
							idCodeValid = false;
						}
						else
						{
							idCodeValid = true;
						}
						result = objM.ClsPersons_update(ID, uC_ViewPersonDetails1.rtbName.Text.Trim(),
						                                uC_ViewPersonDetails1.rtbSurname.Text.Trim(),
						                                uC_ViewPersonDetails1.rmebNationalCode.Text.Trim(),
						                                uC_ViewPersonDetails1.TcoNationality.Text.Trim(),
						                                uC_ViewPersonDetails1.rtbFatherName.Text.Trim(),
						                                uC_ViewPersonDetails1.TcoBirthCity.Text.Trim()
						                                ,
						                                (uC_ViewPersonDetails1.bdcBirthDate.SelectedDate != null)
						                                	? uC_ViewPersonDetails1.bdcBirthDate.SelectedDate.Value
						                                	: (DateTime?) null,
						                                uC_ViewPersonDetails1.rmebLicenseDriveCode.Text.Trim(),
						                                uC_ViewPersonDetails1.rmebPhone1.Text.Trim(),
						                                uC_ViewPersonDetails1.rmebPhone2.Text.Trim()
						                                , frmSecure.haveForm
						                                , (uC_ViewPersonDetails1.TcoSex.Text == "مونث")
						                                , uC_ViewPersonDetails1.TcoRegisterCity.Text.Trim()
						                                , uC_ViewPersonDetails1.ImgData,
						                                idCodeValid ? uC_ViewPersonDetails1.rmeIdentifyCode.Text.Trim() : string.Empty
						                                , uC_ViewPersonDetails1.rtbRegisterCode.Text.Trim()
						                                , frmSecure.dtEndSecure);
						cbbView_Click(null, null);
						cbbSave_Click(null, null);
					}
					frmSecure.Close();
				}
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
			}
		}

		private void MasterTemplate_CustomGrouping(object sender, GridViewCustomGroupingEventArgs e)
		{
			bool? value = null;
			//            if (e != null)
			//                if (e.Row != null)
			//if(e.Row.Cells!=null)
			//if(e.Row.Cells.Count>0)
			//if(e.Row.Cells["GatePass_IsExpired"]!=null)
			//{
			value = (bool?) e.Row.Cells["GatePass_IsExpired"].Value;
			switch (value)
			{
				case true:
					e.GroupKey = "درخواست های منقضی شده";

					break;
				default:
					e.GroupKey = "درخواست های معتبر";
					break;
			}
			//	}
		}

		private void MainRadGridView_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
		{
			if (e.Value == null)
			{
				e.FormatString = e.Group.Key.ToString();
			}
		}

		private void frm_GatePassesGatePlace_Shown(object sender, EventArgs e)
		{
			if (pmStatus == ItemsPublic.IndexStatus.toNew)
			{
				cbbNew_Click(sender, e);
				cbbEdit_Click(sender, e);
			}
			if (MainRadGridView.Rows.Count > 0)
			{
				MainRadGridView.Groups[0].HeaderRow.IsExpanded = true;
				MainRadGridView.Groups[0].Expand();
			}
		}
        //private RadGridView rgv_Pack;
        private OutputDatas RMail;
        internal void setItemsPack(decimal IdPack)
        {
            RMail = new OutputDatas();
           // rgv_Pack = new RadGridView();

            RMail = objManager.View_packages(null, null, null, null, null, null, null, null, null, null, null, null, IdPack.ToString().Trim(), null, null, null, null);
            if (RMail.success)
            {
                if (RMail.ResultTable.Rows.Count != 1)
                {
                    ItemsPublic.Exeptor("بسته یافت نشد");
                }
                radGridViewPacks.DataSource = RMail.ResultTable;
                radGridViewPacks.CurrentRow = radGridViewPacks.Rows[0];
                rgvPack = radGridViewPacks;
                

                

            //    #region rgv_Pack Details
            //    rgv_Pack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            //    rgv_Pack.CausesValidation = false;
            //    rgv_Pack.MasterTemplate.AllowAddNewRow = false;
            //    rgv_Pack.MasterTemplate.AutoGenerateColumns = false;

            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn11 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn12 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn13 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn14 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            //    Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn15 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn16 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn17 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn18 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn19 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            //    Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
                
            ////    rgv_Pack.MasterTemplate.AllowAddNewRow = true;
            //  //  rgv_Pack.MasterTemplate.AutoGenerateColumns = false;
            //    gridViewTextBoxColumn1.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn1.FieldName = "Package_TicketId";
            //    gridViewTextBoxColumn1.HeaderText = "شماره بسته";
            //    gridViewTextBoxColumn1.Name = "Package_TicketId";
            //    gridViewTextBoxColumn1.Width = 90;
            //    gridViewTextBoxColumn2.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn2.FieldName = "TypePack_Name";
            //    gridViewTextBoxColumn2.HeaderText = "نوع بسته";
            //    gridViewTextBoxColumn2.Name = "TypePack_Name";
            //    gridViewTextBoxColumn2.Width = 117;
            //    gridViewTextBoxColumn3.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn3.FieldName = "Office_Name";
            //    gridViewTextBoxColumn3.HeaderText = "اداره متقاضی";
            //    gridViewTextBoxColumn3.Name = "Office_Name";
            //    gridViewTextBoxColumn3.Width = 178;
            //    gridViewDecimalColumn1.EnableExpressionEditor = false;
            //    gridViewDecimalColumn1.FieldName = "Vehicle_ID";
            //    gridViewDecimalColumn1.HeaderText = "آیدی خودرو";
            //    gridViewDecimalColumn1.IsVisible = false;
            //    gridViewDecimalColumn1.Name = "Vehicle_ID";
            //    gridViewDecimalColumn1.Width = 78;
            //    gridViewDecimalColumn2.EnableExpressionEditor = false;
            //    gridViewDecimalColumn2.FieldName = "Vehicle_number";
            //    gridViewDecimalColumn2.HeaderText = "شماره خودرو";
            //    gridViewDecimalColumn2.IsVisible = false;
            //    gridViewDecimalColumn2.Name = "Vehicle_number";
            //    gridViewDecimalColumn2.Width = 117;
            //    gridViewTextBoxColumn4.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn4.FieldName = "vehicle_Name";
            //    gridViewTextBoxColumn4.HeaderText = "نام خودرو";
            //    gridViewTextBoxColumn4.IsVisible = false;
            //    gridViewTextBoxColumn4.Name = "vehicle_Name";
            //    gridViewTextBoxColumn4.Width = 83;
            //    gridViewTextBoxColumn5.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn5.FieldName = "OperRequestName";
            //    gridViewTextBoxColumn5.HeaderText = "درخواست کننده";
            //    gridViewTextBoxColumn5.Name = "OperRequestName";
            //    gridViewTextBoxColumn5.Width = 157;
            //    gridViewTextBoxColumn6.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn6.FieldName = "OperConfirmName";
            //    gridViewTextBoxColumn6.HeaderText = "تایید کننده";
            //    gridViewTextBoxColumn6.Name = "OperConfirmName";
            //    gridViewTextBoxColumn6.Width = 159;
            //    gridViewTextBoxColumn7.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn7.FieldName = "OperPassageName";
            //    gridViewTextBoxColumn7.HeaderText = "تصویب کننده";
            //    gridViewTextBoxColumn7.Name = "OperPassageName";
            //    gridViewTextBoxColumn7.Width = 150;
            //    gridViewTextBoxColumn8.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn8.FieldName = "Package_Description";
            //    gridViewTextBoxColumn8.HeaderText = "توضیحات";
            //    gridViewTextBoxColumn8.IsVisible = false;
            //    gridViewTextBoxColumn8.Name = "Package_Description";
            //    gridViewDecimalColumn3.EnableExpressionEditor = false;
            //    gridViewDecimalColumn3.FieldName = "Agreement_ID";
            //    gridViewDecimalColumn3.HeaderText = "آیدی قرارداد";
            //    gridViewDecimalColumn3.IsVisible = false;
            //    gridViewDecimalColumn3.Name = "Agreement_ID";
            //    gridViewDecimalColumn4.EnableExpressionEditor = false;
            //    gridViewDecimalColumn4.FieldName = "Agreement_Number";
            //    gridViewDecimalColumn4.HeaderText = "شماره قرارداد";
            //    gridViewDecimalColumn4.Name = "Agreement_Number";
            //    gridViewDecimalColumn4.Width = 153;
            //    gridViewTextBoxColumn9.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn9.FieldName = "Agreement_Title";
            //    gridViewTextBoxColumn9.HeaderText = "عنوان قرارداد";
            //    gridViewTextBoxColumn9.Name = "Agreement_Title";
            //    gridViewTextBoxColumn9.Width = 247;
            //    gridViewTextBoxColumn10.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn10.FieldName = "Agreement_Company";
            //    gridViewTextBoxColumn10.HeaderText = "شرکت طرف قرارداد";
            //    gridViewTextBoxColumn10.Name = "Agreement_Company";
            //    gridViewTextBoxColumn10.Width = 205;
            //    gridViewTextBoxColumn11.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn11.FieldName = "TravelArea_LabelTravel";
            //    gridViewTextBoxColumn11.HeaderText = "مسیر تردد";
            //    gridViewTextBoxColumn11.Name = "TravelArea_LabelTravel";
            //    gridViewTextBoxColumn11.Width = 190;
            //    gridViewDecimalColumn5.EnableExpressionEditor = false;
            //    gridViewDecimalColumn5.FieldName = "Office_ID";
            //    gridViewDecimalColumn5.HeaderText = "آیدی اداره";
            //    gridViewDecimalColumn5.IsVisible = false;
            //    gridViewDecimalColumn5.Name = "Office_ID";
            //    gridViewDecimalColumn6.EnableExpressionEditor = false;
            //    gridViewDecimalColumn6.FieldName = "TravelArea_Id";
            //    gridViewDecimalColumn6.HeaderText = "آیدی محدوده تردد";
            //    gridViewDecimalColumn6.IsVisible = false;
            //    gridViewDecimalColumn6.Name = "TravelArea_Id";
            //    gridViewTextBoxColumn12.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn12.FieldName = "TravelArea_Name";
            //    gridViewTextBoxColumn12.HeaderText = "نام محدوده تردد";
            //    gridViewTextBoxColumn12.IsVisible = false;
            //    gridViewTextBoxColumn12.Name = "TravelArea_Name";
            //    gridViewDecimalColumn7.EnableExpressionEditor = false;
            //    gridViewDecimalColumn7.FieldName = "TravelArea_ParentId";
            //    gridViewDecimalColumn7.HeaderText = "آیدی محدوده والد";
            //    gridViewDecimalColumn7.IsVisible = false;
            //    gridViewDecimalColumn7.Name = "TravelArea_ParentId";
            //    gridViewDecimalColumn8.EnableExpressionEditor = false;
            //    gridViewDecimalColumn8.FieldName = "TypePack_Id";
            //    gridViewDecimalColumn8.HeaderText = "آیدی  نوع بسته";
            //    gridViewDecimalColumn8.IsVisible = false;
            //    gridViewDecimalColumn8.Name = "TypePack_Id";
            //    gridViewDecimalColumn9.EnableExpressionEditor = false;
            //    gridViewDecimalColumn9.FieldName = "OperRequestId";
            //    gridViewDecimalColumn9.HeaderText = "آیدی درخواست کننده";
            //    gridViewDecimalColumn9.IsVisible = false;
            //    gridViewDecimalColumn9.Name = "OperRequestId";
            //    gridViewDecimalColumn10.EnableExpressionEditor = false;
            //    gridViewDecimalColumn10.FieldName = "OperRequestBaridId";
            //    gridViewDecimalColumn10.HeaderText = "شماره برید درخواست کننده";
            //    gridViewDecimalColumn10.IsVisible = false;
            //    gridViewDecimalColumn10.Name = "OperRequestBaridId";
            //    gridViewDecimalColumn11.EnableExpressionEditor = false;
            //    gridViewDecimalColumn11.FieldName = "OperConfirmBaridId";
            //    gridViewDecimalColumn11.HeaderText = "شماره برید تایید کننده";
            //    gridViewDecimalColumn11.IsVisible = false;
            //    gridViewDecimalColumn11.Name = "OperConfirmBaridId";
            //    gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            //    gridViewCheckBoxColumn1.FieldName = "Package_IsExpired";
            //    gridViewCheckBoxColumn1.HeaderText = "منقضی شده";
            //    gridViewCheckBoxColumn1.IsVisible = false;
            //    gridViewCheckBoxColumn1.MinWidth = 20;
            //    gridViewCheckBoxColumn1.Name = "Package_IsExpired";
            //    gridViewCheckBoxColumn1.Width = 68;
            //    gridViewTextBoxColumn13.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn13.FieldName = "Package_Shift";
            //    gridViewTextBoxColumn13.HeaderText = "شیفت کاری";
            //    gridViewTextBoxColumn13.Name = "Package_Shift";
            //    gridViewTextBoxColumn13.Width = 66;
            //    gridViewDecimalColumn12.EnableExpressionEditor = false;
            //    gridViewDecimalColumn12.FieldName = "OperPassageId";
            //    gridViewDecimalColumn12.HeaderText = "آیدی تصویب کننده";
            //    gridViewDecimalColumn12.IsVisible = false;
            //    gridViewDecimalColumn12.Name = "OperPassageId";
            //    gridViewDecimalColumn13.EnableExpressionEditor = false;
            //    gridViewDecimalColumn13.FieldName = "Package_OfficePrintID";
            //    gridViewDecimalColumn13.HeaderText = "آیدی چاپی";
            //    gridViewDecimalColumn13.IsVisible = false;
            //    gridViewDecimalColumn13.Name = "Package_OfficePrintID";
            //    gridViewDecimalColumn14.EnableExpressionEditor = false;
            //    gridViewDecimalColumn14.FieldName = "OffPrintId";
            //    gridViewDecimalColumn14.HeaderText = "آیدی اداره چاپ";
            //    gridViewDecimalColumn14.IsVisible = false;
            //    gridViewDecimalColumn14.Name = "OffPrintId";
            //    gridViewTextBoxColumn14.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn14.FieldName = "OffPrintName";
            //    gridViewTextBoxColumn14.HeaderText = "نام اداره چاپ کننده";
            //    gridViewTextBoxColumn14.IsVisible = false;
            //    gridViewTextBoxColumn14.Name = "OffPrintName";
            //    gridViewDateTimeColumn1.EnableExpressionEditor = false;
            //    gridViewDateTimeColumn1.FieldName = "Package_StartDate";
            //    gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            //    gridViewDateTimeColumn1.HeaderText = "تاریخ شروع";
            //    gridViewDateTimeColumn1.IsVisible = false;
            //    gridViewDateTimeColumn1.Name = "Package_StartDate";
            //    gridViewDateTimeColumn2.EnableExpressionEditor = false;
            //    gridViewDateTimeColumn2.FieldName = "Package_EndDate";
            //    gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            //    gridViewDateTimeColumn2.HeaderText = "تاریخ پایان";
            //    gridViewDateTimeColumn2.IsVisible = false;
            //    gridViewDateTimeColumn2.Name = "Package_EndDate";
            //    gridViewDecimalColumn15.EnableExpressionEditor = false;
            //    gridViewDecimalColumn15.FieldName = "package_Id";
            //    gridViewDecimalColumn15.HeaderText = "آیدی بسته";
            //    gridViewDecimalColumn15.IsVisible = false;
            //    gridViewDecimalColumn15.Name = "package_Id";
            //    gridViewDecimalColumn16.EnableExpressionEditor = false;
            //    gridViewDecimalColumn16.FieldName = "OperConfirmId";
            //    gridViewDecimalColumn16.HeaderText = "آیدی تایید کننده";
            //    gridViewDecimalColumn16.IsVisible = false;
            //    gridViewDecimalColumn16.Name = "OperConfirmId";
            //    gridViewDecimalColumn17.EnableExpressionEditor = false;
            //    gridViewDecimalColumn17.FieldName = "OperPassageBaridId";
            //    gridViewDecimalColumn17.HeaderText = "شماره اتوماسیون تصویب کننده";
            //    gridViewDecimalColumn17.IsVisible = false;
            //    gridViewDecimalColumn17.Name = "OperPassageBaridId";
            //    gridViewTextBoxColumn15.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn15.FieldName = "vehicle_Color";
            //    gridViewTextBoxColumn15.HeaderText = "رنگ خودرو";
            //    gridViewTextBoxColumn15.IsVisible = false;
            //    gridViewTextBoxColumn15.Name = "vehicle_Color";
            //    gridViewTextBoxColumn16.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn16.FieldName = "Vehicle_Model";
            //    gridViewTextBoxColumn16.HeaderText = "مدل خودرو";
            //    gridViewTextBoxColumn16.IsVisible = false;
            //    gridViewTextBoxColumn16.Name = "Vehicle_Model";
            //    gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            //    gridViewCheckBoxColumn2.FieldName = "Vehicle_IsCompany";
            //    gridViewCheckBoxColumn2.HeaderText = "خودروی شرکتی";
            //    gridViewCheckBoxColumn2.IsVisible = false;
            //    gridViewCheckBoxColumn2.MinWidth = 20;
            //    gridViewCheckBoxColumn2.Name = "Vehicle_IsCompany";
            //    gridViewDecimalColumn18.EnableExpressionEditor = false;
            //    gridViewDecimalColumn18.FieldName = "VehicleType_ID";
            //    gridViewDecimalColumn18.HeaderText = "آیدی نوع خودرو";
            //    gridViewDecimalColumn18.IsVisible = false;
            //    gridViewDecimalColumn18.Name = "VehicleType_ID";
            //    gridViewTextBoxColumn17.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn17.FieldName = "VehicleType_Name";
            //    gridViewTextBoxColumn17.HeaderText = "نوع خودرو";
            //    gridViewTextBoxColumn17.IsVisible = false;
            //    gridViewTextBoxColumn17.Name = "VehicleType_Name";
            //    gridViewDecimalColumn19.EnableExpressionEditor = false;
            //    gridViewDecimalColumn19.FieldName = "StatusPack_Id";
            //    gridViewDecimalColumn19.HeaderText = "آیدی وضعیت";
            //    gridViewDecimalColumn19.IsVisible = false;
            //    gridViewDecimalColumn19.Name = "StatusPack_Id";
            //    gridViewTextBoxColumn18.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn18.FieldName = "StatusPack_Name";
            //    gridViewTextBoxColumn18.HeaderText = "نام وضعیت";
            //    gridViewTextBoxColumn18.IsVisible = false;
            //    gridViewTextBoxColumn18.Name = "StatusPack_Name";
            //    gridViewTextBoxColumn19.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn19.FieldName = "StatusPack_Desc";
            //    gridViewTextBoxColumn19.HeaderText = "توضیحات وضعیت";
            //    gridViewTextBoxColumn19.IsVisible = false;
            //    gridViewTextBoxColumn19.Name = "StatusPack_Desc";
            //    gridViewTextBoxColumn20.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn20.FieldName = "StatusPack_Label";
            //    gridViewTextBoxColumn20.HeaderText = "وضعیت";
            //    gridViewTextBoxColumn20.IsVisible = false;
            //    gridViewTextBoxColumn20.Name = "StatusPack_Label";
            //    gridViewTextBoxColumn20.Width = 68;
            //    gridViewTextBoxColumn21.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn21.FieldName = "Package_Events";
            //    gridViewTextBoxColumn21.HeaderText = "رویداد نگاری مجموعه بسته";
            //    gridViewTextBoxColumn21.IsVisible = false;
            //    gridViewTextBoxColumn21.Name = "Package_Events";
            //    gridViewTextBoxColumn21.Width = 58;
            //    gridViewTextBoxColumn22.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn22.FieldName = "TypePlates_Id";
            //    gridViewTextBoxColumn22.HeaderText = "شماره نوع پلاک";
            //    gridViewTextBoxColumn22.IsVisible = false;
            //    gridViewTextBoxColumn22.Name = "TypePlates_Id";
            //    gridViewTextBoxColumn22.Width = 89;
            //    gridViewTextBoxColumn23.EnableExpressionEditor = false;
            //    gridViewTextBoxColumn23.FieldName = "TypePlates_Desc";
            //    gridViewTextBoxColumn23.HeaderText = "نوع پلاک";
            //    gridViewTextBoxColumn23.Name = "TypePlates_Desc";
            //    gridViewTextBoxColumn23.Width = 83;
            //    rgv_Pack.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            //gridViewTextBoxColumn1,
            //gridViewTextBoxColumn2,
            //gridViewTextBoxColumn3,
            //gridViewDecimalColumn1,
            //gridViewDecimalColumn2,
            //gridViewTextBoxColumn4,
            //gridViewTextBoxColumn5,
            //gridViewTextBoxColumn6,
            //gridViewTextBoxColumn7,
            //gridViewTextBoxColumn8,
            //gridViewDecimalColumn3,
            //gridViewDecimalColumn4,
            //gridViewTextBoxColumn9,
            //gridViewTextBoxColumn10,
            //gridViewTextBoxColumn11,
            //gridViewDecimalColumn5,
            //gridViewDecimalColumn6,
            //gridViewTextBoxColumn12,
            //gridViewDecimalColumn7,
            //gridViewDecimalColumn8,
            //gridViewDecimalColumn9,
            //gridViewDecimalColumn10,
            //gridViewDecimalColumn11,
            //gridViewCheckBoxColumn1,
            //gridViewTextBoxColumn13,
            //gridViewDecimalColumn12,
            //gridViewDecimalColumn13,
            //gridViewDecimalColumn14,
            //gridViewTextBoxColumn14,
            //gridViewDateTimeColumn1,
            //gridViewDateTimeColumn2,
            //gridViewDecimalColumn15,
            //gridViewDecimalColumn16,
            //gridViewDecimalColumn17,
            //gridViewTextBoxColumn15,
            //gridViewTextBoxColumn16,
            //gridViewCheckBoxColumn2,
            //gridViewDecimalColumn18,
            //gridViewTextBoxColumn17,
            //gridViewDecimalColumn19,
            //gridViewTextBoxColumn18,
            //gridViewTextBoxColumn19,
            //gridViewTextBoxColumn20,
            //gridViewTextBoxColumn21,
            //gridViewTextBoxColumn22,
            //gridViewTextBoxColumn23});
            //    rgv_Pack.Name = "rgv_Pack";
            //    //rgv_Pack.ReadOnly = true;
            // //   rgv_Pack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // //   rgv_Pack.Size = new System.Drawing.Size(984, 372);
            // //   rgv_Pack.TabIndex = 0;
            //    #endregion
            //    rgv_Pack.Rows.AddNew();


            //    foreach (DataColumn col in RMail.ResultTable.Columns)
            //    {
            //        rgv_Pack.CurrentRow.Cells[col.ColumnName].Value =
            //            RMail.ResultTable.Rows[0][col.ColumnName];
            //    }


              //  rgv_Pack.DataSource = RMail.ResultTable;
              //  MessageBox.Show(rgv_Pack.Rows.Count.ToString());


              //  rgv_Pack.CurrentRow = rgv_Pack.Rows[0];
          //      rgv_Pack.CurrentRow.Cells["StatusPack_Id"].Value = int.Parse( rgv_Pack.CurrentRow.Cells["StatusPack_Id"].Value.ToString().Trim());

            
                //rgvPack = rgv_Pack;
            }
            else
            {
                ItemsPublic.Exeptor(RMail.Message);
            }
        }
    }
}
