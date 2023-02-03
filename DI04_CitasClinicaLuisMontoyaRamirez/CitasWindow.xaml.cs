using System;
using System.Windows;
using System.Windows.Controls;
using DI04_CitasClinicaLuisMontoyaRamirez.dto;
using DI04_CitasClinicaLuisMontoyaRamirez.logica;

namespace DI04_CitasClinicaLuisMontoyaRamirez;

public partial class CitasWindow : Window
{
    private Cita _cita;
    private int _posicion;
    private bool _modificar;
    private LogicaClientes _clientes;
    private LogicaCitas _citas;
    private int _errores = 0;
      
    /**
     * Constructor para añadir una cita
     */
    public CitasWindow(LogicaCitas citas)
    {
        _clientes = new LogicaClientes();
        InitializeComponent();
        AddDatosComponentes(); // Creo este metodo para meter los datos a los combobox.
        _modificar = false;
        _cita = new Cita();
        DataContext = _cita;
        _citas = citas;
    }
    
    public CitasWindow(LogicaCitas citas, LogicaClientes clientes)
    {
        _clientes = clientes;
        InitializeComponent();
        AddDatosComponentes(); // Creo este metodo para meter los datos a los combobox.
        _modificar = false;
        _cita = new Cita();
        DataContext = _cita;
        _citas = citas;
    }

    /**
     * Constructor para modificar una cita
     */
    public CitasWindow(LogicaCitas citas, Cita cita, int posicion)
    {
        InitializeComponent();
        _modificar = true;
        _citas = citas;
        _cita = cita;
        _posicion = posicion;
        DataContext = _cita;
    }

    /**
     * Metodo para añadir datos a los componentes necesarios.
     */
    private void AddDatosComponentes()
    {
        // Rellenamos las horas, de 9 a 20.
        for (int i = 9; i <= 20; i++)
        {
            CbHora.Items.Add(i); 
        }
        CbHora.SelectedIndex = 1; // Seleccionamos la hora 10 por defecto.
        CbPaciente.SelectedIndex = 0; // Seleccionamos el primer paciente por defecto.

        // Rellenamos el CbPaciente con los clientes de la lista de clientes
        foreach (var cliente in _clientes.ListaClientes)
        {
            CbPaciente.Items.Add(cliente.Email);
        }
        
        // Rellenamos el CbMetodoPago con los metodos de pago.
        CbMetodoPago.Items.Add("Tarjeta");
        CbMetodoPago.Items.Add("Efectivo");
        CbMetodoPago.SelectedIndex = 0; // Seleccionamos Tarjeta por defecto.
    }

    private void BtnAddCita_OnClick(object sender, RoutedEventArgs e)
    {
        if(_modificar) // Si modificar esta a true, llamamos a modificar cita y si no, a a añadir cita.
        {
            _citas.modCita(_cita, _posicion);
        }
        else
        {
            _citas.addCita(_cita);
        }
        this.Close();
    }

    private void BtnCancelCita_OnClick(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
    
    private void Validation_Error(object sender, ValidationErrorEventArgs e)
    {
        if (e.Action == ValidationErrorEventAction.Added)            
            _errores++;
        else
            _errores--;

        if (_errores == 0)
            BtnAddCita.IsEnabled = true;
        else
            BtnAddCita.IsEnabled = false;

    }

    private void TbMotivo_OnLostFocus(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TbMotivo.Text))
        {
            MessageBox.Show("El motivo no puede estar vacio", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    

    private void DpFecha_OnCalendarClosed(object sender, RoutedEventArgs e)
    {
        if (DpFecha.SelectedDate < DateTime.Now)
        {
            MessageBox.Show("La fecha no puede ser anterior a la actual", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}