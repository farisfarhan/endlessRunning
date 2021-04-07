using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameisover : MonoBehaviour
{
    public static string restarting;
    
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        runnin.collide = "n";
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("QUIT!");
    }
}
