using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRefresh : MonoBehaviour
{
    [SerializeField]
    GameObject food;

    [SerializeField]
    ItemSO foodItem;

    [SerializeField]
    PlayerInventory inventory;

    [SerializeField]
    float secondsToWait;

    bool isWaiting = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!food.gameObject.activeInHierarchy && !inventory.HasItem(foodItem) && !isWaiting)
        {
            StartCoroutine(Refresh());
        }
    }

    IEnumerator Refresh()
    {
        isWaiting = true;
        yield return new WaitForSeconds(secondsToWait);
        food.gameObject.SetActive(true);
        isWaiting = false;
    }
}
