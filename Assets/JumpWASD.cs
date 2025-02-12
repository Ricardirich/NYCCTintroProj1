using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpWASD : MonoBehaviour
{
    bool jump = false;
    bool canJump = true;
    Vector3 jumpForce;
    Rigidbody2D myRB;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = Direction();
        //Debug.Log("desired dir based off player input: " + dir);
        transform.Translate(dir*speed*Time.deltaTime);

        if(Input.GetKey(KeyCode.space))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }
    }

    void FixedUpdate()
    {
        if(jump && canJump)
        {
            myRB.AddForce(Vector3.up * jumpForce);
        }
    }

    void OnCollisionStay2D(collision2D other)
    {
        canJump = true;
    }

    void OnCollisionExit2D(collision2D other)
    {
        canJump = false;
    }

        Vector3 Direction()
    {
        //temp vector to hold our direction
        Vector3 v = Vector3.zero;

        //now do our left/right
        if(Input.GetKey(KeyCode.D))
            { v += Vector3.right; }
        else if(Input.GetKey(KeyCode.A))
            { v += Vector3.left; }

        //return our desired direction after all WASD checks  
        return v;
    }
}
