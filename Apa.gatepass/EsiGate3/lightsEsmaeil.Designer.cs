namespace aorc.gatepass.EsiGate3
{
    partial class lightsEsmaeil
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
            this.rbCard = new Telerik.WinControls.UI.RadButton();
            this.rbBlock = new Telerik.WinControls.UI.RadButton();
            this.rbFree = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFree)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rbCard);
            this.radGroupBox1.Controls.Add(this.rbBlock);
            this.radGroupBox1.Controls.Add(this.rbFree);
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
            // rbCard
            // 
            this.rbCard.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCard.Image = global::aorc.gatepass.Properties.Resources.Perspective_Logoff_disable48;
            this.rbCard.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCard.Location = new System.Drawing.Point(63, 3);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(54, 50);
            this.rbCard.TabIndex = 202;
            this.rbCard.Tag = "avnse";
            this.rbCard.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rbCard.Click += new System.EventHandler(this.rbCard_Click);
            // 
            // rbBlock
            // 
            this.rbBlock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBlock.Image = global::aorc.gatepass.Properties.Resources.Perspective_Shutdown_disable48;
            this.rbBlock.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBlock.Location = new System.Drawing.Point(123, 3);
            this.rbBlock.Name = "rbBlock";
            this.rbBlock.Size = new System.Drawing.Size(54, 50);
            this.rbBlock.TabIndex = 201;
            this.rbBlock.Tag = "avnse";
            this.rbBlock.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rbBlock.Click += new System.EventHandler(this.rbBlock_Click);
            // 
            // rbFree
            // 
            this.rbFree.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFree.Image = global::aorc.gatepass.Properties.Resources.Perspective_Reboot_disable48;
            this.rbFree.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbFree.Location = new System.Drawing.Point(3, 3);
            this.rbFree.Name = "rbFree";
            this.rbFree.Size = new System.Drawing.Size(54, 50);
            this.rbFree.TabIndex = 200;
            this.rbFree.Tag = "avnse";
            this.rbFree.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rbFree.Click += new System.EventHandler(this.rbFree_Click);
            // 
            // lightsEsmaeil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Name = "lightsEsmaeil";
            this.Size = new System.Drawing.Size(181, 56);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rbCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        public Telerik.WinControls.UI.RadButton rbCard;
        public Telerik.WinControls.UI.RadButton rbBlock;
        public Telerik.WinControls.UI.RadButton rbFree;
    }
}
