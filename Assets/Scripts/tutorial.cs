using System;
using UnityEngine.UI;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class tutorial : systemScoring
{
    public GameObject edibleMush;
    public GameObject inedibleMush;

    public GameObject tutorialUI_1;
    public GameObject tutorialUI_2;
    public GameObject tutorialUI_3;

    private Boolean newSpawn = true;
    private Boolean newSpawn2 = true;
    private Boolean newSpawn3 = true;
    private Boolean newSpawn4 = true;
    private Boolean newSpawn5 = true;

    public Vector3 UIposition = new Vector3(-10f, -10f, 0f);

    private GameObject newTutorial1;
    private GameObject newTutorial2;
    private GameObject newTutorial3;

    public GameObject[] hearts;
    public GameObject scoreText;
    private float delay = 0;

    public GameObject tutorialEnd;

    private void Start()
    {
        tutorialUI_1.transform.position = new Vector3(-4.6f, 2.5f, 0f);
        tutorialUI_2.transform.position = new Vector3(4.35f, 2.4f, 0f);
        tutorialUI_3.transform.position = new Vector3(-5f, 2f, 0f);
    }

    void Update()
    {
        if (newSpawn)
        {
            newTutorial1 = Instantiate(tutorialUI_1);
            Instantiate(edibleMush);
            newSpawn = false;
        }

        if( score == -1 )
        {
            if (newSpawn5)
            {
                Instantiate(edibleMush);
                newSpawn5 = false;
                score = 0;
            }
        }

        if (score == 1)
        {
            if (newSpawn2)
            {
                newTutorial1.transform.position = UIposition;
                newTutorial2 = Instantiate(tutorialUI_2);
                Instantiate(inedibleMush);
                newSpawn2 = false;
            }
        }

        if ( health <= 2 || score == 2 )
        {   
            if (newSpawn3)
            {
                Instantiate(inedibleMush);
                newSpawn3 = false;
            }
            if (newSpawn4)
            {
                newTutorial3 = Instantiate(tutorialUI_3);
                newSpawn4 = false;
            }
        }

        if (score == 6 )
        {
            SceneManager.LoadSceneAsync("End Tutorial");
        }
        
        UpdateLives(health);
        UpdateScore();
    }

    void FixedUpdate()
    {
        delay += 1;
        if (delay % 75 == 0 && ( score > 2 || health < 3 )) 
        {
            int num = UnityEngine.Random.Range(0, 2);
            if (num == 0)
            {
                Instantiate(inedibleMush, new Vector3(-5f, -10f, 0f), new Quaternion());
            }
            else { Instantiate(edibleMush); }
        }
        if (delay > 200) { delay = 0; }
    }
    public void UpdateLives(int health)
    {
        if (health < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (health < 3)
        {
            Destroy(hearts[2].gameObject);
        }
    }

    void UpdateScore()
    {
        Text scoreTextB = scoreText.GetComponent<Text>();
        scoreTextB.text = "SCORE: " + score;
    }
}
