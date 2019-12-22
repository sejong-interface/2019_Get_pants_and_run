using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    Rigidbody2D myrigidbody;

    [SerializeField]
    private float power;
    [SerializeField]
    Transform pos;
    [SerializeField]
    float checkRadius;
    [SerializeField]
    LayerMask islayer;

    public int jumpCount;

    int jumpCnt;

    bool isGround;
    bool crashEnemy;

    //시간 측정
    float timer;
    float waitingTime;
    bool inside;

    private void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        jumpCnt = jumpCount;

        timer = 0.0f;
        waitingTime = 0.5f;
        inside = false;
    }

    private void Update()
    {
        isGround = Physics2D.OverlapCircle(pos.position, checkRadius, islayer); //
        if (isGround == true && Input.GetKeyDown(KeyCode.Space) && jumpCnt > 0)
        {
            myrigidbody.velocity = Vector2.up * power;
        }

        if (isGround == false && Input.GetKeyDown(KeyCode.Space) && jumpCnt > 0)
        {
            myrigidbody.velocity = Vector2.up * power;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            jumpCnt--;
        }

        if (isGround)
        {
            jumpCnt = jumpCount;

        }


    }

    private void FixedUpdate()
    {
        //float hor = Input.GetAxis("Horizontal");
        float hor = 1;
        myrigidbody.velocity = new Vector2(hor * 3, myrigidbody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            StartCoroutine(TimeWait());
            float hor = 1;
            myrigidbody.velocity = new Vector2(hor * 3, myrigidbody.velocity.y);
        }
        if (collision.gameObject.tag == "Friend")
        {
            Debug.Log("Game Over");
            QuitGame();   
        }
    }


    IEnumerator TimeWait()
    {
        float hor = -1;
        myrigidbody.velocity = new Vector2(hor * 3, myrigidbody.velocity.y);
        yield return new WaitForSeconds(0.2f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("Finish");
            QuitGame();
        }
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

}

    /*
    //public float jump = 10f; // first jump value
    //public float jump2 = 12f; // second jump value

    //int jumpCount = 0;

    //public void Jump_Btn() // function to put in jump button
    //{
    //    float v = Input.GetAxis("Vertical");

    //    if (jumpCount == 0)
    //        {
    //            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
    //            jumpCount += 1;
    //        }
    //        else if (jumpCount == 1)
    //        {
    //            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump2, 0);
    //            jumpCount += 1;
    //        }


    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.tag.CompareTo("Land") ==0)
    //    {
    //        jumpCount = 0;
    //    }
    //}

    //
    //public float maxSpeed;
    //public float jumpPower;
    //Rigidbody2D rigid;
    //SpriteRenderer spriteRenderer;
    //Animator anim;

    //// Start is called before the first frame update
    //void Awake()
    //{
    //    rigid = GetComponent <Rigidbody2D>();
    //    spriteRenderer = GetComponent<SpriteRenderer>();
    //    anim = GetComponent<Animator>();
    //}

    //void Update() // 1번 / s 정도
    //{
    //    // Jump
    //    if (Input.GetButtonDown("Jump"))
    //    {
    //        rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
    //        anim.SetBool("isJumping", true);
    //    }

    //    //Stop Speed
    //    if (Input.GetButtonUp("Horizontal"))
    //    {
    //        rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
    //    }

    //    //Direction Sprite
    //    if (Input.GetButtonDown("Horizontal"))
    //    {
    //        spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
    //    }

    //    // Animation
    //    if (Mathf.Abs(rigid.velocity.x) < 0.3)
    //    {
    //        anim.SetBool("isWalking", false);
    //    }
    //    else
    //    {
    //        anim.SetBool("isWalking", true);
    //    }
    //}

    //// Update is called once per frame
    //void FixedUpdate() // 50번 / s 정도
    //{
    //    // Move By Key Control
    //    float h = Input.GetAxisRaw("Horizontal");

    //    rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

    //    if(rigid.velocity.x > maxSpeed) // Right Max Speed
    //    {
    //        rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
    //    }
    //    else if (rigid.velocity.x < maxSpeed*(-1))  // Left Max Speed
    //    {
    //        rigid.velocity = new Vector2(maxSpeed*(-1), rigid.velocity.y);
    //    }

    //    //Landing Platform
    //    Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));

    //    RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1);

    //    if(rayHit.collider != null) // 빔을 쏴서 맞았을때
    //    {
    //        Debug.Log(rayHit.collider.name);
    //    }
    //}
}
*/