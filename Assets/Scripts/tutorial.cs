using System;
using System.Collections;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public Transform basket;
    public float distanceToDestroy = 5f;
    public float distCheck;

    public Transform spawnPoint;

    public GameObject edibleMush;
    public GameObject inedibleMush;

    public GameObject tutorialUI_1;
    public GameObject tutorialUI_2;
    public GameObject tutorialUI_3;

    public Boolean newSpawn = true;
    public Boolean newSpawn2 = true;

    // Start is called before the first frame update
    void Start()
    {
        basket = GameObject.FindWithTag("basket").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (newSpawn)
        {
            Instantiate(tutorialUI_1);
            Instantiate(edibleMush);
            newSpawn = false;
        }
       
        if( newSpawn2)
        {
            Instantiate(tutorialUI_2);
            Instantiate(inedibleMush);
            newSpawn2 = false;
        }

        Transform edible_y = edibleMush.GetComponent<Transform>();
        //int edible = edible_y.position.y;

        /*if ( < -5 )
        {
            edibleMush.transform.SetPositionAndRotation(spawnPoint.position, spawnPoint.rotation);
        }*/

        //reposition(edibleMush);
        //reposition(inedibleMush);
    }

    void reposition(GameObject mush)
    {
        
    }




}
