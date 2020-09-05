using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServerClasses;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace aorc.gatepass.ui.agreement
{
    public partial class frm_Agreements : aorc.gatepass.mainForm
    {
        public frm_Agreements()
        {
            InitializeComponent();
        }

        private void frm_Agreements_Load(object sender, EventArgs e)
        {
            setAllMouseMenus();
            GroupingControls((Control)this);
            GroupingRadObjects(findRadItems());
          //  cbbView_Click(sender, e);
            cbbSearch_Click(sender, e);

        }

        private void ShowPropertiesItems()
        {
            uC_agreementsDetails1.rmebNumber.Text = MainRadGridView.CurrentRow.Cells["Agreement_Number"].Value.ToString();
            uC_agreementsDetails1.rtbTitle.Text = MainRadGridView.CurrentRow.Cells["Agreement_Title"].Value.ToString();
            uC_agreementsDetails1.rtbCompany.Text = MainRadGridView.CurrentRow.Cells["Agreement_Company"].Value.ToString();
            uC_agreementsDetails1.rmebPhone.Text = MainRadGridView.CurrentRow.Cells["Agreement_AgentPhone"].Value.ToString();
            uC_agreementsDetails1.rtbAgentName.Text = MainRadGridView.CurrentRow.Cells["Agreement_AgentName"].Value.ToString();
            uC_agreementsDetails1.bdcEndDate1.DateTime = (DateTime)MainRadGridView.CurrentRow.Cells["Agreement_EndDate"].Value;
            uC_agreementsDetails1.bdcStartDate1.DateTime = (DateTime)MainRadGridView.CurrentRow.Cells["Agreement_StartDate"].Value;
            uC_agreementsDetails1.tbDescriptions.Text = MainRadGridView.CurrentRow.Cells["Agreement_Description"].Value.ToString();
            uC_agreementsDetails1.rddlActive.SelectedIndex = ((bool)MainRadGridView.CurrentRow.Cells["Agreement_IsActive"].Value == true) ? 0 : 1;
            uC_agreementsDetails1.rtbManagerName.Text = MainRadGridView.CurrentRow.Cells["Agreement_ManagerName"].Value.ToString();
            uC_agreementsDetails1.rtbAdress.Text = MainRadGridView.CurrentRow.Cells["Agreement_Adress"].Value.ToString();
            uC_agreementsDetails1.rmebPhoneCompany.Text = MainRadGridView.CurrentRow.Cells["Agreement_ManagerTell"].Value.ToString();
            uC_agreementsDetails1.rddlTypeAgree.SelectedIndex = ((bool)MainRadGridView.CurrentRow.Cells["Agreement_IsIndustrial"].Value == true) ? 0 : 1;
            uC_agreementsDetails1.rmebCountCar.Text = MainRadGridView.CurrentRow.Cells["Agreement_CountCars"].Value.ToString();
        }

        private void radGridViewAgreements_SelectionChanged(object sender, EventArgs e)
        {
            SetProperties(ShowPropertiesItems);
        }

        private void frm_Agreements_eventSaveToDelete()
        {
            result = objManager.ClsAgreements_delete((decimal)radGridViewAgreements.CurrentRow.Cells["Agreement_ID"].Value);
        }

        private void frm_Agreements_eventSaveToEdit()
        {

            decimal? tempNumber = !string.IsNullOrEmpty(uC_agreementsDetails1.rmebNumber.Text.Trim()) ? (decimal?)decimal.Parse(uC_agreementsDetails1.rmebNumber.Text.Trim()) : null;


            result = objManager.ClsAgreements_update(
                (decimal)radGridViewAgreements.CurrentRow.Cells["Agreement_ID"].Value,
                tempNumber,
                uC_agreementsDetails1.rtbAgentName.Text, uC_agreementsDetails1.rmebPhone.Text,
                uC_agreementsDetails1.rtbCompany.Text, uC_agreementsDetails1.tbDescriptions.Text,
                (uC_agreementsDetails1.bdcEndDate1.SelectedDate != null) ? uC_agreementsDetails1.bdcEndDate1.SelectedDate.Value : (DateTime?)null,
                uC_agreementsDetails1.rddlActive.SelectedIndex == 0,
                (uC_agreementsDetails1.bdcStartDate1.SelectedDate != null) ? uC_agreementsDetails1.bdcStartDate1.SelectedDate.Value : (DateTime?)null,
                uC_agreementsDetails1.rtbTitle.Text, uC_agreementsDetails1.rtbManagerName.Text
                , uC_agreementsDetails1.rmebPhoneCompany.Text,
                uC_agreementsDetails1.rtbAdress.Text,
                (uC_agreementsDetails1.rddlTypeAgree.SelectedIndex == 0) ? true : false
, int.Parse(uC_agreementsDetails1.rmebCountCar.Text));
        }

        private void frm_Agreements_eventSaveToNew()
        {
            result = objManager.ClsAgreements_insert(
                        decimal.Parse(uC_agreementsDetails1.rmebNumber.Text),
                        ((uC_agreementsDetails1.rddlActive.SelectedIndex == 0) ? true : false),
                        uC_agreementsDetails1.rtbTitle.Text,
                        uC_agreementsDetails1.rtbCompany.Text,
                        (uC_agreementsDetails1.bdcStartDate1.SelectedDate != null) ? uC_agreementsDetails1.bdcStartDate1.SelectedDate.Value : (DateTime?)null,
                        (uC_agreementsDetails1.bdcEndDate1.SelectedDate != null) ? uC_agreementsDetails1.bdcEndDate1.SelectedDate.Value : (DateTime?)null,
                        uC_agreementsDetails1.rtbAgentName.Text,
                        uC_agreementsDetails1.rmebPhone.Text, uC_agreementsDetails1.tbDescriptions.Text, uC_agreementsDetails1.rtbManagerName.Text
                        , uC_agreementsDetails1.rmebPhoneCompany.Text,
                        uC_agreementsDetails1.rtbAdress.Text,
                        (uC_agreementsDetails1.rddlTypeAgree.SelectedIndex == 0) ? true : false
, int.Parse(uC_agreementsDetails1.rmebCountCar.Text));
            frm_Agreements_eventStatusNew();
        }

        private void frm_Agreements_eventSaveToSearch()
        {

            DateTime? dts1 = null;
            DateTime? dts2 = null;
            DateTime? dte1 = null;
            DateTime? dte2 = null;
            if (uC_agreementsDetails1.bdcStartDate1.SelectedDate != null)
            {
                dts1 = uC_agreementsDetails1.bdcStartDate1.SelectedDate.Value;
            }
            if (uC_agreementsDetails1.bdcStartDate2.SelectedDate != null)
            {
                dts2 = uC_agreementsDetails1.bdcStartDate2.SelectedDate.Value;
            }
            if (uC_agreementsDetails1.bdcEndDate1.SelectedDate != null)
            {
                dte1 = uC_agreementsDetails1.bdcEndDate1.SelectedDate.Value;
            }
            if (uC_agreementsDetails1.bdcEndDate2.SelectedDate != null)
            {
                dte2 = uC_agreementsDetails1.bdcEndDate2.SelectedDate.Value;
            }

            bool? tempType = null;
            if (uC_agreementsDetails1.rddlTypeAgree.SelectedIndex != -1)
            {
                tempType = uC_agreementsDetails1.rddlTypeAgree.SelectedIndex == 0;
            }

            result = objManager.View_agreements(dts1, dts2, dte1, dte2, uC_agreementsDetails1.rtbManagerName.Text
                        , uC_agreementsDetails1.rtbAgentName.Text,
                        uC_agreementsDetails1.rtbCompany.Text,
                        tempType, uC_agreementsDetails1.rmebNumber.Text);
        }

        private void frm_Agreements_eventSaveToView()
        {
            result = objManager.View_agreements(null, null, null, null, string.Empty, string.Empty, string.Empty, null, null);
        }

        private void rmiAgreements_Click(object sender, EventArgs e)
        {
            documentWindowAgreements.Show();
        }

        private void rmiPropertyAgree_Click(object sender, EventArgs e)
        {
            toolWindowProperties.Show();
        }

        private void radDock1_DockWindowClosed(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
        {
            switch (e.DockWindow.Name)
            {
                case "toolWindowProperties":
                    toolWindowProperties.Visible = false;
                    break;
                case "documentWindowAgreements":
                    documentWindowAgreements.Visible = false;
                    break;
            }

            if (!toolWindowProperties.Visible && !documentWindowAgreements.Visible)
            {
                cbbCancel_Click(sender, e);
            }
        }

        private void frm_Agreements_eventAfterSave()
        {
            uC_agreementsDetails1.modeIsSearch = false;
          //  MainRadGridView.Refresh();
        }

        private void frm_Agreements_eventStatusDelete()
        {
            uC_agreementsDetails1.modeIsSearch = false;
        }

        private void frm_Agreements_eventStatusEdit()
        {
            uC_agreementsDetails1.modeIsSearch = false;
            uC_agreementsDetails1.rtbTitle.Focus();
        }

        private void frm_Agreements_eventStatusNew()
        {
            uC_agreementsDetails1.modeIsSearch = false;
            uC_agreementsDetails1.rmebNumber.Focus();
        }

        private void frm_Agreements_eventStatusSearch()
        {
            uC_agreementsDetails1.modeIsSearch = true;
        }

        private void frm_Agreements_eventStatusView()
        {
            uC_agreementsDetails1.modeIsSearch = false;
        }

        DateTime firstTimeRowFormat = new DateTime();

        DateTime endTimeRowFormat = new DateTime();

        int countDay = 0;

        private void radGridViewAgreements_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            try
            {
                if (!ItemsPublic.IsnewRowAdded && ItemsPublic.MyRights.Contains(ServerClasses.AllFunctions._Rights.View_agreements))
                if (e != null)
                    if (e.RowElement != null)
                        if (!(e.RowElement is GridTableHeaderRowElement))
                        {
                            if (radGridViewAgreements != null)
                                if (e.RowElement.RowInfo != null)
                                    if (e.RowElement.RowInfo.Cells["Agreement_EndDate"].Value != null)
                                    {
                                        bool isActive = true;;
                                        if (e.RowElement.RowInfo.Cells["Agreement_IsActive"].Value!=null)
	{
		isActive =  (bool)e.RowElement.RowInfo.Cells["Agreement_IsActive"].Value;
	}
                                        firstTimeRowFormat = DateTime.Now;
                                        endTimeRowFormat = (DateTime)e.RowElement.RowInfo.Cells["Agreement_EndDate"].Value;
                                        countDay = 1 + (int)endTimeRowFormat.Subtract(firstTimeRowFormat).TotalDays;

                                        if (countDay < 0 || !isActive)
                                        {
                                            e.RowElement.DrawFill = true;
                                            e.RowElement.BackColor = Color.LightGray;
                                        }
                                        else if (countDay < 5)
                                        {
                                            e.RowElement.DrawFill = true;
                                            e.RowElement.BackColor = Color.LightPink;
                                        }
                                        else if (countDay < 15)
                                        {
                                            e.RowElement.DrawFill = true;
                                            e.RowElement.BackColor = Color.Yellow;
                                        }
                                        else
                                        {
                                            e.RowElement.DrawFill = true;
                                            e.RowElement.BackColor = Color.White;
                                        }
                                    }
                        }

            }
            catch (Exception ex)
            {
                //ItemsPublic.ShowMessage("رنگ نگاری ناقص"+ "\r\n"+ex.Message);
                ItemsPublic.Exeptor("رنگ نگاری ناقص" + "\r\n" + ex.Message);
            }
        }
    }
}