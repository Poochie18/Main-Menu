using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System;
using System.Linq;

public class SettingsMenu : MonoBehaviour
{
    public Toggle toggle;
    public Slider slider;
    public Text valueCount;
    public Button muteButton;

    Resolution[] res;
    private bool muteSound = false;
    public float tempVolume ;
    public Dropdown dropdown;

    void Awake()
    {
        toggle.isOn = false;
        Resolution[] resolution = Screen.resolutions;
        res = resolution.Distinct().ToArray();
        string[] strRes = new string[res.Length];
        for(int i = 0; i < res.Length; i++)
        {
            strRes[i] = res[i].width.ToString() + "x"+res[i].height.ToString();
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(strRes.ToList());
        Screen.SetResolution(1280, 720, Screen.fullScreen, 60);
        slider.value = SoundManager.instance.volumeLvl;
    }

   public void SetRes()
    {
        Screen.SetResolution(res[dropdown.value].width, res[dropdown.value].height, Screen.fullScreen, 60);
    }

    public void FullScreenToggle()
    {
        Screen.fullScreen = toggle.isOn;
    }

    public void MuteSound()
    {
        if (!muteSound)
        {
            muteButton.GetComponentInChildren<Text>().text = "X";
            tempVolume = slider.value;
            muteSound = true;
            SoundVolume(0f);
        }
        else
        {
            muteButton.GetComponentInChildren<Text>().text = " ";
            SoundVolume(tempVolume);
            muteSound = false;
        }
    }

    public void SoundVolume(float volume)
    {
        slider.value = volume;
        if(slider.value == 0)
            muteButton.GetComponentInChildren<Text>().text = "X";
        else
            muteButton.GetComponentInChildren<Text>().text = " ";
        valueCount.text = (Math.Round(volume * 100)).ToString();
        SoundManager.instance.SoundVolume(volume);
    }

    private void Update()
    {
        SoundVolume(slider.value);
    }
}
