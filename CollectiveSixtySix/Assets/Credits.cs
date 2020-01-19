using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public float creditsTime;
    public float creditsFinished;
    // Start is called before the first frame update
    void Start()
    {
        creditsFinished = Time.time + creditsTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= creditsFinished)
        {
            Debug.Log("YouWin");
        }
    }
}
