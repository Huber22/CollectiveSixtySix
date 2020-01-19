using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public float creditsTime;
    public float creditsFinished;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        creditsFinished = Time.time + creditsTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Menu");
        }
        if (Time.time >= creditsFinished)
        {
            Debug.Log("YouWin");
        }
    }
}
