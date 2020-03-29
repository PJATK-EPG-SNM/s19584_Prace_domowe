using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diver : MonoBehaviour
{
    public float speed = 500;
    public float jump = 400;
    private bool isGrounded;
    private Rigidbody2D rb;
    
    Animator anim;

    // Start is called before the first frame update
    void Start(){
    anim = GetComponent<Animator> ();
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

        if (xDisplacement != 0) {
      anim.SetBool ("isWalking", true);
      }
      else {
        anim.SetBool ("isWalking", false);
	  }

      
} 

    void OnCollisionEnter2D(Collision2D col){
     isGrounded = true;
     }
}
