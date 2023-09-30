using System;

namespace MvvmWizard.Classes {
    public class WizardSettings {
        public static readonly WizardSettings Instance = new WizardSettings();

        private WizardSettings() {
        }

        public Func<Type, object> ViewResolver { get; set; }
    }
}
