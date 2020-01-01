using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEventExample
{
    private static UIEventExample instance = new UIEventExample();
    public static UIEventExample Instacne
    {
        get
        {
            if (instance == null)
                instance = new UIEventExample();

            return instance;
        }
    }

    private void StartButton()
    {
        Debug.Log("Start");
    }

    private void ExitButton()
    {
        Debug.Log("Exit");
    }

    private void OptionButton()
    {
        UIManager.Instacne.Close("StartMenu", true);
        UIManager.Instacne.Show("OptionMenu", true);
    }

    private void VideoButton()
    {
        UIManager.Instacne.Close("OptionMenu", true);
        UIManager.Instacne.Show("VideoMenu", true);
    }

    private void SoundButton()
    {
        UIManager.Instacne.Close("OptionMenu", true);
        UIManager.Instacne.Show("SoundMenu", true);
    }

    private void InputButton()
    {
        UIManager.Instacne.Close("OptionMenu", true);
        UIManager.Instacne.Show("InputMenu", true);
    }

    private void OtherButton()
    {
        UIManager.Instacne.Close("OptionMenu", true);
        UIManager.Instacne.Show("OtherMenu", true);
    }

    private void InfomationButton()
    {
        UIManager.Instacne.Close("StartMenu", true);
        UIManager.Instacne.Show("InfomationMenu", true);
    }

    private void BackButton()
    {
        UIManager.Instacne.Back();
    }

    private void VolumeSlider(float volume)
    {
        Debug.Log($"Volume is {volume}.");
    }

    private void BrightnessScrollbar(float brightness)
    {
        Debug.Log($"Brightness is {brightness}.");
    }

    private void ShowSomethingToggle(bool isChecked)
    {
        if (isChecked)
            Debug.Log("You can do something!");
        else
            Debug.Log("You can't do something!");
    }

    private void InputTypeDropdown(int type)
    {
        switch (type)
        {
            case 0:
                Debug.Log("You choose normal input type!");
                break;
            case 1:
                Debug.Log("You choose special input type!");
                break;
            case 2:
                Debug.Log("You choose abnormal input type!");
                break;
            default:
                Debug.Log("You are joking!");
                break;
        }
    }
}
