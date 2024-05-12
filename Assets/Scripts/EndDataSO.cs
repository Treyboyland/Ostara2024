using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EndData-", menuName = "Game/End Data", order = 0)]
public class EndDataSO : ScriptableObject
{
    [SerializeField]
    string title;

    [SerializeField]
    [TextArea]
    string description;

    public string Title => title;
    public string Description => description;
}
