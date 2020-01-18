using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class mainMenu : MonoBehaviour
{
    public Text StartText;
    // Start is called before the first frame update
    void Start()
    {
        StartText.text = "Start";
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Level1Complete == true)
        {
            StartText.text = "Continue";
        }
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
    public void LevelSelect()
    {
        Debug.Log("Level select menu");
    }
    public void Options()
    {
        Debug.Log("options menu");
    }
    public void Credits()
    {
        Debug.Log("Play Credits");
    }
}
