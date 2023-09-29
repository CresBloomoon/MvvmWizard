using MvvmWizard.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardDemo.Classes;

namespace WizardDemo.ViewModels.Simple
{
    public class RegistrationViewModel : StepViewModelBase
    {
        private bool isProcessing;

        private string firstName;

        private string lastName;

        private string email;

        public bool IsProcessing
        {
            get { return this.isProcessing; }
            set { this.SetProperty(ref this.isProcessing, value); }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.SetProperty(ref this.firstName, value);
                RaisePropertyChanged(nameof(MyIsEnabled));
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.SetProperty(ref this.lastName, value);
                RaisePropertyChanged(nameof(MyIsEnabled));
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                this.SetProperty(ref this.email, value);
                RaisePropertyChanged(nameof(MyIsEnabled));
            }
        }

        public bool MyIsEnabled => !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(lastName) &&
                                   !string.IsNullOrWhiteSpace(Email);

        /// <inheritdoc />
        public override async Task OnTransitedFrom(TransitionContext transitionContext)
        {
            if (transitionContext.TransitToStep < transitionContext.TransitedFromStep)
            {
                return;
            }

            transitionContext.SharedContext["UserDetails"] = new UserDetails(this.FirstName, this.LastName, this.Email);

            try
            {
                this.IsProcessing = true;
                await Task.Delay(3000);
            }
            finally
            {
                this.IsProcessing = false;
            }
        }
    }

}
