using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ServerClasses;
using Telerik.WinControls.UI;
using System.Globalization;
using System.Drawing;
using System.Reflection;

namespace aorc.gatepass
{
    public static class ItemsPublic
    {


        public enum _EsiGate : int
        {
            none = -1,
            gate1 = 8,
            gate2 = 9
        }

        public enum MiniGateWayEsiMode: byte
        {
            blocked =0,
            free=1,
            card=2,            
        }

        public enum MiniGateMainEsiMode : byte
        {
            NormalGate,
            EmergencyGate,
            BlockGate,            
            FreeRunGate,
            Unkown
        }

        public enum IndexStatus : byte
        {
            toView,
            toSearch,
            toNew,
            toEdit,
            toDelete,
            setPack,
            viewPack
        }
        
        public enum  MyEnumReportSatet : int
        {
            none = -1,
            person = 0,
            agreement = 1,
            office = 2,
            workPlace = 3,
            operators = 4,
            vehicle = 5
        }

        public static string BigErr = "";
        public static bool ConnectToServer;
        public static bool AcssesIsDenied;

        public static bool IsnewRowAdded { get; set; }
        public const string _infoDel = "عملیات حذف با موفقیت انجام پذیرفت";
        public const string _infoNew = "اطلاعات جدید افزوده شد";
        public const string _infoEdit = "عملیات ویرایش با موفقیت انجام شد";
        public const string _infoSelRow = "ابتدا آیتمی را انتخاب کنید";
        public const string _questionSureToDel = "آیا قصد حذف آیتم انتخابی را دارید";
        public const string _questionSureToEdit = "آیا قصد ویرایش آیتم انتخابی را دارید";

        public const string _errTitleCantEmpty = "عنوان نمی تواند خالی باشد";
        public const string _errCompanyCantEmpty = "نام شرکت نمی تواند خالی باشد";
        public const string _errDateCantEmpty = "تاریخ نمی تواند خالی باشد";
        public const string _errAgreementNumber = "شماره قرار داد صحیح نمی باشد";

        public const string _errOfficeNameCantEmpty = "نام اداره مقدار صحیحی ندارد";
        public const string _errParentDontFind = "اداره بالاسری یافت نشد";
        public const string _errBaridIdCantEmpty = "شماره برید کاربر وجود ندارد";
        public const string _errSignNotValue = "حق امضا تعیین تکلیف نشده";
        public const string _errStartDate = "تاریخ شروع تنظیم نیست";
        public const string _errEndDate = "تاریخ پایان تنظیم نیست";
        public const string _errNullOfficeOperatorsId = "اپراتوری یافت نشد";
        public const string _errNullGroup = "گروه یافت نشد";
        public const string _errConnection = "متاسفانه امکان برقراری ارتباط با سرور وجود ندارد";
        public const string _errCantFindId = "آیتم مورد نظر شناسایی نشد";
        public const string _errTaNameEmpty = "مقدار صحیحی برای نام محل کار وارد نشده است";
        public const string _errTaCantFindTaid = "قراردادی یافت نشد";
        public const string _errBlReasonNotFind = "آیتم مورد نظر یافت نشد";
        public const string _errBlReasonTypeIsEmpty = "نام نوع نمی تواند خالی باشد";
        public const string _errNotFindPerson = "شخصی یافت نشد";
        public const string _errTimeIsNull = "تاریخ تهی است";
        public const string _errStateIsNull = "وضعیت جدید نامشخص می باشد";
        public const string _errIndustrial = "نوع قرارداد نامشخص است";
        public const string _errPersonName = "نام فرد وارد نشده است";
        public const string _errPersonSurName = "نام خانوادگی وارد نشده است";
        public const string _errPersonFatherName = "نام پدر وارد نشده است";
        public const string _errNameEmpty = "نام نمی تواند خالی باشد";
        public const string _err = "";

        public static DataTable AllUserBarid { get; set; }
        public static DataTable AllCity { get; set; }
        public static DataTable AllNationality { get; set; }
        public static List<AllFunctions._Rights> MyRights { get; set; }
        public static Baridsoft.EOrg.Directory.BusinessObject.User CUser;
        public static string MyComputerName { get; set; }
        public static string MyIpAddress { get; set; }
        public static string MyOfficeName { get; set; }
        public static string MyGroupName { get; set; }
        public static int MyOfficeId { get; set; }
        public static decimal MyBaridId { get; set; }
        public static decimal MyOffOperId { get; set; }
        public static string EsiKey { get; set; }

        // public static bool isLogin { get; set; }
        //   public static RadTreeView MyRTV { get; set; }

        public static void Exeptor(params string[] message)
        {
            var exStr = message.Aggregate("", (current, s) => current + (s + "\n"));
            throw new Exception(exStr);
        }


        public static bool QuestionSureTo(string str)
        {

            var dr = MessageBox.Show(str, "هشدار", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
            return dr == DialogResult.Yes;
        }


        public static void ShowMessage(string str)
        {
            MessageBox.Show(str, "آگاهی", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        public static void SetAllLocations()
        {
            Manager objManager2 = new Manager();
            OutputDatas Result = new OutputDatas();
            //DtModels = null;
            //DtModels = new DataTable ();
            //DtModels.Columns.Add ( "VehicleType_ID" , typeof ( decimal ) );
            //DtModels.Columns.Add ( "VehicleType_Name" , typeof ( string ) );
            //DtModels.Columns.Add ( "VehicleType_Desc" , typeof ( string ) );
            //DtModels.Columns.Add ( "VehicleType_Hidden" , typeof ( bool ) );
            Result = objManager2.View_Nationalities();
            AllNationality = new DataTable();
            AllNationality.Columns.Add("Nationality_Id", typeof(int));
            AllNationality.Columns.Add("Nationality_Name", typeof(string));
            AllCity = new DataTable();
            AllCity.Columns.Add("City_Id", typeof(int));
            AllCity.Columns.Add("City_Name", typeof(string));
            if (!Result.success)
            {
                ItemsPublic.Exeptor(Result.Message);
            }

            foreach (DataRow item in Result.ResultTable.Rows)
            {
                AllNationality.Rows.Add(item["Nationality_Id"], item["Nationality_Name"]);
            }

            Result = objManager2.View_Cities();
            if (!Result.success)
            {
                ItemsPublic.Exeptor(Result.Message);
            }

            foreach (DataRow item in Result.ResultTable.Rows)
            {
                AllCity.Rows.Add(item["City_Id"], item["City_Name"]);
            }
        }

        public static string HowManyCarInAgree(decimal? Agreement_ID)
        {
            if (Agreement_ID == null)
            {
                //ItemsPublic.Exeptor("قرار دادی انتخاب نشده است");
                return string.Empty;
            }
            Customer ICustomer = new Customer();
            var Input = new Dictionary<AllFunctions._IdData, object>();
            Input.Add(AllFunctions._IdData.Event_ComputerName, ItemsPublic.MyComputerName);
            Input.Add(AllFunctions._IdData.Event_IpAddress, ItemsPublic.MyIpAddress);
            Input.Add(AllFunctions._IdData.OfficeOperators_Id, ItemsPublic.MyOffOperId);
            Input.Add(AllFunctions._IdData.IdMethod, AllFunctions._IdMethod.ClsAgreements_HowManayCarsInAgree);
            Input.Add(AllFunctions._IdData.Agreement_ID, Agreement_ID);
            var result = ICustomer.Suit(Serialize.BinarySerialize(Input));
            if (result.success)
            {
                string str = "تعداد";
                str += " " + result.ResultTable.Rows[1][0].ToString() + " " + "از" + " " + result.ResultTable.Rows[0][0].ToString() +
                       " " + "خودرو استفاده شده اند";
                return str;
            }
            else
            {
                MessageBox.Show(result.Message);
                return "نا مشخص";
            }
        }

        public static string GetMessage(string alert)
        {
            return Interaction.InputBox(alert, "توضیحات", string.Empty);
        }
        /// <summary>
        /// Convert Georgian Date to Persian Date
        /// </summary>
        /// <param name="dt">Date in Georgian</param>
        /// <returns>Persian Date in YYYY/MM/DD</returns>
        /// 
        public static int GetDayOfMonth(DateTime dt)
        {
            PersianCalendar p = new PersianCalendar();
            return p.GetDayOfMonth(dt);
        }
        public static string GetPersianDate(DateTime dt)
        {
            PersianCalendar p = new PersianCalendar();
            int y = p.GetYear(dt);
            int m = p.GetMonth(dt);
            int d = p.GetDayOfMonth(dt);
        
            return string.Format("{0}/{1}/{2}", y, (m > 9 ? m.ToString() : "0" + m), (d > 9 ? d.ToString() : "0" + d));
        }

        public static string TimeNow()
        {

            //  DateTime dt = DateTime.Now;
           //   TimeSpan ts = dt.Date;
          //    DateTime.Now.Date.ToShortDateString();

            return GetPersianDate(DateTime.Now);
        }

        public static string GetPersianHour(DateTime dt)
        {
            PersianCalendar p = new PersianCalendar();
            int h = p.GetHour(dt);
            int m = p.GetMinute(dt);
            int s = p.GetSecond(dt);
            
            return string.Format("{0}:{1}:{2}", h, (m > 9 ? m.ToString() : "0" + m), (s > 9 ? s.ToString() : "0" + s));
        }
        
        public static int GetDayOfYear(DateTime dt)
        {
            PersianCalendar p = new PersianCalendar();
            return p.GetDayOfYear(dt);
        }

        public static int DiffDateInDay(DateTime dt,DateTime dt2)
        {
            return ((int)(dt2 - dt).TotalDays + 1);
        }

        public static void checkText(object sender, KeyEventArgs e, string inText, int? maxCount)
        {

            if (
                  !(
                      (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                   || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                   || e.KeyCode == Keys.Left 
                   || e.KeyCode == Keys.Right
                   || e.KeyCode == Keys.Back 
                   || e.KeyCode == Keys.Delete
                   || e.KeyCode == Keys.ControlKey
                   || e.KeyCode == Keys.ShiftKey
                   || e.KeyCode == Keys.Home
                   || e.KeyCode == Keys.End
                   || (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Control)
                   || (e.KeyCode == Keys.V && Control.ModifierKeys == Keys.Control)
                   || (e.KeyCode == Keys.X && Control.ModifierKeys == Keys.Control)
                ))
            {

                e.SuppressKeyPress = true;
            }
            //if(Control.ModifierKeys == Keys.Control)
           // MessageBox.Show(Control.ModifierKeys.ToString());

                if (maxCount != null)
                {
                    if((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                   || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                   || (e.KeyCode == Keys.V && Control.ModifierKeys == Keys.Control)
                        )
                        if (inText.Trim().Count() >= maxCount)
                        {
                            e.SuppressKeyPress = true;
                        }
                }

            //if (!(
            //        (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            //        || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            //        || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right
            //        || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete))
            //{
            //    e.SuppressKeyPress = true;
            //}
            //if (maxCount != null)
            //{
            //    if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            //        || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            //        if (inText.Trim().Count() >= maxCount)
            //        {
            //            e.SuppressKeyPress = true;
            //        }
            //}
        }
        public static bool IsDigitNumber(string Input, int NumDigit)
        {

            if (string.IsNullOrEmpty(Input))
            {
                return false;
            }
            if (Input.Count() == NumDigit || (NumDigit == -1 && Input.Count() <= 10) || (NumDigit == -10 && Input.Count()<19))
            {
                try
                {
                    var result = decimal.Parse(Input);
                    if (result <= 0)
                    {
                        return false;
                    }
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            return false;
        }

        public static bool NationalCodeIsTrue(string strNatoCode)
        {
            strNatoCode = strNatoCode.Trim();
            if (strNatoCode.Count() != 10)
            {
                return false;
            }
            switch (strNatoCode)
            {
                case "0000000000":
                    return false;
                case "1111111111":
                    return false;
                case "2222222222":
                    return false;
                case "3333333333":
                    return false;
                case "4444444444":
                    return false;
                case "5555555555":
                    return false;
                case "6666666666":
                    return false;
                case "7777777777":
                    return false;
                case "8888888888":
                    return false;
                case "9999999999":
                    return false;
                default:
                    break;
            }
            var DigitControl = int.Parse(strNatoCode.Substring(9, 1));
            int CodeSum = 0;
            for (int i = 2; i < 11; i++)
            {
                CodeSum += ((i) * int.Parse(strNatoCode.Substring((10 - i), 1)));
            }
            int R11 = CodeSum % 11;
            if (R11 < 2 && DigitControl == R11)
            {
                return true;
            }
            else if (R11 >= 2 && DigitControl == (11 - R11))
            {
                return true;
            }
            return false;
        }

        public static void copyGrid(RadGridView CopyFrom, RadGridView ToCopy)
        {
            //if (ToCopy.Rows.Count > 0)
            //{
            //    while (ToCopy.Rows.Count > 0)
            //    {
            //        ToCopy.Rows.RemoveAt(0);
            //    }
            //}

            ToCopy.Rows.Clear();
            ToCopy.CurrentRow = null;
           // ToCopy.DataSource = null;
         //   bool exPic = false;
            foreach (GridViewRowInfo itemRow in CopyFrom.Rows)
            {
                ToCopy.Rows.AddNew();
                foreach (GridViewDataColumn col in CopyFrom.Columns)
                {
                    try
                    {
                        //if ( col.Name == "Person_Picture")
                        //{
                        //    var ms = new System.IO.MemoryStream();
                        //    var Picture = ((Bitmap)itemRow.Cells[col.Name].Value);
                        //    Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        //    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[col.Name].Value
                        //        = ms.ToArray();

                        //}
                        //else
                        //{
                            ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[col.Name].Value
                                   = itemRow.Cells[col.Name].Value;
                      //  }

                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            if (col.Name == "Person_Picture")
                            {
                                var ms = new System.IO.MemoryStream();
                                var Picture = ((Bitmap)itemRow.Cells[col.Name].Value);
                                Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[col.Name].Value= ms.ToArray();
                               // exPic = true;
                            }
                            else
                            {
                                ItemsPublic.Exeptor(col.Name + "\r\n" + ex.Message);
                            }
                        }
                        catch (Exception ex2)
                        {

                            ItemsPublic.Exeptor(col.Name + "\r\n" + ex.Message + "\r\n" + ex2.Message);
                        }

                     //   ItemsPublic.Exeptor(itemRow.Cells[col.Name].ColumnInfo.FieldName + "\r\n" + ex.Message);
                    }

                }
                ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_IsExpired"].Value = false;
            }



        }

        public static bool signPrint {
            get 
            { 
              Manager m = new Manager();
             OutputDatas od =    m.ClsGlobalSetting_AllowPrintSign();
             return (int)od.ResultTable.Rows[0][0] == 1;
            }
            set
            {

            }
        }

        public static void copyGrid(GridViewSelectedRowsCollection CopyFrom, RadGridView ToCopy)
        {

            Dictionary<int, int> Indexs = new Dictionary<int, int>();
            //  GridViewDataColumn col in ToCopy.Columns)

            for (int j =0 ; j<ToCopy.Columns.Count();j++)
            {
                for (int i = 0; i < CopyFrom[0].Cells.Count; i++)
                {
                    if (CopyFrom[0].Cells[i].ColumnInfo.FieldName == ToCopy.Columns[j].FieldName)
                    {
                        Indexs.Add(i, j);
                        break;
                    }
                }
            }

            foreach (GridViewRowInfo itemRow in CopyFrom)
            {
               // ToCopy.CurrentRow = null;
               // ToCopy.AllowAddNewRow = true;
                ToCopy.Rows.AddNew();
                foreach (var myIndex in Indexs)
                {
                    try
                    {

                        //if (itemRow.Cells[myIndex.Key].ColumnInfo.FieldName != "Person_Picture")
                        //{

                            ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[myIndex.Value].Value
                                   = itemRow.Cells[myIndex.Key].Value;


                            


                           // ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_State"].Value = true;
                            
                           // ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["Gatepass_ID"].Value = null;

                        //}
                        //else
                        //{
                        //   // var ms = new System.IO.MemoryStream();
                        //  //  var Picture = ((Bitmap)itemRow.Cells[myIndex.Key].Value);
                        //  //  Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        //    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[myIndex.Value].Value = itemRow.Cells[myIndex.Key].Value;
                        //}

                    }
                catch (Exception ex)
                    {
                        //try
                        //{
                        //    if (itemRow.Cells[myIndex.Key].ColumnInfo.FieldName == "Person_Picture")
                        //    {
                        //        var ms = new System.IO.MemoryStream();
                        //        var Picture = ((Bitmap)itemRow.Cells[myIndex.Key].Value);
                        //        Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //        ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[myIndex.Value].Value
                        //            = ms.ToArray();
                        //    }
                        //    else
                        //    {
                        //        ItemsPublic.Exeptor(itemRow.Cells[myIndex.Key].ColumnInfo.FieldName + "\r\n" + ex.Message);
                        //    }
                        //}
                        //catch (Exception ex2)
                        //{

                            ItemsPublic.Exeptor(itemRow.Cells[myIndex.Key].ColumnInfo.FieldName + "\r\n" + ex.Message );
                        //}
                    }

                    
                                      

              //      ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_State"].Value = true;
               //     ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_IsExpired"].Value = false;
                //    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["Gatepass_ID"].Value = null;


                }

                ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_IsExpired"].Value = false;
            }
        }

        public static void copyGridBack02(GridViewSelectedRowsCollection CopyFrom, RadGridView ToCopy)
        {


            Dictionary<int, int> Indexs = new Dictionary<int, int>();

            //  GridViewDataColumn col in ToCopy.Columns)

            for (int j = 0; j < ToCopy.Columns.Count(); j++)
            {
                for (int i = 0; i < CopyFrom[0].Cells.Count; i++)
                {
                    if (CopyFrom[0].Cells[i].ColumnInfo.FieldName == ToCopy.Columns[j].FieldName)
                    {
                        Indexs.Add(i, j);
                        break;
                    }
                }
            }

            foreach (GridViewRowInfo itemRow in CopyFrom)
            {
                // ToCopy.CurrentRow = null;
                // ToCopy.AllowAddNewRow = true;
                ToCopy.Rows.AddNew();
                foreach (var myIndex in Indexs)
                {
                    try
                    {

                        ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[myIndex.Value].Value
                               = itemRow.Cells[myIndex.Key].Value;

                        //}
                        //else
                        //{
                        //    var ms = new System.IO.MemoryStream();
                        //    var Picture = ((Bitmap)itemRow.Cells[myIndex.Key].Value);
                        //    Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        //    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[myIndex.Value].Value
                        //        = ms.ToArray();
                        //}

                    }


                    catch (Exception ex)
                    {
                        try
                        {
                            if (itemRow.Cells[myIndex.Key].ColumnInfo.FieldName == "Person_Picture")
                            {
                                var ms = new System.IO.MemoryStream();
                                var Picture = ((Bitmap)itemRow.Cells[myIndex.Key].Value);
                                Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[myIndex.Value].Value
                                    = ms.ToArray();
                            }
                            else
                            {
                                ItemsPublic.Exeptor(itemRow.Cells[myIndex.Key].ColumnInfo.FieldName + "\r\n" + ex.Message);
                            }
                        }
                        catch (Exception ex2)
                        {

                            ItemsPublic.Exeptor(itemRow.Cells[myIndex.Key].ColumnInfo.FieldName + "\r\n" + ex.Message + "\r\n" + ex2.Message);
                        }
                    }

                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_State"].Value = true;
                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_IsExpired"].Value = false;
                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["Gatepass_ID"].Value = null;


                    //      ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_State"].Value = true;
                    //     ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_IsExpired"].Value = false;
                    //    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["Gatepass_ID"].Value = null;


                }
            }
        }

        public static void copyGridBack01(GridViewSelectedRowsCollection CopyFrom, RadGridView ToCopy)
        {
            foreach (GridViewRowInfo itemRow in CopyFrom)
            {
                // ToCopy.CurrentRow = null;
                // ToCopy.AllowAddNewRow = true;
                ToCopy.Rows.AddNew();
                foreach (GridViewDataColumn col in ToCopy.Columns)
                {
                    try
                    {
                        // ToCopy.Rows[ToCopy.Rows.Count - 1] = itemRow;
                        //  GridViewCellInfo col in itemRow.Cells
                        for (int i = 0; i < itemRow.Cells.Count; i++)
                        {
                            if (itemRow.Cells[i].ColumnInfo.FieldName == col.FieldName)
                            {
                                ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[col.FieldName].Value
                            = itemRow.Cells[col.FieldName].Value;
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            if (col.FieldName == "Person_Picture")
                            {
                                var ms = new System.IO.MemoryStream();
                                var Picture = ((Bitmap)itemRow.Cells[col.FieldName].Value);
                                Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                                ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[col.FieldName].Value
                                    = ms.ToArray();

                            }
                            else
                            {
                                ItemsPublic.Exeptor(col.Name + "\r\n" + ex.Message);
                            }
                        }
                        catch (Exception ex2)
                        {

                            ItemsPublic.Exeptor(col.Name + "\r\n" + ex.Message + "\r\n" + ex2.Message);
                        }
                    }

                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_State"].Value = true;
                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_IsExpired"].Value = false;
                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["Gatepass_ID"].Value = null;


                }
            }
        }

        public static void copyGridFast(RadGridView CopyFrom, RadGridView ToCopy)
        {
            ToCopy.Visible = false;
                foreach (GridViewDataRowInfo itemRow in ToCopy.Rows)
                {
                    itemRow.Cells["GatePass_State"].Value = false;
                }
            
            foreach (GridViewDataRowInfo itemRow in CopyFrom.Rows)
            {
                if (ToCopy.Rows.Where(x => x.Cells["Person_NationalCode"].Value == itemRow.Cells["Person_NationalCode"].Value).Count() == 0)
                {
                    ToCopy.Rows.AddNew();
                    foreach (GridViewDataColumn col in CopyFrom.Columns)
                    {
                        try
                        {
                            ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[col.Name].Value
                                = itemRow.Cells[col.Name].Value;
                        }
                        catch (Exception ex)
                        {
                            try
                            {
                                if (col.Name == "Person_Picture")
                                {
                                    var ms = new System.IO.MemoryStream();
                                    var Picture = ((Bitmap)itemRow.Cells[col.Name].Value);
                                    Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[col.Name].Value
                                        = ms.ToArray();

                                }
                                else
                                {
                                    ItemsPublic.Exeptor(col.Name + "\r\n" + ex.Message);
                                }
                            }
                            catch (Exception ex2)
                            {

                                ItemsPublic.Exeptor(col.Name + "\r\n" + ex.Message + "\r\n" + ex2.Message);
                            }
                        }
                    }

                 //   ToCopy.Rows.First(x => x.Cells["Person_NationalCode"].Value 
                    //    == itemRow.Cells["Person_NationalCode"].Value).Cells["GatePass_State"].Value = true;

                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_State"].Value = true;
                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_IsExpired"].Value = false;
                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["Gatepass_ID"].Value = null;

                    //radGridViewSelected.CurrentRow.Cells["GatePass_IsExpired"].Value = null;
                }
                else
                {
                  //  ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_State"].Value = true;

                    ToCopy.Rows.First(x => x.Cells["Person_NationalCode"].Value
                       == itemRow.Cells["Person_NationalCode"].Value).Cells["GatePass_State"].Value = true;

                }
            }
            ToCopy.Refresh();
         //   var dd = ToCopy.Rows.Where(x => !(bool)x.Cells["GatePass_State"].Value);
            
         //   ToCopy.Rows.Remove(dd);

            ToCopy.AllowDeleteRow = true;
            int max = ToCopy.Rows.Count();
           
            for (int i = 0; i < max;i++ )
            {
                if (!(bool)ToCopy.Rows[i].Cells["GatePass_State"].Value)
                {
                    ToCopy.Rows.RemoveAt(i);
                    i = i-1;
                    max = max - 1;
                }
            }
            ToCopy.Refresh();
            ToCopy.Visible = true;
            //int i = 0;
            //while ( i < ToCopy.Rows.Count())
            //{
            //    if (!(bool)ToCopy.Rows[i].Cells["GatePass_State"].Value)
            //    {
            //        //ToCopy.DataSource = null;
            //        //ToCopy.cu = null;
            //        //ToCopy.CurrentRow = null;

            //        //if (ToCopy.SelectedRows.Count>0)
            //        //{
            //        //    ItemsPublic.ShowMessage("!!!");
            //        //}
            //      //  ToCopy.Rows.RemoveAt(i);
            //      //  ToCopy.Rows.Remove
            //        continue;
            //    }
            //    i++;
            //}

        }

        public static void copyGrid2(RadGridView CopyFrom, RadGridView ToCopy)
        {
            if (ToCopy.Rows.Count > 0)
            {
                while (ToCopy.Rows.Count > 0)
                {
                    ToCopy.Rows.RemoveAt(0);
                }
            }
            foreach (GridViewDataRowInfo itemRow in CopyFrom.Rows)
            {
                ToCopy.Rows.AddNew();
                foreach (GridViewDataColumn col in CopyFrom.Columns)
                {
                    try
                    {

                        ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[col.Name].Value
                            = itemRow.Cells[col.Name].Value;
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            if (col.Name == "Person_Picture")
                            {
                                var ms = new System.IO.MemoryStream();
                                var Picture = ((Bitmap)itemRow.Cells[col.Name].Value);
                                Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                                ToCopy.Rows[ToCopy.Rows.Count - 1].Cells[col.Name].Value
                                    = ms.ToArray();

                            }
                            else
                            {
                                ItemsPublic.Exeptor(col.Name + "\r\n" + ex.Message);
                            }
                        }
                        catch (Exception ex2)
                        {

                            ItemsPublic.Exeptor(col.Name + "\r\n" + ex.Message + "\r\n" + ex2.Message);
                        }
                    }

                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_State"].Value = false;
                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["GatePass_IsExpired"].Value = false;
                    ToCopy.Rows[ToCopy.Rows.Count - 1].Cells["Gatepass_ID"].Value = null;
                }
            }
        }

        public static string InfoVersion()
        {
               return   Assembly.GetExecutingAssembly().GetName().Version.ToString();

        }
        }
}