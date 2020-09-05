using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aorc.gatepass.forms
{
    public delegate void DelegateAddNewItem();
    public delegate void DelegateEditItem();
    public delegate void DelegateDeleteItem();
    public delegate void DelegateSaveData();
    public delegate void DelegateCancelData();
    public delegate void DelegatePrintData();
    public delegate void DelegatePrintSetting();
    public partial class baseform : superform
    {
        public baseform()
        {
            InitializeComponent();
        }
        public event DelegateAddNewItem AddNewItem;
        public event DelegateEditItem EditItem;
        public event DelegateDeleteItem DeleteItem;
        public event DelegateSaveData  Save;
        public event DelegateCancelData  Cancel;
        public event DelegatePrintData  PrintData;
        public event DelegatePrintSetting PrintSetting;

        private void جدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckPermision(ApaAddRight))
            {
                MessageBox.Show("شما دسترسی مجاز برای این عملیات را ندارید");
                return;
            }
            if (AddNewItem != null)
            {
                AddNewItem();
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (!CheckPermision(ApaAddRight))
            {
                MessageBox.Show("شما دسترسی مجاز برای این عملیات را ندارید");
                return;
            }
            if (AddNewItem != null)
            {
                AddNewItem();
            }
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckPermision(ApaEditRight))
            {
                MessageBox.Show("شما دسترسی مجاز برای این عملیات را ندارید");
                return;
            }
            if (EditItem != null)
            {
                EditItem();
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckPermision(ApaDeleteRight))
            {
                MessageBox.Show("شما دسترسی مجاز برای این عملیات را ندارید");
                return;
            }
            if (DeleteItem  != null)
            {
                DeleteItem();
            }
        }

        private void چاپToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrintData != null)
            {
                PrintData();
            }
        }

        private void تنظیماتچاپToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrintSetting != null)
            {
                PrintSetting();
            }
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void برشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^X");
        }

        private void رونوشتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^C");
        }

        private void الصاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^V");
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^X");
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^C");
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^V");
        }

        private void دربارهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("درباره ما");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!CheckPermision(ApaEditRight))
            {
                MessageBox.Show("شما دسترسی مجاز برای این عملیات را ندارید");
                return;
            }
            if (EditItem != null)
            {
                EditItem();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!CheckPermision(ApaDeleteRight))
            {
                MessageBox.Show("شما دسترسی مجاز برای این عملیات را ندارید");
                return;
            }
            if (DeleteItem != null)
            {
                DeleteItem();
            }
        }

        private void ذخیرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Save != null)
            {
                Save();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (Save != null)
            {
                Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (Cancel != null)
            {
                Cancel();
            }
        }

        private void انصرافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Cancel != null)
            {
                Cancel();
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (PrintData != null)
            {
                PrintData();
            }
        }

        private void دربارهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("راهنما");
        }

        private void baseform_Load(object sender, EventArgs e)
        {
            if (ShowEditFunctions)
            {
                ویرایشToolStripMenuItem.Visible = true;
                toolStripSeparator2.Visible = true;
                cutToolStripButton.Visible = true;
                copyToolStripButton.Visible = true;
                pasteToolStripButton.Visible = true;
            }
            else
            {
                ویرایشToolStripMenuItem.Visible = false;
                toolStripSeparator2.Visible = false;
                cutToolStripButton.Visible = false;
                copyToolStripButton.Visible = false;
                pasteToolStripButton.Visible = false;
            }
        }
    }
}
