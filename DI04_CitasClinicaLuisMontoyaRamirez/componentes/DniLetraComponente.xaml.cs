using System.Windows;
using System.Windows.Controls;

namespace DI04_CitasClinicaLuisMontoyaRamirez.componentes;

public partial class DniLetraComponente
{
    /**
     * Constructor, inicializa el componente y asigna el DataContext
     */
    public DniLetraComponente()
    {
        InitializeComponent();
        DataContext = this;
    }
    
    // Longitud del número de DNI, por defecto 8. No es necesaria, pero la uso.
    public int LongitudNumero { get; set; }

    /**
     * Método que se ejecuta cada vez que se modifica el texto del TextBox.
     * Controla que se escriban 8 números, y una vez se hayan escrito, llama al método que calcula la letra.
     * Si se borra un número, se borra la letra.
     */
    private void ContenidoDni_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        switch (ContenidoDni.Text.Length)
        {
            case 8:
            {
                int dni = int.Parse(ContenidoDni.Text);
                LetraDni.Text = CalcularLetraDni(dni).ToString();
                break;
            }
            case < 8:
                LetraDni.Text = "";
                break;
        }
    }

    /**
     * Método que calcula la letra del DNI a partir del número.
     * @param dni Número del DNI
     * @return Letra del DNI
     */
    private char CalcularLetraDni(int dni)
    {
        const string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
        int posicion = dni % 23;
        return letras[posicion];
    }

    /**
     * Método que se ejecuta cuando se pierde el foco del TextBox.
     * Si la longitud del número del DNI es menor que 8, se muestra un mensaje de error.
     */
    private void ContenidoDni_OnLostFocus(object sender, RoutedEventArgs e)
    {
        if (ContenidoDni.Text.Length != 8)
        {
            MessageBox.Show("El DNI debe tener 8 números");
        }
    }
    
}