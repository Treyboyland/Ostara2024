using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    [SerializeField]
    SpriteRenderer spriteRenderer;

    [SerializeField]
    Collider2D playerCollider;

    [SerializeField]
    PlayerSpriteController spriteController;


    public bool IsImmobilized { get; set; } = false;

    public bool CanPerformAction
    {
        get
        {
            return !IsImmobilized;
        }
    }

    public PlayerSpriteController SpriteController { get => spriteController; }
}
