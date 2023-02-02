using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace DI04_CitasClinicaLuisMontoyaRamirez.dto;

/**
 * Implementamos las interfaces INotifyPropertyChanged y IDataErrorInfo para poder notificar a la vista de los cambios
 * en los datos y para poder validar los datos introducidos por el usuario, y la interfaz ICloneable para poder clonar
 * objetos de esta clase, para poder trabajar con copias de los mismos al editarlos.
 */
public class Cita : INotifyPropertyChanged, ICloneable, IDataErrorInfo
{
   // Atributos de la clase
   private DateTime _fecha; 
   private int _hora;
   private string _motivo;
   private string _observaciones;
   private string _metodoPago;
   // !!!!!!!!!! IMPORTANTE, EL EMAIL, SERIA EL ID DEL PACIENTE. POR AHORA NO GESTIONARÉ ID DE RESERVA. !!!!!!!!!!!!!!!!!!!!!!!!
   private string _email; // Con el email identifico al paciente, ya que, al igual que un dni, es único para cada paciente.
   
   private const string ErCorreo = "[A-Z0-9a-z._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}";

   // Getters y setters de los atributos
   public DateTime Fecha
   {
      get => _fecha; // esto es lo mismo que poner get "{ return _fecha; }"
      set
      {
         _fecha = value;
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Fecha))); //
      }
   }

   public int Hora
   {
       get => _hora; // esto es equivalente a get "{ return _hora; }"
       set
       {
           _hora = value;
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Hora))); //
       }
   }

   public string Motivo
    {
        get => _motivo;
        set
        {
            _motivo = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Motivo))); //
        }
    }
    
    public string Observaciones
    {
        get => _observaciones;
        set
        {
            _observaciones = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Observaciones))); //
        }
    }
    
    public string MetodoPago
    {
        get => _metodoPago;
        set
        {
            _metodoPago = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MetodoPago))); //
        }
    }
    
    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email))); //
        }
    }
    
    
    
    
    // Constructor de la clase
    public Cita(DateTime fecha, int hora, string motivo, string observaciones, string metodoPago, string email)
    {
        _fecha = fecha;
        _hora = hora;
        _motivo = motivo;
        _observaciones = observaciones;
        _metodoPago = metodoPago;
        _email = email;
    }

    // Constructor vacío
    public Cita()
    {
        _fecha = DateTime.Now + TimeSpan.FromDays(1); // Por defecto, la fecha será el día siguiente al de hoy.
        _hora = 10;
        _motivo = "";
        _observaciones = "";
        _metodoPago = "Tarjeta";
        _email = "lmr.87@protonmail.ch";
    }

    /**
    * Crea un nuevo objeto, que es la copia de la instancia actual. Lo usaremos para poder editar los datos de una reserva.
    */
    public object Clone()
    { 
        return this.MemberwiseClone();
    }
    
   /** Evento que ocurre cuando el valor de una propiedad cambia. */
   public event PropertyChangedEventHandler? PropertyChanged;
   
    /**
     * Implementación de la interfaz IDataErrorInfo. Devuelve un mensaje de error si el valor de una propiedad no es válido.
     * En caso contrario, devuelve null.
     */
   public string Error => throw new NotImplementedException();

   /**
     * Devuelve el mensaje de error asociado a la propiedad especificada. Si no hay error, devuelve null.
     * Algunas comprobaciones no son necesarias, pero no se lo suficiente para optimizarlo.
     * Podría rellenar los ComboBox del formulario por defecto, pero entonces tengo que gestionar de forma diferente
     * las citas, ya que estoy adaptandolo a partir del ejemplo de clase, gestiono estas comprobaciones aunque algunas no
     * sean necesarias.
     */
   public string this[string columnName]
   {
       get
       {
           string result = "";
           switch (columnName)
           {
               case "Fecha":
               {
                   if (this.Fecha < DateTime.Now) // Si la fecha es anterior a la actual...
                   {
                       result = "La fecha de la cita no puede ser anterior a la fecha actual.";
                   }

                   break;
               }
               case "Hora":
               {
                   // Las horas se gestionarán de la siguiente manera. 
                   // El horario de citas es de 9 a 20.
                   // Por comodidad y falta de tiempo, solo habrá una cita cada hora.
                   if (this.Hora is < 9 or > 20) // Si la hora está fuera del horario de trabajo...
                   {
                       result = "La hora de la cita debe estar entre las 9:00 y las 20:00.";
                   }

                   break;
               }
               case "Motivo":
               {
                   // El motivo de la cita no puede estar vacío.
                   if (string.IsNullOrWhiteSpace(Motivo))
                   {
                       result = "El motivo de la cita no puede estar vacío.";
                   }

                   break;
               }
               case "MetodoPago":
               {
                   // El método de pago no puede estar vacío.
                   if (string.IsNullOrWhiteSpace(MetodoPago))
                   {
                       result = "El método de pago no puede estar vacío.";
                   }

                   break;
               }
               // El email no puede estar vacío.
               case "Email" when string.IsNullOrWhiteSpace(Email):
                   result = "El email no puede estar vacío.";
                   break;
               case "Email":
               {
                   if (!Regex.IsMatch(Email, ErCorreo)) // Si el email no es válido...
                   {
                       result = "El email no es válido.";
                   }

                   break;
               }
               // Creo que debería hacer un ENUM para los ComboBox, pero no se gestionarlo en C#
               default:
               {
                   if (columnName == "Email")
                   {
                       // con IsNullOrWhiteSpace, comprobamos que no sea nulo, vacío, o relleno de espacios en blanco
                       if (string.IsNullOrWhiteSpace(this._email)) 
                       {
                           result = "El email del paciente no puede estar vacío.";
                       } else if (!Regex.IsMatch(this._email, ErCorreo)) // si el email no coincide con al expresion regular...
                       {
                           result = "El email del paciente no tiene un formato válido."; 
                       }
                   }

                   break;
               }
           }
           return result;
       }
   }
}