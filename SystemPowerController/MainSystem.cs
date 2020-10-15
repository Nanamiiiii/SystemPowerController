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
        // シャットダウン，サインアウト，リブートは3秒カウントあり
        // モニタ電源とスリープは即

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
            // TimeCountのインスタンス生成（0: シャットダウン）
            TimeCount tc = new TimeCount(0);

            // 0.5s待機後にカウント処理
            System.Threading.Thread.Sleep(500);
            
            tc.Run_Count();
        }

        // サインアウト
        public static void UserSigningOut()
        {
            // TimeCountのインスタンス生成（1: サインアウト）
            TimeCount tc = new TimeCount(1);

            // 0.5s待機後にカウント処理
            System.Threading.Thread.Sleep(500);

            tc.Run_Count();
        }

        // リブート
        public static void SystemReboot()
        {
            // TimeCountのインスタンス生成（2: サインアウト）
            TimeCount tc = new TimeCount(2);

            // 0.5s待機後にカウント処理
            System.Threading.Thread.Sleep(500);
            
            tc.Run_Count();
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
