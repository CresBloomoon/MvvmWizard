using System.Collections.Generic;

namespace MvvmWizard.Classes
{
    public class TransitionContext
    {
        public Dictionary<string, object> SharedContext { get; internal set; }
        public Dictionary<int, string> StepIndices { get; internal set; }
        public int TransitedFromStep { get; internal set; }
        public int TransitToStep { get; set; }
        public bool AbortTransition { get; set; }
        public bool IsSkipAction { get; internal set; }
    }
}