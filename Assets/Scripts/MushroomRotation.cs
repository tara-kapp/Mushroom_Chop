using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomRotation : MonoBehaviour
{
    public Rigidbody2D rb;
    public int rotationSpeedPos = 60;
    public int rotationSpeedNeg = -60;
    float mushroomDrag = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        float rotationSpeed = Random.Range(rotationSpeedNeg, rotationSpeedPos);
        rb = GetComponent<Rigidbody2D>();
        rb.drag = mushroomDrag;
        rb.AddTorque(rotationSpeed);
    }
}
