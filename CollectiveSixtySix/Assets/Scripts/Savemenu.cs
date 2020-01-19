using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savemenu : MonoBehaviour
{
    public GameObject saveMenu;
    // Start is called before the first frame update
    void Start()
    {
        saveMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveMenuUi()
    {
        saveMenu.SetActive(true);
    }
    public void resetGame()
    {
        GameManager.Instance.levelSelectOption = false;
        GameManager.Instance.Level1Complete = false;
        GameManager.Instance.Level2Complete = false;
        GameManager.Instance.Level5Complete = false;
        GameManager.Instance.Level4Complete = false;
    }

}
