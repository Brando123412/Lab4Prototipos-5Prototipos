using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaPlayer : MonoBehaviour
{
    
}
/*
 * using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum Dir { UP, DOWN, LEFT, RIGHT }

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int velocity;
    [SerializeField] private float axis;
    
    [SerializeField] private Rigidbody2D myRB;
    [SerializeField] SpriteRenderer mySR;


    [Header("Jump")]
    [SerializeField] private float jumpInpulse;
    [SerializeField] private LayerMask myLayerMask;
    [SerializeField] private int maxJumps;
    [SerializeField] private int saltos;

    private Vector2 direction = Vector2.up;

    private Func<bool> isCriteria;
    private Action isMovement;

    private void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        mySR = GetComponent<SpriteRenderer>();

        ChangeGravity(Dir.UP);
    }

    private void FixedUpdate()
    {
        isMovement();
        OnValidateJump(isCriteria);
    }

    public void Movement(InputAction.CallbackContext value)
    {
        axis = value.ReadValue<float>();
    }

    public void Jump(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            if(saltos > 0)
            {
                myRB.AddForce(direction * jumpInpulse, ForceMode2D.Impulse);
                saltos -= 1;
            }
        }
    }

    public void PowerUp(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            Vector2 directionChange = value.ReadValue<Vector2>();

            if(Vector2.Dot(directionChange, Vector2.up) == 1)
            {
                ChangeGravity(Dir.UP);
            }
            else if(Vector2.Dot(directionChange, Vector2.down) == 1)
            {
                ChangeGravity(Dir.DOWN);
            }
            else if (Vector2.Dot(directionChange, Vector2.right) == 1)
            {
                ChangeGravity(Dir.RIGHT);
            }
            else if (Vector2.Dot(directionChange, Vector2.left) == 1)
            {
                ChangeGravity(Dir.LEFT);
            }
        }
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

    private void ChangeGravity(Dir caseDirection)
    {
        switch (caseDirection)
        {
            case Dir.UP:
                direction = Vector2.up;
                isCriteria = () => { return myRB.velocity.y < 0; };
                isMovement = () => { myRB.velocity = new Vector2(axis * velocity * direction.y, myRB.velocity.y); };
                break;

            case Dir.DOWN:
                direction = Vector2.down;
                isCriteria = () => { return myRB.velocity.y > 0; };
                isMovement = () => { myRB.velocity = new Vector2(axis * velocity * direction.y, myRB.velocity.y); };
                break;

            case Dir.LEFT:
                direction = Vector2.left;
                isCriteria = () => { return myRB.velocity.x > 0; };
                isMovement = () => { myRB.velocity = new Vector2(myRB.velocity.x, axis * velocity * direction.x); };
                break;

            case Dir.RIGHT:
                direction = Vector2.right;
                isCriteria = () => { return myRB.velocity.x < 0; };
                isMovement = () => { myRB.velocity = new Vector2(myRB.velocity.x, axis * velocity * direction.x); };
                break;
        }

        Physics2D.gravity = direction * -9.81f;
    }
}*/