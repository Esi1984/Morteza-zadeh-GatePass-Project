using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aorc.gatepass.Tag
{
    public static class ReaderPublics
    {
        static public string bestChoise = "";
    }

    public class MortezazadehReaders
    {

        List<string> allComs;
        private System.Windows.Forms.Timer timer_Req;
        public string stateStr = "";
        bool Iconnected = false;

        public MortezazadehReaders()
        {
            Iconnected = false;
            timer_Req = new System.Windows.Forms.Timer();
            timer_Req.Enabled = false ;
            timer_Req.Interval = 1000;
            timer_Req.Tick += new System.EventHandler(this.timer_Req_Tick);
        }

        public void  TryToConnect()
        {
            DisConnect();
            Iconnected = false;
            timer_Req.Enabled = false;
            if (ReaderPublics.bestChoise!="")
            {
                if (OpenPort(ReaderPublics.bestChoise))
                {
                    stateStr = "اتصال ریدر برقرار می باشد";
                    Iconnected = true;
                    timer_Req.Enabled = true;
                    return;
                }
                else
                {
                    ReaderPublics.bestChoise = "";
                }
            }

            if (!System.IO.Ports.SerialPort.GetPortNames().Equals(System.DBNull.Value))
            {
                allComs = new List<string>();
                foreach (string np in System.IO.Ports.SerialPort.GetPortNames())
                {
                    allComs.Add(np);
                }
            }
            foreach (var items in allComs)
            {
                if (OpenPort(items))
                {
                    stateStr = "اتصال ریدر برقرار می باشد";
                    Iconnected = true;
                    timer_Req.Enabled = true;
                    ReaderPublics.bestChoise = items;
                    return;
                }
                
            }
            stateStr = "ریدر یافت نشد";
        }

        private bool OpenPort(string InComStr)
        {
            try
            {
                //   timer_Time.Enabled = true;
               // timer_Req.Enabled = true;

                if (InComStr != string.Empty)
                {

                    if (RFT230.MF_InitComm(InComStr, 9600) == 0)
                    {
                        byte[] TypeCard = new byte[2];
                        int rr = RFT230.MF_Request(0, 0, ref TypeCard[0]);

                        switch (rr)
                        {
                            case 1:
                                return true;
                            case 33:
                                RFT230.MF_ExitComm();
                                return false;
                            case 0:
                                return true;
                            //    RFT230.MF_ExitComm();
                                return false;
                            default:
                                RFT230.MF_ExitComm();
                                return false;
                        }

                    }
                    else
                    {
                        if (RFT230.MF_ExitComm() != 0)
                        {
                            /// !!!!!!!!!!!!!!!!!!!!!!
                        }
                    }
                }
                return false;
            }
            catch (Exception exception)
            {
                //  EventLogHandler.CreateEventLog("frmCard, btnOpen_Click: " + exception.Message);
                throw new Exception("خطا هنگام تلاش برای اتصال به کام   " + InComStr +" .... "+ exception.Message);
                return false;
            }

           // return false;
        }

        public void DisConnect()
        {
            timer_Req.Enabled = false;
            if (Iconnected)
            {
                int rr = RFT230.MF_ExitComm();
                if (rr == 0)
                {
                    Iconnected = false;
                    stateStr = "";
                    //   pCheckPort.BackColor = Color.Red;
                    //  btnClose.Enabled = false;
                    //  btnOpen.Enabled = true;

                    //    stateStr 
                }
                else
                {
                    // pCheckPort.BackColor = Color.Red;
                }
            }            
        }

        private void timer_Req_Tick(object sender, EventArgs e)
        {
            // GetCount = MYcOUNT;
            try
            {
                timer_Req.Enabled = false;
                byte[] TypeCard = new byte[2];
                int rr = RFT230.MF_Request(0, 0, ref TypeCard[0]);
                if (rr == 0)
                {
                    byte[] tmpSnr = new byte[4];
                    if (RFT230.MF_Anticoll(0, ref tmpSnr[0]) == 0)
                    {
                        string SNR = ValidValue(tmpSnr[0].ToString("X"))
                            + ValidValue(tmpSnr[1].ToString("X"))
                            + ValidValue(tmpSnr[2].ToString("X"))
                            + ValidValue(tmpSnr[3].ToString("X"));

                        //string SNR = tmpSnr[0].ToString("X") + tmpSnr[1].ToString("X") + tmpSnr[2].ToString("X") + tmpSnr[3].ToString("X");
                        SNR = Convert.ToString(Int64.Parse(SNR, System.Globalization.NumberStyles.HexNumber));
                        try
                        {
                            foreach (byte a in SNR + "\r")
                            {
                                HID.SendKey(a);
                            }
                        }
                        catch (Exception ee)
                        {
                            // EventLogHandler.CreateEventLog("frmCard, timer_Req_Tick(Catch1): " + ee.Message);
                        }
                    }

                    int[] Beep = { 10 };
                    RFT230.MF_ControlBuzzer(0, Beep[0]);
                //    Counter++;

                }
                else if (rr == 33)
                {
                    DisConnect();
                    return;
                }
                timer_Req.Enabled = true;
            }

            catch (Exception ee)
            {
                // EventLogHandler.CreateEventLog("frmCard, timer_Req_Tick(Catch2): " + ee.Message);
                throw new Exception("خطا هنگام تلاش برای دریافت داده از کام   " + " .... " + ee.Message);
            }
        }

        private string ValidValue(string _value)
        {
            if (_value.Length < 2)
                return _value = "0" + _value;
            else
                return _value;
        }


    }
}
