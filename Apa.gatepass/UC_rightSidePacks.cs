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
	public partial class UC_rightSidePacks : UserControl
	{
		public UC_rightSidePacks()
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
		public void UnSelect()
		{
			CurrentStatusPack=null;
			packsTreeView1.SelectedNode=null;
		}
		public void SelectFirst()
		{
			//CurrentStatusPack=null;
			packsTreeView1.SelectedNode = packsTreeView1.Nodes ["NodePacks"].Nodes ["NodePassed"];
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
						CurrentStatusPack = AllFunctions._StatusPack.Passage;
						eventNodePassed();
						break;
					case "NodeWaitPass":
						CurrentStatusPack = AllFunctions._StatusPack.Confirm;
						eventNodeWaitPass();
						break;
					case "NodeWaitConfirm":
						CurrentStatusPack = AllFunctions._StatusPack.Request;
						eventNodeWaitConfirm();
						break;
					case "NodeWaitRequest":
						CurrentStatusPack = AllFunctions._StatusPack.Create;
						eventNodeWaitRequest();
						break;
					case "NodeNoConfirm":
						CurrentStatusPack = AllFunctions._StatusPack.NoConfirm;
						eventNodeNoConfirm();
						break;
					case "NodeNoPass":
						CurrentStatusPack = AllFunctions._StatusPack.NoPassage;
						eventNodeNoPass();
						break;
					default:
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
