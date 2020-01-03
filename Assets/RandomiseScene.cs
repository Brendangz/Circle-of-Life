using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomiseScene : MonoBehaviour
{
    private void Start()
    {
        
    }
    


    public void ChooseRandomLevel()
    {
        int levelRange = Random.Range(1, 3);
        // pick random scene when button is pressed
        SceneManager.LoadScene(levelRange);  
        //Application.LoadLevel("Zebra_Scene");
    }
}


