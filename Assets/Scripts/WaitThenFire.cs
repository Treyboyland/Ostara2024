using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitThenFire : MonoBehaviour
{
    [SerializeField]
    float secondsToWait;

    [SerializeField]
    GameEvent eventToFire;

    bool isWaiting;

    public void StartSequence()
    {
        if (!isWaiting)
        {
            StartCoroutine(WaitThenInvoke());
        }
    }

    IEnumerator WaitThenInvoke()
    {
        isWaiting = true;
        yield return new WaitForSeconds(secondsToWait);
        eventToFire.Invoke();
        isWaiting = false;
    }
}
