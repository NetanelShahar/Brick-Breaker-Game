using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{
    public void PlayGame () 
    {
        Debug.Log("Moving to Level1");
        SceneManager.LoadScene("Level1");
    }

    public void Quit () 
    {
        Debug.Log("Quit the Game");
        Application.Quit();
    }
}
