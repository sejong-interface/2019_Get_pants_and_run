using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    Rigidbody2D enemyRigidbody;

    bool isGround;

    [SerializeField]
    private float power;
    [SerializeField]
    Transform pos;
    [SerializeField]
    float checkRadius;
    [SerializeField]
    LayerMask islayer;

    private void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        isGround = Physics2D.OverlapCircle(pos.position, checkRadius, islayer);
    }

    private void FixedUpdate()
    {
        float hor = 1;
        enemyRigidbody.velocity = new Vector2(0, enemyRigidbody.velocity.y);
    }
}
