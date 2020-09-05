namespace aorc.gatepass
{
    partial class Form2
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
			this.rightside1 = new aorc.gatepass.eorg.ui.rightside ();
			this.SuspendLayout ();
			// 
			// rightside1
			// 
			this.rightside1.CurrentEOrgContainer = null;
			this.rightside1.EOrgContainers = null;
			this.rightside1.Icon = null;
			this.rightside1.Location = new System.Drawing.Point ( 4 , 2 );
			this.rightside1.Name = "rightside1";
			this.rightside1.ParentApplicationService = null;
			this.rightside1.Size = new System.Drawing.Size ( 268 , 439 );
			this.rightside1.TabIndex = 0;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F , 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 275 , 444 );
			this.Controls.Add ( this.rightside1 );
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler ( this.Form2_Load );
			this.ResumeLayout ( false );

        }

        #endregion

		private eorg.ui.rightside rightside1;


	}
}