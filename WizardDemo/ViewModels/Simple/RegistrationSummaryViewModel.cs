using MvvmWizard.Classes;
using System.Threading.Tasks;
using WizardDemo.Classes;

namespace WizardDemo.ViewModels.Simple {
    public class RegistrationSummaryViewModel : StepViewModelBase {
        private UserDetails userDetails;

        public UserDetails UserDetails {
            get { return this.userDetails; }
            set { this.SetProperty(ref this.userDetails, value); }
        }

        public override Task OnTransitedTo(TransitionContext transitionContext) {
            this.UserDetails = transitionContext.SharedContext["UserDetails"] as UserDetails;

            return base.OnTransitedTo(transitionContext);
        }
    }
}
