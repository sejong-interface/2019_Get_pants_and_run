using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public groundCheck groundCheckScript;
    float distance;
    float posX, posY, posZ;
    float boost;
    //SphereCollider myCollider;

    // Start is called before the first frame update

    public float getDistance()
    {
        return distance;
    }

    void Start()
    {
        //Rigidbody myRigidbody = GetComponent<Rigidbody>();

        //Debug.Log("useGravity : " + myRigidbody.useGravity);
        //myCollider = GetComponent<SphereCollider>();

        distance = 0;
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
        boost = 0;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Mathf.Sqrt(Mathf.Pow(posX - transform.position.x, 2) + Mathf.Pow(posY - transform.position.y, 2) + Mathf.Pow(posZ - transform.position.z, 2));

        //Debug.Log("distance : " + distance);

        if (Input.GetKeyDown(KeyCode.Space) && groundCheckScript.getIsGrounded())
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.2f + boost);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.2f - boost);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - 0.2f - boost, transform.position.y, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + 0.2f + boost, transform.position.y, transform.position.z);
        }
    }
}
