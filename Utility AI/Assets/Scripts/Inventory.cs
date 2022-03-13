using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> Items;

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public bool HasItem(Item item)
    {
        if (Items.Contains(item))
            return true;
        else
            return false;
    }

    public void RemoveItem(Item item)
    {
        if (Items.Contains(item))
            Items.Remove(item);
    }

}
