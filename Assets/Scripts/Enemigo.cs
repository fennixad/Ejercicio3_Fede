using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : Entidad
{
    public int poder { get; set; }

    public Enemigo(string name, int nivel, int salud, int poder) : base(name, nivel, salud)
    {
        this.poder = poder;
    }
    public int Ataque(PersonajeJugable p)
    {
        int da�o = 0;

        if (p.defensa < this.poder)
        {
            da�o = this.poder - p.defensa;
        }
        return da�o;
    }
}
