using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.clienttest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //if (aorc.gatepass.eorg.ui.rightside.OOficeID <= 0)
            //{
            //    aorc.gatepass.ui.frm_officeselector frm = new gatepass.ui.frm_officeselector();
            //    //TODO: Corrct User ID To cUser.ID
            //    frm.UserID = 111;// cUser.ID;
            //    frm.ShowDialog();
            //    frm.Close();
            //    frm.Dispose();
            //}


            
        }

        private void btnPacks_Click(object sender, EventArgs e)
        {
            aorc.gatepass.ui.package.frm_packs frm = new gatepass.ui.package.frm_packs();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void btnPackManage_Click(object sender, EventArgs e)
        {
            aorc.gatepass.ui.package.frm_packManage  frm = new gatepass.ui.package.frm_packManage();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            aorc.gatepass.ui.person.frm_person  frm = new gatepass.ui.person.frm_person();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            aorc.gatepass.ui.group.frm_groups frm = new gatepass.ui.group.frm_groups();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void btnOffices_Click(object sender, EventArgs e)
        {
            aorc.gatepass.ui.office.frm_offices frm = new gatepass.ui.office.frm_offices();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void btnOperators_Click(object sender, EventArgs e)
        {
            aorc.gatepass.ui.operators.frm_operators frm = new gatepass.ui.operators.frm_operators();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void btnAgreements_Click(object sender, EventArgs e)
        {
            aorc.gatepass.ui.agreement.frm_Agreements frm = new gatepass.ui.agreement.frm_Agreements();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void btnTravelAreas_Click(object sender, EventArgs e)
        {
            aorc.gatepass.ui.travelarea.frm_travelAreas frm = new gatepass.ui.travelarea.frm_travelAreas();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void btnVehicleTypes_Click(object sender, EventArgs e)
        {
            aorc.gatepass.ui.vehicle.frm_vehicleTypes frm = new gatepass.ui.vehicle.frm_vehicleTypes();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnBlackLists_Click(object sender, EventArgs e)
        {
            aorc.gatepass.ui.blacklist.frm_blacklists frm = new gatepass.ui.blacklist.frm_blacklists();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void btnBLReason_Click(object sender, EventArgs e)
        {
            aorc.gatepass.ui.blacklist.frm_blacklistReasons frm = new gatepass.ui.blacklist.frm_blacklistReasons();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            aorc.gatepass.mainForm frm2 = new aorc.gatepass.mainForm();
            frm2.ShowDialog();
            frm2.Close();
            frm2.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //aorc.gatepass.ui.login.frm_officeselector frm2 = new aorc.gatepass.ui.login.frm_officeselector();
            //frm2.ShowDialog();
            //frm2.Close();
            //frm2.Dispose();
        }


    }
}
