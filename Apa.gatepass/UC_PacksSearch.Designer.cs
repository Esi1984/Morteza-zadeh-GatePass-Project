namespace aorc.gatepass
{
    partial class UC_PacksSearch
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
			this.j = new Telerik.WinControls.UI.RadGroupBox ();
			this.rmebNationalCode = new Telerik.WinControls.UI.RadMaskedEditBox ();
			this.rlblNationalCode = new Telerik.WinControls.UI.RadLabel ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.j ) ).BeginInit ();
			this.j.SuspendLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rmebNationalCode ) ).BeginInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rlblNationalCode ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// j
			// 
			this.j.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.j.BackColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 191 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 219 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) );
			this.j.Controls.Add ( this.rmebNationalCode );
			this.j.Controls.Add ( this.rlblNationalCode );
			this.j.Dock = System.Windows.Forms.DockStyle.Fill;
			this.j.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
			this.j.FooterImageIndex = -1;
			this.j.FooterImageKey = "";
			this.j.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
			this.j.HeaderImageIndex = -1;
			this.j.HeaderImageKey = "";
			this.j.HeaderMargin = new System.Windows.Forms.Padding ( 0 );
			this.j.HeaderText = "";
			this.j.Location = new System.Drawing.Point ( 0 , 0 );
			this.j.Name = "j";
			this.j.Padding = new System.Windows.Forms.Padding ( 2 , 18 , 2 , 2 );
			// 
			// 
			// 
			this.j.RootElement.Padding = new System.Windows.Forms.Padding ( 2 , 18 , 2 , 2 );
			this.j.Size = new System.Drawing.Size ( 197 , 27 );
			this.j.TabIndex = 100;
			// 
			// rmebNationalCode
			// 
			this.rmebNationalCode.AllowPromptAsInput = false;
			this.rmebNationalCode.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.rmebNationalCode.AutoSize = true;
			this.rmebNationalCode.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
			this.rmebNationalCode.Location = new System.Drawing.Point ( 5 , 3 );
			this.rmebNationalCode.MaxLength = 10;
			this.rmebNationalCode.Name = "rmebNationalCode";
			this.rmebNationalCode.PlaceHolder = '-';
			this.rmebNationalCode.PromptChar = '-';
			this.rmebNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rmebNationalCode.Size = new System.Drawing.Size ( 141 , 19 );
			this.rmebNationalCode.TabIndex = 8;
			this.rmebNationalCode.TabStop = false;
			this.rmebNationalCode.Tag = "aens";
			this.rmebNationalCode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.rmebNationalCode.KeyDown += new System.Windows.Forms.KeyEventHandler ( this.rmebNationalCode_KeyDown );
			this.rmebNationalCode.TextChanged += new System.EventHandler ( this.rmebNationalCode_TextChanged );
			// 
			// rlblNationalCode
			// 
			this.rlblNationalCode.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.rlblNationalCode.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
			this.rlblNationalCode.Location = new System.Drawing.Point ( 152 , 5 );
			this.rlblNationalCode.Name = "rlblNationalCode";
			this.rlblNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rlblNationalCode.Size = new System.Drawing.Size ( 42 , 17 );
			this.rlblNationalCode.TabIndex = 9;
			this.rlblNationalCode.Text = "کد ملی";
			this.rlblNationalCode.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			// 
			// UC_PacksSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F , 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add ( this.j );
			this.Name = "UC_PacksSearch";
			this.Size = new System.Drawing.Size ( 197 , 27 );
			( ( System.ComponentModel.ISupportInitialize ) ( this.j ) ).EndInit ();
			this.j.ResumeLayout ( false );
			this.j.PerformLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rmebNationalCode ) ).EndInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rlblNationalCode ) ).EndInit ();
			this.ResumeLayout ( false );

        }

        #endregion

		private Telerik.WinControls.UI.RadGroupBox j;
		public Telerik.WinControls.UI.RadMaskedEditBox rmebNationalCode;
		public Telerik.WinControls.UI.RadLabel rlblNationalCode;
    }
}
