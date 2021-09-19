using CubeAlgs.Repositories;
using CubeAlgs.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CubeAlgs
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //IKernel container = new StandardKernel();

        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);
        //    ConfigureContainer();
        //    ComposeObjects();
        //    Application.Current.MainWindow.Title = "Cube Algs";
        //    Application.Current.MainWindow.Show();
        //}

        //private void ConfigureContainer()
        //{
        //    // Repositories
        //    container.Bind<ISetRepository>().To<SetRepository>().InTransientScope();

        //    // Services
        //    container.Bind<ISetService>().To<SetService>().InTransientScope();
        //}

        //private void ComposeObjects()
        //{
        //    Application.Current.MainWindow = container.Get<MainWindow>();
        //}
    }
}
