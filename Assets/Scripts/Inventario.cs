using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario 
{
    public List<Item> items = new List<Item> ();

    public void AñadirItem(Item item)
    {
        items.Add(item);
        Debug.Log("Se añadio: " +  item.nombre);

        for (int i = 0; i < items.Count; i++)
        {
            Debug.Log(items[i].nombre);
        }
    }

    public void QuitarItem(Item item)
    {
        items.Remove(item);
        Debug.Log("Se eliminó: " + item.nombre);

        for (int i = 0; i < items.Count; i++)
        {
            Debug.Log(items[i].nombre);
        }
    }
}
