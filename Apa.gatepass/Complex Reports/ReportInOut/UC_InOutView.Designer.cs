namespace aorc.gatepass.Complex_Reports.ReportInOut
{
    partial class UC_InOutView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.radGridViewSelected = new Telerik.WinControls.UI.RadGridView();
            this.rgbDescriptions = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbDescriptions)).BeginInit();
            this.rgbDescriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // radGridViewSelected
            // 
            this.radGridViewSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.radGridViewSelected.CausesValidation = false;
            this.radGridViewSelected.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridViewSelected.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGridViewSelected.ForeColor = System.Drawing.Color.Black;
            this.radGridViewSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridViewSelected.Location = new System.Drawing.Point(5, 19);
            // 
            // radGridViewSelected
            // 
            this.radGridViewSelected.MasterTemplate.AllowAddNewRow = false;
            this.radGridViewSelected.MasterTemplate.AllowDragToGroup = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "InOutLog_ID";
            gridViewDecimalColumn1.HeaderText = "آیدی ورد و خروج";
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "InOutLog_ID";
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Archive_ID";
            gridViewDecimalColumn2.HeaderText = "آیدی آرشیو";
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "Archive_ID";
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Gatepass_ID";
            gridViewDecimalColumn3.HeaderText = "آیدی گیت پاس";
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "Gatepass_ID";
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "Person_ID";
            gridViewDecimalColumn4.HeaderText = "آیدی شخص";
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "Person_ID";
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "Vehicle_ID";
            gridViewDecimalColumn5.HeaderText = "آیدی خودرو";
            gridViewDecimalColumn5.IsVisible = false;
            gridViewDecimalColumn5.Name = "Vehicle_ID";
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "Time";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "زمان ثبت اصلی";
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.Name = "Time";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Gate_Id";
            gridViewTextBoxColumn1.HeaderText = "آیدی دروازه ثبت تردد";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Gate_Id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "FarsiDate";
            gridViewTextBoxColumn2.HeaderText = "تاریخ ثبت";
            gridViewTextBoxColumn2.Name = "FarsiDate";
            gridViewTextBoxColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn2.Width = 116;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "FarsiTime";
            gridViewTextBoxColumn3.HeaderText = "زمان ثبت";
            gridViewTextBoxColumn3.Name = "FarsiTime";
            gridViewTextBoxColumn3.Width = 101;
            this.radGridViewSelected.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.radGridViewSelected.MasterTemplate.EnableGrouping = false;
            this.radGridViewSelected.MasterTemplate.ShowRowHeaderColumn = false;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "FarsiDate";
            this.radGridViewSelected.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridViewSelected.Name = "radGridViewSelected";
            this.radGridViewSelected.ReadOnly = true;
            this.radGridViewSelected.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridViewSelected.Size = new System.Drawing.Size(244, 269);
            this.radGridViewSelected.TabIndex = 9;
            this.radGridViewSelected.Text = "radGridView1";
            // 
            // rgbDescriptions
            // 
            this.rgbDescriptions.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbDescriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgbDescriptions.Controls.Add(this.radGridViewSelected);
            this.rgbDescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgbDescriptions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbDescriptions.FooterImageIndex = -1;
            this.rgbDescriptions.FooterImageKey = "";
            this.rgbDescriptions.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center;
            this.rgbDescriptions.HeaderImageIndex = -1;
            this.rgbDescriptions.HeaderImageKey = "";
            this.rgbDescriptions.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.rgbDescriptions.HeaderText = "سابقه تردد";
            this.rgbDescriptions.HeaderTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.rgbDescriptions.Location = new System.Drawing.Point(0, 0);
            this.rgbDescriptions.Name = "rgbDescriptions";
            this.rgbDescriptions.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.rgbDescriptions.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.rgbDescriptions.Size = new System.Drawing.Size(254, 293);
            this.rgbDescriptions.TabIndex = 10;
            this.rgbDescriptions.Text = "سابقه تردد";
            // 
            // UC_InOutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.rgbDescriptions);
            this.Name = "UC_InOutView";
            this.Size = new System.Drawing.Size(254, 293);
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbDescriptions)).EndInit();
            this.rgbDescriptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridViewSelected;
        private Telerik.WinControls.UI.RadGroupBox rgbDescriptions;
    }
}
