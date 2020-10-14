using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SystemPowerController
{
    class Monitor
    {
        // モニタ電源関連のコマンド送信用
        const int SC_MONITORPOWER = 0xf170;
        const int WM_SYSCOMMAND = 0x112;

        // Win32API
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]

        // APIに投げる（SendMessageだとバグるからPostに変更 たぶん同期処理のせい）
        static extern IntPtr PostMessage(int hWnd, uint Msg, int wParam, int lParam);

        // モニタ出力off
        public static void PowerOff()
        {
            PostMessage(-1, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }

        // モニタ出力on
        public static void PowerOn()
        {
            PostMessage(-1, WM_SYSCOMMAND, SC_MONITORPOWER, -1);
        }

        // モニタ省電力
        public static void PowerSave()
        {
            PostMessage(-1, WM_SYSCOMMAND, SC_MONITORPOWER, 1);
        }
    }
}
