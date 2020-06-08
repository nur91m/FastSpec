using Caliburn.Micro;
using System.Windows;
using SpecUI.ViewModels;

namespace SpecUI
{
    public class Bootstrapper: BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();            
        }

        public void StartSpecApp()
        {
            IWindowManager wm = new WindowManager();
            wm.ShowDialog(new MainViewModel());
        }
        //protected override void OnStartup(object sender, StartupEventArgs e)
        //{
        //    DisplayRootViewFor<MainViewModel>();
        //}
    }
}
