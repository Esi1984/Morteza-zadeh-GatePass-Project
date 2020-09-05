namespace aorc.gatepass.EsiGate3
{
    partial class lightsMainMode
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rbEmergency = new Telerik.WinControls.UI.RadButton();
            this.rbNormal = new Telerik.WinControls.UI.RadButton();
            this.rbBlock = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbEmergency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rbEmergency);
            this.radGroupBox1.Controls.Add(this.rbNormal);
            this.radGroupBox1.Controls.Add(this.rbBlock);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(181, 56);
            this.radGroupBox1.TabIndex = 194;
            // 
            // rbEmergency
            // 
            this.rbEmergency.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmergency.Image = global::aorc.gatepass.Properties.Resources.emergnecyModeDisable;
            this.rbEmergency.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEmergency.Location = new System.Drawing.Point(63, 3);
            this.rbEmergency.Name = "rbEmergency";
            this.rbEmergency.Size = new System.Drawing.Size(54, 50);
            this.rbEmergency.TabIndex = 202;
            this.rbEmergency.Tag = "avnse";
            this.rbEmergency.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rbEmergency.Click += new System.EventHandler(this.rbEmergency_Click);
            // 
            // rbNormal
            // 
            this.rbNormal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNormal.Image = global::aorc.gatepass.Properties.Resources.NormalModeDisable;
            this.rbNormal.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNormal.Location = new System.Drawing.Point(123, 3);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(54, 50);
            this.rbNormal.TabIndex = 201;
            this.rbNormal.Tag = "avnse";
            this.rbNormal.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rbNormal.Click += new System.EventHandler(this.rbNormal_Click);
            // 
            // rbBlock
            // 
            this.rbBlock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBlock.Image = global::aorc.gatepass.Properties.Resources.BlockModeDisable;
            this.rbBlock.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBlock.Location = new System.Drawing.Point(3, 3);
            this.rbBlock.Name = "rbBlock";
            this.rbBlock.Size = new System.Drawing.Size(54, 50);
            this.rbBlock.TabIndex = 200;
            this.rbBlock.Tag = "avnse";
            this.rbBlock.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rbBlock.Click += new System.EventHandler(this.rbBlock_Click);
            // 
            // lightsMainMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Name = "lightsMainMode";
            this.Size = new System.Drawing.Size(181, 56);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rbEmergency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbBlock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        public Telerik.WinControls.UI.RadButton rbEmergency;
        public Telerik.WinControls.UI.RadButton rbNormal;
        public Telerik.WinControls.UI.RadButton rbBlock;
    }
}
