using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.ui.vehicle
{
    public partial class frm_vehicleTypes : aorc.gatepass.mainForm
    {
        public frm_vehicleTypes()
        {
            InitializeComponent();
        }

        private void frm_vehicleTypes_Load(object sender, EventArgs e)
        {
			setAllMouseMenus ();
            GroupingControls((Control)this);
            GroupingRadObjects(findRadItems());
           cbbView_Click(sender, e);
        }
        private void ShowPropertiesItems()
        {
            uC_vehicleTypesDetails1.rtbVehicleType.Text = MainRadGridView.CurrentRow.Cells["VehicleType_Name"].Value.ToString();
            uC_vehicleTypesDetails1.rtbDescriptions.Text = MainRadGridView.CurrentRow.Cells["VehicleType_Desc"].Value.ToString();
        }
        private void radGridViewTypeVehicle_SelectionChanged(object sender, EventArgs e)
        {
            SetProperties(ShowPropertiesItems);
        }

        private void frm_vehicleTypes_eventSaveToDelete()
        {
            result = objManager.ClsVehicles_update_Type(int.Parse(MainRadGridView.CurrentRow.Cells["VehicleType_ID"].Value.ToString()), true, string.Empty);
        }

        private void frm_vehicleTypes_eventSaveToEdit()
        {
            result = objManager.ClsVehicles_update_Type(int.Parse(MainRadGridView.CurrentRow.Cells["VehicleType_ID"].Value.ToString()),null,uC_vehicleTypesDetails1.rtbDescriptions.Text);
        }

        private void frm_vehicleTypes_eventSaveToNew()
        {
            result = objManager.ClsVehicles_insert_Type(uC_vehicleTypesDetails1.rtbVehicleType.Text,
                                                        uC_vehicleTypesDetails1.rtbDescriptions.Text);
           // frm_vehicleTypes_eventStatusNew();
        }

        private void frm_vehicleTypes_eventSaveToSearch()
        {
            result = objManager.View_vehiclesType(null, uC_vehicleTypesDetails1.rtbVehicleType.Text.Trim());
        }

        private void frm_vehicleTypes_eventSaveToView()
        {
            result = objManager.View_vehiclesType(false,null);
        }

        private void radDock1_DockWindowClosed(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
        {
            switch (e.DockWindow.Name)
            {
                case "toolWindowProperties":
                    toolWindowProperties.Visible = false;
                    break;
                case "documentWindowTypeVehicle":
                    documentWindowTypeVehicle.Visible = false;
                    break;
            }

            if (!toolWindowProperties.Visible && !documentWindowTypeVehicle.Visible)
            {
                cbbCancel_Click(sender, e);
            }
        }

        private void rmiProperty_Click(object sender, EventArgs e)
        {
            toolWindowProperties.Show();
        }

        private void rmiVehicleTypes_Click(object sender, EventArgs e)
        {
            documentWindowTypeVehicle.Show();
        }

        private void frm_vehicleTypes_eventAfterSave()
        {

        }

        private void frm_vehicleTypes_eventStatusDelete()
        {

        }

        private void frm_vehicleTypes_eventStatusEdit()
        {
            uC_vehicleTypesDetails1.rtbDescriptions.Focus();
        }

        private void frm_vehicleTypes_eventStatusNew()
        {
            uC_vehicleTypesDetails1.rtbVehicleType.Focus();
        }

        private void frm_vehicleTypes_eventStatusSearch()
        {
        }

        private void frm_vehicleTypes_eventStatusView()
        {

        }


    }
}
