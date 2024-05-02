using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "PointSOController", menuName = "ScriptableObjects/PointSOController", order = 1)]
public class PointSOController : ScriptableObject
{
    public event Action<int> gainPoints;
    public event Action<int> UpdatePoints;
    [SerializeField]int points;
    [SerializeField] OnWin_and_OnLose OWSO;
    public void StartSOPointSO()
    {
        gainPoints += UpdateCurrentPoints;
    }
    void UpdateCurrentPoints(int value)
    {
        points += value;
        if (points >= 6)
        {
            OWSO.ActiveOnWin();
        }
        UpdatePoints?.Invoke(points);
    }

    public void GainPoint()
    {
        gainPoints?.Invoke(points);
    }
}
