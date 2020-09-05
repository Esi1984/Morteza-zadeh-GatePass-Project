namespace aorc.gatepass
{
    partial class UC_Sign
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
			this.rgbSign = new Telerik.WinControls.UI.RadGroupBox();
			this.bdcDateExpire = new Baridsoft.Components.Windows.UI.BaridDateControl();
			this.bdcDateStart = new Baridsoft.Components.Windows.UI.BaridDateControl();
			this.rgbImage = new Telerik.WinControls.UI.RadGroupBox();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.rbtnImage = new Telerik.WinControls.UI.RadButton();
			this.rlblDateStart = new Telerik.WinControls.UI.RadLabel();
			this.rlblDateExpire = new Telerik.WinControls.UI.RadLabel();
			((System.ComponentModel.ISupportInitialize)(this.rgbSign)).BeginInit();
			this.rgbSign.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rgbImage)).BeginInit();
			this.rgbImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rbtnImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rlblDateStart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rlblDateExpire)).BeginInit();
			this.SuspendLayout();
			// 
			// rgbSign
			// 
			this.rgbSign.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.rgbSign.Controls.Add(this.bdcDateExpire);
			this.rgbSign.Controls.Add(this.bdcDateStart);
			this.rgbSign.Controls.Add(this.rgbImage);
			this.rgbSign.Controls.Add(this.rlblDateStart);
			this.rgbSign.Controls.Add(this.rlblDateExpire);
			this.rgbSign.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rgbSign.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rgbSign.FooterImageIndex = -1;
			this.rgbSign.FooterImageKey = "";
			this.rgbSign.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
			this.rgbSign.HeaderImageIndex = -1;
			this.rgbSign.HeaderImageKey = "";
			this.rgbSign.HeaderMargin = new System.Windows.Forms.Padding(0);
			this.rgbSign.HeaderText = "خصوصیات امضا";
			this.rgbSign.Location = new System.Drawing.Point(0, 0);
			this.rgbSign.Name = "rgbSign";
			this.rgbSign.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
			// 
			// 
			// 
			this.rgbSign.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
			this.rgbSign.Size = new System.Drawing.Size(236, 256);
			this.rgbSign.TabIndex = 0;
			this.rgbSign.Text = "خصوصیات امضا";
			// 
			// bdcDateExpire
			// 
			this.bdcDateExpire.BackColor = System.Drawing.Color.White;
			this.bdcDateExpire.CalendarCulture = Baridsoft.Components.Windows.UI.CalendarCulture.Shamsi;
			this.bdcDateExpire.CanChangeCulture = true;
			this.bdcDateExpire.ColorHoliday = true;
			this.bdcDateExpire.CurrentDate = null;
			this.bdcDateExpire.DateTime = null;
			this.bdcDateExpire.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bdcDateExpire.Format = Baridsoft.Components.Windows.UI.DateViewFormat.ShortDate;
			this.bdcDateExpire.Hour = 23;
			this.bdcDateExpire.IgnoreBusyState = false;
			this.bdcDateExpire.Location = new System.Drawing.Point(9, 227);
			this.bdcDateExpire.Margin = new System.Windows.Forms.Padding(0);
			this.bdcDateExpire.MinimumSize = new System.Drawing.Size(40, 16);
			this.bdcDateExpire.Minute = 59;
			this.bdcDateExpire.Name = "bdcDateExpire";
			this.bdcDateExpire.OverrideParentReadOnly = true;
			this.bdcDateExpire.ReadOnly = false;
			this.bdcDateExpire.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.bdcDateExpire.SelectedDate = null;
			this.bdcDateExpire.ShowButton = true;
			this.bdcDateExpire.ShowCultureIndicator = true;
			this.bdcDateExpire.ShowNullButton = true;
			this.bdcDateExpire.ShowTodayButton = true;
			this.bdcDateExpire.Size = new System.Drawing.Size(133, 21);
			this.bdcDateExpire.TabIndex = 2;
			this.bdcDateExpire.Tag = "aen";
			// 
			// bdcDateStart
			// 
			this.bdcDateStart.BackColor = System.Drawing.Color.White;
			this.bdcDateStart.CalendarCulture = Baridsoft.Components.Windows.UI.CalendarCulture.Shamsi;
			this.bdcDateStart.CanChangeCulture = true;
			this.bdcDateStart.ColorHoliday = true;
			this.bdcDateStart.CurrentDate = null;
			this.bdcDateStart.DateTime = null;
			this.bdcDateStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bdcDateStart.Format = Baridsoft.Components.Windows.UI.DateViewFormat.ShortDate;
			this.bdcDateStart.Hour = 23;
			this.bdcDateStart.IgnoreBusyState = false;
			this.bdcDateStart.Location = new System.Drawing.Point(9, 198);
			this.bdcDateStart.Margin = new System.Windows.Forms.Padding(0);
			this.bdcDateStart.MinimumSize = new System.Drawing.Size(40, 16);
			this.bdcDateStart.Minute = 59;
			this.bdcDateStart.Name = "bdcDateStart";
			this.bdcDateStart.OverrideParentReadOnly = true;
			this.bdcDateStart.ReadOnly = false;
			this.bdcDateStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.bdcDateStart.SelectedDate = null;
			this.bdcDateStart.ShowButton = true;
			this.bdcDateStart.ShowCultureIndicator = true;
			this.bdcDateStart.ShowNullButton = true;
			this.bdcDateStart.ShowTodayButton = true;
			this.bdcDateStart.Size = new System.Drawing.Size(133, 21);
			this.bdcDateStart.TabIndex = 1;
			this.bdcDateStart.Tag = "aen";
			// 
			// rgbImage
			// 
			this.rgbImage.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.rgbImage.Controls.Add(this.pbImage);
			this.rgbImage.Controls.Add(this.rbtnImage);
			this.rgbImage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rgbImage.FooterImageIndex = -1;
			this.rgbImage.FooterImageKey = "";
			this.rgbImage.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
			this.rgbImage.HeaderImageIndex = -1;
			this.rgbImage.HeaderImageKey = "";
			this.rgbImage.HeaderMargin = new System.Windows.Forms.Padding(0);
			this.rgbImage.HeaderText = "";
			this.rgbImage.Location = new System.Drawing.Point(5, 23);
			this.rgbImage.Name = "rgbImage";
			this.rgbImage.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
			// 
			// 
			// 
			this.rgbImage.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
			this.rgbImage.Size = new System.Drawing.Size(224, 170);
			this.rgbImage.TabIndex = 1;
			// 
			// pbImage
			// 
			this.pbImage.Location = new System.Drawing.Point(5, 5);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(213, 129);
			this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbImage.TabIndex = 4;
			this.pbImage.TabStop = false;
			this.pbImage.Tag = "a";
			// 
			// rbtnImage
			// 
			this.rbtnImage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnImage.Location = new System.Drawing.Point(4, 140);
			this.rbtnImage.Name = "rbtnImage";
			this.rbtnImage.Size = new System.Drawing.Size(213, 24);
			this.rbtnImage.TabIndex = 0;
			this.rbtnImage.Tag = "ane";
			this.rbtnImage.Text = "بارگذاری تصویر امضا";
			this.rbtnImage.Click += new System.EventHandler(this.rbtnImage_Click);
			// 
			// rlblDateStart
			// 
			this.rlblDateStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rlblDateStart.Location = new System.Drawing.Point(145, 198);
			this.rlblDateStart.Name = "rlblDateStart";
			this.rlblDateStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rlblDateStart.Size = new System.Drawing.Size(87, 17);
			this.rlblDateStart.TabIndex = 3;
			this.rlblDateStart.Text = "تاریخ شروع اعتبار";
			this.rlblDateStart.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			// 
			// rlblDateExpire
			// 
			this.rlblDateExpire.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rlblDateExpire.Location = new System.Drawing.Point(145, 227);
			this.rlblDateExpire.Name = "rlblDateExpire";
			this.rlblDateExpire.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rlblDateExpire.Size = new System.Drawing.Size(80, 17);
			this.rlblDateExpire.TabIndex = 5;
			this.rlblDateExpire.Text = "تاریخ پایان اعتبار";
			this.rlblDateExpire.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			// 
			// UC_Sign
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.rgbSign);
			this.Name = "UC_Sign";
			this.Size = new System.Drawing.Size(236, 256);
			((System.ComponentModel.ISupportInitialize)(this.rgbSign)).EndInit();
			this.rgbSign.ResumeLayout(false);
			this.rgbSign.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rgbImage)).EndInit();
			this.rgbImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rbtnImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rlblDateStart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rlblDateExpire)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox rgbSign;
        private Telerik.WinControls.UI.RadLabel rlblDateStart;
        private Telerik.WinControls.UI.RadLabel rlblDateExpire;
        private Telerik.WinControls.UI.RadGroupBox rgbImage;
        public System.Windows.Forms.PictureBox pbImage;
        private Telerik.WinControls.UI.RadButton rbtnImage;
        public Baridsoft.Components.Windows.UI.BaridDateControl bdcDateExpire;
        public Baridsoft.Components.Windows.UI.BaridDateControl bdcDateStart;
    }
}
