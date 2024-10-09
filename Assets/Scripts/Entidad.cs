using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entidad 
{
    public string name { get; set; }
    public int nivel { get; set; }
    public int salud {  get; set; }

    public Entidad()
    {

    }
    public Entidad (string name, int nivel, int salud)
    {
        this.name = name;
        this.nivel = nivel;
        this.salud = salud;
    }
}
