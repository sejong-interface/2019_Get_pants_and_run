using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int coinCount = 0;
    public float distance;
    public Text coinText;
    public Text distanceText;
    // Start is called before the first frame update
    void GetCoin()
    {
        coinCount++;
        coinText.text = coinCount + "개";
        Debug.Log("동전: " + coinCount);
    }
    
    void distancemeter()
    {
        distanceText.text = "달린거리 : " + distance + "m";
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
