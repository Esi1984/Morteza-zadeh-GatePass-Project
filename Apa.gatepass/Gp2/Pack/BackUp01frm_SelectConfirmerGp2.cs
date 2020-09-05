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

namespace aorc.gatepass.Gp2.Pack
{
    public partial class BackUp01frm_SelectConfirmerGp2 : Form
    {
        public BackUp01frm_SelectConfirmerGp2()
        {            
                InitializeComponent();           
        }

        Manager objConfirmer = new Manager();
        
        private OutputDatas ODConfirmer = new OutputDatas();     		  

        private void cbbSave_Click(object sender, EventArgs e)
        {
            if (rddlConfirmer.SelectedIndex != -1 )
            {     
                BaridIdConfirmer = indexConfirmer;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (ItemsPublic.EsiKey == "1")
            {
                BaridIdConfirmer = null;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else 
            {
                BaridIdConfirmer = null;
                ItemsPublic.ShowMessage("گیرنده پیام انتخاب نشده است");
            }       	
        }

        private void cbbCancel_Click(object sender, EventArgs e)
        {
            BaridIdConfirmer = null;
			this.Close();
        }
		
        private void SetConfirmsList()
        {
            var objC = new Manager();
            ODConfirmer = new OutputDatas();
            ODConfirmer = objC.MyConfirmers(null);
            if (ODConfirmer.success)
            {
               // rddlConfirmer.DataSource = ODConfirmer.ResultTable.Columns["BaridName"];
                for (int index = 0; index < ODConfirmer.ResultTable.Rows.Count; index++)
                {
                    rddlConfirmer.Items.Add((string)ODConfirmer.ResultTable.Rows[index]["BaridName"]);
                }
            }
            else
            {
                ItemsPublic.ShowMessage(ODConfirmer.Message);
            }
        }

        //  private decimal SetrddlConfirmer(decimal rddlIndex)
     //   {         
            //   VehicleType_ID				       VehicleType_Name

            //for (int i = 0; i < ODConfirmer.ResultTable.Rows.Count; i++)
            //{
            //    if ((int)ODConfirmer.ResultTable.Rows[i]["Operator_BaridId"] == Operator_BaridId)
            //    {
            //        return i;
            //    }
            //}

          //  return (decimal)ODConfirmer.ResultTable.Rows[rddlIndex]["Operator_BaridId"];
          //  ItemsPublic.Exeptor("اپراتور یافت نشد");
          //  return -1;
      //  }


        public decimal? BaridIdConfirmer;
        private decimal? indexConfirmer
        {
            get {
                int ij = ODConfirmer.ResultTable.Rows.Count;
                string str = ODConfirmer.ResultTable.Rows[rddlConfirmer.SelectedIndex]["Operator_BaridId"].ToString();
                decimal? kk = (decimal?)ODConfirmer.ResultTable.Rows[rddlConfirmer.SelectedIndex]["Operator_BaridId"];
                return rddlConfirmer.SelectedIndex > -1 ? kk : null; }
            set {  }
            //rddlConfirmer.SelectedIndex = value != null ? SetrddlConfirmer((decimal)value) : -1;
        }

        private void BackUp01frm_SelectConfirmerGp2_Load(object sender, EventArgs e)
        {
            BaridIdConfirmer = null;
            SetConfirmsList();
        }

        private void BackUp01frm_SelectConfirmerGp2_Shown(object sender, EventArgs e)
        {
            CursorDefault();
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
        
    }
}
