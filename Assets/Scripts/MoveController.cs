using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public float i = 1f;
    public float k = 1f;

    Vector2 direction = Vector2.zero;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //float inputX = Input.GetAxis("Horizontal");
        //float inputY = Input.GetAxis("Vertical");

        //Vector2 direction = new Vector2(inputX, inputY);

        //if (direction.magnitude > 1)
        //{
        //    direction = direction.normalized;
        //}
        //rb.velocity = direction * speed;



        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontalInput, verticalInput);

        if (Input.GetKey(KeyCode.W))
        {
            direction += new Vector2(-k, i);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += new Vector2(-i, -i);
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += new Vector2(k, -i);
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += new Vector2(i, i);
        }

        if (direction.magnitude > 1)
        {
            direction = direction.normalized;
        }
        rb.velocity = direction * speed;
    }
}
