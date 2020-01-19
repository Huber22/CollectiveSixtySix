using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    public bool Level1Complete;//start gamestate 2
    public bool Level2Complete;//start gamestate 3
    public bool Level5Complete;//start gamestate 4 maybe
    public bool Level4Complete;
    public bool HasGun;
    public bool PlayerCanMove;

    public bool levelSelectOption;

    private static GameManager instance = null;
    public static GameManager Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if ((instance != null) && (instance != this))
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        levelSelectOption = false;
        Level1Complete = false;
        Level2Complete = false;
        Level5Complete = false;
        Level4Complete = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
