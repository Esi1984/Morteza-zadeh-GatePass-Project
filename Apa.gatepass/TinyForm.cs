using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Telerik.WinControls;

namespace aorc.gatepass
{
    public partial class TinyForm : mainForm
    {
        public event DelegateStatusAction eventSaveTiny;
        public event DelegateStatusAction eventExitTiny;
        public event DelegateStatusAction eventSearchTiny;
        public event DelegateStatusAction eventTextChangeTiny;

        public int? IdSelected { get; set; }

        public string NameSelected { get; set; }
        public decimal? baridIdSelected { get; set; }
        public string JobSelected { get; set; }
        public string UserCodeSelected { get; set; }
        protected DataTable mySource { get; set; }
        protected string myColSearchName;

        public TinyForm()
        {
            InitializeComponent();

        }
        private void cbbExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        protected void cbbSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainRadGridView.SelectedRows.Count == 1)
                {
                    eventSaveTiny();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(ItemsPublic._infoSelRow);
                }
            }
            catch (Exception ex)
            {
                eventSaveTiny();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cbbSearch_Click(object sender, EventArgs e)
        {
            FindInfo(cbtbSearch.Text);
        }

        private void cbtbSearch_TextChanged(object sender, EventArgs e)
        {
            FindInfo(cbtbSearch.Text);
        }

        private void FindInfo(string myStr)
        {

            var tinyQuery = from dt in mySource.AsEnumerable()
                            where (((string)dt[myColSearchName]).Contains(myStr))
                            select dt;
            try
            {
                MainRadGridView.DataSource = tinyQuery.CopyToDataTable();
            }
            catch
            {
                MainRadGridView.DataSource = null;
            }
        }

        private void TinyForm_Load(object sender, EventArgs e)
        {
            justListForm();

            mySource = null;
            myColSearchName = "";

            IdSelected = null;
            baridIdSelected = null;
            NameSelected = "";

            JobSelected = "";
            UserCodeSelected = "";

            //    MainRadGridView.DataSource = mySource;

        }

        public void unVisibleCbbEmpty()
        {
            cbbEmpty.Visibility = ElementVisibility.Hidden;
        }
        private void cbbEmpty_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TinyForm_eventAfterSave()
        {

        }

        private void TinyForm_eventStatusView()
        {

        }


    }
}
