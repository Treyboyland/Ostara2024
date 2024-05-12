using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Player player;

    [SerializeField]
    float speed;

    [SerializeField]
    Rigidbody2D body;

    [SerializeField]
    float thresholdMagnitude;

    [SerializeField]
    float secondsToWait;

    float elapsed = 0;

    Vector2 currentMovementVector;

    public void HandleMove(InputAction.CallbackContext context)
    {
        //Debug.LogWarning("Handling");
        currentMovementVector = context.ReadValue<Vector2>();
        elapsed = 0;
    }

    void FixedUpdate()
    {
        if (player.CanPerformAction)
        {
            elapsed += Time.fixedDeltaTime;
            if (elapsed >= secondsToWait && body.velocity.sqrMagnitude < thresholdMagnitude)
            {
                body.velocity = new Vector2();
            }
            Move();
        }
        else
        {
            body.velocity = new Vector2();
        }
    }

    void Move()
    {
        Vector2 movement = currentMovementVector;
        if (movement != new Vector2())
        {
            elapsed = 0;
        }
        else
        {
            body.velocity = Vector2.zero;

        }
        movement *= speed;
        //movement *= speed * Time.fixedDeltaTime;
        body.velocity = movement;
        //body.AddForce(movement, ForceMode2D.Impulse);
    }
}
