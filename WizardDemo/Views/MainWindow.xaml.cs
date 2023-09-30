using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace WizardDemo {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            // コンストラクタの初期化
            this.InitializeComponent();

            // カスタムアニメーションのStoryboardを作成
            var customAnimation = new Storyboard();

            // 前進アニメーション用のDoubleAnimationを作成
            AnimationTimeline animationForward =
                new DoubleAnimation() {
                    // アニメーションの持続時間
                    Duration = new Duration(TimeSpan.FromMilliseconds(2000)),
                    // 開始値
                    From = 0.2,
                    // 終了値
                    To = 1.0,
                    // 減速率
                    DecelerationRatio = 0.9
                };

            // アニメーションの対象プロパティを設定（Opacityプロパティに対するアニメーション）
            Storyboard.SetTargetProperty(animationForward, new PropertyPath("Opacity"));

            // アニメーションをStoryboardに追加
            customAnimation.Children.Add(animationForward);

            // 以下の行は、Wizard1コントロールのForwardTransitionAnimationプロパティにカスタムアニメーションを設定するためのもので、コメントアウトされています。
            // this.Wizard1.ForwardTransitionAnimation = customAnimation;

            // 未処理の例外をキャッチするイベントハンドラを設定
            App.Current.DispatcherUnhandledException += CurrentOnDispatcherUnhandledException;

            // ドメイン全体の未処理の例外をキャッチするイベントハンドラを設定
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
        }

        // ドメイン全体の未処理の例外が発生したときのイベントハンドラ
        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e) {
            // 未処理の例外メッセージを表示
            MessageBox.Show($"Error: {e.ExceptionObject}");
        }

        // UIスレッドでの未処理の例外が発生したときのイベントハンドラ
        private void CurrentOnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) {
            // 未処理の例外メッセージを表示
            MessageBox.Show($"Error: {e.Exception}");

            // 例外が処理されたことをマーク（アプリケーションを続行できるようにする）
            e.Handled = true;
        }
    }
}
