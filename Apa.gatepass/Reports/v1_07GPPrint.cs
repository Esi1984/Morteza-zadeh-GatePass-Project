namespace aorc.gatepass.Reports
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for v1_07GPPrint.
    /// </summary>
    public partial class v1_07GPPrint : Telerik.Reporting.Report
    {
        public v1_07GPPrint()
        {
            //
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
       
    }
}