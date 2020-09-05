using Telerik.WinControls.UI;

namespace aorc.gatepass
{
	partial class mainForm
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
            this.rmiStatus = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiStatusView = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiStatusSearch = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiStatusNew = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiStatusEdit = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.rmiStatusDelete = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiStatusPrint = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiStatusSettingPrint = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.rmiStatusExit = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiEdit = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiCut = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiCopy = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiPaste = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiAction = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiSave = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiCancel = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiHelp = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiHelp2 = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiAbout = new Telerik.WinControls.UI.RadMenuItem();
            this.commandBarRowElement2MainF = new Telerik.WinControls.UI.CommandBarRowElement();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.rmiView = new Telerik.WinControls.UI.RadMenuItem();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElementStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.commandBarRowElement1MainF = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1MainF = new Telerik.WinControls.UI.CommandBarStripElement();
            this.cbbView = new Telerik.WinControls.UI.CommandBarButton();
            this.cbbSearch = new Telerik.WinControls.UI.CommandBarButton();
            this.cbbNew = new Telerik.WinControls.UI.CommandBarButton();
            this.cbbEdit = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator1MainF = new Telerik.WinControls.UI.CommandBarSeparator();
            this.cbbDelete = new Telerik.WinControls.UI.CommandBarButton();
            this.cbbSave = new Telerik.WinControls.UI.CommandBarButton();
            this.cbbCancel = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator3MainF = new Telerik.WinControls.UI.CommandBarSeparator();
            this.cbbPrint = new Telerik.WinControls.UI.CommandBarButton();
            this.RadCommandBar1MainF = new Telerik.WinControls.UI.RadCommandBar();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadCommandBar1MainF)).BeginInit();
            this.SuspendLayout();
            // 
            // rmiStatus
            // 
            this.rmiStatus.AccessibleDescription = "پرونده";
            this.rmiStatus.AccessibleName = "پرونده";
            this.rmiStatus.Class = "";
            this.rmiStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiStatus.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmiStatusView,
            this.rmiStatusSearch,
            this.rmiStatusNew,
            this.rmiStatusEdit,
            this.radMenuSeparatorItem1});
            this.rmiStatus.Name = "rmiStatus";
            this.rmiStatus.Text = "وضعیت";
            this.rmiStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // rmiStatusView
            // 
            this.rmiStatusView.AccessibleDescription = "مشاهده";
            this.rmiStatusView.AccessibleName = "مشاهده";
            this.rmiStatusView.Class = "";
            this.rmiStatusView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.rmiStatusView.Image = global::aorc.gatepass.Properties.Resources.view;
            this.rmiStatusView.Name = "rmiStatusView";
            this.rmiStatusView.Tag = null;
            this.rmiStatusView.Text = "مشاهده";
            this.rmiStatusView.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiStatusView.Click += new System.EventHandler(this.rmiStatusView_Click);
            // 
            // rmiStatusSearch
            // 
            this.rmiStatusSearch.AccessibleDescription = "جستجو";
            this.rmiStatusSearch.AccessibleName = "جستجو";
            this.rmiStatusSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiStatusSearch.Image = global::aorc.gatepass.Properties.Resources.search_b_icon__2_;
            this.rmiStatusSearch.Name = "rmiStatusSearch";
            this.rmiStatusSearch.Text = "جستجو";
            this.rmiStatusSearch.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiStatusSearch.Click += new System.EventHandler(this.rmiStatusSearch_Click);
            // 
            // rmiStatusNew
            // 
            this.rmiStatusNew.AccessibleDescription = "جدید";
            this.rmiStatusNew.AccessibleName = "جدید";
            this.rmiStatusNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiStatusNew.Image = global::aorc.gatepass.Properties.Resources.add_new;
            this.rmiStatusNew.Name = "rmiStatusNew";
            this.rmiStatusNew.Text = "جدید";
            this.rmiStatusNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiStatusNew.Click += new System.EventHandler(this.rmiStatusNew_Click);
            // 
            // rmiStatusEdit
            // 
            this.rmiStatusEdit.AccessibleDescription = "ویرایش";
            this.rmiStatusEdit.AccessibleName = "ویرایش";
            this.rmiStatusEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiStatusEdit.Image = global::aorc.gatepass.Properties.Resources.edit;
            this.rmiStatusEdit.Name = "rmiStatusEdit";
            this.rmiStatusEdit.Text = "ویرایش";
            this.rmiStatusEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiStatusEdit.Click += new System.EventHandler(this.rmiStatusEdit_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // rmiStatusDelete
            // 
            this.rmiStatusDelete.AccessibleDescription = "حذف";
            this.rmiStatusDelete.AccessibleName = "حذف";
            this.rmiStatusDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiStatusDelete.Image = global::aorc.gatepass.Properties.Resources.blue_recycle_bin_icon;
            this.rmiStatusDelete.Name = "rmiStatusDelete";
            this.rmiStatusDelete.Text = "حذف";
            this.rmiStatusDelete.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiStatusDelete.Click += new System.EventHandler(this.rmiStatusDelete_Click);
            // 
            // rmiStatusPrint
            // 
            this.rmiStatusPrint.AccessibleDescription = "چاپ";
            this.rmiStatusPrint.AccessibleName = "چاپ";
            this.rmiStatusPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiStatusPrint.Image = global::aorc.gatepass.Properties.Resources.print_icon;
            this.rmiStatusPrint.Name = "rmiStatusPrint";
            this.rmiStatusPrint.Text = "چاپ";
            this.rmiStatusPrint.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiStatusPrint.Click += new System.EventHandler(this.rmiStatusPrint_Click);
            // 
            // rmiStatusSettingPrint
            // 
            this.rmiStatusSettingPrint.AccessibleDescription = "تنظیمات چاپ";
            this.rmiStatusSettingPrint.AccessibleName = "تنظیمات چاپ";
            this.rmiStatusSettingPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiStatusSettingPrint.Image = global::aorc.gatepass.Properties.Resources.printSettings;
            this.rmiStatusSettingPrint.Name = "rmiStatusSettingPrint";
            this.rmiStatusSettingPrint.Text = "تنظیمات چاپ";
            this.rmiStatusSettingPrint.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiStatusSettingPrint.Click += new System.EventHandler(this.rmiStatusSettingPrint_Click);
            // 
            // radMenuSeparatorItem2
            // 
            this.radMenuSeparatorItem2.AccessibleDescription = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.AccessibleName = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // rmiStatusExit
            // 
            this.rmiStatusExit.AccessibleDescription = "خروج";
            this.rmiStatusExit.AccessibleName = "خروج";
            this.rmiStatusExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiStatusExit.Image = global::aorc.gatepass.Properties.Resources.exit;
            this.rmiStatusExit.Name = "rmiStatusExit";
            this.rmiStatusExit.Text = "خروج";
            this.rmiStatusExit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiStatusExit.Click += new System.EventHandler(this.rmiStatusExit_Click);
            // 
            // rmiEdit
            // 
            this.rmiEdit.AccessibleDescription = "ویرایش";
            this.rmiEdit.AccessibleName = "ویرایش";
            this.rmiEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiEdit.Image = null;
            this.rmiEdit.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmiCut,
            this.rmiCopy,
            this.rmiPaste});
            this.rmiEdit.Name = "rmiEdit";
            this.rmiEdit.Text = "ویرایش";
            this.rmiEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // rmiCut
            // 
            this.rmiCut.AccessibleDescription = "برش";
            this.rmiCut.AccessibleName = "برش";
            this.rmiCut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiCut.Image = global::aorc.gatepass.Properties.Resources.cut;
            this.rmiCut.Name = "rmiCut";
            this.rmiCut.Text = "برش";
            this.rmiCut.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiCut.Click += new System.EventHandler(this.rmiCut_Click);
            // 
            // rmiCopy
            // 
            this.rmiCopy.AccessibleDescription = "رونوشت";
            this.rmiCopy.AccessibleName = "رونوشت";
            this.rmiCopy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiCopy.Image = global::aorc.gatepass.Properties.Resources.copy;
            this.rmiCopy.Name = "rmiCopy";
            this.rmiCopy.Text = "رونوشت";
            this.rmiCopy.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiCopy.Click += new System.EventHandler(this.rmiCopy_Click);
            // 
            // rmiPaste
            // 
            this.rmiPaste.AccessibleDescription = "چسباندن";
            this.rmiPaste.AccessibleName = "چسباندن";
            this.rmiPaste.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiPaste.Image = global::aorc.gatepass.Properties.Resources.paste;
            this.rmiPaste.Name = "rmiPaste";
            this.rmiPaste.Text = "چسباندن";
            this.rmiPaste.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiPaste.Click += new System.EventHandler(this.rmiPaste_Click);
            // 
            // rmiAction
            // 
            this.rmiAction.AccessibleDescription = "عملیات";
            this.rmiAction.AccessibleName = "عملیات";
            this.rmiAction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiAction.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmiSave,
            this.rmiCancel,
            this.rmiStatusDelete,
            this.rmiStatusPrint,
            this.rmiStatusSettingPrint,
            this.radMenuSeparatorItem2,
            this.rmiStatusExit});
            this.rmiAction.Name = "rmiAction";
            this.rmiAction.Text = "عملیات";
            this.rmiAction.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // rmiSave
            // 
            this.rmiSave.AccessibleDescription = "تایید";
            this.rmiSave.AccessibleName = "تایید";
            this.rmiSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiSave.Image = global::aorc.gatepass.Properties.Resources.pass3;
            this.rmiSave.Name = "rmiSave";
            this.rmiSave.Text = "تایید";
            this.rmiSave.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiSave.Click += new System.EventHandler(this.rmiSave_Click);
            // 
            // rmiCancel
            // 
            this.rmiCancel.AccessibleDescription = "انصراف";
            this.rmiCancel.AccessibleName = "انصراف";
            this.rmiCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiCancel.Image = global::aorc.gatepass.Properties.Resources.cancel;
            this.rmiCancel.Name = "rmiCancel";
            this.rmiCancel.Text = "انصراف";
            this.rmiCancel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiCancel.Click += new System.EventHandler(this.rmiCancel_Click);
            // 
            // rmiHelp
            // 
            this.rmiHelp.AccessibleDescription = "راهنما";
            this.rmiHelp.AccessibleName = "راهنما";
            this.rmiHelp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiHelp.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmiHelp2,
            this.rmiAbout});
            this.rmiHelp.Name = "rmiHelp";
            this.rmiHelp.Text = "راهنما";
            this.rmiHelp.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // rmiHelp2
            // 
            this.rmiHelp2.AccessibleDescription = "راهنما";
            this.rmiHelp2.AccessibleName = "راهنما";
            this.rmiHelp2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiHelp2.Image = global::aorc.gatepass.Properties.Resources.help;
            this.rmiHelp2.Name = "rmiHelp2";
            this.rmiHelp2.Text = "راهنما";
            this.rmiHelp2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiHelp2.Click += new System.EventHandler(this.rmiHelp2_Click);
            // 
            // rmiAbout
            // 
            this.rmiAbout.AccessibleDescription = "درباره";
            this.rmiAbout.AccessibleName = "درباره";
            this.rmiAbout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiAbout.Image = global::aorc.gatepass.Properties.Resources.about;
            this.rmiAbout.Name = "rmiAbout";
            this.rmiAbout.Text = "درباره";
            this.rmiAbout.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiAbout.Click += new System.EventHandler(this.rmiAbout_Click);
            // 
            // commandBarRowElement2MainF
            // 
            this.commandBarRowElement2MainF.DisplayName = null;
            this.commandBarRowElement2MainF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.commandBarRowElement2MainF.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement2MainF.Text = "";
            // 
            // radMenu1
            // 
            this.radMenu1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmiStatus,
            this.rmiEdit,
            this.rmiView,
            this.rmiAction,
            this.rmiHelp});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radMenu1.Size = new System.Drawing.Size(549, 19);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            // 
            // rmiView
            // 
            this.rmiView.AccessibleDescription = "مشاهده";
            this.rmiView.AccessibleName = "مشاهده";
            this.rmiView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rmiView.Name = "rmiView";
            this.rmiView.Text = "مشاهده";
            this.rmiView.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElementStatus});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 214);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radStatusStrip1.Size = new System.Drawing.Size(549, 24);
            this.radStatusStrip1.TabIndex = 4;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.Resize += new System.EventHandler(this.radStatusStrip1_Resize);
            // 
            // radLabelElementStatus
            // 
            this.radLabelElementStatus.AccessibleDescription = "مشاهده، جستجو و مدیریت قرارداد ها";
            this.radLabelElementStatus.AccessibleName = "مشاهده، جستجو و مدیریت قرارداد ها";
            this.radLabelElementStatus.AutoSize = false;
            this.radLabelElementStatus.Bounds = new System.Drawing.Rectangle(0, 0, 231, 18);
            this.radLabelElementStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabelElementStatus.Name = "radLabelElementStatus";
            this.radStatusStrip1.SetSpring(this.radLabelElementStatus, false);
            this.radLabelElementStatus.Text = "نوار وضعیت مربوط به حالت جاری عملیات اجرایی";
            this.radLabelElementStatus.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElementStatus.TextWrap = true;
            this.radLabelElementStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarRowElement1MainF
            // 
            this.commandBarRowElement1MainF.DisplayName = null;
            this.commandBarRowElement1MainF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.commandBarRowElement1MainF.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1MainF.RightToLeft = true;
            this.commandBarRowElement1MainF.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1MainF});
            this.commandBarRowElement1MainF.Text = "";
            // 
            // commandBarStripElement1MainF
            // 
            this.commandBarStripElement1MainF.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1MainF.FloatingForm = null;
            this.commandBarStripElement1MainF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.commandBarStripElement1MainF.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.cbbView,
            this.cbbSearch,
            this.cbbNew,
            this.cbbEdit,
            this.commandBarSeparator1MainF,
            this.cbbDelete,
            this.cbbSave,
            this.cbbCancel,
            this.commandBarSeparator3MainF,
            this.cbbPrint});
            this.commandBarStripElement1MainF.Name = "commandBarStripElement1";
            this.commandBarStripElement1MainF.Text = "";
            // 
            // cbbView
            // 
            this.cbbView.AccessibleDescription = "مشاهده";
            this.cbbView.AccessibleName = "مشاهده";
            this.cbbView.ClipText = true;
            this.cbbView.DisplayName = "مشاهده";
            this.cbbView.DrawText = true;
            this.cbbView.FlipText = false;
            this.cbbView.Image = global::aorc.gatepass.Properties.Resources._52;
            this.cbbView.Name = "cbbView";
            this.cbbView.Tag = "av";
            this.cbbView.Text = "بازآوری";
            this.cbbView.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbbView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbbView.TextWrap = false;
            this.cbbView.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbbView.Click += new System.EventHandler(this.cbbView_Click);
            // 
            // cbbSearch
            // 
            this.cbbSearch.AccessibleDescription = "جستجو";
            this.cbbSearch.AccessibleName = "جستجو";
            this.cbbSearch.DisplayName = "جستجو";
            this.cbbSearch.DrawText = true;
            this.cbbSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbbSearch.Image = global::aorc.gatepass.Properties.Resources.search;
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Tag = "av";
            this.cbbSearch.Text = "جستجو";
            this.cbbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbbSearch.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbbSearch.Click += new System.EventHandler(this.cbbSearch_Click);
            // 
            // cbbNew
            // 
            this.cbbNew.AccessibleDescription = "جدید";
            this.cbbNew.AccessibleName = "جدید";
            this.cbbNew.DisplayName = "جدید";
            this.cbbNew.DrawText = true;
            this.cbbNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbbNew.Image = global::aorc.gatepass.Properties.Resources.add_new;
            this.cbbNew.Name = "cbbNew";
            this.cbbNew.Tag = "av";
            this.cbbNew.Text = "جدید";
            this.cbbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbbNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbbNew.Click += new System.EventHandler(this.cbbNew_Click);
            // 
            // cbbEdit
            // 
            this.cbbEdit.AccessibleDescription = "ویرایش";
            this.cbbEdit.AccessibleName = "ویرایش";
            this.cbbEdit.DisplayName = "ویرایش";
            this.cbbEdit.DrawText = true;
            this.cbbEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbbEdit.Image = global::aorc.gatepass.Properties.Resources.edit;
            this.cbbEdit.Name = "cbbEdit";
            this.cbbEdit.Tag = "av";
            this.cbbEdit.Text = "ویرایش";
            this.cbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbbEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbbEdit.Click += new System.EventHandler(this.cbbEdit_Click);
            // 
            // commandBarSeparator1MainF
            // 
            this.commandBarSeparator1MainF.AccessibleDescription = "commandBarSeparator1";
            this.commandBarSeparator1MainF.AccessibleName = "commandBarSeparator1";
            this.commandBarSeparator1MainF.DisplayName = "خط جدا کننده شماره یک";
            this.commandBarSeparator1MainF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.commandBarSeparator1MainF.Name = "commandBarSeparator1MainF";
            this.commandBarSeparator1MainF.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator1MainF.VisibleInOverflowMenu = false;
            // 
            // cbbDelete
            // 
            this.cbbDelete.AccessibleDescription = "حذف";
            this.cbbDelete.AccessibleName = "حذف";
            this.cbbDelete.DisplayName = "حذف";
            this.cbbDelete.DrawText = true;
            this.cbbDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbbDelete.Image = global::aorc.gatepass.Properties.Resources.blue_recycle_bin_icon;
            this.cbbDelete.Name = "cbbDelete";
            this.cbbDelete.Tag = "av";
            this.cbbDelete.Text = "حذف";
            this.cbbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbbDelete.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbbDelete.Click += new System.EventHandler(this.cbbDelete_Click);
            // 
            // cbbSave
            // 
            this.cbbSave.AccessibleDescription = "تایید";
            this.cbbSave.AccessibleName = "تایید";
            this.cbbSave.DisplayName = "تایید";
            this.cbbSave.DrawText = true;
            this.cbbSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbbSave.Image = global::aorc.gatepass.Properties.Resources.pass3;
            this.cbbSave.Name = "cbbSave";
            this.cbbSave.Tag = "asned";
            this.cbbSave.Text = "تایید";
            this.cbbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbbSave.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbbSave.Click += new System.EventHandler(this.cbbSave_Click);
            // 
            // cbbCancel
            // 
            this.cbbCancel.AccessibleDescription = "انصراف";
            this.cbbCancel.AccessibleName = "انصراف";
            this.cbbCancel.DisplayName = "انصراف";
            this.cbbCancel.DrawText = true;
            this.cbbCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbbCancel.Image = global::aorc.gatepass.Properties.Resources.cancel;
            this.cbbCancel.Name = "cbbCancel";
            this.cbbCancel.Tag = "asned";
            this.cbbCancel.Text = "انصراف";
            this.cbbCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbbCancel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbbCancel.Click += new System.EventHandler(this.cbbCancel_Click);
            // 
            // commandBarSeparator3MainF
            // 
            this.commandBarSeparator3MainF.AccessibleDescription = "commandBarSeparator3";
            this.commandBarSeparator3MainF.AccessibleName = "commandBarSeparator3";
            this.commandBarSeparator3MainF.DisplayName = "خط جدا کننده شماره سه";
            this.commandBarSeparator3MainF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.commandBarSeparator3MainF.Name = "commandBarSeparator3MainF";
            this.commandBarSeparator3MainF.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator3MainF.VisibleInOverflowMenu = false;
            // 
            // cbbPrint
            // 
            this.cbbPrint.AccessibleDescription = "چاپ";
            this.cbbPrint.AccessibleName = "چاپ";
            this.cbbPrint.DisplayName = "چاپ";
            this.cbbPrint.DrawText = true;
            this.cbbPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbbPrint.Image = global::aorc.gatepass.Properties.Resources.print_icon;
            this.cbbPrint.Name = "cbbPrint";
            this.cbbPrint.Tag = "av";
            this.cbbPrint.Text = "چاپ";
            this.cbbPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbbPrint.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // RadCommandBar1MainF
            // 
            this.RadCommandBar1MainF.AutoSize = true;
            this.RadCommandBar1MainF.Dock = System.Windows.Forms.DockStyle.Top;
            this.RadCommandBar1MainF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadCommandBar1MainF.Location = new System.Drawing.Point(0, 19);
            this.RadCommandBar1MainF.Name = "RadCommandBar1MainF";
            this.RadCommandBar1MainF.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1MainF});
            this.RadCommandBar1MainF.Size = new System.Drawing.Size(549, 55);
            this.RadCommandBar1MainF.TabIndex = 1;
            this.RadCommandBar1MainF.Tag = "";
            this.RadCommandBar1MainF.Text = "radCommandBar1";
            // 
            // mainForm
            // 
            this.AcceptButton = this.rmiSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 238);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.RadCommandBar1MainF);
            this.Controls.Add(this.radMenu1);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم مادر";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.VisibleChanged += new System.EventHandler(this.mainForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadCommandBar1MainF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		protected Telerik.WinControls.UI.RadMenu radMenu1;
		protected Telerik.WinControls.UI.RadMenuItem rmiStatus;
		private Telerik.WinControls.UI.RadMenuItem rmiStatusEdit;
		private Telerik.WinControls.UI.RadMenuItem rmiStatusNew;
		protected Telerik.WinControls.UI.RadMenuItem rmiStatusDelete;
		private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
		private Telerik.WinControls.UI.RadMenuItem rmiStatusPrint;
		private Telerik.WinControls.UI.RadMenuItem rmiStatusSettingPrint;
		private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem2;
		private Telerik.WinControls.UI.RadMenuItem rmiStatusExit;
		private Telerik.WinControls.UI.RadMenuItem rmiEdit;
		private Telerik.WinControls.UI.RadMenuItem rmiCut;
		private Telerik.WinControls.UI.RadMenuItem rmiCopy;
		private Telerik.WinControls.UI.RadMenuItem rmiPaste;
		private Telerik.WinControls.UI.RadMenuItem rmiAction;
		private Telerik.WinControls.UI.RadMenuItem rmiSave;
		private Telerik.WinControls.UI.RadMenuItem rmiCancel;
		private Telerik.WinControls.UI.RadMenuItem rmiHelp;
		private Telerik.WinControls.UI.RadMenuItem rmiHelp2;
		private Telerik.WinControls.UI.RadMenuItem rmiAbout;
		private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2MainF;
		private Telerik.WinControls.UI.RadMenuItem rmiStatusSearch;
		protected Telerik.WinControls.UI.RadMenuItem rmiView;
		private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
		protected Telerik.WinControls.UI.RadLabelElement radLabelElementStatus;
		private Telerik.WinControls.UI.RadMenuItem rmiStatusView;
		private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
		private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1MainF;
		protected Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1MainF;
		private Telerik.WinControls.UI.CommandBarButton cbbView;
		private Telerik.WinControls.UI.CommandBarButton cbbSearch;
		protected Telerik.WinControls.UI.CommandBarButton cbbNew;
		protected Telerik.WinControls.UI.CommandBarButton cbbEdit;
		private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1MainF;
		private Telerik.WinControls.UI.CommandBarButton cbbDelete;
		private Telerik.WinControls.UI.CommandBarButton cbbSave;
		private Telerik.WinControls.UI.CommandBarButton cbbCancel;
		private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator3MainF;
		private Telerik.WinControls.UI.CommandBarButton cbbPrint;
		private Telerik.WinControls.UI.RadCommandBar RadCommandBar1MainF;
		public RadDropDownMenu contextMenu = new RadDropDownMenu ();
		
	}
}

