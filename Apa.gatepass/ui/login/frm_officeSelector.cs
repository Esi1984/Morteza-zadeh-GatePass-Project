using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServerClasses;
using System;
namespace aorc.gatepass.ui.login
{
    public partial class frm_officeselector : Form
    {

        public frm_officeselector(DataTable InDt)
        {
            InitializeComponent();

            dt = InDt;
        }
        //public decimal UserID;
        DataTable dt;
        public int indexSelected = -1;
        private void frm_officeselector_Load(object sender, EventArgs e)
        {
            try
            {
                       // this.Visible = true;
                        comboBox1.Items.Clear();
                        foreach (DataRow item in dt.Rows)
                        {
                            comboBox1.Items.Add(item.ItemArray[3].ToString());
                        }
                        comboBox1.SelectedIndex = 0;
             
                //   ItemsPublic.ConnectToServer = true;
            }catch(Exception ex)
            {
               // MessageBox.Show("عملیات لاگین به سامانه مجوز تردد با خطا مواجه شده است");
                ItemsPublic.ConnectToServer = false;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                indexSelected = comboBox1.SelectedIndex;
                this.Close();

                //ItemsPublic.MyOfficeId = Convert.ToInt32(dt.Rows[comboBox1.SelectedIndex][0]);
                //ItemsPublic.MyOfficeName = dt.Rows[comboBox1.SelectedIndex][3].ToString();
                //var obj = new Customer();
                //var input = new Dictionary<AllFunctions._IdData, object>();
                //input.Add(AllFunctions._IdData.Event_ComputerName, System.Net.Dns.GetHostName());
                //input.Add(AllFunctions._IdData.Operator_BaridId, ItemsPublic.MyBaridId);
                //input.Add(AllFunctions._IdData.Office_ID, ItemsPublic.MyOfficeId);
                //input.Add(AllFunctions._IdData.Event_IpAddress, ItemsPublic.MyIpAddress);
                //input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsOffOper_MyOffOperId);

                //var Point = new OutputDatas();
                //Point = obj.Suit(Serialize.BinarySerialize(input));
                ////    Point = obj.Suit(Class1.BinarySerialize(input));
                //DataTable dt2;
                //if (Point.success)
                //{
                //    dt2 = Point.ResultTable;
                //    ItemsPublic.MyOffOperId = Convert.ToDecimal(dt2.Rows[0][0]);
                //    var myList2 = new List<AllFunctions._Rights>();
                //    for (int i = 1; i < dt2.Rows.Count; i++)
                //        myList2.Add((AllFunctions._Rights) int.Parse(dt2.Rows[i][0].ToString()));
                //    ItemsPublic.MyRights = myList2;
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show(Point.Message);
                //    ItemsPublic.AcssesIsDenied = true;
                //    this.Close();
                //}
            }catch
            {
               // MessageBox.Show("عملیات لاگین به سامانه مجوز تردد با خطا مواجه شده است");
                ItemsPublic.ConnectToServer = false;
                this.Close();
            }
            ItemsPublic.ConnectToServer = true;
        }
    }
}
