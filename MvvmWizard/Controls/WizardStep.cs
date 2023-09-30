namespace MvvmWizard.Controls {
    using MvvmWizard.Classes;
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;

    public partial class WizardStep : ButtonBase {
        public static readonly DependencyProperty ViewTypeProperty = DependencyProperty.Register(nameof(ViewType), typeof(Type), typeof(WizardStep));
        public static readonly DependencyProperty UnderlyingDataContextProperty = DependencyProperty.Register(nameof(UnderlyingDataContext), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty IsSelectedProperty = DependencyProperty.Register(nameof(IsSelected), typeof(bool), typeof(WizardStep));
        public static readonly DependencyProperty IsProcessedProperty = DependencyProperty.Register(nameof(IsProcessed), typeof(bool), typeof(WizardStep));

        static WizardStep() {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(WizardStep),
                new FrameworkPropertyMetadata(typeof(WizardStep)));
        }

        public WizardStep() {
            this.Command = new SimpleCommand(this.TransitToCurrent);
        }

        public Type ViewType {
            get { return (Type)this.GetValue(ViewTypeProperty); }
            set { this.SetValue(ViewTypeProperty, value); }
        }

        public object UnderlyingDataContext {
            get { return this.GetValue(UnderlyingDataContextProperty); }
            set { this.SetValue(UnderlyingDataContextProperty, value); }
        }

        public bool IsSelected {
            get { return (bool)this.GetValue(IsSelectedProperty); }
            set { this.SetValue(IsSelectedProperty, value); }
        }

        public bool IsProcessed {
            get { return (bool)this.GetValue(IsProcessedProperty); }
            set { this.SetValue(IsProcessedProperty, value); }
        }

        // 親となる "WizardTabControl" を取得するプロパティ
        public Wizard ParentTabControl {
            get {
                ItemsControl itemsControl = ItemsControl.ItemsControlFromItemContainer(this);

                /* If "Wizard" has dynamic steps (ItemsSource="{Binding ...}) 
                 * then "ItemsControl.ItemsControlFromItemContainer(this)" returns "ItemsControl" object,
                * which cannot be casted to "Wizard", but its templated parent is exactly what we want. */

                // "ItemsControl" から親の "Wizard" コントロールを取得
                var wizard = itemsControl as Wizard ?? itemsControl?.TemplatedParent as Wizard;

                return wizard;
            }
        }

        // カスタムコマンドの実行メソッド
        protected virtual void TransitToCurrent() {
            Wizard wizard = this.ParentTabControl;

            if (!wizard.AllowNavigationOnSummaryItemClick) {
                return;
            }

            int transitTo = wizard.Items.IndexOf(this);

            if (wizard.CurrentStepIndex != transitTo) {
                wizard.TryTransitTo(transitTo, true);
            }
        }
    }
}
