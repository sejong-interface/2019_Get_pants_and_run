using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameManager gameManager;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Sphere")
        {
            gameManager.getCoin();
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10, 0, 0));
    }
}
