using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    SpriteRenderer mySR;
    Rigidbody2D rb2D;
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        mySR = GetComponent<SpriteRenderer>();
    }
    void OnMovement()
    {

    }
    void OnJump()
    {

    }
    void OnUpdateColor(){
    }
    void ValidateJump()
    {

    }
    void ValidateChanceColor()
    {
        
    }
    void StopController()
    {

    }
}
