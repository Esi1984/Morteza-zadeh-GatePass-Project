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
	public partial class mainForm : Form
	{
		public delegate void DelegateStatusAction();

		protected delegate void DelegateRadGridSelectionChanged();

		public event DelegateStatusAction eventBlockPerson;
        public event DelegateStatusAction eventSecureForm;

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

		protected void setMenuForPakcManager()
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
			cbbEdit.Text = "بسته باز شود";
			//  cbbSearch.Text = "جستجوی افراد";
		}

		protected RadItemCollection findRadItems()
		{
			var ric = new RadItemCollection();
			ric.AddRange(cbbCancel, cbbDelete, cbbEdit, cbbNew, cbbPrint, cbbSave, cbbSearch, cbbView);
			ric.AddRange(rmiCancel, rmiCopy, rmiCut, rmiHelp2, rmiPaste, rmiSave, rmiStatusDelete, rmiStatusEdit,
			             rmiStatusExit, rmiStatusNew, rmiStatusPrint, rmiStatusSearch, rmiStatusSettingPrint,
			             rmiStatusView);

			ric.AddRange(rightCbbBlockPerson, rightCbbDelete, rightCbbEdit
					   , rightCbbExit, rightCbbNew, rightCbbSearch,rightCbbView);

			rightCbbView.Tag = cbbView.Tag;
			this.rightCbbSearch.Tag = cbbSearch.Tag;
			this.rightCbbNew.Tag =  cbbNew.Tag;
			this.rightCbbEdit.Tag =cbbEdit.Tag;
			this.rightCbbDelete.Tag = cbbDelete.Tag;

 
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

		public mainForm()
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
        private bool copyingMode = false;
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
                        if (!copyingMode)
						objManager.EmptyControls(myAll);
					}
				}
			}
			catch (Exception ex)
			{
				//ItemsPublic.ShowMessage(ex.Message);
                ItemsPublic.IsnewRowAdded = false;
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//  this.Close();
			}
		}

		protected void justListForm()
		{
			RadCommandBar1MainF.Visible = false;
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
						GroupingControlsView(cntrl);
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

						//if ( cntrl is RadDropDownList )
						//{
						//    MessageBox.Show ( cntrl.Name );
						//}
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
				eventStatusNew();
				MainRadGridView.Enabled = false;
				MainRadGridView.CurrentRow = null;
				MainRadGridView.ClearSelection();
				objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toNew);
				//ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toNew;
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
				//ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toEdit;
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

        protected void cbbSearch_Click(object sender, EventArgs e)
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
				//ItemsPublic.sta = ItemsPublic.IndexStatus.toView;
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
							foreach (DataColumn col in result.ResultTable.Columns)
							{
								MainRadGridView.CurrentRow.Cells[col.ColumnName].Value =
									result.ResultTable.Rows[0][col.ColumnName];
							}
							MainRadGridView.CurrentRow = null;
                            ItemsPublic.IsnewRowAdded = false;
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
                            copyingMode = true;
							MainRadGridView.DataSource = result.ResultTable;
							MainRadGridView.Enabled = true;
                            copyingMode = false;
                        ///    MainRadGridView.CurrentRow = MainRadGridView.CurrentRow;
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
                            copyingMode = true;
							MainRadGridView.DataSource = result.ResultTable;
                            copyingMode = false;
							MainRadGridView.Enabled = true;
                         //   MainRadGridView.CurrentRow = MainRadGridView.CurrentRow;
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
				eventStatusView();
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
            ItemsPublic.BigErr += "a";
			try
			{
			//	this.radLabelElementStatus.Bounds = new System.Drawing.Rectangle(0, 0, radStatusStrip1.Width, 18);
                ItemsPublic.BigErr += "b";
			}
			catch (Exception ex)
			{
				ItemsPublic.ShowMessage(ex.Message + "\n" + setErrMessage(ex));
				//ItemsPublic.ShowMessage(ex.Message);
				// this.Close();
                ItemsPublic.BigErr += "E";
			}
            
		}

		private void mainForm_Load(object sender, EventArgs e)
		{
            ItemsPublic.BigErr += "c";
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

		public Telerik.WinControls.UI.CommandBarButton cbbBlockPerson;
        public Telerik.WinControls.UI.CommandBarButton cbbSecureForm;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2MainF;

		public void createCbbBlockSecure()
		{
			//var commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement ();
			//this.commandBarRowElement1.Strips.AddRange ( new Telerik.WinControls.UI.CommandBarStripElement [] {
			//commandBarStripElement2} );
			cbbBlockPerson = new Telerik.WinControls.UI.CommandBarButton();
            cbbSecureForm = new Telerik.WinControls.UI.CommandBarButton();
            commandBarSeparator2MainF = new Telerik.WinControls.UI.CommandBarSeparator();

			this.commandBarStripElement1MainF.Items.Clear();


            this.commandBarSeparator2MainF.AccessibleDescription = "commandBarSeparator2";
            this.commandBarSeparator2MainF.AccessibleName = "commandBarSeparator2";
            this.commandBarSeparator2MainF.DisplayName = "خط جدا کننده شماره دو";
            this.commandBarSeparator2MainF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.commandBarSeparator2MainF.Name = "commandBarSeparator2MainF";
            this.commandBarSeparator2MainF.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator2MainF.VisibleInOverflowMenu = false;




			cbbBlockPerson.AccessibleDescription = "لیست سیاه";
            cbbBlockPerson.AccessibleName = "لیست سیاه";
			cbbBlockPerson.ClipText = true;
            cbbBlockPerson.DisplayName = "لیست سیاه";
			cbbBlockPerson.DrawText = true;
			cbbBlockPerson.FlipText = false;
			cbbBlockPerson.Image = global::aorc.gatepass.Properties.Resources.block2;
			cbbBlockPerson.Name = "cbbBlockPerson";
			cbbBlockPerson.Tag = "av";
            cbbBlockPerson.Text = "لیست سیاه";
			cbbBlockPerson.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			cbbBlockPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbbBlockPerson.TextWrap = false;
			cbbBlockPerson.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			cbbBlockPerson.Click += new System.EventHandler(cbbBlockPerson_Click);


            this.cbbSecureForm.AccessibleDescription = "وضعیت حفاظتی";
            this.cbbSecureForm.AccessibleName = "وضعیت حفاظتی";
            cbbBlockPerson.ClipText = true;
            this.cbbSecureForm.DisplayName = "تنظیم فرم حفاظتی";
            this.cbbSecureForm.DrawText = true;
            cbbBlockPerson.FlipText = false;
            this.cbbSecureForm.Image = global::aorc.gatepass.Properties.Resources.agent24;
            this.cbbSecureForm.Name = "cbbSecureForm";
            this.cbbSecureForm.Tag = "av";
            this.cbbSecureForm.Text = "وضعیت حفاظتی";
            this.cbbSecureForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbbSecureForm.TextWrap = false;
            this.cbbSecureForm.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbbSecureForm.Click += new System.EventHandler(cbbSecureForm_Click);




			this.commandBarStripElement1MainF.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[]
			                                                 	{
			                                                 		this.cbbView,
			                                                 		this.cbbSearch,
			                                                 		this.cbbNew,
			                                                 		this.cbbEdit,
                                                                    this.commandBarSeparator1MainF,
			                                                 		cbbBlockPerson,cbbSecureForm,
			                                                 		this.commandBarSeparator2MainF,
			                                                 		this.cbbDelete,
			                                                 		this.cbbSave,
			                                                 		this.cbbCancel,
			                                                 		this.commandBarSeparator3MainF,
			                                                 		this.cbbPrint
			                                                 	});
			this.commandBarStripElement1MainF.Name = "commandBarStripElement1";
			this.commandBarStripElement1MainF.Text = "";

			rightCbbBlockPerson = new RadMenuItem
			                      	{
			                      		AccessibleDescription = "لیست سیاه",
			                      		AccessibleName = "لیست سیاه",
			                      		FlipText = false,
										Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) ),
			                      		Image = global::aorc.gatepass.Properties.Resources.block2g,
			                      		Name = "rightCbbBlockPerson",
										Tag = cbbBlockPerson.Tag ,
			                      		Text = "لیست سیاه",
			                      		TextAlignment = System.Drawing.ContentAlignment.MiddleCenter,
			                      		Visibility = Telerik.WinControls.ElementVisibility.Visible,
										TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			                      	};


            rightCbbSecureForm = new RadMenuItem
            {
                AccessibleDescription = "وضعیت حفاظتی",
                AccessibleName = "وضعیت حفاظتی",
                FlipText = false,
                Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178))),
                Image = global::aorc.gatepass.Properties.Resources.agent16,
                Name = "rightCbbSecureForm",
                Tag = cbbSecureForm.Tag,
                Text = "وضعیت حفاظتی",
                TextAlignment = System.Drawing.ContentAlignment.MiddleCenter,
                Visibility = Telerik.WinControls.ElementVisibility.Visible,
                TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            };



            rightCbbSecureForm.Click += new System.EventHandler(cbbSecureForm_Click);
			rightCbbBlockPerson.Click += new System.EventHandler ( cbbBlockPerson_Click );
			setAllRightMenusCopy();
			contextMenu.Items.AddRange ( rightCbbView , rightCbbSearch , rightCbbNew , rightCbbEdit , rightCbbSecureForm
			, rightCbbBlockPerson , rightCbbDelete , rightCbbExit);
			MainRadGridView.ContextMenuOpening += new ContextMenuOpeningEventHandler ( MainRadGridView_ContextMenuOpening );

		}

		private void cbbBlockPerson_Click(object sender, EventArgs e)
		{
			CursorWait();
			eventBlockPerson();
			CursorDefault();
		}


        private void cbbSecureForm_Click(object sender, EventArgs e)
        {
            CursorWait();
            eventSecureForm();
            CursorDefault();
        }



		RadMenuItem rightCbbView = new RadMenuItem ();
		RadMenuItem rightCbbSearch = new RadMenuItem ();
		RadMenuItem rightCbbNew = new RadMenuItem ();
		RadMenuItem rightCbbEdit = new RadMenuItem ();
		RadMenuItem rightCbbDelete = new RadMenuItem ();
		RadMenuItem rightCbbExit = new RadMenuItem ();
		RadMenuItem rightCbbBlockPerson =  new RadMenuItem();
        RadMenuItem rightCbbSecureForm = new RadMenuItem();
        

		protected void setAllMouseMenus()
		{
			setAllRightMenusCopy();
			 //contextMenu.Items.AddRange ( rightCbbView , rmiStatusSearch , rmiStatusNew , rmiStatusEdit , rmiStatusDelete , rmiStatusPrint , rmiStatusExit );
			contextMenu.Items.AddRange ( rightCbbView , rightCbbSearch , rightCbbNew , rightCbbEdit
										, rightCbbDelete , rightCbbExit );
			MainRadGridView.ContextMenuOpening += new ContextMenuOpeningEventHandler(MainRadGridView_ContextMenuOpening);
		}
		private void setAllRightMenusCopy()
		{
			rightCbbView.AccessibleDescription = "مشاهده";
			rightCbbView.AccessibleName = "مشاهده";
			rightCbbView.FlipText = false;
			rightCbbView.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			rightCbbView.Image = global::aorc.gatepass.Properties.Resources._52g;
			rightCbbView.Name = "rightCbbView";
			
			rightCbbView.Text = "بازآوری";
			rightCbbView.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			rightCbbView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			rightCbbView.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			rightCbbView.Click += new System.EventHandler ( cbbView_Click );

			// cbbSearch
			// 
			this.rightCbbSearch.AccessibleDescription = "جستجو";
			this.rightCbbSearch.AccessibleName = "جستجو";
			this.rightCbbSearch.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbSearch.Image = global::aorc.gatepass.Properties.Resources.searchg;
			this.rightCbbSearch.Name = "rightCbbSearch";
		
			this.rightCbbSearch.Text = "جستجو";
			this.rightCbbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbSearch.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbSearch.Click += new System.EventHandler ( this.cbbSearch_Click );
			// 
			// cbbNew
			// 
			this.rightCbbNew.AccessibleDescription = "جدید";
			this.rightCbbNew.AccessibleName = "جدید";
			this.rightCbbNew.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbNew.Image = global::aorc.gatepass.Properties.Resources.add_newg;
			this.rightCbbNew.Name = "rightCbbNew";
			
			this.rightCbbNew.Text = "جدید";
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
			this.rightCbbEdit.Name = "rightCbbEdit";
			
			this.rightCbbEdit.Text = "ویرایش";
				this.rightCbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbEdit.Click += new System.EventHandler ( this.cbbEdit_Click );
			// 
			
			// cbbDelete
			// 
			this.rightCbbDelete.AccessibleDescription = "حذف";
			this.rightCbbDelete.AccessibleName = "حذف";
			this.rightCbbDelete.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rightCbbDelete.Image = global::aorc.gatepass.Properties.Resources.blue_recycle_bin_icong;
			this.rightCbbDelete.Name = "rightCbbDelete";
	
			this.rightCbbDelete.Text = "حذف";
			this.rightCbbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rightCbbDelete.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rightCbbDelete.Click += new System.EventHandler ( this.cbbDelete_Click );
			// 
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
		private void MainRadGridView_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
		{
			e.ContextMenu = contextMenu;
		}

        private void mainForm_VisibleChanged(object sender, EventArgs e)
        {
            ItemsPublic.BigErr += "V";
        }


	}
}
