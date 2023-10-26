using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball2Script : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -6);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            //GameData.points += 10;
            Destroy(gameObject);
        }
        if(collision.tag == "Bad")
        {
            Destroy(gameObject);
        }
    }
}
