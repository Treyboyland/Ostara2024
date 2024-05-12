using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndText : MonoBehaviour
{
    [SerializeField]
    TMP_Text title;

    [SerializeField]
    TMP_Text description;

    // Start is called before the first frame update
    void Start()
    {
        SetData();
    }

    void SetData()
    {
        title.text = EndDataHolder.Instance.EndData.Title;
        description.text = EndDataHolder.Instance.EndData.Description;
    }
}
