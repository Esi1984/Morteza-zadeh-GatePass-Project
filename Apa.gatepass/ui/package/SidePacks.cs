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


namespace aorc.gatepass.ui.package		
{
	public partial class SidePacks : UserControl
    {
       // public static decimal OOficeID = 0;
    //    public static List<string> SecurityList { get; set; }

        public SidePacks()
        {
            InitializeComponent();
        }

        private void SidePacks_Load(object sender, EventArgs e)
        {
        }

        private RadTreeNode CurrentNode;
        private void baridTreeView1_SelectedNodeChanged(object sender, Telerik.WinControls.UI.RadTreeViewEventArgs e)
        {
        	try
        	{
        		CurrentNode = e.Node;
        		Cursor = Cursors.WaitCursor;
        		switch (CurrentNode.Name)
        		{
        			case "NodeAgree":
        				//  baridTreeView1.Nodes["NodeManagement"].Nodes["NodeVehicleType"].Visible = true;
        				//baridTreeView1.Nodes["NodeManagement"].Nodes.Refresh();
        				//baridTreeView1.Refresh();
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
        				var frmNodePerson = new gatepass.ui.person.frm_person();
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
        				//var frmCreateGp = new gatepass.ui.package.frm_GatePasses ();
        				//frmCreateGp = new gatepass.ui.package.frm_GatePasses ();
        				//frmCreateGp.pmStatus = ItemsPublic.IndexStatus.toNew;
        				//frmCreateGp.IndexPack = null;
        				//frmCreateGp.isNew=true;
        				//frmCreateGp.ShowDialog ();
        				//frmCreateGp.Close ();
        				//frmCreateGp.Dispose ();
        				var frmSet = new gatepass.ui.package.frm_SettingPack();
        				var frmPackM = new gatepass.ui.package.frm_GatePasses();
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
        							frmPackM.SetSetting(frmSet.uC_packDetailsForNew1);
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
        				var frmListPacks = new gatepass.ui.package.frm_packs();
        				frmListPacks.ShowDialog();
        				frmListPacks.Close();
        				frmListPacks.Dispose();
        				break;
        		}
        		Cursor = Cursors.Default;
        	}
        	catch (Exception ex)
        	{
        		Cursor = Cursors.Default;
        		MessageBox.Show(ex.Message);
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
