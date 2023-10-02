﻿using System;
using System.Windows;

namespace WizardDemo {
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application {
        [STAThread]
        public static void Main() {
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
