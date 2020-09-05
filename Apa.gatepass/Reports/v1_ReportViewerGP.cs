using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.ReportViewer.WinForms;

namespace aorc.gatepass.Reports
{
    public partial class v1_ReportViewerGP : Form
    {
        public v1_ReportViewerGP()
        {
            InitializeComponent();
        }
        private decimal gatepassID;

        /// <summary>
        /// Generate Report And Display Report Form
        /// </summary>
        /// <param name="GpArchiveView">DataTable from GatePass Archive Data</param>
        /// <returns>Dialog Result of ShowDialog method</returns>

        public static DialogResult ShowReport(DataTable GpArchiveView)
        {
            v1_ReportViewerGP frm = new v1_ReportViewerGP();
            GPPrint rep1 = new GPPrint();
            rep1.DataSource = GpArchiveView;
            if (GpArchiveView.Rows[0].Field<int>("CountPrinted")>0)
            {
                    rep1.Almosana();
            }

            if (!ItemsPublic.signPrint)
            {
                rep1.SignPrint();
            }

            //else
            //{
            //    rep1.SetPicSign((byte[])GpArchiveView.Rows[0].Field<byte[]>("Sign_Shape"));
            //}

            frm.gatepassID = GpArchiveView.Rows[0].Field<decimal>("Gatepass_ID");
            //MessageBox.Show(GpArchiveView.Rows[0].Field<int>("CountPrinted").ToString());
            frm.reportViewer1.Report = rep1;
            frm.reportViewer1.RefreshReport();
            return frm.ShowDialog();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            ServerClasses.OutputDatas result = m.ClsPacksGps_PrintingGp2(gatepassID, ServerClasses.AllFunctions._StatePrint.Printing);
            if (!result.success)
            {
                MessageBox.Show(result.Message);
                return;
            }
            else
            {
                reportViewer1.PrintReport();
                if (MessageBox.Show("آیا عملیات چاپ با موفقیت صورت پذیرفت؟","اطلاعات چاپ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerClasses.OutputDatas printRes = m.ClsPacksGps_PrintedGP2(gatepassID, ServerClasses.AllFunctions._StatePrint.Complete);
                    if (!printRes.success)
                    {
                        MessageBox.Show(printRes.Message);
                    }
                }
                else
                {
                    ServerClasses.OutputDatas printRes = m.ClsPacksGps_PrintedGP2(gatepassID, ServerClasses.AllFunctions._StatePrint.Free);
                    if (!printRes.success)
                    {
                        MessageBox.Show(printRes.Message);
                    }
                }
                this.Close();
            }
        }

		private void v1_ReportViewerGP_Load( object sender , EventArgs e )
		{

		}

		private void v1_ReportViewerGP_Shown( object sender , EventArgs e )
		{
			toolStripButton1.Enabled = true;
		}
    }
}
