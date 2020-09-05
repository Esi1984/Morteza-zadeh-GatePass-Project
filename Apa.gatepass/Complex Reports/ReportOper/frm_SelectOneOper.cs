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

namespace aorc.gatepass.Complex_Reports.ReportOper
{
    public partial class frm_SelectOneOper : Form
    {
      public  clsReportCase objOper = new clsReportCase();        

        public frm_SelectOneOper()
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
        private void EmptyProperty()
        {            
            rtbBardiName.Text = "";            
        }


        private void cbbSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckOneSelectedRow(radGridViewSelected.SelectedRows.Count))
                {
                    if (radGridViewSelected.CurrentRow != null)
                    {
                     //   objOper.SelectedCase.SpecialCode = decimal.Parse(radGridViewSelected.CurrentRow.Cells["BaridUserCode"].Value.ToString());
                        objOper.SelectedCase.ID = (int)radGridViewSelected.CurrentRow.Cells["Operator_ID"].Value;
                        objOper.SelectedCase.Fname = radGridViewSelected.CurrentRow.Cells["BaridName"].Value.ToString().Trim();
                        objOper.SelectedCase.Sname = "به کد کاربری" +" : "+ radGridViewSelected.CurrentRow.Cells["BaridUserCode"].Value.ToString().Trim();
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
                objOper.CurrentCase = null;
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

        private void frm_SelectOneOper_Load(object sender, EventArgs e)
        {

        }

        private void radGridViewSelected_DoubleClick(object sender, EventArgs e)
        {
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
                result = objManager.View_operators(null,rtbBardiName.Text.Trim(),string.Empty);
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

        //private void rtbSearchPerson_Enter(object sender, EventArgs e)
        //{
        //    rtbNationalCode.SelectionStart = 0;
        //    rtbNationalCode.SelectionLength = rtbNationalCode.Text.Length;
        //}

        private void frm_SelectOneOper_Shown(object sender, EventArgs e)
        {
            rtbBardiName.Focus();
        }


         private void cbbEmpty_Click(object sender, EventArgs e)
        {
            rtbBardiName.Text = "";
        }

         



    }
}
