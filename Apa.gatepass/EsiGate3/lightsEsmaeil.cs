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
    public partial class lightsEsmaeil : UserControl
    {
        public lightsEsmaeil()
        {
            InitializeComponent();
            EsiGateWay = null;
        }

        public delegate void DelegateStatusAction();

        public event DelegateStatusAction EsmaeilBlock;
        public event DelegateStatusAction EsmaeilFree;
        public event DelegateStatusAction EsmaeilCard;

        private ItemsPublic.MiniGateWayEsiMode? EsiGateWay = null;

          
        private void buttonModeFree()
        {
            this.rbBlock.Image = global::aorc.gatepass.Properties.Resources.Perspective_Shutdown_disable48;
            this.rbCard.Image = global::aorc.gatepass.Properties.Resources.Perspective_Logoff_disable48;
            this.rbFree.Image = global::aorc.gatepass.Properties.Resources.Perspective_Button_Reboot_icon_48;
        }

        private void buttonModeBlock()
        {
            this.rbBlock.Image = global::aorc.gatepass.Properties.Resources.Perspective_Button_Shutdown_icon48;
            this.rbCard.Image = global::aorc.gatepass.Properties.Resources.Perspective_Logoff_disable48;
            this.rbFree.Image = global::aorc.gatepass.Properties.Resources.Perspective_Reboot_disable48;
        }

        private void buttonModeCard()
        {
            this.rbBlock.Image = global::aorc.gatepass.Properties.Resources.Perspective_Shutdown_disable48;
            this.rbCard.Image = global::aorc.gatepass.Properties.Resources.Perspective_Button_Logoff_icon48;
            this.rbFree.Image = global::aorc.gatepass.Properties.Resources.Perspective_Reboot_disable48;
        }


        
        
        public  ItemsPublic.MiniGateWayEsiMode? GateWayMode
        {
            get { return EsiGateWay; }
            set 
            {
                switch (value)
                {
                    case ItemsPublic.MiniGateWayEsiMode.blocked:
                        EsiGateWay = value;
                        buttonModeBlock();
                        EnableMode();
                      //  radGroupBox1.Enabled = true;
                        break;
                    case ItemsPublic.MiniGateWayEsiMode.free:
                        EsiGateWay = value;
                        buttonModeFree();
                        EnableMode();
                    //    radGroupBox1.Enabled = true;
                        break;
                    case ItemsPublic.MiniGateWayEsiMode.card:
                        EsiGateWay = value;
                        buttonModeCard();
                        EnableMode();
                   //     radGroupBox1.Enabled = true;
                        break;
                    default:
                        DisableMode();
                        break;
                }

            }
        }

        private void rbBlock_Click(object sender, EventArgs e)
        {
            EsmaeilBlock();
        }

        private void rbCard_Click(object sender, EventArgs e)
        {
            EsmaeilCard();
        }

        private void rbFree_Click(object sender, EventArgs e)
        {
            EsmaeilFree();
        }

        internal void DisableMode()
        {
            //radGroupBox1.Enabled = false;

            radGroupBox1.Visible = false;
        }

        internal void EnableMode()
        {
           // radGroupBox1.Enabled = true;

            radGroupBox1.Visible = true;
        }
    }
}
