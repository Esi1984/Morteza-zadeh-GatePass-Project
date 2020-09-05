using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baridsoft.EOrg.Framework.PluginInterface;
using ServerClasses;
using Telerik.WinControls.UI;

namespace aorc.gatepass.eorg.ui
{
    public partial class rightside : UserControl, Baridsoft.EOrg.Framework.PluginInterface.IEOrgExplorer
    {
       // public static decimal OOficeID = 0;
    //    public static List<string> SecurityList { get; set; }

        public rightside()
        {
            InitializeComponent();
        }

        private void rightside_Load(object sender, EventArgs e)
        {
            //  SecurityList = new List<string>();
            foreach (var item in System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName()))
            {
                if (item.ToString().Substring(0, 3) == "172")
                {
                    ItemsPublic.MyIpAddress = item.ToString();
                }
            }
        }

        public void Activate()
        {
        //OOO   ItemsPublic.MyIpAddress = "127.0.0.1";
        	
       // OOO
			rightside_Load ( null , null );
			//baridTreeView1.CollapseAll ();
          //  baridTreeView1.ExpandAll();
			ExplorerPanel exPanel = new ExplorerPanel ();
			Baridsoft.EOrg.Framework.PluginInterface.IEOrgContainer container = exPanel;
			container.Activate ();
//OOO
              //  aorc.gatepass.ui.login.frm_officeselector frm = new gatepass.ui.login.frm_officeselector();

				//OOO ItemsPublic.MyBaridId = 18300010002000000053103314M;
                ItemsPublic.MyBaridId =Baridsoft.EOrg.Framework.General.UserContext.CurrentUser.ID;

                ItemsPublic.MyComputerName = System.Net.Dns.GetHostName();
                aorc.gatepass.ui.login.MyLogin  LoginObj = new gatepass.ui.login.MyLogin();
                LoginObj.Start();
              //  frm.ShowDialog();
        	    exPanel.ShowPropOper(ItemsPublic.MyOfficeName);
             //   frm.Close();
             //   frm.Dispose();
            if (!ItemsPublic.AcssesIsDenied && ItemsPublic.ConnectToServer)
            {
                checkSectionRights();
            }

        }

        public event EventHandler Activated;

        public UserControl AsUserControl
        {
            get { return null; }
        }

        private IEOrgContainer currentEOrgContainer;

        public IEOrgContainer CurrentEOrgContainer
        {

            get { return this.currentEOrgContainer; }

            set
            {

                if ((this.currentEOrgContainer != null) && (this.currentEOrgContainer != value))
                {

                    this.currentEOrgContainer.Deactivate();

                }

                this.currentEOrgContainer = value;
                //TODO: uncomment below line for runnig currectly via EORG
                //value.Activate();

            }
        }

        //public Baridsoft.EOrg.Framework.PluginInterface.IEOrgContainer CurrentEOrgContainer { get; set; }

        public void Deactivate()
        {

        }

        public event EventHandler Deactivated;

        public System.Collections.ArrayList EOrgContainers { get; set; }

        public Image Icon { get; set; }

        public void Initialize()
        {

        }

        public object InvokeMethod(string method, params object[] paramArray)
        {
            return null;
        }

        public Baridsoft.EOrg.Framework.PluginInterface.IEOrgApplicationService ParentApplicationService { get; set; }

        public void RefreshItem(object item)
        {

        }

        public void SelectItem(object item)
        {
            //checkSectionRights();
            //foreach (var right in ItemsPublic.MyRights)
            //{
            //    if (right == AllFunctions._Rights.View_agreements) baridTreeView1.Nodes["NodeManagement"].Nodes["NodeAgree"].Visible = true;
            //    if (right == AllFunctions._Rights.View_persons) baridTreeView1.Nodes["NodeManagement"].Nodes["NodePerson"].Visible = true;
            //    if (right == AllFunctions._Rights.View_offices) baridTreeView1.Nodes["NodeManagement"].Nodes["NodeOffice"].Visible = true;
            //    if (right == AllFunctions._Rights.View_groups) baridTreeView1.Nodes["NodeManagement"].Nodes["NodeGroup"].Visible = true;
            //    if (right == AllFunctions._Rights.View_bLreasons) baridTreeView1.Nodes["NodeManagement"].Nodes["NodeBLReasons"].Visible = true;
            //    if (right == AllFunctions._Rights.View_blackLists) baridTreeView1.Nodes["NodeManagement"].Nodes["NodeBlackLists"].Visible = true;
            //    if (right == AllFunctions._Rights.View_operators) baridTreeView1.Nodes["NodeManagement"].Nodes["NodeOper"].Visible = true;
            //    if (right == AllFunctions._Rights.View_travelAreas) baridTreeView1.Nodes["NodeManagement"].Nodes["NodeTravelArea"].Visible = true;
            //    if (right == AllFunctions._Rights.View_vehiclesType) baridTreeView1.Nodes["NodeManagement"].Nodes["NodeVehicleType"].Visible = true;
            //}
            //baridTreeView1.Nodes["NodeManagement"].Nodes.Refresh();
            //baridTreeView1.Refresh();
        }

        public object SelectedItem
        {
            get { return string.Empty; }
        }

        public event EventHandler SelectedItemChanged;
        
        private RadTreeNode CurrentNode;
        public void checkSectionRights()
        {            
            baridTreeView1.CollapseAll();

            baridTreeView1.Nodes["NodeManagement"].Nodes["NodeGateEsi"].Visible = false;
            baridTreeView1.Nodes["NodeManagement"].Nodes["NodeTag"].Visible = false;
            baridTreeView1.Nodes["NodeManagement"].Nodes["NodeReports"].Visible = false;
            baridTreeView1.Nodes["NodeManagement"].Nodes["NodeAgree"].Visible = false;
            baridTreeView1.Nodes["NodeManagement"].Nodes["NodePerson"].Visible = false;
            baridTreeView1.Nodes["NodeManagement"].Nodes["NodeOffice"].Visible = false;
            baridTreeView1.Nodes["NodeManagement"].Nodes["NodeGroup"].Visible = false;
            baridTreeView1.Nodes["NodeManagement"].Nodes["NodeBLReasons"].Visible = false;
            baridTreeView1.Nodes["NodeManagement"].Nodes["NodeBlackLists"].Visible = false;
            baridTreeView1.Nodes["NodeManagement"].Nodes["NodeOper"].Visible = false;
            baridTreeView1.Nodes["NodeManagement"].Nodes["NodeTravelArea"].Visible = false;
            baridTreeView1.Nodes["NodeManagement"].Nodes["NodeVehicleType"].Visible = false;

			baridTreeView1.Nodes ["NodeManagement"].Nodes ["NodeGlobalSetting"].Visible = false;
			baridTreeView1.Nodes ["NodeManagement"].Nodes ["NodeVehicles"].Visible = false;
			baridTreeView1.Nodes ["NodeManagement"].Visible = false;

			baridTreeView1.Nodes ["NodeGP"].Visible = false;
			baridTreeView1.Nodes ["NodeGP"].Nodes ["NodeCreateGp"].Visible = false;
			baridTreeView1.Nodes ["NodeGP"].Nodes ["NodeListPacks"].Visible = false;
            // NodeGateEsi
            int tedWindow = 0;
           RadTreeNode JustNode = null;
           if (!ItemsPublic.ConnectToServer)
           {
               return;
           }
           foreach (var right in ItemsPublic.MyRights)
           {
               if (right == AllFunctions._Rights.SystemSettingsManager)
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeGlobalSetting"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodeGlobalSetting"];
                   tedWindow++;
               }
               if (right == AllFunctions._Rights.View_vehicles)
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeVehicles"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodeVehicles"];
                   tedWindow++;
               }
               if (right == AllFunctions._Rights.View_agreements)
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeAgree"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodeAgree"];
                   tedWindow++;
               }
               if (right == AllFunctions._Rights.View_persons || right == AllFunctions._Rights.Request)
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodePerson"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodePerson"];
                   tedWindow++;
               }
               if (right == AllFunctions._Rights.View_offices)
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeOffice"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodeOffice"];
                   tedWindow++;
               }
               if (right == AllFunctions._Rights.View_groups)
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeGroup"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodeGroup"];
                   tedWindow++;
               }
               if (right == AllFunctions._Rights.View_bLreasons)
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeBLReasons"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodeBLReasons"];
                   tedWindow++;
               }
               if (right == AllFunctions._Rights.View_blackLists)
               {
                   //baridTreeView1.Nodes ["NodeManagement"].Visible = true;
                   //baridTreeView1.Nodes["NodeManagement"].Nodes["NodeBlackLists"].Visible = true;
               }
               if (right == AllFunctions._Rights.View_operators)
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeOper"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodeOper"];
                   tedWindow++;
               }
               if (right == AllFunctions._Rights.View_travelAreas)
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeTravelArea"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodeTravelArea"];
                   tedWindow++;
               }
               if (right == AllFunctions._Rights.View_vehiclesType)
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeVehicleType"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodeVehicleType"];
                   tedWindow++;
               }
               if (right == AllFunctions._Rights.View_packages ||
                   right == AllFunctions._Rights.confirm ||
                   right == AllFunctions._Rights.PassgeWorkerWoman ||
                   right == AllFunctions._Rights.PassageWorkerMan ||
                   right == AllFunctions._Rights.PassageGuest ||
                   right == AllFunctions._Rights.PassageTemp ||
                   right == AllFunctions._Rights.PassageArmy ||
                   right == AllFunctions._Rights.PassageTrainee)
               {
                   baridTreeView1.Nodes["NodeGP"].Visible = true;
                   baridTreeView1.Nodes["NodeGP"].Nodes["NodeListPacks"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeGP"].Nodes["NodeListPacks"];
                   tedWindow++;
               }

               if (right == AllFunctions._Rights.Request)
               {
                   baridTreeView1.Nodes["NodeGP"].Visible = true;
                   baridTreeView1.Nodes["NodeGP"].Nodes["NodeListPacks"].Visible = true;
                   baridTreeView1.Nodes["NodeGP"].Nodes["NodeCreateGp"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeGP"].Nodes["NodeListPacks"];
                   tedWindow++;
               }
               if (right == AllFunctions._Rights.Report_person
                   || right == AllFunctions._Rights.Report_office
                   || right == AllFunctions._Rights.Report_vehicle
                   || right == AllFunctions._Rights.Report_gatepass
                   || right == AllFunctions._Rights.Report_blacklist
                   || right == AllFunctions._Rights.Report_operator
                   || right == AllFunctions._Rights.Report_Inout
                   || right == AllFunctions._Rights.Report_Agreement
                   || right == AllFunctions._Rights.ReportLimitedPerson
                   )
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeReports"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodeReports"];
                   tedWindow++;
               }

               if (right == AllFunctions._Rights.TagView)
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeTag"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodeTag"];
                   tedWindow++;
               }
               

                   if (right == AllFunctions._Rights.EsiGateViewGOff)
               {
                   baridTreeView1.Nodes["NodeManagement"].Visible = true;
                   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeGateEsi"].Visible = true;
                   JustNode = baridTreeView1.Nodes["NodeManagement"].Nodes["NodeGateEsi"];
                   tedWindow++;
               }

           }

        //	baridTreeView1.Nodes["NodeManagement"].Nodes.Refresh();

            baridTreeView1.Nodes.Refresh();
            baridTreeView1.Refresh();
            baridTreeView1.ExpandAll();
            if (tedWindow == 1)
            {
             //   baridTreeView1.SelectedNode = JustNode;
                baridTreeView1.SelectedNode = null;
                baridTreeView1.SelectedNode = JustNode;
            }
        }
        private void baridTreeView1_SelectedNodeChanged(object sender, Telerik.WinControls.UI.RadTreeViewEventArgs e)
        {
        	try
        	{
                if (e.Node == null)
                    return;
        		CurrentNode = e.Node;
        		Cursor = Cursors.WaitCursor;
        		switch (CurrentNode.Name)
        		{
        			case "NodeAgree":
        				//  baridTreeView1.Nodes["NodeManagement"].Nodes["NodeVehicleType"].Visible = true;
        				//  baridTreeView1.Nodes["NodeManagement"].Nodes.Refresh();
        				//  baridTreeView1.Refresh();
        				//  break;
        				var frmNodeAgree = new gatepass.ui.agreement.frm_Agreements();
        				frmNodeAgree.ShowDialog();
        				frmNodeAgree.Close();
        				frmNodeAgree.Dispose();
        				break;
        			case "NodeGroup":
        				var frmNodeGroup = new gatepass.ui.group.frm_groups();
        				frmNodeGroup.ShowDialog();
        				frmNodeGroup.Close();
        				frmNodeGroup.Dispose();
        				break;
        			case "NodeOffice":
        				//   baridTreeView1.Nodes["NodeManagement"].Nodes["NodeVehicleType"].Visible = false;
        				//baridTreeView1.Nodes["NodeManagement"].Nodes.Refresh();
        				//baridTreeView1.Refresh();
        				//  break;
        				var frmNodeOffice = new gatepass.ui.office.frm_offices();
        				frmNodeOffice.ShowDialog();
        				frmNodeOffice.Close();
        				frmNodeOffice.Dispose();
        				break;
        			case "NodeOper":
        				var frmNodeOper = new gatepass.ui.operators.frm_operators();
        				frmNodeOper.ShowDialog();
        				frmNodeOper.Close();
        				frmNodeOper.Dispose();
        				break;

        			case "NodePerson":
                        ItemsPublic.BigErr += "-1";
        				var frmNodePerson = new gatepass.ui.person.frm_person();
                     //   var frmNodePerson = new mainForm();
                        ItemsPublic.BigErr += "0";
        				frmNodePerson.ShowDialog();
        				frmNodePerson.Close();
        				frmNodePerson.Dispose();
        				break;

        			case "NodeVehicleType":
        				var frmNodeVehicleType = new gatepass.ui.vehicle.frm_vehicleTypes();
        				frmNodeVehicleType.ShowDialog();
        				frmNodeVehicleType.Close();
        				frmNodeVehicleType.Dispose();
        				break;

        			case "NodeVehicles":
        				var frmNodeVehicles = new gatepass.ui.vehicle.frm_vehicles();
        				frmNodeVehicles.ShowDialog();
        				frmNodeVehicles.Close();
        				frmNodeVehicles.Dispose();
        				break;

        			case "NodeTravelArea":
        				var frmNodeTravelArea = new gatepass.ui.travelarea.frm_travelAreas();
        				frmNodeTravelArea.ShowDialog();
        				frmNodeTravelArea.Close();
        				frmNodeTravelArea.Dispose();
        				break;

        			case "NodeBLReasons":
        				var frmNodeBLReasons = new gatepass.ui.blacklist.frm_blacklistReasons();
        				frmNodeBLReasons.ShowDialog();
        				frmNodeBLReasons.Close();
        				frmNodeBLReasons.Dispose();
        				break;

        			case "NodeBlackLists":
						var frmNodeBlackLists = new gatepass.ui.blacklist.frm_blacklists();
						frmNodeBlackLists.ShowDialog();
						frmNodeBlackLists.Close();
						frmNodeBlackLists.Dispose();
						break;

					case "NodeCreateGp":
                        var frmPackM2 = new aorc.gatepass.Gp2.Pack.frm_InpackGP();
						frmPackM2.pmStatus = ItemsPublic.IndexStatus.toNew;
        				frmPackM2.IndexPack = null;
        				frmPackM2.isNew = true;
						frmPackM2.MainRadGridView.AllowAddNewRow = false;
        				frmPackM2.IsnewRowAdded = false;
						frmPackM2.ShowDialog ();
						frmPackM2.Close();
        				frmPackM2.Dispose();
					break;

        			case "NodeCreateGp2":
        				//var frmCreateGp = new gatepass.ui.package.frm_GatePasses ();
        				//frmCreateGp = new gatepass.ui.package.frm_GatePasses ();
        				//frmCreateGp.pmStatus = ItemsPublic.IndexStatus.toNew;
        				//frmCreateGp.IndexPack = null;
        				//frmCreateGp.isNew=true;
        				//frmCreateGp.ShowDialog ();
        				//frmCreateGp.Close ();
        				//frmCreateGp.Dispose ();
        				var frmSet = new gatepass.ui.package.frm_SettingPackGates();
        				var frmPackM = new gatepass.ui.package.frm_GatePassesGates();
        				frmPackM.pmStatus = ItemsPublic.IndexStatus.toNew;
        				frmPackM.IndexPack = null;
        				frmPackM.isNew = true;
        				//	 frmPackM.

        				var frmAddPersons = new gatepass.ui.package.frm_SelectOrAddPersons4();
        				frmAddPersons.ShowDialog();
        				if (frmAddPersons.DialogResult == DialogResult.OK)
        				{
        					//	frmAddPersons.ShowDialog();
        					if (frmAddPersons.State)
        					{
        						//MainRadGridView.DataSource=null;
        						//MainRadGridView.SelectAll();
        						//frmPackM.MainRadGridView.AllowAddNewRow = true;
        						frmPackM.IsnewRowAdded = true;
        						//frmPackM.MainRadGridView.CurrentRow = null;
        						//MainRadGridView.Rows.RemoveAt(0);
        						//frmPackM.MainRadGridView.DataSource = null;
        						//MainRadGridView.EndInit();
        						//MainRadGridView.EndUpdate();
        						//	MainRadGridView.EndEdit();
        						//while (MainRadGridView.Rows.Count > 0)
        						//{
        						//    MainRadGridView.Rows.RemoveAt(0);
        						//}

        						for (int count = 0; count < frmAddPersons.radGridViewSelected.Rows.Count; count++)
        						{
        							#region set rows

        							frmPackM.MainRadGridView.Rows.AddNew();
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_ID"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_ID"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_NationalCode"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_NationalCode"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_isWoman"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_isWoman"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_IdentifyCode"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_IdentifyCode"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_LicenseDriverCode"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_LicenseDriverCode"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_Name"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Name"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_Surname"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Surname"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_FatherName"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_FatherName"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_BirthCity"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_BirthCity"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_RegisterCity"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_RegisterCity"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_Nationality"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Nationality"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_BirthDate"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_BirthDate"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_Phone1"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Phone1"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_Phone2"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Phone2"].Value;
        							//						frmPackM.MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_HaveForm"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_HaveForm"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_RegisterCode"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_RegisterCode"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Person_LabelIsWoman"].Value =
        								frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_LabelIsWoman"].Value;
        							frmPackM.MainRadGridView.CurrentRow.Cells["Gatepass_ID"].Value = -1;
        							frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_IntPrint"].Value = -1;
        							frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_IsDriver"].Value = false;
        							frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_TimeLock"].Value = null;
        							frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_LockerId"].Value = -1;
        							frmPackM.MainRadGridView.CurrentRow.Cells["package_Id"].Value = -1;
        							frmPackM.MainRadGridView.CurrentRow.Cells["GatePass_IsExpired"].Value = false;
        							if (frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value != null)
        							{
        								using (var ms = new System.IO.MemoryStream())
        								{
        									((Bitmap) frmAddPersons.radGridViewSelected.Rows[count].Cells["Person_Picture"].Value).
        										Save(ms,
        										     System.
        										     	Drawing
        										     	.
        										     	Imaging
        										     	.
        										     	ImageFormat
        										     	.Jpeg);
        									var picture = ms.ToArray();
        									frmPackM.MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = picture.Length > 0
        									                                                                    	? picture
        									                                                                    	: null;
        								}
        							}
        							else
        							{
        								frmPackM.MainRadGridView.CurrentRow.Cells["Person_Picture"].Value = null;
        							}
        							#endregion
        						}
        						frmPackM.MainRadGridView.AllowAddNewRow = false;
        						frmPackM.IsnewRowAdded = false;
        						//frmPackM.MainRadGridView.Refresh();
        						//frmSet = new gatepass.ui.package.frm_SettingPack();
        						frmSet.ShowDialog();
        						if (frmSet.DialogResult == DialogResult.OK)
        						{
        							frmPackM.SetSetting(frmSet.uC_packDetailsForNewGates1);
        							frmPackM.ShowDialog();
        						}
        						//result = frmPackM.gotResult ();
        						//result = frmPackM.DialogResult == DialogResult.OK ? frmPackM.gotResult() : null;
        					}
        					frmPackM.Close();
        					frmPackM.Dispose();
        					frmSet.Close();
        					frmSet.Dispose();
        					frmAddPersons.Close();
        					frmAddPersons.Dispose();
        				}
        				break;

        			case "NodeListPacks":
                        var frmListPacks = new aorc.gatepass.Gp2.Pack.frm_InPacksMode();
        				frmListPacks.ShowDialog();
        				frmListPacks.Close();
        				frmListPacks.Dispose();
        				break;

					case "NodeGlobalSetting":
                    //    throw new Exception();
        				var frmGlobal = new gatepass.frm_GlobalSetting();
						frmGlobal.ShowDialog ();
						frmGlobal.Close ();
						frmGlobal.Dispose ();
						break;

                    case "NodeReports":
                        var frmReports = new aorc.gatepass.Complex_Reports.Reporter.MainReporter();
                        frmReports.ShowDialog();
                        frmReports.Close();
                        frmReports.Dispose();
                        break;

                    case"NodeTag":
                        var frmTag = new aorc.gatepass.Tag.TagForm();
                    //    var frmTag = new aorc.gatepass.Tag.tag001();

                        frmTag.ShowDialog();
                        frmTag.Close();
                        frmTag.Dispose();
                        break;

                    case "NodeGateEsi":
                        var frmGateBase = new aorc.gatepass.EsiGate3.EsiGateBase();
                        frmGateBase.ShowDialog();
                        frmGateBase.Close();
                        frmGateBase.Dispose();
                        break;

        		}
        		Cursor = Cursors.Default;
        	}
        	catch (Exception ex)
        	{
                try
                {
                    Cursor = Cursors.Default;
                MessageBox.Show( " ItemsPublic.BigErr:= " + ItemsPublic.BigErr);
                    MessageBox.Show("ex.InnerException:= " + ex.InnerException + "\r\n\r\n" + "ex.Message:= " + ex.Message + "\r\n\r\n" + "ex.Source:= " + ex.Source + "\r\n\r\n" + "ex.StackTrace:= " + ex.StackTrace + "\r\n\r\n" + "ex.ToString():= " + ex.ToString());
                    if (ex.InnerException != null)
                    {

                        MessageBox.Show("ex.InnerException.Message:= " + ex.InnerException.Message + "\r\n\r\n" + "ex.InnerException.Source:= " + ex.InnerException.Source + "\r\n\r\n" + "ex.InnerException.StackTrace:= " + ex.InnerException.StackTrace + "\r\n\r\n" + "ex.InnerException.ToString():= " + ex.InnerException.ToString());
                    }
                }
                catch
                {
                    MessageBox.Show("ERR :-)");
                }

        	}
        }

    	private void baridTreeView1_NodeMouseClick(object sender, RadTreeViewEventArgs e)
        {
            if (e.Node == CurrentNode)
            {
                baridTreeView1_SelectedNodeChanged(sender, e);
            }
        }
    }
}
