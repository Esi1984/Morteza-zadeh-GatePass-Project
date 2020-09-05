using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.EsiGate3
{
    public partial class lightsMainMode : UserControl
    {
        public lightsMainMode()
        {
            InitializeComponent();
            EsiGateMode = null;
        }

        public delegate void DelegateStatusAction();

        public event DelegateStatusAction EsmaeilBlock;
        public event DelegateStatusAction EsmaeilEmergency;
        public event DelegateStatusAction EsmaeilNormal;

        private ItemsPublic.MiniGateMainEsiMode? EsiGateMode = null;


        private void buttonModeEmergency()
        {
            //   aorc.gatepass.Properties.Resources.NormalModeDisable
            this.rbNormal.Image = global::aorc.gatepass.Properties.Resources.NormalModeDisable;
            this.rbEmergency.Image = global::aorc.gatepass.Properties.Resources.emergnecyModeEnable;
            this.rbBlock.Image = global::aorc.gatepass.Properties.Resources.BlockModeDisable;
        }

        private void buttonModeBlock()
        {
            this.rbNormal.Image = global::aorc.gatepass.Properties.Resources.NormalModeDisable;
            this.rbEmergency.Image = global::aorc.gatepass.Properties.Resources.emergnecyModeDisable;
            this.rbBlock.Image = global::aorc.gatepass.Properties.Resources.BlockModeEnable;
        }

        private void buttonModeNormal()
        {
            this.rbNormal.Image = global::aorc.gatepass.Properties.Resources.NormalModeEnable;
            this.rbEmergency.Image = global::aorc.gatepass.Properties.Resources.emergnecyModeDisable;
            this.rbBlock.Image = global::aorc.gatepass.Properties.Resources.BlockModeDisable;
        }

        public void EnableGateWay()
        {
           // GateMainMode = EsiGateMode;
            //radGroupBox1.Enabled = true;
            radGroupBox1.Visible = true;
        }
        private void buttonModeDisable()
        {


            this.rbNormal.Image = global::aorc.gatepass.Properties.Resources.NormalModeDisable;
            this.rbBlock.Image = global::aorc.gatepass.Properties.Resources.BlockModeDisable;
            this.rbEmergency.Image = global::aorc.gatepass.Properties.Resources.emergnecyModeDisable;


          //  radGroupBox1.Visible = false;
        }

        public ItemsPublic.MiniGateMainEsiMode? GateMainMode
        {
            get { return EsiGateMode; }
            set
            {
                switch (value)
                {
                    case ItemsPublic.MiniGateMainEsiMode.NormalGate:
                        EsiGateMode = value;
                        buttonModeNormal();
                        EnableGateWay();
                        break;
                    case ItemsPublic.MiniGateMainEsiMode.EmergencyGate:
                        EsiGateMode = value;
                        buttonModeEmergency();
                        EnableGateWay();
                        break;
                    case ItemsPublic.MiniGateMainEsiMode.BlockGate:
                        EsiGateMode = value;
                        buttonModeBlock();
                        EnableGateWay();
                        break;
                    case ItemsPublic.MiniGateMainEsiMode.FreeRunGate:
                     //   buttonModeDisable();
                        break;
                    default:
                        buttonModeDisable();
                        break;

                }
            }
        }

        private void rbBlock_Click(object sender, EventArgs e)
        {
            EsmaeilBlock();
        }

        private void rbEmergency_Click(object sender, EventArgs e)
        {
            EsmaeilEmergency();
        }

        private void rbNormal_Click(object sender, EventArgs e)
        {
            EsmaeilNormal();
        }

       
    }
}
