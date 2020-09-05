using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Drawing;
using Baridsoft.Components.Windows.UI;
using ServerClasses;
using Baridsoft.EOrg.Directory.BusinessObject;
using Baridsoft.EOrg.Directory.BusinessFacadeInterface;
using Baridsoft.EOrg.Framework.General;

namespace aorc.gatepass
{
	public class Manager
	{
		//private ItemsPublic.IndexStatus _myIndexStatus;
		//public MyStatusIndex;
		public ItemsPublic.IndexStatus TypeStatus
		{
			get { return currentStatus.Index; }
		}

		private struct MyStatus
		{

			public Color MyColor { get; set; }
			public string Text { get; set; }
			public ItemsPublic.IndexStatus Index { get; set; }

		}

		private readonly MyStatus _statusDelete, _statusEdit, _statusNew, _statusSearch, _statusView, _setPack;
		private MyStatus currentStatus;
		private PoliceClient MyPolice;
		private Customer ICustomer;
		private Dictionary<AllFunctions._IdData, object> Input;

		public Office2010BlackTheme InActiveTheme { get; set; }

		public Manager()
		{
			ICustomer = new Customer();
			Input = new Dictionary<AllFunctions._IdData, object>();
			MyPolice = new PoliceClient();

			//MyIndexStatus = IndexStatus.toDelete;
			//  InActiveTheme.ThemeName = "";
			_setPack.Index = ItemsPublic.IndexStatus.setPack;
			_setPack.MyColor = Color.Chocolate;
			_setPack.Text = "تنظیمات بسته";

			_statusDelete.Index = ItemsPublic.IndexStatus.toDelete;
			_statusDelete.MyColor = Color.Red;
			_statusDelete.Text = "عملیات حذف";

			_statusEdit.Index = ItemsPublic.IndexStatus.toEdit;
			_statusEdit.MyColor = Color.Yellow;
			_statusEdit.Text = "وضعیت ویرایش اطلاعات فعال است";

			_statusNew.Index = ItemsPublic.IndexStatus.toNew;
			_statusNew.MyColor = Color.Chartreuse;
			_statusNew.Text = "وضعیت افزودن اطلاعات جدید";

			_statusSearch.Index = ItemsPublic.IndexStatus.toSearch;
			_statusSearch.MyColor = Color.Blue;
			_statusSearch.Text = "وضعیت جستجو فعال می باشد";

			_statusView.Index = ItemsPublic.IndexStatus.toView;
			_statusView.MyColor = Color.White;
			_statusView.Text = "وضعیت مشاهده فعال است";
		}

		private void MyRefresh()
		{
			Input.Clear();
			Input.Add(AllFunctions._IdData.Event_ComputerName, ItemsPublic.MyComputerName);
			Input.Add(AllFunctions._IdData.Event_IpAddress, ItemsPublic.MyIpAddress);
			Input.Add(AllFunctions._IdData.OfficeOperators_Id, ItemsPublic.MyOffOperId);
		}

		private OutputDatas test()
		{
			// refresh
			// add dic
			// dastresi
			// call customer
			// return result

			MyRefresh();
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_offices);

			return ICustomer.Suit(Serialize.BinarySerialize(Input));
		}

		private void SetStatus(MyStatus inStatus)
		{
			RBE.Text = inStatus.Text;
			((Telerik.WinControls.Primitives.FillPrimitive)
			 (RBE.GetChildAt(0))).BackColor = inStatus.MyColor;
			currentStatus = inStatus;
		}

		public RadLabelElement RBE { get; set; }
		public IEnumerable<object> EditActive { get; set; }
		public IEnumerable<object> NewActive { get; set; }
		public IEnumerable<object> SearchActive { get; set; }
		public IEnumerable<object> ViewActive { get; set; }
		public IEnumerable<object> DeleteActive { get; set; }
		public IEnumerable<object> EveryItems { get; set; }

		public void ChangeStatus(ItemsPublic.IndexStatus toStatus)
		{
			InActiveControls(EveryItems);
			switch (toStatus)
			{
				case ItemsPublic.IndexStatus.toDelete:
					SetStatus(_statusDelete);
					AvticeControls(DeleteActive);
					break;
				case ItemsPublic.IndexStatus.toEdit:
					SetStatus(_statusEdit);
					AvticeControls(EditActive);
					break;
				case ItemsPublic.IndexStatus.toNew:
					SetStatus(_statusNew);
					EmptyControls(EveryItems);
					AvticeControls(NewActive);
					break;
				case ItemsPublic.IndexStatus.toSearch:
					SetStatus(_statusSearch);
					EmptyControls(EveryItems);
					AvticeControls(SearchActive);
					break;
				case ItemsPublic.IndexStatus.toView:
					SetStatus(_statusView);
					EmptyControls(EveryItems);
					AvticeControls(ViewActive);
					break;
				case ItemsPublic.IndexStatus.setPack:
					SetStatus(_setPack);
					//AvticeControls(EditActive);
					break;
				case ItemsPublic.IndexStatus.viewPack:
					SetStatus(_statusView);
					AvticeControls(ViewActive);
					break;
			}
		}

		private void AvticeControls(IEnumerable<object> mylist)
		{
            if (mylist == null)
            {
                return;
            }
			foreach (var cntrl in mylist)
			{
				if (cntrl is TextBox)
				{
					((TextBox) cntrl).ReadOnly = false;
					//((TextBox)cntrl).ThemeName = "";
				}
				else if (cntrl is RadTextBox)
				{
					((RadTextBox) cntrl).ReadOnly = false;
					((RadTextBox) cntrl).ThemeName = "";
				}
				else if (cntrl is RadDropDownList)
				{
					if (currentStatus.Index == ItemsPublic.IndexStatus.toNew)
					{
						((RadDropDownList) cntrl).SelectedIndex = -1;
						( ( RadDropDownList ) cntrl ).Text = string.Empty;
					}
					((RadDropDownList) cntrl).Enabled = true;
				}
				else if (cntrl is RadSpinEditor)
				{
					((RadSpinEditor) cntrl).ReadOnly = false;
					((RadSpinEditor) cntrl).InterceptArrowKeys = true;
					((RadSpinEditor) cntrl).ThemeName = "";
				}
				else if (cntrl is RadMaskedEditBox)
				{
					((RadMaskedEditBox) cntrl).ReadOnly = false;
					((RadMaskedEditBox) cntrl).ThemeName = "";
				}
				else if (cntrl is BaridDateControl)
				{
					((BaridDateControl) cntrl).ReadOnly = false;
					//   ((BaridDateControl)cntrl).ThemeName = "";
				}
				else if (cntrl is RadGridView)
				{
					((RadGridView) cntrl).ReadOnly = false;
				}
				else if (cntrl is Control)
				{
					((Control) cntrl).Enabled = true;
					//  ((Control)cntrl).ThemeName = "";
				}
				else if (cntrl is RadItem)
				{
					((RadItem) cntrl).Enabled = true;
					//((RadItem)cntrl).ThemeName = "";
				}
				else
				{
					throw new Exception();
				}
			}
		}

		public void EmptyControls(IEnumerable<object> mylist)
		{
			foreach (var cntrl in mylist)
			{
					//if(cntrl.GetType() == (Control).g
				try
				{
					//if(cntrl.GetType().Equals(System.Type.GetType("Control")))
					if (((Control) cntrl).Tag.ToString().Any(c => c == 'L'))
					{
						continue;
					}
				}
				catch
				{

				}
				if (cntrl is TextBox)
				{
					((TextBox) cntrl).Text = "";
					//((TextBox)cntrl).ThemeName = "";
				}
				else if (cntrl is RadTextBox)
				{
					((RadTextBox) cntrl).Text = "";
				}
				else if (cntrl is PictureBox)
				{
					((PictureBox) cntrl).Image = null;
				}
				else if (cntrl is RadSpinEditor)
				{
					((RadSpinEditor) cntrl).Value = 0;
				}
				else if (cntrl is RadMaskedEditBox)
				{
					((RadMaskedEditBox) cntrl).Text = "";
				}
				else if (cntrl is BaridDateControl)
				{
					((BaridDateControl) cntrl).SelectedDate = null;
					//   ((BaridDateControl)cntrl).ThemeName = "";
				}
				else if (cntrl is RadDropDownList)
				{
					//if (ItemsPublic.MyStatus == IndexStatus.toNew)
					//{
					//    ((RadDropDownList)cntrl).SelectedIndex = 0;
					//}else
					//{
					//    ((RadDropDownList)cntrl).SelectedIndex = -1;
					//}
					((RadDropDownList) cntrl).SelectedIndex = -1;
					( ( RadDropDownList ) cntrl ).Text = string.Empty;
				}
				else if (cntrl is RadGridView)
				{
					((RadGridView) cntrl).DataSource = null;
					// ((RadGridView)cntrl).Rows.Clear();
				}
				else if (cntrl is RadTreeView)
				{
					((RadTreeView) cntrl).SelectedNode = null;
					// ((RadGridView)cntrl).Rows.Clear();
				}
				else if (cntrl is Control)
				{
					// ((Control)cntrl).Enabled = true;
					//  ((Control)cntrl).ThemeName = "";

				}
				else if (cntrl is RadItem)
				{
					// ((RadItem)cntrl).Text="";
					//((RadItem)cntrl).ThemeName = "";
				}

				else
				{
					throw new Exception();
				}

			}
		}

		private void InActiveControls(params IEnumerable<object>[] mylist)
		{
			foreach (var cntrl in mylist.SelectMany(enumerable => enumerable))
			{
				if (cntrl is TextBox)
				{
					((TextBox) cntrl).ReadOnly = true;
					//   ((TextBox)cntrl).ThemeName = InActiveTheme.ThemeName;

				}
				else if (cntrl is RadTextBox)
				{
					((RadTextBox) cntrl).ReadOnly = true;

					((RadTextBox) cntrl).ThemeName = InActiveTheme.ThemeName;
				}
				else if ( cntrl is RadDropDownList )
				{
					( ( RadDropDownList ) cntrl ).Enabled = false;
					// ((RadItem)cntrl).ThemeName = InActiveTheme.ThemeName;
				}
				else if (cntrl is RadSpinEditor)
				{
					((RadSpinEditor) cntrl).ReadOnly = true;
					((RadSpinEditor) cntrl).InterceptArrowKeys = false;
					((RadSpinEditor) cntrl).ThemeName = InActiveTheme.ThemeName;
				}
				else if (cntrl is RadMaskedEditBox)
				{
					((RadMaskedEditBox) cntrl).ReadOnly = true;
					((RadMaskedEditBox) cntrl).ThemeName = InActiveTheme.ThemeName;
				}
				else if (cntrl is BaridDateControl)
				{
					((BaridDateControl) cntrl).ReadOnly = true;
					// ((BaridDateControl)cntrl).ThemeName = InActiveTheme.ThemeName;
				}
				else if (cntrl is RadTreeView)
				{
					//((RadTreeView)cntrl).ReadOnly = true;
				}
				else if (cntrl is RadGridView)
				{
					((RadGridView) cntrl).ReadOnly = true;
				}
				else if (cntrl is Control)
				{
					((Control) cntrl).Enabled = false;
					// ((Control)cntrl).ThemeName = InActiveTheme.ThemeName;

				}
				else if (cntrl is RadItem)
				{
					((RadItem) cntrl).Enabled = false;
					// ((RadItem)cntrl).ThemeName = InActiveTheme.ThemeName;
				}
				else
				{
					throw new Exception();
				}
			}
		}

		#region Call Functions

		#region BARID Functions


		private OutputDatas BaridInfo_ViewAllUsers2()
		{
			OutputDatas BaridResult = new OutputDatas();

			// create a data table with bottom's Information
			// resultTable.Cols => "BaridName"     = string  
			//                     "BaridJob"      = string
			//                     "BaridUserCode" = decimal
			//                     "Operator_BaridId"       = decimal

			BaridResult.ResultTable.Columns.Add("BaridName");
			BaridResult.ResultTable.Columns.Add("BaridJob");
			BaridResult.ResultTable.Columns.Add("BaridUserCode");
			BaridResult.ResultTable.Columns.Add("Operator_BaridId");
			try
			{
				// call barid functions and add All UserInfo to the BaridResult.ResultTable

				/*********************************/
				Baridsoft.EOrg.Directory.BusinessFacadeInterface.IUserFacade iuF =
					Baridsoft.EOrg.Directory.BusinessFacadeInterface.DirectoryProxyFactory.NewUserFacade();
				Baridsoft.EOrg.Directory.BusinessObject.UserList ul =
					iuF.GetAllUsers(Baridsoft.EOrg.Framework.General.UserContext.TicketID);
				foreach (User item in ul)
				{
					BaridResult.ResultTable.Rows.Add(item.Name, "", item.UserName, item.ID);
				}

				BaridResult.success = true;
			}
			catch (Exception ex)
			{
				BaridResult.success = false;
				BaridResult.Message = ex.Message;
			}
			return BaridResult;
		}


		private string GetBaridUserParticipant(decimal BaridID)
		{
			IParticipantFacade part = DirectoryProxyFactory.NewParticipantFacade();
			return part.GetDefaultParticipant(UserContext.TicketID, BaridID).DisplayString;
		}

		private OutputDatas GetBaridUserInfo(decimal BaridID)
		{
			OutputDatas BaridResult = new OutputDatas();
			try
			{
				IUserFacade iper = DirectoryProxyFactory.NewUserFacade();
				User per = iper.GetUser(UserContext.TicketID, BaridID);
				IParticipantFacade ipar = DirectoryProxyFactory.NewParticipantFacade();
				Participant par = ipar.GetDefaultParticipant(UserContext.TicketID, BaridID);

				BaridResult.ResultTable.Columns.Add("BaridName");
				BaridResult.ResultTable.Columns.Add("BaridJob");
				BaridResult.ResultTable.Columns.Add("BaridUserCode");
				BaridResult.ResultTable.Columns.Add("Operator_BaridId");
				BaridResult.ResultTable.Rows.Add(per.Name, par.DisplayString, per.UserName, per.ID);
				BaridResult.success = true;
			}
			catch (Exception ex)
			{

				BaridResult.success = false;
				BaridResult.Message = ex.Message;
			}
			return BaridResult;

		}


		#endregion

		public OutputDatas ClsGlobalSetting_View()
		{
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsGlobalSetting_View);
			//&
			MyPolice.ClsGlobalSetting_View(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
		}

        public OutputDatas ClsGlobalSetting_AllowPrintSign()
        {
            MyRefresh();
            //#
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsGlobalSetting_AllowPrintSign);
            //&
           // MyPolice.ClsGlobalSetting_View(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
        }

		public OutputDatas ClsGlobalSetting_update(IEnumerable<int> Package_CollectionGps)
		{
			if (Package_CollectionGps.Count() != 13)
			{
				ItemsPublic.Exeptor("عدم ارسال تنظیمات جدید سامانه");
			}
			MyRefresh(); 
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsGlobalSetting_update);
			//&
			Input.Add(AllFunctions._IdData.Package_CollectionGps, Package_CollectionGps);
			MyPolice.ClsGlobalSetting_update(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
		}

		public OutputDatas ClsAgreements_insert
			(decimal Agreement_Number, bool? Agreement_IsActive, string Agreement_Title
			 , string Agreement_Company, DateTime? Agreement_StartDate
			 , DateTime? Agreement_EndDate, string Agreement_AgentName
			 , string Agreement_AgentPhone, string Agreement_Description
			 , string Agreement_ManagerName, string Agreement_ManagerTell
			 , string Agreement_Adress, bool? Agreement_IsIndustrial, int? Agreement_CountCars)
		{
			//@  
			//#
			if (Agreement_CountCars == null)
			{
				Agreement_CountCars = 0;
			}
			if (Agreement_Number == null || Agreement_Number <= 0)
			{
				ItemsPublic.Exeptor(ItemsPublic._errAgreementNumber);
			}
			if (Agreement_Title == "")
			{
				ItemsPublic.Exeptor(ItemsPublic._errTitleCantEmpty);
			}
			if (Agreement_Company == "")
			{
				ItemsPublic.Exeptor(ItemsPublic._errCompanyCantEmpty);
			}
			if (Agreement_EndDate == null || Agreement_StartDate == null)
			{
				ItemsPublic.Exeptor(ItemsPublic._errDateCantEmpty);
			}
			if (Agreement_IsIndustrial == null)
			{
				ItemsPublic.Exeptor(ItemsPublic._errIndustrial);
			}            
			MyRefresh();
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsAgreements_insert);
			Input.Add(AllFunctions._IdData.Agreement_Number, Agreement_Number);
			if (Agreement_IsActive != null)
			{
				Input.Add(AllFunctions._IdData.Agreement_IsActive, Agreement_IsActive);
			}
			Input.Add(AllFunctions._IdData.Agreement_Title, Agreement_Title);
			Input.Add(AllFunctions._IdData.Agreement_Company, Agreement_Company);
			Input.Add(AllFunctions._IdData.Agreement_StartDate, Agreement_StartDate);
			Input.Add(AllFunctions._IdData.Agreement_EndDate, Agreement_EndDate);
			Input.Add(AllFunctions._IdData.Agreement_AgentName, Agreement_AgentName);
			Input.Add(AllFunctions._IdData.Agreement_AgentPhone, Agreement_AgentPhone);
			Input.Add(AllFunctions._IdData.Agreement_Description, Agreement_Description);

			if (!string.IsNullOrEmpty(Agreement_ManagerName))
				Input.Add(AllFunctions._IdData.Agreement_ManagerName, Agreement_ManagerName);
			if (!string.IsNullOrEmpty(Agreement_ManagerTell))
				Input.Add(AllFunctions._IdData.Agreement_ManagerTell, Agreement_ManagerTell);
			if (!string.IsNullOrEmpty(Agreement_Adress))
				Input.Add(AllFunctions._IdData.Agreement_Adress, Agreement_Adress);

			Input.Add(AllFunctions._IdData.Agreement_IsIndustrial, Agreement_IsIndustrial);

			Input.Add(AllFunctions._IdData.Agreement_CountCars, Agreement_CountCars);

			//&
			MyPolice.ClsAgreements_insert(ref Input);
			OutputDatas os = ICustomer.Suit(Serialize.BinarySerialize(Input));
			//  SetAgreeIndustrialText(ref os);
			return os;
			//%
			//$
		}


		private void SetAgreeIndustrialText(ref OutputDatas os)
		{
			MessageBox.Show(os.ResultTable.Rows.Count.ToString());
			foreach (DataRow item in os.ResultTable.Rows)
			{
				//(bool)item["Agreement_IsIndustrial"] ? "صنعتی" : "غیر صنعتی";
				item["Agreement_Adress"] = "aaaaaaaaa";
			}
		}

		public OutputDatas ClsAgreements_update
			(decimal Agreement_ID,decimal? Agreement_Number, string Agreement_AgentName
			 , string Agreement_AgentPhone, string Agreement_Company
			 , string Agreement_Description, DateTime? Agreement_EndDate
			 , bool Agreement_IsActive, DateTime? Agreement_StartDate
			 , string Agreement_Title, string Agreement_ManagerName, string Agreement_ManagerTell
			 , string Agreement_Adress, bool? Agreement_IsIndustrial, int? Agreement_CountCars)
		{
			//@

           
			if (Agreement_Title == "")
			{
				ItemsPublic.Exeptor(ItemsPublic._errTitleCantEmpty);
			}
			if (Agreement_Company == "")
			{
				ItemsPublic.Exeptor(ItemsPublic._errCompanyCantEmpty);
			}
			if (Agreement_EndDate == null || Agreement_StartDate == null)
			{
				ItemsPublic.Exeptor(ItemsPublic._errDateCantEmpty);
			}
			if (Agreement_IsIndustrial == null)
			{
				ItemsPublic.Exeptor(ItemsPublic._errIndustrial);
			}
			if (Agreement_CountCars == null)
			{
				ItemsPublic.Exeptor("تعداد خودروی قرارد وارد نشده است");
			}

			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsAgreements_update);

			Input.Add(AllFunctions._IdData.Agreement_ID, Agreement_ID);

            if (Agreement_Number !=null)
            Input.Add(AllFunctions._IdData.Agreement_Number, Agreement_Number);

			Input.Add(AllFunctions._IdData.Agreement_AgentName, Agreement_AgentName);
			Input.Add(AllFunctions._IdData.Agreement_AgentPhone, Agreement_AgentPhone);
			Input.Add(AllFunctions._IdData.Agreement_Company, Agreement_Company);
			Input.Add(AllFunctions._IdData.Agreement_Description, Agreement_Description);
			Input.Add(AllFunctions._IdData.Agreement_EndDate, Agreement_EndDate);
			Input.Add(AllFunctions._IdData.Agreement_IsActive, Agreement_IsActive);
			Input.Add(AllFunctions._IdData.Agreement_StartDate, Agreement_StartDate);
			Input.Add(AllFunctions._IdData.Agreement_Title, Agreement_Title);
			Input.Add(AllFunctions._IdData.Agreement_ManagerName, Agreement_ManagerName);
			Input.Add(AllFunctions._IdData.Agreement_ManagerTell, Agreement_ManagerTell);
			Input.Add(AllFunctions._IdData.Agreement_Adress, Agreement_Adress);
			Input.Add(AllFunctions._IdData.Agreement_IsIndustrial, Agreement_IsIndustrial);
			Input.Add(AllFunctions._IdData.Agreement_CountCars, Agreement_CountCars);
			//&
			MyPolice.ClsAgreements_update(ref Input);
			OutputDatas os = ICustomer.Suit(Serialize.BinarySerialize(Input));
			//   SetAgreeIndustrialText(ref os);
			return os;
			//%

			//$
		}

		public OutputDatas ClsAgreements_delete(decimal Agreement_ID)
		{
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsAgreements_delete);
			Input.Add(AllFunctions._IdData.Agreement_ID, Agreement_ID);
			//&
			MyPolice.ClsAgreements_delete(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsBlack_BL_insert(
			decimal? BlackList_PersonID,
			DateTime? BlackList_DateTime, int? BlackList_BLReasonID,
			string BlackList_Desc, bool? BlackList_isBlack)
		{
			//if (BlackList_OperId==null)
			//{
			//    ItemsPublic.Exeptor(ItemsPublic._errNullOfficeOperators_Id);
			//}
			if (BlackList_PersonID == null)
			{
				ItemsPublic.Exeptor(ItemsPublic._errNotFindPerson);
			}
			//if (BlackList_DateTime == null)
			//{
			//    ItemsPublic.Exeptor(ItemsPublic._errTimeIsNull);
			//}
			if (BlackList_BLReasonID == null)
			{
				ItemsPublic.Exeptor(ItemsPublic._errBlReasonTypeIsEmpty);
			}
			if (BlackList_isBlack == null)
			{
				ItemsPublic.Exeptor(ItemsPublic._errStateIsNull);
			}

			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsBlack_BL_insert);
			if (!string.IsNullOrEmpty(BlackList_Desc))
				Input.Add(AllFunctions._IdData.BlackList_Desc, BlackList_Desc);

			Input.Add(AllFunctions._IdData.Person_ID, BlackList_PersonID);
			Input.Add(AllFunctions._IdData.BlackList_DateTime, BlackList_DateTime);
			Input.Add(AllFunctions._IdData.BLReason_ID, BlackList_BLReasonID);
			Input.Add(AllFunctions._IdData.BlackList_isBlack, BlackList_isBlack);

			//&
			MyPolice.ClsBlack_BL_insert(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsBlack_BLR_insert(string BLReason_Type, string BLReason_Desc)
		{
			if (string.IsNullOrEmpty(BLReason_Type))
				ItemsPublic.Exeptor(ItemsPublic._errBlReasonTypeIsEmpty);
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsBlack_BLR_insert);
			Input.Add(AllFunctions._IdData.BLReason_Type, BLReason_Type);
			if (!string.IsNullOrEmpty(BLReason_Desc))
				Input.Add(AllFunctions._IdData.BLReason_Desc, BLReason_Desc);
			//&
			MyPolice.ClsBlack_BLR_insert(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsBlack_BLR_update(int? BLReason_ID,
		                                       string BLReason_Type, string BLReason_Desc)
		{
			if (BLReason_ID == null)
				ItemsPublic.Exeptor(ItemsPublic._errBlReasonNotFind);

			if (string.IsNullOrEmpty(BLReason_Type))
				ItemsPublic.Exeptor(ItemsPublic._errBlReasonTypeIsEmpty);
			//@
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsBlack_BLR_update);

			Input.Add(AllFunctions._IdData.BLReason_Type, BLReason_Type);
			//if (!string.IsNullOrEmpty(BLReason_Desc))
				Input.Add(AllFunctions._IdData.BLReason_Desc, BLReason_Desc);
			Input.Add(AllFunctions._IdData.BLReason_ID, BLReason_ID);
			//&
			MyPolice.ClsBlack_BLR_update(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsBlack_BLR_delete(int? BLReason_ID)
		{
			if (BLReason_ID == null)
				ItemsPublic.Exeptor(ItemsPublic._errBlReasonNotFind);
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsBlack_BLR_delete);
			Input.Add(AllFunctions._IdData.BLReason_ID, BLReason_ID);

			//&
			MyPolice.ClsBlack_BLR_delete(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsGroups_insert(bool? Group_IsActive, string Group_Name,
		                                    string Group_Description, List<int> Group_ListRights)
		{
			if (string.IsNullOrEmpty(Group_Name))
			{
				ItemsPublic.Exeptor();
			}
			if (Group_IsActive == null)
			{
				ItemsPublic.Exeptor();
			}
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsGroups_insert);
			//&
			Input.Add(AllFunctions._IdData.Group_Name, Group_Name);
			Input.Add(AllFunctions._IdData.Group_IsActive, Group_IsActive);
			if (!string.IsNullOrEmpty(Group_Description))
			{
				Input.Add(AllFunctions._IdData.Group_Description, Group_Description);
			}
			if (Group_ListRights.Count > 0)
			{
				Input.Add(AllFunctions._IdData.Group_ListRights, Group_ListRights);
			}
			MyPolice.ClsGroups_insert(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%S
			//$
		}

		public OutputDatas ClsGroups_update(int? Group_ID, bool? Group_IsActive, string Group_Name,
		                                    string Group_Description, List<int> Group_ListRights)
		{
			if (Group_ID == null)
			{
				ItemsPublic.Exeptor();
			}
			if (string.IsNullOrEmpty(Group_Name))
			{
				ItemsPublic.Exeptor();
			}
			if (Group_IsActive == null)
			{
				ItemsPublic.Exeptor();
			}
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsGroups_update);
			Input.Add(AllFunctions._IdData.Group_ID, Group_ID);
			Input.Add(AllFunctions._IdData.Group_Name, Group_Name);
			Input.Add(AllFunctions._IdData.Group_IsActive, Group_IsActive);
			if (!string.IsNullOrEmpty(Group_Description))
			{
				Input.Add(AllFunctions._IdData.Group_Description, Group_Description);
			}
			if (Group_ListRights.Count > 0)
			{
				Input.Add(AllFunctions._IdData.Group_ListRights, Group_ListRights);
			}

			//&
			MyPolice.ClsGroups_update(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsGroups_delete(int? Group_ID)
		{
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsGroups_delete);
			if (Group_ID == null)
			{
				ItemsPublic.Exeptor();
			}
			//&
			Input.Add(AllFunctions._IdData.Group_ID, Group_ID);
			MyPolice.ClsGroups_delete(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsOffice_update
			(
			int Office_ID,
			bool Office_Active,
			int? Office_ParentId,
			string Office_Name,
			int? Office_MonthlyGPAllowed,
			int? Office_DailyGPAllowed,
			string Office_Description,
			string Office_Phone1,
			string Office_Phone2
			)
		{
			if (string.IsNullOrEmpty(Office_Name))
				ItemsPublic.Exeptor(ItemsPublic._errOfficeNameCantEmpty);

			//if (Office_ID == null)
			//    ItemsPublic.Exeptor(ItemsPublic._errOffice_NameCantEmpty);
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOffice_update);
			Input.Add(AllFunctions._IdData.Office_ID, Office_ID);
			Input.Add(AllFunctions._IdData.Office_Name, Office_Name);
			if (Office_Active != null)
				Input.Add(AllFunctions._IdData.Office_Active, (bool) Office_Active);
			//if (Office_ParentId != null)
				Input.Add(AllFunctions._IdData.Office_ParentId, Office_ParentId);
			if (Office_MonthlyGPAllowed != null)
				Input.Add(AllFunctions._IdData.Office_MonthlyGPAllowed, Office_MonthlyGPAllowed);
			if (Office_DailyGPAllowed != null)
				Input.Add(AllFunctions._IdData.Office_DailyGPAllowed, Office_DailyGPAllowed);
			if (!string.IsNullOrEmpty(Office_Description))
				Input.Add(AllFunctions._IdData.Office_Description, Office_Description);
			if (!string.IsNullOrEmpty(Office_Phone1))
				Input.Add(AllFunctions._IdData.Office_Phone1, Office_Phone1);
			if (!string.IsNullOrEmpty(Office_Phone2))
				Input.Add(AllFunctions._IdData.Office_Phone2, Office_Phone2);
			//&
			MyPolice.ClsOffice_update(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsOffice_delete(int Office_ID)
		{
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOffice_delete);
			Input.Add(AllFunctions._IdData.Office_ID, Office_ID);

			//&
			MyPolice.ClsOffice_delete(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsOffice_insert
			(
			bool? Office_Active,
			int? Office_ParentId,
			string Office_Name,
			int? Office_MonthlyGPAllowed,
			int? Office_DailyGPAllowed,
			string Office_Description,
			string Office_Phone1,
			string Office_Phone2
			)
		{
			//  Office_ID
			//  Office_Name
			//  Office_Active
			//  Office_MonthlyGPAllowed
			//  Office_MonthlyRemindGp
			//  Office_DailyGPAllowed
			//  Office_DailyRemindGp
			//  Office_Description
			//  Office_ParentId
			//  Office_Phone1
			//  Office_Phone2
			//@ 
			if (string.IsNullOrEmpty(Office_Name))
				ItemsPublic.Exeptor(ItemsPublic._errOfficeNameCantEmpty);

			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOffice_insert);

			Input.Add(AllFunctions._IdData.Office_Name, Office_Name);
			if (Office_Active != null)
				Input.Add(AllFunctions._IdData.Office_Active, Office_Active);
			if (Office_ParentId != null)
				Input.Add(AllFunctions._IdData.Office_ParentId, Office_ParentId);
			if (Office_MonthlyGPAllowed != null)
				Input.Add(AllFunctions._IdData.Office_MonthlyGPAllowed, Office_MonthlyGPAllowed);
			if (Office_DailyGPAllowed != null)
				Input.Add(AllFunctions._IdData.Office_DailyGPAllowed, Office_DailyGPAllowed);
			if (!string.IsNullOrEmpty(Office_Description))
				Input.Add(AllFunctions._IdData.Office_Description, Office_Description);
			if (!string.IsNullOrEmpty(Office_Phone1))
				Input.Add(AllFunctions._IdData.Office_Phone1, Office_Phone1);
			if (!string.IsNullOrEmpty(Office_Phone2))
				Input.Add(AllFunctions._IdData.Office_Phone2, Office_Phone2);
			//&
			MyPolice.ClsOffice_insert(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}


		public OutputDatas ClsOffOper_Create(
			decimal? Operator_BaridId,
			string Operator_Tellphone1,
			string Operator_Tellphone2,
			bool? Operator_Active,
			bool? Sign_Allowed,
			DateTime? Sign_DateExpire,
			DateTime? Sign_DateStart,
			byte[] Sign_Shape,
            List<int> Group_OffOper_ListGroupsId,
			int? Office_ID, string Operator_Name)
		{
			if (Operator_BaridId == null)
			{
				ItemsPublic.Exeptor(ItemsPublic._errBaridIdCantEmpty);
			}
			if (Sign_Allowed == null)
			{
				ItemsPublic.Exeptor(ItemsPublic._errSignNotValue);
			}
            if (Group_OffOper_ListGroupsId.Count()<1)
            {
                ItemsPublic.Exeptor("گروه انتخاب نشده است");
            }
			if (Office_ID == null)
			{
				ItemsPublic.Exeptor("اداره انتخاب نشده است");
			}
			//@ 

			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOffOper_Create);
			Input.Add(AllFunctions._IdData.Operator_BaridId, Operator_BaridId);
			Input.Add(AllFunctions._IdData.Office_ID, Office_ID);
			if (!string.IsNullOrEmpty(Operator_Tellphone1))
				Input.Add(AllFunctions._IdData.Operator_Tellphone1, Operator_Tellphone1);
			if (!string.IsNullOrEmpty(Operator_Tellphone2))
				Input.Add(AllFunctions._IdData.Operator_Tellphone2, Operator_Tellphone2);
			if (Operator_Active != null)
				Input.Add(AllFunctions._IdData.Operator_Active, (bool) Operator_Active);
			Input.Add(AllFunctions._IdData.Operator_Name, Operator_Name);
			Input.Add(AllFunctions._IdData.Sign_Allowed, Sign_Allowed);
			if (Sign_Allowed == true)
			{
				if (Sign_DateExpire != null)
				{
					Input.Add(AllFunctions._IdData.Sign_DateExpire, Sign_DateExpire);
				}
				else
				{
					ItemsPublic.Exeptor(ItemsPublic._errEndDate);
				}
				if (Sign_DateStart != null)
				{
					Input.Add(AllFunctions._IdData.Sign_DateStart, Sign_DateStart);
				}
				else
				{
					ItemsPublic.Exeptor(ItemsPublic._errStartDate);
				}

                if (Sign_Shape != null)
                {
                    if (Sign_Shape.Length > 0)
                        Input.Add(AllFunctions._IdData.Sign_Shape, Sign_Shape);
                }
			}
			// if(Group_ID!=null)
            Input.Add(AllFunctions._IdData.Group_OffOper_ListGroupsId, Group_OffOper_ListGroupsId);

			//&


			MyPolice.ClsOffOper_Create(ref Input);
			var odServer = ICustomer.Suit(Serialize.BinarySerialize(Input));
			if (odServer.success)
			{

				odServer.ResultTable = setOperBarid(ref odServer);
			}

			return odServer;
			//%

			//$
		}

		public OutputDatas ClsOffOper_Delete(decimal? OffOperValue_Id)
		{
			if (OffOperValue_Id == null)
			{
				ItemsPublic.Exeptor(ItemsPublic._errNullOfficeOperatorsId);
			}
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOffOper_Delete);
			Input.Add(AllFunctions._IdData.OffOperValue_Id, OffOperValue_Id);
			//&
			MyPolice.ClsOffOper_Delete(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

        public OutputDatas ClsOffOper_Update(
            decimal? OffOperValue_Id,
            List<int> Group_OffOper_ListGroupsId,
            string Operator_Tellphone1,
            string Operator_Tellphone2,
            bool? Operator_Active,
            bool Sign_Allowed,
            DateTime? Sign_DateExpire,
            DateTime? Sign_DateStart,
            byte[] Sign_Shape, string Operator_Name
            )
        {

            if (OffOperValue_Id == null)
            {
                ItemsPublic.Exeptor(ItemsPublic._errNullOfficeOperatorsId);
            }
            if (Group_OffOper_ListGroupsId.Count() < 1)
            {
                ItemsPublic.Exeptor("گروه انتخاب نشده است");
            }

            //@ 
            MyRefresh();
            //#
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOffOper_Update);
            Input.Add(AllFunctions._IdData.OffOperValue_Id, OffOperValue_Id);

            Input.Add(AllFunctions._IdData.Operator_Name, Operator_Name);

            if (!string.IsNullOrEmpty(Operator_Tellphone1))
                Input.Add(AllFunctions._IdData.Operator_Tellphone1, Operator_Tellphone1);
            if (!string.IsNullOrEmpty(Operator_Tellphone2))
                Input.Add(AllFunctions._IdData.Operator_Tellphone2, Operator_Tellphone2);

            if (Operator_Active != null)
            {
                if (Operator_Active == false)
                {
                    MessageBox.Show(
                        "شما اقدام به مسدود نمودن اپراتور انتخابی نموده اید" + "\n" + " و تا زمانی که  این اپراتور را فعال ننمایید" + "\n" +
                        " قادر به کار در سیستم مجوز تردد نخواهد بود ", "هشدار", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    //return dr == DialogResult.Yes;
                }
                Input.Add(AllFunctions._IdData.Operator_Active, (bool)Operator_Active);
            }

            Input.Add(AllFunctions._IdData.Sign_Allowed, Sign_Allowed);
            if (Sign_Allowed)
            {
                if (Sign_DateExpire != null)
                {
                    Input.Add(AllFunctions._IdData.Sign_DateExpire, Sign_DateExpire);
                }
                else
                {
                    ItemsPublic.Exeptor(ItemsPublic._errEndDate);
                }
                if (Sign_DateStart != null)
                {
                    Input.Add(AllFunctions._IdData.Sign_DateStart, Sign_DateStart);
                }
                else
                {
                    ItemsPublic.Exeptor(ItemsPublic._errStartDate);
                }
                if (Sign_Shape!=null)
                {
                    if (Sign_Shape.Length >0)
                Input.Add(AllFunctions._IdData.Sign_Shape, Sign_Shape);
                }
            }
            if (Group_OffOper_ListGroupsId.Count() > 0)
                Input.Add(AllFunctions._IdData.Group_OffOper_ListGroupsId, Group_OffOper_ListGroupsId);
            else
            {
                ItemsPublic.Exeptor(ItemsPublic._errNullGroup);
            }

            //&
            MyPolice.ClsOffOper_Update(ref Input);
            var odServer = ICustomer.Suit(Serialize.BinarySerialize(Input));
            if (odServer.success)
            {
                odServer.ResultTable = setOperBarid(ref odServer);
            }
            return odServer;
            //%

            //$
        }

		public OutputDatas ClsOffOper_MyOffOperId()
		{
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOffOper_MyOffOperId);
			//&
			//MyPolice.ClsOffOper_MyOffOperId(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		//public OutputDatas ClsOperators_insert()
		//{

		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOperators_insert);
		//    //&
		//    
		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

		//public OutputDatas ClsOperators_delete()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOperators_delete);
		//    //&

		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

		//public OutputDatas ClsOperators_setTest()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOperators_setTest);
		//    //&
		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

		//public OutputDatas ClsOperators_upDate()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOperators_upDate);
		//    //&
		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

		//public OutputDatas ClsOperators_signInsert()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOperators_signInsert);
		//    //&
		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

		//public OutputDatas ClsOperators_signDelete()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOperators_signDelete);
		//    //&
		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

		//public OutputDatas ClsOperators_signUpdate()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOperators_signUpdate);
		//    //&
		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

		public OutputDatas ClsPacksGps_updatePackGps(
			decimal? package_Id,
			string Package_Description,
			decimal? Agreement_ID,
			int? TravelArea_Id,
			DateTime? Package_StartDate,
			DateTime? Package_EndDate,
			int? TypePack_Id,
            DataTable Package_CollectionGps,
			AllFunctions._StatusPack pos,
			string Package_Shift,
			IEnumerable<int> Package_GatesIdCombo,
            IEnumerable<int> Package_PlacesIdCombo
			)
		{
            if (pos == AllFunctions._StatusPack.Request)
            {

                if (Package_GatesIdCombo == null)
                {
                    ItemsPublic.Exeptor("دروازه ای انتخاب نشده است");
                }

                if (Package_PlacesIdCombo == null)
                {
                    ItemsPublic.Exeptor("محدوده ترددی انتخاب نشده است");
                }

                if (!(Package_GatesIdCombo.Count() > 0))
                {
                    ItemsPublic.Exeptor("دروازه ای انتخاب نشده است");

                }


                if (!(Package_PlacesIdCombo.Count() > 0))
                {
                    ItemsPublic.Exeptor("محدوده ترددی انتخاب نشده است");
                }
                if (string.IsNullOrEmpty(Package_Shift))
                {
                    ItemsPublic.Exeptor("شیفت کاری تنظیم نیست");
                }
                if (package_Id == null)
                {
                    ItemsPublic.Exeptor("بسته یافت نشد");
                }
                if (TypePack_Id == null ||  TypePack_Id == -1)

                {
                    ItemsPublic.Exeptor("نوع بسته مشخص نیست");
                }
                if (Package_StartDate == null)
                {
                    ItemsPublic.Exeptor("تاریخ شروع تنظیم نیست");
                }
                if (Package_EndDate == null)
                {
                    ItemsPublic.Exeptor("تاریخ پایان تنظیم نیست");
                }
                if (Agreement_ID == null && TypePack_Id < 2)
                {
                    ItemsPublic.Exeptor("قرار داد مشخص نشده است");
                }
                if (TravelArea_Id == null)
                {
                    ItemsPublic.Exeptor("محل کار تعیین نشده");
                }
                if (Package_CollectionGps == null)
                {
                }
                //if (Package_CollectionGps.Rows.Count < 1)
                if (Package_CollectionGps.Rows.Count < 1)
                {
                    ItemsPublic.Exeptor("هیچ شخصی انتخاب نشده است");
                } //@ 

            }

            MyRefresh();

            if (Package_GatesIdCombo != null)
            if (Package_GatesIdCombo.Count()>0)
            {
			Input.Add ( AllFunctions._IdData.Package_GatesIdCombo , Package_GatesIdCombo );
                
            }
            if (Package_PlacesIdCombo != null)
            if (Package_PlacesIdCombo.Count() > 0)
            {
                Input.Add(AllFunctions._IdData.Package_PlacesIdCombo, Package_PlacesIdCombo);

            }
            if (!string.IsNullOrEmpty(Package_Shift))
            {

                Input.Add(AllFunctions._IdData.Package_Shift, Package_Shift);

            }

            if (TypePack_Id != null)
                if (TypePack_Id != -1)
            {
                Input.Add(AllFunctions._IdData.TypePack_Id, TypePack_Id);

            }
            if (Package_StartDate != null)
            {
                Input.Add(AllFunctions._IdData.Package_StartDate, Package_StartDate);

            }
            if (Package_EndDate != null)
            {
                Input.Add(AllFunctions._IdData.Package_EndDate, Package_EndDate);
            }
            if (Agreement_ID != null )
            {

                Input.Add(AllFunctions._IdData.Agreement_ID, Agreement_ID);
            }
            if (TravelArea_Id != null)
            {
                Input.Add(AllFunctions._IdData.TravelArea_Id, TravelArea_Id);

            }
            if (Package_CollectionGps != null)
            if (Package_CollectionGps.Rows.Count > 0)
            {
                Input.Add(AllFunctions._IdData.Package_CollectionGps, Package_CollectionGps);

            } //@ 

			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_updatePackGps);
			Input.Add(AllFunctions._IdData.package_Id, package_Id);
			Input.Add(AllFunctions._IdData.Package_Description, Package_Description);

			Input.Add(AllFunctions._IdData.Package_Status, (int) pos);

			//&
			MyPolice.ClsPacksGps_updatePackGps(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

        public OutputDatas ClsPacksGps_insertPackGps(
            DateTime? Package_StartDate,
            DateTime? Package_EndDate,
            decimal? Agreement_ID,
            int? TravelArea_Id,
            string Package_Description,
            int? TypePack_Id,
            DataTable Package_CollectionGps,
            AllFunctions._StatusPack pos,
            string Package_Shift,
            IEnumerable<int> Package_GatesIdCombo,
            IEnumerable<int> Package_PlacesIdCombo
            )
        {


            if (pos == AllFunctions._StatusPack.Request)
            {

                if (Package_GatesIdCombo == null)
                {
                    ItemsPublic.Exeptor("دروازه ای انتخاب نشده است");
                }

                    if (!(Package_GatesIdCombo.Count() > 0))
                    {
                        ItemsPublic.Exeptor("دروازه ای انتخاب نشده است");

                    }


                    if (Package_PlacesIdCombo == null)
                    {
                        ItemsPublic.Exeptor("محدوده ترددی انتخاب نشده است");
                    }

                if (!(Package_PlacesIdCombo.Count() > 0))
                {
                    ItemsPublic.Exeptor("محدوده ترددی انتخاب نشده است");
                }
                if (string.IsNullOrEmpty(Package_Shift))
                {
                    ItemsPublic.Exeptor("شیفت کاری تنظیم نیست");
                }
                
                if (TypePack_Id == null || TypePack_Id == -1)
                {
                    ItemsPublic.Exeptor("نوع بسته مشخص نیست");
                }
                if (Package_StartDate == null)
                {
                    ItemsPublic.Exeptor("تاریخ شروع تنظیم نیست");
                }
                if (Package_EndDate == null)
                {
                    ItemsPublic.Exeptor("تاریخ پایان تنظیم نیست");
                }
                if (Agreement_ID == null && TypePack_Id < 2)
                {
                    ItemsPublic.Exeptor("قرار داد مشخص نشده است");
                }
                if (TravelArea_Id == null)
                {
                    ItemsPublic.Exeptor("محل کار تعیین نشده");
                }
                if (Package_CollectionGps == null)
                {
                }
                //if (Package_CollectionGps.Rows.Count < 1)
                //if (Package_CollectionGps.Rows.Count < 1)
                //{
                //    ItemsPublic.Exeptor("هیچ شخصی انتخاب نشده است");
                //} //@ 

            }


            MyRefresh();

            //if (Package_PlacesIdCombo == null || !(Package_PlacesIdCombo.Count() > 0))
            //{
            //    ItemsPublic.Exeptor("محدوده ترددی انتخاب نشده است");
            //}
            //if (string.IsNullOrEmpty(Package_Shift))
            //{
            //    ItemsPublic.Exeptor("شیفت کاری تنظیم نیست");
            //}
            //if (TypePack_Id == null)
            //{
            //    ItemsPublic.Exeptor("نوع بسته مشخص نیست");
            //}
            //if (Package_StartDate == null)
            //{
            //    ItemsPublic.Exeptor("تاریخ شروع تنظیم نیست");
            //}
            //if (Package_EndDate == null)
            //{
            //    ItemsPublic.Exeptor("تاریخ پایان تنظیم نیست");
            //}
            //if (Agreement_ID == null && TypePack_Id < 2)
            //{
            //    ItemsPublic.Exeptor("قرار داد مشخص نشده است");
            //}
            //if (TravelArea_Id == null)
            //{
            //    ItemsPublic.Exeptor(" محل کار تعیین نشده");
            //}

            if (Package_CollectionGps.Rows.Count < 1)
            {
                ItemsPublic.Exeptor("هیچ شخصی انتخاب نشده است");
            }


            if (Package_GatesIdCombo!=null)
            if (Package_GatesIdCombo.Count() > 0)
            {
                Input.Add(AllFunctions._IdData.Package_GatesIdCombo, Package_GatesIdCombo);

            }

            if (Package_PlacesIdCombo != null)
            if (Package_PlacesIdCombo.Count() > 0)
            {
                Input.Add(AllFunctions._IdData.Package_PlacesIdCombo, Package_PlacesIdCombo);

            }

            if (!string.IsNullOrEmpty(Package_Shift))
            {

                Input.Add(AllFunctions._IdData.Package_Shift, Package_Shift);

            }

            if (TypePack_Id != null)
                if (TypePack_Id != -1)
            {
                Input.Add(AllFunctions._IdData.TypePack_Id, TypePack_Id);

            }
            if (Package_StartDate != null)
            {
                Input.Add(AllFunctions._IdData.Package_StartDate, Package_StartDate);

            }
            if (Package_EndDate != null)
            {
                Input.Add(AllFunctions._IdData.Package_EndDate, Package_EndDate);
            }
            if (Agreement_ID != null)
            {

                Input.Add(AllFunctions._IdData.Agreement_ID, Agreement_ID);
            }
            if (TravelArea_Id != null)
            {
                Input.Add(AllFunctions._IdData.TravelArea_Id, TravelArea_Id);

            }
            if (Package_CollectionGps != null)
            if (Package_CollectionGps.Rows.Count > 0)
            {
                Input.Add(AllFunctions._IdData.Package_CollectionGps, Package_CollectionGps);

            } //@ 


            //@ 
            //#
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_insertPackGps);
            //    if (! string.IsNullOrEmpty(Package_Description))
            Input.Add(AllFunctions._IdData.Package_Description, Package_Description);
      //      Input.Add(AllFunctions._IdData.Package_Shift, Package_Shift);

          //  if (Agreement_ID != null)
             //   Input.Add(AllFunctions._IdData.Agreement_ID, Agreement_ID);
         //   Input.Add(AllFunctions._IdData.TravelArea_Id, TravelArea_Id);
          //  Input.Add(AllFunctions._IdData.Package_StartDate, Package_StartDate);
          //  Input.Add(AllFunctions._IdData.Package_EndDate, Package_EndDate);
        //    Input.Add(AllFunctions._IdData.TypePack_Id, TypePack_Id);
         //   Input.Add(AllFunctions._IdData.Package_CollectionGps, Package_CollectionGps);
         //   Input.Add(AllFunctions._IdData.Package_GatesIdCombo, Package_GatesIdCombo);
         //   Input.Add(AllFunctions._IdData.Package_PlacesIdCombo, Package_PlacesIdCombo);

            //if (Package_personIdHasVehicle != null && Vehicle_ID != null)
            //{
            //    // Input.Add(AllFunctions._IdData.Package_personIdHasVehicle, Package_personIdHasVehicle);
            //    Input.Add(AllFunctions._IdData.Vehicle_ID, Vehicle_ID);
            //}
            //else if (!(Package_personIdHasVehicle == null && Vehicle_ID == null))
            //{
            //    if (Package_personIdHasVehicle == null)
            //    {
            //        ItemsPublic.Exeptor("راننده انتخاب نشده است");
            //    }
            //    ItemsPublic.Exeptor("خودرویی برای راننده انتخاب نشده است");
            //}

            Input.Add(AllFunctions._IdData.Package_Status, (int)pos);

            MyPolice.ClsPacksGps_insertPackGps(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
            //%
            //$
        }

        public OutputDatas ClsPacksGps_updatePackGpsOldVersion(
            decimal? package_Id,
            string Package_Description,
            decimal? Agreement_ID,
            int? TravelArea_Id,
            DateTime? Package_StartDate,
            DateTime? Package_EndDate,
            int? TypePack_Id,
            IEnumerable<decimal> Package_CollectionGps,
            decimal? Package_personIdHasVehicle,
            decimal? Vehicle_ID,
            AllFunctions._StatusPack pos,
            string Package_Shift,
            IEnumerable<int> Package_GatesIdCombo,
IEnumerable<int> Package_PlacesIdCombo
            )
        {
            if (!(Package_PlacesIdCombo.Count() > 0))
            {
                ItemsPublic.Exeptor("محدوده ترددی انتخاب نشده است");
            }

            if (string.IsNullOrEmpty(Package_Shift))
            {
                ItemsPublic.Exeptor("شیفت کاری تنظیم نیست");
            }
            if (package_Id == null)
            {
                ItemsPublic.Exeptor("بسته یافت نشد");
            }
            if (TypePack_Id == null)
            {
                ItemsPublic.Exeptor("نوع بسته مشخص نیست");
            }
            if (Package_StartDate == null)
            {
                ItemsPublic.Exeptor("تاریخ شروع تنظیم نیست");
            }
            if (Package_EndDate == null)
            {
                ItemsPublic.Exeptor("تاریخ پایان تنظیم نیست");
            }
            if (Agreement_ID == null && TypePack_Id < 2)
            {
                ItemsPublic.Exeptor("قرار داد مشخص نشده است");
            }
            if (TravelArea_Id == null)
            {
                ItemsPublic.Exeptor("محل کار تعیین نشده");
            }
            if (Package_CollectionGps.Count() < 1)
            {
                ItemsPublic.Exeptor("هیچ شخصی انتخاب نشده است");
            } //@ 
            MyRefresh();
            //#
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_updatePackGps);
            Input.Add(AllFunctions._IdData.package_Id, package_Id);
            Input.Add(AllFunctions._IdData.Package_Description, Package_Description);

            if (Agreement_ID != null)
                Input.Add(AllFunctions._IdData.Agreement_ID, Agreement_ID);

            Input.Add(AllFunctions._IdData.Package_Shift, Package_Shift);

            Input.Add(AllFunctions._IdData.TravelArea_Id, TravelArea_Id);
            Input.Add(AllFunctions._IdData.Package_StartDate, Package_StartDate);
            Input.Add(AllFunctions._IdData.Package_EndDate, Package_EndDate);
            Input.Add(AllFunctions._IdData.Package_CollectionGps, Package_CollectionGps);
            Input.Add(AllFunctions._IdData.Package_GatesIdCombo, Package_GatesIdCombo);
            Input.Add(AllFunctions._IdData.Package_PlacesIdCombo, Package_PlacesIdCombo);
            if ((Package_personIdHasVehicle != null && Vehicle_ID != null) || ((Package_personIdHasVehicle == null && Vehicle_ID == null)))
            {
                //Input.Add(AllFunctions._IdData.Package_personIdHasVehicle, Package_personIdHasVehicle);
                Input.Add(AllFunctions._IdData.Vehicle_ID, Vehicle_ID);
            }
            else
            {
                if (Package_personIdHasVehicle == null)
                {
                    ItemsPublic.Exeptor("راننده انتخاب نشده است");
                }
                ItemsPublic.Exeptor("خودرویی برای راننده انتخاب نشده است");
            }
            Input.Add(AllFunctions._IdData.TypePack_Id, TypePack_Id);
            Input.Add(AllFunctions._IdData.Package_Status, (int)pos);

            //&
            MyPolice.ClsPacksGps_updatePackGps(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
            //%

            //$
        }

        public OutputDatas ClsPacksGps_insertPackGpsOldVersion(
            DateTime? Package_StartDate,
            DateTime? Package_EndDate,
            decimal? Agreement_ID,
            int? TravelArea_Id,
            string Package_Description,
            int? TypePack_Id,
            IEnumerable<decimal> Package_CollectionGps,
            decimal? Package_personIdHasVehicle,
            decimal? Vehicle_ID,
            AllFunctions._StatusPack pos,
            string Package_Shift,
            IEnumerable<int> Package_GatesIdCombo,
            IEnumerable<int> Package_PlacesIdCombo
            )
        {
            if (Package_PlacesIdCombo == null || !(Package_PlacesIdCombo.Count() > 0))
            {
                ItemsPublic.Exeptor("محدوده ترددی انتخاب نشده است");
            }
            if (string.IsNullOrEmpty(Package_Shift))
            {
                ItemsPublic.Exeptor("شیفت کاری تنظیم نیست");
            }
            if (TypePack_Id == null)
            {
                ItemsPublic.Exeptor("نوع بسته مشخص نیست");
            }
            if (Package_StartDate == null)
            {
                ItemsPublic.Exeptor("تاریخ شروع تنظیم نیست");
            }
            if (Package_EndDate == null)
            {
                ItemsPublic.Exeptor("تاریخ پایان تنظیم نیست");
            }
            if (Agreement_ID == null && TypePack_Id < 2)
            {
                ItemsPublic.Exeptor("قرار داد مشخص نشده است");
            }
            if (TravelArea_Id == null)
            {
                ItemsPublic.Exeptor(" محل کار تعیین نشده");
            }
            if (Package_CollectionGps.Count() < 1)
            {
                ItemsPublic.Exeptor("هیچ شخصی انتخاب نشده است");
            }

            //@ 
            MyRefresh();
            //#
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_insertPackGps);
            //    if (! string.IsNullOrEmpty(Package_Description))
            Input.Add(AllFunctions._IdData.Package_Description, Package_Description);
            Input.Add(AllFunctions._IdData.Package_Shift, Package_Shift);

            if (Agreement_ID != null)
                Input.Add(AllFunctions._IdData.Agreement_ID, Agreement_ID);
            Input.Add(AllFunctions._IdData.TravelArea_Id, TravelArea_Id);
            Input.Add(AllFunctions._IdData.Package_StartDate, Package_StartDate);
            Input.Add(AllFunctions._IdData.Package_EndDate, Package_EndDate);
            Input.Add(AllFunctions._IdData.TypePack_Id, TypePack_Id);
            Input.Add(AllFunctions._IdData.Package_CollectionGps, Package_CollectionGps);
            Input.Add(AllFunctions._IdData.Package_GatesIdCombo, Package_GatesIdCombo);
            Input.Add(AllFunctions._IdData.Package_PlacesIdCombo, Package_PlacesIdCombo);

            if (Package_personIdHasVehicle != null && Vehicle_ID != null)
            {
                // Input.Add(AllFunctions._IdData.Package_personIdHasVehicle, Package_personIdHasVehicle);
                Input.Add(AllFunctions._IdData.Vehicle_ID, Vehicle_ID);
            }
            else if (!(Package_personIdHasVehicle == null && Vehicle_ID == null))
            {
                if (Package_personIdHasVehicle == null)
                {
                    ItemsPublic.Exeptor("راننده انتخاب نشده است");
                }
                ItemsPublic.Exeptor("خودرویی برای راننده انتخاب نشده است");
            }

            Input.Add(AllFunctions._IdData.Package_Status, (int)pos);

            MyPolice.ClsPacksGps_insertPackGps(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
            //%
            //$
        }

        public OutputDatas ClsPacksGps_confirm(decimal? package_Id, AllFunctions._StatusPack pos, string eventsMessage, DataTable Package_CollectionGps)
		{
			if (package_Id == null)
			{
				ItemsPublic.Exeptor("بسته یافت نشد");
			}

            if (Package_CollectionGps.Rows.Count < 1)
            {
                ItemsPublic.Exeptor("هیچ شخصی انتخاب نشده است");
            }

			//@ 
			MyRefresh();
			//#

			Input.Add(AllFunctions._IdData.package_Id, package_Id);
            

			if (pos != AllFunctions._StatusPack.Confirm
			    && pos != AllFunctions._StatusPack.NoConfirm)
			{
				ItemsPublic.Exeptor("وضعیت بسته با عملیات درخواستی مطابقت ندارد");
			}
			Input.Add(AllFunctions._IdData.Package_Status, (int) pos);
			var Package_Events = eventsMessage;//pos == AllFunctions._StatusPack.Confirm ? string.Empty :ItemsPublic.GetMessage ( "لطفا علت عدم تایید را توضیح دهید" );
			Input.Add ( AllFunctions._IdData.Package_Events , Package_Events );

            Input.Add(AllFunctions._IdData.Package_CollectionGps, Package_CollectionGps);

			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_confirm);

			MyPolice.ClsPacksGps_confirm(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

        public OutputDatas ClsPacksGps_passage(decimal? package_Id, AllFunctions._StatusPack pos, string eventsMessage, DataTable Package_CollectionGps)
		{
			if (package_Id == null)
			{
				ItemsPublic.Exeptor("بسته یافت نشد");
			}
            if (Package_CollectionGps.Rows.Count < 1)
            {
                ItemsPublic.Exeptor("هیچ شخصی انتخاب نشده است");
            }
			//@ 
			MyRefresh();
			//#

			Input.Add(AllFunctions._IdData.package_Id, package_Id);
			if (pos != AllFunctions._StatusPack.Passage
			    && pos != AllFunctions._StatusPack.NoPassage)
			{
				ItemsPublic.Exeptor("وضعیت بسته با عملیات درخواستی مطابقت ندارد");
			}
			Input.Add(AllFunctions._IdData.Package_Status, (int) pos);
			var Package_Events = eventsMessage;// pos == AllFunctions._StatusPack.Passage ? string.Empty :ItemsPublic.GetMessage("لطفا علت عدم تصویب را توضیح دهید") ;
			Input.Add ( AllFunctions._IdData.Package_Events , Package_Events );

            Input.Add(AllFunctions._IdData.Package_CollectionGps, Package_CollectionGps);
            
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_passage);
			MyPolice.ClsPacksGps_passage(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsPacksGps_ExpireGp( decimal? Gatepass_ID )
		{
			if (Gatepass_ID == null)
			{
				ItemsPublic.Exeptor("مجوز عبوری یافت نشد");
			}
			//@ 
			MyRefresh();
			//#
			Input.Add ( AllFunctions._IdData.Gatepass_ID , Gatepass_ID );

            

			Input.Add ( AllFunctions._IdData.IdMethod , AllFunctions._IdMethod.ClsPacksGps_ExpireGp );
			MyPolice.ClsPacksGps_ExpireGp ( ref Input );
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}


		public OutputDatas ClsPacksGps_PrintedGP( AllFunctions._StatePrint GatePass_IntPrint, DataTable Package_CollectionGps)
		{
            if (Package_CollectionGps.Rows.Count < 1)
            {
                ItemsPublic.Exeptor("هیچ شخصی انتخاب نشده است");
            }

			if (GatePass_IntPrint != AllFunctions._StatePrint.Complete && GatePass_IntPrint != AllFunctions._StatePrint.Free)
			{
				ItemsPublic.Exeptor("وضعیت دریافتی مجاز نمی باشد");
			}
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_PrintedGP);
			//Input.Add(AllFunctions._IdData.Gatepass_ID, Gatepass_ID);
			Input.Add(AllFunctions._IdData.GatePass_IntPrint, GatePass_IntPrint);
            Input.Add(AllFunctions._IdData.Package_CollectionGps, Package_CollectionGps);

			MyPolice.ClsPacksGps_PrintedGP(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

        public OutputDatas ClsPacksGps_RequestPrintGP( DataTable Package_CollectionGps)
		{

            if (Package_CollectionGps.Rows.Count < 1)
            {
                ItemsPublic.Exeptor("هیچ مجوزی انتخاب نشده است");
            }

            //if ( Gatepass_ID == null )
            //{
            //    ItemsPublic.Exeptor ( "گیت پاسی انتخاب نشده است" );
            //}
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_RequestPrintGP);
		//	Input.Add ( AllFunctions._IdData.Gatepass_ID , Gatepass_ID );
            Input.Add(AllFunctions._IdData.Package_CollectionGps, Package_CollectionGps);
			MyPolice.ClsPacksGps_RequestPrintGP(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%
			//$
		}

        public OutputDatas ClsPacksGps_RegisterCards(DataTable Package_CollectionGps)
        {

            if (Package_CollectionGps.Rows.Count < 1)
            {
                ItemsPublic.Exeptor("هیچ مجوزی انتخاب نشده است");
            }

            //if ( Gatepass_ID == null )
            //{
            //    ItemsPublic.Exeptor ( "گیت پاسی انتخاب نشده است" );
            //}
            //@ 
            MyRefresh();
            //#
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_RegisterCards);
            //	Input.Add ( AllFunctions._IdData.Gatepass_ID , Gatepass_ID );
            Input.Add(AllFunctions._IdData.Package_CollectionGps, Package_CollectionGps);
            MyPolice.ClsPacksGps_RegisterCards(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));

            //%
            //$
        }



        public OutputDatas ClsPacksGps_PrintingGp( AllFunctions._StatePrint GatePass_IntPrint, DataTable Package_CollectionGps)
		{

            if (Package_CollectionGps.Rows.Count < 1)
            {
                ItemsPublic.Exeptor("هیچ شخصی انتخاب نشده است");
            }
            //if ( Gatepass_ID == null )
            //{
            //    ItemsPublic.Exeptor ( "گیت پاسی انتخاب نشده است" );
            //}
			if ( GatePass_IntPrint != AllFunctions._StatePrint.Printing && GatePass_IntPrint != AllFunctions._StatePrint.Free )
			{
				ItemsPublic.Exeptor ( "وضعیت دریافتی مجاز نمی باشد" );
			}
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_PrintingGp);
		//	Input.Add ( AllFunctions._IdData.Gatepass_ID , Gatepass_ID );
			Input.Add ( AllFunctions._IdData.GatePass_IntPrint , GatePass_IntPrint );
            Input.Add(AllFunctions._IdData.Package_CollectionGps, Package_CollectionGps);
			MyPolice.ClsPacksGps_PrintingGp(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}
		public OutputDatas ClsPacksGps_FreePrintGP()
		{
			//@ 
			MyRefresh ();
			//#
			Input.Add ( AllFunctions._IdData.IdMethod , AllFunctions._IdMethod.ClsPacksGps_FreePrintGP );
			MyPolice.ClsPacksGps_FreePrintGP ( ref Input );
			return ICustomer.Suit ( Serialize.BinarySerialize ( Input ) );
			//%

			//$
		}

        public OutputDatas ClsPacksGps_PrintedGP2(decimal? Gatepass_ID, AllFunctions._StatePrint GatePass_IntPrint)
        {
            if (Gatepass_ID == null)
            {
                ItemsPublic.Exeptor("گیت پاسی انتخاب نشده است");
            }

            if (GatePass_IntPrint != AllFunctions._StatePrint.Complete && GatePass_IntPrint != AllFunctions._StatePrint.Free)
            {
                ItemsPublic.Exeptor("وضعیت دریافتی مجاز نمی باشد");
            }
            //@ 
            MyRefresh();
            //#
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_PrintedGP);
            Input.Add(AllFunctions._IdData.Gatepass_ID, Gatepass_ID);
            Input.Add(AllFunctions._IdData.GatePass_IntPrint, GatePass_IntPrint);

            MyPolice.ClsPacksGps_PrintedGP(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
            //%

            //$
        }

        public OutputDatas ClsPacksGps_RequestPrintGP2(decimal? Gatepass_ID)
        {
            if (Gatepass_ID == null)
            {
                ItemsPublic.Exeptor("گیت پاسی انتخاب نشده است");
            }
            //@ 
            MyRefresh();
            //#
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_RequestPrintGP);
            Input.Add(AllFunctions._IdData.Gatepass_ID, Gatepass_ID);
            MyPolice.ClsPacksGps_RequestPrintGP(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
            //%
            //$
        }

        public OutputDatas ClsPacksGps_PrintingGp2(decimal? Gatepass_ID, AllFunctions._StatePrint GatePass_IntPrint)
        {
            if (Gatepass_ID == null)
            {
                ItemsPublic.Exeptor("گیت پاسی انتخاب نشده است");
            }
            if (GatePass_IntPrint != AllFunctions._StatePrint.Printing && GatePass_IntPrint != AllFunctions._StatePrint.Free)
            {
                ItemsPublic.Exeptor("وضعیت دریافتی مجاز نمی باشد");
            }
            //@ 
            MyRefresh();
            //#
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_PrintingGp);
            Input.Add(AllFunctions._IdData.Gatepass_ID, Gatepass_ID);
            Input.Add(AllFunctions._IdData.GatePass_IntPrint, GatePass_IntPrint);
            MyPolice.ClsPacksGps_PrintingGp(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
            //%

            //$
        }
        public OutputDatas ClsPacksGps_FreePrintGP2()
        {
            //@ 
            MyRefresh();
            //#
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPacksGps_FreePrintGP);
            MyPolice.ClsPacksGps_FreePrintGP(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
            //%

            //$
        }

		public OutputDatas ClsPersons_insert(string Name, string SurName,
		                                     string NationalCode, string Nationality,
		                                     string FatherName, string BirthCity,
		                                     DateTime? BirthDate, string LicenseDriveCode,
		                                     string Phone1, string Phone2,
		                                     bool HaveForm, bool? IsWoman, string RegisterCity,
											 byte [] Picture , string IdentifyCode , string Person_RegisterCode , DateTime? SecureEnd )
		{
            bool canBlack = ItemsPublic.MyRights.Contains(AllFunctions._Rights.ClsBlack_BL_insert);

            if (!ItemsPublic.IsDigitNumber(NationalCode.Trim(), 10))
            {
                ItemsPublic.Exeptor("مقدار وارد شده جهت کد ملی نا معتبر می باشد");
            }

            if (!ItemsPublic.NationalCodeIsTrue(NationalCode.Trim()))
                {                   
                    ItemsPublic.Exeptor("مقدار وارد شده جهت کد ملی نا معتبر می باشد");
                }       

            if (string.IsNullOrEmpty(Name.Trim()))
			{
				ItemsPublic.Exeptor(ItemsPublic._errPersonName);
			}
            if (string.IsNullOrEmpty(SurName.Trim()))
			{
				ItemsPublic.Exeptor(ItemsPublic._errPersonSurName);
			}
            if (string.IsNullOrEmpty(FatherName.Trim()))
			{
				ItemsPublic.Exeptor(ItemsPublic._errPersonFatherName);
			}

            if (string.IsNullOrEmpty(Nationality.Trim()))
            {
                ItemsPublic.Exeptor("ملیت فرد مشخص نیست");
            }
            
            if (!canBlack && string.IsNullOrEmpty(BirthCity.Trim()))
            {
                ItemsPublic.Exeptor("شهر محل تولد فرد مشخص نیست");
            }
            if (!canBlack && string.IsNullOrEmpty(RegisterCity.Trim()))
            {
                ItemsPublic.Exeptor("محل صدور شناسنامه مشخصی نیست");
            }
            if (!canBlack && string.IsNullOrEmpty(Person_RegisterCode.Trim()))
            {
                ItemsPublic.Exeptor("شماره شناسنامه وارد نشده است");
            }
            if (IsWoman == null)
            {
                ItemsPublic.Exeptor("جنسیت مشخص نیست");
            }

			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPersons_insert); 
			if (IdentifyCode.Trim() != string.Empty && IdentifyCode.Trim() != "0")
			{
				Input.Add(AllFunctions._IdData.Person_IdentifyCode, IdentifyCode.Trim());
			}
			Input.Add(AllFunctions._IdData.Person_isWoman, IsWoman);
			if (LicenseDriveCode.Trim() != string.Empty && LicenseDriveCode.Trim() != "0")
			{
				Input.Add(AllFunctions._IdData.Person_LicenseDriverCode, LicenseDriveCode.Trim());
			}
			Input.Add(AllFunctions._IdData.Person_Name, Name);
			Input.Add(AllFunctions._IdData.Person_NationalCode, NationalCode.Trim());
			//if (!string.IsNullOrEmpty(Nationality))
				Input.Add(AllFunctions._IdData.Person_Nationality, Nationality.Trim());
			if (!string.IsNullOrEmpty(Phone1) && Phone1.Trim() != "0")
				Input.Add(AllFunctions._IdData.Person_Phone1, Phone1);
			if (!string.IsNullOrEmpty(Phone2) && Phone2.Trim() != "0")
				Input.Add(AllFunctions._IdData.Person_Phone2, Phone2);
			//if (!string.IsNullOrEmpty(RegisterCity))
				Input.Add(AllFunctions._IdData.Person_RegisterCity, RegisterCity);

			Input.Add(AllFunctions._IdData.Person_Surname, SurName);

			if (HaveForm != null)
				Input.Add(AllFunctions._IdData.Person_HaveForm, HaveForm);

			if ( SecureEnd != null)
				Input.Add ( AllFunctions._IdData.Person_SecureFormDate , SecureEnd );

		//	if (!string.IsNullOrEmpty(FatherName))
				Input.Add(AllFunctions._IdData.Person_FatherName, FatherName);
		//	if (!string.IsNullOrEmpty(Person_RegisterCode))
				Input.Add(AllFunctions._IdData.Person_RegisterCode, Person_RegisterCode);
			if (BirthDate != null)
				Input.Add(AllFunctions._IdData.Person_BirthDate, BirthDate);
			//if (!string.IsNullOrEmpty(BirthCity))
				Input.Add(AllFunctions._IdData.Person_BirthCity, BirthCity);

			if (Picture != null)
				if (Picture.Length > 0)
				{
					Input.Add(AllFunctions._IdData.Person_Picture, Picture);
				}
			//&
			MyPolice.ClsPersons_insert(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsPersons_delete(decimal ID)
		{
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPersons_delete);
			Input.Add(AllFunctions._IdData.Person_ID, ID);
			//&
			MyPolice.ClsPersons_delete(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}


        public OutputDatas ClsPersons_SecureManualUpdate(DataTable GpPersonCarList, bool HaveForm, DateTime? SecureEnd)
        {

            if (GpPersonCarList.Rows.Count < 1)
            {
                ItemsPublic.Exeptor("هیچ شخصی انتخاب نشده است");
            }  

            MyRefresh();


            if (HaveForm != null)
                Input.Add(AllFunctions._IdData.Person_HaveForm, HaveForm);

            if (SecureEnd != null)
                Input.Add(AllFunctions._IdData.Person_SecureFormDate, SecureEnd);

            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPersons_SecureManualUpdate);

            Input.Add(AllFunctions._IdData.GpPersonCarList, GpPersonCarList);

            return ICustomer.Suit(Serialize.BinarySerialize(Input));

        }
		public OutputDatas ClsPersons_update(decimal ID, string Name, string SurName,
		                                     string NationalCode, string Nationality,
		                                     string FatherName, string BirthCity,
		                                     DateTime? BirthDate, string LicenseDriveCode,
		                                     string Phone1, string Phone2,
		                                     bool HaveForm, bool? IsWoman, string RegisterCity,
											 byte [] Picture , string IdentifyCode , string Person_RegisterCode , DateTime? SecureEnd )
		{
			if (string.IsNullOrEmpty(Name.Trim()))
			{
				ItemsPublic.Exeptor(ItemsPublic._errPersonName);
			}
            if (string.IsNullOrEmpty(SurName.Trim()))
			{
				ItemsPublic.Exeptor(ItemsPublic._errPersonSurName);
			}
            if (string.IsNullOrEmpty(FatherName.Trim()))
			{
				ItemsPublic.Exeptor(ItemsPublic._errPersonFatherName);
			}


            if (string.IsNullOrEmpty(Nationality.Trim()))
            {
                ItemsPublic.Exeptor("ملیت فرد مشخص نیست");
            }
            if (string.IsNullOrEmpty(BirthCity.Trim()))
            {
                ItemsPublic.Exeptor("شهر محل تولد فرد مشخص نیست");
            }
            if (string.IsNullOrEmpty(RegisterCity.Trim()))
            {
                ItemsPublic.Exeptor("محل صدور شناسنامه مشخصی نیست");
            }
            if (string.IsNullOrEmpty(Person_RegisterCode.Trim()))
            {
                ItemsPublic.Exeptor("شماره شناسنامه وارد نشده است");
            }

            if (IsWoman == null)
            {
                ItemsPublic.Exeptor("جنسیت مشخص نیست");
            }

			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsPersons_update);
			if (IdentifyCode.Trim() == "0")
			{
				IdentifyCode = string.Empty;
			}

			Input.Add(AllFunctions._IdData.Person_IdentifyCode, IdentifyCode.Trim());

			Input.Add(AllFunctions._IdData.Person_isWoman, IsWoman);
			if (LicenseDriveCode.Trim() == "0")
				LicenseDriveCode = string.Empty;
			Input.Add(AllFunctions._IdData.Person_LicenseDriverCode, LicenseDriveCode.Trim());
			Input.Add(AllFunctions._IdData.Person_Name, Name);
			Input.Add(AllFunctions._IdData.Person_NationalCode, NationalCode.Trim());

			// if (string.IsNullOrEmpty(Nationality))
			Input.Add(AllFunctions._IdData.Person_Nationality, Nationality.Trim());
			if (Phone1.Trim() == "0")
				Phone1 = string.Empty;
			Input.Add(AllFunctions._IdData.Person_Phone1, Phone1);
			if (Phone2.Trim() == "0")
				Phone2 = string.Empty;
			Input.Add(AllFunctions._IdData.Person_Phone2, Phone2);
			//  if (!string.IsNullOrEmpty(RegisterCity))
			Input.Add(AllFunctions._IdData.Person_RegisterCity, RegisterCity);

			Input.Add(AllFunctions._IdData.Person_Surname, SurName);
			if (HaveForm != null)
				Input.Add(AllFunctions._IdData.Person_HaveForm, HaveForm);
			if ( SecureEnd != null )
				Input.Add ( AllFunctions._IdData.Person_SecureFormDate , SecureEnd );

			//   if (!string.IsNullOrEmpty(FatherName))
			Input.Add(AllFunctions._IdData.Person_FatherName, FatherName);
			//  if (!string.IsNullOrEmpty(Person_RegisterCode))
			Input.Add(AllFunctions._IdData.Person_RegisterCode, Person_RegisterCode);
			//   if (BirthDate != null)
			Input.Add(AllFunctions._IdData.Person_BirthDate, BirthDate);


			// if (!string.IsNullOrEmpty(BirthCity))
			Input.Add(AllFunctions._IdData.Person_BirthCity, BirthCity);

			if (Picture.Length > 0)
			{
				Input.Add(AllFunctions._IdData.Person_Picture, Picture);
			}
			Input.Add(AllFunctions._IdData.Person_ID, ID);

			//&
			MyPolice.ClsPersons_update(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%
			//$
		}

		public OutputDatas ClsTravelAreas_insert(string TravelArea_Name,
		                                         string TravelArea_Description, int? TravelArea_ParentId)
		{
			if (string.IsNullOrEmpty(TravelArea_Name))
			{
				ItemsPublic.Exeptor(ItemsPublic._errTaNameEmpty);
			}
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsTravelAreas_insert);
			Input.Add(AllFunctions._IdData.TravelArea_Name, TravelArea_Name);
			Input.Add(AllFunctions._IdData.TravelArea_Description, TravelArea_Description);
			if (TravelArea_ParentId != null)
				Input.Add(AllFunctions._IdData.TravelArea_ParentId, TravelArea_ParentId);
			//&
			MyPolice.ClsTravelAreas_insert(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsTravelAreas_update
			(int? TravelArea_Id, string TravelArea_Name,
			 string TravelArea_Description, int? TravelArea_ParentId, bool? TravelArea_Hidden)
		{
			if (TravelArea_Id == null)
			{
				ItemsPublic.Exeptor(ItemsPublic._errTaCantFindTaid);
			}
			if (string.IsNullOrEmpty(TravelArea_Name))
			{
				ItemsPublic.Exeptor(ItemsPublic._errNameEmpty);
			}
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsTravelAreas_update);
			Input.Add(AllFunctions._IdData.TravelArea_Id, TravelArea_Id);
			//   if (!string.IsNullOrEmpty(TravelArea_Name))
			Input.Add(AllFunctions._IdData.TravelArea_Name, TravelArea_Name);
			//if (string.IsNullOrEmpty(TravelArea_Description))
			Input.Add(AllFunctions._IdData.TravelArea_Description, TravelArea_Description);
			if (TravelArea_ParentId != null)
				Input.Add(AllFunctions._IdData.TravelArea_ParentId, TravelArea_ParentId);
			if (TravelArea_Hidden != null && TravelArea_Hidden != false) //DAR HAR SORAT TRUE HESAB MIKONAD
				Input.Add(AllFunctions._IdData.TravelArea_Hidden, TravelArea_Hidden);
			//&
			MyPolice.ClsTravelAreas_update(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsVehicles_insert(
			int TypePlates_Id , string Vehicle_number, string vehicle_Name,
			string vehicle_Color, string Vehicle_Model, int? VehicleType_ID, bool? Vehicle_IsCompany)
		{

            if (TypePlates_Id > 1 || TypePlates_Id<0)
            {
                ItemsPublic.Exeptor("نوع پلاک نامشخص می باشد");
            }	


			if (string.IsNullOrEmpty(Vehicle_number))
			{
				ItemsPublic.Exeptor("شماره خودرو صحیح وارد نشده است");
			}	
			//if (string.IsNullOrEmpty(vehicle_Name))
			//{
			//    ItemsPublic.Exeptor("نام خودرو وارد نشده است");
			//}


			if (string.IsNullOrEmpty(vehicle_Color))
			{
				ItemsPublic.Exeptor("رنگ خودرو وارد نشده است");
			}
			if (string.IsNullOrEmpty(Vehicle_Model))
			{
				ItemsPublic.Exeptor("مدل خودرو وارد نشده است");
			}
			if (VehicleType_ID == null)
			{
				ItemsPublic.Exeptor("نوعی برای خودرو انتخاب نشده است");
			}
			if (Vehicle_IsCompany == null)
			{
				ItemsPublic.Exeptor("وضعیت خودرو نامشخص است");
			}
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsVehicles_insert);

            Input.Add(AllFunctions._IdData.TypePlates_Id, TypePlates_Id);

            Input.Add(AllFunctions._IdData.Vehicle_number, Vehicle_number);


			//	Input.Add(AllFunctions._IdData.vehicle_Name, vehicle_Name);

			if (!string.IsNullOrEmpty(vehicle_Name))
				Input.Add(AllFunctions._IdData.vehicle_Name, vehicle_Name);

			Input.Add(AllFunctions._IdData.vehicle_Color, vehicle_Color);
			Input.Add(AllFunctions._IdData.Vehicle_Model, Vehicle_Model);
			Input.Add(AllFunctions._IdData.VehicleType_ID, VehicleType_ID);
			Input.Add(AllFunctions._IdData.Vehicle_IsCompany, Vehicle_IsCompany);

			//&

			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsVehicles_insert_Type(string VehicleType_Name, string VehicleType_Desc)
		{
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsVehicles_insert_Type);
			Input.Add(AllFunctions._IdData.VehicleType_Name, VehicleType_Name);
			Input.Add(AllFunctions._IdData.VehicleType_Desc, VehicleType_Desc);
			Input.Add(AllFunctions._IdData.VehicleType_Hidden, false);
			//&
			MyPolice.ClsVehicles_insert_Type(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsVehicles_update(
            int TypePlates_Id,decimal? Vehicle_ID, string Vehicle_number, string vehicle_Name,
			string vehicle_Color, string Vehicle_Model, int? VehicleType_ID, bool? Vehicle_IsCompany)
		{

            if (TypePlates_Id > 1 || TypePlates_Id < 0)
            {
                ItemsPublic.Exeptor("نوع پلاک نامشخص می باشد");
            }	

			if ( string.IsNullOrEmpty ( Vehicle_number ) )
			{
				ItemsPublic.Exeptor ( "شماره خودرو صحیح وارد نشده است" );
			}	

			if (Vehicle_ID == null)
			{
				ItemsPublic.Exeptor(" خودرو یافت نشد");
			}
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsVehicles_update);
			//&
			Input.Add(AllFunctions._IdData.Vehicle_ID, Vehicle_ID);

            Input.Add(AllFunctions._IdData.TypePlates_Id, TypePlates_Id);

			if (!string.IsNullOrEmpty(Vehicle_number))
				Input.Add(AllFunctions._IdData.Vehicle_number, Vehicle_number);
			if (!string.IsNullOrEmpty(vehicle_Name))
				Input.Add(AllFunctions._IdData.vehicle_Name, vehicle_Name);
			if (!string.IsNullOrEmpty(vehicle_Color))
				Input.Add(AllFunctions._IdData.vehicle_Color, vehicle_Color);
			if (!string.IsNullOrEmpty(Vehicle_Model))
				Input.Add(AllFunctions._IdData.Vehicle_Model, Vehicle_Model);
			if (VehicleType_ID != null)

				Input.Add(AllFunctions._IdData.VehicleType_ID, VehicleType_ID);
			if (Vehicle_IsCompany != null)
				Input.Add(AllFunctions._IdData.Vehicle_IsCompany, Vehicle_IsCompany);

			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas ClsVehicles_update_Type(int? VehicleType_ID, bool? isdelete, string VehicleType_Desc)
		{
			if (VehicleType_ID == null)
			{
				ItemsPublic.Exeptor(ItemsPublic._errCantFindId);
			}
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsVehicles_update_Type);
			Input.Add(AllFunctions._IdData.VehicleType_ID, VehicleType_ID);
			if (!string.IsNullOrEmpty(VehicleType_Desc))
				Input.Add(AllFunctions._IdData.VehicleType_Desc, VehicleType_Desc);
			if (isdelete != null && isdelete == true)
				Input.Add(AllFunctions._IdData.VehicleType_Hidden, true);
			//&
			MyPolice.ClsVehicles_update_Type(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

        public OutputDatas View_groups(string Group_Name, bool? Group_IsActive, decimal? OffOperValue_Id)
		{
			//@ 
			MyRefresh();
			//#

			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_groups);
			if (Group_IsActive != null)
				Input.Add(AllFunctions._IdData.Group_IsActive, Group_IsActive);
			if (!string.IsNullOrEmpty(Group_Name))
				Input.Add(AllFunctions._IdData.Group_Name, Group_Name);
            if (OffOperValue_Id != null)
                Input.Add(AllFunctions._IdData.OffOperValue_Id, OffOperValue_Id);
			//&
			MyPolice.View_groups(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas View_rights(int? Group_ID, int? OffOperValue_Id)
		{
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_rights);
			if (Group_ID != null)
				Input.Add(AllFunctions._IdData.Group_ID, Group_ID);
			if (OffOperValue_Id != null)
				Input.Add(AllFunctions._IdData.OffOperValue_Id, OffOperValue_Id);
			//&
			MyPolice.View_rights(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//foreach (var o in od)
			//{

			//}
			//%

			//$
		}

        public OutputDatas View_offices(string Office_Name)
        {
            return View_officesComplex(Office_Name, null, null,null,null,false);
        }
        public OutputDatas View_officesComplex(string Office_Name, decimal? Agreement_ID,
            decimal? Person_ID, DateTime? Package_StartDate, DateTime? Package_StartDate2,bool isComplex)
		{
			//@ 

			MyRefresh();
			//#

            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_offices);

            if(isComplex)
                Input.Add(AllFunctions._IdData.Package_Status, null);
			
            if (!string.IsNullOrEmpty(Office_Name))
			{
				// ItemsPublic.Exeptor(ItemsPublic._errOffice_NameCantEmpty);
				Input.Add(AllFunctions._IdData.Office_Name, Office_Name.Trim());
			}

            if (Agreement_ID != null)
            {
                Input.Add(AllFunctions._IdData.Agreement_ID, Agreement_ID);
            }

            if (Person_ID != null)
            {
                Input.Add(AllFunctions._IdData.Person_ID, Person_ID);
            }

            if (Package_StartDate != null)
            {
                Input.Add(AllFunctions._IdData.Package_StartDate, Package_StartDate);
            }
            if (Package_StartDate2 != null)
            {
                Input.Add(AllFunctions._IdData.Package_StartDate2, Package_StartDate2);
            }
			//&

			MyPolice.View_offices(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		//public OutputDatas View_officeDetail()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_officeDetail);
		//    //&

		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}
		//private bool aaaaa()
		//{
		//    OutputDatas ddd = new OutputDatas();

		//    ddd.success = true;
		//    ddd.ResultTable = null;
		//    return true;
		//}
		private OutputDatas BaridInfo_ViewAllUsers3()
		{
			OutputDatas results = new OutputDatas();

			try
			{
				IParticipantFacade ipar = DirectoryProxyFactory.NewParticipantFacade();
				DataTable dt = ipar.Find(UserContext.TicketID, false, "1", "1").DataSet.Tables[0];


				IUserFacade iusers = DirectoryProxyFactory.NewUserFacade();
				UserList users = iusers.GetAllUsers(UserContext.TicketID);
				var result = from d in users.DataSet.Tables[0].AsEnumerable()
				             join a in dt.AsEnumerable() on d.Field<decimal>("ID") equals a.Field<decimal>("PersonID") into SS
				             from a in SS.DefaultIfEmpty()
				             select new
				                    	{
				                    		PersonName = a.Field<string>("PersonName"),
				                    		PersonID = a.Field<decimal>("PersonID"),
				                    		ParticipantString = a.Field<string>("DisplayString"),
				                    		PersonUserName = d.Field<string>("UserName")
				                    	};
				DataTable z = new DataTable();
				z.Columns.Add("BaridName");
				z.Columns.Add("BaridJob");
				z.Columns.Add("BaridUserCode");
				z.Columns.Add("Operator_BaridId");
				foreach (var item in result)
				{
					z.Rows.Add(item.PersonName, item.ParticipantString, item.PersonUserName, item.PersonID);
				}
				results.ResultTable = z;
				results.success = true;
			}
			catch (Exception ex)
			{
				results.success = false;
				results.Message = ex.Message;
			}
			return results;
		}

		public DataTable BaridInfo_ViewAllUsers()
		{
			DataTable results = new DataTable();
			//results.success = true;
			///resultsTable = null;
			//return results;
			try
			{
				IParticipantFacade ipar = DirectoryProxyFactory.NewParticipantFacade();
				DataTable dt = ipar.Find(UserContext.TicketID, false, "1", "1").DataSet.Tables[0];

				IUserFacade iusers = DirectoryProxyFactory.NewUserFacade();
				UserList users = iusers.GetAllUsers(UserContext.TicketID);
				var result = from d in users.DataSet.Tables[0].AsEnumerable()
				             join a in dt.AsEnumerable() on d.Field<decimal>("ID") equals a.Field<decimal>("PersonID") into SS
				             from a in SS.DefaultIfEmpty()
				             select new
				                    	{
				                    		PersonName = a.Field<string>("PersonName"),
				                    		PersonID = a.Field<decimal>("PersonID"),
				                    		ParticipantString = a.Field<string>("DisplayString"),
				                    		PersonUserName = d.Field<string>("UserName")
				                    	};
				DataTable z = new DataTable();
				z.Columns.Add("BaridName");
				z.Columns.Add("BaridJob");
				z.Columns.Add("BaridUserCode");
				z.Columns.Add("Operator_BaridId", typeof (decimal));

				foreach (var item in result)
				{
                    //if (z.AsEnumerable().Where(x => x.Field<decimal>("Operator_BaridId") == item.PersonID).Count() > 0)
                    //{
                    //    (z.AsEnumerable().Single(x => x.Field<decimal>("Operator_BaridId") == item.PersonID)).Field<string>("");
                    //        //+= "\r\n" + item.ParticipantString;
                    //}
                    //else
                    //{
                    //    z.Rows.Add(item.PersonName, item.ParticipantString, item.PersonUserName, item.PersonID);
                    //}

                    z.Rows.Add(item.PersonName, item.ParticipantString, item.PersonUserName, item.PersonID);
				}
				results = z;
				// results.success = true;
			}
			catch (Exception ex)
			{
				//  results.success = false;
				//  results.Message = ex.Message;
				ItemsPublic.Exeptor(ex.Message);
			}
			return results;
		}

		private DataTable setOperBarid(ref OutputDatas odServer)
		{
            if (ItemsPublic.AllUserBarid == null)
            {
                ItemsPublic.AllUserBarid = BaridInfo_ViewAllUsers();
            }else if (ItemsPublic.AllUserBarid.Rows.Count <1)
            {
                ItemsPublic.AllUserBarid = BaridInfo_ViewAllUsers();
            }

			var odBarid = ItemsPublic.AllUserBarid;
			var myQuery = from dtS in odServer.ResultTable.AsEnumerable()
			              join dtB in odBarid.AsEnumerable() on dtS.Field<decimal>("Operator_BaridId") equals
			              	dtB.Field<decimal>("Operator_BaridId")
			              select new
			                     	{
			                     		#region Create Fields
			                     		BaridName = dtB["BaridName"],
			                     		BaridJob = dtB["BaridJob"],
			                     		BaridUserCode = dtB["BaridUserCode"],
			                     		OfficeOperators_Id = dtS["OfficeOperators_Id"],			                     		
			                     		Office_Name = dtS["Office_Name"],
			                     		Operator_BaridId = dtS["Operator_BaridId"],
			                     		Operator_Active = dtS["Operator_Active"],
			                     		Operator_Tellphone1 = dtS["Operator_Tellphone1"],
			                     		Operator_Tellphone2 = dtS["Operator_Tellphone2"],
			                     		Operator_Hidden = dtS["Operator_Hidden"],
			                     		Office_ID = dtS["Office_ID"],
			                     		Operator_ID = dtS["Operator_ID"],
			                     		Sign_DateExpire = dtS["Sign_DateExpire"],
			                     		Sign_DateStart = dtS["Sign_DateStart"],
			                     		Sign_Shape = dtS["Sign_Shape"],
			                     		Sign_Allowed = dtS["Sign_Allowed"]
			                     		#endregion
			                     	};

			var tempTable = new DataTable();
			tempTable.Columns.Add("BaridName", typeof (string));
			tempTable.Columns.Add("BaridJob", typeof (string));
			tempTable.Columns.Add("BaridUserCode", typeof (string));
			tempTable.Columns.Add("OfficeOperators_Id", typeof (decimal));
			//tempTable.Columns.Add("Group_Name", typeof (string));
			tempTable.Columns.Add("Office_Name", typeof (string));
			tempTable.Columns.Add("Operator_BaridId", typeof (decimal));
			tempTable.Columns.Add("Operator_Active", typeof (bool));
			tempTable.Columns.Add("Operator_Tellphone1", typeof (decimal));
			tempTable.Columns.Add("Operator_Tellphone2", typeof (decimal));
			tempTable.Columns.Add("Operator_Hidden", typeof (bool));
			tempTable.Columns.Add("Office_ID", typeof (int));
			//tempTable.Columns.Add("Group_ID", typeof (int));
			tempTable.Columns.Add("Operator_ID", typeof (int));
			tempTable.Columns.Add("Sign_DateExpire", typeof (DateTime));
			tempTable.Columns.Add("Sign_DateStart", typeof (DateTime));
			tempTable.Columns.Add("Sign_Shape", typeof (byte[]));
			tempTable.Columns.Add("Sign_Allowed", typeof (bool));
            bool lump = true;
			foreach (var item in myQuery)
			{

                lump = true;
                foreach (DataRow obj in tempTable.Rows)
                {
                    if ((decimal)obj["Operator_BaridId"] == (decimal)item.Operator_BaridId && (string)obj["Office_Name"] == (string)item.Office_Name)
                    {
                        obj["BaridJob"] += "\r\n"+"و"+" " + item.BaridJob.ToString();
                        lump = false;
                        break;
                    }
                }

                if (lump)
				tempTable.Rows.Add(item.BaridName, item.BaridJob, item.BaridUserCode, item.OfficeOperators_Id,				                   
				                   item.Office_Name, item.Operator_BaridId, item.Operator_Active,
				                   item.Operator_Tellphone1,
				                   item.Operator_Tellphone2, item.Operator_Hidden, item.Office_ID,
				                   item.Operator_ID, item.Sign_DateExpire, item.Sign_DateStart, item.Sign_Shape,
				                   item.Sign_Allowed);
			}
			return tempTable;
		}

        public OutputDatas View_operators(bool? Operator_Active, string BaridName, string Office_Name)
		{
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_operators);
			//&
			if (Operator_Active != null)
				Input.Add(AllFunctions._IdData.Operator_Active, Operator_Active);

            if (!string.IsNullOrEmpty(BaridName))
            {
                Input.Add(AllFunctions._IdData.Operator_Name, BaridName.Trim());
            }

            if (!string.IsNullOrEmpty(Office_Name))
            {
                Input.Add(AllFunctions._IdData.Office_Name, Office_Name.Trim());
            }

			MyPolice.View_operators(ref Input);
			var odServer = ICustomer.Suit(Serialize.BinarySerialize(Input));
			//  DataTable dtt = odServer.ResultTable;


			if (odServer.success)
			{

				odServer.ResultTable = setOperBarid(ref odServer);                
			}




			return odServer;

			//%

			//$
		}
        public OutputDatas MyConfirmers(bool? isCurrentOff)
		{

			//@ 
			MyRefresh();
			//#
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.MyConfirmers);
			//&
			if(isCurrentOff!=null)
                Input.Add(AllFunctions._IdData.Office_Active, isCurrentOff);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));

			//  DataTable dtt = odServer.ResultTable;
            //if (odServer.success)
            //{

            //    odServer.ResultTable = setOperBarid(ref odServer);
            //}


			//return odServer;

			//%

			//$
		}

        public OutputDatas MyTypesPack(bool? isGp)
        {

            //@ 
            MyRefresh();
            //#
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.MyTypesPack);
            //&
            if (isGp != null)
                Input.Add(AllFunctions._IdData.Group_IsActive, isGp);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));

            //  DataTable dtt = odServer.ResultTable;
            //if (odServer.success)
            //{

            //    odServer.ResultTable = setOperBarid(ref odServer);
            //}


            //return odServer;

            //%

            //$
        }
        
		//public OutputDatas View_operatorDetail()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_operatorDetail);
		//    //&
		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

        public OutputDatas View_agreements
    (Nullable<DateTime> Agreement_StartDate,
     Nullable<DateTime> Agreement_StartDate2,
     Nullable<DateTime> Agreement_EndDate,
     Nullable<DateTime> Agreement_EndDate2,
     string Agreement_ManagerName,
     string Agreement_AgentName,
     string Agreement_Company,
     bool? Agreement_IsIndustrial,
     string Agreement_Number)
        {
      return View_agreementsComplex( Agreement_StartDate,
      Agreement_StartDate2,
      Agreement_EndDate,
      Agreement_EndDate2,
      Agreement_ManagerName,
      Agreement_AgentName,
      Agreement_Company,
      Agreement_IsIndustrial,
      Agreement_Number,null,null,null,null,null,null);
        }
		public OutputDatas View_agreementsComplex
			(Nullable<DateTime> Agreement_StartDate,
			 Nullable<DateTime> Agreement_StartDate2,
			 Nullable<DateTime> Agreement_EndDate,
			 Nullable<DateTime> Agreement_EndDate2,
			 string Agreement_ManagerName,
			 string Agreement_AgentName,
			 string Agreement_Company,
			 bool? Agreement_IsIndustrial,
			 string Agreement_Number,
            decimal? Vehicle_ID,
            int? Office_ID,
            decimal? Person_ID,
            DateTime?    Package_StartDate,
            DateTime?    Package_StartDate2,
            bool? IsReport
            )
		{
			//@
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_agreements);
			if (!string.IsNullOrEmpty(Agreement_Number) && Agreement_Number.Trim() != "0")
			{
				Input.Add(AllFunctions._IdData.Agreement_Number, Agreement_Number);
			}
			if (!string.IsNullOrEmpty(Agreement_ManagerName))
			{
				Input.Add(AllFunctions._IdData.Agreement_ManagerName, Agreement_ManagerName);
			}
			if (!string.IsNullOrEmpty(Agreement_AgentName))
			{
				Input.Add(AllFunctions._IdData.Agreement_AgentName, Agreement_AgentName);
			}
			if (!string.IsNullOrEmpty(Agreement_Company))
			{
				Input.Add(AllFunctions._IdData.Agreement_Company, Agreement_Company);
			}
			if (Agreement_IsIndustrial != null)
			{
				Input.Add(AllFunctions._IdData.Agreement_IsIndustrial, Agreement_IsIndustrial);
			}
			if (Agreement_StartDate != null)
			{
				Input.Add(AllFunctions._IdData.Agreement_StartDate, Agreement_StartDate);
			}
			if (Agreement_StartDate2 != null)
			{
				Input.Add(AllFunctions._IdData.Agreement_StartDate2, Agreement_StartDate2);
			}
			if (Agreement_EndDate != null)
			{
				Input.Add(AllFunctions._IdData.Agreement_EndDate, Agreement_EndDate);
			}
			if (Agreement_EndDate2 != null)
			{
				Input.Add(AllFunctions._IdData.Agreement_EndDate2, Agreement_EndDate2);
			}

            if (Vehicle_ID != null)
            {
                Input.Add(AllFunctions._IdData.Vehicle_ID, Vehicle_ID);
            }

            if (Office_ID != null)
            {
                Input.Add(AllFunctions._IdData.Office_ID, Office_ID);
            }

            if (Person_ID != null)
            {
                Input.Add(AllFunctions._IdData.Person_ID, Person_ID);
            }

            if (Package_StartDate != null)
            {
                Input.Add(AllFunctions._IdData.Package_StartDate, Package_StartDate);
            }
            if (Package_StartDate2 != null)
            {
                Input.Add(AllFunctions._IdData.Package_StartDate2, Package_StartDate2);
            }

            if (IsReport != null)
            {
                Input.Add(AllFunctions._IdData.Package_Status, IsReport);
            }
            
			//&
			MyPolice.View_agreements(ref Input);
			OutputDatas os = ICustomer.Suit(Serialize.BinarySerialize(Input));
			//  SetAgreeIndustrialText(ref os);
			return os;
			//%
			//$
		}

		//public OutputDatas View_agreementDetail(decimal Agreement_Number)
		//{
		//    //@
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_agreementDetail);
		//    Input.Add(AllFunctions._IdData.Agreement_Number, Agreement_Number);
		//    //&
		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

        public OutputDatas View_vehicles(int? VehicleType_ID, int? TypePlates_Id, string Vehicle_number, int? Vehicle_IndexIsCompany, string Vehicle_Model)
        {
            return View_vehiclesComplex(VehicleType_ID, TypePlates_Id, Vehicle_number, Vehicle_IndexIsCompany, Vehicle_Model,null,null,null,null,null);
        }
        public OutputDatas View_vehiclesComplex(int? VehicleType_ID, int? TypePlates_Id
            , string Vehicle_number, int? Vehicle_IndexIsCompany, string Vehicle_Model
            , decimal? Person_ID, decimal? Agreement_ID, int? Office_ID
            , DateTime? Package_StartDate,DateTime? Package_StartDate2)
		{
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_vehicles);

            if (TypePlates_Id !=null )
            {
                if(TypePlates_Id!=-1)
                Input.Add(AllFunctions._IdData.TypePlates_Id, TypePlates_Id);
            }

			if (VehicleType_ID != null)
			{
                if (VehicleType_ID != -1)
				Input.Add(AllFunctions._IdData.VehicleType_ID, VehicleType_ID);
			}
			if (!string.IsNullOrEmpty(Vehicle_number))
			{
				Input.Add(AllFunctions._IdData.Vehicle_number, Vehicle_number);
			}


            if (!string.IsNullOrEmpty(Vehicle_Model))
			{
				Input.Add(AllFunctions._IdData.Vehicle_Model, Vehicle_Model);
			}


            if (Vehicle_IndexIsCompany !=null)
            {
                if (Vehicle_IndexIsCompany != -1)
                    Input.Add(AllFunctions._IdData.Vehicle_IsCompany, Vehicle_IndexIsCompany==0?true:false);
            }


            if (Person_ID != null)
            {
                Input.Add(AllFunctions._IdData.Person_ID, Person_ID);
            }
            if (Agreement_ID != null)
            {
                Input.Add(AllFunctions._IdData.Agreement_ID, Agreement_ID);
            }
            if (Office_ID != null)
            {
                Input.Add(AllFunctions._IdData.Office_ID, Office_ID);
            }

            if (Package_StartDate != null)
            {
                Input.Add(AllFunctions._IdData.Package_StartDate, Package_StartDate);
            }
            if (Package_StartDate2 != null)
            {
                Input.Add(AllFunctions._IdData.Package_StartDate2, Package_StartDate2);
            }

			//&
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%
			//$
		}

        public OutputDatas View_vehiclesListPersons(DataTable GpPersonCarList)
        {
            // vehiclesListPersons

            if (GpPersonCarList.Rows.Count < 1)
            {
                ItemsPublic.Exeptor("هیچ شخصی انتخاب نشده است");
            } //@ 

            //@ 
            MyRefresh();
            //#

            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.vehiclesListPersons);

            Input.Add(AllFunctions._IdData.GpPersonCarList, GpPersonCarList);

            return ICustomer.Suit(Serialize.BinarySerialize(Input));

        }

		public OutputDatas View_vehiclesType(bool? VehicleType_Hidden, string VehicleType_Name)
		{
			//@ 
			MyRefresh();
            //AllFunctions._IdData.VehicleType_Name
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_vehiclesType);
			if (VehicleType_Hidden != null)
				Input.Add(AllFunctions._IdData.VehicleType_Hidden, VehicleType_Hidden);

            if (!string.IsNullOrEmpty(VehicleType_Name))
                Input.Add(AllFunctions._IdData.VehicleType_Name, VehicleType_Name);


			//&
			MyPolice.View_vehiclesType(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		//public OutputDatas View_vehicleDetail()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_vehicleDetail);
		//    //&
		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

		public OutputDatas View_travelAreas(string TravelArea_Name)
		{

			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_travelAreas);
			if (!string.IsNullOrEmpty(TravelArea_Name))
				Input.Add(AllFunctions._IdData.TravelArea_Name, TravelArea_Name);
			//&
			MyPolice.View_travelAreas(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		//public OutputDatas View_travelAreaDetail()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_travelAreaDetail);
		//    //&
		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

		public OutputDatas View_gatePasses(decimal? package_Id)
		{
			//@ 
			if (package_Id == null)
			{
				ItemsPublic.Exeptor("آیدی بسته یافت نشد");
			}
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_gatePasses);

			Input.Add(AllFunctions._IdData.package_Id, package_Id);
			//&
			var odServer =  ICustomer.Suit ( Serialize.BinarySerialize ( Input ) );
			if ( odServer.success )
			{
				var odServer2 = new DataTable ();
				odServer2 = odServer.ResultTable;
				//odServer2.Columns ["Package_TicketId"].ReadOnly = false;
				foreach ( DataRow item in odServer2.Rows )
				{
					//item.SetField("GatePass_TicketId",  ConvertNumbers.Int64ToBase36 ( Int64.Parse ( item ["Gatepass_ID"].ToString () ) ));
					item ["GatePass_TicketId"] = ConvertNumbers.Int64ToBase36 ( Int64.Parse ( item ["Gatepass_ID"].ToString () ) );
				}

				odServer.ResultTable = odServer2;
			}
			return odServer;
			//%

			//$
		}

		public OutputDatas View_gatePasseDetail()
		{
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_gatePasseDetail);
			//&
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		public OutputDatas View_packages( bool? Package_IsExpired , AllFunctions._StatusPack? Status 
		, decimal? Agreement_Number , int? Office_ID , DateTime? Package_StartDate , DateTime? Package_StartDate2 
		, DateTime? Package_EndDate , DateTime? Package_EndDate2 , int? Package_OperIdRequest , int? Package_OperIdConfirm
        , int? Package_OperIdPassage, string Person_NationalCode, string package_Id, string Gatepass_ID, int? Package_GatesIdCombo, int? GatePass_IntPrint, int? statePackForView)
		{
			//if (OfficeOperators_Id == null)
			//{
			//    ItemsPublic.Exeptor("سطح دسترسی نامشخص");
			//}
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_packages);

			//   Input.Add(AllFunctions._IdData.OfficeOperators_Id, OfficeOperators_Id);
			if (Package_IsExpired != null)
			{
				Input.Add(AllFunctions._IdData.Package_IsExpired, Package_IsExpired);
			}
			else
			{
				Input.Add(AllFunctions._IdData.Package_IsExpired, false);
			}
            if (Package_GatesIdCombo != null)
                Input.Add(AllFunctions._IdData.Package_GatesIdCombo, Package_GatesIdCombo);
			if (Agreement_Number != null)
				Input.Add(AllFunctions._IdData.Agreement_Number, Agreement_Number);
			if (Office_ID != null)
				Input.Add(AllFunctions._IdData.Office_ID, Office_ID);
			if (Package_StartDate != null)
				Input.Add(AllFunctions._IdData.Package_StartDate, Package_StartDate);
			if (Package_StartDate2 != null)
				Input.Add(AllFunctions._IdData.Package_StartDate2, Package_StartDate2);
			if (Package_EndDate != null)
				Input.Add(AllFunctions._IdData.Package_EndDate, Package_EndDate);
			if (Package_EndDate2 != null)
				Input.Add(AllFunctions._IdData.Package_EndDate2, Package_EndDate2);
			if (Package_OperIdRequest != null)
				Input.Add(AllFunctions._IdData.Package_OperIdRequest, Package_OperIdRequest);
			if (Package_OperIdConfirm != null)
				Input.Add(AllFunctions._IdData.Package_OperIdConfirm, Package_OperIdConfirm);
			if (Package_OperIdPassage != null)
				Input.Add(AllFunctions._IdData.Package_OperIdPassage, Package_OperIdPassage);
			  
			if (!string.IsNullOrEmpty(Person_NationalCode))
				Input.Add(AllFunctions._IdData.Person_NationalCode, Person_NationalCode);

			if ( !string.IsNullOrEmpty ( package_Id ) )
				Input.Add ( AllFunctions._IdData.package_Id , package_Id );

			if ( !string.IsNullOrEmpty ( Gatepass_ID ) )
				Input.Add ( AllFunctions._IdData.Gatepass_ID , Gatepass_ID );

			if ( Status !=null)
				Input.Add ( AllFunctions._IdData.Package_Status , Status );

            if(GatePass_IntPrint!=null)
                Input.Add(AllFunctions._IdData.GatePass_IntPrint, GatePass_IntPrint);
			//&
          //  statePackForView
                if(statePackForView!=null)
                Input.Add(AllFunctions._IdData.statePackForView, statePackForView);

			var odServer = ICustomer.Suit(Serialize.BinarySerialize(Input));
			if (odServer.success)
			{
				var odServer2 = new DataTable ();
				odServer2 = odServer.ResultTable;
				//odServer2.Columns ["Package_TicketId"].ReadOnly = false;
				foreach ( DataRow item in odServer2.Rows )
				{
					//item.SetField("Package_TicketId", ConvertNumbers.Int64ToBase36(Int64.Parse(item["package_Id"].ToString())));
					item["Package_TicketId"] = ConvertNumbers.Int64ToBase36 ( Int64.Parse ( item ["package_Id"].ToString() ) );
			    	//	MessageBox.Show ( item ["Package_TicketId"].ToString () );
				}
				odServer.ResultTable = odServer2;
			}
			return odServer;
			//%

			//$
		}

		public OutputDatas View_packageDetail()
		{
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_packageDetail);
			//&
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

        public OutputDatas View_persons(
            bool? Person_isWoman,
            bool? Person_HaveForm,
            bool? Person_Picture,
            bool? BlackList_isBlack,
            string Person_Name,
            string Person_Surname,
            string Person_NationalCode,
            string Person_IdentifyCode,
            string Person_LicenseDriverCode,
            string Person_RegisterCode,
            string Person_SmartFind)
        {
            return View_personsComplex(
             Person_isWoman,
             Person_HaveForm,
             Person_Picture,
             BlackList_isBlack,
             Person_Name,
             Person_Surname,
             Person_NationalCode,
             Person_IdentifyCode,
             Person_LicenseDriverCode,
             Person_RegisterCode,
             Person_SmartFind,null,null,null,null,null,null);
        }

		public OutputDatas View_personsComplex(
			bool? Person_isWoman,
			bool? Person_HaveForm,
			bool? Person_Picture,
			bool? BlackList_isBlack,
			string Person_Name,
			string Person_Surname,
			string Person_NationalCode,
            string Person_IdentifyCode,
            string Person_LicenseDriverCode,
            string Person_RegisterCode,
			string Person_SmartFind,
            decimal? Vehicle_ID,
            int? Office_ID,
            decimal? Agreement_ID,
            int? TravelArea_Id,
            DateTime? Package_StartDate,
            DateTime? Package_StartDate2
            )
		{
			//@ 
			MyRefresh();
			//#
         
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_persons);
            
			if (!string.IsNullOrEmpty(Person_SmartFind))
				Input.Add(AllFunctions._IdData.Person_SmartFind, Person_SmartFind);

			if (Person_isWoman != null)
				Input.Add(AllFunctions._IdData.Person_isWoman, Person_isWoman);

			if (Person_HaveForm != null)
				Input.Add(AllFunctions._IdData.Person_HaveForm, Person_HaveForm);

			if (Person_Picture != null)
			{
				if (Person_Picture == false)
				{
					Input.Add(AllFunctions._IdData.Person_Picture, null);
				}
				else
				{
					var temp = new byte[1] {1};
					Input.Add(AllFunctions._IdData.Person_Picture, temp);
				}
			}
			if (BlackList_isBlack != null)
				Input.Add(AllFunctions._IdData.BlackList_isBlack, BlackList_isBlack);

			if (!String.IsNullOrEmpty(Person_Name))
				Input.Add(AllFunctions._IdData.Person_Name, Person_Name);

			if (!String.IsNullOrEmpty(Person_Surname))
				Input.Add(AllFunctions._IdData.Person_Surname, Person_Surname);

            if (!String.IsNullOrEmpty(Person_NationalCode) && !Person_NationalCode.Contains('-'))
            {
            Person_NationalCode =    Person_NationalCode.Replace("\r\n", "");
                Input.Add(AllFunctions._IdData.Person_NationalCode, Person_NationalCode);
            }


            if (!String.IsNullOrEmpty(Person_IdentifyCode) && !Person_IdentifyCode.Contains('-'))
            {
                Person_IdentifyCode = Person_IdentifyCode.Replace("\r\n", "");
                Input.Add(AllFunctions._IdData.Person_IdentifyCode, Person_IdentifyCode);
            }

            if (!String.IsNullOrEmpty(Person_LicenseDriverCode) && !Person_LicenseDriverCode.Contains('-'))
            {
                Person_LicenseDriverCode = Person_LicenseDriverCode.Replace("\r\n", "");
                Input.Add(AllFunctions._IdData.Person_LicenseDriverCode, Person_LicenseDriverCode);
            }

            if (!String.IsNullOrEmpty(Person_RegisterCode) && !Person_RegisterCode.Contains('-'))
            {
                Person_RegisterCode = Person_RegisterCode.Replace("\r\n", "");
                Input.Add(AllFunctions._IdData.Person_RegisterCode, Person_RegisterCode);
            }



            if (Vehicle_ID != null)
            {
                Input.Add(AllFunctions._IdData.Vehicle_ID, Vehicle_ID);
            }

            if (Office_ID != null)
            {
                Input.Add(AllFunctions._IdData.Office_ID, Office_ID);
            }

            if (Agreement_ID != null)
            {
                Input.Add(AllFunctions._IdData.Agreement_ID, Agreement_ID);
            }

            if (TravelArea_Id != null)
            {
                Input.Add(AllFunctions._IdData.TravelArea_Id, TravelArea_Id);
            }

            if (Package_StartDate != null)
            {
                Input.Add(AllFunctions._IdData.Package_StartDate, Package_StartDate);
            }
            if (Package_StartDate2 != null)
            {
                Input.Add(AllFunctions._IdData.Package_StartDate2, Package_StartDate2);
            }
			//&
			MyPolice.View_persons(ref Input);
           // OutputDatas dtr = new OutputDatas();
            return ICustomer.Suit(Serialize.BinarySerialize(Input));

         //   MessageBox.Show(dtr.ResultTable.Rows.Count.ToString());

          //  return dtr;
			//%

			//$
		}

		//public OutputDatas View_personDetail()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_personDetail);
		//    //&
		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}


		public OutputDatas View_bLreasons(string BLReason_Type)
		{
			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_bLreasons);
			if (!string.IsNullOrEmpty(BLReason_Type))
				Input.Add(AllFunctions._IdData.BLReason_Type, BLReason_Type);
			//&
			MyPolice.View_bLreasons(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		//public OutputDatas View_bLreasonDetail()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_bLreasonDetail);
		//    //&

		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

		public OutputDatas View_blackLists( decimal? Person_ID )
		{

			//@ 
			MyRefresh();
			//#
			Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_blackLists);
			if ( Person_ID != null )
			{
				Input.Add ( AllFunctions._IdData.Person_ID , Person_ID );
		}
			//&
			MyPolice.View_blackLists(ref Input);
			return ICustomer.Suit(Serialize.BinarySerialize(Input));
			//%

			//$
		}

		//public OutputDatas View_blackListDetail()
		//{
		//    //@ 
		//    MyRefresh();
		//    //#
		//    Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_blackListDetail);
		//    //&
		//    return ICustomer.Suit(Serialize.BinarySerialize(Input));
		//    //%

		//    //$
		//}

		#endregion

		//-*+
			
		public OutputDatas View_Nationalities()
		{
			//@ 
			MyRefresh ();
			//#
			Input.Add ( AllFunctions._IdData.IdMethod , AllFunctions._IdMethod.View_Nationalities );
			//&
		//	MyPolice.View_Nationalities ( ref Input );
			return ICustomer.Suit ( Serialize.BinarySerialize ( Input ) );
			//%

			//$
		}

		public OutputDatas View_Cities()
		{
			//@ 
			MyRefresh ();
			//#
			Input.Add ( AllFunctions._IdData.IdMethod , AllFunctions._IdMethod.View_Cities );
			//&
			//	MyPolice.View_Nationalities ( ref Input );
			return ICustomer.Suit ( Serialize.BinarySerialize ( Input ) );
			//%

			//$
		}

		public OutputDatas ClsLocations_Nationality_insert( string Nationality_Name )
		{
			if ( string.IsNullOrEmpty ( Nationality_Name ) )
			{
				ItemsPublic.Exeptor ( "تابعیت جدید نامی ندارد" );
			}
			//@ 
			MyRefresh ();
			//#
			Input.Add ( AllFunctions._IdData.IdMethod , AllFunctions._IdMethod.ClsLocations_Nationality_insert );
			Input.Add ( AllFunctions._IdData.Nationality_Name , Nationality_Name );
			//&
			MyPolice.ClsLocations_Nationality_insert ( ref Input );
			return ICustomer.Suit ( Serialize.BinarySerialize ( Input ) );
			//%

			//$
		}

		public OutputDatas ClsLocations_City_insert( String City_Name )
		{
			if ( string.IsNullOrEmpty ( City_Name ) )
			{
				ItemsPublic.Exeptor ( "شهر جدید نامی ندارد" );
			}
			//@ 
			MyRefresh ();
			//#
			Input.Add ( AllFunctions._IdData.IdMethod , AllFunctions._IdMethod.ClsLocations_City_insert );
			Input.Add ( AllFunctions._IdData.City_Name , City_Name );
			//&
			MyPolice.ClsLocations_City_insert ( ref Input );
			return ICustomer.Suit ( Serialize.BinarySerialize ( Input ) );
			//%

			//$
		}

		public OutputDatas View_Gates(decimal? packId )
		{
			
			MyRefresh ();
			//#
			if ( packId !=null)
			{
				Input.Add(AllFunctions._IdData.package_Id, packId);
			}
			Input.Add ( AllFunctions._IdData.IdMethod , AllFunctions._IdMethod.View_Gates );
			//Input.Add ( AllFunctions._IdData.City_Name , City_Name );
			//&
			//MyPolice.vi ( ref Input );
			return ICustomer.Suit ( Serialize.BinarySerialize ( Input ) );
			//%

			//$
		}

		public OutputDatas View_Places( decimal? packId )
		{

			MyRefresh ();
			//#
			if ( packId !=null )
			{
				Input.Add ( AllFunctions._IdData.package_Id , packId );
			}
			Input.Add ( AllFunctions._IdData.IdMethod , AllFunctions._IdMethod.View_Places );
			//Input.Add ( AllFunctions._IdData.City_Name , City_Name );
			//&
			//MyPolice.vi ( ref Input );
			return ICustomer.Suit ( Serialize.BinarySerialize ( Input ) );
			//%

			//$
		}

        public OutputDatas ReportInOut(
            decimal? Person_ID,
             decimal? Vehicle_ID,
             decimal? Gatepass_ID,
            DateTime? Package_StartDate,
            DateTime? Package_StartDate2 
            )
        {
            MyRefresh();

            if (Person_ID != null)
                Input.Add(AllFunctions._IdData.Person_ID, Person_ID);
            if (Vehicle_ID != null)
                Input.Add(AllFunctions._IdData.Vehicle_ID, Vehicle_ID);

            if (Gatepass_ID != null)
                Input.Add(AllFunctions._IdData.Gatepass_ID, Gatepass_ID);

            if (Package_StartDate != null)
                Input.Add(AllFunctions._IdData.Package_StartDate, Package_StartDate);
            if (Package_StartDate2 != null)
                Input.Add(AllFunctions._IdData.Package_StartDate2, Package_StartDate2);
           
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ReportInOut);

            MyPolice.ReportInOut(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
        }

        public OutputDatas FindJustArchive(
             string Gatepass_ID
            )
        {
            MyRefresh();
         //   ItemsPublic.Exeptor ( "شهر جدید نامی ندارد" );
           
            if (!string.IsNullOrEmpty(Gatepass_ID)){
                Input.Add(AllFunctions._IdData.Gatepass_ID, Gatepass_ID);
            }else
            {
                ItemsPublic.Exeptor ( "مقداری جهت یافتن آرشیو یافت نشد" );
            }
            
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.FindJustArchive);

            MyPolice.ReportInOut(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
        }



        public OutputDatas ReportGp(
            decimal? Agreement_ID,
            int? Office_ID,
            int? TravelArea_Id,
            decimal? Person_ID,
            decimal? Vehicle_ID,
            int? Package_OperIdRequest,
            int? Package_OperIdConfirm,
            int? Package_OperIdPassage,
            int? GatePass_IntPrint,
            int? TypePack_Id,
            DateTime? Package_StartDate,
            DateTime? Package_StartDate2            
            )
        {
            MyRefresh();

            //#

            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ReportGP);

            //if (!string.IsNullOrEmpty())
            //    Input.Add(AllFunctions._IdData, );

            //if ( != null)
            //    Input.Add(AllFunctions._IdData., );

            if (GatePass_IntPrint == null)
            {
                ItemsPublic.Exeptor("مقدار ورودی جهت تعداد چاپ نامشخص می باشد");
            }
            if (TypePack_Id == null)
            {
                ItemsPublic.Exeptor("مقدار ورودی جهت نوع بسته نامشخص می باشد");
            }


            if ( Agreement_ID != null)
                Input.Add(AllFunctions._IdData.Agreement_ID,Agreement_ID );

             if ( Office_ID != null)
                Input.Add(AllFunctions._IdData.Office_ID,Office_ID );
             if (TravelArea_Id != null)
                Input.Add(AllFunctions._IdData.TravelArea_Id,TravelArea_Id );
             if (Person_ID != null)
                Input.Add(AllFunctions._IdData.Person_ID,Person_ID );
             if (Vehicle_ID != null)
                Input.Add(AllFunctions._IdData.Vehicle_ID, Vehicle_ID);
             if (Package_OperIdRequest != null)
                Input.Add(AllFunctions._IdData.Package_OperIdRequest,Package_OperIdRequest );
             if (Package_OperIdConfirm != null)
                Input.Add(AllFunctions._IdData.Package_OperIdConfirm, Package_OperIdConfirm);
             if (Package_OperIdPassage != null)
                Input.Add(AllFunctions._IdData.Package_OperIdPassage,Package_OperIdPassage );
             if ( GatePass_IntPrint != -1)
                Input.Add(AllFunctions._IdData.GatePass_IntPrint,GatePass_IntPrint );
             if (TypePack_Id != -1)
                Input.Add(AllFunctions._IdData.TypePack_Id,TypePack_Id );
             if (Package_StartDate != null)
                Input.Add(AllFunctions._IdData.Package_StartDate,Package_StartDate );
             if (Package_StartDate2 != null)
                Input.Add(AllFunctions._IdData.Package_StartDate2,Package_StartDate2 );

            MyPolice.View_persons(ref Input);

            var odServer = ICustomer.Suit(Serialize.BinarySerialize(Input));
            if (odServer.success)
            {
                var odServer2 = new DataTable();
                odServer2 = odServer.ResultTable;
                //odServer2.Columns ["Package_TicketId"].ReadOnly = false;
                foreach (DataRow item in odServer2.Rows)
                {
                    //item.SetField("GatePass_TicketId",  ConvertNumbers.Int64ToBase36 ( Int64.Parse ( item ["Gatepass_ID"].ToString () ) ));
                    item["GatePass_TicketId"] = ConvertNumbers.Int64ToBase36(Int64.Parse(item["Gatepass_ID"].ToString()));
                    item["Package_TicketId"] = ConvertNumbers.Int64ToBase36(Int64.Parse(item["package_Id"].ToString()));
                }

                odServer.ResultTable = new DataTable();
                odServer.ResultTable  =odServer2;
            }
            return odServer;



        }

        public OutputDatas UpdateTag(decimal? arcId , decimal? tagId,bool isgatePassId)
        {

            MyRefresh();
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.UpdateTag);


            if (isgatePassId)
            {
               // datas.ContainsKey(_IdData.Person_ID);
                Input.Add(AllFunctions._IdData.Person_ID, null);
            }
            //if (!string.IsNullOrEmpty())
            //    Input.Add(AllFunctions._IdData, );

            //if ( != null)
            //    Input.Add(AllFunctions._IdData., );

            if (arcId == null)
            {
                ItemsPublic.Exeptor("آرشیوی مشخص نشده");
            }

            if (tagId == null)
            {
                ItemsPublic.Exeptor("تگی مشخص نشده");
            }


            Input.Add(AllFunctions._IdData.Gatepass_ID, arcId);
            Input.Add(AllFunctions._IdData.TypePack_Id, tagId);

            MyPolice.UpdateTag(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));


        }
        public OutputDatas EsiContCurrentState(ItemsPublic._EsiGate InEsigate, DateTime? LastRefreshTime, decimal seePassingCode)
        {
            MyRefresh();
            // _EsiGate
            if (LastRefreshTime!=null)
            {
                Input.Add(AllFunctions._IdData.EsiMiniGate_TimeRefresh, (DateTime)LastRefreshTime);
            }
            Input.Add(AllFunctions._IdData.EsiMiniGate_Id, (int)InEsigate);
            Input.Add(AllFunctions._IdData.GatePass_IntPrint, seePassingCode);
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.EsiContCurrentState);
      //      MyPolice.UpdateTag(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
        }
        public OutputDatas EsiContTestHard(ItemsPublic._EsiGate InEsigate, DateTime? LastRefreshTime)
        {

            MyRefresh();            
            if (LastRefreshTime != null)
            {
                Input.Add(AllFunctions._IdData.EsiMiniGate_TimeRefresh, (DateTime)LastRefreshTime);
            }
            Input.Add(AllFunctions._IdData.EsiMiniGate_Id, (int)InEsigate);
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.EsiContTestHard);
      //      MyPolice.UpdateTag(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));

        }


        internal OutputDatas EsiContTestNet(ItemsPublic._EsiGate InEsigate, DateTime? LastRefreshTime)
        {
            MyRefresh();

            if (LastRefreshTime != null)
            {
                Input.Add(AllFunctions._IdData.EsiMiniGate_TimeRefresh, (DateTime)LastRefreshTime);
            }
            Input.Add(AllFunctions._IdData.EsiMiniGate_Id, (int)InEsigate);
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.EsiContTestNet);
         //   MyPolice.UpdateTag(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));

        }

        internal OutputDatas EsiContSetNewMode(ItemsPublic._EsiGate mygate, ItemsPublic.MiniGateMainEsiMode miniGateMainEsiMode)
        {
            MyRefresh();

            Input.Add(AllFunctions._IdData.EsiMiniGate_Id, (int)mygate);

            Input.Add(AllFunctions._IdData.MiniGateMainEsiMode_Id, (int)miniGateMainEsiMode);
            
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.EsiContSetNewMode);

         //   MyPolice.UpdateTag(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
        }

        internal OutputDatas EsiContSetNewWay(ItemsPublic._EsiGate mygate, ItemsPublic.MiniGateWayEsiMode miniGateWayEsiModeIn, ItemsPublic.MiniGateWayEsiMode miniGateWayEsiModeOut)
        {
            MyRefresh();

            Input.Add(AllFunctions._IdData.EsiMiniGate_Id, (int)mygate);

            Input.Add(AllFunctions._IdData.MiniGateWayEsiMode_Id, (int)miniGateWayEsiModeIn);

            Input.Add(AllFunctions._IdData.OUTMiniGateWayEsiMode_Id, (int)miniGateWayEsiModeOut);

            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.EsiContSetNewWay);

        //    MyPolice.UpdateTag(ref Input);
            return ICustomer.Suit(Serialize.BinarySerialize(Input));
        }
    }
}

