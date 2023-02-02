using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using DI04_CitasClinicaLuisMontoyaRamirez.dto;
using DI04_CitasClinicaLuisMontoyaRamirez.logica;

namespace DI04_CitasClinicaLuisMontoyaRamirez;

public partial class PerfilDeCliente
{
    private readonly Cliente _cliente; // Cliente que se va a crear
    private readonly LogicaClientes _clientes; 
    private int _errores; // Contador de errores, no hace falta inicializarlo porque se inicializa a 0 por defecto.

    /**
     * Constructor de la clase PerfilDeCliente
     */
    public PerfilDeCliente(LogicaClientes logicaClientes)
    {
        InitializeComponent();
        _cliente = new Cliente(); // Inicializamos el cliente
        DataContext = _cliente; // Asignamos el cliente al DataContext
        _clientes = logicaClientes;
        
        BtnGuardar.IsEnabled = false; // Desactivamos el botón de guardar
    }
    
    /**
     * Método que se ejecuta cuando se pulsa el botón de guardar
     */
    private void BtnGuardar_OnClick(object sender, RoutedEventArgs e)
    {
        // Guardamos el DNI "manualmente", ya que no soy capaz de añadirlo al DataContext.
        _cliente.Dni = DniComponente.ContenidoDni.Text + DniComponente.LetraDni.Text;
        _clientes.AddCliente(_cliente);
        Close(); // Cerramos la ventana
    }
    
    /**
     * Método para la validación de los campos.
     */
    private void Validation_Error(object sender, ValidationErrorEventArgs e)
    {
        if (e.Action == ValidationErrorEventAction.Added)            
            _errores++;
        else
            _errores--;

        // Si no hay errores....
        if (_errores == 0)
        {
            // Comprobamos que el dni es correcto (no he sido capaz de validarlo de otra manera)
            // No es la mejor solución y no termina de funcionar bien.
            if (DniComponente.ContenidoDni.Text.Length == 8 && DniComponente.LetraDni.Text.Length == 1)
            {
                BtnGuardar.IsEnabled = true;
            }
        }
        else
        {
            BtnGuardar.IsEnabled = false;
        }
        //BtnGuardar.IsEnabled = _errores == 0; // si _errores vale 0 es True, y si vale 1 es False.
    }
    
    /**
     * OnLostFocus del nombre.
     */
    private void TbNombre_OnLostFocus(object sender, RoutedEventArgs e)
    {
        // Si hay error de validación...
        if (Validation.GetHasError(TbNombre))
        {
            MessageBox.Show("El nombre no tiene un formato correcto. Debe tener entre 3 y 20 carácteres.");
        }
        else
        {
            Validation.ClearInvalid(TbNombre.GetBindingExpression(TextBox.TextProperty));
        }
    }

    /**
     * OnLostFocus del apellido.
     */
    private void TbApellidos_OnLostFocus(object sender, RoutedEventArgs e)
    {
        if (Validation.GetHasError(TbApellidos))
        {
            MessageBox.Show("Los apellidos no tienen un formato correcto. Deben tener entre 3 y 20 carácteres.");
        }
    }
    
    /**
     * OnLostFocus del teléfono.
     */
    private void TbTelefono_OnLostFocus(object sender, RoutedEventArgs e)
    {
        if (Validation.GetHasError(TbTelefono))
        {
            MessageBox.Show("El teléfono no tiene un formato correcto. Debe tener 9 dígitos.");
        }
    }
    
    /**
     * OnLostFocus del email.
     */
    private void TbEmail_OnLostFocus(object sender, RoutedEventArgs e)
    {
        if (Validation.GetHasError(TbEmail))
        {
            MessageBox.Show("El email no tiene un formato correcto.");
        }
    }

    /**
     * OnLostFocus de la dirección.
     */
    private void TbDireccion_OnLostFocus(object sender, RoutedEventArgs e)
    {
        if (Validation.GetHasError(TbDireccion))
        {
            MessageBox.Show("La dirección no tiene un formato correcto. Debe tener entre 3 y 50 carácteres.");
        }
    }
    
    /**
     * OnTextChanged del nombre.
     * Necesito hacerlo para que no me salte el MessageBox de error al perder el foco si está correcto.
     */
    private void TbNombre_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        // si coincide con la expresión regular...
        if (Regex.IsMatch(TbNombre.Text, _cliente.GetRegexNombre()))
        {
            // ... borramos el error de validación.
            Validation.ClearInvalid(TbNombre.GetBindingExpression(TextBox.TextProperty));
        }
        else // si no..
        {
            // ... volvemos a marcar el error de validación. Seguro que hay alguna forma mejor de hacerlo.
            Validation.MarkInvalid(TbNombre.GetBindingExpression(TextBox.TextProperty),
                new ValidationError(new ExceptionValidationRule(),
                    "El nombre no tiene un formato correcto. Debe tener entre 3 y 20 carácteres."));
        }
    }

    /**
     * OnTextChanged de los apellidos.
     * Necesito hacerlo para que no me salte el MessageBox de error al perder el foco si está correcto.
     */
    private void TbApellidos_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        if (Regex.IsMatch(TbApellidos.Text, _cliente.GetRegexApellidos()))
        {
            Validation.ClearInvalid(TbApellidos.GetBindingExpression(TextBox.TextProperty));
        }
        else
        {
            Validation.MarkInvalid(TbApellidos.GetBindingExpression(TextBox.TextProperty),
                new ValidationError(new ExceptionValidationRule(),
                    "Los apellidos no tienen un formato correcto. Deben tener entre 3 y 20 carácteres."));
        }
    }

    /**
     * OnTextChanged del teléfono.
     * Necesito hacerlo para que no me salte el MessageBox de error al perder el foco si está correcto.
     */
    private void TbTelefono_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        if (Regex.IsMatch(TbTelefono.Text, _cliente.GetRegexTelefono()))
        {
            Validation.ClearInvalid(TbTelefono.GetBindingExpression(TextBox.TextProperty));
        }
        else
        {
            Validation.MarkInvalid(TbTelefono.GetBindingExpression(TextBox.TextProperty),
                new ValidationError(new ExceptionValidationRule(),
                    "El teléfono no tiene un formato correcto. Debe tener 9 dígitos."));
        }
    }

    /**
     * OnTextChanged del email.
     * Necesito hacerlo para que no me salte el MessageBox de error al perder el foco si está correcto.
     */
    private void TbEmail_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        if (Regex.IsMatch(TbEmail.Text, _cliente.GetRegexEmail()))
        {
            Validation.ClearInvalid(TbEmail.GetBindingExpression(TextBox.TextProperty));
        }
        else
        {
            Validation.MarkInvalid(TbEmail.GetBindingExpression(TextBox.TextProperty),
                new ValidationError(new ExceptionValidationRule(), "El email no tiene un formato correcto."));
        }
    }

    /**
     * OnTextChanged de la dirección.
     * Necesito hacerlo para que no me salte el MessageBox de error al perder el foco si está correcto.
     */
    private void TbDireccion_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        if (Regex.IsMatch(TbDireccion.Text, _cliente.GetRegexDireccion()))
        {
            Validation.ClearInvalid(TbDireccion.GetBindingExpression(TextBox.TextProperty));
        }
        else
        {
            Validation.MarkInvalid(TbDireccion.GetBindingExpression(TextBox.TextProperty),
                new ValidationError(new ExceptionValidationRule(),
                    "La dirección no tiene un formato correcto. Debe tener entre 3 y 50 carácteres."));
        }
    }
}