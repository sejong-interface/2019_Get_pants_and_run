using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{
    
    public int playerScore = 0;
    
    public GameObject playerScoreUI;

    
    
    void Update()
    {
 
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score:" + (int)playerScore);
        
        

        
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.name == "EndLevel") // 무시해도 됨
        {
            CountScore(); // 이거 무시해도 됨 //  맵의 마지막 부분을 endlevel이라고 설정하고, 그걸 통과하면 남은 시간들과 먹은 코인들의 점수를 더하려고 했으나 거듭실패해서 버림

        }
        
        if(trig.gameObject.name == "Coin")
        {
            playerScore += 100;
            Destroy(trig.gameObject);
        }
    }


    void CountScore()
    {
        
        
    }



}
