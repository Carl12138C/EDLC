using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    Rigidbody2D rb;
    bool waiting = true;
    GameObject player;
    int velocityX;
    int velocityY;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        velocityX = 0;
        velocityY = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (waiting)
        {
            if (Vector3.Distance(transform.position, player.transform.position) < 4.0f)
            {
                waiting = false;
            }
        }
        else
        {
            if (player.transform.position.x < transform.position.x)
            {
                velocityX = -2;
                transform.localScale = new Vector3(1, 1, 1);

            }
            else
            {
                velocityX = 2;
                transform.localScale = new Vector3(-1, 1, 1);

            }
            if (player.transform.position.y < transform.position.y)
            {
                velocityY = -2;
            }
            else
            {
                velocityY = 2;
            }
        }
        rb.velocity = new Vector2(velocityX, velocityY);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "FireBall")
        {
            //GameData.points += 10;
            Destroy(gameObject);
        }
        if (collision.tag == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("DeadScreen");
        }
    }
}
