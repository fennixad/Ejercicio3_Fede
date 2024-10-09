using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Personaje p1 = new Personaje();
        p1.nombre = "Fede";
        p1.nivel = 10;
        p1.salud = 300;

        Personaje p2 = new Personaje();
        p2.nombre = "Link";
        p2.nivel = 20;
        p2.salud = 500;

        Debug.Log("Ejercicio1:");
        p1.MostrarInfo();
        p2.MostrarInfo();

        
        Personaje p3 = new Personaje("Ellie", 2, 30);
        Personaje p4 = new Personaje("Joel", 30, 800);
        Debug.Log("Ejercicio2:");
        p3.MostrarInfo();
        p4.MostrarInfo();

        Debug.Log("Ejercicio2:");
        PersonajeJugable personaje1 = new PersonajeJugable("Kenshin", 10, 100, 5);
        Enemigo enemigo1 = new Enemigo("Pikachu", 10, 40, 7);

        int dañoEnemigo = enemigo1.Ataque(personaje1);
        personaje1.RecibirDaño(dañoEnemigo);

        Debug.Log("poder del enemigo: " + enemigo1.poder);
        Debug.Log("Defensa del personaje: " + personaje1.defensa);
        Debug.Log("Daño inflijido al personaje: " + dañoEnemigo);
        Debug.Log("Salud del personaje: " + personaje1.salud);

        Debug.Log("Ejercicio3:");
        Item item1 = new Item("espada", "Espada Pepinal");
        Item item2 = new Item("escudo", "Escudo mierder");
        Item item3 = new Item("armadura", "Pechera brillante");
        Item item4 = new Item("calzoncillos", "Gallumbos cosmicos");

        Inventario inventario = new Inventario();
        inventario.AñadirItem(item1);
        inventario.AñadirItem(item2);
        inventario.AñadirItem(item3);
        inventario.AñadirItem(item4);

        personaje1.inventario = inventario;
        Debug.Log("Así queda el inventario: ");
        personaje1.VerInventario();

        Debug.Log("Quitamos items:");
        inventario.QuitarItem(item1);
        inventario.QuitarItem(item3);
        Debug.Log("Asi queda el inventario: ");
        personaje1.VerInventario();
    }

}
