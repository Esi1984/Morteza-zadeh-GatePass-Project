using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baridsoft.EOrg.Framework.PluginInterface;
namespace aorc.gatepass.eorg.ui
{
    public partial class ExplorerPanel : UserControl, Baridsoft.EOrg.Framework.PluginInterface.IEOrgContainer
    {
        public ExplorerPanel()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            object obj2 = null;

            if (MainFrameContext.ContainerPanel.Controls.Count > 0)
            {

                obj2 = MainFrameContext.ContainerPanel.Controls[0];

            }

            this.Dock = DockStyle.Fill;

            MainFrameContext.ContainerPanel.Controls.Clear();

            MainFrameContext.ContainerPanel.Controls.Add(this);

            this.Refresh();
        }

        public event EventHandler Activated;

        public void Deactivate()
        {
            
        }

        public event EventHandler Deactivated;

        public Image Icon { get; set; }

        public object InvokeMethod(string method, params object[] paramArray)
        {
            return null;
        }

        public object ItemList { get; set; }

        public Baridsoft.EOrg.Framework.PluginInterface.IEOrgExplorer ParentExplorer { get; set; }

        public void RefreshItem(object item)
        {
           
        }

        public void SelectItem(object item)
        {
            
        }

        public object SelectedItem
        {
            get { return null; }
        }

        public event EventHandler SelectedItemChanged;

        private void ExplorerPanel_Load(object sender, EventArgs e)
        {
            //ServerClasses.Customer CurrentC = new ServerClasses.Customer();
            //Dictionary<ServerClasses.AllFunctions._IdData, object> input = new Dictionary<ServerClasses.AllFunctions._IdData, object>();
            //input.Add(ServerClasses.AllFunctions._IdData.Event_ComputerName, "Local");
            //decimal i = 1;
            //input.Add(ServerClasses.AllFunctions._IdData.OfficeOperators_Id,i);
            //input.Add(ServerClasses.AllFunctions._IdData.Event_IpAddress, "local");
            //input.Add(ServerClasses.AllFunctions._IdData.IdMethod, ServerClasses.AllFunctions._IdMethod.View_packages);
            //ServerClasses.OutputDatas Result = new ServerClasses.OutputDatas();
            //Result = CurrentC.Suit(ServerClasses.Serialize.BinarySerialize(input));
            //if (Result.success)
            //{
            //    dataGridView1.DataSource = Result.ResultTable;
            //}
            //else
            //{
            //    MessageBox.Show(Result.Message);
            //}
        }
        public void ShowRightsOper(){}
        //public void ShowPropOper(string office,string group,string operName,string operJob, string operCode)
        public void ShowPropOper( string office  )
        {
	        vrlblOfficeName.Text = office;
            //rlblVersion.Location.X = 5;    
            //rlblVersion.Left = 5;
            //rlblVersion.Top = panel1.Height - ;
	        rlblOfficeName.Visible = true;
	        vrlblOfficeName.Visible = true;
            rlblVersion.Text = "Version: " + ItemsPublic.InfoVersion();
            rlblVersion.Visible = true;
	        //vrlblGroup.Text = group;
        }
        public void ShowProblem(string InText)
        {
            vrlblOfficeName.Text = InText;
            //rlblVersion.Location.X = 5;    
            //rlblVersion.Left = 5;
            //rlblVersion.Top = panel1.Height - ;
            rlblOfficeName.Visible = false;
            vrlblOfficeName.Visible = true;
            rlblVersion.Text = "Version: " + ItemsPublic.InfoVersion();
            rlblVersion.Visible = true;
            //vrlblGroup.Text = group;
        }

    }
}
