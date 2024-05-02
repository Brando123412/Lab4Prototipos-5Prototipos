using System;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public static Action<int> gainPoints;
    public static Action<int> UpdatePoints;
    int points;
    [SerializeField] OnWin_and_OnLose OWSO;
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
            OWSO.ActiveOnWin();
        }
        UpdatePoints.Invoke(points);
    }
}
