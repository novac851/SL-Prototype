using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Button useButton;
    public Text itemname;
    public Text information;
    Item item;
    public KarmaPoint karmaAdd;

    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        itemname.text = item.name;
        itemname.enabled = true;
        information.text = item.information;
        information.enabled = true;
        useButton.interactable = true;
    }
    public void ClearSlot()
    {
        item = null;
        icon.enabled = false;
        itemname.enabled = false;
        information.enabled = false;
        useButton.interactable = false;
    }
    public void UseItem()
    {
        karmaAdd.karmaPlus();
        Inventory.Instance.Remove(item);
        
    }
    /*public void UseItem()
    {
        if(item!=null)
        {
            item.Use();
        }
    }*/



}
