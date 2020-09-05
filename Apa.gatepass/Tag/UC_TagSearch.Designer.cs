namespace aorc.gatepass.Tag
{
    partial class UC_TagSearch
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
            this.rlblStartDate = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rtbGpId = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.rtbTagId = new Telerik.WinControls.UI.RadMaskedEditBox();
            ((System.ComponentModel.ISupportInitialize)(this.rlblStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbGpId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbTagId)).BeginInit();
            this.SuspendLayout();
            // 
            // rlblStartDate
            // 
            this.rlblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rlblStartDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlblStartDate.Location = new System.Drawing.Point(506, 28);
            this.rlblStartDate.Name = "rlblStartDate";
            this.rlblStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rlblStartDate.Size = new System.Drawing.Size(49, 17);
            this.rlblStartDate.TabIndex = 1017;
            this.rlblStartDate.Text = "تگ RFID";
            this.rlblStartDate.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(504, 5);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(102, 17);
            this.radLabel1.TabIndex = 174;
            this.radLabel1.Text = "کد ملی / بارکد مجوز";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // rtbGpId
            // 
            this.rtbGpId.AllowPromptAsInput = false;
            this.rtbGpId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbGpId.AutoSize = true;
            this.rtbGpId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGpId.Location = new System.Drawing.Point(3, 3);
            this.rtbGpId.MaxLength = 18;
            this.rtbGpId.Name = "rtbGpId";
            this.rtbGpId.PlaceHolder = '-';
            this.rtbGpId.PromptChar = '-';
            this.rtbGpId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.rtbGpId.RootElement.StretchVertically = true;
            this.rtbGpId.Size = new System.Drawing.Size(495, 19);
            this.rtbGpId.TabIndex = 1018;
            this.rtbGpId.TabStop = false;
            this.rtbGpId.Tag = "";
            this.rtbGpId.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.rtbGpId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbGpId_KeyDown);
            this.rtbGpId.TextChanged += new System.EventHandler(this.rtbGpId_TextChanged);
            // 
            // rtbTagId
            // 
            this.rtbTagId.AllowPromptAsInput = false;
            this.rtbTagId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTagId.AutoSize = true;
            this.rtbTagId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTagId.Location = new System.Drawing.Point(3, 28);
            this.rtbTagId.MaxLength = 18;
            this.rtbTagId.Name = "rtbTagId";
            this.rtbTagId.PlaceHolder = '-';
            this.rtbTagId.PromptChar = '-';
            this.rtbTagId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.rtbTagId.RootElement.StretchVertically = true;
            this.rtbTagId.Size = new System.Drawing.Size(495, 19);
            this.rtbTagId.TabIndex = 1021;
            this.rtbTagId.TabStop = false;
            this.rtbTagId.Tag = "";
            this.rtbTagId.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.rtbTagId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbTagId_KeyDown);
            // 
            // UC_TagSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbTagId);
            this.Controls.Add(this.rtbGpId);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rlblStartDate);
            this.Name = "UC_TagSearch";
            this.Size = new System.Drawing.Size(611, 62);
            ((System.ComponentModel.ISupportInitialize)(this.rlblStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbGpId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbTagId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel rlblStartDate;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        public Telerik.WinControls.UI.RadMaskedEditBox rtbGpId;
        public Telerik.WinControls.UI.RadMaskedEditBox rtbTagId;
    }
}
