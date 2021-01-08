using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    //Player 1
    public Rigidbody2D rb1;

    //Player 2
    public Rigidbody2D rb2;

    void Update()
    {
        float yMov1 = Input.GetAxisRaw("Vertical1");
        float yMov2 = Input.GetAxisRaw("Vertical2");
        
        UpdateVelocity(yMov1, yMov2);
    }

    private void UpdateVelocity(float yMov1,float yMov2)
    {
        rb1.velocity = new Vector2(0, yMov1)*speed;
        rb2.velocity = new Vector2(0, yMov2)*speed;
    }
    
}
