using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Scene_1");

    }
    public void PlayOptions()
        {SceneManager.LoadSceneAsync("Options");
       
     }

     public void PlayMenu()
        {SceneManager.LoadSceneAsync("Main Screen");
       
     }
    
}
