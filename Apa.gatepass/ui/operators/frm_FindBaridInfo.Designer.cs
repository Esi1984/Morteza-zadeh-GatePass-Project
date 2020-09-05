namespace aorc.gatepass.ui.operators
{
    partial class frm_FindBaridInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FindBaridInfo));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.radGridViewBaridInfo = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radCBarTinyMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewBaridInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewBaridInfo.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // cbreSearch
            // 
            this.cbreSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.cbreSearch.Bounds = new System.Drawing.Rectangle(0, 0, 617, 32);
            this.cbreSearch.DrawText = false;
            this.cbreSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbreSearch.RightToLeft = true;
            this.cbreSearch.StretchVertically = false;
            // 
            // radCBarTinyMain
            // 
            this.radCBarTinyMain.Location = new System.Drawing.Point(0, 0);
            this.radCBarTinyMain.Size = new System.Drawing.Size(617, 80);
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
            this.radLabelElementStatus.Bounds = new System.Drawing.Rectangle(0, 0, 617, 18);
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
            // radGridViewBaridInfo
            // 
            this.radGridViewBaridInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.radGridViewBaridInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridViewBaridInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridViewBaridInfo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGridViewBaridInfo.ForeColor = System.Drawing.Color.Black;
            this.radGridViewBaridInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridViewBaridInfo.Location = new System.Drawing.Point(0, 80);
            // 
            // radGridViewBaridInfo
            // 
            this.radGridViewBaridInfo.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Operator_BaridId";
            gridViewTextBoxColumn1.HeaderText = "شماره برید";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Operator_BaridId";
            gridViewTextBoxColumn1.Width = 71;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "BaridName";
            gridViewTextBoxColumn2.HeaderText = "نام خانوادگی و نام";
            gridViewTextBoxColumn2.Name = "BaridName";
            gridViewTextBoxColumn2.Width = 187;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "BaridJob";
            gridViewTextBoxColumn3.HeaderText = "سمت";
            gridViewTextBoxColumn3.Name = "BaridJob";
            gridViewTextBoxColumn3.Width = 400;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "BaridUserCode";
            gridViewCheckBoxColumn1.HeaderText = "کد کاربری";
            gridViewCheckBoxColumn1.IsVisible = false;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "BaridUserCode";
            gridViewCheckBoxColumn1.Width = 72;
            this.radGridViewBaridInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCheckBoxColumn1});
            this.radGridViewBaridInfo.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridViewBaridInfo.Name = "radGridViewBaridInfo";
            this.radGridViewBaridInfo.ReadOnly = true;
            this.radGridViewBaridInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridViewBaridInfo.Size = new System.Drawing.Size(617, 449);
            this.radGridViewBaridInfo.TabIndex = 0;
            this.radGridViewBaridInfo.Text = "radGridView1";
            this.radGridViewBaridInfo.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridViewBaridInfo_CellDoubleClick);
            // 
            // frm_FindBaridInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(617, 553);
            this.Controls.Add(this.radGridViewBaridInfo);
            this.JobSelected = "";
            this.MainRadGridView = this.radGridViewBaridInfo;
            this.Name = "frm_FindBaridInfo";
            this.NameSelected = "";
            this.Text = "کاربران";
            this.UserCodeSelected = "";
            this.eventSaveTiny += new aorc.gatepass.mainForm.DelegateStatusAction(this.frm_FindBaridInfo_eventSaveTiny);
            this.Load += new System.EventHandler(this.frm_BaridForm_Load);
            this.Controls.SetChildIndex(this.radCBarTinyMain, 0);
            this.Controls.SetChildIndex(this.radGridViewBaridInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radCBarTinyMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewBaridInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewBaridInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridViewBaridInfo;
    }
}
