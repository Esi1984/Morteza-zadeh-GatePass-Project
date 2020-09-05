using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass
{
	public partial class UC_personDetails3 : UserControl
	{
		public delegate void DelegateStatusSavePic();

		public event DelegateStatusSavePic eventUpdatePic;

		public UC_personDetails3()
		{
			InitializeComponent();
		}

		public byte[] ImgData
		{
			get
			{
				if (pbImage.Image != null)
				{
					var ms = new System.IO.MemoryStream();
					pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
					return ms.ToArray();                    
				}
				byte[] temp = {};
				return temp;
			}
			set
			{
				if (value != null && value.Length > 0)
				{
					var ms = new System.IO.MemoryStream();
					ms.Write(value, 0, value.Length);
					pbImage.Image = Image.FromStream(ms);
				}
				else
				{
					pbImage.Image = null;
				}
			}
		}

		public bool getPicThenSetPic = false;

        public void LimitAccess()
        {
            rbtnImage.Tag = "a";
            rtbName.Tag = "aen";
            rtbSurname.Tag = "aen";
            rmebNationalCode.Tag = "ans";
            rtbRegisterCode.Tag = "aen";
            rtbFatherName.Tag = "aen";
            comboBirthCity.Tag = "aen";
            bdcBirthDate.Tag = "aen";
            comboRegisterCity.Tag = "aen";
            comboNationality.Tag = "aen";
            rddlsex.Tag = "aen";
            rmeIdentifyCode.Tag = "aen";
            rmebLicenseDriveCode.Tag = "aen";
            rmebPhone1.Tag = "aen";
            rmebPhone2.Tag = "aen";
            rddlHaveForm.Tag = "a";
            bdcEndSecureDate.Tag = "a";
            rddlIsBlack.Tag = "a";
        }
        private void rbtnImage_Click(object sender, EventArgs e)
        {
            try
            {
                apaco.webcam.lib.main frm = new apaco.webcam.lib.main();
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //result goes to SelectedImage Field
                    pbImage.Image = frm.SelectedImage;


                    if (getPicThenSetPic)
                    {
                        eventUpdatePic();
                    }
                    // Convert Image To Binary Array               
                }
                frm.Dispose();
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
            }
        }

		private void rmeIdentifyCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				decimal k = decimal.Parse(rmeIdentifyCode.Text);
			}
			catch
			{
				if (rmeIdentifyCode.Text.Count() > 0)
				{
					rmeIdentifyCode.Text = rmeIdentifyCode.Text.Substring(0, rmeIdentifyCode.Text.Count() - 1);
					rmeIdentifyCode_TextChanged(null, null);
				}
			}
		}

		private void rmebNationalCode_Enter( object sender , EventArgs e )
		{
			rmebNationalCode.SelectionStart = 0;
			rmebNationalCode.SelectionLength = rmebNationalCode.Text.Length;
		}

		private void rmeIdentifyCode_Enter( object sender , EventArgs e )
		{
			rmeIdentifyCode.SelectionStart = 0;
			rmeIdentifyCode.SelectionLength = rmeIdentifyCode.Text.Length;
		}

		private void rmebLicenseDriveCode_Enter( object sender , EventArgs e )
		{
			rmebLicenseDriveCode.SelectionStart = 0;
			rmebLicenseDriveCode.SelectionLength = rmebLicenseDriveCode.Text.Length;
		}

		private void rmebNationalCode_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText(sender,e,rmebNationalCode.Text,10);
		}

		private void rtbRegisterCode_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText(sender,e,rtbRegisterCode.Text,10);
		}

		private void rmeIdentifyCode_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText(sender,e,rmeIdentifyCode.Text,10);
		}

		private void rmebLicenseDriveCode_KeyDown( object sender , KeyEventArgs e )
		{
			ItemsPublic.checkText(sender,e,rmebLicenseDriveCode.Text,10);
		}
	}
}
