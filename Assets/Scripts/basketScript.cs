using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;
using UnityEngine.SocialPlatforms.Impl;

public class basketScript : systemScoring
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
        if (other.gameObject.tag == "edible")
        {
            gameObject.GetComponent<AudioSource>().Play();
            StartCoroutine(StopSFX());
            Destroy(other.gameObject);
            RemoveScore();
        }
        else if(other.gameObject.tag == "inedible") {
            gameObject.GetComponent<AudioSource>().Play();
            StartCoroutine(StopSFX());
            Destroy(other.gameObject);
            AddScore();
        }
        else if (other.gameObject.tag == "hallucigenic")
        {
            gameObject.GetComponent<AudioSource>().Play();
            StartCoroutine(StopSFX());
            Destroy(other.gameObject);
            AddScore(); AddScore();
        }

        IEnumerator StopSFX()
        {
            yield return new WaitForSeconds(0.5f);
            gameObject.GetComponent<AudioSource>().Stop();
        }
    }
}