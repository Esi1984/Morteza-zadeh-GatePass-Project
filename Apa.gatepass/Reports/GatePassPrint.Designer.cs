namespace aorc.gatepass.Reports
{
    partial class GatePassPrint
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( GatePassPrint ) );
			Telerik.Reporting.Drawing.FormattingRule formattingRule1 = new Telerik.Reporting.Drawing.FormattingRule ();
			Telerik.Reporting.Drawing.FormattingRule formattingRule2 = new Telerik.Reporting.Drawing.FormattingRule ();
			Telerik.Reporting.Drawing.FormattingRule formattingRule3 = new Telerik.Reporting.Drawing.FormattingRule ();
			Telerik.Reporting.Drawing.FormattingRule formattingRule4 = new Telerik.Reporting.Drawing.FormattingRule ();
			Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule ();
			Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule ();
			Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule ();
			Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule ();
			this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource ();
			this.detail = new Telerik.Reporting.DetailSection ();
			this.panel1 = new Telerik.Reporting.Panel ();
			this.pictureBox1 = new Telerik.Reporting.PictureBox ();
			this.pictureBox2 = new Telerik.Reporting.PictureBox ();
			this.textBox2 = new Telerik.Reporting.TextBox ();
			this.checkBox1 = new Telerik.Reporting.CheckBox ();
			this.textBox3 = new Telerik.Reporting.TextBox ();
			this.textBox4 = new Telerik.Reporting.TextBox ();
			this.textBox5 = new Telerik.Reporting.TextBox ();
			this.textBox6 = new Telerik.Reporting.TextBox ();
			this.textBox7 = new Telerik.Reporting.TextBox ();
			this.textBox8 = new Telerik.Reporting.TextBox ();
			this.textBox9 = new Telerik.Reporting.TextBox ();
			this.textBox10 = new Telerik.Reporting.TextBox ();
			this.textBox11 = new Telerik.Reporting.TextBox ();
			this.textBox12 = new Telerik.Reporting.TextBox ();
			this.panel2 = new Telerik.Reporting.Panel ();
			this.textBox13 = new Telerik.Reporting.TextBox ();
			this.textBox14 = new Telerik.Reporting.TextBox ();
			this.panel3 = new Telerik.Reporting.Panel ();
			this.textBox15 = new Telerik.Reporting.TextBox ();
			this.textBox16 = new Telerik.Reporting.TextBox ();
			this.textBox17 = new Telerik.Reporting.TextBox ();
			this.textBox19 = new Telerik.Reporting.TextBox ();
			this.textBox20 = new Telerik.Reporting.TextBox ();
			this.textBox18 = new Telerik.Reporting.TextBox ();
			this.panel4 = new Telerik.Reporting.Panel ();
			this.textBox21 = new Telerik.Reporting.TextBox ();
			this.textBox22 = new Telerik.Reporting.TextBox ();
			this.textBox23 = new Telerik.Reporting.TextBox ();
			this.textBox24 = new Telerik.Reporting.TextBox ();
			this.textBox25 = new Telerik.Reporting.TextBox ();
			this.textBox26 = new Telerik.Reporting.TextBox ();
			this.textBox27 = new Telerik.Reporting.TextBox ();
			this.textBox28 = new Telerik.Reporting.TextBox ();
			this.textBox29 = new Telerik.Reporting.TextBox ();
			this.textBox30 = new Telerik.Reporting.TextBox ();
			this.barcode1 = new Telerik.Reporting.Barcode ();
			this.textBox1 = new Telerik.Reporting.TextBox ();
			( ( System.ComponentModel.ISupportInitialize ) ( this ) ).BeginInit ();
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
			this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm ( 14D );
			this.detail.Items.AddRange ( new Telerik.Reporting.ReportItemBase [] {
            this.panel1,
            this.textBox1} );
			this.detail.Name = "detail";
			// 
			// panel1
			// 
			this.panel1.Items.AddRange ( new Telerik.Reporting.ReportItemBase [] {
            this.pictureBox1,
            this.pictureBox2,
            this.textBox2,
            this.checkBox1,
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
            this.textBox14,
            this.panel3,
            this.textBox15,
            this.textBox16,
            this.textBox17,
            this.textBox19,
            this.textBox20,
            this.textBox18,
            this.panel4,
            this.textBox21,
            this.textBox22,
            this.textBox23,
            this.textBox24,
            this.textBox25,
            this.textBox26,
            this.textBox27,
            this.textBox28,
            this.textBox29,
            this.textBox30,
            this.barcode1} );
			this.panel1.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 2.5399994850158691D ) , Telerik.Reporting.Drawing.Unit.Mm ( 2.5399994850158691D ) );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 88.899993896484375D ) , Telerik.Reporting.Drawing.Unit.Mm ( 132.37698364257813D ) );
			this.panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
			this.panel1.Style.Font.Name = "B Traffic";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 0.0010012307902798057D ) , Telerik.Reporting.Drawing.Unit.Mm ( 0.0010012307902798057D ) );
			this.pictureBox1.MimeType = "";
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 30.479001998901367D ) , Telerik.Reporting.Drawing.Unit.Mm ( 35.56500244140625D ) );
			this.pictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
			this.pictureBox1.Value = "= Fields.Person_Picture";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 36.829998016357422D ) , Telerik.Reporting.Drawing.Unit.Mm ( 0.0010012307902798057D ) );
			this.pictureBox2.MimeType = "image/png";
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 15.240000724792481D ) , Telerik.Reporting.Drawing.Unit.Mm ( 12.69899845123291D ) );
			this.pictureBox2.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
			this.pictureBox2.Value = ( ( object ) ( resources.GetObject ( "pictureBox2.Value" ) ) );
			// 
			// textBox2
			// 
			this.textBox2.Culture = new System.Globalization.CultureInfo ( "fa-IR" );
			this.textBox2.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 30.482006072998047D ) , Telerik.Reporting.Drawing.Unit.Mm ( 12.701999664306641D ) );
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 34.290000915527344D ) , Telerik.Reporting.Drawing.Unit.Mm ( 7.62000036239624D ) );
			this.textBox2.Style.Font.Name = "B Nazanin";
			this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 6D );
			this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox2.Value = "شرکت ملی پالایش و پخش فرآورده های نفتی ایران\r\nشرکت پالایش نفت آبادان (سهامی عام)";
			// 
			// checkBox1
			// 
			formattingRule1.Filters.AddRange ( new Telerik.Reporting.Data.Filter [] {
            new Telerik.Reporting.Data.Filter("=Fields.Vehicle_number", Telerik.Reporting.Data.FilterOperator.Equal, "=NULL")} );
			formattingRule1.Style.Visible = false;
			this.checkBox1.ConditionalFormatting.AddRange ( new Telerik.Reporting.Drawing.FormattingRule [] {
            formattingRule1} );
			this.checkBox1.Culture = new System.Globalization.CultureInfo ( "fa-IR" );
			this.checkBox1.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 64.774009704589844D ) , Telerik.Reporting.Drawing.Unit.Mm ( 7.62000036239624D ) );
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 22.859996795654297D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0799989700317383D ) );
			this.checkBox1.Style.Visible = true;
			this.checkBox1.Text = "پروانه خودرو";
			// 
			// textBox3
			// 
			this.textBox3.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 30.482004165649414D ) , Telerik.Reporting.Drawing.Unit.Mm ( 20.324003219604492D ) );
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 57.152000427246094D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0799989700317383D ) );
			this.textBox3.Style.Font.Bold = true;
			this.textBox3.Style.Font.Name = "B Nazanin";
			this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 14D );
			this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox3.Value = "= IIf(Fields.Person_IdentifyCode <> \"\", Fields.Person_IdentifyCode, Fields.Person" +
    "_NationalCode)";
			// 
			// textBox4
			// 
			this.textBox4.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 30.482004165649414D ) , Telerik.Reporting.Drawing.Unit.Mm ( 25.406003952026367D ) );
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 57.152004241943359D ) , Telerik.Reporting.Drawing.Unit.Mm ( 10.159997940063477D ) );
			this.textBox4.Style.Font.Bold = true;
			this.textBox4.Style.Font.Name = "B Nazanin";
			this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 15D );
			this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox4.Value = "= Fields.Person_Name + \" \" + Fields.Person_Surname";
			// 
			// textBox5
			// 
			this.textBox5.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 48.268047332763672D ) , Telerik.Reporting.Drawing.Unit.Mm ( 35.566005706787109D ) );
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 25.41203498840332D ) , Telerik.Reporting.Drawing.Unit.Mm ( 7.61799430847168D ) );
			this.textBox5.Style.Font.Name = "B Nazanin";
			this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 12D );
			this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox5.Value = "اعتبار این پروانه : ";
			// 
			// textBox6
			// 
			this.textBox6.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 81.292037963867188D ) , Telerik.Reporting.Drawing.Unit.Mm ( 43.186000823974609D ) );
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 5.0799951553344727D ) , Telerik.Reporting.Drawing.Unit.Mm ( 7.6200046539306641D ) );
			this.textBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
			this.textBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
			this.textBox6.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel ( 1D );
			this.textBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel ( 1D );
			this.textBox6.Style.Font.Name = "B Nazanin";
			this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 12D );
			this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox6.Value = "از";
			// 
			// textBox7
			// 
			this.textBox7.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 48.268047332763672D ) , Telerik.Reporting.Drawing.Unit.Mm ( 43.186000823974609D ) );
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 33.021991729736328D ) , Telerik.Reporting.Drawing.Unit.Mm ( 7.6200046539306641D ) );
			this.textBox7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
			this.textBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
			this.textBox7.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel ( 1D );
			this.textBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel ( 1D );
			this.textBox7.Style.Font.Name = "B Titr";
			this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 14D );
			this.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox7.Value = "= aorc.gatepass.ItemsPublic.GetPersianDate(Fields.Package_StartDate)";
			// 
			// textBox8
			// 
			this.textBox8.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 38.110050201416016D ) , Telerik.Reporting.Drawing.Unit.Mm ( 43.186008453369141D ) );
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 10.155993461608887D ) , Telerik.Reporting.Drawing.Unit.Mm ( 7.6199965476989746D ) );
			this.textBox8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
			this.textBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
			this.textBox8.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel ( 1D );
			this.textBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel ( 1D );
			this.textBox8.Style.Font.Name = "B Nazanin";
			this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 12D );
			this.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox8.Value = "لغایت";
			// 
			// textBox9
			// 
			this.textBox9.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 5.0840182304382324D ) , Telerik.Reporting.Drawing.Unit.Mm ( 43.186008453369141D ) );
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 33.024002075195312D ) , Telerik.Reporting.Drawing.Unit.Mm ( 7.6200046539306641D ) );
			this.textBox9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
			this.textBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
			this.textBox9.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel ( 1D );
			this.textBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel ( 1D );
			this.textBox9.Style.Font.Name = "B Titr";
			this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 14D );
			this.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox9.Value = "= aorc.gatepass.ItemsPublic.GetPersianDate(Fields.Package_EndDate)";
			// 
			// textBox10
			// 
			this.textBox10.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 38.106048583984375D ) , Telerik.Reporting.Drawing.Unit.Mm ( 35.568008422851562D ) );
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 10.159997940063477D ) , Telerik.Reporting.Drawing.Unit.Mm ( 7.6200046539306641D ) );
			this.textBox10.Style.Font.Name = "B Nazanin";
			this.textBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 12D );
			this.textBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox10.Value = "بمدت";
			// 
			// textBox11
			// 
			this.textBox11.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 25.40403938293457D ) , Telerik.Reporting.Drawing.Unit.Mm ( 35.568008422851562D ) );
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 12.700003623962402D ) , Telerik.Reporting.Drawing.Unit.Mm ( 7.6200046539306641D ) );
			this.textBox11.Style.Font.Name = "B Titr";
			this.textBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 14D );
			this.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
			this.textBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox11.Value = "= (aorc.gatepass.ItemsPublic.GetDayOfYear(Fields.Package_EndDate) - aorc.gatepass" +
    ".ItemsPublic.GetDayOfYear(Fields.Package_StartDate)) + 1";
			// 
			// textBox12
			// 
			this.textBox12.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 17.782028198242188D ) , Telerik.Reporting.Drawing.Unit.Mm ( 35.568008422851562D ) );
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 7.6200046539306641D ) , Telerik.Reporting.Drawing.Unit.Mm ( 7.6200046539306641D ) );
			this.textBox12.Style.Font.Name = "B Nazanin";
			this.textBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 12D );
			this.textBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox12.Value = "روز";
			// 
			// panel2
			// 
			this.panel2.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 0.0010012307902798057D ) , Telerik.Reporting.Drawing.Unit.Mm ( 50.808017730712891D ) );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 88.897994995117188D ) , Telerik.Reporting.Drawing.Unit.Mm ( 1.3229166269302368D ) );
			this.panel2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
			// 
			// textBox13
			// 
			this.textBox13.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 68.579994201660156D ) , Telerik.Reporting.Drawing.Unit.Mm ( 52.1329345703125D ) );
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 20.319999694824219D ) , Telerik.Reporting.Drawing.Unit.Mm ( 11.367062568664551D ) );
			this.textBox13.Style.Font.Name = "B Nazanin";
			this.textBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 11D );
			this.textBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox13.Value = "محدوده تردد: ";
			// 
			// textBox14
			// 
			this.textBox14.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 0.0010012307902798057D ) , Telerik.Reporting.Drawing.Unit.Mm ( 52.1329345703125D ) );
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 68.576988220214844D ) , Telerik.Reporting.Drawing.Unit.Mm ( 11.367062568664551D ) );
			this.textBox14.Style.Font.Bold = true;
			this.textBox14.Style.Font.Name = "B Nazanin";
			this.textBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 11D );
			this.textBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox14.Value = "= Fields.Places_Label";
			// 
			// panel3
			// 
			this.panel3.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 0D ) , Telerik.Reporting.Drawing.Unit.Mm ( 63.501998901367188D ) );
			this.panel3.Name = "panel3";
			this.panel3.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 88.897994995117188D ) , Telerik.Reporting.Drawing.Unit.Mm ( 1.3229166269302368D ) );
			this.panel3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
			// 
			// textBox15
			// 
			this.textBox15.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 77.474006652832031D ) , Telerik.Reporting.Drawing.Unit.Mm ( 64.826919555664062D ) );
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 11.425990104675293D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0800032615661621D ) );
			this.textBox15.Value = "خودرو:";
			// 
			// textBox16
			// 
			formattingRule2.Filters.AddRange ( new Telerik.Reporting.Data.Filter [] {
            new Telerik.Reporting.Data.Filter("=Fields.vehicle_Name", Telerik.Reporting.Data.FilterOperator.Equal, "=\"\"")} );
			formattingRule2.Style.Visible = false;
			this.textBox16.ConditionalFormatting.AddRange ( new Telerik.Reporting.Drawing.FormattingRule [] {
            formattingRule2} );
			this.textBox16.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 57.152008056640625D ) , Telerik.Reporting.Drawing.Unit.Mm ( 64.826919555664062D ) );
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 20.319999694824219D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0800032615661621D ) );
			this.textBox16.Style.Font.Bold = true;
			this.textBox16.Value = "= IIf(Fields.Vehicle_IsCompany,\"شرکتی\",\"غیر شرکتی\")";
			// 
			// textBox17
			// 
			this.textBox17.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 2.5399994850158691D ) , Telerik.Reporting.Drawing.Unit.Mm ( 65.190376281738281D ) );
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 50.800003051757812D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0800032615661621D ) );
			this.textBox17.Value = "= Fields.Vehicle_Model + \" \" + Fields.vehicle_Name + \" \" + Fields.vehicle_Color";
			// 
			// textBox19
			// 
			this.textBox19.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 57.152008056640625D ) , Telerik.Reporting.Drawing.Unit.Mm ( 70.272377014160156D ) );
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 31.745986938476562D ) , Telerik.Reporting.Drawing.Unit.Mm ( 8.4676189422607422D ) );
			this.textBox19.Style.Font.Bold = true;
			this.textBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 12D );
			this.textBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox19.Value = "= Fields.Vehicle_number";
			// 
			// textBox20
			// 
			formattingRule3.Filters.AddRange ( new Telerik.Reporting.Data.Filter [] {
            new Telerik.Reporting.Data.Filter("=Fields.vehicle_Name", Telerik.Reporting.Data.FilterOperator.Equal, "=\"\"")} );
			formattingRule3.Style.Visible = false;
			this.textBox20.ConditionalFormatting.AddRange ( new Telerik.Reporting.Drawing.FormattingRule [] {
            formattingRule3} );
			this.textBox20.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 30.482006072998047D ) , Telerik.Reporting.Drawing.Unit.Mm ( 70.272377014160156D ) );
			this.textBox20.Name = "textBox20";
			this.textBox20.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 22.857999801635742D ) , Telerik.Reporting.Drawing.Unit.Mm ( 8.4676189422607422D ) );
			this.textBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox20.Value = "شماره گواهینامه:";
			// 
			// textBox18
			// 
			formattingRule4.Filters.AddRange ( new Telerik.Reporting.Data.Filter [] {
            new Telerik.Reporting.Data.Filter("=Fields.vehicle_Name", Telerik.Reporting.Data.FilterOperator.Equal, "=\"\"")} );
			formattingRule4.Style.Visible = false;
			this.textBox18.ConditionalFormatting.AddRange ( new Telerik.Reporting.Drawing.FormattingRule [] {
            formattingRule4} );
			this.textBox18.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 2.5399994850158691D ) , Telerik.Reporting.Drawing.Unit.Mm ( 70.272377014160156D ) );
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 27.940004348754883D ) , Telerik.Reporting.Drawing.Unit.Mm ( 8.4676189422607422D ) );
			this.textBox18.Style.Font.Bold = true;
			this.textBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 11D );
			this.textBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
			this.textBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.textBox18.Value = "= Fields.Person_LicenseDriverCode";
			// 
			// panel4
			// 
			this.panel4.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 0D ) , Telerik.Reporting.Drawing.Unit.Mm ( 78.74200439453125D ) );
			this.panel4.Name = "panel4";
			this.panel4.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 88.897994995117188D ) , Telerik.Reporting.Drawing.Unit.Mm ( 1.3229166269302368D ) );
			this.panel4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
			// 
			// textBox21
			// 
			this.textBox21.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 60.955982208251953D ) , Telerik.Reporting.Drawing.Unit.Mm ( 80.0669174194336D ) );
			this.textBox21.Name = "textBox21";
			this.textBox21.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 27.942007064819336D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0800032615661621D ) );
			this.textBox21.Value = "دروازه محل تردد:";
			// 
			// textBox22
			// 
			this.textBox22.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 0.0010012307902798057D ) , Telerik.Reporting.Drawing.Unit.Mm ( 80.066932678222656D ) );
			this.textBox22.Name = "textBox22";
			this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 60.952983856201172D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0799951553344727D ) );
			this.textBox22.Style.Font.Bold = true;
			this.textBox22.Value = "= Fields.Gate_Label";
			// 
			// textBox23
			// 
			this.textBox23.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 60.955982208251953D ) , Telerik.Reporting.Drawing.Unit.Mm ( 85.14892578125D ) );
			this.textBox23.Name = "textBox23";
			this.textBox23.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 27.942007064819336D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0800032615661621D ) );
			this.textBox23.Value = "شرکت/پيمانکاري:";
			// 
			// textBox24
			// 
			this.textBox24.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 0.0010012307902798057D ) , Telerik.Reporting.Drawing.Unit.Mm ( 85.14892578125D ) );
			this.textBox24.Name = "textBox24";
			this.textBox24.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 60.952980041503906D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0799951553344727D ) );
			this.textBox24.Style.Font.Bold = true;
			this.textBox24.Value = "= Fields.Agreement_Company";
			// 
			// textBox25
			// 
			this.textBox25.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 60.955982208251953D ) , Telerik.Reporting.Drawing.Unit.Mm ( 90.2309341430664D ) );
			this.textBox25.Name = "textBox25";
			this.textBox25.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 27.944013595581055D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0800032615661621D ) );
			this.textBox25.Value = "محل کار:";
			// 
			// textBox26
			// 
			this.textBox26.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 60.955982208251953D ) , Telerik.Reporting.Drawing.Unit.Mm ( 95.312934875488281D ) );
			this.textBox26.Name = "textBox26";
			this.textBox26.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 27.942014694213867D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0800032615661621D ) );
			this.textBox26.Value = "تایید کننده:";
			// 
			// textBox27
			// 
			this.textBox27.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 60.955982208251953D ) , Telerik.Reporting.Drawing.Unit.Mm ( 100.39494323730469D ) );
			this.textBox27.Name = "textBox27";
			this.textBox27.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 27.942014694213867D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0800032615661621D ) );
			this.textBox27.Value = "تصویب کننده:";
			// 
			// textBox28
			// 
			this.textBox28.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 0.0010012307902798057D ) , Telerik.Reporting.Drawing.Unit.Mm ( 90.2309341430664D ) );
			this.textBox28.Name = "textBox28";
			this.textBox28.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 60.952980041503906D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0800032615661621D ) );
			this.textBox28.Style.Font.Bold = true;
			this.textBox28.Value = "= Fields.TravelArea_LabelTravel";
			// 
			// textBox29
			// 
			this.textBox29.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 0.0010012307902798057D ) , Telerik.Reporting.Drawing.Unit.Mm ( 95.312942504882812D ) );
			this.textBox29.Name = "textBox29";
			this.textBox29.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 60.952983856201172D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0799951553344727D ) );
			this.textBox29.Style.Font.Bold = true;
			this.textBox29.Value = "= Fields.Package_NameOperConfirm";
			// 
			// textBox30
			// 
			this.textBox30.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 0.0010012307902798057D ) , Telerik.Reporting.Drawing.Unit.Mm ( 100.39495086669922D ) );
			this.textBox30.Name = "textBox30";
			this.textBox30.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 60.952980041503906D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0799951553344727D ) );
			this.textBox30.Style.Font.Bold = true;
			this.textBox30.Value = "= Fields.Package_NameOperPassage";
			// 
			// barcode1
			// 
			this.barcode1.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 0.0010012307902798057D ) , Telerik.Reporting.Drawing.Unit.Mm ( 124.45999145507813D ) );
			this.barcode1.Name = "barcode1";
			this.barcode1.ShowText = false;
			this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 88.896987915039062D ) , Telerik.Reporting.Drawing.Unit.Mm ( 7.9159893989562988D ) );
			this.barcode1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.barcode1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
			this.barcode1.Value = "= Fields.Archive_ID";
			// 
			// textBox1
			// 
			this.textBox1.Location = new Telerik.Reporting.Drawing.PointU ( Telerik.Reporting.Drawing.Unit.Mm ( 2.5399975776672363D ) , Telerik.Reporting.Drawing.Unit.Mm ( 134.91899108886719D ) );
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU ( Telerik.Reporting.Drawing.Unit.Mm ( 48.260002136230469D ) , Telerik.Reporting.Drawing.Unit.Mm ( 5.0800032615661621D ) );
			this.textBox1.Style.Font.Name = "Consolas";
			this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
			this.textBox1.Value = "S.N:{Fields.Archive_ID}";
			// 
			// GatePassPrint
			// 
			this.Culture = new System.Globalization.CultureInfo ( "fa-IR" );
			this.DataSource = this.sqlDataSource1;
			this.Items.AddRange ( new Telerik.Reporting.ReportItemBase [] {
            this.detail} );
			this.Name = "GatePassPrint";
			this.PageSettings.Landscape = false;
			this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Mm ( 5D );
			this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Mm ( 5D );
			this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Mm ( 5D );
			this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Mm ( 5D );
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A6;
			this.Style.BackgroundColor = System.Drawing.Color.White;
			styleRule1.Selectors.AddRange ( new Telerik.Reporting.Drawing.ISelector [] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")} );
			styleRule1.Style.Color = System.Drawing.Color.Black;
			styleRule1.Style.Font.Bold = true;
			styleRule1.Style.Font.Italic = false;
			styleRule1.Style.Font.Name = "Tahoma";
			styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 20D );
			styleRule1.Style.Font.Strikeout = false;
			styleRule1.Style.Font.Underline = false;
			styleRule2.Selectors.AddRange ( new Telerik.Reporting.Drawing.ISelector [] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")} );
			styleRule2.Style.Color = System.Drawing.Color.Black;
			styleRule2.Style.Font.Name = "Tahoma";
			styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 11D );
			styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			styleRule3.Selectors.AddRange ( new Telerik.Reporting.Drawing.ISelector [] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")} );
			styleRule3.Style.Font.Name = "Tahoma";
			styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 11D );
			styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			styleRule4.Selectors.AddRange ( new Telerik.Reporting.Drawing.ISelector [] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")} );
			styleRule4.Style.Font.Name = "Tahoma";
			styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point ( 11D );
			styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.StyleSheet.AddRange ( new Telerik.Reporting.Drawing.StyleRule [] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4} );
			this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Mm;
			this.Width = Telerik.Reporting.Drawing.Unit.Cm ( 9.5D );
			( ( System.ComponentModel.ISupportInitialize ) ( this ) ).EndInit ();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.Panel panel1;
        private Telerik.Reporting.PictureBox pictureBox1;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.PictureBox pictureBox2;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.CheckBox checkBox1;
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
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox textBox19;
        private Telerik.Reporting.TextBox textBox20;
        private Telerik.Reporting.TextBox textBox18;
        private Telerik.Reporting.Panel panel4;
        private Telerik.Reporting.TextBox textBox21;
        private Telerik.Reporting.TextBox textBox22;
        private Telerik.Reporting.TextBox textBox23;
        private Telerik.Reporting.TextBox textBox24;
        private Telerik.Reporting.TextBox textBox25;
        private Telerik.Reporting.TextBox textBox26;
        private Telerik.Reporting.TextBox textBox27;
        private Telerik.Reporting.TextBox textBox28;
        private Telerik.Reporting.TextBox textBox29;
        private Telerik.Reporting.TextBox textBox30;
        private Telerik.Reporting.Barcode barcode1;

    }
}