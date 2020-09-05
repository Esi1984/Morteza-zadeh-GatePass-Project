using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServerClasses;
using System.Threading;

namespace aorc.gatepass.EsiGate3
{
    public partial class mortezazadehUcGate : UserControl
    {

        Manager GateManager = null;
        OutputDatas myCurrentState = null;
        decimal seePassing = -1;

        //   Thread ttt;

      //  Thread myThreadState = new Thread(ews);

        //public string labelName = "";
        // public int IdNumber = -1;

      //  public string labelMyGate = "";

        DateTime? LastRefreshTime = null;

        public ItemsPublic._EsiGate mygate = ItemsPublic._EsiGate.none;

        public mortezazadehUcGate()
        {
            InitializeComponent();
            GateManager = new Manager();
            myCurrentState = new OutputDatas();

            //ttt = new Thread(delegate()
            //{
            //    timerNews.Enabled = true;
            //});

        }

        private void GetNews()
        {
            try { 

            if (ItemsPublic._EsiGate.none == mygate)
            {
                GEventer("متاسفانه گیت شناسه معتبر ندارد");
                return;
            }

            var RNews = GateManager.EsiContCurrentState(mygate, LastRefreshTime, seePassing);
            if (RNews.success)
            {
                if (RNews.ResultTable == null)
                {
                    return;
                }
                myCurrentState = RNews;
                this.rtbGateName.Text = myCurrentState.ResultTable.Rows[0]["EsiMiniGate_Label"].ToString().Trim();
                switch ((ItemsPublic.MiniGateMainEsiMode)(int)myCurrentState.ResultTable.Rows[0]["MiniGateMainEsiMode_Id"])
                {
                    case ItemsPublic.MiniGateMainEsiMode.NormalGate:

                        this.lightsMainMode1.GateMainMode = ItemsPublic.MiniGateMainEsiMode.NormalGate;

                        this.LightGoIn.GateWayMode
                            = (ItemsPublic.MiniGateWayEsiMode)(int)myCurrentState.ResultTable.Rows[0]["MiniGateWayEsiMode_Id"];

                        this.LightGoOut.GateWayMode
                        = (ItemsPublic.MiniGateWayEsiMode)(int)myCurrentState.ResultTable.Rows[0]["OUT_MiniGateWayEsiMode_Id"];



                        break;
                    case ItemsPublic.MiniGateMainEsiMode.EmergencyGate:

                        this.lightsMainMode1.GateMainMode = ItemsPublic.MiniGateMainEsiMode.EmergencyGate;
                        this.LightGoIn.DisableMode();
                        this.LightGoOut.DisableMode();

                        //this.LightGoIn.GateWayMode
                        //    = ItemsPublic.MiniGateWayEsiMode.free;

                        //this.LightGoOut.GateWayMode
                        //= ItemsPublic.MiniGateWayEsiMode.free;

                        break;
                    case ItemsPublic.MiniGateMainEsiMode.BlockGate:
                        this.lightsMainMode1.GateMainMode = ItemsPublic.MiniGateMainEsiMode.BlockGate;
                        this.LightGoIn.DisableMode();
                        this.LightGoOut.DisableMode();
                        //                 this.LightGoIn.GateWayMode
                        //    = ItemsPublic.MiniGateWayEsiMode.blocked;

                        //this.LightGoOut.GateWayMode
                        //= ItemsPublic.MiniGateWayEsiMode.blocked;

                        break;

                    case ItemsPublic.MiniGateMainEsiMode.FreeRunGate:
                        this.lightsMainMode1.GateMainMode = ItemsPublic.MiniGateMainEsiMode.FreeRunGate;
                        this.LightGoIn.DisableMode();
                        this.LightGoOut.DisableMode();

                        //             this.LightGoIn.GateWayMode
                        //    = ItemsPublic.MiniGateWayEsiMode.free;
                        //this.LightGoOut.GateWayMode
                        //= ItemsPublic.MiniGateWayEsiMode.free;

                        break;


                }

                this.PicDisableGate.Visible = false;
                this.PicEnableGate.Visible = true;

             //   LightGoIn.Enabled = true;
             //   LightGoOut.Enabled = true;

                this.rtbGateState.Text = "وضعیت " + myCurrentState.ResultTable.Rows[0]["MiniGateMainEsiMode_Label"].ToString().Trim();

                if (LastRefreshTime == null)
                {
                    LastRefreshTime = new DateTime();
                }

                LastRefreshTime = (DateTime?)myCurrentState.ResultTable.Rows[0]["EsiMiniGate_TimeRefresh"];

                GEventer("وضعیت جاری تنظیم در تاریخ", LastRefreshTime.ToString());

            }
            }
            catch (Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
            } 

        }
        public void whoAmI(ItemsPublic._EsiGate inGateMode, string inGatelabel)
        {
            mygate = inGateMode;
            rtbGateName.Text = inGatelabel;
        }

        public bool TryToConnect() 
        {
            try
            {

                if (ItemsPublic._EsiGate.none == mygate)
                {
                    GEventer("متاسفانه گیت شناسه معتبر ندارد");
                    return false;
                }

                myCurrentState = GateManager.EsiContCurrentState(mygate, LastRefreshTime, seePassing);
                // result.ResultTable.Rows[0][""].ToString().Trim();
                if (myCurrentState.success)
                {

                    //   TryToConnect
                    //    this.labelMyGate = result.ResultTable.Rows[0]["EsiMiniGate_Label"].ToString().Trim();

                    // this.rtbGateName.Text = myCurrentState.ResultTable.Rows[0]["EsiMiniGate_Label"].ToString().Trim();

                    this.rtbGateName.Invoke((MethodInvoker)delegate
                    {
                        this.rtbGateName.Text = myCurrentState.ResultTable.Rows[0]["EsiMiniGate_Label"].ToString().Trim();
                    });


                    this.lightsMainMode1.GateMainMode = (ItemsPublic.MiniGateMainEsiMode)(int)myCurrentState.ResultTable.Rows[0]["MiniGateMainEsiMode_Id"];

                    if (this.lightsMainMode1.GateMainMode == ItemsPublic.MiniGateMainEsiMode.NormalGate)
                    {


                        this.LightGoIn.GateWayMode
                            = (ItemsPublic.MiniGateWayEsiMode)(int)myCurrentState.ResultTable.Rows[0]["MiniGateWayEsiMode_Id"];

                        this.LightGoOut.GateWayMode
             = (ItemsPublic.MiniGateWayEsiMode)(int)myCurrentState.ResultTable.Rows[0]["OUT_MiniGateWayEsiMode_Id"];


                    }
                    else
                    {
                        this.LightGoIn.DisableMode();
                        this.LightGoOut.DisableMode();
                    }

                    this.PicDisableGate.Invoke((MethodInvoker)delegate
                    {
                        this.PicDisableGate.Visible = false;
                    });
                    this.PicEnableGate.Invoke((MethodInvoker)delegate
                                 {
                                     this.PicEnableGate.Visible = true;
                                 });


                    LightGoIn.Enabled = true;

                    LightGoOut.Enabled = true;


                    this.rtbGateState.Invoke((MethodInvoker)delegate
                    {
                        this.rtbGateState.Text = "وضعیت " + myCurrentState.ResultTable.Rows[0]["MiniGateMainEsiMode_Label"].ToString().Trim();
                    });



                    if (LastRefreshTime == null)
                    {
                        LastRefreshTime = new DateTime();
                    }

                    LastRefreshTime = (DateTime?)myCurrentState.ResultTable.Rows[0]["EsiMiniGate_TimeRefresh"];

                    GEventer("اتصال موفق به گیت در زمان: ", LastRefreshTime.ToString());

                    timerNews.Enabled = true;

                    // ttt.Start();
                    return true;

                }
                else
                {
                    ItemsPublic.ShowMessage(myCurrentState.Message);
                    // gheire faAl shavad
                }
                return false;
            }catch(Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
                return false;
            } 
        }

        //public bool tryToDC() 
        //{ 
        //}
        private void PicDisableGate_DoubleClick(object sender, EventArgs e)
        {

        }

        private void PicEnableGate_DoubleClick(object sender, EventArgs e)
        {
            //if (!ItemsPublic.QuestionSureTo("آیا قصد قطع ارتباط با گیت را دارید؟"))
            //{
                
            //}
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void GEventer(params string[] inStr)
        {
           
            gEvent.Invoke((MethodInvoker)delegate {
                string myStr = "";
                foreach (string item in inStr)
                {
                    myStr += item + "\r\n";                    
                }
                myStr += "-----------------\r\n";
                gEvent.Text = myStr + gEvent.Text;
            });            
        }
        private void rbSetting_Click(object sender, EventArgs e)
        {

        }

        private void LightGoIn_EsmaeilBlock()
        {
            try
            {
                timerNews.Stop();
                if (ItemsPublic._EsiGate.none == mygate)
                {
                    GEventer("متاسفانه گیت شناسه معتبر ندارد");
                    return;
                }
                OutputDatas result = GateManager.EsiContSetNewWay(mygate, ItemsPublic.MiniGateWayEsiMode.blocked
                    , (ItemsPublic.MiniGateWayEsiMode)(int)myCurrentState.ResultTable.Rows[0]["OUT_MiniGateWayEsiMode_Id"]
                    );
                if (result.success)
                {
                    if (result.EsiBool)
                    {
                        GEventer("دستور جدید ارسال شد");
                    }
                    else
                    {
                        GEventer("ارسال دستور به دلیل فنی زیر ناموفق بود", result.EsiMessage);
                    }
                }
                else
                {
                    GEventer("تنظیم مسیر به دلیل زیر ناموفق بود", result.Message);

                }
                timerNews.Start();
            }
            catch (Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
            } 

        }

        private void LightGoIn_EsmaeilCard()
        {
            try { 
            timerNews.Stop();
            if (ItemsPublic._EsiGate.none == mygate)
            {
                GEventer("متاسفانه گیت شناسه معتبر ندارد");
                return;
            }
            OutputDatas result = GateManager.EsiContSetNewWay(mygate, ItemsPublic.MiniGateWayEsiMode.card
                , (ItemsPublic.MiniGateWayEsiMode)(int)myCurrentState.ResultTable.Rows[0]["OUT_MiniGateWayEsiMode_Id"]
                );
            if (result.success)
            {
                if (result.EsiBool)
                {
                    GEventer("دستور جدید ارسال شد");
                }
                else
                {
                    GEventer("ارسال دستور به دلیل فنی زیر ناموفق بود", result.EsiMessage);
                }
            }
            else
            {
                GEventer("تنظیم مسیر به دلیل زیر ناموفق بود", result.Message);

            }
            timerNews.Start();
            }
            catch (Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
            } 
        }

        private void LightGoIn_EsmaeilFree()
        {
            try { 
            timerNews.Stop();
            if (ItemsPublic._EsiGate.none == mygate)
            {
                GEventer("متاسفانه گیت شناسه معتبر ندارد");
                return;
            }
            OutputDatas result = GateManager.EsiContSetNewWay(mygate, ItemsPublic.MiniGateWayEsiMode.free
                , (ItemsPublic.MiniGateWayEsiMode)(int)myCurrentState.ResultTable.Rows[0]["OUT_MiniGateWayEsiMode_Id"]
                );
            if (result.success)
            {
                if (result.EsiBool)
                {
                    GEventer("دستور جدید ارسال شد");
                }
                else
                {
                    GEventer("ارسال دستور به دلیل فنی زیر ناموفق بود", result.EsiMessage);
                }
            }
            else
            {
                GEventer("تنظیم مسیر به دلیل زیر ناموفق بود", result.Message);

            }
            timerNews.Start();
            }
            catch (Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
            } 
        }

        private void LightGoOut_EsmaeilBlock()
        {
            try { 
            timerNews.Stop();
            if (ItemsPublic._EsiGate.none == mygate)
            {
                GEventer("متاسفانه گیت شناسه معتبر ندارد");
                return;
            }
            OutputDatas result = GateManager.EsiContSetNewWay(mygate
                , (ItemsPublic.MiniGateWayEsiMode)(int)myCurrentState.ResultTable.Rows[0]["MiniGateWayEsiMode_Id"]
                , ItemsPublic.MiniGateWayEsiMode.blocked
                );
            if (result.success)
            {
                if (result.EsiBool)
                {
                    GEventer("دستور جدید ارسال شد");
                }
                else
                {
                    GEventer("ارسال دستور به دلیل فنی زیر ناموفق بود", result.EsiMessage);
                }
            }
            else
            {
                GEventer("تنظیم مسیر به دلیل زیر ناموفق بود", result.Message);

            }
            timerNews.Start();
            }
            catch (Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
            } 
        }

        private void LightGoOut_EsmaeilCard()
        {
            try { 
            timerNews.Stop();
            if (ItemsPublic._EsiGate.none == mygate)
            {
                GEventer("متاسفانه گیت شناسه معتبر ندارد");
                return;
            }
            OutputDatas result = GateManager.EsiContSetNewWay(mygate
                , (ItemsPublic.MiniGateWayEsiMode)(int)myCurrentState.ResultTable.Rows[0]["MiniGateWayEsiMode_Id"]
                , ItemsPublic.MiniGateWayEsiMode.card
                );
            if (result.success)
            {
                if (result.EsiBool)
                {
                    GEventer("دستور جدید ارسال شد");
                }
                else
                {
                    GEventer("ارسال دستور به دلیل فنی زیر ناموفق بود", result.EsiMessage);
                }
            }
            else
            {
                GEventer("تنظیم مسیر به دلیل زیر ناموفق بود", result.Message);

            }
            timerNews.Start();
            }
            catch (Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
            } 
        }

        private void LightGoOut_EsmaeilFree()
        {
            try { 
            timerNews.Stop();
            if (ItemsPublic._EsiGate.none == mygate)
            {
                GEventer("متاسفانه گیت شناسه معتبر ندارد");
                return;
            }
            OutputDatas result = GateManager.EsiContSetNewWay(mygate
                , (ItemsPublic.MiniGateWayEsiMode)(int)myCurrentState.ResultTable.Rows[0]["MiniGateWayEsiMode_Id"]
                , ItemsPublic.MiniGateWayEsiMode.free
                );
            if (result.success)
            {
                if (result.EsiBool)
                {
                    GEventer("دستور جدید ارسال شد");
                }
                else
                {
                    GEventer("ارسال دستور به دلیل فنی زیر ناموفق بود", result.EsiMessage);
                }
            }
            else
            {
                GEventer("تنظیم مسیر به دلیل زیر ناموفق بود", result.Message);

            }
            timerNews.Start();
            }
            catch (Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
            } 
        }

        private void timerNews_Tick(object sender, EventArgs e)
        {
            this.timerNews.Stop();
            GetNews();
            this.timerNews.Start();
        }

    
        private void lightsMainMode1_EsmaeilBlock()
        {
            try { 
            timerNews.Stop();
            if (ItemsPublic._EsiGate.none == mygate)
            {
                GEventer("متاسفانه گیت شناسه معتبر ندارد");
                return;
            }
            OutputDatas result = GateManager.EsiContSetNewMode(mygate, ItemsPublic.MiniGateMainEsiMode.BlockGate);
            if (result.success)
            {
                if (result.EsiBool)
                {
                    GEventer("دستور بسته شدن گیت با موفقیت ارسال شد");
                }
                else
                {
                    GEventer("ارسال دستور به دلیل فنی زیر ناموفق بود", result.EsiMessage);
                }
            }
            else
            {
                GEventer("تست شبکه به دلیل زیر ناموفق بود", result.Message);

            }
            timerNews.Start();
            }
            catch (Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
            } 
        }

        private void lightsMainMode1_EsmaeilEmergency()
        {
            try { 
            timerNews.Stop();
            if (ItemsPublic._EsiGate.none == mygate)
            {
                GEventer("متاسفانه گیت شناسه معتبر ندارد");
                return;
            }
            OutputDatas result = GateManager.EsiContSetNewMode(mygate, ItemsPublic.MiniGateMainEsiMode.EmergencyGate);
            if (result.success)
            {
                if (result.EsiBool)
                {
                    GEventer("دستور باز شدن اضطراری گیت با موفقیت ارسال شد");
                }
                else
                {
                    GEventer("ارسال دستور به دلیل فنی زیر ناموفق بود", result.EsiMessage);
                }
            }
            else
            {
                GEventer("تست  باز شدن اضطراری به دلیل زیر ناموفق بود", result.Message);

            }
            timerNews.Start();
            }
            catch (Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
            } 
        }

        private void lightsMainMode1_EsmaeilNormal()
        {
            try { 
            timerNews.Stop();
            if (ItemsPublic._EsiGate.none == mygate)
            {
                GEventer("متاسفانه گیت شناسه معتبر ندارد");
                return;
            }
            OutputDatas result = GateManager.EsiContSetNewMode(mygate, ItemsPublic.MiniGateMainEsiMode.NormalGate);
            if (result.success)
            {
                if (result.EsiBool)
                {
                    GEventer("دستور رفتن به وضعیت عادی  با موفقیت ارسال شد");
                }
                else
                {
                    GEventer("ارسال دستور به دلیل فنی زیر ناموفق بود", result.EsiMessage);
                }
            }
            else
            {
                GEventer("تست وضعیت عادی گیت به دلیل زیر ناموفق بود", result.Message);

            }
            timerNews.Start();
            }
            catch (Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
            } 
        }

        private void freerumode()
        {
            try { 
            timerNews.Stop();
            if (ItemsPublic._EsiGate.none == mygate)
            {
                GEventer("متاسفانه گیت شناسه معتبر ندارد");
                return;
            }
            OutputDatas result = GateManager.EsiContSetNewMode(mygate, ItemsPublic.MiniGateMainEsiMode.FreeRunGate);
            if (result.success)
            {
                if (result.EsiBool)
                {
                    GEventer("دستور عبور آزاد  با موفقیت ارسال شد");
                }
                else
                {
                    GEventer("ارسال دستور به دلیل فنی زیر ناموفق بود", result.EsiMessage);
                }
            }
            else
            {
                GEventer("تست عبور آزاد به دلیل زیر ناموفق بود", result.Message);

            }
            timerNews.Start();
            }
            catch (Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
            } 
        }

        private void rbNetTest_Click(object sender, EventArgs e)
        {

        }

        private void TestNet()
        {
            try { 
            timerNews.Stop();
            if (ItemsPublic._EsiGate.none == mygate)
            {
                GEventer("متاسفانه گیت شناسه معتبر ندارد");
                return;
            }
            var result = GateManager.EsiContTestNet(mygate, LastRefreshTime);
            if (result.success)
            {
                if (result.EsiBool)
                {
                    GEventer("دستور تست شبکه با موفقیت ارسال شد");
                }
                else
                {
                    GEventer("تست شبکه به دلیل فنی زیر ناموفق بود", result.EsiMessage);
                }
            }
            else
            {
                GEventer("تست شبکه به دلیل زیر ناموفق بود", result.Message);
            }
            timerNews.Start();
            }
            catch (Exception ex)
            {
                GEventer("خطای بحرانی: ", ex.Message);
            } 
        }

        private void PicEnableGate_Click(object sender, EventArgs e)
        {
            TestNet();
        }

        private void PicDisableGate_Click(object sender, EventArgs e)
        {
            TryToConnect();
        }
    }
}
