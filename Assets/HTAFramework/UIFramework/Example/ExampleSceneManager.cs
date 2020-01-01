using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleSceneManager : MonoBehaviour
{
    void Start()
    {
        UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Button>("StartButton"), UIEventExample.Instacne);
        UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Button>("OptionButton"), UIEventExample.Instacne);
        UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Button>("InfomationButton"), UIEventExample.Instacne);
        UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Button>("ExitButton"), UIEventExample.Instacne);
        UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Button>("VideoButton"), UIEventExample.Instacne);
        UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Button>("SoundButton"), UIEventExample.Instacne);
        UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Button>("InputButton"), UIEventExample.Instacne);
        UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Button>("OtherButton"), UIEventExample.Instacne);

        for (int i = 1; i <= 6; i++)
        {
            UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Button>($"BackButton{ i.ToString() }"), UIEventExample.Instacne);
        }
        UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Slider>("VolumeSlider"), UIEventExample.Instacne);
        UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Scrollbar>("BrightnessScrollbar"), UIEventExample.Instacne);
        UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Toggle>("ShowSomethingToggle"), UIEventExample.Instacne);
        UIEventManager.LinkEvent(UIManager.Instacne.FindUI<Dropdown>("InputTypeDropdown"), UIEventExample.Instacne);
    }
}
