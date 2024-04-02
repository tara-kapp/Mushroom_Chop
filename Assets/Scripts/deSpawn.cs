using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deSpawn : MonoBehaviour
{
    public Transform basket;
    public float distanceToDestroy = 5f;
    public float distCheck;

    void Start()
    {
        //find the Paddle object by tag, then load its transform into our variable
        basket = GameObject.FindWithTag("basket").GetComponent<Transform>();
    }

    void Update()
    {
        if (transform.position.y < (basket.position.y - distanceToDestroy))
        {
            Destroy(gameObject);
        }
    }
}
