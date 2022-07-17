using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name =="MainMenu")
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Prototype 3"));
            SceneManager.UnloadSceneAsync("MainMenu");
        }
        else
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainMenu"));
            SceneManager.UnloadSceneAsync("Protoype 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
