using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D body;
    public float moveVal;
    public float moveSpeed = 25.0f;

    public float jumping = 0.0f;

    // Start is called before the first frame update
    void OnMove(InputValue value)
    {
        moveVal = value.Get<float>();
    }

    void OnJump(InputValue value)
    {
         jumping = value.Get<float>();
    }


    void Update()
    {
        transform.Translate(new Vector2(moveVal, jumping*5.0f) * moveSpeed * Time.deltaTime);
    }
}
