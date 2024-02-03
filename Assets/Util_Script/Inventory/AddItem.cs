using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{
    public Item Item;

    public void AddtoItems()
    {
        InventoryController.Instance.Add(Item);
    }
}
