using System.Windows;
using System.Windows.Input;
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
        private readonly LogicaClientes _logicaClientes;
        public MainWindow()
        {
            InitializeComponent();
            _logicaCitas = new LogicaCitas();
            _logicaClientes = new LogicaClientes();
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAddCita_Click(object sender, RoutedEventArgs e)
        {
            //CitasWindow citasWindow = new CitasWindow(_logicaCitas);
            CitasWindow citasWindow = new CitasWindow(_logicaCitas, _logicaClientes);
            citasWindow.ShowDialog(); // ShowDialog, modal, Show, no modal
        }

        private void btnVerCita_Click(object sender, RoutedEventArgs e)
        {
            TablaCitasWindow tablaCitasWindow = new TablaCitasWindow(_logicaCitas, _logicaClientes);
            tablaCitasWindow.Show(); // ShowDialog, modal, Show, no modal
        }

        private void PerfilDeCliente_OnClick(object sender, RoutedEventArgs e)
        {
            // Abre la ventana de perfil de cliente
            PerfilDeCliente perfilDeCliente = new PerfilDeCliente(_logicaClientes);
            perfilDeCliente.ShowDialog(); // Dialogo modal.
        }
        
        /* Atajos de teclado */
        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.N when Keyboard.IsKeyDown(Key.LeftCtrl):
                    btnAddCita_Click(sender, e);
                    break;
                case Key.V when Keyboard.IsKeyDown(Key.LeftCtrl):
                    btnVerCita_Click(sender, e);
                    break;
                case Key.C when Keyboard.IsKeyDown(Key.LeftCtrl):
                    PerfilDeCliente_OnClick(sender, e);
                    break;
            }
        }
    }
}