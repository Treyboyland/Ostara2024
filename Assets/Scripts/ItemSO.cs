using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item-", menuName = "Game/Item", order = 0)]
public class ItemSO : ScriptableObject
{
    [SerializeField]
    string itemName;
}
