using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServerClasses;
namespace aorc.gatepass
{
	public partial class UC_rightSidePacksFilter : UserControl
	{
		public UC_rightSidePacksFilter()
		{
			InitializeComponent ();
		}
		
		public delegate void DelegateStatusAction();
		public event DelegateStatusAction eventNodePassed;
		public event DelegateStatusAction eventNodeWaitPass;
		public event DelegateStatusAction eventNodeWaitConfirm;
		public event DelegateStatusAction eventNodeWaitRequest;
		public event DelegateStatusAction eventNodeNoConfirm;
		public event DelegateStatusAction eventNodeNoPass;
		public AllFunctions._StatusPack? CurrentStatusPack { get;set;}
        public int? WhatState = null;
        public int? FilterMode = null;

		public void UnSelect()
		{
            FilterMode = null;
            WhatState = null;
			CurrentStatusPack=null;
			packsTreeView1.SelectedNode=null;
		}

		public void SelectFirst()
		{
			//CurrentStatusPack=null;

            if(ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageGuest)
                ||ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageTrainee)
                ||ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassageWorkerMan)
                ||ItemsPublic.MyRights.Contains(AllFunctions._Rights.PassgeWorkerWoman))
            {
                packsTreeView1.SelectedNode = packsTreeView1.Nodes["NodePacks"].Nodes["NodeWaitPass"];
            }
            else if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.PrintWithPic) || ItemsPublic.MyRights.Contains(AllFunctions._Rights.PrintWithoutPic))
            {
                packsTreeView1.SelectedNode = packsTreeView1.Nodes["NodePacks"].Nodes["NodePassed"];
            }
            else if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.confirm))
            {
                packsTreeView1.SelectedNode = packsTreeView1.Nodes["NodePacks"].Nodes["NodeWaitConfirm"];
            }
            else if (ItemsPublic.MyRights.Contains(AllFunctions._Rights.Request))
            {
                packsTreeView1.SelectedNode = packsTreeView1.Nodes["NodePacks"].Nodes["NodeWaitRequest"];
            }
            else
            {
                packsTreeView1.SelectedNode = packsTreeView1.Nodes["NodePacks"];
            }
		}

		private void packsTreeView1_SelectedNodeChanged( object sender , Telerik.WinControls.UI.RadTreeViewEventArgs e )
		{
			try
			{
				//CurrentNode = e.Node;
				if ( e==null||e.Node==null )
					return;
				Cursor = Cursors.WaitCursor;
                
				switch ( e.Node.Name )
				{
					case "NodePassed":
                        WhatState = 0;
                        FilterMode = null;
						CurrentStatusPack = AllFunctions._StatusPack.Passage;
						eventNodePassed();
						break;

                    #region NodePassed
                    case "NodePassedGateM":
                        WhatState = 2;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Passage;
                        eventNodePassed();
                        break;

                    case "NodePassedGate13":
                        WhatState = null;
                        FilterMode = 3;
                      //  FilterMode = 3;
                        CurrentStatusPack = AllFunctions._StatusPack.Passage;
                        eventNodePassed();
                        break;

                    case "NodePassedGate14":
                        WhatState = 3;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Passage;
                        eventNodePassed();
                        break;

                    case "NodePassedGate18":
                        WhatState = 4;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Passage;
                        eventNodePassed();
                        break;

                    case "NodePassedGate19":
                        WhatState = 5;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Passage;
                        eventNodePassed();
                        break;

                    case "NodePassedGateGO":
                        WhatState = 6;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Passage;
                        eventNodePassed();
                        break;

                    #endregion

                    case "NodeWaitPass":
                        WhatState = null;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Confirm;
						eventNodeWaitPass();
						break;

                    #region NodeWaitPass
                    case "NodeWaitPassGateM":
                        WhatState = 1;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Confirm;
                        eventNodeWaitPass();
                        break;

                    case "NodeWaitPassGate13":
                        WhatState = null;
                        FilterMode = 3;
                        CurrentStatusPack = AllFunctions._StatusPack.Confirm;
                        eventNodeWaitPass();
                        break;

                    case "NodeWaitPassGate14":
                        WhatState = 3;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Confirm;
                        eventNodeWaitPass();
                        break;

                    case "NodeWaitPassGate18":
                        WhatState = 4;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Confirm;
                        eventNodeWaitPass();
                        break;

                    case "NodeWaitPassGate19":
                        WhatState = 5;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Confirm;
                        eventNodeWaitPass();
                        break;

                    case "NodeWaitPassGateGO":
                        WhatState = 6;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Confirm;
                        eventNodeWaitPass();
                        break;

                    #endregion

                    case "NodeWaitConfirm":
                        WhatState = null;
                        FilterMode = null;
						CurrentStatusPack = AllFunctions._StatusPack.Request;
						eventNodeWaitConfirm();
						break;

                    #region NodeWaitConfirm
                    case "NodeWaitConfirmGateM":
                        WhatState = null;
                        FilterMode = 3;
                        CurrentStatusPack = AllFunctions._StatusPack.Request;
                        eventNodeWaitConfirm();
                        break;

                    case "NodeWaitConfirmGate13":
                        WhatState = 2;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Request;
                        eventNodeWaitConfirm();
                        break;

                    case "NodeWaitConfirmGate14":
                        WhatState = 3;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Request;
                        eventNodeWaitConfirm();
                        break;

                    case "NodeWaitConfirmGate18":
                        WhatState = 4;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Request;
                        eventNodeWaitConfirm();
                        break;

                    case "NodeWaitConfirmGate19":
                        WhatState = 5;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Request;
                        eventNodeWaitConfirm();
                        break;

                    case "NodeWaitConfirmGateGO":
                        WhatState = 6;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Request;
                        eventNodeWaitConfirm();
                        break;

                    #endregion

                    case "NodeWaitRequest":
                        WhatState = null;
                        FilterMode = null;
						CurrentStatusPack = AllFunctions._StatusPack.Create;
						eventNodeWaitRequest();
						break;

                    #region NodeWaitRequest

                    case "NodeWaitRequestGateM":
                        WhatState = null;
                        FilterMode = 3;
                        CurrentStatusPack = AllFunctions._StatusPack.Create;
                        eventNodeWaitRequest();
                        break;

                    case "NodeWaitRequestGate13":
                        WhatState = 2;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Create;
                        eventNodeWaitRequest();
                        break;

                    case "NodeWaitRequestGate14":
                        WhatState = 3;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Create;
                        eventNodeWaitRequest();
                        break;

                    case "NodeWaitRequestGate18":
                        WhatState = 4;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Create;
                        eventNodeWaitRequest();
                        break;

                    case "NodeWaitRequestGate19":
                        WhatState = 5;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Create;
                        eventNodeWaitRequest();
                        break;

                    case "NodeWaitRequestGateGO":
                        WhatState = 6;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.Create;
                        eventNodeWaitRequest();
                        break;

                    #endregion

                    case "NodeNoConfirm":
                        WhatState = null;
                        FilterMode = null;
						CurrentStatusPack = AllFunctions._StatusPack.NoConfirm;
						eventNodeNoConfirm();
						break;

                    #region NodeNoConfirm

                    case "NodeNoConfirmGateM":
                        WhatState = null;
                        FilterMode = 3;
                        CurrentStatusPack = AllFunctions._StatusPack.NoConfirm;
                        eventNodeNoConfirm();
                        break;

                    case "NodeNoConfirmGate13":
                        WhatState = 2;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.NoConfirm;
                        eventNodeNoConfirm();
                        break;

                    case "NodeNoConfirmGate14":
                        WhatState = 3;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.NoConfirm;
                        eventNodeNoConfirm();
                        break;

                    case "NodeNoConfirmGate18":
                        WhatState = 4;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.NoConfirm;
                        eventNodeNoConfirm();
                        break;

                    case "NodeNoConfirmGate19":
                        WhatState = 5;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.NoConfirm;
                        eventNodeNoConfirm();
                        break;

                    case "NodeNoConfirmGateGO":
                        WhatState = 6;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.NoConfirm;
                        eventNodeNoConfirm();
                        break;

                    #endregion

                    case "NodeNoPass":
                        WhatState = null;
                        FilterMode = null;
						CurrentStatusPack = AllFunctions._StatusPack.NoPassage;
						eventNodeNoPass();
						break;

                    #region NodeNoPass

                    case "NodeNoPassGateM":
                        WhatState = null;
                        FilterMode = 3;
                        CurrentStatusPack = AllFunctions._StatusPack.NoPassage;
                        eventNodeNoPass();
                        break;

                    case "NodeNoPassGate13":
                        WhatState = 2;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.NoPassage;
                        eventNodeNoPass();
                        break;

                    case "NodeNoPassGate14":
                        WhatState = 3;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.NoPassage;
                        eventNodeNoPass();
                        break;

                    case "NodeNoPassGate18":
                        WhatState = 4;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.NoPassage;
                        eventNodeNoPass();
                        break;

                    case "NodeNoPassGate19":
                        WhatState = 5;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.NoPassage;
                        eventNodeNoPass();
                        break;

                    case "NodeNoPassGateGO":
                        WhatState = 6;
                        FilterMode = null;
                        CurrentStatusPack = AllFunctions._StatusPack.NoPassage;
                        eventNodeNoPass();
                        break;

                    #endregion

                    default:
                        WhatState = null;
						CurrentStatusPack = null;
						break;
				}
				Cursor = Cursors.Default;
			}
			catch ( Exception ex )
			{
				Cursor = Cursors.Default;
				MessageBox.Show ( ex.Message );
			}
		}

	}
}
