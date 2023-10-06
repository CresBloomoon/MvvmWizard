using MvvmWizard.Classes;
using MvvmWizard.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace MvvmWizard.Controls {
    public partial class Wizard : Selector, INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public static readonly DependencyProperty SharedContextProperty = DependencyProperty.Register(nameof(SharedContext), typeof(Dictionary<string, object>), typeof(Wizard));
        public static readonly DependencyProperty FinishCommandProperty = DependencyProperty.Register(nameof(FinishCommand), typeof(ICommand), typeof(Wizard));
        public static readonly DependencyProperty CancelCommandProperty = DependencyProperty.Register(nameof(CancelCommand), typeof(ICommand), typeof(Wizard));
        public static readonly DependencyProperty InstallExecuteCommandProperty = DependencyProperty.Register(nameof(InstallExecuteCommand), typeof(ICommand), typeof(Wizard));
        public static readonly DependencyProperty UseCircularNavigationProperty = DependencyProperty.Register(nameof(UseCircularNavigation), typeof(bool), typeof(Wizard));
        public static readonly DependencyProperty NavigationBlockMinHeightProperty = DependencyProperty.Register(nameof(NavigationBlockMinHeight), typeof(double), typeof(Wizard));

        public static readonly DependencyProperty IsTransitionAnimationEnabledProperty = DependencyProperty.Register(nameof(IsTransitionAnimationEnabled), typeof(bool), typeof(Wizard));
        public static readonly DependencyProperty ForwardTransitionAnimationProperty = DependencyProperty.Register(nameof(ForwardTransitionAnimation), typeof(Storyboard), typeof(Wizard));
        public static readonly DependencyProperty BackwardTransitionAnimationProperty = DependencyProperty.Register(nameof(BackwardTransitionAnimation), typeof(Storyboard), typeof(Wizard));

        private static readonly Storyboard DefaultForwardTransitionAnimation;
        private static readonly Storyboard DefaultBackwardTransitionAnimation;

        private bool _isTransiting;

        /// <summary>
        /// 1つのViewで2度目のNextボタンを押したときに、次のステップに進むかどうかを示す値を取得または設定します。
        /// </summary>
        private bool _isSecondNextButtonEnabled = false;

        public TransitionController TransitionController { get; }
        public WizardStep CurrentStep => (WizardStep)this.SelectedItem;
        public int CurrentStepIndex => this.SelectedIndex;
        public int FirstStepIndex { get; } = 0;
        public int LastStepIndex => this.Items.Count - 1;
        public bool IsFirstStep => this.CurrentStepIndex == this.FirstStepIndex;
        public bool IsLastStep => this.CurrentStepIndex == this.LastStepIndex;

        static Wizard() {
            //本クラスのデフォルトスタイルキーを指定
            //スタイルキーは、WPFコントロールがどのスタイルを使用するかを示すもので、ここでは本クラス自体がそのデフォルトのスタイルキーとして設定している。
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Wizard), new FrameworkPropertyMetadata(typeof(Wizard)));

            //Storyboard(アニメーション）の初期化
            DefaultForwardTransitionAnimation = new Storyboard();

            //ページが前に進むときのアニメーションを設定。
            AnimationTimeline animationForward =
                new ThicknessAnimation {
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
                new ThicknessAnimation {
                    Duration = new Duration(TimeSpan.FromMilliseconds(300)),
                    From = new Thickness(-500, 0, 500, 0),
                    To = new Thickness(0),
                    DecelerationRatio = 0.9
                };

            Storyboard.SetTargetProperty(animationBackward, new PropertyPath("Margin"));
            DefaultBackwardTransitionAnimation.Children.Add(animationBackward);
            DefaultBackwardTransitionAnimation.Freeze();
        }

        public Wizard() {
            this.SharedContext = new Dictionary<string, object>();

            this.TransitionController = new TransitionController(
                this.ShowPreviousStep,
                () => this.ShowNextStep(false),
                () => this.ShowNextStep(true),
                x => this.FinishCommand?.Execute(x),
                c => this.CancelCommand?.Execute(c),
                () => this.SharedContext);

            this.Loaded += this.OnLoaded;
        }

        public Dictionary<string, object> SharedContext {
            get { return (Dictionary<string, object>)this.GetValue(SharedContextProperty); }
            set { SetValue(SharedContextProperty, value); }
        }

        public ICommand FinishCommand {
            get { return (ICommand)this.GetValue(FinishCommandProperty); }
            set { this.SetValue(FinishCommandProperty, value); }
        }

        public ICommand CancelCommand {
            get { return (ICommand)this.GetValue(CancelCommandProperty); }
            set { this.SetValue(CancelCommandProperty, value); }
        }

        public ICommand InstallExecuteCommand {
            get { return (ICommand)this.GetValue(InstallExecuteCommandProperty); }
            set { this.SetValue(InstallExecuteCommandProperty, value); }
        }

        public bool IsTransitionAnimationEnabled {
            get { return (bool)this.GetValue(IsTransitionAnimationEnabledProperty); }
            set { this.SetValue(IsTransitionAnimationEnabledProperty, value); }
        }

        public bool UseCircularNavigation {
            get { return (bool)this.GetValue(UseCircularNavigationProperty); }
            set { this.SetValue(UseCircularNavigationProperty, value); }
        }

        public double NavigationBlockMinHeight {
            get { return (double)this.GetValue(NavigationBlockMinHeightProperty); }
            set { this.SetValue(NavigationBlockMinHeightProperty, value); }
        }

        public Storyboard ForwardTransitionAnimation {
            get { return (Storyboard)this.GetValue(ForwardTransitionAnimationProperty); }
            set { this.SetValue(ForwardTransitionAnimationProperty, value); }
        }

        public Storyboard BackwardTransitionAnimation {
            get { return (Storyboard)this.GetValue(BackwardTransitionAnimationProperty); }
            set { this.SetValue(BackwardTransitionAnimationProperty, value); }
        }

        public bool IsTransiting {
            get { return this._isTransiting; }
            set {
                this._isTransiting = value;
                this.RaisePropertyChanged();
            }
        }

        public async void TryTransitTo(int transitToIndex, bool skippingStep = false) {
            try {
                this.IsTransiting = true;
                await this.TransitTo(transitToIndex, skippingStep);
            }
            finally {
                this.IsTransiting = false;
            }
        }

        protected override void OnSelectionChanged(SelectionChangedEventArgs e) {
            foreach (WizardStep step in e.RemovedItems.OfType<WizardStep>()) {
                step.IsSelected = false;
            }

            if (e.AddedItems.Count == 0) {
                base.OnSelectionChanged(e);
                return;
            }

            var selectedStep = (WizardStep)e.AddedItems[0];
            selectedStep.IsSelected = true;

            if (DesignerProperties.GetIsInDesignMode(this)) {
                return;
            }

            this.RaisePropertyChanged(nameof(this.CurrentStep));
            this.RaisePropertyChanged(nameof(this.IsFirstStep));
            this.RaisePropertyChanged(nameof(this.IsLastStep));

            base.OnSelectionChanged(e);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null) {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnLoaded(object sender, RoutedEventArgs e) {
            this.Loaded -= this.OnLoaded;

            this.TryTransitTo(this.FirstStepIndex);
        }

        private void ShowNextStep(bool skippingStep) {
            int navigateTo = this.CurrentStepIndex + 1;

            if (this.UseCircularNavigation && this.IsLastStep) {
                navigateTo = this.FirstStepIndex;
            }

            this.TryTransitTo(navigateTo, skippingStep);
        }

        private void ShowPreviousStep() {
            int navigateTo = this.CurrentStepIndex - 1;

            if (this.UseCircularNavigation && this.IsFirstStep) {
                navigateTo = this.LastStepIndex;
            }

            this.TryTransitTo(navigateTo);
        }

        private async Task TransitTo(int transitToIndex, bool skippingStep) {
            var transitionConext = new TransitionContext {
                SharedContext = this.SharedContext,
                TransitedFromStep = this.CurrentStepIndex,
                TransitToStep = transitToIndex,
                IsSkipAction = skippingStep,

                StepIndices =
                                               this.Items.Cast<WizardStep>().Select((x, i) => new { Name = x.Name, Index = i }).ToDictionary(
                                                   x => x.Index,
                                                   x => x.Name),
            };

            bool navigatingForward = !this.IsFirstStep && !this.IsLastStep && this.CurrentStepIndex < transitToIndex;
            navigatingForward |= this.IsFirstStep && transitToIndex != this.LastStepIndex;
            navigatingForward |= this.IsLastStep && transitToIndex == this.FirstStepIndex;

            /* Transit From (OnLoaded starts with "-1") */
            if (this.CurrentStepIndex >= this.FirstStepIndex) {
                var navigateFromView = (FrameworkElement)this.CurrentStep.Content;
                var navigateFrom = navigateFromView?.DataContext as ITransitionAware;

                if (navigateFrom != null) {
                    await navigateFrom.OnTransitedFrom(transitionConext);

                    if (transitionConext.AbortTransition) {
                        return;
                    }
                }

                this.CurrentStep.IsProcessed = !skippingStep && navigatingForward;
            }

            /* Non-circular and index was not changed (by user) -> Special cases for first and last steps */
            if (!this.UseCircularNavigation && transitionConext.TransitToStep == transitToIndex) {
                /* First step and navigating back. */
                if (this.IsFirstStep && transitToIndex < this.FirstStepIndex) {
                    return;
                }

                //InstallExecuteCommand実行
                if (CurrentStep != null && CurrentStep.IsInstallExecutionStep == true && navigatingForward == true) {
                    if (this._isSecondNextButtonEnabled == false) {
                        this.InstallExecuteCommand?.Execute(this.SharedContext);
                        CurrentStep.ForwardButtonTitle = "Next";
                        CurrentStep.BackButtonVisibility = Visibility.Collapsed;
                        CurrentStep.CancelButtonVisibility = Visibility.Collapsed;
                        this._isSecondNextButtonEnabled = true;
                        return;
                    }

                }

                //最後のステップで、前に進む場合
                if (this.IsLastStep && transitToIndex > this.LastStepIndex) {
                    this.FinishCommand?.Execute(this.SharedContext);
                    return;
                }
            }

            transitToIndex = transitionConext.TransitToStep;

            if (transitToIndex > this.LastStepIndex) {
                string message =
                    $"Failed navigating to the step with index {transitToIndex} (Index out of range, max index is {this.LastStepIndex})";

                throw new IndexOutOfRangeException(message);
            }

            Debug.WriteLine($"Navigating to index {transitToIndex}");

            WizardStep stepToSelect = (WizardStep)this.Items[transitToIndex];

            if (stepToSelect.Content == null && stepToSelect.ViewType != null) {
                if (WizardSettings.Instance.ViewResolver == null) {
                    throw new NullReferenceException("WizardSettings.Instance.ViewResolver is not set.");
                }

                stepToSelect.Content = WizardSettings.Instance.ViewResolver(stepToSelect.ViewType);
            }

            /* Transit To */
            var navigateToView = (FrameworkElement)stepToSelect.Content;
            stepToSelect.UnderlyingDataContext = navigateToView?.DataContext;
            this.SelectedItem = stepToSelect;

            if (this.IsTransitionAnimationEnabled) {
                Storyboard storyboard = navigatingForward
                                            ? (this.ForwardTransitionAnimation ?? DefaultForwardTransitionAnimation)
                                            : (this.BackwardTransitionAnimation ?? DefaultBackwardTransitionAnimation);

                navigateToView?.BeginStoryboard(storyboard);
            }

            var navigateTo = navigateToView?.DataContext as ITransitionAware;

            if (navigateTo != null) {
                /* Do only once. */
                if (navigateTo.TransitionController == null) {
                    navigateTo.TransitionController = this.TransitionController;
                }

                await navigateTo.OnTransitedTo(transitionConext);
            }
        }


    }
}
