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
    public partial class mainForm2 : Form
    {
        public delegate void DelegateStatusAction();

        protected delegate void DelegateRadGridSelectionChanged();

        public event DelegateStatusAction eventStatusNew;
        public event DelegateStatusAction eventStatusEdit;
        public event DelegateStatusAction eventStatusSearch;
        public event DelegateStatusAction eventStatusView;
        public event DelegateStatusAction eventStatusDelete;

        public event DelegateStatusAction eventSaveToDelete;
        public event DelegateStatusAction eventSaveToEdit;
        public event DelegateStatusAction eventSaveToNew;
        public event DelegateStatusAction eventSaveToView;
        public event DelegateStatusAction eventAfterSave;
        public event DelegateStatusAction eventSaveToSearch;

        // public event DelegateStatusAction eventClearProperiesItems;
        //  public event DelegateStatusAction eventShowPropertiesItems;

        protected Manager objManager;
        public RadGridView MainRadGridView { get; set; }
        protected OutputDatas result;
        protected List<object> myNew;
        protected List<object> myEdit;
        protected List<object> mySearch;
        protected List<object> myDelete;
        protected List<object> myView;
        protected List<object> myAll;

        private void setMenuForPakcManager()
        {
            cbbView.Text = "بازآوری لیست افراد";
            cbbNew.Text = "افزودن شخص";
            cbbEdit.Text = "بروزرسانی مشخصات بسته";
            cbbSearch.Text = "جستجوی افراد";
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
            ric.AddRange(cbbCancel, cbbDelete, cbbEdit, cbbNew, cbbPrint, cbbSave, cbbSearch, cbbView);
            ric.AddRange(rmiCancel, rmiCopy, rmiCut, rmiHelp2, rmiPaste, rmiSave, rmiStatusDelete, rmiStatusEdit,
                         rmiStatusExit, rmiStatusNew, rmiStatusPrint, rmiStatusSearch, rmiStatusSettingPrint,
                         rmiStatusView);

            rmiCancel.Tag = cbbCancel.Tag;
            // rmiCopy.Tag = cbbCopy.Tag;
            // rmiCut.Tag = cbbCut.Tag;
            rmiStatusDelete.Tag = cbbDelete.Tag;
            rmiStatusEdit.Tag = cbbEdit.Tag;
            rmiStatusNew.Tag = cbbNew.Tag;
            //   rmiPaste.Tag = cbbPaste.Tag;
            rmiStatusPrint.Tag = cbbPrint.Tag;
            rmiStatusSettingPrint.Tag = cbbPrint.Tag;
            rmiSave.Tag = cbbSave.Tag;
            rmiStatusSearch.Tag = cbbSearch.Tag;
            rmiStatusView.Tag = cbbView.Tag;

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

        public mainForm2()
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

        protected void SetProperties(DelegateRadGridSelectionChanged showMyProperties)
        {
            try
            {
                if (!ItemsPublic.IsnewRowAdded)
                {
                    //   MessageBox.Show(MainRadGridView.CurrentRow.Cells[0].Value.ToString());
                    if (MainRadGridView.SelectedRows.Count == 1)
                    {
                        showMyProperties();
                    }
                    else
                    {
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

        protected void GroupingControls(Control collect)
        {
            try
            {
                foreach (Control cntrl in collect.Controls)
                {
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
                    //if (cntrl.Tag == null || cntrl.Tag.ToString() == "")
                    //{
                    //    GroupingRadObjects(cntrl);
                    //}

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

            var dr = MessageBox.Show(ItemsPublic._questionSureToEdit, "هشدار", MessageBoxButtons.YesNo,
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

            	var frmAddPersons = new gatepass.ui.package.frm_SelectOrAddPersons4();
				////   frmAddPersons.pmStatus = ItemsPublic.IndexStatus.toEdit;
				// //  frmAddPersons.IndexPack = (decimal?)MainRadGridView.CurrentRow.Cells["package_Id"].Value;
				// //  frmAddPersons.setItemsPack(ref radGridViewPacks);
				//frmAddPersons.radGridViewSelected = MainRadGridView;
				frmAddPersons.ShowDialog();
				if (frmAddPersons.State)
				{
					//MainRadGridView.DataSource=null;
					//MainRadGridView.SelectAll();
					MainRadGridView.AllowAddNewRow = true;
					ItemsPublic.IsnewRowAdded = true;
					MainRadGridView.CurrentRow = null;

					while (MainRadGridView.Rows.Count>0)
					{
						MainRadGridView.Rows[0].Delete();
					}
					
					for (int count = 0; count <frmAddPersons.radGridViewSelected.Rows.Count;count++)
					{
		
						MainRadGridView.Rows.AddNew();
						MainRadGridView.CurrentRow.Cells["Person_ID"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_ID"].Value;
						MainRadGridView.CurrentRow.Cells["Person_NationalCode"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_NationalCode"].Value;
						MainRadGridView.CurrentRow.Cells["Person_isWoman"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_isWoman"].Value;
						MainRadGridView.CurrentRow.Cells["Person_IdentifyCode"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_IdentifyCode"].Value;
						MainRadGridView.CurrentRow.Cells["Person_LicenseDriverCode"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_LicenseDriverCode"].Value;
						MainRadGridView.CurrentRow.Cells["Person_Name"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Name"].Value;
						MainRadGridView.CurrentRow.Cells["Person_Surname"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Surname"].Value;
						MainRadGridView.CurrentRow.Cells["Person_FatherName"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_FatherName"].Value;
						MainRadGridView.CurrentRow.Cells["Person_BirthCity"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_BirthCity"].Value;
						MainRadGridView.CurrentRow.Cells["Person_RegisterCity"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_RegisterCity"].Value;
						MainRadGridView.CurrentRow.Cells["Person_Nationality"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Nationality"].Value;
						MainRadGridView.CurrentRow.Cells["Person_BirthDate"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_BirthDate"].Value;
						MainRadGridView.CurrentRow.Cells["Person_Phone1"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Phone1"].Value;
						MainRadGridView.CurrentRow.Cells["Person_Phone2"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Phone2"].Value;
						MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value;
						MainRadGridView.CurrentRow.Cells["Person_HaveForm"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_HaveForm"].Value;
						MainRadGridView.CurrentRow.Cells["Person_RegisterCode"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_RegisterCode"].Value;
						MainRadGridView.CurrentRow.Cells["Person_LabelIsWoman"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_LabelIsWoman"].Value;
						MainRadGridView.CurrentRow.Cells["Gatepass_ID"].Value = -1;
						MainRadGridView.CurrentRow.Cells["GatePass_IntPrint"].Value = -1;
						MainRadGridView.CurrentRow.Cells["GatePass_IsDriver"].Value = false;
						MainRadGridView.CurrentRow.Cells["GatePass_TimeLock"].Value = -1;
						MainRadGridView.CurrentRow.Cells["GatePass_LockerId"].Value = -1;
						//MainRadGridView.CurrentRow.Cells["package_Id"].Value = 
					}
					MainRadGridView.AllowAddNewRow = false;
					ItemsPublic.IsnewRowAdded = false;
					MainRadGridView.Refresh();
					//radGridViewPackManage.Enabled = true;
				}
				frmAddPersons.Close();
				frmAddPersons.Dispose();
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }

        }

        protected void cbbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                eventStatusEdit();
                if (!CheckOneSelectedRow(MainRadGridView.SelectedRows.Count) || !QuestionSureToEdit())
                {
                    return;
                }
                MainRadGridView.Enabled = false;
                objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toEdit);
                // //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toEdit;
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }
        }

        private void cbbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                eventStatusDelete();
                MainRadGridView.Enabled = true;
                objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toDelete);
                //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toDelete;
                cbbSave_Click(sender, e);
                cbbCancel_Click(sender, e);
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }
        }

        private void cbbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                eventStatusSearch();
                MainRadGridView.Enabled = false;
                MainRadGridView.CurrentRow = null;
                MainRadGridView.Enabled = false;
                objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toSearch);
                //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toSearch;
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
                objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toView);
                //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;
                cbbSave_Click(sender, e);
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
                            ItemsPublic.IsnewRowAdded = true;
                            MainRadGridView.Rows.AddNew();
                            ItemsPublic.IsnewRowAdded = false;
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
                }
                eventAfterSave();
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

        private void mainForm2_Load(object sender, EventArgs e)
        {

        }

        private void rmiStatusView_Click(object sender, EventArgs e)
        {
            cbbView_Click(sender, e);

        }

        private void rmiStatusSearch_Click(object sender, EventArgs e)
        {
            cbbSearch_Click(sender, e);
        }

        protected void rmiStatusNew_Click(object sender, EventArgs e)
        {
            cbbNew_Click(sender, e);
        }

        protected void rmiStatusEdit_Click(object sender, EventArgs e)
        {
            cbbEdit_Click(sender, e);
        }

        private void rmiStatusDelete_Click(object sender, EventArgs e)
        {
            cbbDelete_Click(sender, e);
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
        }

        private void rmiCancel_Click(object sender, EventArgs e)
        {
            cbbCancel_Click(sender, e);
        }

        private void rmiHelp2_Click(object sender, EventArgs e)
        {

        }

        private void rmiAbout_Click(object sender, EventArgs e)
        {

        }

        private void rmiStatusPrint_Click(object sender, EventArgs e)
        {

        }

        private void rmiStatusSettingPrint_Click(object sender, EventArgs e)
        {

        }

        private void cbbNoPassage_Click(object sender, EventArgs e)
        {

        }

        private void cbbNoConfirm_Click(object sender, EventArgs e)
        {

        }

        private void cbbPassage_Click(object sender, EventArgs e)
        {

        }

        private void cbbConfirm_Click(object sender, EventArgs e)
        {

        }

        private void cbbRequest_Click(object sender, EventArgs e)
        {

        }

		
    }
}
