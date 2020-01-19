using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEffect : MonoBehaviour
{
    public ParticleSystem muzzle;
    public GameObject smoke;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            muzzle.Play();
           GameObject smokeFX= Instantiate(smoke, muzzle.transform.position,Quaternion.identity);
            Destroy(smokeFX, .6f);
        }
    }
}
