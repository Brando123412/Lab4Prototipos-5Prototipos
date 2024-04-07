using System;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public static Action<int> gainPoints;
    public static Action<int> UpdatePoints;
    int points;
    private void Awake()
    {
        gainPoints += UpdateCurrentPoints;
    }
    void UpdateCurrentPoints(int value)
    {
        points += value;
        print("hola");
        if(points >= 6)
        {
            GameManager.OnWin?.Invoke();
        }
        UpdatePoints.Invoke(points);
    }
}
