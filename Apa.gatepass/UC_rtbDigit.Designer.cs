namespace aorc.gatepass
{
    partial class UC_rtbDigit
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
			this.rtbDigit = new Telerik.WinControls.UI.RadTextBox ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rtbDigit ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// rtbDigit
			// 
			this.rtbDigit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbDigit.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
			this.rtbDigit.Location = new System.Drawing.Point ( 0 , 0 );
			this.rtbDigit.Name = "rtbDigit";
			this.rtbDigit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rtbDigit.Size = new System.Drawing.Size ( 141 , 19 );
			this.rtbDigit.TabIndex = 2;
			this.rtbDigit.TabStop = false;
			this.rtbDigit.Tag = "aens";
			this.rtbDigit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.rtbDigit.KeyPress += new System.Windows.Forms.KeyPressEventHandler ( this.rtbDigit_KeyPress );
			// 
			// UC_rtbDigit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F , 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add ( this.rtbDigit );
			this.Name = "UC_rtbDigit";
			this.Size = new System.Drawing.Size ( 141 , 19 );
			( ( System.ComponentModel.ISupportInitialize ) ( this.rtbDigit ) ).EndInit ();
			this.ResumeLayout ( false );
			this.PerformLayout ();

        }

        #endregion

		public Telerik.WinControls.UI.RadTextBox rtbDigit;



	}
}
