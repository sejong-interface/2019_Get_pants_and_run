using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceFromStartPoint : MonoBehaviour
{
    [SerializeField]
    public Transform startPoint;

    [SerializeField]
    public Text distanceText;

    public float distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = (transform.position.x- startPoint.transform.position.x);




        distanceText.text = "Distance: " + distance.ToString("F1") + " meters";

        if(distance >=21)
        {
            distanceText.text = "Finish!";
        }
    }
}
