using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 500;
    public float jump = 400;
    private bool isGrounded;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update(){
        float xDisplacement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);

        if(Input.GetKeyDown("space") && (isGrounded == true)) {
          rb.AddForce(new Vector2(0, jump));
          isGrounded = false;
        }
    }
    
    void OnCollisionEnter2D(Collision2D col){
     isGrounded = true;
     }
}
