using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeJugable : Entidad
{
    public int defensa {  get; set; }
    public Inventario inventario { get; set; }

    public PersonajeJugable(string name, int nivel, int salud, int defensa) : base(name, nivel, salud)
    {
        this.defensa = defensa;
    }

    public void RecibirDa�o(int da�o)
    {
        this.salud -= da�o;
    }

    public void VerInventario()
    {
        for (int i = 0; i < inventario.items.Count; i++)
        {
            Debug.Log(inventario.items[i].nombre);
        }
    }
}
