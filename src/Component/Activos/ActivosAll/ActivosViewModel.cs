using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Front.src.Component.Activos.ActivosAll;
//Este es el viewModel correspondiente a la vista ActivosView
internal class ActivosViewModel : BindableBase
{

    public DelegateCommand<string> NavigateCommand { get; private set; }
    private readonly IRegionManager _regionManager;

    public ActivosViewModel(IRegionManager regionManager)
    {

        _regionManager = regionManager ?? throw new ArgumentNullException(nameof(regionManager));
        NavigateCommand = new DelegateCommand<string>(Navigate);
    }

    private void Navigate(string viewName)
    {

        _regionManager.RequestNavigate("MenuPrincipal", viewName);
    }
}
