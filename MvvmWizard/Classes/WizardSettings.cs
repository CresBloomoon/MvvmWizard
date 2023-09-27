using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWizard.Classes
{
    public class WizardSettings
    {
        public static readonly WizardSettings Instance = new WizardSettings();

        private WizardSettings()
        {
        }

        public Func<Type, object> ViewResolver { get; set; }
    }
}
