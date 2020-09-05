using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Baridsoft.EOrg.Workflow.UI.Win;
using Baridsoft.EOrg.Workflow.BusinessObject;
using Baridsoft.EOrg.Security.BusinessFacadeInterface;
using Baridsoft.EOrg.Security.BusinessObject;
using Baridsoft.EOrg.Directory.BusinessObject;
using Baridsoft.EOrg.Directory.BusinessFacadeInterface;
using Baridsoft.EOrg.Workflow.BusinessFacadeInterface;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Diagnostics;
using Baridsoft.EOrg.Framework.General;
using ServerClasses;

namespace aorc.gatepass.ui.mail
{
    class MailBarid
    {
        const int _TypeGpBaridId = 100002;
        const string _sss = " :: "+"لطفا جهت اقدام قبل از باز نمودن پیام گزینه مشاهده بسته مجوز را انتخاب نمایید";
        public bool SendMail(decimal IdSender, decimal? IdReceiverTemp, decimal IdPack, string InSubject, string InDescription) 
        {
            try
            {
                if (IdReceiverTemp == null)
                {
                    return false;
                }
               var IdReceiver = (decimal)IdReceiverTemp;
                //if (IdPack == null)
                //{
                //    ItemsPublic.Exeptor("بسته ورودی نامشخص است");
                //}
                //if (IdReceiver == null)
                //{
                //    ItemsPublic.Exeptor("گیرنده پیام نامشخص است");
                //}
            //    IdPack = (decimal)IdPack;
                
                string TicketID = UserContext.TicketID;
                PostItem mail = new PostItem(true);
                // MessageBox.Show(mail.GetID().ToString());
                mail.Subject = InSubject;// "درخواست مجوز عبور";
                mail.StateDate = DateTime.Now;

                mail.Description = string.IsNullOrEmpty(InDescription) ? _sss : InDescription + "\r\n\r\n" + _sss;
          //      return false;
                EOrgObject infoPack = new EOrgObject(true);
                infoPack.CreatorID = IdSender;// UserContext.CurrentUser.ID;
                infoPack.ObjectTypeID = _TypeGpBaridId;// عدد ثابت باید برای آبجکت های از نوع بسته های مجوز لحاظ شود
                infoPack.IsCreatedBySystem = true;
                infoPack.SensitivityLevel = (int)SensivityType.Normal;
                infoPack.ObjectID = IdPack;
                infoPack.OwnerID = IdSender; // UserContext.CurrentUser.ID;
                infoPack.AllowInheritablePermissions = true;
                IEOrgObjectFacade facade1 = SecurityProxyFactory.NewEOrgObjectFacade();
                if (!facade1.IsExistObject(TicketID, IdPack))
                {

                    mail.ReferenceId = facade1.Create(TicketID, infoPack);
                }
                else
                {
                    mail.ReferenceId = facade1.LoadObject(TicketID, IdPack).ObjectID;
                }
                
                InvolvedPersonList workFlowInvolvedPersonList = new InvolvedPersonList();
                InvolvedPerson workFlowInvolvedPerson = new InvolvedPerson(true);
                IParticipantFacade participantFacade = DirectoryProxyFactory.NewParticipantFacade();
                Participant defaultParticipant = participantFacade.GetDefaultParticipant(TicketID, IdReceiver);
                workFlowInvolvedPerson.PersonID = IdReceiver;
                workFlowInvolvedPerson.InvolvedTypeID = (int)InvolvedType.MainReceiver;
                workFlowInvolvedPerson.InvolvedParticipantID = defaultParticipant.ID;
                workFlowInvolvedPerson.OrganizationID = defaultParticipant.OrganizationUnitID;
                workFlowInvolvedPerson.DisplayString = defaultParticipant.PersonName + "(" + defaultParticipant.DisplayString + ")";
                workFlowInvolvedPerson.PersonName = defaultParticipant.PersonName;
                workFlowInvolvedPerson.PositionName = defaultParticipant.PositionName;
                workFlowInvolvedPersonList.Add(workFlowInvolvedPerson);
                mail.InvolvedPersonList = workFlowInvolvedPersonList;

                IPostItemFacade facade = WorkflowProxyFactory.NewPostItemFacade();
                decimal idResult = facade.Send(TicketID, mail, IdSender, true);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        public bool OpenMail( decimal IdPack)
        {

            bool FakeVersion = false;
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
                    if (verEsi.ToString() != "1")
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
                if (!FakeVersion)
                {
                    // aorc.gatepass.ui.login.frm_officeselector frm = new gatepass.ui.login.frm_officeselector();

                    //OOO ItemsPublic.MyBaridId = 18300010002000000053103314M;



                    foreach (var item in System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName()))
                    {
                        if (item.ToString().Substring(0, 3) == "172")
                        {
                            ItemsPublic.MyIpAddress = item.ToString();
                        }
                    }



                    ItemsPublic.MyBaridId = Baridsoft.EOrg.Framework.General.UserContext.CurrentUser.ID;

                    ItemsPublic.MyComputerName = System.Net.Dns.GetHostName();

                    aorc.gatepass.ui.login.MyLogin LoginObj = new gatepass.ui.login.MyLogin();
                    LoginObj.Start();

                //    frm.ShowDialog();
                 //   frm.Close();
                    if (!ItemsPublic.AcssesIsDenied && ItemsPublic.ConnectToServer)
                    {


                        gatepass.Gp2.Pack.frm_InpackGP frmPackM = new gatepass.Gp2.Pack.frm_InpackGP();
                        //var frmPackM = new gatepass.ui.package.frm_packManage();

                        frmPackM.isNew = false;
                        frmPackM.pmStatus = ItemsPublic.IndexStatus.toEdit;
                        frmPackM.IndexPack = IdPack;

                        frmPackM.setItemsPack(IdPack);
                        frmPackM.ShowDialog();
                    }
                    else
                    {
                        FakeVersion = true;
                        MessageBox.Show("متاسفانه امکان برقراری ارتباط با سرور وجود ندارد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //     var result = frmPackM.DialogResult == DialogResult.OK ? frmPackM.gotResult() : null;
                }
                else
                {
                    ItemsPublic.ShowMessage("نسخه برنامه بروز نیست");
                }               
            }
            catch (Exception ex)
            {
                FakeVersion = true;
                MessageBox.Show(ex.Message);
            }

            return false;
        }
    }
}
