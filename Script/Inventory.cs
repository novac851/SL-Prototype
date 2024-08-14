using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int space = 9;
    public List<Item> items = new List<Item>();
    public static Inventory Instance;

    private void Awake()
    {
        Instance = this;
    }

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public void Add(Item item)
    {
        if (item.ShowInventory)
        {
            if (items.Count >= space)
                return;
            items.Add(item);
            if(onItemChangedCallback!=null)
            {
                onItemChangedCallback.Invoke();
            }
        }
    }
    public void Remove(Item item)
    {
        items.Remove(item);
        if(onItemChangedCallback!=null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}
