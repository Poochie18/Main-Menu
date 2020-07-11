using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void StartPressed()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitPressed()
    {
        Debug.Log("Exit");
        //Application.Quit();
    }
}
