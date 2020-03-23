using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour

{
    private bool collide;
    void Update () {
      if(collide == true)
        {
         transform.Rotate(Vector3.forward * 1);
        }
 }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collide = true;
    }
}