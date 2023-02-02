using System.Windows;
using DI04_CitasClinicaLuisMontoyaRamirez.logica;

namespace DI04_CitasClinicaLuisMontoyaRamirez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// TODO: AÑADIR TOOLTIP A TODO!!!!!
    /// TODO: si da tiempo, boton para añadir clientes
    
    public partial class MainWindow
    {
        private readonly LogicaCitas _logicaCitas;
        public MainWindow()
        {
            InitializeComponent();
            _logicaCitas = new LogicaCitas();
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAddCita_Click(object sender, RoutedEventArgs e)
        {
            CitasWindow citasWindow = new CitasWindow(_logicaCitas);
            citasWindow.ShowDialog(); // ShowDialog, modal, Show, no modal
        }

        private void btnVerCita_Click(object sender, RoutedEventArgs e)
        {
            TablaCitasWindow tablaCitasWindow = new TablaCitasWindow(_logicaCitas);
            tablaCitasWindow.Show(); // ShowDialog, modal, Show, no modal
        }
    }
}