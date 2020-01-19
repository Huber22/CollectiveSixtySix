using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public GameObject LevelCompleteScreen;
    public int Level;
    // Start is called before the first frame update
    void Start()
    {
        LevelCompleteScreen.SetActive( false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.tag=="Player")
        {
            Debug.Log("Win");
            LevelCompleteScreen.SetActive(true);
            Time.timeScale = 0;
            if (Level == 1)
            {
                GameManager.Instance.Level1Complete = true;
            }
            else if (Level == 2)
            {
                GameManager.Instance.Level2Complete = true;
            }
            else if (Level == 5)
            {
                GameManager.Instance.Level5Complete = true;
            }
            else if (Level == 4)
            {
                Debug.Log("credits");
                SceneManager.LoadScene("Credits");
            }
        }
    }
}
