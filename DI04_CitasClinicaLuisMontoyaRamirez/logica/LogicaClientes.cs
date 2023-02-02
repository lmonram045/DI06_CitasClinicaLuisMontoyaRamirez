using System.Collections.ObjectModel;
using DI04_CitasClinicaLuisMontoyaRamirez.dto;

namespace DI04_CitasClinicaLuisMontoyaRamirez.logica;

public class LogicaClientes
{
    public ObservableCollection<Cliente> listaClientes { get; set; }
    
    /**
     * Constructor de la clase
     */
    public LogicaClientes()
    {
        listaClientes = new ObservableCollection<Cliente>();
        //  no se podrá crear paciente en esta versión, solo los que añadiré por defecto.
        listaClientes.Add(new Cliente("lmr.87@protonmail.ch", "Luis Montoya Ramírez")); // Añadimos un cliente de ejemplo
        listaClientes.Add(new Cliente("dale.cooper@blacklake.com", "Dale Cooper"));
        listaClientes.Add(new Cliente("jmmillan@cardiffelectric.com", "Joe MacMillan"));
        listaClientes.Add(new Cliente("kirklt@uspf.gov", "James Tiberius Kirk"));
        listaClientes.Add(new Cliente("a.nadir@greendale.tk", "Abed Nadir"));
    }
    
    /**
     * Método para añadir un cliente a la lista
     */
    public void addCliente(Cliente cliente)
    {
        listaClientes.Add(cliente);
    }
    
    /**
     * Método para modificar un cliente de la lista
     */
    public void modCliente(Cliente cliente, int posicion)
    {
        listaClientes[posicion] = cliente;
    }
    
    /**
     * Método para eliminar un cliente de la lista
     */
    public void eliminarCliente(int posicion)
    {
        listaClientes.RemoveAt(posicion);
    }
}