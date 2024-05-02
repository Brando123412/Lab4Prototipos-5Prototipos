using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "HandlerHealtSO", menuName = "ScriptableObjects/HandlerHealtSO", order = 1)]
public class HandlerHealtSO : ScriptableObject
{
    public event Action<int> lifeUpdate;
    public event Action<int> modifyHealth;
    [SerializeField] int health;
    public void UpdateLife()
    {

    }
    public void ModifyLife(int life)
    {
        modifyHealth?.Invoke(life);
    }
    private void Awake()
    {
        //modifyHealth += UpdateCurrentHealth;
    }
    void UpdateCurrentHealth(int value)
    {
        health += Mathf.Clamp(value, 0, 100);
        lifeUpdate.Invoke(health);
        if (health <= 0)
        {
            GameManager.OnLose?.Invoke();
        }
    }
}
