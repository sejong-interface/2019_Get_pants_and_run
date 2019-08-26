using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Sphere SphereScript;
    public Text distanceText;
    public Text coinText;
    int coinNum;

    public void getCoin()
    {
        
        coinText.text = "Coin You Got : " + ++coinNum;
    }

    // Start is called before the first frame update
    void Start()
    {
        distanceText.text = "Distance From InitPos : 0";
        coinText.text = "Coin You Got : 0";
        coinNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        distanceText.text = "Distance From InitPos : " + SphereScript.getDistance();
    }
}
