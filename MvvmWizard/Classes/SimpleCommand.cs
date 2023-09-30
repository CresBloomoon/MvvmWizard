using System;
using System.Windows.Input;

namespace MvvmWizard.Classes {
    public sealed class SimpleCommand : ICommand {
        /// <summary>
        /// 実行用デリゲート
        /// </summary>
        private readonly Action _executeMethod;

        /// <summary>
        /// 実行可否判定用デリゲート
        /// </summary>
        private readonly Func<bool> _canExecuteMethod;

        public SimpleCommand(Action executeMethod) : this(executeMethod, () => true) {
        }

        public SimpleCommand(Action executeMethod, Func<bool> canExecuteMethod) {
            this._executeMethod = executeMethod ??
                throw new ArgumentNullException(nameof(executeMethod), "実行用デリゲートがnullです。");
            this._canExecuteMethod = canExecuteMethod ??
                throw new ArgumentNullException(nameof(canExecuteMethod), "実行可否判定用デリゲートがnullです。");
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute() {
            return this._canExecuteMethod();
        }

        public void Execute() {
            if (this.CanExecute()) {
                this._executeMethod();
            }
        }

        public bool CanExecute(object parameter) {
            return this.CanExecute();
        }

        public void Execute(object parameter) {
            this.Execute();
        }
    }
}
