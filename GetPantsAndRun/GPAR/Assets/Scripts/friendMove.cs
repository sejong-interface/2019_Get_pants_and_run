using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friendMove : MonoBehaviour
{

    Rigidbody2D myrigidbody;

    [SerializeField]
    private float power;

    private void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //float hor = Input.GetAxis("Horizontal");
        float hor = 1;
        myrigidbody.velocity = new Vector2(hor * 3, myrigidbody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
