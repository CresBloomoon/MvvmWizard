using MvvmWizard.Classes;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WizardDemo.Views.Simple {
    /// <summary>
    /// SimpleDemoDialog.xaml の相互作用ロジック
    /// </summary>
    public partial class SimpleDemoDialog {
        public SimpleDemoDialog() {
            this.FinishCommand = new SimpleGenericCommand<Dictionary<string, object>>(FinishMethod);
            this.CloseCommand = new SimpleGenericCommand<Dictionary<string, object>>(CancelMethod);
            this.InstallExecuteCommand = new SimpleGenericCommand<Dictionary<string, object>>(InstallExecuteMethod);
            this.SharedContext = new Dictionary<string, object>();
            this.SharedContext["In"] = 88;

            this.InitializeComponent();
        }

        private void FinishMethod(Dictionary<string, object> obj) {
            this.Close();
        }

        private void CancelMethod(Dictionary<string, object> obj) {
            //後始末処理

            this.Close();
        }

        private void InstallExecuteMethod(Dictionary<string, object> obj) {
            //インストール処理

            //Start();
            Task.Delay(2000);
        }

        public ICommand FinishCommand { get; }

        public ICommand CloseCommand { get; }

        public ICommand InstallExecuteCommand { get; }

        public Dictionary<string, object> SharedContext { get; }
    }
}
