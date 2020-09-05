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
	public partial class UC_ViewPersonDetails : UserControl
	{
		public delegate void DelegateStatusSavePic();

		public event DelegateStatusSavePic eventUpdatePic;

		public UC_ViewPersonDetails()
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

        internal void clearItems()
        {

        }
    }
}
