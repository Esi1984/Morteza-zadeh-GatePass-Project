using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI;
using ServerClasses;
using Telerik.WinControls;
using aorc.gatepass.Complex_Reports.Uc_Mini;

namespace aorc.gatepass.Complex_Reports.ReportGH
{
    public partial class frm_SelectOneAgree : Form
    {
      public  clsReportCase objAgree = new clsReportCase();        

        public frm_SelectOneAgree()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                this.Close();
            }
        }

        Manager objManager = new Manager();
        private OutputDatas result = new OutputDatas();
        protected bool CheckOneSelectedRow(int countSelectedRows)
        {
            if (countSelectedRows != 1)
            {
                MessageBox.Show(ItemsPublic._infoSelRow);
                return false;
            }
            return true;
        }

        private void cbbSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckOneSelectedRow(radGridViewSelected.SelectedRows.Count))
                {
                    if (radGridViewSelected.CurrentRow != null)
                    {
                        objAgree.SelectedCase.SpecialCode = decimal.Parse(radGridViewSelected.CurrentRow.Cells["Agreement_Number"].Value.ToString());
                        objAgree.SelectedCase.ID = (decimal)radGridViewSelected.CurrentRow.Cells["Agreement_ID"].Value;
                        objAgree.SelectedCase.Fname = radGridViewSelected.CurrentRow.Cells["Agreement_Title"].Value.ToString().Trim();
                        objAgree.SelectedCase.Sname = "شرکت/پیمانکار" + " : " + radGridViewSelected.CurrentRow.Cells["Agreement_Company"].Value.ToString().Trim() + " " + "به شماره قرارداد";
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
            }
        }

        private void cbbUnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                objAgree.CurrentCase = null;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
            }
        }

        private void cbbSave_Click(object sender, EventArgs e)
        {
            cbbSelect_Click(sender,e);

        }

        private void cbbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frm_SelectOneAgree_Load(object sender, EventArgs e)
        {
            if (!ItemsPublic.MyRights.Contains(AllFunctions._Rights.View_agreements))
            {
                pnlMore.Visible = false;
            }
        }


       

        private void radGridViewSelected_DoubleClick(object sender, EventArgs e)
        {
          //  cbbSelect_Click(sender, e);
            cbbSave_Click(sender, e);
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
        private void rbtnSelectPerson_Click(object sender, EventArgs e)
        {
            try
            {
                CursorWait();
 
                 bool? tempType = null;
            if(rddlTypeAgree.SelectedIndex!=-1)
            {
                tempType = rddlTypeAgree.SelectedIndex == 0;
            }


                result = objManager.View_agreements(null,null,null,null,rtbManagerName.Text.Trim(),string.Empty,rtbCompany.Text.Trim(),tempType,rmebNumber.Text.Trim());

                if (result.success)
                {
                    radGridViewSelected.DataSource = result.ResultTable;
                    if (radGridViewSelected.Rows.Count<1)
                    {
                        CursorDefault();
                        ItemsPublic.ShowMessage("موردی یافت نشد");
                    }
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
                CursorDefault();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                CursorDefault();
            }
 
        }

        private void frm_SelectOneAgree_Shown(object sender, EventArgs e)
        {
            rmebNumber.Focus();
        }



        private void rmebNumber_KeyDown(object sender, KeyEventArgs e)
        {
            ItemsPublic.checkText(sender, e, rmebNumber.Text, null);
        }

        private void cbbEmpty_Click(object sender, EventArgs e)
        {
            rtbCompany.Text = "";
            rtbManagerName.Text = "";
            rmebNumber.Text = "";
            rddlTypeAgree.SelectedIndex = -1;
        }



       

    }
}
