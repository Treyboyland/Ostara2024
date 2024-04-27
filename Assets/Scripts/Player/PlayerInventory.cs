using System;
using System.Collections;
using System.Collections.Generic;
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
}
