using MvvmWizard.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Unity;

using SimpleDemoDialog = WizardDemo.Views.Simple.SimpleDemoDialog;

namespace WizardDemo.ViewModels
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            var unityContainer = new UnityContainer();
            WizardSettings.Instance.ViewResolver = type => unityContainer.Resolve(type);

            this.StartSimpleDemoCommand = new SimpleCommand(() => this.StartDemo(new SimpleDemoDialog()));
        }



        public ICommand StartSimpleDemoCommand { get; }

        public ICommand StartAdvancedDemoCommand { get; }

        private void StartDemo(Window dialog)
        {
            dialog.Owner = Application.Current.MainWindow;
            dialog.WindowState = WindowState.Normal;
            dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            dialog.Show();
            dialog.Activate();
        }
    }
}
