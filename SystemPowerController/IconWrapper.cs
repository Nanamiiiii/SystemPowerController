using System;
using System.ComponentModel;
using System.Windows;


namespace SystemPowerController
{
    public partial class IconWrapper : Component
    {
        public IconWrapper()
        {
            this.InitializeComponent(); // 初期化           

            // コンテキストメニューの設定
            this.toolStripMenuItem_Open.Click += this.toolStripMenuItem_Open_Click;
            this.toolStripMenuItem_Close.Click += this.toolStripMenuItem_Close_Click;
            this.toolStripMenuItem_MonitorOff.Click += this.toolStripMenuItem_MonitorOff_Click;
            this.toolStripMenuItem_SystemSleep.Click += this.toolStripMenuItem_SystemSleep_Click;
            this.toolStripMenuItem_SystemShutdown.Click += this.toolStripMenuItem_SystemShutdown_Click;
            this.toolStripMenuItem_SystemReboot.Click += this.toolStripMenuItem_SystemReboot_Click;
            this.toolStripMenuItem_UserSigningout.Click += this.toolStripMenuItem_UserSigningOut_Click;
        }

        public IconWrapper(IContainer container)
        {
            container.Add(this);

            this.InitializeComponent();
        }

        // ウィンドウ表示
        private void toolStripMenuItem_Open_Click(Object sender, EventArgs e)
        {
            MainWindow v = new MainWindow();
            v.Show();
        }

        // アプリケーション終了
        private void toolStripMenuItem_Close_Click(Object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        // モニター出力off
        private void toolStripMenuItem_MonitorOff_Click(Object sender, EventArgs e)
        {
            // MainSystemクラスからPowerOffメソッドの呼び出し
            MainSystem.MonitorPowerOff();
        }

        // システムをスリープ
        private void toolStripMenuItem_SystemSleep_Click(Object sender, EventArgs e)
        {
            // MainSystemからSystemSleepメソッドの呼び出し
            MainSystem.SystemSleep();
        }

        // システムをシャットダウン
        private void toolStripMenuItem_SystemShutdown_Click(Object sender, EventArgs e)
        {
            // MainSystemからSystemShutdownメソッドを呼び出し
            MainSystem.SystemShutdown();
           
        }

        // システムを再起動
        private void toolStripMenuItem_SystemReboot_Click(Object sender, EventArgs e)
        {
            // MainSystemからSystemRebootメソッドを呼び出し
            MainSystem.SystemReboot();
        }

        // サインアウト
        private void toolStripMenuItem_UserSigningOut_Click(Object sender, EventArgs e)
        {
            // MainSystemからUserSigningOutメソッドを呼び出し
            MainSystem.UserSigningOut();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
