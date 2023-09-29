using System;
using System.Data;
using System.Windows.Input;

namespace MvvmWizard.Classes
{
    public class SimpleGenericCommand<TParameter> : ICommand
    {
        private readonly Action<TParameter> executeMethod;
        private readonly Func<bool> canExecuteMethod;
        private readonly Func<TParameter> defaultParameterFunc;

        public SimpleGenericCommand(Action<TParameter> executeMethod,
                                    Func<TParameter> defaultParameterFunc = null)
            : this(executeMethod, () => true, defaultParameterFunc)
        {
        }

        public SimpleGenericCommand(
            Action<TParameter> executeMethod,
            Func<bool> canExecuteMethod,
            Func<TParameter> defaultParameterFunc = null)
        {
            this.executeMethod = executeMethod ?? throw new ArgumentNullException(nameof(executeMethod), "Execute method cannot be null");
            this.canExecuteMethod = canExecuteMethod ?? throw new ArgumentNullException(nameof(canExecuteMethod), "CanExecute method cannot be null");
            this.defaultParameterFunc = defaultParameterFunc;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute()
        {
            return this.canExecuteMethod();
        }

        public void Execute()
        {
            if (defaultParameterFunc is null)
            {
                this.Execute(null);
                return;
            }

            this.Execute(defaultParameterFunc());
        }

        public void Execute(TParameter parameter)
        {
            if (this.CanExecute())
            {
                this.executeMethod(parameter);
            }
        }

        public void Execute(object parameter)
        {
            this.Execute((TParameter)parameter);
        }

        public bool CanExecute(object parameter)
        {
            return this.CanExecute();
        }
    }
}