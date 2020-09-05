namespace aorc.gatepass
{
    partial class UC_actionPanel
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
            this.rgbAction = new Telerik.WinControls.UI.RadGroupBox();
            this.rsbAction = new Telerik.WinControls.UI.RadSplitButton();
            this.rmiSearch = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiNew = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiEdit = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiView = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiDelete = new Telerik.WinControls.UI.RadMenuItem();
            this.rbtnAction = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgbAction)).BeginInit();
            this.rgbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsbAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnAction)).BeginInit();
            this.SuspendLayout();
            // 
            // rgbAction
            // 
            this.rgbAction.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbAction.Controls.Add(this.rsbAction);
            this.rgbAction.Controls.Add(this.rbtnAction);
            this.rgbAction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbAction.FooterImageIndex = -1;
            this.rgbAction.FooterImageKey = "";
            this.rgbAction.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
            this.rgbAction.HeaderImageIndex = -1;
            this.rgbAction.HeaderImageKey = "";
            this.rgbAction.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.rgbAction.HeaderText = "عملیات";
            this.rgbAction.Location = new System.Drawing.Point(3, 3);
            this.rgbAction.Name = "rgbAction";
            this.rgbAction.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.rgbAction.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.rgbAction.Size = new System.Drawing.Size(186, 52);
            this.rgbAction.TabIndex = 0;
            this.rgbAction.Text = "عملیات";
            this.rgbAction.Click += new System.EventHandler(this.rgbAction_Click);
            // 
            // rsbAction
            // 
            this.rsbAction.DefaultItem = null;
            this.rsbAction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsbAction.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmiSearch,
            this.rmiNew,
            this.rmiEdit,
            this.rmiView,
            this.rmiDelete});
            this.rsbAction.Location = new System.Drawing.Point(42, 19);
            this.rsbAction.Name = "rsbAction";
            this.rsbAction.Size = new System.Drawing.Size(133, 26);
            this.rsbAction.TabIndex = 1;
            this.rsbAction.Text = "تنظیم وضعیت";
            // 
            // rmiSearch
            // 
            this.rmiSearch.AccessibleDescription = "حالت جستجو";
            this.rmiSearch.AccessibleName = "حالت جستجو";
            this.rmiSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmiSearch.Image = global::aorc.gatepass.Properties.Resources.search;
            this.rmiSearch.Name = "rmiSearch";
            this.rmiSearch.Text = "حالت جستجو";
            this.rmiSearch.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiSearch.Click += new System.EventHandler(this.rmiSearch_Click);
            // 
            // rmiNew
            // 
            this.rmiNew.AccessibleDescription = "حالت افزودن";
            this.rmiNew.AccessibleName = "حالت افزودن";
            this.rmiNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmiNew.Image = global::aorc.gatepass.Properties.Resources.add_new;
            this.rmiNew.Name = "rmiNew";
            this.rmiNew.Text = "حالت افزودن";
            this.rmiNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiNew.Click += new System.EventHandler(this.rmiNew_Click);
            // 
            // rmiEdit
            // 
            this.rmiEdit.AccessibleDescription = "حالت ویرایش";
            this.rmiEdit.AccessibleName = "حالت ویرایش";
            this.rmiEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmiEdit.Image = global::aorc.gatepass.Properties.Resources.edit;
            this.rmiEdit.Name = "rmiEdit";
            this.rmiEdit.Text = "حالت ویرایش";
            this.rmiEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiEdit.Click += new System.EventHandler(this.rmiEdit_Click);
            // 
            // rmiView
            // 
            this.rmiView.AccessibleDescription = "حالت مشاهده";
            this.rmiView.AccessibleName = "حالت مشاهده";
            this.rmiView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmiView.Image = global::aorc.gatepass.Properties.Resources.view;
            this.rmiView.Name = "rmiView";
            this.rmiView.Text = "حالت مشاهده";
            this.rmiView.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiView.Click += new System.EventHandler(this.rmiView_Click);
            // 
            // rmiDelete
            // 
            this.rmiDelete.AccessibleDescription = "حذف";
            this.rmiDelete.AccessibleName = "حذف";
            this.rmiDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmiDelete.Image = global::aorc.gatepass.Properties.Resources.delete;
            this.rmiDelete.Name = "rmiDelete";
            this.rmiDelete.Text = "حذف";
            this.rmiDelete.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiDelete.Click += new System.EventHandler(this.rmiDelete_Click);
            // 
            // rbtnAction
            // 
            this.rbtnAction.AutoSize = true;
            this.rbtnAction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbtnAction.Image = global::aorc.gatepass.Properties.Resources.pass3;
            this.rbtnAction.Location = new System.Drawing.Point(10, 19);
            this.rbtnAction.Name = "rbtnAction";
            this.rbtnAction.Size = new System.Drawing.Size(26, 26);
            this.rbtnAction.TabIndex = 2;
            this.rbtnAction.Tag = "";
            // 
            // UC_actionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgbAction);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "UC_actionPanel";
            this.Size = new System.Drawing.Size(193, 59);
            ((System.ComponentModel.ISupportInitialize)(this.rgbAction)).EndInit();
            this.rgbAction.ResumeLayout(false);
            this.rgbAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsbAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnAction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox rgbAction;
        private Telerik.WinControls.UI.RadSplitButton rsbAction;
        private Telerik.WinControls.UI.RadButton rbtnAction;
        private Telerik.WinControls.UI.RadMenuItem rmiSearch;
        private Telerik.WinControls.UI.RadMenuItem rmiNew;
        private Telerik.WinControls.UI.RadMenuItem rmiEdit;
        private Telerik.WinControls.UI.RadMenuItem rmiView;
        private Telerik.WinControls.UI.RadMenuItem rmiDelete;
    }
}
