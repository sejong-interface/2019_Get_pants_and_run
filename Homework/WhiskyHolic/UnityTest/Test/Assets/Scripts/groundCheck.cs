using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    float distanceGround;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = false;
        distanceGround = GetComponent<Collider>().bounds.extents.y;
    }

    public bool getIsGrounded()
    {
        return isGrounded;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Physics.Raycast(transform.position, -Vector3.up, distanceGround + 0.1f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
