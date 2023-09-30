using MvvmWizard.Classes;
using System.Threading.Tasks;

namespace MvvmWizard.Interfaces {
    public interface ITransitionAware {
        TransitionController TransitionController { get; set; }

        Task OnTransitedTo(TransitionContext transitionContext);

        Task OnTransitedFrom(TransitionContext transitionContext);
    }
}
