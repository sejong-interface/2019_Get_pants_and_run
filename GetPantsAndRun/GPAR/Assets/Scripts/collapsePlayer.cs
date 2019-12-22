using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collapsePlayer : MonoBehaviour
{
    public GameObject collapseName;
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Coin")
        {
            Destroy(collapseName);
        }
    }
}
