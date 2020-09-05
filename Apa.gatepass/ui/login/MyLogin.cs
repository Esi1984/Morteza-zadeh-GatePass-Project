using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerClasses;
using System.Data;

namespace aorc.gatepass.ui.login
{
    class MyLogin
    {
        DataTable dt;
     //   Dictionary<int, string> comboBox1;
        public void Start()
        {
            try
            {
                //this.Visible = false;
                ItemsPublic.AcssesIsDenied = false;
                ItemsPublic.ConnectToServer = true;
                Customer customer = new Customer();
                var input = new Dictionary<AllFunctions._IdData, object>();
                input.Add(AllFunctions._IdData.Event_ComputerName, ItemsPublic.MyComputerName);
                input.Add(AllFunctions._IdData.Operator_BaridId, ItemsPublic.MyBaridId);
                input.Add(AllFunctions._IdData.Event_IpAddress, ItemsPublic.MyIpAddress);
                input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.View_offices);
                var result = new OutputDatas();
                result = customer.Suit(Serialize.BinarySerialize(input));
                if (result == null)
                {
                    ItemsPublic.ConnectToServer = false;
                  //  this.Close();
                    return;
                }
                if (result.success)
                {
                    dt = result.ResultTable;
                    if (dt.Rows.Count == 1)
                    {
                       // comboBox1.Add((int)dt.Rows[0].ItemArray[0], dt.Rows[0].ItemArray[3].ToString());
                       // comboBox1.SelectedIndex = 0;
                       // button1_Click(sender, e);
                        Login((int)dt.Rows[0].ItemArray[0], dt.Rows[0].ItemArray[3].ToString());

                    }
                    else if (dt.Rows.Count == 0)
                    {
                        ItemsPublic.AcssesIsDenied = true;
                      //  this.Close();
                        return;
                    }
                    else
                    {
                      //  this.Visible = true;


                       // comboBox1 = new Dictionary<int, string>();

                        frm_officeselector frm = new frm_officeselector(dt);

                        frm.ShowDialog();
                       // int temp = frm.indexSelected;

                        if (frm.indexSelected < 0)
                        {
                            ItemsPublic.Exeptor("اداره ای انتخاب نشده است");
                        }

                        Login((int)dt.Rows[frm.indexSelected].ItemArray[0], dt.Rows[frm.indexSelected].ItemArray[3].ToString());
                        //foreach (DataRow item in dt.Rows)
                        //{
                        //    comboBox1.Items.Add(item.ItemArray[3].ToString());
                        //}
                        //comboBox1.SelectedIndex = 0;
                    }
                }
                else
                {
                    ItemsPublic.AcssesIsDenied = true;
                    ItemsPublic.ShowMessage(result.Message);
                   // MessageBox.Show(result.Message);
                   // this.Close();
                }
                //   ItemsPublic.ConnectToServer = true;
            }
            catch (Exception ex)
            {
                ItemsPublic.ShowMessage(ex.Message);
                // MessageBox.Show("عملیات لاگین به سامانه مجوز تردد با خطا مواجه شده است");
                ItemsPublic.ConnectToServer = false;
                //this.Close();
            }
        }

        private void Login(int IdOffice,string OffName)
        {
            try
            {
                ItemsPublic.MyOfficeId = Convert.ToInt32(IdOffice);
                ItemsPublic.MyOfficeName = OffName;// dt.Rows[comboBox1.SelectedIndex][3].ToString();
                var obj = new Customer();
                var input = new Dictionary<AllFunctions._IdData, object>();
                input.Add(AllFunctions._IdData.Event_ComputerName, System.Net.Dns.GetHostName());
                input.Add(AllFunctions._IdData.Operator_BaridId, ItemsPublic.MyBaridId);
                input.Add(AllFunctions._IdData.Office_ID, ItemsPublic.MyOfficeId);
                input.Add(AllFunctions._IdData.Event_IpAddress, ItemsPublic.MyIpAddress);
                input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOffOper_MyOffOperId);

                var Point = new OutputDatas();
                Point = obj.Suit(Serialize.BinarySerialize(input));
                //    Point = obj.Suit(Class1.BinarySerialize(input));
                DataTable dt2;
                if (Point.success)
                {
                    dt2 = Point.ResultTable;
                    ItemsPublic.MyOffOperId = Convert.ToDecimal(dt2.Rows[0][0]);
                    var myList2 = new List<AllFunctions._Rights>();
                    for (int i = 1; i < dt2.Rows.Count; i++)
                        myList2.Add((AllFunctions._Rights)int.Parse(dt2.Rows[i][0].ToString()));
                    ItemsPublic.MyRights = myList2;
                 //  this.Close();
                }
                else
                {
                    ItemsPublic.ShowMessage(Point.Message);
                   // MessageBox.Show();
                    ItemsPublic.AcssesIsDenied = true;
                  //  this.Close();
                }
            }
            catch
            {
                // MessageBox.Show("عملیات لاگین به سامانه مجوز تردد با خطا مواجه شده است");
                ItemsPublic.ConnectToServer = false;
              //  this.Close();
            }
            ItemsPublic.ConnectToServer = true;
        }
    }
}
