using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Animator playerAnim;
    public Rigidbody playerRigid;
    public float w_speed, wb_speed, olw_speed, rn_speed, ro_speed, jump_speed;
    public bool walking;
    public Transform playerTrans;
    private int jumpCount = 0; // Variable to track if player can jump

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRigid.velocity = new Vector3((transform.forward * w_speed * Time.deltaTime).x, playerRigid.velocity.y, (transform.forward * w_speed * Time.deltaTime).z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRigid.velocity = new Vector3((-transform.forward * w_speed * Time.deltaTime).x, playerRigid.velocity.y, (-transform.forward * w_speed * Time.deltaTime).z);
        }
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount > (60 * 3)) // Only jump if allowed
        {
            playerRigid.AddForce(Vector3.up * jump_speed, ForceMode.VelocityChange);
            jumpCount = 0;
        }
    }

    void Update()
    {
        jumpCount = jumpCount + 1;
        
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerAnim.SetTrigger("walk");
            playerAnim.ResetTrigger("idle");
            walking = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.ResetTrigger("walk");
            playerAnim.SetTrigger("idle");
            walking = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerAnim.SetTrigger("walkback");
            playerAnim.ResetTrigger("idle");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.ResetTrigger("walkback");
            playerAnim.SetTrigger("idle");
        }
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount > (60 * 3)) // Only trigger jump animation if allowed
        {
            playerAnim.SetTrigger("jump");
            playerAnim.ResetTrigger("idle");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerAnim.ResetTrigger("jump");
            playerAnim.SetTrigger("idle");
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerTrans.Rotate(0, -ro_speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerTrans.Rotate(0, ro_speed * Time.deltaTime, 0);
        }
        if (walking)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                w_speed += rn_speed;
                playerAnim.SetTrigger("run");
                playerAnim.ResetTrigger("walk");
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                w_speed = olw_speed;
                playerAnim.ResetTrigger("run");
                playerAnim.SetTrigger("walk");
            }
        }
    }


}
