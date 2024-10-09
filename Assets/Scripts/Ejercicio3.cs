using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    void Start()
    {
        SumaTresWhile();
        SumaTresFor();
        MenuPrincipal();
    }

    void SumaTresWhile()
    {
        int y = 7, x = 0;

        while (x <= 4)
        {
            y += 3;
            x ++;
        }
        print("Ejercicio 1\ny: " + y + "  x: " + x);
    }
    void SumaTresFor()
    {
        int y = 7, x = 0;

        for (int i = 0; i <= 4; i++)
        {
            y += 3;
            x++;
        }
        print("Ejercicio 2\ny: " + y + "  x: " + x);
    }
    void MenuPrincipal()
    {
        float num = Random.Range(0, 4);

        switch (num)
        {
            case 0:
                print("Ejercicio3\nNueva Partida");
                break;

            case 1:
                print("Ejercicio3\nPartida Cargada");
                break;

            case 2:
                print("Ejercicio3\nOpciones de Juego");
                break;

            default:
                print("Ejercicio3\nCreditos, Salir del juego");
                break;
        }
    }
}
