using MVVM_StartProjekt.Models;
using Prism.Mvvm;
using MVVM_StartProjekt;
using MVVM_StartProjekt.ExtensionMethods;
using System.Data;
using System.Collections.Generic;

namespace MVVM_StartProjekt.ViewModels
{
    class ShellViewModel : BindableBase
    {


        /// <summary>
        /// DataBinding für MainWindow Titel
        /// </summary>
        public string Title { get; set; } = "MVVM - Konzept";
        

    }
}
