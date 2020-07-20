using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //public static MainMenu instance = null;

    public GameObject settingsMenu;
    public GameObject mainMenu;
    //public GameObject canvas;
    public GameObject back;

    private bool setActive;

    void Awake()
    {
        setActive = true;
        settingsMenu.SetActive(!setActive);
        mainMenu.SetActive(setActive);
        GameObject setButton = GameObject.Find("SettingsButton");
        setButton.GetComponent<Button>().onClick.AddListener(SetSettings);
        //GameObject back = GameObject.Find("BackButton");
        back.GetComponent<Button>().onClick.AddListener(SetSettings);
    }

    public void StartPressed()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitPressed()
    {
        //Debug.Log("Exit");
        Application.Quit();
    }

    public void SetSettings()
    {

        
        if (setActive)
        {
            settingsMenu.SetActive(true);
            mainMenu.SetActive(false);
            setActive = false;
        }
        else
        {
            settingsMenu.SetActive(false);
            mainMenu.SetActive(true);
            setActive = true;
        }
    }
}
