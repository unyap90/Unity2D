using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(2, rb2d.velocity.y);
            //transform.Rotate(0f, 180f, 0f);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-2, rb2d.velocity.y);
            //transform.Rotate(0f, 180f, 0f);
        }

        if (Input.GetKey("space"))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 2);
        }
    }
}
