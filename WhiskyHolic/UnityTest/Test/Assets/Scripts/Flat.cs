using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zRotation = transform.localEulerAngles.z;

        zRotation = Input.GetAxis("Horizontal") + transform.localEulerAngles.z;
        transform.localEulerAngles = new Vector3(0, -44, zRotation);

        if(Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x <= Screen.width / 2) transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + 10, transform.localEulerAngles.y, transform.localEulerAngles.z);
            else if (Input.mousePosition.x > Screen.width / 2) transform.localEulerAngles = new Vector3(transform.localEulerAngles.x - 10, transform.localEulerAngles.y, transform.localEulerAngles.z);
        }
    }
}
