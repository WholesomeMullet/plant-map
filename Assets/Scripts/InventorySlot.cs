using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Text name;

    public void Additem(Item _item)
    {
        name.text = _item.itemName;
        icon.sprite = _item.itemIcon;
    }

}
