using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Front.src.Component.Activos.ActivosCreate;

//Este es el ViewModel vinculado a la vista, todo dentro de la carpeta.
class ActivosCreateViewModel : BindableBase
{
    public DelegateCommand<string> NavigateCommand { get; private set; }
    private readonly IRegionManager _regionManager;

    public string Codigo { get; set; }
    public string NombreActivo { get; set; }
    public string Categoria { get; set; }
    public string Odometro { get; set; }
    public string Patente { get; set; }
    public string AnoFabricacion { get; set; }
    public string IdentificacionEspecial { get; set; }
    public string Modelo { get; set; }
    public string NumeroMotor { get; set; }
    public string NumeroSerie { get; set; }
    public string Glosa { get; set; }

    public ActivosCreateViewModel(IRegionManager regionManager)
    {
        _regionManager = regionManager ?? throw new ArgumentNullException(nameof(regionManager));
        NavigateCommand = new DelegateCommand<string>(Navigate);
        // Inicialización de las propiedades del ViewModel
        InitializeProperties();
    }

    private void Navigate(string viewName)
    {

        _regionManager.RequestNavigate("MenuPrincipal", viewName);
    }

    private void InitializeProperties()
    {
        // Aquí puedes inicializar tus propiedades, por ejemplo:
        Codigo = "Algún valor inicial";
        // Y así sucesivamente para las demás propiedades
    }
}
