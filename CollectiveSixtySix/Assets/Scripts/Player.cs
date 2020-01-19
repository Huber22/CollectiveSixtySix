using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject gun;
    public GameObject startpoint;
    Transform point;

    // Start is called before the first frame update
    void Start()
    {
         point = Instantiate(startpoint.transform,this.transform.position,Quaternion.identity);
        gun.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.HasGun == true&& SceneManager.GetActiveScene().name=="Level5")
        {
            gun.SetActive(true);
        }
        if(SceneManager.GetActiveScene().name != "Level5")
        {
            GameManager.Instance.HasGun = false;
            gun.SetActive(false);
        }
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
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        this.transform.position = point.position;
}
 }
