using MvvmWizard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWizard.Classes
{
    public abstract class StepViewModelBase : BindableBase, ITransitionAware
    {
        /// <inheritdoc />
        public TransitionController TransitionController { get; set; }

        /// <inheritdoc />
        public virtual Task OnTransitedTo(TransitionContext transitionContext)
        {
            return Task.FromResult<object>(null);
        }

        /// <inheritdoc />
        public virtual Task OnTransitedFrom(TransitionContext transitionContext)
        {
            return Task.FromResult<object>(null);
        }
    }
}
