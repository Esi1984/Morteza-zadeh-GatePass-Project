using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace aorc.gatepass.ui.group
{
    public partial class frm_SelectRights : aorc.gatepass.TinyForm
    {
        public frm_SelectRights()
        {
            InitializeComponent();
        }
        public DataTable RightsSelected;
        public RadGridView CurrentGrid { get; set; }
        private void frm_SelectRights_Load(object sender, EventArgs e)
        {
            this.Width = 247;
            this.Height = 550;
            cbreSearch.Visibility = ElementVisibility.Hidden;
            cbbView_Click(sender,e);
            foreach (var myrow in MainRadGridView.Rows)
            {
                myrow.Cells["Right_Selected"].Value = false;
                foreach (var Row in CurrentGrid.Rows)
                {
                    if ((int)myrow.Cells["Right_ID"].Value == (int)Row.Cells["Right_ID"].Value)
                    {
                        myrow.Cells["Right_Selected"].Value = true;
                        break;
                    }
                }
            } 
        }

        private void frm_SelectRights_eventSaveToView()
        {
            result = objManager.View_rights(null,null);
        }

        private void radGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (MainRadGridView.SelectedRows.Count == 1)
            {
                if (e.Column.Name == "Right_Selected")
                {
                    bool temp;
                    if (radGridView1.CurrentRow.Cells["Right_Selected"].Value != null)
                    {
                        temp = bool.Parse(radGridView1.CurrentRow.Cells["Right_Selected"].Value.ToString());
                    }
                    else
                    {
                        temp = true;
                    }
                    radGridView1.CurrentRow.Cells["Right_Selected"].Value = !temp;
                }
            }
        }

        private void frm_SelectRights_eventSaveTiny()
        {
            RightsSelected = new DataTable();
            RightsSelected.Columns.Add("Right_ID", typeof (int));
            RightsSelected.Columns.Add("Right_Name", typeof (string));
            RightsSelected.Columns.Add("Right_Label", typeof (string));
            RightsSelected.Columns.Add("Right_Description", typeof (string));
         //  RightsSelected.Columns.Add("Right_Selected", typeof (bool));
          //  CurrentGrid.Rows.Clear();
            MainRadGridView.Visible = false;
            //for (int i = 0; i < MainRadGridView.Rows.Count; i++)
            //{
            //    if ((bool)MainRadGridView.Rows[i].Cells["Right_Selected"].Value || MainRadGridView.Rows[i].Cells["Right_Selected"].Value==null)
            //    {
            //        MainRadGridView.Rows[i].Delete();
            //    }
            //}
            foreach (var row in MainRadGridView.Rows)
            {
                if ((bool)row.Cells["Right_Selected"].Value)
                {
                    RightsSelected.Rows.Add();
                    RightsSelected.Rows[RightsSelected.Rows.Count - 1]["Right_ID"] =(int) row.Cells["Right_ID"].Value;
                    RightsSelected.Rows[RightsSelected.Rows.Count - 1]["Right_Name"] =row.Cells["Right_Name"].Value.ToString();
                    RightsSelected.Rows[RightsSelected.Rows.Count - 1]["Right_Label"] = row.Cells["Right_Label"].Value.ToString();
                    RightsSelected.Rows[RightsSelected.Rows.Count - 1]["Right_Description"] = row.Cells["Right_Description"].Value.ToString();
                //    RightsSelected.Rows[RightsSelected.Rows.Count - 1]["Right_Selected"] = (bool)row.Cells["Right_Selected"].Value;
                   // row.Delete();
                  //  CurrentGrid.Rows.Add(row);
                }
            }
           // CurrentGrid = MainRadGridView;
        }
    }
}