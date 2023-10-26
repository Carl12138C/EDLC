using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject fireball1;
    public GameObject fireball2;
    public GameObject fireball3;
    public GameObject fireball4;
    Rigidbody2D rb;
    Animator anim;
    int velocityX;
    int velocityY;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 0);
        GameData.cooldownF = 0 ;
    }

    // Update is called once per frame
    void Update()
    {
        velocityX = 0;
        velocityY = 0;
        if(Input.GetKey(KeyCode.W))
        {
            velocityY += 4;
            anim.SetInteger("Stage", 4);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocityY += -4;
            anim.SetInteger("Stage", 2);

        }
        if (Input.GetKey(KeyCode.A))
        {
            velocityX += -4;
            anim.SetInteger("Stage", 3);

        }
        if (Input.GetKey(KeyCode.D))
        {
            velocityX += 4;
            anim.SetInteger("Stage", 1 );

        }


        rb.velocity = new Vector2(velocityX, velocityY);

        GameData.cooldownF -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space)&& GameData.cooldownF<=0 && anim.GetInteger("Stage") == 4 )//up
        {
            GameData.cooldownF = 2;
            var pos = transform.position;
            var go = Instantiate(fireball1, pos, Quaternion.identity);
        }
        else if(Input.GetKeyDown(KeyCode.Space) && GameData.cooldownF <= 0 && anim.GetInteger("Stage") == 2)//down
        {
            GameData.cooldownF = 2;
            var pos = transform.position;
            var go = Instantiate(fireball2, pos, Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && GameData.cooldownF <= 0 && anim.GetInteger("Stage") == 3)//left
        {
            GameData.cooldownF = 2;
            var pos = transform.position;
            var go = Instantiate(fireball3, pos, Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && GameData.cooldownF <= 0 && anim.GetInteger("Stage") == 1)//right
        {
            GameData.cooldownF = 2;
            var pos = transform.position;
            var go = Instantiate(fireball4, pos, Quaternion.identity);
        }



    }
    
}
