using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WokingCycle : MonoBehaviour
{

    private Animator anim;
    private CharacterController controller;
    public float speeeed = 6.0f;
    public float turnSpeed = 60.0f;
    public float jumpSpeed = 8.0f;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20.0f; 


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up")){
            anim.SetInteger("AniParOJ",1);
            anim.SetBool("Jumping", false);
        } else if(Input.GetKey(KeyCode.Space)){
            anim.SetBool("Jumping", true);
        }  else {
            anim.SetInteger("AniParOJ",0);
            anim.SetBool("Jumping", false);
        }



        if(controller.isGrounded){
            //
            if (Input.GetKey(KeyCode.F)){
                moveDirection = transform.forward * -Input.GetAxis("Vertical") * (speeeed * 3.0f);
            } else {
                moveDirection = transform.forward * -Input.GetAxis("Vertical") * speeeed;
            }
            //
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        float turn = Input.GetAxis("Horizontal");
        transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
        controller.Move(moveDirection * Time.deltaTime);
        moveDirection.y -= gravity * Time.deltaTime;
    }
}
