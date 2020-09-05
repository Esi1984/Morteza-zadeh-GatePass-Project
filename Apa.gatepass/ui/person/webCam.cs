using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
namespace aorc.gatepass.ui.person
{
    delegate void updateImageStateDelegate(Bitmap b);
    public partial class webCam : aorc.gatepass.TinyForm
    {
        
        private void updateImageState(Bitmap b)
        {

            PictureBox p = new PictureBox();
            p.Image = b;
            p.Location = new System.Drawing.Point(29, 3 + topmargin);
            p.Size = new System.Drawing.Size(140, 163);
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(p);
            p.Click += new EventHandler(SelectPicture);
            topmargin += 166;
            SelectPicture(p, new EventArgs());
        }

        private void SelectPicture(object p, EventArgs e)
        {
            ms.Close();
            ms = new System.IO.MemoryStream();
            PictureBox p1 = (PictureBox)p;
            foreach (PictureBox item in panel1.Controls)
            {
                item.BorderStyle = BorderStyle.FixedSingle;
            }
            p1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            p1.BorderStyle = BorderStyle.Fixed3D;
        }

        public System.IO.MemoryStream ms;
        public webCam()
        {
            InitializeComponent();
        }
        int topmargin = 0;
        private void video_NewFrame(object sender, NewFrameEventArgs e)
        {
            Bitmap frame = (Bitmap)e.Frame.Clone();
            if (takephoto)
            {
                takephoto = false;
                updateImageStateDelegate up = new updateImageStateDelegate(updateImageState);
                this.Invoke(up, frame);
                
            }
            pictureBox1.Image = frame;

        }

        private void webCam_Load(object sender, EventArgs e)
        {
            try
            {
                unVisibleCbbEmpty();
                cbreSearch.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                ms = new System.IO.MemoryStream();
                GetCameraList();
                videoCapture = new VideoCaptureDevice(VideDevices[comboBox1.SelectedIndex].MonikerString);
                videoCapture.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoCapture.DesiredFrameSize = new Size(254, 413);
                //videoCapture.DesiredFrameSize = new Size(354, 413);
                videoCapture.Start();
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                this.Close();
            }
        }

        FilterInfoCollection VideDevices;
        VideoCaptureDevice videoCapture;
        private void closeVideoSource()
        {
            if (!(videoCapture == null))
            {
                if (videoCapture.IsRunning)
                {
                    videoCapture.SignalToStop();
                    videoCapture = null;
                }
            }
        }
        private void GetCameraList()
        {
            try
            {
                VideDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                comboBox1.Items.Clear();
                if (VideDevices.Count == 0)
                {
                    throw new ApplicationException();
                }
                foreach (FilterInfo item in VideDevices)
                {
                    comboBox1.Items.Add(item.Name);
                }
                comboBox1.SelectedIndex = 0;
            }
            catch (ApplicationException ex)
            {
                comboBox1.Items.Add("No Capture Device Found");
                MessageBox.Show(ex.Message);
                this.Close();
            }

        }

        private void webCam_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                closeVideoSource();
            }catch(Exception ex){
                ItemsPublic.ShowMessage(ex.Message);
            }
        }
        bool takephoto = false;
        private void button1_Click(object sender, EventArgs e)
        {
            //videoCapture.Stop();
            videoCapture.DisplayPropertyPage(this.Handle);
            //videoCapture.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            takephoto = true;
        }

        private void webCam_eventSaveTiny()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoCapture.DisplayPropertyPage(this.Handle);
        }
    }
}
