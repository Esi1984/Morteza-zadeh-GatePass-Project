namespace aorc.gatepass.Reports
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for b04_GPPrint.
    /// </summary>
    public partial class b04_GPPrint : Telerik.Reporting.Report
    {
        public b04_GPPrint()
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