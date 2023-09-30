using System.Collections.Generic;

namespace MvvmWizard.Classes {

    /// <summary>
    /// ステップ間の遷移時に渡されるコンテキスト
    /// </summary>
    public class TransitionContext {

        /// <summary>
        /// 共有コンテキスト
        /// </summary>
        public Dictionary<string, object> SharedContext { get; internal set; }

        /// <summary>
        /// ステップのインデックスとステップ名を関連付けるディクショナリ
        /// </summary>
        public Dictionary<int, string> StepIndices { get; internal set; }

        /// <summary>
        /// 遷移元のステップのインデックス
        /// </summary>
        public int TransitedFromStep { get; internal set; }

        /// <summary>
        /// 遷移先のステップのインデックス
        /// </summary>
        public int TransitToStep { get; set; }

        /// <summary>
        /// 遷移を中止するかどうか
        /// </summary>
        public bool AbortTransition { get; set; }

        /// <summary>
        /// 遷移時にスキップアクションが行われたかどうか
        /// </summary>
        public bool IsSkipAction { get; internal set; }
    }
}