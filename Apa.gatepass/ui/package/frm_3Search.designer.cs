namespace aorc.gatepass.ui.package
{
	partial class frm_3Search
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
			this.commandBarRowElement2MainF = new Telerik.WinControls.UI.CommandBarRowElement ();
			this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme ();
			this.uC_SearchGp1 = new aorc.gatepass.UC_SearchGp ();
			this.SuspendLayout ();
			// 
			// commandBarRowElement2MainF
			// 
			this.commandBarRowElement2MainF.DisplayName = null;
			this.commandBarRowElement2MainF.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.commandBarRowElement2MainF.MinSize = new System.Drawing.Size ( 25 , 25 );
			this.commandBarRowElement2MainF.Text = "";
			// 
			// uC_SearchGp1
			// 
			this.uC_SearchGp1.Location = new System.Drawing.Point ( 2 , 12 );
			this.uC_SearchGp1.Name = "uC_SearchGp1";
			this.uC_SearchGp1.Size = new System.Drawing.Size ( 503 , 89 );
			this.uC_SearchGp1.TabIndex = 0;
			this.uC_SearchGp1.eventEndSearch += new aorc.gatepass.UC_SearchGp.DelegateStatusAction ( this.uC_SearchGp1_eventEndSearch );
			// 
			// frm_3Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F , 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 191 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 219 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) );
			this.ClientSize = new System.Drawing.Size ( 506 , 102 );
			this.Controls.Add ( this.uC_SearchGp1 );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frm_3Search";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "جستجوی بسته های مجوز";
			this.Load += new System.EventHandler ( this.frm_3Search_Load );
			this.Shown += new System.EventHandler ( this.frm_3Search_Shown );
			this.ResumeLayout ( false );

        }

        #endregion

		private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2MainF;
		private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
		private UC_SearchGp uC_SearchGp1;
    }
}

