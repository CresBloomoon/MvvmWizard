using System;

namespace MvvmWizard.Classes {
    public sealed class TransitionController {
        public TransitionController(
            Action previousStepMethod,
            Action nextStepMethod,
            Action skipStepMethod,
            Action<object> finishMethod,
            Action<object> cancelMethod,
            Func<object> sharedContextFunc) {
            this.PreviousStepCommand = new SimpleCommand(previousStepMethod);
            this.NextStepCommand = new SimpleCommand(nextStepMethod);
            this.SkipStepCommand = new SimpleCommand(skipStepMethod);

            this.FinishCommand = new SimpleGenericCommand<object>(finishMethod, sharedContextFunc);
            this.CancelCommand = new SimpleGenericCommand<object>(cancelMethod, sharedContextFunc);
        }

        public SimpleCommand PreviousStepCommand { get; }
        public SimpleCommand NextStepCommand { get; }
        public SimpleCommand SkipStepCommand { get; }
        public SimpleGenericCommand<object> FinishCommand { get; }
        public SimpleGenericCommand<object> CancelCommand { get; }
    }
}
