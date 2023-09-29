using MvvmWizard.Classes;
using System.Collections.Generic;
using System.Windows.Input;

namespace WizardDemo.Views.Simple
{
    /// <summary>
    /// SimpleDemoDialog.xaml の相互作用ロジック
    /// </summary>
    public partial class SimpleDemoDialog
    {
        public SimpleDemoDialog()
        {
            this.CloseCommand = new SimpleGenericCommand<Dictionary<string, object>>(ExecuteMethod);
            this.SharedContext = new Dictionary<string, object>();
            this.SharedContext["In"] = 88;

            this.InitializeComponent();
        }

        private void ExecuteMethod(Dictionary<string, object> obj)
        {
            this.Close();
        }

        public ICommand CloseCommand { get; }

        public Dictionary<string, object> SharedContext { get; }
    }
}
