using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getDistance : MonoBehaviour
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
        distance = (transform.position.x - startPoint.transform.position.x);

        distanceText.text = "Distance : " + distance.ToString("F1") + " m";

        if (distance >= 50) //  저의 땅 범위가 21까지라서 이렇게 정한것임요
        {
            distanceText.text = "Finish!";
        }
    }
}
