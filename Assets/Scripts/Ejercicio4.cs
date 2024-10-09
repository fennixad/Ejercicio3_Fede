using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    int[] habitaciones = { 3, 4, 1, 6, 4, 8, 7 };
    void Start()
    {
        CambioHabitaciones(habitaciones);
        InicializoA0(habitaciones);
        CreaLista();
    }

    void CambioHabitaciones(int[] habitaciones)
    {
        print("Ejercicio1 primer array:");
        foreach (var habitacion in habitaciones)
        {
            print(habitacion);
        }

        habitaciones[4] = 9;

        print("Ejercicio1 segundo array:");
        foreach (var habitacion in habitaciones)
        {
            print(habitacion);
        }

        if (habitaciones[1] == habitaciones[6])
        {
            print("El elemento es igual");
        }
        else
        {
            print("El elemento es diferente");
        }
    }

    void InicializoA0(int[] habitaciones)
    {
        
        print("Ejercicio2: ");

        for (int i = 0; i < habitaciones.Length -1; i++)
        {
            habitaciones[i] = 0;
        }

        foreach (var habitacion in habitaciones)
        {
            print(habitacion);
        }
    }

    void CreaLista()
    {
        List<int> milista = new List<int> { 1, 2, 3, 4, 5, 6 };

        print("Ejercicio 3 Primera lista:");
        foreach(var numero in milista)
        {
            print(numero);
        }

        milista.RemoveAt(1);

        print("Ejercicio 3 Segunda lista:");

        foreach (var numero in milista)
        {
            print(numero);
        }
        
    }

}
