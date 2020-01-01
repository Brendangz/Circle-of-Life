using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomiseScene : MonoBehaviour
{
    
    int levelRange = Random.Range(1, 2);


    private void Start()
    {
        OnMouseClick();
    }

    public void OnMouseClick()
    {
        SceneManager.LoadScene(levelRange);
    }
}


