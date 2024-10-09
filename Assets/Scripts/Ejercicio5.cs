using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    private int num = 4;
    void Start()
    {
        print("Ejercicio1: " + ParImpar(3));
        print("Ejercicio2: El valor de num es: " + num);
        CambiarValor(num);
        print("Ejercicio2: El valor de num despues de la función es: " + num);
        print("Ejercicio3");
        TablaDeMultiplicar(3);
    }

    string ParImpar(int num)
    {
        if (num % 2 == 0)
        {
            return "Par";
        }
        else
        {
            return "Impar";
        }
    }
    int CambiarValor(int numero)
    {
        return numero += 5;
    }

    void TablaDeMultiplicar(int num)
    {
        for (int i = 0; i < 11; i++)
        {
            print("3 x " + i + " = " + num * i);
        }
    }
}
