using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace DI04_CitasClinicaLuisMontoyaRamirez.dto;

public class Cliente : INotifyPropertyChanged, ICloneable, IDataErrorInfo
{
    // Atributos
    private string _email;
    private string _nombre;
    
    private const string ErCorreo = "[A-Z0-9a-z._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}";
    
    // Getters y Setters
    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            this.PropertyChanged(this, new PropertyChangedEventArgs("Email"));
        }
    }
    
    public string Nombre
    {
        get => _nombre;
        set
        {
            _nombre = value;
            this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
        }
    }
    
    // Constructor
    public Cliente(string email, string nombre)
    {
        this._email = email;
        this._nombre = nombre;
    }
    
    public object Clone()
    {
        return this.MemberwiseClone();
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
    
    public string Error => throw new NotImplementedException();

    public string this[string columnName]
    {
        get
        {
            string result = "";
            switch (columnName)
            {
                case "Email":
                    if (!Regex.IsMatch(this._email, ErCorreo))
                    {
                        result = "El correo no es válido";
                    }
                    break;
                case "Nombre":
                    if (this._nombre.Length < 3 || string.IsNullOrEmpty(this._nombre)) // por cambiar, valido el nombre por longitud.
                    {
                        result = "El nombre debe tener al menos 3 caracteres";
                    }
                    break;
            }
            return result;
        }
    }
    
    
    
}