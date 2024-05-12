using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullChase : MonoBehaviour
{
    [SerializeField]
    Player player;

    [SerializeField]
    GameObject door;

    [SerializeField]
    float secondsToChase;

    bool shouldChase;

    Vector3 startPos;
    private float elapsed;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldChase)
        {
            elapsed += Time.deltaTime;
            transform.position = Vector3.Lerp(startPos, player.transform.position, elapsed / secondsToChase);
        }
    }

    public void CheckChase()
    {
        shouldChase = !door.activeInHierarchy;
    }
}
