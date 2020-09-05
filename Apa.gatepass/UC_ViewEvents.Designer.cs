namespace aorc.gatepass
{
    partial class UC_ViewEvents
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
            this.rtbEvents = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rtbEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbEvents
            // 
            this.rtbEvents.AutoScroll = true;
            this.rtbEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEvents.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEvents.Location = new System.Drawing.Point(0, 0);
            this.rtbEvents.Multiline = true;
            this.rtbEvents.Name = "rtbEvents";
            this.rtbEvents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.rtbEvents.RootElement.StretchVertically = true;
            this.rtbEvents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rtbEvents.Size = new System.Drawing.Size(991, 207);
            this.rtbEvents.TabIndex = 7;
            this.rtbEvents.TabStop = false;
            this.rtbEvents.Tag = "a";
            // 
            // UC_ViewEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbEvents);
            this.Name = "UC_ViewEvents";
            this.Size = new System.Drawing.Size(991, 207);
            ((System.ComponentModel.ISupportInitialize)(this.rtbEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Telerik.WinControls.UI.RadTextBox rtbEvents;
    }
}
