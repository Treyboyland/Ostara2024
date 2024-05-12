using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenDimmer : MonoBehaviour
{
    [SerializeField]
    float alphaPerSecond;

    [SerializeField]
    SpriteRenderer spriteRenderer;

    public bool IncreaseDim { get; set; } = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ChangeAlpha();
    }

    void ChangeAlpha()
    {
        int addition = IncreaseDim ? 1 : -1;
        float alpha = spriteRenderer.color.a;
        alpha += addition * alphaPerSecond * Time.deltaTime;
        alpha = Mathf.Clamp(alpha, 0, 1);
        SetAlpha(alpha);
    }

    void SetAlpha(float a)
    {
        var color = spriteRenderer.color;
        color.a = a;
        spriteRenderer.color = color;
    }
}
