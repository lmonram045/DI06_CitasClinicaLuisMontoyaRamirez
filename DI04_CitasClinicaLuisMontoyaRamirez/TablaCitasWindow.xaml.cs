using System.Windows;
using DI04_CitasClinicaLuisMontoyaRamirez.logica;

namespace DI04_CitasClinicaLuisMontoyaRamirez;

public partial class TablaCitasWindow : Window
{

    private LogicaCitas _logicaCitas; 
    public TablaCitasWindow(LogicaCitas logicaCitas)
    {
        InitializeComponent();
        _logicaCitas = logicaCitas; // Inicializamos la logica de citas
        DataGridCitas.DataContext = logicaCitas; // Asignamos el contexto de datos
    }

    private void BtnVolver_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void BtnEliminar_Click(object sender, RoutedEventArgs e)
    {
        if (DataGridCitas.SelectedIndex != -1)
            _logicaCitas.eliminarCita(DataGridCitas.SelectedIndex);
        else
            MessageBox.Show("Debe seleccionar un item de la tabla", "Error selección", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}