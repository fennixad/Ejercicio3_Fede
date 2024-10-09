using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje 
{
    public string nombre {  get; set; }
    public int nivel { get; set; }
    public int salud { get; set; }
    
    public Personaje()
    {

    }

    public Personaje(string nombre, int nivel, int salud)
    {
        this.nombre = nombre;
        this.nivel = nivel;
        this.salud = salud;
    }
    
    public void MostrarInfo()
    {
        Debug.Log("nombre: " + this.nombre + ". nivel: " + this.nivel + ". salud: " + this.salud);
    }
}
