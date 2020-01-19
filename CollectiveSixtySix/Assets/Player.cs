using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
        
        if (hit.transform.tag == "Death")
        {
            Die();
            Debug.Log("Die");
        }
    }
    void Die() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
 }
