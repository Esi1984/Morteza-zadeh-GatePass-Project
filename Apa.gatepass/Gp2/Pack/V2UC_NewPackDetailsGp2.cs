using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServerClasses;

namespace aorc.gatepass.Gp2.Pack
{
	public partial class V2UC_NewPackDetailsGp2 : UserControl
	{
		public V2UC_NewPackDetailsGp2()
		{
			InitializeComponent();           
		}


        private OutputDatas ODSettings = new OutputDatas();     		  


		public delegate void DelegateStatusAction();
		public event DelegateStatusAction eventTickVehicle;
		public int? CurrentTravelId { get; set; }
		public int? CurrentOfficeId { get; set; }
		public decimal? CurrentAgreeId { get; set; }
		//public decimal? CurrentCarId { get; set; }
		public List<int> CurrentGates { get;set;}
		public List<int> CurrentPlaces { get; set; }

		private void rbtnAgree_Click(object sender, EventArgs e)
		{
            if (rtbNumberAgree.Text.Trim().Count() > 5)
            {
                Manager objManager = new Manager();
                var resultFindAgree = objManager.View_agreements(null, null, null, null, null, null, null, null, rtbNumberAgree.Text.Trim());
                if (resultFindAgree.success)
                {
                    if (resultFindAgree.ResultTable.Rows.Count > 0)
                    {
                        CurrentAgreeId = decimal.Parse(resultFindAgree.ResultTable.Rows[0]["Agreement_ID"].ToString().Trim());
                        rtbNumberAgree.Text = resultFindAgree.ResultTable.Rows[0]["Agreement_Number"].ToString().Trim();
                        rtbCompanyAgree.Text = resultFindAgree.ResultTable.Rows[0]["Agreement_Company"].ToString().Trim();
                       // rtbTitleAgree.Text = resultFindAgree.ResultTable.Rows[0]["Agreement_Title"].ToString().Trim();
                        rlblCountCar.Text = ItemsPublic.HowManyCarInAgree(CurrentAgreeId);

                        var firstTimeRowFormat = DateTime.Now;
                        var endTimeRowFormat = (DateTime)resultFindAgree.ResultTable.Rows[0]["Agreement_EndDate"];
                        var countDay = 1 + (int)endTimeRowFormat.Subtract(firstTimeRowFormat).TotalDays;

                        if (countDay < 1)
                        {
                            rlblHintAgree.Text = "قرارداد اعتبار ندارد";
                        }
                        else
                        {
                            rlblHintAgree.Text = countDay.ToString() + " روز تا پایان قرارداد";
                        }

                        rlblHintAgree.Visible = true;

                    }
                    else
                    {
                        rlblHintAgree.Text = "قرارداد معتبری یافت نشد";
                        rlblHintAgree.Visible = true;                        
                    }
                }
                else
                {
                    MessageBox.Show(resultFindAgree.Message);
                }
            }
            else
            {
                rlblHintAgree.Text = "قرارداد معتبری یافت نشد";
                rlblHintAgree.Visible = true;
            }
		}

		private void rbtnTravel_Click(object sender, EventArgs e)
		{
			var frm = new gatepass.ui.package.frm_SelectArea();
			frm.ShowDialog();
			if (frm.DialogResult == DialogResult.OK)
			{
				CurrentTravelId = frm.IdTa;
				rtbTravelLabel.Text = frm.masir;
			}
			frm.Close();
			//frm.Dispose();
		}


		private void rddlTypePack_SelectedIndexChanged( object sender , Telerik.WinControls.UI.Data.PositionChangedEventArgs e )
		{

            if (rddlTypePack.SelectedIndex > -1)
            {
                bool haveAgree = (bool)ODSettings.ResultTable.Rows[rddlTypePack.SelectedIndex]["TypePack_NeedAgree"];
                if (!haveAgree)
                {
                    rgbAgree.Visible = false;
                    CurrentAgreeId = null;
                    rtbCompanyAgree.Text = string.Empty;
                    rtbNumberAgree.Text = string.Empty;
                    //rtbTitleAgree.Text = string.Empty;
                }
                else if (haveAgree && rddlTypePack.Enabled)
                {
                    rgbAgree.Visible = true;
                }

            }
            else
            {
                rgbAgree.Visible = false;
                CurrentAgreeId = null;
                rtbCompanyAgree.Text = string.Empty;
                rtbNumberAgree.Text = string.Empty;
            }
            

			
		}

		private void rbtnGates_Click( object sender , EventArgs e )
		{
			var frm = new gatepass.ui.package.frm_SelectGates ();
			frm.SetInfo( CurrentGates);
			frm.ShowDialog ();
			if ( frm.DialogResult == DialogResult.OK )
			{
				rtbGates.Text = "";
				CurrentGates = new List<int>();
				foreach ( var obj in frm.radGridViewSelected.Rows )
				{
				//	string ss = obj.Cells["Gate_Id"].Value.ToString().Trim();
					//int ii = int.Parse(obj.Cells["Gate_Id"].Value.ToString().Trim());
					CurrentGates.Add ( int.Parse ( obj.Cells ["Gate_Id"].Value.ToString ().Trim () ) );
					rtbGates.Text += obj.Cells ["Gate_Name"].Value.ToString ().Trim()+"\r\n";
				}
			}
			frm.Close ();
			frm.Dispose ();
		}

		private void rbtnPlaces_Click( object sender , EventArgs e )
		{
			var frm = new gatepass.ui.package.frm_SelectPlaces ();
			frm.SetInfo ( CurrentPlaces );
			frm.ShowDialog ();
			if ( frm.DialogResult == DialogResult.OK )
			{
				rtbPlaces.Text = "";
				CurrentPlaces = new List<int> ();
				foreach ( var obj in frm.radGridViewSelected.Rows )
				{
					//	string ss = obj.Cells["Gate_Id"].Value.ToString().Trim();
					//int ii = int.Parse(obj.Cells["Gate_Id"].Value.ToString().Trim());
					CurrentPlaces.Add ( int.Parse ( obj.Cells ["Place_Id"].Value.ToString ().Trim () ) );
					rtbPlaces.Text += obj.Cells ["Place_Name"].Value.ToString ().Trim ()+"\r\n";
				}
			}
			frm.Close ();
			frm.Dispose ();
		}

        private void rtbNumberAgree_TextChanged(object sender, EventArgs e)
        {
            rlblHintAgree.Visible = false;
            CurrentAgreeId = null;
           // rtbNumberAgree.Text = "";
            rtbCompanyAgree.Text = "";            
            rlblCountCar.Text = "";
        }

        private void rtbNumberAgree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbtnAgree_Click(sender, e);
                return;
            }
        }

        public void SetTypePackList(bool isGp)
        {
            rddlTypePack.Items.Clear();
            var objC = new Manager();
            ODSettings = new OutputDatas();
            ODSettings = objC.MyTypesPack(isGp);
            if (ODSettings.success)
            {
                // rddlConfirmer.DataSource = ODConfirmer.ResultTable.Columns["BaridName"];
                for (int index = 0; index < ODSettings.ResultTable.Rows.Count; index++)
                {
                    rddlTypePack.Items.Add((string)ODSettings.ResultTable.Rows[index]["TypePack_Name"]);
                }
            }
            else
            {
                ItemsPublic.ShowMessage(ODSettings.Message);
                // this.Close();
            }
        }

       // public decimal? TypePackRealId;
        public string TypePackRealName;

        public bool? isGpType
        {
            get
            {
                if (rbGp.Checked)
                {
                    return true;
                }
                if (rbCard.Checked )
                {
                    return false;
                }
                return null;
            }
            set
            {
                rbGp.Checked = false;
                rbCard.Checked = false;
                if (value == false)
                {
                    rbCard.Checked = true;
                   
                }
                else
                {
                    rbGp.Checked = true;
                }              
            }
        }
        public int? TypePackId
        {
            get
            {
               int? TypePackRealId= (int?)ODSettings.ResultTable.Rows[rddlTypePack.SelectedIndex]["TypePack_Id"];
               TypePackRealName = rddlTypePack.Text;
               // TypePackRealId = kk;
                return rddlTypePack.SelectedIndex > -1 ? TypePackRealId : null;
         
            }
            set {
                int index = -1;
                rddlTypePack.SelectedIndex = -1;
                foreach (DataRow item in ODSettings.ResultTable.Rows)
                {
                    index++;
                    if (value == (int)item["TypePack_Id"])
                    {                      
                        rddlTypePack.SelectedIndex = index;
                        return;
                    }
                }
                }
            }
            //rddlConfirmer.SelectedIndex = value != null ? SetrddlConfirmer((decimal)value) : -1;
        
    //    public void loadTypePack(int realId , string label){
    //   TypePackRealId = realId;
    //   TypePackRealName = label;
    //   rddlTypePack.Text = label;
    //}


        private void rbGp_CheckedChanged(object sender, EventArgs e)
        {
            SetTypePackList(true);
        }

        private void rbCard_CheckedChanged(object sender, EventArgs e)
        {
            SetTypePackList(false);
        }

        public bool AgreeisOk() 
        {
            bool haveAgree = (bool)ODSettings.ResultTable.Rows[rddlTypePack.SelectedIndex]["TypePack_NeedAgree"];
            if (haveAgree && CurrentAgreeId == null)
            {
                return false;
            }
            return true;
        }

	}
}
