using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace aorc.gatepass.Complex_Reports.ReportInOut
{
    public partial class UC_PageGp : UserControl
    {
        public UC_PageGp()
        {
            InitializeComponent();
        }

        private byte[] ImgDataPic
        {
            get
            {
                if (pbImage.Image != null)
                {
                    var ms = new System.IO.MemoryStream();
                    pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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

        private byte[] ImgDataSign
        {
            get
            {
                if (pbSign.Image != null)
                {
                    var ms = new System.IO.MemoryStream();
                    pbSign.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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
                    pbSign.Image = Image.FromStream(ms);
                }
                else
                {
                    pbSign.Image = null;
                }
            }
        }

        public void setItems(GridViewRowInfo radGridViewReport)
        {
            // radGridViewReport["Person_Name"].ToString();

            if (!(radGridViewReport.Cells["Person_Picture"].Value is DBNull))
            {
                byte[] Picture = ((byte[])radGridViewReport.Cells["Person_Picture"].Value);
                if (Picture.Length > 0)
                {
                    ImgDataPic = Picture;
                }
                else
                {
                    ImgDataPic = new byte[0];
                }
            }
            else
            {
                ImgDataPic = new byte[0];
            }

            if (radGridViewReport.Cells["Vehicle_number"] != null)
            if (!(radGridViewReport.Cells["Vehicle_number"].Value is DBNull))
            if (radGridViewReport.Cells["Vehicle_number"].Value != null)
            {
                chkHaveVehicle.Visible = true;
                
                rtbVeh.Text =
                    radGridViewReport.Cells["VehicleType_Name"].Value.ToString()
                    + " "
                    + radGridViewReport.Cells["Vehicle_Model"].Value.ToString()
                    + "    "+" رنگ: "
                    + radGridViewReport.Cells["vehicle_Color"].Value.ToString()
                    + "    "+" نوع: "
                    + ((bool)radGridViewReport.Cells["Vehicle_IsCompany"].Value ? "شرکتی" : "غیرشرکتی")
                    + "\r\n"+ " به شماره: "
                    + radGridViewReport.Cells["Vehicle_number"].Value.ToString()
                    + " شماره گواهینامه: "
                    + radGridViewReport.Cells["Person_LicenseDriverCode"].Value.ToString();
            }
            else
            {
                chkHaveVehicle.Visible = false;
                rtbVeh.Text = "خودرو ندارد";
            }

            rtbName.Text = radGridViewReport.Cells["Person_Name"].Value.ToString()
                + " " + radGridViewReport.Cells["Person_Surname"].Value.ToString();
            rmebNationalCode.Text = radGridViewReport.Cells["Person_NationalCode"].Value.ToString();

         
            
            //aorc.gatepass.ItemsPublic.GetPersianDate((DateTime)radGridViewReport.Cells["Package_StartDate"].Value)
            //int val1 = (aorc.gatepass.ItemsPublic.GetDayOfYear((DateTime)radGridViewReport.Cells["Package_EndDate"].Value)
            //    - aorc.gatepass.ItemsPublic.GetDayOfYear((DateTime)radGridViewReport.Cells["Package_StartDate"].Value))
            //    + 1;

            int val1 = aorc.gatepass.ItemsPublic.DiffDateInDay
                ((DateTime)radGridViewReport.Cells["Package_StartDate"].Value
                , (DateTime)radGridViewReport.Cells["Package_EndDate"].Value);

            rmebDays.Text = "اعتبار این پروانه به مدت " +
               val1 + " روز";


            rmebHistory.Text = "از " + aorc.gatepass.ItemsPublic.GetPersianDate((DateTime)radGridViewReport.Cells["Package_StartDate"].Value)
                + " لغایت " + aorc.gatepass.ItemsPublic.GetPersianDate((DateTime)radGridViewReport.Cells["Package_EndDate"].Value);


            Places_Label.Text = radGridViewReport.Cells["Places_Label"].Value.ToString();

            rtbArchiveID.Text = radGridViewReport.Cells["Archive_ID"].Value.ToString();

            rtbGate.Text = radGridViewReport.Cells["Gate_Label"].Value.ToString();

            rtbTA.Text = radGridViewReport.Cells["TravelArea_Name"].Value.ToString();
            rtbDesc.Text = radGridViewReport.Cells["Package_Description"].Value.ToString();
            rtbConfirm.Text = radGridViewReport.Cells["Package_NameOperConfirm"].Value.ToString();
            rtbPassage.Text = radGridViewReport.Cells["Package_NameOperPassage"].Value.ToString();


            if ((int)radGridViewReport.Cells["CountPrinted"].Value <= 0)
             {
                 lblCountPrint.Text = "چاپ نشده";
             }
            else if ((int)radGridViewReport.Cells["CountPrinted"].Value == 1)
            {
                 lblCountPrint.Text = "یکبار چاپ شده";
            }
            else if ((int)radGridViewReport.Cells["CountPrinted"].Value > 1)
            {
                 lblCountPrint.Text = radGridViewReport.Cells["CountPrinted"].Value.ToString() + " مرتبه چاپ شده است ";
            }

            if (radGridViewReport.Cells["Archive_TagId"] != null)
                if (!(radGridViewReport.Cells["Archive_TagId"].Value is DBNull))
            rtbTagId.Text = radGridViewReport.Cells["Archive_TagId"].Value.ToString();
        }

        public void clearItems()
        {
           // pbImage.imag = null;
            chkHaveVehicle.Visible = false;
            rtbName.Text = "";
            rmebNationalCode.Text = "";
            rmebDays.Text = "";
            rmebHistory.Text = "";
            //rlblDescriptions.Text = "";
            Places_Label.Text = "";
            rtbArchiveID.Text = "";
            //radLabel1.Text = "";
            rtbVeh.Text = "";
            //radLabel2.Text = "";
            rtbGate.Text = "";
            //radLabel3.Text = "";
            rtbTA.Text = "";
            //radLabel4.Text = "";
            rtbDesc.Text = "";
            //radLabel5.Text = "";
            rtbConfirm.Text = "";
            //radLabel6.Text = "";
            rtbPassage.Text = "";
            
            lblCountPrint.Text = "";
            ImgDataPic = null;
            ImgDataSign = null;

            rtbTagId.Text = "";
//            pictureBox2.Image = null;
        }

        internal void ViewMode()
        {

            chkHaveVehicle.Tag = "a";
            rtbName.Tag = "a";
            rmebNationalCode.Tag = "a";
            rmebDays.Tag = "a";
            rmebHistory.Tag = "a";
            Places_Label.Tag = "a";
            rtbArchiveID.Tag = "a";
            rtbVeh.Tag = "a";
            rtbGate.Tag = "a";
            rtbTA.Tag = "a";
            rtbDesc.Tag = "a";
            rtbConfirm.Tag = "a";
            rtbPassage.Tag = "a";
            rtbTagId.Tag = "a";
           // lblCountPrint.Tag = "a";
        }
    }
}
