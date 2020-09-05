using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass
{
    public partial class UC_Sign : UserControl
    {
        public UC_Sign()
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
                    try
                    {
                        pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        ms.Seek(0, 0);
                    }
                    catch(Exception ex)
                    {
                        ItemsPublic.ShowMessage("خطا در بارگذاری عکس "+"\r\n\r\n"+ex.Message);
                    }
                    return ms.ToArray();
                }
                byte[] temp = { };
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

        private void rbtnImage_Click(object sender, EventArgs e)
        {


            Stream myStream = null;
            OpenFileDialog frm = new OpenFileDialog();

            frm.InitialDirectory = "c:\\";
            frm.Filter = "Image files (*.Jpeg)|*.Jpeg|All files (*.*)|*.*";
            frm.FilterIndex = 2;
            frm.RestoreDirectory = true;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = frm.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            Image bmp = Image.FromStream(myStream);
                                pbImage.Image = bmp;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }



           
        }
    }
}
