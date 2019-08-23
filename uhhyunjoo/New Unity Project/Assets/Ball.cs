using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    float startingPoint;
    //SphereCollider myCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody myRigidbody = GetComponent<Rigidbody>();
        //Debug.Log("Use gravity?:" +myRigidbody.useGravity);
        //myCollider = GetComponent<SphereCollider>();
        
        Debug.Log("Start"); // console에 찍어라
        startingPoint = transform.position.z;
        
    }

    // Update is called once per frame
    void Update()
    {
        //float distance;
        //distance = transform.position.z - startingPoint;
        float positionX = transform.position.x;
        positionX = positionX - 0.01f*Input.GetAxis("Horizontal");
        transform.position = new Vector3(positionX, transform.position.y, transform.position.z);
        //Debug.Log(distance);
        //myCollider.radius = myCollider.radius + 0.03f;
    }

}
