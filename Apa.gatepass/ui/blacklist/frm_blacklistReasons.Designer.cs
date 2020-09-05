namespace aorc.gatepass.ui.blacklist
{
    partial class frm_blacklistReasons
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frm_blacklistReasons ) );
			Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn ();
			Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn ();
			Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn ();
			Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn ();
			Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor ();
			this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock ();
			this.documentWindowBLReasons = new Telerik.WinControls.UI.Docking.DocumentWindow ();
			this.radGridViewBLReasons = new Telerik.WinControls.UI.RadGridView ();
			this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer ();
			this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip ();
			this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip ();
			this.toolWindowProperties = new Telerik.WinControls.UI.Docking.ToolWindow ();
			this.uC_BLReasons1 = new aorc.gatepass.UC_BLReasons ();
			this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement ();
			this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement ();
			this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement ();
			this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement ();
			this.commandBarRowElement3 = new Telerik.WinControls.UI.CommandBarRowElement ();
			this.commandBarRowElement4 = new Telerik.WinControls.UI.CommandBarRowElement ();
			this.commandBarRowElement5 = new Telerik.WinControls.UI.CommandBarRowElement ();
			this.commandBarStripElement3 = new Telerik.WinControls.UI.CommandBarStripElement ();
			this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton ();
			this.commandBarButton2 = new Telerik.WinControls.UI.CommandBarButton ();
			this.commandBarStripElement4 = new Telerik.WinControls.UI.CommandBarStripElement ();
			this.radCheckBoxElement1 = new Telerik.WinControls.UI.RadCheckBoxElement ();
			this.rmiProperty = new Telerik.WinControls.UI.RadMenuItem ();
			this.rmiTypeName = new Telerik.WinControls.UI.RadMenuItem ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.contextMenu ) ).BeginInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.radDock1 ) ).BeginInit ();
			this.radDock1.SuspendLayout ();
			this.documentWindowBLReasons.SuspendLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.radGridViewBLReasons ) ).BeginInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.documentContainer1 ) ).BeginInit ();
			this.documentContainer1.SuspendLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.documentTabStrip1 ) ).BeginInit ();
			this.documentTabStrip1.SuspendLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.toolTabStrip2 ) ).BeginInit ();
			this.toolTabStrip2.SuspendLayout ();
			this.toolWindowProperties.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// rmiStatus
			// 
			this.rmiStatus.BackColor = System.Drawing.SystemColors.Control;
			this.rmiStatus.Bounds = new System.Drawing.Rectangle ( 0 , 0 , 61 , 19 );
			this.rmiStatus.ForeColor = System.Drawing.Color.Black;
			this.rmiStatus.Padding = new System.Windows.Forms.Padding ( 8 , 1 , 8 , 1 );
			this.rmiStatus.RightToLeft = true;
			this.rmiStatus.ShowArrow = false;
			this.rmiStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rmiStatus.UseDefaultDisabledPaint = false;
			// 
			// rmiStatusDelete
			// 
			this.rmiStatusDelete.BackColor = System.Drawing.SystemColors.Window;
			this.rmiStatusDelete.Class = "RadMenuItem";
			this.rmiStatusDelete.RightToLeft = true;
			this.rmiStatusDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// rmiView
			// 
			this.rmiView.BackColor = System.Drawing.SystemColors.Control;
			this.rmiView.Bounds = new System.Drawing.Rectangle ( 0 , 0 , 67 , 19 );
			this.rmiView.Class = "RadMenuItem";
			this.rmiView.ForeColor = System.Drawing.Color.Black;
			this.rmiView.Items.AddRange ( new Telerik.WinControls.RadItem [] {
            this.rmiProperty,
            this.rmiTypeName} );
			this.rmiView.Padding = new System.Windows.Forms.Padding ( 8 , 1 , 8 , 1 );
			this.rmiView.RightToLeft = true;
			this.rmiView.ShowArrow = false;
			this.rmiView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rmiView.UseDefaultDisabledPaint = false;
			// 
			// radLabelElementStatus
			// 
			this.radLabelElementStatus.BackColor = System.Drawing.SystemColors.Control;
			this.radLabelElementStatus.Bounds = new System.Drawing.Rectangle ( 0 , 0 , 681 , 18 );
			this.radLabelElementStatus.CanFocus = true;
			this.radLabelElementStatus.ForeColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 21 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 66 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 139 ) ) ) ) );
			this.radLabelElementStatus.RightToLeft = true;
			this.radLabelElementStatus.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			// 
			// commandBarStripElement1MainF
			// 
			this.commandBarStripElement1MainF.BackColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 230 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 240 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 251 ) ) ) ) );
			this.commandBarStripElement1MainF.BackColor2 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 224 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 235 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 248 ) ) ) ) );
			this.commandBarStripElement1MainF.BackColor3 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 211 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 226 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 244 ) ) ) ) );
			this.commandBarStripElement1MainF.BackColor4 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 211 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 226 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 244 ) ) ) ) );
			this.commandBarStripElement1MainF.BorderBottomColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 211 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 226 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 244 ) ) ) ) );
			this.commandBarStripElement1MainF.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders;
			this.commandBarStripElement1MainF.BorderColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 156 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 189 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 232 ) ) ) ) );
			this.commandBarStripElement1MainF.BorderColor2 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 156 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 189 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 232 ) ) ) ) );
			this.commandBarStripElement1MainF.BorderColor3 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 156 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 189 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 232 ) ) ) ) );
			this.commandBarStripElement1MainF.BorderColor4 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 156 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 189 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 232 ) ) ) ) );
			this.commandBarStripElement1MainF.BorderInnerColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 248 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 250 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 252 ) ) ) ) );
			this.commandBarStripElement1MainF.BorderInnerColor2 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 248 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 250 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 252 ) ) ) ) );
			this.commandBarStripElement1MainF.BorderInnerColor3 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 248 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 250 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 252 ) ) ) ) );
			this.commandBarStripElement1MainF.BorderInnerColor4 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 248 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 250 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 252 ) ) ) ) );
			this.commandBarStripElement1MainF.BorderLeftColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 211 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 226 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 244 ) ) ) ) );
			this.commandBarStripElement1MainF.BorderRightColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 211 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 226 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 244 ) ) ) ) );
			this.commandBarStripElement1MainF.BorderTopColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 211 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 226 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 244 ) ) ) ) );
			this.commandBarStripElement1MainF.Bounds = new System.Drawing.Rectangle ( 0 , 0 , 358 , 55 );
			this.commandBarStripElement1MainF.DesiredLocation = ( ( System.Drawing.PointF ) ( resources.GetObject ( "commandBarStripElement1MainF.DesiredLocation" ) ) );
			this.commandBarStripElement1MainF.DisplayName = "commandBarStripElement1MainForm";
			this.commandBarStripElement1MainF.DrawBorder = true;
			this.commandBarStripElement1MainF.DrawFill = true;
			this.commandBarStripElement1MainF.DrawText = false;
			this.commandBarStripElement1MainF.GradientPercentage2 = 0.5F;
			this.commandBarStripElement1MainF.MinSize = new System.Drawing.Size ( 30 , 30 );
			this.commandBarStripElement1MainF.NumberOfColors = 4;
			this.commandBarStripElement1MainF.RightToLeft = true;
			this.commandBarStripElement1MainF.StretchHorizontally = false;
			// 
			// cbbNew
			// 
			this.cbbNew.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.cbbNew.BackColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
			this.cbbNew.BackColor2 = System.Drawing.Color.Transparent;
			this.cbbNew.BackColor3 = System.Drawing.Color.Transparent;
			this.cbbNew.BackColor4 = System.Drawing.Color.Transparent;
			this.cbbNew.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders;
			this.cbbNew.BorderColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 190 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 106 ) ) ) ) );
			this.cbbNew.BorderColor2 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 160 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 160 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 160 ) ) ) ) );
			this.cbbNew.BorderColor3 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 156 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 189 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 232 ) ) ) ) );
			this.cbbNew.BorderColor4 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 156 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 189 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 232 ) ) ) ) );
			this.cbbNew.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
			this.cbbNew.BorderInnerColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 254 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 245 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 195 ) ) ) ) );
			this.cbbNew.BorderInnerColor2 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 248 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 250 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 252 ) ) ) ) );
			this.cbbNew.BorderInnerColor3 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 248 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 250 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 252 ) ) ) ) );
			this.cbbNew.BorderInnerColor4 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 248 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 250 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 252 ) ) ) ) );
			this.cbbNew.BorderLeftWidth = 3F;
			this.cbbNew.BorderWidth = 2F;
			this.cbbNew.Bounds = new System.Drawing.Rectangle ( 0 , 0 , 31 , 51 );
			this.cbbNew.DrawBorder = true;
			this.cbbNew.DrawFill = true;
			this.cbbNew.ForeColor = System.Drawing.Color.Black;
			this.cbbNew.GradientPercentage = 0.498861F;
			this.cbbNew.GradientPercentage2 = 0.5102506F;
			this.cbbNew.NumberOfColors = 4;
			this.cbbNew.RightToLeft = true;
			this.cbbNew.StretchHorizontally = false;
			// 
			// cbbEdit
			// 
			this.cbbEdit.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.cbbEdit.BackColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
			this.cbbEdit.BackColor2 = System.Drawing.Color.Transparent;
			this.cbbEdit.BackColor3 = System.Drawing.Color.Transparent;
			this.cbbEdit.BackColor4 = System.Drawing.Color.Transparent;
			this.cbbEdit.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders;
			this.cbbEdit.BorderColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 190 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 106 ) ) ) ) );
			this.cbbEdit.BorderColor2 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 160 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 160 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 160 ) ) ) ) );
			this.cbbEdit.BorderColor3 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 156 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 189 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 232 ) ) ) ) );
			this.cbbEdit.BorderColor4 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 156 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 189 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 232 ) ) ) ) );
			this.cbbEdit.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
			this.cbbEdit.BorderInnerColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 254 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 245 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 195 ) ) ) ) );
			this.cbbEdit.BorderInnerColor2 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 248 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 250 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 252 ) ) ) ) );
			this.cbbEdit.BorderInnerColor3 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 248 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 250 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 252 ) ) ) ) );
			this.cbbEdit.BorderInnerColor4 = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 248 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 250 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 252 ) ) ) ) );
			this.cbbEdit.BorderLeftWidth = 3F;
			this.cbbEdit.BorderWidth = 2F;
			this.cbbEdit.Bounds = new System.Drawing.Rectangle ( 0 , 0 , 41 , 51 );
			this.cbbEdit.DrawBorder = true;
			this.cbbEdit.DrawFill = true;
			this.cbbEdit.ForeColor = System.Drawing.Color.Black;
			this.cbbEdit.GradientPercentage = 0.498861F;
			this.cbbEdit.GradientPercentage2 = 0.5102506F;
			this.cbbEdit.NumberOfColors = 4;
			this.cbbEdit.RightToLeft = true;
			this.cbbEdit.StretchHorizontally = false;
			// 
			// contextMenu
			// 
			// 
			// 
			// 
			this.contextMenu.RootElement.StretchHorizontally = false;
			this.contextMenu.RootElement.StretchVertically = false;
			// 
			// radDock1
			// 
			this.radDock1.ActiveWindow = this.documentWindowBLReasons;
			this.radDock1.CausesValidation = false;
			this.radDock1.Controls.Add ( this.documentContainer1 );
			this.radDock1.Controls.Add ( this.toolTabStrip2 );
			this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront;
			this.radDock1.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.radDock1.IsCleanUpTarget = true;
			this.radDock1.Location = new System.Drawing.Point ( 0 , 74 );
			this.radDock1.MainDocumentContainer = this.documentContainer1;
			this.radDock1.Name = "radDock1";
			this.radDock1.Padding = new System.Windows.Forms.Padding ( 5 );
			this.radDock1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			// 
			// 
			// 
			this.radDock1.RootElement.MinSize = new System.Drawing.Size ( 25 , 25 );
			this.radDock1.RootElement.Padding = new System.Windows.Forms.Padding ( 5 );
			this.radDock1.Size = new System.Drawing.Size ( 681 , 260 );
			this.radDock1.SplitterWidth = 4;
			this.radDock1.TabIndex = 90;
			this.radDock1.TabStop = false;
			this.radDock1.Text = "radDock1";
			this.radDock1.DockWindowClosed += new Telerik.WinControls.UI.Docking.DockWindowEventHandler ( this.radDock1_DockWindowClosed );
			// 
			// documentWindowBLReasons
			// 
			this.documentWindowBLReasons.CloseAction = Telerik.WinControls.UI.Docking.DockWindowCloseAction.Hide;
			this.documentWindowBLReasons.Controls.Add ( this.radGridViewBLReasons );
			this.documentWindowBLReasons.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.documentWindowBLReasons.Location = new System.Drawing.Point ( 6 , 28 );
			this.documentWindowBLReasons.Name = "documentWindowBLReasons";
			this.documentWindowBLReasons.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
			this.documentWindowBLReasons.Size = new System.Drawing.Size ( 363 , 216 );
			this.documentWindowBLReasons.Text = "انواع مسدود سازی";
			// 
			// radGridViewBLReasons
			// 
			this.radGridViewBLReasons.BackColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 233 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 240 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 249 ) ) ) ) );
			this.radGridViewBLReasons.CausesValidation = false;
			this.radGridViewBLReasons.Cursor = System.Windows.Forms.Cursors.Default;
			this.radGridViewBLReasons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radGridViewBLReasons.Font = new System.Drawing.Font ( "Tahoma" , 8.25F );
			this.radGridViewBLReasons.ForeColor = System.Drawing.Color.Black;
			this.radGridViewBLReasons.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.radGridViewBLReasons.Location = new System.Drawing.Point ( 0 , 0 );
			// 
			// radGridViewBLReasons
			// 
			this.radGridViewBLReasons.MasterTemplate.AllowAddNewRow = false;
			gridViewTextBoxColumn1.EnableExpressionEditor = false;
			gridViewTextBoxColumn1.FieldName = "BLReason_ID";
			gridViewTextBoxColumn1.HeaderText = "ردیف";
			gridViewTextBoxColumn1.IsVisible = false;
			gridViewTextBoxColumn1.Name = "BLReason_ID";
			gridViewTextBoxColumn1.Width = 71;
			gridViewTextBoxColumn2.EnableExpressionEditor = false;
			gridViewTextBoxColumn2.FieldName = "BLReason_Type";
			gridViewTextBoxColumn2.HeaderText = "نام نوع";
			gridViewTextBoxColumn2.Name = "BLReason_Type";
			gridViewTextBoxColumn2.Width = 334;
			gridViewTextBoxColumn3.EnableExpressionEditor = false;
			gridViewTextBoxColumn3.FieldName = "BLReason_Desc";
			gridViewTextBoxColumn3.HeaderText = "توضیحات";
			gridViewTextBoxColumn3.IsVisible = false;
			gridViewTextBoxColumn3.Name = "BLReason_Desc";
			gridViewTextBoxColumn3.Width = 330;
			gridViewCheckBoxColumn1.EnableExpressionEditor = false;
			gridViewCheckBoxColumn1.FieldName = "BLReason_Hidden";
			gridViewCheckBoxColumn1.HeaderText = "وضعیت";
			gridViewCheckBoxColumn1.IsVisible = false;
			gridViewCheckBoxColumn1.MinWidth = 20;
			gridViewCheckBoxColumn1.Name = "BLReason_Hidden";
			this.radGridViewBLReasons.MasterTemplate.Columns.AddRange ( new Telerik.WinControls.UI.GridViewDataColumn [] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCheckBoxColumn1} );
			this.radGridViewBLReasons.MasterTemplate.ShowRowHeaderColumn = false;
			sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
			sortDescriptor1.PropertyName = "column1";
			this.radGridViewBLReasons.MasterTemplate.SortDescriptors.AddRange ( new Telerik.WinControls.Data.SortDescriptor [] {
            sortDescriptor1} );
			this.radGridViewBLReasons.Name = "radGridViewBLReasons";
			this.radGridViewBLReasons.ReadOnly = true;
			this.radGridViewBLReasons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.radGridViewBLReasons.Size = new System.Drawing.Size ( 363 , 216 );
			this.radGridViewBLReasons.TabIndex = 0;
			this.radGridViewBLReasons.Text = "radGridView1";
			this.radGridViewBLReasons.SelectionChanged += new System.EventHandler ( this.radGridViewBLReasons_SelectionChanged );
			// 
			// documentContainer1
			// 
			this.documentContainer1.CausesValidation = false;
			this.documentContainer1.Controls.Add ( this.documentTabStrip1 );
			this.documentContainer1.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.documentContainer1.Location = new System.Drawing.Point ( 5 , 5 );
			this.documentContainer1.Name = "documentContainer1";
			this.documentContainer1.Padding = new System.Windows.Forms.Padding ( 5 );
			// 
			// 
			// 
			this.documentContainer1.RootElement.MinSize = new System.Drawing.Size ( 25 , 25 );
			this.documentContainer1.RootElement.Padding = new System.Windows.Forms.Padding ( 5 );
			this.documentContainer1.Size = new System.Drawing.Size ( 375 , 250 );
			this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size ( 415 , 216 );
			this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
			this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size ( 14 , 66 );
			this.documentContainer1.SplitterWidth = 4;
			this.documentContainer1.TabIndex = 0;
			this.documentContainer1.TabStop = false;
			// 
			// documentTabStrip1
			// 
			this.documentTabStrip1.CausesValidation = false;
			this.documentTabStrip1.Controls.Add ( this.documentWindowBLReasons );
			this.documentTabStrip1.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.documentTabStrip1.Location = new System.Drawing.Point ( 0 , 0 );
			this.documentTabStrip1.Name = "documentTabStrip1";
			// 
			// 
			// 
			this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size ( 25 , 25 );
			this.documentTabStrip1.SelectedIndex = 0;
			this.documentTabStrip1.Size = new System.Drawing.Size ( 375 , 250 );
			this.documentTabStrip1.TabIndex = 0;
			this.documentTabStrip1.TabStop = false;
			// 
			// toolTabStrip2
			// 
			this.toolTabStrip2.Controls.Add ( this.toolWindowProperties );
			this.toolTabStrip2.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.toolTabStrip2.Location = new System.Drawing.Point ( 384 , 5 );
			this.toolTabStrip2.Name = "toolTabStrip2";
			// 
			// 
			// 
			this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size ( 25 , 25 );
			this.toolTabStrip2.SelectedIndex = 0;
			this.toolTabStrip2.Size = new System.Drawing.Size ( 292 , 250 );
			this.toolTabStrip2.SizeInfo.AbsoluteSize = new System.Drawing.Size ( 292 , 200 );
			this.toolTabStrip2.SizeInfo.SplitterCorrection = new System.Drawing.Size ( 101 , 0 );
			this.toolTabStrip2.TabIndex = 1;
			this.toolTabStrip2.TabStop = false;
			// 
			// toolWindowProperties
			// 
			this.toolWindowProperties.AutoScroll = true;
			this.toolWindowProperties.Caption = null;
			this.toolWindowProperties.Controls.Add ( this.uC_BLReasons1 );
			this.toolWindowProperties.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.toolWindowProperties.Location = new System.Drawing.Point ( 1 , 24 );
			this.toolWindowProperties.Name = "toolWindowProperties";
			this.toolWindowProperties.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolWindowProperties.Size = new System.Drawing.Size ( 290 , 224 );
			this.toolWindowProperties.Text = "مشخصات نوع مسدود سازی جاری";
			// 
			// uC_BLReasons1
			// 
			this.uC_BLReasons1.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.uC_BLReasons1.Location = new System.Drawing.Point ( 1 , 4 );
			this.uC_BLReasons1.Name = "uC_BLReasons1";
			this.uC_BLReasons1.Size = new System.Drawing.Size ( 259 , 217 );
			this.uC_BLReasons1.TabIndex = 0;
			// 
			// commandBarRowElement1
			// 
			this.commandBarRowElement1.DisplayName = null;
			this.commandBarRowElement1.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.commandBarRowElement1.MinSize = new System.Drawing.Size ( 25 , 25 );
			this.commandBarRowElement1.Strips.AddRange ( new Telerik.WinControls.UI.CommandBarStripElement [] {
            this.commandBarStripElement1} );
			// 
			// commandBarStripElement1
			// 
			this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
			this.commandBarStripElement1.FloatingForm = null;
			this.commandBarStripElement1.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.commandBarStripElement1.Name = "commandBarStripElement1";
			this.commandBarStripElement1.Text = "";
			// 
			// commandBarRowElement2
			// 
			this.commandBarRowElement2.DisplayName = null;
			this.commandBarRowElement2.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.commandBarRowElement2.MinSize = new System.Drawing.Size ( 25 , 25 );
			this.commandBarRowElement2.Strips.AddRange ( new Telerik.WinControls.UI.CommandBarStripElement [] {
            this.commandBarStripElement2} );
			// 
			// commandBarStripElement2
			// 
			this.commandBarStripElement2.DisplayName = "commandBarStripElement2";
			this.commandBarStripElement2.FloatingForm = null;
			this.commandBarStripElement2.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.commandBarStripElement2.Name = "commandBarStripElement2";
			this.commandBarStripElement2.Text = "";
			// 
			// commandBarRowElement3
			// 
			this.commandBarRowElement3.DisplayName = null;
			this.commandBarRowElement3.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.commandBarRowElement3.MinSize = new System.Drawing.Size ( 25 , 25 );
			// 
			// commandBarRowElement4
			// 
			this.commandBarRowElement4.DisplayName = null;
			this.commandBarRowElement4.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.commandBarRowElement4.MinSize = new System.Drawing.Size ( 25 , 25 );
			// 
			// commandBarRowElement5
			// 
			this.commandBarRowElement5.DisplayName = null;
			this.commandBarRowElement5.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.commandBarRowElement5.MinSize = new System.Drawing.Size ( 25 , 25 );
			this.commandBarRowElement5.Strips.AddRange ( new Telerik.WinControls.UI.CommandBarStripElement [] {
            this.commandBarStripElement3,
            this.commandBarStripElement4} );
			// 
			// commandBarStripElement3
			// 
			this.commandBarStripElement3.DisplayName = "commandBarStripElement3";
			this.commandBarStripElement3.FloatingForm = null;
			this.commandBarStripElement3.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.commandBarStripElement3.Items.AddRange ( new Telerik.WinControls.UI.RadCommandBarBaseItem [] {
            this.commandBarButton1,
            this.commandBarButton2} );
			this.commandBarStripElement3.Name = "commandBarStripElement3";
			this.commandBarStripElement3.Text = "";
			// 
			// commandBarButton1
			// 
			this.commandBarButton1.AccessibleDescription = "commandBarButton1";
			this.commandBarButton1.AccessibleName = "commandBarButton1";
			this.commandBarButton1.DisplayName = "commandBarButton1";
			this.commandBarButton1.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.commandBarButton1.Image = ( ( System.Drawing.Image ) ( resources.GetObject ( "commandBarButton1.Image" ) ) );
			this.commandBarButton1.Name = "commandBarButton1";
			this.commandBarButton1.Text = "commandBarButton1";
			this.commandBarButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// commandBarButton2
			// 
			this.commandBarButton2.AccessibleDescription = "commandBarButton2";
			this.commandBarButton2.AccessibleName = "commandBarButton2";
			this.commandBarButton2.DisplayName = "commandBarButton2";
			this.commandBarButton2.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.commandBarButton2.Image = ( ( System.Drawing.Image ) ( resources.GetObject ( "commandBarButton2.Image" ) ) );
			this.commandBarButton2.Name = "commandBarButton2";
			this.commandBarButton2.Text = "commandBarButton2";
			this.commandBarButton2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// commandBarStripElement4
			// 
			this.commandBarStripElement4.DisplayName = "commandBarStripElement4";
			this.commandBarStripElement4.FloatingForm = null;
			this.commandBarStripElement4.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.commandBarStripElement4.Name = "commandBarStripElement4";
			this.commandBarStripElement4.Text = "";
			// 
			// radCheckBoxElement1
			// 
			this.radCheckBoxElement1.AccessibleDescription = "radCheckBoxElement1";
			this.radCheckBoxElement1.AccessibleName = "radCheckBoxElement1";
			this.radCheckBoxElement1.Checked = false;
			this.radCheckBoxElement1.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.radCheckBoxElement1.Name = "radCheckBoxElement1";
			this.radCheckBoxElement1.Text = "radCheckBoxElement1";
			this.radCheckBoxElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// rmiProperty
			// 
			this.rmiProperty.AccessibleDescription = "خصوصیات";
			this.rmiProperty.AccessibleName = "خصوصیات";
			this.rmiProperty.Name = "rmiProperty";
			this.rmiProperty.Text = "خصوصیات";
			this.rmiProperty.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rmiProperty.Click += new System.EventHandler ( this.rmiProperty_Click );
			// 
			// rmiTypeName
			// 
			this.rmiTypeName.AccessibleDescription = "لیست نام نوع ها";
			this.rmiTypeName.AccessibleName = "لیست نام نوع ها";
			this.rmiTypeName.Name = "rmiTypeName";
			this.rmiTypeName.Text = "لیست نام نوع ها";
			this.rmiTypeName.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.rmiTypeName.Click += new System.EventHandler ( this.rmiTypeName_Click );
			// 
			// frm_blacklistReasons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F , 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 681 , 358 );
			this.Controls.Add ( this.radDock1 );
			this.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.Location = new System.Drawing.Point ( 0 , 0 );
			this.MainRadGridView = this.radGridViewBLReasons;
			this.Name = "frm_blacklistReasons";
			this.Text = "دلایل مسدود سازی";
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.eventStatusNew += new aorc.gatepass.mainForm.DelegateStatusAction ( this.frm_blacklistReasons_eventStatusNew );
			this.eventStatusEdit += new aorc.gatepass.mainForm.DelegateStatusAction ( this.frm_blacklistReasons_eventStatusEdit );
			this.eventStatusSearch += new aorc.gatepass.mainForm.DelegateStatusAction ( this.frm_blacklistReasons_eventStatusSearch );
			this.eventStatusView += new aorc.gatepass.mainForm.DelegateStatusAction ( this.frm_blacklistReasons_eventStatusView );
			this.eventStatusDelete += new aorc.gatepass.mainForm.DelegateStatusAction ( this.frm_blacklistReasons_eventStatusDelete );
			this.eventSaveToDelete += new aorc.gatepass.mainForm.DelegateStatusAction ( this.frm_blacklistReasons_eventSaveToDelete );
			this.eventSaveToEdit += new aorc.gatepass.mainForm.DelegateStatusAction ( this.frm_blacklistReasons_eventSaveToEdit );
			this.eventSaveToNew += new aorc.gatepass.mainForm.DelegateStatusAction ( this.frm_blacklistReasons_eventSaveToNew );
			this.eventSaveToView += new aorc.gatepass.mainForm.DelegateStatusAction ( this.frm_blacklistReasons_eventSaveToView );
			this.eventAfterSave += new aorc.gatepass.mainForm.DelegateStatusAction ( this.frm_blacklistReasons_eventAfterSave );
			this.eventSaveToSearch += new aorc.gatepass.mainForm.DelegateStatusAction ( this.frm_blacklistReasons_eventSaveToSearch );
			this.Load += new System.EventHandler ( this.frm_blacklistReasons_Load );
			this.Controls.SetChildIndex ( this.radDock1 , 0 );
			( ( System.ComponentModel.ISupportInitialize ) ( this.contextMenu ) ).EndInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.radDock1 ) ).EndInit ();
			this.radDock1.ResumeLayout ( false );
			this.documentWindowBLReasons.ResumeLayout ( false );
			( ( System.ComponentModel.ISupportInitialize ) ( this.radGridViewBLReasons ) ).EndInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.documentContainer1 ) ).EndInit ();
			this.documentContainer1.ResumeLayout ( false );
			( ( System.ComponentModel.ISupportInitialize ) ( this.documentTabStrip1 ) ).EndInit ();
			this.documentTabStrip1.ResumeLayout ( false );
			( ( System.ComponentModel.ISupportInitialize ) ( this.toolTabStrip2 ) ).EndInit ();
			this.toolTabStrip2.ResumeLayout ( false );
			this.toolWindowProperties.ResumeLayout ( false );
			this.ResumeLayout ( false );
			this.PerformLayout ();

        }

        #endregion

        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindowBLReasons;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindowProperties;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement3;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement4;
        private Telerik.WinControls.UI.RadGridView radGridViewBLReasons;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement5;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement3;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement4;
        private Telerik.WinControls.UI.RadCheckBoxElement radCheckBoxElement1;
        ////////
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow4;
        private Telerik.WinControls.UI.RadButton radButton12;
        private Telerik.WinControls.UI.RadButton radButton14;
        private Telerik.WinControls.UI.RadButton radButton15;
       // private Telerik.WinControls.UI.RadLabelElement radLabelElementStatus;
        private UC_BLReasons uC_BLReasons1;
        private Telerik.WinControls.UI.RadMenuItem rmiProperty;
        private Telerik.WinControls.UI.RadMenuItem rmiTypeName;


    }
}
