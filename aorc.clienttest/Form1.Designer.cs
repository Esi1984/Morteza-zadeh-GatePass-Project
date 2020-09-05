namespace aorc.clienttest
{
    partial class Form1
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer ();
			this.rightside1 = new aorc.gatepass.eorg.ui.rightside ();
			this.splitContainer1.Panel1.SuspendLayout ();
			this.splitContainer1.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point ( 0 , 0 );
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add ( this.rightside1 );
			this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.splitContainer1.Size = new System.Drawing.Size ( 750 , 429 );
			this.splitContainer1.SplitterDistance = 250;
			this.splitContainer1.TabIndex = 0;
			// 
			// rightside1
			// 
			this.rightside1.CurrentEOrgContainer = null;
			this.rightside1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightside1.EOrgContainers = null;
			this.rightside1.Icon = null;
			this.rightside1.Location = new System.Drawing.Point ( 0 , 0 );
			this.rightside1.Name = "rightside1";
			this.rightside1.ParentApplicationService = null;
			this.rightside1.Size = new System.Drawing.Size ( 250 , 429 );
			this.rightside1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F , 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 750 , 429 );
			this.Controls.Add ( this.splitContainer1 );
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "Form1";
			this.Load += new System.EventHandler ( this.Form1_Load );
			this.splitContainer1.Panel1.ResumeLayout ( false );
			this.splitContainer1.ResumeLayout ( false );
			this.ResumeLayout ( false );

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
		 private gatepass.eorg.ui.rightside rightside1;
    }
}

