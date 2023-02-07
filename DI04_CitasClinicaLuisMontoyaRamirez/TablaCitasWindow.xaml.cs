using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using DI04_CitasClinicaLuisMontoyaRamirez.dto;
using DI04_CitasClinicaLuisMontoyaRamirez.logica;

namespace DI04_CitasClinicaLuisMontoyaRamirez;

public partial class TablaCitasWindow : Window
{

    private LogicaCitas _logicaCitas; 
    private LogicaClientes _logicaClientes;
    public TablaCitasWindow(LogicaCitas logicaCitas, LogicaClientes logicaClientes)
    {
        InitializeComponent();
        _logicaCitas = logicaCitas; // Inicializamos la logica de citas
        _logicaClientes = logicaClientes; // Inicializamos la logica de clientes

        // Como quiero mostrar el nombre y apellidos del cliente, tengo que hacer una consulta.
        RellenarTabla();
    }

    /** 
     * Rellena la tabla con los datos de las citas y los clientes.
     * @param logicaCitas
     * @param logicaClientes
     */
    private void RellenarTabla()
    {
        ObservableCollection<Cita> listaCitas = _logicaCitas.listaCitas;
        ObservableCollection<Cliente> listaClientes = _logicaClientes.ListaClientes;

        var consulta = from citas in listaCitas
            join cliente in listaClientes on citas.Email equals cliente.Email
            select new
            {
                Dia = citas.Fecha.ToString("dd/MM/yyyy"),
                citas.Hora,
                cliente.Nombre,
                cliente.Apellidos,
                citas.Motivo,
                citas.Observaciones,
                FormaPago = citas.MetodoPago,
            };

        DataGridCitas.ItemsSource = consulta.ToList();
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