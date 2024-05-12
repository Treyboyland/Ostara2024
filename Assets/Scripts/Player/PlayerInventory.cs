using System;
using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [Serializable]
    public struct ItemCount
    {
        public ItemSO ItemSO;
        public int Count;
    }

    [SerializeField]
    List<ItemCount> initialItems;

    Dictionary<ItemSO, int> inventory = new Dictionary<ItemSO, int>();

    public void AddItem(ItemSO item)
    {
        AddItem(item, 1);
    }

    public void AddItem(ItemSO item, int count)
    {
        if (inventory.ContainsKey(item))
        {
            inventory[item] += count;
        }
        else
        {
            inventory.Add(item, count);
        }
    }

    public bool HasItem(ItemSO item)
    {
        return inventory.ContainsKey(item) && inventory[item] > 0;
    }

    public bool HasItem(ItemAndCount itemAndCount)
    {
        return inventory.ContainsKey(itemAndCount.Item) && inventory[itemAndCount.Item] >= itemAndCount.Count;
    }

    public bool HasItem(ItemSO item, int count)
    {
        return inventory.ContainsKey(item) && inventory[item] >= count;
    }

    public void RemoveItem(ItemSO item)
    {
        RemoveItem(item, 1);
    }

    public void RemoveItem(ItemSO item, int count)
    {
        if (inventory.ContainsKey(item) && inventory[item] >= count)
        {
            inventory[item] -= count;
        }
    }
}
