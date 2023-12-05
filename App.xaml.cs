using Prism.Ioc;
using Prism.Regions;
using Prism.Unity;
using System.ComponentModel;
using System.Windows;
using Transportes_Front.src.Component.Activos.ActivosAll;
using Transportes_Front.src.Component.Activos.ActivosCreate;
using Transportes_Front.src.Component.Insumos.InsumosAll;

namespace Transportes_Front;

public partial class App : PrismApplication
{


    protected override void OnInitialized()
    {
        base.OnInitialized();
    }

    protected override Window CreateShell()
    {
        var regionManager = Container.Resolve<IRegionManager>();
        return new MainWindow(regionManager);
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        //Aqui se registran las rutas, tanto la vista, como su ViewModel
        containerRegistry.RegisterForNavigation<ActivosView, ActivosViewModel>("ActivosView"); 
        containerRegistry.RegisterForNavigation<ActivosCreateView, ActivosCreateViewModel>("ActivosCreate");
        containerRegistry.RegisterForNavigation<InsumosAll, InsumosAllViewModel>("InsumosAll");
    }
}
