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

namespace aorc.gatepass.Gp2.Pack
{
    public partial class frm_InpackGP : Form
	{

		// public event DelegateStatusAction eventClearProperiesItems;
		//  public event DelegateStatusAction eventShowPropertiesItems;
		// private decimal? CurrentDriverId;

        private bool copyingMode = false;
        private bool changeMode = false;
        public bool changedSettings = false;
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
      //  private bool initialDatas = false;
		//public GridViewRowInfo detailsPack;

        private bool isboolNOpassRight()
        {

         //   return true;
            if (rgvPack.CurrentRow.Cells["TypePack_Id"].Value != null)
            {
                if (!(rgvPack.CurrentRow.Cells["TypePack_Id"].Value is DBNull))
                {
                    v3UC_PackDetailsGp21.TypePackRealId = (int)rgvPack.CurrentRow.Cells["TypePack_Id"].Value;
                    v3UC_PackDetailsGp21.isGpType = (bool?)rgvPack.CurrentRow.Cells["TypePack_IsShort"].Value;
                    v3UC_PackDetailsGp21.rddlTypePack.Text = rgvPack.CurrentRow.Cells["TypePack_Name"].Value.ToString().Trim();
                }

                else
                {
                    v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = -1;
                }
            }
            else
            {
                v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = -1;
            }


    switch (((AllFunctions._TypePack) rgvPack.CurrentRow.Cells["TypePack_Id"].Value))
	{
            case AllFunctions._TypePack.WorkerMan:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageNoWorkerMan);
            case AllFunctions._TypePack.WorkerWoman:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageNoWorkerWoman);
            case AllFunctions._TypePack.TeachTrainee:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageNoTrainee);
            case AllFunctions._TypePack.TeachUni:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageNoTrainee);
            case AllFunctions._TypePack.TeachAct:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageNoTrainee);
            case AllFunctions._TypePack.Guest:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageNoGuest);
            case AllFunctions._TypePack.TempWork:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageNoGuest);
            case AllFunctions._TypePack.Company:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageNoGuest);
            case AllFunctions._TypePack.Army:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageNoArmy);
            case AllFunctions._TypePack.Temp:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageNoTemp);
            case AllFunctions._TypePack.CardPublic:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.passageNoCard);
            case AllFunctions._TypePack.CardCompany:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.passageNoCard);
            case AllFunctions._TypePack.CardArmy:
                                return ItemsPublic.MyRights.Contains(AllFunctions._Rights.passageNoCard);
            default:
                               return false;
            }

       //     rgvPack.Rows[0].Cells[""].Value
            //.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights);
        }

        private bool isboolpassRight()
        {

            //    return true;

                switch (((AllFunctions._TypePack) rgvPack.CurrentRow.Cells["TypePack_Id"].Value))
	    {
    case AllFunctions._TypePack.WorkerMan:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageWorkerMan);
    case AllFunctions._TypePack.WorkerWoman:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassgeWorkerWoman);
    case AllFunctions._TypePack.TeachTrainee:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageTrainee);
    case AllFunctions._TypePack.TeachUni:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageTrainee);
    case AllFunctions._TypePack.TeachAct:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageTrainee);
    case AllFunctions._TypePack.Guest:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageGuest);
    case AllFunctions._TypePack.TempWork:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageGuest);
    case AllFunctions._TypePack.Company:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageGuest);
    case AllFunctions._TypePack.Army:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageArmy);
    case AllFunctions._TypePack.Temp:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageTemp);
    case AllFunctions._TypePack.CardPublic:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.passageCard);
    case AllFunctions._TypePack.CardCompany:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.passageCard);
    case AllFunctions._TypePack.CardArmy:
                        return ItemsPublic.MyRights.Contains(AllFunctions._Rights.passageCard);
    default:
                       return false;
            }

       //     rgvPack.Rows[0].Cells[""].Value
            //.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights);
        }
		private void rightsEnableControls()
		{
            //v3UC_PackDetailsGp21.rbtnAgree.Enabled = v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex < 2 &&
            //                                             cbbSave.Enabled;

			if (pmStatus == ItemsPublic.IndexStatus.toNew)
			{
                cbbEdit.Enabled = true;
                cbbNew.Enabled = true;
                cbbGroupCar.Enabled = true;
                cbbSaveTo.Enabled = true;
                cbbRequest.Enabled = true;

               // cbbConfirm.Enabled = false;
               // cbbNoConfirm.Enabled = false;
               // cbbPassage.Enabled = false;
               // cbbNoPassage.Enabled = false;
               // cbbCollectPrint.Enabled = false;
               // cbbOnePrint.Enabled = false;
               // cbbSecureForm.Enabled = false;
               // cbbView.Enabled = false;
               // cbbExpire.Enabled = false;
               ////  MainRadGridView.Columns["GatePass_State"].IsVisible = false;
               // //return;
			}
			else
			{
				switch ((AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value)
				{
					case AllFunctions._StatusPack.Create:
						cbbSaveTo.Enabled=true;
						cbbRequest.Enabled=true;
                        cbbView.Enabled = true;
                        cbbNew.Enabled = true;
                        cbbEdit.Enabled = true;
                        cbbGroupCar.Enabled = true;
                        cbbSecureForm.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPersons_update);

					//	cbbConfirm.Enabled = false;
						//cbbNoConfirm.Enabled = false;
					//	cbbPassage.Enabled = false;
					//	cbbNoPassage.Enabled = false;
					//	cbbCollectPrint.Enabled = false;
						//cbbOnePrint.Enabled = false;
                      //  cbbExpire.Enabled = false;
                       //  MainRadGridView.Columns["GatePass_State"].IsVisible = false;

						break;
					case AllFunctions._StatusPack.Request:
							cbbConfirm.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.confirm);
                            cbbNoConfirm.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.confirm);
                            cbbView.Enabled = true;
                            cbbSecureForm.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPersons_update);
                        //cbbSaveTo.Enabled = false;
                        //cbbRequest.Enabled = false;
                        //cbbPassage.Enabled = false;
                        //cbbNoPassage.Enabled = false;
                        //cbbEdit.Enabled = false;
                        //cbbNew.Enabled = false;
                        //cbbGroupCar.Enabled = false;
                        //cbbSecureForm.Enabled = false;
                        //cbbCollectPrint.Enabled = false;
                        //cbbOnePrint.Enabled = false;
						break;
					case AllFunctions._StatusPack.Confirm:
                        //cbbSaveTo.Enabled = false;
                        //cbbRequest.Enabled = false;
                        //cbbConfirm.Enabled = false;
                        //cbbNoConfirm.Enabled = false;
                        //cbbEdit.Enabled = false;
                        //cbbNew.Enabled = false;
                        //cbbGroupCar.Enabled = false;
                        cbbView.Enabled = true;
                        cbbSecureForm.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPersons_update);
                     //   cbbSecureForm.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPersons_update);
                      //  cbbExpire.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPacksGps_ExpireGp);
					//	cbbCollectPrint.Enabled = false;
						//cbbOnePrint.Enabled = false;

                        cbbPassage.Enabled = isboolpassRight();
                        cbbNoPassage.Enabled = isboolNOpassRight();
						break;
					case AllFunctions._StatusPack.NoConfirm:

                        cbbSaveTo.Enabled=true;
						cbbRequest.Enabled=true;
                        cbbView.Enabled = true;
                        cbbNew.Enabled = true;
                        cbbEdit.Enabled = true;
                        cbbGroupCar.Enabled = true;
                        cbbSecureForm.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPersons_update);
                        //cbbConfirm.Enabled = false;
                        //cbbNoConfirm.Enabled = false;
                        //cbbPassage.Enabled = false;
                        //cbbNoPassage.Enabled = false;
                        //cbbCollectPrint.Enabled = false;
                        //cbbOnePrint.Enabled = false;
                        //cbbExpire.Enabled = false;
                       //  MainRadGridView.Columns["GatePass_State"].IsVisible = false;
						break;
					case AllFunctions._StatusPack.Passage:


                        //cbbEdit.Enabled = false;
                        //cbbNew.Enabled = false;
                        //cbbGroupCar.Enabled = false;

                      //  cbbSecureForm.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPersons_update);
                        cbbSecureForm.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPersons_update);
                        cbbCollectPrint.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.PrintWithoutPic)
                                                || ItemsPublic.MyRights.Contains(AllFunctions._Rights.PrintWithPic);

                     
                    //    cbbCollectPrint.Enabled = cbbOnePrint.Enabled;
                        cbbView.Enabled = true;
                    //    cbbExpire.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPacksGps_ExpireGp);

                        //cbbSaveTo.Enabled = false;
                        //cbbRequest.Enabled = false;
                        //cbbConfirm.Enabled = false;
                        //cbbNoConfirm.Enabled = false;
                        //cbbPassage.Enabled = false;
                        //cbbNoPassage.Enabled = false;
                       ////  MainRadGridView.Columns["GatePass_State"].IsVisible = false;
						break;
					case AllFunctions._StatusPack.NoPassage:

                        cbbSecureForm.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPersons_update);
                        cbbSaveTo.Enabled=true;
						cbbRequest.Enabled=true;
                        cbbView.Enabled = true;
                        cbbNew.Enabled = true;
                        cbbEdit.Enabled = true;
                        cbbGroupCar.Enabled = true;

                        //cbbConfirm.Enabled = false;
                        //cbbNoConfirm.Enabled = false;
                        //cbbPassage.Enabled = false;
                        //cbbNoPassage.Enabled = false;
                        //cbbCollectPrint.Enabled = false;
                        //cbbOnePrint.Enabled = false;
                        //cbbExpire.Enabled = false;
                       //  MainRadGridView.Columns["GatePass_State"].IsVisible = false;
						break;
				}

			}

			//if ( rgvPack.CurrentRow.Cells ["package_Id"].Value == null 
			//||  ( int? ) rgvPack.CurrentRow.Cells ["package_Id"].Value==-1 )
			//{
			//      cbbSecureForm.Enabled=false;
			//} 
            //if (v3UC_PackDetailsGp21.rcbHaveVehicle.Checked && cbbEdit.Enabled)
            //{
            //    cbbDriver.Enabled = true;
            //}
            //else
            //{
            //    cbbDriver.Enabled = false;
            //}
			//rightCbbDriver.Enabled = cbbDriver.Enabled;
      //      rightCbbGroupCar.Enabled = cbbGroupCar.Enabled;
			rightCbbSecure.Enabled = cbbSecureForm.Enabled;
           // rightCbbExpire.Enabled = cbbExpire.Enabled;
		//	rightCbbEdit.Enabled = cbbEdit.Enabled;
		//	rightCbbNew.Enabled = cbbNew.Enabled;
			//rightCbbOnePrint.Enabled = cbbOnePrint.Enabled;
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
			ric.AddRange(cbbCancel, cbbCollectPrint, cbbEdit, cbbNew, cbbOnePrint, cbbSave, cbbDriver,cbbGroupCar, cbbView, cbbSaveTo,
			             cbbConfirm,
			             cbbNoConfirm, cbbPassage, cbbNoPassage, cbbRequest);
			ric.AddRange(rmiCancel, rmiCopy, rmiCut, rmiHelp2, rmiPaste, rmiSave, rmiCollectPrint, rmiStatusEdit,
			             rmiStatusExit, rmiStatusNew, rmiOnePrint, rmiDriver, rmiStatusSettingPrint,
			             rmiStatusView);
            ric.AddRange(rightCbbSecure,rightCbbTagId, rightCbbDriver, rightCbbEmptyCar, rightCbbOnePrint);


            //this.rightCbbView.Tag = cbbView.Tag;
            //this.rightCbbNew.Tag = cbbNew.Tag;
            //this.rightCbbEdit.Tag = cbbEdit.Tag;
            this.rightCbbDriver.Tag = cbbDriver.Tag;
            this.rightCbbTagId.Tag = cbbOnePrint.Tag;  /// ooooooooooooooooooooooooo
            
            this.rightCbbEmptyCar.Tag = cbbView.Tag;
            //this.rightCbbGroupCar.Tag = cbbGroupCar.Tag;
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

		public frm_InpackGP()
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
				//v3UC_PackDetailsGp21.uC_vehicleDetails31.SetModelsCar();
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
            //bool kk = (MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value == null ? false : (string.IsNullOrEmpty(MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value.ToString())?false: (bool)MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value));
            
			if (!ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsPacksGps_ExpireGp)
			    || MainRadGridView.CurrentRow == null
			    ||  ((MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value == null ? false : (bool)MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value))
			    || rgvPack == null
				)
			{
				return false;
			}

            //if ((AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value == AllFunctions._StatusPack.Request
            //    && ItemsPublic.MyRights.Contains(AllFunctions._Rights.confirm)
            //    )
            //{
            //    return true;
            //}

            //if ((AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value == AllFunctions._StatusPack.Confirm ||
            //    (AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value == AllFunctions._StatusPack.Passage)
            //{
            //    switch ((AllFunctions._TypePack) rgvPack.CurrentRow.Cells["TypePack_Id"].Value)
            //    {
            //            #region type pack && rights

            //        case AllFunctions._TypePack.Guest:
            //            if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageGuest))
            //            {
            //                return true;
            //            }
            //            break;
            //        case AllFunctions._TypePack.TeachTrainee:
            //            if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageTrainee))
            //            {
            //                return true;
            //            }
            //            break;
            //        case AllFunctions._TypePack.TeachAct:
            //            if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageTrainee))
            //            {
            //                return true;
            //            }
            //            break;
            //        case AllFunctions._TypePack.TeachUni:
            //            if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageTrainee))
            //            {
            //                return true;
            //            }
            //            break;
            //        case AllFunctions._TypePack.TempWork:
            //            if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageGuest))
            //            {
            //                return true;
            //            }
            //            break;
            //        case AllFunctions._TypePack.Company:
            //            if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageGuest))
            //            {
            //                return true;
            //            }
            //            break;
            //        case AllFunctions._TypePack.WorkerMan:
            //            if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageWorkerMan))
            //            {
            //                return true;
            //            }
            //            break;
            //        case AllFunctions._TypePack.WorkerWoman:
            //            if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassgeWorkerWoman))
            //            {
            //                return true;
            //            }
            //            break;
            //        default:
            //            ItemsPublic.Exeptor("نوع بسته نامشخص می باشد");
            //            break;
            //            //   datas[_IdData.Event_Description] += "\n" + "نوع بسته نامشخص می باشد";
            //            //  throw new Exception();

            //            #endregion
            //    }
            //}

			return true;
		}

		protected void SetProperties()
		{
			try
			{
                //if (true)
                //{
					//   MessageBox.Show(MainRadGridView.CurrentRow.Cells[0].Value.ToString());
					if (!IsnewRowAdded && MainRadGridView.SelectedRows.Count == 1)
					{
						SetPicIfHaveRight();
						ShowPropertiesItems();
                        

                        if (pmStatus != ItemsPublic.IndexStatus.toNew)
                        {

                            cbbExpire.Enabled = haveRightToExpireGp();

                            switch ((AllFunctions._StatusPack)rgvPack.CurrentRow.Cells["StatusPack_Id"].Value)
                            //switch ((AllFunctions._StatusPack)pmStatus)
                            {
                                case AllFunctions._StatusPack.Request:
                                    cbbDriver.Enabled = false;
                                    cbbOnePrint.Enabled = false;
                                    break;
                                case AllFunctions._StatusPack.Confirm:
                                    cbbDriver.Enabled = false;
                                    cbbOnePrint.Enabled = false;
                                    break;
                                case AllFunctions._StatusPack.Passage:
                                    cbbDriver.Enabled = false;
                                    cbbOnePrint.Enabled = ItemsPublic.MyRights.Contains(AllFunctions._Rights.PrintWithoutPic)
                                                || ItemsPublic.MyRights.Contains(AllFunctions._Rights.PrintWithPic);
                                    break;
                                default:
                                    cbbOnePrint.Enabled = false;
                                    cbbDriver.Enabled = (MainRadGridView.CurrentRow.Cells["Person_LicenseDriverCode"].Value != null
                                ? !string.IsNullOrEmpty(MainRadGridView.CurrentRow.Cells["Person_LicenseDriverCode"].Value.ToString().Trim())
                                : false);

                                    break;
                            }
                        }
                        else
                        {
                            // new 
                            cbbExpire.Enabled = false;
                            cbbOnePrint.Enabled = false;
                            cbbDriver.Enabled = (MainRadGridView.CurrentRow.Cells["Person_LicenseDriverCode"].Value != null
                               ? !string.IsNullOrEmpty(MainRadGridView.CurrentRow.Cells["Person_LicenseDriverCode"].Value.ToString().Trim())
                               : false);
                        }
                        
						//var a3 = (bool) MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value != true;

						//cbbExpire.Enabled =( MainRadGridView.CurrentRow != null
						//                    && (bool) MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value == false
						//                    &&
						//                    (rgvPack != null &&
						//                     ((AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value ==
						//                     AllFunctions._StatusPack.Passage || (AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value ==AllFunctions._StatusPack.Confirm || (AllFunctions._StatusPack) rgvPack.CurrentRow.Cells["StatusPack_Id"].Value ==AllFunctions._StatusPack.Request)));


                        

                        rightCbbDriver.Enabled = cbbDriver.Enabled;//
						rightCbbExpire.Enabled = cbbExpire.Enabled;//
                        rightCbbOnePrint.Enabled = cbbOnePrint.Enabled;//
                        rightCbbTagId.Enabled = cbbOnePrint.Enabled;
                     //   rightCbbSecure.Enabled = cbbSecureForm.Enabled;//



					}
					else
					{
                        cbbExpire.Enabled = false;
                        rightCbbExpire.Enabled = false;
                        cbbDriver.Enabled = false;
                        rightCbbDriver.Enabled = false;
                      //  cbbSecureForm.Enabled = false;
                     //   rightCbbSecure.Enabled = false;

                        cbbOnePrint.Enabled = false;
                        rightCbbTagId.Enabled = false;
                        
                        rightCbbOnePrint.Enabled = false;


						uC_ViewPersonDetails1.rbtnImage.Enabled = false;
						objManager.EmptyControls(myAll);
					}
				//}
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

        protected bool QuestionSureToExpireGp()
        {
            var dr = MessageBox.Show("در صورت منقضی کردن، مجوز مربوطه از اعتبار ساقط می شود"+"\r\n"+"آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo,
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
              //  MainRadGridView.Visible = false;
             //   MainRadGridView.Enabled = false;
              //  MainRadGridView.CurrentRow = null;
              //  return;
              //  MainRadGridView.Visible = false;
                copyingMode = true;
                var frmAddPersons = new aorc.gatepass.Gp2.Pack.frm_SelectOrAddPersonsGp2();
				////   frmAddPersons.pmStatus = ItemsPublic.IndexStatus.toEdit;
				//  frmAddPersons.IndexPack = (decimal?)MainRadGridView.CurrentRow.Cells["package_Id"].Value;
				// //  frmAddPersons.setItemsPack(ref radGridViewPacks);
				//frmAddPersons.radGridViewSelected = MainRadGridView;
				//frmAddPersons.radGridViewSelected.DataSource=MainRadGridView;

				//frmAddPersons.radGridViewSelected = MainRadGridView;

				//	frmAddPersons.radGridViewSelected.DataSource = MainRadGridView.DataSource;
				if (MainRadGridView.Rows.Count != 0)
				{
                    
                    ItemsPublic.copyGrid(MainRadGridView, frmAddPersons.radGridViewSelected);
                  //  frmAddPersons.radGridViewSelected.DataSource = MainRadGridView.Rows;
				}
				frmAddPersons.ShowDialog();
				if (frmAddPersons.State)
				{
					
					//MainRadGridView.SelectAll();
                    CursorWait();
                    changeMode = true;
                    MainRadGridView.CurrentRow = null;
					MainRadGridView.AllowAddNewRow = true;
					IsnewRowAdded = true;
                    MainRadGridView.DataSource = null;
                    //MainRadGridView = null;
					//MainRadGridView.Rows.RemoveAt(0);
					//MainRadGridView.DataSource = null;
					//MainRadGridView.EndInit();
					//MainRadGridView.EndUpdate();
				//	MainRadGridView.EndEdit();
                    //while (MainRadGridView.Rows.Count > 0)
                    //{
                    //    MainRadGridView.Rows.RemoveAt(0);
                    //}

					//for (int count = 0; count < frmAddPersons.radGridViewSelected.Rows.Count; count++)
					//{

                    // copyGridFast
                    ItemsPublic.copyGrid(frmAddPersons.radGridViewSelected, MainRadGridView);
					//}
				//	MainRadGridView.AllowAddNewRow = false;
					//IsnewRowAdded = false;
				//	MainRadGridView.Refresh();
                    CursorDefault();
					//radGridViewPackManage.Enabled = true;
				}
				frmAddPersons.Close();
				frmAddPersons.Dispose();
				//setPackInfo();
			}
			catch (Exception ex)
			{
                CursorDefault();
              //  MainRadGridView.Visible = true;
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
			}

			//IsnewRowAdded = true;

            MainRadGridView.AllowAddNewRow = false;
            //IsnewRowAdded = false;
            copyingMode = false;
           // MainRadGridView.Refresh();
			IsnewRowAdded = false;
            MainRadGridView.CurrentRow = null;
			rightsEnableControls();
          //  MainRadGridView.Visible = true;
           

		}

		protected void cbbEdit_Click(object sender, EventArgs e)
        {


          //  MethodComplex();
          //  return;

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
                
                var frmSet = new aorc.gatepass.Gp2.Pack.frm_SettingPackGatePlaceGp2();
				frmSet.SetSettings(this.v3UC_PackDetailsGp21);
				frmSet.ShowDialog();
				if (frmSet.DialogResult == DialogResult.OK)
				{
                    changeMode = true;                    
					MainRadGridView.CurrentRow = null;
					this.SetSetting(frmSet.v2UC_NewPackDetailsGp21);
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
        private void cbbEmptyCar(object sender, EventArgs e)
        {
            try
            {
                changeMode = true;
                uC_vehicleDetails31.rtbColor.Text = "";
                uC_vehicleDetails31.rtbModel.Text = "";
                uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex = -1;
                uC_vehicleDetails31.uC_PlatesCar1.CarNumber = "";
                uC_vehicleDetails31.indexTypeModel = null;
                uC_vehicleDetails31.rddlState.SelectedIndex = -1;

                MainRadGridView.CurrentRow.Cells["Vehicle_ID"].Value
                = null;

                MainRadGridView.SelectedRows[0].Cells["Vehicle_Model"].Value
                = "";

                MainRadGridView.SelectedRows[0].Cells["vehicle_Color"].Value
                = "";

                MainRadGridView.SelectedRows[0].Cells["TypePlates_Id"].Value
                = null;

                MainRadGridView.SelectedRows[0].Cells["Vehicle_number"].Value
                = "";

                MainRadGridView.SelectedRows[0].Cells["Vehicle_IsCompany"].Value
                = null;

                MainRadGridView.SelectedRows[0].Cells["VehicleType_ID"].Value
                = null;

            }catch(Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
            }

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
                    var frm = new gatepass.ui.package.frm_SelectOneVehicle();
                    frm.PersonId = (decimal)MainRadGridView.CurrentRow.Cells["Person_ID"].Value;
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        changeMode = true;
                        uC_vehicleDetails31.rtbColor.Text = frm.Vcolor;
                        uC_vehicleDetails31.rtbModel.Text = frm.VModel;
                        uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex = frm.VTypePlateIndex;
                        uC_vehicleDetails31.uC_PlatesCar1.CarNumber = frm.Vnumber;
                        uC_vehicleDetails31.indexTypeModel = frm.VTypeIndex;
                        uC_vehicleDetails31.rddlState.SelectedIndex = frm.VisCompany ? 0 : 1;

                        MainRadGridView.CurrentRow.Cells["Vehicle_ID"].Value
                        = frm.CurrentId;

                        MainRadGridView.SelectedRows[0].Cells["Vehicle_Model"].Value
                        = uC_vehicleDetails31.rtbModel.Text.Trim();

                        MainRadGridView.SelectedRows[0].Cells["vehicle_Color"].Value
                        = uC_vehicleDetails31.rtbColor.Text.Trim();

                        MainRadGridView.SelectedRows[0].Cells["TypePlates_Id"].Value
                        = uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex.ToString().Trim();

                        MainRadGridView.SelectedRows[0].Cells["Vehicle_number"].Value
                        = uC_vehicleDetails31.uC_PlatesCar1.CarNumber;

                        MainRadGridView.SelectedRows[0].Cells["Vehicle_IsCompany"].Value
                        = uC_vehicleDetails31.rddlState.SelectedIndex == 0 ? true : false;

                        MainRadGridView.SelectedRows[0].Cells["VehicleType_ID"].Value
                        = uC_vehicleDetails31.indexTypeModel.ToString().Trim();

                    }
                    frm.Close();
                    frm.Dispose();
				}
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
			// this.Close();
			}
		}

        private void cbbTagId_Click(object sender, EventArgs e) 
        {
            try {

                if (MainRadGridView.SelectedRows.Count() == 1)
                {
                    decimal? GpId = (decimal)MainRadGridView.CurrentRow.Cells["Gatepass_ID"].Value;
                    // panjereh gereftane ADAD
                    var frmDialog = new frm_EsiInputBox();
                    frmDialog.setItems("تخصیص کد تردد", "لطفا شماره سریال مجوز را وارد نمایید");
                    CursorWait();
                    if (frmDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    string strValue = frmDialog.message.Trim();
                    if (ItemsPublic.IsDigitNumber(strValue, -10))
                    {
                        decimal? myTagId = decimal.Parse(strValue);

                        //   decimal? arcId = decimal.Parse(ucSearchInOut.rtbGpId.Text.Trim());
                        //   decimal? tagId = decimal.Parse(ucSearchInOut.rtbTagId.Text.Trim());

                        var resultTag = objManager.UpdateTag(GpId, myTagId,true);

                        if (resultTag != null)
                            if (resultTag.success)
                            {
                                ItemsPublic.ShowMessage("کد تردد تخصیص یافت");

                                //if (QuestionSureTo("تگ تخصیص یافت" + "\r\n\r\n" + "اقدام برای تخصیص تگی دیگر"))
                                //    {                                    
                                //  emptyProperties();
                                //    radGridViewReport.DataSource = null;
                                //    ucSearchInOut.clearItems();
                                //   }

                                //copyingMode = true;

                                //copyingMode = false;
                                //if (radGridViewReport.Rows.Count < 1)
                                //{
                                //    ItemsPublic.ShowMessage("موردی یافت نشد");
                                //}
                                //else
                                //{
                                //    radLabelElementStatus.Text = "                         " + "تعداد موارد یافت شده: " + radGridViewReport.Rows.Count.ToString() + "                         ";
                                //    //radLabelElementStatus.LabelFill.BackColor = Color.FromArgb(238,204,156);
                                //    //radLabelElementStatus.LabelFill.BackColor2 = Color.FromArgb(255, 149, 0);
                                //    //radLabelElementStatus.LabelFill.BackColor3 = Color.FromArgb(178,118,34);
                                //    //radLabelElementStatus.LabelFill.BackColor4 = Color.FromArgb(114,74,19);
                                //}
                            }
                            else
                            {
                                ItemsPublic.ShowMessage("انجام عملیات تخصیص تگ به یک مجوز به دلیل زیر انجام نشد" + "\r\n" + "\r\n" + resultTag.Message);
                            }
                    }
                    else
                    {
                        ItemsPublic.ShowMessage("مقدار وارد شده فرمت عددی نیست");
                    }
                }
                CursorDefault();
            }
            catch (Exception ex)
            {
                CursorDefault();
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
                rightsEnableControls();
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
                            PutPassOrder(result.ResultTable);
						//	MainRadGridView.DataSource = result.ResultTable;
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
							//MainRadGridView.DataSource = result.ResultTable;
                            PutPassOrder(result.ResultTable);
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
                            //if (v3UC_PackDetailsGp21.rcbHaveVehicle.Checked)
                            //{
                            //    if (CurrentDriverId == null && personIdDriver() == null)
                            //    {
                            //        //	ItemsPublic.Exeptor("راننده ای برای خودرو انتخاب نشده است");
                            //    }
                            //    if (CurrentDriverId != null)
                            //    {
                            //        foreach (var row in MainRadGridView.Rows)
                            //        {
                            //            if ((bool) row.Cells["GatePass_IsDriver"].Value)
                            //            {
                            //                //break;

                            //                row.Cells["GatePass_IsDriver"].Value = false;

                            //                break;
                            //            }
                            //        }
                            //        foreach (var row in MainRadGridView.Rows)
                            //        {
                            //            if ((decimal) row.Cells["Person_ID"].Value == CurrentDriverId)
                            //            {
                            //                //	break;
                            //                row.Cells["GatePass_IsDriver"].Value = true;
                            //                break;
                            //            }
                            //        }
                            //        //	MainRadGridView.EndEdit ();
                            //        //	MainRadGridView.CloseEditor();
                            //        //	MainRadGridView.Refresh();
                            //        CurrentDriverId = null;
                            //    }
                            //}
                            //else
                            //{
                            //    CurrentDriverId = null;
                            //    foreach (var row in MainRadGridView.Rows)
                            //    {
                            //        if ((bool) row.Cells["GatePass_IsDriver"].Value)
                            //        {
                            //            row.Cells["GatePass_IsDriver"].Value = false;
                            //            //MainRadGridView.EndEdit ();
                            //            //MainRadGridView.CloseEditor ();
                            //            //MainRadGridView.Refresh ();
                            //            break;
                            //        }
                            //    }
                            //}
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

        private void PutPassOrder(DataTable dataTable)
        {
            // quantifier     Person_Picture         Person_HaveForm    Person_SecureFormDate
            dataTable.Columns.Add("quantifier", typeof(decimal));
           
        //    List<decimal> IdSort = new List<decimal>();
            decimal kkk = 0;
            foreach (DataRow item in dataTable.Rows)
            {

                kkk = 0;
                if (!(item["Person_Picture"] is DBNull) && item["Person_Picture"] != null)
                {
                    kkk++;
                }

                if ((bool)item["Person_HaveForm"] == true)
                {
                    kkk++;
                }
                if (!(item["Person_SecureFormDate"] is DBNull) &&
                     item["Person_SecureFormDate"] != null)
                {
                    
                    kkk++;
                }
              
                item["quantifier"] = kkk;
            }
            MainRadGridView.DataSource = dataTable;
         //   MainRadGridView.Rows.OrderByDescending(x => x.Cells["quantifier"]);
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
				//CurrentDriverId = null;
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

		//private GroupDescriptor descG = new GroupDescriptor("GatePass_IsExpired");

		private void frm_InpackGP_Load(object sender, EventArgs e)
		{
            var hh =  MainRadGridView.Rows.AsEnumerable();
            uC_vehicleDetails31.SetModelsCar();
			//MainRadGridView.GroupDescriptors.Add(descG);
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

            uC_vehicleDetails31.rtbColor.Tag =
                "a";

            uC_vehicleDetails31.rtbModel.Tag =
               "a";


            uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.Tag =
                "a";

            uC_vehicleDetails31.uC_PlatesCar1.CarNumberTags =
              "a";

            uC_vehicleDetails31.rddlState.Tag =
               "a";

            uC_vehicleDetails31.rddlType.Tag =
               "a";

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
            try
            {
                var result = new OutputDatas();
                var objGateManager = new Manager();

                result = objGateManager.View_Gates(IndexPack);
                if (result.success)
                {

                    v3UC_PackDetailsGp21.rtbGates.Text = "";
                    v3UC_PackDetailsGp21.CurrentGates = new List<int>();
                    foreach (DataRow obj in result.ResultTable.Rows)
                    {
                        //	string ss = obj.Cells["Gate_Id"].Value.ToString().Trim();
                        //int ii = int.Parse(obj.Cells["Gate_Id"].Value.ToString().Trim());
                        v3UC_PackDetailsGp21.CurrentGates.Add(int.Parse(obj["Gate_Id"].ToString().Trim()));
                        v3UC_PackDetailsGp21.rtbGates.Text += obj["Gate_Name"].ToString().Trim() + "\r\n";
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
                    v3UC_PackDetailsGp21.rtbPlaces.Text = "";
                    v3UC_PackDetailsGp21.CurrentPlaces = new List<int>();
                    foreach (DataRow obj in result.ResultTable.Rows)
                    {
                        //	string ss = obj.Cells["Place_Id"].Value.ToString().Trim();
                        //int ii = int.Parse(obj.Cells["Place_Id"].Value.ToString().Trim());
                        v3UC_PackDetailsGp21.CurrentPlaces.Add(int.Parse(obj["Place_Id"].ToString().Trim()));
                        v3UC_PackDetailsGp21.rtbPlaces.Text += obj["Place_Name"].ToString().Trim() + "\r\n";
                    }
                }
                else
                {
                    ItemsPublic.ShowMessage(result.Message);
                }



                v3UC_PackDetailsGp21.rddlShift.Text = rgvPack.CurrentRow.Cells["Package_Shift"].Value.ToString().Trim();

                v3UC_PackDetailsGp21.rtbStatusPack.Text = rgvPack.CurrentRow.Cells["StatusPack_Label"].Value.ToString().Trim();
                v3UC_PackDetailsGp21.rtbPackId.Text = rgvPack.CurrentRow.Cells["Package_TicketId"].Value.ToString().Trim();
                
                v3UC_PackDetailsGp21.rtbOffice.Text = rgvPack.CurrentRow.Cells["Office_Name"].Value.ToString().Trim();



                if (rgvPack.CurrentRow.Cells["TypePack_Id"].Value != null)
                {
                    if (!(rgvPack.CurrentRow.Cells["TypePack_Id"].Value is DBNull))
                    {
                        v3UC_PackDetailsGp21.TypePackRealId = (int)rgvPack.CurrentRow.Cells["TypePack_Id"].Value;
                        v3UC_PackDetailsGp21.isGpType = (bool?)rgvPack.CurrentRow.Cells["TypePack_IsShort"].Value;
                        v3UC_PackDetailsGp21.rddlTypePack.Text = rgvPack.CurrentRow.Cells["TypePack_Name"].Value.ToString().Trim();
                    }

                    else
                    {
                        v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = -1;
                    }
                }
                else
                {
                    v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = -1;
                }



                if (rgvPack.CurrentRow.Cells["Package_StartDate"] != null)
                    if (rgvPack.CurrentRow.Cells["Package_StartDate"].Value != null)
                        if (!string.IsNullOrEmpty(rgvPack.CurrentRow.Cells["Package_StartDate"].Value.ToString()))
                {
                    v3UC_PackDetailsGp21.bdcStartDate.DateTime =
                       (DateTime)rgvPack.CurrentRow.Cells["Package_StartDate"].Value;
                }
                else
                {
                    v3UC_PackDetailsGp21.bdcStartDate.DateTime = (DateTime?)null;
                }


                //v3UC_PackDetailsGp21.bdcStartDate.DateTime = (DateTime) rgvPack.CurrentRow.Cells["Package_StartDate"].Value;
                //v3UC_PackDetailsGp21.bdcEndDate.DateTime = (DateTime) rgvPack.CurrentRow.Cells["Package_EndDate"].Value;

                if (rgvPack.CurrentRow.Cells["Package_EndDate"] != null)
                    if (rgvPack.CurrentRow.Cells["Package_EndDate"].Value != null)
                        if (!string.IsNullOrEmpty(rgvPack.CurrentRow.Cells["Package_EndDate"].Value.ToString()))
                {
                    v3UC_PackDetailsGp21.bdcEndDate.DateTime =
                       (DateTime)rgvPack.CurrentRow.Cells["Package_EndDate"].Value;
                }
                else
                {
                    v3UC_PackDetailsGp21.bdcEndDate.DateTime = (DateTime?)null;
                }


                v3UC_PackDetailsGp21.rddlValid.SelectedIndex = ((bool)rgvPack.CurrentRow.Cells["Package_IsExpired"].Value) ? 0 : 1;

                v3UC_PackDetailsGp21.rtbNumberAgree.Text = rgvPack.CurrentRow.Cells["Agreement_Number"].Value.ToString().Trim();
                string temS = rgvPack.CurrentRow.Cells["Agreement_ID"].Value.ToString().Trim();
                decimal? temp = string.IsNullOrEmpty(temS) ? (decimal?)null : decimal.Parse(temS);
                v3UC_PackDetailsGp21.CurrentAgreeId = temp;
                v3UC_PackDetailsGp21.rtbCompanyAgree.Text = rgvPack.CurrentRow.Cells["Agreement_Company"].Value.ToString().Trim();
                //	v3UC_PackDetailsGp21.rtbTitleAgree.Text = rgvPack.CurrentRow.Cells["Agreement_Title"].Value.ToString().Trim();
                v3UC_PackDetailsGp21.rlblCountCar.Text = ItemsPublic.HowManyCarInAgree(temp);


                temS = rgvPack.CurrentRow.Cells["TravelArea_Id"].Value.ToString().Trim();
                int? temp2 = string.IsNullOrEmpty(temS) ? (int?)null : int.Parse(temS);
                v3UC_PackDetailsGp21.CurrentTravelId = temp2;

                v3UC_PackDetailsGp21.rtbTravelLabel.Text =
                    rgvPack.CurrentRow.Cells["TravelArea_LabelTravel"].Value.ToString().Trim();

                v3UC_PackDetailsGp21.rtbOperRequest.Text = rgvPack.CurrentRow.Cells["OperRequestName"].Value.ToString().Trim();
                v3UC_PackDetailsGp21.rtbOperConfirm.Text = rgvPack.CurrentRow.Cells["OperConfirmName"].Value.ToString().Trim();
                v3UC_PackDetailsGp21.rtbOperPassage.Text = rgvPack.CurrentRow.Cells["OperPassageName"].Value.ToString().Trim();
                v3UC_PackDetailsGp21.tbPackDescriptions.Text =
                    rgvPack.CurrentRow.Cells["Package_Description"].Value.ToString().Trim();

                //v3UC_PackDetailsGp21.uC_vehicleDetails21.rddlType.SelectedIndex =
                //string stV = rgvPack.CurrentRow.Cells["Vehicle_ID"].Value.ToString().Trim();
                //bool boV = !string.IsNullOrEmpty(stV);
                //v3UC_PackDetailsGp21.rcbHaveVehicle.Checked = boV;
                //if (v3UC_PackDetailsGp21.rcbHaveVehicle.Checked)
                //{
                //    v3UC_PackDetailsGp21.CurrentCarId = (decimal?) rgvPack.CurrentRow.Cells["Vehicle_ID"].Value;
                //    v3UC_PackDetailsGp21.uC_vehicleDetails31.rtbModel.Text =
                //        rgvPack.CurrentRow.Cells["Vehicle_Model"].Value.ToString().Trim();
                //    v3UC_PackDetailsGp21.uC_vehicleDetails31.rtbColor.Text =
                //        rgvPack.CurrentRow.Cells["vehicle_Color"].Value.ToString().Trim();



                //    v3UC_PackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex =
                //        (int)rgvPack.CurrentRow.Cells["TypePlates_Id"].Value;


                //    v3UC_PackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.CarNumber =
                //        rgvPack.CurrentRow.Cells["Vehicle_number"].Value.ToString().Trim();



                //    v3UC_PackDetailsGp21.uC_vehicleDetails31.rddlState.SelectedIndex =
                //        (bool) rgvPack.CurrentRow.Cells["Vehicle_IsCompany"].Value ? 0 : 1;
                //    v3UC_PackDetailsGp21.uC_vehicleDetails31.indexTypeModel =
                //        (int?) rgvPack.CurrentRow.Cells["VehicleType_ID"].Value;
                //}
                //else
                //{
                //    v3UC_PackDetailsGp21.rcbHaveVehicle.Checked = false;
                //}

            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                this.Close();
            }
		}

		private void setEmptyInfo()
		{
			//v3UC_PackDetailsGp21.CurrentCarId = null;
			//CurrentDriverId = null;
			v3UC_PackDetailsGp21.rtbStatusPack.Text = "در حال ساخت";
            v3UC_PackDetailsGp21.rtbPackId.Text = "شماره ندارد";
			v3UC_PackDetailsGp21.rtbOffice.Text = "";
			v3UC_PackDetailsGp21.rddlTypePack.SelectedIndex = -1;
			v3UC_PackDetailsGp21.bdcStartDate.DateTime = null;
			v3UC_PackDetailsGp21.bdcEndDate.DateTime = null;
			v3UC_PackDetailsGp21.rddlValid.SelectedIndex = -1;
			v3UC_PackDetailsGp21.rtbNumberAgree.Text = "";
			v3UC_PackDetailsGp21.CurrentAgreeId = null;
			v3UC_PackDetailsGp21.rtbCompanyAgree.Text = "";
			//v3UC_PackDetailsGp21.rtbTitleAgree.Text = "";

			v3UC_PackDetailsGp21.CurrentTravelId = null;

			v3UC_PackDetailsGp21.rtbTravelLabel.Text = "";

			v3UC_PackDetailsGp21.rtbOperRequest.Text = "";
			v3UC_PackDetailsGp21.rtbOperConfirm.Text = "";
			v3UC_PackDetailsGp21.rtbOperPassage.Text = "";
			v3UC_PackDetailsGp21.tbPackDescriptions.Text = "";
            //v3UC_PackDetailsGp21.rcbHaveVehicle.Checked = false;
            //v3UC_PackDetailsGp21.uC_vehicleDetails31.rtbModel.Text = "";
            //v3UC_PackDetailsGp21.uC_vehicleDetails31.rtbColor.Text = "";
            //v3UC_PackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex =-1;
            //v3UC_PackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.CarNumber = "";
            //v3UC_PackDetailsGp21.uC_vehicleDetails31.rddlState.SelectedIndex = -1;
            //v3UC_PackDetailsGp21.uC_vehicleDetails31.indexTypeModel = null;
		}

		private void ShowPropertiesItems()
		{
            if (MainRadGridView.SelectedRows[0].Cells["Vehicle_ID"].Value != null )
                if (!string.IsNullOrEmpty(MainRadGridView.SelectedRows[0].Cells["Vehicle_ID"].Value.ToString()))
                {
                    //  string kk = ":"+MainRadGridView.SelectedRows[0].Cells["Vehicle_ID"].Value.ToString()+":";
                    //   MessageBox.Show(kk);
                    uC_vehicleDetails31.rtbModel.Text =
                        MainRadGridView.SelectedRows[0].Cells["Vehicle_Model"].Value.ToString().Trim();

                    uC_vehicleDetails31.rtbColor.Text =
                        MainRadGridView.SelectedRows[0].Cells["vehicle_Color"].Value.ToString().Trim();

                    uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex =
                        int.Parse(MainRadGridView.SelectedRows[0].Cells["TypePlates_Id"].Value.ToString());

                    uC_vehicleDetails31.uC_PlatesCar1.CarNumber =
                        MainRadGridView.SelectedRows[0].Cells["Vehicle_number"].Value.ToString().Trim();

                    uC_vehicleDetails31.rddlState.SelectedIndex =
                        (bool)MainRadGridView.SelectedRows[0].Cells["Vehicle_IsCompany"].Value ? 0 : 1;

                    uC_vehicleDetails31.indexTypeModel =
                        int.Parse(MainRadGridView.SelectedRows[0].Cells["VehicleType_ID"].Value.ToString());
                }
                else
                {
                    uC_vehicleDetails31.rtbModel.Text ="";

                    uC_vehicleDetails31.rtbColor.Text ="";

                    uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex = -1;
                        
                    uC_vehicleDetails31.uC_PlatesCar1.CarNumber = "";

                    uC_vehicleDetails31.rddlState.SelectedIndex = -1;

                    uC_vehicleDetails31.indexTypeModel = null;                      
                }

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
            //if (((bool) MainRadGridView.SelectedRows[0].Cells["Person_HaveForm"].Value))
            //{
				if (! (MainRadGridView.SelectedRows[0].Cells["Person_SecureFormDate"].Value is DBNull) &&
				    MainRadGridView.SelectedRows[0].Cells["Person_SecureFormDate"].Value != null)
					uC_ViewPersonDetails1.bdcEndSecureDate.DateTime =
						(DateTime) MainRadGridView.SelectedRows[0].Cells["Person_SecureFormDate"].Value;
				else
					uC_ViewPersonDetails1.bdcEndSecureDate.DateTime = (DateTime?) null;
            //}
            //else
            //{
            //    uC_ViewPersonDetails1.bdcEndSecureDate.DateTime = (DateTime?) null;
            //}
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



            //if (MainRadGridView.SelectedRows[0].Cells["Vehicle_Model"].Value != null)
            //uC_vehicleDetails31.rtbModel.Text =
            //   MainRadGridView.SelectedRows[0].Cells["Vehicle_Model"].Value.ToString().Trim();

            //if (MainRadGridView.SelectedRows[0].Cells["vehicle_Color"].Value != null)
            //    uC_vehicleDetails31.rtbColor.Text =
            //   MainRadGridView.SelectedRows[0].Cells["vehicle_Color"].Value.ToString().Trim();


            //if (MainRadGridView.SelectedRows[0].Cells["Person_Phone1"].Value != null)
            //uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex = 
            //    (int)MainRadGridView.SelectedRows[0].Cells["TypePlates_Id"].Value;

            //if (MainRadGridView.SelectedRows[0].Cells["Person_Phone1"].Value != null)
            //uC_vehicleDetails31.uC_PlatesCar1.CarNumber =
            //   MainRadGridView.SelectedRows[0].Cells["Person_LicenseDriverCode"].Value.ToString().Trim();

            //if (MainRadGridView.SelectedRows[0].Cells["Person_Phone1"].Value != null)
            //uC_vehicleDetails31.rddlState.SelectedIndex =
            //   (int)MainRadGridView.SelectedRows[0].Cells["TypePlates_Id"].Value;

            //if (MainRadGridView.SelectedRows[0].Cells["Person_Phone1"].Value != null)
            //uC_vehicleDetails31.indexTypeModel = (int)MainRadGridView.SelectedRows[0].Cells["TypePlates_Id"].Value;
            


			//Get BlackList Status from Server
			//var temp = decimal.Parse(MainRadGridView.SelectedRows[0].Cells["Person_ID"].Value!=null;
			//if (BlackListData.ContainsKey(temp))
			//    uC_ViewPersonDetails1.TcoIsBlack.SelectedIndex = (BlackListData[temp] == false) ? 1 : 0;
			//else
			//    uC_ViewPersonDetails1.TcoIsBlack.SelectedIndex = 1;
		}

        private void cbbSellAllGp_Click(object sender, EventArgs e) 
        {
            foreach (var item in MainRadGridView.Rows)
            {
                if (item.Cells["GatePass_IsExpired"].Value == null)
                    break;
                if (!(bool)item.Cells["GatePass_IsExpired"].Value) 
                {
                    item.Cells["GatePass_State"].Value = true;
                }                
            }
        }
        private void cbbUnSellAllGp_Click(object sender, EventArgs e)
        {
            foreach (var item in MainRadGridView.Rows)
            {
                item.Cells["GatePass_State"].Value = false;
            }
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


				//if (!QuestionSureTo("آیا گ عدم تصویب درخواست مجوز را دارید؟"))
				//{
				//    return;
				//}


                if (!IsAnySelected())
                {
                    infoNosel();
                    return;
                }


				var frmDialog = new frm_GetMessage ();
				if ( frmDialog.ShowDialog () != DialogResult.OK )
				{
					return;
				}


                 CursorWait();


             //   CursorDefault();


				result = objManager.ClsPacksGps_passage
                    (IndexPack, AllFunctions._StatusPack.NoPassage,frmDialog.message,WhoAreMyPersons());


				if (result.success)
				{
                    string mailMessage = string.Empty;
                    aorc.gatepass.ui.mail.MailBarid requestMail = new aorc.gatepass.ui.mail.MailBarid();
                    if (!requestMail.SendMail(ItemsPublic.MyBaridId, (decimal)rgvPack.CurrentRow.Cells["OperRequestBaridId"].Value, (decimal)IndexPack, "عدم تصویب مجوز", "بسته رد تصویب شد با این توضیحات که "+frmDialog.message))
                    {
                        mailMessage = "\r\n\r\n" + "اما ارسال پیام در اتوماسیون ناموفق بود";
                    }
                    // CursorWait();
                    CursorDefault();
                    MessageBox.Show("بسته در مرحله تصویب رد شد" + mailMessage);
					CloseOk();
				}
				else
				{
                    // CursorWait();
                    CursorDefault();
					MessageBox.Show(result.Message);
				}



			}
			catch (Exception ex)
			{
                // CursorWait();
                CursorDefault();
				MessageBox.Show(ex.Message);
			}
		}

        private void infoNosel()
        {
            ItemsPublic.ShowMessage("هیچ شخصی انتخاب نشده است");
        }

        private bool IsAnySelected()
        {
            foreach (GridViewRowInfo item in MainRadGridView.Rows)
            {
                if(item.Cells["GatePass_State"].Value != null)
                    if (!(item.Cells["GatePass_State"].Value is DBNull))
                if ((bool)item.Cells["GatePass_State"].Value)
                {
                    return true;
                }
            }                
                return false;
        }

		private void cbbNoConfirm_Click(object sender, EventArgs e)
		{
			try
			{
				//if (!QuestionSureTo("آیا قصد عدم تایید درخواست مجوز را دارید؟"))
				//{
				//    return;
				//}

                if (!IsAnySelected())
                {
                    infoNosel();
                    return;
                }
               

				var frmDialog = new frm_GetMessage();
				if ( frmDialog.ShowDialog() != DialogResult.OK )
				 {
				 	return;
				 }
                CursorWait();
             //   CursorDefault();

				result = objManager.ClsPacksGps_confirm ( IndexPack , AllFunctions._StatusPack.NoConfirm , frmDialog.message,WhoAreMyPersons());
				if (result.success)
				{

                    string mailMessage = string.Empty;
                    aorc.gatepass.ui.mail.MailBarid requestMail = new aorc.gatepass.ui.mail.MailBarid();
                    if (!requestMail.SendMail(ItemsPublic.MyBaridId, (decimal)rgvPack.CurrentRow.Cells["OperRequestBaridId"].Value, (decimal)IndexPack, "عدم تایید مجوز", "بسته رد تایید شد با این توضیحات که "+frmDialog.message))
                    {
                        mailMessage = "\r\n\r\n" + "اما ارسال پیام در اتوماسیون ناموفق بود";
                    }

                   // CursorWait();
                    CursorDefault();
                    MessageBox.Show("بسته تایید نشد" + mailMessage);
					CloseOk();


				}
				else
				{
                   // CursorWait();
                    CursorDefault();
					MessageBox.Show(result.Message);
				}

			}
			catch (Exception ex)
			{
              //  CursorWait();
                CursorDefault();
				MessageBox.Show(ex.Message);
			}

		}

		private void cbbPassage_Click(object sender, EventArgs e)
		{
			try
			{


                if (!IsAnySelected())
                {
                    infoNosel();
                    return;
                }


				if (!QuestionSureTo("آیا قصد تصویب درخواست مجوز را دارید؟"))
				{
					return;
				}
                //, new OutputDatas()

                 CursorWait();
              //  CursorDefault();
                result = objManager.ClsPacksGps_passage(IndexPack, AllFunctions._StatusPack.Passage,null,WhoAreMyPersons());
				if (result.success)
				{
                    string mailMessage = string.Empty;
                    aorc.gatepass.ui.mail.MailBarid requestMail = new aorc.gatepass.ui.mail.MailBarid();
                    if (!requestMail.SendMail(ItemsPublic.MyBaridId, (decimal)rgvPack.CurrentRow.Cells["OperRequestBaridId"].Value, (decimal)IndexPack, "مجوز های تصویب شده", "بسته مجوز تصویب شد" + "..................................   " + WhoAreMyPersons_Label()))
                    {
                        mailMessage = "\r\n\r\n" + "اما ارسال پیام در اتوماسیون ناموفق بود";
                    }
                    // CursorWait();
                    CursorDefault();

                    //MessageBox.Show("بسته تصویب شد" + mailMessage);


                    rgvPack.CurrentRow.Cells["StatusPack_Id"].Value = (int)AllFunctions._StatusPack.Passage;

                    if (QuestionSureTo("بسته تصویب شد" + mailMessage + "\r\n\r\n" + "آیا تمایل به خروج دارید؟"))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    CursorWait();
                    cbbView_Click(null, null);
                    //  cbbSave_Click(null, null);
                    v3UC_PackDetailsGp21.rtbStatusPack.Text = "تصویب شده";
                    CursorDefault();
				}
				else
				{
                    // CursorWait();
                    CursorDefault();
					MessageBox.Show(result.Message);
				}
			}
			catch (Exception ex)
			{
                // CursorWait();
                CursorDefault();
				MessageBox.Show(ex.Message);
			}
		}

		private void cbbConfirm_Click(object sender, EventArgs e)
		{
			try
			{


                if (!IsAnySelected())
                {
                    infoNosel();
                    return;
                }


				if ( !QuestionSureTo ( "آیا قصد تایید درخواست مجوز را دارید؟" ) )
				{
					return;
				}

				//var frmDialog = new frm_GetMessage();
				//if ( frmDialog.ShowDialog() != DialogResult.OK )
				// {
				//    return;
				// }
                CursorWait();
               // CursorDefault();
				result = objManager.ClsPacksGps_confirm(IndexPack, AllFunctions._StatusPack.Confirm,null,WhoAreMyPersons());
				if (result.success)
				{
                    string mailMessage = string.Empty;
                    aorc.gatepass.ui.mail.MailBarid requestMail = new aorc.gatepass.ui.mail.MailBarid();
                    if (!requestMail.SendMail(ItemsPublic.MyBaridId, (decimal)rgvPack.CurrentRow.Cells["OperRequestBaridId"].Value, (decimal)IndexPack, "مجوز های تایید شده", "بسته مجوز تایید شد " + "..................................   " + WhoAreMyPersons_Label()))
                    {
                        mailMessage = "\r\n\r\n" + "اما ارسال پیام در اتوماسیون ناموفق بود";
                    }

                   // CursorWait();
                    CursorDefault();
                    MessageBox.Show("بسته تایید شد" + mailMessage);
					CloseOk();
				}
				else
				{
                   // CursorWait();
                    CursorDefault();
					MessageBox.Show(result.Message);
				}
				//	this.Close();
			}
			catch (Exception ex)
			{
               // CursorWait();
                CursorDefault();
				MessageBox.Show(ex.Message);
			}
          //   CursorWait();
              //  CursorDefault();
		}

		private void cbbRequest_Click(object sender, EventArgs e)
		{
            //if (!QuestionSureTo("آیا قصد ارسال درخواست مجوز را دارید؟"))
            //{
            //    return;
            //}

            //bool ok = false;
            //foreach (GridViewRowInfo item in MainRadGridView.Rows)
            //{
            //    if((bool)item.Cells["GatePass_State"].Value)
            //    {
            //        ok = true;
            //        break;
            //    }
            //}
            //if (!ok)
            //{
            //    ItemsPublic.ShowMessage(""); 
            //}

            
            if (MainRadGridView.Rows.Count<1)
            {
                ItemsPublic.ShowMessage("هیچ شخصی انتخاب نشده است");
            }


            CursorWait();
            frm_SelectConfirmerGp2 objC = new frm_SelectConfirmerGp2();
            objC.ShowDialog();
            if (objC.DialogResult == DialogResult.OK)
            {
                CursorWait();
                BaridIdConfirmer = objC.BaridIdConfirmer;
			    SavePackInDataBase(AllFunctions._StatusPack.Request);              
            }
            CursorDefault();
		}
        private decimal? BaridIdConfirmer = null;
		private void MainRadGridView_SelectionChanged(object sender, EventArgs e)
		{
            if(!copyingMode)
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



            if (MainRadGridView.Rows.Count<1)
            {
                ItemsPublic.ShowMessage("هیچ شخصی انتخاب نشده است");

            }


			SavePackInDataBase(AllFunctions._StatusPack.Create);


		}

		public OutputDatas gotResult()
		{
			return result;
		}

		private decimal? personIdDriver()
		{
            //if (v3UC_PackDetailsGp21.rcbHaveVehicle.Checked)
            //{
            //    foreach (var row in MainRadGridView.Rows)
            //    {
            //        if ((bool?) row.Cells["GatePass_IsDriver"].Value == true)
            //        {
            //            return ((decimal?) row.Cells["Person_ID"].Value);
            //        }
            //    }
            //}
			return null;
		}


        private DataTable WhoAreMyPersons()
        {
         //   var AllHumans = new OutputDatas();
            var YourPersons = new DataTable();
            YourPersons.Columns.Add("Person_ID", typeof(decimal));
            YourPersons.Columns.Add("Vehicle_ID" ,typeof(decimal));
            YourPersons.Columns.Add("GatePass_State", typeof(int));
            foreach (GridViewRowInfo item in MainRadGridView.Rows )
            {
                YourPersons.Rows.Add();
                YourPersons.Rows[YourPersons.Rows.Count - 1]["Person_ID"] =  (decimal)item.Cells["Person_ID"].Value;
                YourPersons.Rows[YourPersons.Rows.Count - 1]["Vehicle_ID"] = item.Cells["Vehicle_ID"].Value == null ? -1 :string.IsNullOrEmpty(item.Cells["Vehicle_ID"].Value.ToString().Trim())?-1: (decimal)item.Cells["Vehicle_ID"].Value;
                if (item.Cells["GatePass_IsExpired"] != null)
                {
                    if (item.Cells["GatePass_IsExpired"].Value != null)
                    {
                        if (!(bool)item.Cells["GatePass_IsExpired"].Value)
                        {
                            YourPersons.Rows[YourPersons.Rows.Count - 1]["GatePass_State"] = item.Cells["GatePass_State"].Value == null ? -1 : string.IsNullOrEmpty(item.Cells["GatePass_State"].Value.ToString().Trim()) ? -1 : (bool)item.Cells["GatePass_State"].Value ? 1 : -1;
                        }
                        else
                        {
                            //  ItemsPublic.Exeptor("گیت پاس منقضی شده قابل انتخاب نیست");
                            YourPersons.Rows[YourPersons.Rows.Count - 1]["GatePass_State"] = -1;
                        }
                    }
                    else
                    {
                        YourPersons.Rows[YourPersons.Rows.Count - 1]["GatePass_State"] = -1;
                    }
                }
                else
                {
                    YourPersons.Rows[YourPersons.Rows.Count - 1]["GatePass_State"] = -1;
                }
            }
          //  AllHumans.ResultTable = YourPersons;

            return YourPersons;
        }


        private DataTable WhoseGatePasses(bool jusOneSelected)
        {
            //   var AllHumans = new OutputDatas();
            var YourPersons = new DataTable();
            YourPersons.Columns.Add("Gatepass_ID", typeof(decimal));
            YourPersons.Columns.Add("GatePass_IntPrint", typeof(int));
            YourPersons.Columns.Add("GatePass_State", typeof(int));
            if (jusOneSelected)
            {
                YourPersons.Rows.Add();
                YourPersons.Rows[YourPersons.Rows.Count - 1]["Gatepass_ID"] = (decimal)MainRadGridView.CurrentRow.Cells["Gatepass_ID"].Value;
                YourPersons.Rows[YourPersons.Rows.Count - 1]["GatePass_IntPrint"] = MainRadGridView.CurrentRow.Cells["GatePass_IntPrint"].Value == null ? -1 : string.IsNullOrEmpty(MainRadGridView.CurrentRow.Cells["GatePass_IntPrint"].Value.ToString().Trim()) ? -1 : (int)MainRadGridView.CurrentRow.Cells["GatePass_IntPrint"].Value;
                YourPersons.Rows[YourPersons.Rows.Count - 1]["GatePass_State"] = 1;// MainRadGridView.CurrentRow.Cells["GatePass_State"].Value == null ? -1 : string.IsNullOrEmpty(MainRadGridView.CurrentRow.Cells["GatePass_State"].Value.ToString().Trim()) ? -1 : (bool)MainRadGridView.CurrentRow.Cells["GatePass_State"].Value ? 1 : -1;
            }
            else
            {
                foreach (GridViewRowInfo item in MainRadGridView.Rows)
                {
                    YourPersons.Rows.Add();
                    YourPersons.Rows[YourPersons.Rows.Count - 1]["Gatepass_ID"] = (decimal)item.Cells["Gatepass_ID"].Value;
                    YourPersons.Rows[YourPersons.Rows.Count - 1]["GatePass_IntPrint"] = item.Cells["GatePass_IntPrint"].Value == null ? -1 : string.IsNullOrEmpty(item.Cells["GatePass_IntPrint"].Value.ToString().Trim()) ? -1 : (int)item.Cells["GatePass_IntPrint"].Value;
                    if (item.Cells["GatePass_IsExpired"] != null)
                    {
                        if (item.Cells["GatePass_IsExpired"].Value != null)
                        {
                            if (!(bool)item.Cells["GatePass_IsExpired"].Value)
                            {
                                YourPersons.Rows[YourPersons.Rows.Count - 1]["GatePass_State"] = item.Cells["GatePass_State"].Value == null ? -1 : string.IsNullOrEmpty(item.Cells["GatePass_State"].Value.ToString().Trim()) ? -1 : (bool)item.Cells["GatePass_State"].Value && (int)item.Cells["CountPrinted"].Value<1 ? 1 : -1;
                            }
                            else
                            {
                                //  ItemsPublic.Exeptor("گیت پاس منقضی شده قابل انتخاب نیست");
                                YourPersons.Rows[YourPersons.Rows.Count - 1]["GatePass_State"] = -1;
                            }
                        }
                        else
                        {
                            YourPersons.Rows[YourPersons.Rows.Count - 1]["GatePass_State"] = -1;
                        }
                    }
                    else
                    {
                        YourPersons.Rows[YourPersons.Rows.Count - 1]["GatePass_State"] = -1;
                    }
                }
            }
            //  AllHumans.ResultTable = YourPersons;

            return YourPersons;
        }



        private string WhoAreMyPersons_Label()
        {
            try
            {
                string YourPersons = "";
                int state = -100;
                foreach (GridViewRowInfo item in MainRadGridView.Rows)
                {
                    //   YourPersons.Rows[YourPersons.Rows.Count - 1]["Person_ID"] =  (decimal)item.Cells["Person_ID"].Value;
                   //   YourPersons.Rows[YourPersons.Rows.Count - 1]["Vehicle_ID"] = item.Cells["Vehicle_ID"].Value == null ? -1 :string.IsNullOrEmpty(item.Cells["Vehicle_ID"].Value.ToString().Trim())?-1: (decimal)item.Cells["Vehicle_ID"].Value;
                    state = item.Cells["GatePass_State"].Value == null ? -1 : string.IsNullOrEmpty(item.Cells["GatePass_State"].Value.ToString().Trim()) ? -1 : (bool)item.Cells["GatePass_State"].Value ? 1 : -1;
                    if (state == 1)
                    {
                        YourPersons += item.Cells["Person_Name"].Value.ToString().Trim() + "  " + item.Cells["Person_Surname"].Value.ToString().Trim() + " " + item.Cells["Person_NationalCode"].Value.ToString().Trim() + ";";
                    }
                }
                return YourPersons;
            }catch(Exception ex)
            {
                ItemsPublic.ShowMessage("خطا در بارگذاری اسم ها جهت پیام اتوماسیون به شرح زیر" + "\r\n\r\n" + ex.Message);
                return "خطا در بارگذاری اسم ها جهت پیام اتوماسیون به شرح زیر" + "\r\n\r\n" + ex.Message;
            }
        }
		private void SavePackInDataBase(AllFunctions._StatusPack pos)
		{
            string errStateOk = "";
			try
			{
                //IEnumerable<decimal> IePersons = (MainRadGridView.Rows.Where(x => true)).Select(gridViewRowInfo =>
                //                                                                                (decimal)
                //                                                                                gridViewRowInfo.Cells["Person_ID"].
                //                                                                                    Value).ToList();


                 CursorWait();
                //CursorDefault();


                errStateOk = "شروع";
                DataTable IePersons = new DataTable();
                 IePersons = WhoAreMyPersons();
				if (isNew && IndexPack == null)
				{
                    errStateOk = "قبل از درخواست به سرور";
					result = objManager.ClsPacksGps_insertPackGps(
						(v3UC_PackDetailsGp21.bdcStartDate.SelectedDate != null)
							? v3UC_PackDetailsGp21.bdcStartDate.SelectedDate.Value
							: (DateTime?) null,
						(v3UC_PackDetailsGp21.bdcEndDate.SelectedDate != null)
							? v3UC_PackDetailsGp21.bdcEndDate.SelectedDate.Value
							: (DateTime?) null,
						v3UC_PackDetailsGp21.CurrentAgreeId,
						v3UC_PackDetailsGp21.CurrentTravelId,
						v3UC_PackDetailsGp21.tbPackDescriptions.Text.Trim(), v3UC_PackDetailsGp21.TypePackRealId,
						IePersons,
                        pos,
                        v3UC_PackDetailsGp21.rddlShift.Text.Trim()
						, v3UC_PackDetailsGp21.CurrentGates, v3UC_PackDetailsGp21.CurrentPlaces);
                    errStateOk = "نتیجه از سرور دریافت شد";
					if (result.success)
					{
                     //   isNew = false;
                        changeMode = false;
                        changedSettings = true;
                        errStateOk = "موفقیت عملیات";
                        IndexPack = (decimal?)result.ResultTable.Rows[0]["package_Id"];
                        string mailMessage = string.Empty;
                        if (pos == AllFunctions._StatusPack.Request)
                        {
                            errStateOk = "اقدام به ارسال پیام";
                            aorc.gatepass.ui.mail.MailBarid requestMail = new aorc.gatepass.ui.mail.MailBarid();
                            if (!requestMail.SendMail(ItemsPublic.MyBaridId, (decimal?)BaridIdConfirmer, (decimal)IndexPack, "درخواست مجوز عبور",string.Empty))
                            {
                                mailMessage = "\r\n\r\n" + "اما ارسال پیام در اتوماسیون ناموفق بود";
                            }
                            errStateOk = "ارسال پیام انجام شد";
                        }
                        
						string hint = ConvertNumbers.Int64ToBase36 ( long.Parse ( result.ResultTable.Rows [0] ["package_Id"].ToString () ) );
                        // CursorWait();
                        CursorDefault();
                        ItemsPublic.ShowMessage("عملیات با موفقیت انجام شد" + "\r\n" + "شماره پیگیری" + "\r\n\r\n" + hint + mailMessage);
					//	ItemsPublic.ShowMessage ( "عملیات با موفقیت انجام شد" + "\r\n" + "شماره پیگیری" + " : " +"\r\n"+ hint );
						//ItemsPublic.ShowMessage("عملیات با موفقیت انجام شد" + "\r\n" + "شماره پیگیری" + "\r\n" + hint+" <=");
						if (pos != AllFunctions._StatusPack.Create)
							CloseOk();
					}
					else
					{
                        // CursorWait();
                        CursorDefault();
						MessageBox.Show(result.Message);
					}
				}
				else
				{
                    errStateOk = "inStartDate";
                    var inStartDate = (v3UC_PackDetailsGp21.bdcStartDate.SelectedDate != null)
                            ? v3UC_PackDetailsGp21.bdcStartDate.SelectedDate.Value
                            : (DateTime?)null;
                    errStateOk = "inEndDate";
                    var inEndDate = (v3UC_PackDetailsGp21.bdcEndDate.SelectedDate != null)
                            ? v3UC_PackDetailsGp21.bdcEndDate.SelectedDate.Value
                            : (DateTime?)null;
                    errStateOk = "inTypePack";
                    int? inTypePack = v3UC_PackDetailsGp21.TypePackRealId;
                    errStateOk = "در حین ارسال سرویس";
					result = objManager.ClsPacksGps_updatePackGps(
						IndexPack,
						v3UC_PackDetailsGp21.tbPackDescriptions.Text.Trim(),
						v3UC_PackDetailsGp21.CurrentAgreeId,
						v3UC_PackDetailsGp21.CurrentTravelId,
						inStartDate,
						inEndDate,
						inTypePack, IePersons,
						 pos,
						v3UC_PackDetailsGp21.rddlShift.Text.Trim()
						, v3UC_PackDetailsGp21.CurrentGates, v3UC_PackDetailsGp21.CurrentPlaces);
                    errStateOk = "نتیجه دریافت شد";
					if (result.success)
					{
                        changedSettings = true;
                        changeMode = false;
						//MessageBox.Show("عملیات با موفقیت انجام شد");
						string hint = ConvertNumbers.Int64ToBase36 ( long.Parse ( result.ResultTable.Rows [0] ["package_Id"].ToString () ) );
                        string mailMessage = string.Empty;
                        if (pos == AllFunctions._StatusPack.Request)
                        {
                            errStateOk = "اقدام به ارسال پیام";
                            aorc.gatepass.ui.mail.MailBarid requestMail = new aorc.gatepass.ui.mail.MailBarid();
                            if (!requestMail.SendMail(ItemsPublic.MyBaridId, (decimal?)BaridIdConfirmer, decimal.Parse((result.ResultTable.Rows[0]["package_Id"].ToString())), "درخواست مجوز عبور",string.Empty))
                            {
                                mailMessage ="\r\n\r\n"+ "اما ارسال پیام در اتوماسیون ناموفق بود";
                            }
                        }

                    //    changeMode = false;

                        // CursorWait();
                        CursorDefault();
                        ItemsPublic.ShowMessage("عملیات با موفقیت انجام شد" + "\r\n" + "شماره پیگیری" + "\r\n\r\n" + hint + mailMessage);
						//ItemsPublic.ShowMessage ( "عملیات با موفقیت انجام شد" + "\r\n" + "شماره پیگیری" + " : " + hint );
						//ItemsPublic.ShowMessage ( "عملیات با موفقیت انجام شد" + "\r\n" + "به شماره پیگیری زیر" + "\r\n" +"=> "+ hint+" <=" );
						if (pos != AllFunctions._StatusPack.Create)
							CloseOk();
					}
					else
					{
                        // CursorWait();
                        CursorDefault();
						MessageBox.Show(result.Message);
					}
				}
			}
			catch (Exception ex)
			{
                // CursorWait();
                CursorDefault();
				MessageBox.Show("اشکال در عملیات وارده"+"\r\n "+errStateOk +"\r\n\r\n"+ ex.Message);
				//MessageBox.Show ( "اطلاعات وارده کامل نمی باشد" );
			}
		}

		private void v3UC_PackDetailsGp21_eventTickVehicle()
		{
			try
			{
                //cbbDriver.Enabled = v3UC_PackDetailsGp21.rcbHaveVehicle.Checked && MainRadGridView.CurrentRow != null &&
                //                    cbbEdit.Enabled;
				//eventStatusView();
				//	MainRadGridView.Enabled = true;
				//	objManager.ChangeStatus ( aorc.gatepass.ItemsPublic.IndexStatus.viewPack );
                //if (v3UC_PackDetailsGp21.rcbHaveVehicle.Checked)
                //{
                //    if (! (CurrentDriverId == null && personIdDriver() == null))
                //    {
                //        //	ItemsPublic.Exeptor ( "راننده ای برای خودرو انتخاب نشده است" );

                //        if (CurrentDriverId != null)
                //        {
                //            foreach (var row in MainRadGridView.Rows)
                //            {
                //                if ((bool) row.Cells["GatePass_IsDriver"].Value)
                //                {
                //                    //break;

                //                    row.Cells["GatePass_IsDriver"].Value = false;

                //                    break;
                //                }
                //            }
                //            foreach (var row in MainRadGridView.Rows)
                //            {
                //                if ((decimal) row.Cells["Person_ID"].Value == CurrentDriverId)
                //                {
                //                    //	break;
                //                    row.Cells["GatePass_IsDriver"].Value = true;
                //                    break;
                //                }
                //            }
                //            //	MainRadGridView.EndEdit ();
                //            //	MainRadGridView.CloseEditor();
                //            //	MainRadGridView.Refresh();
                //            CurrentDriverId = null;
                //        }
                //    }
                //}
                //else
                //{
                //    CurrentDriverId = null;
                //    foreach (var row in MainRadGridView.Rows)
                //    {
                //        if ((bool) row.Cells["GatePass_IsDriver"].Value)
                //        {
                //            row.Cells["GatePass_IsDriver"].Value = false;
                //            //MainRadGridView.EndEdit ();
                //            //MainRadGridView.CloseEditor ();
                //            //MainRadGridView.Refresh ();
                //            break;
                //        }
                //    }
                //}
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
          //  CursorWait();
         //   CursorDefault();
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

		public void SetSetting(aorc.gatepass.Gp2.Pack.V2UC_NewPackDetailsGp2 obj)
		{
            v3UC_PackDetailsGp21.rtbPlaces.Text = obj.rtbPlaces.Text.Trim();
            v3UC_PackDetailsGp21.CurrentPlaces = obj.CurrentPlaces;

            v3UC_PackDetailsGp21.rtbGates.Text = obj.rtbGates.Text.Trim();
            v3UC_PackDetailsGp21.CurrentGates = obj.CurrentGates;

			v3UC_PackDetailsGp21.rddlTypePack.Text = obj.TypePackRealName;
            v3UC_PackDetailsGp21.TypePackRealId = obj.TypePackId;
            v3UC_PackDetailsGp21.isGpType = obj.isGpType;

			v3UC_PackDetailsGp21.bdcStartDate.DateTime = obj.bdcStartDate.DateTime;
			v3UC_PackDetailsGp21.bdcEndDate.DateTime = obj.bdcEndDate.DateTime;
			v3UC_PackDetailsGp21.rtbNumberAgree.Text = obj.rtbNumberAgree.Text.Trim();
			v3UC_PackDetailsGp21.CurrentAgreeId = obj.CurrentAgreeId;
			v3UC_PackDetailsGp21.rtbCompanyAgree.Text = obj.rtbCompanyAgree.Text.Trim();
			//v3UC_PackDetailsGp21.rtbTitleAgree.Text = obj.rtbTitleAgree.Text.Trim();
			v3UC_PackDetailsGp21.rlblCountCar.Text = obj.rlblCountCar.Text.Trim();
			v3UC_PackDetailsGp21.rddlShift.Text = obj.rddlShift.Text.Trim();

			v3UC_PackDetailsGp21.CurrentTravelId = obj.CurrentTravelId;

			v3UC_PackDetailsGp21.rtbTravelLabel.Text = obj.rtbTravelLabel.Text.Trim();

			v3UC_PackDetailsGp21.tbPackDescriptions.Text = obj.tbPackDescriptions.Text.Trim();

			//v3UC_PackDetailsGp21.uC_vehicleDetails21.rddlType.SelectedIndex =
            //v3UC_PackDetailsGp21.rcbHaveVehicle.Checked = obj.rcbHaveVehicle.Checked;
            //if (v3UC_PackDetailsGp21.rcbHaveVehicle.Checked)
            //{

            //    v3UC_PackDetailsGp21.CurrentCarId = obj.CurrentCarId;
            //    v3UC_PackDetailsGp21.uC_vehicleDetails31.rtbModel.Text =

            //        obj.uC_vehicleDetails31.rtbModel.Text.Trim();
            //    v3UC_PackDetailsGp21.uC_vehicleDetails31.rtbColor.Text =
            //        obj.uC_vehicleDetails31.rtbColor.Text.Trim();

            //    v3UC_PackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex =
            //        obj.uC_vehicleDetails31.uC_PlatesCar1.rddlTypePlate.SelectedIndex;

            //    v3UC_PackDetailsGp21.uC_vehicleDetails31.uC_PlatesCar1.CarNumber =
            //        obj.uC_vehicleDetails31.uC_PlatesCar1.CarNumber;

            //    v3UC_PackDetailsGp21.uC_vehicleDetails31.rddlState.SelectedIndex =
            //        obj.uC_vehicleDetails31.rddlState.SelectedIndex;

            //    v3UC_PackDetailsGp21.uC_vehicleDetails31.indexTypeModel = obj.uC_vehicleDetails31.indexTypeModel;
            //}
		}

        private void MainRadGridView_RowFormatting(object sender, RowFormattingEventArgs e)
        {

            //if ( int.Parse ( e.RowElement.RowInfo.Cells ["CountPrinted"].Value.ToString () ) == 0 )

            try
            {
                if (!copyingMode)
                if (e != null)
                    if (e.RowElement != null)
                        if (!(e.RowElement is GridTableHeaderRowElement))
                        {
                            AllFunctions._StatusPack spValue = AllFunctions._StatusPack.Expired;
                            if (rgvPack != null)
                                if (rgvPack.CurrentRow != null)
                                    if (rgvPack.CurrentRow.Cells["StatusPack_Id"].Value != null)
                                    {
                                        spValue = (AllFunctions._StatusPack)rgvPack.CurrentRow.Cells["StatusPack_Id"].Value;
                                    }
                            if (e.RowElement.RowInfo.Cells["GatePass_IsExpired"] != null)
                                if (e.RowElement.RowInfo.Cells["GatePass_IsExpired"].Value != null)
                                    if ((bool)e.RowElement.RowInfo.Cells["GatePass_IsExpired"].Value == true)
                            {
                                e.RowElement.DrawFill = true;
                                e.RowElement.BackColor = Color.Gray;
                            }
                            else if (spValue == AllFunctions._StatusPack.Expired
                                || spValue == AllFunctions._StatusPack.Create
                                || spValue == AllFunctions._StatusPack.Request
                                || spValue == AllFunctions._StatusPack.NoConfirm
                                || spValue == AllFunctions._StatusPack.NoPassage)
                            {
                                 if (e.RowElement.RowInfo.Cells["Vehicle_number"] != null)
                                {
                                    if (e.RowElement.RowInfo.Cells["Vehicle_number"].Value != null)
                                    {
                                        if (!string.IsNullOrEmpty(e.RowElement.RowInfo.Cells["Vehicle_number"].Value.ToString()))
                                        {
                                            e.RowElement.DrawFill = true;
                                            e.RowElement.BackColor = Color.LightPink;
                                        }
                                        else
                                        {
                                            e.RowElement.DrawFill = true;
                                            e.RowElement.BackColor = Color.White;
                                        }
                                    }
                                    else
                                    {
                                        e.RowElement.DrawFill = true;
                                        e.RowElement.BackColor = Color.White;
                                    }
                                }
                                else
                                {
                                    e.RowElement.DrawFill = true;
                                    e.RowElement.BackColor = Color.White;
                                }
                            }
                            else
                            {
                                if (e.RowElement.RowInfo.Cells["CountPrinted"] != null)
                                    if (e.RowElement.RowInfo.Cells["CountPrinted"].Value != null)
                                    {
                                        if (int.Parse(e.RowElement.RowInfo.Cells["CountPrinted"].Value.ToString()) > 0)
                                        {
                                            e.RowElement.DrawFill = true;
                                            e.RowElement.BackColor = Color.LightBlue;
                                        }
                                        else if (e.RowElement.RowInfo.Cells["Person_SecureFormDate"].Value == null || string.IsNullOrEmpty(e.RowElement.RowInfo.Cells["Person_SecureFormDate"].Value.ToString()))
                                        {
                                            e.RowElement.DrawFill = true;
                                            e.RowElement.BackColor = Color.PaleGoldenrod;
                                        }
                                        else if (e.RowElement.RowInfo.Cells["quantifier"].Value != null)
                                        {
                                            if (int.Parse(e.RowElement.RowInfo.Cells["quantifier"].Value.ToString()) == 3)
                                            {
                                                e.RowElement.DrawFill = true;
                                                e.RowElement.BackColor = Color.LightGreen;
                                            }
                                            else
                                            {
                                                e.RowElement.DrawFill = true;
                                                e.RowElement.BackColor = Color.White;
                                            }
                                        }
                                        else
                                        {
                                            e.RowElement.DrawFill = true;
                                            e.RowElement.BackColor = Color.White;
                                        }
                                    }
                            }
                        }

            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
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

                if (!QuestionSureTo("چاپ گروهی ممکن است زمان بر باشد آیا مطمئن هستید؟"))
                {
                    return;
                }
                CursorWait();
                if (MainRadGridView.SelectedRows.Count() == 1)
                {
                  //  decimal IDG = (decimal)MainRadGridView.CurrentRow.Cells["Gatepass_ID"].Value;

                    if (v3UC_PackDetailsGp21.isGpType == true)
                    {
                        var ResultPrint = objManager.ClsPacksGps_RequestPrintGP(WhoseGatePasses(false));
                        if (ResultPrint.success)
                        {
                            CursorDefault();
                            ReportViewerGP.ShowReport(ResultPrint.ResultTable);
                        }
                        else
                        {
                            // CursorWait();
                            CursorDefault();
                            ItemsPublic.ShowMessage(ResultPrint.Message);
                        }
                    }
                    else if (v3UC_PackDetailsGp21.isGpType == false)
                    {
                        var ResultPrint = objManager.ClsPacksGps_RegisterCards(WhoseGatePasses(false));
                        if (ResultPrint.success)
                        {
                            CursorDefault();
                            ItemsPublic.ShowMessage("عملیات ثبت نهایی مجوز بلند مدت با موفقیت انجام شد");
                           // ReportViewerGP.ShowReport(ResultPrint.ResultTable);
                        }
                        else
                        {
                            // CursorWait();
                            CursorDefault();
                            ItemsPublic.ShowMessage(ResultPrint.Message);
                        }
                    }
                    else
                    {
                        ItemsPublic.ShowMessage("عملیات ناموفق: نوع بسته نامشخص می باشد");
                    }
                }
                CursorDefault();
            }
            catch (Exception ex)
            {
                // CursorWait();
                CursorDefault();
                ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
            }
		}

		private void cbbOnePrint_Click(object sender, EventArgs e)
		{
			try
			{
				if (MainRadGridView.SelectedRows.Count() == 1)
				{
					//decimal IDG = (decimal) MainRadGridView.CurrentRow.Cells["Gatepass_ID"].Value;
                    // ClsPacksGps_RegisterCards
                    if (v3UC_PackDetailsGp21.isGpType == true)
                    {
                        var ResultPrint = objManager.ClsPacksGps_RequestPrintGP(WhoseGatePasses(true));
                        if (ResultPrint.success)
                        {
                            //  int county = ResultPrint.ResultTable.Rows.Count;
                          //  MessageBox.Show(ResultPrint.ResultTable.Rows[0].Field<int>("CountPrinted").ToString());
                            //MessageBox.Show(county.ToString());
                            ReportViewerGP.ShowReport(ResultPrint.ResultTable);
                        }
                        else
                        {
                            ItemsPublic.ShowMessage(ResultPrint.Message);
                        }
                        
                    }
                    else if (v3UC_PackDetailsGp21.isGpType == false)
                    {

                        if (!QuestionSureTo("پس از ثبت امکان تغییر وجود نخواهد داشت، آیا مطمئن هستید؟"))
                        {
                            return;
                        }

                        var ResultRegister = objManager.ClsPacksGps_RegisterCards(WhoseGatePasses(true));
                        if (ResultRegister.success)
                        {
                            ItemsPublic.ShowMessage("عملیات ثبت مجوز بلند مدت با موفقیت انجام شد");
                            //  int county = ResultPrint.ResultTable.Rows.Count;
                            // MessageBox.Show(ResultPrint.ResultTable.Rows[0].Field<int>("CountPrinted").ToString());
                            //MessageBox.Show(county.ToString());
                            //  ReportViewerGP.ShowReport(ResultPrint.ResultTable);
                        }
                        else
                        {
                            ItemsPublic.ShowMessage(ResultRegister.Message);
                        }
                    }
                    else
                    {
                        ItemsPublic.ShowMessage("عملیات ناموفق: نوع بسته نامشخص می باشد");
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

                if (QuestionSureToExpireGp())
				if (MainRadGridView.SelectedRows.Count() == 1)
				{
                     CursorWait();
                   // CursorDefault();
					var IDG = (decimal) MainRadGridView.CurrentRow.Cells["Gatepass_ID"].Value;
					var Resultexpire = objManager.ClsPacksGps_ExpireGp(IDG);
					if (Resultexpire.success)
					{
                        // CursorWait();
                        CursorDefault();
						ItemsPublic.ShowMessage(Resultexpire.success ? "مجوز عبور مورد نظر منقضی شد" : Resultexpire.Message);
						MainRadGridView.SelectedRows[0].Cells["GatePass_IsExpired"].Value = true;
                        MainRadGridView.SelectedRows[0].Cells["GatePass_State"].Value = false;
					}
					else
					{
                        // CursorWait();
                        CursorDefault();
						ItemsPublic.ShowMessage(Resultexpire.Message);
					}
				}
			}
			catch (Exception ex)
			{
                // CursorWait();
                CursorDefault();
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
			}
		}
        
	//	private RadMenuItem rightCbbView = new RadMenuItem();
	//	private RadMenuItem rightCbbNew = new RadMenuItem();
	//	private RadMenuItem rightCbbEdit = new RadMenuItem();
		private RadMenuItem rightCbbDriver = new RadMenuItem();
        private RadMenuItem rightCbbTagId = new RadMenuItem();

        private RadMenuItem rightCbbEmptyCar = new RadMenuItem();
        
     //   private RadMenuItem rightCbbGroupCar = new RadMenuItem();
		private RadMenuItem rightCbbOnePrint = new RadMenuItem();
		private RadMenuItem rightCbbExpire = new RadMenuItem();
	//	private RadMenuItem rightCbbExit = new RadMenuItem();
		private RadMenuItem rightCbbSecure = new RadMenuItem();

      //  private RadMenuItem rightCbbSelOneGp = new RadMenuItem();

        private RadMenuItem rightCbbSelAllGp = new RadMenuItem();
        private RadMenuItem rightCbbUnSelAllGp = new RadMenuItem();

		protected void setAllMouseMenus()
		{
			setAllRightMenusCopy();
            contextMenu.Items.AddRange(rightCbbSelAllGp, rightCbbUnSelAllGp,rightCbbTagId, rightCbbDriver, rightCbbEmptyCar, rightCbbSecure
			                           , rightCbbOnePrint, rightCbbExpire);
			MainRadGridView.ContextMenuOpening += new ContextMenuOpeningEventHandler(MainRadGridView_ContextMenuOpening);
		}

		private void setAllRightMenusCopy()
		{
			// cbbView
            //this.rightCbbView.AccessibleDescription = "مشاهده";
            //this.rightCbbView.AccessibleName = "مشاهده";
            //this.rightCbbView.FlipText = false;
            //this.rightCbbView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
            //                                                 System.Drawing.GraphicsUnit.Point, ((byte) (178)));
            //this.rightCbbView.Image = global::aorc.gatepass.Properties.Resources._52g;
            //this.rightCbbView.Name = "cbbView";

            //this.rightCbbView.Text = "بازآوری";
            //this.rightCbbView.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            //this.rightCbbView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            //this.rightCbbView.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            //this.rightCbbView.Click += new System.EventHandler(this.cbbView_Click);
            //// 
            //// cbbNew
            //// 
            //this.rightCbbNew.AccessibleDescription = "جدید";
            //this.rightCbbNew.AccessibleName = "جدید";
            //this.rightCbbNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
            //                                                System.Drawing.GraphicsUnit.Point, ((byte) (178)));
            //this.rightCbbNew.Image = global::aorc.gatepass.Properties.Resources.personsg;
            //this.rightCbbNew.Name = "cbbNew";

            //this.rightCbbNew.Text = "انتخاب افراد";
            //this.rightCbbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            //this.rightCbbNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            //this.rightCbbNew.Click += new System.EventHandler(this.cbbNew_Click);
            //// 

            //// cbbEdit
            //// 
            //this.rightCbbEdit.AccessibleDescription = "ویرایش";
            //this.rightCbbEdit.AccessibleName = "ویرایش";
            //this.rightCbbEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
            //                                                 System.Drawing.GraphicsUnit.Point, ((byte) (178)));
            //this.rightCbbEdit.Image = global::aorc.gatepass.Properties.Resources.editg;
            //this.rightCbbEdit.Name = "cbbEdit";

            //this.rightCbbEdit.Text = "تنظیمات بسته";
            //this.rightCbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            //this.rightCbbEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            //this.rightCbbEdit.Click += new System.EventHandler(this.cbbEdit_Click);
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


            //rightCbbTagId 
            this.rightCbbTagId.AccessibleDescription = "تخصیص کد تردد";
            this.rightCbbTagId.AccessibleName = "تخصیص کد تردد";
            this.rightCbbTagId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
			                                                   System.Drawing.GraphicsUnit.Point, ((byte) (178)));
            this.rightCbbTagId.Image = global::aorc.gatepass.Properties.Resources.searchg;
            this.rightCbbTagId.Name = "cbbTagId";

            this.rightCbbTagId.Text = "تخصیص کد تردد";
            this.rightCbbTagId.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rightCbbTagId.ToolTipText = "تخصیص کد تردد به مجوز انتخابی";
            this.rightCbbTagId.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rightCbbTagId.Click += new System.EventHandler(this.cbbTagId_Click);

             // rightCbbEmptyCar
            this.rightCbbEmptyCar.AccessibleDescription = "حذف خودرو";

            this.rightCbbEmptyCar.AccessibleName = "حذف خودرو";

            this.rightCbbEmptyCar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
                                                               System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rightCbbEmptyCar.Image = global::aorc.gatepass.Properties.Resources.edit_remove1;
            this.rightCbbEmptyCar.Name = "CbbEmptyCar";

            this.rightCbbEmptyCar.Text = "حذف خودرو";
            this.rightCbbEmptyCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rightCbbEmptyCar.ToolTipText = "حذف مشخصات خودرو از اطلاعات گیت پاس فرد جاری";
            this.rightCbbEmptyCar.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rightCbbEmptyCar.Click += new System.EventHandler(this.cbbEmptyCar);




            // cbbGroupCar
            // 

            //this.rightCbbGroupCar.AccessibleDescription = "آخرین خودروها";
            //this.rightCbbGroupCar.AccessibleName = "آخرین خودروها";
            //this.rightCbbGroupCar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
            //                                                   System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            //this.rightCbbGroupCar.Image = global::aorc.gatepass.Properties.Resources.carg;
            //this.rightCbbGroupCar.Name = "cbbGroupCar";

            //this.rightCbbGroupCar.Text = "تنظیم آخرین خودروها";
            //this.rightCbbGroupCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            //this.rightCbbGroupCar.ToolTipText = "";
            //this.rightCbbGroupCar.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            //this.rightCbbGroupCar.Click += new System.EventHandler(this.cbbGroupCar_Click);


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
            //this.rightCbbExit.AccessibleDescription = "خروج";
            //this.rightCbbExit.AccessibleName = "خروج";
            //this.rightCbbExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
            //                                                 System.Drawing.GraphicsUnit.Point, ((byte) (178)));
            //this.rightCbbExit.Image = global::aorc.gatepass.Properties.Resources.exitg;
            //this.rightCbbExit.Name = "rightCbbExit";
            //this.rightCbbExit.Text = "خروج";
            //this.rightCbbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            //this.rightCbbExit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            //this.rightCbbExit.Click += new System.EventHandler(this.rmiStatusExit_Click);


            //// cbbSelOneGp
            //// 
            //this.rightCbbSelOneGp.AccessibleDescription = "انتخاب مجوز";
            //this.rightCbbSelOneGp.AccessibleName = "انتخاب مجوز";
            //this.rightCbbSelOneGp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
            //                                                   System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            //this.rightCbbSelOneGp.Image = global::aorc.gatepass.Properties.Resources;
            //this.rightCbbSelOneGp.Name = "cbbSelOneGp";

            //this.rightCbbSelOneGp.Text = "انتخاب مجوز";
            //this.rightCbbSelOneGp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            //this.rightCbbSelOneGp.ToolTipText = "انتخاب مجوز جاری جهت انجام عملیات";
            //this.rightCbbSelOneGp.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            //this.rightCbbSelOneGp.Click += new System.EventHandler(this.cbbSelOneGp_Click);
            //// 

            // cbbSellAllGp
            // 
            this.rightCbbSelAllGp.AccessibleDescription = "انتخاب همه";
            this.rightCbbSelAllGp.AccessibleName = "انتخاب همه";
            this.rightCbbSelAllGp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
                                                               System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rightCbbSelAllGp.Image = global::aorc.gatepass.Properties.Resources.personsg;
            this.rightCbbSelAllGp.Name = "cbbSelAllGp";

            this.rightCbbSelAllGp.Text = "انتخاب همه";
            this.rightCbbSelAllGp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rightCbbSelAllGp.ToolTipText = "انتخاب تمامی مجوز ها";
            this.rightCbbSelAllGp.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rightCbbSelAllGp.Click += new System.EventHandler(this.cbbSellAllGp_Click);
            // 
            // cbbUnSellAllGp
            // 
            this.rightCbbUnSelAllGp.AccessibleDescription = "عدم انتخاب همه";
            this.rightCbbUnSelAllGp.AccessibleName = "عدم انتخاب همه";
            this.rightCbbUnSelAllGp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
                                                               System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rightCbbUnSelAllGp.Image = global::aorc.gatepass.Properties.Resources.block2g;
            this.rightCbbUnSelAllGp.Name = "cbbUnSelAllGp";

            this.rightCbbUnSelAllGp.Text = "عدم انتخاب همه";
            this.rightCbbUnSelAllGp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rightCbbUnSelAllGp.ToolTipText = "عدم انتخاب همه مجوز ها";
            this.rightCbbUnSelAllGp.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rightCbbUnSelAllGp.Click += new System.EventHandler(this.cbbUnSellAllGp_Click);
            // 
		}

		private void MainRadGridView_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
		{
			e.ContextMenu = contextMenu;
		}

		private void cbbSecureForm_Click(object sender, EventArgs e)
		{

           // MethodComplex();
           // return;

            try
			{
                int state = 0;
                var frmSecure = new aorc.gatepass.Gp2.Pack.frm_SecureUpdateGp2();
                if (IsAnySelected())
                {
                    state = 2;
                    frmSecure.groupMode();

                    //infoNosel();
                    // return;
                }
                else
                {
                    if (MainRadGridView.SelectedRows.Count() == 1)
                    {
                        state = 1;

                        MainRadGridView.SelectedRows[0].Cells["GatePass_State"].Value = true;

                        frmSecure.showProperties(
                            uC_ViewPersonDetails1.rtbName.Text
                            , uC_ViewPersonDetails1.rtbSurname.Text
                            , uC_ViewPersonDetails1.TcoSex.Text
                            , uC_ViewPersonDetails1.rmebNationalCode.Text
                            , uC_ViewPersonDetails1.bdcEndSecureDate.DateTime
                            , (bool)MainRadGridView.SelectedRows[0].Cells["Person_HaveForm"].Value
                            );

                    }
                }

                if(state >0)
                {
                        frmSecure.ShowDialog();
                        if (frmSecure.DialogResult == DialogResult.OK)
                        {
                          DataTable AllPerson = WhoAreMyPersons();

                         result = objManager.ClsPersons_SecureManualUpdate(AllPerson,frmSecure.haveForm, frmSecure.dtEndSecure);

                         if (result != null)
                         {
                             if (!result.success)
                             {
                                 ItemsPublic.ShowMessage(result.Message);
                             }
                         }
                         else
                         {
                             ItemsPublic.ShowMessage("بدون نتیجه");
                         }

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

        //private void MasterTemplate_CustomGrouping(object sender, GridViewCustomGroupingEventArgs e)
        //{
        //    //bool? value = null;
        //    ////            if (e != null)
        //    ////                if (e.Row != null)
        //    ////if(e.Row.Cells!=null)
        //    ////if(e.Row.Cells.Count>0)
        //    ////if(e.Row.Cells["GatePass_IsExpired"]!=null)
        //    ////{
        //    //value = (bool?) e.Row.Cells["GatePass_IsExpired"].Value;
        //    //switch (value)
        //    //{
        //    //    case true:
        //    //        e.GroupKey = "درخواست های منقضی شده";


        


        //    //        break;
        //    //    default:
        //    //        e.GroupKey = "درخواست های معتبر";
        //    //        break;
        //    //}
        //    ////	}
        //}

        //private void MainRadGridView_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        //{
        //    if (e.Value == null)
        //    {
        //        e.FormatString = e.Group.Key.ToString();
        //    }
        //}

		private void frm_InpackGP_Shown(object sender, EventArgs e)
		{


            cbbUnSellAllGp_Click(null,null);

            if (MainRadGridView.Rows.Count() > 0)
            {
                MainRadGridView_RowsChanged(null, null);
                CursorDefault();
            }
            else
            {

                if (pmStatus == ItemsPublic.IndexStatus.toNew)
                {

                    // ItemsPublic.copyGrid(gridViewSelectedRowsCollection, MainRadGridView);
                    cbbNew_Click(sender, e);
                    cbbEdit_Click(sender, e);
                }
            }
                //if (MainRadGridView.Rows.Count > 0)
                //{
                //    MainRadGridView.Groups[0].HeaderRow.IsExpanded = true;
                //    MainRadGridView.Groups[0].Expand();
                //}



		}
        //private RadGridView rgv_Pack;
        private OutputDatas RMail;
        internal void setItemsPack(decimal IdPack)
        {
            RMail = new OutputDatas();
           // rgv_Pack = new RadGridView();

            RMail = objManager.View_packages(null, null, null, null, null, null, null, null, null, null, null, null, IdPack.ToString().Trim(), null, null, null, 3);

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

        private void MainRadGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (e != null)
                    if (e.Column != null)
                        if (e.Column.Name == "GatePass_State")
                            if (MainRadGridView.SelectedRows.Count == 1)
                            {
                                if (e.Column.Name == "GatePass_State" && (!(bool)MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value))
                                {
                                    bool temp;
                                    if (MainRadGridView.CurrentRow.Cells["GatePass_State"].Value != null
                                        && !string.IsNullOrEmpty(MainRadGridView.CurrentRow.Cells["GatePass_State"].Value.ToString()))
                                    {
                                        temp = (bool)MainRadGridView.CurrentRow.Cells["GatePass_State"].Value;
                                    }
                                    else
                                    {
                                        temp = false;
                                    }
                                    MainRadGridView.CurrentRow.Cells["GatePass_State"].Value = !temp;
                                }
                            }
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
                // ItemsPublic.ShowMessage(ex.Message);
              //  this.Close();
            }
        }

        private void MainRadGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            //if (MainRadGridView.SelectedRows.Count == 1)
            //{
            //    if (e.Column.Name == "GatePass_State" && (!(bool)MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value))
            //    {
            //        bool temp;
            //        if (MainRadGridView.CurrentRow.Cells["GatePass_State"].Value != null
            //            && !string.IsNullOrEmpty( MainRadGridView.CurrentRow.Cells["GatePass_State"].Value.ToString()))
            //        {
            //            temp = (bool)MainRadGridView.CurrentRow.Cells["GatePass_State"].Value;
            //        }
            //        else
            //        {
            //            temp = false;
            //        }
            //        MainRadGridView.CurrentRow.Cells["GatePass_State"].Value = !temp;
            //    }
            //}
        }

        private void toolWindowPropertiesPack_Click(object sender, EventArgs e)
        {

        }

        private void MainRadGridView_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
           // if (!IsnewRowAdded)
           // {
            if (!copyingMode)
                radLabelElementStatus.Text = "تعداد رکورد ها: " + MainRadGridView.Rows.Count().ToString() + "            ";
          //  }
        }

     //   GridViewSelectedRowsCollection gridViewSelectedRowsCollection;

        public void SeletedPersons(GridViewSelectedRowsCollection IngridViewSelectedRowsCollection)
        {
            if (IngridViewSelectedRowsCollection.Count > 0)
            {
                // initialDatas = true;
               //  gridViewSelectedRowsCollection = IngridViewSelectedRowsCollection;
                changeMode = true;
                IsnewRowAdded = true;
                ItemsPublic.copyGrid(IngridViewSelectedRowsCollection,MainRadGridView);
                IsnewRowAdded = false;
            }
        }

        private void MethodSimple()
        {

            try
            {
                CursorWait();
                foreach (GridViewDataRowInfo item in MainRadGridView.Rows)
                {

                    // View_vehiclesListPersons

                     result = objManager.View_vehiclesComplex(null, null, null, null, null
                         , (decimal)item.Cells["Person_ID"].Value, null, null, null, null);

                 //   DataTable AllPerson = WhoAreMyPersons();
                  //  result = objManager.View_vehiclesListPersons(AllPerson);
                    if (result != null)
                    {
                        if (result.success)
                        {
                            // MainRadGridView.DataSource = result.ResultTable;
                            if (result.ResultTable != null)
                                if (result.ResultTable.Rows != null)
                                    if (result.ResultTable.Rows.Count > 0)
                                    {

                                        item.Cells["Vehicle_ID"].Value = (decimal)result.ResultTable.Rows[0]["Vehicle_ID"];

                                        item.Cells["Vehicle_Model"].Value = result.ResultTable.Rows[0]["Vehicle_Model"].ToString();

                                        item.Cells["vehicle_Color"].Value = result.ResultTable.Rows[0]["vehicle_Color"].ToString();

                                        item.Cells["TypePlates_Id"].Value = (int)result.ResultTable.Rows[0]["TypePlates_Id"];

                                        item.Cells["Vehicle_number"].Value = result.ResultTable.Rows[0]["Vehicle_number"].ToString();

                                        item.Cells["Vehicle_IsCompany"].Value = (bool)result.ResultTable.Rows[0]["Vehicle_IsCompany"];

                                        item.Cells["VehicleType_ID"].Value = (int)result.ResultTable.Rows[0]["VehicleType_ID"];
                                    }


                        }
                        else
                        {
                            ItemsPublic.ShowMessage(result.Message);
                        }
                    }
                }
                CursorDefault();
            }
            catch (Exception ex)
            {
                CursorDefault();
                ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }
        }

        private void MethodComplex()
        {

            {
                try
                {

                    //if (!QuestionSureTo("تنظیم آخرین خودرو در تعداد بالا ممکن است زمان بر باشد آیا مطمئن هستید؟"))
                    //{
                    //    return;
                    //}

                    CursorWait();

                    //   foreach (GridViewDataRowInfo item in MainRadGridView.Rows)
                    //    {
                    //     View_vehiclesListPersons
                    //      result = objManager.View_vehiclesComplex(null, null, null, null, null, (decimal)item.Cells["Person_ID"].Value, null, null, null, null);

                    //cbbSellAllGp_Click(null, null);
                    DataTable AllPerson = WhoAreMyPersons();
                    result = objManager.View_vehiclesListPersons(AllPerson);
                    if (result != null)
                    {
                        if (result.success)
                        {
                            changeMode = true;
                            // MainRadGridView.DataSource = result.ResultTable;
                            if (result.ResultTable != null)
                                if (result.ResultTable.Rows != null)
                                    foreach (DataRow myRow in result.ResultTable.Rows)
                                    {

                                        decimal temDc = decimal.Parse(myRow["Person_ID"].ToString().Trim());

                                        var curRow = MainRadGridView.Rows.First(x => decimal.Parse(x.Cells["Person_ID"].Value.ToString().Trim()) == temDc);

                                        // curRow.IsSelected = true;

                                        curRow.Cells["Vehicle_ID"].Value = (decimal)myRow["Vehicle_ID"];

                                        curRow.Cells["Vehicle_Model"].Value = myRow["Vehicle_Model"].ToString();

                                        curRow.Cells["vehicle_Color"].Value = myRow["vehicle_Color"].ToString();

                                        curRow.Cells["TypePlates_Id"].Value = (int)myRow["TypePlates_Id"];

                                        curRow.Cells["Vehicle_number"].Value = myRow["Vehicle_number"].ToString();

                                        curRow.Cells["Vehicle_IsCompany"].Value = (bool)myRow["Vehicle_IsCompany"];

                                        curRow.Cells["VehicleType_ID"].Value = (int)myRow["VehicleType_ID"];
                                    }
                            // CursorWait();
                            CursorDefault();
                        }
                        else
                        {
                            // CursorWait();
                            CursorDefault();
                            ItemsPublic.ShowMessage(result.Message);
                        }
                    }
                    // }
                    CursorDefault();
                }
                catch (Exception ex)
                {
                    CursorDefault();
                    ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
                    //ItemsPublic.ShowMessage(ex.Message);
                    // this.Close();
                }



            }
        }

        private void cbbGroupCar_Click(object sender, EventArgs e)
        {

            if (!IsAnySelected())
            {
                infoNosel();
                return;
            }

            MethodComplex();
            ItemsPublic.ShowMessage("آخرین خودروی اشخاص انتخابی تنظیم شد");

         //   MethodComplex();

        }

        private void frm_InpackGP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changeMode)
                if (!QuestionSureTo("تغییرات ذخیره نشده دارید" + "\r\n\r\n" + "آیا قصد خروج بدون ذخیره آنها را دارید"))
            {
                e.Cancel = true;
            }
        }

        
        //{
        //    try
        //    {
        //        CursorWait();

        //         //   foreach (GridViewDataRowInfo item in MainRadGridView.Rows)
        //        //    {
        //       //     View_vehiclesListPersons
        //      //      result = objManager.View_vehiclesComplex(null, null, null, null, null, (decimal)item.Cells["Person_ID"].Value, null, null, null, null);

        //            cbbSellAllGp_Click(sender,e);
        //            DataTable AllPerson = WhoAreMyPersons();
        //            result = objManager.View_vehiclesListPersons(AllPerson);
        //            if (result != null)
        //            {
        //                if (result.success)
        //                {
        //                    // MainRadGridView.DataSource = result.ResultTable;
        //                    if (result.ResultTable != null)
        //                        if (result.ResultTable.Rows != null)
        //                            foreach (DataRow myRow in result.ResultTable.Rows)
        //                            {

        //                                decimal temDc = decimal.Parse(myRow["Person_ID"].ToString().Trim());

        //                                var curRow = MainRadGridView.Rows.First(x => decimal.Parse(x.Cells["Person_ID"].Value.ToString().Trim()) == temDc);

        //                               // curRow.IsSelected = true;

        //                                curRow.Cells["Vehicle_ID"].Value = (decimal)myRow["Vehicle_ID"];

        //                                curRow.Cells["Vehicle_Model"].Value = myRow["Vehicle_Model"].ToString();

        //                                curRow.Cells["vehicle_Color"].Value = myRow["vehicle_Color"].ToString();

        //                                curRow.Cells["TypePlates_Id"].Value = (int)myRow["TypePlates_Id"];

        //                                curRow.Cells["Vehicle_number"].Value = myRow["Vehicle_number"].ToString();

        //                                curRow.Cells["Vehicle_IsCompany"].Value = (bool)myRow["Vehicle_IsCompany"];

        //                                curRow.Cells["VehicleType_ID"].Value = (int)myRow["VehicleType_ID"];
        //                            }
        //                }
        //                else
        //                {
        //                    ItemsPublic.ShowMessage(result.Message);
        //                }
        //            }
        //       // }
        //        CursorDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        CursorDefault();
        //        ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
        //        //ItemsPublic.ShowMessage(ex.Message);
        //        // this.Close();
        //    }


        //    //try
        //    //{
        //    //    CursorWait();
        //    //    foreach (GridViewDataRowInfo item in MainRadGridView.Rows)
        //    //    {
        //    //        // View_vehiclesListPersons
        //    //        // result = objManager.View_vehiclesComplex(null, null, null, null, null, (decimal)item.Cells["Person_ID"].Value, null, null, null, null);
        //    //        DataTable AllPerson = WhoAreMyPersons();
        //    //        result = objManager.View_vehiclesListPersons(AllPerson);
        //    //        if (result != null)
        //    //        {
        //    //            if (result.success)
        //    //            {
        //    //                // MainRadGridView.DataSource = result.ResultTable;
        //    //                if (result.ResultTable!=null)
        //    //                    if (result.ResultTable.Rows != null)
        //    //                        if (result.ResultTable.Rows.Count>0)
        //    //                {
                                
        //    //                item.Cells["Vehicle_ID"].Value =(decimal)result.ResultTable.Rows[0]["Vehicle_ID"];

        //    //                item.Cells["Vehicle_Model"].Value = result.ResultTable.Rows[0]["Vehicle_Model"].ToString();

        //    //                item.Cells["vehicle_Color"].Value = result.ResultTable.Rows[0]["vehicle_Color"].ToString();

        //    //                item.Cells["TypePlates_Id"].Value =(int)result.ResultTable.Rows[0]["TypePlates_Id"];

        //    //                item.Cells["Vehicle_number"].Value =result.ResultTable.Rows[0]["Vehicle_number"].ToString();

        //    //                item.Cells["Vehicle_IsCompany"].Value =(bool)result.ResultTable.Rows[0]["Vehicle_IsCompany"];

        //    //                item.Cells["VehicleType_ID"].Value = (int)result.ResultTable.Rows[0]["VehicleType_ID"];
        //    //                }


        //    //            }
        //    //            else
        //    //            {
        //    //                ItemsPublic.ShowMessage(result.Message);
        //    //            }
        //    //        }
        //    //    }
        //    //    CursorDefault();
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    CursorDefault();
        //    //    ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
        //    //    //ItemsPublic.ShowMessage(ex.Message);
        //    //    // this.Close();
        //    //}
        //}
    }
}
