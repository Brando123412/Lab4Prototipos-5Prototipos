using System;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public static Action<int> modifyHealth;
    public static Action<int> UpdateHealth;
    [SerializeField]int health;
    private void Awake()
    {
        modifyHealth += UpdateCurrentHealth;
    }                                                                                                          
    void UpdateCurrentHealth(int value)
    {
        health += Mathf.Clamp(value,0 ,100);
        UpdateHealth.Invoke(health);
        if(health <= 0)
        {
            GameManager.OnLose?.Invoke();
        }
    }
}
