namespace SystemPowerController
{
    partial class IconWrapper
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconWrapper));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_MonitorOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_SystemSleep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_SystemShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "電源管理";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Open,
            this.toolStripMenuItem_Close,
            this.toolStripMenuItem_MonitorOff,
            this.toolStripMenuItem_SystemSleep,
            this.toolStripMenuItem_SystemShutdown});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 164);
            // 
            // toolStripMenuItem_Open
            // 
            this.toolStripMenuItem_Open.Name = "toolStripMenuItem_Open";
            this.toolStripMenuItem_Open.Size = new System.Drawing.Size(204, 32);
            this.toolStripMenuItem_Open.Text = "開く";
            // 
            // toolStripMenuItem_Close
            // 
            this.toolStripMenuItem_Close.Name = "toolStripMenuItem_Close";
            this.toolStripMenuItem_Close.Size = new System.Drawing.Size(204, 32);
            this.toolStripMenuItem_Close.Text = "終了";
            // 
            // toolStripMenuItem_MonitorOff
            // 
            this.toolStripMenuItem_MonitorOff.Name = "toolStripMenuItem_MonitorOff";
            this.toolStripMenuItem_MonitorOff.Size = new System.Drawing.Size(204, 32);
            this.toolStripMenuItem_MonitorOff.Text = "モニター電源OFF";
            // 
            // toolStripMenuItem_SystemSleep
            // 
            this.toolStripMenuItem_SystemSleep.Name = "toolStripMenuItem_SystemSleep";
            this.toolStripMenuItem_SystemSleep.Size = new System.Drawing.Size(204, 32);
            this.toolStripMenuItem_SystemSleep.Text = "スリープ";
            // 
            // toolStripMenuItem_SystemShutdown
            // 
            this.toolStripMenuItem_SystemShutdown.Name = "toolStripMenuItem_SystemShutdown";
            this.toolStripMenuItem_SystemShutdown.Size = new System.Drawing.Size(204, 32);
            this.toolStripMenuItem_SystemShutdown.Text = "シャットダウン";
            this.contextMenuStrip1.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Close;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_MonitorOff;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SystemSleep;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SystemShutdown;
    }
}
