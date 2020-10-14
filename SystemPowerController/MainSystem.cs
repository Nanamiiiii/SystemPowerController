using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemPowerController
{
    public class MainSystem
    { 
        // モニター電源off
        public static void MonitorPowerOff()
        {
            // 0.5s待機後にモニターオフ
            System.Threading.Thread.Sleep(500);
            Monitor.PowerOff();
        }

        // シャットダウン
        public static void SystemShutdown()
        {
            // 0.5s待機後にシャットダウン
            System.Threading.Thread.Sleep(500);
            SystemPower.SystemPowerControll(0);
        }

        // サインアウト
        public static void UserSigningOut()
        {
            // 0.5s待機後にサインアウト
            System.Threading.Thread.Sleep(500);
            SystemPower.SystemPowerControll(1);
        }

        // リブート
        public static void SystemReboot()
        {
            // 0.5s待機後にリブート
            System.Threading.Thread.Sleep(500);
            SystemPower.SystemPowerControll(2);
        }

        // スリープ(サスペンド)
        // スリープだけどう実装するかよくわからず，PowerState.Suspendにした
        public static void SystemSleep()
        {
            // 0.5s待機後にサスペンド
            System.Threading.Thread.Sleep(500);
            Application.SetSuspendState(PowerState.Suspend, false, false);
        }
    }
}
