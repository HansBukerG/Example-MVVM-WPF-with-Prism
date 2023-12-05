using Prism.Regions;
using System;
using System.Windows;


namespace Transportes_Front
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IRegionManager _regionManager;

        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();


            var _regionManager = regionManager ?? throw new ArgumentNullException(nameof(regionManager));

            DataContext = new MainViewModel(regionManager);

            // Obtiene las dimensiones de la pantalla principal
            var screenWidth = SystemParameters.PrimaryScreenWidth;
            var screenHeight = SystemParameters.PrimaryScreenHeight;

            // Calcula el tamaño al 70% de la pantalla
            Width = screenWidth * 0.90;
            Height = screenHeight * 0.80;

            // Para centrar la ventana en la pantalla
            Left = (screenWidth - Width) / 2;
            Top = (screenHeight - Height) / 2;
        }
    }
}
