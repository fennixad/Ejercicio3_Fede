using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario 
{
    public List<Item> items = new List<Item> ();

    public void A�adirItem(Item item)
    {
        items.Add(item);
        Debug.Log("Se a�adio: " +  item.nombre);

        for (int i = 0; i < items.Count; i++)
        {
            Debug.Log(items[i].nombre);
        }
    }

    public void QuitarItem(Item item)
    {
        items.Remove(item);
        Debug.Log("Se elimin�: " + item.nombre);

        for (int i = 0; i < items.Count; i++)
        {
            Debug.Log(items[i].nombre);
        }
    }
}
