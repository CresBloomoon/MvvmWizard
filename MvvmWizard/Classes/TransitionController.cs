using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWizard.Classes
{
    public sealed class TransitionController
    {
        public TransitionController(
            Action previousStepMethod,
            Action nextStepMethod,
            Action skipStepMethod,
            Action<object> finishMethod,
            Func<object> sharedContextFunc)
        {
            this.PreviousStepCommand = new SimpleCommand(previousStepMethod);
            this.NextStepCommand = new SimpleCommand(nextStepMethod);
            this.SkipStepCommand = new SimpleCommand(skipStepMethod);

            this.FinishCommand = new SimpleGenericCommand<object>(finishMethod, sharedContextFunc);
        }

        public SimpleCommand PreviousStepCommand { get; }
        public SimpleCommand NextStepCommand { get; }
        public SimpleCommand SkipStepCommand { get; }
        public SimpleGenericCommand<object> FinishCommand { get; }
    }
}
