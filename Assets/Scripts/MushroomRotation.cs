using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomRotation : MonoBehaviour
{
    public Rigidbody2D rb;
    float rotationSpeed = 30;
    float mushroomDrag = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.drag = mushroomDrag;
        rb.AddTorque(rotationSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
