using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JobRequirements : MonoBehaviour
{
    [SerializeField]
    PlayerInventory inventory;

    [SerializeField]
    ItemAndCount grass;

    [SerializeField]
    ItemAndCount fedMatriarch;

    [SerializeField]
    ItemAndCount dustedFloors;

    public UnityEvent SuccessEvent;


    bool grassFired, floorsFired;


    void Update()
    {
        if (!grassFired && inventory.HasItem(grass))
        {
            grassFired = true;
            SuccessEvent.Invoke();
        }

        if (!floorsFired && inventory.HasItem(dustedFloors))
        {
            floorsFired = true;
            SuccessEvent.Invoke();
        }
    }

    public bool AllRequirementsCompleted()
    {
        return inventory.HasItem(grass) && inventory.HasItem(fedMatriarch) && inventory.HasItem(dustedFloors);
    }
}
