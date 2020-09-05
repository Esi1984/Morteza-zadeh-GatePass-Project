namespace aorc.gatepass.Reports
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for v1_2GPPrint.
    /// </summary>
    public partial class v1_2GPPrint : Telerik.Reporting.Report
    {

        TextWatermark tw1;

        bool signPrint = true;
      
        public v1_2GPPrint()
        {
            
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            
            //
            // TODO: Add any constructor code after InitializeComponent call
            //            
        }

		private void detail_ItemDataBound( object sender , EventArgs e )
		{
            
		}

        public void Almosana()
        {            
            TextWatermark tw1 = new TextWatermark();
            tw1.Color = System.Drawing.Color.LightGray;
            tw1.Font.Bold = true;
            tw1.Font.Italic = false;
            tw1.Font.Name = "B Titr";
            tw1.Font.Size = Telerik.Reporting.Drawing.Unit.Point(100D);
            tw1.Orientation = Telerik.Reporting.Drawing.WatermarkOrientation.Diagonal;
            tw1.Text = "المثنی";            
            this.PageSettings.Watermarks.Add(tw1);
        }

        
        public void SignPrint()
        {
          //  signPrint = false;
            pnlSign.Visible = false;       
        }

        internal void SetPicSign(byte[] inPic)
        {
            var ms = new System.IO.MemoryStream();
            ms.Write(inPic, 0, inPic.Length);
            pictureBoxSign.Value = Image.FromStream(ms);
        }
    }
}