using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float walkingSpeed;
    private Rigidbody2D rbody;
    private Animator anim;

    // Use this for initialization
    void Start () {
        this.rbody = GetComponent<Rigidbody2D>();
        this.anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        Vector2 movementVector;

        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Debug.Log(inputX);
        Debug.Log(inputY);

        if (inputX != 0)
        {
            movementVector = new Vector2(inputX, 0);
        }
        else
        {
            movementVector = new Vector2(0, inputY);
        }

        if (movementVector != Vector2.zero)
        {
            this.anim.SetBool("isWalking", true);
            this.anim.SetFloat("input_y", movementVector.y);
            this.anim.SetFloat("input_x", movementVector.x);
        }
        else
        {
            this.anim.SetBool("isWalking", false);
        }

        this.rbody.MovePosition(this.rbody.position + movementVector * Time.deltaTime * walkingSpeed);
    }
}
