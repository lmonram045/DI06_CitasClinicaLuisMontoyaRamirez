using System.Collections.ObjectModel;
using DI04_CitasClinicaLuisMontoyaRamirez.dto;

namespace DI04_CitasClinicaLuisMontoyaRamirez.logica;

public class LogicaClientes
{
    // TODO: Revisar todo por si acaso.
    public ObservableCollection<Cliente> ListaClientes { get; set; } = new(); // La podemos declarar e inicializar así.

    /**
     * Constructor de la clase
     */
    public LogicaClientes()
    {
        ListaClientes.Add(new Cliente("Luis", "Montoya Ramírez", "611221122", "luis@protonmail.ch", "45586045e", "calle falsa, 123", "01/01/1987", "")); 
        ListaClientes.Add(new Cliente("Dale", "Cooper", "", "dale.cooper@blacklake.com", "12345678z", "708 Northwestern Street, Twin Peaks, Washington", "19/04/1954", "observacion"));
        ListaClientes.Add(new Cliente("Joe", "MacMillan", "611223344", "jmm@cardiffelectric.com", "87654321x", "Cardiff Electric, 123", "01/01/1947", "observacion"));
        ListaClientes.Add(new Cliente("James Tiberius", "Kirk", "", "kirklt@uspf.gov","23456789d", "Starfleet Command, 123, Riverside, Iowa", "22/03/2233", "observacion"));
        ListaClientes.Add(new Cliente("Abed", "Nadir", "", "a.nadir@greendale.tk", "98765432m", "Greendale Community College, 123", "24/03/1979", "observacion"));
        
    }
    
    /**
     * Método para añadir un cliente a la lista
     */
    public void AddCliente(Cliente cliente)
    {
        ListaClientes.Add(cliente);
    }
    
    /**
     * Método para modificar un cliente de la lista
     */
    public void ModCliente(Cliente cliente, int posicion)
    {
        ListaClientes[posicion] = cliente;
    }
    
    /**
     * Método para eliminar un cliente de la lista
     */
    public void EliminarCliente(int posicion)
    {
        ListaClientes.RemoveAt(posicion);
    }
}