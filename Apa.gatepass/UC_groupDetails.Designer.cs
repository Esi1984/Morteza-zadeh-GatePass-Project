namespace aorc.gatepass
{
    partial class UC_groupDetails
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.rlblActive = new Telerik.WinControls.UI.RadLabel();
            this.rddlActive = new Telerik.WinControls.UI.RadDropDownList();
            this.rlblName = new Telerik.WinControls.UI.RadLabel();
            this.rtbName = new Telerik.WinControls.UI.RadTextBox();
            this.rgbDescriptions = new Telerik.WinControls.UI.RadGroupBox();
            this.tbDescriptions = new Telerik.WinControls.UI.RadTextBox();
            this.r = new Telerik.WinControls.UI.RadGroupBox();
            this.rbtnSeeRights = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rlblActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddlActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbDescriptions)).BeginInit();
            this.rgbDescriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            this.r.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSeeRights)).BeginInit();
            this.SuspendLayout();
            // 
            // rlblActive
            // 
            this.rlblActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rlblActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlblActive.Location = new System.Drawing.Point(783, 34);
            this.rlblActive.Name = "rlblActive";
            this.rlblActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rlblActive.Size = new System.Drawing.Size(40, 17);
            this.rlblActive.TabIndex = 3;
            this.rlblActive.Text = "وضعیت";
            this.rlblActive.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // rddlActive
            // 
            this.rddlActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddlActive.DropDownAnimationEnabled = true;
            this.rddlActive.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddlActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "فعال";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "غیر فعال";
            radListDataItem2.TextWrap = true;
            this.rddlActive.Items.Add(radListDataItem1);
            this.rddlActive.Items.Add(radListDataItem2);
            this.rddlActive.Location = new System.Drawing.Point(699, 34);
            this.rddlActive.Name = "rddlActive";
            this.rddlActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rddlActive.ShowImageInEditorArea = true;
            this.rddlActive.Size = new System.Drawing.Size(78, 19);
            this.rddlActive.TabIndex = 1;
            this.rddlActive.Tag = "aens";
            // 
            // rlblName
            // 
            this.rlblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rlblName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlblName.Location = new System.Drawing.Point(783, 11);
            this.rlblName.Name = "rlblName";
            this.rlblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rlblName.Size = new System.Drawing.Size(43, 17);
            this.rlblName.TabIndex = 1;
            this.rlblName.Text = "نام گروه";
            this.rlblName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // rtbName
            // 
            this.rtbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbName.Location = new System.Drawing.Point(495, 9);
            this.rtbName.Name = "rtbName";
            this.rtbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbName.Size = new System.Drawing.Size(282, 19);
            this.rtbName.TabIndex = 0;
            this.rtbName.TabStop = false;
            this.rtbName.Tag = "aens";
            // 
            // rgbDescriptions
            // 
            this.rgbDescriptions.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbDescriptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rgbDescriptions.Controls.Add(this.tbDescriptions);
            this.rgbDescriptions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbDescriptions.FooterImageIndex = -1;
            this.rgbDescriptions.FooterImageKey = "";
            this.rgbDescriptions.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
            this.rgbDescriptions.HeaderImageIndex = -1;
            this.rgbDescriptions.HeaderImageKey = "";
            this.rgbDescriptions.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.rgbDescriptions.HeaderText = "توضیحات";
            this.rgbDescriptions.Location = new System.Drawing.Point(5, 3);
            this.rgbDescriptions.Name = "rgbDescriptions";
            this.rgbDescriptions.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.rgbDescriptions.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.rgbDescriptions.Size = new System.Drawing.Size(484, 59);
            this.rgbDescriptions.TabIndex = 5;
            this.rgbDescriptions.Text = "توضیحات";
            // 
            // tbDescriptions
            // 
            this.tbDescriptions.AutoScroll = true;
            this.tbDescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescriptions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescriptions.Location = new System.Drawing.Point(2, 18);
            this.tbDescriptions.Multiline = true;
            this.tbDescriptions.Name = "tbDescriptions";
            this.tbDescriptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.tbDescriptions.RootElement.StretchVertically = true;
            this.tbDescriptions.Size = new System.Drawing.Size(480, 39);
            this.tbDescriptions.TabIndex = 3;
            this.tbDescriptions.TabStop = false;
            this.tbDescriptions.Tag = "aen";
            // 
            // r
            // 
            this.r.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.r.Controls.Add(this.rbtnSeeRights);
            this.r.Controls.Add(this.rtbName);
            this.r.Controls.Add(this.rgbDescriptions);
            this.r.Controls.Add(this.rlblName);
            this.r.Controls.Add(this.rlblActive);
            this.r.Controls.Add(this.rddlActive);
            this.r.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.FooterImageIndex = -1;
            this.r.FooterImageKey = "";
            this.r.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
            this.r.HeaderImageIndex = -1;
            this.r.HeaderImageKey = "";
            this.r.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.r.HeaderText = "";
            this.r.Location = new System.Drawing.Point(0, 0);
            this.r.Name = "r";
            this.r.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.r.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.r.Size = new System.Drawing.Size(828, 65);
            this.r.TabIndex = 2;
            // 
            // rbtnSeeRights
            // 
            this.rbtnSeeRights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnSeeRights.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtnSeeRights.Location = new System.Drawing.Point(495, 31);
            this.rbtnSeeRights.Name = "rbtnSeeRights";
            this.rbtnSeeRights.Size = new System.Drawing.Size(198, 29);
            this.rbtnSeeRights.TabIndex = 2;
            this.rbtnSeeRights.Tag = "aen";
            this.rbtnSeeRights.Text = "تنظیم دسترسی";
            this.rbtnSeeRights.Click += new System.EventHandler(this.rbtnSeeRights_Click);
            // 
            // UC_groupDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.r);
            this.Name = "UC_groupDetails";
            this.Size = new System.Drawing.Size(828, 65);
            ((System.ComponentModel.ISupportInitialize)(this.rlblActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddlActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbDescriptions)).EndInit();
            this.rgbDescriptions.ResumeLayout(false);
            this.rgbDescriptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            this.r.ResumeLayout(false);
            this.r.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSeeRights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private Telerik.WinControls.UI.RadLabel rlblActive;
        public Telerik.WinControls.UI.RadDropDownList rddlActive;
        private Telerik.WinControls.UI.RadLabel rlblName;
        public Telerik.WinControls.UI.RadTextBox rtbName;
        private Telerik.WinControls.UI.RadGroupBox rgbDescriptions;
        private Telerik.WinControls.UI.RadGroupBox r;
        public Telerik.WinControls.UI.RadTextBox tbDescriptions;
        public Telerik.WinControls.UI.RadButton rbtnSeeRights;
    }
}
