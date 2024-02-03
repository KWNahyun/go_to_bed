using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance;
    // Inventory�� �� Item ����Ʈ
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    private string savePath = "Inventory/Save/SaveFile";
    private string itemPrefabPath = "Inventory/Items/";
    public List<Dictionary<string, object>> csvList = new List<Dictionary<string, object>>();

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
        Items.Clear();
        // Inventory �� ������ �ߺ� ���� ����
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
        Debug.Log("Destroyed duplicated slots");

        SyncWithSave();

        // Items ����Ʈ�� �����ϴ� ��� �����۵� Slot�� ���� �ֱ�
        foreach (var Item in Items)
        {
            if (csvList[Item.id]["itemCount"].ToString() != "0")
            {
                GameObject obj = Instantiate(InventoryItem, ItemContent);
                var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
                var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
                var itemCount = obj.transform.Find("ItemCount").GetComponent<Text>();

                itemName.text = Item.itemName;
                itemIcon.sprite = Item.itemIcon;
                itemCount.text = csvList[Item.id]["itemCount"].ToString();
            }
        }
    }

    public void SyncWithSave()
    {
        // ���� CSV���� ���� List �ʱ�ȭ
        csvList.Clear();
        // CSV���� ������ ������ ����
        csvList = CSVReader.Read(savePath);
        Debug.Log("CSV Read Successful");

        for (int i = 0; i < csvList.Count; i++)
        {
            GameObject itemInstance = Instantiate(Resources.Load(itemPrefabPath + csvList[i]["itemID"]) as GameObject);
            itemInstance.GetComponent<AddItem>().AddtoItems();
            Destroy(itemInstance);
            Debug.Log($"Item Instance {i} Added to Items");
        }
    }
}