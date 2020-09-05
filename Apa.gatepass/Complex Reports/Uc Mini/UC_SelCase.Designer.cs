namespace aorc.gatepass.Complex_Reports.Uc_Mini
{
    partial class UC_SelCase
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
            this.rbtSearch = new Telerik.WinControls.UI.RadButton();
            this.rtbLabel = new Telerik.WinControls.UI.RadTextBox();
            this.rgbCase = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.rbtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbCase)).BeginInit();
            this.rgbCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtSearch
            // 
            this.rbtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.rbtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.rbtSearch.Location = new System.Drawing.Point(335, 3);
            this.rbtSearch.Name = "rbtSearch";
            this.rbtSearch.Size = new System.Drawing.Size(96, 20);
            this.rbtSearch.TabIndex = 1012;
            this.rbtSearch.Tag = "";
            this.rbtSearch.Text = "نا مشخص";
            this.rbtSearch.Click += new System.EventHandler(this.rbtSearch_Click);
            // 
            // rtbLabel
            // 
            this.rtbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLabel.Location = new System.Drawing.Point(5, 3);
            this.rtbLabel.Multiline = true;
            this.rtbLabel.Name = "rtbLabel";
            this.rtbLabel.ReadOnly = true;
            this.rtbLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.rtbLabel.RootElement.StretchVertically = true;
            this.rtbLabel.Size = new System.Drawing.Size(324, 21);
            this.rtbLabel.TabIndex = 1013;
            this.rtbLabel.TabStop = false;
            this.rtbLabel.Tag = "";
            this.rtbLabel.ThemeName = "Office2010Black";
            // 
            // rgbCase
            // 
            this.rgbCase.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.rgbCase.Controls.Add(this.rbtSearch);
            this.rgbCase.Controls.Add(this.rtbLabel);
            this.rgbCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgbCase.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbCase.FooterImageIndex = -1;
            this.rgbCase.FooterImageKey = "";
            this.rgbCase.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
            this.rgbCase.HeaderImageIndex = -1;
            this.rgbCase.HeaderImageKey = "";
            this.rgbCase.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.rgbCase.HeaderText = "";
            this.rgbCase.Location = new System.Drawing.Point(0, 0);
            this.rgbCase.Name = "rgbCase";
            this.rgbCase.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.rgbCase.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.rgbCase.Size = new System.Drawing.Size(436, 27);
            this.rgbCase.TabIndex = 1014;
            // 
            // UC_SelCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgbCase);
            this.Name = "UC_SelCase";
            this.Size = new System.Drawing.Size(436, 27);
            ((System.ComponentModel.ISupportInitialize)(this.rbtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbCase)).EndInit();
            this.rgbCase.ResumeLayout(false);
            this.rgbCase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Telerik.WinControls.UI.RadButton rbtSearch;
        public Telerik.WinControls.UI.RadTextBox rtbLabel;
        private Telerik.WinControls.UI.RadGroupBox rgbCase;
    }
}
