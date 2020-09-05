namespace aorc.gatepass.Reports
{
    partial class v1_08GPPrint
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Drawing.FormattingRule formattingRule1 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule2 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule3 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule4 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule5 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule6 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule7 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.detail = new Telerik.Reporting.DetailSection();
            this.panel1 = new Telerik.Reporting.Panel();
            this.pictureBox1 = new Telerik.Reporting.PictureBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.panel2 = new Telerik.Reporting.Panel();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.panel3 = new Telerik.Reporting.Panel();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.textBox19 = new Telerik.Reporting.TextBox();
            this.textBox20 = new Telerik.Reporting.TextBox();
            this.textBox18 = new Telerik.Reporting.TextBox();
            this.panel4 = new Telerik.Reporting.Panel();
            this.textBox24 = new Telerik.Reporting.TextBox();
            this.textBox25 = new Telerik.Reporting.TextBox();
            this.textBox26 = new Telerik.Reporting.TextBox();
            this.textBox27 = new Telerik.Reporting.TextBox();
            this.textBox28 = new Telerik.Reporting.TextBox();
            this.textBox29 = new Telerik.Reporting.TextBox();
            this.textBox30 = new Telerik.Reporting.TextBox();
            this.textBox31 = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.textBox32 = new Telerik.Reporting.TextBox();
            this.textBox33 = new Telerik.Reporting.TextBox();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.textBox14 = new Telerik.Reporting.TextBox();
            this.textBox22 = new Telerik.Reporting.TextBox();
            this.textBox21 = new Telerik.Reporting.TextBox();
            this.panel5 = new Telerik.Reporting.Panel();
            this.checkBox2 = new Telerik.Reporting.CheckBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.tbVersion = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Data Source=sqlserver;Initial Catalog=apa_aorcGP;Integrated Security=True";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.ProviderName = "System.Data.SqlClient";
            this.sqlDataSource1.SelectCommand = "SELECT        View_Archives.*\r\nFROM            View_Archives";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(11.938000679016113D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel1,
            this.textBox1,
            this.tbVersion});
            this.detail.Name = "detail";
            this.detail.ItemDataBound += new System.EventHandler(this.detail_ItemDataBound);
            // 
            // panel1
            // 
            this.panel1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pictureBox1,
            this.textBox3,
            this.textBox4,
            this.textBox5,
            this.textBox6,
            this.textBox7,
            this.textBox8,
            this.textBox9,
            this.textBox10,
            this.textBox11,
            this.textBox12,
            this.panel2,
            this.textBox13,
            this.panel3,
            this.textBox15,
            this.textBox19,
            this.textBox20,
            this.textBox18,
            this.panel4,
            this.textBox24,
            this.textBox25,
            this.textBox26,
            this.textBox27,
            this.textBox28,
            this.textBox29,
            this.textBox30,
            this.textBox31,
            this.textBox17,
            this.textBox32,
            this.textBox33,
            this.barcode1,
            this.textBox14,
            this.textBox22,
            this.textBox21,
            this.panel5});
            this.panel1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0799989700317383D), Telerik.Reporting.Drawing.Unit.Mm(5.0799989700317383D));
            this.panel1.Name = "panel1";
            this.panel1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(92.980628967285156D), Telerik.Reporting.Drawing.Unit.Mm(105.64434051513672D));
            this.panel1.Style.BackgroundColor = System.Drawing.Color.Empty;
            this.panel1.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.panel1.Style.Font.Name = "B Traffic";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0.0010012307902798057D));
            this.pictureBox1.MimeType = "";
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(30.479001998901367D), Telerik.Reporting.Drawing.Unit.Mm(30.479001998901367D));
            this.pictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pictureBox1.Value = "= Fields.Person_Picture";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = false;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(32.755416870117188D), Telerik.Reporting.Drawing.Unit.Mm(17.515419006347656D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.152000427246094D), Telerik.Reporting.Drawing.Unit.Mm(5.0799989700317383D));
            this.textBox3.Style.Font.Bold = true;
            this.textBox3.Style.Font.Name = "B Titr";
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.Value = "= IIf(IsNull(Fields.Person_IdentifyCode,\"\").Trim() <> \"\", IsNull(Fields.Person_Id" +
                "entifyCode,\"\").Trim() , Fields.Person_NationalCode)";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = false;
            formattingRule1.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("= Len(Fields.Person_Name + \" \" + Fields.Person_Surname)", Telerik.Reporting.Data.FilterOperator.GreaterThan, "25")});
            formattingRule1.Style.Font.Bold = true;
            formattingRule1.Style.Font.Name = "B Titr";
            formattingRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox4.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule1});
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(32.755416870117188D), Telerik.Reporting.Drawing.Unit.Mm(22.595418930053711D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.152004241943359D), Telerik.Reporting.Drawing.Unit.Mm(7.8845839500427246D));
            this.textBox4.Style.Font.Bold = true;
            this.textBox4.Style.Font.Name = "B Titr";
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.Value = "= Fields.Person_Name + \" \" + Fields.Person_Surname";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = false;
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(48.268047332763672D), Telerik.Reporting.Drawing.Unit.Mm(30.480001449584961D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(25.41203498840332D), Telerik.Reporting.Drawing.Unit.Mm(5.0719876289367676D));
            this.textBox5.Style.Font.Name = "B Nazanin";
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.Value = "اعتبار این پروانه : ";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = false;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(81.292037963867188D), Telerik.Reporting.Drawing.Unit.Mm(35.560005187988281D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(5.0799951553344727D), Telerik.Reporting.Drawing.Unit.Mm(5.0739998817443848D));
            this.textBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox6.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox6.Style.Font.Name = "B Nazanin";
            this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox6.Value = "از";
            // 
            // textBox7
            // 
            this.textBox7.CanGrow = false;
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(48.268047332763672D), Telerik.Reporting.Drawing.Unit.Mm(35.553989410400391D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(33.021991729736328D), Telerik.Reporting.Drawing.Unit.Mm(5.0739974975585938D));
            this.textBox7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox7.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox7.Style.Font.Name = "B Titr";
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox7.Value = "= aorc.gatepass.ItemsPublic.GetPersianDate(Fields.Package_StartDate)";
            // 
            // textBox8
            // 
            this.textBox8.CanGrow = false;
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(38.110050201416016D), Telerik.Reporting.Drawing.Unit.Mm(35.553997039794922D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(10.155993461608887D), Telerik.Reporting.Drawing.Unit.Mm(5.0739917755126953D));
            this.textBox8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox8.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox8.Style.Font.Name = "B Nazanin";
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox8.Value = "لغایت";
            // 
            // textBox9
            // 
            this.textBox9.CanGrow = false;
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0840182304382324D), Telerik.Reporting.Drawing.Unit.Mm(35.553997039794922D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(33.024002075195312D), Telerik.Reporting.Drawing.Unit.Mm(5.0739955902099609D));
            this.textBox9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox9.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox9.Style.Font.Name = "B Titr";
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox9.Value = "= aorc.gatepass.ItemsPublic.GetPersianDate(Fields.Package_EndDate)";
            // 
            // textBox10
            // 
            this.textBox10.CanGrow = false;
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(38.106048583984375D), Telerik.Reporting.Drawing.Unit.Mm(30.482004165649414D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(10.159997940063477D), Telerik.Reporting.Drawing.Unit.Mm(5.071993350982666D));
            this.textBox10.Style.Font.Name = "B Nazanin";
            this.textBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox10.Value = "بمدت";
            // 
            // textBox11
            // 
            this.textBox11.CanGrow = false;
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(25.40403938293457D), Telerik.Reporting.Drawing.Unit.Mm(30.482004165649414D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(12.700003623962402D), Telerik.Reporting.Drawing.Unit.Mm(5.071993350982666D));
            this.textBox11.Style.Font.Name = "B Titr";
            this.textBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox11.Value = "= (aorc.gatepass.ItemsPublic.GetDayOfYear(Fields.Package_EndDate) - aorc.gatepass" +
                ".ItemsPublic.GetDayOfYear(Fields.Package_StartDate)) + 1";
            // 
            // textBox12
            // 
            this.textBox12.CanGrow = false;
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(17.782028198242188D), Telerik.Reporting.Drawing.Unit.Mm(30.482004165649414D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(7.6200046539306641D), Telerik.Reporting.Drawing.Unit.Mm(5.071993350982666D));
            this.textBox12.Style.Font.Name = "B Nazanin";
            this.textBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox12.Value = "روز";
            // 
            // panel2
            // 
            this.panel2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(1.3457404293149011E-06D), Telerik.Reporting.Drawing.Unit.Mm(41.768928527832031D));
            this.panel2.Name = "panel2";
            this.panel2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(73.393417358398438D), Telerik.Reporting.Drawing.Unit.Mm(1.3229166269302368D));
            this.panel2.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.panel2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // textBox13
            // 
            this.textBox13.Angle = 0D;
            this.textBox13.CanGrow = false;
            this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(73.395423889160156D), Telerik.Reporting.Drawing.Unit.Mm(40.636009216308594D));
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(19.057027816772461D), Telerik.Reporting.Drawing.Unit.Mm(3.8729305267333984D));
            this.textBox13.Style.Font.Bold = true;
            this.textBox13.Style.Font.Name = "B Nazanin";
            this.textBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            this.textBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox13.Value = "محدوده تردد: ";
            // 
            // panel3
            // 
            this.panel3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0.0010012307902798057D), Telerik.Reporting.Drawing.Unit.Mm(55.501594543457031D));
            this.panel3.Name = "panel3";
            this.panel3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(92.979621887207031D), Telerik.Reporting.Drawing.Unit.Mm(1.3229166269302368D));
            this.panel3.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.panel3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // textBox15
            // 
            this.textBox15.CanGrow = false;
            this.textBox15.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(77.474006652832031D), Telerik.Reporting.Drawing.Unit.Mm(56.826515197753906D));
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(11.425990104675293D), Telerik.Reporting.Drawing.Unit.Mm(5.0800032615661621D));
            this.textBox15.Value = "خودرو:";
            // 
            // textBox19
            // 
            this.textBox19.CanGrow = false;
            this.textBox19.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(57.152008056640625D), Telerik.Reporting.Drawing.Unit.Mm(61.906528472900391D));
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(31.745986938476562D), Telerik.Reporting.Drawing.Unit.Mm(5.0799837112426758D));
            this.textBox19.Style.Font.Bold = true;
            this.textBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox19.Value = "= Fields.Vehicle_number";
            // 
            // textBox20
            // 
            this.textBox20.CanGrow = false;
            this.textBox20.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(30.482006072998047D), Telerik.Reporting.Drawing.Unit.Mm(61.906528472900391D));
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(22.857999801635742D), Telerik.Reporting.Drawing.Unit.Mm(5.0799789428710938D));
            this.textBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            this.textBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox20.Value = "= IIf(Fields.Vehicle_number<>\"\",\"شماره گواهینامه:\",\"\") ";
            // 
            // textBox18
            // 
            this.textBox18.CanGrow = false;
            this.textBox18.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0.268603652715683D), Telerik.Reporting.Drawing.Unit.Mm(61.906528472900391D));
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(30.211399078369141D), Telerik.Reporting.Drawing.Unit.Mm(5.0799789428710938D));
            this.textBox18.Style.Font.Bold = true;
            this.textBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox18.Value = "= IIf(Fields.Vehicle_number<>\"\", Fields.Person_LicenseDriverCode,\"\")";
            // 
            // panel4
            // 
            this.panel4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(65.664596557617188D));
            this.panel4.Name = "panel4";
            this.panel4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(92.9796142578125D), Telerik.Reporting.Drawing.Unit.Mm(1.3229166269302368D));
            this.panel4.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.panel4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // textBox24
            // 
            this.textBox24.CanGrow = false;
            formattingRule2.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("= Len(IIf(Fields.Agreement_Company<>\"\",\"ش/پ: \" +\": \"+ Fields.Agreement_Company,Ty" +
                    "pePack_Name))", Telerik.Reporting.Data.FilterOperator.LessThan, "31")});
            formattingRule2.Style.Font.Bold = true;
            formattingRule2.Style.Font.Name = "B Nazanin";
            formattingRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox24.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule2});
            this.textBox24.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0.26860305666923523D), Telerik.Reporting.Drawing.Unit.Mm(72.071525573730469D));
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(92.451454162597656D), Telerik.Reporting.Drawing.Unit.Mm(4.1284728050231934D));
            this.textBox24.Style.Font.Bold = true;
            this.textBox24.Style.Font.Name = "B Nazanin";
            this.textBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox24.Value = "= IIf(Fields.Agreement_Company<>\"\",\"ش/پ: \" +\": \"+ Fields.Agreement_Company,TypePa" +
                "ck_Name)";
            // 
            // textBox25
            // 
            this.textBox25.CanGrow = false;
            this.textBox25.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(77.7396240234375D), Telerik.Reporting.Drawing.Unit.Mm(76.2020034790039D));
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(15.240000724792481D), Telerik.Reporting.Drawing.Unit.Mm(11.086930274963379D));
            this.textBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.textBox25.Value = "محل کار:";
            // 
            // textBox26
            // 
            this.textBox26.CanGrow = false;
            this.textBox26.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(72.402061462402344D), Telerik.Reporting.Drawing.Unit.Mm(87.290931701660156D));
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20.317996978759766D), Telerik.Reporting.Drawing.Unit.Mm(5.0800032615661621D));
            this.textBox26.Value = "تایید کننده:";
            // 
            // textBox27
            // 
            this.textBox27.CanGrow = false;
            this.textBox27.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(72.402053833007812D), Telerik.Reporting.Drawing.Unit.Mm(92.3729248046875D));
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20.317996978759766D), Telerik.Reporting.Drawing.Unit.Mm(5.0800032615661621D));
            this.textBox27.Value = "تصویب کننده:";
            // 
            // textBox28
            // 
            this.textBox28.CanGrow = false;
            formattingRule3.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("= Len(Fields.TravelArea_LabelTravel)", Telerik.Reporting.Data.FilterOperator.LessThan, "31")});
            formattingRule3.Style.Font.Bold = true;
            formattingRule3.Style.Font.Name = "B Nazanin";
            formattingRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox28.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule3});
            this.textBox28.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0.26860439777374268D), Telerik.Reporting.Drawing.Unit.Mm(76.2020034790039D));
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(77.4690170288086D), Telerik.Reporting.Drawing.Unit.Mm(11.086926460266113D));
            this.textBox28.Style.Font.Bold = true;
            this.textBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox28.Value = "= Fields.TravelArea_LabelTravel";
            // 
            // textBox29
            // 
            this.textBox29.CanGrow = false;
            this.textBox29.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0.0010012307902798057D), Telerik.Reporting.Drawing.Unit.Mm(87.290931701660156D));
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(72.399055480957031D), Telerik.Reporting.Drawing.Unit.Mm(5.0799951553344727D));
            this.textBox29.Style.Font.Bold = true;
            this.textBox29.Value = "= Fields.Package_NameOperConfirm";
            // 
            // textBox30
            // 
            this.textBox30.CanGrow = false;
            this.textBox30.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0.0010012307902798057D), Telerik.Reporting.Drawing.Unit.Mm(92.372932434082031D));
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(72.399055480957031D), Telerik.Reporting.Drawing.Unit.Mm(5.0799951553344727D));
            this.textBox30.Style.Font.Bold = true;
            this.textBox30.Value = "= Fields.Package_NameOperPassage";
            // 
            // textBox31
            // 
            this.textBox31.CanGrow = false;
            formattingRule4.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("=Fields.Vehicle_number", Telerik.Reporting.Data.FilterOperator.Equal, "\"\"")});
            formattingRule4.Style.Visible = false;
            this.textBox31.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule4});
            this.textBox31.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(48.268051147460938D), Telerik.Reporting.Drawing.Unit.Mm(56.826515197753906D));
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(29.203962326049805D), Telerik.Reporting.Drawing.Unit.Mm(5.0800032615661621D));
            this.textBox31.Value = "= IIf(Fields.Vehicle_number<>\"\", Fields.VehicleType_Name + \" \" + Fields.Vehicle_M" +
                "odel , \"ندارد\")";
            // 
            // textBox17
            // 
            this.textBox17.CanGrow = false;
            formattingRule5.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("=Fields.Vehicle_number", Telerik.Reporting.Data.FilterOperator.Equal, "\"\"")});
            formattingRule5.Style.Visible = false;
            this.textBox17.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule5});
            this.textBox17.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(17.782028198242188D), Telerik.Reporting.Drawing.Unit.Mm(56.826515197753906D));
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20.325986862182617D), Telerik.Reporting.Drawing.Unit.Mm(5.0800032615661621D));
            this.textBox17.Value = "= Fields.vehicle_Color";
            // 
            // textBox32
            // 
            this.textBox32.CanGrow = false;
            this.textBox32.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(38.968009948730469D), Telerik.Reporting.Drawing.Unit.Mm(56.826515197753906D));
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(8.8859806060791016D), Telerik.Reporting.Drawing.Unit.Mm(5.0800032615661621D));
            this.textBox32.Value = "= IIf(Fields.Vehicle_number<>\"\",\"رنگ: \",\"\")";
            // 
            // textBox33
            // 
            this.textBox33.CanGrow = false;
            this.textBox33.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0.268603652715683D), Telerik.Reporting.Drawing.Unit.Mm(56.826515197753906D));
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(17.511423110961914D), Telerik.Reporting.Drawing.Unit.Mm(5.0800032615661621D));
            this.textBox33.Style.Font.Bold = true;
            this.textBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox33.Value = "= IIf(Fields.Vehicle_number<>\"\", IIf(Fields.Vehicle_IsCompany,\"شرکتی\",\"غیرشرکتی\")" +
                ",\"\")";
            // 
            // barcode1
            // 
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(42.184650421142578D), Telerik.Reporting.Drawing.Unit.Mm(97.728355407714844D));
            this.barcode1.Name = "barcode1";
            this.barcode1.ShowText = false;
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(50.794960021972656D), Telerik.Reporting.Drawing.Unit.Mm(7.9159893989562988D));
            this.barcode1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.barcode1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
            this.barcode1.Value = "= Fields.Archive_ID";
            // 
            // textBox14
            // 
            this.textBox14.CanGrow = false;
            formattingRule6.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("= Len(Fields.Places_Label)", Telerik.Reporting.Data.FilterOperator.LessThan, "31")});
            formattingRule6.Style.Color = System.Drawing.Color.Black;
            formattingRule6.Style.Font.Bold = true;
            formattingRule6.Style.Font.Name = "B Nazanin";
            formattingRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox14.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule6});
            this.textBox14.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(43.093849182128906D));
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(92.436363220214844D), Telerik.Reporting.Drawing.Unit.Mm(13.73066520690918D));
            this.textBox14.Style.BorderColor.Default = System.Drawing.Color.Black;
            this.textBox14.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox14.Style.Font.Bold = true;
            this.textBox14.Style.Font.Name = "B Nazanin";
            this.textBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.textBox14.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox14.Value = "= Fields.Places_Label";
            // 
            // textBox22
            // 
            this.textBox22.CanGrow = false;
            this.textBox22.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0.26860439777374268D), Telerik.Reporting.Drawing.Unit.Mm(66.989517211914062D));
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(64.503402709960938D), Telerik.Reporting.Drawing.Unit.Mm(5.0799951553344727D));
            this.textBox22.Style.Font.Bold = true;
            this.textBox22.Value = "= Fields.Gate_Label";
            // 
            // textBox21
            // 
            this.textBox21.CanGrow = false;
            this.textBox21.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(64.774002075195312D), Telerik.Reporting.Drawing.Unit.Mm(66.989517211914062D));
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(27.942007064819336D), Telerik.Reporting.Drawing.Unit.Mm(5.0800032615661621D));
            this.textBox21.Value = "محل تردد دروازه:";
            // 
            // panel5
            // 
            formattingRule7.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("= IIf(Fields.Vehicle_number<>\"\",1,0)", Telerik.Reporting.Data.FilterOperator.Equal, "0")});
            formattingRule7.Style.Visible = false;
            this.panel5.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule7});
            this.panel5.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.checkBox2});
            this.panel5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(63.485969543457031D), Telerik.Reporting.Drawing.Unit.Mm(10.160001754760742D));
            this.panel5.Name = "panel5";
            this.panel5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(25.412029266357422D), Telerik.Reporting.Drawing.Unit.Mm(5.0810003280639648D));
            // 
            // checkBox2
            // 
            this.checkBox2.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.checkBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(2.5510284900665283D), Telerik.Reporting.Drawing.Unit.Mm(0.0010012307902798057D));
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(22.859996795654297D), Telerik.Reporting.Drawing.Unit.Mm(5.0799989700317383D));
            this.checkBox2.Style.Visible = true;
            this.checkBox2.Text = "پروانه خودرو";
            this.checkBox2.Value = "= IIf(Fields.Vehicle_number<>\"\",True,False)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(48.2599983215332D), Telerik.Reporting.Drawing.Unit.Mm(110.72634887695313D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(48.260002136230469D), Telerik.Reporting.Drawing.Unit.Mm(5.0800032615661621D));
            this.textBox1.Style.Font.Name = "Consolas";
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox1.Value = "S.N:{Fields.Archive_ID}";
            // 
            // tbVersion
            // 
            this.tbVersion.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0799975395202637D), Telerik.Reporting.Drawing.Unit.Mm(110.72634887695313D));
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(19.054008483886719D), Telerik.Reporting.Drawing.Unit.Mm(5.0800032615661621D));
            this.tbVersion.Style.Font.Name = "Consolas";
            this.tbVersion.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.tbVersion.Value = "V:1.08";
            // 
            // v1_08GPPrint
            // 
            this.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.DataSource = this.sqlDataSource1;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "v1_08GPPrint";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Mm(0D);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Mm(0D);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Mm(0D);
            this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Mm(0D);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A6;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.Color = System.Drawing.Color.Black;
            styleRule1.Style.Font.Bold = true;
            styleRule1.Style.Font.Italic = false;
            styleRule1.Style.Font.Name = "Tahoma";
            styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(20D);
            styleRule1.Style.Font.Strikeout = false;
            styleRule1.Style.Font.Underline = false;
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.Color = System.Drawing.Color.Black;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
            this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Mm;
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(10.159999847412109D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.Panel panel1;
        private Telerik.Reporting.PictureBox pictureBox1;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.Panel panel2;
        private Telerik.Reporting.TextBox textBox13;
        private Telerik.Reporting.TextBox textBox14;
        private Telerik.Reporting.Panel panel3;
        private Telerik.Reporting.TextBox textBox15;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox textBox19;
		private Telerik.Reporting.TextBox textBox20;
        private Telerik.Reporting.Panel panel4;
        private Telerik.Reporting.TextBox textBox21;
        private Telerik.Reporting.TextBox textBox22;
        private Telerik.Reporting.TextBox textBox24;
        private Telerik.Reporting.TextBox textBox25;
        private Telerik.Reporting.TextBox textBox26;
        private Telerik.Reporting.TextBox textBox27;
        private Telerik.Reporting.TextBox textBox28;
        private Telerik.Reporting.TextBox textBox29;
        private Telerik.Reporting.TextBox textBox30;
        private Telerik.Reporting.Barcode barcode1;
		private Telerik.Reporting.TextBox textBox18;
        private Telerik.Reporting.TextBox tbVersion;
        private Telerik.Reporting.TextBox textBox31;
        private Telerik.Reporting.TextBox textBox32;
        private Telerik.Reporting.TextBox textBox33;
        private Telerik.Reporting.CheckBox checkBox2;
        private Telerik.Reporting.Panel panel5;

    }
}