using MvvmWizard.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardDemo.Classes;
using WizardDemo.Views.Simple;

namespace WizardDemo.ViewModels.Simple
{
    public class RegistrationSummaryViewModel : StepViewModelBase
    {
        private UserDetails userDetails;

        public UserDetails UserDetails
        {
            get { return this.userDetails; }
            set { this.SetProperty(ref this.userDetails, value); }
        }

        public override Task OnTransitedTo(TransitionContext transitionContext)
        {
            this.UserDetails = transitionContext.SharedContext["UserDetails"] as UserDetails;

            return base.OnTransitedTo(transitionContext);
        }
    }
}
