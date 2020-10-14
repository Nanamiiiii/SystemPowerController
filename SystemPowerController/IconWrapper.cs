using System;
using System.ComponentModel;
using System.Windows;

namespace SystemPowerController
{
    public partial class IconWrapper : Component
    {
        public IconWrapper()
        {
            this.InitializeComponent(); //初期化

            //コンテキストメニューの設定
            this.toolStripMenuItem_Open.Click += this.toolStripMenuItem_Open_Click;
            this.toolStripMenuItem_Close.Click += this.toolStripMenuItem_Close_Click;
            this.toolStripMenuItem_MonitorOff.Click += this.toolStripMenuItem_MonitorOff_Click;
            this.toolStripMenuItem_SystemSleep.Click += this.toolStripMenuItem_SystemSleep_Click;
            this.toolStripMenuItem_SystemShutdown.Click += this.toolStripMenuItem_SystemShutdown_Click;
        }

        public IconWrapper(IContainer container)
        {
            container.Add(this);

            this.InitializeComponent();
        }

        //ウィンドウ表示
        private void toolStripMenuItem_Open_Click(Object sender, EventArgs e)
        {
            MainWindow v = new MainWindow();
            v.Show();
        }

        //アプリケーション終了
        private void toolStripMenuItem_Close_Click(Object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        //モニター出力off
        private void toolStripMenuItem_MonitorOff_Click(Object sender, EventArgs e)
        {
            //未実装
            
        }

        //システムをスリープ
        private void toolStripMenuItem_SystemSleep_Click(Object sender, EventArgs e)
        {
            //未実装
            
        }

        //システムをシャットダウン
        private void toolStripMenuItem_SystemShutdown_Click(Object sender, EventArgs e)
        {
            //未実装
           
        }
    }
}
