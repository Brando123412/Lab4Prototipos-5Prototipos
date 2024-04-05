using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum Dirrection { UP, DOWN, LEFT, RIGHT }
public class PlayerController : MonoBehaviour
{
    SpriteRenderer mySR;
    Rigidbody2D rb2D;
    [SerializeField] float axisMovement;
    [SerializeField] float speed;

    [Header("Jump Values")]
    [SerializeField] private float jumpInpulse;
    [SerializeField] private LayerMask myLayerMask;
    [SerializeField] private int maxJumps;
    [SerializeField] private int saltos;

    private Vector2 direction = Vector2.up;

    private Func<bool> isCriteria;
    private Action isMovement;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        mySR = GetComponent<SpriteRenderer>();

        ChangeGravity(Dirrection.UP);
    }
    private void FixedUpdate()
    {
        isMovement();
        OnValidateJump(isCriteria);
    }
    void OnMovement(InputValue value)
    {
        axisMovement = value.Get<float>();
    }
    private void OnValidateJump(Func<bool> directionCriteria)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -direction, 0.75f, myLayerMask);
        Debug.DrawRay(transform.position, -direction * 0.75f, Color.green);

        if (hit.collider != null && directionCriteria.Invoke())
        {
            saltos = maxJumps;
        }
    }
    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            if (saltos > 0)
            {
                rb2D.AddForce(direction * jumpInpulse, ForceMode2D.Impulse);
                saltos -= 1;
            }
        }
    }
    public void OnPowerUp(InputValue value)
    {
        
            Vector2 directionChange = value.Get<Vector2>();

            if (Vector2.Dot(directionChange, Vector2.up) == 1)
            {
                ChangeGravity(Dirrection.UP);
            }
            else if (Vector2.Dot(directionChange, Vector2.down) == 1)
            {
                ChangeGravity(Dirrection.DOWN);
            }
            else if (Vector2.Dot(directionChange, Vector2.right) == 1)
            {
                ChangeGravity(Dirrection.RIGHT);
            }
            else if (Vector2.Dot(directionChange, Vector2.left) == 1)
            {
                ChangeGravity(Dirrection.LEFT);
            }
       
    }
    private void ChangeGravity(Dirrection caseDirection)
    {
        switch (caseDirection)
        {
            case Dirrection.UP:
                direction = Vector2.up;
                isCriteria = () => { return rb2D.velocity.y < 0; };
                isMovement = () => { rb2D.velocity = new Vector2(axisMovement * speed * direction.y, rb2D.velocity.y); };
                break;

            case Dirrection.DOWN:
                direction = Vector2.down;
                isCriteria = () => { return rb2D.velocity.y > 0; };
                isMovement = () => { rb2D.velocity = new Vector2(axisMovement * speed * direction.y, rb2D.velocity.y); };
                break;

            case Dirrection.LEFT:
                direction = Vector2.left;
                isCriteria = () => { return rb2D.velocity.x > 0; };
                isMovement = () => { rb2D.velocity = new Vector2(rb2D.velocity.x, axisMovement * speed * direction.x); };
                break;

            case Dirrection.RIGHT:
                direction = Vector2.right;
                isCriteria = () => { return rb2D.velocity.x < 0; };
                isMovement = () => { rb2D.velocity = new Vector2(rb2D.velocity.x, axisMovement * speed * direction.x); };
                break;
        }

        Physics2D.gravity = direction * -9.81f;
    }
    void OnColorR(InputValue value)
    {
        if (value.isPressed)
        {
            print("ColorR");
        }
    }
    void OnColorG(InputValue value)
    {
        if (value.isPressed)
        {
            print("ColorG");
        }
    }
    void OnColorB(InputValue value)
    {
        if (value.isPressed)
        {
            print("ColorB");
        }
    }
    void ValidateJump(InputValue value)
    {

    }
    void ValidateChanceColor()
    {
        
    }
    void StopController()
    {

    }
}