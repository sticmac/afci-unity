using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 250f;
    [SerializeField] Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            rb2d.AddForce(new Vector2(0, jumpForce));
        }

        float direction = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(speed * direction, rb2d.velocity.y);
    }
}
