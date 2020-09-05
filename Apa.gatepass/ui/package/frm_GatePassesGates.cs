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
	public partial class frm_GatePassesGates : Form
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
			uC_packDetailsGates1.rbtnAgree.Enabled = uC_packDetailsGates1.rddlTypePack.SelectedIndex < 2 && cbbSave.Enabled;

			if (pmStatus == ItemsPublic.IndexStatus.toNew)
			{
				cbbConfirm.Enabled = false;
				cbbNoConfirm.Enabled = false;
				cbbPassage.Enabled = false;
				cbbNoPassage.Enabled = false;
				cbbCollectPrint.Enabled = false;
				cbbOnePrint.Enabled = false;
				cbbSecureForm.Enabled=false;
				cbbView.Enabled=false;
				//return;
			}  else
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
					cbbSecureForm.Enabled=false;
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
					cbbSecureForm.Enabled=false;
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
			if (uC_packDetailsGates1.rcbHaveVehicle.Checked && cbbEdit.Enabled)
			{
				cbbDriver.Enabled = true;
			}
			else
			{
				cbbDriver.Enabled = false;
			}
			rightCbbDriver.Enabled =cbbDriver.Enabled;
			rightCbbSecure.Enabled = cbbSecureForm.Enabled;
			rightCbbEdit.Enabled =cbbEdit.Enabled;
			rightCbbNew.Enabled =cbbNew.Enabled;
			rightCbbOnePrint.Enabled =cbbOnePrint.Enabled;
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
			ric.AddRange ( rightCbbSecure,rightCbbDriver,rightCbbEdit,rightCbbExit,rightCbbNew,rightCbbOnePrint,rightCbbView );


			this.rightCbbView.Tag = cbbView.Tag;
			this.rightCbbNew.Tag = cbbNew.Tag;
			this.rightCbbEdit.Tag =  cbbEdit.Tag;
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
			if ( ItemsPublic.MyRights.Contains ( AllFunctions._Rights.ClsPersons_update ) && pmStatus != ItemsPublic.IndexStatus.toNew )
			{
				uC_ViewPersonDetails1.rbtnImage.Tag = "advens";
				uC_ViewPersonDetails1.rbtnImage.Enabled = true;
			}
		}

		public frm_GatePassesGates()
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
				uC_packDetailsGates1.uC_vehicleDetails21.SetModelsCar();
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

			if (( AllFunctions._StatusPack ) rgvPack.CurrentRow.Cells ["StatusPack_Id"].Value == AllFunctions._StatusPack.Confirm	|| ( AllFunctions._StatusPack ) rgvPack.CurrentRow.Cells ["StatusPack_Id"].Value == AllFunctions._StatusPack.Passage)
			{
				switch ( ( AllFunctions._TypePack ) rgvPack.CurrentRow.Cells ["TypePack_Id"].Value )
				{
					#region type pack && rights
					case AllFunctions._TypePack.Guest:
   if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageGuest))
   {
   	return true;
   }
						break;
					case AllFunctions._TypePack.TeachTrainee:
						if ( ItemsPublic.MyRights.Contains ( AllFunctions._Rights.PassageTrainee ) )
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.TeachAct:
						if ( ItemsPublic.MyRights.Contains ( AllFunctions._Rights.PassageTrainee ) )
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.TeachUni:
						if ( ItemsPublic.MyRights.Contains ( AllFunctions._Rights.PassageTrainee ) )
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.TempWork:
						if ( ItemsPublic.MyRights.Contains ( AllFunctions._Rights.PassageGuest ) )
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.Company:
						if ( ItemsPublic.MyRights.Contains ( AllFunctions._Rights.PassageGuest ) )
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.WorkerMan:
						if ( ItemsPublic.MyRights.Contains ( AllFunctions._Rights.PassageWorkerMan ) )
						{
							return true;
						}
						break;
					case AllFunctions._TypePack.WorkerWoman:
						if ( ItemsPublic.MyRights.Contains ( AllFunctions._Rights.PassgeWorkerWoman ) )
						{
							return true;
						}
						break;
					default:
						ItemsPublic.Exeptor( "نوع بسته نامشخص می باشد" );
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
						cbbDriver.Enabled = uC_packDetailsGates1.rcbHaveVehicle.Checked && MainRadGridView.CurrentRow != null &&
						                    cbbEdit.Enabled && !string.IsNullOrEmpty ( MainRadGridView.CurrentRow.Cells ["Person_LicenseDriverCode"].Value.ToString ().Trim() );
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

		private string S = "";
		private bool lump = false;

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


				var frmSet = new gatepass.ui.package.frm_SettingPackGates();
				frmSet.SetSettings(this.uC_packDetailsGates1);
				frmSet.ShowDialog();
				if (frmSet.DialogResult == DialogResult.OK)
				{
					MainRadGridView.CurrentRow = null;
					this.SetSetting ( frmSet.uC_packDetailsForNewGates1 );
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
					//uC_packDetailsGates1.rcbHaveVehicle.Checked = true;
					CurrentDriverId = (decimal) MainRadGridView.CurrentRow.Cells["Person_ID"].Value;
					if (uC_packDetailsGates1.rcbHaveVehicle.Checked)
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
							if (uC_packDetailsGates1.rcbHaveVehicle.Checked)
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

		private GroupDescriptor descG = new GroupDescriptor ( "GatePass_IsExpired" );
		private void frm_GatePassesGates_Load(object sender, EventArgs e)
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
			uC_packDetailsGates1.uC_vehicleDetails21.rtbColor.Tag = uC_packDetailsGates1.uC_vehicleDetails21.rtbColor.Tag + "L";
			uC_packDetailsGates1.uC_vehicleDetails21.rtbModel.Tag = uC_packDetailsGates1.uC_vehicleDetails21.rtbModel.Tag + "L";
			uC_packDetailsGates1.uC_vehicleDetails21.uC_CarNumber1.CarNumberTags =
				uC_packDetailsGates1.uC_vehicleDetails21.uC_CarNumber1.CarNumberTags + "L";
			uC_packDetailsGates1.uC_vehicleDetails21.rddlState.Tag = uC_packDetailsGates1.uC_vehicleDetails21.rddlState.Tag + "L";
			uC_packDetailsGates1.uC_vehicleDetails21.rddlType.Tag = uC_packDetailsGates1.uC_vehicleDetails21.rddlType.Tag + "L";

			setAllMouseMenus ();
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
if(result.success)
{

uC_packDetailsGates1.rtbGates.Text = "";
				uC_packDetailsGates1.CurrentGates = new List<int>();
				foreach ( DataRow obj in result.ResultTable.Rows )
				{
				//	string ss = obj.Cells["Gate_Id"].Value.ToString().Trim();
					//int ii = int.Parse(obj.Cells["Gate_Id"].Value.ToString().Trim());
					uC_packDetailsGates1.CurrentGates.Add ( int.Parse ( obj["Gate_Id"].ToString ().Trim () ) );
					uC_packDetailsGates1.rtbGates.Text += obj["Gate_Name"].ToString ().Trim()+"\r\n";
				}
}	else
{
	ItemsPublic.ShowMessage(result.Message);
}

			uC_packDetailsGates1.rddlShift.Text = rgvPack.CurrentRow.Cells["Package_Shift"].Value.ToString().Trim();

			uC_packDetailsGates1.rtbStatusPack.Text = rgvPack.CurrentRow.Cells["StatusPack_Label"].Value.ToString().Trim();
			uC_packDetailsGates1.rtbOffice.Text = rgvPack.CurrentRow.Cells["Office_Name"].Value.ToString().Trim();
			switch ((ServerClasses.AllFunctions._TypePack) rgvPack.CurrentRow.Cells["TypePack_Id"].Value)
			{
				case ServerClasses.AllFunctions._TypePack.WorkerMan:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.WorkerMan;
					break;
				case ServerClasses.AllFunctions._TypePack.WorkerWoman:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.WorkerWoman;
					break;
				case ServerClasses.AllFunctions._TypePack.TeachTrainee:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.TeachTrainee;
					break;
				case ServerClasses.AllFunctions._TypePack.TeachUni:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.TeachUni;
					break;
				case ServerClasses.AllFunctions._TypePack.TeachAct:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.TeachAct;
					break;
				case ServerClasses.AllFunctions._TypePack.Guest:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.Guest;
					break;
				case ServerClasses.AllFunctions._TypePack.TempWork:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.TempWork;
					break;
				case ServerClasses.AllFunctions._TypePack.Company:
					uC_packDetailsGates1.rddlTypePack.SelectedIndex = (int) ServerClasses.AllFunctions._TypePack.Company;
					break;
			}
			uC_packDetailsGates1.bdcStartDate.DateTime = (DateTime) rgvPack.CurrentRow.Cells["Package_StartDate"].Value;
			uC_packDetailsGates1.bdcEndDate.DateTime = (DateTime) rgvPack.CurrentRow.Cells["Package_EndDate"].Value;
			uC_packDetailsGates1.rddlValid.SelectedIndex = ((bool) rgvPack.CurrentRow.Cells["Package_IsExpired"].Value) ? 0 : 1;
			uC_packDetailsGates1.rtbNumberAgree.Text = rgvPack.CurrentRow.Cells["Agreement_Number"].Value.ToString().Trim();
			string temS = rgvPack.CurrentRow.Cells["Agreement_ID"].Value.ToString().Trim();
			decimal? temp = string.IsNullOrEmpty(temS) ? (decimal?) null : decimal.Parse(temS);
			uC_packDetailsGates1.CurrentAgreeId = temp;
			uC_packDetailsGates1.rtbCompanyAgree.Text = rgvPack.CurrentRow.Cells["Agreement_Company"].Value.ToString().Trim();
			uC_packDetailsGates1.rtbTitleAgree.Text = rgvPack.CurrentRow.Cells["Agreement_Title"].Value.ToString().Trim();
			uC_packDetailsGates1.rlblCountCar.Text = ItemsPublic.HowManyCarInAgree(temp);


			temS = rgvPack.CurrentRow.Cells["TravelArea_Id"].Value.ToString().Trim();
			int? temp2 = string.IsNullOrEmpty(temS) ? (int?) null : int.Parse(temS);
			uC_packDetailsGates1.CurrentTravelId = temp2;

			uC_packDetailsGates1.rtbTravelLabel.Text =
				rgvPack.CurrentRow.Cells["TravelArea_LabelTravel"].Value.ToString().Trim();

			uC_packDetailsGates1.rtbOperRequest.Text = rgvPack.CurrentRow.Cells["OperRequestName"].Value.ToString().Trim();
			uC_packDetailsGates1.rtbOperConfirm.Text = rgvPack.CurrentRow.Cells["OperConfirmName"].Value.ToString().Trim();
			uC_packDetailsGates1.rtbOperPassage.Text = rgvPack.CurrentRow.Cells["OperPassageName"].Value.ToString().Trim();
			uC_packDetailsGates1.tbPackDescriptions.Text =
				rgvPack.CurrentRow.Cells["Package_Description"].Value.ToString().Trim();

			//uC_packDetailsGates1.uC_vehicleDetails21.rddlType.SelectedIndex =
			string stV = rgvPack.CurrentRow.Cells["Vehicle_ID"].Value.ToString().Trim();
			bool boV = !string.IsNullOrEmpty(stV);
			uC_packDetailsGates1.rcbHaveVehicle.Checked =boV;
			if (uC_packDetailsGates1.rcbHaveVehicle.Checked)
			{
				uC_packDetailsGates1.CurrentCarId = (decimal?) rgvPack.CurrentRow.Cells["Vehicle_ID"].Value;
				uC_packDetailsGates1.uC_vehicleDetails21.rtbModel.Text =
					rgvPack.CurrentRow.Cells["Vehicle_Model"].Value.ToString().Trim();
				uC_packDetailsGates1.uC_vehicleDetails21.rtbColor.Text =
					rgvPack.CurrentRow.Cells["vehicle_Color"].Value.ToString().Trim();
				uC_packDetailsGates1.uC_vehicleDetails21.uC_CarNumber1.CarNumber =
					rgvPack.CurrentRow.Cells["Vehicle_number"].Value.ToString().Trim();
				uC_packDetailsGates1.uC_vehicleDetails21.rddlState.SelectedIndex =
					(bool) rgvPack.CurrentRow.Cells["Vehicle_IsCompany"].Value ? 0 : 1;
				uC_packDetailsGates1.uC_vehicleDetails21.indexTypeModel = (int?) rgvPack.CurrentRow.Cells["VehicleType_ID"].Value;
			}
			else
			{
				uC_packDetailsGates1.rcbHaveVehicle.Checked = false;
			}
		}

		private void setEmptyInfo()
		{
			uC_packDetailsGates1.CurrentCarId = null;
			CurrentDriverId = null;
			uC_packDetailsGates1.rtbStatusPack.Text = "درحال ساخت";
			uC_packDetailsGates1.rtbOffice.Text = "";
			uC_packDetailsGates1.rddlTypePack.SelectedIndex = -1;
			uC_packDetailsGates1.bdcStartDate.DateTime = null;
			uC_packDetailsGates1.bdcEndDate.DateTime = null;
			uC_packDetailsGates1.rddlValid.SelectedIndex = -1;
			uC_packDetailsGates1.rtbNumberAgree.Text = "";
			uC_packDetailsGates1.CurrentAgreeId = null;
			uC_packDetailsGates1.rtbCompanyAgree.Text = "";
			uC_packDetailsGates1.rtbTitleAgree.Text = "";

			uC_packDetailsGates1.CurrentTravelId = null;

			uC_packDetailsGates1.rtbTravelLabel.Text = "";

			uC_packDetailsGates1.rtbOperRequest.Text = "";
			uC_packDetailsGates1.rtbOperConfirm.Text = "";
			uC_packDetailsGates1.rtbOperPassage.Text = "";
			uC_packDetailsGates1.tbPackDescriptions.Text = "";
			uC_packDetailsGates1.rcbHaveVehicle.Checked = false;
			uC_packDetailsGates1.uC_vehicleDetails21.rtbModel.Text = "";
			uC_packDetailsGates1.uC_vehicleDetails21.rtbColor.Text = "";
			uC_packDetailsGates1.uC_vehicleDetails21.uC_CarNumber1.CarNumber = "";
			uC_packDetailsGates1.uC_vehicleDetails21.rddlState.SelectedIndex = -1;
			uC_packDetailsGates1.uC_vehicleDetails21.indexTypeModel = null;
		}

		private void ShowPropertiesItems()
		{
			if (MainRadGridView.SelectedRows[0].Cells["Person_Name"].Value != null)
			{
				uC_ViewPersonDetails1.rtbName.Text = MainRadGridView.SelectedRows[0].Cells["Person_Name"].Value.ToString().Trim();
			}
			if (MainRadGridView.SelectedRows[0].Cells["Person_Surname"].Value != null)
			{
				uC_ViewPersonDetails1.rtbSurname.Text = MainRadGridView.SelectedRows[0].Cells["Person_Surname"].Value.ToString().Trim();
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
				uC_ViewPersonDetails1.bdcBirthDate.DateTime = (DateTime) MainRadGridView.SelectedRows[0].Cells["Person_BirthDate"].Value;
			}else
			{
				uC_ViewPersonDetails1.bdcBirthDate.DateTime = (DateTime?)null;
			}
			if (MainRadGridView.SelectedRows[0].Cells["Person_LicenseDriverCode"].Value != null)
			{
				uC_ViewPersonDetails1.rmebLicenseDriveCode.Text =
					MainRadGridView.SelectedRows[0].Cells["Person_LicenseDriverCode"].Value.ToString().Trim();
			}else
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
				uC_ViewPersonDetails1.rmebPhone2.Text = MainRadGridView.SelectedRows[0].Cells["Person_Phone2"].Value.ToString().Trim();
			}
			uC_ViewPersonDetails1.TcoHaveForm.Text =
				((bool) MainRadGridView.SelectedRows[0].Cells["Person_HaveForm"].Value) ? "دارد" : "ندارد";
if ( ( ( bool ) MainRadGridView.SelectedRows [0].Cells ["Person_HaveForm"].Value ) )
{
	if (! (MainRadGridView.SelectedRows[0].Cells["Person_SecureFormDate"].Value is DBNull) &&
			    MainRadGridView.SelectedRows[0].Cells["Person_SecureFormDate"].Value != null)
uC_ViewPersonDetails1.bdcEndSecureDate.DateTime = (DateTime) MainRadGridView.SelectedRows[0].Cells["Person_SecureFormDate"].Value;
else
		uC_ViewPersonDetails1.bdcEndSecureDate.DateTime = ( DateTime? ) null;
}else
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
						var picture = ms.ToArray();
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
					MessageBox.Show("بسته در مرحله تصویب رد شد");
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
				var frmDialog = new frm_GetMessage ();
				if ( frmDialog.ShowDialog () != DialogResult.OK )
				{
					return;
				}
                result = objManager.ClsPacksGps_confirm(IndexPack, AllFunctions._StatusPack.NoConfirm, frmDialog.message, null);
				if (result.success)
				{
					MessageBox.Show("بسته تایید نشد");
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
				if (!QuestionSureTo("آیا قصد تایید درخواست مجوز را دارید؟"))
				{
					return;
				}
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
			if (!QuestionSureTo("آیا قصد ارسال درخواست مجوز را دارید؟"))
			{
				return;
			}
			SavePackInDataBase(AllFunctions._StatusPack.Request);
		}

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
			if (uC_packDetailsGates1.rcbHaveVehicle.Checked)
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
				if (isNew)
				{
					result = objManager.ClsPacksGps_insertPackGpsOldVersion(
						(uC_packDetailsGates1.bdcStartDate.SelectedDate != null)
							? uC_packDetailsGates1.bdcStartDate.SelectedDate.Value
							: (DateTime?) null,
						(uC_packDetailsGates1.bdcEndDate.SelectedDate != null)
							? uC_packDetailsGates1.bdcEndDate.SelectedDate.Value
							: (DateTime?) null,
						uC_packDetailsGates1.CurrentAgreeId,
						uC_packDetailsGates1.CurrentTravelId,
						uC_packDetailsGates1.tbPackDescriptions.Text.Trim(), uC_packDetailsGates1.rddlTypePack.SelectedIndex, personsId,
						personIdDriver(),
						uC_packDetailsGates1.CurrentCarId, pos, uC_packDetailsGates1.rddlShift.Text.Trim()
						, uC_packDetailsGates1.CurrentGates , null );
					if (result.success)
					{
						MessageBox.Show("عملیات با موفقیت انجام شد");
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
						uC_packDetailsGates1.tbPackDescriptions.Text.Trim(),
						uC_packDetailsGates1.CurrentAgreeId,
						uC_packDetailsGates1.CurrentTravelId,
						(uC_packDetailsGates1.bdcStartDate.SelectedDate != null)
							? uC_packDetailsGates1.bdcStartDate.SelectedDate.Value
							: (DateTime?) null,
						(uC_packDetailsGates1.bdcEndDate.SelectedDate != null)
							? uC_packDetailsGates1.bdcEndDate.SelectedDate.Value
							: (DateTime?) null,
						uC_packDetailsGates1.rddlTypePack.SelectedIndex, personsId, personIdDriver(), uC_packDetailsGates1.CurrentCarId, pos,
						uC_packDetailsGates1.rddlShift.Text.Trim()
						, uC_packDetailsGates1.CurrentGates , null );
					if (result.success)
					{
						MessageBox.Show("عملیات با موفقیت انجام شد");
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
			}
		}

		private void uC_packDetailsGates1_eventTickVehicle()
		{
			try
			{
				cbbDriver.Enabled = uC_packDetailsGates1.rcbHaveVehicle.Checked && MainRadGridView.CurrentRow != null && cbbEdit.Enabled;
				//eventStatusView();
				//	MainRadGridView.Enabled = true;
				//	objManager.ChangeStatus ( aorc.gatepass.ItemsPublic.IndexStatus.viewPack );
				if (uC_packDetailsGates1.rcbHaveVehicle.Checked)
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

		public void SetSetting(UC_packDetailsForNewGates obj)
		{
			uC_packDetailsGates1.rtbGates.Text = obj.rtbGates.Text.Trim ();
			uC_packDetailsGates1.CurrentGates = obj.CurrentGates;

			uC_packDetailsGates1.rddlTypePack.SelectedIndex = obj.rddlTypePack.SelectedIndex;
			uC_packDetailsGates1.bdcStartDate.DateTime = obj.bdcStartDate.DateTime;
			uC_packDetailsGates1.bdcEndDate.DateTime = obj.bdcEndDate.DateTime;
			uC_packDetailsGates1.rtbNumberAgree.Text = obj.rtbNumberAgree.Text.Trim();
			uC_packDetailsGates1.CurrentAgreeId = obj.CurrentAgreeId;
			uC_packDetailsGates1.rtbCompanyAgree.Text = obj.rtbCompanyAgree.Text.Trim();
			uC_packDetailsGates1.rtbTitleAgree.Text = obj.rtbTitleAgree.Text.Trim();
			uC_packDetailsGates1.rlblCountCar.Text = obj.rlblCountCar.Text.Trim();
			uC_packDetailsGates1.rddlShift.Text = obj.rddlShift.Text.Trim();

			uC_packDetailsGates1.CurrentTravelId = obj.CurrentTravelId;

			uC_packDetailsGates1.rtbTravelLabel.Text = obj.rtbTravelLabel.Text.Trim();

			uC_packDetailsGates1.tbPackDescriptions.Text = obj.tbPackDescriptions.Text.Trim();

			//uC_packDetailsGates1.uC_vehicleDetails21.rddlType.SelectedIndex =
			uC_packDetailsGates1.rcbHaveVehicle.Checked = obj.rcbHaveVehicle.Checked;
			if (uC_packDetailsGates1.rcbHaveVehicle.Checked)
			{
				uC_packDetailsGates1.CurrentCarId = obj.CurrentCarId;
				uC_packDetailsGates1.uC_vehicleDetails21.rtbModel.Text =
					obj.uC_vehicleDetails21.rtbModel.Text.Trim();
				uC_packDetailsGates1.uC_vehicleDetails21.rtbColor.Text =
					obj.uC_vehicleDetails21.rtbColor.Text.Trim();
				uC_packDetailsGates1.uC_vehicleDetails21.uC_CarNumber1.CarNumber =
					obj.uC_vehicleDetails21.uC_CarNumber1.CarNumber;
				uC_packDetailsGates1.uC_vehicleDetails21.rddlState.SelectedIndex =
					obj.uC_vehicleDetails21.rddlState.SelectedIndex;
				uC_packDetailsGates1.uC_vehicleDetails21.indexTypeModel = obj.uC_vehicleDetails21.indexTypeModel;
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
			                                (idCodeValid == true) ? uC_ViewPersonDetails1.rmeIdentifyCode.Text.Trim() : string.Empty
											, uC_ViewPersonDetails1.rtbRegisterCode.Text.Trim () ,
											 ( uC_ViewPersonDetails1.bdcEndSecureDate.SelectedDate != null )
			                                	? uC_ViewPersonDetails1.bdcEndSecureDate.SelectedDate.Value
			                                	: ( DateTime? ) null );
if(result.success==false)
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

					var ResultPrint = objManager.ClsPacksGps_RequestPrintGP2(IDG);
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
						MainRadGridView.SelectedRows [0].Cells ["GatePass_IsExpired"].Value =true;
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

		RadMenuItem rightCbbView = new RadMenuItem ();
		RadMenuItem rightCbbNew = new RadMenuItem ();
		RadMenuItem rightCbbEdit = new RadMenuItem ();
		RadMenuItem rightCbbDriver = new RadMenuItem ();
		RadMenuItem rightCbbOnePrint = new RadMenuItem ();
		RadMenuItem rightCbbExpire		= new RadMenuItem ();
		RadMenuItem rightCbbExit = new RadMenuItem ();
		RadMenuItem rightCbbSecure = new RadMenuItem ();

		protected void setAllMouseMenus()
		{
			setAllRightMenusCopy ();
			contextMenu.Items.AddRange ( rightCbbView , rightCbbNew , rightCbbEdit , rightCbbDriver , rightCbbSecure
										, rightCbbOnePrint , rightCbbExpire , rightCbbExit );
			MainRadGridView.ContextMenuOpening += new ContextMenuOpeningEventHandler ( MainRadGridView_ContextMenuOpening );
		}
		private void setAllRightMenusCopy()
		{
			// cbbView
			this.rightCbbView.AccessibleDescription = "مشاهده";
			this.rightCbbView.AccessibleName = "مشاهده";
			this.rightCbbView.FlipText = false;
			this.rightCbbView.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbView.Image = global::aorc.gatepass.Properties.Resources._52g;
			this.rightCbbView.Name = "cbbView";
			
			this.rightCbbView.Text = "بازآوری";
			this.rightCbbView.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.rightCbbView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbView.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbView.Click += new System.EventHandler ( this.cbbView_Click );
			// 
			// cbbNew
			// 
			this.rightCbbNew.AccessibleDescription = "جدید";
			this.rightCbbNew.AccessibleName = "جدید";
			this.rightCbbNew.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbNew.Image = global::aorc.gatepass.Properties.Resources.personsg;
			this.rightCbbNew.Name = "cbbNew";
			
			this.rightCbbNew.Text = "انتخاب افراد";
			this.rightCbbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbNew.Click += new System.EventHandler ( this.cbbNew_Click );
			// 
			
			// cbbEdit
			// 
			this.rightCbbEdit.AccessibleDescription = "ویرایش";
			this.rightCbbEdit.AccessibleName = "ویرایش";
			this.rightCbbEdit.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbEdit.Image = global::aorc.gatepass.Properties.Resources.editg;
			this.rightCbbEdit.Name = "cbbEdit";
			
			this.rightCbbEdit.Text = "تنظیمات بسته";
			this.rightCbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbEdit.Click += new System.EventHandler ( this.cbbEdit_Click );
			//
			//rightCbbSecure
			//
			this.rightCbbSecure.AccessibleDescription = "وضعیت حفاظتی";
			this.rightCbbSecure.AccessibleName = "وضعیت حفاظتی";
			this.rightCbbSecure.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbSecure.Image = global::aorc.gatepass.Properties.Resources.agent16;
			this.rightCbbSecure.Name = "CbbSecure";

			this.rightCbbSecure.Text = "وضعیت حفاظتی";
			this.rightCbbSecure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbSecure.ToolTipText = "تنظیم وضعیت فرد انتخابی از نظر داشتن فرم حفاظتی";
			this.rightCbbSecure.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbSecure.Click += new System.EventHandler ( this.cbbSecureForm_Click );
			// 
			// cbbDriver
			// 
			this.rightCbbDriver.AccessibleDescription = "راننده";
			this.rightCbbDriver.AccessibleName = "راننده";
			this.rightCbbDriver.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbDriver.Image = global::aorc.gatepass.Properties.Resources.carg;
			this.rightCbbDriver.Name = "cbbDriver";
			
			this.rightCbbDriver.Text = "انتخاب راننده";
			this.rightCbbDriver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbDriver.ToolTipText = "انتخاب فرد جاری به عنوان راننده";
			this.rightCbbDriver.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbDriver.Click += new System.EventHandler ( this.cbbSearch_Click );
			// 
			
			// cbbOnePrint
			// 
			this.rightCbbOnePrint.AccessibleDescription = "چاپ انتخابی";
			this.rightCbbOnePrint.AccessibleName = "چاپ انتخابی";
			this.rightCbbOnePrint.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbOnePrint.Image = global::aorc.gatepass.Properties.Resources.print_icong;
			this.rightCbbOnePrint.Name = "cbbOnePrint";
			
			this.rightCbbOnePrint.Text = "چاپ انتخابی";
			this.rightCbbOnePrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbOnePrint.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbOnePrint.Click += new System.EventHandler ( this.cbbOnePrint_Click );
			// 
			
			// cbbExpire
			// 
			this.rightCbbExpire.AccessibleDescription = "منقضی کردن مجوز عبور";
			this.rightCbbExpire.AccessibleName = "منقضی کردن مجوز عبور";
			this.rightCbbExpire.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbExpire.Image = global::aorc.gatepass.Properties.Resources.abortg;
			this.rightCbbExpire.Name = "cbbExpire";
			
			this.rightCbbExpire.Text = "خاتمه مجوز";
			this.rightCbbExpire.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.rightCbbExpire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbExpire.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbExpire.Click += new System.EventHandler ( this.cbbExpire_Click );

			// exit
			this.rightCbbExit.AccessibleDescription = "خروج";
			this.rightCbbExit.AccessibleName = "خروج";
			this.rightCbbExit.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbExit.Image = global::aorc.gatepass.Properties.Resources.exitg;
			this.rightCbbExit.Name = "rightCbbExit";
			this.rightCbbExit.Text = "خروج";
			this.rightCbbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbExit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbExit.Click += new System.EventHandler ( this.rmiStatusExit_Click );
		}
		private void MainRadGridView_ContextMenuOpening( object sender , ContextMenuOpeningEventArgs e )
		{
			e.ContextMenu = contextMenu;
		}

		private void cbbSecureForm_Click( object sender , EventArgs e )
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

		private void MasterTemplate_CustomGrouping( object sender , GridViewCustomGroupingEventArgs e )
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

		private void MainRadGridView_GroupSummaryEvaluate( object sender , GroupSummaryEvaluationEventArgs e )
		{
				if(e.Value==null)
				{
					e.FormatString = e.Group.Key.ToString();
				}
		}

		private void uC_packDetailsGates1_eventTickVehicle_1()
		{

		}

		private void frm_GatePassesGates_Shown( object sender , EventArgs e )
		{
			if ( pmStatus == ItemsPublic.IndexStatus.toNew )
			{
				cbbNew_Click(sender, e);
				cbbEdit_Click(sender, e);
			}
			if ( MainRadGridView.Rows.Count>0)
{
	MainRadGridView.Groups[0].HeaderRow.IsExpanded = true;
	MainRadGridView.Groups[0].Expand();
}
		}
	}
}
