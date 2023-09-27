using MvvmWizard.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace MvvmWizard.Controls
{
    public partial class Wizard : Selector, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static readonly DependencyProperty SharedContextProperty = DependencyProperty.Register(nameof(SharedContext), typeof(Dictionary<string, object>), typeof(Wizard));
        public static readonly DependencyProperty FinishCommandProperty = DependencyProperty.Register(nameof(FinishCommand), typeof(ICommand), typeof(Wizard));
        public static readonly DependencyProperty UseCircularNavigationProperty = DependencyProperty.Register(nameof(UseCircularNavigation), typeof(bool), typeof(Wizard));
        public static readonly DependencyProperty NavigationBlockMinHeightProperty = DependencyProperty.Register(nameof(NavigationBlockMinHeight), typeof(double), typeof(Wizard));

        public static readonly DependencyProperty IsTransitionAnimationEnabledProperty = DependencyProperty.Register(nameof(IsTransitionAnimationEnabled), typeof(bool), typeof(Wizard));
        public static readonly DependencyProperty ForwardTransitionAnimationProperty = DependencyProperty.Register(nameof(ForwardTransitionAnimation), typeof(Storyboard), typeof(Wizard));
        public static readonly DependencyProperty BackwardTransitionAnimationProperty = DependencyProperty.Register(nameof(BackwardTransitionAnimation), typeof(Storyboard), typeof(Wizard));

        private static readonly Storyboard DefaultForwardTransitionAnimation;
        private static readonly Storyboard DefaultBackwardTransitionAnimation;

        private bool _isTransiting;

        public TransitionController TransitionController { get; }
        public WizardStep CurrentStep => (WizardStep)this.SelectedItem;
        public int CurrentStepIndex => this.SelectedIndex;
        public int FirstStepIndex { get; } = 0;
        public int LastStepIndex => this.Items.Count - 1;
        public bool IsFirstStep => this.CurrentStepIndex == this.FirstStepIndex;
        public bool IsLastStep => this.CurrentStepIndex == this.LastStepIndex;

        static Wizard()
        {
            //本クラスのデフォルトスタイルキーを指定
            //スタイルキーは、WPFコントロールがどのスタイルを使用するかを示すもので、ここでは本クラス自体がそのデフォルトのスタイルキーとして設定している。
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Wizard), new FrameworkPropertyMetadata(typeof(Wizard)));

            //Storyboard(アニメーション）の初期化
            DefaultForwardTransitionAnimation = new Storyboard();

            //ページが前に進むときのアニメーションを設定。
            AnimationTimeline animationForward =
                new ThicknessAnimation
                {
                    //アニメーションの持続時間
                    Duration = new Duration(TimeSpan.FromMilliseconds(300)),
                    //アニメーションの開始位置
                    From = new Thickness(500, 0, -500, 0),
                    //アニメーションの終了位置
                    To = new Thickness(0),
                    //アニメーションの減速率
                    DecelerationRatio = 0.9
                };

            //アニメーションの対象プロパティを設定。今回はMarginプロパティを設定している。
            Storyboard.SetTargetProperty(animationForward, new PropertyPath("Margin"));
            //先ほど設定したアニメーションをStoryboardに追加
            DefaultForwardTransitionAnimation.Children.Add(animationForward);
            //Storyboardを凍結。これにより、アニメーションの設定を変更できなくなる。パフォーマンス向上のために必要。
            DefaultForwardTransitionAnimation.Freeze();

            //ページが後ろに戻るときのアニメーションを設定。あとは前に進むときと同じ。
            DefaultBackwardTransitionAnimation = new Storyboard();
            AnimationTimeline animationBackward =
                new ThicknessAnimation
                {
                    Duration = new Duration(TimeSpan.FromMilliseconds(300)),
                    From = new Thickness(-500, 0, 500, 0),
                    To = new Thickness(0),
                    DecelerationRatio = 0.9
                };

            Storyboard.SetTargetProperty(animationBackward, new PropertyPath("Margin"));
            DefaultBackwardTransitionAnimation.Children.Add(animationBackward);
            DefaultBackwardTransitionAnimation.Freeze();
        }

        public Wizard()
        {
            this.SharedContext = new Dictionary<string, object>();

            this.TransitionController = new TransitionController(
                this.ShowPreviousStep,

                )
        }

        public Dictionary<string, object> SharedContext
        {
            get { return (Dictionary<string, object>)this.GetValue(SharedContextProperty); }
            set { SetValue(SharedContextProperty, value); }
        }

        public ICommand FinishCommand
        {
            get { return (ICommand)this.GetValue(FinishCommandProperty); }
            set { this.SetValue(FinishCommandProperty, value); }
        }

        public bool IsTransitionAnimationEnabled
        {
            get { return (bool)this.GetValue(IsTransitionAnimationEnabledProperty); }
            set { this.SetValue(IsTransitionAnimationEnabledProperty, value); }
        }

        public bool UseCircularNavigation
        {
            get { return (bool)this.GetValue(UseCircularNavigationProperty); }
            set { this.SetValue(UseCircularNavigationProperty, value); }
        }

        public double NavigationBlockMinHeight
        {
            get { return (double)this.GetValue(NavigationBlockMinHeightProperty); }
            set { this.SetValue(NavigationBlockMinHeightProperty, value); }
        }

        public Storyboard ForwardTransitionAnimation
        {
            get { return (Storyboard)this.GetValue(ForwardTransitionAnimationProperty); }
            set { this.SetValue(ForwardTransitionAnimationProperty, value); }
        }

        public Storyboard BackwardTransitionAnimation
        {
            get { return (Storyboard)this.GetValue(BackwardTransitionAnimationProperty); }
            set { this.SetValue(BackwardTransitionAnimationProperty, value); }
        }

        public bool IsTransiting
        {
            get { return this._isTransiting; }
            set
            {
                this._isTransiting = value;
                this.RaisePropertyChanged();
            }
        }

    }
}
