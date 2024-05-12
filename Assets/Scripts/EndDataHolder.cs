using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDataHolder : MonoBehaviour
{
    public EndDataSO EndData { get; set; }

    public static EndDataHolder Instance { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null && this != Instance)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
