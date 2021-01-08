using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 startPos = new Vector2(0,0);
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        ResetBall();
    }

    void Update()
    {
        //when the ball reaches the edge of the screen, add a point and reset it
        if (Mathf.Abs(this.transform.position.x) > 10)
        {
            //add a point
            
            //reset the ball
            ResetBall();
        }
    }

    private void OnCollisionEnter2D(Collision2D hit)
    {
        //check which player the ball hit
        if (hit.gameObject.name == "Player 1")
        {
            //distance from player center
            float dist = this.transform.position.y - GameObject.Find("Player 1").transform.position.y;
            
            //add velocity in Y axis
            rb.velocity = new Vector2(rb.velocity.x,dist);
        }
        if (hit.gameObject.name == "Player 2")
        {
            //distance from player center
            float dist = this.transform.position.y - GameObject.Find("Player 2").transform.position.y;
            
            //add velocity in Y axis
            rb.velocity = new Vector2(rb.velocity.x,dist);
        }
    }

    private void ResetBall()
    {
        this.transform.position = startPos;
        rb.velocity = new Vector2(0,0);
        int rand = Random.Range(0, 2);
        if (rand == 0)
        {
            //Move left
            
            rb.velocity = new Vector2(-speed,0);
        }
        else if (rand == 1)
        {
            //Move right   
            rb.velocity = new Vector2(speed,0);
        }
    }
}
