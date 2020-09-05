using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using Telerik.WinControls.UI;
using aorc.gatepass;
using System.Data;

namespace Laitner
{
    internal class ManageExcel
    {

        protected Manager objManager = new Manager();
        private const int _firstFace = 0;
        private const int _secondFace = 1;
        private const int _Desc = 2;

        private string WhatMyGroups(decimal OfficeOperators_Id)
        {
            string rrr = "";
            var WhatGroups = objManager.View_groups(null, null, OfficeOperators_Id);
            if (WhatGroups.success)
            {
                //radGridViewSearch.DataSource = WhatGroups.ResultTable;
                //if (CurrentInfo != null)
              
                
                foreach (DataRow item in WhatGroups.ResultTable.Rows)
                {
                    rrr += item["Group_Name"].ToString().Trim() + "  -  ";
                }
               
            }
            else
            {
                MessageBox.Show(WhatGroups.Message);               
            }

            return rrr;

        }

        public void WirteToExcel(ref RadGridView InRad)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "*.xlsx";
            openFileDialog1.FileName = "*.xls";
            System.Windows.Forms.TextBox t1 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox t2 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox t3 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox t4 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox t5 = new System.Windows.Forms.TextBox(); 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int counterExit = 0;
                //var ExcelObj = new Microsoft.Office.Interop.Excel.Application();
                //object missVal = System.Reflection.Missing.Value;
                //Excel.Workbook theWorkbook = ExcelObj.Workbooks.Add(missVal);
                ////Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(
                ////    openFileDialog1.FileName, 0, true, 5,
                ////    "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);
                //Excel.Sheets sheets = theWorkbook.Worksheets;
                //Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);
                int i = 1;
                t1.Text = "";
                t2.Text = "";
                t3.Text = "";
                t4.Text = "";
                t5.Text = "";
                foreach (var item in InRad.Rows)
                {
                    //   Excel.Range range = worksheet.get_Range("A" + i.ToString(), "C" + i.ToString());
                    //   var myvalues = (System.Array)range.Cells.Value;
                    t1.Text  += item.Cells["BaridName"].Value.ToString()+"\r\n";
                    t2.Text += item.Cells["Office_Name"].Value.ToString() + "\r\n";
                    t3.Text += WhatMyGroups((decimal)item.Cells["OfficeOperators_Id"].Value) + "\r\n";
                    t4.Text += item.Cells["BaridJob"].Value.ToString() + "\r\n";
                    t5.Text += item.Cells["Operator_Tellphone1"].Value.ToString() + "\r\n";

                    i++;

                       // worksheet.Cells[1, 3] = item.Cells[""].Value.ToString();
                    //    worksheet.Cells[1,1] = "aaaaaaaa";
                    // worksheet.SaveAs("c:\aaaaaa");


                }

               //     theWorkbook.Saved = true;
               //     theWorkbook.SaveAs(openFileDialog1.FileName+"123" );
                    //theWorkbook.Save();
               //     ExcelObj.UserControl = false;
                //    ExcelObj.Quit();
                //    theWorkbook.Close();
                   // Process.Start("theWorkbook");
            //    MessageBox.Show("ff");
                
            }

        }

        private string FindMultiLines(string value)
        {
                string str = "";
                string cc = "";
                for (int i = 0; i < value.Count(); i++)
                {
                  cc=  value.Substring(i, 1);
                    if(cc !=";")
                    {
                        str += cc;
                    } else
                    {
                        str += "\r\n";
                    }
                }
               return  str;
        }

      

     

        private string[] ConvertToStringArray(System.Array values)
        {

            // create a new string array
            string[] theArray = new string[values.Length];

            // loop through the 2-D System.Array and populate the 1-D String Array
            for (int i = 1; i <= values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    theArray[i - 1] = "";
                else
                    theArray[i - 1] = (string) values.GetValue(1, i).ToString();
            }

            return theArray;
        }

        public int TypeCardsId { get; set; }
    }
}
