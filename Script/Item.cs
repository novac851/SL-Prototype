using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu (fileName = "New Item",menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = null;
    public Sprite icon = null;
    public bool ShowInventory = true;
    public string information = null;

    /*public void Use()
    {
        
    }*/

    public void RemoveItem()
    {
        Inventory.Instance.Remove(this);
    }

}
