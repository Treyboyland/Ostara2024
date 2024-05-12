using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCheck : MonoBehaviour
{
    [SerializeField]
    GameEvent successCheck;

    [SerializeField]
    GameEvent failCheck;

    [SerializeField]
    bool passOnlyOnce;

    [SerializeField]
    ItemAndCount itemAndCount;

    bool passFired = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.gameObject.GetComponent<Player>();
        if (player != null)
        {
            RunChecks(player);
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
        if (player != null)
        {
            RunChecks(player);
        }
    }

    void RunChecks(Player player)
    {
        var inventory = player.gameObject.GetComponentInChildren<PlayerInventory>();
        bool hasItem = inventory.HasItem(itemAndCount);

        bool chosen = (hasItem && !passOnlyOnce) || (hasItem && passOnlyOnce && !passFired);

        GameEvent toFire = chosen ? successCheck : failCheck;

        if (successCheck == toFire)
        {
            passFired = true;
        }
        if (toFire)
        {
            toFire.Invoke();
        }
    }
}
