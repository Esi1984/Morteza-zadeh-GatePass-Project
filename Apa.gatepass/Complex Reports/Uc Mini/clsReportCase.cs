using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aorc.gatepass.Complex_Reports.Uc_Mini
{
 public   class clsReportCase
    {

    public  struct MyReportCase
        {
            public decimal? ID;
            public decimal? SpecialCode;
            public decimal? SecondSpecialCode;
            public string Fname;
            public string Sname;
            public string Lname;
            public string Desc;
            public bool? stateBool1;
            public bool? limitedOffice;
            public string Label
            {
                get
                {
                    if (ID != null)
                    {
                        return Fname + " " + Sname + " " + SpecialCode.ToString();
                    }
                    return string.Empty;
                }
            }
        }

       public MyReportCase SelectedCase;

       public MyReportCase? CurrentCase
        {
            get
            {
                if (SelectedCase.ID != null)
                {
                    return SelectedCase;
                }
                else
                {
                    return null;
                }

            }
            set
            {
                if (value != null)
                {
                    SelectedCase = (MyReportCase)value;
                }
                else
                {
                    SelectedCase.ID = null;
                    SelectedCase.SpecialCode = null;
                    SelectedCase.Fname = string.Empty;
                    SelectedCase.Sname = string.Empty;
                    SelectedCase.Lname = string.Empty;
                    SelectedCase.Desc = string.Empty;
                    SelectedCase.stateBool1 = null;
                }
            }
        }
        public clsReportCase()
        {
              
            SelectedCase = new MyReportCase();
        }

        //public void Limit()
        //{
        //    SelectedCase.limitedOffice = true;
        //}
    }
}
