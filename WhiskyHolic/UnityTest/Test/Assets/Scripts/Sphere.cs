using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    //float distance;
    //float posX, posY, posZ;
    //SphereCollider myCollider;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody myRigidbody = GetComponent<Rigidbody>();

        //Debug.Log("useGravity : " + myRigidbody.useGravity);
        //myCollider = GetComponent<SphereCollider>();

        //distance = 0;
       // posX = transform.position.x;
        //posY = transform.position.y;
        //posZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //distance = Mathf.Sqrt(Mathf.Pow(posX - transform.position.x, 2) + Mathf.Pow(posY - transform.position.y, 2) + Mathf.Pow(posZ - transform.position.z, 2));

        //Debug.Log("distance : " + distance);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 100);
        }
    }
}
