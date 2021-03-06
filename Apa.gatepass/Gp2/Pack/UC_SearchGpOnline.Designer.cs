﻿namespace aorc.gatepass
{
    partial class UC_SearchGpOnline
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
            this.rgbTravelArea = new Telerik.WinControls.UI.RadGroupBox();
            this.rlblHint = new Telerik.WinControls.UI.RadLabel();
            this.rrbPackId = new Telerik.WinControls.UI.RadRadioButton();
            this.rrbNationalCode = new Telerik.WinControls.UI.RadRadioButton();
            this.rrbGatePassId = new Telerik.WinControls.UI.RadRadioButton();
            this.rlblSearch = new Telerik.WinControls.UI.RadLabel();
            this.rtbSearch = new Telerik.WinControls.UI.RadTextBox();
            this.rbtnSearch = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgbTravelArea)).BeginInit();
            this.rgbTravelArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rlblHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbPackId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbNationalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbGatePassId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // rgbTravelArea
            // 
            this.rgbTravelArea.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbTravelArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgbTravelArea.Controls.Add(this.rlblHint);
            this.rgbTravelArea.Controls.Add(this.rrbPackId);
            this.rgbTravelArea.Controls.Add(this.rrbNationalCode);
            this.rgbTravelArea.Controls.Add(this.rrbGatePassId);
            this.rgbTravelArea.Controls.Add(this.rbtnSearch);
            this.rgbTravelArea.Controls.Add(this.rlblSearch);
            this.rgbTravelArea.Controls.Add(this.rtbSearch);
            this.rgbTravelArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgbTravelArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbTravelArea.FooterImageIndex = -1;
            this.rgbTravelArea.FooterImageKey = "";
            this.rgbTravelArea.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
            this.rgbTravelArea.HeaderImageIndex = -1;
            this.rgbTravelArea.HeaderImageKey = "";
            this.rgbTravelArea.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.rgbTravelArea.HeaderText = "";
            this.rgbTravelArea.Location = new System.Drawing.Point(0, 0);
            this.rgbTravelArea.Name = "rgbTravelArea";
            this.rgbTravelArea.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.rgbTravelArea.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.rgbTravelArea.Size = new System.Drawing.Size(536, 25);
            this.rgbTravelArea.TabIndex = 0;
            // 
            // rlblHint
            // 
            this.rlblHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rlblHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rlblHint.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.rlblHint.ForeColor = System.Drawing.Color.Red;
            this.rlblHint.Location = new System.Drawing.Point(241, 5);
            this.rlblHint.Name = "rlblHint";
            this.rlblHint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rlblHint.Size = new System.Drawing.Size(76, 15);
            this.rlblHint.TabIndex = 101;
            this.rlblHint.Tag = "";
            this.rlblHint.Text = "موردی یافت نشد";
            this.rlblHint.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rlblHint.Visible = false;
            // 
            // rrbPackId
            // 
            this.rrbPackId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rrbPackId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rrbPackId.Location = new System.Drawing.Point(102, 3);
            this.rrbPackId.Name = "rrbPackId";
            this.rrbPackId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rrbPackId.Size = new System.Drawing.Size(117, 18);
            this.rrbPackId.TabIndex = 2;
            this.rrbPackId.Tag = "avnse";
            this.rrbPackId.Text = "شماره بسته مجوز";
            this.rrbPackId.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbPackId_ToggleStateChanged);
            // 
            // rrbNationalCode
            // 
            this.rrbNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rrbNationalCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rrbNationalCode.ForeColor = System.Drawing.Color.IndianRed;
            this.rrbNationalCode.Location = new System.Drawing.Point(-2, 3);
            this.rrbNationalCode.Name = "rrbNationalCode";
            this.rrbNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rrbNationalCode.Size = new System.Drawing.Size(98, 18);
            this.rrbNationalCode.TabIndex = 3;
            this.rrbNationalCode.TabStop = true;
            this.rrbNationalCode.Tag = "avnse";
            this.rrbNationalCode.Text = "کد ملی شخص";
            this.rrbNationalCode.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.rrbNationalCode.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbNationalCode_ToggleStateChanged);
            // 
            // rrbGatePassId
            // 
            this.rrbGatePassId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rrbGatePassId.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.rrbGatePassId.Location = new System.Drawing.Point(128, 29);
            this.rrbGatePassId.Name = "rrbGatePassId";
            this.rrbGatePassId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rrbGatePassId.Size = new System.Drawing.Size(110, 18);
            this.rrbGatePassId.TabIndex = 4;
            this.rrbGatePassId.Tag = "از میان بسته هایی که منقضی نشده اند و شما دسترسی مشاهده آنها را دارید آن بسته که " +
                "شامل شماره گیت پاسی مطابق با عبارت مورد جستجو  می باشد را یافت می کند";
            this.rrbGatePassId.Text = "شماره گیت پاس";
            this.rrbGatePassId.Visible = false;
            this.rrbGatePassId.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbGatePassId_ToggleStateChanged);
            // 
            // rlblSearch
            // 
            this.rlblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rlblSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlblSearch.Location = new System.Drawing.Point(491, 3);
            this.rlblSearch.Name = "rlblSearch";
            this.rlblSearch.Size = new System.Drawing.Size(42, 17);
            this.rlblSearch.TabIndex = 2;
            this.rlblSearch.Text = "جستجو";
            // 
            // rtbSearch
            // 
            this.rtbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSearch.Location = new System.Drawing.Point(375, 3);
            this.rtbSearch.Name = "rtbSearch";
            this.rtbSearch.Size = new System.Drawing.Size(110, 19);
            this.rtbSearch.TabIndex = 0;
            this.rtbSearch.TabStop = false;
            this.rtbSearch.Tag = "avnse";
            this.rtbSearch.TextChanged += new System.EventHandler(this.rtbSearch_TextChanged);
            this.rtbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbSearch_KeyDown);
            // 
            // rbtnSearch
            // 
            this.rbtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSearch.Image = global::aorc.gatepass.Properties.Resources.searchg;
            this.rbtnSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnSearch.Location = new System.Drawing.Point(323, 2);
            this.rbtnSearch.Name = "rbtnSearch";
            this.rbtnSearch.Size = new System.Drawing.Size(46, 20);
            this.rbtnSearch.TabIndex = 1;
            this.rbtnSearch.Tag = "avnse";
            this.rbtnSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnSearch.Click += new System.EventHandler(this.rbtnSearch_Click);
            // 
            // UC_SearchGpOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgbTravelArea);
            this.Name = "UC_SearchGpOnline";
            this.Size = new System.Drawing.Size(536, 25);
            ((System.ComponentModel.ISupportInitialize)(this.rgbTravelArea)).EndInit();
            this.rgbTravelArea.ResumeLayout(false);
            this.rgbTravelArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rlblHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbPackId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbNationalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbGatePassId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox rgbTravelArea;
		public Telerik.WinControls.UI.RadButton rbtnSearch;
        private Telerik.WinControls.UI.RadLabel rlblSearch;
        public Telerik.WinControls.UI.RadTextBox rtbSearch;
		private Telerik.WinControls.UI.RadRadioButton rrbPackId;
		private Telerik.WinControls.UI.RadRadioButton rrbNationalCode;
		private Telerik.WinControls.UI.RadRadioButton rrbGatePassId;
		private Telerik.WinControls.UI.RadLabel rlblHint;
    }
}
