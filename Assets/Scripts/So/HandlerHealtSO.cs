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

    [SerializeField] OnWin_and_OnLose OWSO; 
    public void UpdateLife()
    {
        lifeUpdate?.Invoke(health);
    }
    public void ModifyLife(int life)
    {
        modifyHealth?.Invoke(life);
    }
    public void StartSOLifeSO()
    {
        modifyHealth += UpdateCurrentHealth;
    }
    void UpdateCurrentHealth(int value)
    {
        health += Mathf.Clamp(value, 0, 100);
        lifeUpdate.Invoke(health);
        if (health <= 0)
        {
            OWSO.ActiveOnLose();
        }
    }
}
