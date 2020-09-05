using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.Complex_Reports.Uc_Mini
{
    public partial class UC_SelAgree : UserControl
    {
        public decimal? CurrentAgreeId { get; set; }
        public UC_SelAgree()
        {
            InitializeComponent();
        }

        private void rbtnAgree_Click(object sender, EventArgs e)
        {
            if (rtbNumberAgree.Text.Trim().Count() > 5)
            {
                Manager objManager = new Manager();
                var resultFindAgree = objManager.View_agreements(null, null, null, null, null, null, null, null, rtbNumberAgree.Text.Trim());
                if (resultFindAgree.success)
                {
                    if (resultFindAgree.ResultTable.Rows.Count > 0)
                    {
                        CurrentAgreeId = decimal.Parse(resultFindAgree.ResultTable.Rows[0]["Agreement_ID"].ToString().Trim());
                        rtbNumberAgree.Text = resultFindAgree.ResultTable.Rows[0]["Agreement_Number"].ToString().Trim();
                        rtbCompanyAgree.Text = resultFindAgree.ResultTable.Rows[0]["Agreement_Company"].ToString().Trim();
                        // rtbTitleAgree.Text = resultFindAgree.ResultTable.Rows[0]["Agreement_Title"].ToString().Trim();
                        rlblCountCar.Text = ItemsPublic.HowManyCarInAgree(CurrentAgreeId);
                    }
                    else
                    {
                        rlblHintAgree.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show(resultFindAgree.Message);
                }
            }
        }

        private void rbtnAgree_TextChanged(object sender, EventArgs e)
        {
            rlblHintAgree.Visible = false;
            CurrentAgreeId = null;
            rtbCompanyAgree.Text = "";
            rlblCountCar.Text = "";
        }
    }
}
