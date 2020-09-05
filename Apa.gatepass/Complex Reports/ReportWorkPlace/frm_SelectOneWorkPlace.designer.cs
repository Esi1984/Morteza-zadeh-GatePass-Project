namespace aorc.gatepass.Complex_Reports.ReportWorkPlace
{
	partial class frm_SelectOneWorkPlace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.commandBarRowElement2MainF = new Telerik.WinControls.UI.CommandBarRowElement();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElementStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.RadCommandBar1MainF = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1MainF = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1MainF = new Telerik.WinControls.UI.CommandBarStripElement();
            this.cbbSave = new Telerik.WinControls.UI.CommandBarButton();
            this.cbbCancel = new Telerik.WinControls.UI.CommandBarButton();
            this.cbbNoChoice = new Telerik.WinControls.UI.CommandBarButton();
            this.MainRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rgbDescriptions = new Telerik.WinControls.UI.RadGroupBox();
            this.rtbSearch = new Telerik.WinControls.UI.RadTextBox();
            this.uC_TreeOffices1 = new aorc.gatepass.UC_TreeOffices();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadCommandBar1MainF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbDescriptions)).BeginInit();
            this.rgbDescriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // commandBarRowElement2MainF
            // 
            this.commandBarRowElement2MainF.DisplayName = null;
            this.commandBarRowElement2MainF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.commandBarRowElement2MainF.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement2MainF.Text = "";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElementStatus});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 407);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radStatusStrip1.Size = new System.Drawing.Size(315, 24);
            this.radStatusStrip1.TabIndex = 4;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // radLabelElementStatus
            // 
            this.radLabelElementStatus.AccessibleDescription = "مشاهده، جستجو و مدیریت قرارداد ها";
            this.radLabelElementStatus.AccessibleName = "مشاهده، جستجو و مدیریت قرارداد ها";
            this.radLabelElementStatus.AutoSize = true;
            this.radLabelElementStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabelElementStatus.Name = "radLabelElementStatus";
            this.radLabelElementStatus.RightToLeft = true;
            this.radStatusStrip1.SetSpring(this.radLabelElementStatus, false);
            this.radLabelElementStatus.Text = "پنجره جهت انتخاب یک محل کار";
            this.radLabelElementStatus.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElementStatus.TextWrap = true;
            this.radLabelElementStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.radPanel1.Controls.Add(this.RadCommandBar1MainF);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(315, 49);
            this.radPanel1.TabIndex = 5;
            this.radPanel1.Text = "radPanel1";
            // 
            // RadCommandBar1MainF
            // 
            this.RadCommandBar1MainF.AutoSize = true;
            this.RadCommandBar1MainF.Dock = System.Windows.Forms.DockStyle.Top;
            this.RadCommandBar1MainF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadCommandBar1MainF.Location = new System.Drawing.Point(0, 0);
            this.RadCommandBar1MainF.Name = "RadCommandBar1MainF";
            this.RadCommandBar1MainF.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1MainF});
            this.RadCommandBar1MainF.Size = new System.Drawing.Size(315, 55);
            this.RadCommandBar1MainF.TabIndex = 2;
            this.RadCommandBar1MainF.Tag = "";
            this.RadCommandBar1MainF.Text = "radCommandBar1";
            // 
            // commandBarRowElement1MainF
            // 
            this.commandBarRowElement1MainF.DisplayName = null;
            this.commandBarRowElement1MainF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.commandBarRowElement1MainF.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1MainF.RightToLeft = true;
            this.commandBarRowElement1MainF.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1MainF});
            this.commandBarRowElement1MainF.Text = "";
            // 
            // commandBarStripElement1MainF
            // 
            this.commandBarStripElement1MainF.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1MainF.FloatingForm = null;
            this.commandBarStripElement1MainF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.commandBarStripElement1MainF.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.cbbSave,
            this.cbbCancel,
            this.cbbNoChoice});
            this.commandBarStripElement1MainF.Name = "commandBarStripElement1";
            this.commandBarStripElement1MainF.Text = "";
            // 
            // cbbSave
            // 
            this.cbbSave.AccessibleDescription = "تایید";
            this.cbbSave.AccessibleName = "تایید";
            this.cbbSave.DisplayName = "تایید";
            this.cbbSave.DrawText = true;
            this.cbbSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbbSave.Image = global::aorc.gatepass.Properties.Resources.pass3;
            this.cbbSave.Name = "cbbSave";
            this.cbbSave.Tag = "asned";
            this.cbbSave.Text = "تایید";
            this.cbbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbbSave.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbbSave.Click += new System.EventHandler(this.cbbSave_Click);
            // 
            // cbbCancel
            // 
            this.cbbCancel.AccessibleDescription = "انصراف";
            this.cbbCancel.AccessibleName = "انصراف";
            this.cbbCancel.DisplayName = "انصراف";
            this.cbbCancel.DrawText = true;
            this.cbbCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbbCancel.Image = global::aorc.gatepass.Properties.Resources.cancel;
            this.cbbCancel.Name = "cbbCancel";
            this.cbbCancel.Tag = "asned";
            this.cbbCancel.Text = "انصراف";
            this.cbbCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbbCancel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbbCancel.Click += new System.EventHandler(this.cbbCancel_Click);
            // 
            // cbbNoChoice
            // 
            this.cbbNoChoice.AccessibleDescription = "رد انتخاب";
            this.cbbNoChoice.AccessibleName = "رد انتخاب";
            this.cbbNoChoice.DisplayName = "رد انتخاب";
            this.cbbNoChoice.DrawText = true;
            this.cbbNoChoice.Image = global::aorc.gatepass.Properties.Resources.blue_recycle_bin_icon;
            this.cbbNoChoice.Name = "cbbNoChoice";
            this.cbbNoChoice.Text = "رد انتخاب";
            this.cbbNoChoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbbNoChoice.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbbNoChoice.Click += new System.EventHandler(this.cbbNoChoice_Click);
            // 
            // MainRadGridView
            // 
            this.MainRadGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.MainRadGridView.CausesValidation = false;
            this.MainRadGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainRadGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MainRadGridView.ForeColor = System.Drawing.Color.Black;
            this.MainRadGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainRadGridView.Location = new System.Drawing.Point(2, 98);
            // 
            // MainRadGridView
            // 
            this.MainRadGridView.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "TravelArea_Id";
            gridViewTextBoxColumn1.HeaderText = "ردیف";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "TravelArea_Id";
            gridViewTextBoxColumn1.Width = 71;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "TravelArea_Name";
            gridViewTextBoxColumn2.HeaderText = "محدوده تردد";
            gridViewTextBoxColumn2.Name = "TravelArea_Name";
            gridViewTextBoxColumn2.Width = 281;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "TravelArea_Hidden";
            gridViewCheckBoxColumn1.HeaderText = "قابل مشاهده";
            gridViewCheckBoxColumn1.IsVisible = false;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "TravelArea_Hidden";
            gridViewCheckBoxColumn1.Width = 55;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "TravelArea_Description";
            gridViewTextBoxColumn3.HeaderText = "توضیحات";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "TravelArea_Description";
            gridViewTextBoxColumn3.Width = 289;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "TravelArea_ParentId";
            gridViewTextBoxColumn4.HeaderText = "آیدی والد";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "TravelArea_ParentId";
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "TravelArea_ParentName";
            gridViewTextBoxColumn5.HeaderText = "محدوده بالاسری";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "TravelArea_ParentName";
            this.MainRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.MainRadGridView.MasterTemplate.ShowRowHeaderColumn = false;
            this.MainRadGridView.Name = "MainRadGridView";
            this.MainRadGridView.ReadOnly = true;
            this.MainRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainRadGridView.Size = new System.Drawing.Size(280, 208);
            this.MainRadGridView.TabIndex = 97;
            this.MainRadGridView.Text = "radGridView1";
            this.MainRadGridView.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 10);
            this.panel1.TabIndex = 0;
            // 
            // rgbDescriptions
            // 
            this.rgbDescriptions.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbDescriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgbDescriptions.Controls.Add(this.rtbSearch);
            this.rgbDescriptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.rgbDescriptions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbDescriptions.FooterImageIndex = -1;
            this.rgbDescriptions.FooterImageKey = "";
            this.rgbDescriptions.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
            this.rgbDescriptions.HeaderImageIndex = -1;
            this.rgbDescriptions.HeaderImageKey = "";
            this.rgbDescriptions.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.rgbDescriptions.HeaderText = "بر اساس نام محل کار";
            this.rgbDescriptions.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rgbDescriptions.Location = new System.Drawing.Point(0, 59);
            this.rgbDescriptions.Name = "rgbDescriptions";
            this.rgbDescriptions.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.rgbDescriptions.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.rgbDescriptions.Size = new System.Drawing.Size(315, 43);
            this.rgbDescriptions.TabIndex = 98;
            this.rgbDescriptions.Text = "بر اساس نام محل کار";
            // 
            // rtbSearch
            // 
            this.rtbSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSearch.Location = new System.Drawing.Point(2, 22);
            this.rtbSearch.Name = "rtbSearch";
            this.rtbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbSearch.Size = new System.Drawing.Size(311, 19);
            this.rtbSearch.TabIndex = 3;
            this.rtbSearch.TabStop = false;
            this.rtbSearch.Tag = "aens";
            this.rtbSearch.TextChanged += new System.EventHandler(this.rtbSearch_TextChanged);
            // 
            // uC_TreeOffices1
            // 
            this.uC_TreeOffices1.AutoScroll = true;
            this.uC_TreeOffices1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_TreeOffices1.Location = new System.Drawing.Point(0, 102);
            this.uC_TreeOffices1.Name = "uC_TreeOffices1";
            this.uC_TreeOffices1.Size = new System.Drawing.Size(315, 305);
            this.uC_TreeOffices1.TabIndex = 100;
            this.uC_TreeOffices1.Tag = "";
            this.uC_TreeOffices1.eventSelectedNodeChanged += new aorc.gatepass.UC_TreeOffices.SelectedNodeChanged(this.uC_TreeOffices1_eventSelectedNodeChanged);
            // 
            // frm_SelectOneWorkPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 431);
            this.Controls.Add(this.uC_TreeOffices1);
            this.Controls.Add(this.rgbDescriptions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.MainRadGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_SelectOneWorkPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب محل کار";
            this.Load += new System.EventHandler(this.frm_SelectArea_Load);
            this.Shown += new System.EventHandler(this.frm_SelectOneWorkPlace_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadCommandBar1MainF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbDescriptions)).EndInit();
            this.rgbDescriptions.ResumeLayout(false);
            this.rgbDescriptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2MainF;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        protected Telerik.WinControls.UI.RadLabelElement radLabelElementStatus;
		private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
		private Telerik.WinControls.UI.RadPanel radPanel1;
		private Telerik.WinControls.UI.RadCommandBar RadCommandBar1MainF;
		private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1MainF;
		protected Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1MainF;
		private Telerik.WinControls.UI.CommandBarButton cbbSave;
        private Telerik.WinControls.UI.CommandBarButton cbbCancel;
        private Telerik.WinControls.UI.CommandBarButton cbbNoChoice;
        private Telerik.WinControls.UI.RadGridView MainRadGridView;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadGroupBox rgbDescriptions;
        public Telerik.WinControls.UI.RadTextBox rtbSearch;
        private UC_TreeOffices uC_TreeOffices1;


        






    }
}

