using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTrigger : MonoBehaviour
{
    [SerializeField]
    ItemSO foodItem;

    [SerializeField]
    GameEvent foodDelivered;

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.gameObject.GetComponent<Player>();

        if (player)
        {
            var inventory = player.gameObject.GetComponentInChildren<PlayerInventory>();
            if (inventory && inventory.HasItem(foodItem))
            {
                inventory.RemoveItem(foodItem);
                foodDelivered.Invoke();
            }
        }
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        var player = other.gameObject.GetComponent<Player>();

        if (player)
        {
            var inventory = player.gameObject.GetComponentInChildren<PlayerInventory>();
            if (inventory && inventory.HasItem(foodItem))
            {
                inventory.RemoveItem(foodItem);
                foodDelivered.Invoke();
            }
        }
    }
}
