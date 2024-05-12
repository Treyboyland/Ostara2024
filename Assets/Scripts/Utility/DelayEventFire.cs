using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DelayEventFire : MonoBehaviour
{
    [SerializeField]
    float secondsToWait;

    public UnityEvent EventToFire;

    bool started = false;

    public void StartSequence()
    {
        if (!started)
        {
            StartCoroutine(WaitThenFire());
        }

    }

    private IEnumerator WaitThenFire()
    {
        started = true;
        yield return new WaitForSeconds(secondsToWait);
        EventToFire.Invoke();
        started = false;
    }
}
