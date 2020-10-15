using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// シャットダウン,ログオフ等はWMIのWin32_OperatingSystemのWin32Shutdownで実装

namespace SystemPowerController
{
    class SystemPower
    {
        // 直接呼び出されるメソッド
        public static void SystemPowerControl(int Flag)
        {
            switch (Flag)
            {
                case 0: // シャットダウン
                    RunWin32Shutdown(Win32ShutdownFlags.Shutdown);
                    break;
                case 1: // サインアウト
                    RunWin32Shutdown(Win32ShutdownFlags.Logoff);
                    break;
                case 2: // 再起動
                    RunWin32Shutdown(Win32ShutdownFlags.Reboot);
                    break;
                default:
                    break;
            }
        }

        
        /// <summary>
        /// シャットダウン等の処理
        /// 参考(というか必要としてるそのものなのでほぼ丸コピ): https://johobase.com/wmi-os-shutdown-csharp/
        /// </summary>
        /// <param name="shutdownFlags">シャットダウン動作の種類　内容は以下のWin32ShutdownFlagsの定義参照</param>
        private static void Win32Shutdown(int shutdownFlags)
        {
            Thread thread = new Thread(() =>
            {
                //　Win32_OperatingSystemクラスの作成
                using (ManagementClass managementClass = new ManagementClass("Win32_OperatingSystem"))
                {
                    //　Win32_OperatingSystemオブジェクトの取得
                    managementClass.Get();
                    //　権限有効化
                    managementClass.Scope.Options.EnablePrivileges = true;
                    //　コレクション取得
                    ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();

                    //　WMIオブジェクト列挙
                    foreach (ManagementObject managementObject in managementObjectCollection)
                    {
                        //　InvokeMethodでWMIメソッド実行
                        managementObject.InvokeMethod(
                            "Win32Shutdown",
                            new object[] { shutdownFlags, 0 }
                            );
                        // リソース開放
                        managementObject.Dispose();
                    }
                }
            });
            // スレッドモデルをSTAに
            thread.SetApartmentState(ApartmentState.STA);
            // スレッド実行
            thread.Start();
            // スレッド終了待ち
            thread.Join();
        }

        // シャットダウン実行
        private static void RunWin32Shutdown(Win32ShutdownFlags shutdownFlags)
        {
            int flags = (int)shutdownFlags;
            Win32Shutdown(flags);
        }

        // シャットダウンフラグ
        enum Win32ShutdownFlags
        {
            // ログオフ（サインアウト）
            Logoff = 0,
            // シャットダウン
            Shutdown = 1,
            // 再起動
            Reboot = 2,
            // 電源オフ
            PowerOff = 8,
            // 強制的に実行
            Forced = 4
        }

    }
}
