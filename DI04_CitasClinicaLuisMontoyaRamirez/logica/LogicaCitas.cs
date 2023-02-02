using System;
using System.Collections.ObjectModel;
using DI04_CitasClinicaLuisMontoyaRamirez.dto;

namespace DI04_CitasClinicaLuisMontoyaRamirez.logica;

public class LogicaCitas
{
    public ObservableCollection<Cita> listaCitas { get; set; } // Lista de citas
    
    /*
     * Constructor
     */
    public LogicaCitas()
    {
        listaCitas = new ObservableCollection<Cita>(); // Inicializamos la lista de citas
        // Creamos una cita de ejemplo
        listaCitas.Add(new Cita(new DateTime(2022, 11, 22), 12, "Porque si", "No tiene capacidad de observar nada", "tarjeta", "lmr.87@protonmail.ch"));
    }
    
    /*
     * Método para añadir una cita
     */
    public void addCita(Cita cita)
    {
        listaCitas.Add(cita);
    }
    
    /*
     * Método para modificar una cita
     */
    public void modCita(Cita cita, int posicion)
    {
        listaCitas[posicion] = cita;
    }
    
    /*
     * Método para eliminar una cita
     */
    public void eliminarCita(int posicion)
    {
        listaCitas.RemoveAt(posicion);
    }
    
}   