using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.forms
{
    public partial class superform : Form
    {
        public superform()
        {
            InitializeComponent();
        }
        #region Security Properties
        /// <summary>
        ///     دسترسی به فرم برنامه
        /// </summary>
        /// <remarks>باز شدن فرم منوط به وجود این مقدار در لیست دسترسی ها می باشد.</remarks>
        [Category("APA Security")]
        [Description("Right require to open form")]
        public string ApaOpenRight { get; set; }

        /// <summary>
        ///     دسترسی ایجاد آیتم جدید در فرم
        /// </summary>
        /// <remarks>ایجاد یک آیتم جدید در این فرم منوط به وجود این دسترسی می باشد.</remarks>
        [Category("APA Security")]
        [Description("Right require to Add new Item")]
        public string ApaAddRight { get; set; }

        /// <summary>
        ///     دسترسی ویرایش آیتمها در این فرم
        /// </summary>
        /// <remarks>ویرایش آیتمها در این فرم منوط به وجود این دسترسی می باشد.</remarks>
        [Category("APA Security")]
        [Description("Right Require to Edit Items")]
        public string ApaEditRight { get; set; }

        /// <summary>
        ///     دسترسی حذف آیتم های این فرم
        /// </summary>
        /// <remarks>حذف آیتمها در این فرم منوط به وجود این دسترسی می باشد.</remarks>
        [Category("APA Security")]
        [Description("Right Require to Delete Items")]
        public string ApaDeleteRight { get; set; }



        /// <summary>
        /// بررسی وجود یک دسترسی در لیست دسترسیهای کاربر وارد شده
        /// </summary>
        /// <param name="value">عنوان دسترسی مورد نیاز به صورت رشته</param>
        /// <returns>این تابع مقدار True/False بر می گرداند</returns>
        public bool CheckPermision(string value)
        {
            if (value == null)
            {
                return false;
            }
            if (value.Trim() == string.Empty)
            {
                return false;
            }
            string result;
            try
            {
                result = SecurityList.Find(
                delegate(string security)
                {
                    return security == value;
                }
                );
            }
            catch (ArgumentNullException)
            {

                return false;
            }
            if (result == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// لیست دسترسیهای مجاز کاربر
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// 
        [Category("APA Security")]
        [Description("List Of all availible security for loged in user")]
        public List<string> SecurityList { get; set; }
        #endregion
        
        /// <summary>
        /// تعیین وضعیت گزینه های ویرایش
        /// </summary>
        [Category("APA Security")]
        [Description("Visible/Unvisible Edit Parameters")]
        public bool ShowEditFunctions { get; set; }
        
    }

}
