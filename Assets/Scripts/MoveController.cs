using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(inputX, inputY);

        if(direction.magnitude > 1)
        {
            direction = direction.normalized;
        }
        rb.velocity = direction * speed;
    }
}
