using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace DI04_CitasClinicaLuisMontoyaRamirez.dto;

public class Cliente : INotifyPropertyChanged, ICloneable, IDataErrorInfo
{
    // Atributos
    private string _nombre;
    private string _apellidos;
    private string _telefono;
    private string _email;
    private string _dni;
    private string _direccion;
    private string _fechaNacimiento;
    private string _observaciones;

    // Expresiones regulares para comprobaciones.
    private const string RegexNombre = @"^[a-zA-Z ]{3,20}$";
    private const string RegexApellidos = @"^[a-zA-Z ]{3,20}$";
    private const string RegexTelefono = @"^[0-9]{9}$";
    private const string RegexEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
    private const string RegexDni = @"^[0-9]{8}[A-Z]$";
    private const string RegexDireccion = @"^[a-zA-Z0-9, ]{3,50}$";
    
    // Getters para Regex
    public string GetRegexNombre() => RegexNombre;
    public string GetRegexApellidos() => RegexApellidos;
    public string GetRegexTelefono() => RegexTelefono;
    public string GetRegexEmail() => RegexEmail;
    public string GetRegexDireccion() => RegexDireccion;


    // Getters y Setters
    public string Nombre
    {
        get => _nombre;
        set
        {
            _nombre = value;
            // Notifica a la vista de que se ha cambiado el valor de la propiedad.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nombre))); 
        }
    }
    
    public string Apellidos
    {
        get => _apellidos;
        set
        {
            _apellidos = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Apellidos)));
        }
    }
    
    public string Telefono
    {
        get => _telefono;
        set
        {
            _telefono = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Telefono)));
        }
    }
    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
        }
    }
    
    public string Dni
    {
        get => _dni;
        set
        {
            _dni = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Dni)));
        }
    }
    
    public string Direccion
    {
        get => _direccion;
        set
        {
            _direccion = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Direccion)));
        }
    }
    
    public string FechaNacimiento
    {
        get => _fechaNacimiento;
        set
        {
            _fechaNacimiento = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FechaNacimiento)));
        }
    }
    
    public string Observaciones
    {
        get => _observaciones;
        set
        {
            _observaciones = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Observaciones)));
        }
    }
 
    
    /**
     * Constructor por defecto. Inicializa todas las variables a vacío.
     */
    public Cliente()
    {
        _nombre = "";
        _apellidos = "";
        _telefono = "";
        _email = "";
        _dni = "";
        _direccion = "";
        _fechaNacimiento = "";
        _observaciones = "";
    }
    
    /**
     * Constructor con parámetros.
     */
    public Cliente(string nombre, string apellidos, string telefono, string email, string dni, string direccion,
        string fechaNacimiento, string observaciones)
    {
        _nombre = nombre;
        _apellidos = apellidos;
        _telefono = telefono;
        _email = email;
        _dni = dni;
        _direccion = direccion;
        _fechaNacimiento = fechaNacimiento;
        _observaciones = observaciones;
    }
    
    /**
     * Se utiliza para crear una copia superficial del objeto.
     * Utiliza  MemberwiseClone() para crear una copia de todos los campos del objeto actual.
     * @return Copia del objeto actual.
     */
    public object Clone()
    {
        return MemberwiseClone();
    }
    
    // Evento que se lanza cuando se modifica una propiedad.
    // Se utiliza en l para notificar a la vista de que se ha modificado una propiedad.
    public event PropertyChangedEventHandler? PropertyChanged;
    
    // Necesito implementar este método debido a la interfaz IDataErrorInfo. No se utiliza en la aplicación, pero
    // es necesario para poder validar los errores en la vista.
    public string Error => throw new NotImplementedException();

    /**
     * Método que se utiliza para validar los campos del formulario.
     * @param columnName Nombre de la columna que se quiere validar.
     * @return Mensaje de error si el campo no es válido, null si es válido.
     */
    public string this[string columnName]
    {
        get
        {
            string result = "";
            switch (columnName)
            { 
                case "Nombre":
                    if (!Regex.IsMatch(this.Nombre, RegexNombre))
                    {
                        result = "El nombre no tiene formato correcto";
                    }
                    break;
                
                case "Apellidos":
                    if (!Regex.IsMatch(this.Apellidos, RegexApellidos))
                    {
                        result = "Los apellidos no tienen formato correcto";
                    }
                    break;
                
                case "Telefono":
                    if (!Regex.IsMatch(this.Telefono, RegexTelefono))
                    {
                        result = "El telefono no tiene formato correcto";
                    }
                    break;
                
                case "Email":
                    if (!Regex.IsMatch(this._email, RegexEmail))
                    {
                        result = "El email no tiene formato correcto";
                    }
                    break;
                
                case "Dni":
                    if (!Regex.IsMatch(this.Dni, RegexDni))
                    {
                        result = "El DNI no es correcto";
                    }
                    break;
                
                case "Direccion":
                    if (!Regex.IsMatch(this.Direccion, RegexDireccion))
                    {
                        result = "La direccion no tiene formato correcto";
                    }
                    break;
                case "FechaNacimiento":
                    if (String.IsNullOrWhiteSpace(FechaNacimiento))
                    {   
                        result = "La fecha de nacimiento no es correcta";
                    }
                    break;
            }
            return result;
        }
    }

}