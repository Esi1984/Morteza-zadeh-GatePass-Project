using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace aorc.gatepass.EsiGate3
{
    public partial class MorMonitoring : UserControl
    {


        public delegate void DelegateStatusAction();
        public event DelegateStatusAction EventEsiNoSeePass;


        public MorMonitoring()
        {
            InitializeComponent();
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void ShowPersonPass(string fName,string lName,ref Byte[] inPic, bool comeIn)
        {

            //  global::aorc.gatepass.Properties.Resources.Male
            this.rtbInfo.Text = fName + " " + lName;
            PbComeIn.Visible = comeIn;
            PbGoOut.Visible = !comeIn;
            rtbArrow.Text = comeIn ? "ورود" : "خروج";

            //PicPassingEsi.Image = (Image) inPic;

           // Byte[] data = new Byte[0];
            if (inPic.Length>0)
            {
                //data = (Byte[])(inPic);
                MemoryStream mem = new MemoryStream(inPic);
                PicPassingEsi.Image = Image.FromStream(mem);
            }
            else
            {
                //imgGate1.BackColor = Color.Silver;
                PicPassingEsi.Image = global::aorc.gatepass.Properties.Resources.Male;
            }

           

        }

        private void PicPassingEsi_DoubleClick(object sender, EventArgs e)
        {
            PbComeIn.Visible = false;
            PbGoOut.Visible = false;
            this.rtbInfo.Text = "نام و نشان متردد";
            rtbArrow.Text = "-";
            PicPassingEsi.Image = global::aorc.gatepass.Properties.Resources.Male;
            EventEsiNoSeePass();
        }



    }
}
