using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomRotation : MonoBehaviour
{
    public Rigidbody2D rb;
    int rotationSpeedNegative = -30;
    int rotationSpeedPositive = 30;
    float mushroomDrag = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        float rotationSpeed = Random.Range(rotationSpeedNegative, rotationSpeedPositive);
        rb = GetComponent<Rigidbody2D>();
        rb.drag = mushroomDrag;
        rb.AddTorque(rotationSpeed);
    }
}
