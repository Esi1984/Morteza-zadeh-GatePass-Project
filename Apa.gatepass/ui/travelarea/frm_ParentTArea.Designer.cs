namespace aorc.gatepass.ui.travelarea
{
    partial class frm_ParentTArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ParentTArea));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radCBarTinyMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
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
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 80);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "TravelArea_Id";
            gridViewTextBoxColumn1.HeaderText = "شماره";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "TravelArea_Id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "TravelArea_Name";
            gridViewTextBoxColumn2.HeaderText = "محدوده";
            gridViewTextBoxColumn2.Name = "TravelArea_Name";
            gridViewTextBoxColumn2.Width = 365;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "TravelArea_Description";
            gridViewTextBoxColumn3.HeaderText = "توضیحات";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "TravelArea_Description";
            gridViewTextBoxColumn3.Width = 169;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "TravelArea_Hidden";
            gridViewCheckBoxColumn1.HeaderText = "وضعیت";
            gridViewCheckBoxColumn1.IsPinned = true;
            gridViewCheckBoxColumn1.IsVisible = false;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "TravelArea_Hidden";
            gridViewCheckBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left;
            gridViewCheckBoxColumn1.Width = 41;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "TravelArea_ParentId";
            gridViewTextBoxColumn4.HeaderText = "شماره والد";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "TravelArea_ParentId";
            gridViewTextBoxColumn4.Width = 68;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn4});
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView1.Size = new System.Drawing.Size(387, 379);
            this.radGridView1.TabIndex = 7;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellDoubleClick);
            // 
            // frm_ParentTArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(387, 483);
            this.Controls.Add(this.radGridView1);
            this.JobSelected = "";
            this.MainRadGridView = this.radGridView1;
            this.Name = "frm_ParentTArea";
            this.NameSelected = "";
            this.Text = "محدوده تردد";
            this.UserCodeSelected = "";
            this.eventSaveTiny += new aorc.gatepass.mainForm.DelegateStatusAction(this.frm_ParentTArea_eventSaveTiny);
            this.eventSaveToView += new aorc.gatepass.mainForm.DelegateStatusAction(this.frm_ParentTArea_eventSaveToView);
            this.Load += new System.EventHandler(this.frm_ParentTArea_Load);
            this.Controls.SetChildIndex(this.radCBarTinyMain, 0);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radCBarTinyMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
