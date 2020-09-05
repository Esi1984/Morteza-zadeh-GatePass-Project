namespace aorc.gatepass.ui.operators
{
    partial class frm_FindGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FindGroups));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGridViewGroups = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radCBarTinyMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // cbreSearch
            // 
            this.cbreSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.cbreSearch.Bounds = new System.Drawing.Rectangle(0, 0, 387, 32);
            this.cbreSearch.DrawText = false;
            this.cbreSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbreSearch.RightToLeft = true;
            this.cbreSearch.StretchVertically = false;
            // 
            // radCBarTinyMain
            // 
            this.radCBarTinyMain.Location = new System.Drawing.Point(0, 0);
            this.radCBarTinyMain.Size = new System.Drawing.Size(387, 80);
            // 
            // rmiStatus
            // 
            this.rmiStatus.Bounds = new System.Drawing.Rectangle(0, 0, 61, 19);
            // 
            // rmiStatusDelete
            // 
            this.rmiStatusDelete.Class = "RadMenuItem";
            // 
            // rmiView
            // 
            this.rmiView.Bounds = new System.Drawing.Rectangle(0, 0, 67, 19);
            this.rmiView.Class = "RadMenuItem";
            // 
            // radLabelElementStatus
            // 
            this.radLabelElementStatus.Bounds = new System.Drawing.Rectangle(0, 0, 387, 18);
            // 
            // commandBarStripElement1MainF
            // 
            this.commandBarStripElement1MainF.Bounds = new System.Drawing.Rectangle(0, 0, 358, 55);
            this.commandBarStripElement1MainF.DesiredLocation = ((System.Drawing.PointF)(resources.GetObject("commandBarStripElement1MainF.DesiredLocation")));
            this.commandBarStripElement1MainF.MinSize = new System.Drawing.Size(30, 30);
            // 
            // cbbNew
            // 
            this.cbbNew.Bounds = new System.Drawing.Rectangle(0, 0, 31, 51);
            // 
            // cbbEdit
            // 
            this.cbbEdit.Bounds = new System.Drawing.Rectangle(0, 0, 41, 51);
            // 
            // contextMenu
            // 
            // 
            // 
            // 
            this.contextMenu.RootElement.StretchHorizontally = false;
            this.contextMenu.RootElement.StretchVertically = false;
            // 
            // radGridViewGroups
            // 
            this.radGridViewGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.radGridViewGroups.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridViewGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridViewGroups.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGridViewGroups.ForeColor = System.Drawing.Color.Black;
            this.radGridViewGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridViewGroups.Location = new System.Drawing.Point(0, 80);
            // 
            // radGridViewGroups
            // 
            this.radGridViewGroups.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Group_ID";
            gridViewTextBoxColumn1.HeaderText = "ردیف";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Group_ID";
            gridViewTextBoxColumn1.Width = 71;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Group_Name";
            gridViewTextBoxColumn2.HeaderText = "نام گروه";
            gridViewTextBoxColumn2.Name = "Group_Name";
            gridViewTextBoxColumn2.Width = 290;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "Group_IsActive";
            gridViewCheckBoxColumn1.HeaderText = "وضعیت";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "Group_IsActive";
            gridViewCheckBoxColumn1.Width = 62;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Group_Description";
            gridViewTextBoxColumn3.HeaderText = "وضعیت";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "Group_Description";
            gridViewTextBoxColumn3.Width = 258;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Office_ParentId";
            gridViewTextBoxColumn4.HeaderText = "شماره اداره بالا سری";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "Office_ParentId";
            gridViewTextBoxColumn4.Width = 220;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Office_MonthlyRemindGp";
            gridViewTextBoxColumn5.HeaderText = "باقیمانده سهمیه روزانه";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "Office_MonthlyRemindGp";
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Office_MonthlyGPAllowed";
            gridViewTextBoxColumn6.HeaderText = "سهمیه ماهیانه";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "Office_MonthlyGPAllowed";
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Office_DailyGPAllowed";
            gridViewTextBoxColumn7.HeaderText = "سهمیه روزانه";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "Office_DailyGPAllowed";
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Office_DailyRemindGp";
            gridViewTextBoxColumn8.HeaderText = "باقیمانده سهمیه روزانه";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "Office_DailyRemindGp";
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "Office_Description";
            gridViewTextBoxColumn9.HeaderText = "توضیحات";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "Office_Description";
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "Office_Phone1";
            gridViewTextBoxColumn10.HeaderText = "شماره تماس اول";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "Office_Phone1";
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "Office_Phone2";
            gridViewTextBoxColumn11.HeaderText = "شماره تماس دوم";
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "Office_Phone2";
            gridViewTextBoxColumn11.Width = 192;
            this.radGridViewGroups.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.radGridViewGroups.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridViewGroups.Name = "radGridViewGroups";
            this.radGridViewGroups.ReadOnly = true;
            this.radGridViewGroups.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridViewGroups.Size = new System.Drawing.Size(387, 449);
            this.radGridViewGroups.TabIndex = 0;
            this.radGridViewGroups.Text = "radGridView1";
            this.radGridViewGroups.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridViewGroups_CellDoubleClick);
            // 
            // frm_FindGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(387, 553);
            this.Controls.Add(this.radGridViewGroups);
            this.JobSelected = "";
            this.MainRadGridView = this.radGridViewGroups;
            this.Name = "frm_FindGroups";
            this.NameSelected = "";
            this.Text = "گروه ها";
            this.UserCodeSelected = "";
            this.eventSaveTiny += new aorc.gatepass.mainForm.DelegateStatusAction(this.frm_FindGroups_eventSaveTiny);
            this.eventSaveToView += new aorc.gatepass.mainForm.DelegateStatusAction(this.frm_TinyGroups_eventSaveToView);
            this.Load += new System.EventHandler(this.frm_TinyGroups_Load);
            this.Controls.SetChildIndex(this.radCBarTinyMain, 0);
            this.Controls.SetChildIndex(this.radGridViewGroups, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radCBarTinyMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridViewGroups;
    }
}
