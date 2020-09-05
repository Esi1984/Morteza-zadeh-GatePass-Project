using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using aorc.gatepass.Complex_Reports;
using ServerClasses;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;


namespace aorc.gatepass.EsiGate3
{
    public partial class EsiGateBase : Form
    {

        // aorc.gatepass.Complex_Reports.ReportInOut.UC_InOutView ucPropertyInOutView;
      //  aorc.gatepass.Complex_Reports.ReportInOut.UC_PageGp ucPropertyInOut;
     //   UC_TagSearch ucSearchInOut;

        #region Columns

        GridViewDecimalColumn gridViewDecimalColumnPerson1;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson1;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson2;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson3;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson4;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson5;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson6;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson7;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson8;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson9;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson10;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson11;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson12;
        GridViewCheckBoxColumn gridViewCheckBoxColumnPerson1;
        GridViewDateTimeColumn gridViewDateTimeColumnPerson1;
        GridViewCheckBoxColumn gridViewCheckBoxColumnPerson2;
        GridViewImageColumn gridViewImageColumnPerson1;
        GridViewDateTimeColumn gridViewDateTimeColumnPerson2;
        GridViewTextBoxColumn gridViewTextBoxColumnPerson13;
        GridViewCheckBoxColumn gridViewCheckBoxColumnPerson3;
        GridViewCheckBoxColumn gridViewCheckBoxColumnPerson4;

        GridViewTextBoxColumn gridViewTextBoxColumnAgreement1;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement2;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement3;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement4;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement5;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement6;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement7;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement8;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement9;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement10;
        GridViewDateTimeColumn gridViewDateTimeColumnAgreement1;
        GridViewDateTimeColumn gridViewDateTimeColumnAgreement2;
        GridViewCheckBoxColumn gridViewCheckBoxColumnAgreement1;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement11;
        GridViewTextBoxColumn gridViewTextBoxColumnAgreement12;
        GridViewCheckBoxColumn gridViewCheckBoxColumnAgreement2;


        GridViewTextBoxColumn gridViewTextBoxColumnOff1;
        GridViewTextBoxColumn gridViewTextBoxColumnOff2;
        GridViewCheckBoxColumn gridViewCheckBoxColumnOff1;
        GridViewTextBoxColumn gridViewTextBoxColumnOff3;
        GridViewTextBoxColumn gridViewTextBoxColumnOff4;
        GridViewTextBoxColumn gridViewTextBoxColumnOff5;
        GridViewTextBoxColumn gridViewTextBoxColumnOff6;
        GridViewTextBoxColumn gridViewTextBoxColumnOff7;
        GridViewTextBoxColumn gridViewTextBoxColumnOff8;
        GridViewTextBoxColumn gridViewTextBoxColumnOff9;
        GridViewTextBoxColumn gridViewTextBoxColumnOff10;
        GridViewTextBoxColumn gridViewTextBoxColumnOff11;

        GridViewDecimalColumn gridViewDecimalColumnVeh1;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh1;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh2;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh3;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh4;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh5;
        GridViewCheckBoxColumn gridViewCheckBoxColumnVeh1;
        GridViewCheckBoxColumn gridViewCheckBoxColumnVeh2;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh6;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh7;
        GridViewTextBoxColumn gridViewTextBoxColumnVeh8;

        #region Pack and GatePass

        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack1;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack2;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack3;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack4;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack5;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack6;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack7;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack1;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack2;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack8;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack9;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack10;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack3;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack4;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack11;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack5;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack6;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack7;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack8;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack9;
        Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumnPack1;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack12;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack10;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack11;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack12;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack13;
        Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumnPack1;
        Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumnPack2;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack13;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack14;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack15;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnPack16;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack14;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack15;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack16;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnPack17;

        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnGatePass1;
        Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumnGatePass1;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass1;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass2;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass3;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass4;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass5;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass6;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass7;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass8;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass9;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass10;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass11;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass12;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass13;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass14;
        Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumnGatePass1;
        Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumnGatePass2;
        Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumnGatePass1;
        Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumnGatePass2;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass15;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass16;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass17;
        Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumnGatePass3;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass18;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnGatePass2;
        //Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnGatePass3 ;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnGatePass4;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnGatePass5;
        Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumnGatePass3;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass19;
        Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumnGatePass6;
        Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumnGatePass4;
        Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumnGatePass5;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass20;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass21;
        Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumnGatePass22;

        #endregion


        #endregion

        protected Manager objManager;
        protected OutputDatas result;


        protected Manager objManagerTag = new Manager();
        protected OutputDatas resultTag = new OutputDatas();


        bool stateIsnewRowAdded = false;
        public enum _State : int
        {
            _None = 0,
            _Person = 1,
            _agreement = 2,
            _office = 3,
            _vehicle = 4,
            _gatepass = 5,
            _blacklist = 6,
            _operator = 7,
            _Inout = 8
        }
        _State CurrentState = _State._None;

        public EsiGateBase()
        {
            try
            {
                InitializeComponent();
                //     objManager = new Manager();
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                this.Close();
            }
        }

        private void showMyProperties()
        {
            showInOutPro();
            //switch (CurrentState)
            //{
            //    case _State._None:
            //        break;
            //    case _State._Inout:
                   
            //        break;
            //    default:
            //        break;
            //}
        }

        private void showInOutPro()
        {
          //  ucPropertyInOut.clearItems();
       //     ucPropertyInOut.setItems(radGridViewReport.CurrentRow);
            //result.MiniTable1
            //foreach (var item in result.MiniTable1.Rows)
            //{
            ////    item[0].
            //}
        //    ucPropertyInOutView.Show(result.MiniTable1, (decimal)radGridViewReport.CurrentRow.Cells["Archive_ID"].Value);
        }

    

        private void emptyProperties()
        {
           // ucPropertyInOut.clearItems();
        }

        protected void SetProperties()
        {
            try
            {
                if (!stateIsnewRowAdded)
                {
                    //if (radGridViewReport.SelectedRows.Count == 1)
                    //{
                    //    showMyProperties();
                    //}
                    //else
                    //{
                    //    emptyProperties();
                    //}
                }
            }
            catch (Exception ex)
            {
                //ItemsPublic.ShowMessage(ex.Message);
                ItemsPublic.ShowMessage(ex.Message);
                //  this.Close();
            }
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

        protected void cbbDoEmpty_Click(object sender, EventArgs e)
        {
            try
            {
                switch (CurrentState)
                {
                    case _State._None:
                        break;
                    case _State._Person:
                     //   ucSearchPerson.clearItenms();
                        break;
                    case _State._agreement:
                       // ucSearchAgree.clearItenms();
                        break;
                    case _State._office:
                      //  ucSearchOffice.clearItenms();
                        break;
                    case _State._vehicle:
                      //  ucSearchVeh.clearItenms();
                        break;
                    case _State._gatepass:
                     //   ucSearchGP.clearItenms();
                        break;
                    case _State._blacklist:
                        break;
                    case _State._operator:
                        break;
                    case _State._Inout:
                        break;
                    default:
                        throw new Exception("وضعیت در بخش گزارشات نا معلوم می باشد");
                }
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
            }

        }

        protected void cbbEdit_Click(object sender, EventArgs e)
        {
            try
            {
             //   ucSearchInOut_eventTagInput();
            }
            catch (Exception ex)
            {
                CursorDefault();
                ItemsPublic.ShowMessage(ex.Message);
            }
        }

        private void cbbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //:-)//   eventStatusDelete();
             //   radGridViewReport.Enabled = true;
                objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toDelete);
                //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toDelete;
                cbbSave_Click(sender, e);
                cbbCancel_Click(sender, e);
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }
        }

        private void cbbSearch_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                CursorDefault();
                ItemsPublic.ShowMessage(ex.Message);
            }
        }

        protected void cbbRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //:-)//   eventStatusView();
            //    radGridViewReport.Enabled = true;
                objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toView);
                //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;
              //  cbbSave_Click(sender, e);
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }
        }

        protected void cbbSave_Click(object sender, EventArgs e)
        {

            try
            {

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
                    ItemsPublic.ShowMessage(ex.Message);
                }
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }
        }

        protected void cbbCancel_Click(object sender, EventArgs e)
        {
            try
            {
                //cbbRefresh_Click(sender,e);
             //   radGridViewReport.Enabled = true;
             //   radGridViewReport.CurrentRow = null;
                objManager.ChangeStatus(aorc.gatepass.ItemsPublic.IndexStatus.toView);
                //ItemsPublic.MyStatus = ItemsPublic.IndexStatus.toView;
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
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
                ItemsPublic.ShowMessage(ex.Message);
                //ItemsPublic.ShowMessage(ex.Message);
                // this.Close();
            }
        }

        List<AllFunctions._Rights> userRights = ItemsPublic.MyRights;

        private void EsiGateBase_Load(object sender, EventArgs e)
        {


            this.UcGateController1.whoAmI(ItemsPublic._EsiGate.gate1, "گیت شماره یک");
            this.UcGateController2.whoAmI(ItemsPublic._EsiGate.gate2, "گیت شماره دو");


            // whoAmI

                
         //   toolWindowSecondProperties.Hide();

            //uC_TreeReport1.TreeViewReports.Nodes["NodePerson"].Visible = 
            //    userRights.Contains(AllFunctions._Rights.Report_person) 
            //    || userRights.Contains(AllFunctions._Rights.ReportLimitedPerson);
            
            //uC_TreeReport1.TreeViewReports.Nodes["NodeAgreement"].Visible = userRights.Contains(AllFunctions._Rights.Report_Agreement);
            //uC_TreeReport1.TreeViewReports.Nodes["NodeOffice"].Visible = userRights.Contains(AllFunctions._Rights.Report_office);
            //uC_TreeReport1.TreeViewReports.Nodes["NodeVehicle"].Visible = userRights.Contains(AllFunctions._Rights.Report_vehicle);
            //uC_TreeReport1.TreeViewReports.Nodes["NodeGP"].Visible = userRights.Contains(AllFunctions._Rights.Report_gatepass);
            //uC_TreeReport1.TreeViewReports.Nodes["NodeBlacklist"].Visible = userRights.Contains(AllFunctions._Rights.Report_blacklist);
            //uC_TreeReport1.TreeViewReports.Nodes["NodeOperator"].Visible = userRights.Contains(AllFunctions._Rights.Report_operator);
            //uC_TreeReport1.TreeViewReports.Nodes["NodeInout"].Visible = userRights.Contains(AllFunctions._Rights.Report_Inout);

        }

        private void rmiStatusView_Click(object sender, EventArgs e)
        {
            cbbRefresh_Click(sender, e);
        }

        private void rmiStatusSearch_Click(object sender, EventArgs e)
        {
            cbbSearch_Click(sender, e);
        }

        protected void rmiStatusNew_Click(object sender, EventArgs e)
        {
            cbbDoEmpty_Click(sender, e);
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

        RadMenuItem rightcbbRefresh = new RadMenuItem();

        RadMenuItem rightCbbSearch = new RadMenuItem();

        RadMenuItem rightCbbEdit = new RadMenuItem();

        RadMenuItem rightCbbExit = new RadMenuItem();

        protected void setAllMouseMenus()
        {
            setAllRightMenusCopy();
            //contextMenu.Items.AddRange ( rightcbbRefresh , rmiStatusSearch , rmiStatusNew , rmiStatusEdit , rmiStatusDelete , rmiStatusPrint , rmiStatusExit );
            contextMenu.Items.AddRange(rightcbbRefresh, rightCbbSearch, rightCbbEdit
                                        , rightCbbExit);
          //  radGridViewReport.ContextMenuOpening += new ContextMenuOpeningEventHandler(radGridViewReport_ContextMenuOpening);
        }

        private void setAllRightMenusCopy()
        {
            rightcbbRefresh.AccessibleDescription = "مشاهده";
            rightcbbRefresh.AccessibleName = "مشاهده";
            rightcbbRefresh.FlipText = false;
            rightcbbRefresh.Image = global::aorc.gatepass.Properties.Resources._52g;
            rightcbbRefresh.Name = "rightcbbRefresh";
            rightcbbRefresh.Tag = "av";
            rightcbbRefresh.Text = "بازآوری";
            rightcbbRefresh.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            rightcbbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            rightcbbRefresh.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            rightcbbRefresh.Click += new System.EventHandler(cbbRefresh_Click);

            // cbbSearch
            // 
            this.rightCbbSearch.AccessibleDescription = "جستجو";
            this.rightCbbSearch.AccessibleName = "جستجو";
            this.rightCbbSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rightCbbSearch.Image = global::aorc.gatepass.Properties.Resources.searchg;
            this.rightCbbSearch.Name = "rightCbbSearch";
            this.rightCbbSearch.Tag = "av";
            this.rightCbbSearch.Text = "جستجو";
            this.rightCbbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rightCbbSearch.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rightCbbSearch.Click += new System.EventHandler(this.cbbSearch_Click);
            // 

            // cbbEdit
            // 
            this.rightCbbEdit.AccessibleDescription = "تخصیص تگ";
            this.rightCbbEdit.AccessibleName = "تخصیص تگ";
            this.rightCbbEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rightCbbEdit.Image = global::aorc.gatepass.Properties.Resources.editg;
            this.rightCbbEdit.Name = "rightCbbEdit";
            this.rightCbbEdit.Tag = "av";
            this.rightCbbEdit.Text = "تخصیص تگ";
            this.rightCbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rightCbbEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rightCbbEdit.Click += new System.EventHandler(this.cbbEdit_Click);
            // 

            // exit
            this.rightCbbExit.AccessibleDescription = "خروج";
            this.rightCbbExit.AccessibleName = "خروج";
            this.rightCbbExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rightCbbExit.Image = global::aorc.gatepass.Properties.Resources.exitg;
            this.rightCbbExit.Name = "rightCbbExit";
            this.rightCbbExit.Text = "خروج";
            this.rightCbbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rightCbbExit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rightCbbExit.Click += new System.EventHandler(this.rmiStatusExit_Click);
        }

        private void radGridViewReport_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu = contextMenu;
        }
     
        private void InOutPainter()
        {
            #region _gatepass

            #region Pack and GatePass

            gridViewTextBoxColumnPerson9 = new GridViewTextBoxColumn();
            gridViewDecimalColumnPack3 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack7 = new GridViewDecimalColumn();

            gridViewCheckBoxColumnGatePass2 = new GridViewCheckBoxColumn();
            gridViewTextBoxColumnGatePass2 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass6 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass8 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass3 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass4 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass5 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnPack1 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnPack10 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass11 = new GridViewTextBoxColumn();

            gridViewDateTimeColumnGatePass2 = new GridViewDateTimeColumn();


            gridViewImageColumnGatePass1 = new GridViewImageColumn();

            gridViewTextBoxColumnGatePass7 = new GridViewTextBoxColumn();


            gridViewTextBoxColumnGatePass15 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnPack2 = new GridViewTextBoxColumn();


            gridViewTextBoxColumnGatePass17 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnGatePass16 = new GridViewTextBoxColumn();

            gridViewCheckBoxColumnGatePass3 = new GridViewCheckBoxColumn();

            gridViewTextBoxColumnPack13 = new GridViewTextBoxColumn();

            gridViewDateTimeColumnPack1 = new GridViewDateTimeColumn();

            gridViewDateTimeColumnPack2 = new GridViewDateTimeColumn();
            //gridViewTextBoxColumnPack1 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass22 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack9 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack7 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack12 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack3 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass21 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass9 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnGatePass10 = new GridViewTextBoxColumn();
            gridViewDecimalColumnGatePass2 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack1 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack2 = new GridViewDecimalColumn();
            gridViewDecimalColumnPack4 = new GridViewDecimalColumn();
            gridViewTextBoxColumnPack4 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack5 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack6 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack8 = new GridViewTextBoxColumn();

            gridViewTextBoxColumnPack11 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack14 = new GridViewTextBoxColumn();
            gridViewTextBoxColumnPack15 = new GridViewTextBoxColumn();
            gridViewDateTimeColumnGatePass1 = new GridViewDateTimeColumn();

            gridViewDateTimeColumnGatePass3 = new GridViewDateTimeColumn();

            gridViewImageColumnPerson1 = new GridViewImageColumn();

            gridViewDecimalColumnVeh1 = new GridViewDecimalColumn();


            gridViewTextBoxColumnPerson9.EnableExpressionEditor = false;
            gridViewTextBoxColumnPerson9.FieldName = "TravelArea_Name";
            gridViewTextBoxColumnPerson9.HeaderText = "نام محدوده تردد";
            gridViewTextBoxColumnPerson9.IsVisible = false;
            gridViewTextBoxColumnPerson9.Name = "TravelArea_Name";



            gridViewDecimalColumnPack3.EnableExpressionEditor = false;
            gridViewDecimalColumnPack3.FieldName = "CountPrinted";
            gridViewDecimalColumnPack3.HeaderText = "تعداد چاپ";
            gridViewDecimalColumnPack3.IsVisible = false;
            gridViewDecimalColumnPack3.Name = "CountPrinted";


            gridViewDecimalColumnPack7.EnableExpressionEditor = false;
            gridViewDecimalColumnPack7.FieldName = "Archive_ID";
            gridViewDecimalColumnPack7.HeaderText = "آیدی آرشیو";
            gridViewDecimalColumnPack7.IsVisible = false;
            gridViewDecimalColumnPack7.Name = "Archive_ID";

            gridViewTextBoxColumnGatePass2.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass2.FieldName = "Person_NationalCode";
            gridViewTextBoxColumnGatePass2.HeaderText = "شماره ملی";
            gridViewTextBoxColumnGatePass2.Name = "Person_NationalCode";
            gridViewTextBoxColumnGatePass2.Width = 145;

            gridViewCheckBoxColumnGatePass2.EnableExpressionEditor = false;
            gridViewCheckBoxColumnGatePass2.FieldName = "Person_isWoman";
            gridViewCheckBoxColumnGatePass2.HeaderText = "مونث";
            gridViewCheckBoxColumnGatePass2.IsVisible = false;
            gridViewCheckBoxColumnGatePass2.MinWidth = 20;
            gridViewCheckBoxColumnGatePass2.Name = "Person_isWoman";
            gridViewCheckBoxColumnGatePass2.Width = 31;



            gridViewTextBoxColumnGatePass6.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass6.FieldName = "Person_IdentifyCode";
            gridViewTextBoxColumnGatePass6.HeaderText = "شماره شناسایی";
            gridViewTextBoxColumnGatePass6.Name = "Person_IdentifyCode";
            gridViewTextBoxColumnGatePass6.Width = 103;



            gridViewTextBoxColumnGatePass8.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass8.FieldName = "Person_LicenseDriverCode";
            gridViewTextBoxColumnGatePass8.HeaderText = "شماره گواهینامه رانندگی";
            gridViewTextBoxColumnGatePass8.IsVisible = true;
            gridViewTextBoxColumnGatePass8.Name = "Person_LicenseDriverCode";
            gridViewTextBoxColumnGatePass8.Width = 168;



            gridViewTextBoxColumnGatePass3.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass3.FieldName = "Person_Name";
            gridViewTextBoxColumnGatePass3.HeaderText = "نام";
            gridViewTextBoxColumnGatePass3.Name = "Person_Name";
            gridViewTextBoxColumnGatePass3.Width = 119;
            gridViewTextBoxColumnGatePass4.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass4.FieldName = "Person_Surname";
            gridViewTextBoxColumnGatePass4.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumnGatePass4.Name = "Person_Surname";
            gridViewTextBoxColumnGatePass4.Width = 195;
            gridViewTextBoxColumnGatePass5.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass5.FieldName = "Person_FatherName";
            gridViewTextBoxColumnGatePass5.HeaderText = "نام پدر";
            gridViewTextBoxColumnGatePass5.Name = "Person_FatherName";
            gridViewTextBoxColumnGatePass5.Width = 109;




            gridViewTextBoxColumnPack1.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack1.FieldName = "Person_BirthCity";
            gridViewTextBoxColumnPack1.HeaderText = "شهر محل تولد";
            gridViewTextBoxColumnPack1.Name = "Person_BirthCity";
            gridViewTextBoxColumnPack1.IsVisible = true;
            gridViewTextBoxColumnPack1.Width = 90;



            gridViewTextBoxColumnPack10.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack10.FieldName = "Person_RegisterCity";
            gridViewTextBoxColumnPack10.HeaderText = "محل صدور";
            gridViewTextBoxColumnPack10.Name = "Person_RegisterCity";
            gridViewTextBoxColumnPack10.Width = 90;



            gridViewTextBoxColumnGatePass11.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass11.FieldName = "Person_Nationality";
            gridViewTextBoxColumnGatePass11.HeaderText = "تابعیت";
            gridViewTextBoxColumnGatePass11.IsVisible = true;
            gridViewTextBoxColumnGatePass11.Name = "Person_Nationality";
            gridViewTextBoxColumnGatePass11.Width = 64;



            gridViewDateTimeColumnGatePass2.EnableExpressionEditor = false;
            gridViewDateTimeColumnGatePass2.FieldName = "Person_BirthDate";
            gridViewDateTimeColumnGatePass2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnGatePass2.HeaderText = "تاریخ تولد";
            gridViewDateTimeColumnGatePass2.IsVisible = true;
            gridViewDateTimeColumnGatePass2.Name = "Person_BirthDate";



            gridViewImageColumnGatePass1.EnableExpressionEditor = false;
            gridViewImageColumnGatePass1.FieldName = "Person_Picture";
            gridViewImageColumnGatePass1.HeaderText = "عکس";
            gridViewImageColumnGatePass1.IsVisible = false;
            gridViewImageColumnGatePass1.Name = "Person_Picture";


            gridViewTextBoxColumnGatePass7.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass7.FieldName = "Person_LabelIsWoman";
            gridViewTextBoxColumnGatePass7.HeaderText = "جنسیت";
            gridViewTextBoxColumnGatePass7.Name = "Person_LabelIsWoman";
            gridViewTextBoxColumnGatePass7.Width = 57;


            gridViewTextBoxColumnGatePass15.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass15.FieldName = "Vehicle_number";
            gridViewTextBoxColumnGatePass15.HeaderText = "پلاک خودرو";
            gridViewTextBoxColumnGatePass15.Name = "Vehicle_number";
            gridViewTextBoxColumnGatePass15.Width = 81;



            gridViewTextBoxColumnPack2.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack2.FieldName = "vehicle_Name";
            gridViewTextBoxColumnPack2.HeaderText = "نام خودرو";
            gridViewTextBoxColumnPack2.Name = "vehicle_Name";
            gridViewTextBoxColumnPack2.Width = 117;


            gridViewTextBoxColumnGatePass17.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass17.FieldName = "vehicle_Color";
            gridViewTextBoxColumnGatePass17.HeaderText = "رنگ خودرو";
            gridViewTextBoxColumnGatePass17.Name = "vehicle_Color";
            gridViewTextBoxColumnGatePass17.Width = 64;


            gridViewTextBoxColumnGatePass16.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass16.FieldName = "Vehicle_Model";
            gridViewTextBoxColumnGatePass16.HeaderText = "مدل خودرو";
            gridViewTextBoxColumnGatePass16.Name = "Vehicle_Model";
            gridViewTextBoxColumnGatePass16.Width = 67;

            gridViewCheckBoxColumnGatePass3.EnableExpressionEditor = false;
            gridViewCheckBoxColumnGatePass3.FieldName = "Vehicle_IsCompany";
            gridViewCheckBoxColumnGatePass3.HeaderText = "خودرو شرکتی";
            gridViewCheckBoxColumnGatePass3.IsVisible = false;
            gridViewCheckBoxColumnGatePass3.MinWidth = 20;
            gridViewCheckBoxColumnGatePass3.Name = "Vehicle_IsCompany";
            gridViewCheckBoxColumnGatePass3.Width = 85;



            gridViewTextBoxColumnPack13.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack13.FieldName = "VehicleType_Name";
            gridViewTextBoxColumnPack13.HeaderText = "نام نوع خودرو";
            gridViewTextBoxColumnPack13.IsVisible = true;
            gridViewTextBoxColumnPack13.Name = "VehicleType_Name";


            gridViewDateTimeColumnPack1.EnableExpressionEditor = false;
            gridViewDateTimeColumnPack1.FieldName = "Package_StartDate";
            gridViewDateTimeColumnPack1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnPack1.HeaderText = "تاریخ شروع";
            gridViewDateTimeColumnPack1.IsVisible = false;
            gridViewDateTimeColumnPack1.Name = "Package_StartDate";



            gridViewDateTimeColumnPack2.EnableExpressionEditor = false;
            gridViewDateTimeColumnPack2.FieldName = "Package_EndDate";
            gridViewDateTimeColumnPack2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnPack2.HeaderText = "تاریخ پایان";
            gridViewDateTimeColumnPack2.IsVisible = false;
            gridViewDateTimeColumnPack2.Name = "Package_EndDate";



            gridViewTextBoxColumnGatePass22.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass22.FieldName = "Package_OperIdRequest";
            gridViewTextBoxColumnGatePass22.HeaderText = "Package_OperIdRequest";
            gridViewTextBoxColumnGatePass22.IsVisible = false;
            gridViewTextBoxColumnGatePass22.Name = "Package_OperIdRequest";



            gridViewTextBoxColumnPack9.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack9.FieldName = "Package_NameOperRequest";
            gridViewTextBoxColumnPack9.HeaderText = "نام درخواست کننده";
            gridViewTextBoxColumnPack9.Name = "Package_NameOperRequest";
            gridViewTextBoxColumnPack9.Width = 102;



            gridViewTextBoxColumnPack7.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack7.FieldName = "Package_Description";
            gridViewTextBoxColumnPack7.HeaderText = "توضیحات";
            gridViewTextBoxColumnPack7.IsVisible = true;
            gridViewTextBoxColumnPack7.Name = "Package_Description";





            gridViewTextBoxColumnPack12.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack12.FieldName = "Package_Shift";
            gridViewTextBoxColumnPack12.HeaderText = "شیفت کاری";
            gridViewTextBoxColumnPack12.Name = "Package_Shift";
            gridViewTextBoxColumnPack12.Width = 66;


            gridViewTextBoxColumnPack3.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack3.FieldName = "Office_Name";
            gridViewTextBoxColumnPack3.HeaderText = "اداره متقاضی";
            gridViewTextBoxColumnPack3.Name = "Office_Name";
            gridViewTextBoxColumnPack3.Width = 105;


            gridViewTextBoxColumnGatePass21.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass21.FieldName = "TypePlates_Desc";
            gridViewTextBoxColumnGatePass21.HeaderText = "TypePlates_Desc";
            gridViewTextBoxColumnGatePass21.IsVisible = false;
            gridViewTextBoxColumnGatePass21.Name = "TypePlates_Desc";



            gridViewTextBoxColumnGatePass9.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass9.FieldName = "Places_Label";
            gridViewTextBoxColumnGatePass9.HeaderText = "محدوده تردد";
            gridViewTextBoxColumnGatePass9.IsVisible = true;
            gridViewTextBoxColumnGatePass9.Name = "Places_Label";
            gridViewTextBoxColumnGatePass9.Width = 106;


            gridViewTextBoxColumnGatePass10.EnableExpressionEditor = false;
            gridViewTextBoxColumnGatePass10.FieldName = "Gate_Label";
            gridViewTextBoxColumnGatePass10.HeaderText = "دروازه تردد";
            gridViewTextBoxColumnGatePass10.IsVisible = true;
            gridViewTextBoxColumnGatePass10.Name = "Gate_Label";



            gridViewDecimalColumnGatePass2.EnableExpressionEditor = false;
            gridViewDecimalColumnGatePass2.FieldName = "Gatepass_ID";
            gridViewDecimalColumnGatePass2.HeaderText = "آیدی گیت پاس";
            gridViewDecimalColumnGatePass2.IsVisible = false;
            gridViewDecimalColumnGatePass2.Name = "Gatepass_ID";


            gridViewDecimalColumnVeh1.EnableExpressionEditor = false;
            gridViewDecimalColumnVeh1.FieldName = "Archive_TagId";
            gridViewDecimalColumnVeh1.HeaderText = "کد تردد";
            gridViewDecimalColumnVeh1.IsVisible = true;
            gridViewDecimalColumnVeh1.Name = "Archive_TagId";


            gridViewDecimalColumnPack1.EnableExpressionEditor = false;
            gridViewDecimalColumnPack1.FieldName = "Package_BaridIdOperRequest";
            gridViewDecimalColumnPack1.HeaderText = "Package_BaridIdOperRequest";
            gridViewDecimalColumnPack1.IsVisible = false;
            gridViewDecimalColumnPack1.Name = "Package_BaridIdOperRequest";

            gridViewDecimalColumnPack2.EnableExpressionEditor = false;
            gridViewDecimalColumnPack2.FieldName = "Package_BaridIdOperConfirm";
            gridViewDecimalColumnPack2.HeaderText = "Package_BaridIdOperConfirm";
            gridViewDecimalColumnPack2.IsVisible = false;
            gridViewDecimalColumnPack2.Name = "Package_BaridIdOperConfirm";
            gridViewDecimalColumnPack2.Width = 105;


            gridViewDecimalColumnPack4.EnableExpressionEditor = false;
            gridViewDecimalColumnPack4.FieldName = "Package_BaridIdOperPassage";
            gridViewDecimalColumnPack4.HeaderText = "Package_BaridIdOperPassage";
            gridViewDecimalColumnPack4.IsVisible = false;
            gridViewDecimalColumnPack4.Name = "Package_BaridIdOperPassage";




            gridViewTextBoxColumnPack4.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack4.FieldName = "Package_OperIdConfirm";
            gridViewTextBoxColumnPack4.HeaderText = "Package_OperIdConfirm";
            gridViewTextBoxColumnPack4.IsVisible = false;
            gridViewTextBoxColumnPack4.Name = "Package_OperIdConfirm";
            gridViewTextBoxColumnPack4.Width = 105;
            gridViewTextBoxColumnPack5.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack5.FieldName = "Package_NameOperConfirm";
            gridViewTextBoxColumnPack5.HeaderText = "تایید کننده ";
            gridViewTextBoxColumnPack5.Name = "Package_NameOperConfirm";
            gridViewTextBoxColumnPack5.Width = 105;
            gridViewTextBoxColumnPack6.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack6.FieldName = "Package_OperIdPassage";
            gridViewTextBoxColumnPack6.HeaderText = "Package_OperIdPassage";
            gridViewTextBoxColumnPack6.IsVisible = false;
            gridViewTextBoxColumnPack6.Name = "Package_OperIdPassage";
            gridViewTextBoxColumnPack6.Width = 105;


            gridViewTextBoxColumnPack8.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack8.FieldName = "Package_NameOperPassage";
            gridViewTextBoxColumnPack8.HeaderText = "تصویب کننده";
            gridViewTextBoxColumnPack8.IsVisible = true;
            gridViewTextBoxColumnPack8.Name = "Package_NameOperPassage";
            gridViewTextBoxColumnPack8.Width = 247;



            gridViewTextBoxColumnPack11.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack11.FieldName = "TravelArea_LabelTravel";
            gridViewTextBoxColumnPack11.HeaderText = "محل کار";
            gridViewTextBoxColumnPack11.IsVisible = true;
            gridViewTextBoxColumnPack11.Name = "TravelArea_LabelTravel";


            gridViewTextBoxColumnPack14.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack14.FieldName = "Agreement_Company";
            gridViewTextBoxColumnPack14.HeaderText = "پیمانکار / شرکت";
            gridViewTextBoxColumnPack14.IsVisible = true;
            gridViewTextBoxColumnPack14.Name = "Agreement_Company";

            gridViewTextBoxColumnPack15.EnableExpressionEditor = false;
            gridViewTextBoxColumnPack15.FieldName = "TypePack_Name";
            gridViewTextBoxColumnPack15.HeaderText = "نوع بسته";
            gridViewTextBoxColumnPack15.IsVisible = true;
            gridViewTextBoxColumnPack15.Name = "TypePack_Name";







            gridViewDateTimeColumnGatePass1.EnableExpressionEditor = false;
            gridViewDateTimeColumnGatePass1.FieldName = "Agreement_StartDate";
            gridViewDateTimeColumnGatePass1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnGatePass1.HeaderText = "Agreement_StartDate";
            gridViewDateTimeColumnGatePass1.IsVisible = false;
            gridViewDateTimeColumnGatePass1.Name = "Agreement_StartDate";
            gridViewDateTimeColumnGatePass1.Width = 85;
            gridViewDateTimeColumnGatePass3.EnableExpressionEditor = false;
            gridViewDateTimeColumnGatePass3.FieldName = "Agreement_EndDate";
            gridViewDateTimeColumnGatePass3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumnGatePass3.HeaderText = "Agreement_EndDate";
            gridViewDateTimeColumnGatePass3.IsVisible = false;
            gridViewDateTimeColumnGatePass3.Name = "Agreement_EndDate";


            gridViewImageColumnPerson1.EnableExpressionEditor = false;
            gridViewImageColumnPerson1.FieldName = "Sign_Shape";
            gridViewImageColumnPerson1.HeaderText = "Sign_Shape";
            gridViewImageColumnPerson1.IsVisible = false;
            gridViewImageColumnPerson1.Name = "Sign_Shape";




            #endregion

            #endregion
        }

        private void clear(_State InState)
        {
            try
            {
                CursorWait();
                switch (CurrentState)
                {
                    case _State._None:
                        break;
                    case _State._Person:
                    //    ucSearchPerson.clearItenms();
                        break;
                    case _State._agreement:
                      //  ucSearchAgree.clearItenms();

                        break;
                    case _State._office:
                     //   ucSearchOffice.clearItenms();
                        break;
                    case _State._vehicle:
                     //   ucSearchVeh.clearItenms();

                        break;
                    case _State._gatepass:
                        break;
                    case _State._blacklist:
                        break;
                    case _State._operator:
                        break;
                    case _State._Inout:
                        break;
                    default:
                        break;
                }
                CursorDefault();
            }
            catch (Exception ex)
            {
                CursorDefault();
                ItemsPublic.ShowMessage(ex.Message);
            }
        }
        bool copyingMode = false;
        private void radGridViewReport_SelectionChanged(object sender, EventArgs e)
        {
            SetProperties();
        }

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
                        //   GroupingControlsView(cntrl);
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
                                    //    myEdit.Add(cntrl);
                                    break;
                                case 'n':
                                    //   myNew.Add(cntrl);
                                    break;
                                case 's':
                                    //   mySearch.Add(cntrl);
                                    break;
                                case 'd':
                                    //   myDelete.Add(cntrl);
                                    break;
                                case 'v':
                                    //   myView.Add(cntrl);
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
                ItemsPublic.ShowMessage(ex.Message);
                //MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        protected List<object> myAll = new List<object>();

        private void EsiGateBase_Shown(object sender, EventArgs e)
        {


             UcGateController1.TryToConnect2();
             UcGateController2.TryToConnect2();


         //   UcGateController1.GetNews();
         //   UcGateController2.GetNews();


         //   cbbEdit.Visibility = ElementVisibility.Hidden;
        //    Painter(_State._Inout);

         //   ucSearchInOut.rtbGpId.Focus();

            //if (uC_TreeReport1.TreeViewReports.Nodes.Where(x=>x.Visible).Count() == 1)
            //{
            //    uC_TreeReport1.TreeViewReports.SelectedNode = uC_TreeReport1.TreeViewReports.Nodes.Single(x => x.Visible);
            //}
        }

        private void ucSearchInOut_eventGpInput()
        {
         //   ucPropertyInOut.clearItems();
          //  cbbSearch_Click(null,null);
        }


        protected bool QuestionSureTo(string str)
        {

            var dr = MessageBox.Show(str, "هشدار", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
            return dr == DialogResult.Yes;
        }

   

        private void rtbTagId_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
