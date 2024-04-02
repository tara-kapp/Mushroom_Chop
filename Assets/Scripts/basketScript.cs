using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;
using UnityEngine.SocialPlatforms.Impl;

public class basketScript : MonoBehaviour
{

    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public Vector2 movement;

    // Auto-load the RigidBody component into the variable:
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Listen for player input to move the object:
    void FixedUpdate()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);

        if (Input.GetMouseButton(0))
        {
            var mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0f; // zero z
            mouseWorldPos.y = -5f; // negative five y
            transform.position = mouseWorldPos;
        }


    }
    // Makes objects with the tag "mushroom" disappear on contact:
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "mushroom")
        {
            Debug.Log("touch");
            Destroy(other.gameObject);
       
        }
    }
}