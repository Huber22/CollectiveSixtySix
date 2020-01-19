using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Button Level1;
    public Button Level2;
    public Button Level3;
    public Button Level4;
    public Button Level5;
    // Start is called before the first frame update
    void Start()
    {
        Level2.interactable = false;
        Level3.interactable = false;
        Level4.interactable = false;
        Level5.interactable = false;
        if (GameManager.Instance.Level1Complete)
        {
            Level2.interactable = true;
        }
        if (GameManager.Instance.Level2Complete)
        {
            Level5.interactable = true;
        }
        if (GameManager.Instance.Level5Complete)
        {
            Level4.interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
