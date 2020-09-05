namespace aorc.gatepass.eorg.ui
{
    partial class ExplorerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerPanel));
            this.rlblVersion = new Telerik.WinControls.UI.RadLabel();
            this.vrlblOfficeName = new Telerik.WinControls.UI.RadLabel();
            this.rlblOfficeName = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rlblVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrlblOfficeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblOfficeName)).BeginInit();
            this.SuspendLayout();
            // 
            // rlblVersion
            // 
            this.rlblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rlblVersion.BackColor = System.Drawing.Color.Transparent;
            this.rlblVersion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlblVersion.ForeColor = System.Drawing.Color.Red;
            this.rlblVersion.Location = new System.Drawing.Point(41, 570);
            this.rlblVersion.Name = "rlblVersion";
            this.rlblVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rlblVersion.Size = new System.Drawing.Size(49, 23);
            this.rlblVersion.TabIndex = 46;
            this.rlblVersion.Text = "none";
            this.rlblVersion.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.rlblVersion.Visible = false;
            // 
            // vrlblOfficeName
            // 
            this.vrlblOfficeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vrlblOfficeName.BackColor = System.Drawing.Color.Transparent;
            this.vrlblOfficeName.Font = new System.Drawing.Font("Tahoma", 16.25F);
            this.vrlblOfficeName.ForeColor = System.Drawing.Color.Blue;
            this.vrlblOfficeName.Location = new System.Drawing.Point(232, 528);
            this.vrlblOfficeName.Name = "vrlblOfficeName";
            this.vrlblOfficeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.vrlblOfficeName.Size = new System.Drawing.Size(168, 31);
            this.vrlblOfficeName.TabIndex = 45;
            this.vrlblOfficeName.Text = "لطفا منتظر بمانید";
            this.vrlblOfficeName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rlblOfficeName
            // 
            this.rlblOfficeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rlblOfficeName.BackColor = System.Drawing.Color.Transparent;
            this.rlblOfficeName.Font = new System.Drawing.Font("Tahoma", 16.25F);
            this.rlblOfficeName.ForeColor = System.Drawing.Color.Navy;
            this.rlblOfficeName.Location = new System.Drawing.Point(543, 528);
            this.rlblOfficeName.Name = "rlblOfficeName";
            this.rlblOfficeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rlblOfficeName.Size = new System.Drawing.Size(50, 31);
            this.rlblOfficeName.TabIndex = 44;
            this.rlblOfficeName.Text = "اداره";
            this.rlblOfficeName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.rlblOfficeName.Visible = false;
            // 
            // ExplorerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.rlblVersion);
            this.Controls.Add(this.vrlblOfficeName);
            this.Controls.Add(this.rlblOfficeName);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ExplorerPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(645, 605);
            this.Load += new System.EventHandler(this.ExplorerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rlblVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrlblOfficeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblOfficeName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel rlblVersion;
        private Telerik.WinControls.UI.RadLabel rlblOfficeName;
        public Telerik.WinControls.UI.RadLabel vrlblOfficeName;



    }
}
