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
        string gameDifficulty = PlayerPrefs.GetString("gameDifficulty");
        if(gameDifficulty == "easy"){
            Debug.Log("drag set to 10");
            mushroomDrag = 10;
        }
        else if(gameDifficulty == "normal"){
            Debug.Log("drag set to 2");
            mushroomDrag = 2;
        }
        else if(gameDifficulty == "hard"){
            Debug.Log("drag set to 1");
            mushroomDrag = 1;
        }
        float rotationSpeed = Random.Range(rotationSpeedNegative, rotationSpeedPositive);
        rb = GetComponent<Rigidbody2D>();
        rb.drag = mushroomDrag;
        rb.AddTorque(rotationSpeed);
    }
}
