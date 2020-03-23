using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public float Time = 2;
    Rigidbody2D rb;
    

void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
      {
         if(collision.gameObject.name.Equals("player"))
            {
                Destroy(gameObject,Time);
            }
      }

}
