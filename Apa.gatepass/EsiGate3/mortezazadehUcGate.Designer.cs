namespace aorc.gatepass.EsiGate3
{
    partial class mortezazadehUcGate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mortezazadehUcGate));
            this.rtbGateState = new Telerik.WinControls.UI.RadTextBox();
            this.rtbGateName = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lightsMainMode1 = new aorc.gatepass.EsiGate3.lightsMainMode();
            this.gEvent = new Telerik.WinControls.UI.RadTextBox();
            this.LightGoIn = new aorc.gatepass.EsiGate3.lightsEsmaeil();
            this.LightGoOut = new aorc.gatepass.EsiGate3.lightsEsmaeil();
            this.PicEnableGate = new System.Windows.Forms.PictureBox();
            this.PicDisableGate = new System.Windows.Forms.PictureBox();
            this.timerNews = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rtbGateState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbGateName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEnableGate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDisableGate)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbGateState
            // 
            this.rtbGateState.BackColor = System.Drawing.Color.DarkRed;
            this.rtbGateState.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtbGateState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbGateState.Location = new System.Drawing.Point(6, 108);
            this.rtbGateState.Name = "rtbGateState";
            this.rtbGateState.ReadOnly = true;
            this.rtbGateState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbGateState.Size = new System.Drawing.Size(181, 34);
            this.rtbGateState.TabIndex = 197;
            this.rtbGateState.TabStop = false;
            this.rtbGateState.Tag = "";
            this.rtbGateState.Text = "وضعیت نامشخص";
            this.rtbGateState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbGateName
            // 
            this.rtbGateName.BackColor = System.Drawing.Color.DarkRed;
            this.rtbGateName.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtbGateName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbGateName.Location = new System.Drawing.Point(6, 6);
            this.rtbGateName.Name = "rtbGateName";
            this.rtbGateName.ReadOnly = true;
            this.rtbGateName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbGateName.Size = new System.Drawing.Size(181, 34);
            this.rtbGateName.TabIndex = 14;
            this.rtbGateName.TabStop = false;
            this.rtbGateName.Tag = "";
            this.rtbGateName.Text = "نام و نشان گیت";
            this.rtbGateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.lightsMainMode1);
            this.radGroupBox1.Controls.Add(this.gEvent);
            this.radGroupBox1.Controls.Add(this.rtbGateName);
            this.radGroupBox1.Controls.Add(this.rtbGateState);
            this.radGroupBox1.Controls.Add(this.LightGoIn);
            this.radGroupBox1.Controls.Add(this.LightGoOut);
            this.radGroupBox1.Controls.Add(this.PicDisableGate);
            this.radGroupBox1.Controls.Add(this.PicEnableGate);
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
            this.radGroupBox1.Size = new System.Drawing.Size(192, 566);
            this.radGroupBox1.TabIndex = 203;
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // lightsMainMode1
            // 
            this.lightsMainMode1.GateMainMode = null;
            this.lightsMainMode1.Location = new System.Drawing.Point(6, 46);
            this.lightsMainMode1.Name = "lightsMainMode1";
            this.lightsMainMode1.Size = new System.Drawing.Size(181, 56);
            this.lightsMainMode1.TabIndex = 208;
            this.lightsMainMode1.EsmaeilBlock += new aorc.gatepass.EsiGate3.lightsMainMode.DelegateStatusAction(this.lightsMainMode1_EsmaeilBlock);
            this.lightsMainMode1.EsmaeilEmergency += new aorc.gatepass.EsiGate3.lightsMainMode.DelegateStatusAction(this.lightsMainMode1_EsmaeilEmergency);
            this.lightsMainMode1.EsmaeilNormal += new aorc.gatepass.EsiGate3.lightsMainMode.DelegateStatusAction(this.lightsMainMode1_EsmaeilNormal);
            // 
            // gEvent
            // 
            this.gEvent.BackColor = System.Drawing.Color.DarkRed;
            this.gEvent.Font = new System.Drawing.Font("2  Baran", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gEvent.Location = new System.Drawing.Point(5, 438);
            this.gEvent.Multiline = true;
            this.gEvent.Name = "gEvent";
            this.gEvent.ReadOnly = true;
            this.gEvent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.gEvent.RootElement.StretchVertically = true;
            this.gEvent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gEvent.Size = new System.Drawing.Size(181, 123);
            this.gEvent.TabIndex = 203;
            this.gEvent.TabStop = false;
            this.gEvent.Tag = "";
            this.gEvent.Text = "رویداد نگار";
            this.gEvent.ThemeName = "Office2010Black";
            // 
            // LightGoIn
            // 
            this.LightGoIn.Enabled = false;
            this.LightGoIn.GateWayMode = null;
            this.LightGoIn.Location = new System.Drawing.Point(6, 148);
            this.LightGoIn.Name = "LightGoIn";
            this.LightGoIn.Size = new System.Drawing.Size(181, 56);
            this.LightGoIn.TabIndex = 195;
            this.LightGoIn.EsmaeilBlock += new aorc.gatepass.EsiGate3.lightsEsmaeil.DelegateStatusAction(this.LightGoIn_EsmaeilBlock);
            this.LightGoIn.EsmaeilFree += new aorc.gatepass.EsiGate3.lightsEsmaeil.DelegateStatusAction(this.LightGoIn_EsmaeilFree);
            this.LightGoIn.EsmaeilCard += new aorc.gatepass.EsiGate3.lightsEsmaeil.DelegateStatusAction(this.LightGoIn_EsmaeilCard);
            // 
            // LightGoOut
            // 
            this.LightGoOut.Enabled = false;
            this.LightGoOut.GateWayMode = null;
            this.LightGoOut.Location = new System.Drawing.Point(6, 376);
            this.LightGoOut.Name = "LightGoOut";
            this.LightGoOut.Size = new System.Drawing.Size(181, 56);
            this.LightGoOut.TabIndex = 196;
            this.LightGoOut.EsmaeilBlock += new aorc.gatepass.EsiGate3.lightsEsmaeil.DelegateStatusAction(this.LightGoOut_EsmaeilBlock);
            this.LightGoOut.EsmaeilFree += new aorc.gatepass.EsiGate3.lightsEsmaeil.DelegateStatusAction(this.LightGoOut_EsmaeilFree);
            this.LightGoOut.EsmaeilCard += new aorc.gatepass.EsiGate3.lightsEsmaeil.DelegateStatusAction(this.LightGoOut_EsmaeilCard);
            // 
            // PicEnableGate
            // 
            this.PicEnableGate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicEnableGate.BackgroundImage")));
            this.PicEnableGate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicEnableGate.ErrorImage = null;
            this.PicEnableGate.Image = global::aorc.gatepass.Properties.Resources.eGateEnable02;
            this.PicEnableGate.InitialImage = null;
            this.PicEnableGate.Location = new System.Drawing.Point(5, 210);
            this.PicEnableGate.Name = "PicEnableGate";
            this.PicEnableGate.Size = new System.Drawing.Size(181, 160);
            this.PicEnableGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicEnableGate.TabIndex = 8;
            this.PicEnableGate.TabStop = false;
            this.PicEnableGate.Visible = false;
            this.PicEnableGate.Click += new System.EventHandler(this.PicEnableGate_Click);
            this.PicEnableGate.DoubleClick += new System.EventHandler(this.PicEnableGate_DoubleClick);
            // 
            // PicDisableGate
            // 
            this.PicDisableGate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicDisableGate.BackgroundImage")));
            this.PicDisableGate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicDisableGate.ErrorImage = null;
            this.PicDisableGate.Image = global::aorc.gatepass.Properties.Resources.eGateDisable;
            this.PicDisableGate.InitialImage = null;
            this.PicDisableGate.Location = new System.Drawing.Point(5, 210);
            this.PicDisableGate.Name = "PicDisableGate";
            this.PicDisableGate.Size = new System.Drawing.Size(181, 160);
            this.PicDisableGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDisableGate.TabIndex = 9;
            this.PicDisableGate.TabStop = false;
            this.PicDisableGate.Click += new System.EventHandler(this.PicDisableGate_Click);
            this.PicDisableGate.DoubleClick += new System.EventHandler(this.PicDisableGate_DoubleClick);
            // 
            // timerNews
            // 
            this.timerNews.Interval = 500;
            this.timerNews.Tick += new System.EventHandler(this.timerNews_Tick);
            // 
            // mortezazadehUcGate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Name = "mortezazadehUcGate";
            this.Size = new System.Drawing.Size(192, 566);
            ((System.ComponentModel.ISupportInitialize)(this.rtbGateState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbGateName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEnableGate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDisableGate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicEnableGate;
        private System.Windows.Forms.PictureBox PicDisableGate;
        private Telerik.WinControls.UI.RadTextBox rtbGateName;
        private lightsEsmaeil LightGoIn;
        private lightsEsmaeil LightGoOut;
        private Telerik.WinControls.UI.RadTextBox rtbGateState;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox gEvent;
        private System.Windows.Forms.Timer timerNews;
        private lightsMainMode lightsMainMode1;
    }
}
