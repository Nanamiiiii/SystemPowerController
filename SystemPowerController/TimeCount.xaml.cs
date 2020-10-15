using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace SystemPowerController
{
    /// <summary>
    /// TimeCount.xaml の相互作用ロジック
    /// </summary>
    public partial class TimeCount : Window
    {
        private int todoFlag;
        private CancellationTokenSource countCancelToken;
        private bool CancellationFlag;

        private string[] WindowText =
        {
            "システムをシャットダウンします",
            "サインアウトします",
            "システムを再起動します"
        };
        
        public TimeCount(int Flag)
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
            todoFlag = Flag;
            textblock.Text = WindowText[Flag];
        }

        public void Run_Count()
        {
            this.Show();
            Progress_Count();
        }
        private async void Progress_Count()
        {
            // キャンセル処理用トークン
            countCancelToken = new CancellationTokenSource();
            var vm = this.DataContext as ViewModel;
            CancellationFlag = false;

            await Task.Run( async () =>
            {
                while(vm.Progress < 100)
                {

                    // 30msごとにインクリメント
                    await Task.Delay(30);
                    vm.Progress += 1;                   
                   
                    // キャンセルリクエストの確認
                    if (countCancelToken.IsCancellationRequested)
                    {
                        CancellationFlag = true;
                        return;
                    }
                }
                
            });

            this.Close();

            //シャットダウン，リブート，サインアウトでだけ使うのでSystemPowerControlの引数をそのまま
            if(!CancellationFlag) SystemPower.SystemPowerControl(todoFlag);

            // デバッグ用
            // if (!CancellationFlag) MessageBox.Show("Count End."); 
        }

        

        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            if(countCancelToken != null)
            {
                countCancelToken.Cancel();
            }
        }

        public class ViewModel : INotifyPropertyChanged
        {
            private int _Progress;
            
            public int Progress
            {
                get { return this._Progress; }
                set
                {
                    this._Progress = value;
                    this.NotifyProperyChanged(nameof(this.Progress));
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
            private void NotifyProperyChanged(string name)
            {
                this.PropertyChanged?.Invoke(
                    this,
                    new PropertyChangedEventArgs(name)
                    );
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (countCancelToken != null)
            {
                countCancelToken.Cancel();
            }
        }
    }
}
