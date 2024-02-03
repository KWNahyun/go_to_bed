using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance;
    // Inventory에 들어갈 Item 리스트
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
        // Inventory 상에 아이템 중복 존재 배제
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
        Debug.Log("Destroyed duplicated slots");

        SyncWithSave();

        // Items 리스트에 존재하는 모든 아이템들 Slot에 각각 넣기
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
        // 기존 CSV에서 받은 List 초기화
        csvList.Clear();
        // CSV에서 아이템 데이터 읽음
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