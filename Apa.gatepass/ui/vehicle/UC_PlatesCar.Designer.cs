namespace aorc.gatepass.ui.vehicle
{
    partial class UC_PlatesCar
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
            this.rgbCarNumber = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rddlTypePlate = new Telerik.WinControls.UI.RadDropDownList();
            this.uC_PlatesSimple1 = new aorc.gatepass.ui.vehicle.UC_PlatesSimple();
            this.uC_PlatesMeli1 = new aorc.gatepass.ui.vehicle.UC_PlatesMeli();
            ((System.ComponentModel.ISupportInitialize)(this.rgbCarNumber)).BeginInit();
            this.rgbCarNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddlTypePlate)).BeginInit();
            this.SuspendLayout();
            // 
            // rgbCarNumber
            // 
            this.rgbCarNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbCarNumber.Controls.Add(this.radLabel1);
            this.rgbCarNumber.Controls.Add(this.rddlTypePlate);
            this.rgbCarNumber.Controls.Add(this.uC_PlatesSimple1);
            this.rgbCarNumber.Controls.Add(this.uC_PlatesMeli1);
            this.rgbCarNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgbCarNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbCarNumber.FooterImageIndex = -1;
            this.rgbCarNumber.FooterImageKey = "";
            this.rgbCarNumber.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
            this.rgbCarNumber.HeaderImageIndex = -1;
            this.rgbCarNumber.HeaderImageKey = "";
            this.rgbCarNumber.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.rgbCarNumber.HeaderText = "";
            this.rgbCarNumber.Location = new System.Drawing.Point(0, 0);
            this.rgbCarNumber.Name = "rgbCarNumber";
            this.rgbCarNumber.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.rgbCarNumber.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.rgbCarNumber.Size = new System.Drawing.Size(148, 69);
            this.rgbCarNumber.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Location = new System.Drawing.Point(94, 5);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(46, 17);
            this.radLabel1.TabIndex = 19;
            this.radLabel1.Text = "نوع پلاک";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // rddlTypePlate
            // 
            this.rddlTypePlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rddlTypePlate.DropDownAnimationEnabled = true;
            this.rddlTypePlate.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddlTypePlate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "ملی";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "دو بخشی";
            radListDataItem2.TextWrap = true;
            this.rddlTypePlate.Items.Add(radListDataItem1);
            this.rddlTypePlate.Items.Add(radListDataItem2);
            this.rddlTypePlate.Location = new System.Drawing.Point(10, 3);
            this.rddlTypePlate.Name = "rddlTypePlate";
            this.rddlTypePlate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rddlTypePlate.ShowImageInEditorArea = true;
            this.rddlTypePlate.Size = new System.Drawing.Size(78, 19);
            this.rddlTypePlate.TabIndex = 18;
            this.rddlTypePlate.Tag = "ans";
            this.rddlTypePlate.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rddlTypePlate_SelectedIndexChanged);
            // 
            // uC_PlatesSimple1
            // 
            this.uC_PlatesSimple1.CarNumber = null;
            this.uC_PlatesSimple1.CarNumberTags = "aens";
            this.uC_PlatesSimple1.Location = new System.Drawing.Point(9, 23);
            this.uC_PlatesSimple1.Name = "uC_PlatesSimple1";
            this.uC_PlatesSimple1.Size = new System.Drawing.Size(130, 44);
            this.uC_PlatesSimple1.TabIndex = 21;
            this.uC_PlatesSimple1.Visible = false;
            // 
            // uC_PlatesMeli1
            // 
            this.uC_PlatesMeli1.CarNumber = null;
            this.uC_PlatesMeli1.CarNumberTags = "aens";
            this.uC_PlatesMeli1.Location = new System.Drawing.Point(0, 28);
            this.uC_PlatesMeli1.Name = "uC_PlatesMeli1";
            this.uC_PlatesMeli1.Size = new System.Drawing.Size(147, 25);
            this.uC_PlatesMeli1.TabIndex = 20;
            this.uC_PlatesMeli1.Visible = false;
            // 
            // UC_PlatesCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgbCarNumber);
            this.Name = "UC_PlatesCar";
            this.Size = new System.Drawing.Size(148, 69);
            this.Load += new System.EventHandler(this.UC_PlatesCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgbCarNumber)).EndInit();
            this.rgbCarNumber.ResumeLayout(false);
            this.rgbCarNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddlTypePlate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox rgbCarNumber;
        public Telerik.WinControls.UI.RadDropDownList rddlTypePlate;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        public UC_PlatesMeli uC_PlatesMeli1;
        public UC_PlatesSimple uC_PlatesSimple1;


	}
}
