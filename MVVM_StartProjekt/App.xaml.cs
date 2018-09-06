using MVVM_StartProjekt.App_Start;
using System.Windows;

namespace MVVM_StartProjekt
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new Bootstrapper().Run();
        }
    }
}
