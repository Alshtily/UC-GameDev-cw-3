using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paddle : MonoBehaviour
{

// Rigidbody2D

    

    private Rigidbody2D RB;

    // Start is called before the first frame update
    void Start()
    {
        

       RB = GetComponent<Rigidbody2D>();
        
    }


    void move() {
         RB.velocity = new Vector2(Input.GetAxis("Horizontal") ,0) * 10;
    }


    void FixedUpdate(){
move();
    }




   
}
