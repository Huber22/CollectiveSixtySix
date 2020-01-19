using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    CharacterController characterController;

    private Vector3 lastPosition = new Vector3(0, 0, 0);

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public Animator anim;

    public float jumptime=3f;
    public float timetofall;

    private Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.PlayerCanMove == true)
        {
            if (characterController.isGrounded && SceneManager.GetActiveScene().name != "Level2")
            {
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0f);
                moveDirection *= speed;

                if (Input.GetButton("Jump") && SceneManager.GetActiveScene().name != "Level4")
                {
                    moveDirection.y = jumpSpeed;
                    anim.SetTrigger("Jumping");
                    timetofall = Time.time + jumptime;
                }
            }
            else if (characterController.isGrounded && SceneManager.GetActiveScene().name == "Level2")
            {

                moveDirection = new Vector3(Input.GetAxis("Level2"), 0.0f, 0f);
                moveDirection *= speed;


                if (Input.GetKeyDown("f"))
                {
                    moveDirection.y = jumpSpeed;
                    anim.SetTrigger("Jumping");
                    timetofall = Time.time + jumptime;
                }
            }


            moveDirection.y -= gravity * Time.deltaTime;
            //if less than -1 in y play fall anim
            // Move the controller
            characterController.Move(moveDirection * Time.deltaTime);
            
        }
        if (lastPosition != gameObject.transform.position && characterController.isGrounded == true) 
        {
            anim.SetBool("Moving", true);
            anim.SetBool("Fall", false);
        }
        else if(lastPosition != gameObject.transform.position && characterController.isGrounded == false&& Time.time>timetofall)
        {
            anim.SetBool("Moving", false);
            anim.SetBool("Fall", true);
        }
        else if(lastPosition == gameObject.transform.position)
        {
            anim.SetBool("Moving", false);
            anim.SetBool("Fall", false);
        }
        lastPosition = gameObject.transform.position;
        

    }
}
