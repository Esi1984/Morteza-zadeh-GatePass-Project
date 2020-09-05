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
    public partial class ReportViewerGP : Form
    {
        public ReportViewerGP()
        {
            InitializeComponent();
        }

        protected void CursorWait()
        {
            this.UseWaitCursor = true;
            this.Cursor = Cursors.WaitCursor;
        }

        protected void CursorDefault()
        {
            this.UseWaitCursor = false;
            this.Cursor = Cursors.Default;
        }

        private decimal gatepassID;

        /// <summary>
        /// Generate Report And Display Report Form
        /// </summary>
        /// <param name="GpArchiveView">DataTable from GatePass Archive Data</param>
        /// <returns>Dialog Result of ShowDialog method</returns>
     static private DataTable GpArchiveTable;
        public static DialogResult ShowReport(DataTable GpArchiveView)
        {


            ReportViewerGP frm = new ReportViewerGP();
            
            GPPrint rep1 = new GPPrint();
            
            GpArchiveTable = GpArchiveView;
            rep1.DataSource = GpArchiveTable;
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
            // CursorWait();
        //    CursorDefault();


            return frm.ShowDialog();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
             CursorWait();
           // CursorDefault();
            Manager m = new Manager();
            ServerClasses.OutputDatas result = m.ClsPacksGps_PrintingGp(ServerClasses.AllFunctions._StatePrint.Printing, GpArchiveTable);
            if (!result.success)
            {
                // CursorWait();
                CursorDefault();
                MessageBox.Show(result.Message);
                return;
            }
            else
            {
                reportViewer1.PrintReport();
                // CursorWait();
                CursorDefault();
                if (MessageBox.Show("آیا عملیات چاپ با موفقیت صورت پذیرفت؟","اطلاعات چاپ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                     CursorWait();
                   // CursorDefault();
                    ServerClasses.OutputDatas printRes = m.ClsPacksGps_PrintedGP(ServerClasses.AllFunctions._StatePrint.Complete, GpArchiveTable);
                    if (!printRes.success)
                    {
                        // CursorWait();
                        CursorDefault();
                        MessageBox.Show(printRes.Message);
                    }
                }
                else
                {
                     CursorWait();
                    //CursorDefault();
                    ServerClasses.OutputDatas printRes = m.ClsPacksGps_PrintedGP(ServerClasses.AllFunctions._StatePrint.Free, GpArchiveTable);
                    if (!printRes.success)
                    {
                        // CursorWait();
                        CursorDefault();
                        MessageBox.Show(printRes.Message);
                    }
                }
                // CursorWait();
                CursorDefault();
                this.Close();
            }
        }

		private void ReportViewerGP_Load( object sender , EventArgs e )
		{

		}

		private void ReportViewerGP_Shown( object sender , EventArgs e )
		{
			toolStripButton1.Enabled = true;
		}
    }
}
