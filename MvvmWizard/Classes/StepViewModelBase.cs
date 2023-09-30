using MvvmWizard.Interfaces;
using System.Threading.Tasks;

namespace MvvmWizard.Classes {
    public abstract class StepViewModelBase : BindableBase, ITransitionAware {
        public TransitionController TransitionController { get; set; }

        public virtual Task OnTransitedTo(TransitionContext transitionContext) {
            return Task.FromResult<object>(null);
        }

        public virtual Task OnTransitedFrom(TransitionContext transitionContext) {
            return Task.FromResult<object>(null);
        }
    }
}
