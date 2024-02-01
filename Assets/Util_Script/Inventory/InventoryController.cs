using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance;
    // Inventory�� �� Item ����Ʈ
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
        // Inventory �� ������ �ߺ� ���� ����
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }

        // Items ����Ʈ�� �����ϴ� ��� �����۵� Slot�� ���� �ֱ�
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
