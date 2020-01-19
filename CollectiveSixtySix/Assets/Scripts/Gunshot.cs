using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunshot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider collider)
    {
        if (Input.GetMouseButtonDown(0)&& collider.tag == "Player"&&GameManager.Instance.HasGun==true)
        {
            Debug.Log("Trigger death");//Play animation and replace "enemy" with dead version also gunshot sound
            //once animation is done popup sign that says pow
        }
    }
}
