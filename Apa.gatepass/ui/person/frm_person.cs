using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI;

namespace aorc.gatepass.ui.person
{
	public partial class frm_person : aorc.gatepass.mainForm
	{
		// private Dictionary<decimal, bool> BlackListData = new Dictionary<decimal, bool>();

		public frm_person()
		{
			InitializeComponent();
		}

		private void frm_person_Load(object sender, EventArgs e)
		{
            try
            {
                ItemsPublic.BigErr += "1";
                ItemsPublic.SetAllLocations();
                ItemsPublic.BigErr += "2";
                if (ItemsPublic.MyRights.Contains(ServerClasses.AllFunctions._Rights.View_persons))
                {
                    createCbbBlockSecure();
                }
                else
                {
                    uC_personDetails31.LimitAccess();
                }
                ItemsPublic.BigErr += "3";
                GroupingControls((Control)this);
                ItemsPublic.BigErr += "4";
                GroupingRadObjects(findRadItems());
                ItemsPublic.BigErr += "5";
                if (ItemsPublic.MyRights.Contains(ServerClasses.AllFunctions._Rights.View_persons))
                {
                    GroupingRadObjects(new RadItemCollection { cbbBlockPerson, cbbSecureForm });

                    //   loadAllData();

                    // cbbView_Click(sender, e);
                    cbbSearch_Click(null, null);
                }
                else
                {
                    cbbSearch_Click(null, null);
                }
                ItemsPublic.BigErr += "6";
                uC_personDetails31.comboBirthCity.SetAllLocations();
                ItemsPublic.BigErr += "7";
                uC_personDetails31.comboNationality.SetAllLocations();
                ItemsPublic.BigErr += "8";
                uC_personDetails31.comboRegisterCity.SetAllLocations();
                ItemsPublic.BigErr += "9";
            }catch(Exception ex){
                MessageBox.Show("ex.InnerException:= " + ex.InnerException + "\r\n\r\n" + "ex.Message:= " + ex.Message + "\r\n\r\n" + "ex.Source:= " + ex.Source + "\r\n\r\n" + "ex.StackTrace:= " + ex.StackTrace + "\r\n\r\n" + "ex.ToString():= " + ex.ToString() + "\r\n\r\n" + " ItemsPublic.BigErr:= " + ItemsPublic.BigErr);
                
            }
			//foreach ( object cntrl in myAll )
			//{
			//    if ( cntrl is RadDropDownList )
			//    {
			//        MessageBox.Show ("=>   "+ (( RadDropDownList ) cntrl).Name );
			//    }
			//}		
		}

        //private void loadAllData()
        //{
        //    BlackListData.Clear();
        //    DataTable FullPersons = new DataTable();
        //    CursorWait();
        //    result = objManager.View_persons(null, null, null, false, string.Empty, string.Empty, string.Empty, string.Empty);

        //    if (result.success)
        //    {
        //        FullPersons.Merge(result.ResultTable);
        //        foreach (DataRow item in result.ResultTable.Rows)
        //        {
        //            BlackListData.Add(decimal.Parse(item[0].ToString()), false);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show(result.Message);
        //        return;
        //    }

        //    result = objManager.View_persons(null, null, null, true, string.Empty, string.Empty, string.Empty, string.Empty);
        //    if (result.success)
        //    {
        //        FullPersons.Merge(result.ResultTable);
        //        foreach (DataRow item in result.ResultTable.Rows)
        //        {
        //            BlackListData.Add(decimal.Parse(item["Person_ID"].ToString()), true);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show(result.Message);
        //        return;
        //    }
        //    if (FullPersons.Rows.Count > 0)
        //    {
        //        radGridViewPersons.DataSource = FullPersons;
        //        radGridViewPersons.Enabled = true;
        //    }

        //    CursorDefault();
        //}

		private void menuService_ContextMenuDisplaying(object sender, ContextMenuDisplayingEventArgs e)
		{
			//the menu request is associated with a valid DockWindow instance, which resides within a DocumentTabStrip
			if (e.MenuType == ContextMenuType.DockWindow &&
			    e.DockWindow.DockTabStrip is DocumentTabStrip)
			{
				//remove the "Close" menu items
				for (int i = 0; i < e.MenuItems.Count; i++)
				{
					RadMenuItemBase menuItem = e.MenuItems[i];
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

		private void ShowPropertiesItems()
		{
			uC_personDetails31.rtbName.Text = radGridViewPersons.SelectedRows[0].Cells["Person_Name"].Value.ToString();
			uC_personDetails31.rtbSurname.Text = radGridViewPersons.SelectedRows[0].Cells["Person_Surname"].Value.ToString();
			uC_personDetails31.rmebNationalCode.Text =
			radGridViewPersons.SelectedRows[0].Cells["Person_NationalCode"].Value.ToString();

			uC_personDetails31.comboNationality.setItem( 
			radGridViewPersons.SelectedRows[0].Cells["Person_Nationality"].Value.ToString().Trim());
			uC_personDetails31.rtbFatherName.Text = radGridViewPersons.SelectedRows[0].Cells["Person_FatherName"].Value.ToString();
			uC_personDetails31.comboBirthCity.setItem( radGridViewPersons.SelectedRows[0].Cells["Person_BirthCity"].Value.ToString().Trim());
			uC_personDetails31.comboRegisterCity.setItem(radGridViewPersons.SelectedRows[0].Cells["Person_RegisterCity"].Value.ToString().Trim());
			uC_personDetails31.rmeIdentifyCode.Text =
				radGridViewPersons.SelectedRows[0].Cells["Person_IdentifyCode"].Value.ToString();

			uC_personDetails31.rtbRegisterCode.Text = MainRadGridView.CurrentRow.Cells["Person_RegisterCode"].Value.ToString();
			if (!(radGridViewPersons.SelectedRows[0].Cells["Person_BirthDate"].Value is DBNull))
			{
				uC_personDetails31.bdcBirthDate.DateTime =
					(DateTime) radGridViewPersons.SelectedRows[0].Cells["Person_BirthDate"].Value;
			} else
			{
				uC_personDetails31.bdcBirthDate.DateTime =(DateTime?)null;
			}

		if ( !( radGridViewPersons.SelectedRows [0].Cells ["Person_SecureFormDate"].Value is DBNull ) )
			{
				uC_personDetails31.bdcEndSecureDate.DateTime =
					( DateTime ) radGridViewPersons.SelectedRows [0].Cells ["Person_SecureFormDate"].Value;
			}  else
		{
			uC_personDetails31.bdcEndSecureDate.DateTime =	  ( DateTime? ) null;
		}


			uC_personDetails31.rmebLicenseDriveCode.Text =
				radGridViewPersons.SelectedRows[0].Cells["Person_LicenseDriverCode"].Value.ToString();
			uC_personDetails31.rmebPhone1.Text = radGridViewPersons.SelectedRows[0].Cells["Person_Phone1"].Value.ToString();
			uC_personDetails31.rmebPhone2.Text = radGridViewPersons.SelectedRows[0].Cells["Person_Phone2"].Value.ToString();
			uC_personDetails31.rddlHaveForm.SelectedIndex =
				((bool) radGridViewPersons.SelectedRows[0].Cells["Person_HaveForm"].Value) ? 0 : 1;
			uC_personDetails31.rddlsex.SelectedIndex = (bool) radGridViewPersons.SelectedRows[0].Cells["Person_isWoman"].Value
			                                          	? 1
			                                          	: 0;
			if (!(radGridViewPersons.SelectedRows[0].Cells["Person_Picture"].Value is DBNull))
			{
				byte[] Picture = ((byte[]) radGridViewPersons.SelectedRows[0].Cells["Person_Picture"].Value);
				if (Picture.Length > 0)
				{
					uC_personDetails31.ImgData = Picture;
				}
				else
				{
					uC_personDetails31.ImgData = new byte[0];
				}
			}
			else
			{
				uC_personDetails31.ImgData = new byte[0];
			}

			//Get BlackList Status from Server
            //if (ItemsPublic.MyRights.Contains(ServerClasses.AllFunctions._Rights.View_persons))
            //{
                var temp = decimal.Parse(radGridViewPersons.SelectedRows[0].Cells["Person_ID"].Value.ToString());
                //if (BlackListData.ContainsKey(temp))
                uC_personDetails31.rddlIsBlack.SelectedIndex = ((bool)radGridViewPersons.SelectedRows[0].Cells["Person_IsBlackTemp"].Value) ? 0 : 1;
                        //(BlackListData[temp] == false) ? 1 : 0;
               // else
                   // ItemsPublic.Exeptor("وضعیت فرد مورد نظر در سیستم وجود ندارد");
            //}
            //else
            //{
            //    uC_personDetails31.rddlIsBlack.SelectedIndex = 1;
            //}
			// uC_personDetails31.rddlIsBlack.SelectedIndex = 1;
		}

		private void radGridViewPersons_SelectionChanged(object sender, EventArgs e)
		{
			SetProperties(ShowPropertiesItems);
		}

		private void frm_person_eventSaveToDelete()
		{
			decimal ID = decimal.Parse(radGridViewPersons.SelectedRows[0].Cells["Person_ID"].Value.ToString());
			result = objManager.ClsPersons_delete(ID);
		}

		private void frm_person_eventSaveToEdit()
		{
			decimal ID = decimal.Parse(radGridViewPersons.SelectedRows[0].Cells["Person_ID"].Value.ToString());
			bool idCodeValid;
			if (uC_personDetails31.rmeIdentifyCode.Text.Trim() == string.Empty ||
			    uC_personDetails31.rmeIdentifyCode.Text.Trim() == "0")
			{
				idCodeValid = false;
			}
			else
			{
				idCodeValid = true;
			}
			result = objManager.ClsPersons_update(ID, uC_personDetails31.rtbName.Text.Trim(),
			                                      uC_personDetails31.rtbSurname.Text.Trim(),
			                                      uC_personDetails31.rmebNationalCode.Text.Trim(),
			                                      uC_personDetails31.comboNationality.ReturnSaveIfNew(),
			                                      uC_personDetails31.rtbFatherName.Text.Trim(),
			                                      uC_personDetails31.comboBirthCity.ReturnSaveIfNew()
			                                      ,
			                                      (uC_personDetails31.bdcBirthDate.SelectedDate != null)
			                                      	? uC_personDetails31.bdcBirthDate.SelectedDate.Value
			                                      	: (DateTime?) null,
			                                      uC_personDetails31.rmebLicenseDriveCode.Text.Trim(),
			                                      uC_personDetails31.rmebPhone1.Text.Trim(),
			                                      uC_personDetails31.rmebPhone2.Text.Trim()
			                                      , (uC_personDetails31.rddlHaveForm.SelectedIndex == 0) ? true : false,
                                                  ((uC_personDetails31.rddlsex.SelectedIndex == -1) ? (bool?)null : ((uC_personDetails31.rddlsex.SelectedIndex == 1) ? true : false))
                                                      ,
			                                      uC_personDetails31.comboRegisterCity.ReturnSaveIfNew()
			                                      , uC_personDetails31.ImgData,
			                                      (idCodeValid )
			                                      	? uC_personDetails31.rmeIdentifyCode.Text.Trim()
			                                      	: string.Empty
												  , uC_personDetails31.rtbRegisterCode.Text.Trim () , 
													( uC_personDetails31.bdcEndSecureDate.SelectedDate != null )
			                                      	? uC_personDetails31.bdcEndSecureDate.SelectedDate.Value
			                                      	: ( DateTime? ) null );

		}

		private void frm_person_eventSaveToNew()
		{
			bool idCodeValid;
			if (uC_personDetails31.rmeIdentifyCode.Text.Trim() == string.Empty ||
			    uC_personDetails31.rmeIdentifyCode.Text.Trim() == "0")
			{
				idCodeValid = false;
			}
			else
			{
				idCodeValid = true;
			}
			result = objManager.ClsPersons_insert(uC_personDetails31.rtbName.Text.Trim(),
			                                      uC_personDetails31.rtbSurname.Text.Trim(),
			                                      uC_personDetails31.rmebNationalCode.Text.Trim(),
												  uC_personDetails31.comboNationality.ReturnSaveIfNew(),
			                                      uC_personDetails31.rtbFatherName.Text.Trim(),
			                                      uC_personDetails31.comboBirthCity.ReturnSaveIfNew(),
			                                      (uC_personDetails31.bdcBirthDate.SelectedDate != null)
			                                      	? uC_personDetails31.bdcBirthDate.SelectedDate.Value
			                                      	: (DateTime?) null,
			                                      uC_personDetails31.rmebLicenseDriveCode.Text.Trim(),
			                                      uC_personDetails31.rmebPhone1.Text.Trim(),
			                                      uC_personDetails31.rmebPhone2.Text.Trim(),
			                                      (uC_personDetails31.rddlHaveForm.SelectedIndex == 0) ? true : false,
                                                  ((uC_personDetails31.rddlsex.SelectedIndex == -1) ? (bool?)null : ((uC_personDetails31.rddlsex.SelectedIndex == 1) ? true : false))
                                                      ,
			                                      uC_personDetails31.comboRegisterCity.ReturnSaveIfNew()
			                                      , uC_personDetails31.ImgData,
			                                      (idCodeValid == true)
			                                      	? uC_personDetails31.rmeIdentifyCode.Text.Trim()
			                                      	: string.Empty
			                                      , uC_personDetails31.rtbRegisterCode.Text.Trim(),
													( uC_personDetails31.bdcEndSecureDate.SelectedDate != null )
			                                      	? uC_personDetails31.bdcEndSecureDate.SelectedDate.Value
			                                      	: ( DateTime? ) null );
            //if (result.success)
            //{
            //    BlackListData.Add(decimal.Parse(result.ResultTable.Rows[0]["Person_ID"].ToString()), false);
            //}
			frm_person_eventStatusNew();
		}

		private void frm_person_eventSaveToSearch()
		{
			bool? Person_isWoman = null;
			bool? Person_HaveForm = null;
			bool? Person_Picture = null;
			bool? BlackList_isBlack = null;

			if (uC_personDetails31.rddlsex.SelectedIndex != -1)
				Person_isWoman = uC_personDetails31.rddlsex.SelectedIndex == 1;
			if (uC_personDetails31.rddlHaveForm.SelectedIndex != -1)
				Person_HaveForm = uC_personDetails31.rddlHaveForm.SelectedIndex == 0;
			if (uC_personDetails31.rddlIsBlack.SelectedIndex != -1)
				BlackList_isBlack = uC_personDetails31.rddlIsBlack.SelectedIndex == 0;

			result = objManager.View_persons(
				Person_isWoman, Person_HaveForm,
				Person_Picture, BlackList_isBlack,
				uC_personDetails31.rtbName.Text.Trim(),
				uC_personDetails31.rtbSurname.Text.Trim(),
				uC_personDetails31.rmebNationalCode.Text.Trim(),
                uC_personDetails31.rmeIdentifyCode.Text.Trim(),
                uC_personDetails31.rmebLicenseDriveCode.Text.Trim(),
                uC_personDetails31.rtbRegisterCode.Text.Trim(),
                string.Empty);
		}

		private void frm_person_eventSaveToView()
		{
			result = objManager.View_persons(null, null, null, null, null, null, null,null,null,null, string.Empty);
		}

		private void rmiPersons_Click(object sender, EventArgs e)
		{
			documentWindowPersons.Show();
		}

		private void rmiProperty_Click(object sender, EventArgs e)
		{
			toolWindowProperties.Show();
		}

		private void radDock1_DockWindowClosed(object sender, DockWindowEventArgs e)
		{
			switch (e.DockWindow.Name)
			{
				case "toolWindowProperties":
					toolWindowProperties.Visible = false;
					break;
				case "documentWindowPersons":
					documentWindowPersons.Visible = false;
					break;
			}

			if (!toolWindowProperties.Visible && !documentWindowPersons.Visible)
			{
				cbbCancel_Click(sender, e);
			}
		}

		private void frm_person_eventAfterSave()
		{
          //  radGridViewPersons_RowFormatting(
          //  SetProperties(ShowPropertiesItems);
		}

		private void frm_person_eventStatusDelete()
		{

		}

		private void frm_person_eventStatusEdit()
		{
			uC_personDetails31.rtbName.Focus();
		}

		private void frm_person_eventStatusNew()
		{
			uC_personDetails31.rtbName.Focus();
		}

		private void frm_person_eventStatusSearch()
		{
			uC_personDetails31.rtbName.Focus();
		}

		private void frm_person_eventStatusView()
		{

		}

		protected bool QuestionSureToBlock()
		{

			var dr = MessageBox.Show("آیا قصد تغییر وضعیت فرد انتخابی را دارید", "هشدار", MessageBoxButtons.YesNo,
			                         MessageBoxIcon.Question);
			return dr == DialogResult.Yes;
		}

		private void frm_person_eventBlockPerson()
		{
			if (MainRadGridView.SelectedRows.Count() != 1)
			{
				ItemsPublic.ShowMessage("ابتدا آیتمی را انتخاب کنید");
				return;
			}
			if ( true )//QuestionSureToBlock()
			{
				var tempId = decimal.Parse(radGridViewPersons.SelectedRows[0].Cells["Person_ID"].Value.ToString());
				var frm = new frm_BlockPerson();
                frm.currentIsBlack = ((bool)radGridViewPersons.SelectedRows[0].Cells["Person_IsBlackTemp"].Value) ;
				frm.currentPersonId = tempId;
				frm.ShowDialog();
				if (frm.DialogResult == DialogResult.OK)
				{
					 radGridViewPersons.SelectedRows[0].Cells["Person_IsBlackTemp"].Value  = ! ((bool)radGridViewPersons.SelectedRows[0].Cells["Person_IsBlackTemp"].Value) ;
                     uC_personDetails31.rddlIsBlack.SelectedIndex = ((bool)radGridViewPersons.SelectedRows[0].Cells["Person_IsBlackTemp"].Value) ? 0 : 1;
				}
				frm.Close();
			}
		}

		private void radGridViewPersons_RowFormatting( object sender , RowFormattingEventArgs e )
		{
            try
            {
                if (!ItemsPublic.IsnewRowAdded && ItemsPublic.MyRights.Contains(ServerClasses.AllFunctions._Rights.View_persons))
                    if (e != null)
                        if (e.RowElement != null)
                            if (!(e.RowElement is GridTableHeaderRowElement))
                                if (e.RowElement.RowInfo.Cells["Person_ID"] != null)
                                    if (e.RowElement.RowInfo.Cells["Person_HaveForm"] != null)
                                    {
                                        //var tempId = bool.Parse(e.RowElement.RowInfo.Cells["Person_IsBlackTemp"].Value.ToString());
                                        //if(e.RowElement.RowInfo.Cells["Person_IsBlackTemp"]!=null)
                                        if (e.RowElement.RowInfo.Cells["Person_IsBlackTemp"] != null)
                                        {
                                            bool? tempIsBlack = (bool)e.RowElement.RowInfo.Cells["Person_IsBlackTemp"].Value;

                                            if (tempIsBlack == true)
                                            {
                                                e.RowElement.DrawFill = true;
                                                e.RowElement.BackColor = Color.PaleVioletRed;
                                            }
                                            else if (e.RowElement.RowInfo.Cells["Person_SecureFormDate"].Value == null || string.IsNullOrEmpty(e.RowElement.RowInfo.Cells["Person_SecureFormDate"].Value.ToString()))
                                            {
                                              //  DateTime? dd = (DateTime?)e.RowElement.RowInfo.Cells["Person_SecureFormDate"].Value;
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
            }
            catch(Exception ex)
            {
                //ItemsPublic.ShowMessage("رنگ نگاری ناقص"+ "\r\n"+ex.Message);
                ItemsPublic.Exeptor("رنگ نگاری ناقص" + "\r\n" + ex.Message);
            }
		}

        private void frm_person_eventSecureForm()
        {
            try{

                if (MainRadGridView.SelectedRows.Count() == 1)
                {
                    var frmSecure = new gatepass.ui.package.frm_SecureUpdate();
                    frmSecure.showProperties(
                        uC_personDetails31.rtbName.Text
                        , uC_personDetails31.rtbSurname.Text
                        , uC_personDetails31.rddlsex.Text
                        , uC_personDetails31.rmebNationalCode.Text
                        , uC_personDetails31.bdcEndSecureDate.DateTime
                        , (bool)MainRadGridView.SelectedRows[0].Cells["Person_HaveForm"].Value
                        );
                    frmSecure.ShowDialog();
                    if (frmSecure.DialogResult == DialogResult.OK)
                    {
                        Manager objM = new Manager();
                        decimal ID = decimal.Parse(MainRadGridView.SelectedRows[0].Cells["Person_ID"].Value.ToString());
                        bool idCodeValid;
                        if (uC_personDetails31.rmeIdentifyCode.Text.Trim() == string.Empty ||
                            uC_personDetails31.rmeIdentifyCode.Text.Trim() == "0")
                        {
                            idCodeValid = false;
                        }
                        else
                        {
                            idCodeValid = true;
                        }
                        result = objM.ClsPersons_update(ID, uC_personDetails31.rtbName.Text.Trim(),
                                                  uC_personDetails31.rtbSurname.Text.Trim(),
                                                  uC_personDetails31.rmebNationalCode.Text.Trim(),
                                                  uC_personDetails31.comboNationality.ReturnSaveIfNew(),
                                                  uC_personDetails31.rtbFatherName.Text.Trim(),
                                                  uC_personDetails31.comboBirthCity.ReturnSaveIfNew()
                                                  ,
                                                  (uC_personDetails31.bdcBirthDate.SelectedDate != null)
                                                    ? uC_personDetails31.bdcBirthDate.SelectedDate.Value
                                                    : (DateTime?)null,
                                                  uC_personDetails31.rmebLicenseDriveCode.Text.Trim(),
                                                  uC_personDetails31.rmebPhone1.Text.Trim(),
                                                  uC_personDetails31.rmebPhone2.Text.Trim()
                                                  , frmSecure.haveForm,
                                                  ((uC_personDetails31.rddlsex.SelectedIndex == -1) ? (bool?)null : ((uC_personDetails31.rddlsex.SelectedIndex == 1) ? true : false))
                                                      ,
                                                  uC_personDetails31.comboRegisterCity.ReturnSaveIfNew()
                                                  , uC_personDetails31.ImgData,
                                                  (idCodeValid)
                                                    ? uC_personDetails31.rmeIdentifyCode.Text.Trim()
                                                    : string.Empty
                                                  , uC_personDetails31.rtbRegisterCode.Text.Trim(),
                                                    frmSecure.dtEndSecure);

                        if (result.success)
                        {
                            ItemsPublic.ShowMessage("وضعیت فرم حفاظتی بروز شد");
                            foreach (DataColumn col in result.ResultTable.Columns)
                            {
                                MainRadGridView.CurrentRow.Cells[col.ColumnName].Value =
                                    result.ResultTable.Rows[0][col.ColumnName];
                            }
                        }
                        else
                        {
                            MessageBox.Show(result.Message);
                        }
                    }
                    frmSecure.Close();
                }
                
         
            }catch(Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
            }

        }

	}
}
