using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int valuedanno;
    [SerializeField] Transform[] pivots;
    int current=0;
    float speed = 5;
    [SerializeField] HandlerHealtSO HHSO;
    private void Update()
    {
        Movement();
    }
    void Movement()
    {
        transform.position = Vector3.MoveTowards(transform.position, pivots[current].position, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           
            HHSO.ModifyLife(valuedanno);
        }
        if (collision.CompareTag("Pivots"))
        {
            if (current == 0) current = 1;
            else if (current == 1) current = 0;
        }
    }
}