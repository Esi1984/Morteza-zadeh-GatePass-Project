namespace aorc.gatepass.EsiGate3
{
    partial class MorMonitoring
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
            this.rtbArrow = new Telerik.WinControls.UI.RadTextBox();
            this.rtbInfo = new Telerik.WinControls.UI.RadTextBox();
            this.PbComeIn = new System.Windows.Forms.PictureBox();
            this.PbGoOut = new System.Windows.Forms.PictureBox();
            this.PicPassingEsi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbComeIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGoOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassingEsi)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rtbArrow);
            this.radGroupBox1.Controls.Add(this.rtbInfo);
            this.radGroupBox1.Controls.Add(this.PicPassingEsi);
            this.radGroupBox1.Controls.Add(this.PbComeIn);
            this.radGroupBox1.Controls.Add(this.PbGoOut);
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
            this.radGroupBox1.Size = new System.Drawing.Size(191, 301);
            this.radGroupBox1.TabIndex = 204;
            // 
            // rtbArrow
            // 
            this.rtbArrow.BackColor = System.Drawing.Color.DarkRed;
            this.rtbArrow.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtbArrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbArrow.Location = new System.Drawing.Point(88, 7);
            this.rtbArrow.Name = "rtbArrow";
            this.rtbArrow.ReadOnly = true;
            this.rtbArrow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbArrow.Size = new System.Drawing.Size(59, 48);
            this.rtbArrow.TabIndex = 216;
            this.rtbArrow.TabStop = false;
            this.rtbArrow.Tag = "";
            this.rtbArrow.Text = "-";
            this.rtbArrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbInfo
            // 
            this.rtbInfo.AutoScroll = true;
            this.rtbInfo.BackColor = System.Drawing.Color.DarkRed;
            this.rtbInfo.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbInfo.Location = new System.Drawing.Point(5, 226);
            this.rtbInfo.Multiline = true;
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.rtbInfo.RootElement.StretchVertically = true;
            this.rtbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.rtbInfo.Size = new System.Drawing.Size(181, 38);
            this.rtbInfo.TabIndex = 211;
            this.rtbInfo.TabStop = false;
            this.rtbInfo.Tag = "";
            this.rtbInfo.Text = "مشخصات متردد";
            this.rtbInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rtbInfo.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            // 
            // PbComeIn
            // 
            this.PbComeIn.Image = global::aorc.gatepass.Properties.Resources.arrow_download_icon48Green;
            this.PbComeIn.Location = new System.Drawing.Point(28, 5);
            this.PbComeIn.Name = "PbComeIn";
            this.PbComeIn.Size = new System.Drawing.Size(54, 50);
            this.PbComeIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbComeIn.TabIndex = 215;
            this.PbComeIn.TabStop = false;
            // 
            // PbGoOut
            // 
            this.PbGoOut.Image = global::aorc.gatepass.Properties.Resources.arrow_upload_icon;
            this.PbGoOut.Location = new System.Drawing.Point(28, 5);
            this.PbGoOut.Name = "PbGoOut";
            this.PbGoOut.Size = new System.Drawing.Size(54, 50);
            this.PbGoOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbGoOut.TabIndex = 214;
            this.PbGoOut.TabStop = false;
            // 
            // PicPassingEsi
            // 
            this.PicPassingEsi.BackgroundImage = global::aorc.gatepass.Properties.Resources.Male;
            this.PicPassingEsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicPassingEsi.ErrorImage = null;
            this.PicPassingEsi.Image = global::aorc.gatepass.Properties.Resources.Male;
            this.PicPassingEsi.InitialImage = null;
            this.PicPassingEsi.Location = new System.Drawing.Point(4, 61);
            this.PicPassingEsi.Name = "PicPassingEsi";
            this.PicPassingEsi.Size = new System.Drawing.Size(181, 160);
            this.PicPassingEsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPassingEsi.TabIndex = 209;
            this.PicPassingEsi.TabStop = false;
            this.PicPassingEsi.DoubleClick += new System.EventHandler(this.PicPassingEsi_DoubleClick);
            // 
            // MorMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Name = "MorMonitoring";
            this.Size = new System.Drawing.Size(191, 301);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbComeIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGoOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassingEsi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.PictureBox PicPassingEsi;
        private Telerik.WinControls.UI.RadTextBox rtbInfo;
        private System.Windows.Forms.PictureBox PbComeIn;
        private System.Windows.Forms.PictureBox PbGoOut;
        private Telerik.WinControls.UI.RadTextBox rtbArrow;
    }
}
