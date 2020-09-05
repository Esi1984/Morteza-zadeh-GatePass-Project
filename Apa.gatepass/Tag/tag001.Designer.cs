namespace aorc.gatepass.Tag
{
    partial class tag001
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
            this.ucSearchInOut = new aorc.gatepass.Tag.UC_TagSearch();
            this.rtbTagId = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.rtbGpId = new Telerik.WinControls.UI.RadMaskedEditBox();
            ((System.ComponentModel.ISupportInitialize)(this.rtbTagId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbGpId)).BeginInit();
            this.SuspendLayout();
            // 
            // ucSearchInOut
            // 
            this.ucSearchInOut.Location = new System.Drawing.Point(12, 12);
            this.ucSearchInOut.Name = "ucSearchInOut";
            this.ucSearchInOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucSearchInOut.Size = new System.Drawing.Size(482, 61);
            this.ucSearchInOut.TabIndex = 1;
            // 
            // rtbTagId
            // 
            this.rtbTagId.AllowPromptAsInput = false;
            this.rtbTagId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTagId.AutoSize = true;
            this.rtbTagId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTagId.Location = new System.Drawing.Point(38, 129);
            this.rtbTagId.MaxLength = 18;
            this.rtbTagId.Name = "rtbTagId";
            this.rtbTagId.PlaceHolder = '-';
            this.rtbTagId.PromptChar = '-';
            this.rtbTagId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.rtbTagId.RootElement.StretchVertically = true;
            this.rtbTagId.Size = new System.Drawing.Size(401, 19);
            this.rtbTagId.TabIndex = 1023;
            this.rtbTagId.TabStop = false;
            this.rtbTagId.Tag = "";
            this.rtbTagId.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.rtbTagId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbTagId_KeyDown);
            // 
            // rtbGpId
            // 
            this.rtbGpId.AllowPromptAsInput = false;
            this.rtbGpId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbGpId.AutoSize = true;
            this.rtbGpId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGpId.Location = new System.Drawing.Point(38, 104);
            this.rtbGpId.MaxLength = 18;
            this.rtbGpId.Name = "rtbGpId";
            this.rtbGpId.PlaceHolder = '-';
            this.rtbGpId.PromptChar = '-';
            this.rtbGpId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.rtbGpId.RootElement.StretchVertically = true;
            this.rtbGpId.Size = new System.Drawing.Size(401, 19);
            this.rtbGpId.TabIndex = 1022;
            this.rtbGpId.TabStop = false;
            this.rtbGpId.Tag = "";
            this.rtbGpId.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // tag001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 263);
            this.Controls.Add(this.rtbTagId);
            this.Controls.Add(this.rtbGpId);
            this.Controls.Add(this.ucSearchInOut);
            this.Name = "tag001";
            this.Text = "tag001";
            ((System.ComponentModel.ISupportInitialize)(this.rtbTagId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbGpId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_TagSearch ucSearchInOut;
        public Telerik.WinControls.UI.RadMaskedEditBox rtbTagId;
        public Telerik.WinControls.UI.RadMaskedEditBox rtbGpId;
    }
}