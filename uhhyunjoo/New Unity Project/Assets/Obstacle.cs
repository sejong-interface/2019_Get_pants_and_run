using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float delta = -0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float newXposition = transform.position.x + delta; // frame 마다 newXposition이 -0.1씩 이동
        transform.position = new Vector3(newXposition, 2, -7);
        if (transform.position.x < -3.5)
        {
            delta = 0.1f;
        }
        else if (transform.position.x >= 3.5)
        {
            delta = -0.1f;
        }
    }
}
