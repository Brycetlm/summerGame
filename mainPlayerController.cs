using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainPlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed=400;
    public GameObject mainPlayer;
    public Animator anim;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        mainPlayer = this.gameObject;
        anim = this.gameObject.GetComponent<Animator>();

        //rb.velocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mainPlayerMovement();
       
    }
    void mainPlayerMovement()
    {
        float directionHorizontal;
        directionHorizontal = Input.GetAxis("Horizontal");
        float directionVertical;
        directionVertical = Input.GetAxis("Vertical");
        float faceDirectionH = Input.GetAxisRaw("Horizontal");
        //左右移动
        if(directionHorizontal!=0)
        {
            anim.SetFloat("direction", 2);   //设置animator界面中的parameter数值
            rb.velocity = new Vector2(directionHorizontal*speed * Time.deltaTime, rb.velocity.y);
            //mainPlayer.transform.position= new Vector2(diractionHorizontal * speed, mainPlayer.transform.position.y);
        }
        //上下移动
        else if (directionVertical != 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, directionVertical * speed*Time.deltaTime);
            //mainPlayer.transform.position = new Vector2(mainPlayer.transform.position.x, diractionVertical * speed );
        }
        else { rb.velocity = new Vector2(0, 0); }

        if(faceDirectionH!=0)
        {
            mainPlayer.transform.localScale = new Vector3(faceDirectionH, mainPlayer.transform.localScale.y, mainPlayer.transform.localScale.z);

        }
        //Debug.Log(rb.velocity);

    }
}
