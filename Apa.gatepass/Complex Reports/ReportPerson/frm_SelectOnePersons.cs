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

namespace aorc.gatepass.Complex_Reports.ReportPerson
{
    public partial class frm_SelectOnePersons : Form
    {
      public  clsReportCase objPerson = new clsReportCase();        

        public frm_SelectOnePersons()
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
            rtbName.Text = "";
            rtbSurname.Text = "";
            rtbFatherName.Text = "";
            rtbNationalCode.Text = "";
        }

        private void rtbSearchPerson_TextChanged(object sender, EventArgs e)
        {
            if (rtbNationalCode.Text.Trim().Count() > 10)
            {
                rtbNationalCode.Text = rtbNationalCode.Text.Substring(0, 10);
            }
        }

        private void cbbSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckOneSelectedRow(radGridViewSelected.SelectedRows.Count))
                {
                    if (radGridViewSelected.CurrentRow != null)
                    {
                        objPerson.SelectedCase.SpecialCode = decimal.Parse(radGridViewSelected.CurrentRow.Cells["Person_NationalCode"].Value.ToString());
                        objPerson.SelectedCase.ID = (decimal)radGridViewSelected.CurrentRow.Cells["Person_ID"].Value;
                        objPerson.SelectedCase.Fname = radGridViewSelected.CurrentRow.Cells["Person_Name"].Value.ToString().Trim();
                        objPerson.SelectedCase.Sname = radGridViewSelected.CurrentRow.Cells["Person_SurName"].Value.ToString().Trim();
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
                objPerson.CurrentCase = null;
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

        private void frm_SelectOnePersons_Load(object sender, EventArgs e)
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
                result = objManager.View_persons(
                null, null,
                null, null,
                rtbName.Text.Trim(),
                rtbSurname.Text.Trim(),
                rtbNationalCode.Text.Trim(),
                  null, null,null,
                string.Empty);
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

        private void frm_SelectOnePersons_Shown(object sender, EventArgs e)
        {
            rtbNationalCode.Focus();
        }


        private void rtbSearchPerson_KeyDown(object sender, KeyEventArgs e)
        {
            ItemsPublic.checkText(sender, e, rtbNationalCode.Text, 10);
        }

        private void cbbEmpty_Click(object sender, EventArgs e)
        {
            rtbFatherName.Text = "";
            rtbName.Text = "";
            rtbNationalCode.Text = "";
            rtbSurname.Text = "";
        }



    }
}
