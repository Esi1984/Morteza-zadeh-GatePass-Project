using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace aorc.gatepass.Tag
{
    class HID
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
            int dwExtraInfo);

        public static void SendKey(byte key)
        {
            const int KEYEVENTF_KEYUP = 0x02;
            const int KEYEVENTF_KEYDOWN = 0x00;
            //const int KEYEVENTF_SILENT = 0x04;
            HID.keybd_event(key, 0, KEYEVENTF_KEYDOWN, 0);
            HID.keybd_event(key, 0, KEYEVENTF_KEYUP, 0);
        }
    }
}
