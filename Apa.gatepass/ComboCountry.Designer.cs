namespace aorc.gatepass
{
    partial class ComboCountry
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
			this.rddlLocations = new Telerik.WinControls.UI.RadDropDownList ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.rddlLocations ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// rddlLocations
			// 
			this.rddlLocations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.rddlLocations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rddlLocations.DropDownAnimationEnabled = true;
			this.rddlLocations.Font = new System.Drawing.Font ( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 178 ) ) );
			this.rddlLocations.Location = new System.Drawing.Point ( 0 , 0 );
			this.rddlLocations.Name = "rddlLocations";
			this.rddlLocations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rddlLocations.ShowImageInEditorArea = true;
			this.rddlLocations.Size = new System.Drawing.Size ( 141 , 19 );
			this.rddlLocations.TabIndex = 145;
			this.rddlLocations.Tag = "aen";
			// 
			// ComboCountry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F , 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add ( this.rddlLocations );
			this.Name = "ComboCountry";
			this.Size = new System.Drawing.Size ( 141 , 19 );
			( ( System.ComponentModel.ISupportInitialize ) ( this.rddlLocations ) ).EndInit ();
			this.ResumeLayout ( false );
			this.PerformLayout ();

        }

        #endregion

		public Telerik.WinControls.UI.RadDropDownList rddlLocations;

	}
}
