using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_Prot : MonoBehaviour
{
    public int playerSpeed= 10;
    public bool facingRight = true;
    public int playerJumpPower = 1250;
    private float moveX;

    public bool isGrounded;
    internal object sprite;

    void Update()
    {
        PlayerMove();
    }
    void PlayerMove()
    {
        //Controls
        moveX = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown ("Jump") && isGrounded == true)
        {
            Jump();
        }
        //Animations
        //PlayerDirection
        if(moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if(moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    void Jump()
    {
        //Jumping code
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        isGrounded = false;

    }
    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Player has collided with " + col.collider.name);
        if (col.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }
}
