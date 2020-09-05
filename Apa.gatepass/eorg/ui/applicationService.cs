using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Baridsoft.EOrg.Framework.PluginInterface;
using System.Drawing;
using aorc.gatepass.eorg.ui;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace aorc.gatepass
{
    class AorcGpApplicationService : IEOrgApplicationService
    {

        public AorcGpApplicationService()
        {
            Icon = aorc.gatepass.Properties.Resources.Links_Fkkolder_icon;
            AddToFrameWork = true;
        }

        public AorcGpApplicationService(IEOrgMainFrame parent)
        {
            ParentMainFrame = parent;
        }

        public void Activate()
        {
            bool FakeVersion = false;
         //   MessageBox.Show(dd.id);
            try
            {
                if (File.Exists(Properties.Settings.Default.UpdateServer))
                {
                    var str = File.ReadAllText(Properties.Settings.Default.UpdateServer);
                    RegistryKey sk = Registry.CurrentUser.OpenSubKey("Software\\AORC GP", true);
                    if (sk == null)
                    {
                        sk = Registry.CurrentUser.CreateSubKey("Software\\AORC GP");
                    }
                    var ver = sk.GetValue("VERSION", "1.0.0.0");
                    var verEsi = sk.GetValue("VEsi", "0");
                    ItemsPublic.EsiKey = verEsi.ToString();
                    if (verEsi.ToString()!= "1")
                    if (str.Length > 0 && str.Split(':')[1].Trim().CompareTo(ver.ToString()) > 0)
                    {
                        MessageBox.Show("نسخه جدیدی از برنامه موجود می باشد.", "اعلان", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //sk.SetValue("VERSION", str.Split(':')[1].Trim());
                        if (File.Exists(Path.Combine(@"\\172.18.8.9\d\SetUp GP\", "GatepassInstaller.exe")))
                        {
                            Process.Start(Path.Combine(@"\\172.18.8.9\d\SetUp GP\", "GatepassInstaller.exe"), "/Silent");
                        }
                    }
                    if (verEsi.ToString() != "1")
                    if (str.Length > 0 && str.Split(':')[1].Trim().CompareTo(ver.ToString()) > 0)
                    {
                        FakeVersion = true;
                    }               
                }
            }
            catch (Exception ex)
            {
                FakeVersion = true;
                MessageBox.Show(ex.Message);
            }
            this.Initialize();
            this.ParentMainFrame.MainToolBar.Visible = false;
            this.ContainerPanel.Enabled = false;
            this.ExplorerPanel.Enabled = false;
            if (FakeVersion)
            {
                MessageBox.Show("نسخه برنامه بروز نیست", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                this.ParentMainFrame.SetFormCaption("سامانه جامع کنترل تردد", "سامانه جامع کنترل تردد", this.Icon);
                this.CurrentEOrgExplorer.Activate();
                this.ParentMainFrame.SetFormCaption("سیستم مجوز عبور و کنترل تردد", "", null);
                if (aorc.gatepass.ItemsPublic.ConnectToServer == false)
                {                  
                    MessageBox.Show("متاسفانه امکان برقراری ارتباط با سرور وجود ندارد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (aorc.gatepass.ItemsPublic.AcssesIsDenied)
                {
                    MessageBox.Show("امکان دسترسی به سامانه مجوز تردد وجود ندارد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    this.ContainerPanel.Enabled = true;
                    this.ExplorerPanel.Enabled = true;
                    CurrentEOrgExplorer.SelectItem(null);
                }
            }

        }

        public event EventHandler Activated;

        public bool AddToFrameWork { get; set; }

        public Panel ContainerPanel { get; set; }

        IEOrgExplorer cEorgXplorer;

        public IEOrgExplorer CurrentEOrgExplorer
        {
            get { return (IEOrgExplorer)cEorgXplorer; }
        }

        public void Deactivate()
        {
            this.ContainerPanel.Enabled = true;
            this.ExplorerPanel.Enabled = true;
            this.CurrentEOrgExplorer.Deactivate();
        }

        public event EventHandler Deactivated;

        public Panel ExplorerPanel { get; set; }

        public bool HideMainToolbar
        {
            get { return false; }
        }

        public int ID { get; set; }

        public Image Icon { get; set; }

        private bool binit = false;

        public void Initialize()
        {
            if (!binit)
            {
                rightside currentEorgXplorer;
                rightside rightmnu;
                currentEorgXplorer = new rightside();
                cEorgXplorer = (IEOrgExplorer)currentEorgXplorer;
                this.ExplorerPanel.Controls.Clear();
                currentEorgXplorer.Dock = DockStyle.Fill;                
                this.ExplorerPanel.Controls.Add(currentEorgXplorer);
                binit = true;
                //   MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //   rightmnu.Enabled = false;
                //   currentEorgXplorer.Enabled = false;
            }
        }

        public string Name { get; set; }

        public IEOrgMainFrame ParentMainFrame { get; set; }

        public object InvokeMethod(string method, decimal referenceId, params object[] paramArray)
        {
            //if (method == "view")
            if(true)
            {
               aorc.gatepass.ui.mail.MailBarid objMail = new gatepass.ui.mail.MailBarid();
               objMail.OpenMail(referenceId);
                // khoroj
            }

            return null;
        }

        public object InvokeMethod(string method, params object[] paramArray)
        {
            return null;
        }
        public ObjectMethod[] GetFolderMethods(string ticketId, decimal FolderId)
        {
            ArrayList list = new ArrayList();
            ObjectMethod method = new ObjectMethod();
            list.Add(method);
            return (list.ToArray(typeof(ObjectMethod)) as ObjectMethod[]);
        }

        public ObjectMethod[] GetNewObjectMethod(string ticketId)
        {
            return new ObjectMethod[0];
        }

        public ObjectMethod[] GetObjectMethods(string ticketId, decimal ObjectId, int objectType)
        {
            return new ObjectMethod[] { new ObjectMethod((long)this.ID, "مشاهده بسته مجوز", "view") };
        }

        public ObjectMethod[] GetShortcutMethod(string ticketId)
        {
            var al = new ObjectMethod[1];
            return al;
        }

    }
}
