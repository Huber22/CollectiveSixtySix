using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public GameObject Advmenu;
    public GameObject GameMenu;
    public GameObject FeelMenu;
    public GameObject playmenu;
    public GameObject regularOptions;
    public Toggle AdvToggle;
    // Start is called before the first frame update
    void Start()
    {
        Advmenu.SetActive(false);
        GameMenu.SetActive(false);
        FeelMenu.SetActive(false);
        playmenu.SetActive(false);
        regularOptions.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AdvancedOptions()
    {
        if (Advmenu.activeSelf == false)
        {
            
            Advmenu.SetActive(true);
            
        }
        else if (Advmenu.activeSelf == true)
        {
            
            Advmenu.SetActive(false);
        }

    }
    public void Gamesettings()
    {
        Advmenu.SetActive(true);
        GameMenu.SetActive(true);
        FeelMenu.SetActive(false);
        playmenu.SetActive(false);
        regularOptions.SetActive(false);
    }
    public void GamefeelSettings()
    {
        Advmenu.SetActive(true);
        GameMenu.SetActive(false);
        FeelMenu.SetActive(true);
        playmenu.SetActive(false);
        regularOptions.SetActive(false);
    }
    public void GameplaySettings()
    {
        Advmenu.SetActive(true);
        GameMenu.SetActive(false);
        FeelMenu.SetActive(false);
        playmenu.SetActive(true);
        regularOptions.SetActive(false);
    }
    public void OptionsRegular()
    {
        Advmenu.SetActive(true);
        GameMenu.SetActive(false);
        FeelMenu.SetActive(false);
        playmenu.SetActive(false);
        regularOptions.SetActive(true);
    }
    public void AdvOff()
    {
        //Advmenu.SetActive(false);
        AdvToggle.isOn = false;
    }
    public void LevelSelectToggle()
    {
        if(GameManager.Instance.levelSelectOption == true)
        {
            Debug.Log("Level Select button on");
            GameManager.Instance.levelSelectOption = false;
        }
        else if (GameManager.Instance.levelSelectOption == false)
        {
            Debug.Log("Level Select button on");
            GameManager.Instance.levelSelectOption = true;
        }
    }
}
