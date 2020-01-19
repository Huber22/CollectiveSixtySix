using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class mainMenu : MonoBehaviour
{
    public Text StartText;
    public GameObject MenuObject;
    public GameObject levelSelect;
    public GameObject levelSelectButton;
    public GameObject regularOptions;
    // Start is called before the first frame update
    void Start()
    {
        Menu();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void acheivements()
    {
        Debug.Log("Acheivements menu");
    }
    public void Exit()
    {
        Debug.Log("ExitGame");
        Application.Quit();
    }
    public void Play()
    {
        Debug.Log("Play level 1");
        SceneManager.LoadScene("Level1");
    }
    public void PlayLevel2()
    {
        Debug.Log("Play level 2");
        SceneManager.LoadScene("Level2");
    }
    public void PlayLevel5()
    {
        Debug.Log("Play level 5");
        SceneManager.LoadScene("Level5");
    }
    public void PlayLevel4()
    {
        Debug.Log("Play level 4");
        SceneManager.LoadScene("Level4");
    }
    public void LevelSelect()
    {
        MenuObject.SetActive(false);
        levelSelect.SetActive(true);
        Debug.Log("Level select menu");
    }
    public void Options()
    {
        regularOptions.SetActive(true);
        MenuObject.SetActive(false);
        
        Debug.Log("options menu");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        Debug.Log("Play Credits");
    }
    public void Menu()
    {
        MenuObject.SetActive(true);
        levelSelect.SetActive(false);
        regularOptions.SetActive(false);
        StartText.text = "Start";
        if (GameManager.Instance.Level1Complete == true)
        {
            StartText.text = "Continue";
        }
        if (GameManager.Instance.Level2Complete == true && GameManager.Instance.levelSelectOption == false)
        {
            levelSelectButton.SetActive(false);
        }
        else if (GameManager.Instance.levelSelectOption == true)
        {
            levelSelectButton.SetActive(true);
        }
    }
}
