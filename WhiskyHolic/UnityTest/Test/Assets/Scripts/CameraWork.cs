using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{
    GameObject Sphere;

    // Start is called before the first frame update
    void Start()
    {
        Sphere = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Sphere.transform.position.x - 1, Sphere.transform.position.y - 1, Sphere.transform.position.z - 8);
    }
}
