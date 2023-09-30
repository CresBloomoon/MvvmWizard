namespace WizardDemo.Behaviors {
    using MahApps.Metro.Controls;
    using MvvmWizard.Controls;
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows;
    using System.Windows.Interactivity;

    public class ApplyValueToAllSummaryItemsBehavior : Behavior<FrameworkElement> {
        public static readonly DependencyProperty PropertyNameProperty = DependencyProperty.Register(
            nameof(PropertyName),
            typeof(string),
            typeof(ApplyValueToAllSummaryItemsBehavior));

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            nameof(Value),
            typeof(object),
            typeof(ApplyValueToAllSummaryItemsBehavior),
            new PropertyMetadata(ValuePropertyChangedCallback));

        private Wizard wizard;

        private PropertyDescriptor propertyToSet;

        public string PropertyName {
            get { return (string)this.GetValue(PropertyNameProperty); }
            set { this.SetValue(PropertyNameProperty, value); }
        }

        public object Value {
            get { return this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }

        protected override void OnAttached() {
            this.AssociatedObject.Loaded += this.TryFindWizard;
        }

        protected override void OnDetaching() {
        }

        protected virtual void OnValueChanged(object newValue) {
            foreach (WizardStep step in this.wizard.Items.OfType<WizardStep>()) {
                Type valueType = newValue.GetType();

                if (this.propertyToSet.PropertyType != valueType) {
                    if (this.propertyToSet.Converter.CanConvertFrom(valueType)) {
                        newValue = this.propertyToSet.Converter.ConvertFrom(newValue);
                    }
                }

                this.propertyToSet.SetValue(step, newValue);
            }
        }

        private static void ValuePropertyChangedCallback(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e) {
            var control = (ApplyValueToAllSummaryItemsBehavior)d;

            if (control.AssociatedObject == null) {
                return;
            }

            control.OnValueChanged(e.NewValue);
        }

        private void TryFindWizard(object sender, RoutedEventArgs routedEventArgs) {
            this.AssociatedObject.Loaded -= this.TryFindWizard;

            this.wizard = this.AssociatedObject.TryFindParent<Wizard>();
            this.propertyToSet = TypeDescriptor.GetProperties(typeof(WizardStep)).Find(this.PropertyName, false);
        }
    }
}