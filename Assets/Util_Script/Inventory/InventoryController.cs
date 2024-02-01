using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance;
    // Inventory에 들어갈 Item 리스트
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public void ListItems()
    {
        // Inventory 상에 아이템 중복 존재 배제
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }

        // Items 리스트에 존재하는 모든 아이템들 Slot에 각각 넣기
        foreach (var Item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            itemName.text = Item.itemName;
            itemIcon.sprite = Item.itemIcon;
        }
    }
}
