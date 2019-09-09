using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    float startingPoint;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        startingPoint = transform.position.z;//시작지점 z포인트값 저장
    }

    // Update is called once per frame
    void Update()
    {
        float distance;
        float timeCount = 0;
        
        float newZPosition = transform.position.z + 0.1f;//z방향으로 쭉 움직이기
        
        
        distance = transform.position.z - startingPoint;
        GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();

        //Debug.Log(distance);
        //이동한 거리 숫자로 보여주기



        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //GetComponent<Rigidbody>().AddForce(Vector3.up * 300);//스페이스 입력받으면 점프
            Rigidbody ballRigid;
            ballRigid = gameObject.GetComponent<Rigidbody>();
            ballRigid.AddForce(Vector3.up * 1000);

        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            timeCount += Time.deltaTime;
            if (timeCount < 10)
            {
                Rigidbody ballRigid;
                ballRigid = gameObject.GetComponent<Rigidbody>();
                ballRigid.AddForce(Vector3.forward * 100);
            }
            if (timeCount > 10)
            {
                timeCount = 0;
            }
        }
        else
        {
            transform.position = new Vector3(0, 1.34f, newZPosition);
        }
        
    }
}
