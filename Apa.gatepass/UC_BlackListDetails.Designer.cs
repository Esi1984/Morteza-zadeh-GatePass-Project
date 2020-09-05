namespace aorc.gatepass
{
    partial class UC_BlackListDetails
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
			this.rlblBLReasonType = new Telerik.WinControls.UI.RadLabel ();
			this.rgbBlackList = new Telerik.WinControls.UI.RadGroupBox ();
			this.rgbDescriptions = new Telerik.WinControls.UI.RadGroupBox ();
			this.tbDescriptions = new System.Windows.Forms.TextBox ();
			this.rddlBLReasonType = new Telerik.WinControls.UI.RadDropDownList ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rlblBLReasonType ) ).BeginInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rgbBlackList ) ).BeginInit ();
			this.rgbBlackList.SuspendLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rgbDescriptions ) ).BeginInit ();
			this.rgbDescriptions.SuspendLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rddlBLReasonType ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// rlblBLReasonType
			// 
			this.rlblBLReasonType.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.rlblBLReasonType.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rlblBLReasonType.Location = new System.Drawing.Point ( 347 , 21 );
			this.rlblBLReasonType.Name = "rlblBLReasonType";
			this.rlblBLReasonType.Size = new System.Drawing.Size ( 40 , 17 );
			this.rlblBLReasonType.TabIndex = 145;
			this.rlblBLReasonType.Text = "به دلیل";
			this.rlblBLReasonType.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			// 
			// rgbBlackList
			// 
			this.rgbBlackList.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.rgbBlackList.Controls.Add ( this.rgbDescriptions );
			this.rgbBlackList.Controls.Add ( this.rlblBLReasonType );
			this.rgbBlackList.Controls.Add ( this.rddlBLReasonType );
			this.rgbBlackList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rgbBlackList.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rgbBlackList.FooterImageIndex = -1;
			this.rgbBlackList.FooterImageKey = "";
			this.rgbBlackList.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
			this.rgbBlackList.HeaderImageIndex = -1;
			this.rgbBlackList.HeaderImageKey = "";
			this.rgbBlackList.HeaderMargin = new System.Windows.Forms.Padding ( 0 );
			this.rgbBlackList.HeaderText = "";
			this.rgbBlackList.Location = new System.Drawing.Point ( 0 , 0 );
			this.rgbBlackList.Name = "rgbBlackList";
			this.rgbBlackList.Padding = new System.Windows.Forms.Padding ( 2 , 18 , 2 , 2 );
			// 
			// 
			// 
			this.rgbBlackList.RootElement.Padding = new System.Windows.Forms.Padding ( 2 , 18 , 2 , 2 );
			this.rgbBlackList.Size = new System.Drawing.Size ( 393 , 155 );
			this.rgbBlackList.TabIndex = 149;
			// 
			// rgbDescriptions
			// 
			this.rgbDescriptions.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.rgbDescriptions.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.rgbDescriptions.Controls.Add ( this.tbDescriptions );
			this.rgbDescriptions.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rgbDescriptions.FooterImageIndex = -1;
			this.rgbDescriptions.FooterImageKey = "";
			this.rgbDescriptions.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
			this.rgbDescriptions.HeaderImageIndex = -1;
			this.rgbDescriptions.HeaderImageKey = "";
			this.rgbDescriptions.HeaderMargin = new System.Windows.Forms.Padding ( 0 );
			this.rgbDescriptions.HeaderText = "توضیحات";
			this.rgbDescriptions.Location = new System.Drawing.Point ( 6 , 46 );
			this.rgbDescriptions.Name = "rgbDescriptions";
			this.rgbDescriptions.Padding = new System.Windows.Forms.Padding ( 2 , 18 , 2 , 2 );
			// 
			// 
			// 
			this.rgbDescriptions.RootElement.Padding = new System.Windows.Forms.Padding ( 2 , 18 , 2 , 2 );
			this.rgbDescriptions.Size = new System.Drawing.Size ( 378 , 104 );
			this.rgbDescriptions.TabIndex = 145;
			this.rgbDescriptions.Text = "توضیحات";
			// 
			// tbDescriptions
			// 
			this.tbDescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbDescriptions.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.tbDescriptions.Location = new System.Drawing.Point ( 5 , 23 );
			this.tbDescriptions.Multiline = true;
			this.tbDescriptions.Name = "tbDescriptions";
			this.tbDescriptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tbDescriptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbDescriptions.Size = new System.Drawing.Size ( 368 , 76 );
			this.tbDescriptions.TabIndex = 1;
			this.tbDescriptions.Tag = "an";
			// 
			// rddlBLReasonType
			// 
			this.rddlBLReasonType.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.rddlBLReasonType.DropDownAnimationEnabled = true;
			this.rddlBLReasonType.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rddlBLReasonType.Location = new System.Drawing.Point ( 6 , 21 );
			this.rddlBLReasonType.Name = "rddlBLReasonType";
			this.rddlBLReasonType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rddlBLReasonType.ShowImageInEditorArea = true;
			this.rddlBLReasonType.Size = new System.Drawing.Size ( 335 , 19 );
			this.rddlBLReasonType.TabIndex = 1;
			this.rddlBLReasonType.Tag = "a";
			// 
			// UC_BlackListDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F , 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add ( this.rgbBlackList );
			this.Name = "UC_BlackListDetails";
			this.Size = new System.Drawing.Size ( 393 , 155 );
			( ( System.ComponentModel.ISupportInitialize ) ( this.rlblBLReasonType ) ).EndInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rgbBlackList ) ).EndInit ();
			this.rgbBlackList.ResumeLayout ( false );
			this.rgbBlackList.PerformLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rgbDescriptions ) ).EndInit ();
			this.rgbDescriptions.ResumeLayout ( false );
			this.rgbDescriptions.PerformLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rddlBLReasonType ) ).EndInit ();
			this.ResumeLayout ( false );

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel rlblBLReasonType;
		public Telerik.WinControls.UI.RadGroupBox rgbBlackList;
		public Telerik.WinControls.UI.RadDropDownList rddlBLReasonType;
		private Telerik.WinControls.UI.RadGroupBox rgbDescriptions;
		public System.Windows.Forms.TextBox tbDescriptions;
    }
}
